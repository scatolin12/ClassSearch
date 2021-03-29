namespace WindowsFormsApp3
{
    partial class ClassSearch
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
            this.btn_carregarclasse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_classe = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Characteristic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toignore = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mainmaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_carregarclasse
            // 
            this.btn_carregarclasse.Location = new System.Drawing.Point(12, 51);
            this.btn_carregarclasse.Name = "btn_carregarclasse";
            this.btn_carregarclasse.Size = new System.Drawing.Size(169, 23);
            this.btn_carregarclasse.TabIndex = 2;
            this.btn_carregarclasse.Text = "Load Class";
            this.btn_carregarclasse.UseVisualStyleBackColor = true;
            this.btn_carregarclasse.Click += new System.EventHandler(this.btn_carregarclasse_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Class";
            // 
            // tb_classe
            // 
            this.tb_classe.Location = new System.Drawing.Point(12, 25);
            this.tb_classe.Name = "tb_classe";
            this.tb_classe.Size = new System.Drawing.Size(169, 20);
            this.tb_classe.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Characteristic,
            this.Value,
            this.toignore});
            this.dataGridView1.Location = new System.Drawing.Point(12, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(533, 499);
            this.dataGridView1.TabIndex = 4;
            // 
            // Characteristic
            // 
            this.Characteristic.HeaderText = "Characteristic";
            this.Characteristic.Name = "Characteristic";
            this.Characteristic.ReadOnly = true;
            this.Characteristic.Width = 280;
            // 
            // Value
            // 
            this.Value.HeaderText = "Value";
            this.Value.Name = "Value";
            this.Value.Width = 130;
            // 
            // toignore
            // 
            this.toignore.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.toignore.HeaderText = "To Ignore";
            this.toignore.Name = "toignore";
            this.toignore.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.toignore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.toignore.Width = 78;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 591);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Status:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mainmaterial,
            this.Result});
            this.dataGridView2.Location = new System.Drawing.Point(607, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(405, 499);
            this.dataGridView2.TabIndex = 6;
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // mainmaterial
            // 
            this.mainmaterial.HeaderText = "Material Model";
            this.mainmaterial.MaxInputLength = 8;
            this.mainmaterial.Name = "mainmaterial";
            // 
            // Result
            // 
            this.Result.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Result.DividerWidth = 8;
            this.Result.HeaderText = "Result";
            this.Result.Name = "Result";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(55, 591);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 13);
            this.lbl_status.TabIndex = 8;
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(987, 9);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(25, 26);
            this.btn_help.TabIndex = 9;
            this.btn_help.Text = "?";
            this.btn_help.UseVisualStyleBackColor = true;
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(937, 51);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 10;
            this.btn_clear.Text = "Clear All";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // ClassSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 613);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_classe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_carregarclasse);
            this.Name = "ClassSearch";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Class Search";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_carregarclasse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_classe;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.DataGridViewTextBoxColumn Characteristic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewCheckBoxColumn toignore;
        private System.Windows.Forms.DataGridViewTextBoxColumn mainmaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Result;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_clear;
    }
}

