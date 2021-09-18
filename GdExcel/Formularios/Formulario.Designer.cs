
namespace GdExcel
{
    partial class Formulario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_generate = new System.Windows.Forms.Button();
            this.label_logo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_filter = new System.Windows.Forms.Button();
            this.data_fim = new System.Windows.Forms.DateTimePicker();
            this.label_data = new System.Windows.Forms.Label();
            this.data_inicio = new System.Windows.Forms.DateTimePicker();
            this.filter_Check = new System.Windows.Forms.CheckBox();
            this.data_view = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CLIENTE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TELEFONE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DATA_CRIACAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GASTO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.panel1.Controls.Add(this.btn_generate);
            this.panel1.Controls.Add(this.label_logo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(638, 33);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(150, 39);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Gerar";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.btn_generate_Click);
            // 
            // label_logo
            // 
            this.label_logo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_logo.Location = new System.Drawing.Point(12, 33);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(315, 39);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "GDExcel Manager";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(189)))), ((int)(((byte)(198)))));
            this.panel2.Controls.Add(this.btn_filter);
            this.panel2.Controls.Add(this.data_fim);
            this.panel2.Controls.Add(this.label_data);
            this.panel2.Controls.Add(this.data_inicio);
            this.panel2.Controls.Add(this.filter_Check);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 100);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 2;
            // 
            // btn_filter
            // 
            this.btn_filter.Location = new System.Drawing.Point(638, 3);
            this.btn_filter.Name = "btn_filter";
            this.btn_filter.Size = new System.Drawing.Size(150, 23);
            this.btn_filter.TabIndex = 2;
            this.btn_filter.Text = "Atualizar";
            this.btn_filter.UseVisualStyleBackColor = true;
            this.btn_filter.Click += new System.EventHandler(this.btn_filter_Click);
            // 
            // data_fim
            // 
            this.data_fim.Location = new System.Drawing.Point(352, 4);
            this.data_fim.Name = "data_fim";
            this.data_fim.Size = new System.Drawing.Size(200, 20);
            this.data_fim.TabIndex = 3;
            this.data_fim.Visible = false;
            // 
            // label_data
            // 
            this.label_data.AutoSize = true;
            this.label_data.Location = new System.Drawing.Point(333, 8);
            this.label_data.Name = "label_data";
            this.label_data.Size = new System.Drawing.Size(13, 13);
            this.label_data.TabIndex = 2;
            this.label_data.Text = "a";
            this.label_data.Visible = false;
            // 
            // data_inicio
            // 
            this.data_inicio.Location = new System.Drawing.Point(127, 4);
            this.data_inicio.Name = "data_inicio";
            this.data_inicio.Size = new System.Drawing.Size(200, 20);
            this.data_inicio.TabIndex = 1;
            this.data_inicio.Visible = false;
            // 
            // filter_Check
            // 
            this.filter_Check.AutoSize = true;
            this.filter_Check.Location = new System.Drawing.Point(19, 7);
            this.filter_Check.Name = "filter_Check";
            this.filter_Check.Size = new System.Drawing.Size(93, 17);
            this.filter_Check.TabIndex = 0;
            this.filter_Check.Text = "Filtro Por Data";
            this.filter_Check.UseVisualStyleBackColor = true;
            this.filter_Check.CheckedChanged += new System.EventHandler(this.filter_Check_CheckedChanged);
            // 
            // data_view
            // 
            this.data_view.AllowUserToAddRows = false;
            this.data_view.AllowUserToDeleteRows = false;
            this.data_view.AllowUserToResizeColumns = false;
            this.data_view.AllowUserToResizeRows = false;
            this.data_view.BackgroundColor = System.Drawing.Color.White;
            this.data_view.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_view.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.CLIENTE,
            this.TELEFONE,
            this.DATA_CRIACAO,
            this.GASTO});
            this.data_view.EnableHeadersVisualStyles = false;
            this.data_view.GridColor = System.Drawing.Color.White;
            this.data_view.Location = new System.Drawing.Point(19, 137);
            this.data_view.MultiSelect = false;
            this.data_view.Name = "data_view";
            this.data_view.ReadOnly = true;
            this.data_view.RowHeadersVisible = false;
            this.data_view.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.data_view.ShowEditingIcon = false;
            this.data_view.Size = new System.Drawing.Size(769, 301);
            this.data_view.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "id";
            this.ID.FillWeight = 3.826432F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 34;
            // 
            // CLIENTE
            // 
            this.CLIENTE.DataPropertyName = "nome";
            this.CLIENTE.FillWeight = 25F;
            this.CLIENTE.HeaderText = "CLIENTE";
            this.CLIENTE.Name = "CLIENTE";
            this.CLIENTE.ReadOnly = true;
            this.CLIENTE.Width = 220;
            // 
            // TELEFONE
            // 
            this.TELEFONE.DataPropertyName = "telefone";
            this.TELEFONE.FillWeight = 25F;
            this.TELEFONE.HeaderText = "TELEFONE";
            this.TELEFONE.Name = "TELEFONE";
            this.TELEFONE.ReadOnly = true;
            this.TELEFONE.Width = 221;
            // 
            // DATA_CRIACAO
            // 
            this.DATA_CRIACAO.DataPropertyName = "DATE_FORMAT(criacao,\'%d/%m/%Y\')";
            this.DATA_CRIACAO.FillWeight = 25F;
            this.DATA_CRIACAO.HeaderText = "DATA DE CRIAÇÃO";
            this.DATA_CRIACAO.Name = "DATA_CRIACAO";
            this.DATA_CRIACAO.ReadOnly = true;
            this.DATA_CRIACAO.Width = 220;
            // 
            // GASTO
            // 
            this.GASTO.DataPropertyName = "gastos";
            this.GASTO.FillWeight = 8F;
            this.GASTO.HeaderText = "TOTAL GASTO";
            this.GASTO.Name = "GASTO";
            this.GASTO.ReadOnly = true;
            this.GASTO.Width = 71;
            // 
            // Formulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(150)))), ((int)(((byte)(143)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.data_view);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Formulario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GDExcel";
            this.Load += new System.EventHandler(this.Formulario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_view)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker data_fim;
        private System.Windows.Forms.Label label_data;
        private System.Windows.Forms.DateTimePicker data_inicio;
        private System.Windows.Forms.CheckBox filter_Check;
        private System.Windows.Forms.Button btn_filter;
        private System.Windows.Forms.DataGridView data_view;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CLIENTE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TELEFONE;
        private System.Windows.Forms.DataGridViewTextBoxColumn DATA_CRIACAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn GASTO;
    }
}

