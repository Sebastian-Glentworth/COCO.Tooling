using COCO.Tooling.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace COCO.Tooling
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            await Run();
        }

        private static async Task Run()
        {
            var instancesVal2014Location = @"C:\Users\glentworths\Downloads\Telegram Desktop\instances_val2014.json";
            using (var fs = File.OpenRead(instancesVal2014Location))
            {
                var valData = await JsonSerializer.DeserializeAsync<InstancesVal2014>(fs);

                foreach (var item in valData.categories)
                {
                    Console.WriteLine(item);
                }
            }
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

            for (int i = 0; i < count; i++)
            {
                Random rnd = new Random();
                int index = rnd.Next(0, dataset.Count);

                randomImages.Add(dataset[index]);
            }

            return randomImages;
        }

        private string GetCaptionFromImage(FileInfo image, CaptionsVal2014 valData)
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