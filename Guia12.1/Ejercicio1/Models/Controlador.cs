using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1.Models
{
    public class Controlador
    {
        public string [] Nombres = new string[100];
        public int [] Tiempos = new int[100];
       public int contador;
        public void AgregarCompetidor(string Nombre)
        {
            Nombres[contador] = Nombre;  
            contador++;
        }
        public void CargarTiempo(int numeroCompetidor,int hh, int mm)
        {
            Tiempos[numeroCompetidor] = hh*60+mm;
        }
        public void ordenarListadoxTiempo()
        {
            for(int i = 0; i < contador - 1; i++)
            {
                for (int j = i + 1; j < contador; j++)
                {
                    if (Tiempos[i] > Tiempos[j])
                    {
                        int temp = Tiempos[j];
                        Tiempos[j] = Tiempos[i];
                        Tiempos[i] = temp;
                    }
                }
            }
        }
    }
}
