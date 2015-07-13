namespace MediaStore
{
    partial class SearchForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lagerfordaProdCbx = new System.Windows.Forms.CheckBox();
            this.kategoriCbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.rensaBtn = new System.Windows.Forms.Button();
            this.namnExaktCbx = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saldoMaxTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.saldoMinTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namnTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lagerSearchBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lagerVarunrTbx = new System.Windows.Forms.TextBox();
            this.lagerAllProdGbx = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.prodDgw = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.lagerAllProdGbx.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prodDgw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(265, 324);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Sök produkt";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lagerfordaProdCbx);
            this.panel1.Controls.Add(this.kategoriCbx);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.rensaBtn);
            this.panel1.Controls.Add(this.namnExaktCbx);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.namnTbx);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lagerSearchBtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lagerVarunrTbx);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(3, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 290);
            this.panel1.TabIndex = 0;
            // 
            // lagerfordaProdCbx
            // 
            this.lagerfordaProdCbx.AutoSize = true;
            this.lagerfordaProdCbx.Location = new System.Drawing.Point(19, 156);
            this.lagerfordaProdCbx.Name = "lagerfordaProdCbx";
            this.lagerfordaProdCbx.Size = new System.Drawing.Size(157, 17);
            this.lagerfordaProdCbx.TabIndex = 8;
            this.lagerfordaProdCbx.Text = "Endast lagerförda produkter";
            this.lagerfordaProdCbx.UseVisualStyleBackColor = true;
            this.lagerfordaProdCbx.Click += new System.EventHandler(this.search_Click);
            // 
            // kategoriCbx
            // 
            this.kategoriCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriCbx.FormattingEnabled = true;
            this.kategoriCbx.Location = new System.Drawing.Point(103, 109);
            this.kategoriCbx.Name = "kategoriCbx";
            this.kategoriCbx.Size = new System.Drawing.Size(138, 21);
            this.kategoriCbx.TabIndex = 7;
            this.kategoriCbx.SelectedIndexChanged += new System.EventHandler(this.searchBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Kategori:";
            // 
            // rensaBtn
            // 
            this.rensaBtn.Location = new System.Drawing.Point(74, 250);
            this.rensaBtn.Name = "rensaBtn";
            this.rensaBtn.Size = new System.Drawing.Size(75, 23);
            this.rensaBtn.TabIndex = 10;
            this.rensaBtn.Text = "Rensa";
            this.rensaBtn.UseVisualStyleBackColor = true;
            this.rensaBtn.Click += new System.EventHandler(this.rensaBtn_Click);
            // 
            // namnExaktCbx
            // 
            this.namnExaktCbx.AutoSize = true;
            this.namnExaktCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namnExaktCbx.Location = new System.Drawing.Point(103, 71);
            this.namnExaktCbx.Name = "namnExaktCbx";
            this.namnExaktCbx.Size = new System.Drawing.Size(120, 17);
            this.namnExaktCbx.TabIndex = 5;
            this.namnExaktCbx.Text = "Matcha namn exakt";
            this.namnExaktCbx.UseVisualStyleBackColor = true;
            this.namnExaktCbx.Click += new System.EventHandler(this.search_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.saldoMaxTbx);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.saldoMinTbx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 179);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 49);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lagersaldo";
            // 
            // saldoMaxTbx
            // 
            this.saldoMaxTbx.Location = new System.Drawing.Point(173, 20);
            this.saldoMaxTbx.Name = "saldoMaxTbx";
            this.saldoMaxTbx.Size = new System.Drawing.Size(39, 20);
            this.saldoMaxTbx.TabIndex = 3;
            this.saldoMaxTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTbx_KeyUp);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Max:";
            // 
            // saldoMinTbx
            // 
            this.saldoMinTbx.Location = new System.Drawing.Point(55, 20);
            this.saldoMinTbx.Name = "saldoMinTbx";
            this.saldoMinTbx.Size = new System.Drawing.Size(39, 20);
            this.saldoMinTbx.TabIndex = 1;
            this.saldoMinTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTbx_KeyUp);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Min:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 4;
            // 
            // namnTbx
            // 
            this.namnTbx.Location = new System.Drawing.Point(102, 49);
            this.namnTbx.Name = "namnTbx";
            this.namnTbx.Size = new System.Drawing.Size(139, 20);
            this.namnTbx.TabIndex = 3;
            this.namnTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTbx_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Namn:";
            // 
            // lagerSearchBtn
            // 
            this.lagerSearchBtn.Location = new System.Drawing.Point(166, 250);
            this.lagerSearchBtn.Name = "lagerSearchBtn";
            this.lagerSearchBtn.Size = new System.Drawing.Size(75, 23);
            this.lagerSearchBtn.TabIndex = 11;
            this.lagerSearchBtn.Text = "Sök";
            this.lagerSearchBtn.UseVisualStyleBackColor = true;
            this.lagerSearchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varunummer:";
            // 
            // lagerVarunrTbx
            // 
            this.lagerVarunrTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerVarunrTbx.Location = new System.Drawing.Point(102, 17);
            this.lagerVarunrTbx.Name = "lagerVarunrTbx";
            this.lagerVarunrTbx.Size = new System.Drawing.Size(139, 20);
            this.lagerVarunrTbx.TabIndex = 1;
            this.lagerVarunrTbx.KeyUp += new System.Windows.Forms.KeyEventHandler(this.searchTbx_KeyUp);
            this.lagerVarunrTbx.Leave += new System.EventHandler(this.search_Click);
            // 
            // lagerAllProdGbx
            // 
            this.lagerAllProdGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lagerAllProdGbx.Controls.Add(this.panel2);
            this.lagerAllProdGbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerAllProdGbx.Location = new System.Drawing.Point(274, 0);
            this.lagerAllProdGbx.Name = "lagerAllProdGbx";
            this.lagerAllProdGbx.Padding = new System.Windows.Forms.Padding(6);
            this.lagerAllProdGbx.Size = new System.Drawing.Size(320, 324);
            this.lagerAllProdGbx.TabIndex = 1;
            this.lagerAllProdGbx.TabStop = false;
            this.lagerAllProdGbx.Text = "2. Produkturval";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.prodDgw);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel2.Location = new System.Drawing.Point(6, 34);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(308, 284);
            this.panel2.TabIndex = 0;
            // 
            // prodDgw
            // 
            this.prodDgw.AllowUserToAddRows = false;
            this.prodDgw.AllowUserToDeleteRows = false;
            this.prodDgw.AllowUserToResizeRows = false;
            this.prodDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.prodDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.prodDgw.Location = new System.Drawing.Point(0, 0);
            this.prodDgw.MultiSelect = false;
            this.prodDgw.Name = "prodDgw";
            this.prodDgw.ReadOnly = true;
            this.prodDgw.RowHeadersVisible = false;
            this.prodDgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.prodDgw.Size = new System.Drawing.Size(308, 284);
            this.prodDgw.StandardTab = true;
            this.prodDgw.TabIndex = 0;
            this.prodDgw.SelectionChanged += new System.EventHandler(this.lagerProdDgw_SelectionChanged);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lagerAllProdGbx);
            this.Name = "SearchForm";
            this.Size = new System.Drawing.Size(596, 324);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.lagerAllProdGbx.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.prodDgw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button lagerSearchBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lagerVarunrTbx;
        private System.Windows.Forms.GroupBox lagerAllProdGbx;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView prodDgw;
        private System.Windows.Forms.TextBox namnTbx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox saldoMaxTbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox saldoMinTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox namnExaktCbx;
        private System.Windows.Forms.Button rensaBtn;
        private System.Windows.Forms.ComboBox kategoriCbx;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox lagerfordaProdCbx;
    }
}
