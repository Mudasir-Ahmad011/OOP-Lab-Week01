using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task1();
            //Task2();
            //Task3();
            //Task4();
            //Task5();
            //Task6();
            //Task7();
            //Task8();
            //Task9();
            //Task10();
            //Task11();
            //Task12();
            //Task13();
            //Task14();
            //Task15();
            //TakeAwayTask();
            //Task17();
            //Task18();
            //Task19();
            //LoginPage();
            Free_pizza_points();
        }
        static void Task1()
        {
            Console.Write("Hello world!!");
            Console.Write("Hello world!!");
            Console.ReadKey();
        }
        static void Task2()
        {
            Console.WriteLine("Hello World!!");
            Console.Write("Hello World!!");
            Console.ReadKey();
        }
        static void Task3()
        {
            int variable = 7;
            Console.WriteLine("value: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task4()
        {
            string variable = "I am String";
            Console.WriteLine("String: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task5()
        {
            char variable = 'A';
            Console.WriteLine("Character: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task6()
        {
            float variable = 2.2F;
            Console.WriteLine("Decimal: ");
            Console.Write(variable);
            Console.ReadKey();
        }
        static void Task7()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You have inputed");
            Console.Write(str);
            Console.ReadKey();
        }
        static void Task8()
        {
            string str;
            str = Console.ReadLine();
            Console.WriteLine("You Have Inputed");
            int num = int.Parse(str);
            Console.WriteLine("The number is: ");
            Console.Write(num);
            Console.ReadKey();
        }
        static void Task9()
        {
            string str;
            Console.WriteLine("Enter floating point value: ");
            str = Console.ReadLine();
            float num = float.Parse(str);
            Console.WriteLine("Floating value is: ");
            Console.Write(num);
           Console.ReadKey();
        }
        static void Task10()
        {
            string str;
            str = Console.ReadLine();
            float length = float.Parse(str);
            float area = length * length;
            Console.WriteLine("The area is: ");
            Console.Write(area);
            Console.ReadKey();
        }
        static void Task11()
        {
            string input;
            Console.WriteLine("Enter the marks");
            input = Console.ReadLine();
            float Marks = float.Parse(input);
            if (Marks > 50)
            {
                Console.WriteLine("You are passed");
            }
            else
            {
                Console.WriteLine("You are failed");
            }
            Console.ReadKey();
        }
        static void Task12()
        {
            for(int x = 0; x < 5; x++)
            {
                Console.WriteLine("Welcome Jack");
            }
            Console.ReadKey();
        }
        static void Task13()
        {
            string str;
            Console.WriteLine("Enter the number");
            str = Console.ReadLine();
            float num = float.Parse(str);
            float sum = 0;
            while (num != -1)
            {
                sum = sum + num;
                str = Console.ReadLine();
                num = float.Parse(str);
            }
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadKey();
        }
        static void Task14()
        {
            string str;
            Console.WriteLine("Enter the number");
            int num;
            int sum = 0;
            do
            {
                str = Console.ReadLine();
                num = int.Parse(str);
                sum = sum + num;
            } while (num != -1);
            sum = sum + 1;
            Console.WriteLine("The sum is {0}", sum);
            Console.ReadKey();
        }
        static void Task15()
        {
            int[] numbers = new int[3];
            int largest = -1;
            for(int idx = 0; idx < 3; idx++)
            {
                Console.WriteLine("Enter the number of index {0}", idx);
                numbers[idx] = int.Parse(Console.ReadLine());

            }
            for (int idx = 0; idx < 3; idx++)
            {
                if (numbers[idx] > largest)
                {
                    largest = numbers[idx];
                }
            }
            Console.WriteLine("The largest number is {0}", largest);
            Console.ReadKey();
        }
        static void TakeAwayTask()
        {
            int age, unitPrice_toy;
            float washingMachinePrice;
            Console.WriteLine("You age: ");
            age = int.Parse(Console.ReadLine());
            Console.WriteLine("Washing Machine Price: ");
            washingMachinePrice = float.Parse(Console.ReadLine());
            Console.WriteLine("Each toy Price: ");
            unitPrice_toy = int.Parse(Console.ReadLine());
            float savedMoney = 0;
            int countToy = 0;
            int moneyIncrement = 10;
            while (age != 0)
            {
                if (age % 2 == 0)
                {
                    savedMoney = savedMoney + moneyIncrement - 1;
                    moneyIncrement += 10;
                }
                else
                {
                    countToy = countToy + 1;
                }
                age--;
            }
            int totaltoysamount = countToy * unitPrice_toy;
            float totalAmount = savedMoney + totaltoysamount;
            if (totalAmount >= washingMachinePrice)
            {
                float remaining_Money = totalAmount - washingMachinePrice;
                Console.WriteLine("Yes! {0}", remaining_Money);
            }
            else
            {
                float require_Money = washingMachinePrice - totalAmount;
                Console.WriteLine("No! {0}", require_Money);
            }
            Console.ReadKey();
        }
        static void Task17()
        {
            int num1, num2;
            Console.WriteLine("Enter first number");
            num1=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            num2 = int.Parse(Console.ReadLine());
            int result = add(num1, num2);
            Console.WriteLine("The sum is {0}", result);
            Console.ReadKey();
        }

        static int add(int n1,int n2)
        {
            return n1 + n2;
        }
        static void Task18()
        {
            string path = "E:\\OOP lab\\Week 01\\.vs\\textfile.txt";
            if (File.Exists(path))
            {
                StreamReader filevariable = new StreamReader(path);
                string record;
                while((record = filevariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                filevariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
            Console.ReadKey();
        }
        static void Task19()
        {
            string path = "E:\\OOP lab\\Week 01\\.vs\\textfile.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine("hello");
            filevariable.Flush();
            filevariable.Close();
        }
        static int menu()
        {
            int option;
            Console.WriteLine("1. SignIn");
            Console.WriteLine("2. SignUp");
            Console.WriteLine("Enter Option: ");
            option = int.Parse(Console.ReadLine());
            return option;
        }
        static void LoginPage()
        {
            string path = "E:\\OOP lab\\Week 01\\.vs\\textfile1.txt";
            string[] names = new string[5];
            string[] password = new string[5];
            int option;
            do {
                readData(path, names, password);
                Console.Clear();
                option = menu();
                Console.Clear();
                if (option == 1)
                {
                    Console.WriteLine("Enter Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string p = Console.ReadLine();
                    signIn(n, p, names, password);
                }
                else if(option == 2)
                {
                    Console.WriteLine("Enter new Name: ");
                    string n = Console.ReadLine();
                    Console.WriteLine("Enter New Password: ");
                    string p = Console.ReadLine();
                    signUp(path, n, p);
                }
            } while (option < 3);
            Console.Read();
        }
        static string parsedata(string record, int field)
        {
            int comma = 1;
            string item = "";
            for(int x = 0; x < record.Length; x++)
            {
                if (record[x] == ',')
                {
                    comma++;
                }
                else if(comma == field)
                {
                    item = item + record[x];
                }
            }
            return item;
        }
        
        static void readData(string path,string[] names,string[] password)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while((record = fileVariable.ReadLine()) != null)
                {
                    names[x] = parsedata(record, 1);
                    password[x] = parsedata(record, 2);
                    x++;
                    if (x >= 5)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not Exists");
            }
        }
        static void signIn(string n,string p,string[] names,string[] password)
        {
            bool flag = false;
            for(int x = 0; x < 5; x++)
            {
                if(n==names[x] && p == password[x])
                {
                    Console.WriteLine("Valid User");
                    flag = true;
                }
            }
            if (flag == false)
            {
                Console.WriteLine("Invalid User");
            }
            Console.ReadKey();
        }
        static void signUp(string path,string n,string p)
        {
            StreamWriter file = new StreamWriter(path, true);
            file.WriteLine(n + "," + p);
            file.Flush();
            file.Close();
        }

        static string nameOf_buyer(string record)
        {
            string namei = "";
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] != ' ')
                {
                    namei = namei + record[x];
                }
                else
                {
                    break;
                }
            }
            return namei;
        }
        static bool order_parsedata(string record, int Number_of_orders, int order_price)
        {
            int comma = 1;
            int field = 1;
            string item = "";
            bool start = false;
            bool result = false;
            bool checkComma = false;
            int count = 0;
            for (int x = 0; x < record.Length; x++)
            {
                if (record[x] == ']')
                {
                    start = false;
                    if (int.Parse(item) >= order_price)
                    {
                        count = count + 1;
                    }
                    break;
                }
                if (record[x] == ',')
                {
                    comma++;
                    int num = int.Parse(item);
                    if (num >= order_price)
                    {
                        count = count + 1;
                    }
                    item = "";
                    checkComma = true;
                }
                if (start == true && comma == field)
                {
                    item = item + record[x];
                }
                if (checkComma == true)
                {
                    field++;
                    checkComma = false;
                }
                if (record[x] == '[')
                {
                    start = true;
                }
            }
            if (count >= Number_of_orders)
            {
                result = true;
            }
            return result;
        }
        static void OrderreadData(string path, int Number_of_orders, int order_price, string[] Free_pizzaTo_name)
        {
            int x = 0;
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                string namei;
                bool Free_pizza = false;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Free_pizza = order_parsedata(record, Number_of_orders, order_price);
                    namei = nameOf_buyer(record);
                    if (Free_pizza == true)
                    {
                        Free_pizzaTo_name[x] = namei;
                        x++;
                    }
                    if (x >= 2)
                    {
                        break;
                    }
                }
                fileVariable.Close();
            }
        }
        static void Free_pizza_points()
        {
            string path = "E:\\OOP lab\\Week 01\\.vs\\orders.txt";
            Console.WriteLine("Enter the minimum numbers of orders: ");
            int Number_of_orders = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the minimum order prize: ");
            int order_price = int.Parse(Console.ReadLine());
            string[] Free_pizzaTo_name = new string[2];
            OrderreadData(path, Number_of_orders, order_price, Free_pizzaTo_name);
            for (int x = 0; x < 2; x++)
            {
                Console.WriteLine(Free_pizzaTo_name[x]);
            }
            Console.ReadKey();
        }
    }
}


