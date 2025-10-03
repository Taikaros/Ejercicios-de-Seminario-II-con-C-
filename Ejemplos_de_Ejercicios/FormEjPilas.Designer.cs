namespace Ejercicio_de_Seminario
{
    partial class FormEjPilas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Recuperar = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_VerDato = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Ingresar = new System.Windows.Forms.TextBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(371, 81);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(285, 310);
            this.dataGridView1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.btn_Recuperar);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.btn_VerDato);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txb_Ingresar);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 303);
            this.panel1.TabIndex = 13;
            // 
            // btn_Recuperar
            // 
            this.btn_Recuperar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Recuperar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Recuperar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Recuperar.Location = new System.Drawing.Point(0, 243);
            this.btn_Recuperar.Name = "btn_Recuperar";
            this.btn_Recuperar.Size = new System.Drawing.Size(228, 57);
            this.btn_Recuperar.TabIndex = 13;
            this.btn_Recuperar.Text = "Recuperar";
            this.btn_Recuperar.UseVisualStyleBackColor = true;
            this.btn_Recuperar.Click += new System.EventHandler(this.btn_Recuperar_Click_1);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(0, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(228, 17);
            this.label9.TabIndex = 11;
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Eliminar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Eliminar.Location = new System.Drawing.Point(0, 171);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(228, 55);
            this.btn_Eliminar.TabIndex = 10;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(0, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 17);
            this.label7.TabIndex = 9;
            // 
            // btn_VerDato
            // 
            this.btn_VerDato.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_VerDato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerDato.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_VerDato.Location = new System.Drawing.Point(0, 104);
            this.btn_VerDato.Name = "btn_VerDato";
            this.btn_VerDato.Size = new System.Drawing.Size(228, 50);
            this.btn_VerDato.TabIndex = 6;
            this.btn_VerDato.Text = "Ver Dato";
            this.btn_VerDato.UseVisualStyleBackColor = true;
            this.btn_VerDato.Click += new System.EventHandler(this.btn_VerDato_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 17);
            this.label4.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 17);
            this.label3.TabIndex = 3;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_agregar.Location = new System.Drawing.Point(0, 37);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(228, 33);
            this.btn_agregar.TabIndex = 2;
            this.btn_agregar.Text = "Agregar a la Pila";
            this.btn_agregar.UseVisualStyleBackColor = true;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click_1);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 1;
            // 
            // txb_Ingresar
            // 
            this.txb_Ingresar.BackColor = System.Drawing.Color.Gainsboro;
            this.txb_Ingresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.txb_Ingresar.Location = new System.Drawing.Point(0, 0);
            this.txb_Ingresar.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.txb_Ingresar.Name = "txb_Ingresar";
            this.txb_Ingresar.Size = new System.Drawing.Size(228, 20);
            this.txb_Ingresar.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Pila";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // FormEjPilas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(668, 472);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormEjPilas";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormEjPilas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Recuperar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_VerDato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Ingresar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}