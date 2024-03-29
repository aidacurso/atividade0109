﻿
namespace pizza
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
            this.dataInformacoes = new System.Windows.Forms.DataGridView();
            this.dataPedido = new System.Windows.Forms.DataGridView();
            this.colunaIdentificadorPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColunaValorTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonCliente = new System.Windows.Forms.Button();
            this.buttonPedido = new System.Windows.Forms.Button();
            this.colunaIdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTelefoneCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataInformacoes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).BeginInit();
            this.SuspendLayout();
            // 
            // dataInformacoes
            // 
            this.dataInformacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataInformacoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIdCliente,
            this.colunaNomeCliente,
            this.colunaTelefoneCliente});
            this.dataInformacoes.Location = new System.Drawing.Point(10, 9);
            this.dataInformacoes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataInformacoes.Name = "dataInformacoes";
            this.dataInformacoes.RowHeadersWidth = 51;
            this.dataInformacoes.RowTemplate.Height = 29;
            this.dataInformacoes.Size = new System.Drawing.Size(384, 320);
            this.dataInformacoes.TabIndex = 0;
            // 
            // dataPedido
            // 
            this.dataPedido.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataPedido.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIdentificadorPedido,
            this.colunaDescricao,
            this.ColunaValorTotal});
            this.dataPedido.Location = new System.Drawing.Point(612, 9);
            this.dataPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataPedido.Name = "dataPedido";
            this.dataPedido.RowHeadersWidth = 51;
            this.dataPedido.RowTemplate.Height = 29;
            this.dataPedido.Size = new System.Drawing.Size(389, 320);
            this.dataPedido.TabIndex = 1;
            // 
            // colunaIdentificadorPedido
            // 
            this.colunaIdentificadorPedido.HeaderText = "Identificador do pedido";
            this.colunaIdentificadorPedido.MinimumWidth = 6;
            this.colunaIdentificadorPedido.Name = "colunaIdentificadorPedido";
            this.colunaIdentificadorPedido.Width = 125;
            // 
            // colunaDescricao
            // 
            this.colunaDescricao.HeaderText = "Descrição do pedido";
            this.colunaDescricao.MinimumWidth = 6;
            this.colunaDescricao.Name = "colunaDescricao";
            this.colunaDescricao.Width = 125;
            // 
            // ColunaValorTotal
            // 
            this.ColunaValorTotal.HeaderText = "Valor total do pedido";
            this.ColunaValorTotal.MinimumWidth = 6;
            this.ColunaValorTotal.Name = "ColunaValorTotal";
            this.ColunaValorTotal.Width = 125;
            // 
            // buttonCliente
            // 
            this.buttonCliente.Location = new System.Drawing.Point(102, 334);
            this.buttonCliente.Name = "buttonCliente";
            this.buttonCliente.Size = new System.Drawing.Size(184, 23);
            this.buttonCliente.TabIndex = 2;
            this.buttonCliente.Text = "clique para excluir clientes";
            this.buttonCliente.UseVisualStyleBackColor = true;
            this.buttonCliente.Click += new System.EventHandler(this.buttonCliente_Click);
            // 
            // buttonPedido
            // 
            this.buttonPedido.Location = new System.Drawing.Point(733, 334);
            this.buttonPedido.Name = "buttonPedido";
            this.buttonPedido.Size = new System.Drawing.Size(160, 23);
            this.buttonPedido.TabIndex = 3;
            this.buttonPedido.Text = "clique para excluir pedidos";
            this.buttonPedido.UseVisualStyleBackColor = true;
            this.buttonPedido.Click += new System.EventHandler(this.buttonPedido_Click);
            // 
            // colunaIdCliente
            // 
            this.colunaIdCliente.HeaderText = "Identificador do cliente";
            this.colunaIdCliente.MinimumWidth = 6;
            this.colunaIdCliente.Name = "colunaIdCliente";
            this.colunaIdCliente.Width = 125;
            // 
            // colunaNomeCliente
            // 
            this.colunaNomeCliente.HeaderText = "Nome do cliente";
            this.colunaNomeCliente.MinimumWidth = 6;
            this.colunaNomeCliente.Name = "colunaNomeCliente";
            this.colunaNomeCliente.Width = 125;
            // 
            // colunaTelefoneCliente
            // 
            this.colunaTelefoneCliente.HeaderText = "Telefone do cliente";
            this.colunaTelefoneCliente.MinimumWidth = 6;
            this.colunaTelefoneCliente.Name = "colunaTelefoneCliente";
            this.colunaTelefoneCliente.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 395);
            this.Controls.Add(this.buttonPedido);
            this.Controls.Add(this.buttonCliente);
            this.Controls.Add(this.dataPedido);
            this.Controls.Add(this.dataInformacoes);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataInformacoes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataPedido)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataInformacoes;
        private System.Windows.Forms.DataGridView dataPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdentificadorPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIdentificadorPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColunaValorTotal;
        private System.Windows.Forms.Button buttonCliente;
        private System.Windows.Forms.Button buttonPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaIdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaNomeCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colunaTelefoneCliente;
    }
}