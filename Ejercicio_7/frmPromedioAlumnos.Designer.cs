namespace Ejercicio_7
{
  partial class frmPromedioAlumnos
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
      this.txtNombreAlumno = new System.Windows.Forms.TextBox();
      this.btnBorrarNombre = new System.Windows.Forms.Button();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtNota1 = new System.Windows.Forms.TextBox();
      this.btnAgregarNota = new System.Windows.Forms.Button();
      this.btnCalcularPromedios = new System.Windows.Forms.Button();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.btnAgregarAlumno = new System.Windows.Forms.Button();
      this.txtNota3 = new System.Windows.Forms.TextBox();
      this.txtNota2 = new System.Windows.Forms.TextBox();
      this.label9 = new System.Windows.Forms.Label();
      this.label8 = new System.Windows.Forms.Label();
      this.lstNombresAlumnos = new System.Windows.Forms.ListBox();
      this.lstNotas = new System.Windows.Forms.ListBox();
      this.lstPromediosAlumnos = new System.Windows.Forms.ListBox();
      this.label4 = new System.Windows.Forms.Label();
      this.label5 = new System.Windows.Forms.Label();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.lblPromedioGeneral = new System.Windows.Forms.TextBox();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.btnSalir = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.groupBox2.SuspendLayout();
      this.groupBox3.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(245, 20);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(1171, 37);
      this.label1.TabIndex = 0;
      this.label1.Text = "Calcular promedio y promedio general de los alumnos, siendo Alumno una clase.";
      // 
      // txtNombreAlumno
      // 
      this.txtNombreAlumno.Location = new System.Drawing.Point(244, 50);
      this.txtNombreAlumno.Name = "txtNombreAlumno";
      this.txtNombreAlumno.Size = new System.Drawing.Size(286, 31);
      this.txtNombreAlumno.TabIndex = 0;
      // 
      // btnBorrarNombre
      // 
      this.btnBorrarNombre.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnBorrarNombre.Location = new System.Drawing.Point(546, 43);
      this.btnBorrarNombre.Name = "btnBorrarNombre";
      this.btnBorrarNombre.Size = new System.Drawing.Size(43, 44);
      this.btnBorrarNombre.TabIndex = 4;
      this.btnBorrarNombre.Text = "X";
      this.btnBorrarNombre.UseVisualStyleBackColor = true;
      this.btnBorrarNombre.Click += new System.EventHandler(this.btnBorrarNombre_Click);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Cursor = System.Windows.Forms.Cursors.Default;
      this.label3.Location = new System.Drawing.Point(143, 53);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(87, 25);
      this.label3.TabIndex = 3;
      this.label3.Text = "Nombre";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Cursor = System.Windows.Forms.Cursors.Default;
      this.label2.Location = new System.Drawing.Point(170, 103);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(57, 25);
      this.label2.TabIndex = 3;
      this.label2.Text = "Nota";
      // 
      // txtNota1
      // 
      this.txtNota1.Location = new System.Drawing.Point(244, 100);
      this.txtNota1.Name = "txtNota1";
      this.txtNota1.Size = new System.Drawing.Size(109, 31);
      this.txtNota1.TabIndex = 1;
      // 
      // btnAgregarNota
      // 
      this.btnAgregarNota.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnAgregarNota.Enabled = false;
      this.btnAgregarNota.Location = new System.Drawing.Point(381, 100);
      this.btnAgregarNota.Name = "btnAgregarNota";
      this.btnAgregarNota.Size = new System.Drawing.Size(132, 80);
      this.btnAgregarNota.TabIndex = 5;
      this.btnAgregarNota.Text = "Agregar Nota";
      this.btnAgregarNota.UseVisualStyleBackColor = true;
      this.btnAgregarNota.Click += new System.EventHandler(this.btnAgregarNota_Click);
      // 
      // btnCalcularPromedios
      // 
      this.btnCalcularPromedios.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnCalcularPromedios.Location = new System.Drawing.Point(770, 212);
      this.btnCalcularPromedios.Name = "btnCalcularPromedios";
      this.btnCalcularPromedios.Size = new System.Drawing.Size(132, 80);
      this.btnCalcularPromedios.TabIndex = 0;
      this.btnCalcularPromedios.Text = "Calcular Promedios";
      this.btnCalcularPromedios.UseVisualStyleBackColor = true;
      this.btnCalcularPromedios.Click += new System.EventHandler(this.btnCalcularPromedios_Click);
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.btnAgregarAlumno);
      this.groupBox1.Controls.Add(this.btnAgregarNota);
      this.groupBox1.Controls.Add(this.txtNombreAlumno);
      this.groupBox1.Controls.Add(this.txtNota3);
      this.groupBox1.Controls.Add(this.txtNota2);
      this.groupBox1.Controls.Add(this.txtNota1);
      this.groupBox1.Controls.Add(this.label9);
      this.groupBox1.Controls.Add(this.btnBorrarNombre);
      this.groupBox1.Controls.Add(this.label8);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Location = new System.Drawing.Point(30, 70);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(820, 248);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Datos del Alumno";
      // 
      // btnAgregarAlumno
      // 
      this.btnAgregarAlumno.Location = new System.Drawing.Point(546, 103);
      this.btnAgregarAlumno.Name = "btnAgregarAlumno";
      this.btnAgregarAlumno.Size = new System.Drawing.Size(132, 80);
      this.btnAgregarAlumno.TabIndex = 4;
      this.btnAgregarAlumno.Text = "Agregar Alumno";
      this.btnAgregarAlumno.UseVisualStyleBackColor = true;
      this.btnAgregarAlumno.Click += new System.EventHandler(this.btnAgregarAlumno_Click);
      // 
      // txtNota3
      // 
      this.txtNota3.Location = new System.Drawing.Point(244, 174);
      this.txtNota3.Name = "txtNota3";
      this.txtNota3.Size = new System.Drawing.Size(109, 31);
      this.txtNota3.TabIndex = 3;
      // 
      // txtNota2
      // 
      this.txtNota2.Location = new System.Drawing.Point(244, 137);
      this.txtNota2.Name = "txtNota2";
      this.txtNota2.Size = new System.Drawing.Size(109, 31);
      this.txtNota2.TabIndex = 2;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Cursor = System.Windows.Forms.Cursors.Default;
      this.label9.Location = new System.Drawing.Point(170, 177);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(57, 25);
      this.label9.TabIndex = 3;
      this.label9.Text = "Nota";
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Cursor = System.Windows.Forms.Cursors.Default;
      this.label8.Location = new System.Drawing.Point(170, 140);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(57, 25);
      this.label8.TabIndex = 3;
      this.label8.Text = "Nota";
      // 
      // lstNombresAlumnos
      // 
      this.lstNombresAlumnos.Enabled = false;
      this.lstNombresAlumnos.FormattingEnabled = true;
      this.lstNombresAlumnos.ItemHeight = 25;
      this.lstNombresAlumnos.Location = new System.Drawing.Point(46, 95);
      this.lstNombresAlumnos.Name = "lstNombresAlumnos";
      this.lstNombresAlumnos.Size = new System.Drawing.Size(327, 329);
      this.lstNombresAlumnos.TabIndex = 8;
      // 
      // lstNotas
      // 
      this.lstNotas.Enabled = false;
      this.lstNotas.FormattingEnabled = true;
      this.lstNotas.ItemHeight = 25;
      this.lstNotas.Location = new System.Drawing.Point(409, 95);
      this.lstNotas.Name = "lstNotas";
      this.lstNotas.Size = new System.Drawing.Size(327, 329);
      this.lstNotas.TabIndex = 8;
      // 
      // lstPromediosAlumnos
      // 
      this.lstPromediosAlumnos.Enabled = false;
      this.lstPromediosAlumnos.FormattingEnabled = true;
      this.lstPromediosAlumnos.ItemHeight = 25;
      this.lstPromediosAlumnos.Location = new System.Drawing.Point(61, 197);
      this.lstPromediosAlumnos.Name = "lstPromediosAlumnos";
      this.lstPromediosAlumnos.Size = new System.Drawing.Size(327, 329);
      this.lstPromediosAlumnos.TabIndex = 8;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Cursor = System.Windows.Forms.Cursors.Default;
      this.label4.Location = new System.Drawing.Point(162, 54);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(84, 25);
      this.label4.TabIndex = 3;
      this.label4.Text = "Alumno";
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Cursor = System.Windows.Forms.Cursors.Default;
      this.label5.Location = new System.Drawing.Point(533, 54);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(68, 25);
      this.label5.TabIndex = 3;
      this.label5.Text = "Notas";
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Cursor = System.Windows.Forms.Cursors.Default;
      this.label6.Location = new System.Drawing.Point(168, 156);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(103, 25);
      this.label6.TabIndex = 3;
      this.label6.Text = "Promedio";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Cursor = System.Windows.Forms.Cursors.Default;
      this.label7.Location = new System.Drawing.Point(132, 557);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(185, 25);
      this.label7.TabIndex = 3;
      this.label7.Text = "Promedio General";
      // 
      // lblPromedioGeneral
      // 
      this.lblPromedioGeneral.Enabled = false;
      this.lblPromedioGeneral.Location = new System.Drawing.Point(61, 595);
      this.lblPromedioGeneral.Name = "lblPromedioGeneral";
      this.lblPromedioGeneral.Size = new System.Drawing.Size(327, 31);
      this.lblPromedioGeneral.TabIndex = 9;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.lblPromedioGeneral);
      this.groupBox2.Controls.Add(this.lstPromediosAlumnos);
      this.groupBox2.Controls.Add(this.label6);
      this.groupBox2.Controls.Add(this.label7);
      this.groupBox2.Location = new System.Drawing.Point(1011, 70);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(449, 782);
      this.groupBox2.TabIndex = 10;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Promedios";
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.lstNotas);
      this.groupBox3.Controls.Add(this.lstNombresAlumnos);
      this.groupBox3.Controls.Add(this.btnCalcularPromedios);
      this.groupBox3.Controls.Add(this.label4);
      this.groupBox3.Controls.Add(this.label5);
      this.groupBox3.Location = new System.Drawing.Point(30, 374);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(949, 478);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Alumnos";
      // 
      // btnSalir
      // 
      this.btnSalir.Location = new System.Drawing.Point(1511, 779);
      this.btnSalir.Name = "btnSalir";
      this.btnSalir.Size = new System.Drawing.Size(114, 73);
      this.btnSalir.TabIndex = 11;
      this.btnSalir.Text = "SALIR";
      this.btnSalir.UseVisualStyleBackColor = true;
      this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
      // 
      // frmPromedioAlumnos
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1660, 893);
      this.Controls.Add(this.btnSalir);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.groupBox2);
      this.Controls.Add(this.groupBox3);
      this.Name = "frmPromedioAlumnos";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Calculo de Promedios de Alumnos";
      this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPromedioAlumnos_FormClosing);
      this.Load += new System.EventHandler(this.frmPromedioAlumnos_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      this.groupBox3.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtNombreAlumno;
    private System.Windows.Forms.Button btnBorrarNombre;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtNota1;
    private System.Windows.Forms.Button btnAgregarNota;
    private System.Windows.Forms.Button btnCalcularPromedios;
    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListBox lstNombresAlumnos;
    private System.Windows.Forms.ListBox lstNotas;
    private System.Windows.Forms.ListBox lstPromediosAlumnos;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox lblPromedioGeneral;
    private System.Windows.Forms.GroupBox groupBox2;
    private System.Windows.Forms.GroupBox groupBox3;
    private System.Windows.Forms.Button btnAgregarAlumno;
    private System.Windows.Forms.TextBox txtNota3;
    private System.Windows.Forms.TextBox txtNota2;
    private System.Windows.Forms.Label label9;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.Button btnSalir;
  }
}

