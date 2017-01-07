using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payment
{
    class Score:Client
    {
        protected uint NumAccount;
        protected uint NumCreditCard;
        public decimal Cash;
        protected bool NulledAccount;
        protected bool LockCreditCard;
        protected string PinCode;

        public Score(string firstName, string lastName, string fatherName,uint NumAccount,uint NumCreditCard,string PinCode)
            : base(firstName, lastName, fatherName)
        {
            this.NumAccount = NumAccount;
            this.NumCreditCard = NumCreditCard;
            Cash = 0;
            NulledAccount = false;
            LockCreditCard = false;
            this.PinCode = PinCode;
          
        }
        public bool Pay(decimal amount,string PinCode) // повертає успішність платежу
        {
            if (NulledAccount || LockCreditCard || this.PinCode != PinCode) return false;
            else
            {
                Cash -= amount;
                return true;
            }
         }

        public bool PayToScore(decimal amount, Score score,string PinCode)
        {
            if (score.LockCreditCard || score.NulledAccount|| this.PinCode!=PinCode) return false;
            else
            {
                Cash -= amount;
                score.Cash += amount;
                return true;
            }
        }
        public bool putMoney(decimal amount, string PinCode)
        {
            if (NulledAccount || LockCreditCard || this.PinCode != PinCode) return false;
            else
            {
                Cash += amount;
                return true;
            }
        }
        public bool nulledAccount(string PinCode)
    {
        if (this.PinCode != PinCode) return false;
        else
        {
            NulledAccount = true;
            return true;
        }
    }
        public bool nulledAccount(int AcssesId) // 0 -user 1 -admin 
        {
            if (AcssesId == 1)
            {
                NulledAccount = true;
                return true;
            }
            else return false;
        }
        


    }
}
