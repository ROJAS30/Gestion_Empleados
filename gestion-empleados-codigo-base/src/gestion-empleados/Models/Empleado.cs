namespace gestion_empleados.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Departamento { get; set; } = string.Empty;
        public decimal Salario { get; set; }
        public string Email { get; set; } = string.Empty;

    }
}
