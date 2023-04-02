using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static THA_Winform_W5.Form1;

namespace THA_Winform_W5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataTable dataSimpan = new DataTable();
        DataTable dataTampil = new DataTable();
        DataTable dataCategory = new DataTable();
        List<Product> produk = new List<Product>();
        List<string> category = new List<string>();
        List<char> charList = new List<char>();
        int count = 5;
        int hitung = 0;
        bool ada = false;
        public class Product
        {
            public string IDProduct { get; set; }
            public string Nama { get; set; }
            public string Harga { get; set; }
            public string Stock { get; set; }
            public string IDCat { get; set; }
            public Product(string Nama, string Harga, string Stock, string idcat)
            {
                //this.IDProduct = IDProduct;
                this.Nama = Nama;
                this.Harga = Harga;
                this.Stock = Stock;
                this.IDCat = idcat;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxFilter.Enabled = false;
            dataTampil.Columns.Add("ID Product");
            dataTampil.Columns.Add("Nama Product");
            dataTampil.Columns.Add("Harga");
            dataTampil.Columns.Add("Stock");
            dataTampil.Columns.Add("ID Category");

            dataSimpan.Columns.Add("ID Product");
            dataSimpan.Columns.Add("Nama Product");
            dataSimpan.Columns.Add("Harga");
            dataSimpan.Columns.Add("Stock");
            dataSimpan.Columns.Add("ID Category");
            dataGridViewProduct.DataSource = dataSimpan;

            dataCategory.Columns.Add("ID Category");
            dataCategory.Columns.Add("Nama Category");
            dataGridViewCat.DataSource = dataCategory;

            produk.Add(new Product("Jas Hitam", "100000", "10", "Jas"));
            produk.Add(new Product("T-Shirt Black Pink", "70000", "20", "T-Shirt"));
            produk.Add(new Product("T-Shirt Obsessive", "75000", "16", "T-Shirt"));
            produk.Add(new Product("Rok Mini", "82000", "26", "Rok"));
            produk.Add(new Product("Jeans Biru", "90000", "5", "Celana"));
            produk.Add(new Product("Celana Pendek Coklat", "60000", "11", "Celana"));
            produk.Add(new Product("Cawat Blink-blink", "1000000", "1", "Cawat"));
            produk.Add(new Product("Rocca Shirt", "50000", "8", "T-Shirt"));

            foreach (Product prod in produk)
            {
                IDProduct(prod);
            }
            foreach (Product prod in produk)
            {
                if (!category.Contains(prod.IDCat))
                {
                    category.Add(prod.IDCat);
                }
            }

            for (int i = 0; i < category.Count; i++)
            {
                dataCategory.Rows.Add("C" + (i + 1), category[i]);
                foreach (Product prod in produk)
                {
                    if (prod.IDCat == category[i])
                    {
                        prod.IDCat = "C" + (i + 1);
                    }
                }
            }

            foreach (Product a in produk)
            {
                dataSimpan.Rows.Add(a.IDProduct, a.Nama, a.Harga, a.Stock, a.IDCat);
            }

            for (int i = 0; i < category.Count; i++)
            {
                comboBoxFilter.Items.Add(category[i].ToString());
                comboBoxCat.Items.Add(category[i].ToString());
            }

        }
        private void IDProduct(Product product)
        {
            charList.Add(Convert.ToChar(product.Nama[0]));
            foreach (char a in charList)
            {
                if (product.Nama[0] == a)
                {
                    hitung++;
                }
            }
            product.IDProduct = Convert.ToChar(product.Nama[0]) + hitung.ToString("000");
            hitung = 0;
        }
        private void IDCategory(Product product)
        {
            for (int i = 0; i < dataCategory.Rows.Count; i++)
            {
                if (product.IDCat == dataCategory.Rows[i][1].ToString())
                {
                    product.IDCat = dataCategory.Rows[i][0].ToString();
                }
            }
        }
        private void buttonFilter_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Enabled = true;
            comboBoxFilter.Items.Clear();
            foreach (string a in category)
            {
                comboBoxFilter.Items.Add(a);
            }
        }
        private void buttonAll_Click(object sender, EventArgs e)
        {
            comboBoxFilter.Text = "";
            dataTampil.Rows.Clear();
            comboBoxFilter.Enabled = false;
            dataGridViewProduct.DataSource = dataSimpan;
           
        }
        private void buttonAddCat_Click(object sender, EventArgs e)
        {
            Product prod = new Product(textBoxNamaDetails.Text, textBoxHarga.Text, textBoxStock.Text, textBoxNamaCat.Text);
            if (textBoxNamaCat.Text != "")
            {
                if (!category.Contains(textBoxNamaCat.Text))
                {
                    category.Add(textBoxNamaCat.Text);
                    count++;
                    dataCategory.Rows.Add("C" + count, textBoxNamaCat.Text);
                    IDCategory(prod);
                }
                else
                {
                    MessageBox.Show("Category sudah ada", "Error");
                }
            }
            else
            {
                MessageBox.Show("Masukkan nama category terlebih dahulu", "Error");
            }
            comboBoxFilter.Items.Clear();
            comboBoxCat.Items.Clear();
            for (int i = 0; i < dataCategory.Rows.Count; i++)
            {
                comboBoxCat.Items.Add(dataCategory.Rows[i][1].ToString());
                comboBoxFilter.Items.Add(dataCategory.Rows[i][1].ToString());
            }
            textBoxNamaDetails.Text = "";
            comboBoxCat.Text = "";
            textBoxHarga.Text = "";
            textBoxStock.Text = "";
            textBoxNamaCat.Text = "";
        }
        private void buttonRemovecat_Click(object sender, EventArgs e)
        {
            dataGridViewProduct.DataSource = dataSimpan;
            int select = dataGridViewCat.CurrentCell.RowIndex;
            for (int i = 0; i < dataSimpan.Rows.Count; i++)
            {
                if (dataSimpan.Rows[i][4].ToString() == dataCategory.Rows[select][0].ToString())
                {
                    dataSimpan.Rows.RemoveAt(i);
                    i = 0;
                }
            }
            category.Remove(dataCategory.Rows[select][1].ToString());
            dataCategory.Rows.RemoveAt(select);

            comboBoxCat.Items.Remove(dataCategory.Rows[select][1].ToString());
            comboBoxFilter.Items.Remove(dataCategory.Rows[select][1].ToString());
        }
        private void comboBoxCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            Product prod = new Product(textBoxNamaDetails.Text, textBoxHarga.Text, textBoxStock.Text, comboBoxCat.Text);
            if (textBoxNamaDetails.Text != "" && comboBoxCat.Text != "" && textBoxHarga.Text != "" && textBoxStock.Text != "")
            {
                for (int i = 0; i < dataSimpan.Rows.Count; i++)
                {
                    if (textBoxNamaDetails.Text == dataSimpan.Rows[i][1].ToString())
                    {
                        MessageBox.Show("Nama sudah ada", "Error");
                        ada = true;
                    }
                }
                if (ada == false)
                {
                    for (int i = 0; i < dataCategory.Rows.Count; i++)
                    {
                        if (dataCategory.Rows[i][1].ToString() == comboBoxCat.Text)
                        {
                            produk.Add(prod);
                            IDCategory(prod);
                            IDProduct(prod);
                            dataSimpan.Rows.Add(prod.IDProduct, prod.Nama, prod.Harga, prod.Stock, prod.IDCat);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Input yang lengkap ya", "Error");
            }
            textBoxNamaDetails.Text = "";
            comboBoxCat.Text = "";
            textBoxHarga.Text = "";
            textBoxStock.Text = "";
        }
        private void buttonEditCat_Click(object sender, EventArgs e)
        {
            if (textBoxNamaDetails.Text != "" && textBoxHarga.Text != "" && textBoxStock.Text != "" && comboBoxCat.Text != "")
            {
                int select = dataGridViewProduct.CurrentCell.RowIndex;
                string produkid = dataSimpan.Rows[select][0].ToString();
                dataSimpan.Rows.Clear();
                foreach (Product prod in produk)
                {
                    if (produkid == prod.IDProduct)
                    {
                        prod.Nama = textBoxNamaDetails.Text;
                        prod.Harga = textBoxHarga.Text;
                        prod.Stock = textBoxStock.Text;
                        prod.IDCat = comboBoxCat.Text;
                        IDCategory(prod);
                        if (prod.IDProduct[0] != textBoxNamaDetails.Text[0])
                        {
                            IDProduct(prod);
                        }
                        dataSimpan.Rows.Clear();
                        foreach (Product produk in produk)
                        {
                            dataSimpan.Rows.Add(produk.IDProduct, produk.Nama, produk.Harga, produk.Stock, produk.IDCat);
                        }

                    }
                }

            }
            else
            {
                MessageBox.Show("Pilih produk yang mau diedit terlebih dahulu", "Error");
            }
            textBoxNamaDetails.Text = "";
            comboBoxCat.Text = "";
            textBoxHarga.Text = "";
            textBoxStock.Text = "";
        }
        private void buttonRemovaProduct_Click(object sender, EventArgs e)
        {
            dataSimpan.Rows.RemoveAt(dataGridViewProduct.CurrentCell.RowIndex);
        }
        private void comboBoxFilter_SelectedChangeCommitted(object sender, EventArgs e)
        {
            dataTampil.Rows.Clear();
            dataGridViewProduct.DataSource = dataTampil;
            
            foreach (Product produk in produk)
            {
                for (int i = 0; i < dataCategory.Rows.Count; i++)
                {
                    if (dataCategory.Rows[i][1].ToString() == comboBoxFilter.Text && produk.IDCat == dataCategory.Rows[i][0].ToString()) //&& produk.Nama == dataSimpan.Rows[i][1].ToString())
                    {
                        dataTampil.Rows.Add(produk.IDProduct, produk.Nama, produk.Harga, produk.Stock, produk.IDCat);
                    }
                }
            }
        }

        private void dataGridViewProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Product product in produk)
            {
                if (dataGridViewProduct.CurrentRow.Cells["Nama Product"].Value.ToString() == product.Nama)
                {
                    textBoxNamaDetails.Text = product.Nama;
                    comboBoxCat.Text = product.IDCat;
                    textBoxHarga.Text = product.Harga;
                    textBoxStock.Text = product.Stock;
                    for (int i = 0; i< dataCategory.Rows.Count; i++)
                    {
                        if (dataCategory.Rows[i][0].ToString() == product.IDCat)
                        {
                            comboBoxCat.Text = dataCategory.Rows[i][1].ToString();
                        }
                    }
                }
            }
        }
    }
}
