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

            var twitter = new TwitterImage("g7rkPB5uI2xOqELAhlNrorSU4", "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc", "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E", "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe");
            Console.WriteLine(twitter.PublishToTwitter($"Tenemos un nuevo pasajero! Bienvenid@ {conductor.Nombre} {conductor.Apellido}!",@"C:\Users\FIT\Desktop\Arreglos y combinaciones.png"));
        }

        public void AddPasajero (Pasajero pasajero)
        {
            this.pasajeros.Add(pasajero);

            var twitter = new TwitterImage("g7rkPB5uI2xOqELAhlNrorSU4", "8hOTyS71GrTH9Ool3rXykAJRY5AmgSPiy78b1wYUPcvfIzXeEc", "1396065818-8vnV9HJFW5ArcfFg2zE9hLA68CZYFXO8Cjv6o2E", "675fHmUzeaPajtj3pO64w5xd3p9YI3kco7kSvKhzeEvYe");
            Console.WriteLine(twitter.PublishToTwitter($"Tenemos un nuevo pasajero! Bienvenid@ {pasajero.Nombre} {pasajero.Apellido}!",@"C:\Users\FIT\Desktop\Arreglos y combinaciones.png"));

        }
    }
}