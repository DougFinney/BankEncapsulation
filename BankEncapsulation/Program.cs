using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var myAccount = new BankAccount();


            myAccount.GetBalance();

            myAccount.Deposit();

            myAccount.GetBalance();
        
        }
            //Console.WriteLine("How much would you like to deposit?");
            //Console.Write("$");
            //var userInput = double.Parse(Console.ReadLine());

            

            //Console.WriteLine($"Current Balance: ${myAccount.GetBalance()}\n");
            
            //Console.WriteLine($"Current Balance: ${myAccount.GetBalance()}\n");
         
        
    }

    
}
