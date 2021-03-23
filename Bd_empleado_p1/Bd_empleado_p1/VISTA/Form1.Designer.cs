
namespace Bd_empleado_p1
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
            this.Id_empleado = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Empl_nombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Empl_tel = new System.Windows.Forms.Label();
            this.Empl_direccion = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.Empl_DUI = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.Empl_cargo = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.Empl_email = new System.Windows.Forms.Label();
            this.bto_eliminar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Id_empleado
            // 
            this.Id_empleado.AutoSize = true;
            this.Id_empleado.Location = new System.Drawing.Point(92, 48);
            this.Id_empleado.Name = "Id_empleado";
            this.Id_empleado.Size = new System.Drawing.Size(89, 17);
            this.Id_empleado.TabIndex = 0;
            this.Id_empleado.Text = "Id_empleado";
            this.Id_empleado.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 1;
            // 
            // Empl_nombre
            // 
            this.Empl_nombre.AutoSize = true;
            this.Empl_nombre.Location = new System.Drawing.Point(92, 132);
            this.Empl_nombre.Name = "Empl_nombre";
            this.Empl_nombre.Size = new System.Drawing.Size(95, 17);
            this.Empl_nombre.TabIndex = 2;
            this.Empl_nombre.Text = "Empl_nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Empl_apellido";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 162);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 22);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(95, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(154, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(361, 256);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(154, 22);
            this.textBox4.TabIndex = 11;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(361, 162);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(154, 22);
            this.textBox5.TabIndex = 10;
            // 
            // Empl_tel
            // 
            this.Empl_tel.AutoSize = true;
            this.Empl_tel.Location = new System.Drawing.Point(358, 223);
            this.Empl_tel.Name = "Empl_tel";
            this.Empl_tel.Size = new System.Drawing.Size(62, 17);
            this.Empl_tel.TabIndex = 9;
            this.Empl_tel.Text = "Empl_tel";
            // 
            // Empl_direccion
            // 
            this.Empl_direccion.AutoSize = true;
            this.Empl_direccion.Location = new System.Drawing.Point(358, 132);
            this.Empl_direccion.Name = "Empl_direccion";
            this.Empl_direccion.Size = new System.Drawing.Size(104, 17);
            this.Empl_direccion.TabIndex = 8;
            this.Empl_direccion.Text = "Empl_direccion";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(361, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(154, 22);
            this.textBox6.TabIndex = 7;
            // 
            // Empl_DUI
            // 
            this.Empl_DUI.AutoSize = true;
            this.Empl_DUI.Location = new System.Drawing.Point(358, 48);
            this.Empl_DUI.Name = "Empl_DUI";
            this.Empl_DUI.Size = new System.Drawing.Size(70, 17);
            this.Empl_DUI.TabIndex = 6;
            this.Empl_DUI.Text = "Empl_DUI";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(637, 162);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(154, 22);
            this.textBox7.TabIndex = 15;
            // 
            // Empl_cargo
            // 
            this.Empl_cargo.AutoSize = true;
            this.Empl_cargo.Location = new System.Drawing.Point(634, 132);
            this.Empl_cargo.Name = "Empl_cargo";
            this.Empl_cargo.Size = new System.Drawing.Size(83, 17);
            this.Empl_cargo.TabIndex = 14;
            this.Empl_cargo.Text = "Empl_cargo";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(637, 68);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(154, 22);
            this.textBox8.TabIndex = 13;
            // 
            // Empl_email
            // 
            this.Empl_email.AutoSize = true;
            this.Empl_email.Location = new System.Drawing.Point(634, 48);
            this.Empl_email.Name = "Empl_email";
            this.Empl_email.Size = new System.Drawing.Size(80, 17);
            this.Empl_email.TabIndex = 12;
            this.Empl_email.Text = "Empl_email";
            // 
            // bto_eliminar
            // 
            this.bto_eliminar.Location = new System.Drawing.Point(95, 312);
            this.bto_eliminar.Name = "bto_eliminar";
            this.bto_eliminar.Size = new System.Drawing.Size(114, 44);
            this.bto_eliminar.TabIndex = 16;
            this.bto_eliminar.Text = "Eliminar";
            this.bto_eliminar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Apellido,
            this.DUI,
            this.Direccion,
            this.Tel,
            this.Email,
            this.Cargo});
            this.dataGridView1.Location = new System.Drawing.Point(30, 405);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1056, 198);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.Width = 125;
            // 
            // DUI
            // 
            this.DUI.HeaderText = "DUI";
            this.DUI.MinimumWidth = 6;
            this.DUI.Name = "DUI";
            this.DUI.Width = 125;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.MinimumWidth = 6;
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 125;
            // 
            // Tel
            // 
            this.Tel.HeaderText = "Tel";
            this.Tel.MinimumWidth = 6;
            this.Tel.Name = "Tel";
            this.Tel.Width = 125;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.Width = 125;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 643);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bto_eliminar);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.Empl_cargo);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.Empl_email);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Empl_tel);
            this.Controls.Add(this.Empl_direccion);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Empl_DUI);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Empl_nombre);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Id_empleado);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Id_empleado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Empl_nombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label Empl_tel;
        private System.Windows.Forms.Label Empl_direccion;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label Empl_DUI;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label Empl_cargo;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label Empl_email;
        private System.Windows.Forms.Button bto_eliminar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn DUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
    }
}

