namespace Conclave
{
    partial class FrmGerenciar
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
            this.dgvCardeais = new System.Windows.Forms.DataGridView();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btAdicionar = new System.Windows.Forms.Button();
            this.btRemover = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardeais)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCardeais
            // 
            this.dgvCardeais.AllowUserToAddRows = false;
            this.dgvCardeais.AllowUserToDeleteRows = false;
            this.dgvCardeais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCardeais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nome});
            this.dgvCardeais.Location = new System.Drawing.Point(12, 12);
            this.dgvCardeais.Name = "dgvCardeais";
            this.dgvCardeais.ReadOnly = true;
            this.dgvCardeais.Size = new System.Drawing.Size(344, 426);
            this.dgvCardeais.TabIndex = 0;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(370, 81);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(67, 24);
            this.lblNome.TabIndex = 1;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(443, 78);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(245, 29);
            this.txtNome.TabIndex = 2;
            // 
            // btAdicionar
            // 
            this.btAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAdicionar.Location = new System.Drawing.Point(374, 204);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(314, 34);
            this.btAdicionar.TabIndex = 3;
            this.btAdicionar.Text = "&Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // btRemover
            // 
            this.btRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRemover.Location = new System.Drawing.Point(374, 371);
            this.btRemover.Name = "btRemover";
            this.btRemover.Size = new System.Drawing.Size(314, 36);
            this.btRemover.TabIndex = 4;
            this.btRemover.Text = "&Excluir";
            this.btRemover.UseVisualStyleBackColor = true;
            this.btRemover.Click += new System.EventHandler(this.btRemover_Click);
            // 
            // FrmGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 450);
            this.Controls.Add(this.btRemover);
            this.Controls.Add(this.btAdicionar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.dgvCardeais);
            this.Name = "FrmGerenciar";
            this.Text = "FrmGerenciar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGerenciar_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCardeais)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCardeais;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btAdicionar;
        private System.Windows.Forms.Button btRemover;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}