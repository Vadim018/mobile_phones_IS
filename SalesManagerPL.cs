using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    class SalesManagerPL : ISalesManagerPL
    {
        IMobilePhoneBLL mobilePhoneBLL;
        public SalesManagerPL(IMobilePhoneBLL mobilePhoneBLL)
        {
            this.mobilePhoneBLL = mobilePhoneBLL;
        }
        public void CreateMobile()
        {
            Console.Write("BRAND: ");
            string brand = Console.ReadLine();

            Console.Write("MODEL: ");
            string model = Console.ReadLine();
            mobilePhoneBLL.CreateMobile(brand, model);
        }
        public void GetAllMobile()
        {
            List<MobilePhone> mobilePhones = mobilePhoneBLL.GetAllMobile();

            foreach(MobilePhone mobilePhone in mobilePhones)
            {
                Console.WriteLine(mobilePhone);
            }
        }
    }
}