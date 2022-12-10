namespace KittensSports.View
{
    partial class TelaCadastroUsuario
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
            this.ttbNome = new System.Windows.Forms.TextBox();
            this.ttbEmail = new System.Windows.Forms.TextBox();
            this.ttbUsername = new System.Windows.Forms.TextBox();
            this.ttbSenha = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ttbNome
            // 
            this.ttbNome.Location = new System.Drawing.Point(14, 139);
            this.ttbNome.Name = "ttbNome";
            this.ttbNome.Size = new System.Drawing.Size(561, 23);
            this.ttbNome.TabIndex = 0;
            // 
            // ttbEmail
            // 
            this.ttbEmail.Location = new System.Drawing.Point(14, 206);
            this.ttbEmail.Name = "ttbEmail";
            this.ttbEmail.Size = new System.Drawing.Size(561, 23);
            this.ttbEmail.TabIndex = 1;
            // 
            // ttbUsername
            // 
            this.ttbUsername.Location = new System.Drawing.Point(14, 286);
            this.ttbUsername.Name = "ttbUsername";
            this.ttbUsername.Size = new System.Drawing.Size(561, 23);
            this.ttbUsername.TabIndex = 2;
            // 
            // ttbSenha
            // 
            this.ttbSenha.Location = new System.Drawing.Point(12, 355);
            this.ttbSenha.Name = "ttbSenha";
            this.ttbSenha.Size = new System.Drawing.Size(563, 23);
            this.ttbSenha.TabIndex = 3;
            this.ttbSenha.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "Cadastro de Usuário";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nome Completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Username";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(264, 337);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Senha";
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(389, 403);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(72, 23);
            this.btnVer.TabIndex = 9;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(500, 403);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 10;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // TelaCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 466);
            this.Controls.Add(this.btnGravar);
            this.Controls.Add(this.btnVer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ttbSenha);
            this.Controls.Add(this.ttbUsername);
            this.Controls.Add(this.ttbEmail);
            this.Controls.Add(this.ttbNome);
            this.Name = "TelaCadastroUsuario";
            this.Text = "TelaCadastroUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ttbNome;
        private TextBox ttbEmail;
        private TextBox ttbUsername;
        private TextBox ttbSenha;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnVer;
        private Button btnGravar;
    }
}