using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace BankEncapsulation
{
   public class BankAccount
   {
        //Constructor   
        public BankAccount()
        {

        }

        private double _balance = 0;

        public void Deposit()
        {
            bool isTrue = false;
            double amount;

            do
            {
                Console.WriteLine("How much would you like to deposit?");
                Console.Write("$");
                isTrue = double.TryParse(Console.ReadLine(), out amount);

            } while (!isTrue);

            _balance += amount;

             Console.WriteLine($"Deposit of ${amount} accepted\n");
            
        }
        
        public void GetBalance()
        {
            Console.WriteLine("Current Account Balance:");
            Console.WriteLine($"${_balance}\n");


        }
   }
}
