using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_7
{
  public partial class frmPromedioAlumnos : Form
  {
    //variables para el calculo de promedios

    private const int tam = 3;
    private double promedioGeneral = 0;
    private readonly Alumno[] aAlumnos = new Alumno[tam];
    private int cont = 0;

    public frmPromedioAlumnos()
    {
      InitializeComponent();
    }

    private void frmPromedioAlumnos_Load(object sender, EventArgs e)
    {
      btnCalcularPromedios.Enabled = false;
    }

    private void btnAgregarAlumno_Click(object sender, EventArgs e)
    {
      try
      {
        if (double.Parse(txtNota1.Text) > 10 || double.Parse(txtNota1.Text) < 0
        || double.Parse(txtNota2.Text) > 10 || double.Parse(txtNota2.Text) < 0 ||
        double.Parse(txtNota3.Text) > 10 || double.Parse(txtNota3.Text) < 0)
        {
          MessageBox.Show($"ERROR!");
          if (double.Parse(txtNota1.Text) > 10 || double.Parse(txtNota1.Text) < 0)
          {
            MessageBox.Show($"Que estas haciendo flaco, las notas son del 0 al 10, papurri!\n" +
            $"REVISA LA NOTA 1 wey");
            txtNota1.Focus();
          }
          if (double.Parse(txtNota2.Text) > 10 || double.Parse(txtNota2.Text) < 0)
          {
            MessageBox.Show($"Que estas haciendo flaco, las notas son del 0 al 10, papurri!\n" +
            $"REVISA LA NOTA 2 mamerto");
            txtNota2.Focus();
          }
          if (double.Parse(txtNota3.Text) > 10 || double.Parse(txtNota3.Text) < 0)
          {
            MessageBox.Show($"Que estas haciendo flaco, las notas son del 0 al 10, papurri!\n" +
            $"REVISA LA NOTA 3 rigoberto");
            txtNota3.Focus();
          }
        }
        else
        {// instanciando clase alumno
          cont++;
          Alumno sarmientito = new Alumno(
            txtNombreAlumno.Text,
            double.Parse(txtNota1.Text),
            double.Parse(txtNota2.Text),
            double.Parse(txtNota3.Text)
            );
          // agregando a sarmientito al array de alumnitos
          aAlumnos[cont - 1] = sarmientito;

          // mostrar alumnos en las listas
          lstNombresAlumnos.Items.Add(sarmientito.Nombre);
          lstNombresAlumnos.Items.Add("------------------------------------------------");
          lstNotas.Items.Add($"N1: {sarmientito.Nota1}, N2: {sarmientito.Nota2}, N3: {sarmientito.Nota3}");
          lstNotas.Items.Add("------------------------------------------------");

          // mensaje de array lleno y deshabilitacion de botones de cargado
          if (cont == tam)
          {
            MessageBox.Show("Lista de alumnos completa.");
            btnAgregarAlumno.Enabled = false;
            btnAgregarNota.Enabled = false;
            btnCalcularPromedios.Enabled = true;
            btnBorrarNombre.Enabled = false;
            txtNombreAlumno.Enabled = false;
            txtNota1.Enabled = false;
            txtNota2.Enabled = false;
            txtNota3.Enabled = false;
          }

          // limpiar campos luego de la carga
          txtNota1.Text = "";
          txtNota2.Text = "";
          txtNota3.Text = "";

          // foco en las notas
          btnBorrarNombre.PerformClick();
          txtNombreAlumno.Focus();
        }
      }
      catch (Exception)
      {
        MessageBox.Show("No llenaste los datos del alumno!");
      }
    }

    private void btnBorrarNombre_Click(object sender, EventArgs e)
    {
      txtNombreAlumno.Clear();
      txtNombreAlumno.Focus();
    }

    private void btnAgregarNota_Click(object sender, EventArgs e)
    {
    }

    private void btnCalcularPromedios_Click(object sender, EventArgs e)
    {
      lstPromediosAlumnos.Items.Clear();
      promedioGeneral = 0;
      // bucle para iterar por cada elemento del array aAlumnos
      for (int i = 0; i < aAlumnos.Length; i++)
      {
        // imprimir en la lista de promedios los alumnos y sus promedios
        lstPromediosAlumnos.Items.Add($"" +
          $"{aAlumnos[i].Nombre} --> {Math.Round(aAlumnos[i].CalcularPromedioAloBotta(), 2)}");
        lstPromediosAlumnos.Items.Add("------------------------------------------------");

        // calcular promedio general
        promedioGeneral += aAlumnos[i].CalcularPromedioAloBotta();
      }

      promedioGeneral /= aAlumnos.Length;
      lblPromedioGeneral.Text = Math.Round(promedioGeneral, 2).ToString();
    }

    private void frmPromedioAlumnos_FormClosing(object sender, FormClosingEventArgs e)
    {
      if (MessageBox.Show("Esta a punto de salir del programa. Esta seguro?", "Saliendo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
      {
        e.Cancel = false;
      }
      else e.Cancel = true;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}