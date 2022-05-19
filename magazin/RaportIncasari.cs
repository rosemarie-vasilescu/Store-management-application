using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;


namespace magazin
{
    public partial class RaportIncasari : Form
    {
        public RaportIncasari()
        {
            InitializeComponent();
        }

        private void RaportIncasari_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRaport_Click(object sender, EventArgs e)
        {
            DateTime d1 = new DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month,
dateTimePicker1.Value.Day);
            DateTime d2 = new DateTime(dateTimePicker2.Value.Year, dateTimePicker2.Value.Month, dateTimePicker2.Value.Day);
            this.AchizitiiTableAdapter.Fill(this.IncasariDS.Achizitii, d1, d2);

            ReportParameter[] parameters = new ReportParameter[1];
            parameters[0] = new ReportParameter("Data1", "Lista achizitiilor din perioada " + d1.ToShortDateString() + " - " + d2.ToShortDateString());
            //Comunicare parametrii
            this.reportViewer1.LocalReport.SetParameters(parameters);

            this.reportViewer1.RefreshReport();
        }
    }
}
