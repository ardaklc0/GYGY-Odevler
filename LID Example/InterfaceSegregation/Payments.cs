using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegregation
{
    public abstract class Payments
    {
        public int Id { get; set; }
        public string OwnerName { get; set; }
    }

    interface ICard
    {
        public string GetCardNumber();
        public DateTime GetExpireDate();
        public string GetSSLNumber();
        public void PayWithCard();
    }

    interface IBankTransfer
    {
        public string GetIBANNumber();
        public string GetAccountNumber();
        public void PayWithBank();
    }

    interface IEWallet
    {
        public string GetEWalletNumber();
        public string GetWalletPassword();
        public void PayWithEWallet();
    }

    public class CardPayment : Payments, ICard
    {
        public string CardNumber { get; set; }
        public DateTime ExpireDate { get; set; }
        public string SSLNumber { get; set; }

        public string GetCardNumber()
        {
            return $"Your card number is {this.CardNumber}";
        }

        public DateTime GetExpireDate()
        {
            return this.ExpireDate;
        }

        public string GetSSLNumber()
        {
            return $"Your SSL number is {this.SSLNumber}";
        }

        public void PayWithCard()
        {
            Console.WriteLine("You have paid with your card");
        }
    }

    public class BankTransferPayment : Payments, IBankTransfer
    {
        public string AccountNumber { get; set; }
        public string IBANNumber { get; set; }

        public string GetAccountNumber()
        {
            return $"Your account number is {this.AccountNumber}";
        }

        public string GetIBANNumber()
        {
            return $"Your IBAN number is {this.IBANNumber}";
        }

        public void PayWithBank()
        {
            Console.WriteLine("You have paid with your bank");
        }
    }

    public class EWalletPayment : Payments, IEWallet
    {
        public string EWalletNumber { get; set; }
        public string WalletPassword { get; set; }

        public string GetEWalletNumber()
        {
            return $"Your e-wallet number is {this.EWalletNumber}";
        }

        public string GetWalletPassword()
        {
            return $"Your wallet password is {this.WalletPassword}";
        }

        public void PayWithEWallet()
        {
            Console.WriteLine("You have paid with your e-wallet")
        }
    }
}
