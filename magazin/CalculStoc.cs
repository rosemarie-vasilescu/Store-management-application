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
    public partial class CalculStoc : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();

        private OleDbConnection con2 = new OleDbConnection();
        private OleDbCommand cmd2 = new OleDbCommand();
        private OleDbDataReader rdr2;
        public CalculStoc()
        {
            InitializeComponent();
        }

        private void CalculStoc_Load(object sender, EventArgs e)
        {
            //Configurez obiectele conexiune si comanda
            con.ConnectionString = calculStocTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            con2.ConnectionString = calculStocTableAdapter.Connection.ConnectionString;
            cmd2.Connection = con2;

            //Sterg continut tabele CalculStoc si Stoc
            con.Open();
            cmd.CommandText = "Delete * from CalculStoc";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "Delete * from StocProduse";
            cmd.ExecuteNonQuery();
            con.Close();
            this.calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
            this.stocProduseTableAdapter.Fill(this.calculStocDS.StocProduse);

            filtrare();
        }

        private void btnStocInitial_Click(object sender, EventArgs e)
        {
            // Stoc Initial
            con.Open();
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                              "SELECT 1, Data, IdProdus, Cantitate " +
                              "FROM StocInitial";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculStoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
        }
        private void stocInitial()
        {
            // Stoc Initial
            con.Open();
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                              "SELECT 1, Data, IdProdus, Cantitate " +
                              "FROM StocInitial";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculStoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
        }
        private void btnAchizitii_Click(object sender, EventArgs e)
        {
            // Intrari
            con.Open();
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                              "SELECT 2, Achizitii.DataAchizitie, AchizitiiContinut.IdProdus, AchizitiiContinut.Cantitate " +
                              "FROM Achizitii INNER JOIN AchizitiiContinut ON Achizitii.IdAchizitie = AchizitiiContinut.IdAchizitie";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculStoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
        }
        private void achizitii()
        {
            // Intrari
            con.Open();
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                              "SELECT 2, Achizitii.DataAchizitie, AchizitiiContinut.IdProdus, AchizitiiContinut.Cantitate " +
                              "FROM Achizitii INNER JOIN AchizitiiContinut ON Achizitii.IdAchizitie = AchizitiiContinut.IdAchizitie";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            con.Close();
            //Incarc dataTable-ul CalculStoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
        }
        private void btnVanzari_Click(object sender, EventArgs e)
        {
            // Iesiri
            con.Open();
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                              "SELECT 3, Vanzari.DataVanzare, VanzariContinut.IdProdus, -VanzariContinut.Cantitate " +
                              "FROM (Vanzari INNER JOIN VanzariContinut ON Vanzari.IdVanzare = VanzariContinut.IdVanzare) INNER JOIN Clienti ON Vanzari.IdClient=Clienti.IdClient ";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            con.Close();

      

            //Incarc dataTable-ul CalculStoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
        }
        private void vanzari()
        {
            // Iesiri
            con.Open();
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                              "SELECT 3, Vanzari.DataVanzare, VanzariContinut.IdProdus, -VanzariContinut.Cantitate " +
                              "FROM (Vanzari INNER JOIN VanzariContinut ON Vanzari.IdVanzare = VanzariContinut.IdVanzare) INNER JOIN Clienti ON Vanzari.IdClient=Clienti.IdClient ";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

            con.Close();



            //Incarc dataTable-ul CalculStoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
        }
        private void btnStocFinal_Click(object sender, EventArgs e)
        {
            con.Open();
            // Calculez totaluri pe Cantitate si grupez pe IdProdus
            // inserez rezultatul in tabela Stoc
            cmd.CommandText = "INSERT INTO StocProduse ( IdProdus, Cantitate ) " +
                              "SELECT IdProdus, Sum(Cantitate) " +
                              "FROM CalculStoc GROUP BY IdProdus";
            cmd.ExecuteNonQuery();
            //Stoc final
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, IdProdus, Cantitate, Data ) " +
                              "SELECT 4, IdProdus, Sum(Cantitate) , now()" +
                              "FROM CalculStoc GROUP BY IdProdus";
            cmd.ExecuteNonQuery();
            con.Close();
            //Incarc dataTable-ul CalculStoc si Stoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
            calculStocDS.StocProduse.Clear();
            stocProduseTableAdapter.Fill(this.calculStocDS.StocProduse);
        }
        private void stocFinal()
        {
            con.Open();
            // Calculez totaluri pe Cantitate si grupez pe IdProdus
            // inserez rezultatul in tabela Stoc
            cmd.CommandText = "INSERT INTO StocProduse ( IdProdus, Cantitate ) " +
                              "SELECT IdProdus, Sum(Cantitate) " +
                              "FROM CalculStoc GROUP BY IdProdus";
            cmd.ExecuteNonQuery();
            //Stoc final
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, IdProdus, Cantitate, Data ) " +
                              "SELECT 4, IdProdus, Sum(Cantitate) , now()" +
                              "FROM CalculStoc GROUP BY IdProdus";
            cmd.ExecuteNonQuery();
            con.Close();
            //Incarc dataTable-ul CalculStoc si Stoc
            calculStocDS.CalculStoc.Clear();
            calculStocTableAdapter.Fill(this.calculStocDS.CalculStoc);
            calculStocDS.StocProduse.Clear();
            stocProduseTableAdapter.Fill(this.calculStocDS.StocProduse);
        }
        private void filtrare()
        {
            try { calculStocBindingSource.Filter = "IdProdus=" + txtFiltru.Text; }
            catch { }
        }

        private void stocProduseBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            filtrare();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            filtrare();
        }

        private void txtFiltru_TextChanged(object sender, EventArgs e)
        {
            filtrare();
        }
    }
}
