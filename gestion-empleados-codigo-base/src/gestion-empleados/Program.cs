using System;
using System.Collections.Generic;
using gestion_empleados.Models;

namespace gestion_empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Gestión de Empleados - Demo");
            var lista = new List<Empleado>
            {
                new Empleado { Id = 1, Nombre = "Ana", Departamento = "TI", Salario = 45000 },
                new Empleado { Id = 2, Nombre = "Luis", Departamento = "RRHH", Salario = 38000 }
            };

            foreach (var e in lista)
            {
                Console.WriteLine($"{e.Id} - {e.Nombre} - {e.Departamento} - {e.Salario}");
            }
        }
    }
}
