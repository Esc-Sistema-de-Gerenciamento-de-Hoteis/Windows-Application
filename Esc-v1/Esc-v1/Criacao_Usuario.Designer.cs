namespace Esc_v1
{
    partial class Criacao_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Criacao_Usuario));
            label1 = new Label();
            EmailTxt = new TextBox();
            NomeTxt = new TextBox();
            label2 = new Label();
            PerfilTxt = new TextBox();
            label3 = new Label();
            PasswordTxt = new TextBox();
            label4 = new Label();
            ConfirmaPasswordTxt = new TextBox();
            label5 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 36);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 5;
            label1.Text = "E-mail";
            // 
            // EmailTxt
            // 
            EmailTxt.Location = new Point(70, 33);
            EmailTxt.Name = "EmailTxt";
            EmailTxt.Size = new Size(226, 23);
            EmailTxt.TabIndex = 0;
            // 
            // NomeTxt
            // 
            NomeTxt.Location = new Point(70, 62);
            NomeTxt.Name = "NomeTxt";
            NomeTxt.Size = new Size(201, 23);
            NomeTxt.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 65);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // PerfilTxt
            // 
            PerfilTxt.Location = new Point(77, 32);
            PerfilTxt.Name = "PerfilTxt";
            PerfilTxt.Size = new Size(147, 23);
            PerfilTxt.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 35);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 3;
            label3.Text = "Perfil";
            // 
            // PasswordTxt
            // 
            PasswordTxt.Location = new Point(77, 61);
            PasswordTxt.Name = "PasswordTxt";
            PasswordTxt.Size = new Size(147, 23);
            PasswordTxt.TabIndex = 4;
            PasswordTxt.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(11, 64);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 6;
            label4.Text = "Senha";
            // 
            // ConfirmaPasswordTxt
            // 
            ConfirmaPasswordTxt.Location = new Point(77, 90);
            ConfirmaPasswordTxt.Name = "ConfirmaPasswordTxt";
            ConfirmaPasswordTxt.Size = new Size(147, 23);
            ConfirmaPasswordTxt.TabIndex = 5;
            ConfirmaPasswordTxt.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(11, 93);
            label5.Name = "label5";
            label5.Size = new Size(61, 15);
            label5.TabIndex = 8;
            label5.Text = "Confirmar";
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(19, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(326, 87);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dados Pessoais";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(PerfilTxt);
            groupBox2.Controls.Add(ConfirmaPasswordTxt);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(PasswordTxt);
            groupBox2.Location = new Point(19, 115);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(326, 128);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Dados Sistemicos";
            // 
            // button1
            // 
            button1.Location = new Point(19, 249);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Salvar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(96, 249);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 7;
            button2.Text = "Limpar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Criacao_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(366, 287);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(NomeTxt);
            Controls.Add(label2);
            Controls.Add(EmailTxt);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Criacao_Usuario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrado de Usuário";
            Load += Criacao_Usuario_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox EmailTxt;
        private TextBox NomeTxt;
        private Label label2;
        private TextBox PerfilTxt;
        private Label label3;
        private TextBox PasswordTxt;
        private Label label4;
        private TextBox ConfirmaPasswordTxt;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
    }
}