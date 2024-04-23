using System.Drawing;
using System.IO;
using System.Web.Mvc;
using ZXing;

public class QRCodeController : Controller
{
    public ActionResult GenerateQRCode(string text)
    {
        // Crée un objet BarcodeWriter pour générer le QRCode
        var barcodeWriter = new BarcodeWriter
        {
            Format = BarcodeFormat.QR_CODE,
            Options = new ZXing.Common.EncodingOptions
            {
                Width = 300,
                Height = 300 // Ajuste la taille du QRCode selon tes besoins
            }
        };

        // Encode le texte dans un QRCode bitmap
        using (var bitmap = barcodeWriter.Write(text))
        {
            // Convertit le bitmap en tableau de bytes
            using (var stream = new MemoryStream())
            {
                bitmap.Save(stream, System.Drawing.Imaging.ImageFormat.Png);
                var imgBytes = stream.ToArray();

                // Retourne l'image du QRCode
                return File(imgBytes, "image/png");
            }
        }
    }
}