namespace MediaStore
{
    partial class AterkopForm
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
            this.aterkopCompactSearchForm = new MediaStore.CompactSearchForm();
            this.label3 = new System.Windows.Forms.Label();
            this.antalTbx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.verkstallBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.avbrytBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.betalaTbx = new System.Windows.Forms.TextBox();
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.verkstallBtn);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.okBtn);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.avbrytBtn);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label4);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.betalaTbx);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(369, 226);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(369, 248);
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
            this.statusStrip.Size = new System.Drawing.Size(369, 22);
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
            this.groupBox1.Controls.Add(this.aterkopCompactSearchForm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.antalTbx);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkt";
            // 
            // aterkopCompactSearchForm
            // 
            this.aterkopCompactSearchForm.Location = new System.Drawing.Point(18, 24);
            this.aterkopCompactSearchForm.Name = "aterkopCompactSearchForm";
            this.aterkopCompactSearchForm.Size = new System.Drawing.Size(290, 42);
            this.aterkopCompactSearchForm.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(149, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Antalet återförs till lagersaldot.";
            // 
            // antalTbx
            // 
            this.antalTbx.Location = new System.Drawing.Point(56, 82);
            this.antalTbx.Name = "antalTbx";
            this.antalTbx.Size = new System.Drawing.Size(81, 20);
            this.antalTbx.TabIndex = 2;
            this.antalTbx.TextChanged += new System.EventHandler(this.antalTbx_TextChanged);
            this.antalTbx.Enter += new System.EventHandler(this.tbx_Enter);
            this.antalTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.antalTbx_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Antal:";
            // 
            // verkstallBtn
            // 
            this.verkstallBtn.Location = new System.Drawing.Point(109, 185);
            this.verkstallBtn.Name = "verkstallBtn";
            this.verkstallBtn.Size = new System.Drawing.Size(75, 23);
            this.verkstallBtn.TabIndex = 3;
            this.verkstallBtn.Text = "Verkställ";
            this.verkstallBtn.UseVisualStyleBackColor = true;
            this.verkstallBtn.Click += new System.EventHandler(this.verkstallBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(190, 185);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 4;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // avbrytBtn
            // 
            this.avbrytBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.avbrytBtn.Location = new System.Drawing.Point(271, 185);
            this.avbrytBtn.Name = "avbrytBtn";
            this.avbrytBtn.Size = new System.Drawing.Size(75, 23);
            this.avbrytBtn.TabIndex = 5;
            this.avbrytBtn.Text = "Avsluta";
            this.avbrytBtn.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Summa att återbetala:";
            // 
            // betalaTbx
            // 
            this.betalaTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.betalaTbx.Location = new System.Drawing.Point(201, 143);
            this.betalaTbx.Name = "betalaTbx";
            this.betalaTbx.ReadOnly = true;
            this.betalaTbx.Size = new System.Drawing.Size(100, 20);
            this.betalaTbx.TabIndex = 2;
            this.betalaTbx.TabStop = false;
            // 
            // AterkopForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 248);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AterkopForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Återköp";
            this.Load += new System.EventHandler(this.AterkopForm_Load);
            this.toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.BottomToolStripPanel.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
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
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.Button verkstallBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button avbrytBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox betalaTbx;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox antalTbx;
        private System.Windows.Forms.Label label2;
        private CompactSearchForm aterkopCompactSearchForm;

    }
}