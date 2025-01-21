using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        public List<Question> Questions { get; set; } = new List<Question>();

        protected Exam(int time, int questionsNumber)
        {
            Time = time;
            NumOfQuestions = questionsNumber; 
        }

        public abstract void ShowExam();
        public  void AddQuestion(Question question)
        {
            Questions.Add(question); 
        }

       


    }
}
