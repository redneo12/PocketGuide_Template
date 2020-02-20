using MvvmHelpers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;
using PocketGuide.Models;

namespace PocketGuide.Helpers
{

    public class ChecklistItemHelper
    {
        public static ObservableCollection<Grouping<string, ChecklistItem>> ChecklistItemGrouped { get; set; }

        public static ObservableCollection<ChecklistItem> ChecklistItem { get; set; }

        static ChecklistItemHelper()
        {
            ChecklistItem = new ObservableCollection<ChecklistItem>();


            ChecklistItem.Add(new ChecklistItem
            {
                
                Item = "The hazardous product has a supplier label.",
                Section = "",
                IsChecked = false
            });



            var sorted = from s in ChecklistItem
                         orderby s.ID
                         group s by s.Section into sGroup
                         select new Grouping<string, ChecklistItem>(sGroup.Key, sGroup);

            
            ChecklistItemGrouped = new ObservableCollection<Grouping<string, ChecklistItem>>(sorted);
        }
    }
}
