using System;

namespace UdemyExercise
{
    class ImageOrientation
    {
        static void Main(string[] args)
        {
            int width = Convert.ToInt32(Console.ReadLine());
            int height = Convert.ToInt32(Console.ReadLine());
            if ((width / height) < 1)
                Console.WriteLine("Image Is portrait");
            if ((width / height) > 1)
                Console.WriteLine("Image Is Landscape");
            if ((float)(width / height) == 1)
                Console.WriteLine("Image Is Sqaure");
        }
    }
}
