using System;
using System.Collections.Generic;
using System.Text;

namespace PocketGuide.Models
{
    public class PocketGuideItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Type TargetType { get; set; }

    }
}
