using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using Stego.ValidateDocument;
using Stego.Encrypt;
using Stego.Decrypt;



namespace MyProject
{
    class CommonCalls
    {

        frmTextToImage frmtxttoimg;
        frmImageToImage frmimgtoimg;
        public void openForm(string p)
        {
            if (p.Equals("EnTextToImage"))
            {

                frmtxttoimg = new frmTextToImage("Encryption");
                frmtxttoimg.ShowDialog();
            }

            else if (p.Equals("DeImageToText"))
            {

                frmtxttoimg = new frmTextToImage("Decryption");
                frmtxttoimg.ShowDialog();
            }
            else if (p.Equals("EnImageToImage"))
            {

                frmimgtoimg = new frmImageToImage("Encryption");
                frmimgtoimg.ShowDialog();
            }
            else if (p.Equals("DeImageToImage"))
            {

                frmimgtoimg = new frmImageToImage("Decryption");
                frmimgtoimg.ShowDialog();
            }

        }

        public bool validateFile(string path)
        {
            ValidateImage v = new ValidateImage();
            string message;
            bool check = v.validateFile(path, out message);
            if (!check)
                MessageBox.Show(message);
            return check;
        }

        public Image EnTextToImage(string path, string details, string text)
        {

            Bitmap image = new Bitmap(path);
            ToImage t = new ToImage();

            //Hide Text Behind Image
            image = t.textToImage(image, text, details);
            return image;

        }

        public string DeImageToText(string path, string password, out bool verification)
        {
            ToText t = new ToText();
            Bitmap image = new Bitmap(path);
            return t.imageToText(image, password, out verification);
        }

        internal Image EnImageToImage(string path1, string password, string path2)
        {
            Bitmap image1 = new Bitmap(path1);
            Bitmap image2 = new Bitmap(path2);
            ToImage t = new ToImage();

            //Hide Image Behind Image
            image1 = t.imageToImage(image1, image2, password);
            Image finalImage;
            finalImage = image1;
            return finalImage;
        }

        internal Image DeImageToImage(string path1, string details, out bool verification)
        {
            Bitmap image = new Bitmap(path1);
            ToText t = new ToText();

            //Hide Image Behind Image
            Image finalImage = t.imageFromImage(image, details, out verification);

            return finalImage;
        }


        public bool notNull(string p)
        {
            if (p.Equals(""))
                return false;
            else
                return true;
        }

        public bool passwordMatch(string p,string c)
        {
            if (p.Equals(c))
                return true;
            else
                return false;
        }

    }
}
