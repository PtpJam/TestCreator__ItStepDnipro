using System;
using System.Linq;
using System.Text;
using TestCreator__ItStepDnipro.Model;

namespace TestCreator__ItStepDnipro.Adapters
{
    internal class TestToTxtAdapter : ITestAdapter
    {
        public string Generate(Test test)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var item in test.Questions)
            {
                stringBuilder.AppendLine(item.Id.ToString());
                stringBuilder.AppendLine(item.Text);
                stringBuilder.AppendLine();
                for (int i = 0; i < item.Answers.Count; i++)
                {
                    stringBuilder.AppendLine($"{i + 1}. {item.Answers[i].Text}");
                }
                stringBuilder.AppendLine();
                stringBuilder.AppendLine($"Correct:\t {String.Join(",", item.Answers.Where(x => x.IsCorrect.Equals(true)).Select(g => g.Id).ToList())}");
                stringBuilder.AppendLine();
                stringBuilder.AppendLine();

            }
            return stringBuilder.ToString();
        }
    }
}
