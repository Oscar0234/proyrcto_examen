namespace formulario2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.factura = new System.Windows.Forms.Label();
            this.numero = new System.Windows.Forms.Label();
            this.cliente = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.direccion = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.descripcion = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.Precio = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Valor = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.añadir2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // factura
            // 
            this.factura.AutoSize = true;
            this.factura.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.factura.Location = new System.Drawing.Point(12, 9);
            this.factura.Name = "factura";
            this.factura.Size = new System.Drawing.Size(222, 25);
            this.factura.TabIndex = 0;
            this.factura.Text = "FACTURA DE CONTADO";
            this.factura.Click += new System.EventHandler(this.label1_Click);
            // 
            // numero
            // 
            this.numero.AutoSize = true;
            this.numero.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numero.Location = new System.Drawing.Point(828, 9);
            this.numero.Name = "numero";
            this.numero.Size = new System.Drawing.Size(65, 20);
            this.numero.TabIndex = 2;
            this.numero.Text = "NO.C-00";
            // 
            // cliente
            // 
            this.cliente.AutoSize = true;
            this.cliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cliente.Location = new System.Drawing.Point(35, 46);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(55, 20);
            this.cliente.TabIndex = 3;
            this.cliente.Text = "Cliente";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 69);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(118, 23);
            this.textBox1.TabIndex = 4;
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.direccion.Location = new System.Drawing.Point(175, 46);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(72, 20);
            this.direccion.TabIndex = 5;
            this.direccion.Text = "Dirección";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(154, 71);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 23);
            this.textBox2.TabIndex = 6;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cantidad.Location = new System.Drawing.Point(330, 46);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(50, 20);
            this.Cantidad.TabIndex = 7;
            this.Cantidad.Text = "CANT.";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(293, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(126, 23);
            this.textBox3.TabIndex = 8;
            // 
            // descripcion
            // 
            this.descripcion.AutoSize = true;
            this.descripcion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.descripcion.Location = new System.Drawing.Point(474, 46);
            this.descripcion.Name = "descripcion";
            this.descripcion.Size = new System.Drawing.Size(101, 20);
            this.descripcion.TabIndex = 9;
            this.descripcion.Text = "DESCRIPCION";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(443, 71);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(176, 23);
            this.textBox4.TabIndex = 10;
            // 
            // Precio
            // 
            this.Precio.AutoSize = true;
            this.Precio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Precio.Location = new System.Drawing.Point(655, 46);
            this.Precio.Name = "Precio";
            this.Precio.Size = new System.Drawing.Size(56, 20);
            this.Precio.TabIndex = 11;
            this.Precio.Text = "P.UNIT.";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(634, 69);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 12;
            // 
            // Valor
            // 
            this.Valor.AutoSize = true;
            this.Valor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Valor.Location = new System.Drawing.Point(763, 46);
            this.Valor.Name = "Valor";
            this.Valor.Size = new System.Drawing.Size(98, 20);
            this.Valor.TabIndex = 13;
            this.Valor.Text = "VALOR TOTAL";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(750, 69);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(131, 23);
            this.textBox6.TabIndex = 14;
            // 
            // añadir2
            // 
            this.añadir2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.añadir2.Location = new System.Drawing.Point(426, 130);
            this.añadir2.Name = "añadir2";
            this.añadir2.Size = new System.Drawing.Size(81, 27);
            this.añadir2.TabIndex = 15;
            this.añadir2.Text = "AÑADIR";
            this.añadir2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(154, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(645, 150);
            this.dataGridView1.TabIndex = 16;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Column2";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Column3";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Column4";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Column5";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Column6";
            this.Column6.Name = "Column6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.añadir2);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.Valor);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.Precio);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.descripcion);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.Cantidad);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.direccion);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.numero);
            this.Controls.Add(this.factura);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label factura;
        private Label numero;
        private Label cliente;
        private TextBox textBox1;
        private Label direccion;
        private TextBox textBox2;
        private Label Cantidad;
        private TextBox textBox3;
        private Label descripcion;
        private TextBox textBox4;
        private Label Precio;
        private TextBox textBox5;
        private Label Valor;
        private TextBox textBox6;
        private Button añadir2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}