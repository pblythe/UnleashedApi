using System;
using System.Linq;
using UnleashedApi.Models;

namespace UnleashedApi.Extensions
{
    public static class SalesOrderExtensions
    {
        public static SalesOrder CalcluateTotals(this SalesOrder salesOrder)
        {
            if (salesOrder == null)
                throw new ArgumentNullException("salesOrder");

            var taxModelRate = salesOrder.Tax != null ? salesOrder.Tax.TaxRate : 0;
            var taxRate = salesOrder.TaxRate ?? taxModelRate;
            var exchangeRate = salesOrder.ExchangeRate ?? 1;

            foreach (var line in salesOrder.SalesOrderLines)
                CalculcateTotals(line, taxRate, exchangeRate);

            var lines = salesOrder.SalesOrderLines;
            salesOrder.BCTaxTotal = lines.Sum(p => p.BCLineTax);
            salesOrder.BCSubTotal = lines.Sum(p => p.BCLineTotal);
            salesOrder.BCTotal = salesOrder.BCSubTotal + salesOrder.BCTaxTotal;

            salesOrder.TaxTotal = lines.Sum(p => p.LineTax);;
            salesOrder.SubTotal = lines.Sum(p => p.LineTotal);
            salesOrder.Total = salesOrder.SubTotal + salesOrder.TaxTotal;
            
            return salesOrder;
        }

        public static SalesOrderLine CalculcateTotals(this SalesOrderLine line, decimal taxRate, decimal exchangeRate)
        {
            var itemTaxRate = line.TaxRate ?? taxRate;
            line.BCLineTotal = line.BCUnitPrice * line.OrderQuantity;
            line.BCLineTax = line.BCLineTotal * itemTaxRate;
            line.LineTotal = line.BCLineTotal * exchangeRate;
            line.LineTax = line.BCLineTax * exchangeRate;
            line.UnitPrice = line.BCUnitPrice * exchangeRate;
            return line;
        }
    }
}
