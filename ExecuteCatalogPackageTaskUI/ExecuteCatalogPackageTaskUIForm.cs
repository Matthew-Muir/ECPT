using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExecuteCatalogPackageTaskUI
{
    public partial class ExecuteCatalogPackageTaskUIForm : Form
    {
        private TaskHost taskHost;
        public ExecuteCatalogPackageTaskUIForm(TaskHost taskHostValue)
        {
            InitializeComponent();
            taskHost = taskHostValue;
            intTBX.Text = taskHost.Properties["ServerName"].GetValue(taskHost).ToString();
            folderTBX.Text = taskHost.Properties["PackageFolder"].GetValue(taskHost).ToString();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            taskHost.Properties["ServerName"].SetValue(taskHost, intTBX.Text);
            taskHost.Properties["PackageFolder"].SetValue(taskHost, folderTBX.Text);
        }
    }
}
