using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XBuilder.XForms
{
    public partial class XAbout : Form
    {
        public XAbout()
        {
            InitializeComponent();
        }
        private void AuthorLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void GitLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/k3rnel-dev");
        }

        private void ModuleLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/0xd4d/dnlib");
        }
    }
}
