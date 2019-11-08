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
    public partial class Form1 : Form
    {
        public Form1()
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
                    blnAtivo = true;
                    ativo = 1;
                }
                else
                {
                    blnAtivo = false;
                    ativo = 0;
                }

                Gravar(txtNome.Text, txtEndereco.Text, mskTelefone.Text, strSexo, ativo);
            }
        }
        private void BtnExcluir_Click(object sender, EventArgs e)
        {
            var objDados = new Dados();
            objDados.Excluir(Convert.ToInt32(txtExcluir.Text));
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            frmConsultar frm = new frmConsultar();
            frm.ShowDialog();
        }
    }
}
