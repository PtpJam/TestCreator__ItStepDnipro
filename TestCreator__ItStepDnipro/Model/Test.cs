using System;
using System.Collections.Generic;
namespace TestCreator__ItStepDnipro.Model
{
    [Serializable]
    public class Test
    {
        public Test()
        {
            Questions = new List<Question>();
        }
        public Test(int id, string name) : this()
        {
            Id = id;
            Name = name ?? throw new ArgumentNullException(nameof(name));
        }
        public Test(string name, List<Question> questions)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Questions = questions ?? throw new ArgumentNullException(nameof(Questions));
        }

        public int Id { get; set; }
        public string Autor { get; set; }
        public string Name { get; set; }

        public List<Question> Questions { get; set; }

    }
}
