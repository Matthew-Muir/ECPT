using Microsoft.DataTransformationServices.Controls;
using Microsoft.SqlServer.Dts.Runtime;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECPTTaskEditor
{
    public partial class ECPTTaskEditorUIForm : DTSBaseTaskUI
    {
        private const string Title = "ECPT Editor";
        private const string Description = "Description of what my task is going to do";
        public static Icon taskIcon = new Icon(@"C:\Users\mattm\source\repos\ECPT\ECPTTaskEditor\Resources\favicon.ico");

        public ECPTTaskEditorUIForm(TaskHost taskHost, object connections)
            :base(Title, taskIcon, Description, taskHost, connections)
        {
            GeneralView generalView = new GeneralView();
            this.DTSTaskUIHost.AddView("General", generalView, null);

            SettingsView settingsView = new SettingsView();
            this.DTSTaskUIHost.AddView("Settings", settingsView, null);

        }
    }
}
