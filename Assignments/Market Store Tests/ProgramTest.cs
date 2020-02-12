namespace Market_Store_Tests
{
    using Market_Store;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;

    [TestFixture]
    public class ProgramTest
    {
        private ICard card;

        [Test]
        public void ValidateAllBronzeCardResult()
        {
            var turnovers = new List<decimal>()
            {
                0, 1, 99, 100, 101, 150, 300, 303, 599
            };

            var expectedResults = new List<string>()
            {
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 0.0%{Environment.NewLine}Discount: $0.00{Environment.NewLine}Total: $150.00",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 0.0%{Environment.NewLine}Discount: $0.00{Environment.NewLine}Total: $150.00",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 0.0%{Environment.NewLine}Discount: $0.00{Environment.NewLine}Total: $150.00",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 1.0%{Environment.NewLine}Discount: $1.50{Environment.NewLine}Total: $148.50",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 1.0%{Environment.NewLine}Discount: $1.50{Environment.NewLine}Total: $148.50",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 1.0%{Environment.NewLine}Discount: $1.50{Environment.NewLine}Total: $148.50",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 1.0%{Environment.NewLine}Discount: $1.50{Environment.NewLine}Total: $148.50",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 2.5%{Environment.NewLine}Discount: $3.75{Environment.NewLine}Total: $146.25",
                $"Purchase value: $150.00{Environment.NewLine}Discount rate: 2.5%{Environment.NewLine}Discount: $3.75{Environment.NewLine}Total: $146.25"
            };

            var purchaseValue = 150;

            for (int i = 0; i < turnovers.Count; i++)
            {
                this.card = new BronzeCard(turnovers[i]);
                string actualResult = PayDesk.CalulateDiscount(purchaseValue, this.card);

                Assert.AreEqual(expectedResults[i], actualResult);
            }
        }

        [Test]
        public void ValidateAllSilverCardResult()
        {
            var turnovers = new List<decimal>()
            {
                0, 1, 300, 350, 850
            };

            var expectedResults = new List<string>()
            {
                $"Purchase value: $600.00{Environment.NewLine}Discount rate: 2.0%{Environment.NewLine}Discount: $12.00{Environment.NewLine}Total: $588.00",
                $"Purchase value: $600.00{Environment.NewLine}Discount rate: 2.0%{Environment.NewLine}Discount: $12.00{Environment.NewLine}Total: $588.00",
                $"Purchase value: $600.00{Environment.NewLine}Discount rate: 2.0%{Environment.NewLine}Discount: $12.00{Environment.NewLine}Total: $588.00",
                $"Purchase value: $600.00{Environment.NewLine}Discount rate: 3.5%{Environment.NewLine}Discount: $21.00{Environment.NewLine}Total: $579.00",
                $"Purchase value: $600.00{Environment.NewLine}Discount rate: 3.5%{Environment.NewLine}Discount: $21.00{Environment.NewLine}Total: $579.00"
            };

            var purchaseValue = 600;

            for (int i = 0; i < turnovers.Count; i++)
            {
                this.card = new SilverCard(turnovers[i]);
                string actualResult = PayDesk.CalulateDiscount(purchaseValue, this.card);

                Assert.AreEqual(expectedResults[i], actualResult);
            }
        }

        [Test]
        public void ValidateAllGoldCardResult()
        {
            var turnovers = new List<decimal>()
            {
                0, 1, 99, 100, 101, 250, 300, 444, 800, 1000
            };

            var expectedResults = new List<string>()
            {
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 2.0%{Environment.NewLine}Discount: $26.00{Environment.NewLine}Total: $1274.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 2.0%{Environment.NewLine}Discount: $26.00{Environment.NewLine}Total: $1274.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 2.0%{Environment.NewLine}Discount: $26.00{Environment.NewLine}Total: $1274.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 3.0%{Environment.NewLine}Discount: $39.00{Environment.NewLine}Total: $1261.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 3.0%{Environment.NewLine}Discount: $39.00{Environment.NewLine}Total: $1261.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 4.0%{Environment.NewLine}Discount: $52.00{Environment.NewLine}Total: $1248.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 5.0%{Environment.NewLine}Discount: $65.00{Environment.NewLine}Total: $1235.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 6.0%{Environment.NewLine}Discount: $78.00{Environment.NewLine}Total: $1222.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 10.0%{Environment.NewLine}Discount: $130.00{Environment.NewLine}Total: $1170.00",
                $"Purchase value: $1300.00{Environment.NewLine}Discount rate: 10.0%{Environment.NewLine}Discount: $130.00{Environment.NewLine}Total: $1170.00",
            };

            var purchaseValue = 1300;

            for (int i = 0; i < turnovers.Count; i++)
            {
                this.card = new GoldCard(turnovers[i]);
                string actualResult = PayDesk.CalulateDiscount(purchaseValue, this.card);

                Assert.AreEqual(expectedResults[i], actualResult);
            }
        }
    }
}