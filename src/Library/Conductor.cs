namespace PII_Herencia

{
    public class Conductor : IUcuRide
    {

        public string Apellido { get; set; }

        public string Nombre { get; set; }

        public string Cedula { get; set; }

        public string Bio { get; set; }

        public string Vehiculo { get; set; }

        public double Calificacion { get; set; }

        public string Foto { get; set; }

        public virtual string ComunOPool()
        {
            return "Indefinido";
        }

        public virtual int MaxPasajeros()
        {
            return 1;
        }
    }
}