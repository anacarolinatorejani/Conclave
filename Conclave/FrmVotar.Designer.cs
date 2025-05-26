namespace Conclave
{
    partial class FrmVotar
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
            this.lbxCardeais = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btVotar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxCardeais
            // 
            this.lbxCardeais.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxCardeais.FormattingEnabled = true;
            this.lbxCardeais.ItemHeight = 25;
            this.lbxCardeais.Location = new System.Drawing.Point(65, 76);
            this.lbxCardeais.Name = "lbxCardeais";
            this.lbxCardeais.Size = new System.Drawing.Size(208, 179);
            this.lbxCardeais.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escolha um cardeal:";
            // 
            // btVotar
            // 
            this.btVotar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btVotar.Location = new System.Drawing.Point(118, 288);
            this.btVotar.Name = "btVotar";
            this.btVotar.Size = new System.Drawing.Size(99, 45);
            this.btVotar.TabIndex = 2;
            this.btVotar.Text = "&Votar";
            this.btVotar.UseVisualStyleBackColor = true;
            this.btVotar.Click += new System.EventHandler(this.btVotar_Click);
            // 
            // FrmVotar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 365);
            this.Controls.Add(this.btVotar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbxCardeais);
            this.Name = "FrmVotar";
            this.Text = "FrmVotar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxCardeais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVotar;
    }
}