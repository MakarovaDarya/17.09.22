using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Homework_2
{
    struct Student
    {
        public string surname;
        public string name;
        public int ident;
        public string dateofB;
        public string category;
        public double alcohol;
        public Student(string surname, string name, int ident, string dateofB, string category, double alcohol)
        {
            this.surname = surname;
            this.name = name;
            this.ident = ident;
            this.dateofB = dateofB;
            this.category = category;
            this.alcohol = alcohol;
        }
        public double Alco()
        {
            return alcohol;
        }
        public void Print()
        {
            Console.WriteLine($"Фамилия:{surname},Имя:{name},Идентификатор:{ident},Дата рождения:{dateofB},Категория:{category}, Объем выпитого алкоголя:{alcohol}");
        }
    }
    struct user
    {
        public string name;
        public string city;
        public int age;
        public int PIN;
        public user(string name, string city, int age, int PIN)
        {
            this.name = name;
            this.city = city;
            this.age = age;
            this.PIN = PIN;
        }
        public void Print()
        {
            Console.WriteLine($"Имя:{name},Город:{city},Возраст:{age},Пин-код:{PIN}");

        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Student student1 = new Student("Агиева", "Лилия", 1, "05.02.2004", "b", 0.8);
            student1.Print();
            Student student2 = new Student("Макарова", "Дарья", 2, "27.04.2004", "b", 0.5);
            student2.Print();
            Student student3 = new Student("Хамидуллина", "Диана", 3, "14.10.2004", "в", 0);
            student3.Print();
            Student student4 = new Student("Вальярова", "Алина", 4, "10.03.2004", "b", 0.5);
            student4.Print();
            Student student5 = new Student("Дания", "Муракаева", 5, "07.06.2004", "с", 0.2);
            student5.Print();
            double allV = student1.Alco() + student2.Alco() + student3.Alco() + student4.Alco() + student5.Alco();
            Console.WriteLine($"Общий объем выпитого алкоголя: {allV}");
            Console.WriteLine($"Первый студент выпил: {Math.Round(student1.Alco() * 100 / allV, 1)}%");
            Console.WriteLine($"Второй студент выпил: {Math.Round(student2.Alco() * 100 / allV, 1)}%");
            Console.WriteLine($"Третий студент выпил: {Math.Round(student3.Alco() * 100 / allV, 1)}%");
            Console.WriteLine($"Четвертый студент выпил: {Math.Round(student4.Alco() * 100 / allV, 1)}%");
            Console.WriteLine($"Пятый студент выпил: {Math.Round(student5.Alco() * 100 / allV, 1)}%");
            Console.ReadKey();

            Console.WriteLine("Задание 2");
            Console.WriteLine($"Byte-Максимальное значение: {byte.MaxValue} - Минимальное значение: {byte.MinValue}");
            Console.WriteLine($"Sbyte-Максимальное значение: {sbyte.MaxValue} - Минимальное значение: {sbyte.MinValue}");
            Console.WriteLine($"Short-Максимальное значение: {short.MaxValue} - Минимальное значение: {short.MinValue}");
            Console.WriteLine($"Ushort-Максимальное значение: {ushort.MaxValue} - Минимальное значение: {ushort.MinValue}");
            Console.WriteLine($"Int-Максимальное значение: {int.MaxValue} - Минимальное значение: {int.MinValue}");
            Console.WriteLine($"Uint-Максимальное значение: {uint.MaxValue} - Минимальное значение: {uint.MinValue}");
            Console.WriteLine($"Long-Максимальное значение: {long.MaxValue} - Минимальное значение: {long.MinValue}");
            Console.WriteLine($"Ulong-Максимальное значение: {ulong.MaxValue} - Минимальное значение: {ulong.MinValue}");
            Console.WriteLine($"Float-Максимальное значение: {float.MaxValue} - Минимальное значение: {float.MinValue}");
            Console.WriteLine($"Double-Максимальное значение: {double.MaxValue} - Минимальное значение: {double.MinValue}");
            Console.WriteLine($"Decimal-Максимальное значение: {decimal.MaxValue} - Минимальное значение: {decimal.MinValue}");

            Console.WriteLine("Задание 3");
            user New_U = new user();
            Console.Write("Введите имя пользователя: ");
            New_U.name = Console.ReadLine();
            Console.Write("Введите город: ");
            New_U.city = Console.ReadLine();
            Console.Write("Введите возраст: ");
            New_U.age = int.Parse(Console.ReadLine());
            Console.Write("Введите PIN-код: ");
            New_U.PIN = int.Parse(Console.ReadLine());
            New_U.Print();
            Console.ReadKey();

            Console.WriteLine("Задание 4");
            Console.Write("Введите имя: ");
            string[] name = Console.ReadLine().Split(' ');



            Console.WriteLine("Задание 5");
            Console.Write("Сколько стоит ваш опуск? ");
            int holidayPrice = int.Parse(Console.ReadLine());
            Console.Write("Сколько стоит утылка виски? ");
            int normPrice = int.Parse(Console.ReadLine());
            Console.Write("Какая скидка в DutyFree? ");
            int salePrice = int.Parse(Console.ReadLine());
            int butaloc = holidayPrice / (normPrice * salePrice / 100);
            Console.WriteLine($"Кол-во бутылок, необходимых купить, чтобы экономия покрыла отпуск: {butaloc}");



            Console.WriteLine("Задание 6");
            Console.Write("Введите скорость таракана в км/ч: ");
            int S = int.Parse(Console.ReadLine());
            double s = S * 100000 / 3600;
            Console.WriteLine($"Его скорость : {Math.Floor(s)} см/с");
            Console.ReadKey();

            Console.WriteLine("Задание 7");
            Console.Write("Напишите что-нибудь: ");
            string str1 = Console.ReadLine();
            StringBuilder str2 = new StringBuilder();
            foreach (Char x in str1.ToCharArray())
            {
                if (Char.IsLower(x))
                {
                    str2.Append(Char.ToUpper(x));
                }
                else
                {
                    str2.Append(Char.ToLower(x));
                }
            }
            Console.WriteLine(str2);
           







        }
    }
}
