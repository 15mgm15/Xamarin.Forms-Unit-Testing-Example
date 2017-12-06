using System;
using System.Threading.Tasks;
using UnitTest.Helpers;
using Xamarin.Forms;

[assembly: Dependency(typeof(DeliverServerSideData))]
namespace UnitTest.Helpers
{
    public class DeliverServerSideData : IDeliverServerSideData
    {
        public DeliverServerSideData()
        {
        }

        public async Task<string> GetJsonData()
        {
            await Task.Delay(2000);
            return "test";
        }
    }
}
