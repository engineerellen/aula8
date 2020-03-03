using System;
using System.Collections.Generic;
using Aula_4;

namespace TesteAula4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Jeep> lista = new List<Jeep>();
            Jeep carro = new Jeep();
            lista.Add(carro);

            Jeep carro2 = new Jeep();
            lista.Add(carro2);

            Jeep carro3 = new Jeep();
            lista.Add(carro3);

            foreach (var car in lista)
            {
                car.Andar();
            }

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i].Andar();
            }

        }
    }
}
