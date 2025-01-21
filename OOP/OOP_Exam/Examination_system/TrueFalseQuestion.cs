using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int mark, Answer[] answerList, Answer rightAnswer) : base(header, body, mark, answerList, rightAnswer)
        {
        }

        public override void DisplayQuestion()
        {
            Console.WriteLine($"{Header}\n{Body} (Mark: {Mark})\n");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.AnswerId}. {answer.AnswerText}");
            }
        }
    }
}
