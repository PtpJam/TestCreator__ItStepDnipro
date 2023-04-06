using System.IO;
using TestCreator__ItStepDnipro.Adapters;
using TestCreator__ItStepDnipro.Model;

namespace TestCreator__ItStepDnipro.Controller
{
    public class SaveController
    {
        public void Save(Test test, ITestAdapter adapter)
        {
            //deelete on next versionn
            test.Name = test.Name.Replace(':', '_').Replace('.','_');
            File.WriteAllText($"{test.Name}.txt", adapter.Generate(test));
        }
    }
}
