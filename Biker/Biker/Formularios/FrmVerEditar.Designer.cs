
namespace Biker.Formularios
{
    partial class FrmVerEditar
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
            this.TabRuta = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAñadirRuta = new System.Windows.Forms.Button();
            this.GrvRuta = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Localidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Distancia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.GrvCarrera = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaComboBoxCarrera = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tiempo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Completada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaCorredorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAñadirCarrera = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAñadirCorredor = new System.Windows.Forms.Button();
            this.grvCorredores = new System.Windows.Forms.DataGridView();
            this.corredorIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.corredorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabCompeticion = new System.Windows.Forms.TabPage();
            this.GrvRutaCompeticion = new System.Windows.Forms.DataGridView();
            this.competicionIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaComboBoxCompeticion = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ordenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaCompeticionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAñadirRutaCompeticion = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAñadirCompeticion = new System.Windows.Forms.Button();
            this.GrvCompeticion = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Premio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competicionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.competicionBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.numeroRutasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.competicionIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rutaCompeticionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TabRuta.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRuta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvCarrera)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaCorredorBindingSource)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grvCorredores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corredorBindingSource)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.TabCompeticion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRutaCompeticion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaCompeticionBindingSource)).BeginInit();
            this.flowLayoutPanel4.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrvCompeticion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // TabRuta
            // 
            this.TabRuta.Controls.Add(this.flowLayoutPanel2);
            this.TabRuta.Controls.Add(this.GrvRuta);
            this.TabRuta.Location = new System.Drawing.Point(4, 22);
            this.TabRuta.Name = "TabRuta";
            this.TabRuta.Padding = new System.Windows.Forms.Padding(3);
            this.TabRuta.Size = new System.Drawing.Size(792, 333);
            this.TabRuta.TabIndex = 1;
            this.TabRuta.Text = "Ruta";
            this.TabRuta.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.Controls.Add(this.BtnAñadirRuta);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 284);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(786, 46);
            this.flowLayoutPanel2.TabIndex = 3;
            // 
            // BtnAñadirRuta
            // 
            this.BtnAñadirRuta.Location = new System.Drawing.Point(3, 3);
            this.BtnAñadirRuta.Name = "BtnAñadirRuta";
            this.BtnAñadirRuta.Size = new System.Drawing.Size(94, 35);
            this.BtnAñadirRuta.TabIndex = 2;
            this.BtnAñadirRuta.Text = "Añadir Ruta";
            this.BtnAñadirRuta.UseVisualStyleBackColor = true;
            this.BtnAñadirRuta.Click += new System.EventHandler(this.BtnAñadirRuta_Click);
            // 
            // GrvRuta
            // 
            this.GrvRuta.AllowUserToAddRows = false;
            this.GrvRuta.AllowUserToDeleteRows = false;
            this.GrvRuta.AutoGenerateColumns = false;
            this.GrvRuta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvRuta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.Localidad,
            this.Distancia});
            this.GrvRuta.DataSource = this.rutaBindingSource;
            this.GrvRuta.Dock = System.Windows.Forms.DockStyle.Top;
            this.GrvRuta.Location = new System.Drawing.Point(3, 3);
            this.GrvRuta.MultiSelect = false;
            this.GrvRuta.Name = "GrvRuta";
            this.GrvRuta.Size = new System.Drawing.Size(786, 281);
            this.GrvRuta.TabIndex = 2;
            this.GrvRuta.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Localidad
            // 
            this.Localidad.DataPropertyName = "Localidad";
            this.Localidad.HeaderText = "Localidad";
            this.Localidad.Name = "Localidad";
            // 
            // Distancia
            // 
            this.Distancia.DataPropertyName = "Distancia";
            this.Distancia.HeaderText = "Distancia";
            this.Distancia.Name = "Distancia";
            // 
            // rutaBindingSource
            // 
            this.rutaBindingSource.DataSource = typeof(Biker.Modelo.Ruta);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.GrvCarrera);
            this.tabPage1.Controls.Add(this.flowLayoutPanel5);
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Controls.Add(this.grvCorredores);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Corredores";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // GrvCarrera
            // 
            this.GrvCarrera.AllowUserToAddRows = false;
            this.GrvCarrera.AllowUserToDeleteRows = false;
            this.GrvCarrera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrvCarrera.AutoGenerateColumns = false;
            this.GrvCarrera.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvCarrera.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.rutaComboBoxCarrera,
            this.dataGridViewTextBoxColumn8,
            this.Tiempo,
            this.Completada,
            this.Fecha});
            this.GrvCarrera.DataSource = this.rutaCorredorBindingSource;
            this.GrvCarrera.Location = new System.Drawing.Point(353, 3);
            this.GrvCarrera.MultiSelect = false;
            this.GrvCarrera.Name = "GrvCarrera";
            this.GrvCarrera.Size = new System.Drawing.Size(431, 281);
            this.GrvCarrera.TabIndex = 2;
            this.GrvCarrera.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_CellValueChanged);
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "CorredorID";
            this.dataGridViewTextBoxColumn6.HeaderText = "CorredorID";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // rutaComboBoxCarrera
            // 
            this.rutaComboBoxCarrera.DataPropertyName = "RutaID";
            this.rutaComboBoxCarrera.DataSource = this.rutaBindingSource;
            this.rutaComboBoxCarrera.DisplayMember = "Nombre";
            this.rutaComboBoxCarrera.HeaderText = "Ruta";
            this.rutaComboBoxCarrera.Name = "rutaComboBoxCarrera";
            this.rutaComboBoxCarrera.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rutaComboBoxCarrera.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rutaComboBoxCarrera.ValueMember = "RutaID";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Distancia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Distancia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // Tiempo
            // 
            this.Tiempo.DataPropertyName = "Tiempo";
            this.Tiempo.HeaderText = "Tiempo";
            this.Tiempo.Name = "Tiempo";
            // 
            // Completada
            // 
            this.Completada.DataPropertyName = "Completada";
            this.Completada.HeaderText = "Completada";
            this.Completada.Name = "Completada";
            // 
            // Fecha
            // 
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            // 
            // rutaCorredorBindingSource
            // 
            this.rutaCorredorBindingSource.DataSource = typeof(Biker.Modelo.RutaCorredor);
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel5.Controls.Add(this.BtnAñadirCarrera);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(353, 284);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(431, 46);
            this.flowLayoutPanel5.TabIndex = 3;
            // 
            // BtnAñadirCarrera
            // 
            this.BtnAñadirCarrera.Location = new System.Drawing.Point(3, 3);
            this.BtnAñadirCarrera.Name = "BtnAñadirCarrera";
            this.BtnAñadirCarrera.Size = new System.Drawing.Size(94, 35);
            this.BtnAñadirCarrera.TabIndex = 2;
            this.BtnAñadirCarrera.Text = "Añadir Carrera";
            this.BtnAñadirCarrera.UseVisualStyleBackColor = true;
            this.BtnAñadirCarrera.Click += new System.EventHandler(this.BtnAñadirCarrera_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.BtnAñadirCorredor);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 284);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(344, 46);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // BtnAñadirCorredor
            // 
            this.BtnAñadirCorredor.Location = new System.Drawing.Point(3, 3);
            this.BtnAñadirCorredor.Name = "BtnAñadirCorredor";
            this.BtnAñadirCorredor.Size = new System.Drawing.Size(94, 35);
            this.BtnAñadirCorredor.TabIndex = 2;
            this.BtnAñadirCorredor.Text = "Añadir Corredor";
            this.BtnAñadirCorredor.UseVisualStyleBackColor = true;
            this.BtnAñadirCorredor.Click += new System.EventHandler(this.BtnAñadirCorredor_Click);
            // 
            // grvCorredores
            // 
            this.grvCorredores.AllowUserToAddRows = false;
            this.grvCorredores.AllowUserToDeleteRows = false;
            this.grvCorredores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grvCorredores.AutoGenerateColumns = false;
            this.grvCorredores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvCorredores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.corredorIDDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn});
            this.grvCorredores.DataSource = this.corredorBindingSource;
            this.grvCorredores.Location = new System.Drawing.Point(3, 3);
            this.grvCorredores.MultiSelect = false;
            this.grvCorredores.Name = "grvCorredores";
            this.grvCorredores.Size = new System.Drawing.Size(344, 281);
            this.grvCorredores.TabIndex = 0;
            this.grvCorredores.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_CellValueChanged);
            this.grvCorredores.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.grvCorredores_RowStateChanged);
            // 
            // corredorIDDataGridViewTextBoxColumn
            // 
            this.corredorIDDataGridViewTextBoxColumn.DataPropertyName = "CorredorID";
            this.corredorIDDataGridViewTextBoxColumn.HeaderText = "CorredorID";
            this.corredorIDDataGridViewTextBoxColumn.Name = "corredorIDDataGridViewTextBoxColumn";
            this.corredorIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            this.categoriaDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.categoriaDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // corredorBindingSource
            // 
            this.corredorBindingSource.AllowNew = true;
            this.corredorBindingSource.DataSource = typeof(Biker.Modelo.Corredor);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.TabRuta);
            this.tabControl1.Controls.Add(this.TabCompeticion);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 359);
            this.tabControl1.TabIndex = 0;
            // 
            // TabCompeticion
            // 
            this.TabCompeticion.Controls.Add(this.GrvRutaCompeticion);
            this.TabCompeticion.Controls.Add(this.flowLayoutPanel4);
            this.TabCompeticion.Controls.Add(this.flowLayoutPanel3);
            this.TabCompeticion.Controls.Add(this.GrvCompeticion);
            this.TabCompeticion.Location = new System.Drawing.Point(4, 22);
            this.TabCompeticion.Name = "TabCompeticion";
            this.TabCompeticion.Padding = new System.Windows.Forms.Padding(3);
            this.TabCompeticion.Size = new System.Drawing.Size(792, 333);
            this.TabCompeticion.TabIndex = 2;
            this.TabCompeticion.Text = "Competición";
            this.TabCompeticion.UseVisualStyleBackColor = true;
            // 
            // GrvRutaCompeticion
            // 
            this.GrvRutaCompeticion.AllowUserToAddRows = false;
            this.GrvRutaCompeticion.AllowUserToDeleteRows = false;
            this.GrvRutaCompeticion.AutoGenerateColumns = false;
            this.GrvRutaCompeticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvRutaCompeticion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.competicionIDDataGridViewTextBoxColumn,
            this.rutaComboBoxCompeticion,
            this.ordenDataGridViewTextBoxColumn});
            this.GrvRutaCompeticion.DataSource = this.rutaCompeticionBindingSource;
            this.GrvRutaCompeticion.Location = new System.Drawing.Point(255, 3);
            this.GrvRutaCompeticion.MultiSelect = false;
            this.GrvRutaCompeticion.Name = "GrvRutaCompeticion";
            this.GrvRutaCompeticion.Size = new System.Drawing.Size(529, 281);
            this.GrvRutaCompeticion.TabIndex = 6;
            this.GrvRutaCompeticion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_CellValueChanged);
            // 
            // competicionIDDataGridViewTextBoxColumn
            // 
            this.competicionIDDataGridViewTextBoxColumn.DataPropertyName = "CompeticionID";
            this.competicionIDDataGridViewTextBoxColumn.HeaderText = "CompeticionID";
            this.competicionIDDataGridViewTextBoxColumn.Name = "competicionIDDataGridViewTextBoxColumn";
            this.competicionIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // rutaComboBoxCompeticion
            // 
            this.rutaComboBoxCompeticion.DataPropertyName = "RutaID";
            this.rutaComboBoxCompeticion.DataSource = this.rutaBindingSource;
            this.rutaComboBoxCompeticion.DisplayMember = "Nombre";
            this.rutaComboBoxCompeticion.HeaderText = "Ruta";
            this.rutaComboBoxCompeticion.Name = "rutaComboBoxCompeticion";
            this.rutaComboBoxCompeticion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.rutaComboBoxCompeticion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.rutaComboBoxCompeticion.ValueMember = "RutaID";
            // 
            // ordenDataGridViewTextBoxColumn
            // 
            this.ordenDataGridViewTextBoxColumn.DataPropertyName = "Orden";
            this.ordenDataGridViewTextBoxColumn.HeaderText = "Orden";
            this.ordenDataGridViewTextBoxColumn.Name = "ordenDataGridViewTextBoxColumn";
            // 
            // rutaCompeticionBindingSource
            // 
            this.rutaCompeticionBindingSource.DataSource = typeof(Biker.Modelo.RutaCompeticion);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel4.Controls.Add(this.BtnAñadirRutaCompeticion);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(255, 287);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(529, 46);
            this.flowLayoutPanel4.TabIndex = 6;
            // 
            // BtnAñadirRutaCompeticion
            // 
            this.BtnAñadirRutaCompeticion.Location = new System.Drawing.Point(3, 3);
            this.BtnAñadirRutaCompeticion.Name = "BtnAñadirRutaCompeticion";
            this.BtnAñadirRutaCompeticion.Size = new System.Drawing.Size(151, 35);
            this.BtnAñadirRutaCompeticion.TabIndex = 2;
            this.BtnAñadirRutaCompeticion.Text = "Añadir Ruta a Competicion";
            this.BtnAñadirRutaCompeticion.UseVisualStyleBackColor = true;
            this.BtnAñadirRutaCompeticion.Click += new System.EventHandler(this.BtnAñadirRutaCompeticion_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.Controls.Add(this.btnAñadirCompeticion);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 284);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(246, 46);
            this.flowLayoutPanel3.TabIndex = 5;
            // 
            // btnAñadirCompeticion
            // 
            this.btnAñadirCompeticion.Location = new System.Drawing.Point(3, 3);
            this.btnAñadirCompeticion.Name = "btnAñadirCompeticion";
            this.btnAñadirCompeticion.Size = new System.Drawing.Size(107, 35);
            this.btnAñadirCompeticion.TabIndex = 2;
            this.btnAñadirCompeticion.Text = "Añadir Competicion";
            this.btnAñadirCompeticion.UseVisualStyleBackColor = true;
            this.btnAñadirCompeticion.Click += new System.EventHandler(this.btnAñadirCompeticion_Click);
            // 
            // GrvCompeticion
            // 
            this.GrvCompeticion.AllowUserToAddRows = false;
            this.GrvCompeticion.AllowUserToDeleteRows = false;
            this.GrvCompeticion.AutoGenerateColumns = false;
            this.GrvCompeticion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GrvCompeticion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Premio,
            this.numeroRutasDataGridViewTextBoxColumn,
            this.competicionIDDataGridViewTextBoxColumn1,
            this.nombreDataGridViewTextBoxColumn1,
            this.premioDataGridViewTextBoxColumn,
            this.rutaCompeticionsDataGridViewTextBoxColumn});
            this.GrvCompeticion.DataSource = this.competicionBindingSource;
            this.GrvCompeticion.Location = new System.Drawing.Point(3, 3);
            this.GrvCompeticion.MultiSelect = false;
            this.GrvCompeticion.Name = "GrvCompeticion";
            this.GrvCompeticion.Size = new System.Drawing.Size(246, 281);
            this.GrvCompeticion.TabIndex = 4;
            this.GrvCompeticion.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grv_CellValueChanged);
            this.GrvCompeticion.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.GrvCompeticion_RowStateChanged);
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Premio
            // 
            this.Premio.DataPropertyName = "Premio";
            this.Premio.HeaderText = "Premio";
            this.Premio.Name = "Premio";
            // 
            // competicionBindingSource
            // 
            this.competicionBindingSource.DataSource = typeof(Biker.Modelo.Competicion);
            // 
            // competicionBindingSource1
            // 
            this.competicionBindingSource1.DataSource = typeof(Biker.Modelo.Competicion);
            // 
            // numeroRutasDataGridViewTextBoxColumn
            // 
            this.numeroRutasDataGridViewTextBoxColumn.DataPropertyName = "NumeroRutas";
            this.numeroRutasDataGridViewTextBoxColumn.HeaderText = "NumeroRutas";
            this.numeroRutasDataGridViewTextBoxColumn.Name = "numeroRutasDataGridViewTextBoxColumn";
            this.numeroRutasDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // competicionIDDataGridViewTextBoxColumn1
            // 
            this.competicionIDDataGridViewTextBoxColumn1.DataPropertyName = "CompeticionID";
            this.competicionIDDataGridViewTextBoxColumn1.HeaderText = "CompeticionID";
            this.competicionIDDataGridViewTextBoxColumn1.Name = "competicionIDDataGridViewTextBoxColumn1";
            // 
            // nombreDataGridViewTextBoxColumn1
            // 
            this.nombreDataGridViewTextBoxColumn1.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn1.Name = "nombreDataGridViewTextBoxColumn1";
            // 
            // premioDataGridViewTextBoxColumn
            // 
            this.premioDataGridViewTextBoxColumn.DataPropertyName = "Premio";
            this.premioDataGridViewTextBoxColumn.HeaderText = "Premio";
            this.premioDataGridViewTextBoxColumn.Name = "premioDataGridViewTextBoxColumn";
            // 
            // rutaCompeticionsDataGridViewTextBoxColumn
            // 
            this.rutaCompeticionsDataGridViewTextBoxColumn.DataPropertyName = "RutaCompeticions";
            this.rutaCompeticionsDataGridViewTextBoxColumn.HeaderText = "RutaCompeticions";
            this.rutaCompeticionsDataGridViewTextBoxColumn.Name = "rutaCompeticionsDataGridViewTextBoxColumn";
            // 
            // FrmVerEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 359);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(816, 398);
            this.MinimumSize = new System.Drawing.Size(816, 398);
            this.Name = "FrmVerEditar";
            this.Text = "Ver / Editar";
            this.Load += new System.EventHandler(this.FrmVerEditar_Load);
            this.TabRuta.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvRuta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaBindingSource)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvCarrera)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaCorredorBindingSource)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grvCorredores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corredorBindingSource)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.TabCompeticion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvRutaCompeticion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rutaCompeticionBindingSource)).EndInit();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrvCompeticion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competicionBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        protected System.Windows.Forms.BindingSource corredorBindingSource;
        private System.Windows.Forms.TabPage TabRuta;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BtnAñadirCorredor;
        private System.Windows.Forms.DataGridView grvCorredores;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button BtnAñadirRuta;
        private System.Windows.Forms.DataGridView GrvRuta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Localidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Distancia;
        private System.Windows.Forms.BindingSource rutaBindingSource;
        private System.Windows.Forms.TabPage TabCompeticion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button btnAñadirCompeticion;
        private System.Windows.Forms.DataGridView GrvCompeticion;
        private System.Windows.Forms.BindingSource competicionBindingSource;
        private System.Windows.Forms.DataGridView GrvRutaCompeticion;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button BtnAñadirRutaCompeticion;
        private System.Windows.Forms.DataGridView GrvCarrera;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Button BtnAñadirCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn corredorIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource rutaCorredorBindingSource;
        private System.Windows.Forms.BindingSource rutaCompeticionBindingSource;
        private System.Windows.Forms.BindingSource competicionBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn rutaComboBoxCarrera;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tiempo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Completada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn competicionIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn rutaComboBoxCompeticion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Premio;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroRutasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn competicionIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn premioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rutaCompeticionsDataGridViewTextBoxColumn;
    }
}