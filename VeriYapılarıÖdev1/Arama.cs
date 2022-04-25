using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdev1
{
    public class Arama: IQueue
    {
        private static object[] arama;
        private int front = 0;
        private int rear = 0;
        private int size = 0;
        private int count = 0;
        public Arama(int s)
        {
            size = s;
            arama = new object[size];
        }
        List<Notlar> Not = new List<Notlar>();
        // Enqueue fonksiyonu kuyruğa yeni eleman eklenmesini sağlar.
        public void Enqueue(object o)
        {
            if (size == rear)
                throw new Exception("Aramalar dolu.");
            else
            {
                arama[rear] = o;

                rear++;
            }
        }
        // Dequeue fonksiyonu kuyruğun başındaki elemanı siler.
       public object Dequeue()
        {
            if (front == rear)
                throw new Exception("Aramalar boş.");
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    arama[i] = arama[i + 1];
                }

                if (rear < size)
                    arama[rear] = 0;


                rear--;
            }
            return rear; 

        }
        // ISEmpty kuyruğun boş olmadığının kontrolünü sağlar.
        public Boolean IsEmpty()
        {
            return (count == 0);
        }
        //Display fonksiyonu ekrana yazdırmak için kullanılır.
        public string Display()
        {
            string eleman = "";
            for (int i = front; i < rear; i++)
            { 
               eleman += "->" + arama[i];
            }
            return eleman;
       }
        // Peek fonksiyonu kuyruğun ilk elemanını verir.
        public Object Peek()
        {
            return front;
        }
        // Temsilci not ekleyebilir.
        public void NotEkle(Notlar not)
        {
            Not.Add(not);
        }
       

    }
    }

