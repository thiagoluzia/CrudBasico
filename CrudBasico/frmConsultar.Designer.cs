namespace CrudBasico
{
    partial class frmConsultar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lstClientes = new System.Windows.Forms.ListView();
            this.IdCliente = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Endereco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sexo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ativo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DataCadastro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(12, 12);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.Size = new System.Drawing.Size(562, 177);
            this.dgvClientes.TabIndex = 0;
            // 
            // lstClientes
            // 
            this.lstClientes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.IdCliente,
            this.Nome,
            this.Endereco,
            this.Telefone,
            this.Sexo,
            this.Ativo,
            this.DataCadastro});
            this.lstClientes.FullRowSelect = true;
            this.lstClientes.GridLines = true;
            this.lstClientes.Location = new System.Drawing.Point(12, 206);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(562, 168);
            this.lstClientes.TabIndex = 1;
            this.lstClientes.UseCompatibleStateImageBehavior = false;
            this.lstClientes.View = System.Windows.Forms.View.Details;
            // 
            // IdCliente
            // 
            this.IdCliente.Text = "Código";
            this.IdCliente.Width = 48;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome do Cliente";
            this.Nome.Width = 111;
            // 
            // Endereco
            // 
            this.Endereco.Text = "Enderço";
            this.Endereco.Width = 151;
            // 
            // Telefone
            // 
            this.Telefone.Text = "Telefone";
            this.Telefone.Width = 99;
            // 
            // Sexo
            // 
            this.Sexo.Text = "Sexo";
            this.Sexo.Width = 41;
            // 
            // Ativo
            // 
            this.Ativo.Text = "Ativo?";
            this.Ativo.Width = 43;
            // 
            // DataCadastro
            // 
            this.DataCadastro.Text = "Data";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(483, 380);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 29);
            this.btnExcluir.TabIndex = 2;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(386, 380);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 29);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // frmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 546);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.lstClientes);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmConsultar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consultar Clientes";
            this.Load += new System.EventHandler(this.FrmConsultar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ListView lstClientes;
        private System.Windows.Forms.ColumnHeader IdCliente;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.ColumnHeader Endereco;
        private System.Windows.Forms.ColumnHeader Telefone;
        private System.Windows.Forms.ColumnHeader Sexo;
        private System.Windows.Forms.ColumnHeader Ativo;
        private System.Windows.Forms.ColumnHeader DataCadastro;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
    }
}