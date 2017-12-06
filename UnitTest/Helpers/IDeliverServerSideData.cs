using System;
using System.Threading.Tasks;

namespace UnitTest.Helpers
{
    public interface IDeliverServerSideData
    {
        Task<string> GetJsonData();
    }
}
