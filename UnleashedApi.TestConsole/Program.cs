using System;
using System.Linq;
using System.Threading.Tasks;
using UnleashedApi.Extensions;
using UnleashedApi.Models;

namespace UnleashedApi.TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncMain();

            Console.ReadLine();
        }

        static async void AsyncMain()
        {

            var client = new UnleashedClient("", "");

            var t1 = client.SalesInvoice.List();
            var t2 = client.PaymentTerms.List();

            Task.WaitAll(t1, t2);

            var salesperson = (await client.SalesPersons.List()).FirstOrDefault();
            var tax = (await client.Taxes.List()).First();

            var salesorder = new SalesOrder();
            salesorder.Customer = new LinkedCustomer("ACE001");
            salesorder.CustomerRef = "PO00001";
            salesorder.DeliveryCity = "DCITY";
            salesorder.DeliveryCountry = "DCOUNTRY";
            salesorder.DeliveryName = "DNAME";
            salesorder.DeliveryPostCode = "DPOST";
            salesorder.DeliveryRegion = "DREGION";
            salesorder.DeliveryStreetAddress = "DSTREET";
            salesorder.DeliverySuburb = "RSUBURB";
            salesorder.OrderDate = new DateTime(2014, 4, 4);
            salesorder.OrderStatus = "Placed";
            salesorder.Tax = tax;
            salesorder.SalesPerson = salesperson;

            var item = new SalesOrderLine();
            item.Guid = new Guid();
            item.BCUnitPrice = 10.990m;
            item.OrderQuantity = 1;
            item.LineNumber = 1;
            item.Product = new LinkedProduct("MTU001");
            salesorder.SalesOrderLines.Add(item);

            salesorder.CalcluateTotals();
            await client.SalesOrders.Add(salesorder);

            Console.ReadLine();
        }
    }
}
