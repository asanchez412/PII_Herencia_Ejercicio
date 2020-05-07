using System;
using System.Collections;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!
            */

            Usuarios usuarios = new Usuarios();

            Pool conductor1 = new Pool("Juan", "Pérez", "1.685.531-3", "Conductor hace 10 años", "Mazda 3", 9.8, @"C:\Users\FIT\Desktop\imagen.jpg");
            Comun conductor2 = new Comun("Emilio", "Urquiza", "1.924.573-1", "Conductor en tiempo libre", "Chevrolet Onix", 9.6, @"C:\Users\FIT\Desktop\imagen.jpg");

            Pasajero pasajero1 = new Pasajero("Leticia", "Giménez", "1.664.529-5", 10.0, @"C:\Users\FIT\Desktop\imagen.jpg");
            Pasajero pasajero2 = new Pasajero("Hernán", "Ibáñez", "3.156.561-7", 9.0, @"C:\Users\FIT\Desktop\imagen.jpg");
            Pasajero pasajero3 = new Pasajero("Walter", "Tridente", "5.021.637-2", 9.67, @"C:\Users\FIT\Desktop\imagen.jpg");

            usuarios.AddConductor(conductor1);
            usuarios.AddConductor(conductor2);

            usuarios.AddPasajero(pasajero1);
            usuarios.AddPasajero(pasajero2);
            usuarios.AddPasajero(pasajero3);
        
        }
    }
}
