using MvvmHelpers;
using PocketGuide.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Linq;


//https://github.com/jamesmontemagno/Xamarin.Forms-Monkeys

namespace PocketGuide.Helpers
{
    public static class GlossaryHelper
    {
        public static ObservableCollection<Grouping<string, GlossaryItem>> GlossaryGrouped { get; set; }

        public static ObservableCollection<GlossaryItem> Glossary { get; set; }

        static GlossaryHelper()
        {
            Glossary = new ObservableCollection<GlossaryItem>();
            //Replace("\n" with "&#x0a;")


            //**Dictionary**//
            Glossary.Add(new GlossaryItem
            {
                Element = "Act",
                Definition = "Means the Hazardous Products Act.",
            });



            
        }
    }
}
