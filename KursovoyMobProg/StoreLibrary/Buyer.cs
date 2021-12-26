using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Buyer
    {
        string name = "Default";
        string suname = "Default";
        byte age = 0;      
        public Thread myThread;
        public List<Product> myProducts = new List<Product>();
        static Random r = new Random();
        public Buyer(string n, string sn, byte a)
        {
            name = n;
            suname = sn;
            age = a;            
        }
        public void StartPay((Buyer, List<Product>) date) {
            myThread = new Thread(new ParameterizedThreadStart(Pay));
            myThread.Start(date);
        }
        public void Pay(object obj) {
            (Buyer, List<Product>) data = ((Buyer, List<Product>))obj;//чем больше тов чем больше вероятность покупки  
            Buyer man =data.Item1;
            List<Product> pr = data.Item2;            
            for (int i = 0; i < pr.Count; i++)
            {
                var item = pr[i];
                if (r.Next(10) == 0)
                {
                    man.myProducts.Add(item);
                    pr.Remove(item);
                }
            }
            Thread.Sleep(1000);
            Pay(obj);
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public string Suname
        {
            get
            {
                return suname;
            }
            set
            {
                suname = value;
            }
        }
        public byte Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public int CountTov
        {
            get
            {
                return myProducts.Count;
            }        
        }
    }
}
