using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    class MainMenu : IMenu
    {
        IMenu salesManagerMenu;
        public MainMenu(IMenu salesManagerMenu)
        {
            this.salesManagerMenu = salesManagerMenu;
        }
        public void Run()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("1 - SALESMANAGER MENU");
                Console.WriteLine("2 - EXIT");

                int menuNumber = Convert.ToInt32(Console.ReadLine());

                switch (menuNumber)
                {
                    case 1:
                        salesManagerMenu.Run();
                        break;
                    case 2:
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