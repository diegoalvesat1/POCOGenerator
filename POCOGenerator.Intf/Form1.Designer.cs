namespace POCOGenerator.Intf
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.connectToDatabase = new System.Windows.Forms.Button();
            this.tables = new System.Windows.Forms.CheckedListBox();
            this.regex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.selectAll = new System.Windows.Forms.LinkLabel();
            this.selectNone = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.connectionString = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.sistema = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.Tabela = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectToDatabase
            // 
            this.connectToDatabase.Location = new System.Drawing.Point(13, 13);
            this.connectToDatabase.Name = "connectToDatabase";
            this.connectToDatabase.Size = new System.Drawing.Size(149, 23);
            this.connectToDatabase.TabIndex = 0;
            this.connectToDatabase.Text = "&Conectar Banco de Dados";
            this.connectToDatabase.UseVisualStyleBackColor = true;
            this.connectToDatabase.Click += new System.EventHandler(this.connectToDatabase_Click);
            // 
            // tables
            // 
            this.tables.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tables.CheckOnClick = true;
            this.tables.FormattingEnabled = true;
            this.tables.Location = new System.Drawing.Point(13, 43);
            this.tables.Name = "tables";
            this.tables.Size = new System.Drawing.Size(469, 394);
            this.tables.TabIndex = 3;
            this.tables.SelectedIndexChanged += new System.EventHandler(this.tables_SelectedIndexChanged);
            // 
            // regex
            // 
            this.regex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regex.CausesValidation = false;
            this.regex.Location = new System.Drawing.Point(13, 511);
            this.regex.MaxLength = 65535;
            this.regex.Name = "regex";
            this.regex.ReadOnly = true;
            this.regex.Size = new System.Drawing.Size(469, 20);
            this.regex.TabIndex = 5;
            this.regex.Text = "TableFilterInclude = null;";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 495);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Regex (copiado para área de transferência automaticamente)";
            // 
            // selectAll
            // 
            this.selectAll.AutoSize = true;
            this.selectAll.Location = new System.Drawing.Point(312, 27);
            this.selectAll.Name = "selectAll";
            this.selectAll.Size = new System.Drawing.Size(85, 13);
            this.selectAll.TabIndex = 1;
            this.selectAll.TabStop = true;
            this.selectAll.Text = "Selecionar Tudo";
            this.selectAll.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectAll_LinkClicked);
            // 
            // selectNone
            // 
            this.selectNone.AutoSize = true;
            this.selectNone.Location = new System.Drawing.Point(399, 27);
            this.selectNone.Name = "selectNone";
            this.selectNone.Size = new System.Drawing.Size(86, 13);
            this.selectNone.TabIndex = 2;
            this.selectNone.TabStop = true;
            this.selectNone.Text = "Desmarcar Tudo";
            this.selectNone.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.selectNone_LinkClicked);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 543);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Connection string";
            // 
            // connectionString
            // 
            this.connectionString.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionString.CausesValidation = false;
            this.connectionString.Location = new System.Drawing.Point(12, 559);
            this.connectionString.MaxLength = 65535;
            this.connectionString.Name = "connectionString";
            this.connectionString.ReadOnly = true;
            this.connectionString.Size = new System.Drawing.Size(469, 20);
            this.connectionString.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 448);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Prefixo da Tabela";
            // 
            // sistema
            // 
            this.sistema.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sistema.CausesValidation = false;
            this.sistema.Location = new System.Drawing.Point(13, 464);
            this.sistema.MaxLength = 65535;
            this.sistema.Name = "sistema";
            this.sistema.Size = new System.Drawing.Size(149, 20);
            this.sistema.TabIndex = 9;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(409, 463);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 23);
            this.btnAtualizar.TabIndex = 10;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.BtnAtualizar_Click);
            // 
            // Tabela
            // 
            this.Tabela.Location = new System.Drawing.Point(169, 464);
            this.Tabela.Name = "Tabela";
            this.Tabela.Size = new System.Drawing.Size(234, 20);
            this.Tabela.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(167, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Nome da Tabela";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 592);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tabela);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sistema);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectionString);
            this.Controls.Add(this.selectNone);
            this.Controls.Add(this.selectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regex);
            this.Controls.Add(this.tables);
            this.Controls.Add(this.connectToDatabase);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "POCO Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectToDatabase;
        private System.Windows.Forms.CheckedListBox tables;
        private System.Windows.Forms.TextBox regex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel selectAll;
        private System.Windows.Forms.LinkLabel selectNone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox connectionString;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sistema;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.TextBox Tabela;
        private System.Windows.Forms.Label label4;
    }
}

