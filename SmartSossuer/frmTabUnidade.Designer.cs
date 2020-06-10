namespace SmartSossuer
{
    partial class frmTabUnidade
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
            this.lblTabUnidade = new System.Windows.Forms.Label();
            this.btnSairTabUni = new System.Windows.Forms.Button();
            this.btnDeletarTabUni = new System.Windows.Forms.Button();
            this.dgvUnidade = new System.Windows.Forms.DataGridView();
            this.lblTabNomeUnidade = new System.Windows.Forms.Label();
            this.txtTabNomeUnidade = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidade)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTabUnidade
            // 
            this.lblTabUnidade.AutoSize = true;
            this.lblTabUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabUnidade.Location = new System.Drawing.Point(11, 18);
            this.lblTabUnidade.Name = "lblTabUnidade";
            this.lblTabUnidade.Size = new System.Drawing.Size(81, 20);
            this.lblTabUnidade.TabIndex = 10;
            this.lblTabUnidade.Text = "Unidades:";
            // 
            // btnSairTabUni
            // 
            this.btnSairTabUni.Location = new System.Drawing.Point(389, 462);
            this.btnSairTabUni.Name = "btnSairTabUni";
            this.btnSairTabUni.Size = new System.Drawing.Size(75, 23);
            this.btnSairTabUni.TabIndex = 8;
            this.btnSairTabUni.Text = "Sair";
            this.btnSairTabUni.UseVisualStyleBackColor = true;
            this.btnSairTabUni.Click += new System.EventHandler(this.btnSairTabUni_Click);
            // 
            // btnDeletarTabUni
            // 
            this.btnDeletarTabUni.Location = new System.Drawing.Point(117, 462);
            this.btnDeletarTabUni.Name = "btnDeletarTabUni";
            this.btnDeletarTabUni.Size = new System.Drawing.Size(75, 23);
            this.btnDeletarTabUni.TabIndex = 7;
            this.btnDeletarTabUni.Text = "Deletar";
            this.btnDeletarTabUni.UseVisualStyleBackColor = true;
            // 
            // dgvUnidade
            // 
            this.dgvUnidade.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnidade.Location = new System.Drawing.Point(15, 143);
            this.dgvUnidade.Name = "dgvUnidade";
            this.dgvUnidade.Size = new System.Drawing.Size(549, 303);
            this.dgvUnidade.TabIndex = 6;
            // 
            // lblTabNomeUnidade
            // 
            this.lblTabNomeUnidade.AutoSize = true;
            this.lblTabNomeUnidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTabNomeUnidade.Location = new System.Drawing.Point(12, 82);
            this.lblTabNomeUnidade.Name = "lblTabNomeUnidade";
            this.lblTabNomeUnidade.Size = new System.Drawing.Size(165, 16);
            this.lblTabNomeUnidade.TabIndex = 11;
            this.lblTabNomeUnidade.Text = "Digite o nome da unidade:";
            // 
            // txtTabNomeUnidade
            // 
            this.txtTabNomeUnidade.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtTabNomeUnidade.Location = new System.Drawing.Point(15, 101);
            this.txtTabNomeUnidade.Name = "txtTabNomeUnidade";
            this.txtTabNomeUnidade.Size = new System.Drawing.Size(280, 20);
            this.txtTabNomeUnidade.TabIndex = 9;
            // 
            // frmTabUnidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(574, 503);
            this.Controls.Add(this.lblTabNomeUnidade);
            this.Controls.Add(this.lblTabUnidade);
            this.Controls.Add(this.txtTabNomeUnidade);
            this.Controls.Add(this.btnSairTabUni);
            this.Controls.Add(this.btnDeletarTabUni);
            this.Controls.Add(this.dgvUnidade);
            this.Name = "frmTabUnidade";
            this.ShowIcon = false;
            this.Text = "Tabela Unidade";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnidade)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTabUnidade;
        private System.Windows.Forms.Button btnSairTabUni;
        private System.Windows.Forms.Button btnDeletarTabUni;
        private System.Windows.Forms.DataGridView dgvUnidade;
        private System.Windows.Forms.Label lblTabNomeUnidade;
        private System.Windows.Forms.TextBox txtTabNomeUnidade;
    }
}