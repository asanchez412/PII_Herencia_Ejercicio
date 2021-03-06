namespace PII_Herencia

{
    public class Pool : Conductor
    {
        public Pool(string nombre, string apellido, string cedula, string bio, string vehiculo, double calificacion, string foto)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Cedula = cedula;
            this.Bio = bio;
            this.Vehiculo = vehiculo;
            this.Calificacion = calificacion;
            this.Foto = foto;
        }

        public override string ComunOPool()
        {
            return "Pool";
        }

        public override int MaxPasajeros()
        {
            return 4;
        }
    }
}