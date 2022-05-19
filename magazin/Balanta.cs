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
using System.Data;


namespace magazin
{
    public partial class Balanta : Form
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();

        public Balanta()
        {
            InitializeComponent();
        }

        private void Balanta_Load(object sender, EventArgs e)
        {
            con.ConnectionString = balantaStocTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con.Open();
            //Sterg continut tabela BalantaStoc
            cmd.CommandText = "Delete * from BalantaStoc";
            cmd.ExecuteNonQuery();
            con.Close();
            //Calcul stoc
            Calcule.calculStoc(balantaStocTableAdapter.Connection.ConnectionString);
            calculStocTableAdapter.Fill(balDS.CalculStoc);
            stocFinal();
            stocInitial();
            intrari();
            iesiri();


        }

        private void btnStocInitial_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "UPDATE BalantaStoc LEFT JOIN StocInitial ON BalantaStoc.IdProdus = StocInitial.IdProdus " +
                              "SET BalantaStoc.StocInitial = StocInitial.Cantitate";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaStocTableAdapter.Fill(balDS.BalantaStoc);

        }
        private void stocInitial()
        {
            con.Open();
            cmd.CommandText = "UPDATE BalantaStoc LEFT JOIN StocInitial ON BalantaStoc.IdProdus = StocInitial.IdProdus " +
                              "SET BalantaStoc.StocInitial = StocInitial.Cantitate";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaStocTableAdapter.Fill(balDS.BalantaStoc);
        }
        private void btnStocFinal_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd.CommandText = "INSERT INTO BalantaStoc ( IdProdus, StocFinal )" +
                            " SELECT IdProdus, Cantitate FROM CalculStoc Where IdOperatie=4";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaStocTableAdapter.Fill(balDS.BalantaStoc);

        }
        private void stocFinal()
        {
            con.Open();
            cmd.CommandText = "INSERT INTO BalantaStoc ( IdProdus, StocFinal )" +
                            " SELECT IdProdus, Cantitate FROM CalculStoc Where IdOperatie=4";
            cmd.ExecuteNonQuery();
            con.Close();
            //Afisez balanta
            balantaStocTableAdapter.Fill(balDS.BalantaStoc);
        }

        private void btnIntrari_Click(object sender, EventArgs e)
        {
            BalDSTableAdapters.IntrariTableAdapter ta = new BalDSTableAdapters.IntrariTableAdapter();
            ta.Fill(balDS.Intrari);

            DataRelation balIntrari = balDS.Relations.Add(balDS.BalantaStoc.Columns["IdProdus"], balDS.Intrari.Columns["IdProdus"]);

            foreach (DataRow rb in balDS.BalantaStoc)
            {
                foreach (DataRow ri in rb.GetChildRows(balIntrari))
                {
                    rb["Intrari"] = ri["Total"];
                }
            }

        }
        private void intrari()
        {
            BalDSTableAdapters.IntrariTableAdapter ta = new BalDSTableAdapters.IntrariTableAdapter();
            ta.Fill(balDS.Intrari);

            DataRelation balIntrari = balDS.Relations.Add(balDS.BalantaStoc.Columns["IdProdus"], balDS.Intrari.Columns["IdProdus"]);

            foreach (DataRow rb in balDS.BalantaStoc)
            {
                foreach (DataRow ri in rb.GetChildRows(balIntrari))
                {
                    rb["Intrari"] = ri["Total"];
                }
            }
        }
        private void btnIesiri_Click(object sender, EventArgs e)
        {
            BalDSTableAdapters.IesiriTableAdapter ta = new BalDSTableAdapters.IesiriTableAdapter();
            ta.Fill(balDS.Iesiri);

            DataRelation balIesiri = balDS.Relations.Add(balDS.BalantaStoc.Columns["IdProdus"], balDS.Iesiri.Columns["IdProdus"]);

            foreach (DataRow rb in balDS.BalantaStoc)
            {
                foreach (DataRow ri in rb.GetChildRows(balIesiri))
                {
                    rb["Iesiri"] = ri["Total"];
                }
            }

        }
        private void iesiri()
        {
            BalDSTableAdapters.IesiriTableAdapter ta = new BalDSTableAdapters.IesiriTableAdapter();
            ta.Fill(balDS.Iesiri);

            DataRelation balIesiri = balDS.Relations.Add(balDS.BalantaStoc.Columns["IdProdus"], balDS.Iesiri.Columns["IdProdus"]);

            foreach (DataRow rb in balDS.BalantaStoc)
            {
                foreach (DataRow ri in rb.GetChildRows(balIesiri))
                {
                    rb["Iesiri"] = ri["Total"];
                }
            }
        }
    }
}
