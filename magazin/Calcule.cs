using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Windows.Forms;
using System.Data.OleDb;

namespace magazin
{
    class Calcule
    {
        private static OleDbConnection con = new OleDbConnection();
        private static OleDbCommand cmd = new OleDbCommand();
        public static void calculStoc(string cs)
        {
            con.ConnectionString = cs;
            cmd.Connection = con;
            con.Open();
            //Sterg continut tabele CalculStoc
            cmd.CommandText = "Delete * from CalculStoc";
            cmd.ExecuteNonQuery();

            stocInitial(); intrari(); iesiri();stocFinal();
            con.Close();
        }
        private static void stocInitial()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdProdus, Cantitate) " +
                              "Select 1,Data, IdProdus, Cantitate " +
                              "From StocInitial";

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void intrari()
        {
            cmd.CommandText = "Insert into CalculStoc(IdOperatie, Data, IdProdus, Cantitate) " +
                              "Select 2,Achizitii.DataAchizitie, AchizitiiContinut.IdProdus, AchizitiiContinut.Cantitate " +
                              "From Achizitii INNER JOIN AchizitiiContinut ON Achizitii.IdAchizitie = AchizitiiContinut.IdAchizitie";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void iesiri()
        {

            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                              "SELECT 3, Vanzari.DataVanzare, VanzariContinut.IdProdus, -VanzariContinut.Cantitate " +
                              "FROM (Vanzari INNER JOIN VanzariContinut ON Vanzari.IdVanzare = VanzariContinut.IdVanzare) INNER JOIN Clienti ON Vanzari.IdClient=Clienti.IdClient ";
                              
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private static void stocFinal()
        {

            // Calculez totaluri pe Cantitate si grupez pe IdProdus 
            cmd.CommandText = "INSERT INTO CalculStoc ( IdOperatie, Data, IdProdus, Cantitate ) " +
                  "SELECT 4,now(), IdProdus, Sum(Cantitate) " +
                  "FROM CalculStoc GROUP BY IdProdus";
            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
