namespace MyProject
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
            this.FileSelect = new System.Windows.Forms.OpenFileDialog();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabEncrypt = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtPath1 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblText = new System.Windows.Forms.Label();
            this.lblAnswerHint = new System.Windows.Forms.Label();
            this.txtAnswerHint = new System.Windows.Forms.TextBox();
            this.txtSecurityQuestion = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.txtText = new System.Windows.Forms.TextBox();
            this.lblSecurityQuestion = new System.Windows.Forms.Label();
            this.txtCSecurityAnswer = new System.Windows.Forms.TextBox();
            this.lblCSecurityAnswer = new System.Windows.Forms.Label();
            this.txtSecurityAnswer = new System.Windows.Forms.TextBox();
            this.lblSecurityAnswer = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.lblFile = new System.Windows.Forms.Label();
            this.tabDecrypt = new System.Windows.Forms.TabPage();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FileSave = new System.Windows.Forms.SaveFileDialog();
            this.FileSelect1 = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabEncrypt.SuspendLayout();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // FileSelect
            // 
            this.FileSelect.FileName = "openFileDialog1";
            this.FileSelect.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            this.FileSelect.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSelect_FileOk);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEncrypt);
            this.tabControl.Controls.Add(this.tabDecrypt);
            this.tabControl.Location = new System.Drawing.Point(1, 24);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(666, 480);
            this.tabControl.TabIndex = 0;
            // 
            // tabEncrypt
            // 
            this.tabEncrypt.Controls.Add(this.button2);
            this.tabEncrypt.Controls.Add(this.button1);
            this.tabEncrypt.Controls.Add(this.txtPath1);
            this.tabEncrypt.Controls.Add(this.textBox1);
            this.tabEncrypt.Controls.Add(this.lblText);
            this.tabEncrypt.Controls.Add(this.lblAnswerHint);
            this.tabEncrypt.Controls.Add(this.txtAnswerHint);
            this.tabEncrypt.Controls.Add(this.txtSecurityQuestion);
            this.tabEncrypt.Controls.Add(this.btnReset);
            this.tabEncrypt.Controls.Add(this.btnEncrypt);
            this.tabEncrypt.Controls.Add(this.txtText);
            this.tabEncrypt.Controls.Add(this.lblSecurityQuestion);
            this.tabEncrypt.Controls.Add(this.txtCSecurityAnswer);
            this.tabEncrypt.Controls.Add(this.lblCSecurityAnswer);
            this.tabEncrypt.Controls.Add(this.txtSecurityAnswer);
            this.tabEncrypt.Controls.Add(this.lblSecurityAnswer);
            this.tabEncrypt.Controls.Add(this.txtConfirmPassword);
            this.tabEncrypt.Controls.Add(this.lblConfirmPassword);
            this.tabEncrypt.Controls.Add(this.txtPassword);
            this.tabEncrypt.Controls.Add(this.lblPassword);
            this.tabEncrypt.Controls.Add(this.btnBrowse);
            this.tabEncrypt.Controls.Add(this.txtPath);
            this.tabEncrypt.Controls.Add(this.lblFile);
            this.tabEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabEncrypt.Name = "tabEncrypt";
            this.tabEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncrypt.Size = new System.Drawing.Size(658, 454);
            this.tabEncrypt.TabIndex = 0;
            this.tabEncrypt.Text = "Encrypt";
            this.tabEncrypt.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(368, 395);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 50);
            this.button2.TabIndex = 22;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(583, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtPath1
            // 
            this.txtPath1.Enabled = false;
            this.txtPath1.Location = new System.Drawing.Point(161, 386);
            this.txtPath1.Name = "txtPath1";
            this.txtPath1.Size = new System.Drawing.Size(410, 20);
            this.txtPath1.TabIndex = 20;
            this.txtPath1.TextChanged += new System.EventHandler(this.txtPath1_TextChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(375, 397);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(86, 20);
            this.textBox1.TabIndex = 19;
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(18, 315);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(28, 13);
            this.lblText.TabIndex = 18;
            this.lblText.Text = "Text";
            // 
            // lblAnswerHint
            // 
            this.lblAnswerHint.AutoSize = true;
            this.lblAnswerHint.Location = new System.Drawing.Point(18, 206);
            this.lblAnswerHint.Name = "lblAnswerHint";
            this.lblAnswerHint.Size = new System.Drawing.Size(64, 13);
            this.lblAnswerHint.TabIndex = 17;
            this.lblAnswerHint.Text = "Answer Hint";
            // 
            // txtAnswerHint
            // 
            this.txtAnswerHint.Location = new System.Drawing.Point(161, 202);
            this.txtAnswerHint.Name = "txtAnswerHint";
            this.txtAnswerHint.Size = new System.Drawing.Size(410, 20);
            this.txtAnswerHint.TabIndex = 16;
            // 
            // txtSecurityQuestion
            // 
            this.txtSecurityQuestion.Location = new System.Drawing.Point(161, 108);
            this.txtSecurityQuestion.Name = "txtSecurityQuestion";
            this.txtSecurityQuestion.Size = new System.Drawing.Size(410, 20);
            this.txtSecurityQuestion.TabIndex = 15;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(260, 397);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(93, 50);
            this.btnReset.TabIndex = 14;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(161, 397);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(93, 50);
            this.btnEncrypt.TabIndex = 13;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // txtText
            // 
            this.txtText.Location = new System.Drawing.Point(161, 234);
            this.txtText.Multiline = true;
            this.txtText.Name = "txtText";
            this.txtText.Size = new System.Drawing.Size(410, 146);
            this.txtText.TabIndex = 12;
            // 
            // lblSecurityQuestion
            // 
            this.lblSecurityQuestion.AutoSize = true;
            this.lblSecurityQuestion.Location = new System.Drawing.Point(18, 110);
            this.lblSecurityQuestion.Name = "lblSecurityQuestion";
            this.lblSecurityQuestion.Size = new System.Drawing.Size(90, 13);
            this.lblSecurityQuestion.TabIndex = 11;
            this.lblSecurityQuestion.Text = "Security Question";
            // 
            // txtCSecurityAnswer
            // 
            this.txtCSecurityAnswer.Location = new System.Drawing.Point(161, 172);
            this.txtCSecurityAnswer.Name = "txtCSecurityAnswer";
            this.txtCSecurityAnswer.PasswordChar = '$';
            this.txtCSecurityAnswer.Size = new System.Drawing.Size(410, 20);
            this.txtCSecurityAnswer.TabIndex = 10;
            // 
            // lblCSecurityAnswer
            // 
            this.lblCSecurityAnswer.AutoSize = true;
            this.lblCSecurityAnswer.Location = new System.Drawing.Point(18, 174);
            this.lblCSecurityAnswer.Name = "lblCSecurityAnswer";
            this.lblCSecurityAnswer.Size = new System.Drawing.Size(121, 13);
            this.lblCSecurityAnswer.TabIndex = 9;
            this.lblCSecurityAnswer.Text = "Confirm Security Answer";
            // 
            // txtSecurityAnswer
            // 
            this.txtSecurityAnswer.Location = new System.Drawing.Point(161, 140);
            this.txtSecurityAnswer.Name = "txtSecurityAnswer";
            this.txtSecurityAnswer.PasswordChar = '$';
            this.txtSecurityAnswer.Size = new System.Drawing.Size(410, 20);
            this.txtSecurityAnswer.TabIndex = 8;
            // 
            // lblSecurityAnswer
            // 
            this.lblSecurityAnswer.AutoSize = true;
            this.lblSecurityAnswer.Location = new System.Drawing.Point(18, 142);
            this.lblSecurityAnswer.Name = "lblSecurityAnswer";
            this.lblSecurityAnswer.Size = new System.Drawing.Size(83, 13);
            this.lblSecurityAnswer.TabIndex = 7;
            this.lblSecurityAnswer.Text = "Security Answer";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(161, 76);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(410, 20);
            this.txtConfirmPassword.TabIndex = 6;
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(18, 78);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(161, 44);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(410, 20);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(18, 46);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(53, 13);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Password";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(577, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 2;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtPath
            // 
            this.txtPath.Enabled = false;
            this.txtPath.Location = new System.Drawing.Point(161, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(410, 20);
            this.txtPath.TabIndex = 1;
            this.txtPath.TextChanged += new System.EventHandler(this.txtPath_TextChanged);
            // 
            // lblFile
            // 
            this.lblFile.AutoSize = true;
            this.lblFile.Location = new System.Drawing.Point(18, 14);
            this.lblFile.Name = "lblFile";
            this.lblFile.Size = new System.Drawing.Size(23, 13);
            this.lblFile.TabIndex = 0;
            this.lblFile.Text = "File";
            // 
            // tabDecrypt
            // 
            this.tabDecrypt.Location = new System.Drawing.Point(4, 22);
            this.tabDecrypt.Name = "tabDecrypt";
            this.tabDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabDecrypt.Size = new System.Drawing.Size(658, 454);
            this.tabDecrypt.TabIndex = 1;
            this.tabDecrypt.Text = "Dycrypt";
            this.tabDecrypt.UseVisualStyleBackColor = true;
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Padding = new System.Windows.Forms.Padding(0);
            this.menuMain.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuMain.Size = new System.Drawing.Size(666, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // FileSave
            // 
            this.FileSave.DefaultExt = "png";
            this.FileSave.FileName = "Image";
            this.FileSave.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            this.FileSave.FileOk += new System.ComponentModel.CancelEventHandler(this.FileSave_FileOk);
            // 
            // FileSelect1
            // 
            this.FileSelect1.FileName = "openFileDialog1";
            this.FileSelect1.Filter = "PNG|*.png|GIF|*.gif|BMP|*.bmp|JPEG|*.jpg;*.jpeg";
            this.FileSelect1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 503);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuMain;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl.ResumeLayout(false);
            this.tabEncrypt.ResumeLayout(false);
            this.tabEncrypt.PerformLayout();
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog FileSelect;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEncrypt;
        private System.Windows.Forms.TabPage tabDecrypt;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label lblFile;
        private System.Windows.Forms.TextBox txtCSecurityAnswer;
        private System.Windows.Forms.Label lblCSecurityAnswer;
        private System.Windows.Forms.TextBox txtSecurityAnswer;
        private System.Windows.Forms.Label lblSecurityAnswer;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.TextBox txtText;
        private System.Windows.Forms.Label lblSecurityQuestion;
        private System.Windows.Forms.TextBox txtSecurityQuestion;
        private System.Windows.Forms.Label lblAnswerHint;
        private System.Windows.Forms.TextBox txtAnswerHint;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.SaveFileDialog FileSave;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtPath1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog FileSelect1;
        private System.Windows.Forms.Button button2;
    }
}

