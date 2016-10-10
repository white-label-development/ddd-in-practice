﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddd.Logic
{
    public sealed class SnackMachine
    {
        /*
         * Snack Machine:
            Insert money into the machine
            Return the money back
            Buy a snack
        */

        //sealed = for least privilege.

        /*
            * started with core domain
            * start with a single context: don't introduce several bounded contexts upfront. introduce new conexts only when complexity forces it.
            * always look for abstractions
            */


        public Money MoneyInside { get; private set; }
        public Money MoneyInTransaction { get; private set; }
       


   

        public void InsertMoney(Money money)
        {
            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            //MoneyInTransaction = 0; come back to this
        }

        public void BuySnack()
        {
            MoneyInTransaction += MoneyInTransaction;
            //MoneyInTransaction = 0;
        }
    }
}
