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
    public partial class VanzariContinut : Form
    {
        public VanzariContinut()
        {
            InitializeComponent();
        }

        private void VanzariContinut_Load(object sender, EventArgs e)
        {
            refreshGrid(vanzareBindingSource.Position);
            try
            {
                vanzareContinutBindingSource.Filter = "IdVanzare=" + txtIdVanzare.Text;
            }
            catch { }
            //   filtreazaDetaliu();
            refreshGrid(vanzareBindingSource.Position);

        }
        private void refreshGrid(int p)
        {
            // TODO: This line of code loads data into the 'vanzari.VanzareContinut' table. You can move, or remove it, as needed.
            this.vanzareContinutTableAdapter.Fill(this.vanzari.VanzareContinut);
            // TODO: This line of code loads data into the 'vanzari.Vanzare' table. You can move, or remove it, as needed.
            this.vanzareTableAdapter.Fill(this.vanzari.Vanzare);
            vanzareBindingSource.Position = p;
        }
        private void filtreazaDetaliu()
        {
            try
            {
                vanzareContinutBindingSource.Filter = "IdVanzare=" + txtIdVanzare.Text;
            }
            catch { }
        }

        private void btnVanzareNoua_Click(object sender, EventArgs e)
        {
            Vanzare f = new Vanzare();
            f.completeazaTitlu("VANZARE NOUA");
            f.ShowDialog();
            refreshGrid(vanzareBindingSource.Position);
        }

        private void btnModificaVanzare_Click(object sender, EventArgs e)
        {
            Vanzare f = new Vanzare();
            f.completeazaTitlu("MODIFICARE VANZARE");
            f.bs1 = vanzareBindingSource;
            f.bs2 = vanzareContinutBindingSource;
            f.ShowDialog();
            refreshGrid(vanzareBindingSource.Position);
        }

        private void btnStergeVanzare_Click(object sender, EventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";

            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = vanzareTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

            // Sterg continut comanda
            cmd.CommandText = "Delete From VanzariContinut Where IdVanzare = " + txtIdVanzare.Text;

            // MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            // Sterg comanda
            cmd.CommandText = "Delete From Vanzari Where IdVanzare = " + txtIdVanzare.Text;
            // MessageBox.Show(cmd.CommandText);
            cmd.ExecuteNonQuery();

            con.Close();

            // Refresh grid-uri
            refreshGrid(vanzareBindingSource.Position);
            // filtreazaDetaliu();
            try
            {
                vanzareContinutBindingSource.Filter = "IdVanzare=" + txtIdVanzare.Text;
            }
            catch { }
        }

        private void vanzareBindingSource_PositionChanged(object sender, EventArgs e)
        {
            filtreazaDetaliu();
        }
    }
}
