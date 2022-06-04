using System;
namespace Examen_B
{
    class Estudiante_primaria: Estudiante, IEstudiante
    {
        public int Precio_Fijo_Anual{ set; get; }
        public Estudiante_primaria (int Precio_Fijo_Anual, string nombre, string apellido, int cedula_identidad, string nombre_institucion) : base (nombre, apellido, cedula_identidad, nombre_institucion)
        {
            this.valor = Precio_Fijo_Anual;
        }
        public void imprimir()
        {
            Console.writeLine("Datos del estudiante");
            Console.writeLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.writeLine("Cedula de identidad: " +cedula_identidad);
            Console.writeLine("Nombre de la institucion: " +nombre_institucion);
        }
        public int calcular_Dato() 
        {
            Console.writeLine("El valor de la matricula es $" +Precio_Fijo_Anual);
           return Precio_Fijo_Anual;

        }     
    }   
}