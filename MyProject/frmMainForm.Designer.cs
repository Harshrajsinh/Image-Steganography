namespace MyProject
{
    partial class frmMainForm
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.grpToFile = new System.Windows.Forms.GroupBox();
            this.btnImageToFile = new System.Windows.Forms.Button();
            this.btnFileToFile = new System.Windows.Forms.Button();
            this.btnTextToFiles = new System.Windows.Forms.Button();
            this.grpToImage = new System.Windows.Forms.GroupBox();
            this.btnImageToImage = new System.Windows.Forms.Button();
            this.btnFileToImage = new System.Windows.Forms.Button();
            this.btnTextToImage = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grpFromFile = new System.Windows.Forms.GroupBox();
            this.btnImageFromFile = new System.Windows.Forms.Button();
            this.btnFileFromFile = new System.Windows.Forms.Button();
            this.btnTextFromFile = new System.Windows.Forms.Button();
            this.grpFromImage = new System.Windows.Forms.GroupBox();
            this.btnImageFromImage = new System.Windows.Forms.Button();
            this.btnFileFromImage = new System.Windows.Forms.Button();
            this.btnTextFromImage = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.grpToFile.SuspendLayout();
            this.grpToImage.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.grpFromFile.SuspendLayout();
            this.grpFromImage.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grpToFile);
            this.groupBox3.Controls.Add(this.grpToImage);
            this.groupBox3.Location = new System.Drawing.Point(12, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 208);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Encryption";
            // 
            // grpToFile
            // 
            this.grpToFile.Controls.Add(this.btnImageToFile);
            this.grpToFile.Controls.Add(this.btnFileToFile);
            this.grpToFile.Controls.Add(this.btnTextToFiles);
            this.grpToFile.Location = new System.Drawing.Point(20, 29);
            this.grpToFile.Name = "grpToFile";
            this.grpToFile.Size = new System.Drawing.Size(281, 80);
            this.grpToFile.TabIndex = 1;
            this.grpToFile.TabStop = false;
            this.grpToFile.Text = "To File";
            // 
            // btnImageToFile
            // 
            this.btnImageToFile.Location = new System.Drawing.Point(191, 19);
            this.btnImageToFile.Name = "btnImageToFile";
            this.btnImageToFile.Size = new System.Drawing.Size(75, 44);
            this.btnImageToFile.TabIndex = 3;
            this.btnImageToFile.Text = "Image";
            this.btnImageToFile.UseVisualStyleBackColor = true;
            // 
            // btnFileToFile
            // 
            this.btnFileToFile.Location = new System.Drawing.Point(101, 19);
            this.btnFileToFile.Name = "btnFileToFile";
            this.btnFileToFile.Size = new System.Drawing.Size(75, 44);
            this.btnFileToFile.TabIndex = 2;
            this.btnFileToFile.Text = "File";
            this.btnFileToFile.UseVisualStyleBackColor = true;
            // 
            // btnTextToFiles
            // 
            this.btnTextToFiles.Location = new System.Drawing.Point(11, 19);
            this.btnTextToFiles.Name = "btnTextToFiles";
            this.btnTextToFiles.Size = new System.Drawing.Size(75, 44);
            this.btnTextToFiles.TabIndex = 1;
            this.btnTextToFiles.Text = "Text";
            this.btnTextToFiles.UseVisualStyleBackColor = true;
            this.btnTextToFiles.Click += new System.EventHandler(this.btnTextToFiles_Click);
            // 
            // grpToImage
            // 
            this.grpToImage.Controls.Add(this.btnImageToImage);
            this.grpToImage.Controls.Add(this.btnFileToImage);
            this.grpToImage.Controls.Add(this.btnTextToImage);
            this.grpToImage.Location = new System.Drawing.Point(20, 115);
            this.grpToImage.Name = "grpToImage";
            this.grpToImage.Size = new System.Drawing.Size(281, 80);
            this.grpToImage.TabIndex = 2;
            this.grpToImage.TabStop = false;
            this.grpToImage.Text = "To Image";
            // 
            // btnImageToImage
            // 
            this.btnImageToImage.Location = new System.Drawing.Point(191, 19);
            this.btnImageToImage.Name = "btnImageToImage";
            this.btnImageToImage.Size = new System.Drawing.Size(75, 44);
            this.btnImageToImage.TabIndex = 6;
            this.btnImageToImage.Text = "Image";
            this.btnImageToImage.UseVisualStyleBackColor = true;
            this.btnImageToImage.Click += new System.EventHandler(this.btnImageToImage_Click);
            // 
            // btnFileToImage
            // 
            this.btnFileToImage.Location = new System.Drawing.Point(101, 19);
            this.btnFileToImage.Name = "btnFileToImage";
            this.btnFileToImage.Size = new System.Drawing.Size(75, 44);
            this.btnFileToImage.TabIndex = 5;
            this.btnFileToImage.Text = "File";
            this.btnFileToImage.UseVisualStyleBackColor = true;
            // 
            // btnTextToImage
            // 
            this.btnTextToImage.Location = new System.Drawing.Point(11, 19);
            this.btnTextToImage.Name = "btnTextToImage";
            this.btnTextToImage.Size = new System.Drawing.Size(75, 44);
            this.btnTextToImage.TabIndex = 4;
            this.btnTextToImage.Text = "Text";
            this.btnTextToImage.UseVisualStyleBackColor = true;
            this.btnTextToImage.Click += new System.EventHandler(this.btnTextToImage_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grpFromFile);
            this.groupBox4.Controls.Add(this.grpFromImage);
            this.groupBox4.Location = new System.Drawing.Point(12, 245);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(313, 208);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Decryption ";
            // 
            // grpFromFile
            // 
            this.grpFromFile.Controls.Add(this.btnImageFromFile);
            this.grpFromFile.Controls.Add(this.btnFileFromFile);
            this.grpFromFile.Controls.Add(this.btnTextFromFile);
            this.grpFromFile.Location = new System.Drawing.Point(20, 29);
            this.grpFromFile.Name = "grpFromFile";
            this.grpFromFile.Size = new System.Drawing.Size(281, 80);
            this.grpFromFile.TabIndex = 3;
            this.grpFromFile.TabStop = false;
            this.grpFromFile.Text = "From File";
            // 
            // btnImageFromFile
            // 
            this.btnImageFromFile.Location = new System.Drawing.Point(191, 19);
            this.btnImageFromFile.Name = "btnImageFromFile";
            this.btnImageFromFile.Size = new System.Drawing.Size(75, 44);
            this.btnImageFromFile.TabIndex = 9;
            this.btnImageFromFile.Text = "Image";
            this.btnImageFromFile.UseVisualStyleBackColor = true;
            // 
            // btnFileFromFile
            // 
            this.btnFileFromFile.Location = new System.Drawing.Point(101, 19);
            this.btnFileFromFile.Name = "btnFileFromFile";
            this.btnFileFromFile.Size = new System.Drawing.Size(75, 44);
            this.btnFileFromFile.TabIndex = 8;
            this.btnFileFromFile.Text = "File";
            this.btnFileFromFile.UseVisualStyleBackColor = true;
            this.btnFileFromFile.Click += new System.EventHandler(this.btnFileFromFile_Click);
            // 
            // btnTextFromFile
            // 
            this.btnTextFromFile.Location = new System.Drawing.Point(11, 19);
            this.btnTextFromFile.Name = "btnTextFromFile";
            this.btnTextFromFile.Size = new System.Drawing.Size(75, 44);
            this.btnTextFromFile.TabIndex = 7;
            this.btnTextFromFile.Text = "Text";
            this.btnTextFromFile.UseVisualStyleBackColor = true;
            // 
            // grpFromImage
            // 
            this.grpFromImage.Controls.Add(this.btnImageFromImage);
            this.grpFromImage.Controls.Add(this.btnFileFromImage);
            this.grpFromImage.Controls.Add(this.btnTextFromImage);
            this.grpFromImage.Location = new System.Drawing.Point(20, 115);
            this.grpFromImage.Name = "grpFromImage";
            this.grpFromImage.Size = new System.Drawing.Size(281, 80);
            this.grpFromImage.TabIndex = 4;
            this.grpFromImage.TabStop = false;
            this.grpFromImage.Text = "From Image";
            // 
            // btnImageFromImage
            // 
            this.btnImageFromImage.Location = new System.Drawing.Point(191, 19);
            this.btnImageFromImage.Name = "btnImageFromImage";
            this.btnImageFromImage.Size = new System.Drawing.Size(75, 44);
            this.btnImageFromImage.TabIndex = 12;
            this.btnImageFromImage.Text = "Image";
            this.btnImageFromImage.UseVisualStyleBackColor = true;
            this.btnImageFromImage.Click += new System.EventHandler(this.btnImageFromImage_Click);
            // 
            // btnFileFromImage
            // 
            this.btnFileFromImage.Location = new System.Drawing.Point(101, 19);
            this.btnFileFromImage.Name = "btnFileFromImage";
            this.btnFileFromImage.Size = new System.Drawing.Size(75, 44);
            this.btnFileFromImage.TabIndex = 11;
            this.btnFileFromImage.Text = "File";
            this.btnFileFromImage.UseVisualStyleBackColor = true;
            // 
            // btnTextFromImage
            // 
            this.btnTextFromImage.Location = new System.Drawing.Point(11, 19);
            this.btnTextFromImage.Name = "btnTextFromImage";
            this.btnTextFromImage.Size = new System.Drawing.Size(75, 44);
            this.btnTextFromImage.TabIndex = 10;
            this.btnTextFromImage.Text = "Text";
            this.btnTextFromImage.UseVisualStyleBackColor = true;
            this.btnTextFromImage.Click += new System.EventHandler(this.btnTextFromImage_Click);
            // 
            // frmMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 474);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMainForm";
            this.Load += new System.EventHandler(this.frmMainForm_Load);
            this.groupBox3.ResumeLayout(false);
            this.grpToFile.ResumeLayout(false);
            this.grpToImage.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.grpFromFile.ResumeLayout(false);
            this.grpFromImage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox grpToFile;
        private System.Windows.Forms.Button btnImageToFile;
        private System.Windows.Forms.Button btnFileToFile;
        private System.Windows.Forms.Button btnTextToFiles;
        private System.Windows.Forms.GroupBox grpToImage;
        private System.Windows.Forms.Button btnImageToImage;
        private System.Windows.Forms.Button btnFileToImage;
        private System.Windows.Forms.Button btnTextToImage;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox grpFromFile;
        private System.Windows.Forms.Button btnImageFromFile;
        private System.Windows.Forms.Button btnFileFromFile;
        private System.Windows.Forms.Button btnTextFromFile;
        private System.Windows.Forms.GroupBox grpFromImage;
        private System.Windows.Forms.Button btnImageFromImage;
        private System.Windows.Forms.Button btnFileFromImage;
        private System.Windows.Forms.Button btnTextFromImage;


    }
}