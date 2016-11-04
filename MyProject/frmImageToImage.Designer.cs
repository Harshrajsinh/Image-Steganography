namespace MyProject
{
    partial class frmImageToImage
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblImageCover = new System.Windows.Forms.Label();
            this.FileSave = new System.Windows.Forms.SaveFileDialog();
            this.FileSelect = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse1 = new System.Windows.Forms.Button();
            this.lblImage = new System.Windows.Forms.Label();
            this.FileSelect1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnMainWindow
            // 
            this.btnMainWindow.Location = new System.Drawing.Point(302, 154);
            this.btnMainWindow.Name = "btnMainWindow";
            this.btnMainWindow.Size = new System.Drawing.Size(93, 50);
            this.btnMainWindow.TabIndex = 7;
            this.btnMainWindow.Text = "Main Window";
            this.btnMainWindow.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(203, 154);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 50);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(104, 154);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(93, 50);
            this.btnOperation.TabIndex = 5;
            this.btnOperation.Text = "Encrypt";
            this.btnOperation.UseVisualStyleBackColor = true;
            this.btnOperation.Click += new System.EventHandler(this.btnOperation_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.SystemColors.Window;
            this.txtConfirmPassword.Location = new System.Drawing.Point(104, 90);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(410, 20);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.Tag = "";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(12, 93);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 52;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(104, 58);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(410, 20);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(12, 61);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 51;
            this.lblPassword.Text = "Password";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(520, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(104, 26);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(410, 20);
            this.txtPath.TabIndex = 1;
            // 
            // lblImageCover
            // 
            this.lblImageCover.AutoSize = true;
            this.lblImageCover.Location = new System.Drawing.Point(12, 29);
            this.lblImageCover.Name = "lblImageCover";
            this.lblImageCover.Size = new System.Drawing.Size(67, 13);
            this.lblImageCover.TabIndex = 48;
            this.lblImageCover.Text = "Cover Image";
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
            // btnBrowse1
            // 
            this.btnBrowse1.Location = new System.Drawing.Point(520, 119);
            this.btnBrowse1.Name = "btnBrowse1";
            this.btnBrowse1.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse1.TabIndex = 4;
            this.btnBrowse1.Text = "Browse";
            this.btnBrowse1.UseVisualStyleBackColor = true;
            this.btnBrowse1.Click += new System.EventHandler(this.btnBrowse1_Click);
            // 
            // lblImage
            // 
            this.lblImage.AutoSize = true;
            this.lblImage.Location = new System.Drawing.Point(12, 124);
            this.lblImage.Name = "lblImage";
            this.lblImage.Size = new System.Drawing.Size(77, 13);
            this.lblImage.TabIndex = 53;
            this.lblImage.Text = "Image To Hide";
            // 
            // FileSelect1
            // 
            this.FileSelect1.FileName = "openFileDialog1";
            this.FileSelect1.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            this.FileSelect1.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSelect1_FileOk);
            // 
            // txtPath1
            // 
            this.txtPath1.Location = new System.Drawing.Point(104, 122);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.ReadOnly = true;
            this.txtPath1.Size = new System.Drawing.Size(410, 20);
            this.txtPath1.TabIndex = 54;
            // 
            // frmImageToImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 213);
            this.Controls.Add(this.txtPath1);
            this.Controls.Add(this.btnBrowse1);
            this.Controls.Add(this.lblImage);
            this.Controls.Add(this.btnMainWindow);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.lblImageCover);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmImageToImage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Image To Image";
            this.Load += new System.EventHandler(this.frmImageToImage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMainWindow;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblImageCover;
        private System.Windows.Forms.SaveFileDialog FileSave;
        private System.Windows.Forms.OpenFileDialog FileSelect;
        private System.Windows.Forms.Button btnBrowse1;
        private System.Windows.Forms.Label lblImage;
        private System.Windows.Forms.OpenFileDialog FileSelect1;
        private System.Windows.Forms.TextBox txtPath1;

    }
}