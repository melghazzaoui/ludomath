
namespace Ludomath
{
    partial class Form1
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
            this.gb1 = new System.Windows.Forms.GroupBox();
            this.gbNum = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gbResult = new System.Windows.Forms.GroupBox();
            this.labelBravo = new System.Windows.Forms.Label();
            this.btnSubmitAnswer = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.labelEqual = new System.Windows.Forms.Label();
            this.labelOperande2 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.labelOperande1 = new System.Windows.Forms.Label();
            this.gb1.SuspendLayout();
            this.gbResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb1
            // 
            this.gb1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gb1.BackColor = System.Drawing.Color.FloralWhite;
            this.gb1.Controls.Add(this.gbNum);
            this.gb1.Controls.Add(this.button1);
            this.gb1.Location = new System.Drawing.Point(12, 12);
            this.gb1.Name = "gb1";
            this.gb1.Size = new System.Drawing.Size(754, 793);
            this.gb1.TabIndex = 0;
            this.gb1.TabStop = false;
            // 
            // gbNum
            // 
            this.gbNum.BackColor = System.Drawing.Color.MistyRose;
            this.gbNum.Location = new System.Drawing.Point(7, 23);
            this.gbNum.Name = "gbNum";
            this.gbNum.Size = new System.Drawing.Size(553, 750);
            this.gbNum.TabIndex = 1;
            this.gbNum.TabStop = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(568, 215);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 180);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gbResult
            // 
            this.gbResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbResult.BackColor = System.Drawing.Color.LavenderBlush;
            this.gbResult.Controls.Add(this.labelBravo);
            this.gbResult.Controls.Add(this.btnSubmitAnswer);
            this.gbResult.Controls.Add(this.txtResult);
            this.gbResult.Controls.Add(this.labelEqual);
            this.gbResult.Controls.Add(this.labelOperande2);
            this.gbResult.Controls.Add(this.labelX);
            this.gbResult.Controls.Add(this.labelOperande1);
            this.gbResult.Location = new System.Drawing.Point(772, 12);
            this.gbResult.Name = "gbResult";
            this.gbResult.Size = new System.Drawing.Size(1140, 793);
            this.gbResult.TabIndex = 1;
            this.gbResult.TabStop = false;
            // 
            // labelBravo
            // 
            this.labelBravo.Font = new System.Drawing.Font("Segoe UI", 80F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelBravo.Location = new System.Drawing.Point(6, 319);
            this.labelBravo.Name = "labelBravo";
            this.labelBravo.Size = new System.Drawing.Size(1128, 159);
            this.labelBravo.TabIndex = 6;
            this.labelBravo.Text = "Tu es un vrai puma";
            this.labelBravo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSubmitAnswer
            // 
            this.btnSubmitAnswer.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSubmitAnswer.Location = new System.Drawing.Point(957, 16);
            this.btnSubmitAnswer.Name = "btnSubmitAnswer";
            this.btnSubmitAnswer.Size = new System.Drawing.Size(177, 185);
            this.btnSubmitAnswer.TabIndex = 5;
            this.btnSubmitAnswer.Text = "?";
            this.btnSubmitAnswer.UseVisualStyleBackColor = true;
            this.btnSubmitAnswer.Click += new System.EventHandler(this.btnSubmitAnswer_Click);
            // 
            // txtResult
            // 
            this.txtResult.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtResult.Location = new System.Drawing.Point(667, 16);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(283, 185);
            this.txtResult.TabIndex = 4;
            this.txtResult.Text = "11";
            // 
            // labelEqual
            // 
            this.labelEqual.AutoSize = true;
            this.labelEqual.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEqual.ForeColor = System.Drawing.Color.Blue;
            this.labelEqual.Location = new System.Drawing.Point(491, 19);
            this.labelEqual.Name = "labelEqual";
            this.labelEqual.Size = new System.Drawing.Size(170, 177);
            this.labelEqual.TabIndex = 3;
            this.labelEqual.Text = "=";
            // 
            // labelOperande2
            // 
            this.labelOperande2.AutoSize = true;
            this.labelOperande2.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOperande2.Location = new System.Drawing.Point(333, 19);
            this.labelOperande2.Name = "labelOperande2";
            this.labelOperande2.Size = new System.Drawing.Size(152, 177);
            this.labelOperande2.TabIndex = 2;
            this.labelOperande2.Text = "1";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Segoe UI", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelX.ForeColor = System.Drawing.Color.Blue;
            this.labelX.Location = new System.Drawing.Point(200, 53);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(97, 106);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            // 
            // labelOperande1
            // 
            this.labelOperande1.AutoSize = true;
            this.labelOperande1.Font = new System.Drawing.Font("Segoe UI", 100F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelOperande1.Location = new System.Drawing.Point(6, 19);
            this.labelOperande1.Name = "labelOperande1";
            this.labelOperande1.Size = new System.Drawing.Size(152, 177);
            this.labelOperande1.TabIndex = 0;
            this.labelOperande1.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 817);
            this.Controls.Add(this.gbResult);
            this.Controls.Add(this.gb1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gb1.ResumeLayout(false);
            this.gbResult.ResumeLayout(false);
            this.gbResult.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb1;
        private System.Windows.Forms.GroupBox gbResult;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox gbNum;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Label labelOperande1;
        private System.Windows.Forms.Label labelEqual;
        private System.Windows.Forms.Label labelOperande2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btnSubmitAnswer;
        private System.Windows.Forms.Label labelBravo;
    }
}

