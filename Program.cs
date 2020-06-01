using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class Student
    {
        protected readonly string studentName;
        protected readonly int presence;

        public Student(string studentName, int presence)
        {
            this.studentName = studentName;
            this.presence = presence; 
        }

        public void PrintStudentStatistic()
        {
            Console.WriteLine($"{studentName} was on {presence} lessons.");
        }

        public abstract bool PassExam();

    }

    class Simple : Student
    {
        public Simple(string studentName, int presence) : base (studentName, presence)
        {
        }

        public override bool PassExam()
        {
            Random rnd = new Random();
            int possibilitty = rnd.Next(1, 10);

            if (presence >= 20)
            {
                return true;
            }
            else if (presence >= 10 && possibilitty >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Smart : Student
    {
        public Smart(string studentName, int presence) : base(studentName, presence)
        {
        }

        public override bool PassExam()
        {
            Random rnd = new Random();
            int possibilitty = rnd.Next(1, 10);

            if (presence >= 20)
            {
                return true;
            }
            else if(presence >= 10 && possibilitty >= 3)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Genius : Student
    {
        public Genius(string studentName, int presence) : base(studentName, presence)
        {
        }

        public override bool PassExam()
        {

            if (presence >= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student[] students = new Student[10];
            students[0] = new Simple("Жуков Василий Серапионович", 20);
            students[1] = new Simple("Евдокимов Алексей Германнович", 4);
            students[2] = new Simple("Суворов Вилен Никитевич", 19);
            students[3] = new Simple("Наумов Лука Александрович", 7);
            students[4] = new Simple("Шестаков Григорий Георгиевич", 12);
            students[5] = new Smart("Мельников Аркадий Глебович", 17);
            students[6] = new Smart("Степанов Тимофей Мартынович", 20);
            students[7] = new Smart("Беспалов Лавр Валентинович", 14);
            students[8] = new Smart("Давыдов Валерий Геннадьевич", 7);
            students[9] = new Genius("Зиновьев Аскольд Геласьевич", 20);

            for (int i = 0; i < students.Length; i++)
            {
                students[i].PrintStudentStatistic();
                if (students[i].PassExam())
                {
                    Console.WriteLine("He passed the exam!");
                }
                else
                {
                    Console.WriteLine("He didn't pass the exam!");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
