using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.MiniJuegos
{
    internal class JuegoAccion : VideoJuego
    {
        public bool EsAptoparamenores { get; set; }
        public string MostrarInformacion_Juegoaccion()
        {
            MostrarInformacion();
            return $"Es Apto para todas las Edades: {EsAptoparamenores}";
        }
    }
}
