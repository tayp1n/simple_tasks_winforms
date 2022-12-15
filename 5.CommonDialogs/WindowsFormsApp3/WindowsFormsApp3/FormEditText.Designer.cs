
namespace WindowsFormsApp3
{
    partial class FormEditText
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
            this.textBoxEdit = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.btnCancelFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxEdit
            // 
            this.textBoxEdit.Location = new System.Drawing.Point(12, 12);
            this.textBoxEdit.Multiline = true;
            this.textBoxEdit.Name = "textBoxEdit";
            this.textBoxEdit.Size = new System.Drawing.Size(218, 426);
            this.textBoxEdit.TabIndex = 1;
            this.textBoxEdit.TabStop = false;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(248, 12);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(106, 208);
            this.btnSaveFile.TabIndex = 2;
            this.btnSaveFile.Text = "Save";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // btnCancelFile
            // 
            this.btnCancelFile.Location = new System.Drawing.Point(248, 226);
            this.btnCancelFile.Name = "btnCancelFile";
            this.btnCancelFile.Size = new System.Drawing.Size(106, 212);
            this.btnCancelFile.TabIndex = 3;
            this.btnCancelFile.Text = "Cancel";
            this.btnCancelFile.UseVisualStyleBackColor = true;
            this.btnCancelFile.Click += new System.EventHandler(this.btnCancelFile_Click);
            // 
            // FormEditText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btnCancelFile);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.textBoxEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(387, 489);
            this.MinimumSize = new System.Drawing.Size(387, 489);
            this.Name = "FormEditText";
            this.Load += new System.EventHandler(this.FormEditText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxEdit;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Button btnCancelFile;
    }
}