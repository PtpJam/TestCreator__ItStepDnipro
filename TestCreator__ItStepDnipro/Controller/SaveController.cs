using System.IO;
using TestCreator__ItStepDnipro.Adapters;
using TestCreator__ItStepDnipro.Model;

namespace TestCreator__ItStepDnipro.Controller
{
    public class SaveController
    {
        public void Save(Test test, ITestAdapter adapter)
        {

            File.WriteAllText($"{test.Name}.txt", adapter.Generate(test));
        }
    }
}
