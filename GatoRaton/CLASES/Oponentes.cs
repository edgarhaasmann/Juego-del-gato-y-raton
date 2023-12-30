

namespace GatoRaton.CLASES
{
    public class Oponente : Jugador
    {

        private int _dificultad { set; get; }

        public Oponente(string nombre, int poisicionX, int posicionY, int dificultad) : base(nombre, poisicionX, posicionY)
        {
            this._dificultad = dificultad;
        }

        public void Avanza(ref PictureBox pbJugador, ref PictureBox pbOponente)
        {

            int deltaX = pbJugador.Location.X - pbOponente.Location.X;
            int deltaY = pbJugador.Location.Y - pbOponente.Location.Y;

            double distanciaTotal = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
            int velocidad;
            if(this._dificultad == 0)
            {
                velocidad = 10;
            }else if (this._dificultad == 1){
                velocidad = 20;
            }else{
                velocidad = 30;
            }


            double velocidadX = velocidad * deltaX / distanciaTotal;
            double velocidadY = velocidad * deltaY / distanciaTotal;

            pbOponente.Left += (int)velocidadX;
            pbOponente.Top += (int)velocidadY;

        }
        public bool Colision(PictureBox pb1, PictureBox pb2)
        {
            Rectangle rect1 = new Rectangle(pb1.Location, pb1.Size);
            Rectangle rect2 = new Rectangle(pb2.Location, pb2.Size);

            return rect1.IntersectsWith(rect2);
        }


    } 
}
