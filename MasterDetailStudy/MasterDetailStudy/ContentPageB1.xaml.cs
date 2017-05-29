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
    public partial class ContentPageB1 : ContentPage
    {
        private MasterDetailPage _masterDetailPage;
        public ContentPageB1(MasterDetailPage masterDetailPage)
        {
            _masterDetailPage = masterDetailPage;
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ContentPageB2(_masterDetailPage));
        }

        private void OnClickedOpenDrawer(object sender, EventArgs e)
        {
            _masterDetailPage.IsPresented = true;
        }
    }
}
