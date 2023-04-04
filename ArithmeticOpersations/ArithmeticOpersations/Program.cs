//using System;
//using System.Collections.Generic;
//using System.Diagnostics.Eventing.Reader;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace ArithmeticOpersations
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            while (true)
//            {
//                Console.WriteLine("Enter 1 for addition: ");
//                Console.WriteLine("Enter 2 for subtraction: ");
//                Console.WriteLine("Enter 3 for multiplication: ");
//                Console.WriteLine("Enter 4 for division: ");
//                Console.WriteLine("Enter 5 for exit: ");
//                int choice = int.Parse(Console.ReadLine());
//                switch (choice)
//                {
//                    case 1:
//                        Console.WriteLine("enter first number: ");
//                        string num1 = Console.ReadLine();
//                        Console.WriteLine("enter second number: ");
//                        string num2 = Console.ReadLine();
//                        bool check = int.TryParse(num1, out int result);
//                        bool check1 = int.TryParse(num2, out int age);


//                        if (check == false || check1 == false)
//                        {
//                            Console.WriteLine("Please enter  valid number");
//                        }
//                        else if (int.Parse(num1) ==00 || int.Parse(num2)== 0)
//                        {
//                            Console.WriteLine("at least one number should be greater than zero");

//                        }

//                        else if (int.Parse(num1) < 0 && int.Parse(num2) < 0)
//                        {
//                            Console.WriteLine("please enter positive number");
//                        }
//                        else
//                        {
//                            int sum = int.Parse(num1) + int.Parse(num2);
//                            Console.WriteLine("reqired sum is " + sum);
//                        }
//                        break;
//                    case 2:
//                        Console.WriteLine("enter first number: ");
//                        string a = Console.ReadLine();
//                        Console.WriteLine("enter second number: ");
//                        string b = Console.ReadLine();
//                        bool check2 = int.TryParse(a, out int result1);
//                        bool check3 = int.TryParse(b, out int age1);


//                        if (check2 == false || check3 == false)
//                        {
//                            Console.WriteLine("Please enter valid number");
//                        }
//                        else if (int.Parse(a) < 0 || int.Parse(b) < 0)
//                        {
//                            Console.WriteLine("at least one number should be greater than zero");

//                        }

//                        else if (int.Parse(a) < 0 && int.Parse(b) < 0)
//                        {
//                            Console.WriteLine("please enter positive number");
//                        }
//                        else
//                        {
//                            int sub = int.Parse(a) - int.Parse(b);
//                            Console.WriteLine("reqired sum is " + sub);
//                        }
//                        break;
//                    case 3:
//                        Console.WriteLine("enter first number: ");
//                        string c = Console.ReadLine();
//                        Console.WriteLine("enter second number: ");
//                        string d = Console.ReadLine();
//                        bool check4 = int.TryParse(c, out int result2);
//                        bool check5 = int.TryParse(d, out int age2);


//                        if (check4 == false || check5 == false)
//                        {
//                            Console.WriteLine("Please enter valid number");
//                        }
//                        else if (int.Parse(c) == 0 || int.Parse(d)== 0)
//                        {
//                            Console.WriteLine("at least one number should be greater than zero");

//                        }

//                        else if (int.Parse(c) < 0 && int.Parse(d) < 0)
//                        {
//                            Console.WriteLine("please enter positive number");
//                        }
//                        else
//                        {
//                            int mul = int.Parse(c) * int.Parse(d);
//                            Console.WriteLine("reqired sum is " + mul);
//                        }
//                        break;
//                    case 4:
//                        Console.WriteLine("enter first number: ");
//                        string e = Console.ReadLine();
//                        Console.WriteLine("enter second number: ");
//                        string f = Console.ReadLine();
//                        bool check6 = int.TryParse(e, out int result3);
//                        bool check7 = int.TryParse(f, out int age3);


//                        if (check6 == false || check7 == false)
//                        {
//                            Console.WriteLine("Please enter valid number");
//                        }
//                        else if (int.Parse(e) == 0 || int.Parse(f) ==0)
//                        {
//                            Console.WriteLine("at least one number should be greater than zero");

//                        }

//                        else if (int.Parse(e) < 0 && int.Parse(f) < 0)
//                        {
//                            Console.WriteLine("please enter positive number");
//                        }
//                        else
//                        {
//                            int div = int.Parse(e) / int.Parse(f);
//                            Console.WriteLine("reqired sum is " + div);
//                        }
//                        break;
//                    case 5:
//                        Environment.Exit(0);
//                        break;





//                }
//                Console.ReadLine();
//            }



//        }
//    }
//}
//using System;
//class Address
//{
//    public int houseNo { set; get; } = 323;
//    public System.String houseName { set; get; } = "Tachy villa";
//    public static string Country { set; get; } = "India";


//    public override string ToString()
//    {
//        return "House Name: " + houseName + "\nHouse No " + houseNo + "\nCountary: " + Address.Country;

//    }
//}
//class Student
//{

//    private int _studentId { set; get; } = 7987;
//    private string _studendName { set; get; } = "Naushad";
//    public Address _studentAddress;
//    public Address GetAddress
//    {
//        set{ _studentAddress = value; }

//    }

//    // public Student(Address a)
//    // {
//    // _studentAddress = a;
//    // }

//    public override string ToString()
//    {
//        return "Student Name: " + _studendName + "\nStudent Id " + _studentId + "\nAddress : " + _studentAddress;

//    }
//}
//class Test
//{
//    public static void Main()
//    {
//        Student student = new Student();
//        Address address = new Address();
//        student.GetAddress = address;

//        Console.WriteLine(student);
//    }
//}
using System;
class Demo
{
    public static void Main()
    {
        int s = 324;
        int v = 3234;
        int z = s + v;
        Console.WriteLine(z);
    }
}