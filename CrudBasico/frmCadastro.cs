using System;
using System.Windows.Forms;

namespace CrudBasico
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        #region Variaveis publicas
        public int Codigo;
        public string Nome;
        public string Endereco;
        public string Telefone;
        public string Sexo;
        public string Ativo;
        public DateTime DataCadastro;
        #endregion

        #region Metodos
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

                Gravar(txtNome.Text, txtEndereco.Text, mskTelefone.Text, strSexo, strAtivo);
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
