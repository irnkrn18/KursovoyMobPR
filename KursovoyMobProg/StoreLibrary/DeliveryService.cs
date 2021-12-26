using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace StoreLibrary
{
    public class DeliveryService:Delivery
    {
        //PictureBox pb;
        List<Product> order = new List<Product>();
        Thread myThread;
        static int step = -2;
        static bool ready=false;

        public bool getReady() { return ready; }
        public void setReady(bool b) { ready = b; }
        public List<Product> getOrder()
        {
            return order;            
        }
        public void setOrder(List<Product> pr)
        {
            order = pr;           
        }
        public void setOrder()
        {
            List<Product> pr = new List<Product>();
            Random r = new Random();
            for (int i = 0; i < 5; i++)
            {                
                pr.Add(CreateRandomProduct(r));
            }
            order = pr;
        }
        Product CreateRandomProduct(Random r)
        {
            string[] names = { "Свитер", "Шарф", "Шапка", "Перчатки" };
           
            return new Product(names[r.Next(names.Length)], Math.Round(r.NextDouble() * 100,1));
        }
        public void postOrder(PictureBox pbGruzov)
        {
            myThread = new Thread(new ParameterizedThreadStart(Go));
            myThread.Start(pbGruzov);
        }

        
        public static void Go(object obj) {
            //bool gruz = true;
            PictureBox pb=(PictureBox)obj;
            if (pb.Location.X <= 430)
            {
                pb.Image = Image.FromFile("Img//Gruzovik.png");
                Thread.Sleep(1500);
                step = 2;
                ready = true; 
            }
            else if (pb.Location.X >= 614)
            {
                pb.Image = Image.FromFile("Img//GruzovikGo.png");
            }
            if (pb.Location.X >= 616)
            {                
                step = -2;
                pb.Invoke((MethodInvoker)delegate
                {                  
                    pb.Location = new Point(pb.Location.X + step, pb.Location.Y);
                });
                Thread.CurrentThread.Abort();
            }
            pb.Invoke((MethodInvoker)delegate
            {
                // Running on the UI thread
                pb.Location = new Point(pb.Location.X + step, pb.Location.Y);
            });
            Thread.Sleep(20);
            Go(pb);
        }
                    
          
    }
}
