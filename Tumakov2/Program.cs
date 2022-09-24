using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tumakov2;

namespace Tumakov2
{
    public enum types
    {
        Текущий,
        Сберегательный
    }
    struct BankAccount
    {
        public int number;
        public string types;
        public double balance;
        public BankAccount(int number, string types, double balance)
        {
            this.number = number;
            this.types = types;
            this.balance = balance;
        }
        public void Print()
        {
            Console.WriteLine($"Номер счёта:{number}, Тип:{types}, Баланс:{balance}");
        }

    }
    public enum vuz
    {
        KGU=0,
        KAI=1,
        KNRTU=2
    }
    struct worker
    {
        public string name;
        public int Vuz;
        public worker(string name, int Vuz)
        {
            this.name = name;
            this.Vuz = Vuz;
        }
        public void Print()
        {
            
            Console.WriteLine($"Работник {name}, Вуз - {Vuz}");
        }
    }
    


    
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Упр 3.1");
            types now = types.Сберегательный;
            Console.WriteLine($"Счёт- {now}, номер-{1}", now, (int)now);
            Console.ReadKey();

            Console.WriteLine("Упр 3.2");
            BankAccount acc = new BankAccount(100000000,"Текущий",5.675);
            acc.Print();
            Console.ReadKey();

            Console.WriteLine("ДЗ 3.1");
            worker Worker1 = new worker($"Иванов Иван", (int)vuz.KGU);
            
            Worker1.Print();
            


        }
    }
}
