
namespace Exercicio_MySql_Cadastro_2Forms
{
    partial class Form2
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
            this.txtCaixaPesquisa = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvTabelaUsuario = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCaixaPesquisa
            // 
            this.txtCaixaPesquisa.Location = new System.Drawing.Point(12, 13);
            this.txtCaixaPesquisa.Name = "txtCaixaPesquisa";
            this.txtCaixaPesquisa.Size = new System.Drawing.Size(405, 23);
            this.txtCaixaPesquisa.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvTabelaUsuario
            // 
            this.dgvTabelaUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabelaUsuario.Location = new System.Drawing.Point(12, 40);
            this.dgvTabelaUsuario.Name = "dgvTabelaUsuario";
            this.dgvTabelaUsuario.RowTemplate.Height = 25;
            this.dgvTabelaUsuario.Size = new System.Drawing.Size(486, 236);
            this.dgvTabelaUsuario.TabIndex = 2;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 344);
            this.Controls.Add(this.dgvTabelaUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtCaixaPesquisa);
            this.Name = "Form2";
            this.Text = "Pesquisa";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabelaUsuario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCaixaPesquisa;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvTabelaUsuario;
    }
}