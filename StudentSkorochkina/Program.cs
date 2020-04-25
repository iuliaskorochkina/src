using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace StudentSkorochkina
{
    public class Student
    {
        public Student()
        {
        }
        private string group;
        private string surname;
        private string name;

        public string Group
        {
            get { return this.group; }
            set { this.group = value; }
        }
        public string Surname
        {
            get { return this.surname; }
            set { this.surname = value; }
        }
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            string Conclusion;

            Console.WriteLine("Введете размер массива: \n");
            size = Convert.ToInt32(Console.ReadLine());
            Student[] Students = new Student[size];
            for (int i = 0; i < size; i++)
            {
                Students[i] = new Student();
                Console.WriteLine("Введите фамилия: \n");
                Students[i].Surname = Console.ReadLine();
                Console.WriteLine("Введите имя: \n");
                Students[i].Name = Console.ReadLine();
                Console.WriteLine("Введите группу: \n");
                Students[i].Group = Console.ReadLine();
            }
            Console.WriteLine("Хотите ли вывести массив?(Да) \n");
            Conclusion = Console.ReadLine();

            if (Conclusion == "Да")
            {
                foreach (var a in (Students))
                {
                    Console.WriteLine("Фамилия: " + a.Surname + " Имя: " + a.Name + "Группа: " + a.Group);
                }
            }
            Sort(Students);
            Console.WriteLine("Массив сохранен в файл Save. \n");
            WritingToFile(Students);
            Console.ReadKey();
        }


        public static void WritingToFile(Student[] students)
        {
            using (StreamWriter writer = new StreamWriter("save.txt"))
            {
                foreach (var s in students)
                {
                    writer.WriteLine("Группа: " + s.Group + " Фамилия: " + s.Surname + " Имя: " + s.Name);
                }
            }
        }
        public static void Sort(Student[] students)
        {
            students = students.OrderByDescending(s => s.Group).ThenByDescending(s => s.Surname).ThenByDescending(s => s.Name).ToArray();
        }
    }
}
