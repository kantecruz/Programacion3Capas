using example.tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using example.business_layer;
using example.fisic_layer;
namespace example
{
    public partial class frmlistProducts : Form
    {
        public clspSQLServer vsqlServer = new clspSQLServer();
        public frmlistProducts()
        {            
            InitializeComponent();
        }

        private void frmlistProducts_Load(object sender, EventArgs e)
        {
            List<clspFLProduct> vlistProduct = new List<clspFLProduct>();
            int vresult = clspBLProduct.queryToDataBase(ref vlistProduct, vsqlServer);
            if (vresult == 1) {
                dataGridViewProducts.DataSource = vlistProduct;
                lblresult.Text = "Se ha cargado correctamente";
            }
            else
            {
                lblresult.Text = "Error: no se ha cargado correctamente";
            }
        }
    }
}
