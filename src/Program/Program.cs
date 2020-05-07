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

            Pool conductor1 = new Pool();
            Comun conductor2 = new Comun();

            Pasajero pasajero1 = new Pasajero();
            Pasajero pasajero2 = new Pasajero();
            Pasajero pasajero3 = new Pasajero();

            usuarios.AddConductor(conductor1);
            usuarios.AddConductor(conductor2);

            usuarios.AddPasajero(pasajero1);
            usuarios.AddPasajero(pasajero2);
            usuarios.AddPasajero(pasajero3);
        
        }
    }
}
