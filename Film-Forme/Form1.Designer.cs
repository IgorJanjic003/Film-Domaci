namespace Film_Forme
{
    partial class Form1
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
            this.id = new System.Windows.Forms.TextBox();
            this.naziv = new System.Windows.Forms.TextBox();
            this.trajanje = new System.Windows.Forms.TextBox();
            this.zanr = new System.Windows.Forms.TextBox();
            this.original = new System.Windows.Forms.TextBox();
            this.poreklo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.unesi = new System.Windows.Forms.Button();
            this.menjaj = new System.Windows.Forms.Button();
            this.brisi = new System.Windows.Forms.Button();
            this.sledeci = new System.Windows.Forms.Button();
            this.prethodni = new System.Windows.Forms.Button();
            this.pocetak = new System.Windows.Forms.Button();
            this.kraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.Location = new System.Drawing.Point(158, 70);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(100, 20);
            this.id.TabIndex = 0;
            // 
            // naziv
            // 
            this.naziv.Location = new System.Drawing.Point(158, 96);
            this.naziv.Name = "naziv";
            this.naziv.Size = new System.Drawing.Size(100, 20);
            this.naziv.TabIndex = 1;
            // 
            // trajanje
            // 
            this.trajanje.Location = new System.Drawing.Point(158, 122);
            this.trajanje.Name = "trajanje";
            this.trajanje.Size = new System.Drawing.Size(100, 20);
            this.trajanje.TabIndex = 2;
            // 
            // zanr
            // 
            this.zanr.Location = new System.Drawing.Point(158, 148);
            this.zanr.Name = "zanr";
            this.zanr.Size = new System.Drawing.Size(100, 20);
            this.zanr.TabIndex = 3;
            // 
            // original
            // 
            this.original.Location = new System.Drawing.Point(158, 174);
            this.original.Name = "original";
            this.original.Size = new System.Drawing.Size(100, 20);
            this.original.TabIndex = 4;
            // 
            // poreklo
            // 
            this.poreklo.Location = new System.Drawing.Point(158, 200);
            this.poreklo.Name = "poreklo";
            this.poreklo.Size = new System.Drawing.Size(100, 20);
            this.poreklo.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Naziv";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Trajanje";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Zanr";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Naziv originala";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Zemlja Porekla";
            // 
            // unesi
            // 
            this.unesi.Location = new System.Drawing.Point(308, 68);
            this.unesi.Name = "unesi";
            this.unesi.Size = new System.Drawing.Size(133, 74);
            this.unesi.TabIndex = 12;
            this.unesi.Text = "Unesi";
            this.unesi.UseVisualStyleBackColor = true;
            this.unesi.Click += new System.EventHandler(this.unesi_Click);
            // 
            // menjaj
            // 
            this.menjaj.Location = new System.Drawing.Point(418, 149);
            this.menjaj.Name = "menjaj";
            this.menjaj.Size = new System.Drawing.Size(75, 23);
            this.menjaj.TabIndex = 13;
            this.menjaj.Text = "Menjaj";
            this.menjaj.UseVisualStyleBackColor = true;
            this.menjaj.Click += new System.EventHandler(this.menjaj_Click);
            // 
            // brisi
            // 
            this.brisi.Location = new System.Drawing.Point(472, 68);
            this.brisi.Name = "brisi";
            this.brisi.Size = new System.Drawing.Size(133, 75);
            this.brisi.TabIndex = 14;
            this.brisi.Text = "Obrisi";
            this.brisi.UseVisualStyleBackColor = true;
            this.brisi.Click += new System.EventHandler(this.brisi_Click);
            // 
            // sledeci
            // 
            this.sledeci.Location = new System.Drawing.Point(530, 149);
            this.sledeci.Name = "sledeci";
            this.sledeci.Size = new System.Drawing.Size(75, 23);
            this.sledeci.TabIndex = 15;
            this.sledeci.Text = "Sledeci";
            this.sledeci.UseVisualStyleBackColor = true;
            this.sledeci.Click += new System.EventHandler(this.sledeci_Click);
            // 
            // prethodni
            // 
            this.prethodni.Location = new System.Drawing.Point(308, 148);
            this.prethodni.Name = "prethodni";
            this.prethodni.Size = new System.Drawing.Size(75, 23);
            this.prethodni.TabIndex = 16;
            this.prethodni.Text = "Prethodni";
            this.prethodni.UseVisualStyleBackColor = true;
            this.prethodni.Click += new System.EventHandler(this.prethodni_Click);
            // 
            // pocetak
            // 
            this.pocetak.Location = new System.Drawing.Point(308, 178);
            this.pocetak.Name = "pocetak";
            this.pocetak.Size = new System.Drawing.Size(75, 23);
            this.pocetak.TabIndex = 17;
            this.pocetak.Text = "Pocetak";
            this.pocetak.UseVisualStyleBackColor = true;
            this.pocetak.Click += new System.EventHandler(this.pocetak_Click);
            // 
            // kraj
            // 
            this.kraj.Location = new System.Drawing.Point(530, 178);
            this.kraj.Name = "kraj";
            this.kraj.Size = new System.Drawing.Size(75, 23);
            this.kraj.TabIndex = 18;
            this.kraj.Text = "Kraj";
            this.kraj.UseVisualStyleBackColor = true;
            this.kraj.Click += new System.EventHandler(this.kraj_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kraj);
            this.Controls.Add(this.pocetak);
            this.Controls.Add(this.prethodni);
            this.Controls.Add(this.sledeci);
            this.Controls.Add(this.brisi);
            this.Controls.Add(this.menjaj);
            this.Controls.Add(this.unesi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.poreklo);
            this.Controls.Add(this.original);
            this.Controls.Add(this.zanr);
            this.Controls.Add(this.trajanje);
            this.Controls.Add(this.naziv);
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id;
        private System.Windows.Forms.TextBox naziv;
        private System.Windows.Forms.TextBox trajanje;
        private System.Windows.Forms.TextBox zanr;
        private System.Windows.Forms.TextBox original;
        private System.Windows.Forms.TextBox poreklo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button unesi;
        private System.Windows.Forms.Button menjaj;
        private System.Windows.Forms.Button brisi;
        private System.Windows.Forms.Button sledeci;
        private System.Windows.Forms.Button prethodni;
        private System.Windows.Forms.Button pocetak;
        private System.Windows.Forms.Button kraj;
    }
}

