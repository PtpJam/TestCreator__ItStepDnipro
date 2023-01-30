using System;

namespace TestCreator__ItStepDnipro.Model
{
    [Serializable]
    public class Answer
    {
        public Answer(int id, string text, bool isCorrect)
        {
            Id = id;
            Text = text ?? throw new ArgumentNullException(nameof(text));
            IsCorrect = isCorrect;
        }
        public Answer()
        {

        }
        public int Id { get; set; }
        public string Text { get; set; }
        public bool IsCorrect { get; set; }


    }
}
