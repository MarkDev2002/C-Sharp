using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab7
{
    public partial class frmMon : Form
    {
        public frmMon()
        {
            InitializeComponent();
        }

        private void MonBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.monBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.basicStudentManagementDataSet);
                MessageBox.Show("Success");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error");
                FrmMon_Load(sender, e);
            }

        }

        private void FrmMon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'basicStudentManagementDataSet.Mon' table. You can move, or remove it, as needed.
            this.monTableAdapter.Fill(this.basicStudentManagementDataSet.Mon);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
           
        }
    }
}
