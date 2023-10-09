using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        public void C() //Funzione "Crea"
        {
            //Assegna alle variabili i valori scritti dall'utente
            p[dim].Nome = txtb_ProductName.Text;
            p[dim].Prezzo = float.Parse(txtb_ProductPrice.Text);
            dim++;
        }
        public void R() //Funzione "Leggi"
        {
            //Visualizza sulla listbox i prodotti e i prezzi
            lb_ProductsList.Items.Clear(); //La pulisco ogni volta

            for (int i = 0; i < dim; i++)
            {
                lb_ProductsList.Items.Add($"Il prodotto {p[i].Nome} costa {p[i].Prezzo}€.");
            }
        }
        public void U() //Funzione "Modifica"
        {
            string researchName = txtb_UpdateProduct.Text; //Vecchio prodotto da modificare
            string newName = txtb_NewProductName.Text; //Nuovo nome da assegnare

            for (int i = 0; i < dim; i++)
            {
                if (p[i].Nome == researchName)
                {
                    p[i].Nome = newName;
                }
            }
        }
        public void D() //Funzione "Elimina"
        {
            string cancelName = txtb_DeleteProduct.Text; //Nome prodotto da eliminare
            bool productExists = false; //Bool per controllare se esiste

            for (int i = 0; i < dim; i++)
            {
                if (p[i].Nome == cancelName)
                {
                    lb_ProductsList.Items.RemoveAt(i); //Elimina dalla listbox al determinato indice
                    p[i].Nome = null;
                    p[i].Prezzo = 0;
                    productExists = true;
                    break;
                }
            }

            if (productExists == false) //In caso il prodotto inserito non esistesse
            {
                MessageBox.Show("Il prodotto non esiste.");
            }
        }
        public void FindMin() //Funzione "Trovare minimo"
        {
            int i;
            bool ver;

            //Faccio un ordinamento in base al prezzo
            do
            {
                ver = true;

                for (i = 1; i < dim; i++)
                {
                    if (p[i - 1].Prezzo > p[i].Prezzo)
                    {
                        float biggerPrice = p[i - 1].Prezzo;
                        string biggerProductName = p[i - 1].Nome;

                        float lowerPrice = p[i].Prezzo;
                        string lowerProductName = p[i].Nome;

                        p[i].Prezzo = biggerPrice;
                        p[i].Nome = biggerProductName;

                        p[i - 1].Prezzo = lowerPrice;
                        p[i - 1].Nome = lowerProductName;

                        ver = false;
                    }

                }

            } while (ver == false);

            //Prendo il primo valore
            i = 0;

            //Visualizzo il nome e il prezzo
            MessageBox.Show($"Il prodotto col prezzo più basso è {p[i].Nome} che costa {p[i].Prezzo}€.");
        }
        public void FindMax() //Funzione "Trovare massimo"
        {
            int i;
            bool ver;

            //Faccio un ordinamento in base al prezzo
            do
            {
                ver = true;

                for (i = 1; i < dim; i++)
                {
                    if (p[i - 1].Prezzo > p[i].Prezzo)
                    {
                        float biggerPrice = p[i - 1].Prezzo;
                        string biggerProductName = p[i - 1].Nome;

                        float lowerPrice = p[i].Prezzo;
                        string lowerProductName = p[i].Nome;

                        p[i].Prezzo = biggerPrice;
                        p[i].Nome = biggerProductName;

                        p[i - 1].Prezzo = lowerPrice;
                        p[i - 1].Nome = lowerProductName;

                        ver = false;
                    }

                }

            } while (ver == false);

            //Prendo l'ultimo valore
            i = dim - 1;

            //Visualizzo il nome e il prezzo
            MessageBox.Show($"Il prodotto col prezzo più alto è {p[i].Nome} che costa {p[i].Prezzo}€.");
        }
        public void OrdinamentoAlfabetico() //Funzione "Ordinare"
        {
            int scambi = 0;

            do
            {
                scambi = 0;

                for (int i = 0; i < dim - 1; i++)
                {
                    if (string.Compare(p[i + 1].Nome, p[i].Nome) < 0) //Compare prende le prime due lettere, se la prima da minore di 0, allora scambio
                    {
                        string firstLetter = p[i + 1].Nome;
                        string secondLetter = p[i].Nome;

                        p[i].Nome = firstLetter;
                        p[i + 1].Nome = secondLetter;
                        scambi++;
                    }
                }
            } while (scambi != 0);

            for (int i = 0; i < dim; i++)
            {
                lb_ProductsList.Items.Add($"Il prodotto {p[i].Nome} costa {p[i].Prezzo}€.");
            }
        }
        public void SommaPrezzi() //Funzione "Somma"
        {
            float somma = 0;

            for (int i = 0; i < dim; i++)
            {
                somma += p[i].Prezzo;
            }

            MessageBox.Show($"La somma dei prezzi è {somma}.");
        }
        public void PercentSum() //Funzione "Sommare percentuale"
        {
            float discount = float.Parse(txtb_Percentuale.Text); //"Sconto" da applicare
            float finalPrice = 0;

            for (int i = 0; i < dim; i++)
            {
                finalPrice = (p[i].Prezzo * discount) / 100;
                p[i].Prezzo += finalPrice; //Sommo
            }

        }
        public void PercentSub() //Funzione "Sottrarre percentuale"
        {
            float discount = float.Parse(txtb_Percentuale.Text); //"Sconto" da applicare
            float finalPrice = 0;

            for (int i = 0; i < dim; i++)
            {
                finalPrice = (p[i].Prezzo * discount) / 100;
                p[i].Prezzo -= finalPrice; //Sottraggo
            }
        }
        public void ReadFromFile() //Funzione "Leggere da file"
        {
            string fileLine; //Riga dal file
            string[] splittedLine = new string[3]; //Array che conterrà la riga splittata
            int j = 0;

            using (StreamReader fileRead = new StreamReader(@"Articoli.CSV"))
            {
                do
                {
                    fileLine = fileRead.ReadLine();

                    if (fileLine != null)
                    {
                        splittedLine = fileLine.Split(';'); //Splitto secondo il ";" e butto nell'array
                        p[j].Nome = splittedLine[0]; //Prima parte è il nome
                        p[j].Prezzo = float.Parse(splittedLine[1]); //Seconda parte è il prezzo
                        lb_ProductsList.Items.Add($"Il prodotto {splittedLine[0]} costa {float.Parse(splittedLine[1])}€."); //Rappresento nella listbox
                        j++;
                    }
                }
                while (!fileRead.EndOfStream);
            }
        }
        public void WriteOnFile() //Funzione "Scrivi su file"
        {
            using (StreamWriter fileWrite = File.AppendText("Articoli.csv"))
            {
                for (int i = 0; i < dim; i++)
                {
                    fileWrite.WriteLine($"{p[i].Nome};{p[i].Prezzo}");
                }
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

        private void btn_FindMin_Click(object sender, EventArgs e)
        {
            FindMin();
        }

        private void btn_FindMax_Click(object sender, EventArgs e)
        {
            FindMax();
        }

        private void btn_OrdinamenteAlfabetico_Click(object sender, EventArgs e)
        {
            lb_ProductsList.Items.Clear();
            OrdinamentoAlfabetico();
        }

        private void btn_PriceSumm_Click(object sender, EventArgs e)
        {
            SommaPrezzi();
        }

        private void btn_PercentOperations_Click(object sender, EventArgs e)
        {
            lbl_Percent.Show();
            txtb_Percentuale.Show();
            btn_Sommare.Show();
            btn_Sottrarre.Show();
        }

        private void btn_ReadFromFile_Click(object sender, EventArgs e)
        {
            ReadFromFile();
            lbl_UpdateProduct.Show();
            txtb_UpdateProduct.Show();
            lbl_NewProductName.Show();
            txtb_NewProductName.Show();
            lbl_DeleteProduct.Show();
            txtb_DeleteProduct.Show();
        }

        private void btn_SaveOnFile_Click(object sender, EventArgs e)
        {
            WriteOnFile();
        }

        private void btn_Sommare_Click(object sender, EventArgs e)
        {
            PercentSum();
            R();
        }

        private void btn_Sottrarre_Click(object sender, EventArgs e)
        {
            PercentSub();
            R();
        }
    }
}
