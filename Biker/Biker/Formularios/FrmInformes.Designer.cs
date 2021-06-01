
namespace Biker.Formularios
{
    partial class FrmInformes
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
            this.tabGanadores = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompeticion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.premioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanciaTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiempoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ganadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryEntry1 = new System.DirectoryServices.DirectoryEntry();
            this.tabControl1.SuspendLayout();
            this.tabGanadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabGanadores);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabGanadores
            // 
            this.tabGanadores.Controls.Add(this.dataGridView3);
            this.tabGanadores.Controls.Add(this.dataGridView1);
            this.tabGanadores.Controls.Add(this.label1);
            this.tabGanadores.Location = new System.Drawing.Point(4, 22);
            this.tabGanadores.Name = "tabGanadores";
            this.tabGanadores.Padding = new System.Windows.Forms.Padding(3);
            this.tabGanadores.Size = new System.Drawing.Size(792, 424);
            this.tabGanadores.TabIndex = 0;
            this.tabGanadores.Text = "Ganadores Competición";
            this.tabGanadores.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombreDataGridViewTextBoxColumn,
            this.NombreCompeticion,
            this.premioDataGridViewTextBoxColumn,
            this.distanciaTotalDataGridViewTextBoxColumn,
            this.tiempoTotalDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.ganadorBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(136, 96);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(546, 299);
            this.dataGridView3.TabIndex = 2;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // NombreCompeticion
            // 
            this.NombreCompeticion.DataPropertyName = "NombreCompeticion";
            this.NombreCompeticion.HeaderText = "NombreCompeticion";
            this.NombreCompeticion.Name = "NombreCompeticion";
            this.NombreCompeticion.ReadOnly = true;
            // 
            // premioDataGridViewTextBoxColumn
            // 
            this.premioDataGridViewTextBoxColumn.DataPropertyName = "Premio";
            this.premioDataGridViewTextBoxColumn.HeaderText = "Premio";
            this.premioDataGridViewTextBoxColumn.Name = "premioDataGridViewTextBoxColumn";
            this.premioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanciaTotalDataGridViewTextBoxColumn
            // 
            this.distanciaTotalDataGridViewTextBoxColumn.DataPropertyName = "DistanciaTotal";
            this.distanciaTotalDataGridViewTextBoxColumn.HeaderText = "DistanciaTotal";
            this.distanciaTotalDataGridViewTextBoxColumn.Name = "distanciaTotalDataGridViewTextBoxColumn";
            this.distanciaTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiempoTotalDataGridViewTextBoxColumn
            // 
            this.tiempoTotalDataGridViewTextBoxColumn.DataPropertyName = "TiempoTotal";
            this.tiempoTotalDataGridViewTextBoxColumn.HeaderText = "TiempoTotal";
            this.tiempoTotalDataGridViewTextBoxColumn.Name = "tiempoTotalDataGridViewTextBoxColumn";
            this.tiempoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ganadorBindingSource
            // 
            this.ganadorBindingSource.DataSource = typeof(Biker.Modelo.Informes.Ganador);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(786, 336);
            this.dataGridView1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(137, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Los ganadores de cada competicion son:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmInformes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FrmInformes";
            this.Text = "Infomes";
            this.Load += new System.EventHandler(this.FrmInformes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabGanadores.ResumeLayout(false);
            this.tabGanadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ganadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabGanadores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectoryEntry directoryEntry1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.BindingSource ganadorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompeticion;
        private System.Windows.Forms.DataGridViewTextBoxColumn premioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanciaTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiempoTotalDataGridViewTextBoxColumn;
    }
}