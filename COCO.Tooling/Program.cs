using COCO.Tooling.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

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
            var imageLocation = @"";
            var valLocation = @"";
            var outputLocation = @"";

            var images = LoadImagesIntoList(imageLocation);

            var json = File.ReadAllText(valLocation);
            var valData = JsonConvert.DeserializeObject<val2014>(json);


            
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

        private string GetCaptionFromImage(FileInfo image, val2014 valData)
        {
            var fileName = image.Name;
            var id = valData.images.Single(s => s.file_name == fileName).id;
            return valData.annotations.First(s => s.image_id == id).caption;
        }

        private void CopyFilesToNewLocation(List<FileInfo> filesToCopy, string newLocation)
        {
            foreach (var file in filesToCopy)
            {
                file.CopyTo($@"{newLocation}/{file.Name}");
            }
        }
    }
}
