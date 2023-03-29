using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovPrinciple
{
    public abstract class Accounts
    {
        public int Id { get; set; }
        public string AccountName { get; set; }
        public string OwnerName { get; set; }
        public double AccountAmount { get; set; }

        public abstract void WithDrawMoney(double amount);
        public abstract void DepositMoney(double amount);
    }

    public interface IExpirable
    {
        void GetExpireDate();
    }

    public class SavingAccounts : Accounts
    {
        public override void DepositMoney(double amount)
        {
            Console.WriteLine($"You deposit {amount} dollars. Now you have {amount + this.AccountAmount} dollars.");
        }

        public override void WithDrawMoney(double amount)
        {
            Console.WriteLine($"You withdraw {amount} dollars. Now you have {this.AccountAmount - amount} dollars");
        }
    }

    public class DepositAccounts : Accounts, IExpirable
    {
        public override void DepositMoney(double amount)
        {
            Console.WriteLine($"You deposit {amount} dollars. Now you have {amount + this.AccountAmount} dollars.");
        }

        public override void WithDrawMoney(double amount)
        {
            Console.WriteLine($"You cannot withdraw money yet. You have {this.AccountAmount} dollars.");
        }

        public void GetExpireDate()
        {
            Console.WriteLine($"You can withdraw your money on {DateTime.Now}");
        }
    }
}
