using System;
using System.Collections.Generic;

namespace TestCreator__ItStepDnipro.Model
{
    [Serializable]
    public class Question
    {
        public Question(int id, string text)
        {
            Id = id;
            Text = text ?? throw new ArgumentNullException(nameof(text));
        }
        public Question()
        {

        }
        public int Id { get; set; }
        public string Text { get; set; }
        public List<Answer> Answers { get; set; } = new List<Answer>(4);
    }
}
