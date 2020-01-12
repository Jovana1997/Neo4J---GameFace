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
    public partial class Form3 : Form
    {
        private GraphClient client;
        public Form3(string naziv, double ocena, string zanr, string link, string opis)
        {
            InitializeComponent();
            Global.naziv = naziv;
            labelIgrica.Text += ":  " + naziv;
            labelOcena.Text += ":  " + ocena;
            labelZanr.Text += ":  " + zanr;
            labelLink.Text += ":  " + link;
            rtbOpis.Text = opis;
        }


        private void btnPrikaziKom_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Igrica {Naziv:'" + Global.naziv + "'})<-[r:Komentarise]-(b:Korisnik) return r",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<RKomentar> komentari = ((IRawGraphClient)client).ExecuteGetCypherResults<RKomentar>(query).ToList();
            
            Table table = new Table();
            DataRow row;
            DataColumn column = new DataColumn();
            column.DataType = System.Type.GetType("System.String");
            column.ColumnName = "Komentar";
            table.komentari.Columns.Add(column);
            DataColumn column1 = new DataColumn();
            column1.DataType = System.Type.GetType("System.String");
            column1.ColumnName = "Username";
            table.komentari.Columns.Add(column1);
            foreach (RKomentar k in komentari)
            {
                row = table.komentari.NewRow();
                row["Komentar"] = k.Komentar;
                //table.komentari.Rows.Add(row);
                query = new Neo4jClient.Cypher.CypherQuery("match (n:Igrica {Naziv:'" + Global.naziv + "'})<-[r:Komentarise {Komentar:'" + k.Komentar + "'}]-(b:Korisnik) return b",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
                List<Korisnik> korisnici = ((IRawGraphClient)client).ExecuteGetCypherResults<Korisnik>(query).ToList();
                row["Username"] = korisnici.First().Username;
                table.komentari.Rows.Add(row);
            }
            dataGridView1.DataSource = table.komentari;
        }

        private void Form3_Load(object sender, EventArgs e)
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
            public static string naziv;
        }
        public class Table
        {
            public DataTable komentari;

            public Table()
            {
                komentari = new DataTable("Komentari");
            }
        }
    }
}
