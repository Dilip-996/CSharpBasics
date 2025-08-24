namespace FacebookNameDisplay.UI
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Button buttonAddName;
        private System.Windows.Forms.ListBox listBoxNames;
        private System.Windows.Forms.Button buttonShowMessage;
        private System.Windows.Forms.Label labelMessage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.buttonAddName = new System.Windows.Forms.Button();
            this.listBoxNames = new System.Windows.Forms.ListBox();
            this.buttonShowMessage = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(12, 12);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(200, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // buttonAddName
            // 
            this.buttonAddName.Location = new System.Drawing.Point(218, 10);
            this.buttonAddName.Name = "buttonAddName";
            this.buttonAddName.Size = new System.Drawing.Size(75, 23);
            this.buttonAddName.TabIndex = 1;
            this.buttonAddName.Text = "Add";
            this.buttonAddName.UseVisualStyleBackColor = true;
            this.buttonAddName.Click += new System.EventHandler(this.buttonAddName_Click);
            // 
            // listBoxNames
            // 
            this.listBoxNames.FormattingEnabled = true;
            this.listBoxNames.Location = new System.Drawing.Point(12, 40);
            this.listBoxNames.Name = "listBoxNames";
            this.listBoxNames.Size = new System.Drawing.Size(281, 95);
            this.listBoxNames.TabIndex = 2;
            // 
            // buttonShowMessage
            // 
            this.buttonShowMessage.Location = new System.Drawing.Point(12, 145);
            this.buttonShowMessage.Name = "buttonShowMessage";
            this.buttonShowMessage.Size = new System.Drawing.Size(100, 23);
            this.buttonShowMessage.TabIndex = 3;
            this.buttonShowMessage.Text = "Show Message";
            this.buttonShowMessage.UseVisualStyleBackColor = true;
            this.buttonShowMessage.Click += new System.EventHandler(this.buttonShowMessage_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(12, 175);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 200);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.buttonShowMessage);
            this.Controls.Add(this.listBoxNames);
            this.Controls.Add(this.buttonAddName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Form1";
            this.Text = "Facebook Name Display";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}

