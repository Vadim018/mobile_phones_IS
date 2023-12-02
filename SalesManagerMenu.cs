using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    class SalesManagerMenu : IMenu
    {
        ISalesManagerPL salesManagerPL;
        public SalesManagerMenu(ISalesManagerPL salesManagerPL)
        {
            this.salesManagerPL = salesManagerPL;
        }
        public void Run()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1. CREATE MOBILE");
                Console.WriteLine("2. GET MOBILES");
                Console.WriteLine("3. EXIT");

                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        salesManagerPL.CreateMobile();
                        break;

                    case 2:
                        salesManagerPL.GetAllMobile();
                        break;

                    case 3:
                        flag = false;
                        break;

                    default:
                        Console.WriteLine("CHOOSE ONE OF THE POINTS BELOW");
                        break;
                }
            }
        }
    }
}