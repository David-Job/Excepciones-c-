namespace Vista
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dniDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellido2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alumnoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label_ERROR = new System.Windows.Forms.Label();
            this.textBox_dni = new System.Windows.Forms.TextBox();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_apellido1 = new System.Windows.Forms.TextBox();
            this.textBox_apellido2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.anadir_button = new System.Windows.Forms.Button();
            this.data_error_label = new System.Windows.Forms.Label();
            this.conexionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_eliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeight = 46;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registroDataGridViewTextBoxColumn,
            this.dniDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellido1DataGridViewTextBoxColumn,
            this.apellido2DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.alumnoBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Highlight;
            this.dataGridView1.Location = new System.Drawing.Point(2, 2);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1088, 398);
            this.dataGridView1.TabIndex = 0;
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
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBox1.Location = new System.Drawing.Point(16, 487);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(320, 31);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 433);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inserte el registro que quiere eliminar";
            // 
            // label_ERROR
            // 
            this.label_ERROR.AutoSize = true;
            this.label_ERROR.Location = new System.Drawing.Point(20, 544);
            this.label_ERROR.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ERROR.Name = "label_ERROR";
            this.label_ERROR.Size = new System.Drawing.Size(0, 25);
            this.label_ERROR.TabIndex = 4;
            // 
            // textBox_dni
            // 
            this.textBox_dni.Location = new System.Drawing.Point(848, 415);
            this.textBox_dni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_dni.Name = "textBox_dni";
            this.textBox_dni.Size = new System.Drawing.Size(232, 31);
            this.textBox_dni.TabIndex = 5;
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(848, 465);
            this.textBox_nombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(232, 31);
            this.textBox_nombre.TabIndex = 6;
            // 
            // textBox_apellido1
            // 
            this.textBox_apellido1.Location = new System.Drawing.Point(848, 519);
            this.textBox_apellido1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_apellido1.Name = "textBox_apellido1";
            this.textBox_apellido1.Size = new System.Drawing.Size(232, 31);
            this.textBox_apellido1.TabIndex = 7;
            // 
            // textBox_apellido2
            // 
            this.textBox_apellido2.Location = new System.Drawing.Point(848, 571);
            this.textBox_apellido2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_apellido2.Name = "textBox_apellido2";
            this.textBox_apellido2.Size = new System.Drawing.Size(232, 31);
            this.textBox_apellido2.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(718, 419);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(718, 469);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(718, 519);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "1º Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(718, 571);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "2º Apellido";
            // 
            // anadir_button
            // 
            this.anadir_button.Location = new System.Drawing.Point(848, 631);
            this.anadir_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.anadir_button.Name = "anadir_button";
            this.anadir_button.Size = new System.Drawing.Size(100, 38);
            this.anadir_button.TabIndex = 13;
            this.anadir_button.Text = "Añadir";
            this.anadir_button.UseVisualStyleBackColor = true;
            this.anadir_button.Click += new System.EventHandler(this.anadir_button_Click);
            // 
            // data_error_label
            // 
            this.data_error_label.AutoSize = true;
            this.data_error_label.Location = new System.Drawing.Point(718, 685);
            this.data_error_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.data_error_label.Name = "data_error_label";
            this.data_error_label.Size = new System.Drawing.Size(0, 25);
            this.data_error_label.TabIndex = 14;
            // 
            // conexionBindingSource
            // 
            this.conexionBindingSource.DataSource = typeof(Alumnos.Conexion);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(350, 477);
            this.button_eliminar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(150, 56);
            this.button_eliminar.TabIndex = 15;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 733);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.data_error_label);
            this.Controls.Add(this.anadir_button);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_apellido2);
            this.Controls.Add(this.textBox_apellido1);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.textBox_dni);
            this.Controls.Add(this.label_ERROR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conexionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource conexionBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dniDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellido2DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource alumnoBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ERROR;
        private System.Windows.Forms.TextBox textBox_dni;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_apellido1;
        private System.Windows.Forms.TextBox textBox_apellido2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button anadir_button;
        private System.Windows.Forms.Label data_error_label;
        private System.Windows.Forms.Button button_eliminar;
    }
}

