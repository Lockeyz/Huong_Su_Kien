namespace thuchanh0902_22
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSayIt = new System.Windows.Forms.Button();
            this.tbEdit = new System.Windows.Forms.TextBox();
            this.lbCount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbCount);
            this.panel1.Controls.Add(this.btnSayIt);
            this.panel1.Controls.Add(this.tbEdit);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(486, 276);
            this.panel1.TabIndex = 0;
            // 
            // btnSayIt
            // 
            this.btnSayIt.Enabled = false;
            this.btnSayIt.Location = new System.Drawing.Point(185, 153);
            this.btnSayIt.Name = "btnSayIt";
            this.btnSayIt.Size = new System.Drawing.Size(75, 23);
            this.btnSayIt.TabIndex = 1;
            this.btnSayIt.Text = "Say it";
            this.btnSayIt.UseVisualStyleBackColor = true;
            this.btnSayIt.Click += new System.EventHandler(this.btnSayIt_Click);
            // 
            // tbEdit
            // 
            this.tbEdit.Location = new System.Drawing.Point(124, 64);
            this.tbEdit.Name = "tbEdit";
            this.tbEdit.Size = new System.Drawing.Size(206, 20);
            this.tbEdit.TabIndex = 0;
            this.tbEdit.TextChanged += new System.EventHandler(this.tbEdit_TextChanged);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Location = new System.Drawing.Point(336, 67);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(13, 13);
            this.lbCount.TabIndex = 2;
            this.lbCount.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 300);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSayIt;
        private System.Windows.Forms.TextBox tbEdit;
        private System.Windows.Forms.Label lbCount;
    }
}

