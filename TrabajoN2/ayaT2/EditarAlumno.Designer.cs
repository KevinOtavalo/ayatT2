namespace ayaT2
{
    partial class EditarAlumno
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
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.txb_NombreAlumno = new System.Windows.Forms.TextBox();
            this.txb_NumeroMatricula = new System.Windows.Forms.TextBox();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_ApellidoMat = new System.Windows.Forms.TextBox();
            this.txb_ApellidoPat = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(178, 238);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 25;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Location = new System.Drawing.Point(61, 238);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_Guardar.TabIndex = 24;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // txb_NombreAlumno
            // 
            this.txb_NombreAlumno.Location = new System.Drawing.Point(169, 59);
            this.txb_NombreAlumno.Name = "txb_NombreAlumno";
            this.txb_NombreAlumno.Size = new System.Drawing.Size(100, 20);
            this.txb_NombreAlumno.TabIndex = 23;
            // 
            // txb_NumeroMatricula
            // 
            this.txb_NumeroMatricula.Location = new System.Drawing.Point(169, 183);
            this.txb_NumeroMatricula.Name = "txb_NumeroMatricula";
            this.txb_NumeroMatricula.Size = new System.Drawing.Size(100, 20);
            this.txb_NumeroMatricula.TabIndex = 22;
            // 
            // txb_Email
            // 
            this.txb_Email.Location = new System.Drawing.Point(169, 154);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(100, 20);
            this.txb_Email.TabIndex = 21;
            // 
            // txb_ApellidoMat
            // 
            this.txb_ApellidoMat.Location = new System.Drawing.Point(169, 120);
            this.txb_ApellidoMat.Name = "txb_ApellidoMat";
            this.txb_ApellidoMat.Size = new System.Drawing.Size(100, 20);
            this.txb_ApellidoMat.TabIndex = 20;
            // 
            // txb_ApellidoPat
            // 
            this.txb_ApellidoPat.Location = new System.Drawing.Point(169, 90);
            this.txb_ApellidoPat.Name = "txb_ApellidoPat";
            this.txb_ApellidoPat.Size = new System.Drawing.Size(100, 20);
            this.txb_ApellidoPat.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(72, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Numero Matricula";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Apellido Materno";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Apellido Paterno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(99, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 26;
            this.label6.Text = "Edita el alumno";
            // 
            // EditarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 321);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.txb_NombreAlumno);
            this.Controls.Add(this.txb_NumeroMatricula);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_ApellidoMat);
            this.Controls.Add(this.txb_ApellidoPat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "EditarAlumno";
            this.Text = "EditarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox txb_NombreAlumno;
        private System.Windows.Forms.TextBox txb_NumeroMatricula;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_ApellidoMat;
        private System.Windows.Forms.TextBox txb_ApellidoPat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
    }
}