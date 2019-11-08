using System;
using System.Collections.Generic;
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
            CarregarListView();
        }
        //Grid é mais facil
        private void CarregarGridView()
        {
            var objDados = new Dados();
            List<Clientes> lstClientes = new List<Clientes>();

            lstClientes = objDados.Consultar();
            dgvClientes.DataSource = lstClientes;

        }
        private void CarregarListView()
        {
            var objDados = new Dados();
            List<Clientes> listaClientes = new List<Clientes>();
            listaClientes = objDados.Consultar();
            ListViewItem objListViewItem = new ListViewItem();

            foreach (var itemLista in listaClientes)
            {
                objListViewItem = new ListViewItem();

                objListViewItem.Text = itemLista.IdCliente.ToString();
                objListViewItem.SubItems.Add(itemLista.Nome);
                objListViewItem.SubItems.Add(itemLista.Endereco);
                objListViewItem.SubItems.Add(itemLista.Telefone);
                objListViewItem.SubItems.Add(itemLista.Sexo);
                objListViewItem.SubItems.Add(itemLista.Ativo);

                objListViewItem.SubItems.Add(itemLista.DataCadastro.ToShortDateString());

                lstClientes.Items.Add(objListViewItem);
            }
        }
    }
}
