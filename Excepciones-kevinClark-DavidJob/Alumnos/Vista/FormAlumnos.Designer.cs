namespace Vista
{
    partial class FormAlumnos
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
            this.components = new System.ComponentModel.Container();
            this.dataGridViewAlumnos = new System.Windows.Forms.DataGridView();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxRegistro = new System.Windows.Forms.TextBox();
            this.labelRegistro = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.textBoxDni = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxApellido1 = new System.Windows.Forms.TextBox();
            this.textBoxApellido2 = new System.Windows.Forms.TextBox();
            this.labelDni = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellido1 = new System.Windows.Forms.Label();
            this.labelApellido2 = new System.Windows.Forms.Label();
            this.buttonAnyadir = new System.Windows.Forms.Button();
            this.labelDataError = new System.Windows.Forms.Label();
            this.conexionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlumnos
            // 
            this.dataGridViewAlumnos.AllowDrop = true;
            this.dataGridViewAlumnos.AllowUserToAddRows = false;
            this.dataGridViewAlumnos.AllowUserToDeleteRows = false;
            this.dataGridViewAlumnos.AllowUserToResizeRows = false;
            this.dataGridViewAlumnos.AutoGenerateColumns = false;
            this.dataGridViewAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAlumnos.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewAlumnos.ColumnHeadersHeight = 46;
            this.dataGridViewAlumnos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn});
            this.dataGridViewAlumnos.DataSource = this.alumnoBindingSource;
            this.dataGridViewAlumnos.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridViewAlumnos.Location = new System.Drawing.Point(1, 1);
            this.dataGridViewAlumnos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewAlumnos.Name = "dataGridViewAlumnos";
            this.dataGridViewAlumnos.RowHeadersWidth = 82;
            this.dataGridViewAlumnos.RowTemplate.Height = 33;
            this.dataGridViewAlumnos.Size = new System.Drawing.Size(544, 207);
            this.dataGridViewAlumnos.TabIndex = 0;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            // 
            // dniDataGridViewTextBoxColumn
            // 
            this.dniDataGridViewTextBoxColumn.DataPropertyName = "Dni";
            this.dniDataGridViewTextBoxColumn.HeaderText = "Dni";
            this.dniDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.dniDataGridViewTextBoxColumn.Name = "dniDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // apellido1DataGridViewTextBoxColumn
            // 
            this.apellido1DataGridViewTextBoxColumn.DataPropertyName = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.HeaderText = "Apellido1";
            this.apellido1DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.apellido1DataGridViewTextBoxColumn.Name = "apellido1DataGridViewTextBoxColumn";
            // 
            // apellido2DataGridViewTextBoxColumn
            // 
            this.apellido2DataGridViewTextBoxColumn.DataPropertyName = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.HeaderText = "Apellido2";
            this.apellido2DataGridViewTextBoxColumn.MinimumWidth = 10;
            this.apellido2DataGridViewTextBoxColumn.Name = "apellido2DataGridViewTextBoxColumn";
            // 
            // alumnoBindingSource
            // 
            this.alumnoBindingSource.DataSource = typeof(Alumnos.Alumno);
            // 
            // textBoxRegistro
            // 
            this.textBoxRegistro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxRegistro.Location = new System.Drawing.Point(8, 253);
            this.textBoxRegistro.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRegistro.Name = "textBoxRegistro";
            this.textBoxRegistro.Size = new System.Drawing.Size(162, 20);
            this.textBoxRegistro.TabIndex = 1;
            // 
            // labelRegistro
            // 
            this.labelRegistro.AutoSize = true;
            this.labelRegistro.Location = new System.Drawing.Point(6, 225);
            this.labelRegistro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistro.Name = "labelRegistro";
            this.labelRegistro.Size = new System.Drawing.Size(178, 13);
            this.labelRegistro.TabIndex = 3;
            this.labelRegistro.Text = "Inserte el registro que quiere eliminar";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Location = new System.Drawing.Point(10, 283);
            this.labelError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(0, 13);
            this.labelError.TabIndex = 4;
            // 
            // textBoxDni
            // 
            this.textBoxDni.Location = new System.Drawing.Point(424, 216);
            this.textBoxDni.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxDni.Name = "textBoxDni";
            this.textBoxDni.Size = new System.Drawing.Size(118, 20);
            this.textBoxDni.TabIndex = 5;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(424, 242);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(118, 20);
            this.textBoxNombre.TabIndex = 6;
            // 
            // textBoxApellido1
            // 
            this.textBoxApellido1.Location = new System.Drawing.Point(424, 270);
            this.textBoxApellido1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxApellido1.Name = "textBoxApellido1";
            this.textBoxApellido1.Size = new System.Drawing.Size(118, 20);
            this.textBoxApellido1.TabIndex = 7;
            // 
            // textBoxApellido2
            // 
            this.textBoxApellido2.Location = new System.Drawing.Point(424, 297);
            this.textBoxApellido2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxApellido2.Name = "textBoxApellido2";
            this.textBoxApellido2.Size = new System.Drawing.Size(118, 20);
            this.textBoxApellido2.TabIndex = 8;
            // 
            // labelDni
            // 
            this.labelDni.AutoSize = true;
            this.labelDni.Location = new System.Drawing.Point(359, 218);
            this.labelDni.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDni.Name = "labelDni";
            this.labelDni.Size = new System.Drawing.Size(26, 13);
            this.labelDni.TabIndex = 9;
            this.labelDni.Text = "DNI";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(359, 244);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre";
            // 
            // labelApellido1
            // 
            this.labelApellido1.AutoSize = true;
            this.labelApellido1.Location = new System.Drawing.Point(359, 270);
            this.labelApellido1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido1.Name = "labelApellido1";
            this.labelApellido1.Size = new System.Drawing.Size(57, 13);
            this.labelApellido1.TabIndex = 11;
            this.labelApellido1.Text = "1º Apellido";
            // 
            // labelApellido2
            // 
            this.labelApellido2.AutoSize = true;
            this.labelApellido2.Location = new System.Drawing.Point(359, 297);
            this.labelApellido2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelApellido2.Name = "labelApellido2";
            this.labelApellido2.Size = new System.Drawing.Size(57, 13);
            this.labelApellido2.TabIndex = 12;
            this.labelApellido2.Text = "2º Apellido";
            // 
            // buttonAnyadir
            // 
            this.buttonAnyadir.Location = new System.Drawing.Point(424, 328);
            this.buttonAnyadir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonAnyadir.Name = "buttonAnyadir";
            this.buttonAnyadir.Size = new System.Drawing.Size(50, 20);
            this.buttonAnyadir.TabIndex = 13;
            this.buttonAnyadir.Text = "Añadir";
            this.buttonAnyadir.UseVisualStyleBackColor = true;
            this.buttonAnyadir.Click += new System.EventHandler(this.ButtonAnyadirClick);
            // 
            // labelDataError
            // 
            this.labelDataError.AutoSize = true;
            this.labelDataError.Location = new System.Drawing.Point(359, 356);
            this.labelDataError.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDataError.Name = "labelDataError";
            this.labelDataError.Size = new System.Drawing.Size(0, 13);
            this.labelDataError.TabIndex = 14;
            // 
            // conexionBindingSource
            // 
            this.conexionBindingSource.DataSource = typeof(Alumnos.Conexion);
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(175, 248);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 29);
            this.buttonEliminar.TabIndex = 15;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.ButtonEliminarClick);
            // 
            // FormAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 381);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.labelDataError);
            this.Controls.Add(this.buttonAnyadir);
            this.Controls.Add(this.labelApellido2);
            this.Controls.Add(this.labelApellido1);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.labelDni);
            this.Controls.Add(this.textBoxApellido2);
            this.Controls.Add(this.textBoxApellido1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDni);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelRegistro);
            this.Controls.Add(this.textBoxRegistro);
            this.Controls.Add(this.dataGridViewAlumnos);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormAlumnos";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource conexionBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewAlumnos;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.TextBox textBoxRegistro;
        private System.Windows.Forms.Label labelRegistro;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.TextBox textBoxDni;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxApellido1;
        private System.Windows.Forms.TextBox textBoxApellido2;
        private System.Windows.Forms.Label labelDni;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellido1;
        private System.Windows.Forms.Label labelApellido2;
        private System.Windows.Forms.Button buttonAnyadir;
        private System.Windows.Forms.Label labelDataError;
        private System.Windows.Forms.Button buttonEliminar;
    }
}

