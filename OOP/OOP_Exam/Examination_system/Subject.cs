using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_system
{
    internal class Subject
    {
        public int SubId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject(int subId, string subName) 
        {
            SubId = subId;
            SubjectName = subName;
        }

        public void CreateExam(Exam exam) 
        {
            Exam = exam;
        }

        public override string ToString()
        {
            return $"Subject ID: {SubId}, Subject Name: {SubjectName}";
        }
    }
}
