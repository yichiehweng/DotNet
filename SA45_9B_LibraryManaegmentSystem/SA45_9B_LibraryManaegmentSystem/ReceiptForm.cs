using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA45_9B_LibraryManaegmentSystem
{
    public partial class ReceiptForm : Form
    {
        LibraryEntities context = new LibraryEntities();
        List<IssueTran> theTran;
        //List<string> theTran=new List<string>() {"0"};
        
        public ReceiptForm(List<IssueTran> theTran)
        {
            InitializeComponent();
            this.theTran = theTran;
        }

    
        public ReceiptForm()
        {
            InitializeComponent();            
        }
        private void ReceiptForm_Load(object sender, EventArgs e)
        {
            CrystalReport4 cr = new CrystalReport4();
            crystalReportViewer1.ReportSource = cr;

            /*
            LibraryDataSet ds = new LibraryDataSet();
            LibraryDataSetTableAdapters.IssueTranTableAdapter ts = new LibraryDataSetTableAdapters.IssueTranTableAdapter();
            ts.Fill(ds.IssueTran);
            CrystalReport3 cr = new CrystalReport3();
            cr.SetDataSource(ds);

            crystalReport31.SetParameterValue("DateIssue", "2017-09-27");
            crystalReport31.SetParameterValue("Due Date", "2017-10-05");
            crystalReport31.SetParameterValue("ISBN Number", "1111111111");
            crystalReport31.SetParameterValue("Member Name", "Lou Anna Tan");
            crystalReport31.SetParameterValue("Book Title", "The New Paper");          
            crystalReportViewer1.ReportSource = cr;
            */
            /*
            crystalReport31.SetDataSource(theTran);
            crystalReport31.SetParameterValue("Date Issue", theTran[0].DateIssue);
            crystalReport31.SetParameterValue("Due Date", theTran[0].DateDue);
            crystalReport31.SetParameterValue("ISBN Number", theTran[0].ISBNNumber);
            crystalReport31.SetParameterValue("Member Name", theTran[0].Member.MemberName.Last());
            crystalReport31.SetParameterValue("Book Title",theTran[0].Book.BookTitle);
            */
            /*            
            crystalReport31.SetDataSource(theTran);
            crystalReport31.SetParameterValue("Date Issue", "2017-09-27");
            crystalReport31.SetParameterValue("Due Date","2017-10-05");
            crystalReport31.SetParameterValue("ISBN Number", "1111111111");
            crystalReport31.SetParameterValue("Member Name", "Lou Anna Tan");
            crystalReport31.SetParameterValue("Book Title","The New Paper");
            */

        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
