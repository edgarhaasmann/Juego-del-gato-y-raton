
namespace GatoRaton.CLASES
{
    public class Jugador
    {
        public string nombre { get; set; }
        protected int posicionY { get; set; }
        protected int posicionX { get; set; }
        public bool vivo { set; get; }



        public Jugador(string nombre, int posicionY, int posocionX)
        {
            this.nombre = nombre;
            this.posicionY = posicionY;
            this.posicionX = posocionX;

        }


        public int Arriba(PictureBox tablero)
        {
            posicionY = posicionY - 20 >= tablero.Location.Y  ? this.posicionY - 20 : this.posicionY;
            return posicionY;
        }

        public int Abajo(PictureBox tablero)
        {
            this.posicionY = posicionY + 20 <= tablero.Height + 120 ? this.posicionY+20:this.posicionY;
            return posicionY;
        }

        public int Derecha(PictureBox tablero)
        {
            this.posicionX = posicionX + 20 <= 725 ? this.posicionX + 20 : this.posicionX;
            return posicionX;
        }
        public int Izquierda(PictureBox tablero)
        {
            this.posicionX = posicionX - 20 >= 10 ? this.posicionX - 20 : this.posicionX;
            return posicionX;
        }



        public PictureBox MovimientoRamdom(Dictionary<string, int> dato,ref PictureBox jugador)
        {
            Random random = new Random( );

            int maxX = random.Next(dato["minX"], dato["maxX"]);
            int maxY = random.Next(dato["minY"], dato["maxY"]);

            this.posicionX = maxX;
            this.posicionY = maxY;
            jugador.Location = new Point(maxX, maxY);
            return jugador;
        }

        

        public string Terminar()
        {
            string msg;
            if (vivo)
            {
                msg = $"¡Felicidades! {this.nombre},\n Usted Gano";
            }
            else
            {
                msg =  $"¡Upps! te atrapo el gato,\n {this.nombre} siempre hay una segunda vez :(";
            }
            this.vivo = false;
            return msg;

        }

    }
}
