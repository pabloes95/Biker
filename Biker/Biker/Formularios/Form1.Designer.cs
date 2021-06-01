
namespace Biker
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnVerEditar = new System.Windows.Forms.Button();
            this.BtnFiltrar = new System.Windows.Forms.Button();
            this.BtnInformes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVerEditar
            // 
            this.btnVerEditar.Location = new System.Drawing.Point(265, 43);
            this.btnVerEditar.Name = "btnVerEditar";
            this.btnVerEditar.Size = new System.Drawing.Size(170, 62);
            this.btnVerEditar.TabIndex = 0;
            this.btnVerEditar.Text = "Ver/Editar";
            this.btnVerEditar.UseVisualStyleBackColor = true;
            this.btnVerEditar.Click += new System.EventHandler(this.btnVerEditar_Click);
            // 
            // BtnFiltrar
            // 
            this.BtnFiltrar.Location = new System.Drawing.Point(265, 135);
            this.BtnFiltrar.Name = "BtnFiltrar";
            this.BtnFiltrar.Size = new System.Drawing.Size(170, 62);
            this.BtnFiltrar.TabIndex = 1;
            this.BtnFiltrar.Text = "Filtrar";
            this.BtnFiltrar.UseVisualStyleBackColor = true;
            this.BtnFiltrar.Click += new System.EventHandler(this.BtnFiltrar_Click);
            // 
            // BtnInformes
            // 
            this.BtnInformes.Location = new System.Drawing.Point(265, 233);
            this.BtnInformes.Name = "BtnInformes";
            this.BtnInformes.Size = new System.Drawing.Size(170, 62);
            this.BtnInformes.TabIndex = 2;
            this.BtnInformes.Text = "Informes";
            this.BtnInformes.UseVisualStyleBackColor = true;
            this.BtnInformes.Click += new System.EventHandler(this.BtnInformes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 326);
            this.Controls.Add(this.BtnInformes);
            this.Controls.Add(this.BtnFiltrar);
            this.Controls.Add(this.btnVerEditar);
            this.MaximumSize = new System.Drawing.Size(721, 365);
            this.MinimumSize = new System.Drawing.Size(721, 365);
            this.Name = "Form1";
            this.Text = "Biker";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVerEditar;
        private System.Windows.Forms.Button BtnFiltrar;
        private System.Windows.Forms.Button BtnInformes;
    }
}

