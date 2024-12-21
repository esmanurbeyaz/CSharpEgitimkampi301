namespace CSharpEgitimkampi301.PresentationLayer
{
    partial class FrmProduct
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
            btnGetById = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            txtProductName = new TextBox();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            btnList = new Button();
            txtProductId = new TextBox();
            label1 = new Label();
            txtProductStock = new TextBox();
            label4 = new Label();
            txtProductPrice = new TextBox();
            label5 = new Label();
            label6 = new Label();
            cmbCategory = new ComboBox();
            txtDescription = new TextBox();
            label7 = new Label();
            btnList2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.FromArgb(255, 255, 192);
            btnGetById.Location = new Point(145, 466);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(182, 45);
            btnGetById.TabIndex = 25;
            btnGetById.Text = "Id'ye Göre Getir";
            btnGetById.UseVisualStyleBackColor = false;
            btnGetById.Click += btnGetById_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(255, 255, 192);
            btnUpdate.Location = new Point(145, 415);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(182, 45);
            btnUpdate.TabIndex = 24;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 255, 192);
            btnDelete.Location = new Point(145, 364);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 45);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(255, 255, 192);
            btnAdd.Location = new Point(145, 313);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 45);
            btnAdd.TabIndex = 22;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(145, 39);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(182, 27);
            txtProductName.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(65, 42);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 17;
            label2.Text = "Ürün Adı :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(343, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(837, 499);
            dataGridView1.TabIndex = 16;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(255, 255, 192);
            btnList.Location = new Point(145, 262);
            btnList.Name = "btnList";
            btnList.Size = new Size(87, 45);
            btnList.TabIndex = 15;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            btnList.Click += btnList_Click;
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(145, 6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(182, 27);
            txtProductId.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(73, 9);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 13;
            label1.Text = "Ürün ID :";
            label1.Click += label1_Click;
            // 
            // txtProductStock
            // 
            txtProductStock.Location = new Point(145, 72);
            txtProductStock.Name = "txtProductStock";
            txtProductStock.Size = new Size(182, 27);
            txtProductStock.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 75);
            label4.Name = "label4";
            label4.Size = new Size(80, 20);
            label4.TabIndex = 26;
            label4.Text = "Ürün Stok :";
            // 
            // txtProductPrice
            // 
            txtProductPrice.Location = new Point(145, 105);
            txtProductPrice.Name = "txtProductPrice";
            txtProductPrice.Size = new Size(182, 27);
            txtProductPrice.TabIndex = 29;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(57, 108);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 28;
            label5.Text = "Ürün Fiyat :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 141);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 30;
            label6.Text = "Kategori :";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(145, 141);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(182, 28);
            cmbCategory.TabIndex = 32;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(145, 175);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(182, 73);
            txtDescription.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 178);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 34;
            label7.Text = "Ürün Çıklaması :";
            // 
            // btnList2
            // 
            btnList2.BackColor = Color.FromArgb(255, 255, 192);
            btnList2.Location = new Point(238, 262);
            btnList2.Name = "btnList2";
            btnList2.Size = new Size(87, 45);
            btnList2.TabIndex = 35;
            btnList2.Text = "Listele 2";
            btnList2.UseVisualStyleBackColor = false;
            btnList2.Click += btnList2_Click;
            // 
            // FrmProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(175, 220, 250);
            ClientSize = new Size(1210, 570);
            Controls.Add(btnList2);
            Controls.Add(label7);
            Controls.Add(txtDescription);
            Controls.Add(cmbCategory);
            Controls.Add(label6);
            Controls.Add(txtProductPrice);
            Controls.Add(label5);
            Controls.Add(txtProductStock);
            Controls.Add(label4);
            Controls.Add(btnGetById);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnList);
            Controls.Add(txtProductId);
            Controls.Add(label1);
            Name = "FrmProduct";
            Text = "Form1";
            Load += FrmProduct_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGetById;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnAdd;
        private TextBox txtProductName;
        private Label label2;
        private DataGridView dataGridView1;
        private Button btnList;
        private TextBox txtProductId;
        private Label label1;
        private TextBox txtProductStock;
        private Label label4;
        private TextBox txtProductPrice;
        private Label label5;
        private Label label6;
        private ComboBox cmbCategory;
        private TextBox txtDescription;
        private Label label7;
        private Button btnList2;
    }
}