using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameFace.Data;
using Neo4jClient;
using Neo4jClient.Cypher;

namespace GameFace
{
    public partial class Form2 : Form
    {
        private GraphClient client;
        public Form2(string id)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "12345");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            InitializeComponent();
            Global.idKorisnika = id;
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Zanr) return n.Naziv",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<string> zanrovi = ((IRawGraphClient)client).ExecuteGetCypherResults<string>(query).ToList();
            foreach(string z in zanrovi)
            {
                comboBox1.Items.Add(z);
            }
            for(int i=1; i<11; i++)
            {
                cbOcena.Items.Add(i);
            }
        }


        private void btnZanrPrikazi_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Zanr {Naziv:'" + comboBox1.SelectedItem + "'})<-[r:Pripada]-(b:Igrica) return b",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<Igrica> igrice = ((IRawGraphClient)client).ExecuteGetCypherResults<Igrica>(query).ToList();
            Table table = new Table();
            DataRow row;
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Naziv";
            table.nazivi.Columns.Add(column);
            foreach (Igrica i in igrice)
            {
                row = table.nazivi.NewRow();
                row["Naziv"] = i.Naziv;
                table.nazivi.Rows.Add(row);
            }
            dataGridView1.DataSource = table.nazivi;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            client = new GraphClient(new Uri("http://localhost:7474/db/data"), "neo4j", "12345");
            try
            {
                client.Connect();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
        public static class Global
        {
            public static string idKorisnika;
        }
        public class Table
        {
            public DataTable nazivi;

            public Table()
            {
                nazivi = new DataTable("Igrice");
            }
        }

        private void btnOceni_Click(object sender, EventArgs e)
        {
            client.Cypher
            .Match("(a:Korisnik {Username:'" + Global.idKorisnika + "'}), (b:Igrica {Naziv:'" + tbNazivIgrice.Text + "'})")
            .Merge("(a)-[r:Ocenjuje {Ocena:'" + cbOcena.SelectedItem + "'}]->(b)")
            .ExecuteWithoutResults();
            MessageBox.Show("Uspesno ste ocenili igricu");
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKomentarisi_Click(object sender, EventArgs e)
        {
            client.Cypher
            .Match("(a:Korisnik {Username:'" + Global.idKorisnika + "'}), (b:Igrica {Naziv:'" + tbNazivIgrice.Text + "'})")
            .Merge("(a)-[r:Komentarise {Komentar:'" + tbKomentar.Text + "'}]->(b)")
            .ExecuteWithoutResults();
            MessageBox.Show("Uspesno ste ostavili komentar");
        }

        private void btnPrikaziIgricu_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Igrica {Naziv:'" + tbNazivIgrice.Text + "'}) return n",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<Igrica> igrice1 = ((IRawGraphClient)client).ExecuteGetCypherResults<Igrica>(query).ToList();
            if (igrice1.Count == 0)
            {
                MessageBox.Show("Ne postoji takva igrica");
                tbNazivIgrice.Clear();
            }
            else
            {
                query = new Neo4jClient.Cypher.CypherQuery("match (n:Igrica {Naziv:'" + tbNazivIgrice.Text + "'})<-[r:Ocenjuje]-(b:Korisnik) return r",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);
                List<ROcena> ocene = ((IRawGraphClient)client).ExecuteGetCypherResults<ROcena>(query).ToList();
                double prosecnaOcena = 0;
                foreach (ROcena o in ocene)
                {
                    prosecnaOcena += Convert.ToDouble(o.Ocena);
                }
                if (ocene.Count > 1)
                {
                    prosecnaOcena = prosecnaOcena / ocene.Count;
                }
                prosecnaOcena = Math.Round(prosecnaOcena, 2);
                query = new Neo4jClient.Cypher.CypherQuery("match (n:Igrica {Naziv:'" + tbNazivIgrice.Text + "'})-[r:Pripada]->(b:Zanr) return b",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);
                List<Zanr> zanrovi = ((IRawGraphClient)client).ExecuteGetCypherResults<Zanr>(query).ToList();
                string zanr = zanrovi.First().Naziv;
                query = new Neo4jClient.Cypher.CypherQuery("match (n:Igrica {Naziv:'" + tbNazivIgrice.Text + "'}) return n",
                                                               new Dictionary<string, object>(), CypherResultMode.Set);
                List<Igrica> igrice = ((IRawGraphClient)client).ExecuteGetCypherResults<Igrica>(query).ToList();
                string link = igrice.First().Link;
                string opis = igrice.First().Opis;
                Form3 f3 = new Form3(tbNazivIgrice.Text, prosecnaOcena, zanr, link, opis);
                f3.Show();
                client.Cypher
                .Match("(n:Igrica {Naziv:'" + tbNazivIgrice.Text + "'})")
                .Set("n.Ocena = '" + prosecnaOcena.ToString() + "'")
                .ExecuteWithoutResults();
            }
        }
    }
}
