using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class Question
    {
        public String Header { get; set; }
        public String Body { get; set; }
        public int Mark { get; set; }
        public Answer[] AnswerList { get; set; }
        public Answer RightAnswer { get; set; }



        protected Question(string header, string body, int mark, Answer[] answerList, Answer rightAnswer) 
        {
            Header = header;
            Body = body;
            Mark = mark;
            AnswerList = answerList;
            RightAnswer = rightAnswer;

        }

        public abstract void DisplayQuestion();

    }
}
