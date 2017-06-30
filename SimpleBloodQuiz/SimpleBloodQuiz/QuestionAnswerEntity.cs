namespace SimpleBloodQuiz
{
    public class QuestionAnswerEntity
    {
        public string Question { get; set; }

        public string[] AnswersList { get; set; }

        public string  Answer { get; set; } // proper answer
    }
}