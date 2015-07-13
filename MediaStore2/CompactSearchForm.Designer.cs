namespace MediaStore
{
    partial class CompactSearchForm
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
            this.namnCbx = new System.Windows.Forms.ComboBox();
            this.varunrTbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namnCbx
            // 
            this.namnCbx.FormattingEnabled = true;
            this.namnCbx.Location = new System.Drawing.Point(80, 16);
            this.namnCbx.Name = "namnCbx";
            this.namnCbx.Size = new System.Drawing.Size(207, 21);
            this.namnCbx.Sorted = true;
            this.namnCbx.TabIndex = 3;
            this.namnCbx.TextChanged += new System.EventHandler(this.namnCbx_TextChanged);
            this.namnCbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.namnCbx_KeyDown);
            this.namnCbx.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.namnCbx_KeyPress);
            // 
            // varunrTbx
            // 
            this.varunrTbx.Location = new System.Drawing.Point(3, 16);
            this.varunrTbx.Name = "varunrTbx";
            this.varunrTbx.Size = new System.Drawing.Size(71, 20);
            this.varunrTbx.TabIndex = 2;
            this.varunrTbx.TextChanged += new System.EventHandler(this.varunrTbx_TextChanged);
            this.varunrTbx.Enter += new System.EventHandler(this.varunrTbx_Enter);
            this.varunrTbx.KeyDown += new System.Windows.Forms.KeyEventHandler(this.varunrTbx_KeyDown);
            this.varunrTbx.Leave += new System.EventHandler(this.varunrTbx_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Varunr";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Namn";
            // 
            // CompactSearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.varunrTbx);
            this.Controls.Add(this.namnCbx);
            this.Name = "CompactSearchForm";
            this.Size = new System.Drawing.Size(290, 42);
            this.Load += new System.EventHandler(this.CompactSearchForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox namnCbx;
        private System.Windows.Forms.TextBox varunrTbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
