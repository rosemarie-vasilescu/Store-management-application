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
    public partial class StatisticiAchizitii : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private decimal totalAchizitii;

        public StatisticiAchizitii()
        {
            InitializeComponent();
        }

        private void StatisticiFurnizori_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.StatisticiFurnizori' table. You can move, or remove it, as needed.
            this.statisticiFurnizoriTableAdapter.Fill(this.dataSet1.StatisticiFurnizori);
            //Pregatire con si cmd
            con = statisticiFurnizoriTableAdapter.Connection;
            cmd.Connection = con;
            //Total plati
            cmd.CommandText = "select sum(Cantitate) as Total from AchizitiiContinut";

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();
            totalAchizitii = rdr.GetDecimal(0);
            con.Close();
            rdr.Close();

            txtAchizitii.Text = "" + totalAchizitii;

            foreach (DataRow r in dataSet1.StatisticiFurnizori)
            {
                decimal x;
                x = (decimal)r["Total"] / totalAchizitii;
                x = Math.Round(x, 4) * 100;
                x = Math.Round(x, 2);
                r["Procent"] = x;
            }
        }

    }
    }

