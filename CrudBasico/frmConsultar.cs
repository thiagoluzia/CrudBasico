using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CrudBasico.Dados;

namespace CrudBasico
{
    public partial class frmConsultar : Form
    {
        public frmConsultar()
        {
            InitializeComponent();
        }

        private void FrmConsultar_Load(object sender, EventArgs e)
        {
            CarregarGridView();
        }
        private void CarregarGridView()
        {
            var objDados = new Dados();
            List<Clientes> lstClientes = new List<Clientes>();

            lstClientes = objDados.Consultar();
            dgvClientes.DataSource = lstClientes;
        }
    }
}
