namespace CSharpEgitimkampi301.PresentationLayer
{
    partial class FrmCategory
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txtCategoryId = new TextBox();
            btnList = new Button();
            dataGridView1 = new DataGridView();
            txtCategoryName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            rdbActive = new RadioButton();
            rdbPassive = new RadioButton();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnGetById = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 9);
            label1.Name = "label1";
            label1.Size = new Size(92, 20);
            label1.TabIndex = 0;
            label1.Text = "Kategori ID :";
            // 
            // txtCategoryId
            // 
            txtCategoryId.Location = new Point(148, 6);
            txtCategoryId.Name = "txtCategoryId";
            txtCategoryId.Size = new Size(182, 27);
            txtCategoryId.TabIndex = 1;
            // 
            // btnList
            // 
            btnList.BackColor = Color.FromArgb(192, 192, 255);
            btnList.Location = new Point(148, 117);
            btnList.Name = "btnList";
            btnList.Size = new Size(182, 45);
            btnList.TabIndex = 2;
            btnList.Text = "Listele";
            btnList.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(346, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(554, 354);
            dataGridView1.TabIndex = 3;
            // 
            // txtCategoryName
            // 
            txtCategoryName.Location = new Point(148, 39);
            txtCategoryName.Name = "txtCategoryName";
            txtCategoryName.Size = new Size(182, 27);
            txtCategoryName.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 42);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 4;
            label2.Text = "Kategori Adı :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 6;
            label3.Text = "Kategori Durumu :";
            // 
            // rdbActive
            // 
            rdbActive.AutoSize = true;
            rdbActive.Location = new Point(148, 75);
            rdbActive.Name = "rdbActive";
            rdbActive.Size = new Size(61, 24);
            rdbActive.TabIndex = 7;
            rdbActive.TabStop = true;
            rdbActive.Text = "Aktif";
            rdbActive.UseVisualStyleBackColor = true;
            // 
            // rdbPassive
            // 
            rdbPassive.AutoSize = true;
            rdbPassive.Location = new Point(215, 75);
            rdbPassive.Name = "rdbPassive";
            rdbPassive.Size = new Size(60, 24);
            rdbPassive.TabIndex = 8;
            rdbPassive.TabStop = true;
            rdbPassive.Text = "Pasif";
            rdbPassive.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 192, 255);
            btnAdd.Location = new Point(148, 168);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(182, 45);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Ekle";
            btnAdd.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 192, 255);
            btnDelete.Location = new Point(148, 219);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(182, 45);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 192, 255);
            btnUpdate.Location = new Point(148, 270);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(182, 45);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnGetById
            // 
            btnGetById.BackColor = Color.FromArgb(192, 192, 255);
            btnGetById.Location = new Point(148, 321);
            btnGetById.Name = "btnGetById";
            btnGetById.Size = new Size(182, 45);
            btnGetById.TabIndex = 12;
            btnGetById.Text = "Id'ye Göre Getir";
            btnGetById.UseVisualStyleBackColor = false;
            // 
            // FrmCategory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(912, 516);
            Controls.Add(btnGetById);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(rdbPassive);
            Controls.Add(rdbActive);
            Controls.Add(label3);
            Controls.Add(txtCategoryName);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(btnList);
            Controls.Add(txtCategoryId);
            Controls.Add(label1);
            Name = "FrmCategory";
            Text = "Form1";
            Load += FrmCategory_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtCategoryId;
        private Button btnList;
        private DataGridView dataGridView1;
        private TextBox txtCategoryName;
        private Label label2;
        private Label label3;
        private RadioButton rdbActive;
        private RadioButton rdbPassive;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnGetById;
    }
}
