using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int questionsNumber) : base(time, questionsNumber)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam:\n");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.WriteLine($"Correct Answer: {question.RightAnswer.AnswerText}\n");
            }
            Console.WriteLine("End of Exam\n");
        }
    }
}
