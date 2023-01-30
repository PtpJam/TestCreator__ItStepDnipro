using Newtonsoft.Json;
using TestCreator__ItStepDnipro.Model;

namespace TestCreator__ItStepDnipro.Adapters
{
    internal class TestToJsonAdapter : ITestAdapter
    {
        public string Generate(Test test) => JsonConvert.SerializeObject(test);
    }
}
