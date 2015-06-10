using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BankSoftware.Interfaces;
using BankSoftware.Customers;
using BankSoftware.Accounts;

namespace BankSoftware
{
    class BankOfKurtovoKonare
    {
        static void Main(string[] args)
        {
            Individual pesho = new Individual("Pesho");
            Company softUni = new Company("Software University");
            Individual joro = new Individual("Georgi");

            DepositAccount peshoAcc = new DepositAccount(pesho, 1000m, 0.05m);
            LoanAccount softUniAcc = new LoanAccount(softUni, -15000m, 0.10m);
            MortgageAccount joroAcc = new MortgageAccount(joro, -50000m, 0.08m);

            List<IAccount> accounts = new List<IAccount>()
            {
                peshoAcc,
                softUniAcc,
                joroAcc
            };
            foreach (var account in accounts)
            {
                Console.WriteLine(account);
            }
            Console.WriteLine("Sum with Interest: {0}", peshoAcc.CalculateInterest(24));
            Console.WriteLine("Sum with Interest: {0}", softUniAcc.CalculateInterest(6));
            Console.WriteLine("Sum with Interest: {0}", joroAcc.CalculateInterest(10));
            Console.WriteLine();

            peshoAcc.Withdraw(100m);
            //peshoAcc.Withdraw(1000m);
            Console.WriteLine(peshoAcc);
            softUniAcc.Deposit(7500m);
            Console.WriteLine(softUniAcc);

            Console.WriteLine("Sum with Interest: {0}", softUniAcc.CalculateInterest(6));

        }
    }
}
