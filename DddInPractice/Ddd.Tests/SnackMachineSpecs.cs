using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using Ddd.Logic;
using FluentAssertions;
using Xunit;

namespace Ddd.Tests
{

    public class SnackMachineSpecs
    {

        [Fact]
        public void Return_money_empties_money_in_transaction()
        {
            var snackMachine = new SnackMachine();
            snackMachine.InsertMoney(Money.Dollar); // was  snackMachine.InsertMoney(new Money(0, 0, 0, 1, 0, 0));

            snackMachine.ReturnMoney();

            snackMachine.MoneyInTransaction.Amount.Should().Be(0M);
        }


        [Fact]
        public void Inserted_money_goesTo_money_in_transaction()
        {
            var snackMachine = new SnackMachine();
            snackMachine.InsertMoney(Money.Dollar);
            snackMachine.InsertMoney(Money.Cent);
           
            snackMachine.MoneyInTransaction.Amount.Should().Be(1.01M);
        }

        [Fact]
        public void Cannot_insert_more_than_once_coin_or_note_at_a_time()
        {
            var snackMachine  = new SnackMachine();
            var twoCent = Money.Cent + Money.Cent;

            Action action = () => snackMachine.InsertMoney(twoCent);

            action.ShouldThrow<InvalidOperationException>();
        }


        [Fact]
        public void Money_in_transaction_goes_to_money_inside_after_purchase()
        {
            var snackMachine = new SnackMachine();
            snackMachine.InsertMoney(Money.Dollar);
            snackMachine.InsertMoney(Money.Dollar);
            
            snackMachine.BuySnack();

            snackMachine.MoneyInside.Amount.Should().Be(2M);
            snackMachine.MoneyInTransaction.Amount.Should().Be(0M);

        }
    }
}
