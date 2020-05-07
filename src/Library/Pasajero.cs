namespace PII_Herencia

{
    public class Pasajero : IUcuRide
    {

        public Pasajero(string nombre, string apellido, string cedula, double calificacion, string foto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Calificacion = calificacion;
            this.Foto = foto;
        }

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public double Calificacion { get; set; }

        public string Foto { get; set; }

    }
}