using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using CoffeePointOfSale.Services.Customer;
using System.Diagnostics;
using CoffeePointOfSale.Services.Storage;
using CoffeePointOfSale.Configuration;

namespace CoffeePointOfSale.Services.CsvExtract
{
    public class CsvExtract : ICsvExtract
    {
        private readonly ICustomerService _customerService;

        public CsvExtract(ICustomerService customerService) 
        {
            _customerService = customerService;
        }
        public void Extract() 
        {
            var customers = _customerService.Customers.List;
            var csvExtractLines = new List<CsvExtractLine>();

            foreach (var customer in customers)
            {
                foreach (var order in customer.Orders)
                {
                    var csvExtractLine = new CsvExtractLine
                    {
                        CustomerId = customer.Phone,
                        OrderDate = DateTime.Parse(order.Date),
                        Subtotal = String.Format("{0:0.00}" , order.Subtotal),
                        OrderTax = String.Format("{0:0.00}", order.Tax),
                        OrderTotalPrice = String.Format("{0:0.00}", order.Total),
                        Payment = order.Card,
                        OrderDetails = order.ToString(),
                    };

                    csvExtractLines.Add(csvExtractLine);
                }
            }

            var outputDirectory = Path.GetTempPath(); //find OS temp directory
            var csvFilename = $"output_{DateTime.Now.Ticks}.csv";
            var csvPathAndFilename = Path.Join(outputDirectory, csvFilename);

            //write csvExtractLines via CSVHelper
            using (var writer = new StreamWriter(csvPathAndFilename))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(csvExtractLines);
            }

            //attempt to open in Excel (or whatever is registered to open .csv files on the machine)
            try
            {
                var processStartInfo = new ProcessStartInfo(csvPathAndFilename)
                {
                    WorkingDirectory = outputDirectory,
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Failed to open [{csvPathAndFilename}]: {ex.Message}");
            }
        }
    }
    public class CsvExtractLine
    {
        public string? CustomerId { get; set; }
        public DateTime? OrderDate { get; set; }
        public string? Subtotal { get; set; }
        public string? OrderTax { get; set; }
        public string? OrderTotalPrice { get; set; }
        public string? Payment { get; set; }
        public string? OrderDetails { get; set; }
    }
}
