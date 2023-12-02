using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    interface IDBItemDAL<T> where T : IID
    {
        List<T> Items { get; set; }
        public void AddItem(T item);
    }
}