using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Upcasting_Downcasting.Entities;

namespace Upcasting_Downcasting.Entities
{
    internal class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;    
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //public override void Withdraw(double amount)  //sobreescrita do Withdraw (public virtual) na classe principal
        //{
        //    Balance -= amount;
        //}




        //PALAVRA BASE - Vamos suporte que para Conta Poupança e desconte + 2 reais.

        public override void Withdraw(double amount)
        {
            base.Withdraw(amount); //Vou chamar a operação de saque na SUPERCLASSE (base)
            Balance -= 2.0;
        }







    }




}
