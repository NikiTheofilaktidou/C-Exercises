using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            PhotoAlbum album = new PhotoAlbum();
            int a = album.GetNumberOfPages();
            PhotoAlbum album2 = new PhotoAlbum(24);
            int b = album2.GetNumberOfPages();
            BigPhotoAlbum bigAlbum1 = new BigPhotoAlbum();
            int c = bigAlbum1.GetNumberOfPages();

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
    class PhotoAlbum
    {
        private int numberOfPages;

        public PhotoAlbum()
        {
            numberOfPages = 16;
        }

        public PhotoAlbum(int numberOfPages)
        {
            this.numberOfPages = numberOfPages;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
    class BigPhotoAlbum
    {
        public int numberOfPages;

        public BigPhotoAlbum()
        {
            numberOfPages = 64;
        }
        public int GetNumberOfPages()
        {
            return numberOfPages;
        }
    }
}
