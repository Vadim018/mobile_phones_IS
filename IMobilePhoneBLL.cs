using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    interface IMobilePhoneBLL
    {
        void CreateMobile(string brand, string model);
        List<MobilePhone> GetAllMobile();
    }
}