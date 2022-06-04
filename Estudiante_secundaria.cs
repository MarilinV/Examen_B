using System;
namespace Examen_B
{
    class Estudiante_secundaria : Estudiante, IEstudiante
    {
        public int Nivel_cursado { set; get; }
        public int Precio_fijo_Anual { set; get; }
        public Estudiante_secundaria (int Nivel_cursado, int Precio_fijo_Anual, string nombre, string apellido, int cedula_identidad, string nombre_institucion) : base (nombre, apellido, cedula_identidad, nombre_institucion)
        {
            this.Nivel_cursado = Nivel;
            this.Precio_fijo_Anual = Precio_fijo_Anual;
        }
        public void imprimir()
        {
            Console.writeLine("Datos del estudiante");
            Console.writeLine("Nombres y apellidos: " +nombre+ ""+apellido);
            Console.writeLine("Cedula de identidad: " +cedula_identidad);
            Console.writeLine("Nombre de la institucion: " +nombre_institucion);
            Console.writeLine("Nivel cursado: " +Nivel_cursado);
            Console.writeLine("Precio fijo: "+Precio_fijo_Anual);
        }
        public void calcular_Dato() 
        {
            int total=0;
            total=Nivel_cursado*Precio_fijo_Anual;
            Console.writeLine("el valor de la matricula es: $"+total);
            return total;
        }
        
    }   
}