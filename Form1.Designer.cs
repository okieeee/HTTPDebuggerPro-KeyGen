namespace HTTPDebuggerKeyGen
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms
        private void InitializeComponent()
        {
            this.applyButton = new System.Windows.Forms.Button();
            this.keyTextBox = new System.Windows.Forms.TextBox();
            this.genButton = new System.Windows.Forms.Button();
            this.SNtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(116, 64);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(80, 21);
            this.applyButton.TabIndex = 0;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // keyTextBox
            // 
            this.keyTextBox.Enabled = false;
            this.keyTextBox.Location = new System.Drawing.Point(22, 38);
            this.keyTextBox.Name = "keyTextBox";
            this.keyTextBox.Size = new System.Drawing.Size(174, 20);
            this.keyTextBox.TabIndex = 2;
            // 
            // genButton
            // 
            this.genButton.Location = new System.Drawing.Point(22, 64);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(78, 21);
            this.genButton.TabIndex = 3;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // SNtextBox
            // 
            this.SNtextBox.Enabled = false;
            this.SNtextBox.Location = new System.Drawing.Point(22, 12);
            this.SNtextBox.Name = "SNtextBox";
            this.SNtextBox.Size = new System.Drawing.Size(174, 20);
            this.SNtextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.ForeColor = System.Drawing.Color.IndianRed;
            this.label1.Location = new System.Drawing.Point(166, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "okie#7771";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 96);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SNtextBox);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.keyTextBox);
            this.Controls.Add(this.applyButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HTTPDebuggerPro KeyGen";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.TextBox keyTextBox;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.TextBox SNtextBox;
        private System.Windows.Forms.Label label1;
    }
}

