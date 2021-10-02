using System;

enum Menu
{
    RegisterNewStudent = 1, RegisterNeEmployee = 2,GetListPersons
}

namespace MT2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintMenuScreen();
        }

        static void PrintMenuScreen()
        {
            Console.Clear();
            PrintHeader();
            PrintListMenu();
            InputMenuFromKeyboard();
        }
        static void PrintHeader()
        {
            Console.WriteLine("Welcome to Digital Library");
            Console.WriteLine("--------------------------");
        }

        static void PrintListMenu()
        {
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("Select Menu:");
        }
        static void InputMenuFromKeyboard()
        {
            Console.WriteLine("Please Select Menu");
            Menu menu = (Menu)(int.Parse(Console.ReadLine()));

            PresentMenu(menu);
        }

        static void PresentMenu(Menu menu)
        {
            if (menu == Menu.RegisterNewStudent) 
            {
                ShowInputRegisterNewStudentScreen();
            } 
            else
            {
                ShowMessageInputMenuIsInCorrect();
            }
        }
        static void ShowInputRegisterNewStudentScreen()
        {
            Console.Clear();
            PrintheaderRegisterStudent();
        }
        static void ShowMessageInputMenuIsInCorrect()
        {
            Console.WriteLine("Register new student.");
            Console.WriteLine("---------------------");
        }

        static void PrintheaderRegisterStudent()
        {
           
           
        }

    }
    class Person
    {
        protected string name;
        protected string address;
        protected string citizenID;

        public Person(string name,string address,string citizenID)
        {
            this.name = name;
            this.address = address;
            this.citizenID = citizenID;
        }

        public string GetName()
        {
            return this.name;
        }
    }

    class Student : Person
    {
        private string studentID;

        public Student(string name, string address, string citizenID, string studentID): base(name, address, citizenID)
        {
            this.studentID = studentID;
        }
    }
  


}
