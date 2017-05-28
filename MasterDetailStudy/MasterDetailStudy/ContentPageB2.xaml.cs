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
    public partial class ContentPageB2 : ContentPage
    {
        private MasterDetailPage _masterDetailPage;
        public ContentPageB2(MasterDetailPage masterDetailPage)
        {
            _masterDetailPage = masterDetailPage;
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
        private void OpenDrawer_OnClicked(object sender, EventArgs e)
        {
            _masterDetailPage.IsPresented = true;
        }
    }
}
