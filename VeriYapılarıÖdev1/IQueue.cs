using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdev1
{
    public interface IQueue
    {
        void Enqueue(object o);
        object Dequeue();
        Boolean IsEmpty();
        string Display();
        object Peek();
        void NotEkle(Notlar not);
      
    }
}
