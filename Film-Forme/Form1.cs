using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Film_Forme
{
    public partial class Form1 : Form
    {
        string cs = "Data source= ubaci si datasource; Initial catalog=Film; Integrated security=true";
        DataTable podaci = new DataTable();
        int trenutni = 0;
        private void osvezi(int tren)
        {
            id.Text = podaci.Rows[tren]["id"].ToString();
            naziv.Text = podaci.Rows[tren]["naziv"].ToString();
            trajanje.Text = podaci.Rows[tren]["trajanje"].ToString();
            zanr.Text = podaci.Rows[tren]["zanr"].ToString();
            original.Text = podaci.Rows[tren]["originalniNaziv"].ToString();
            poreklo.Text = podaci.Rows[tren]["zemljaPorekla"].ToString();
        }
        private void uvezi()
        {
            SqlConnection veza = new SqlConnection(cs);
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * from podaciFilm", veza);
            adapter.Fill(podaci);
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void unesi_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            string funkcija = $"INSERT INTO podaciFilm values({naziv.Text}, {trajanje.Text}, {zanr.Text}, {original.Text}, {poreklo.Text},{id.Text})";
            SqlCommand menjanje = new SqlCommand(funkcija, veza);
            veza.Open();
            menjanje.ExecuteNonQuery();
            veza.Close();
            uvezi();
            MessageBox.Show("Uneto!");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            uvezi();
        }

        private void pocetak_Click(object sender, EventArgs e)
        {
            trenutni = 0;
            osvezi(trenutni);
        }

        private void kraj_Click(object sender, EventArgs e)
        {
            trenutni = podaci.Rows.Count - 1;
            osvezi(trenutni);
        }

        private void sledeci_Click(object sender, EventArgs e)
        {
            if (trenutni < podaci.Rows.Count)
            {
                trenutni++;
             }
            else
            {
                trenutni = 0;
                MessageBox.Show("Listanje je kruzno, sledbenik poslednjeg elementa je prvi");
            }
            osvezi(trenutni);

        }

        private void prethodni_Click(object sender, EventArgs e)
        {
            if (trenutni > 0)
            {
                trenutni--;
            }
            else
            {
                trenutni = podaci.Rows.Count - 1;
                MessageBox.Show("Listanje je kruzno, prethodnik prvog elementa je poslednji");
            }
            osvezi(trenutni);
        }

        private void brisi_Click(object sender, EventArgs e)
        {
                SqlConnection veza = new SqlConnection(cs);
                SqlCommand brisanje = new SqlCommand("DELETE FROM podaciFilm WHERE id=" + id.Text, veza);
                veza.Open();
                brisanje.ExecuteNonQuery();
                veza.Close();
                uvezi();
                podaci.Clear();
                if (trenutni >= podaci.Rows.Count)             
                    trenutni = podaci.Rows.Count - 1;   
                else osvezi(trenutni);
                MessageBox.Show("Obrisano!");
        }

        private void menjaj_Click(object sender, EventArgs e)
        {
            SqlConnection veza = new SqlConnection(cs);
            string funkcija = $"UPDATE podaciFilm SET naziv={naziv.Text}, trajanje={trajanje.Text}, zanr={zanr.Text}, nazivOriginala={original.Text}, zemljaPorekla={poreklo.Text} WHERE id={id.Text}";
            SqlCommand menjanje = new SqlCommand(funkcija, veza);
            veza.Open();
            menjanje.ExecuteNonQuery();
            veza.Close();
            uvezi();
            MessageBox.Show("Promenjeno!");
        }
    }
}
