using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ddd.Logic
{
    public sealed class SnackMachine: Entity
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



        public SnackMachine()
        {
            MoneyInside = Money.None;
            MoneyInTransaction = Money.None;
        }


        public Money MoneyInside { get; private set; }
        public Money MoneyInTransaction { get; private set; }
       


   

        public void InsertMoney(Money money)
        {
            MoneyInTransaction += money;
        }

        public void ReturnMoney()
        {
            //MoneyInTransaction.Clear() - don't as this violates the immutability of the ValueObject.
            MoneyInTransaction = Money.None; ; //overwrite instead.
        }

        public void BuySnack()
        {
            MoneyInTransaction += MoneyInTransaction;
            //MoneyInTransaction = 0;
        }
    }
}
