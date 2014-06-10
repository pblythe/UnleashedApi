using NUnit.Framework;
using UnleashedApi.Extensions;
using UnleashedApi.Models;

namespace UnleashedApi.Tests
{
    [TestFixture]
    public class SalesOrderExtensions
    {
        [Test]
        public void CalculateLineLineTotals()
        {
            var line = new SalesOrderLine();
            line.OrderQuantity = 10;
            line.BCUnitPrice = 10.99m;
            line.CalculcateTotals(0, 1);
            Assert.AreEqual(109.9m, line.LineTotal);
            Assert.AreEqual(109.9m, line.BCLineTotal);
        }
    }
}
