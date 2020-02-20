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

using System.ComponentModel;
namespace PocketGuide.PocketGuides
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Checklist_BKUP : ContentPage
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



        public Checklist_BKUP()
        {

            InitializeComponent();

            BindingContext = new ChecklistViewModel();



        }

        //void Handle_ItemTapped(object sender, ItemTappedEventArgs e) => ((ListView)sender).SelectedItem = null;

        private void OnCheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            //var senderBox = (CheckBox)sender;
            //var row = Grid.GetRow(senderBox);
            //var grid = senderBox.Parent as Grid;
            //
            //var date = grid.Children.Where(c => Grid.GetRow(c) == 1 && Grid.GetColumn(c) == 1);

            //var x = (ChecklistModel)sender;



        }
    }
}