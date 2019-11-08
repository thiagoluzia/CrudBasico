using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrudBasico
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void Gravar(string Nome, string Endereco, string Telefone, string Sexo, int Ativo)
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
        private void BtnGravar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtNome.Text) && !String.IsNullOrEmpty(txtEndereco.Text))
            {
                string strSexo = string.Empty;
                bool blnAtivo = true;
                int ativo = 0;

                if (rbtMasculino.Checked)
                {
                    strSexo = "M";
                }
                else
                {
                    strSexo = "F";
                }

                if (rbtAtivo.Checked)
                {
                    ativo = 1;
                }
                else
                {
                    ativo = 1;
                }

                Gravar(txtNome.Text, txtEndereco.Text, mskTelefone.Text, strSexo, ativo);
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
    }
}
