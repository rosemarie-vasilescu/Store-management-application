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
    public partial class AchizitieContinut : Form
    {
        public AchizitieContinut()
        {
            InitializeComponent();
        }

        private void AchizitieContinut_Load(object sender, EventArgs e)
        {
            refreshGrid(achizitiiBindingSource.Position);
            try
            {
                achizitieContinutBindingSource.Filter = "IdAchizitie=" + txtIdAchizitie.Text;
            }
            catch { }
            //   filtreazaDetaliu();
            refreshGrid(achizitiiBindingSource.Position);

        }
        private void refreshGrid(int p)
        {
            // TODO: This line of code loads data into the 'vanzari.VanzareContinut' table. You can move, or remove it, as needed.
            this.achizitieContinutTableAdapter.Fill(this.achizitiiDS.AchizitieContinut);
            // TODO: This line of code loads data into the 'vanzari.Vanzare' table. You can move, or remove it, as needed.
            this.achizitiiTableAdapter.Fill(this.achizitiiDS.Achizitii);
            achizitiiBindingSource.Position = p;
        }
        private void filtreazaDetaliu()
        {
            try
            {
                achizitieContinutBindingSource.Filter = "IdAchizitie=" + txtIdAchizitie.Text;
            }
            catch { }
        }

        private void btnAchizitieNoua_Click(object sender, EventArgs e)
        {
            Achizitie f = new Achizitie();
            f.completeazaTitlu("ACHIZITIE NOUA");
            f.ShowDialog();
            refreshGrid(achizitiiBindingSource.Position);
        }

        private void btnModificaAchizitie_Click(object sender, EventArgs e)
        {
            Achizitie f = new Achizitie();
            f.completeazaTitlu("MODIFICARE ACHIZITIE");
            f.bs1 = achizitiiBindingSource;
            f.bs2 = achizitieContinutBindingSource;
            f.ShowDialog();
            refreshGrid(achizitiiBindingSource.Position);
        }

        private void btnStergeAchizitie_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = achizitiiTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From AchizitiiContinut Where IdAchizitie = " + txtIdAchizitie.Text;

            // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Achizitii Where IdAchizitie = " + txtIdAchizitie.Text;
            // MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid(achizitiiBindingSource.Position);
            // filtreazaDetaliu();
            try
            {
                achizitieContinutBindingSource.Filter = "IdAchizitie=" + txtIdAchizitie.Text;
            }
            catch { }
        }

        private void achizitiiBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }
    }
}
