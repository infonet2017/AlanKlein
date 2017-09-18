using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class PhotoAlbum
    {
        private int[] album { get; set; }
        private int numberOfPages { get; set; }

        public PhotoAlbum() : this(0)  // constructor
        {
            this.numberOfPages = 16;
        }

        public PhotoAlbum(int r)  // constructor
        {
            this.numberOfPages = r;
        }

        public int GetNumbersOfPages()
        {
            return this.numberOfPages;
        }

    }
}
