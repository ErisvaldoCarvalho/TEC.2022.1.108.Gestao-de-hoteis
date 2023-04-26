﻿namespace WindowsFormsPrincipal1
{
    partial class FormPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoFuncionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.diariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoFuncionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quartoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.listBoxNomeUsuario = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(130)))), ((int)(((byte)(225)))));
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.78182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.consultaToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(882, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.grupoFuncionarioToolStripMenuItem1,
            this.quartoToolStripMenuItem1});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(107, 28);
            this.cadastroToolStripMenuItem.Text = "Cadastros";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(301, 28);
            this.clienteToolStripMenuItem.Text = "Cliente";
            this.clienteToolStripMenuItem.Click += new System.EventHandler(this.clienteToolStripMenuItem_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(301, 28);
            this.funcionarioToolStripMenuItem.Text = "Funcionário";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // grupoFuncionarioToolStripMenuItem1
            // 
            this.grupoFuncionarioToolStripMenuItem1.Name = "grupoFuncionarioToolStripMenuItem1";
            this.grupoFuncionarioToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.grupoFuncionarioToolStripMenuItem1.Size = new System.Drawing.Size(301, 28);
            this.grupoFuncionarioToolStripMenuItem1.Text = "Grupo funcionário";
            this.grupoFuncionarioToolStripMenuItem1.Click += new System.EventHandler(this.grupoFuncionarioToolStripMenuItem1_Click);
            // 
            // quartoToolStripMenuItem1
            // 
            this.quartoToolStripMenuItem1.Name = "quartoToolStripMenuItem1";
            this.quartoToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.quartoToolStripMenuItem1.Size = new System.Drawing.Size(301, 28);
            this.quartoToolStripMenuItem1.Text = "Quarto";
            this.quartoToolStripMenuItem1.Click += new System.EventHandler(this.quartoToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.consultaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem1,
            this.diariaToolStripMenuItem,
            this.buscarFuncionarioToolStripMenuItem,
            this.grupoFuncionarioToolStripMenuItem,
            this.quartoToolStripMenuItem});
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(106, 28);
            this.consultaToolStripMenuItem.Text = "Consultas";
            // 
            // clienteToolStripMenuItem1
            // 
            this.clienteToolStripMenuItem1.Name = "clienteToolStripMenuItem1";
            this.clienteToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
            this.clienteToolStripMenuItem1.Size = new System.Drawing.Size(355, 28);
            this.clienteToolStripMenuItem1.Text = "Cliente";
            this.clienteToolStripMenuItem1.Click += new System.EventHandler(this.clienteToolStripMenuItem1_Click_1);
            // 
            // diariaToolStripMenuItem
            // 
            this.diariaToolStripMenuItem.Name = "diariaToolStripMenuItem";
            this.diariaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.diariaToolStripMenuItem.Size = new System.Drawing.Size(355, 28);
            this.diariaToolStripMenuItem.Text = "Diária";
            this.diariaToolStripMenuItem.Click += new System.EventHandler(this.diariaToolStripMenuItem_Click);
            // 
            // buscarFuncionarioToolStripMenuItem
            // 
            this.buscarFuncionarioToolStripMenuItem.Name = "buscarFuncionarioToolStripMenuItem";
            this.buscarFuncionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
            this.buscarFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(355, 28);
            this.buscarFuncionarioToolStripMenuItem.Text = "Funcionário";
            this.buscarFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.buscarFuncionarioToolStripMenuItem_Click);
            // 
            // grupoFuncionarioToolStripMenuItem
            // 
            this.grupoFuncionarioToolStripMenuItem.Name = "grupoFuncionarioToolStripMenuItem";
            this.grupoFuncionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.G)));
            this.grupoFuncionarioToolStripMenuItem.Size = new System.Drawing.Size(355, 28);
            this.grupoFuncionarioToolStripMenuItem.Text = "Grupo Funcionário";
            this.grupoFuncionarioToolStripMenuItem.Click += new System.EventHandler(this.grupoFuncionarioToolStripMenuItem_Click);
            // 
            // quartoToolStripMenuItem
            // 
            this.quartoToolStripMenuItem.Name = "quartoToolStripMenuItem";
            this.quartoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Q)));
            this.quartoToolStripMenuItem.Size = new System.Drawing.Size(355, 28);
            this.quartoToolStripMenuItem.Text = "Quarto";
            this.quartoToolStripMenuItem.Click += new System.EventHandler(this.quartoToolStripMenuItem_Click);
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(75, 28);
            this.sobreToolStripMenuItem.Text = "Sobre";
            this.sobreToolStripMenuItem.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(265, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(799, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(61, 63);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // buttonSair
            // 
            this.buttonSair.Location = new System.Drawing.Point(799, 150);
            this.buttonSair.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(61, 26);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = true;
            this.buttonSair.Visible = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // listBoxNomeUsuario
            // 
            this.listBoxNomeUsuario.FormattingEnabled = true;
            this.listBoxNomeUsuario.Location = new System.Drawing.Point(791, 102);
            this.listBoxNomeUsuario.Name = "listBoxNomeUsuario";
            this.listBoxNomeUsuario.Size = new System.Drawing.Size(79, 43);
            this.listBoxNomeUsuario.TabIndex = 7;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(234)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(882, 556);
            this.Controls.Add(this.listBoxNomeUsuario);
            this.Controls.Add(this.buttonSair);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(900, 600);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Gestão de Hotéis";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroGrupoDeFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaFuncionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultagrupoDeFuncionarioToolStripMenuItem1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buscarFuncionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoFuncionarioToolStripMenuItem;

       // private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoFuncionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quartoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diariaToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.ListBox listBoxNomeUsuario;
    }
}