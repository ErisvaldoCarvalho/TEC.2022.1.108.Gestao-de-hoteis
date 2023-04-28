﻿namespace WindowsFormsAppGestaoHotel
{
    partial class FormBuscarDiaria
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
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label data_EntradaLabel;
            System.Windows.Forms.Label id_clienteLabel;
            System.Windows.Forms.Label id_funcionarioLabel;
            System.Windows.Forms.Label numeroLabel;
            System.Windows.Forms.Label descricaoLabel;
            System.Windows.Forms.Label valor_DiariaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscarDiaria));
            this.radioButtonDT_EN = new System.Windows.Forms.RadioButton();
            this.radioButtonNome = new System.Windows.Forms.RadioButton();
            this.radioButtonCPF = new System.Windows.Forms.RadioButton();
            this.textBoxDt_En = new System.Windows.Forms.TextBox();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.quartosDataGridView = new System.Windows.Forms.DataGridView();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.data_EntradaTextBox = new System.Windows.Forms.TextBox();
            this.id_clienteTextBox = new System.Windows.Forms.TextBox();
            this.id_funcionarioTextBox = new System.Windows.Forms.TextBox();
            this.numeroTextBox = new System.Windows.Forms.TextBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.valor_DiariaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.diariaDataGridView = new System.Windows.Forms.DataGridView();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diariaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonExcluirQuarto = new System.Windows.Forms.Button();
            this.buttonADCquarto = new System.Windows.Forms.Button();
            this.buttonExcluirDiaria = new System.Windows.Forms.Button();
            this.buttonAlterar = new System.Windows.Forms.Button();
            this.buttonADCDiaria = new System.Windows.Forms.Button();
            this.quartosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            data_EntradaLabel = new System.Windows.Forms.Label();
            id_clienteLabel = new System.Windows.Forms.Label();
            id_funcionarioLabel = new System.Windows.Forms.Label();
            numeroLabel = new System.Windows.Forms.Label();
            descricaoLabel = new System.Windows.Forms.Label();
            valor_DiariaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.quartosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(36, 368);
            idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(43, 13);
            idLabel.TabIndex = 8;
            idLabel.Text = "Código:";
            // 
            // data_EntradaLabel
            // 
            data_EntradaLabel.AutoSize = true;
            data_EntradaLabel.Location = new System.Drawing.Point(12, 416);
            data_EntradaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            data_EntradaLabel.Name = "data_EntradaLabel";
            data_EntradaLabel.Size = new System.Drawing.Size(73, 13);
            data_EntradaLabel.TabIndex = 10;
            data_EntradaLabel.Text = "Data Entrada:";
            // 
            // id_clienteLabel
            // 
            id_clienteLabel.AutoSize = true;
            id_clienteLabel.Location = new System.Drawing.Point(38, 391);
            id_clienteLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_clienteLabel.Name = "id_clienteLabel";
            id_clienteLabel.Size = new System.Drawing.Size(42, 13);
            id_clienteLabel.TabIndex = 12;
            id_clienteLabel.Text = "Cliente:";
            // 
            // id_funcionarioLabel
            // 
            id_funcionarioLabel.AutoSize = true;
            id_funcionarioLabel.Location = new System.Drawing.Point(163, 393);
            id_funcionarioLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            id_funcionarioLabel.Name = "id_funcionarioLabel";
            id_funcionarioLabel.Size = new System.Drawing.Size(65, 13);
            id_funcionarioLabel.TabIndex = 14;
            id_funcionarioLabel.Text = "Funcionário:";
            // 
            // numeroLabel
            // 
            numeroLabel.AutoSize = true;
            numeroLabel.Location = new System.Drawing.Point(609, 363);
            numeroLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            numeroLabel.Name = "numeroLabel";
            numeroLabel.Size = new System.Drawing.Size(47, 13);
            numeroLabel.TabIndex = 16;
            numeroLabel.Text = "Número:";
            // 
            // descricaoLabel
            // 
            descricaoLabel.AutoSize = true;
            descricaoLabel.Location = new System.Drawing.Point(598, 389);
            descricaoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            descricaoLabel.Name = "descricaoLabel";
            descricaoLabel.Size = new System.Drawing.Size(58, 13);
            descricaoLabel.TabIndex = 18;
            descricaoLabel.Text = "Descrição:";
            // 
            // valor_DiariaLabel
            // 
            valor_DiariaLabel.AutoSize = true;
            valor_DiariaLabel.Location = new System.Drawing.Point(580, 414);
            valor_DiariaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            valor_DiariaLabel.Name = "valor_DiariaLabel";
            valor_DiariaLabel.Size = new System.Drawing.Size(79, 13);
            valor_DiariaLabel.TabIndex = 20;
            valor_DiariaLabel.Text = "Valor da Diária:";
            // 
            // radioButtonDT_EN
            // 
            this.radioButtonDT_EN.AutoSize = true;
            this.radioButtonDT_EN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDT_EN.Location = new System.Drawing.Point(32, 10);
            this.radioButtonDT_EN.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonDT_EN.Name = "radioButtonDT_EN";
            this.radioButtonDT_EN.Size = new System.Drawing.Size(132, 22);
            this.radioButtonDT_EN.TabIndex = 0;
            this.radioButtonDT_EN.TabStop = true;
            this.radioButtonDT_EN.Text = "Data da Entrada";
            this.radioButtonDT_EN.UseVisualStyleBackColor = true;
            // 
            // radioButtonNome
            // 
            this.radioButtonNome.AutoSize = true;
            this.radioButtonNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNome.Location = new System.Drawing.Point(32, 72);
            this.radioButtonNome.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonNome.Name = "radioButtonNome";
            this.radioButtonNome.Size = new System.Drawing.Size(67, 22);
            this.radioButtonNome.TabIndex = 0;
            this.radioButtonNome.TabStop = true;
            this.radioButtonNome.Text = "Nome";
            this.radioButtonNome.UseVisualStyleBackColor = true;
            // 
            // radioButtonCPF
            // 
            this.radioButtonCPF.AutoSize = true;
            this.radioButtonCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCPF.Location = new System.Drawing.Point(124, 72);
            this.radioButtonCPF.Margin = new System.Windows.Forms.Padding(2);
            this.radioButtonCPF.Name = "radioButtonCPF";
            this.radioButtonCPF.Size = new System.Drawing.Size(56, 22);
            this.radioButtonCPF.TabIndex = 0;
            this.radioButtonCPF.TabStop = true;
            this.radioButtonCPF.Text = "CPF";
            this.radioButtonCPF.UseVisualStyleBackColor = true;
            // 
            // textBoxDt_En
            // 
            this.textBoxDt_En.Location = new System.Drawing.Point(32, 41);
            this.textBoxDt_En.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxDt_En.Name = "textBoxDt_En";
            this.textBoxDt_En.Size = new System.Drawing.Size(170, 20);
            this.textBoxDt_En.TabIndex = 1;
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(32, 105);
            this.textBoxBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(170, 20);
            this.textBoxBuscar.TabIndex = 2;
            // 
            // quartosDataGridView
            // 
            this.quartosDataGridView.AllowUserToAddRows = false;
            this.quartosDataGridView.AllowUserToDeleteRows = false;
            this.quartosDataGridView.AllowUserToOrderColumns = true;
            this.quartosDataGridView.AutoGenerateColumns = false;
            this.quartosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.quartosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.quartosDataGridView.DataSource = this.quartosBindingSource;
            this.quartosDataGridView.Location = new System.Drawing.Point(598, 162);
            this.quartosDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.quartosDataGridView.Name = "quartosDataGridView";
            this.quartosDataGridView.ReadOnly = true;
            this.quartosDataGridView.RowHeadersWidth = 51;
            this.quartosDataGridView.RowTemplate.Height = 24;
            this.quartosDataGridView.Size = new System.Drawing.Size(428, 145);
            this.quartosDataGridView.TabIndex = 7;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id", true));
            this.idTextBox.Location = new System.Drawing.Point(83, 368);
            this.idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(76, 20);
            this.idTextBox.TabIndex = 9;
            // 
            // data_EntradaTextBox
            // 
            this.data_EntradaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Data_Entrada", true));
            this.data_EntradaTextBox.Location = new System.Drawing.Point(83, 414);
            this.data_EntradaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.data_EntradaTextBox.Name = "data_EntradaTextBox";
            this.data_EntradaTextBox.ReadOnly = true;
            this.data_EntradaTextBox.Size = new System.Drawing.Size(233, 20);
            this.data_EntradaTextBox.TabIndex = 11;
            // 
            // id_clienteTextBox
            // 
            this.id_clienteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id_cliente", true));
            this.id_clienteTextBox.Location = new System.Drawing.Point(83, 391);
            this.id_clienteTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_clienteTextBox.Name = "id_clienteTextBox";
            this.id_clienteTextBox.ReadOnly = true;
            this.id_clienteTextBox.Size = new System.Drawing.Size(76, 20);
            this.id_clienteTextBox.TabIndex = 13;
            // 
            // id_funcionarioTextBox
            // 
            this.id_funcionarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.diariaBindingSource, "Id_funcionario", true));
            this.id_funcionarioTextBox.Location = new System.Drawing.Point(227, 391);
            this.id_funcionarioTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.id_funcionarioTextBox.Name = "id_funcionarioTextBox";
            this.id_funcionarioTextBox.ReadOnly = true;
            this.id_funcionarioTextBox.Size = new System.Drawing.Size(89, 20);
            this.id_funcionarioTextBox.TabIndex = 15;
            // 
            // numeroTextBox
            // 
            this.numeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Numero", true));
            this.numeroTextBox.Location = new System.Drawing.Point(663, 360);
            this.numeroTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numeroTextBox.Name = "numeroTextBox";
            this.numeroTextBox.ReadOnly = true;
            this.numeroTextBox.Size = new System.Drawing.Size(108, 20);
            this.numeroTextBox.TabIndex = 17;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Descricao", true));
            this.descricaoTextBox.Location = new System.Drawing.Point(663, 384);
            this.descricaoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.ReadOnly = true;
            this.descricaoTextBox.Size = new System.Drawing.Size(108, 20);
            this.descricaoTextBox.TabIndex = 19;
            // 
            // valor_DiariaTextBox
            // 
            this.valor_DiariaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.quartosBindingSource, "Valor_Diaria", true));
            this.valor_DiariaTextBox.Location = new System.Drawing.Point(663, 411);
            this.valor_DiariaTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.valor_DiariaTextBox.Name = "valor_DiariaTextBox";
            this.valor_DiariaTextBox.ReadOnly = true;
            this.valor_DiariaTextBox.Size = new System.Drawing.Size(108, 20);
            this.valor_DiariaTextBox.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 327);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "Dados da Diária";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(604, 327);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 20);
            this.label2.TabIndex = 23;
            this.label2.Text = "Dados do Quarto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cadastro de Diária";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 142);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 26;
            this.label4.Text = "Quarto";
            // 
            // diariaDataGridView
            // 
            this.diariaDataGridView.AllowUserToAddRows = false;
            this.diariaDataGridView.AllowUserToDeleteRows = false;
            this.diariaDataGridView.AllowUserToOrderColumns = true;
            this.diariaDataGridView.AutoGenerateColumns = false;
            this.diariaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.diariaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn11});
            this.diariaDataGridView.DataSource = this.diariaBindingSource;
            this.diariaDataGridView.Location = new System.Drawing.Point(11, 162);
            this.diariaDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.diariaDataGridView.Name = "diariaDataGridView";
            this.diariaDataGridView.ReadOnly = true;
            this.diariaDataGridView.RowHeadersWidth = 51;
            this.diariaDataGridView.RowTemplate.Height = 24;
            this.diariaDataGridView.Size = new System.Drawing.Size(583, 145);
            this.diariaDataGridView.TabIndex = 30;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.search;
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(206, 98);
            this.buttonBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(89, 33);
            this.buttonBuscar.TabIndex = 3;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Id_cliente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 60;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nome_Cliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nome do Cliente";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            this.dataGridViewTextBoxColumn3.Width = 120;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cpf_Cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cpf_Cliente";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor_Total";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor_Total";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Id_funcionario";
            this.dataGridViewTextBoxColumn8.HeaderText = "Funcionario";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 69;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "Id_Pagamento";
            this.dataGridViewTextBoxColumn12.HeaderText = "Pagamento";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 115;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data_Entrada";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data Entrada";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "Data_Saida";
            this.dataGridViewTextBoxColumn11.HeaderText = "Data Saida";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 120;
            // 
            // diariaBindingSource
            // 
            this.diariaBindingSource.DataSource = typeof(Models.Diaria);
            // 
            // buttonExcluirQuarto
            // 
            this.buttonExcluirQuarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirQuarto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExcluirQuarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirQuarto.Image")));
            this.buttonExcluirQuarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirQuarto.Location = new System.Drawing.Point(695, 452);
            this.buttonExcluirQuarto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirQuarto.Name = "buttonExcluirQuarto";
            this.buttonExcluirQuarto.Size = new System.Drawing.Size(94, 33);
            this.buttonExcluirQuarto.TabIndex = 24;
            this.buttonExcluirQuarto.Text = "Excluir";
            this.buttonExcluirQuarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirQuarto.UseVisualStyleBackColor = true;
            this.buttonExcluirQuarto.Click += new System.EventHandler(this.buttonExcluirQuarto_Click);
            // 
            // buttonADCquarto
            // 
            this.buttonADCquarto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADCquarto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonADCquarto.Image = ((System.Drawing.Image)(resources.GetObject("buttonADCquarto.Image")));
            this.buttonADCquarto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonADCquarto.Location = new System.Drawing.Point(583, 452);
            this.buttonADCquarto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonADCquarto.Name = "buttonADCquarto";
            this.buttonADCquarto.Size = new System.Drawing.Size(108, 33);
            this.buttonADCquarto.TabIndex = 24;
            this.buttonADCquarto.Text = "Adicionar";
            this.buttonADCquarto.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonADCquarto.UseVisualStyleBackColor = true;
            this.buttonADCquarto.Click += new System.EventHandler(this.buttonADCquarto_Click);
            // 
            // buttonExcluirDiaria
            // 
            this.buttonExcluirDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExcluirDiaria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonExcluirDiaria.Image = ((System.Drawing.Image)(resources.GetObject("buttonExcluirDiaria.Image")));
            this.buttonExcluirDiaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonExcluirDiaria.Location = new System.Drawing.Point(230, 452);
            this.buttonExcluirDiaria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonExcluirDiaria.Name = "buttonExcluirDiaria";
            this.buttonExcluirDiaria.Size = new System.Drawing.Size(94, 33);
            this.buttonExcluirDiaria.TabIndex = 24;
            this.buttonExcluirDiaria.Text = "Excluir";
            this.buttonExcluirDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonExcluirDiaria.UseVisualStyleBackColor = true;
            this.buttonExcluirDiaria.Click += new System.EventHandler(this.buttonExcluirDiaria_Click);
            // 
            // buttonAlterar
            // 
            this.buttonAlterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAlterar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonAlterar.Image = global::WindowsFormsAppGestaoHotel.Properties.Resources.edit;
            this.buttonAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonAlterar.Location = new System.Drawing.Point(131, 452);
            this.buttonAlterar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAlterar.Name = "buttonAlterar";
            this.buttonAlterar.Size = new System.Drawing.Size(95, 33);
            this.buttonAlterar.TabIndex = 24;
            this.buttonAlterar.Text = "Alterar";
            this.buttonAlterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAlterar.UseVisualStyleBackColor = true;
            this.buttonAlterar.Click += new System.EventHandler(this.buttonAlterar_Click);
            // 
            // buttonADCDiaria
            // 
            this.buttonADCDiaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.818182F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonADCDiaria.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonADCDiaria.Image = ((System.Drawing.Image)(resources.GetObject("buttonADCDiaria.Image")));
            this.buttonADCDiaria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonADCDiaria.Location = new System.Drawing.Point(19, 452);
            this.buttonADCDiaria.Margin = new System.Windows.Forms.Padding(2);
            this.buttonADCDiaria.Name = "buttonADCDiaria";
            this.buttonADCDiaria.Size = new System.Drawing.Size(108, 33);
            this.buttonADCDiaria.TabIndex = 24;
            this.buttonADCDiaria.Text = "Adicionar";
            this.buttonADCDiaria.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonADCDiaria.UseVisualStyleBackColor = true;
            this.buttonADCDiaria.Click += new System.EventHandler(this.buttonADCDiaria_Click);
            // 
            // quartosBindingSource
            // 
            this.quartosBindingSource.DataMember = "Quartos";
            this.quartosBindingSource.DataSource = this.diariaBindingSource;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Numero";
            this.dataGridViewTextBoxColumn7.HeaderText = "Número";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Descricao";
            this.dataGridViewTextBoxColumn9.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 125;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Valor_Diaria";
            this.dataGridViewTextBoxColumn10.HeaderText = "Valor da Diária";
            this.dataGridViewTextBoxColumn10.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 125;
            // 
            // FormBuscarDiaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 493);
            this.Controls.Add(this.diariaDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonExcluirQuarto);
            this.Controls.Add(this.buttonADCquarto);
            this.Controls.Add(this.buttonExcluirDiaria);
            this.Controls.Add(this.buttonAlterar);
            this.Controls.Add(this.buttonADCDiaria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(valor_DiariaLabel);
            this.Controls.Add(this.valor_DiariaTextBox);
            this.Controls.Add(descricaoLabel);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(numeroLabel);
            this.Controls.Add(this.numeroTextBox);
            this.Controls.Add(id_funcionarioLabel);
            this.Controls.Add(this.id_funcionarioTextBox);
            this.Controls.Add(id_clienteLabel);
            this.Controls.Add(this.id_clienteTextBox);
            this.Controls.Add(data_EntradaLabel);
            this.Controls.Add(this.data_EntradaTextBox);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.quartosDataGridView);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.textBoxBuscar);
            this.Controls.Add(this.textBoxDt_En);
            this.Controls.Add(this.radioButtonCPF);
            this.Controls.Add(this.radioButtonNome);
            this.Controls.Add(this.radioButtonDT_EN);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBuscarDiaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Buscar de Diária";
            this.Load += new System.EventHandler(this.FormBuscarDiaria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quartosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diariaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quartosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonDT_EN;
        private System.Windows.Forms.RadioButton radioButtonNome;
        private System.Windows.Forms.RadioButton radioButtonCPF;
        private System.Windows.Forms.TextBox textBoxDt_En;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.BindingSource diariaBindingSource;
        private System.Windows.Forms.BindingSource quartosBindingSource;
        private System.Windows.Forms.DataGridView quartosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox data_EntradaTextBox;
        private System.Windows.Forms.TextBox id_clienteTextBox;
        private System.Windows.Forms.TextBox id_funcionarioTextBox;
        private System.Windows.Forms.TextBox numeroTextBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.TextBox valor_DiariaTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonADCDiaria;
        private System.Windows.Forms.Button buttonAlterar;
        private System.Windows.Forms.Button buttonExcluirDiaria;
        private System.Windows.Forms.Button buttonADCquarto;
        private System.Windows.Forms.Button buttonExcluirQuarto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView diariaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
    }
}