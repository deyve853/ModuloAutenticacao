namespace ModuloAutenticacao.Desktop
{
    partial class TelaNivel
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
            this.LblID = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvNivel = new System.Windows.Forms.DataGridView();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.bntAtualizar = new System.Windows.Forms.Button();
            this.bntDeletar = new System.Windows.Forms.Button();
            this.btnPesquisar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).BeginInit();
            this.SuspendLayout();
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.Location = new System.Drawing.Point(192, 121);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(18, 13);
            this.LblID.TabIndex = 0;
            this.LblID.Text = "ID";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(175, 162);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(233, 121);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(354, 20);
            this.textBox1.TabIndex = 2;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(233, 159);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(354, 20);
            this.txtNome.TabIndex = 3;
            // 
            // dgvNivel
            // 
            this.dgvNivel.BackgroundColor = System.Drawing.Color.White;
            this.dgvNivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNivel.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvNivel.Location = new System.Drawing.Point(233, 241);
            this.dgvNivel.Name = "dgvNivel";
            this.dgvNivel.Size = new System.Drawing.Size(354, 185);
            this.dgvNivel.TabIndex = 4;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.BtnCadastrar.Location = new System.Drawing.Point(494, 197);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(93, 23);
            this.BtnCadastrar.TabIndex = 5;
            this.BtnCadastrar.Text = "Cadrastar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.BtnCadastrar_Click);
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.ForeColor = System.Drawing.Color.Black;
            this.bntAtualizar.Location = new System.Drawing.Point(232, 197);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(75, 23);
            this.bntAtualizar.TabIndex = 6;
            this.bntAtualizar.Text = "Atualizar";
            this.bntAtualizar.UseVisualStyleBackColor = true;
            // 
            // bntDeletar
            // 
            this.bntDeletar.ForeColor = System.Drawing.Color.Black;
            this.bntDeletar.Location = new System.Drawing.Point(313, 197);
            this.bntDeletar.Name = "bntDeletar";
            this.bntDeletar.Size = new System.Drawing.Size(75, 23);
            this.bntDeletar.TabIndex = 7;
            this.bntDeletar.Text = "Deletar";
            this.bntDeletar.UseVisualStyleBackColor = true;
            this.bntDeletar.Click += new System.EventHandler(this.bntDeletar_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.ForeColor = System.Drawing.Color.Black;
            this.btnPesquisar.Location = new System.Drawing.Point(413, 197);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(75, 23);
            this.btnPesquisar.TabIndex = 8;
            this.btnPesquisar.Text = "Pequisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // TelaNivel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateBlue;
            this.BackgroundImage = global::ModuloAutenticacao.Desktop.Properties.Resources._6;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(799, 532);
            this.Controls.Add(this.btnPesquisar);
            this.Controls.Add(this.bntDeletar);
            this.Controls.Add(this.bntAtualizar);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.dgvNivel);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.LblID);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "TelaNivel";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNivel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvNivel;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button bntAtualizar;
        private System.Windows.Forms.Button bntDeletar;
        private System.Windows.Forms.Button btnPesquisar;
    }
}