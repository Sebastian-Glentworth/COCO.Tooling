using System;
using System.Collections.Generic;
using System.Text;

namespace COCO.Tooling.Models
{
    public class Image
    {
        public long license { get; set; }
        public string file_name { get; set; }
        public string coco_url { get; set; }
        public long height { get; set; }
        public long width { get; set; }
        public string data_captured { get; set; }
        public string flickr_url { get; set; }
        public long id { get; set; }
    }
}
