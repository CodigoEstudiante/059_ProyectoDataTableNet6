namespace ProyectoDataTableCore.Models
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Nombre { get; set; }
        public string Cargo { get; set; }
        public string Oficina { get; set; }
        public string Salario { get; set; }
        public int Telefono { get; set; }

        public string FechaIngreso { get; set; }
    }
}
