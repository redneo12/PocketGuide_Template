using PocketGuide.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace PocketGuide.Helpers
{
    public class PocketGuideHelper
    {
        public static ObservableCollection<PocketGuideItem> Index { get; set; }

        static PocketGuideHelper()
        {
            Index = new ObservableCollection<PocketGuideItem>();

                       
            Index.Add(new PocketGuideItem
            {
                Id = 1,
                Title = "Introduction",
                TargetType = typeof(PocketGuide.PocketGuides.PageIntroduction),
            });

        }
    }
}
