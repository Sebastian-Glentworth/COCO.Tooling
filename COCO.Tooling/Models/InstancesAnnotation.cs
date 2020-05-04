using System;
using System.Collections.Generic;
using System.Text;

namespace COCO.Tooling.Models
{
    public class InstancesAnnotation
    {
        public double[] segmentations { get; set; }
        public double area { get; set; }
        public long iscrowd { get; set; }
        public long image_id { get; set; }
        public double[] bbox { get; set; }
        public long category_id { get; set; }
        public long id { get; set; }
    }
}
