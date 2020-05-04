using System;
using System.Collections.Generic;
using System.Text;

namespace COCO.Tooling.Models
{
    public class Category
    {
        public string supercategory { get; set; }
        public long id { get; set; }
        public string name { get; set; }

        public override string ToString()
        {
            return $"id: {id}\nsupercategory: {supercategory}\nname: {name}\n";
        }
    }
}