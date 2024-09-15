using BussinesLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SalesManHelper
{
    public partial class frmSalesAndCollectionInAPeriod : Form
    {
        public frmSalesAndCollectionInAPeriod()
        {
            InitializeComponent();
        }

        private void frmSalesAndCollectionInAPeriod_Load(object sender, EventArgs e)
        {
            dgvSalesAndCollectionsList.DataSource=Groups.GetSalesAndCollectionsInAPeriod() ;
        }
    }
}
