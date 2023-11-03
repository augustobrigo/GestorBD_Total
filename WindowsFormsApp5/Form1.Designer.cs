namespace WindowsFormsApp5
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_TodasBD = new System.Windows.Forms.Button();
            this.verUnaBD = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listContenidosTotal = new System.Windows.Forms.ListBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ListContenidos = new System.Windows.Forms.ListBox();
            this.listaTabla = new System.Windows.Forms.ListBox();
            this.listBoxBD = new System.Windows.Forms.ListBox();
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.textbox6 = new System.Windows.Forms.TextBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(657, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 92);
            this.button1.TabIndex = 0;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(122, 92);
            this.button2.TabIndex = 1;
            this.button2.Text = "Servidor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(140, 9);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(122, 92);
            this.button3.TabIndex = 2;
            this.button3.Text = "BD";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(268, 9);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(122, 92);
            this.button4.TabIndex = 3;
            this.button4.Text = "Usuario";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(396, 9);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 92);
            this.button5.TabIndex = 4;
            this.button5.Text = "Password";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(524, 9);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(124, 92);
            this.button6.TabIndex = 5;
            this.button6.Text = "ConsultaSQL";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Servidor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(150, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Base de datos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Usuario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(426, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password";
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(12, 192);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(124, 20);
            this.txtServidor.TabIndex = 11;
            // 
            // txtBD
            // 
            this.txtBD.Enabled = false;
            this.txtBD.Location = new System.Drawing.Point(142, 192);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(149, 20);
            this.txtBD.TabIndex = 12;
            // 
            // txtUser
            // 
            this.txtUser.Enabled = false;
            this.txtUser.Location = new System.Drawing.Point(307, 192);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(149, 20);
            this.txtUser.TabIndex = 13;
            // 
            // txtPwd
            // 
            this.txtPwd.Enabled = false;
            this.txtPwd.Location = new System.Drawing.Point(462, 192);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(149, 20);
            this.txtPwd.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(30, 280);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(599, 26);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(183, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 24);
            this.label5.TabIndex = 16;
            this.label5.Text = "Consulta SQL (select)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(187, 409);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(269, 95);
            this.button7.TabIndex = 17;
            this.button7.Text = "Mostrar/Ejecutar";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_TodasBD
            // 
            this.btn_TodasBD.Enabled = false;
            this.btn_TodasBD.Location = new System.Drawing.Point(1010, 12);
            this.btn_TodasBD.Name = "btn_TodasBD";
            this.btn_TodasBD.Size = new System.Drawing.Size(122, 92);
            this.btn_TodasBD.TabIndex = 18;
            this.btn_TodasBD.Text = "Todas las BD (c:/seguridad/)\r\n";
            this.btn_TodasBD.UseVisualStyleBackColor = true;
            this.btn_TodasBD.Click += new System.EventHandler(this.btn_TodasBD_Click);
            // 
            // verUnaBD
            // 
            this.verUnaBD.Enabled = false;
            this.verUnaBD.Location = new System.Drawing.Point(845, 12);
            this.verUnaBD.Name = "verUnaBD";
            this.verUnaBD.Size = new System.Drawing.Size(122, 92);
            this.verUnaBD.TabIndex = 19;
            this.verUnaBD.Text = "Ver una BD";
            this.verUnaBD.UseVisualStyleBackColor = true;
            this.verUnaBD.Click += new System.EventHandler(this.button9_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.listContenidosTotal);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.ListContenidos);
            this.groupBox2.Controls.Add(this.listaTabla);
            this.groupBox2.Location = new System.Drawing.Point(635, 185);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 232);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NombreBD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(350, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Contenidos";
            // 
            // listContenidosTotal
            // 
            this.listContenidosTotal.FormattingEnabled = true;
            this.listContenidosTotal.Location = new System.Drawing.Point(348, 34);
            this.listContenidosTotal.Name = "listContenidosTotal";
            this.listContenidosTotal.Size = new System.Drawing.Size(376, 173);
            this.listContenidosTotal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nombre campos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Tablas";
            // 
            // ListContenidos
            // 
            this.ListContenidos.FormattingEnabled = true;
            this.ListContenidos.Location = new System.Drawing.Point(196, 34);
            this.ListContenidos.Name = "ListContenidos";
            this.ListContenidos.Size = new System.Drawing.Size(124, 173);
            this.ListContenidos.TabIndex = 1;
            // 
            // listaTabla
            // 
            this.listaTabla.FormattingEnabled = true;
            this.listaTabla.Location = new System.Drawing.Point(30, 34);
            this.listaTabla.Name = "listaTabla";
            this.listaTabla.Size = new System.Drawing.Size(120, 173);
            this.listaTabla.TabIndex = 0;
            this.listaTabla.SelectedIndexChanged += new System.EventHandler(this.listaTabla_SelectedIndexChanged);
            // 
            // listBoxBD
            // 
            this.listBoxBD.FormattingEnabled = true;
            this.listBoxBD.Location = new System.Drawing.Point(1139, 13);
            this.listBoxBD.Name = "listBoxBD";
            this.listBoxBD.Size = new System.Drawing.Size(149, 147);
            this.listBoxBD.TabIndex = 21;
            this.listBoxBD.SelectedIndexChanged += new System.EventHandler(this.listBoxBD_SelectedIndexChanged);
            // 
            // btnImportar
            // 
            this.btnImportar.Enabled = false;
            this.btnImportar.Location = new System.Drawing.Point(723, 121);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(117, 51);
            this.btnImportar.TabIndex = 23;
            this.btnImportar.Text = "Importar BD";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.btnImportar_Click);
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(591, 121);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(117, 51);
            this.btnExportar.TabIndex = 22;
            this.btnExportar.Text = "Exportar BD";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(624, 423);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(735, 126);
            this.dataGridView1.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(184, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(334, 24);
            this.label9.TabIndex = 26;
            this.label9.Text = "Consulta SQL (Insert, Update, delete...)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textbox6
            // 
            this.textbox6.Enabled = false;
            this.textbox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox6.Location = new System.Drawing.Point(19, 353);
            this.textbox6.Name = "textbox6";
            this.textbox6.Size = new System.Drawing.Size(599, 26);
            this.textbox6.TabIndex = 25;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(866, 121);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(117, 51);
            this.button8.TabIndex = 27;
            this.button8.Text = "BD--Lista--FT";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Enabled = false;
            this.button9.Location = new System.Drawing.Point(1000, 121);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(117, 51);
            this.button9.TabIndex = 28;
            this.button9.Text = "FT-Lista--BD";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1373, 561);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textbox6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.listBoxBD);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.verUnaBD);
            this.Controls.Add(this.btn_TodasBD);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Proyecto5";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_TodasBD;
        private System.Windows.Forms.Button verUnaBD;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox listContenidosTotal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox ListContenidos;
        private System.Windows.Forms.ListBox listaTabla;
        private System.Windows.Forms.ListBox listBoxBD;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textbox6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
    }
}

