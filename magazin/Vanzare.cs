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
    public partial class Vanzare : Form
    {
        private OleDbConnection con = new OleDbConnection();
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader rdr;
        private OleDbConnection con2 = new OleDbConnection();
        private OleDbCommand cmd2 = new OleDbCommand();
        private OleDbDataReader rdr2;
        private int idVanzare;
        public BindingSource bs1;
        public BindingSource bs2;
        private int ok = 1;
        public Vanzare()
        {
            InitializeComponent();
        }
        public void completeazaTitlu(String titlu)
        {
            lblOp.Text = titlu;
        }
        private void completeazaVanzare()
        {
            DataRowView current = (DataRowView)bs1.Current;

            idVanzare = (int)current["IdVanzare"];
            txtNrVanzare.Text = Convert.ToString(current["NrVanzare"]);

            cmbClient.Text = current["DClient"].ToString();
            txtTotal.Text = current["Total"].ToString();
            dateTimePicker1.Value = Convert.ToDateTime(current["DataVanzare"]);
            // dtpCazare.Value = Convert.ToDateTime(current["DataCazarii"]);

            bs2.MoveFirst();

            vanzari.vanzareContinutManevra.Clear();


            for (int i = 1; i <= bs2.Count; i++)
            {
                current = (DataRowView)bs2.Current;

                Vanzari.vanzareContinutManevraRow r = vanzari.vanzareContinutManevra.NewvanzareContinutManevraRow();

                r.NrCrt = Convert.ToInt16(current["NrCrt"]);
                r.IdProdus = Convert.ToInt32(current["IdProdus"]);
                r.DProdus = Convert.ToString(current["DProdus"]);
                r.UM = Convert.ToString(current["UM"]);
                r.Valoare = Convert.ToDecimal(current["Valoare"]);
                r.PretVanzare = Convert.ToDecimal(current["PretVanzare"]);
               
                r.Cantitate = Convert.ToDecimal(current["Cantitate"]);
                

                vanzari.vanzareContinutManevra.Rows.Add(r);
                bs2.MoveNext();
            }
        }
        private void A1()
        {
            //Incarcare DataTable Produse
            produseTableAdapter.Fill(vanzari.Produse);
            //Incarcare DataTable Clienti
            clientiTableAdapter.Fill(vanzari.Clienti);

            // Protectie la modificare
            txtNrVanzare.ReadOnly = true;
            txtTotal.ReadOnly = true;
            nrCrtDataGridViewTextBoxColumn.ReadOnly = true;
            uMDataGridViewTextBoxColumn.ReadOnly = true;
            pretVanzareDataGridViewTextBoxColumn.ReadOnly = true;
            idProdusDataGridViewTextBoxColumn.ReadOnly = true;
            


            if (lblOp.Text == "MODIFICARE VANZARE") completeazaVanzare();
            else if (lblOp.Text == "VANZARE NOUA") cmbClient.SelectedIndex = -1;
            //completeazaRezervare();
            //cmbClient.SelectedIndex = -1;
        }
        private void A2()
        {
            if (!validareCampuriObligatorii()) return;
            if (lblOp.Text == "MODIFICARE VANZARE")
            {
                modificaInregistrare();
                stergeContinut();
                adaugaInregistrariVanzariContinut();
                this.Close();
            }
            else if (lblOp.Text == "VANZARE NOUA")
            {
                generez_nr_vanzare();
                adaugaInregistrareVanzari();
                cautaInregistrare();
                adaugaInregistrariVanzariContinut();
                golireCampuri();
            }
        }
        private void A3()
        {
            // Generare NrCrt
            DataRowView current = (DataRowView)vanzareContinutManevraBindingSource.Current;
            try { current["NrCrt"] = vanzareContinutManevraBindingSource.Position + 1; }
            catch { }
        }
        private void A4()
        {
            try
            {


                if (dataGridView1.CurrentCell != null)
                {
                    if (dataGridView1.CurrentCell.ColumnIndex == 0)
                    {
                        DataRowView current = (DataRowView)produseBindingSource.Current;
                        dataGridView1.CurrentRow.Cells[1].Value = current["UM"];
                        dataGridView1.CurrentRow.Cells[2].Value = current["Pret"];
                        dataGridView1.CurrentRow.Cells[5].Value = current["IdProdus"];

                        //dataGridView1.CurrentRow.Cells[9].Value = current["SplImagine"];
                        calcTotal();
                    }
                    if (dataGridView1.CurrentCell.ColumnIndex == 3)
                    {
                        vanzareContinutManevraBindingSource.EndEdit();
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
        private void Vanzare_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vanzari.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.vanzari.Produse);
            // TODO: This line of code loads data into the 'vanzari.Clienti' table. You can move, or remove it, as needed.
            this.clientiTableAdapter.Fill(this.vanzari.Clienti);
            con2.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd2.Connection = con2;
            A1();

        }

        private void btnConfirmare_Click(object sender, EventArgs e)
        {
            bool completatCantitatea = true;

            for (int row = 0; row < dataGridView1.Rows.Count; row++)
            {
                if (dataGridView1.Rows[row].Cells[3].Value != null && dataGridView1.Rows[row].Cells[3].Value.ToString() == "")
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
        private void calcTotal()
        {
            decimal t = 0;
            foreach (DataRow r in vanzari.vanzareContinutManevra)
            {
                if (r["Valoare"] != DBNull.Value)
                    t += (decimal)r["Valoare"];
            }
            txtTotal.Text = Convert.ToString(t);
        }
        private void generez_nr_vanzare()
        {
            con.ConnectionString = clientiTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;
            cmd.CommandText = "SELECT Max(Vanzari.NrVanzare) AS NrMax FROM Vanzari";
            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            txtNrVanzare.Text = rdr.IsDBNull(0) ? "1" : Convert.ToString(rdr.GetInt32(0) + 1); ;

            rdr.Close();
            con.Close();
        }
        private bool validareCampuriObligatorii()
        {
            //Validare de completare obligatorie campul Client
            if (cmbClient.Text == "")
            {
                MessageBox.Show("Completati Client !");
                cmbClient.Focus();
                return false;
            }
            // Validare completare continut
            if (vanzareContinutManevraBindingSource.Count == 0)
            {
                MessageBox.Show("Completati continut vanzare !");
                dataGridView1.Focus();
                return false;
            }
            return true;
        }
        private void adaugaInregistrareVanzari()
        {
            string listaCampuri;
            string listaValori;
            DateTime d = dateTimePicker1.Value;

            listaCampuri = "NrVanzare, DataVanzare, IdClient";
            listaValori = "'" + txtNrVanzare.Text +
                          "',#" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#,"
                               + cmbClient.SelectedValue;

            cmd.CommandText = "Insert into Vanzari(" + listaCampuri + ") " +
                              "Select " + listaValori;

            //MessageBox.Show(cmd.CommandText);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void cautaInregistrare()
        {
            DateTime d = dateTimePicker1.Value;
            cmd.CommandText = "SELECT IdVanzare From Vanzari Where NrVanzare = " + txtNrVanzare.Text;
            // cmd.CommandText = "SELECT IdRezervare From Rezervari Where DataRezervarii = " + "#" + Convert.ToString(d.Month) + "/"
            //                    + Convert.ToString(d.Day) + "/"
            //                    + Convert.ToString(d.Year) + "#" + " AND IdClient= " +cmbClient.SelectedValue;
            // MessageBox.Show(cmd.CommandText);

            con.Open();
            rdr = cmd.ExecuteReader();
            rdr.Read();

            idVanzare = rdr.GetInt32(0);
            // MessageBox.Show(Convert.ToString(idRez));
            rdr.Close();
            con.Close();
        }
        private void adaugaInregistrariVanzariContinut()
        {
            string listaCampuri = "IdVanzare, NrCrt, IdProdus, Cantitate, Pret";
            string listaValori;
            // DateTime d = dtpCazare.Value;
            //  DateTime d2 = (DateTime)dataGridView1.CurrentRow.Cells[8].Value;

            con.Open();
            foreach (DataRow r in vanzari.vanzareContinutManevra)
            {
                
                listaValori = idVanzare + ","
                    + r["NrCrt"] + ","
                    + r["IdProdus"] + ","
                    + r["Cantitate"] + ","
                    + r["PretVanzare"];

                cmd.CommandText = "Insert into VanzariContinut(" + listaCampuri + ") " + "Select " + listaValori;

                // MessageBox.Show(cmd.CommandText);
                cmd.ExecuteNonQuery();
            }
            con.Close();
        }
        private void golireCampuri()
        {
            txtNrVanzare.Text = "";
            txtTotal.Text = "";
            cmbClient.SelectedIndex = -1;
            vanzari.vanzareContinutManevra.Clear();
        }
        private void modificaInregistrare()
        {
            DateTime d1 = dateTimePicker1.Value;
            // DateTime d2 = (DateTime)dataGridView1.CurrentRow.Cells[8].Value;
            con.ConnectionString = produseTableAdapter.Connection.ConnectionString;
            cmd.Connection = con;

            string clauzaWhere = " Where IdVanzare = " + idVanzare;

            string clauzaSet = "Set DataVanzare = #" + d1.Month + "/"
                               + d1.Day + "/"
                               + d1.Year + "#,"
                               + "IdClient = '" + cmbClient.SelectedValue + "'";

            cmd.CommandText = "Update Vanzari " + clauzaSet + clauzaWhere;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void stergeContinut()
        {
            cmd.CommandText = "Delete from VanzariContinut Where IdVanzare = " + idVanzare;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private Boolean verificaStoc(String IdProdus, Decimal cantitate)
        {
            Boolean sufic_stoc = true;

            //MessageBox.Show("parametrii: " + dProdus + " " + cantitate);
            if (cantitate.ToString() == "")
            {
                MessageBox.Show("nu ati compeltat cantitatea");
                return false;
            }
            if (IdProdus == "")
            {
                MessageBox.Show("nu ati compeltat Produs");
                return false;
            }
       
            cmd2.CommandText = "SELECT Cantitate FROM StocProduse  WHERE IdProdus=" + IdProdus;
            MessageBox.Show(cmd2.CommandText);

            con2.Open();
            rdr2 = cmd2.ExecuteReader();
            rdr2.Read();
            //{
           

               MessageBox.Show("text" + rdr2.GetDouble(0));

            
            if (rdr2.GetDouble(0) < Convert.ToDouble(cantitate))
            {
                sufic_stoc = false;
            }
               

            con2.Close();
            rdr2.Close();




            if (sufic_stoc)
            {
                MessageBox.Show("Stoc suficient");
                return true;
            }
            else

            {
                MessageBox.Show("Stoc INSUFICIENT");
                return false;
            }


        }


        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int currRowIndex = e.RowIndex;

            if (e.ColumnIndex == 0)
                for (int row = 0; row < dataGridView1.Rows.Count; row++)
                {
                    if (dataGridView1.Rows[row].Cells[0].Value != null && dataGridView1.Rows[row].Cells[0].Value.Equals(dataGridView1.Rows[currRowIndex].Cells[0].Value) && row != currRowIndex)
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

        private void vanzareContinutManevraBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            A3();
        }

        private void dataGridView1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
                verificaStoc(dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString(), Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells[3].Value));
        }
    }
}
