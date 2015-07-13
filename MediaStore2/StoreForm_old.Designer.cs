namespace MediaStore
{
    partial class StoreForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreForm));
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.butikPage = new System.Windows.Forms.TabPage();
            this.removeBuyBtn = new System.Windows.Forms.Button();
            this.execBuyBtn = new System.Windows.Forms.Button();
            this.abortBuyBtn = new System.Windows.Forms.Button();
            this.addBuyBtn = new System.Windows.Forms.Button();
            this.butikVarukorgGbx = new System.Windows.Forms.GroupBox();
            this.varukorgPanel = new System.Windows.Forms.Panel();
            this.varukorgDgw = new System.Windows.Forms.DataGridView();
            this.VarunrCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Namn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lagerPage = new System.Windows.Forms.TabPage();
            this.lagerProdGbx = new System.Windows.Forms.GroupBox();
            this.lagerRedigeraProdBtn = new System.Windows.Forms.Button();
            this.lagerSaldoTbx = new System.Windows.Forms.TextBox();
            this.lagerPrisTbx = new System.Windows.Forms.TextBox();
            this.lagerKategoriTbx = new System.Windows.Forms.TextBox();
            this.lagerNamnTbx = new System.Windows.Forms.TextBox();
            this.lagerVarunrTbx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.statistikPage = new System.Windows.Forms.TabPage();
            this.butikToolStrip = new System.Windows.Forms.ToolStrip();
            this.aterkopBtn = new System.Windows.Forms.ToolStripButton();
            this.lagerToolStrip = new System.Windows.Forms.ToolStrip();
            this.addProduktBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.raderaProduktBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.inleveransBtn = new System.Windows.Forms.ToolStripButton();
            this.kvittoPrintDoc = new System.Drawing.Printing.PrintDocument();
            this.printDialog = new System.Windows.Forms.PrintDialog();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.butikPage.SuspendLayout();
            this.butikVarukorgGbx.SuspendLayout();
            this.varukorgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.varukorgDgw)).BeginInit();
            this.lagerPage.SuspendLayout();
            this.lagerProdGbx.SuspendLayout();
            this.butikToolStrip.SuspendLayout();
            this.lagerToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.BottomToolStripPanel
            // 
            this.toolStripContainer1.BottomToolStripPanel.Controls.Add(this.statusStrip);
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.tabControl);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(944, 432);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(944, 479);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.butikToolStrip);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.lagerToolStrip);
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(944, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.butikPage);
            this.tabControl.Controls.Add(this.lagerPage);
            this.tabControl.Controls.Add(this.statistikPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(944, 432);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // butikPage
            // 
            this.butikPage.Location = new System.Drawing.Point(4, 22);
            this.butikPage.Name = "butikPage";
            this.butikPage.Padding = new System.Windows.Forms.Padding(3);
            this.butikPage.Size = new System.Drawing.Size(936, 406);
            this.butikPage.TabIndex = 0;
            this.butikPage.Text = "Butik";
            this.butikPage.UseVisualStyleBackColor = true;
            // 
            // removeBuyBtn
            // 
            this.removeBuyBtn.Location = new System.Drawing.Point(551, 170);
            this.removeBuyBtn.Name = "removeBuyBtn";
            this.removeBuyBtn.Size = new System.Drawing.Size(75, 59);
            this.removeBuyBtn.TabIndex = 5;
            this.removeBuyBtn.Text = "Ta ur varukorgen <--";
            this.removeBuyBtn.UseVisualStyleBackColor = true;
            this.removeBuyBtn.Click += new System.EventHandler(this.removeBuyBtn_Click);
            // 
            // execBuyBtn
            // 
            this.execBuyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.execBuyBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.execBuyBtn.Location = new System.Drawing.Point(686, 347);
            this.execBuyBtn.Name = "execBuyBtn";
            this.execBuyBtn.Size = new System.Drawing.Size(86, 40);
            this.execBuyBtn.TabIndex = 3;
            this.execBuyBtn.Text = "Slutför köp";
            this.execBuyBtn.UseVisualStyleBackColor = false;
            this.execBuyBtn.Click += new System.EventHandler(this.execBuyBtn_Click);
            // 
            // abortBuyBtn
            // 
            this.abortBuyBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.abortBuyBtn.BackColor = System.Drawing.Color.Coral;
            this.abortBuyBtn.Location = new System.Drawing.Point(796, 347);
            this.abortBuyBtn.Name = "abortBuyBtn";
            this.abortBuyBtn.Size = new System.Drawing.Size(86, 40);
            this.abortBuyBtn.TabIndex = 4;
            this.abortBuyBtn.Text = "Avbryt köp";
            this.abortBuyBtn.UseVisualStyleBackColor = false;
            this.abortBuyBtn.Click += new System.EventHandler(this.abortBuyBtn_Click);
            // 
            // addBuyBtn
            // 
            this.addBuyBtn.Location = new System.Drawing.Point(551, 88);
            this.addBuyBtn.Name = "addBuyBtn";
            this.addBuyBtn.Size = new System.Drawing.Size(75, 59);
            this.addBuyBtn.TabIndex = 2;
            this.addBuyBtn.Text = "Lägg i varukorgen -->";
            this.addBuyBtn.UseVisualStyleBackColor = true;
            this.addBuyBtn.Click += new System.EventHandler(this.addBuyBtn_Click);
            // 
            // butikVarukorgGbx
            // 
            this.butikVarukorgGbx.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.butikVarukorgGbx.Controls.Add(this.varukorgPanel);
            this.butikVarukorgGbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butikVarukorgGbx.Location = new System.Drawing.Point(634, 6);
            this.butikVarukorgGbx.Name = "butikVarukorgGbx";
            this.butikVarukorgGbx.Size = new System.Drawing.Size(294, 335);
            this.butikVarukorgGbx.TabIndex = 1;
            this.butikVarukorgGbx.TabStop = false;
            this.butikVarukorgGbx.Text = "3. Varukorg";
            // 
            // varukorgPanel
            // 
            this.varukorgPanel.Controls.Add(this.varukorgDgw);
            this.varukorgPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.varukorgPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.varukorgPanel.Location = new System.Drawing.Point(3, 31);
            this.varukorgPanel.Name = "varukorgPanel";
            this.varukorgPanel.Size = new System.Drawing.Size(288, 301);
            this.varukorgPanel.TabIndex = 0;
            // 
            // varukorgDgw
            // 
            this.varukorgDgw.AllowUserToAddRows = false;
            this.varukorgDgw.AllowUserToDeleteRows = false;
            this.varukorgDgw.AllowUserToResizeRows = false;
            this.varukorgDgw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.varukorgDgw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VarunrCol,
            this.Namn,
            this.SaldoCol});
            this.varukorgDgw.Dock = System.Windows.Forms.DockStyle.Fill;
            this.varukorgDgw.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.varukorgDgw.Location = new System.Drawing.Point(0, 0);
            this.varukorgDgw.Name = "varukorgDgw";
            this.varukorgDgw.ReadOnly = true;
            this.varukorgDgw.RowHeadersVisible = false;
            this.varukorgDgw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.varukorgDgw.Size = new System.Drawing.Size(288, 301);
            this.varukorgDgw.StandardTab = true;
            this.varukorgDgw.TabIndex = 1;
            this.varukorgDgw.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.varukorgDgw_CellFormatting);
            // 
            // VarunrCol
            // 
            this.VarunrCol.HeaderText = "Varunr";
            this.VarunrCol.Name = "VarunrCol";
            this.VarunrCol.ReadOnly = true;
            this.VarunrCol.Width = 44;
            // 
            // Namn
            // 
            this.Namn.HeaderText = " Namn";
            this.Namn.Name = "Namn";
            this.Namn.ReadOnly = true;
            this.Namn.Width = 200;
            // 
            // SaldoCol
            // 
            this.SaldoCol.HeaderText = "Antal";
            this.SaldoCol.Name = "SaldoCol";
            this.SaldoCol.ReadOnly = true;
            this.SaldoCol.Width = 40;
            // 
            // lagerPage
            // 
            this.lagerPage.Location = new System.Drawing.Point(4, 22);
            this.lagerPage.Name = "lagerPage";
            this.lagerPage.Padding = new System.Windows.Forms.Padding(3);
            this.lagerPage.Size = new System.Drawing.Size(936, 406);
            this.lagerPage.TabIndex = 1;
            this.lagerPage.Text = "Lager";
            this.lagerPage.UseVisualStyleBackColor = true;
            // 
            // lagerProdGbx
            // 
            this.lagerProdGbx.Controls.Add(this.lagerRedigeraProdBtn);
            this.lagerProdGbx.Controls.Add(this.lagerSaldoTbx);
            this.lagerProdGbx.Controls.Add(this.lagerPrisTbx);
            this.lagerProdGbx.Controls.Add(this.lagerKategoriTbx);
            this.lagerProdGbx.Controls.Add(this.lagerNamnTbx);
            this.lagerProdGbx.Controls.Add(this.lagerVarunrTbx);
            this.lagerProdGbx.Controls.Add(this.label5);
            this.lagerProdGbx.Controls.Add(this.label4);
            this.lagerProdGbx.Controls.Add(this.label3);
            this.lagerProdGbx.Controls.Add(this.label2);
            this.lagerProdGbx.Controls.Add(this.label1);
            this.lagerProdGbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerProdGbx.Location = new System.Drawing.Point(550, 7);
            this.lagerProdGbx.Name = "lagerProdGbx";
            this.lagerProdGbx.Size = new System.Drawing.Size(378, 399);
            this.lagerProdGbx.TabIndex = 1;
            this.lagerProdGbx.TabStop = false;
            this.lagerProdGbx.Text = "3. Vald produkt";
            // 
            // lagerRedigeraProdBtn
            // 
            this.lagerRedigeraProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerRedigeraProdBtn.Location = new System.Drawing.Point(267, 238);
            this.lagerRedigeraProdBtn.Name = "lagerRedigeraProdBtn";
            this.lagerRedigeraProdBtn.Size = new System.Drawing.Size(75, 23);
            this.lagerRedigeraProdBtn.TabIndex = 10;
            this.lagerRedigeraProdBtn.Text = "Redigera";
            this.lagerRedigeraProdBtn.UseVisualStyleBackColor = true;
            this.lagerRedigeraProdBtn.Click += new System.EventHandler(this.lagerRedigeraProdBtn_Click);
            // 
            // lagerSaldoTbx
            // 
            this.lagerSaldoTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerSaldoTbx.Location = new System.Drawing.Point(109, 204);
            this.lagerSaldoTbx.Name = "lagerSaldoTbx";
            this.lagerSaldoTbx.ReadOnly = true;
            this.lagerSaldoTbx.Size = new System.Drawing.Size(73, 20);
            this.lagerSaldoTbx.TabIndex = 9;
            // 
            // lagerPrisTbx
            // 
            this.lagerPrisTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerPrisTbx.Location = new System.Drawing.Point(109, 165);
            this.lagerPrisTbx.Name = "lagerPrisTbx";
            this.lagerPrisTbx.ReadOnly = true;
            this.lagerPrisTbx.Size = new System.Drawing.Size(73, 20);
            this.lagerPrisTbx.TabIndex = 8;
            // 
            // lagerKategoriTbx
            // 
            this.lagerKategoriTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerKategoriTbx.Location = new System.Drawing.Point(109, 125);
            this.lagerKategoriTbx.Name = "lagerKategoriTbx";
            this.lagerKategoriTbx.ReadOnly = true;
            this.lagerKategoriTbx.Size = new System.Drawing.Size(233, 20);
            this.lagerKategoriTbx.TabIndex = 7;
            // 
            // lagerNamnTbx
            // 
            this.lagerNamnTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerNamnTbx.Location = new System.Drawing.Point(109, 88);
            this.lagerNamnTbx.Name = "lagerNamnTbx";
            this.lagerNamnTbx.ReadOnly = true;
            this.lagerNamnTbx.Size = new System.Drawing.Size(233, 20);
            this.lagerNamnTbx.TabIndex = 6;
            // 
            // lagerVarunrTbx
            // 
            this.lagerVarunrTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lagerVarunrTbx.Location = new System.Drawing.Point(109, 51);
            this.lagerVarunrTbx.Name = "lagerVarunrTbx";
            this.lagerVarunrTbx.ReadOnly = true;
            this.lagerVarunrTbx.Size = new System.Drawing.Size(233, 20);
            this.lagerVarunrTbx.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 207);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Lagersaldo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Pris [kr]:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(22, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kategori:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varunummer:";
            // 
            // statistikPage
            // 
            this.statistikPage.Location = new System.Drawing.Point(4, 22);
            this.statistikPage.Name = "statistikPage";
            this.statistikPage.Size = new System.Drawing.Size(936, 406);
            this.statistikPage.TabIndex = 2;
            this.statistikPage.Text = "Statistik";
            this.statistikPage.UseVisualStyleBackColor = true;
            // 
            // butikToolStrip
            // 
            this.butikToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.butikToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aterkopBtn});
            this.butikToolStrip.Location = new System.Drawing.Point(3, 0);
            this.butikToolStrip.Name = "butikToolStrip";
            this.butikToolStrip.Size = new System.Drawing.Size(65, 25);
            this.butikToolStrip.TabIndex = 1;
            // 
            // aterkopBtn
            // 
            this.aterkopBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.aterkopBtn.Image = ((System.Drawing.Image)(resources.GetObject("aterkopBtn.Image")));
            this.aterkopBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aterkopBtn.Name = "aterkopBtn";
            this.aterkopBtn.Size = new System.Drawing.Size(53, 22);
            this.aterkopBtn.Text = "Återköp";
            this.aterkopBtn.Click += new System.EventHandler(this.aterkopBtn_Click);
            // 
            // lagerToolStrip
            // 
            this.lagerToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.lagerToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addProduktBtn,
            this.toolStripSeparator1,
            this.raderaProduktBtn,
            this.toolStripSeparator2,
            this.inleveransBtn});
            this.lagerToolStrip.Location = new System.Drawing.Point(68, 0);
            this.lagerToolStrip.Name = "lagerToolStrip";
            this.lagerToolStrip.Size = new System.Drawing.Size(287, 25);
            this.lagerToolStrip.TabIndex = 0;
            // 
            // addProduktBtn
            // 
            this.addProduktBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addProduktBtn.Image = ((System.Drawing.Image)(resources.GetObject("addProduktBtn.Image")));
            this.addProduktBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addProduktBtn.Name = "addProduktBtn";
            this.addProduktBtn.Size = new System.Drawing.Size(94, 22);
            this.addProduktBtn.Text = "Addera produkt";
            this.addProduktBtn.Click += new System.EventHandler(this.addProductBtn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // raderaProduktBtn
            // 
            this.raderaProduktBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.raderaProduktBtn.Image = ((System.Drawing.Image)(resources.GetObject("raderaProduktBtn.Image")));
            this.raderaProduktBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.raderaProduktBtn.Name = "raderaProduktBtn";
            this.raderaProduktBtn.Size = new System.Drawing.Size(105, 22);
            this.raderaProduktBtn.Text = "Makulera produkt";
            this.raderaProduktBtn.Click += new System.EventHandler(this.deleteProductBtn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // inleveransBtn
            // 
            this.inleveransBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.inleveransBtn.Image = ((System.Drawing.Image)(resources.GetObject("inleveransBtn.Image")));
            this.inleveransBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.inleveransBtn.Name = "inleveransBtn";
            this.inleveransBtn.Size = new System.Drawing.Size(64, 22);
            this.inleveransBtn.Text = "Inleverans";
            // 
            // printDialog
            // 
            this.printDialog.Document = this.kvittoPrintDoc;
            this.printDialog.UseEXDialog = true;
            // 
            // StoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 479);
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MediaStore";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.butikPage.ResumeLayout(false);
            this.butikVarukorgGbx.ResumeLayout(false);
            this.varukorgPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.varukorgDgw)).EndInit();
            this.lagerPage.ResumeLayout(false);
            this.lagerProdGbx.ResumeLayout(false);
            this.lagerProdGbx.PerformLayout();
            this.butikToolStrip.ResumeLayout(false);
            this.butikToolStrip.PerformLayout();
            this.lagerToolStrip.ResumeLayout(false);
            this.lagerToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage butikPage;
        private System.Windows.Forms.TabPage lagerPage;
        private System.Windows.Forms.TabPage statistikPage;
        private System.Windows.Forms.ToolStrip lagerToolStrip;
        private System.Windows.Forms.ToolStripButton addProduktBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton raderaProduktBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton inleveransBtn;
        private MediaStore.SearchForm butikSearchForm;
        private System.Windows.Forms.GroupBox lagerProdGbx;
        private MediaStore.SearchForm lagerSearchForm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lagerRedigeraProdBtn;
        private System.Windows.Forms.TextBox lagerSaldoTbx;
        private System.Windows.Forms.TextBox lagerPrisTbx;
        private System.Windows.Forms.TextBox lagerKategoriTbx;
        private System.Windows.Forms.TextBox lagerNamnTbx;
        private System.Windows.Forms.TextBox lagerVarunrTbx;
        private System.Windows.Forms.GroupBox butikVarukorgGbx;
        private System.Windows.Forms.ToolStrip butikToolStrip;
        private System.Windows.Forms.ToolStripButton aterkopBtn;
        private System.Windows.Forms.Button addBuyBtn;
        private System.Windows.Forms.Button abortBuyBtn;
        private System.Windows.Forms.Button execBuyBtn;
        private System.Windows.Forms.Panel varukorgPanel;
        private System.Windows.Forms.DataGridView varukorgDgw;
        private System.Windows.Forms.Button removeBuyBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn VarunrCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Namn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoCol;
        private System.Drawing.Printing.PrintDocument kvittoPrintDoc;
        private System.Windows.Forms.PrintDialog printDialog;
    }
}

