using System;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables
            string info = "";
            string info1 = "";
            int age = 0;
            double alt = 0.0;
            string nomb = "";




            //saludo y nombre
            Console.WriteLine("Bienvenido al parque de atracciones mas comun del mundo, ese es nuestro enganche.");
            Console.WriteLine("Indicame tu bonito nombre.");
            nomb = Console.ReadLine();

            //ya que es el "Parque mas comun del mundo, aprovechare eso.
            if (nomb == "juan")
                Console.WriteLine("DEMONIOS, TIENES EL NOMBRE MAS COMUN, TIENES UN PASE VIP A NUESTRO PARQUE");




            //edad para el parque
            Console.WriteLine("Bonito nombre, {0}. Porfavor, ingresa tu edad", nomb);
            info = Console.ReadLine();
            age = Convert.ToInt32(info);
            if (age < 18 || age > 65)
            {
                Console.WriteLine("Lo lamento, {0}. Todavia no eres muy adulto, y tampoco queremos que te de un infarto. Tu edad no es aceptada aqui, lo lamento, ", nomb);
            }
            //estatura
            else
            {
                Console.WriteLine("bienvenido seas, humano llamando {0}", nomb);
                Console.WriteLine("Indicame tu altura y más te vale que sea en metros. Por ejemplo: 1.85");
                info1 = Console.ReadLine();
                alt = Convert.ToDouble(info1);


                //detalle para el usuario
                Console.WriteLine("Analizando... individuo {0} de {1} años y estatura {2}", nomb, age, alt);

            }
            if (!(alt > 1.6))
            {
                Console.WriteLine("Puedes entrar a las cosas no E X T R E M A S, pero sigues siendo un poco bajito para lo extremo. ¡Juega un poco de Basket, {0}!", nomb);
            }
            else
            {
                Console.WriteLine("Listo Rey, puedes acceder a todas las atracciones, incluyendo... Lo E X T R E M O");
            }
            
            

            //////////////////////en todas los if no utilize {} puesto que no fue necesario.








        }
    }
}


