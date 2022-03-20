namespace thuchanh2_0902_22
{
    partial class fPhepChia
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComboBox = new System.Windows.Forms.Button();
            this.lbAnswer = new System.Windows.Forms.Label();
            this.btnChia = new System.Windows.Forms.Button();
            this.txbB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbA = new System.Windows.Forms.TextBox();
            this.lbA = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnToListBox = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnToListBox);
            this.panel1.Controls.Add(this.btnComboBox);
            this.panel1.Controls.Add(this.lbAnswer);
            this.panel1.Controls.Add(this.btnChia);
            this.panel1.Controls.Add(this.txbB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txbA);
            this.panel1.Controls.Add(this.lbA);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 155);
            this.panel1.TabIndex = 0;
            // 
            // btnComboBox
            // 
            this.btnComboBox.Location = new System.Drawing.Point(39, 129);
            this.btnComboBox.Name = "btnComboBox";
            this.btnComboBox.Size = new System.Drawing.Size(144, 23);
            this.btnComboBox.TabIndex = 7;
            this.btnComboBox.Text = "Change to ComboBox";
            this.btnComboBox.UseVisualStyleBackColor = true;
            this.btnComboBox.Click += new System.EventHandler(this.btnComboBox_Click);
            // 
            // lbAnswer
            // 
            this.lbAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbAnswer.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAnswer.Location = new System.Drawing.Point(333, 66);
            this.lbAnswer.Name = "lbAnswer";
            this.lbAnswer.Size = new System.Drawing.Size(67, 21);
            this.lbAnswer.TabIndex = 6;
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(288, 65);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(39, 23);
            this.btnChia.TabIndex = 5;
            this.btnChia.Text = "=";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // txbB
            // 
            this.txbB.Location = new System.Drawing.Point(189, 68);
            this.txbB.Name = "txbB";
            this.txbB.Size = new System.Drawing.Size(54, 20);
            this.txbB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = ": B";
            // 
            // txbA
            // 
            this.txbA.Location = new System.Drawing.Point(64, 68);
            this.txbA.Name = "txbA";
            this.txbA.Size = new System.Drawing.Size(53, 20);
            this.txbA.TabIndex = 1;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.Location = new System.Drawing.Point(35, 68);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(23, 22);
            this.lbA.TabIndex = 0;
            this.lbA.Text = "A";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnToListBox
            // 
            this.btnToListBox.Location = new System.Drawing.Point(312, 129);
            this.btnToListBox.Name = "btnToListBox";
            this.btnToListBox.Size = new System.Drawing.Size(160, 23);
            this.btnToListBox.TabIndex = 8;
            this.btnToListBox.Text = "Change to ListBox";
            this.btnToListBox.UseVisualStyleBackColor = true;
            this.btnToListBox.Click += new System.EventHandler(this.btnToListBox_Click);
            // 
            // fPhepChia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 179);
            this.Controls.Add(this.panel1);
            this.Name = "fPhepChia";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.TextBox txbB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbA;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbAnswer;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnComboBox;
        private System.Windows.Forms.Button btnToListBox;
    }
}

