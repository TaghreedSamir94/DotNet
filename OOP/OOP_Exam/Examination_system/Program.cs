using System.Diagnostics;

namespace Examination_system
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=========================================================================");
            Console.WriteLine("***************** Welcome to the Examination System *********************");
            Console.WriteLine("=========================================================================\n");

            Console.WriteLine(" Please Enter type of exam (1 for Practical | 2 for Final): ");
            int examType = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter time for the exam (in minutes from 30 to 180): ");
            int examTime = int.Parse(Console.ReadLine());

            Console.WriteLine("Please Enter number of questions: ");
            int numOfQuestions = int.Parse(Console.ReadLine());


            Console.Clear();
            //if (examType == 1)
            //{
            //    Exam exam = new PracticalExam(examTime, numOfQuestions);
            //}
            //else
            //{
            //    Exam exam = new FinalExam(examTime, numOfQuestions);
            //}

            Exam exam = examType == 1 ? new PracticalExam(examTime, numOfQuestions) : new FinalExam(examTime, numOfQuestions);

            for (int i = 0; i < numOfQuestions; i++)
            {
                Console.WriteLine($"\nQuestion {i + 1}:");
                int questionType;

                if (examType != 1)
                {
                    Console.Write("Enter type of question (1 for MCQ, 2 for True|False): ");
                    questionType = int.Parse(Console.ReadLine());

                }
                else
                {
                    questionType = 1;
                }

                Console.Clear();


                Console.WriteLine($"=== {(questionType == 1 ? "MCQ" : "True | False")} Question ===");

                Console.WriteLine("Please Enter Question Body: ");
                string questionBody = Console.ReadLine();

                Console.WriteLine("Please Enter marks for the question: ");
                int questionMarks = int.Parse(Console.ReadLine());


                Question question;

                if (questionType == 1)
                {
                    String questionHeader = "MCQ Question";
                    Console.WriteLine("Choices of Question");
                    //Console.WriteLine("Enter number of choices: ");
                    //int numChoices = int.Parse(Console.ReadLine());
                    Answer[] choices = new Answer[3];

                    for (int j = 0; j < 3; j++)
                    {
                        Console.WriteLine($"Enter Choice Number {j + 1}: ");
                        choices[j] = new Answer(j + 1, Console.ReadLine());
                    }


                    Console.Write("Enter the correct answer ID: ");
                    int correctAnswerId = int.Parse(Console.ReadLine());

                    question = new MCQQuestion($"{questionHeader} Number {i + 1}",  questionBody, questionMarks, choices, choices[correctAnswerId - 1]);
                }
                else 
                {

                    String questionHeader = "True | False Question";
                    var tfAnswers = new Answer[]
                    {
                    new Answer(1, "True"),
                    new Answer(2, "False")
                    };

                    Console.Write("Enter the correct answer ID (1 for True, 2 for False): ");
                    int correctAnswerId = int.Parse(Console.ReadLine());

                    question = new TrueFalseQuestion($"{questionHeader} Number {i + 1}", questionBody, questionMarks, tfAnswers, tfAnswers[correctAnswerId - 1]);
                }

              
                exam.AddQuestion(question);

                Console.Clear();
            }

            //=====================================================
            Console.Write("\nDo you want to start the exam? (y/n): ");
            char status = char.Parse(Console.ReadLine().ToLower());
            Console.Clear(); 

            if (status == 'y')
            {
                var userAnswers = new List<int>();
                Stopwatch stopwatch = Stopwatch.StartNew();

                int totalPossibleMarks = 0; 
                int totalScore = 0; 

                foreach (var question in exam.Questions)
                {
                    question.DisplayQuestion();
                    Console.Write("Enter your answer ID: ");
                    Console.WriteLine();
                    int userAnswerId = int.Parse(Console.ReadLine());
                    userAnswers.Add(userAnswerId);

                    totalPossibleMarks += question.Mark; 

                    if (question.AnswerList[userAnswerId - 1] == question.RightAnswer)
                    {
                        totalScore += question.Mark; 
                    }
                }

                stopwatch.Stop(); 

                Console.Clear();


                //=====================================================
                Console.WriteLine("Exam Results");
                Console.WriteLine("======================");

                for (int i = 0; i < exam.Questions.Count; i++)
                {
                    var question = exam.Questions[i];
                    Console.WriteLine($"Question {i + 1}: {question.Body}\nYour Answer: {question.AnswerList[userAnswers[i] - 1].AnswerText}\nCorrect Answer: {question.RightAnswer.AnswerText}\n");
                    Console.WriteLine(" ");
                }

                Console.WriteLine($"Your total grade is: {totalScore} from {totalPossibleMarks}\n");

                Console.WriteLine($"Exam time: {exam.Time} minutes\n");

                Console.WriteLine($"Time taken to answer: {stopwatch.Elapsed:hh\\:mm\\:ss\\.fff}\n\n");

                Console.WriteLine("Tank You :)");
            }
            else
            {
                Console.WriteLine("Exam canceled.");
            }




        }
    }
}
