using System;
using System.Windows.Forms;

namespace XBuilder
{
    internal static class Runtime
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new XMain());
        }
    }
}
