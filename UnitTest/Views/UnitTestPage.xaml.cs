using Xamarin.Forms;

namespace UnitTest
{
    public partial class UnitTestPage : ContentPage
    {
        public UnitTestPage()
        {
            InitializeComponent();
            BindingContext = new UnitTestViewModel();
        }
    }
}
