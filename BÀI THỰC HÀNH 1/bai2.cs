using System;
using System.Collections.Generic;
using System.Text;

namespace bai2
{
    class Employee
    {
        private int id;
        private string name;
        private int YearOfBirth;
        private double salaryLevel;
        private double basicSalary;
        public double setSalaryLevel
        {
            get
            {
                return salaryLevel;
            }
            set
            {
                salaryLevel = value;
            }
        }
        public double setBasicSalary
        {
            get
            {
                return basicSalary;
            }
            set
            {
                basicSalary = value;
            }
        }
        public int getId()
        {
            return id;
        }
        public string getName()
        {
            return name;
        }
        public int getYearOfBirth()
        {
            return YearOfBirth;
        }
        public double getIncome()
        {
            return salaryLevel * basicSalary;
        }
        public void display()
        {
            Console.WriteLine("Thong thin ve nguoi lao dong:");
            Console.Write("Dinh danh", id, "Ten", name, "Nam sinh", YearOfBirth, "Luong co ban", basicSalary, "Thu nhap", getIncome());
        }

    }

    class APP
    {
         static void Main(string[] args)
         {
             Employee e = new Employee();
             e.display();
             Console.ReadKey();
         }
    }   
}