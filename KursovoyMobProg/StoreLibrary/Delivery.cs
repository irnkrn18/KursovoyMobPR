using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoreLibrary
{
    interface Delivery
    {
        List<Product> getOrder();
        void setOrder(List<Product> pr);
        void postOrder(PictureBox pbGruzov);
    }
}
