using Microsoft.DataTransformationServices.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ECPTTaskEditor
{
    public partial class SettingsView : System.Windows.Forms.UserControl, IDTSTaskUIView
    {
        private SettingsNode settingsNode = null;
        private System.Windows.Forms.PropertyGrid settingsPropertyGrid;
        private ECPT.ExecuteCatalogPackageTask theTask = null;
        private System.ComponentModel.Container components = null;

        private void InitializeComponent()
        {
            this.settingsPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            this.settingsPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsPropertyGrid.Location = new System.Drawing.Point(3, 0);
            this.settingsPropertyGrid.Name = "settingsPropertyGrid";
            this.settingsPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.settingsPropertyGrid.Size = new System.Drawing.Size(387, 400);
            this.settingsPropertyGrid.TabIndex = 0;
            this.settingsPropertyGrid.ToolbarVisible = false;

            //Settings view
            this.Controls.Add(this.settingsPropertyGrid);
            this.Name = "SettingsView";
            this.Size = new System.Drawing.Size(390, 400);
            this.ResumeLayout(false);

        }
        public SettingsView()
        {
            InitializeComponent();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }
        public void OnCommit(object taskHost)
        {
            
        }

        public void OnInitialize(IDTSTaskUIHost treeHost, TreeNode viewNode, object taskHost, object connections)
        {
        }

        public void OnLoseSelection(ref bool bCanLeaveView, ref string reason)
        {
        }

        public void OnSelection()
        {
        }

        public void OnValidate(ref bool bViewIsValid, ref string reason)
        {
        }
    }
    internal class SettingsNode { }
}
