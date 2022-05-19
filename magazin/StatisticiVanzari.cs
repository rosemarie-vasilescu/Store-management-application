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
    public partial class StatisticiVanzari : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private decimal totalVanzari;

        public StatisticiVanzari()
        {
            InitializeComponent();
        }

        private void StatisticiClienti_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StatisticiClienti' table. You can move, or remove it, as needed.
            this.statisticiClientiTableAdapter.Fill(this.dataSet1.StatisticiClienti);
            //Pregatire con si cmd
            con = statisticiClientiTableAdapter.Connection;
            cmd.Connection = con;
            //Total plati
            cmd.CommandText = "select sum(Cantitate) as Total from VanzariContinut";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            totalVanzari = rdr.GetDecimal(0);
            con.Close();
            rdr.Close();

            txtVanzari.Text = "" + totalVanzari;

            foreach (DataRow r in dataSet1.StatisticiClienti)
            {
                decimal x;
                x = (decimal)r["Total"] / totalVanzari;
                x = Math.Round(x, 4) * 100;
                x = Math.Round(x, 2);
                r["Procent"] = x;
            }
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
