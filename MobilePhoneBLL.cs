using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    class MobilePhoneBLL : IMobilePhoneBLL
    {
        IDBItemDAL<MobilePhone> dbMobilePhone;
        public MobilePhoneBLL(IDBItemDAL<MobilePhone> dbMobilePhone)
        {
            this.dbMobilePhone = dbMobilePhone;
        }
        public void CreateMobile(string brand, string model)
        {
            MobilePhone phone = new MobilePhone(brand, model);
            dbMobilePhone.AddItem(phone);
        }
        public List<MobilePhone> GetAllMobile()
        {
            return dbMobilePhone.Items;
        }
    }
}