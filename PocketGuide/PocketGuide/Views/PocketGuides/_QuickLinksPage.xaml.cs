using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PocketGuide.PocketGuides
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class QuickLinksPage : ContentPage
    {
        public QuickLinksPage()
        {
            InitializeComponent();

        }



        //Generic Buttons Events
        async void Open_Glossary(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PocketGuides.Glossary());
            //await Navigation.PushAsync((Page)Scripts.GetCreatedInstance("Glossary"));
        }

        async void Open_Checklist(object sender, EventArgs e)
        {
            //await Navigation.PushAsync((Page)Scripts.GetCreatedInstance("Checklist"));
            await Navigation.PushAsync(new PocketGuides.Checklist());
        }


        async void Open_Notes(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new PocketGuides.NotesPage());
        }
    }



}