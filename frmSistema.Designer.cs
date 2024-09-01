namespace TP_2___FInal
{
    partial class frmSistema
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
            this.Tareas = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblCate = new System.Windows.Forms.Label();
            this.lblespecial = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCodigoTarea = new System.Windows.Forms.TextBox();
            this.btnModificarTarea = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnBorrarTarea = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtDescDesa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.txtTareaValor = new System.Windows.Forms.TextBox();
            this.txtTareaNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Equipo = new System.Windows.Forms.GroupBox();
            this.btnBorrarEquipo = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnClonar = new System.Windows.Forms.Button();
            this.btnBuscarEquipo = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridViewEquipos = new System.Windows.Forms.DataGridView();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dataGridViewProyecto = new System.Windows.Forms.DataGridView();
            this.txtNombreProyecto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lblValortotal = new System.Windows.Forms.Label();
            this.Tareas.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Equipo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyecto)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tareas
            // 
            this.Tareas.Controls.Add(this.groupBox6);
            this.Tareas.Controls.Add(this.groupBox2);
            this.Tareas.Controls.Add(this.btnBorrarTarea);
            this.Tareas.Controls.Add(this.button1);
            this.Tareas.Controls.Add(this.dataGridView1);
            this.Tareas.Controls.Add(this.groupBox1);
            this.Tareas.Controls.Add(this.txtTareaValor);
            this.Tareas.Controls.Add(this.txtTareaNombre);
            this.Tareas.Controls.Add(this.label2);
            this.Tareas.Controls.Add(this.label1);
            this.Tareas.Enabled = false;
            this.Tareas.Location = new System.Drawing.Point(12, 181);
            this.Tareas.Name = "Tareas";
            this.Tareas.Size = new System.Drawing.Size(848, 238);
            this.Tareas.TabIndex = 0;
            this.Tareas.TabStop = false;
            this.Tareas.Text = "Tareas";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblCate);
            this.groupBox6.Controls.Add(this.lblespecial);
            this.groupBox6.Controls.Add(this.label);
            this.groupBox6.Location = new System.Drawing.Point(421, 185);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(421, 47);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Descripcion:";
            // 
            // lblCate
            // 
            this.lblCate.AutoSize = true;
            this.lblCate.Location = new System.Drawing.Point(72, 22);
            this.lblCate.Name = "lblCate";
            this.lblCate.Size = new System.Drawing.Size(10, 13);
            this.lblCate.TabIndex = 12;
            this.lblCate.Text = "-";
            this.lblCate.Click += new System.EventHandler(this.lblCate_Click);
            // 
            // lblespecial
            // 
            this.lblespecial.AutoSize = true;
            this.lblespecial.Location = new System.Drawing.Point(167, 22);
            this.lblespecial.Name = "lblespecial";
            this.lblespecial.Size = new System.Drawing.Size(10, 13);
            this.lblespecial.TabIndex = 11;
            this.lblespecial.Text = "-";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(11, 22);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(55, 13);
            this.label.TabIndex = 10;
            this.label.Text = "Categoria:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtCodigoTarea);
            this.groupBox2.Controls.Add(this.btnModificarTarea);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(0, 87);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(168, 92);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modificar";
            // 
            // txtCodigoTarea
            // 
            this.txtCodigoTarea.Location = new System.Drawing.Point(58, 19);
            this.txtCodigoTarea.Name = "txtCodigoTarea";
            this.txtCodigoTarea.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoTarea.TabIndex = 10;
            // 
            // btnModificarTarea
            // 
            this.btnModificarTarea.Location = new System.Drawing.Point(49, 52);
            this.btnModificarTarea.Name = "btnModificarTarea";
            this.btnModificarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnModificarTarea.TabIndex = 7;
            this.btnModificarTarea.Text = "Modificar";
            this.btnModificarTarea.UseVisualStyleBackColor = true;
            this.btnModificarTarea.Click += new System.EventHandler(this.btnModificarTarea_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Codigo:";
            // 
            // btnBorrarTarea
            // 
            this.btnBorrarTarea.Location = new System.Drawing.Point(339, 185);
            this.btnBorrarTarea.Name = "btnBorrarTarea";
            this.btnBorrarTarea.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarTarea.TabIndex = 8;
            this.btnBorrarTarea.Text = "Borrar";
            this.btnBorrarTarea.UseVisualStyleBackColor = true;
            this.btnBorrarTarea.Click += new System.EventHandler(this.btnBorrarTarea_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Crear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(420, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(422, 150);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.txtDescDesa);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboCategoria);
            this.groupBox1.Location = new System.Drawing.Point(174, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(240, 157);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Descripcion:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 116);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // txtDescDesa
            // 
            this.txtDescDesa.Location = new System.Drawing.Point(6, 65);
            this.txtDescDesa.Name = "txtDescDesa";
            this.txtDescDesa.Size = new System.Drawing.Size(176, 20);
            this.txtDescDesa.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Descripcion:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Location = new System.Drawing.Point(6, 19);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 0;
            // 
            // txtTareaValor
            // 
            this.txtTareaValor.Location = new System.Drawing.Point(58, 57);
            this.txtTareaValor.Name = "txtTareaValor";
            this.txtTareaValor.Size = new System.Drawing.Size(100, 20);
            this.txtTareaValor.TabIndex = 3;
            // 
            // txtTareaNombre
            // 
            this.txtTareaNombre.Location = new System.Drawing.Point(58, 29);
            this.txtTareaNombre.Name = "txtTareaNombre";
            this.txtTareaNombre.Size = new System.Drawing.Size(100, 20);
            this.txtTareaNombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // Equipo
            // 
            this.Equipo.Controls.Add(this.groupBox7);
            this.Equipo.Controls.Add(this.btnBorrarEquipo);
            this.Equipo.Controls.Add(this.groupBox3);
            this.Equipo.Controls.Add(this.button2);
            this.Equipo.Controls.Add(this.dataGridViewEquipos);
            this.Equipo.Controls.Add(this.txtNombreEquipo);
            this.Equipo.Controls.Add(this.label8);
            this.Equipo.Location = new System.Drawing.Point(12, 12);
            this.Equipo.Name = "Equipo";
            this.Equipo.Size = new System.Drawing.Size(848, 163);
            this.Equipo.TabIndex = 7;
            this.Equipo.TabStop = false;
            this.Equipo.Text = "Equipos";
            // 
            // btnBorrarEquipo
            // 
            this.btnBorrarEquipo.Location = new System.Drawing.Point(49, 114);
            this.btnBorrarEquipo.Name = "btnBorrarEquipo";
            this.btnBorrarEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarEquipo.TabIndex = 9;
            this.btnBorrarEquipo.Text = "Borrar";
            this.btnBorrarEquipo.UseVisualStyleBackColor = true;
            this.btnBorrarEquipo.Click += new System.EventHandler(this.btnBorrarEquipo_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.btnClonar);
            this.groupBox3.Controls.Add(this.btnBuscarEquipo);
            this.groupBox3.Location = new System.Drawing.Point(517, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(325, 87);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Buscar o clonar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "-";
            // 
            // btnClonar
            // 
            this.btnClonar.Location = new System.Drawing.Point(112, 19);
            this.btnClonar.Name = "btnClonar";
            this.btnClonar.Size = new System.Drawing.Size(75, 23);
            this.btnClonar.TabIndex = 10;
            this.btnClonar.Text = "Clonar";
            this.btnClonar.UseVisualStyleBackColor = true;
            this.btnClonar.Click += new System.EventHandler(this.btnClonar_Click);
            // 
            // btnBuscarEquipo
            // 
            this.btnBuscarEquipo.Location = new System.Drawing.Point(20, 19);
            this.btnBuscarEquipo.Name = "btnBuscarEquipo";
            this.btnBuscarEquipo.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarEquipo.TabIndex = 9;
            this.btnBuscarEquipo.Text = "Buscar";
            this.btnBuscarEquipo.UseVisualStyleBackColor = true;
            this.btnBuscarEquipo.Click += new System.EventHandler(this.btnBuscarEquipo_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(49, 83);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Crear";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridViewEquipos
            // 
            this.dataGridViewEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEquipos.Location = new System.Drawing.Point(190, 19);
            this.dataGridViewEquipos.Name = "dataGridViewEquipos";
            this.dataGridViewEquipos.Size = new System.Drawing.Size(321, 126);
            this.dataGridViewEquipos.TabIndex = 5;
            this.dataGridViewEquipos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEquipos_CellContentClick);
            // 
            // txtNombreEquipo
            // 
            this.txtNombreEquipo.Location = new System.Drawing.Point(69, 26);
            this.txtNombreEquipo.Name = "txtNombreEquipo";
            this.txtNombreEquipo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreEquipo.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Nombre:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button3);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.button6);
            this.groupBox4.Controls.Add(this.dataGridViewProyecto);
            this.groupBox4.Controls.Add(this.txtNombreProyecto);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Enabled = false;
            this.groupBox4.Location = new System.Drawing.Point(12, 425);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(848, 163);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Proyecto:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(49, 114);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Borrar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.button5);
            this.groupBox5.Location = new System.Drawing.Point(517, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(325, 126);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Buscar o clonar";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 95);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Clonar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Nombre:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(7, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 8;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(20, 66);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Buscar";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(49, 83);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 6;
            this.button6.Text = "Crear";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // dataGridViewProyecto
            // 
            this.dataGridViewProyecto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProyecto.Location = new System.Drawing.Point(190, 19);
            this.dataGridViewProyecto.Name = "dataGridViewProyecto";
            this.dataGridViewProyecto.Size = new System.Drawing.Size(321, 126);
            this.dataGridViewProyecto.TabIndex = 5;
            this.dataGridViewProyecto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProyecto_CellContentClick);
            // 
            // txtNombreProyecto
            // 
            this.txtNombreProyecto.Location = new System.Drawing.Point(69, 26);
            this.txtNombreProyecto.Name = "txtNombreProyecto";
            this.txtNombreProyecto.Size = new System.Drawing.Size(100, 20);
            this.txtNombreProyecto.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lblValortotal);
            this.groupBox7.Location = new System.Drawing.Point(517, 112);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(325, 45);
            this.groupBox7.TabIndex = 11;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Valor total de tareas:";
            // 
            // lblValortotal
            // 
            this.lblValortotal.AutoSize = true;
            this.lblValortotal.Location = new System.Drawing.Point(17, 20);
            this.lblValortotal.Name = "lblValortotal";
            this.lblValortotal.Size = new System.Drawing.Size(10, 13);
            this.lblValortotal.TabIndex = 14;
            this.lblValortotal.Text = "-";
            // 
            // frmSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 604);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.Equipo);
            this.Controls.Add(this.Tareas);
            this.Name = "frmSistema";
            this.Text = "frmSistema";
            this.Load += new System.EventHandler(this.frmSistema_Load);
            this.Tareas.ResumeLayout(false);
            this.Tareas.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Equipo.ResumeLayout(false);
            this.Equipo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEquipos)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProyecto)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Tareas;
        private System.Windows.Forms.TextBox txtTareaNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTareaValor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtDescDesa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox Equipo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridViewEquipos;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnBorrarTarea;
        private System.Windows.Forms.Button btnModificarTarea;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtCodigoTarea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnBorrarEquipo;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClonar;
        private System.Windows.Forms.Button btnBuscarEquipo;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DataGridView dataGridViewProyecto;
        private System.Windows.Forms.TextBox txtNombreProyecto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblCate;
        private System.Windows.Forms.Label lblespecial;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lblValortotal;
    }
}