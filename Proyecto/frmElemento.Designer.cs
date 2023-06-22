namespace Proyecto
{
    partial class frmElemento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.combocategoria = new System.Windows.Forms.ComboBox();
            this.comboambiente = new System.Windows.Forms.ComboBox();
            this.comboestado = new System.Windows.Forms.ComboBox();
            this.combodisponibilidad = new System.Windows.Forms.ComboBox();
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.txtvalor = new System.Windows.Forms.TextBox();
            this.txtplaca = new System.Windows.Forms.TextBox();
            this.btnguardar = new FontAwesome.Sharp.IconButton();
            this.btninhabilitar = new FontAwesome.Sharp.IconButton();
            this.btnlimpiar = new FontAwesome.Sharp.IconButton();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.Seleccion = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Placa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ambiente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Disponibilidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.txtindice = new System.Windows.Forms.TextBox();
            this.txtidelemento = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(0, -5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 458);
            this.label1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos del elemento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Silver;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 98);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Elemento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Silver;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 130);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoría:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Silver;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 160);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placa SENA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Silver;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 190);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ambiente";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Silver;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Estado:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Silver;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 17);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor del objeto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Silver;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 281);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 17);
            this.label9.TabIndex = 8;
            this.label9.Text = "Marca:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Silver;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(20, 313);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(100, 17);
            this.label10.TabIndex = 9;
            this.label10.Text = "Disponibilidad:";
            // 
            // combocategoria
            // 
            this.combocategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combocategoria.FormattingEnabled = true;
            this.combocategoria.Location = new System.Drawing.Point(139, 128);
            this.combocategoria.Margin = new System.Windows.Forms.Padding(2);
            this.combocategoria.Name = "combocategoria";
            this.combocategoria.Size = new System.Drawing.Size(137, 21);
            this.combocategoria.TabIndex = 10;
            // 
            // comboambiente
            // 
            this.comboambiente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboambiente.FormattingEnabled = true;
            this.comboambiente.Location = new System.Drawing.Point(139, 188);
            this.comboambiente.Margin = new System.Windows.Forms.Padding(2);
            this.comboambiente.Name = "comboambiente";
            this.comboambiente.Size = new System.Drawing.Size(137, 21);
            this.comboambiente.TabIndex = 11;
            // 
            // comboestado
            // 
            this.comboestado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboestado.FormattingEnabled = true;
            this.comboestado.Location = new System.Drawing.Point(139, 218);
            this.comboestado.Margin = new System.Windows.Forms.Padding(2);
            this.comboestado.Name = "comboestado";
            this.comboestado.Size = new System.Drawing.Size(137, 21);
            this.comboestado.TabIndex = 12;
            // 
            // combodisponibilidad
            // 
            this.combodisponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combodisponibilidad.FormattingEnabled = true;
            this.combodisponibilidad.Location = new System.Drawing.Point(139, 311);
            this.combodisponibilidad.Margin = new System.Windows.Forms.Padding(2);
            this.combodisponibilidad.Name = "combodisponibilidad";
            this.combodisponibilidad.Size = new System.Drawing.Size(137, 21);
            this.combodisponibilidad.TabIndex = 13;
            // 
            // txtelemento
            // 
            this.txtelemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtelemento.Location = new System.Drawing.Point(139, 98);
            this.txtelemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(136, 20);
            this.txtelemento.TabIndex = 14;
            // 
            // txtmarca
            // 
            this.txtmarca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtmarca.Location = new System.Drawing.Point(139, 281);
            this.txtmarca.Margin = new System.Windows.Forms.Padding(2);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(136, 20);
            this.txtmarca.TabIndex = 15;
            // 
            // txtvalor
            // 
            this.txtvalor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtvalor.Location = new System.Drawing.Point(139, 251);
            this.txtvalor.Margin = new System.Windows.Forms.Padding(2);
            this.txtvalor.Name = "txtvalor";
            this.txtvalor.Size = new System.Drawing.Size(136, 20);
            this.txtvalor.TabIndex = 16;
            // 
            // txtplaca
            // 
            this.txtplaca.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtplaca.Location = new System.Drawing.Point(139, 160);
            this.txtplaca.Margin = new System.Windows.Forms.Padding(2);
            this.txtplaca.Name = "txtplaca";
            this.txtplaca.Size = new System.Drawing.Size(136, 20);
            this.txtplaca.TabIndex = 17;
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.ForestGreen;
            this.btnguardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnguardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnguardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnguardar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnguardar.IconColor = System.Drawing.Color.Black;
            this.btnguardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnguardar.Location = new System.Drawing.Point(50, 361);
            this.btnguardar.Margin = new System.Windows.Forms.Padding(2);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(84, 27);
            this.btnguardar.TabIndex = 18;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // btninhabilitar
            // 
            this.btninhabilitar.BackColor = System.Drawing.Color.Crimson;
            this.btninhabilitar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btninhabilitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btninhabilitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninhabilitar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btninhabilitar.IconColor = System.Drawing.Color.Black;
            this.btninhabilitar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btninhabilitar.Location = new System.Drawing.Point(152, 361);
            this.btninhabilitar.Margin = new System.Windows.Forms.Padding(2);
            this.btninhabilitar.Name = "btninhabilitar";
            this.btninhabilitar.Size = new System.Drawing.Size(84, 27);
            this.btninhabilitar.TabIndex = 19;
            this.btninhabilitar.Text = "Inhabilitar";
            this.btninhabilitar.UseVisualStyleBackColor = false;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.BackColor = System.Drawing.Color.Gray;
            this.btnlimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnlimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnlimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpiar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnlimpiar.IconColor = System.Drawing.Color.Black;
            this.btnlimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnlimpiar.Location = new System.Drawing.Point(72, 396);
            this.btnlimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(149, 28);
            this.btnlimpiar.TabIndex = 21;
            this.btnlimpiar.Text = "Limpiar formulario";
            this.btnlimpiar.UseVisualStyleBackColor = false;
            this.btnlimpiar.Click += new System.EventHandler(this.btnlimpiar_Click);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1, 12);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(300, 58);
            this.label11.TabIndex = 22;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccion,
            this.Id,
            this.Tipo,
            this.Categoria,
            this.Placa,
            this.Ambiente,
            this.Estado,
            this.Valor,
            this.Disponibilidad});
            this.dgvdata.Location = new System.Drawing.Point(372, 85);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(868, 316);
            this.dgvdata.TabIndex = 23;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            // 
            // Seleccion
            // 
            this.Seleccion.HeaderText = "";
            this.Seleccion.Name = "Seleccion";
            this.Seleccion.Width = 25;
            // 
            // Id
            // 
            this.Id.HeaderText = "Elemento";
            this.Id.Name = "Id";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Placa
            // 
            this.Placa.HeaderText = "Placa";
            this.Placa.Name = "Placa";
            // 
            // Ambiente
            // 
            this.Ambiente.HeaderText = "Ambiente";
            this.Ambiente.Name = "Ambiente";
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // Disponibilidad
            // 
            this.Disponibilidad.HeaderText = "Disponibilidad";
            this.Disponibilidad.Name = "Disponibilidad";
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(369, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(871, 52);
            this.label12.TabIndex = 24;
            this.label12.Text = "ELEMENTOS REGISTRADOS";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtindice
            // 
            this.txtindice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtindice.Location = new System.Drawing.Point(11, 72);
            this.txtindice.Margin = new System.Windows.Forms.Padding(2);
            this.txtindice.Name = "txtindice";
            this.txtindice.Size = new System.Drawing.Size(22, 20);
            this.txtindice.TabIndex = 25;
            // 
            // txtidelemento
            // 
            this.txtidelemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtidelemento.Location = new System.Drawing.Point(269, 72);
            this.txtidelemento.Margin = new System.Windows.Forms.Padding(2);
            this.txtidelemento.Name = "txtidelemento";
            this.txtidelemento.Size = new System.Drawing.Size(22, 20);
            this.txtidelemento.TabIndex = 26;
            // 
            // frmElemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1282, 460);
            this.Controls.Add(this.txtidelemento);
            this.Controls.Add(this.txtindice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btninhabilitar);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtplaca);
            this.Controls.Add(this.txtvalor);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.txtelemento);
            this.Controls.Add(this.combodisponibilidad);
            this.Controls.Add(this.comboestado);
            this.Controls.Add(this.comboambiente);
            this.Controls.Add(this.combocategoria);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmElemento";
            this.Text = "frmElemento";
            this.Load += new System.EventHandler(this.frmElemento_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox combocategoria;
        private System.Windows.Forms.ComboBox comboambiente;
        private System.Windows.Forms.ComboBox comboestado;
        private System.Windows.Forms.ComboBox combodisponibilidad;
        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.TextBox txtvalor;
        private System.Windows.Forms.TextBox txtplaca;
        private FontAwesome.Sharp.IconButton btnguardar;
        private FontAwesome.Sharp.IconButton btninhabilitar;
        private FontAwesome.Sharp.IconButton btnlimpiar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvdata;
        private System.Windows.Forms.DataGridViewButtonColumn Seleccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Placa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ambiente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Disponibilidad;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtindice;
        private System.Windows.Forms.TextBox txtidelemento;
    }
}