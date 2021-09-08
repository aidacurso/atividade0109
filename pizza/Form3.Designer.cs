
namespace pizza
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDescrição = new System.Windows.Forms.Label();
            this.labelValor = new System.Windows.Forms.Label();
            this.textDescricao = new System.Windows.Forms.TextBox();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.pictureCardapio = new System.Windows.Forms.PictureBox();
            this.buttonInformacao = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCardapio)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(115, 100);
            this.buttonSalvar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(130, 22);
            this.buttonSalvar.TabIndex = 0;
            this.buttonSalvar.Text = "Ver valor total";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(96, 10);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(152, 28);
            this.labelTitulo.TabIndex = 1;
            this.labelTitulo.Text = "Faça seu pedido";
            // 
            // labelDescrição
            // 
            this.labelDescrição.AutoSize = true;
            this.labelDescrição.Location = new System.Drawing.Point(26, 37);
            this.labelDescrição.Name = "labelDescrição";
            this.labelDescrição.Size = new System.Drawing.Size(270, 15);
            this.labelDescrição.TabIndex = 2;
            this.labelDescrição.Text = "Digite o número referente a pizza que deseja pedir";
            // 
            // labelValor
            // 
            this.labelValor.AutoSize = true;
            this.labelValor.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelValor.Location = new System.Drawing.Point(104, 183);
            this.labelValor.Name = "labelValor";
            this.labelValor.Size = new System.Drawing.Size(138, 19);
            this.labelValor.TabIndex = 3;
            this.labelValor.Text = "Valor total do pedido";
            // 
            // textDescricao
            // 
            this.textDescricao.Location = new System.Drawing.Point(123, 54);
            this.textDescricao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textDescricao.Name = "textDescricao";
            this.textDescricao.Size = new System.Drawing.Size(110, 23);
            this.textDescricao.TabIndex = 4;
            // 
            // textTotal
            // 
            this.textTotal.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textTotal.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textTotal.Location = new System.Drawing.Point(115, 150);
            this.textTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textTotal.Name = "textTotal";
            this.textTotal.ReadOnly = true;
            this.textTotal.Size = new System.Drawing.Size(130, 34);
            this.textTotal.TabIndex = 5;
            this.textTotal.UseWaitCursor = true;
            // 
            // pictureCardapio
            // 
            this.pictureCardapio.Image = ((System.Drawing.Image)(resources.GetObject("pictureCardapio.Image")));
            this.pictureCardapio.Location = new System.Drawing.Point(302, -523);
            this.pictureCardapio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureCardapio.Name = "pictureCardapio";
            this.pictureCardapio.Size = new System.Drawing.Size(718, 1036);
            this.pictureCardapio.TabIndex = 6;
            this.pictureCardapio.TabStop = false;
            // 
            // buttonInformacao
            // 
            this.buttonInformacao.Location = new System.Drawing.Point(104, 316);
            this.buttonInformacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonInformacao.Name = "buttonInformacao";
            this.buttonInformacao.Size = new System.Drawing.Size(150, 38);
            this.buttonInformacao.TabIndex = 7;
            this.buttonInformacao.Text = "Finalizar pedido e verificar informações";
            this.buttonInformacao.UseVisualStyleBackColor = true;
            this.buttonInformacao.Click += new System.EventHandler(this.buttonInformacao_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 503);
            this.Controls.Add(this.buttonInformacao);
            this.Controls.Add(this.pictureCardapio);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.textDescricao);
            this.Controls.Add(this.labelValor);
            this.Controls.Add(this.labelDescrição);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.buttonSalvar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureCardapio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDescrição;
        private System.Windows.Forms.Label labelValor;
        private System.Windows.Forms.TextBox textDescricao;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.PictureBox pictureCardapio;
        private System.Windows.Forms.Button buttonInformacao;
    }
}