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
    public partial class Furnizori : Form
    {
        const int IdFurnizorIndex = 0;
        const int DFurnizorIndex = 1;
        public Furnizori()
        {
            InitializeComponent();
        }
        private void config(bool v)
        {
            dataGridView1.AllowUserToAddRows = !v;
            dataGridView1.AllowUserToDeleteRows = !v;

            //Protectie coloane
           
            dataGridView1.Columns[DFurnizorIndex].ReadOnly = v;
            

            btnActualizare.Enabled = v;
            btnSalvare.Visible = !v;
            btnRenuntare.Visible = !v;
        }
        private void refresh()
        {
            furnizoriTableAdapter.Fill(dataSet1.Furnizori);
        }
        private bool completareCampuri()
        {
            bool raspuns = true;
            foreach (DataRow r in dataSet1.Furnizori)
            {
                if (r.RowState == DataRowState.Deleted) continue;

                if (r["DFurnizor"] == DBNull.Value)
                {
                    MessageBox.Show("Completati DFurnizor!");
                    raspuns = false;
                }
               


            }
            return raspuns;
        }
        private void Furnizori_Load(object sender, EventArgs e)
        {//A1
            config(true);
            refresh();
            dataGridView1.Columns[IdFurnizorIndex].ReadOnly = true;

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
                furnizoriTableAdapter.Update(dataSet1.Furnizori);
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

            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            int id = (int)dataGridView1.CurrentRow.Cells[0].Value;


            cmd.CommandText = "Select IdFurnizor From Achizitii where IdFurnizor=" + Convert.ToString(id);


            con.Open();

            r = cmd.ExecuteReader();

            if (r.Read())
            {
                MessageBox.Show("Furnizor referit in tabela Achizitii! Nu se poate sterge!");
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
