using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_code
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.AllowDrop = true; 
            pictureBox1.DragEnter += PictureBox_DragEnter;
            pictureBox1.DragDrop += PictureBox_DragDrop;
        }

        private void geterateQR_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = QRCode.GeterateQR(textBox1.Text);
        }

        private void saveQR_Click(object sender, EventArgs e)
        {
            QRCode.SaveQR((Bitmap)pictureBox1.Image);
        }

        private void loadQR_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = QRCode.LoadQRk();
        }

        private void readQR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(QRCode.ReadQR((Bitmap)pictureBox1.Image));
        }

        private void PictureBox_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void PictureBox_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            string imagePath = files[0];
            try
            {
                pictureBox1.Image = Image.FromFile(imagePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка загрузки изображения: " + ex.Message);
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            //Pen pen = new Pen(Color.Black, 2);
            //pen.DashPattern = new float[] { 2, 2 };
            //Rectangle rect = new Rectangle(1, 1, pictureBox1.Width - 2, pictureBox1.Height - 2);
            //e.Graphics.DrawRectangle(pen, rect);
        }
    }
}
