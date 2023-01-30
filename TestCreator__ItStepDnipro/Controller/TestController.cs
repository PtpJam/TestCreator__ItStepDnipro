using System;
using TestCreator__ItStepDnipro.Model;

namespace TestCreator__ItStepDnipro.Controller
{
    public class TestController
    {
        public Test TestProperty { get; set; }
        public TestController(string testName)
        {
            if (string.IsNullOrEmpty(testName))
                testName = DateTime.Now.ToString().Replace(".", "_").Replace("/", "_");
            TestProperty = new Test(0, testName);
        }

        public void AddQueesiont(Question question)
        {
            question.Id = TestProperty.Questions.Count + 1;
            TestProperty.Questions.Add(question);
        }
        public Test getTest() => new Test(TestProperty.Name, TestProperty.Questions);
    }
}
