using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void geterateQR_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = QRCode.geterateQR(textBox1.Text);
        }

        private void saveQR_Click(object sender, EventArgs e)
        {
            QRCode.saveQR((Bitmap)pictureBox1.Image);
        }

        private void loadQR_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = QRCode.loadQRk();
        }

        private void readQR_Click(object sender, EventArgs e)
        {
            MessageBox.Show(QRCode.readQR((Bitmap)pictureBox1.Image));
        }
    }
}
