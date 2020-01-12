namespace GameFace
{
    partial class Form3
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
            this.labelIgrica = new System.Windows.Forms.Label();
            this.labelLink = new System.Windows.Forms.Label();
            this.labelZanr = new System.Windows.Forms.Label();
            this.labelOcena = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnPrikaziKom = new System.Windows.Forms.Button();
            this.rtbOpis = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelIgrica
            // 
            this.labelIgrica.AutoSize = true;
            this.labelIgrica.Location = new System.Drawing.Point(34, 37);
            this.labelIgrica.Name = "labelIgrica";
            this.labelIgrica.Size = new System.Drawing.Size(42, 17);
            this.labelIgrica.TabIndex = 0;
            this.labelIgrica.Text = "Igrica";
            // 
            // labelLink
            // 
            this.labelLink.AutoSize = true;
            this.labelLink.Location = new System.Drawing.Point(34, 141);
            this.labelLink.Name = "labelLink";
            this.labelLink.Size = new System.Drawing.Size(109, 17);
            this.labelLink.TabIndex = 1;
            this.labelLink.Text = "Link za skidanje";
            // 
            // labelZanr
            // 
            this.labelZanr.AutoSize = true;
            this.labelZanr.Location = new System.Drawing.Point(34, 106);
            this.labelZanr.Name = "labelZanr";
            this.labelZanr.Size = new System.Drawing.Size(38, 17);
            this.labelZanr.TabIndex = 2;
            this.labelZanr.Text = "Zanr";
            // 
            // labelOcena
            // 
            this.labelOcena.AutoSize = true;
            this.labelOcena.Location = new System.Drawing.Point(34, 72);
            this.labelOcena.Name = "labelOcena";
            this.labelOcena.Size = new System.Drawing.Size(110, 17);
            this.labelOcena.TabIndex = 3;
            this.labelOcena.Text = "Ocena korisnika";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(416, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Komentari korisnika";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(302, 248);
            this.dataGridView1.TabIndex = 5;
            // 
            // btnPrikaziKom
            // 
            this.btnPrikaziKom.Location = new System.Drawing.Point(585, 37);
            this.btnPrikaziKom.Name = "btnPrikaziKom";
            this.btnPrikaziKom.Size = new System.Drawing.Size(136, 23);
            this.btnPrikaziKom.TabIndex = 6;
            this.btnPrikaziKom.Text = "Prikazi ";
            this.btnPrikaziKom.UseVisualStyleBackColor = true;
            this.btnPrikaziKom.Click += new System.EventHandler(this.btnPrikaziKom_Click);
            // 
            // rtbOpis
            // 
            this.rtbOpis.Location = new System.Drawing.Point(37, 184);
            this.rtbOpis.Name = "rtbOpis";
            this.rtbOpis.Size = new System.Drawing.Size(260, 136);
            this.rtbOpis.TabIndex = 7;
            this.rtbOpis.Text = "";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 375);
            this.Controls.Add(this.rtbOpis);
            this.Controls.Add(this.btnPrikaziKom);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelOcena);
            this.Controls.Add(this.labelZanr);
            this.Controls.Add(this.labelLink);
            this.Controls.Add(this.labelIgrica);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIgrica;
        private System.Windows.Forms.Label labelLink;
        private System.Windows.Forms.Label labelZanr;
        private System.Windows.Forms.Label labelOcena;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnPrikaziKom;
        private System.Windows.Forms.RichTextBox rtbOpis;
    }
}