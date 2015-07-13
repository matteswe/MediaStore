namespace MediaStore
{
    partial class InleveransForm
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
            this.avslutaBtn = new System.Windows.Forms.Button();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.statusLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.antalTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inlevCompactSearchForm = new MediaStore.CompactSearchForm();
            this.okBtn = new System.Windows.Forms.Button();
            this.verkstallBtn = new System.Windows.Forms.Button();
            this.toolStripContainer1.BottomToolStripPanel.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // avslutaBtn
            // 
            this.avslutaBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.avslutaBtn.Location = new System.Drawing.Point(271, 151);
            this.avslutaBtn.Name = "avslutaBtn";
            this.avslutaBtn.Size = new System.Drawing.Size(75, 23);
            this.avslutaBtn.TabIndex = 3;
            this.avslutaBtn.Text = "Avsluta";
            this.avslutaBtn.UseVisualStyleBackColor = true;
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
            this.toolStripContainer1.ContentPanel.Controls.Add(this.avslutaBtn);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.okBtn);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.verkstallBtn);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(369, 194);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.LeftToolStripPanelVisible = false;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.RightToolStripPanelVisible = false;
            this.toolStripContainer1.Size = new System.Drawing.Size(369, 216);
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
            this.groupBox1.Controls.Add(this.antalTbx);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inlevCompactSearchForm);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 117);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Produkt";
            // 
            // antalTbx
            // 
            this.antalTbx.Location = new System.Drawing.Point(122, 82);
            this.antalTbx.Name = "antalTbx";
            this.antalTbx.Size = new System.Drawing.Size(85, 20);
            this.antalTbx.TabIndex = 2;
            this.antalTbx.Enter += new System.EventHandler(this.antalTbx_Enter);
            this.antalTbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.antalTbx_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Antal för inleverans:";
            // 
            // inlevCompactSearchForm
            // 
            this.inlevCompactSearchForm.Location = new System.Drawing.Point(18, 24);
            this.inlevCompactSearchForm.Name = "inlevCompactSearchForm";
            this.inlevCompactSearchForm.Size = new System.Drawing.Size(290, 42);
            this.inlevCompactSearchForm.TabIndex = 0;
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(190, 151);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(75, 23);
            this.okBtn.TabIndex = 2;
            this.okBtn.Text = "Ok";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // verkstallBtn
            // 
            this.verkstallBtn.Location = new System.Drawing.Point(109, 151);
            this.verkstallBtn.Name = "verkstallBtn";
            this.verkstallBtn.Size = new System.Drawing.Size(75, 23);
            this.verkstallBtn.TabIndex = 0;
            this.verkstallBtn.Text = "Verkställ";
            this.verkstallBtn.UseVisualStyleBackColor = true;
            this.verkstallBtn.Click += new System.EventHandler(this.verkstallBtn_Click);
            // 
            // InleveransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.avslutaBtn;
            this.ClientSize = new System.Drawing.Size(369, 216);
            this.Controls.Add(this.toolStripContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InleveransForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inleverans";
            this.Load += new System.EventHandler(this.InleveransForm_Load);
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
        private System.Windows.Forms.ToolStripStatusLabel statusLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox antalTbx;
        private System.Windows.Forms.Label label1;
        private CompactSearchForm inlevCompactSearchForm;
        private System.Windows.Forms.Button avslutaBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Button verkstallBtn;

    }
}