using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Public key token is 2f2263a7c743e9f1

namespace ECPTTaskEditor
{
    public class ECPTTaskEditor : IDtsTaskUI
    {
        private TaskHost taskHost = null;
        private IDtsConnectionService connectionService = null;

        public void Delete(IWin32Window parentWindow)
        {
            
        }

        public ContainerControl GetView()
        {
            return new ECPTTaskEditorUIForm(taskHost, connectionService);
        }


        public void Initialize(TaskHost taskHost, IServiceProvider serviceProvider)
        {
            this.taskHost = taskHost;
            this.connectionService = serviceProvider.GetService(typeof(IDtsConnectionService)) as IDtsConnectionService;
        }

        public void New(IWin32Window parentWindow)
        {
            
        }
    }
}
