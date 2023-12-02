using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
namespace L8
{
    class DBItemDAL<T> : IDBItemDAL<T> where T : IID
    {
        int counter = 1;
        public List<T> Items { get; set; }
        public DBItemDAL()
        {
            Items = new List<T>();
        }
        public void AddItem(T item)
        {
            item.Id = counter++;
            Items.Add(item);
        }
    }
}