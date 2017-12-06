using System;
using System.Threading.Tasks;
using UnitTest.Helpers;
using Xamarin.Forms;

namespace UnitTest
{
    public class UnitTestViewModel
    {
        public Command LoadDataCommand { get; set; }
        public string Data { get; set; }
        IDependencyService DependencyService { get; set; }

        public UnitTestViewModel() : this(new DependencyServiceWrapper())
        {
        }

        public UnitTestViewModel(IDependencyService dependencyService)
        {
            DependencyService = dependencyService;
            LoadDataCommand = new Command(async () => await LoadData());
        }

        public async Task LoadData()
        {
            var service = DependencyService.Get<IDeliverServerSideData>();

            if(service == null)
            {
                return;
            }

            Data = await service?.GetJsonData();
        }
    }

    //Non Unit testable.

    //public class UnitTestViewModel
    //{
    //    public Command LoadDataCommand { get; set; }
    //    public string Data { get; set; }
        
    //    public UnitTestViewModel()
    //    {
    //        LoadDataCommand = new Command(async () => await LoadData());
    //    }

    //    public async Task LoadData()
    //    {
    //        Data = await DependencyService.Get<IDeliverServerSideData>().GetJsonData();
    //    }
    //}
}
