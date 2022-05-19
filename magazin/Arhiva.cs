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
    public partial class Arhiva : Form
    {
        public Arhiva()
        {
            InitializeComponent();
        }

        private void Arhiva_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.Produse' table. You can move, or remove it, as needed.
            this.produseTableAdapter.Fill(this.dataSet1.Produse);
            A1();

        }
        private void A1()
        {

            //Umple cu date obiectele DataTable: Persoane, Localitati (din DataSet):
            arhivaTableAdapter.Fill(dataSet1.Arhiva);


            //Protectie grid 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ReadOnly = true;

            //Protectie txtIdPersoana
            

            A3();
        }
        private void A2()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "ADAUGARE";

            //Pozitionare cursor pe primul camp
            

            // Golire campuri
            golireCampuri();
        }
        private void A3()
        {
            //Initializare lblOp
            lblOp.Text = "";

            //Çonfigurare(butoane)
            configureazaButoane(true);

            //Protectie componente Panel
            protectiePanel(true);

            //Legare controale
            legareControale(true);
        }
        private void A4()
        {
            if (lblOp.Text == "ADAUGARE")
            {
                if (!validareCampuriObligatorii()) return;

                adauga_inregistrare();

                golireCampuri();

                //Pune cursor pe primul camp
                
                refresh_grid(arhivaBindingSource.Position);
            }
            else if (lblOp.Text == "MODIFICARE")
            {
                modifica_inregistrare();
                refresh_grid(arhivaBindingSource.Position);
                A3();
            }
            else
                MessageBox.Show("Operatie actualizare neefectuata");
        }
        private void A5(TextBox txtB)
        {
            decimal p;
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            if (lblOp.Text == "") return;
            if (txtB.Text == "") return;
            if (btnRenuntare.Focused) return;

            if (txtB == txtCantitate)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }
                return;
            }

            if (txtB == txtPret)
            {
                // Validare numericitate
                try { p = Convert.ToDecimal(txtB.Text); }
                catch { MessageBox.Show("Format eronat"); txtB.Focus(); }

                con.ConnectionString = arhivaTableAdapter.Connection.ConnectionString;
                cmd.Connection = con;
                DateTime d = dateTimePicker1.Value;
                if (lblOp.Text == "ADAUGARE")
                {
                    cmd.CommandText = "Select IdProdus From StocInitial where Data= #" + Convert.ToString(d.Month) + "/"
                               +Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#" + " and IdProdus = " + cmbProdus.SelectedValue;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Inregistrare deja existenta la aceasta data pentru acest produs");
                        dateTimePicker1.Focus();
                    }
                    con.Close();
                }

                else if (lblOp.Text == "MODIFICARE")
                {
                    cmd.CommandText = "Select IdProdus From StocInitial where Data= #" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#" + 
                                      " and IdProdus  <> " + cmbProdus.SelectedValue;
                    con.Open();
                    r = cmd.ExecuteReader();
                    if (r.Read())
                    {
                        MessageBox.Show("Inregistrare deja existenta la aceasta data pentru acest produs");
                        dateTimePicker1.Focus();
                    }
                    con.Close();
                }
            }
        }
        private void A6()
        {
            if (lblOp.Text == "")
                return;

        }
        private void A7()
        {
            //Configurare butoane
            configureazaButoane(false);

            //Dezlegare controale Panel
            legareControale(false);

            //Ridicare protectie controale Panel
            protectiePanel(false);

            //Modifcare lblOp
            lblOp.Text = "MODIFICARE";

            //Pozitionare cursor pe primul camp
            dateTimePicker1.Focus();
         
        }
        private void A8()
        {
            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = arhivaTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;

           
            con.Open();
            DateTime d;
           

            const string mesaj = "Confirmati stergerea";
            const string titlu = "Stergere inregistrare";
            
            int id;
            DataRowView current = (DataRowView)arhivaBindingSource.Current;
            d = (DateTime)current["Data"];
            id = (int)current["IdProdus"];
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            cmd.CommandText = "Delete From StocInitial Where Data = #" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "# and IdProdus = " + id;

            MessageBox.Show(cmd.CommandText);


            cmd.ExecuteNonQuery();

            con.Close();

            refresh_grid(arhivaBindingSource.Position);

        }
        private void configureazaButoane(bool v)
        {
            btnRenuntare.Visible = !v;
            btnConfirma.Visible = !v;

            btnAdaugare.Enabled = v;
            btnModificare.Enabled = v;
            btnStergere.Enabled = v;
           
        }

        private void legareControale(bool v)
        {
            if (v)
            {
                dateTimePicker1.DataBindings.Add("Text", arhivaBindingSource, "Data");
                cmbProdus.DataBindings.Add("Text", arhivaBindingSource, "DProdus");
                txtCantitate.DataBindings.Add("Text", arhivaBindingSource, "Cantitate");
                txtPret.DataBindings.Add("Text", arhivaBindingSource, "Pret");
            }
            else
            {
                dateTimePicker1.DataBindings.Clear();
                cmbProdus.DataBindings.Clear();
                txtCantitate.DataBindings.Clear();
                txtPret.DataBindings.Clear();
                
            }
        }
        private void protectiePanel(bool v)
        {

            txtCantitate.ReadOnly = v;
            txtPret.ReadOnly = v;
           
            
        }
        private void golireCampuri()
        {
            txtCantitate.Text = "";
            txtPret.Text = "";
        }
        private bool validareCampuriObligatorii()
        {


            //Validare de completare obligatorie campurile: Nume, CNP, Salariu, Localitate
            if (txtCantitate.Text == "")
            {
                MessageBox.Show("Completati Cantitate!");
                txtCantitate.Focus();
                return false;
            }
            if (txtPret.Text == "")
            {
                MessageBox.Show("Completati Pretul!");
                txtPret.Focus();
                return false;
            }



            return true;
        }
        private void adauga_inregistrare()
        {
            string listaCampuri;
            string listaValori;

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();

            con.ConnectionString = arhivaTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;
            DateTime d = dateTimePicker1.Value;


            listaCampuri = "Data, IdProdus, Cantitate, Pret";
            listaValori = "  #" + Convert.ToString(d.Month) + "/"
                               +Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#"  +
                          ",'" + cmbProdus.SelectedValue + "'" +
                          "," + txtCantitate.Text  +
                          "," + txtPret.Text + "";

            cmd.CommandText = "Insert into StocInitial(" + listaCampuri + ") " +
                              "Select " + listaValori;

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();
        }
        private void refresh_grid(int p)
        {
            arhivaTableAdapter.Fill(dataSet1.Arhiva);
            arhivaBindingSource.Position = p;
        }
        private void modifica_inregistrare()
        {
            

            OleDbConnection con = new OleDbConnection();
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader r;

            con.ConnectionString = arhivaTableAdapter.Connection.ConnectionString;

            cmd.Connection = con;


            con.Open();
            DateTime d;
            const string mesaj = "Confirmati modificarea";
            const string titlu = "Modificare inregistrare";


            int id;
            DataRowView current = (DataRowView)arhivaBindingSource.Current;
            d = (DateTime)current["Data"];
            id = (int)current["IdProdus"];
            var rezultat = MessageBox.Show(mesaj, titlu, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (rezultat == DialogResult.No) return;
            cmd.CommandText = "Delete From StocInitial Where Data = #" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "# and IdProdus = " + id;

          


            cmd.ExecuteNonQuery();

            con.Close();
            adauga_inregistrare();
            refresh_grid(arhivaBindingSource.Position);

           /* listaSet = 
                          " Cantitate = " + txtCantitate.Text +
                          ", Pret = " + txtPret.Text + ""; ;

            cmd.CommandText = "Update StocInitial Set " + listaSet + " Where IdProdus=" + cmbProdus.SelectedValue + " and Data = #" + Convert.ToString(d.Month) + "/"
                               + Convert.ToString(d.Day) + "/"
                               + Convert.ToString(d.Year) + "#";

            MessageBox.Show(cmd.CommandText);

            con.Open();

            cmd.ExecuteNonQuery();

            con.Close();*/
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
        {
            A2();
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            A7();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            A4();
        }

        private void btnRenuntare_Click(object sender, EventArgs e)
        {
            A3();
        }

        private void btnStergere_Click(object sender, EventArgs e)
        {
            A8();
        }

        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {

        }

        private void txtCantitate_Leave(object sender, EventArgs e)
        {
            A5(txtCantitate);
        }

        private void txtPret_Leave(object sender, EventArgs e)
        {
            A5(txtPret);
        }
    }
}
