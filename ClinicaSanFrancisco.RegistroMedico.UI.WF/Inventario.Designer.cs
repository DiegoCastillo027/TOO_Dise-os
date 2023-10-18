namespace ClinicaSanFrancisco.RegistroMedico.UI.WF
{
    partial class Inventario
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
            this.chbAlcohol = new System.Windows.Forms.CheckBox();
            this.chbAlgodon = new System.Windows.Forms.CheckBox();
            this.chbGasas = new System.Windows.Forms.CheckBox();
            this.chbGuantes = new System.Windows.Forms.CheckBox();
            this.chbInyecciones = new System.Windows.Forms.CheckBox();
            this.chbMedicamento = new System.Windows.Forms.CheckBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbAlcohol
            // 
            this.chbAlcohol.AutoSize = true;
            this.chbAlcohol.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAlcohol.Location = new System.Drawing.Point(14, 127);
            this.chbAlcohol.Name = "chbAlcohol";
            this.chbAlcohol.Size = new System.Drawing.Size(76, 21);
            this.chbAlcohol.TabIndex = 14;
            this.chbAlcohol.Text = "Alcohol";
            this.chbAlcohol.UseVisualStyleBackColor = true;
            this.chbAlcohol.CheckedChanged += new System.EventHandler(this.chbAlcohol_CheckedChanged);
            // 
            // chbAlgodon
            // 
            this.chbAlgodon.AutoSize = true;
            this.chbAlgodon.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbAlgodon.Location = new System.Drawing.Point(14, 235);
            this.chbAlgodon.Name = "chbAlgodon";
            this.chbAlgodon.Size = new System.Drawing.Size(159, 21);
            this.chbAlgodon.TabIndex = 15;
            this.chbAlgodon.Text = "Paquetes de Algodon";
            this.chbAlgodon.UseVisualStyleBackColor = true;
            // 
            // chbGasas
            // 
            this.chbGasas.AutoSize = true;
            this.chbGasas.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGasas.Location = new System.Drawing.Point(14, 154);
            this.chbGasas.Name = "chbGasas";
            this.chbGasas.Size = new System.Drawing.Size(116, 21);
            this.chbGasas.TabIndex = 16;
            this.chbGasas.Text = "Gasas Esteriles";
            this.chbGasas.UseVisualStyleBackColor = true;
            this.chbGasas.CheckedChanged += new System.EventHandler(this.chbGasas_CheckedChanged);
            // 
            // chbGuantes
            // 
            this.chbGuantes.AutoSize = true;
            this.chbGuantes.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbGuantes.Location = new System.Drawing.Point(13, 262);
            this.chbGuantes.Name = "chbGuantes";
            this.chbGuantes.Size = new System.Drawing.Size(158, 21);
            this.chbGuantes.TabIndex = 17;
            this.chbGuantes.Text = "Paquetes de Guantes";
            this.chbGuantes.UseVisualStyleBackColor = true;
            // 
            // chbInyecciones
            // 
            this.chbInyecciones.AutoSize = true;
            this.chbInyecciones.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbInyecciones.Location = new System.Drawing.Point(14, 181);
            this.chbInyecciones.Name = "chbInyecciones";
            this.chbInyecciones.Size = new System.Drawing.Size(101, 21);
            this.chbInyecciones.TabIndex = 18;
            this.chbInyecciones.Text = "Inyecciones";
            this.chbInyecciones.UseVisualStyleBackColor = true;
            // 
            // chbMedicamento
            // 
            this.chbMedicamento.AutoSize = true;
            this.chbMedicamento.Font = new System.Drawing.Font("Century Gothic", 7.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMedicamento.Location = new System.Drawing.Point(14, 208);
            this.chbMedicamento.Name = "chbMedicamento";
            this.chbMedicamento.Size = new System.Drawing.Size(115, 21);
            this.chbMedicamento.TabIndex = 19;
            this.chbMedicamento.Text = "Medicamento";
            this.chbMedicamento.UseVisualStyleBackColor = true;
            // 
            // dgvInventario
            // 
            this.dgvInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(0, 12);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersWidth = 51;
            this.dgvInventario.RowTemplate.Height = 24;
            this.dgvInventario.Size = new System.Drawing.Size(641, 646);
            this.dgvInventario.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAgregar.BackColor = System.Drawing.Color.Transparent;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.ForeColor = System.Drawing.Color.Black;
            this.btnAgregar.Location = new System.Drawing.Point(14, 311);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(126, 36);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnModificar.BackColor = System.Drawing.Color.Transparent;
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.ForeColor = System.Drawing.Color.Black;
            this.btnModificar.Location = new System.Drawing.Point(14, 355);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(126, 36);
            this.btnModificar.TabIndex = 23;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEliminar.BackColor = System.Drawing.Color.Transparent;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(14, 399);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(126, 36);
            this.btnEliminar.TabIndex = 24;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(205)))), ((int)(((byte)(147)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(238)))), ((int)(((byte)(219)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.ForeColor = System.Drawing.Color.Black;
            this.btnCerrar.Location = new System.Drawing.Point(14, 602);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(126, 36);
            this.btnCerrar.TabIndex = 25;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.chbAlcohol);
            this.panel1.Controls.Add(this.btnCerrar);
            this.panel1.Controls.Add(this.chbGuantes);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.chbInyecciones);
            this.panel1.Controls.Add(this.chbGasas);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.chbMedicamento);
            this.panel1.Controls.Add(this.btnAgregar);
            this.panel1.Controls.Add(this.chbAlgodon);
            this.panel1.Location = new System.Drawing.Point(647, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 659);
            this.panel1.TabIndex = 26;
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(867, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvInventario);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox chbAlcohol;
        private System.Windows.Forms.CheckBox chbAlgodon;
        private System.Windows.Forms.CheckBox chbGasas;
        private System.Windows.Forms.CheckBox chbGuantes;
        private System.Windows.Forms.CheckBox chbInyecciones;
        private System.Windows.Forms.CheckBox chbMedicamento;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Panel panel1;
    }
}