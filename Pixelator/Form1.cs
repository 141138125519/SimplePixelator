using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Drawing.Imaging;

using System.Diagnostics;

namespace Pixelator
{
    public partial class Form1 : Form
    {
        Bitmap originalImage;
        Bitmap pixelImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void pixelateImage(object sender, EventArgs e)
        {
            Int32 pixelateSize = 32;
            try
            {
                pixelateSize = int.Parse(pixelateSizeInput.Text);

                originalImageBox.Image = null;
                Rectangle rectangle = new Rectangle(0, 0, originalImage.Width, originalImage.Height);
                pixelImage = Pixelate.PixelateImage(originalImage, rectangle, pixelateSize);
                originalImageBox.Image = pixelImage;
                saveButton.Enabled = true;
            }
            catch (FormatException)
            {
                pixelateSizeInput.Text = ("32");
            } 
        }

        private void SavePixelated(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image|.*bmp|Gif Image|*.gif";
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                pixelImage.Save(saveDialog.FileName);
            }

        }

        private void LoadFromUrl(object sender, EventArgs e)
        {

            string imageSource = urlImageSourceInput.Text;

            WebClient client = new WebClient();
            Stream stream = client.OpenRead(imageSource);
            Bitmap bitmap = new Bitmap(stream);
            originalImage = bitmap;

            stream.Flush();
            stream.Close();
            client.Dispose();

            originalImageBox.Image = originalImage;
            originalImageBox.SizeMode = PictureBoxSizeMode.Zoom;
            pixelateButton.Enabled = true;
            saveButton.Enabled = false;
        }

        private void LoadFromFile(object sender, EventArgs e)
        {
            var filePath = string.Empty;
            OpenFileDialog loadFileDialog = new OpenFileDialog();

            loadFileDialog.InitialDirectory = "c:\\";
            loadFileDialog.Filter = "Jpeg Image|*.jpg|Bitmap Image|.*bmp|Gif Image|*.gif";

            if (loadFileDialog.ShowDialog() == DialogResult.OK)
            {
                originalImage = new Bitmap(loadFileDialog.OpenFile());

                originalImageBox.Image = originalImage;
                originalImageBox.SizeMode = PictureBoxSizeMode.Zoom;
                pixelateButton.Enabled = true;
                saveButton.Enabled = false;
            }           
        }
    }
}
