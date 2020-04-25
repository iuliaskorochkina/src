using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StudentSkorochkina
{
    public class Student 
    {
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
            Console.WriteLine("Введете размер массива: \n");
            size = Convert.ToInt32(Console.ReadLine());
            Student[] percon = new Student[size];
            Console.WriteLine("Введите группу: ");
            

        }
    }
}
