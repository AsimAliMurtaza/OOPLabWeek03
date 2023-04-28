//2022-CS-175
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPTasks
{
    public class Student
    {
        public Student() 
        {
            //Console.WriteLine("Default Constructor");
            sName = "Asim";
            matricMarks = 1041;
            interMarks = 1039;
            ecatMarks = 164;
            aggregate = 83.6F;
        }
        public string sName;
        public float matricMarks;
        public float interMarks;
        public float ecatMarks;
        public float aggregate;
    }
    public class Students
    {
        public Students(string n, float a, float b, float c, float d)
        {
            sName = n;
            matricMarks = a;
            interMarks = b;
            ecatMarks = c;
            aggregate = d;
        }
        public string sName;
        public float matricMarks;
        public float interMarks;
        public float ecatMarks;
        public float aggregate;
    }
    public class Studentss
    {
        public Studentss()
        {
            Console.WriteLine("Default");
        }
        public Studentss(Studentss s)
        {
            sName = s.sName;
            matricMarks = s.matricMarks;
            interMarks = s.interMarks;
            ecatMarks = s.ecatMarks;
            aggregate = s.aggregate;
        }
        public string sName;
        public float matricMarks;
        public float interMarks;
        public float ecatMarks;
        public float aggregate;
    }
    public class ClockType
    {
        public int hours;
        public int minutes;
        public int seconds;

        public ClockType()
        {
            hours = 0;
            minutes = 0;
            seconds = 0;
        }
        public ClockType(int h)
        {
            hours = h;
        }
        public ClockType(int h, int m)
        {
            hours = h;
            minutes = m;
        }
        public ClockType(int h, int m, int s)
        {
            hours = h;
            minutes = m;
            seconds = s;
        }

        public void incrementHours()
        {
            hours++;
        }
        public void incrementMinutes()
        {
            minutes++;
        }
        public void incrementSeconds()
        {
            seconds++;
        }
        public void printTime()
        {
            Console.WriteLine(hours + ":" + minutes + ":" + seconds);
        }
        public bool isEqual(int h, int m, int s)
        {
            if (hours == h && minutes == m && seconds == s)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool isEqual(ClockType temp)
        {
            if(hours ==  temp.hours && minutes == temp.minutes && seconds == temp.seconds)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void difference(ClockType c)
        {
            if (c.minutes > 0)
            {
                if (c.seconds > 0)
                {
                    hours = (hours - c.hours) - 1;
                    minutes = (minutes - c.minutes) - 1;
                    seconds = seconds - c.seconds;
                }
                else
                {
                    hours = (hours - c.hours) - 1;
                    minutes = minutes - c.minutes;
                    seconds = seconds - c.seconds;
                }
            }
            else
            {
                if (c.seconds > 0)
                {
                    hours = hours - c.hours;
                    minutes = (minutes - c.minutes) - 1;
                    seconds = seconds - c.seconds;
                }
                else
                {
                    hours = hours - c.hours;
                    minutes = minutes - c.minutes;
                    seconds = seconds - c.seconds;
                }
            }
            if (hours < 0)
            {
                hours = hours * -1;
            }
            if (minutes < 0)
            {
                minutes = minutes * -1;
            }
            if (seconds < 0)
            {
                seconds = seconds * -1;
            }
        }
        public int remainingTime(int h, int m, int s)
        {
            int hour = 23 - h;
            int minute = 59 - m;
            int second = 60 - s;

            hours = hour;
            minutes = minute;
            seconds = second;

            int time = (hour * 60 * 60) + (minute * 60) + second;

            return time;
        }
        public int Elapsed(int h, int m, int s)
        {
            int time;

            time = (h * 60 * 60) + (m * 60) + s;

            hours = h;
            minutes = m;
            seconds = s;

            return time;
        }
    }
    public class Products
    {
        public string name;
        public string category;
        public float price;
        public int quantity;
        public int minimumQuantity;
        public Products()
        {
            name = "";
            category = "grocery";
            price = 0.0F;
            quantity = 0;
            minimumQuantity = 10;
        }
        public Products(string n)
        {
            name = n;
        }
        public Products(string n, string c)
        {
            name = n;
            category = c;
        }
        public Products(string n, string c, float p)
        {
            name = n;
            category = c;
            price = p;
        }
        public Products(string n, string c, float p, int q)
        {
            name = n;
            category = c;
            price = p;
            quantity = q;
        }
        public Products(string n, string c, float p, int q, int minQuan)
        {
            name = n;
            category = c;
            price = p;
            quantity = q;
            minimumQuantity = minQuan;
        }
        public Products(Products prod)
        {
            name = prod.name;
            category = prod.category;
            price = prod.price;
            quantity = prod.quantity;
            minimumQuantity = prod.minimumQuantity;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //TaskOne();
            //TaskTwo();
            //TaskThree();
            //SelfTaskOne();
            //SelfTaskTwo();
            //TaskFour();
            //SelfTaskThree();
            //SelfTaskFour();
            //TaskFive();
            //TaskSix();
            //TaskSevenClockType();
            //ChallengeOne();
            //ChallengeTwo();

        }
        static void TaskOne()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.sName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.interMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
        }
        static void TaskTwo()
        {
            Student s1 = new Student();
            Console.Read();
        }
        static void TaskThree()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.sName);
            Console.Read();
        }
        static void SelfTaskOne()
        {
            Student s1 = new Student();
            Console.WriteLine(s1.sName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.interMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.Read();
        }
        static void SelfTaskTwo()
        {
            Student s1 = new Student();
            Student s2 = new Student();

            Console.WriteLine(s1.sName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.interMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine(s2.sName);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.interMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
            Console.Read();
        }

        /*static void TaskFour()
        {
            Students s1 = new Students("Asim");
            Students s2 = new Students("Ali");

            Console.WriteLine(s1.sName);

            Console.WriteLine(s2.sName);

            Console.Read();
        }*/
        static void SelfTaskThree()
        {
            Students s1 = new Students("Asim", 1041, 1039, 164, 83.6F);

            Console.WriteLine(s1.sName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.interMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.Read();
        }
        static void SelfTaskFour()
        {
            Students s1 = new Students("Asim", 1041, 1039, 164, 83.6F);
            Students s2 = new Students("Ali", 1041, 1039, 164, 83.6F);

            Console.WriteLine(s1.sName);
            Console.WriteLine(s1.matricMarks);
            Console.WriteLine(s1.interMarks);
            Console.WriteLine(s1.ecatMarks);
            Console.WriteLine(s1.aggregate);
            Console.WriteLine(s2.sName);
            Console.WriteLine(s2.matricMarks);
            Console.WriteLine(s2.interMarks);
            Console.WriteLine(s2.ecatMarks);
            Console.WriteLine(s2.aggregate);
            Console.Read();
        }
        static void TaskFive()
        {
            Studentss s1 = new Studentss();
            s1.sName = "Asim";
            Studentss s2 = new Studentss(s1);
            Console.WriteLine(s1.sName);
            Console.WriteLine(s2.sName);
        }
        static void TaskSix()
        {
            List<int> lumbers = new List<int>() {12,13,123,53,1,23,4,5,6,7};
            foreach (var i in lumbers)
            {
                Console.WriteLine(i);
            }
        }
        static void TaskSevenClockType()
        {
            ClockType empty_time = new ClockType();
            Console.Write("Empty Time: ");
            empty_time.printTime();

            ClockType hour_time = new ClockType(10);
            Console.Write("Hour Time: ");
            hour_time.printTime();

            ClockType minute_time = new ClockType(8, 10);
            Console.Write("Minutes Time: ");
            minute_time.printTime();

            ClockType full_time = new ClockType(8, 10, 23);
            Console.Write("Full Time: ");
            full_time.printTime();

            full_time.incrementSeconds();
            Console.Write("Full Time (increment seconds): ");
            full_time.printTime();

            full_time.incrementMinutes();
            Console.Write("Full Time (increment Minutes): ");
            full_time.printTime();

            full_time.incrementHours();
            Console.Write("Full Time (increment Hours): ");
            full_time.printTime();

            bool flag = full_time.isEqual(9, 11, 10);
            Console.WriteLine("Flag: " + flag);

            ClockType equal = new ClockType(11, 23, 12);
            flag = full_time.isEqual(equal);
            Console.WriteLine("Flag: " + flag);
        }
        static void ChallengeOne()
        {
            int secElapsed;
            int secRemain;

            ClockType elapsedTime = new ClockType();
            ClockType remainingTime = new ClockType();

            secElapsed = elapsedTime.Elapsed(6, 50, 20);
            Console.WriteLine("Elapsed time: " + secElapsed);

            secRemain = remainingTime.remainingTime(6, 50, 20);
            Console.WriteLine("Remaining time: " + secRemain);

            remainingTime.difference(elapsedTime);
            Console.Write("Difference between two clocks: ");

            remainingTime.printTime();
            Console.ReadKey();
        }
        static void ChallengeTwo()
        {
            int choice = 0;
            List<Products> product = new List<Products>();

            while (choice != 6)
            {
                choice = menu();
                Console.Clear();

                if (choice == 1)
                {
                    product.Add(AddProduct());
                }
                else if (choice == 2)
                {
                    viewList(product);
                }
                else if (choice == 3)
                {
                    int x = highestPrice(product);

                    Console.Write("Product with Highest PPU: " + product[x].name);
                    Console.ReadKey();
                }
                else if (choice == 4)
                {
                    viewTax(product);
                }
                else if (choice == 5)
                {
                    ordered(product);
                }
                Console.Clear();
            }
        }
        static int menu()
        {
            Console.WriteLine("1.\tAdd New Product");
            Console.WriteLine("2.\tView List of all Products");
            Console.WriteLine("3.\tView Product With The Highest Unit Price");
            Console.WriteLine("4.\tView Sales Tax of All Products");
            Console.WriteLine("5.\tView Products To Be Ordered");
            Console.WriteLine("6. \tExit.");
            Console.Write("Enter Choice: ");

            return int.Parse(Console.ReadLine());
        }
        static Products AddProduct()
        {
            string name;
            string category;
            float price;
            int quantity;
            int minimumQuantity;

            Console.Write("Product Name: ");
            name = Console.ReadLine();

            Console.Write("Product Category: ");
            category = Console.ReadLine();

            Console.Write("Product Price: ");
            price = float.Parse(Console.ReadLine());

            Console.Write("Product Quantity: ");
            quantity = int.Parse(Console.ReadLine());

            Console.Write("Product Minimum Quantity: ");
            minimumQuantity = int.Parse(Console.ReadLine());

            Products product = new Products(name, category, price, quantity, minimumQuantity);

            return product;
        }
        static void viewList(List<Products> p)
        {
            Console.WriteLine("Product Name\t\tCategory\t\tPrice\t\tStock\t\tMinimum Stock");
            foreach (var x in p)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}\t\t{3}\t\t{4}", x.name, x.category, x.price, x.quantity, x.minimumQuantity);
            }
            Console.ReadKey();
        }
        static void ordered(List<Products> p)
        {
            Console.WriteLine("Product Name \t\t Current Stock \t\t Minimum Stock");

            foreach (var item in p)
            {
                if (item.quantity < item.minimumQuantity)
                {
                    Console.WriteLine( "{0} \t\t {1} \t\t {2}", item.name, item.quantity, item.minimumQuantity);
                }
            }
            Console.ReadKey();
        }
        static void viewTax(List<Products> product)
        {
            float tax;
            Console.WriteLine("Product Name\t\tCategory\t\ttax");
            foreach (var item in product)
            {
                tax = calculateTax(item);

                Console.WriteLine("{0} \t\t {1} \t\t {2}" , item.name, item.category, tax);
            }
            Console.ReadKey();
        }
        static float calculateTax(Products product)
        {
            float tax;

            if (product.category == "grocery")
            {
                tax = product.price * (0.1F);
            }
            else if (product.category == "fruit")
            {
                tax = product.price * (0.05F);
            }
            else
            {
                tax = product.price * (0.15F);
            }
            return tax;
        }
        static int highestPrice(List<Products> p)
        {
            float max = 0;
            int idx = 0;
            for (int x = 0; x < p.Count; x++)
            {
                if (max < p[x].price)
                {
                    max = p[x].price;
                    idx = x;
                }
            }
            return idx;
        }
    }
}
