using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class BigPhotoAlbum
    {

        private int[] album { get; set; }
        private int numberOfPages { get; set; }

        public BigPhotoAlbum() : this(0)  // constructor
        {
            this.numberOfPages = 64;
        }

        public BigPhotoAlbum(int r)  // constructor
        {
            this.numberOfPages = r;
        }

        public int GetNumbersOfPages()
        {
            return this.numberOfPages;
        }

    }
}
