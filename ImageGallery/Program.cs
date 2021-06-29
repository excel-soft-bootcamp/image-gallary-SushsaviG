using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    public class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery imageGallery = new ImageGallery(_mailAccount);
            imageGallery.Share();

            Bluetooth _blueToothDevice = new Bluetooth();
            ImageGallery _imageGallery = new ImageGallery(_blueToothDevice);
            _imageGallery.Share();

            Whatsapp _whatsapp = new Whatsapp();
            ImageGallery image = new ImageGallery(_whatsapp);
            image.Share();
        }
    }
}
