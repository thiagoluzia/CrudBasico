using System;
using System.Windows.Forms;

namespace CrudBasico
{
    public partial class frmCadastro : Form
    {
        #region Variaveis publicas
        public int Codigo = 0;
        public string Nome;
        public string Endereco;
        public string Telefone;
        public string Sexo;
        public string Ativo;
        public DateTime DataCadastro;
        #endregion
        public frmCadastro()
        {
            InitializeComponent();
        }
        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            if(Codigo > 0)
            {
                btnGravar.Text = "Atualizar";
                txtNome.Text = Nome;
                txtEndereco.Text = Endereco;
                mskTelefone.Text = Telefone;

                if (Ativo.Equals("Sim"))
                {
                    rbtAtivo.Select();
                }
                else
                {
                    rbtInativo.Select();
                }

                if (Sexo.Equals("F"))
                {
                    rbtFeminino.Select();
                }
                else
                {
                    rbtMasculino.Select();
                }
            }
            else
            {
                btnGravar.Text = "Gravar";
            }
        }

        #region Metodos
        private void Atualizar(int IdCliente, string Nome, string Endereco, string Telefone, string Sexo, string Ativo)
        {
            try
            {
                var objDados = new Dados();
                objDados.Atualizar(IdCliente, Nome, Endereco, Telefone, Sexo, Ativo, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu o seguinte erro: {ex.Message}");
            }
        }
        private void Gravar(string Nome, string Endereco, string Telefone, string Sexo, string Ativo)
        {
            try
            {
                var objDados = new Dados();
                objDados.Gravar(Nome, Endereco, Telefone, Sexo, Ativo, DateTime.Now);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu algum erro: {ex.Message}");
            }
        }
        #endregion

        #region Botoes
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtEndereco.Text))
            {
                string strSexo = string.Empty;
                string strAtivo = string.Empty;
               
                if (rbtMasculino.Checked)
                {
                    strSexo = "M";
                } else {
                    strSexo = "F";
                }

                if (rbtAtivo.Checked)
                {
                    strAtivo = "Sim";
                } else {
                    strAtivo = "Não";
                }

                if(Codigo == 0)
                {
                    Gravar(txtNome.Text, txtEndereco.Text, mskTelefone.Text, strSexo, strAtivo);
                }
                else
                {
                    Atualizar(Codigo, txtNome.Text, txtEndereco.Text, mskTelefone.Text, strSexo, strAtivo);
                }
            }
            else
            {
                if (String.IsNullOrEmpty(txtNome.Text))
                {
                    epError.SetError(txtNome, "Informe o Nome");
                }
                if (String.IsNullOrEmpty(txtEndereco.Text))
                {
                    epError.SetError(txtEndereco, "Informe o Endereço");
                }
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            frmConsultar frm = new frmConsultar();
            frm.ShowDialog();
        }
        #endregion

        
    }
}
