namespace Ejercicio3
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.btnmodificar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.txtdireccion = new System.Windows.Forms.TextBox();
            this.txtrol = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvpersonas = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtidc = new System.Windows.Forms.TextBox();
            this.btnmodificarc = new System.Windows.Forms.Button();
            this.btneliminarc = new System.Windows.Forms.Button();
            this.btnagregarc = new System.Windows.Forms.Button();
            this.txttipo = new System.Windows.Forms.TextBox();
            this.txtsaldo = new System.Windows.Forms.TextBox();
            this.txtnrocuenta = new System.Windows.Forms.TextBox();
            this.txtidp = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvCuenta = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.btnmodificar);
            this.groupBox1.Controls.Add(this.btneliminar);
            this.groupBox1.Controls.Add(this.btnagregar);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtrol);
            this.groupBox1.Controls.Add(this.txtedad);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 241);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS PERSONA";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(70, 12);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(18, 20);
            this.txtid.TabIndex = 13;
            // 
            // btnmodificar
            // 
            this.btnmodificar.Location = new System.Drawing.Point(10, 210);
            this.btnmodificar.Name = "btnmodificar";
            this.btnmodificar.Size = new System.Drawing.Size(313, 23);
            this.btnmodificar.TabIndex = 12;
            this.btnmodificar.Text = "modificar";
            this.btnmodificar.UseVisualStyleBackColor = true;
            this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(10, 180);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(313, 23);
            this.btneliminar.TabIndex = 11;
            this.btneliminar.Text = "eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(10, 151);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(313, 23);
            this.btnagregar.TabIndex = 10;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(94, 114);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(229, 20);
            this.txtdireccion.TabIndex = 9;
            // 
            // txtrol
            // 
            this.txtrol.Location = new System.Drawing.Point(94, 89);
            this.txtrol.Name = "txtrol";
            this.txtrol.Size = new System.Drawing.Size(229, 20);
            this.txtrol.TabIndex = 8;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(94, 63);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(229, 20);
            this.txtedad.TabIndex = 7;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(94, 38);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(229, 20);
            this.txtapellido.TabIndex = 6;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(94, 12);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(229, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Rol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // dgvpersonas
            // 
            this.dgvpersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpersonas.Location = new System.Drawing.Point(370, 12);
            this.dgvpersonas.Name = "dgvpersonas";
            this.dgvpersonas.Size = new System.Drawing.Size(418, 241);
            this.dgvpersonas.TabIndex = 1;
            this.dgvpersonas.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvpersonas_CellMouseDoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtidc);
            this.groupBox2.Controls.Add(this.btnmodificarc);
            this.groupBox2.Controls.Add(this.btneliminarc);
            this.groupBox2.Controls.Add(this.btnagregarc);
            this.groupBox2.Controls.Add(this.txttipo);
            this.groupBox2.Controls.Add(this.txtsaldo);
            this.groupBox2.Controls.Add(this.txtnrocuenta);
            this.groupBox2.Controls.Add(this.txtidp);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(12, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DATOS CUENTA BANCARIA";
            // 
            // txtidc
            // 
            this.txtidc.Enabled = false;
            this.txtidc.Location = new System.Drawing.Point(139, 13);
            this.txtidc.Name = "txtidc";
            this.txtidc.Size = new System.Drawing.Size(18, 20);
            this.txtidc.TabIndex = 13;
            // 
            // btnmodificarc
            // 
            this.btnmodificarc.Location = new System.Drawing.Point(10, 185);
            this.btnmodificarc.Name = "btnmodificarc";
            this.btnmodificarc.Size = new System.Drawing.Size(313, 23);
            this.btnmodificarc.TabIndex = 12;
            this.btnmodificarc.Text = "modificar";
            this.btnmodificarc.UseVisualStyleBackColor = true;
            this.btnmodificarc.Click += new System.EventHandler(this.btnmodificarc_Click);
            // 
            // btneliminarc
            // 
            this.btneliminarc.Location = new System.Drawing.Point(10, 156);
            this.btneliminarc.Name = "btneliminarc";
            this.btneliminarc.Size = new System.Drawing.Size(313, 23);
            this.btneliminarc.TabIndex = 11;
            this.btneliminarc.Text = "eliminar";
            this.btneliminarc.UseVisualStyleBackColor = true;
            this.btneliminarc.Click += new System.EventHandler(this.btneliminarc_Click);
            // 
            // btnagregarc
            // 
            this.btnagregarc.Location = new System.Drawing.Point(10, 127);
            this.btnagregarc.Name = "btnagregarc";
            this.btnagregarc.Size = new System.Drawing.Size(313, 23);
            this.btnagregarc.TabIndex = 10;
            this.btnagregarc.Text = "Agregar";
            this.btnagregarc.UseVisualStyleBackColor = true;
            this.btnagregarc.Click += new System.EventHandler(this.btnagregarc_Click);
            // 
            // txttipo
            // 
            this.txttipo.Location = new System.Drawing.Point(139, 89);
            this.txttipo.Name = "txttipo";
            this.txttipo.Size = new System.Drawing.Size(184, 20);
            this.txttipo.TabIndex = 8;
            // 
            // txtsaldo
            // 
            this.txtsaldo.Location = new System.Drawing.Point(94, 63);
            this.txtsaldo.Name = "txtsaldo";
            this.txtsaldo.Size = new System.Drawing.Size(229, 20);
            this.txtsaldo.TabIndex = 7;
            // 
            // txtnrocuenta
            // 
            this.txtnrocuenta.Location = new System.Drawing.Point(94, 38);
            this.txtnrocuenta.Name = "txtnrocuenta";
            this.txtnrocuenta.Size = new System.Drawing.Size(229, 20);
            this.txtnrocuenta.TabIndex = 6;
            // 
            // txtidp
            // 
            this.txtidp.Location = new System.Drawing.Point(174, 12);
            this.txtidp.Name = "txtidp";
            this.txtidp.Size = new System.Drawing.Size(149, 20);
            this.txtidp.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "TIPO DE CUENTA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "SALDO";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "NRO CUENTA";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "ID PERSONA";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // dgvCuenta
            // 
            this.dgvCuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuenta.Location = new System.Drawing.Point(370, 271);
            this.dgvCuenta.Name = "dgvCuenta";
            this.dgvCuenta.Size = new System.Drawing.Size(418, 206);
            this.dgvCuenta.TabIndex = 3;
            this.dgvCuenta.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCuenta_CellDoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 522);
            this.Controls.Add(this.dgvCuenta);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvpersonas);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpersonas)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuenta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnmodificar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.TextBox txtdireccion;
        private System.Windows.Forms.TextBox txtrol;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.DataGridView dgvpersonas;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtidc;
        private System.Windows.Forms.Button btnmodificarc;
        private System.Windows.Forms.Button btneliminarc;
        private System.Windows.Forms.Button btnagregarc;
        private System.Windows.Forms.TextBox txttipo;
        private System.Windows.Forms.TextBox txtsaldo;
        private System.Windows.Forms.TextBox txtnrocuenta;
        private System.Windows.Forms.TextBox txtidp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvCuenta;
    }
}

