using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace magazin
{
    public partial class FStart : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;

        public FStart()
        {
            InitializeComponent();
        }
        private void A1(Boolean v)
        {
            menuStrip1.Visible = !v;
            lblTitlu.Visible = !v;
            lblAutor.Visible = !v;
            lblParola.Visible = v;
            txtParola.Visible = v;
            lblUtilizator.Visible = v;
            txtUtilizator.Visible = v;
            if (v) btnStart.Text = "Log In";
            else btnStart.Text = "Log Out";
        }

        private Boolean Logare_OK()
        {
            if (txtUtilizator.Text == "")
            {
                MessageBox.Show("Completati utilizator !");
                txtUtilizator.Focus();
                return false;
            }
            if (txtParola.Text == "")
            {
                MessageBox.Show("Completati parola !");
                txtParola.Focus();
                return false;
            }

            con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
                                   "Data Source=D:\\Facultate\\Anul 3\\MPP\\magazin.mdb";

            cmd.Connection = con;
            cmd.CommandText = "Select IdUtilizator,Parola from Utilizatori " +
                              "where Nume='" + txtUtilizator.Text + "'";
            con.Open();
            rdr = cmd.ExecuteReader();
            if (rdr.Read())
            {
                if (txtParola.Text != rdr.GetString(1))
                {
                    MessageBox.Show("Parola eronata");
                    txtParola.Focus();
                    con.Close();
                    return false;
                }
                con.Close();
                return true;
            }
            else
            {
                MessageBox.Show("Utilizator eronat");
                txtUtilizator.Focus();
                con.Close();
                return false;
            }
        }

        private void produsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produse f = new Produse();
            f.ShowDialog();
        }
  

        private void FStart_Load(object sender, EventArgs e)
        {
            A1(true);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (btnStart.Text == "Log In")
            {
                if (Logare_OK()) A1(false);
            }
            else A1(true);
        }

        private void clientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Client f = new Client();
            f.ShowDialog();
        }

        private void furnizorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Furnizori f = new Furnizori();
            f.ShowDialog();
        }

        private void achizitieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AchizitieContinut f = new AchizitieContinut();
            f.ShowDialog();
        }

        private void vanzareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VanzariContinut f = new VanzariContinut();
            f.ShowDialog();
        }

        private void arhivaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Arhiva f = new Arhiva();
            f.ShowDialog();
        }

        private void item_clienti_Click(object sender, EventArgs e)
        {
            StatisticiVanzari f = new StatisticiVanzari();
            f.ShowDialog();
        }

        private void item_vanzari_Click(object sender, EventArgs e)
        {

        }

        private void item_achizitii_Click(object sender, EventArgs e)
        {
            RaportIncasari f = new RaportIncasari();
            f.ShowDialog();
        }

        private void item_furnizori_Click(object sender, EventArgs e)
        {
            StatisticiAchizitii f = new StatisticiAchizitii();
            f.ShowDialog();
        }

        private void ietm_calcul_stoc_Click(object sender, EventArgs e)
        {
            CalculStoc f = new CalculStoc();
            f.ShowDialog();
        }

        private void item_balanta_stoc_Click(object sender, EventArgs e)
        {
            Balanta f = new Balanta();
            f.ShowDialog();
        }
    }
}
