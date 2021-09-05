
namespace pizza
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTítulo = new System.Windows.Forms.Label();
            this.labelNomecliente = new System.Windows.Forms.Label();
            this.labelTelefoneCliente = new System.Windows.Forms.Label();
            this.buttonContinuar = new System.Windows.Forms.Button();
            this.textBoxNomeCliente = new System.Windows.Forms.TextBox();
            this.textBoxTelefoneCliente = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTítulo
            // 
            this.labelTítulo.AutoSize = true;
            this.labelTítulo.Location = new System.Drawing.Point(67, 23);
            this.labelTítulo.Name = "labelTítulo";
            this.labelTítulo.Size = new System.Drawing.Size(146, 20);
            this.labelTítulo.TabIndex = 0;
            this.labelTítulo.Text = "Cadastro de clientes.";
            // 
            // labelNomecliente
            // 
            this.labelNomecliente.AutoSize = true;
            this.labelNomecliente.Location = new System.Drawing.Point(41, 81);
            this.labelNomecliente.Name = "labelNomecliente";
            this.labelNomecliente.Size = new System.Drawing.Size(53, 20);
            this.labelNomecliente.TabIndex = 1;
            this.labelNomecliente.Text = "Nome:";
            // 
            // labelTelefoneCliente
            // 
            this.labelTelefoneCliente.AutoSize = true;
            this.labelTelefoneCliente.Location = new System.Drawing.Point(25, 146);
            this.labelTelefoneCliente.Name = "labelTelefoneCliente";
            this.labelTelefoneCliente.Size = new System.Drawing.Size(69, 20);
            this.labelTelefoneCliente.TabIndex = 2;
            this.labelTelefoneCliente.Text = "Telefone:";
            // 
            // buttonContinuar
            // 
            this.buttonContinuar.Location = new System.Drawing.Point(67, 203);
            this.buttonContinuar.Name = "buttonContinuar";
            this.buttonContinuar.Size = new System.Drawing.Size(172, 34);
            this.buttonContinuar.TabIndex = 3;
            this.buttonContinuar.Text = "Salvar e continuar";
            this.buttonContinuar.UseVisualStyleBackColor = true;
            this.buttonContinuar.Click += new System.EventHandler(this.buttonContinuar_Click);
            // 
            // textBoxNomeCliente
            // 
            this.textBoxNomeCliente.Location = new System.Drawing.Point(100, 81);
            this.textBoxNomeCliente.Name = "textBoxNomeCliente";
            this.textBoxNomeCliente.Size = new System.Drawing.Size(125, 27);
            this.textBoxNomeCliente.TabIndex = 4;
            // 
            // textBoxTelefoneCliente
            // 
            this.textBoxTelefoneCliente.Location = new System.Drawing.Point(100, 139);
            this.textBoxTelefoneCliente.Name = "textBoxTelefoneCliente";
            this.textBoxTelefoneCliente.Size = new System.Drawing.Size(125, 27);
            this.textBoxTelefoneCliente.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 279);
            this.Controls.Add(this.textBoxTelefoneCliente);
            this.Controls.Add(this.textBoxNomeCliente);
            this.Controls.Add(this.buttonContinuar);
            this.Controls.Add(this.labelTelefoneCliente);
            this.Controls.Add(this.labelNomecliente);
            this.Controls.Add(this.labelTítulo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTítulo;
        private System.Windows.Forms.Label labelNomecliente;
        private System.Windows.Forms.Label labelTelefoneCliente;
        private System.Windows.Forms.Button buttonContinuar;
        private System.Windows.Forms.TextBox textBoxNomeCliente;
        private System.Windows.Forms.TextBox textBoxTelefoneCliente;
    }
}

