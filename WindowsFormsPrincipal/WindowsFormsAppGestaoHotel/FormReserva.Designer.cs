﻿namespace WindowsFormsAppGestaoHotel
{
    partial class FormReserva
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReserva));
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.comboBoxBuscarTipo = new System.Windows.Forms.ComboBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelQuartos = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonBuscarTipo = new System.Windows.Forms.Button();
            this.buttonCadastrarReserva = new System.Windows.Forms.Button();
            this.reservaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quartoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listReserva1 = new WindowsFormsAppGestaoHotel.ListReserva();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar
            // 
            this.monthCalendar.Location = new System.Drawing.Point(12, 57);
            this.monthCalendar.MaxDate = new System.DateTime(2033, 12, 31, 0, 0, 0, 0);
            this.monthCalendar.MaxSelectionCount = 1;
            this.monthCalendar.MinDate = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 3;
            this.monthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar_DateChanged);
            // 
            // comboBoxBuscarTipo
            // 
            this.comboBoxBuscarTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.comboBoxBuscarTipo.FormattingEnabled = true;
            this.comboBoxBuscarTipo.Items.AddRange(new object[] {
            "Data Check In",
            "Data Check Out",
            "Data Lançamento"});
            this.comboBoxBuscarTipo.Location = new System.Drawing.Point(168, 15);
            this.comboBoxBuscarTipo.Name = "comboBoxBuscarTipo";
            this.comboBoxBuscarTipo.Size = new System.Drawing.Size(155, 26);
            this.comboBoxBuscarTipo.TabIndex = 4;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistro.Location = new System.Drawing.Point(3, 0);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(217, 20);
            this.labelRegistro.TabIndex = 5;
            this.labelRegistro.Text = "Nenhum registro Cadastrado!";
            this.labelRegistro.Visible = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.labelRegistro);
            this.flowLayoutPanel1.Controls.Add(this.listReserva1);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(280, 57);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(772, 475);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(482, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(0, 0);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // flowLayoutPanelQuartos
            // 
            this.flowLayoutPanelQuartos.Location = new System.Drawing.Point(15, 231);
            this.flowLayoutPanelQuartos.Name = "flowLayoutPanelQuartos";
            this.flowLayoutPanelQuartos.Size = new System.Drawing.Size(216, 301);
            this.flowLayoutPanelQuartos.TabIndex = 7;
            // 
            // buttonBuscarTipo
            // 
            this.buttonBuscarTipo.BackColor = System.Drawing.SystemColors.Control;
            this.buttonBuscarTipo.FlatAppearance.BorderSize = 0;
            this.buttonBuscarTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscarTipo.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscarTipo.Image")));
            this.buttonBuscarTipo.Location = new System.Drawing.Point(329, 13);
            this.buttonBuscarTipo.MaximumSize = new System.Drawing.Size(30, 30);
            this.buttonBuscarTipo.MinimumSize = new System.Drawing.Size(30, 30);
            this.buttonBuscarTipo.Name = "buttonBuscarTipo";
            this.buttonBuscarTipo.Size = new System.Drawing.Size(30, 30);
            this.buttonBuscarTipo.TabIndex = 2;
            this.buttonBuscarTipo.UseVisualStyleBackColor = false;
            this.buttonBuscarTipo.Click += new System.EventHandler(this.buttonBuscarTipo_Click);
            // 
            // buttonCadastrarReserva
            // 
            this.buttonCadastrarReserva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(183)))), ((int)(((byte)(219)))));
            this.buttonCadastrarReserva.FlatAppearance.BorderSize = 0;
            this.buttonCadastrarReserva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCadastrarReserva.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCadastrarReserva.ForeColor = System.Drawing.Color.White;
            this.buttonCadastrarReserva.Image = ((System.Drawing.Image)(resources.GetObject("buttonCadastrarReserva.Image")));
            this.buttonCadastrarReserva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCadastrarReserva.Location = new System.Drawing.Point(12, 12);
            this.buttonCadastrarReserva.Name = "buttonCadastrarReserva";
            this.buttonCadastrarReserva.Size = new System.Drawing.Size(120, 33);
            this.buttonCadastrarReserva.TabIndex = 1;
            this.buttonCadastrarReserva.Text = "Reserva";
            this.buttonCadastrarReserva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonCadastrarReserva.UseVisualStyleBackColor = false;
            this.buttonCadastrarReserva.Click += new System.EventHandler(this.buttonCadastrarReserva_Click);
            // 
            // reservaBindingSource
            // 
            this.reservaBindingSource.DataSource = typeof(Models.Reserva);
            // 
            // quartoBindingSource
            // 
            this.quartoBindingSource.DataSource = typeof(Models.Quarto);
            // 
            // listReserva1
            // 
            this.listReserva1.BackColor = System.Drawing.Color.White;
            this.listReserva1.Location = new System.Drawing.Point(226, 3);
            this.listReserva1.Name = "listReserva1";
            this.listReserva1.Size = new System.Drawing.Size(250, 150);
            this.listReserva1.TabIndex = 0;
            // 
            // FormReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 567);
            this.Controls.Add(this.flowLayoutPanelQuartos);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.comboBoxBuscarTipo);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.buttonBuscarTipo);
            this.Controls.Add(this.buttonCadastrarReserva);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1080, 606);
            this.Name = "FormReserva";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HOTELOGIX - Reservas";
            this.Load += new System.EventHandler(this.FormReserva_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormReserva_KeyDown);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reservaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCadastrarReserva;
        private System.Windows.Forms.Button buttonBuscarTipo;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.ComboBox comboBoxBuscarTipo;
        private System.Windows.Forms.BindingSource reservaBindingSource;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelQuartos;
        private System.Windows.Forms.BindingSource quartoBindingSource;
        private ListReserva listReserva1;
    }
}