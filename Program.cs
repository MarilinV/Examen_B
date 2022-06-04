using System;

namespace Examen_B
{
    class Program
    {
        static void Main (string[]args)
        {
        Estudiante_primaria estudiante_primaria = new Estudiante_primaria(100, "Meredith Elizabeth","Vazquez Alcivar","Francizco Muñoz", 12435678385);
        Estudiante_primaria. imprimir();
        Estudiante_primaria. calcularDato();

        Estudiante_secundaria estudiante_secundaria = new Estudiante_secundaria();
        Estudiante_secundaria. imprimir();
        Estudiante_secundaria. calcular_Dato();

        Estudiante_universitario estudiante_universitario = new Estudiante_universitario();
        Estudiante_universitario. imprimir();
        Estudiante_universitario. calcular_Dato();
        }

    }
}