using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MasterDetailStudy
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
            NavigationPage.PushAsync(new ContentPageA(this));
        }

        private void NavigatePageA_OnClicked(object sender, EventArgs e)
        {
            IsPresented = false;
            if (!(NavigationPage.CurrentPage is ContentPageA))
            {
                NavigationPage.Navigation.PushAsync(new ContentPageA(this));
            }
        }

        private void NavigatePageB_OnClicked(object sender, EventArgs e)
        {
            IsPresented = false;
            if (!(NavigationPage.CurrentPage is ContentPageB1))
            {
                NavigationPage.Navigation.PushAsync(new ContentPageB1(this));
            }
        }
    }

}
