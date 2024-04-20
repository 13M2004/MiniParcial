using LaboratorioProgra1.EjemploPolimorfismo;
using LaboratorioProgra1.EjemploPolimorfismo.Heredados;
using LaboratorioProgra1.Laboratorio;
using LaboratorioProgra1.MiniJuegos;

static void EjemploPolimorfismo()
{
    Animal[] animales = new Animal[3];
    animales[0] = new Tortuga();
    animales[1] = new Gato();
    animales[2] = new Perro();
    foreach (Animal animal in animales)
    {
        animal.HacerSonido();
    }
}   

static void Laboratorio()
{
    VideoJuego videoJuego = new VideoJuego();
    videoJuego.Titulo = "The Legend of Zelda: Breath of the Wild";
    videoJuego.Desarrolladora = "Nintendo";
    videoJuego.Calificacion = 50;
    videoJuego.AnioLanzamiento = 2017;
    videoJuego.MostrarInformacion();
}

//Laboratorio();
//VideoJuego.listaDeJuegos();

static void ffJuegoAccion()
{
    JuegoAccion jcjuegoAccion = new JuegoAccion();
    jcjuegoAccion.Titulo = "Free Fire";
    jcjuegoAccion.Desarrolladora = "111 DOts Studio";
    jcjuegoAccion.Calificacion = 9;
    jcjuegoAccion.AnioLanzamiento = 2017;

    jcjuegoAccion.EsAptoparamenores = true;

    jcjuegoAccion.MostrarInformacion_Juegoaccion();
}

static void ffJuegoDeportes()
{
    JuegoDeportes CCjuegodeportes = new JuegoDeportes();
    CCjuegodeportes.Titulo = "Juegos Olimpicos";
    CCjuegodeportes.Desarrolladora = "Nintendo";
    CCjuegodeportes.Calificacion = 10;
    CCjuegodeportes.AnioLanzamiento = 2016;
    CCjuegodeportes.Deportes = "Atletismo.\nFutbol.\nNatación.";

    CCjuegodeportes.MostrarInformacion_Juegodeportes();
}

static void ffJuegosAventura()
{
    JuegoAventura CCjuegoaventura = new JuegoAventura();
    CCjuegoaventura.Titulo = "ManuelBros";
    CCjuegoaventura.Desarrolladora = "Nintendo";
    CCjuegoaventura.Calificacion = 3;
    CCjuegoaventura.AnioLanzamiento = 2013;
    CCjuegoaventura.Ambiente_abierto = true;

    CCjuegoaventura.MostrarInformacion_JuegoAventura();
}


ffJuegoAccion();
Console.WriteLine("");
ffJuegoDeportes();
Console.WriteLine("");
ffJuegosAventura();

Console.ReadKey();





