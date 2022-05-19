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
    public partial class Produse : Form
    {
        const int IdProdusIndex = 0;
        const int DProdusIndex = 1;
        const int UMIndex = 2;
        const int PretIndex = 3;
        public Produse()
        {
            InitializeComponent();
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
            dataGridView1.Columns[DProdusIndex].ReadOnly = v;
            dataGridView1.Columns[UMIndex].ReadOnly = v;
            dataGridView1.Columns[PretIndex].ReadOnly = v;

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            produseTableAdapter.Fill(dataSet1.Produse);
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Produse)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DProdus"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DProdus!");
                    raspuns = false;
                }
                if (r["UM"] == DBNull.Value)
                {
                    MessageBox.Show("Completati UM!");
                    raspuns = false;
                }
                if (r["Pret"] == DBNull.Value)
                {
                    MessageBox.Show("Completati Pret");
                    raspuns = false;
                }
                


            }
            return raspuns;
        }
        private void Produse_Load(object sender, EventArgs e)
        {
            ///A1
            config(true);
            refresh();
            dataGridView1.Columns[IdProdusIndex].ReadOnly = true;

        }

        private void btnActualizare_Click(object sender, EventArgs e)
        {
            //A2
            config(false);
        }

        private void btnSalvare_Click(object sender, EventArgs e)
        {
            if (!completareCampuri()) return;
            try
            {
                produseTableAdapter.Update(dataSet1.Produse);
                config(true);
                refresh();
            }
            catch (Exception exc)
            {
                string s = exc.Message;

                if (s.IndexOf("duplicate values") > 0)
                    MessageBox.Show("Inregistrare deja existenta !");
                else if (s.IndexOf("cannot be deleted") > 0)
                    MessageBox.Show("Ati sters inregistrari referite in alte tabele !");
            }
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            //A3
            config(true);
            refresh();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            if (btnRenuntare.Focused)
            {
                dataGridView1.CancelEdit();
                //A3
                config(true);
                refresh();

                return;
            }
            MessageBox.Show("Format eronat");

        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;


            cmd.CommandText = "Select IdProdus From VanzariContinut where IdProdus=" + Convert.ToString(id);


            con.Open();

            r = cmd.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("Produs referita in tabela VanzariContinut! Nu se poate sterge!");
                e.Cancel = true;
                con.Close();
                return;
            }
            con.Close();
            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            id = (int)dataGridView1.CurrentRow.Cells[0].Value;


            cmd.CommandText = "Select IdProdus From AchizitiiContinut where IdProdus=" + Convert.ToString(id);


            con.Open();

            r = cmd.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("Produs referita in tabela AchizitiiContinut! Nu se poate sterge!");
                e.Cancel = true;
                con.Close();
                return;
            }
            con.Close();

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;

        }
    }
}
