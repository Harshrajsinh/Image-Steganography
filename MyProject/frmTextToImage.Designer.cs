namespace MyProject
{
    partial class frmTextToImage
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
            this.btnMainWindow = new System.Windows.Forms.Button();
            this.lblText = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.FileSave = new System.Windows.Forms.SaveFileDialog();
            this.FileSelect = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Location = new System.Drawing.Point(297, 270);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(93, 50);
            this.btnMainWindow.TabIndex = 6;
            this.btnMainWindow.Text = "Main Window";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            this.btnMainWindow.Click += new System.EventHandler(this.btnMainWindow_Click);
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(12, 185);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 41;
            this.lblText.Text = "Text";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(198, 270);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(99, 270);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(93, 50);
            this.btnOperation.TabIndex = 4;
            this.btnOperation.Text = "Encrypt";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(99, 111);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtText.Size = new System.Drawing.Size(410, 146);
            this.txtText.TabIndex = 3;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(99, 79);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(410, 20);
            this.txtConfirmPassword.TabIndex = 2;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(7, 82);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 28;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(99, 47);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(410, 20);
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(7, 50);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 26;
            this.lblPassword.Text = "Password";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(515, 13);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 25;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(99, 15);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(410, 20);
            this.txtPath.TabIndex = 24;
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(7, 18);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 23;
            this.lblFile.Text = "File";
            // 
            // FileSave
            // 
            this.FileSave.DefaultExt = "png";
            this.FileSave.FileName = "Image";
            this.FileSave.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            this.FileSave.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSave_FileOk);
            // 
            // FileSelect
            // 
            this.FileSelect.FileName = "openFileDialog1";
            this.FileSelect.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            this.FileSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSelect_FileOk);
            // 
            // frmTextToImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 339);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.txtText);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmTextToImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTextToImage";
            this.Activated += new System.EventHandler(this.frmTextToImage_Activated);
            this.Load += new System.EventHandler(this.frmTextToImage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.SaveFileDialog FileSave;
        private System.Windows.Forms.OpenFileDialog FileSelect;
    }
}