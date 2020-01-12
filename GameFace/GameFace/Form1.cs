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
    public partial class Form1 : Form
    {
        private GraphClient client;
        public Form1()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
            tbNewPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var query = new Neo4jClient.Cypher.CypherQuery("match (n:Korisnik {Username:'" + tbUsername.Text + "', Password:'" + tbPassword.Text + "'}) return n.Username",
                                                           new Dictionary<string, object>(), CypherResultMode.Set);
            List<string> users = ((IRawGraphClient)client).ExecuteGetCypherResults<string>(query).ToList();
            if (users.Count == 0)
            {
                MessageBox.Show("Ne postoji takav korisnik, molimo vas da unseste korisnicko ime i sifru ponovo");
                tbPassword.Clear();
                tbUsername.Clear();
            }
            else
            {
                Global.idKorisnika = users.First();
                Form2 f2 = new Form2(Global.idKorisnika);
                f2.Show();
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            var newUser = new Data.Korisnik { Username = tbNewUsername.Text, Password = tbNewPassword.Text, Ime = tbIme.Text, Prezime = tbPrezime.Text, Email = tbEmail.Text };
            client.Cypher
            .Create("(n:Korisnik {newUser})")
            .WithParam("newUser", newUser)
            .ExecuteWithoutResults();
            MessageBox.Show("Uspesno ste kreirali nalog! Ulogujte se!");
            tbNewPassword.Clear();
            tbNewUsername.Clear();
            tbIme.Clear();
            tbPrezime.Clear();
            tbEmail.Clear();
        }
    }
}
