using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchResizer
{
    public partial class frmMain : Form
    {
        public string imageDirectory;
        public frmMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.jpeg; *.png";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                imageDirectory = ofd.FileName;
                pictureBox2.Image = ResizeImage(new Bitmap(ofd.FileName), 18, 18);
                pictureBox3.Image = ResizeImage(new Bitmap(ofd.FileName), 36, 36);
                pictureBox4.Image = ResizeImage(new Bitmap(ofd.FileName), 72, 72);
                pictureBox1.Image = new Bitmap(ofd.FileName);
                textBox1.Text = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = @"PNG Files|*.png" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox2.Image.Save(saveFileDialog.FileName + label5.Text + ".png");
                        pictureBox3.Image.Save(saveFileDialog.FileName + label6.Text + ".png");
                        pictureBox4.Image.Save(saveFileDialog.FileName + label7.Text + ".png");
                        MessageBox.Show("Operation completed succesfully.", "Twitch Resizer");
                    }
                    catch
                    {
                        MessageBox.Show("Failed to save files.", "Twitch Resizer");
                    }


                }
            }
        }


        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);
            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }
            return destImage;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedItem = "Sub Badges";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == "Channel Points")
            {
                if (textBox1.Text != null) // if it works it works
                {
                    pictureBox2.Image = ResizeImage(new Bitmap(textBox1.Text), 28, 28);
                    pictureBox3.Image = ResizeImage(new Bitmap(textBox1.Text), 56, 56);
                    pictureBox4.Image = ResizeImage(new Bitmap(textBox1.Text), 112, 112);
                }
            }
            else
            {
                try
                {
                    if (textBox1.Text != null)
                    {
                        pictureBox2.Image = ResizeImage(new Bitmap(textBox1.Text), 18, 18);
                        pictureBox3.Image = ResizeImage(new Bitmap(textBox1.Text), 36, 36);
                        pictureBox4.Image = ResizeImage(new Bitmap(textBox1.Text), 72, 72);
                    }
                    else
                    {
                        return;
                    }
                }
                catch
                {

                }
            }

            SwitchModes();

        }


        private void SwitchModes()
        {
            if (comboBox1.SelectedItem == "Channel Points")
            {
                label5.Text = "28x28";
                label6.Text = "56x56";
                label7.Text = "112x112";

            }
            else
            {
                label5.Text = "18x18";
                label6.Text = "36x36";
                label7.Text = "72x72";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout();
            about.Show();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
