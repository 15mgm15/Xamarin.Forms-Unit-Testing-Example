using Xamarin.Forms;

namespace UnitTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new UnitTestPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
