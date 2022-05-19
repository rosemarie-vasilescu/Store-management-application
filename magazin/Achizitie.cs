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
    public partial class Achizitie : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private OleDbConnection con2 = new OleDbConnection();
        private OleDbCommand cmd2 = new OleDbCommand();
        private OleDbDataReader rdr2;
        private int idAchizitie;
        public BindingSource bs1;
        public BindingSource bs2;
        private int ok = 1;
        public Achizitie()
        {
            InitializeComponent();
        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void completeazaAchizitie()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idAchizitie = (int)current["IdAchizitie"];
            txtNrAchizitie.Text = Convert.ToString(current["NrAchizitie"]);

            cmbFurnizor.Text = current["DFurnizor"].ToString();
            txtTotal.Text = current["Total"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(current["DataAchizitie"]);
            // dtpCazare.Value = Convert.ToDateTime(current["DataCazarii"]);

            bs2.MoveFirst();

            achizitiiDS.achizitieContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                AchizitiiDS.achizitieContinutManevraRow r = achizitiiDS.achizitieContinutManevra.NewachizitieContinutManevraRow();

                r.NrCrt = Convert.ToInt16(current["Nrc"]);
                r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                r.DProdus = Convert.ToString(current["DProdus"]);
                r.UM = Convert.ToString(current["UM"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);
                r.PretVanzare = Convert.ToDecimal(current["PretVanzare"]);

                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);


                achizitiiDS.achizitieContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }
        private void A1()
        {
            //Incarcare DataTable Produse
            produseTableAdapter.Fill(achizitiiDS.Produse);
            //Incarcare DataTable Clienti
            furnizoriTableAdapter.Fill(achizitiiDS.Furnizori);

            // Protectie la modificare
            txtNrAchizitie.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            idProdusDataGridViewTextBoxColumn.ReadOnly = true;



            if (lblOp.Text == "MODIFICARE ACHIZITIE") completeazaAchizitie();
            else if (lblOp.Text == "ACHIZITIE NOUA") cmbFurnizor.SelectedIndex = -1;
            //completeazaRezervare();
            //cmbClient.SelectedIndex = -1;
        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE ACHIZITIE")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariAchizitiiContinut();
                this.Close();
            }
            else if (lblOp.Text == "ACHIZITIE NOUA")
            {
                generez_nr_achizitie();
                adaugaInregistrareAchizitii();
                cautaInregistrare();
                adaugaInregistrariAchizitiiContinut();
                golireCampuri();
            }
        }
        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)achizitieContinutManevraBindingSource.Current;
            try { current["NrCrt"] = achizitieContinutManevraBindingSource.Position + 1; }
            catch { }
        }
        private void A4()
        {
            try
            {


                if (dataGridView1.CurrentCell != null)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 1)
                    {
                        DataRowView current = (DataRowView)produseBindingSource.Current;
                        dataGridView1.CurrentRow.Cells[2].Value = current["UM"];
                        dataGridView1.CurrentRow.Cells[3].Value = current["Pret"];
                        dataGridView1.CurrentRow.Cells[6].Value = current["IdProdus"];

                        //dataGridView1.CurrentRow.Cells[9].Value = current["SplImagine"];
                        calcTotal();
                    }
                    if (dataGridView1.CurrentCell.ColumnIndex == 4)
                    {
                        achizitieContinutManevraBindingSource.EndEdit();
                        calcTotal();
                    }
                }
            }
            catch { }

        }
        private void A5(DataGridViewRowCancelEventArgs e)
        {
            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            var rezultat = MessageBox.Show(mesaj, titlu,
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) e.Cancel = true;
        }
        private void Achizitie_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'achizitiiDS.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.achizitiiDS.Produse);
            // TODO: This line of code loads data into the 'achizitiiDS.Furnizori' table. You can move, or remove it, as needed.
            this.furnizoriTableAdapter.Fill(this.achizitiiDS.Furnizori);
            con2.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd2.Connection = con2;
            A1();
        }
        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in achizitiiDS.achizitieContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }
        private void generez_nr_achizitie()
        {
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Achizitii.NrAchizitie) AS NrMax FROM Achizitii";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            txtNrAchizitie.Text = rdr.IsDBNull(0) ? "1" : Convert.ToString(rdr.GetInt32(0) + 1); ;

            rdr.Close();
            con.Close();
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbFurnizor.Text == "")
            {
                MessageBox.Show("Completati Furnizor !");
                cmbFurnizor.Focus();
                return false;
            }
            // Validare completare continut
            if (achizitieContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut achizitie !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }
        private void adaugaInregistrareAchizitii()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "NrAchizitie, DataAchizitie, IdFurnizor";
            listaValori = "'" + txtNrAchizitie.Text +
                          "',#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + cmbFurnizor.SelectedValue;

            cmd.CommandText = "Insert into Achizitii(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void cautaInregistrare()
        {
            DateTime d = dateTimePicker1.Value;
            cmd.CommandText = "SELECT IdAchizitie From Achizitii Where NrAchizitie = " + txtNrAchizitie.Text;
            // cmd.CommandText = "SELECT IdRezervare From Rezervari Where DataRezervarii = " + "#" + Convert.ToString(d.Month) + "/"
            //                    + Convert.ToString(d.Day) + "/"
            //                    + Convert.ToString(d.Year) + "#" + " AND IdClient= " +cmbClient.SelectedValue;
            // MessageBox.Show(cmd.CommandText);

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idAchizitie = rdr.GetInt32(0);
            // MessageBox.Show(Convert.ToString(idRez));
            rdr.Close();
            con.Close();
        }
        private void adaugaInregistrariAchizitiiContinut()
        {
            string listaCampuri = "IdAchizitie, Nrc, IdProdus, Cantitate, PretAchizitie";
            string listaValori;
            // DateTime d = dtpCazare.Value;
            //  DateTime d2 = (DateTime)dataGridView1.CurrentRow.Cells[8].Value;

            con.Open();
            foreach (DataRow r in achizitiiDS.achizitieContinutManevra)
            {

                listaValori = idAchizitie + ","
                    + r["NrCrt"] + ","
                    + r["IdProdus"] + ","
                    + r["Cantitate"] + ","
                    + r["PretVanzare"];

                cmd.CommandText = "Insert into AchizitiiContinut(" + listaCampuri + ") " + "Select " + listaValori;

                // MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrAchizitie.Text = "";
            txtTotal.Text = "";
            cmbFurnizor.SelectedIndex = -1;
            achizitiiDS.achizitieContinutManevra.Clear();
        }
        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            // DateTime d2 = (DateTime)dataGridView1.CurrentRow.Cells[8].Value;
            con.ConnectionString = furnizoriTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdAchizitie = " + idAchizitie;

            string clauzaSet = "Set DataAchizitie = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdFurnizor = '" + cmbFurnizor.SelectedValue + "'";
            
            cmd.CommandText = "Update Achizitii " + clauzaSet + clauzaWhere;
            MessageBox.Show(cmd.CommandText);
            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void stergeContinut()
        {
            cmd.CommandText = "Delete from AchizitiiContinut Where IdAchizitie = " + idAchizitie;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int currRowIndex = e.RowIndex;

            if (e.ColumnIndex == 0)
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    if (dataGridView1.Rows[row].Cells[1].Value != null && dataGridView1.Rows[row].Cells[1].Value.Equals(dataGridView1.Rows[currRowIndex].Cells[1].Value) && row != currRowIndex)
                    {
                        MessageBox.Show("Comanda exista deja!\n linia " + row + "= linia " + currRowIndex);

                        //MessageBox.Show("linia" + currRowIndex);
                        //dataGridView1.CurrentCell = dataGridView1.Rows[currRowIndex].Cells[1];
                        ok = 0;
                        dataGridView1.Rows[currRowIndex].Cells[0].Tag = -1;
                        dataGridView1.Rows.RemoveAt(currRowIndex);

                        break;
                    }
                    else ok = 1;


                }

            if (ok == 1)
                A4();
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            A5(e);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Format eronat");
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            calcTotal();
        }

        private void achizitieContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            bool completatCantitatea = true;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Cells[4].Value != null && dataGridView1.Rows[row].Cells[4].Value.ToString() == "")
                {
                    if (dataGridView1.Rows[row].Cells[1].Value != null)
                    {
                        MessageBox.Show("Nu ati completat cantitatea pt linia " + row);
                        completatCantitatea = false;
                        break;
                    }
                }
            }
            if (completatCantitatea == true)
                A2();
        }
    }
}
