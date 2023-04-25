namespace pryManejo_de_cadenas
{
    partial class frmMain
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
            this.lblTextoa = new System.Windows.Forms.Label();
            this.lblTextob = new System.Windows.Forms.Label();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnComparar = new System.Windows.Forms.Button();
            this.btnRemplazar = new System.Windows.Forms.Button();
            this.lblTexta = new System.Windows.Forms.Label();
            this.lblTextb = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnConvertir = new System.Windows.Forms.Button();
            this.lblFech = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextoa
            // 
            this.lblTextoa.AutoSize = true;
            this.lblTextoa.Location = new System.Drawing.Point(29, 33);
            this.lblTextoa.Name = "lblTextoa";
            this.lblTextoa.Size = new System.Drawing.Size(41, 13);
            this.lblTextoa.TabIndex = 0;
            this.lblTextoa.Text = "TextoA";
            // 
            // lblTextob
            // 
            this.lblTextob.AutoSize = true;
            this.lblTextob.Location = new System.Drawing.Point(29, 74);
            this.lblTextob.Name = "lblTextob";
            this.lblTextob.Size = new System.Drawing.Size(41, 13);
            this.lblTextob.TabIndex = 1;
            this.lblTextob.Text = "TextoB";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(121, 30);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(166, 20);
            this.txtA.TabIndex = 2;
            this.txtA.TextChanged += new System.EventHandler(this.txtA_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(121, 74);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(166, 20);
            this.txtB.TabIndex = 3;
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(32, 109);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(121, 111);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(166, 20);
            this.txtBuscar.TabIndex = 5;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // btnComparar
            // 
            this.btnComparar.Location = new System.Drawing.Point(121, 154);
            this.btnComparar.Name = "btnComparar";
            this.btnComparar.Size = new System.Drawing.Size(75, 23);
            this.btnComparar.TabIndex = 6;
            this.btnComparar.Text = "Comparar";
            this.btnComparar.UseVisualStyleBackColor = true;
            this.btnComparar.Click += new System.EventHandler(this.btnComparar_Click);
            // 
            // btnRemplazar
            // 
            this.btnRemplazar.Location = new System.Drawing.Point(32, 154);
            this.btnRemplazar.Name = "btnRemplazar";
            this.btnRemplazar.Size = new System.Drawing.Size(75, 23);
            this.btnRemplazar.TabIndex = 7;
            this.btnRemplazar.Text = "Remplazar";
            this.btnRemplazar.UseVisualStyleBackColor = true;
            this.btnRemplazar.Click += new System.EventHandler(this.btnRemplazar_Click);
            // 
            // lblTexta
            // 
            this.lblTexta.AutoSize = true;
            this.lblTexta.Location = new System.Drawing.Point(303, 37);
            this.lblTexta.Name = "lblTexta";
            this.lblTexta.Size = new System.Drawing.Size(13, 13);
            this.lblTexta.TabIndex = 8;
            this.lblTexta.Text = "0";
            // 
            // lblTextb
            // 
            this.lblTextb.AutoSize = true;
            this.lblTextb.Location = new System.Drawing.Point(303, 77);
            this.lblTextb.Name = "lblTextb";
            this.lblTextb.Size = new System.Drawing.Size(13, 13);
            this.lblTextb.TabIndex = 9;
            this.lblTextb.Text = "0";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(29, 207);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 10;
            this.lblFecha.Text = "Fecha";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(121, 200);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 11;
            // 
            // btnConvertir
            // 
            this.btnConvertir.Location = new System.Drawing.Point(32, 255);
            this.btnConvertir.Name = "btnConvertir";
            this.btnConvertir.Size = new System.Drawing.Size(75, 23);
            this.btnConvertir.TabIndex = 12;
            this.btnConvertir.Text = "Convertir";
            this.btnConvertir.UseVisualStyleBackColor = true;
            this.btnConvertir.Click += new System.EventHandler(this.btnConvertir_Click);
            // 
            // lblFech
            // 
            this.lblFech.AutoSize = true;
            this.lblFech.Location = new System.Drawing.Point(118, 265);
            this.lblFech.Name = "lblFech";
            this.lblFech.Size = new System.Drawing.Size(37, 13);
            this.lblFech.TabIndex = 13;
            this.lblFech.Text = "Fecha";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(327, 305);
            this.Controls.Add(this.lblFech);
            this.Controls.Add(this.btnConvertir);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTextb);
            this.Controls.Add(this.lblTexta);
            this.Controls.Add(this.btnRemplazar);
            this.Controls.Add(this.btnComparar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.lblTextob);
            this.Controls.Add(this.lblTextoa);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manejo de Cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoa;
        private System.Windows.Forms.Label lblTextob;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnComparar;
        private System.Windows.Forms.Button btnRemplazar;
        private System.Windows.Forms.Label lblTexta;
        private System.Windows.Forms.Label lblTextb;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnConvertir;
        private System.Windows.Forms.Label lblFech;
    }
}

