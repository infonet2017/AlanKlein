using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoAlbumTarea
{
    class AlbumTest
    {
        static void Main(string[] args)
        {
            PhotoAlbum SmallAlbum = new PhotoAlbum();
            PhotoAlbum MediumAlbum = new PhotoAlbum(24);
            BigPhotoAlbum BigAlbum = new BigPhotoAlbum();

            Console.WriteLine("Album n° 1: " + SmallAlbum.GetNumbersOfPages() + " pages");
            Console.WriteLine("Album n° 2: " + MediumAlbum.GetNumbersOfPages() + " pages");
            Console.WriteLine("Album n° 3: " + BigAlbum.GetNumbersOfPages() + " pages");

            Console.ReadLine();
        }
    }
}
