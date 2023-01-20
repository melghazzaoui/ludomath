
namespace Multable
{
    partial class MultableMainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbNum = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // gbNum
            // 
            this.gbNum.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbNum.Location = new System.Drawing.Point(12, 12);
            this.gbNum.Name = "gbNum";
            this.gbNum.Size = new System.Drawing.Size(960, 937);
            this.gbNum.TabIndex = 0;
            this.gbNum.TabStop = false;
            this.gbNum.Enter += new System.EventHandler(this.gbNum_Enter);
            // 
            // MultableMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 961);
            this.Controls.Add(this.gbNum);
            this.Name = "MultableMainForm";
            this.Text = "Table Multiplication";
            this.Load += new System.EventHandler(this.MultableMainForm_Load);
            this.Enter += new System.EventHandler(this.MultableMainForm_Enter);
            this.Leave += new System.EventHandler(this.MultableMainForm_Leave);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNum;
    }
}

