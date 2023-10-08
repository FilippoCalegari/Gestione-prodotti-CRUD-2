namespace Gestione_prodotti_CRUD
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ProductName = new System.Windows.Forms.Label();
            this.txtb_ProductName = new System.Windows.Forms.TextBox();
            this.txtb_ProductPrice = new System.Windows.Forms.TextBox();
            this.lbl_ProductPrice = new System.Windows.Forms.Label();
            this.lb_ProductsList = new System.Windows.Forms.ListBox();
            this.lbl_ProductList = new System.Windows.Forms.Label();
            this.btn_AddProduct = new System.Windows.Forms.Button();
            this.btn_UpdateProduct = new System.Windows.Forms.Button();
            this.btn_ReadProduct = new System.Windows.Forms.Button();
            this.btn_DeleteProduct = new System.Windows.Forms.Button();
            this.txtb_NewProductName = new System.Windows.Forms.TextBox();
            this.lbl_NewProductName = new System.Windows.Forms.Label();
            this.lbl_UpdateProduct = new System.Windows.Forms.Label();
            this.txtb_UpdateProduct = new System.Windows.Forms.TextBox();
            this.lbl_DeleteProduct = new System.Windows.Forms.Label();
            this.txtb_DeleteProduct = new System.Windows.Forms.TextBox();
            this.btn_FindMin = new System.Windows.Forms.Button();
            this.btn_FindMax = new System.Windows.Forms.Button();
            this.btn_OrdinamenteAlfabetico = new System.Windows.Forms.Button();
            this.btn_ReadFromFile = new System.Windows.Forms.Button();
            this.btn_SaveOnFile = new System.Windows.Forms.Button();
            this.btn_PercentOperations = new System.Windows.Forms.Button();
            this.btn_PriceSumm = new System.Windows.Forms.Button();
            this.lbl_Percent = new System.Windows.Forms.Label();
            this.txtb_Percentuale = new System.Windows.Forms.TextBox();
            this.btn_Sommare = new System.Windows.Forms.Button();
            this.btn_Sottrarre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ProductName
            // 
            this.lbl_ProductName.AutoSize = true;
            this.lbl_ProductName.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_ProductName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_ProductName.Location = new System.Drawing.Point(18, 14);
            this.lbl_ProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductName.Name = "lbl_ProductName";
            this.lbl_ProductName.Size = new System.Drawing.Size(119, 20);
            this.lbl_ProductName.TabIndex = 0;
            this.lbl_ProductName.Text = "Nome prodotto:";
            this.lbl_ProductName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtb_ProductName
            // 
            this.txtb_ProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtb_ProductName.Location = new System.Drawing.Point(18, 38);
            this.txtb_ProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_ProductName.Name = "txtb_ProductName";
            this.txtb_ProductName.Size = new System.Drawing.Size(386, 26);
            this.txtb_ProductName.TabIndex = 1;
            this.txtb_ProductName.TextChanged += new System.EventHandler(this.txtb_ProductName_TextChanged);
            // 
            // txtb_ProductPrice
            // 
            this.txtb_ProductPrice.Location = new System.Drawing.Point(18, 98);
            this.txtb_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_ProductPrice.Name = "txtb_ProductPrice";
            this.txtb_ProductPrice.Size = new System.Drawing.Size(386, 26);
            this.txtb_ProductPrice.TabIndex = 3;
            this.txtb_ProductPrice.TextChanged += new System.EventHandler(this.txtb_ProductPrice_TextChanged);
            // 
            // lbl_ProductPrice
            // 
            this.lbl_ProductPrice.AutoSize = true;
            this.lbl_ProductPrice.Location = new System.Drawing.Point(18, 74);
            this.lbl_ProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductPrice.Name = "lbl_ProductPrice";
            this.lbl_ProductPrice.Size = new System.Drawing.Size(126, 20);
            this.lbl_ProductPrice.TabIndex = 2;
            this.lbl_ProductPrice.Text = "Prezzo prodotto:";
            this.lbl_ProductPrice.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lb_ProductsList
            // 
            this.lb_ProductsList.FormattingEnabled = true;
            this.lb_ProductsList.ItemHeight = 20;
            this.lb_ProductsList.Location = new System.Drawing.Point(18, 158);
            this.lb_ProductsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lb_ProductsList.Name = "lb_ProductsList";
            this.lb_ProductsList.Size = new System.Drawing.Size(386, 184);
            this.lb_ProductsList.TabIndex = 4;
            this.lb_ProductsList.SelectedIndexChanged += new System.EventHandler(this.lb_ProductsList_SelectedIndexChanged);
            // 
            // lbl_ProductList
            // 
            this.lbl_ProductList.AutoSize = true;
            this.lbl_ProductList.Location = new System.Drawing.Point(14, 134);
            this.lbl_ProductList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ProductList.Name = "lbl_ProductList";
            this.lbl_ProductList.Size = new System.Drawing.Size(105, 20);
            this.lbl_ProductList.TabIndex = 5;
            this.lbl_ProductList.Text = "Lista prodotti:";
            this.lbl_ProductList.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_ProductList.Click += new System.EventHandler(this.lbl_ProductList_Click);
            // 
            // btn_AddProduct
            // 
            this.btn_AddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_AddProduct.Location = new System.Drawing.Point(416, 38);
            this.btn_AddProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_AddProduct.Name = "btn_AddProduct";
            this.btn_AddProduct.Size = new System.Drawing.Size(308, 308);
            this.btn_AddProduct.TabIndex = 7;
            this.btn_AddProduct.Text = "C";
            this.btn_AddProduct.UseVisualStyleBackColor = true;
            this.btn_AddProduct.Click += new System.EventHandler(this.btn_AddProduct_Click);
            // 
            // btn_UpdateProduct
            // 
            this.btn_UpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_UpdateProduct.Location = new System.Drawing.Point(416, 371);
            this.btn_UpdateProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_UpdateProduct.Name = "btn_UpdateProduct";
            this.btn_UpdateProduct.Size = new System.Drawing.Size(308, 308);
            this.btn_UpdateProduct.TabIndex = 9;
            this.btn_UpdateProduct.Text = "U";
            this.btn_UpdateProduct.UseVisualStyleBackColor = true;
            this.btn_UpdateProduct.Click += new System.EventHandler(this.btn_UpdateProduct_Click);
            // 
            // btn_ReadProduct
            // 
            this.btn_ReadProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_ReadProduct.Location = new System.Drawing.Point(732, 38);
            this.btn_ReadProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ReadProduct.Name = "btn_ReadProduct";
            this.btn_ReadProduct.Size = new System.Drawing.Size(308, 308);
            this.btn_ReadProduct.TabIndex = 10;
            this.btn_ReadProduct.Text = "R";
            this.btn_ReadProduct.UseVisualStyleBackColor = true;
            this.btn_ReadProduct.Click += new System.EventHandler(this.btn_ReadProduct_Click);
            // 
            // btn_DeleteProduct
            // 
            this.btn_DeleteProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_DeleteProduct.Location = new System.Drawing.Point(732, 371);
            this.btn_DeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_DeleteProduct.Name = "btn_DeleteProduct";
            this.btn_DeleteProduct.Size = new System.Drawing.Size(308, 308);
            this.btn_DeleteProduct.TabIndex = 11;
            this.btn_DeleteProduct.Text = "D";
            this.btn_DeleteProduct.UseVisualStyleBackColor = true;
            this.btn_DeleteProduct.Click += new System.EventHandler(this.btn_DeleteProduct_Click);
            // 
            // txtb_NewProductName
            // 
            this.txtb_NewProductName.Location = new System.Drawing.Point(18, 455);
            this.txtb_NewProductName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_NewProductName.Name = "txtb_NewProductName";
            this.txtb_NewProductName.Size = new System.Drawing.Size(386, 26);
            this.txtb_NewProductName.TabIndex = 13;
            this.txtb_NewProductName.Visible = false;
            this.txtb_NewProductName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbl_NewProductName
            // 
            this.lbl_NewProductName.AutoSize = true;
            this.lbl_NewProductName.Location = new System.Drawing.Point(18, 431);
            this.lbl_NewProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NewProductName.Name = "lbl_NewProductName";
            this.lbl_NewProductName.Size = new System.Drawing.Size(166, 20);
            this.lbl_NewProductName.TabIndex = 12;
            this.lbl_NewProductName.Text = "Nuovo nome prodotto:";
            this.lbl_NewProductName.Visible = false;
            this.lbl_NewProductName.Click += new System.EventHandler(this.lbl_NewProductName_Click);
            // 
            // lbl_UpdateProduct
            // 
            this.lbl_UpdateProduct.AutoSize = true;
            this.lbl_UpdateProduct.Location = new System.Drawing.Point(18, 371);
            this.lbl_UpdateProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UpdateProduct.Name = "lbl_UpdateProduct";
            this.lbl_UpdateProduct.Size = new System.Drawing.Size(218, 20);
            this.lbl_UpdateProduct.TabIndex = 16;
            this.lbl_UpdateProduct.Text = "Nome prodotto da modificare:";
            this.lbl_UpdateProduct.Visible = false;
            // 
            // txtb_UpdateProduct
            // 
            this.txtb_UpdateProduct.Location = new System.Drawing.Point(18, 395);
            this.txtb_UpdateProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_UpdateProduct.Name = "txtb_UpdateProduct";
            this.txtb_UpdateProduct.Size = new System.Drawing.Size(386, 26);
            this.txtb_UpdateProduct.TabIndex = 17;
            this.txtb_UpdateProduct.Visible = false;
            this.txtb_UpdateProduct.TextChanged += new System.EventHandler(this.txtb_UpdateProduct_TextChanged);
            // 
            // lbl_DeleteProduct
            // 
            this.lbl_DeleteProduct.AutoSize = true;
            this.lbl_DeleteProduct.Location = new System.Drawing.Point(14, 486);
            this.lbl_DeleteProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_DeleteProduct.Name = "lbl_DeleteProduct";
            this.lbl_DeleteProduct.Size = new System.Drawing.Size(217, 20);
            this.lbl_DeleteProduct.TabIndex = 18;
            this.lbl_DeleteProduct.Text = "Nome prodotto da cancellare:";
            this.lbl_DeleteProduct.Visible = false;
            // 
            // txtb_DeleteProduct
            // 
            this.txtb_DeleteProduct.Location = new System.Drawing.Point(18, 511);
            this.txtb_DeleteProduct.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_DeleteProduct.Name = "txtb_DeleteProduct";
            this.txtb_DeleteProduct.Size = new System.Drawing.Size(386, 26);
            this.txtb_DeleteProduct.TabIndex = 19;
            this.txtb_DeleteProduct.Visible = false;
            // 
            // btn_FindMin
            // 
            this.btn_FindMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_FindMin.Location = new System.Drawing.Point(1048, 38);
            this.btn_FindMin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_FindMin.Name = "btn_FindMin";
            this.btn_FindMin.Size = new System.Drawing.Size(154, 154);
            this.btn_FindMin.TabIndex = 20;
            this.btn_FindMin.Text = "Trovare il Min";
            this.btn_FindMin.UseVisualStyleBackColor = true;
            this.btn_FindMin.Click += new System.EventHandler(this.btn_FindMin_Click);
            // 
            // btn_FindMax
            // 
            this.btn_FindMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_FindMax.Location = new System.Drawing.Point(1210, 38);
            this.btn_FindMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_FindMax.Name = "btn_FindMax";
            this.btn_FindMax.Size = new System.Drawing.Size(154, 154);
            this.btn_FindMax.TabIndex = 21;
            this.btn_FindMax.Text = "Trovare il Max";
            this.btn_FindMax.UseVisualStyleBackColor = true;
            this.btn_FindMax.Click += new System.EventHandler(this.btn_FindMax_Click);
            // 
            // btn_OrdinamenteAlfabetico
            // 
            this.btn_OrdinamenteAlfabetico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_OrdinamenteAlfabetico.Location = new System.Drawing.Point(1048, 192);
            this.btn_OrdinamenteAlfabetico.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_OrdinamenteAlfabetico.Name = "btn_OrdinamenteAlfabetico";
            this.btn_OrdinamenteAlfabetico.Size = new System.Drawing.Size(316, 154);
            this.btn_OrdinamenteAlfabetico.TabIndex = 22;
            this.btn_OrdinamenteAlfabetico.Text = "Ordine Alfabetico";
            this.btn_OrdinamenteAlfabetico.UseVisualStyleBackColor = true;
            this.btn_OrdinamenteAlfabetico.Click += new System.EventHandler(this.btn_OrdinamenteAlfabetico_Click);
            // 
            // btn_ReadFromFile
            // 
            this.btn_ReadFromFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_ReadFromFile.Location = new System.Drawing.Point(1048, 525);
            this.btn_ReadFromFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ReadFromFile.Name = "btn_ReadFromFile";
            this.btn_ReadFromFile.Size = new System.Drawing.Size(154, 154);
            this.btn_ReadFromFile.TabIndex = 27;
            this.btn_ReadFromFile.Text = "Leggi da file";
            this.btn_ReadFromFile.UseVisualStyleBackColor = true;
            this.btn_ReadFromFile.Click += new System.EventHandler(this.btn_ReadFromFile_Click);
            // 
            // btn_SaveOnFile
            // 
            this.btn_SaveOnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_SaveOnFile.Location = new System.Drawing.Point(1210, 525);
            this.btn_SaveOnFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_SaveOnFile.Name = "btn_SaveOnFile";
            this.btn_SaveOnFile.Size = new System.Drawing.Size(154, 154);
            this.btn_SaveOnFile.TabIndex = 26;
            this.btn_SaveOnFile.Text = "Salva su file";
            this.btn_SaveOnFile.UseVisualStyleBackColor = true;
            this.btn_SaveOnFile.Click += new System.EventHandler(this.btn_SaveOnFile_Click);
            // 
            // btn_PercentOperations
            // 
            this.btn_PercentOperations.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_PercentOperations.Location = new System.Drawing.Point(1210, 371);
            this.btn_PercentOperations.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PercentOperations.Name = "btn_PercentOperations";
            this.btn_PercentOperations.Size = new System.Drawing.Size(154, 154);
            this.btn_PercentOperations.TabIndex = 25;
            this.btn_PercentOperations.Text = "Somma o Sottrai %";
            this.btn_PercentOperations.UseVisualStyleBackColor = true;
            this.btn_PercentOperations.Click += new System.EventHandler(this.btn_PercentOperations_Click);
            // 
            // btn_PriceSumm
            // 
            this.btn_PriceSumm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_PriceSumm.Location = new System.Drawing.Point(1048, 371);
            this.btn_PriceSumm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_PriceSumm.Name = "btn_PriceSumm";
            this.btn_PriceSumm.Size = new System.Drawing.Size(154, 154);
            this.btn_PriceSumm.TabIndex = 24;
            this.btn_PriceSumm.Text = "Somma prezzi";
            this.btn_PriceSumm.UseVisualStyleBackColor = true;
            this.btn_PriceSumm.Click += new System.EventHandler(this.btn_PriceSumm_Click);
            // 
            // lbl_Percent
            // 
            this.lbl_Percent.AutoSize = true;
            this.lbl_Percent.Location = new System.Drawing.Point(14, 542);
            this.lbl_Percent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Percent.Name = "lbl_Percent";
            this.lbl_Percent.Size = new System.Drawing.Size(313, 20);
            this.lbl_Percent.TabIndex = 28;
            this.lbl_Percent.Text = "Scegli percentuale da sommare o sottrarre:";
            this.lbl_Percent.Visible = false;
            // 
            // txtb_Percentuale
            // 
            this.txtb_Percentuale.Location = new System.Drawing.Point(18, 567);
            this.txtb_Percentuale.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtb_Percentuale.Name = "txtb_Percentuale";
            this.txtb_Percentuale.Size = new System.Drawing.Size(386, 26);
            this.txtb_Percentuale.TabIndex = 29;
            this.txtb_Percentuale.Visible = false;
            // 
            // btn_Sommare
            // 
            this.btn_Sommare.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Sommare.Location = new System.Drawing.Point(18, 603);
            this.btn_Sommare.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sommare.Name = "btn_Sommare";
            this.btn_Sommare.Size = new System.Drawing.Size(190, 76);
            this.btn_Sommare.TabIndex = 30;
            this.btn_Sommare.Text = "Sommare";
            this.btn_Sommare.UseVisualStyleBackColor = true;
            this.btn_Sommare.Visible = false;
            this.btn_Sommare.Click += new System.EventHandler(this.btn_Sommare_Click);
            // 
            // btn_Sottrarre
            // 
            this.btn_Sottrarre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_Sottrarre.Location = new System.Drawing.Point(214, 603);
            this.btn_Sottrarre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Sottrarre.Name = "btn_Sottrarre";
            this.btn_Sottrarre.Size = new System.Drawing.Size(190, 76);
            this.btn_Sottrarre.TabIndex = 31;
            this.btn_Sottrarre.Text = "Sottrarre";
            this.btn_Sottrarre.UseVisualStyleBackColor = true;
            this.btn_Sottrarre.Visible = false;
            this.btn_Sottrarre.Click += new System.EventHandler(this.btn_Sottrarre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1385, 697);
            this.Controls.Add(this.btn_Sottrarre);
            this.Controls.Add(this.btn_Sommare);
            this.Controls.Add(this.txtb_Percentuale);
            this.Controls.Add(this.lbl_Percent);
            this.Controls.Add(this.btn_ReadFromFile);
            this.Controls.Add(this.btn_SaveOnFile);
            this.Controls.Add(this.btn_PercentOperations);
            this.Controls.Add(this.btn_PriceSumm);
            this.Controls.Add(this.btn_OrdinamenteAlfabetico);
            this.Controls.Add(this.btn_FindMax);
            this.Controls.Add(this.btn_FindMin);
            this.Controls.Add(this.txtb_DeleteProduct);
            this.Controls.Add(this.lbl_DeleteProduct);
            this.Controls.Add(this.txtb_UpdateProduct);
            this.Controls.Add(this.lbl_UpdateProduct);
            this.Controls.Add(this.txtb_NewProductName);
            this.Controls.Add(this.lbl_NewProductName);
            this.Controls.Add(this.btn_DeleteProduct);
            this.Controls.Add(this.btn_ReadProduct);
            this.Controls.Add(this.btn_UpdateProduct);
            this.Controls.Add(this.btn_AddProduct);
            this.Controls.Add(this.lbl_ProductList);
            this.Controls.Add(this.lb_ProductsList);
            this.Controls.Add(this.txtb_ProductPrice);
            this.Controls.Add(this.lbl_ProductPrice);
            this.Controls.Add(this.txtb_ProductName);
            this.Controls.Add(this.lbl_ProductName);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ProductName;
        private System.Windows.Forms.TextBox txtb_ProductName;
        private System.Windows.Forms.TextBox txtb_ProductPrice;
        private System.Windows.Forms.Label lbl_ProductPrice;
        private System.Windows.Forms.ListBox lb_ProductsList;
        private System.Windows.Forms.Label lbl_ProductList;
        private System.Windows.Forms.Button btn_AddProduct;
        private System.Windows.Forms.Button btn_UpdateProduct;
        private System.Windows.Forms.Button btn_ReadProduct;
        private System.Windows.Forms.Button btn_DeleteProduct;
        private System.Windows.Forms.TextBox txtb_NewProductName;
        private System.Windows.Forms.Label lbl_NewProductName;
        private System.Windows.Forms.Label lbl_UpdateProduct;
        private System.Windows.Forms.TextBox txtb_UpdateProduct;
        private System.Windows.Forms.Label lbl_DeleteProduct;
        private System.Windows.Forms.TextBox txtb_DeleteProduct;
        private System.Windows.Forms.Button btn_FindMin;
        private System.Windows.Forms.Button btn_FindMax;
        private System.Windows.Forms.Button btn_OrdinamenteAlfabetico;
        private System.Windows.Forms.Button btn_ReadFromFile;
        private System.Windows.Forms.Button btn_SaveOnFile;
        private System.Windows.Forms.Button btn_PercentOperations;
        private System.Windows.Forms.Button btn_PriceSumm;
        private System.Windows.Forms.Label lbl_Percent;
        private System.Windows.Forms.TextBox txtb_Percentuale;
        private System.Windows.Forms.Button btn_Sommare;
        private System.Windows.Forms.Button btn_Sottrarre;
    }
}

