namespace PII_Herencia

{
    public class Comun : Conductor
    {
        public Comun(string nombre, string apellido, string cedula, string bio, string vehiculo, double calificacion)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Bio = bio;
            this.Vehiculo = vehiculo;
            this.Calificacion = calificacion;
        }

        public override string ComunOPool()
        {
            return "Comun";
        }
    }
}