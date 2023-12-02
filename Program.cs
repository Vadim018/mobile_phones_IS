/* 

|-----------------------------------------------------------------------------------------------------------------------|
| Завдання L8                                                                                                           |
|-----------------------------------------------------------------------------------------------------------------------|
| Створити в окремому класі DBItemDAL колекцію об'єктів класу MobilePhone та вивести інформацію щодо колекції на консоль|
| Клас повинен мати такі поля:                                                                                          |
| 'Id' 'Brand' 'Model'                                                                                                  |
| Окремий клас DBItemDAL повинен мати інтерфейс та такі методи:                                                         |
|  * додавання елемента до колекції;                                                                                    |
|  * отримання всіх елементів з колекції;                                                                               |
|  * пошук елемента по 'Id';                                                                                            |
|  * видалення елемента з колекції;                                                                                     |
|  * заміна старого елемента на новий.                                                                                  |
| Створити окремий клас MobilePhoneBLL з інтерфейсом, методи якого використовують методи класу з колекцією.             |
| Створити окремий клас SalesManagerPL з інтерфейсом, методи якого використовують методи класу MobilePhoneBLL.          |
| Створити дворівневе меню: MainMenu та SalesManagerMenu.                                                               |
| Кожне меню в окремому класі.                                                                                          |
|-----------------------------------------------------------------------------------------------------------------------|

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    class Program
    {
        static void Main()
        {
            IDBItemDAL<MobilePhone> dbMobilePhone = new DBItemDAL<MobilePhone>();

            MobilePhone mobilePhone1 = new MobilePhone("HUAWEI", "P SMART PRO");
            dbMobilePhone.AddItem(mobilePhone1);

            MobilePhone mobilePhone2 = new MobilePhone("SAMSUNG", "GALAXY S23");
            dbMobilePhone.AddItem(mobilePhone2);

            MobilePhone mobilePhone3 = new MobilePhone("XIAOMI", "MI 13 LITE");
            dbMobilePhone.AddItem(mobilePhone3);

            IMobilePhoneBLL mobilePhoneBLL = new MobilePhoneBLL(dbMobilePhone);

            ISalesManagerPL salesManagerPL = new SalesManagerPL(mobilePhoneBLL);

            IMenu salesManagerMenu = new SalesManagerMenu(salesManagerPL);

            IMenu mainMenu = new MainMenu(salesManagerMenu);

            mainMenu.Run();

            Console.ReadKey();
        }
    }
}