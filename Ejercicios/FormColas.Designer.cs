namespace Ejercicio_de_Seminario
{
    partial class FormColas
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
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCola
            // 
            this.dgvCola.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.dgvCola.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvCola.Location = new System.Drawing.Point(370, 156);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.Size = new System.Drawing.Size(285, 310);
            this.dgvCola.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Cola";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
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
            this.panel1.Location = new System.Drawing.Point(11, 171);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(228, 303);
            this.panel1.TabIndex = 7;
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
            this.btn_agregar.Text = "Agregar a la Cola";
            this.btn_agregar.UseVisualStyleBackColor = true;
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
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(-2, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 75);
            this.label1.TabIndex = 6;
            this.label1.Text = "Realizar una lista de almenos 5 elementos visualizarlos todos, ordenarlos, elimin" +
    "ar 2 y luego recuperar los\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormColas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(668, 472);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "FormColas";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormColas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCola;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}