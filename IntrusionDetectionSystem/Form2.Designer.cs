namespace IntrusionDetectionSystem
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.listCreatedFiles = new System.Windows.Forms.CheckedListBox();
            this.listModifiedFiles = new System.Windows.Forms.CheckedListBox();
            this.listDeletedFiles = new System.Windows.Forms.CheckedListBox();
            this.listRenamedFiles = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Modified Files :-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Created Files :-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Deleted Files :-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Renamed Files :-";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(567, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 44);
            this.button1.TabIndex = 8;
            this.button1.Text = "Restore";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listCreatedFiles
            // 
            this.listCreatedFiles.FormattingEnabled = true;
            this.listCreatedFiles.Location = new System.Drawing.Point(296, 39);
            this.listCreatedFiles.Name = "listCreatedFiles";
            this.listCreatedFiles.Size = new System.Drawing.Size(265, 169);
            this.listCreatedFiles.TabIndex = 9;
            // 
            // listModifiedFiles
            // 
            this.listModifiedFiles.FormattingEnabled = true;
            this.listModifiedFiles.Location = new System.Drawing.Point(3, 39);
            this.listModifiedFiles.Name = "listModifiedFiles";
            this.listModifiedFiles.Size = new System.Drawing.Size(265, 169);
            this.listModifiedFiles.TabIndex = 10;
            // 
            // listDeletedFiles
            // 
            this.listDeletedFiles.FormattingEnabled = true;
            this.listDeletedFiles.Location = new System.Drawing.Point(3, 253);
            this.listDeletedFiles.Name = "listDeletedFiles";
            this.listDeletedFiles.Size = new System.Drawing.Size(265, 169);
            this.listDeletedFiles.TabIndex = 11;
            // 
            // listRenamedFiles
            // 
            this.listRenamedFiles.FormattingEnabled = true;
            this.listRenamedFiles.Location = new System.Drawing.Point(296, 253);
            this.listRenamedFiles.Name = "listRenamedFiles";
            this.listRenamedFiles.Size = new System.Drawing.Size(265, 169);
            this.listRenamedFiles.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 438);
            this.Controls.Add(this.listRenamedFiles);
            this.Controls.Add(this.listDeletedFiles);
            this.Controls.Add(this.listModifiedFiles);
            this.Controls.Add(this.listCreatedFiles);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox listCreatedFiles;
        private System.Windows.Forms.CheckedListBox listModifiedFiles;
        private System.Windows.Forms.CheckedListBox listDeletedFiles;
        private System.Windows.Forms.CheckedListBox listRenamedFiles;
    }
}