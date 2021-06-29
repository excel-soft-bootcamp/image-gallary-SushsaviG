using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gallery
{
    public class ImageGallery
    {
        IPicture _picture;
        public ImageGallery(IPicture picture)
        {
            this._picture = picture;
        }
        

        public void Share()
        {
            _picture.Send();

        }
    }
    public interface IPicture
        {
        void send();
        }
}

