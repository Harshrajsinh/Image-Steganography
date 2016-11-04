using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Stego.ValidateDocument;
using Stego.Encrypt;
using Stego.Decrypt;


namespace MyProject
{
    public partial class Form1 : Form
    {
        //Bitmap b;
        string base64String;
        Image  image1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileSave.AddExtension = true;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FileSelect.ShowDialog();

        }

        private void FileSelect_FileOk(object sender, CancelEventArgs e)
        {

            bool validate = validateFile(FileSelect.FileName);
            if(validate)
            txtPath.Text = FileSelect.FileName;
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {
            //txtText.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPath.Text = "";
            txtPassword.Text = "";
            txtConfirmPassword.Text = "";
            txtSecurityQuestion.Text = "";
            txtSecurityAnswer.Text = "";
            txtCSecurityAnswer.Text = "";
            txtAnswerHint.Text = "";
            txtText.Enabled = true;

        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {


            string s = "Password"+txtPassword.Text + "SQ" +txtSecurityQuestion.Text+ "SA"+txtSecurityAnswer.Text + "SH"+txtAnswerHint.Text+"Key"+textBox1.Text;

            Bitmap image = new Bitmap(txtPath.Text);
           Bitmap imageToHide = new Bitmap(txtPath1.Text);
            ToImage t = new ToImage();
            //Hide Text Behind Image
            //image = t.textToImage(image,txtText.Text);

            //Hide Image Behind Image
         image=t.imageToImage(image,imageToHide,s);
            image1 = image;
                FileSave.ShowDialog();
        }

        private bool validateFile(string path)
        {
            ValidateImage v = new ValidateImage();
            string message;
            bool check = v.validateFile(path, out message);
            if (!check)
                MessageBox.Show(message);
            return check;
        }

        private void FileSave_FileOk(object sender, CancelEventArgs e)
        {
                image1.Save(FileSave.FileName, System.Drawing.Imaging.ImageFormat.Png);
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

            bool validate = validateFile(FileSelect.FileName);
            if (validate)
                txtPath1.Text = FileSelect1.FileName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileSelect1.ShowDialog();
        }

        private void txtPath1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            ToText t=new ToText();
            Bitmap image = new Bitmap(txtPath.Text);
            bool verification;
            txtText.Text = t.imageToText(image,"",out verification);
        }
    }
}
