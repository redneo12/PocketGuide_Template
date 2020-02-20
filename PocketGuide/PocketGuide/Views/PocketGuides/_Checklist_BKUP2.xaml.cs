using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MvvmHelpers;
using PocketGuide.Models;
using PocketGuide.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;



namespace PocketGuide.PocketGuides
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Checklist : ContentPage
    {
        private ObservableCollection<ChecklistViewModel> _items;

        public ObservableCollection<ChecklistViewModel> Items
        {
            get { return _items; }
            set
            {
                _items = value;
                OnPropertyChanged();
            }
        }


        public Checklist()
        {
            InitializeComponent();

            BindingContext = new ChecklistViewModel();


        }

        //protected override async void OnAppearing()
        //{
        //    base.OnAppearing();
        //
        //    checkListview.ItemsSource = await App.Database.GetChecklistAsync();
        //}





        //void Handle_ItemTapped(object sender, ItemTappedEventArgs e) => ((ListView)sender).SelectedItem = null;

        private async void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {


            //Entry entrykNotes = new Entry();

            //Label dateLabel = new Label();








            var senderBox = (CheckBox)sender;
            var row = Grid.GetRow(senderBox);
            var grid = senderBox.Parent as Grid;
            var note = (Entry)grid.Children.Where(c => Grid.GetRow(c) == 1 && Grid.GetColumn(c) == 0).First();
            var date = (Label)grid.Children.Where(c => Grid.GetRow(c) == 1 && Grid.GetColumn(c) == 1).First();


            Console.WriteLine("Items: {0}, {1}", note.Text, date.Text);
            if (e.Value)
            {
                //var dataItem = (DataItem)BindingContext;
                DataItem dataItem = new DataItem();


                if (date.Text.Contains("1/1/0001"))
                {
                    date.Text = DateTime.Now.ToShortDateString();
                }
                if (string.IsNullOrEmpty(note.Text))
                {
                    //note.Text = App.Database.GetNoteAsync(dataItem.ID);
                    Console.WriteLine("note.Text" + App.Database.GetNoteAsync(dataItem.ID).ToString());
                }


            }
            else
            {

            }
            
        }

        private async void OnEntryCompleted(object sender, EventArgs e)
        {
            var senderBox = (Entry)sender;
            var row = Grid.GetRow(senderBox);
            var grid = senderBox.Parent as Grid;
            var note = (Entry)grid.Children.Where(c => Grid.GetRow(c) == 1 && Grid.GetColumn(c) == 0).First();
            var date = (Label)grid.Children.Where(c => Grid.GetRow(c) == 1 && Grid.GetColumn(c) == 1).First();
            DataItem dataItem = new DataItem();

            /**THIS IS FOR WHEN ENTRY COMPLEATED EVENT IS HIT**/
            dataItem.Notes = note.Text;
            dataItem.Date = Convert.ToDateTime(date.Text);
            await App.Database.SaveChecklist(dataItem);
            Console.WriteLine("~~~~~~~~ ROW PRESSED;" + dataItem.ToString());
        }
    }
}