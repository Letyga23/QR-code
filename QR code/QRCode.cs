using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QR_code
{
    internal class QRCode
    {
        public static Bitmap geterateQR(string textQR)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcpde = encoder.Encode(textQR);
            return qrcpde;
        }

        public static void saveQR(Bitmap qrCode)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Application.StartupPath;
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                qrCode.Save(save.FileName);
            }
        }

        public static Bitmap loadQRk()
        {
            OpenFileDialog load = new OpenFileDialog();
            load.InitialDirectory = Application.StartupPath;
            load.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (load.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(load.FileName);
            }
            return null;
        }

        public static string readQR(Bitmap qrCode)
        {
            QRCodeDecoder decoder = new QRCodeDecoder();
            return decoder.Decode(new QRCodeBitmapImage(qrCode));
        }
    }
}
