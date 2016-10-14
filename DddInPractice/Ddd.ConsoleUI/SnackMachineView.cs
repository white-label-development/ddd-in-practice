using System;
using Ddd.Logic;

namespace Ddd.ConsoleUI
{
    public class SnackMachineView
    {

        private readonly Logic.SnackMachine _snackMachine;

        public SnackMachineView()
        {
            _snackMachine = new SnackMachine();
            Console.WriteLine("SnackMachine started.");
            Console.WriteLine("Money inserted: " + _snackMachine.MoneyInTransaction.Amount);

            GetMoney();

            if (ReturnMoney()) return;

            Console.WriteLine("Choose Snack...");

        }

        private void GetMoney()
        {
            Console.WriteLine("Add Cent (0 or 1)");
            int cent = ZeroOrOne(Console.ReadLine());
            if (cent == 1) _snackMachine.InsertMoney(Money.Cent);
            Console.WriteLine("Added {0}", cent);

            Console.WriteLine("Add .10");
            int tenCent = ZeroOrOne(Console.ReadLine());
            if (tenCent == 1) _snackMachine.InsertMoney(Money.TenCent);
            Console.WriteLine("Added {0}", tenCent);

            Console.WriteLine("Add .25");
            int twentyFiveCent = ZeroOrOne(Console.ReadLine());
            if (twentyFiveCent == 1) _snackMachine.InsertMoney(Money.Quarter);
            Console.WriteLine("Added {0}", twentyFiveCent);

            Console.WriteLine("Add $1");
            int oneDollar = ZeroOrOne(Console.ReadLine());
            if (oneDollar == 1) _snackMachine.InsertMoney(Money.Dollar);
            Console.WriteLine("Added {0}", oneDollar);

            Console.WriteLine("Add $5");
            int fiveDollar = ZeroOrOne(Console.ReadLine());
            if (fiveDollar == 1) _snackMachine.InsertMoney(Money.FiveDollar);
            Console.WriteLine("Added {0}", fiveDollar);

            Console.WriteLine("Add $20");
            int twentyDollar = ZeroOrOne(Console.ReadLine());
            if (twentyDollar == 1) _snackMachine.InsertMoney(Money.TwentyDollar);
            Console.WriteLine("Added {0}", twentyDollar);


            Console.WriteLine("Money inserted: " + _snackMachine.MoneyInTransaction.Amount);
        }

        private int ZeroOrOne(string zeroOrOne)
        {
            int val = 0;
            if (!int.TryParse(zeroOrOne, out val)) return 0;
            if (val == 1) return 1;
            return 0;
        }

        private bool ReturnMoney()
        {
            Console.WriteLine("Return money y/n?");
            string yesNo = Console.ReadLine();

            if (yesNo == "y")
            {
                Console.WriteLine("Returning money...");
                _snackMachine.ReturnMoney();
                return true;
            }
            return false;
        }
    }
}
