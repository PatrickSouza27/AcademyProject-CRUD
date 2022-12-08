namespace KittensSports.View
{
    partial class TelaUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgHistorico = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastrarTreinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rankingKittensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.dtgTreinosCadastrados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTreinosCadastrados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerenciamento Pessoal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 344);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Historico de Treinos";
            // 
            // dtgHistorico
            // 
            this.dtgHistorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHistorico.Location = new System.Drawing.Point(-1, 368);
            this.dtgHistorico.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgHistorico.Name = "dtgHistorico";
            this.dtgHistorico.RowHeadersWidth = 51;
            this.dtgHistorico.RowTemplate.Height = 25;
            this.dtgHistorico.Size = new System.Drawing.Size(390, 200);
            this.dtgHistorico.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarTreinoToolStripMenuItem,
            this.rankingKittensToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(390, 30);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastrarTreinoToolStripMenuItem
            // 
            this.cadastrarTreinoToolStripMenuItem.Name = "cadastrarTreinoToolStripMenuItem";
            this.cadastrarTreinoToolStripMenuItem.Size = new System.Drawing.Size(131, 24);
            this.cadastrarTreinoToolStripMenuItem.Text = "Cadastrar Treino";
            this.cadastrarTreinoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarTreinoToolStripMenuItem_Click);
            // 
            // rankingKittensToolStripMenuItem
            // 
            this.rankingKittensToolStripMenuItem.Name = "rankingKittensToolStripMenuItem";
            this.rankingKittensToolStripMenuItem.Size = new System.Drawing.Size(125, 24);
            this.rankingKittensToolStripMenuItem.Text = "Ranking Kittens";
            this.rankingKittensToolStripMenuItem.Click += new System.EventHandler(this.rankingKittensToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-2, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Treinos Cadastrados";
            // 
            // dtgTreinosCadastrados
            // 
            this.dtgTreinosCadastrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgTreinosCadastrados.Location = new System.Drawing.Point(-2, 177);
            this.dtgTreinosCadastrados.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtgTreinosCadastrados.Name = "dtgTreinosCadastrados";
            this.dtgTreinosCadastrados.RowHeadersWidth = 51;
            this.dtgTreinosCadastrados.RowTemplate.Height = 25;
            this.dtgTreinosCadastrados.Size = new System.Drawing.Size(391, 163);
            this.dtgTreinosCadastrados.TabIndex = 8;
            // 
            // TelaUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 677);
            this.Controls.Add(this.dtgTreinosCadastrados);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtgHistorico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "TelaUsuario";
            this.Text = "TelaCadastroTreino";
            ((System.ComponentModel.ISupportInitialize)(this.dtgHistorico)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgTreinosCadastrados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DataGridView dtgHistorico;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem cadastrarTreinoToolStripMenuItem;
        private ToolStripMenuItem rankingKittensToolStripMenuItem;
        private Label label3;
        private DataGridView dtgTreinosCadastrados;
    }
}