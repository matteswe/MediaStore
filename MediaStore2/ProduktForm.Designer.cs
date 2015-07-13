namespace MediaStore
{
    partial class ProduktForm
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
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saldoTbx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.kategoriCbx = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.prisTbx = new System.Windows.Forms.TextBox();
            this.namnTbx = new System.Windows.Forms.TextBox();
            this.varunrTbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okBtn = new System.Windows.Forms.Button();
            this.avbrytBtn = new System.Windows.Forms.Button();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.groupBox1);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.okBtn);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.avbrytBtn);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(333, 262);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(333, 284);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            this.toolStripContainer1.TopToolStripPanelVisible = false;
            // 
            // statusStrip
            // 
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 0);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(333, 22);
            this.statusStrip.TabIndex = 0;
            // 
            // statusLbl
            // 
            this.statusLbl.Name = "statusLbl";
            this.statusLbl.Size = new System.Drawing.Size(54, 17);
            this.statusLbl.Text = "statusLbl";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saldoTbx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.kategoriCbx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.prisTbx);
            this.groupBox1.Controls.Add(this.namnTbx);
            this.groupBox1.Controls.Add(this.varunrTbx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(285, 195);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkt";
            // 
            // saldoTbx
            // 
            this.saldoTbx.Location = new System.Drawing.Point(82, 159);
            this.saldoTbx.Name = "saldoTbx";
            this.saldoTbx.ReadOnly = true;
            this.saldoTbx.Size = new System.Drawing.Size(65, 20);
            this.saldoTbx.TabIndex = 20;
            this.saldoTbx.TabStop = false;
            this.saldoTbx.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 162);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lagersaldo:";
            // 
            // kategoriCbx
            // 
            this.kategoriCbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.kategoriCbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kategoriCbx.FormattingEnabled = true;
            this.kategoriCbx.Location = new System.Drawing.Point(82, 100);
            this.kategoriCbx.Name = "kategoriCbx";
            this.kategoriCbx.Size = new System.Drawing.Size(176, 21);
            this.kategoriCbx.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kategori:";
            // 
            // prisTbx
            // 
            this.prisTbx.Location = new System.Drawing.Point(82, 130);
            this.prisTbx.Name = "prisTbx";
            this.prisTbx.Size = new System.Drawing.Size(65, 20);
            this.prisTbx.TabIndex = 7;
            this.prisTbx.Text = "0";
            this.prisTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // namnTbx
            // 
            this.namnTbx.Location = new System.Drawing.Point(82, 68);
            this.namnTbx.Name = "namnTbx";
            this.namnTbx.Size = new System.Drawing.Size(176, 20);
            this.namnTbx.TabIndex = 3;
            this.namnTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbx_KeyPress);
            // 
            // varunrTbx
            // 
            this.varunrTbx.Location = new System.Drawing.Point(82, 29);
            this.varunrTbx.Name = "varunrTbx";
            this.varunrTbx.ReadOnly = true;
            this.varunrTbx.Size = new System.Drawing.Size(176, 20);
            this.varunrTbx.TabIndex = 1;
            this.varunrTbx.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pris [kr]:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Namn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varunr:";
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(175, 222);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(64, 23);
            this.okBtn.TabIndex = 1;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.adderaBtn_Click);
            // 
            // avbrytBtn
            // 
            this.avbrytBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.avbrytBtn.Location = new System.Drawing.Point(245, 222);
            this.avbrytBtn.Name = "avbrytBtn";
            this.avbrytBtn.Size = new System.Drawing.Size(64, 23);
            this.avbrytBtn.TabIndex = 2;
            this.avbrytBtn.Text = "Avbryt";
            this.avbrytBtn.UseVisualStyleBackColor = true;
            // 
            // ProduktForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 284);
            this.Controls.Add(this.toolStripContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProduktForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Addera produkt";
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox saldoTbx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox kategoriCbx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox prisTbx;
        private System.Windows.Forms.TextBox namnTbx;
        private System.Windows.Forms.TextBox varunrTbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button avbrytBtn;
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;

    }
}