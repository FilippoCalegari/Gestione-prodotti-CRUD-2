using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestione_prodotti_CRUD
{
    public partial class Form1 : Form
    {
        public struct Prodotti
        {
            public string Nome;
            public float Prezzo;

        }
        public Prodotti[] p;
        public int dim;
        private void Form1_Load(object sender, EventArgs e)
        {
            p = new Prodotti[100];
            dim = 0;
        }
        public void C()
        {
            p[dim].Nome = txtb_ProductName.Text;
            p[dim].Prezzo = float.Parse(txtb_ProductPrice.Text);
            dim++;
        }
        public void R()
        {
            lb_ProductsList.Items.Clear();
            for (int i = 0; i < dim; i++)
            {
                lb_ProductsList.Items.Add($"{p[i].Nome} {p[i].Prezzo}");
            }
        }
        public void U()
        {
            string researchName = txtb_UpdateProduct.Text;
            string newName = txtb_NewProductName.Text;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].Nome == researchName)
                {
                    p[i].Nome = newName;
                }
            }
        }
        public void D()
        {
            string cancelName = txtb_DeleteProduct.Text;
            bool productExists = false;

            for (int i = 0; i < dim; i++)
            {
                if (p[i].Nome == cancelName)
                {
                    lb_ProductsList.Items.RemoveAt(i);
                    productExists = true;
                    break;
                }
            }

            if (productExists == false)
            {
                MessageBox.Show("Il prodotto non esiste.");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void txtb_ProductName_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtb_ProductPrice_TextChanged(object sender, EventArgs e)
        {

        }
        private void lb_ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            R();
        }
        private void btn_ReadProduct_Click(object sender, EventArgs e)
        {
            R();
        }
        private void btn_AddProduct_Click(object sender, EventArgs e)
        {
            C();
            R();
            lbl_UpdateProduct.Show();
            txtb_UpdateProduct.Show();
            lbl_NewProductName.Show();
            txtb_NewProductName.Show();
            lbl_DeleteProduct.Show();
            txtb_DeleteProduct.Show();
        }
        private void lbl_ProductList_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void lbl_NewProductName_Click(object sender, EventArgs e)
        {

        }
        private void btn_UpdateProduct_Click(object sender, EventArgs e)
        {
            U();
            R();
        }
        private void txtb_UpdateProduct_TextChanged(object sender, EventArgs e)
        {
        
        }
        private void btn_SecondUpdate_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_DeleteProduct_Click(object sender, EventArgs e)
        {
            D();
        }
    }
}
