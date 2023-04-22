using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace Snake
{
    public static class Images
    //public meaning it can be accessed from anywhere, static meaning you dont have to
    //create a new one every time you want to use it
    /*
     a public static class in C# is like a big box of tools that you can share with your 
    friends, and you don't need to unpack and repack it every time you want to use it.
     */
    {
        public readonly static ImageSource Empty = LoadImage("Empty.png");
        public readonly static ImageSource Body = LoadImage("Body.png");
        public readonly static ImageSource Head = LoadImage("Head.png");
        public readonly static ImageSource Food = LoadImage("Food.png");
        public readonly static ImageSource DeadBody = LoadImage("DeadBody.png");
        public readonly static ImageSource DeadHead = LoadImage("DeadHead.png");





        private static ImageSource LoadImage(string fileName)
        {
            return new BitmapImage(new Uri($"Assests/{fileName}", UriKind.Relative));
        }
    }
}
