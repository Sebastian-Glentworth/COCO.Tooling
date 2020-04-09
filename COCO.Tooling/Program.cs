using System;
using System.Collections.Generic;
using System.IO;

namespace COCO.Tooling
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program();
        }

        private Program()
        {

        }

        private List<FileInfo> LoadImagesIntoList(string location)
        {
            var directoryInfo = new DirectoryInfo(location);
            var files = directoryInfo.GetFiles("*.jpg");

            return new List<FileInfo>(files);
        }

        private List<FileInfo> SelectRandomImages(List<FileInfo> dataset, int count)
        {
            var randomImages = new List<FileInfo>();

            for(int i = 0; i < count; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, dataset.Count);

                randomImages.Add(dataset[index]);
            }

            return randomImages;
        }

        private string GetCaptionFromImage(FileInfo image, string JsonFileLocation)
        {


            return string.Empty;
        }
    }
}
