namespace THA_Winform_W5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonRemovaProduct = new System.Windows.Forms.Button();
            this.buttonEditCat = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.comboBoxCat = new System.Windows.Forms.ComboBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.textBoxHarga = new System.Windows.Forms.TextBox();
            this.textBoxNamaDetails = new System.Windows.Forms.TextBox();
            this.labelNamaDet = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRemovecat = new System.Windows.Forms.Button();
            this.buttonAddCat = new System.Windows.Forms.Button();
            this.textBoxNamaCat = new System.Windows.Forms.TextBox();
            this.labelNamaCat = new System.Windows.Forms.Label();
            this.dataGridViewCat = new System.Windows.Forms.DataGridView();
            this.dataGridViewProduct = new System.Windows.Forms.DataGridView();
            this.comboBoxFilter = new System.Windows.Forms.ComboBox();
            this.buttonFilter = new System.Windows.Forms.Button();
            this.buttonAll = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRemovaProduct
            // 
            this.buttonRemovaProduct.Location = new System.Drawing.Point(700, 752);
            this.buttonRemovaProduct.Name = "buttonRemovaProduct";
            this.buttonRemovaProduct.Size = new System.Drawing.Size(110, 88);
            this.buttonRemovaProduct.TabIndex = 45;
            this.buttonRemovaProduct.Text = "Remove product";
            this.buttonRemovaProduct.UseVisualStyleBackColor = true;
            this.buttonRemovaProduct.Click += new System.EventHandler(this.buttonRemovaProduct_Click);
            // 
            // buttonEditCat
            // 
            this.buttonEditCat.Location = new System.Drawing.Point(579, 752);
            this.buttonEditCat.Name = "buttonEditCat";
            this.buttonEditCat.Size = new System.Drawing.Size(115, 88);
            this.buttonEditCat.TabIndex = 44;
            this.buttonEditCat.Text = "Edit Category";
            this.buttonEditCat.UseVisualStyleBackColor = true;
            this.buttonEditCat.Click += new System.EventHandler(this.buttonEditCat_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(463, 752);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(110, 88);
            this.buttonAddProduct.TabIndex = 43;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // comboBoxCat
            // 
            this.comboBoxCat.FormattingEnabled = true;
            this.comboBoxCat.Location = new System.Drawing.Point(203, 725);
            this.comboBoxCat.Name = "comboBoxCat";
            this.comboBoxCat.Size = new System.Drawing.Size(200, 33);
            this.comboBoxCat.TabIndex = 42;
            this.comboBoxCat.SelectedIndexChanged += new System.EventHandler(this.comboBoxCat_SelectedIndexChanged);
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(203, 830);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(200, 31);
            this.textBoxStock.TabIndex = 41;
            // 
            // textBoxHarga
            // 
            this.textBoxHarga.Location = new System.Drawing.Point(203, 781);
            this.textBoxHarga.Name = "textBoxHarga";
            this.textBoxHarga.Size = new System.Drawing.Size(200, 31);
            this.textBoxHarga.TabIndex = 40;
            // 
            // textBoxNamaDetails
            // 
            this.textBoxNamaDetails.Location = new System.Drawing.Point(203, 675);
            this.textBoxNamaDetails.Name = "textBoxNamaDetails";
            this.textBoxNamaDetails.Size = new System.Drawing.Size(602, 31);
            this.textBoxNamaDetails.TabIndex = 39;
            // 
            // labelNamaDet
            // 
            this.labelNamaDet.AutoSize = true;
            this.labelNamaDet.Location = new System.Drawing.Point(90, 675);
            this.labelNamaDet.Name = "labelNamaDet";
            this.labelNamaDet.Size = new System.Drawing.Size(80, 25);
            this.labelNamaDet.TabIndex = 38;
            this.labelNamaDet.Text = "Nama: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 833);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Stock:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(87, 781);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "Harga:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 728);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Category: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(88, 611);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 37);
            this.label4.TabIndex = 34;
            this.label4.Text = "Details";
            // 
            // buttonRemovecat
            // 
            this.buttonRemovecat.Location = new System.Drawing.Point(1139, 466);
            this.buttonRemovecat.Name = "buttonRemovecat";
            this.buttonRemovecat.Size = new System.Drawing.Size(121, 88);
            this.buttonRemovecat.TabIndex = 33;
            this.buttonRemovecat.Text = "Remove Category";
            this.buttonRemovecat.UseVisualStyleBackColor = true;
            this.buttonRemovecat.Click += new System.EventHandler(this.buttonRemovecat_Click);
            // 
            // buttonAddCat
            // 
            this.buttonAddCat.Location = new System.Drawing.Point(1015, 466);
            this.buttonAddCat.Name = "buttonAddCat";
            this.buttonAddCat.Size = new System.Drawing.Size(118, 88);
            this.buttonAddCat.TabIndex = 32;
            this.buttonAddCat.Text = "Add Category";
            this.buttonAddCat.UseVisualStyleBackColor = true;
            this.buttonAddCat.Click += new System.EventHandler(this.buttonAddCat_Click);
            // 
            // textBoxNamaCat
            // 
            this.textBoxNamaCat.Location = new System.Drawing.Point(969, 414);
            this.textBoxNamaCat.Name = "textBoxNamaCat";
            this.textBoxNamaCat.Size = new System.Drawing.Size(301, 31);
            this.textBoxNamaCat.TabIndex = 31;
            // 
            // labelNamaCat
            // 
            this.labelNamaCat.AutoSize = true;
            this.labelNamaCat.Location = new System.Drawing.Point(883, 417);
            this.labelNamaCat.Name = "labelNamaCat";
            this.labelNamaCat.Size = new System.Drawing.Size(80, 25);
            this.labelNamaCat.TabIndex = 30;
            this.labelNamaCat.Text = "Nama: ";
            // 
            // dataGridViewCat
            // 
            this.dataGridViewCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCat.Location = new System.Drawing.Point(888, 96);
            this.dataGridViewCat.Name = "dataGridViewCat";
            this.dataGridViewCat.RowHeadersWidth = 82;
            this.dataGridViewCat.RowTemplate.Height = 33;
            this.dataGridViewCat.Size = new System.Drawing.Size(382, 276);
            this.dataGridViewCat.TabIndex = 29;
            // 
            // dataGridViewProduct
            // 
            this.dataGridViewProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduct.Location = new System.Drawing.Point(80, 96);
            this.dataGridViewProduct.Name = "dataGridViewProduct";
            this.dataGridViewProduct.RowHeadersWidth = 82;
            this.dataGridViewProduct.RowTemplate.Height = 33;
            this.dataGridViewProduct.ShowEditingIcon = false;
            this.dataGridViewProduct.Size = new System.Drawing.Size(723, 479);
            this.dataGridViewProduct.TabIndex = 28;
            this.dataGridViewProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            this.dataGridViewProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduct_CellContentClick);
            // 
            // comboBoxFilter
            // 
            this.comboBoxFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFilter.FormattingEnabled = true;
            this.comboBoxFilter.Location = new System.Drawing.Point(636, 40);
            this.comboBoxFilter.Name = "comboBoxFilter";
            this.comboBoxFilter.Size = new System.Drawing.Size(169, 33);
            this.comboBoxFilter.TabIndex = 27;
            this.comboBoxFilter.SelectionChangeCommitted += new System.EventHandler(this.comboBoxFilter_SelectedChangeCommitted);
            // 
            // buttonFilter
            // 
            this.buttonFilter.Location = new System.Drawing.Point(527, 39);
            this.buttonFilter.Name = "buttonFilter";
            this.buttonFilter.Size = new System.Drawing.Size(76, 34);
            this.buttonFilter.TabIndex = 26;
            this.buttonFilter.Text = "Filter:";
            this.buttonFilter.UseVisualStyleBackColor = true;
            this.buttonFilter.Click += new System.EventHandler(this.buttonFilter_Click);
            // 
            // buttonAll
            // 
            this.buttonAll.Location = new System.Drawing.Point(440, 39);
            this.buttonAll.Name = "buttonAll";
            this.buttonAll.Size = new System.Drawing.Size(64, 37);
            this.buttonAll.TabIndex = 25;
            this.buttonAll.Text = "All";
            this.buttonAll.UseVisualStyleBackColor = true;
            this.buttonAll.Click += new System.EventHandler(this.buttonAll_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(881, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 37);
            this.label2.TabIndex = 24;
            this.label2.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 37);
            this.label1.TabIndex = 23;
            this.label1.Text = "Product";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1412, 942);
            this.Controls.Add(this.buttonRemovaProduct);
            this.Controls.Add(this.buttonEditCat);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.comboBoxCat);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxHarga);
            this.Controls.Add(this.textBoxNamaDetails);
            this.Controls.Add(this.labelNamaDet);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonRemovecat);
            this.Controls.Add(this.buttonAddCat);
            this.Controls.Add(this.textBoxNamaCat);
            this.Controls.Add(this.labelNamaCat);
            this.Controls.Add(this.dataGridViewCat);
            this.Controls.Add(this.dataGridViewProduct);
            this.Controls.Add(this.comboBoxFilter);
            this.Controls.Add(this.buttonFilter);
            this.Controls.Add(this.buttonAll);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRemovaProduct;
        private System.Windows.Forms.Button buttonEditCat;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.ComboBox comboBoxCat;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.TextBox textBoxHarga;
        private System.Windows.Forms.TextBox textBoxNamaDetails;
        private System.Windows.Forms.Label labelNamaDet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRemovecat;
        private System.Windows.Forms.Button buttonAddCat;
        private System.Windows.Forms.TextBox textBoxNamaCat;
        private System.Windows.Forms.Label labelNamaCat;
        private System.Windows.Forms.DataGridView dataGridViewCat;
        private System.Windows.Forms.DataGridView dataGridViewProduct;
        private System.Windows.Forms.ComboBox comboBoxFilter;
        private System.Windows.Forms.Button buttonFilter;
        private System.Windows.Forms.Button buttonAll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

