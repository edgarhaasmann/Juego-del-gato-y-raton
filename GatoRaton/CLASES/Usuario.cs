
namespace GatoRaton.CLASES
{
    public class Usuario : Jugador
    {
        
        public int jugadas;
        public string tiempoAnt { set; get; }

        public Usuario(string nombre, int poisicionX, int posicionY):base( nombre, poisicionX, posicionY)
        {
            this.vivo = true;
            this.jugadas = 0;

        }

        public bool Colision(ref Panel salida, ref PictureBox jugador)
        {
            Rectangle rect1 = new Rectangle(jugador.Location, jugador.Size);
            Rectangle rect2 = new Rectangle(salida.Location, salida.Size);

            return rect1.IntersectsWith(rect2);
        }

        public void SetJugadas()
        {

            jugadas += 1;
        }
        public void setVivo(bool v)
        {
            this.vivo = v;
        }

        public void SetTiempo(string tiempo)
        {
            this.tiempoAnt = tiempo;
        }

    }


}
