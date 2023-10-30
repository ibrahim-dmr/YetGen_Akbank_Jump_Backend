using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulationExcercise.Entities
{
    public class Account
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //public decimal Balance { get; private set; }

        private decimal balance;  //private olan mutalaka camelCase olmalı

        public decimal Balance   //Public olan mutlaka PascalCase olmalı
        {
            get { return balance; }
            set 
            { 
                if(Math.Abs(value - balance) <= 500)
                balance = value;
                Console.WriteLine($"Current Value: {balance}");
            }
        }


        public Account(string name, string surname)
        {
            Id = Guid.NewGuid();
            Name = name;
            Surname = surname;
            Balance = 2000;
        }

        //public void Withdraw(decimal amount)
        //{
        //    if (Balance - amount >= 0)
        //        Balance -= amount;
        //    else
        //        Console.WriteLine("Not enough money");
        //}

    }
}
