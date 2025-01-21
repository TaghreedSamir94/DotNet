using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int questionsNumber) : base(time, questionsNumber)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam:\n");
            foreach (var question in Questions)
            {
                question.DisplayQuestion();
                Console.WriteLine();
            }
            Console.WriteLine("End of Exam\n");

        }
    }
}
