using LaboratorioProgra1.Laboratorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaboratorioProgra1.MiniJuegos
{
    internal class JuegoAventura : VideoJuego
    {
        public bool Ambiente_abierto { get; set; }
        public string MostrarInformacion_JuegoAventura()
        {
            MostrarInformacion();
            return $"El jugador puede Explorar el Juego: {Ambiente_abierto}";
        }

    }
}
