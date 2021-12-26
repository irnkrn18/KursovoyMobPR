using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Store
    {
        public List<Product> products = new List<Product>();
        public List<Buyer> klients = new List<Buyer>();
        public DeliveryService ds = new DeliveryService();
        Thread myThread;
        public void Open() {
            myThread=new Thread(new ParameterizedThreadStart(PosBuyers));
            myThread.Start((klients,products));
        }
        static Buyer CreateRandomBuyer(Random r)
        {
            string[] names = { "Иван", "Нина", "Аня", "Глеб", "Витя" };
            string[] sunames = { "Шевченко", "Ненько", "Паценко", "Луценко", "Онегих" };
            return new Buyer(names[r.Next(names.Length)], sunames[r.Next(sunames.Length)], (byte)(r.Next(65)+16) );
        }
        static void PosBuyers(object obj)
        {
            (List<Buyer>, List<Product>) data= ((List<Buyer>, List<Product>))obj;
            List<Buyer> klients = data.Item1;
            List<Product> products = data.Item2;
            Random r = new Random();
            if (r.Next(5) == 0)
            {
                Buyer buyer = CreateRandomBuyer(r);
                klients.Add(buyer);
                buyer.StartPay((buyer,products));         
            }
            if ((r.Next(10-klients.Count) == 0) && (klients.Count!=0))
            {
                klients[r.Next(klients.Count)].myThread.Abort();
            }
            Thread.Sleep(2000);
            PosBuyers(obj);
        }
        public void Close() {
            foreach (var item in klients)
            {
                item.myThread.Abort();           
            }
            myThread.Abort();
        }

        public List<Buyer> getPrisutstv() {
            List<Buyer> lb = new List<Buyer>();
            foreach (var item in klients)
            {
                if(item.myThread.IsAlive)
                lb.Add(item);
            }
            
            return lb; 
        }
    }
}
