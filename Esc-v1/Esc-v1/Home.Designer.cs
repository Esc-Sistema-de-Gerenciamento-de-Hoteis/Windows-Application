namespace Esc_v1
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            administraçãoToolStripMenuItem = new ToolStripMenuItem();
            usuarioToolStripMenuItem = new ToolStripMenuItem();
            criarToolStripMenuItem = new ToolStripMenuItem();
            alterarToolStripMenuItem = new ToolStripMenuItem();
            editarToolStripMenuItem = new ToolStripMenuItem();
            excluirToolStripMenuItem = new ToolStripMenuItem();
            perfilToolStripMenuItem = new ToolStripMenuItem();
            criarToolStripMenuItem1 = new ToolStripMenuItem();
            alterarToolStripMenuItem1 = new ToolStripMenuItem();
            editarToolStripMenuItem1 = new ToolStripMenuItem();
            exToolStripMenuItem = new ToolStripMenuItem();
            quartoToolStripMenuItem = new ToolStripMenuItem();
            sobreToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, administraçãoToolStripMenuItem, sobreToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 20);
            menuToolStripMenuItem.Text = "Menu";
            // 
            // administraçãoToolStripMenuItem
            // 
            administraçãoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usuarioToolStripMenuItem, perfilToolStripMenuItem, quartoToolStripMenuItem, logoutToolStripMenuItem });
            administraçãoToolStripMenuItem.Name = "administraçãoToolStripMenuItem";
            administraçãoToolStripMenuItem.Size = new Size(96, 20);
            administraçãoToolStripMenuItem.Text = "Administração";
            // 
            // usuarioToolStripMenuItem
            // 
            usuarioToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarToolStripMenuItem, alterarToolStripMenuItem, editarToolStripMenuItem, excluirToolStripMenuItem });
            usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            usuarioToolStripMenuItem.Size = new Size(180, 22);
            usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // criarToolStripMenuItem
            // 
            criarToolStripMenuItem.Name = "criarToolStripMenuItem";
            criarToolStripMenuItem.Size = new Size(109, 22);
            criarToolStripMenuItem.Text = "Criar";
            criarToolStripMenuItem.Click += criarToolStripMenuItem_Click;
            // 
            // alterarToolStripMenuItem
            // 
            alterarToolStripMenuItem.Name = "alterarToolStripMenuItem";
            alterarToolStripMenuItem.Size = new Size(109, 22);
            alterarToolStripMenuItem.Text = "Alterar";
            // 
            // editarToolStripMenuItem
            // 
            editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            editarToolStripMenuItem.Size = new Size(109, 22);
            editarToolStripMenuItem.Text = "Editar";
            // 
            // excluirToolStripMenuItem
            // 
            excluirToolStripMenuItem.Name = "excluirToolStripMenuItem";
            excluirToolStripMenuItem.Size = new Size(109, 22);
            excluirToolStripMenuItem.Text = "Excluir";
            // 
            // perfilToolStripMenuItem
            // 
            perfilToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { criarToolStripMenuItem1, alterarToolStripMenuItem1, editarToolStripMenuItem1, exToolStripMenuItem });
            perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            perfilToolStripMenuItem.Size = new Size(180, 22);
            perfilToolStripMenuItem.Text = "Perfil";
            // 
            // criarToolStripMenuItem1
            // 
            criarToolStripMenuItem1.Name = "criarToolStripMenuItem1";
            criarToolStripMenuItem1.Size = new Size(109, 22);
            criarToolStripMenuItem1.Text = "Criar";
            // 
            // alterarToolStripMenuItem1
            // 
            alterarToolStripMenuItem1.Name = "alterarToolStripMenuItem1";
            alterarToolStripMenuItem1.Size = new Size(109, 22);
            alterarToolStripMenuItem1.Text = "Alterar";
            // 
            // editarToolStripMenuItem1
            // 
            editarToolStripMenuItem1.Name = "editarToolStripMenuItem1";
            editarToolStripMenuItem1.Size = new Size(109, 22);
            editarToolStripMenuItem1.Text = "Editar";
            // 
            // exToolStripMenuItem
            // 
            exToolStripMenuItem.Name = "exToolStripMenuItem";
            exToolStripMenuItem.Size = new Size(109, 22);
            exToolStripMenuItem.Text = "Excluir";
            // 
            // quartoToolStripMenuItem
            // 
            quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            quartoToolStripMenuItem.Size = new Size(180, 22);
            quartoToolStripMenuItem.Text = "Quarto";
            // 
            // sobreToolStripMenuItem
            // 
            sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            sobreToolStripMenuItem.Size = new Size(49, 20);
            sobreToolStripMenuItem.Text = "Sobre";
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(180, 22);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Home";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem administraçãoToolStripMenuItem;
        private ToolStripMenuItem usuarioToolStripMenuItem;
        private ToolStripMenuItem criarToolStripMenuItem;
        private ToolStripMenuItem alterarToolStripMenuItem;
        private ToolStripMenuItem editarToolStripMenuItem;
        private ToolStripMenuItem excluirToolStripMenuItem;
        private ToolStripMenuItem perfilToolStripMenuItem;
        private ToolStripMenuItem criarToolStripMenuItem1;
        private ToolStripMenuItem alterarToolStripMenuItem1;
        private ToolStripMenuItem editarToolStripMenuItem1;
        private ToolStripMenuItem exToolStripMenuItem;
        private ToolStripMenuItem quartoToolStripMenuItem;
        private ToolStripMenuItem sobreToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
    }
}