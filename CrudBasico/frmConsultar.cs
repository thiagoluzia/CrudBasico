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

        #region Metodos
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
        private void EditarRegistro()
        {
            int Codigo;
            string Nome;
            string Endereco;
            string Telefone;
            string Sexo;
            string Ativo;
            DateTime DataCadastro;

            try
            {
                if (lstClientes.SelectedItems.Count > 0)
                {
                    Codigo = Convert.ToInt32(lstClientes.SelectedItems[0].Text);
                    Nome = lstClientes.SelectedItems[0].SubItems[1].Text;
                    Endereco = lstClientes.SelectedItems[0].SubItems[2].Text;
                    Telefone = lstClientes.SelectedItems[0].SubItems[3].Text;
                    Sexo = lstClientes.SelectedItems[0].SubItems[4].Text;
                    Ativo = lstClientes.SelectedItems[0].SubItems[5].Text;
                    DataCadastro = Convert.ToDateTime(lstClientes.SelectedItems[0].SubItems[6].Text);

                    frmCadastro objFrmCadastro = new frmCadastro();
                    objFrmCadastro.Codigo = Codigo;
                    objFrmCadastro.Nome = Nome;
                    objFrmCadastro.Endereco = Endereco;
                    objFrmCadastro.Telefone = Telefone;
                    objFrmCadastro.Sexo = Sexo;
                    objFrmCadastro.Ativo = Ativo;
                    objFrmCadastro.DataCadastro = DataCadastro;
                    objFrmCadastro.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu o seguinte erro: {ex.Message}");
            }
        }
        private void ExcluirRegistro()
        {
            int Codigo = 0;

            try
            {
                if (lstClientes.SelectedItems.Count > 0)
                {
                    Codigo = Convert.ToInt32(lstClientes.SelectedItems[0].Text);
                }

                var objDados = new Dados();
                if (Codigo > 0)
                {
                    objDados.Excluir(Codigo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu o seguinte erro: {ex.Message}");
            }
        }
        #endregion

        #region Botoes
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            ExcluirRegistro();
        }
        private void BtnEditar_Click(object sender, EventArgs e)
        {
            EditarRegistro();
        }
        #endregion
    }
}
