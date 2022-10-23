using crystalReport.ReportGenerator.CrystalReport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace crystalReport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void crvDataTable_Load(object sender, EventArgs e)
        {
            DataTable transcom = new DataTable();

            transcom.Columns.Add("WARRANTY CARD NO", typeof(string));
            transcom.Columns.Add("Warranty Period", typeof(string));
            transcom.Columns.Add("Name", typeof(string));
            transcom.Columns.Add("Address", typeof(string));
            transcom.Columns.Add("Mobile", typeof(string));
            transcom.Columns.Add("Telephone", typeof(string));
            transcom.Columns.Add("E_mail", typeof(string));
            transcom.Columns.Add("Invoice No", typeof(string));
            transcom.Columns.Add("Invoice Date", typeof(string));
            transcom.Columns.Add("Outlet Name", typeof(string));
            transcom.Columns.Add("Sales Person", typeof(string));
            transcom.Columns.Add("Code", typeof(string));
            transcom.Columns.Add("Product Name", typeof(string));
            transcom.Columns.Add("Brand", typeof(string));
            transcom.Columns.Add("Serial", typeof(string));

            ////insert data
            transcom.Rows.Add("ETD-21-007559","Free Service-24.00  Months","Nahid","Mirpur-2","01620753043","028876484","nahid@gmail.com","ETD-2021-2024","13-jun-2021","[ETD]-Ecommerce Transcom Digital (ETD)","MD. WAHID MURAD","391029","Samsung Washing Machine WF16J6500EV/EU","Samsung","08ns5nan800044");
            
            crptProduct crpt = new crptProduct();
            crpt.Database.Tables["Product"].SetDataSource(transcom);

            crvDataTable.ReportSource = null;
            crvDataTable.ReportSource = crpt;
        }
    }
}
