
namespace ExecuteCatalogPackageTaskUI
{
    partial class ExecuteCatalogPackageTaskUIForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.intLabel = new System.Windows.Forms.Label();
            this.intTBX = new System.Windows.Forms.TextBox();
            this.folderTBX = new System.Windows.Forms.TextBox();
            this.folderLabel = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // intLabel
            // 
            this.intLabel.AutoSize = true;
            this.intLabel.Location = new System.Drawing.Point(12, 9);
            this.intLabel.Name = "intLabel";
            this.intLabel.Size = new System.Drawing.Size(48, 13);
            this.intLabel.TabIndex = 0;
            this.intLabel.Text = "Instance";
            // 
            // intTBX
            // 
            this.intTBX.Location = new System.Drawing.Point(66, 9);
            this.intTBX.Name = "intTBX";
            this.intTBX.Size = new System.Drawing.Size(249, 20);
            this.intTBX.TabIndex = 1;
            // 
            // folderTBX
            // 
            this.folderTBX.Location = new System.Drawing.Point(66, 48);
            this.folderTBX.Name = "folderTBX";
            this.folderTBX.Size = new System.Drawing.Size(249, 20);
            this.folderTBX.TabIndex = 3;
            // 
            // folderLabel
            // 
            this.folderLabel.AutoSize = true;
            this.folderLabel.Location = new System.Drawing.Point(12, 48);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(36, 13);
            this.folderLabel.TabIndex = 2;
            this.folderLabel.Text = "Folder";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(240, 93);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDone
            // 
            this.btnDone.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDone.Location = new System.Drawing.Point(159, 93);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 5;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // ExecuteCatalogPackageTaskUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.btnDone);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.folderTBX);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.intTBX);
            this.Controls.Add(this.intLabel);
            this.Name = "ExecuteCatalogPackageTaskUIForm";
            this.Text = "ExecuteCatalogPackageTaskUIForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label intLabel;
        private System.Windows.Forms.TextBox intTBX;
        private System.Windows.Forms.TextBox folderTBX;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnDone;
    }
}