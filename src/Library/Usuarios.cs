using System;
using System.Collections.Generic;
using TwitterUCU;

namespace PII_Herencia

{
    public class Usuarios
    {
        private IList <Conductor> conductores = new List<Conductor>();

        private IList <Pasajero> pasajeros = new List<Pasajero>();

        public void AddConductor (Conductor conductor)
        {
            this.conductores.Add(conductor);

            var twitter = new TwitterImage(, , , );
            Console.WriteLine(twitter.PublishToTwitter("text",@"PathToImage.png"));
        }

        public void AddPasajero (Pasajero pasajero)
        {
            this.pasajeros.Add(pasajero);

            var twitter = new TwitterImage(, , , );
            Console.WriteLine(twitter.PublishToTwitter("text",@"PathToImage.png"));

        }
    }
}