using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.MiniJuegos
{
    internal class JuegoDeportes : VideoJuego
    {
        public string Deportes { get; set; }
        public void MostrarInformacion_Juegodeportes()
        {
            MostrarInformacion();
            Console.WriteLine(Deportes);
        }
    }
}
