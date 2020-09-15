using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
  internal class Alumno
  {
    //   propiedades
    public string Nombre { get; set; }

    //public double [] Notas { get; set; }
    public double Nota1 { get; set; }

    public double Nota2 { get; set; }
    public double Nota3 { get; set; }
    public double Promedio { get; set; }
    public int Legajo { get; set; }

    //  constructores
    public Alumno()
    {
      Nombre = "undefined";
    }

    public Alumno(string nombre, double nota1, double nota2, double nota3)
    {
      Nombre = nombre;
      Nota1 = nota1;
      Nota2 = nota2;
      Nota3 = nota3;
    }

    //  metodo
    //public double CalcularPromedioArray()
    //{
    //  double SumNotas = 0;
    //  for (int i = 0; i < Notas.Length; i++)
    //  {
    //    SumNotas += Notas[i];
    //  }
    //  Promedio = SumNotas / Notas.Length;
    //  return Promedio;
    //}
    public double CalcularPromedioAloBotta()
    {
      Promedio = (Nota1 + Nota2 + Nota3) / 3;
      return Promedio;
    }
  }
}