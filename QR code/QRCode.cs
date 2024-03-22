using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

//MessagingToolkit.QRCode библиотке для QR code (Добавить через Nuget)

namespace QR_code
{
    internal class QRCode
    {
        public static Bitmap GeterateQR(string textQR)
        {
            QRCodeEncoder encoder = new QRCodeEncoder();
            Bitmap qrcpde = encoder.Encode(textQR);
            return qrcpde;
        }

        public static void SaveQR(Bitmap qrCode)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.InitialDirectory = Application.StartupPath;
            save.Filter = "PNG|*.png|JPEG|*.jpg|GIF|*.gif|BMP|*.bmp";
            if (save.ShowDialog() == DialogResult.OK)
            {
                qrCode.Save(save.FileName);
            }
        }

        public static Bitmap LoadQRk()
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

        public static string ReadQR(Bitmap qrCode)
        {
            try
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                return decoder.Decode(new QRCodeBitmapImage(qrCode));
            }
            catch (InvalidDataException)
            {
                return "Изображение не является QR-кодом.";
            }
            catch (Exception ex)
            {
                return "Ошибка при чтении QR-кода: " + ex.Message;
            }
        }
    }
}
