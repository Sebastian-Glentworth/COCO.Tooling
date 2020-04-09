using System;
using System.Collections.Generic;
using System.Text;

namespace COCO.Tooling.Models
{
    public class val2014
    {
       public List<Info> info { get; set; }
       public List<Image> images { get; set; }
       public List<License> licenses { get; set; }
       public List<Annotation> annotations { get; set; }
    }

    public class Info 
    {
        public string description { get; set; }
        public string url { get; set; }
        public string version { get; set; }
        public int year { get; set; }
        public string contributor { get; set; }
        public string date_created { get; set; }
        
    }
    public class Image 
    {
        public int license { get; set; }
        public string file_name { get; set; }
        public string coco_url { get; set; }
        public int height { get; set; }
        public int width { get; set; }
        public string data_captured { get; set; }
        public string flickr_url { get; set; }
        public int id { get; set; }
    }
    public class License 
    {
        public string url { get; set; }
        public int id { get; set; }
        public string name { get; set; }
    }
    public class Annotation 
    {
        public string image_id { get; set; }
        public int id { get; set; }
        public string caption { get; set; }
    }
}
