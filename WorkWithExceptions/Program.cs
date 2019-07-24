using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkWithExceptions
{
        class Program
        {
            static void Main(string[] args)
            {
                Sale venda = new Sale
                {
                    Id = 1,
                    Data = DateTime.Today
                };

                Product item1 = new Product
                {
                    Description = "Smartphone",
                    Price = 2000,
                    Quantity = 1
                };

                Product item2 = null;

                try
                {
                    venda.AdicionarItem(item1);
                    venda.AdicionarItem(item2);
                    Console.WriteLine(venda.Sum());
                }
                catch (NullReferenceException e)
                {
                    Console.WriteLine(e.StackTrace);
                }
                catch (SaleException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("Process finished");
                }

                Console.ReadKey();
            }
        }
    }
