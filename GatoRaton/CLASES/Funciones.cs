

namespace GatoRaton.CLASES
{
    internal class Funciones
    {
        private TimeSpan _tiempoTranscurrido;
        private string _tiempo { get; set; }

        public Funciones() {
            reiniciar();
        }

        public string cronometro()
        {
            _tiempoTranscurrido = _tiempoTranscurrido.Add(TimeSpan.FromSeconds(1));
            _tiempo = _tiempoTranscurrido.ToString(@"hh\:mm\:ss");
            return _tiempo;
        }

        public void reiniciar()
        {
            _tiempoTranscurrido = TimeSpan.Zero;
        }


    }
}
