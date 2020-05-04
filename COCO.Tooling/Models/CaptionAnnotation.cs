using System;
using System.Collections.Generic;
using System.Text;

namespace COCO.Tooling.Models
{
    public class CaptionAnnotation
    {
        public int image_id { get; set; }
        public int id { get; set; }
        public string caption { get; set; }
    }
}
