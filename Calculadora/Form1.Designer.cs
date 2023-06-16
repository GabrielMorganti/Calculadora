
namespace Calculadora {
    partial class Calculadora {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.labelOperacao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(12, 12);
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.Size = new System.Drawing.Size(197, 20);
            this.TxtResultado.TabIndex = 0;
            this.TxtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelOperacao
            // 
            this.labelOperacao.AutoSize = true;
            this.labelOperacao.Location = new System.Drawing.Point(171, 15);
            this.labelOperacao.Name = "labelOperacao";
            this.labelOperacao.Size = new System.Drawing.Size(0, 13);
            this.labelOperacao.TabIndex = 1;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Calculadora.Properties.Resources.coca_2l;
            this.ClientSize = new System.Drawing.Size(306, 456);
            this.Controls.Add(this.labelOperacao);
            this.Controls.Add(this.TxtResultado);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Label labelOperacao;
    }
}

