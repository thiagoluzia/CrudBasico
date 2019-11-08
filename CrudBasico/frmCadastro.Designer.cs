namespace CrudBasico
{
    partial class frmCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.rbtFeminino = new System.Windows.Forms.RadioButton();
            this.btnGravar = new System.Windows.Forms.Button();
            this.mskTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbStatus = new System.Windows.Forms.GroupBox();
            this.rbtInativo = new System.Windows.Forms.RadioButton();
            this.rbtAtivo = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbSexo.SuspendLayout();
            this.gpbStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(86, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(203, 20);
            this.txtNome.TabIndex = 1;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rbtMasculino);
            this.gpbSexo.Controls.Add(this.rbtFeminino);
            this.gpbSexo.Location = new System.Drawing.Point(27, 132);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(262, 57);
            this.gpbSexo.TabIndex = 6;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(116, 22);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 1;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // rbtFeminino
            // 
            this.rbtFeminino.AutoSize = true;
            this.rbtFeminino.Location = new System.Drawing.Point(25, 22);
            this.rbtFeminino.Name = "rbtFeminino";
            this.rbtFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbtFeminino.TabIndex = 0;
            this.rbtFeminino.TabStop = true;
            this.rbtFeminino.Text = "Feminino";
            this.rbtFeminino.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(198, 253);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(91, 29);
            this.btnGravar.TabIndex = 8;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
            // 
            // mskTelefone
            // 
            this.mskTelefone.Location = new System.Drawing.Point(86, 76);
            this.mskTelefone.Mask = "(99) 000-0000";
            this.mskTelefone.Name = "mskTelefone";
            this.mskTelefone.Size = new System.Drawing.Size(100, 20);
            this.mskTelefone.TabIndex = 5;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Location = new System.Drawing.Point(86, 50);
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(203, 20);
            this.txtEndereco.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Endereco:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // gpbStatus
            // 
            this.gpbStatus.Controls.Add(this.rbtInativo);
            this.gpbStatus.Controls.Add(this.rbtAtivo);
            this.gpbStatus.Location = new System.Drawing.Point(27, 195);
            this.gpbStatus.Name = "gpbStatus";
            this.gpbStatus.Size = new System.Drawing.Size(262, 52);
            this.gpbStatus.TabIndex = 7;
            this.gpbStatus.TabStop = false;
            this.gpbStatus.Text = "Status";
            // 
            // rbtInativo
            // 
            this.rbtInativo.AutoSize = true;
            this.rbtInativo.Location = new System.Drawing.Point(116, 19);
            this.rbtInativo.Name = "rbtInativo";
            this.rbtInativo.Size = new System.Drawing.Size(57, 17);
            this.rbtInativo.TabIndex = 1;
            this.rbtInativo.TabStop = true;
            this.rbtInativo.Text = "Inativo";
            this.rbtInativo.UseVisualStyleBackColor = true;
            // 
            // rbtAtivo
            // 
            this.rbtAtivo.AutoSize = true;
            this.rbtAtivo.Location = new System.Drawing.Point(25, 19);
            this.rbtAtivo.Name = "rbtAtivo";
            this.rbtAtivo.Size = new System.Drawing.Size(49, 17);
            this.rbtAtivo.TabIndex = 0;
            this.rbtAtivo.TabStop = true;
            this.rbtAtivo.Text = "Ativo";
            this.rbtAtivo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(198, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "FRM Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 361);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gpbStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEndereco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.gpbSexo);
            this.Controls.Add(this.mskTelefone);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label1);
            this.Name = "frmCadastro";
            this.Text = "frmCadastro";
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbStatus.ResumeLayout(false);
            this.gpbStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.RadioButton rbtFeminino;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.MaskedTextBox mskTelefone;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbStatus;
        private System.Windows.Forms.RadioButton rbtInativo;
        private System.Windows.Forms.RadioButton rbtAtivo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ErrorProvider epError;
    }
}

