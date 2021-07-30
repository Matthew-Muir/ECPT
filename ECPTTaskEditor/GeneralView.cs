using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.DataTransformationServices.Controls;

namespace ECPTTaskEditor
{

    public partial class GeneralView : System.Windows.Forms.UserControl, IDTSTaskUIView
    {
        private GeneralNode generalNode = null;
        private System.Windows.Forms.PropertyGrid generalPropertyGrid;
        private ECPT.ExecuteCatalogPackageTask theTask = null;
        private System.ComponentModel.Container components = null;

        private void InitializeComponent()
        {
            this.generalPropertyGrid = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            this.generalPropertyGrid.Anchor = ((System.Windows.Forms.AnchorStyles)
                ((((System.Windows.Forms.AnchorStyles.Top
                | System.Windows.Forms.AnchorStyles.Bottom)
                | System.Windows.Forms.AnchorStyles.Left)
                | System.Windows.Forms.AnchorStyles.Right)));
            this.generalPropertyGrid.Location = new System.Drawing.Point(3, 0);
            this.generalPropertyGrid.Name = "generalPropertyGrid";
            this.generalPropertyGrid.PropertySort = System.Windows.Forms.PropertySort.Categorized;
            this.generalPropertyGrid.Size = new System.Drawing.Size(387, 360);this.generalPropertyGrid.TabIndex = 0;
            this.generalPropertyGrid.ToolbarVisible = false;

            //General view
            this.Controls.Add(this.generalPropertyGrid);
            this.Name = "GeneralView";
            this.Size = new System.Drawing.Size(390, 360);
            this.ResumeLayout(false);

        }
        public GeneralView()
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
    internal class GeneralNode { }
}
