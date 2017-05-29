using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MasterDetailStudy
{
    public partial class NavigationView : ContentView
    {
        public static readonly BindableProperty EventNameProperty =
            BindableProperty.Create("Text", typeof(string), typeof(NavigationView), null);

        public string Text
        {
            get => (string) GetValue(EventNameProperty);
            set => SetValue(EventNameProperty, value);
        }

        public event EventHandler<EventArgs> Clicked;
        public NavigationView()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Clicked?.Invoke(sender, e);
        }
    }
}