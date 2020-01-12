namespace GameFace
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnZanrPrikazi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNazivIgrice = new System.Windows.Forms.TextBox();
            this.btnPrikaziIgricu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbOcena = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbKomentar = new System.Windows.Forms.RichTextBox();
            this.btnOceni = new System.Windows.Forms.Button();
            this.btnKomentarisi = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zanr";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(28, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(295, 317);
            this.dataGridView1.TabIndex = 2;
            // 
            // btnZanrPrikazi
            // 
            this.btnZanrPrikazi.Location = new System.Drawing.Point(219, 23);
            this.btnZanrPrikazi.Name = "btnZanrPrikazi";
            this.btnZanrPrikazi.Size = new System.Drawing.Size(104, 23);
            this.btnZanrPrikazi.TabIndex = 3;
            this.btnZanrPrikazi.Text = "Prikazi";
            this.btnZanrPrikazi.UseVisualStyleBackColor = true;
            this.btnZanrPrikazi.Click += new System.EventHandler(this.btnZanrPrikazi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Naziv igrice";
            // 
            // tbNazivIgrice
            // 
            this.tbNazivIgrice.Location = new System.Drawing.Point(462, 28);
            this.tbNazivIgrice.Name = "tbNazivIgrice";
            this.tbNazivIgrice.Size = new System.Drawing.Size(138, 22);
            this.tbNazivIgrice.TabIndex = 5;
            // 
            // btnPrikaziIgricu
            // 
            this.btnPrikaziIgricu.Location = new System.Drawing.Point(606, 27);
            this.btnPrikaziIgricu.Name = "btnPrikaziIgricu";
            this.btnPrikaziIgricu.Size = new System.Drawing.Size(75, 23);
            this.btnPrikaziIgricu.TabIndex = 6;
            this.btnPrikaziIgricu.Text = "Prikazi";
            this.btnPrikaziIgricu.UseVisualStyleBackColor = true;
            this.btnPrikaziIgricu.Click += new System.EventHandler(this.btnPrikaziIgricu_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(385, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ocenite igricu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(385, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ocena";
            // 
            // cbOcena
            // 
            this.cbOcena.FormattingEnabled = true;
            this.cbOcena.Location = new System.Drawing.Point(462, 101);
            this.cbOcena.Name = "cbOcena";
            this.cbOcena.Size = new System.Drawing.Size(55, 24);
            this.cbOcena.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ostavite komentar";
            // 
            // tbKomentar
            // 
            this.tbKomentar.Location = new System.Drawing.Point(388, 190);
            this.tbKomentar.Name = "tbKomentar";
            this.tbKomentar.Size = new System.Drawing.Size(236, 111);
            this.tbKomentar.TabIndex = 14;
            this.tbKomentar.Text = "";
            this.tbKomentar.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // btnOceni
            // 
            this.btnOceni.Location = new System.Drawing.Point(560, 101);
            this.btnOceni.Name = "btnOceni";
            this.btnOceni.Size = new System.Drawing.Size(75, 24);
            this.btnOceni.TabIndex = 15;
            this.btnOceni.Text = "Oceni";
            this.btnOceni.UseVisualStyleBackColor = true;
            this.btnOceni.Click += new System.EventHandler(this.btnOceni_Click);
            // 
            // btnKomentarisi
            // 
            this.btnKomentarisi.Location = new System.Drawing.Point(388, 329);
            this.btnKomentarisi.Name = "btnKomentarisi";
            this.btnKomentarisi.Size = new System.Drawing.Size(131, 31);
            this.btnKomentarisi.TabIndex = 16;
            this.btnKomentarisi.Text = "Postavi komentar";
            this.btnKomentarisi.UseVisualStyleBackColor = true;
            this.btnKomentarisi.Click += new System.EventHandler(this.btnKomentarisi_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(70, 20);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(143, 24);
            this.comboBox1.TabIndex = 17;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 431);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnKomentarisi);
            this.Controls.Add(this.btnOceni);
            this.Controls.Add(this.tbKomentar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbOcena);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnPrikaziIgricu);
            this.Controls.Add(this.tbNazivIgrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnZanrPrikazi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnZanrPrikazi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNazivIgrice;
        private System.Windows.Forms.Button btnPrikaziIgricu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbOcena;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox tbKomentar;
        private System.Windows.Forms.Button btnOceni;
        private System.Windows.Forms.Button btnKomentarisi;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}