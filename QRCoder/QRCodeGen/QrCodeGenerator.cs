using System.Drawing;

namespace QRCoder
{
    public class QrGenerator
    {
        public Bitmap GenerateQrCode(string url)
        {
            using var generator = new QRCodeGenerator();
            QRCodeData data = generator.CreateQrCode(url, QRCodeGenerator.ECCLevel.Q);

            using var qrCode = new QRCoder.QRCode(data);
            Bitmap qrImage = qrCode.GetGraphic(20);
            return new Bitmap(qrImage); // Клонируем изображение, т.к. оригинал будет удалён при using
        }
    }
}