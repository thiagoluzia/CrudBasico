using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CrudBasico
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLogin.Text) && !String.IsNullOrEmpty(mskSenha.Text))
            {
                AcessarSistema(this.txtLogin.Text, this.mskSenha.Text);
            }
            
        }
        private void AcessarSistema(string login, string senha)
        {
            var objDados = new Dados();
            List<Dados.Login> lstRetorno = objDados.ConsultarLogin(login, senha);

            if(lstRetorno != null && lstRetorno.Count > 0)
            {
                frmCadastro objFrmCadastro = new frmCadastro();
                objFrmCadastro.ShowDialog();
            }
        }
    }
}
