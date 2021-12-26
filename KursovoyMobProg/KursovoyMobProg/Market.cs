using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StoreLibrary;

namespace KursovoyMobProg
{
    public partial class Market : Form
    {
        Store store = new Store();
        public Market()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void Click_Op(object sender, EventArgs e)
        {
            store.Open();
        }

        private void Click_Cl(object sender, EventArgs e)
        {
            store.Close();
            dgvCl.Enabled = true;
            dgvCl.DataSource = null;
            dgvCl.DataSource = store.klients;
            dgvCl.Update();
        }

        private void Click_Delivery(object sender, EventArgs e)
        {           
            store.ds.setOrder();
            store.ds.postOrder(pbGruzov);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (store.ds.getReady()) {
                foreach (Product item in store.ds.getOrder())
                {
                    store.products.Add(item);
                }
                store.ds.setReady(false);
            }
            dgvTov.DataSource = null;
            dgvTov.DataSource = store.products;

            dgvBuyer.DataSource = null;
            dgvBuyer.DataSource = store.getPrisutstv();
            //dgvCl.DataSource = null;
            //dgvCl.DataSource = store.klients;
        }

        private void dgvCl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           // if (dgvCl.CurrentRow.Index!=-1)
            dgvTCl.DataSource = store.klients[dgvCl.CurrentRow.Index].myProducts;
        }
    }
}
