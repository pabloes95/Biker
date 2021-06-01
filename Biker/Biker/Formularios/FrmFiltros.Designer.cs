
namespace Biker.Formularios
{
    partial class FrmFiltros
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCorredores = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblRuta = new System.Windows.Forms.Label();
            this.CbxRuta = new System.Windows.Forms.ComboBox();
            this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblCompeticion = new System.Windows.Forms.Label();
            this.CbxCompeticion = new System.Windows.Forms.ComboBox();
            this.competicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.CbxCategoria = new System.Windows.Forms.ComboBox();
            this.categoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.BtnBuscarCorredores = new System.Windows.Forms.Button();
            this.GrvCorredores = new System.Windows.Forms.DataGridView();
            this.corredorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarrerasTotales = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corredorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabCompeticiones = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblRutaCompeticion = new System.Windows.Forms.Label();
            this.CbxRutaCompeticion = new System.Windows.Forms.ComboBox();
            this.rutaBindingSourceCompeticion = new System.Windows.Forms.BindingSource(this.components);
            this.panel7 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxCorredores = new System.Windows.Forms.ComboBox();
            this.corredorBindingSourceCombo = new System.Windows.Forms.BindingSource(this.components);
            this.panel8 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.GrvCompeticiones = new System.Windows.Forms.DataGridView();
            this.competicionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumeroRutas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competicionBindingSourceGrid = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.TabCorredores.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSource)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvCorredores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corredorBindingSource)).BeginInit();
            this.tabCompeticiones.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSourceCompeticion)).BeginInit();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corredorBindingSourceCombo)).BeginInit();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvCompeticiones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSourceGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabCorredores);
            this.tabControl1.Controls.Add(this.tabCompeticiones);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // TabCorredores
            // 
            this.TabCorredores.Controls.Add(this.tableLayoutPanel1);
            this.TabCorredores.Controls.Add(this.GrvCorredores);
            this.TabCorredores.Location = new System.Drawing.Point(4, 22);
            this.TabCorredores.Name = "TabCorredores";
            this.TabCorredores.Padding = new System.Windows.Forms.Padding(3);
            this.TabCorredores.Size = new System.Drawing.Size(792, 424);
            this.TabCorredores.TabIndex = 0;
            this.TabCorredores.Text = "Corredores";
            this.TabCorredores.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(235, 418);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 113);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblRuta);
            this.panel1.Controls.Add(this.CbxRuta);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 28);
            this.panel1.TabIndex = 2;
            // 
            // lblRuta
            // 
            this.lblRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRuta.AutoSize = true;
            this.lblRuta.Location = new System.Drawing.Point(15, 3);
            this.lblRuta.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.lblRuta.Name = "lblRuta";
            this.lblRuta.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.lblRuta.Size = new System.Drawing.Size(30, 18);
            this.lblRuta.TabIndex = 1;
            this.lblRuta.Text = "Ruta";
            // 
            // CbxRuta
            // 
            this.CbxRuta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxRuta.DataSource = this.rutaBindingSource;
            this.CbxRuta.DisplayMember = "Nombre";
            this.CbxRuta.FormattingEnabled = true;
            this.CbxRuta.Location = new System.Drawing.Point(80, 3);
            this.CbxRuta.Name = "CbxRuta";
            this.CbxRuta.Size = new System.Drawing.Size(112, 21);
            this.CbxRuta.TabIndex = 0;
            this.CbxRuta.ValueMember = "RutaID";
            // 
            // rutaBindingSource
            // 
            this.rutaBindingSource.DataSource = typeof(Biker.Modelo.Ruta);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.LblCompeticion);
            this.panel2.Controls.Add(this.CbxCompeticion);
            this.panel2.Location = new System.Drawing.Point(3, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 28);
            this.panel2.TabIndex = 3;
            // 
            // LblCompeticion
            // 
            this.LblCompeticion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblCompeticion.AutoSize = true;
            this.LblCompeticion.Location = new System.Drawing.Point(15, 3);
            this.LblCompeticion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblCompeticion.Name = "LblCompeticion";
            this.LblCompeticion.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblCompeticion.Size = new System.Drawing.Size(65, 18);
            this.LblCompeticion.TabIndex = 1;
            this.LblCompeticion.Text = "Competición";
            // 
            // CbxCompeticion
            // 
            this.CbxCompeticion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxCompeticion.DataSource = this.competicionBindingSource;
            this.CbxCompeticion.DisplayMember = "Nombre";
            this.CbxCompeticion.FormattingEnabled = true;
            this.CbxCompeticion.Location = new System.Drawing.Point(80, 3);
            this.CbxCompeticion.Name = "CbxCompeticion";
            this.CbxCompeticion.Size = new System.Drawing.Size(112, 21);
            this.CbxCompeticion.TabIndex = 0;
            this.CbxCompeticion.ValueMember = "CompeticionID";
            // 
            // competicionBindingSource
            // 
            this.competicionBindingSource.DataSource = typeof(Biker.Modelo.Competicion);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.CbxCategoria);
            this.panel4.Location = new System.Drawing.Point(3, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(220, 28);
            this.panel4.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(52, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // CbxCategoria
            // 
            this.CbxCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxCategoria.DataSource = this.categoriaBindingSource;
            this.CbxCategoria.DisplayMember = "Nombre";
            this.CbxCategoria.FormattingEnabled = true;
            this.CbxCategoria.Location = new System.Drawing.Point(80, 3);
            this.CbxCategoria.Name = "CbxCategoria";
            this.CbxCategoria.Size = new System.Drawing.Size(112, 21);
            this.CbxCategoria.TabIndex = 0;
            this.CbxCategoria.ValueMember = "CategoriaID";
            // 
            // categoriaBindingSource
            // 
            this.categoriaBindingSource.DataSource = typeof(Biker.Modelo.Categoria);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.BtnBuscarCorredores);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 379);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(229, 36);
            this.panel3.TabIndex = 3;
            // 
            // BtnBuscarCorredores
            // 
            this.BtnBuscarCorredores.Location = new System.Drawing.Point(3, 0);
            this.BtnBuscarCorredores.Name = "BtnBuscarCorredores";
            this.BtnBuscarCorredores.Size = new System.Drawing.Size(223, 33);
            this.BtnBuscarCorredores.TabIndex = 0;
            this.BtnBuscarCorredores.Text = "Buscar";
            this.BtnBuscarCorredores.UseVisualStyleBackColor = true;
            this.BtnBuscarCorredores.Click += new System.EventHandler(this.button1_Click);
            // 
            // GrvCorredores
            // 
            this.GrvCorredores.AllowUserToAddRows = false;
            this.GrvCorredores.AllowUserToDeleteRows = false;
            this.GrvCorredores.AutoGenerateColumns = false;
            this.GrvCorredores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvCorredores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corredorIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.CarrerasTotales});
            this.GrvCorredores.DataSource = this.corredorBindingSource;
            this.GrvCorredores.Dock = System.Windows.Forms.DockStyle.Right;
            this.GrvCorredores.Location = new System.Drawing.Point(238, 3);
            this.GrvCorredores.Name = "GrvCorredores";
            this.GrvCorredores.ReadOnly = true;
            this.GrvCorredores.Size = new System.Drawing.Size(551, 418);
            this.GrvCorredores.TabIndex = 0;
            // 
            // corredorIDDataGridViewTextBoxColumn
            // 
            this.corredorIDDataGridViewTextBoxColumn.DataPropertyName = "CorredorID";
            this.corredorIDDataGridViewTextBoxColumn.HeaderText = "CorredorID";
            this.corredorIDDataGridViewTextBoxColumn.Name = "corredorIDDataGridViewTextBoxColumn";
            this.corredorIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CarrerasTotales
            // 
            this.CarrerasTotales.HeaderText = "Carreras Totales";
            this.CarrerasTotales.Name = "CarrerasTotales";
            this.CarrerasTotales.ReadOnly = true;
            // 
            // corredorBindingSource
            // 
            this.corredorBindingSource.DataSource = typeof(Biker.Modelo.Corredor);
            // 
            // tabCompeticiones
            // 
            this.tabCompeticiones.Controls.Add(this.tableLayoutPanel2);
            this.tabCompeticiones.Controls.Add(this.GrvCompeticiones);
            this.tabCompeticiones.Location = new System.Drawing.Point(4, 22);
            this.tabCompeticiones.Name = "tabCompeticiones";
            this.tabCompeticiones.Padding = new System.Windows.Forms.Padding(3);
            this.tabCompeticiones.Size = new System.Drawing.Size(792, 424);
            this.tabCompeticiones.TabIndex = 1;
            this.tabCompeticiones.Text = "Competiciones";
            this.tabCompeticiones.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.flowLayoutPanel2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel8, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(235, 418);
            this.tableLayoutPanel2.TabIndex = 4;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.panel5);
            this.flowLayoutPanel2.Controls.Add(this.panel7);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(229, 113);
            this.flowLayoutPanel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LblRutaCompeticion);
            this.panel5.Controls.Add(this.CbxRutaCompeticion);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(220, 28);
            this.panel5.TabIndex = 2;
            // 
            // LblRutaCompeticion
            // 
            this.LblRutaCompeticion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblRutaCompeticion.AutoSize = true;
            this.LblRutaCompeticion.Location = new System.Drawing.Point(15, 3);
            this.LblRutaCompeticion.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.LblRutaCompeticion.Name = "LblRutaCompeticion";
            this.LblRutaCompeticion.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.LblRutaCompeticion.Size = new System.Drawing.Size(30, 18);
            this.LblRutaCompeticion.TabIndex = 1;
            this.LblRutaCompeticion.Text = "Ruta";
            // 
            // CbxRutaCompeticion
            // 
            this.CbxRutaCompeticion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxRutaCompeticion.DataSource = this.rutaBindingSourceCompeticion;
            this.CbxRutaCompeticion.DisplayMember = "Nombre";
            this.CbxRutaCompeticion.FormattingEnabled = true;
            this.CbxRutaCompeticion.Location = new System.Drawing.Point(80, 3);
            this.CbxRutaCompeticion.Name = "CbxRutaCompeticion";
            this.CbxRutaCompeticion.Size = new System.Drawing.Size(112, 21);
            this.CbxRutaCompeticion.TabIndex = 0;
            this.CbxRutaCompeticion.ValueMember = "RutaID";
            // 
            // rutaBindingSourceCompeticion
            // 
            this.rutaBindingSourceCompeticion.DataSource = typeof(Biker.Modelo.Ruta);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.CbxCorredores);
            this.panel7.Location = new System.Drawing.Point(3, 37);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(220, 28);
            this.panel7.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 3);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label4.Size = new System.Drawing.Size(58, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Corredores";
            // 
            // CbxCorredores
            // 
            this.CbxCorredores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CbxCorredores.DataSource = this.corredorBindingSourceCombo;
            this.CbxCorredores.DisplayMember = "Nombre";
            this.CbxCorredores.FormattingEnabled = true;
            this.CbxCorredores.Location = new System.Drawing.Point(80, 3);
            this.CbxCorredores.Name = "CbxCorredores";
            this.CbxCorredores.Size = new System.Drawing.Size(112, 21);
            this.CbxCorredores.TabIndex = 0;
            this.CbxCorredores.ValueMember = "CorredorID";
            // 
            // corredorBindingSourceCombo
            // 
            this.corredorBindingSourceCombo.DataSource = typeof(Biker.Modelo.Corredor);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.button1);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(3, 379);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(229, 36);
            this.panel8.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(223, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // GrvCompeticiones
            // 
            this.GrvCompeticiones.AllowUserToAddRows = false;
            this.GrvCompeticiones.AllowUserToDeleteRows = false;
            this.GrvCompeticiones.AutoGenerateColumns = false;
            this.GrvCompeticiones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvCompeticiones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competicionIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn1,
            this.premioDataGridViewTextBoxColumn,
            this.NumeroRutas});
            this.GrvCompeticiones.DataSource = this.competicionBindingSourceGrid;
            this.GrvCompeticiones.Dock = System.Windows.Forms.DockStyle.Right;
            this.GrvCompeticiones.Location = new System.Drawing.Point(238, 3);
            this.GrvCompeticiones.Name = "GrvCompeticiones";
            this.GrvCompeticiones.ReadOnly = true;
            this.GrvCompeticiones.Size = new System.Drawing.Size(551, 418);
            this.GrvCompeticiones.TabIndex = 3;
            // 
            // competicionIDDataGridViewTextBoxColumn
            // 
            this.competicionIDDataGridViewTextBoxColumn.DataPropertyName = "CompeticionID";
            this.competicionIDDataGridViewTextBoxColumn.HeaderText = "CompeticionID";
            this.competicionIDDataGridViewTextBoxColumn.Name = "competicionIDDataGridViewTextBoxColumn";
            this.competicionIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            this.nombreDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // premioDataGridViewTextBoxColumn
            // 
            this.premioDataGridViewTextBoxColumn.DataPropertyName = "Premio";
            this.premioDataGridViewTextBoxColumn.HeaderText = "Premio";
            this.premioDataGridViewTextBoxColumn.Name = "premioDataGridViewTextBoxColumn";
            this.premioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NumeroRutas
            // 
            this.NumeroRutas.HeaderText = "Numero de Rutas";
            this.NumeroRutas.Name = "NumeroRutas";
            this.NumeroRutas.ReadOnly = true;
            // 
            // competicionBindingSourceGrid
            // 
            this.competicionBindingSourceGrid.DataSource = typeof(Biker.Modelo.Competicion);
            // 
            // FrmFiltros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmFiltros";
            this.Text = "Filtros";
            this.Load += new System.EventHandler(this.FrmFiltros_Load);
            this.tabControl1.ResumeLayout(false);
            this.TabCorredores.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSource)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaBindingSource)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvCorredores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corredorBindingSource)).EndInit();
            this.tabCompeticiones.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSourceCompeticion)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.corredorBindingSourceCombo)).EndInit();
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvCompeticiones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSourceGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabCorredores;
        private System.Windows.Forms.TabPage tabCompeticiones;
        private System.Windows.Forms.DataGridView GrvCorredores;
        private System.Windows.Forms.BindingSource corredorBindingSource;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblRuta;
        private System.Windows.Forms.ComboBox CbxRuta;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblCompeticion;
        private System.Windows.Forms.ComboBox CbxCompeticion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BtnBuscarCorredores;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbxCategoria;
        private System.Windows.Forms.BindingSource rutaBindingSource;
        private System.Windows.Forms.BindingSource competicionBindingSource;
        private System.Windows.Forms.BindingSource categoriaBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn corredorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarrerasTotales;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblRutaCompeticion;
        private System.Windows.Forms.ComboBox CbxRutaCompeticion;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxCorredores;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView GrvCompeticiones;
        private System.Windows.Forms.BindingSource rutaBindingSourceCompeticion;
        private System.Windows.Forms.BindingSource competicionBindingSourceGrid;
        private System.Windows.Forms.BindingSource corredorBindingSourceCombo;
        private System.Windows.Forms.DataGridViewTextBoxColumn competicionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn premioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumeroRutas;
    }
}