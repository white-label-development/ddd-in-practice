using System;
using System.Collections.Generic;
using System.Linq;
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
            snackMachine.InsertMoney(new Money(0, 0, 0, 1, 0, 0));

            snackMachine.ReturnMoney();

            snackMachine.MoneyInTransaction.Amount.Should().Be(0M);
        }
    }
}
