using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinList
{
    public partial class MainPage : ContentPage
    {
        string[] monkeys = new string[] { "Tamarins", "Capuchins", "Squirrel Monkeys", "Spider Monkeys" };
        public MainPage()
        {
            InitializeComponent();
            List<MonkeyList> monkeyLists = new List<MonkeyList>();
            foreach (var monkey in monkeys)
            {
                MonkeyList monkeyList = new MonkeyList() { Name= monkey };
                monkeyLists.Add(monkeyList);
            }
            lstMonkeys.ItemsSource = monkeyLists;
        }

        public void OnEdit(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Edit", mi.CommandParameter.ToString(), "OK");
        }

        public void OnDelete(object sender, EventArgs e)
        {
            var mi = ((MenuItem)sender);
            DisplayAlert("Delete", mi.CommandParameter.ToString(), "OK");
        }
    }
}
