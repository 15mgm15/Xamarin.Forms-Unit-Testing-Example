using NUnit.Framework;
using System;
using Xamarin.Forms.Mocks;
using Xamarin.Forms;
using UnitTest;
using Moq;
using UnitTest.Helpers;

namespace UTest
{
    [TestFixture]
    public class Test
    {
        DependencyServiceStub DependencyService { get; set; }
        Mock<IDeliverServerSideData> ServerSideDataMock { get; set; }
        
        [SetUp]
        public void SetUp()
        {
            MockForms.Init();

            DependencyService = new DependencyServiceStub();

            ServerSideDataMock = new Mock<IDeliverServerSideData>();
            DependencyService.Register<IDeliverServerSideData>(ServerSideDataMock.Object);
        }
        
        [Test]
        public void TestCase()
        {
            var testVm = new UnitTestViewModel(DependencyService);

            ServerSideDataMock.Setup(m => m.GetJsonData()).ReturnsAsync(" ");

            testVm.LoadDataCommand.Execute(null);

            ServerSideDataMock.Verify(m => m.GetJsonData(), Times.Once());

            Assert.IsNotNull(testVm.Data);
        }
    }
}
