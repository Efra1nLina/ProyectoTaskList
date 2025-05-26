namespace ProyectoTaskList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Actividad> lista = new List<Actividad>();
            lista.Add(new Actividad("Eduardo", "Estudiante", "2349 horas", 1));
            lista.Add(new Actividad("José", "Trabajador", "1 horas", 2));
            lista.Add(new Actividad("Emmanuel", "Desempleado", "12312124 horas", 3));
        }
    }
}
