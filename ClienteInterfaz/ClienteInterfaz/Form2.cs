using System;
using System.Drawing;
using System.Net.Sockets;
using System.Windows.Forms;


namespace ClienteInterfaz
{
    public partial class Form2 : Form
    {
        public string mensaje_chat;

        int nPartida;
        Socket server;
        string nombre;
        public int contPuntos = 0;
        public int contGiros = 0;
        int numTotalPreg;


        public Form2(int nPartida, Socket server, string nombre, int numTotalPreg)
        {
            InitializeComponent();
            this.nPartida = nPartida;
            this.server = server;
            this.nombre = nombre;
            this.numTotalPreg = numTotalPreg;

            CheckForIllegalCrossThreadCalls = false;

        }
        public int DameNumPartida() //funcion para obtener el numero de formulario (id de la partida)
        {
            return nPartida;
        }

        public string DameJugador()
        {
            return nombre;
        }

        public int DamenumTotalPreg()
        {
            return numTotalPreg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + nPartida;
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "3/" + nPartida;
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "40/" + nPartida + '/' + textBox1.Text + '/' + nombre;
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Form2_Load(object sender, EventArgs e) //muestra el numero de partida y el nombre del jugador
        {
            numPartida.Text = nPartida.ToString();
            NombreJugador.Text = nombre.ToString();
        }

        public void ReciboPuntosJugador(int puntos40)
        {
            string puntosJ = "" + puntos40;
            textBox1.Text = puntosJ;
        }

        public void ReciboMensaje(string autor10, string mensaje_chat10) //funcion que muestra los mensajes en el chat del juego 
        {
             if (autor10 == nombre)
             {

            chatForm2.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            chatForm2.SelectionColor = Color.PeachPuff;
            chatForm2.AppendText(autor10);
            chatForm2.SelectionAlignment = HorizontalAlignment.Right;
            chatForm2.SelectionFont = new Font("Microsoft Sans Serif", 8);
            chatForm2.SelectionColor = Color.Black;
            chatForm2.AppendText(" :\n" + mensaje_chat10 + "\r\n");

            chatForm2.ScrollToCaret();

            }
            else
              {
                  chatForm2.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                  chatForm2.SelectionColor = Color.PeachPuff;
                  chatForm2.AppendText(autor10);
                  chatForm2.SelectionAlignment = HorizontalAlignment.Left;
                  chatForm2.SelectionFont = new Font("Microsoft Sans Serif", 8);
                  chatForm2.SelectionColor = Color.Black;
                  chatForm2.AppendText(" :\n" + mensaje_chat10 + "\r\n");
                  chatForm2.SelectionAlignment = HorizontalAlignment.Left;
                  chatForm2.ScrollToCaret();
              }

        }

        public void ReciboGanador(string Ganador)
        {
            
            MessageBox.Show("El ganador de la partida es: " + Ganador);
        }
        private void EnviarChat2_Click(object sender, EventArgs e)
        {
            int partida_enviada = nPartida;
            string mensaje_chat = "10/" + partida_enviada + "/" + nombre + "/" + mensajeChat2.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje_chat);
            server.Send(msg);
            mensajeChat2.Text = "";
        }

        private void opcion1_historia_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button1.BackColor = Color.Brown;
        }

        public void ReciboPregunta(string pregunta, string opcionA, string opcionB, string opcionC, string respuesta) //funcion que muestra las preguntas y las opciones en el juego
        {
            preguntaTrivial.Text = pregunta;
            opcion1.Text = opcionA;
            opcion2.Text = opcionB;
            opcion3.Text = opcionC;


            bool resPreg = false;
            while ((timeLeft > 0) && (resPreg == false) && ( (button1.BackColor == Color.Brown) || (button2.BackColor != Color.Brown) || (button3.BackColor != Color.Brown)))
            {

                if ((button1.BackColor == Color.Brown) && (opcion1.Text == respuesta))
                {

                    contPuntos++;
                    resPreg = true;
                    MessageBox.Show("Correcto!");


                }
                if ((button2.BackColor == Color.Brown) && (opcion2.Text == respuesta))
                {

                    contPuntos++;
                    resPreg = true;
                    MessageBox.Show("Correcto!");

                }
                if ((button4.BackColor == Color.Brown) && (opcion3.Text == respuesta))
                {
                    contPuntos++;
                    resPreg = true;
                    MessageBox.Show("Incorrecto!");
                }

                if ((button1.BackColor == Color.Brown) && (opcion1.Text != respuesta))
                {

                   
                    resPreg = true;
                    MessageBox.Show("Incorrecto!");


                }
                if ((button2.BackColor == Color.Brown) && (opcion2.Text != respuesta))
                {

                   
                    resPreg = true;
                    MessageBox.Show("Incorrecto!");

                }
                if ((button4.BackColor == Color.Brown) && (opcion3.Text != respuesta))
                {
                    
                    resPreg = true;
                    MessageBox.Show("Incorrecto!");
                }



            }
            
            if (timeLeft == 0) 
                {
                    
                    MessageBox.Show("La respuesta correcta era:" + respuesta);
                }

           




        }

        public Bitmap RotateImage(Image image, float angle)
        {
            if (image == null)
                throw new ArgumentNullException("image");

            //create a new empty bitmap to hold rotated image
            Bitmap rotatedBmp = new Bitmap(image.Width, image.Height);
            rotatedBmp.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            //make a graphics object from the empty bitmap
            Graphics g = Graphics.FromImage(rotatedBmp);

            //Put the rotation point in the center of the image
            g.TranslateTransform((float)image.Width / 2, (float)image.Height / 2);

            //rotate the image
            g.RotateTransform(angle);

            //move the image back
            g.TranslateTransform(-(float)image.Width / 2, -(float)image.Height / 2);

            //draw passed in image onto graphics object
            g.DrawImage(image, new PointF(0, 0));

            return rotatedBmp;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            //cuenta las veces que se gira la ruleta
            //Load an image in from a file
            Image image = new Bitmap("ruleta1.png");
            //Set our picture box to that image
            pictureBox1.Image = (Bitmap)image.Clone();
            Image oldImage = pictureBox1.Image;
            //Pass in our original image and return a new image rotated 180 degrees right
            Random rnd = new Random();
            int grados = rnd.Next(0, 360);
            string numgrados = "" + grados;
            

            pictureBox1.Image = RotateImage(image, grados);
            contGiros++;

            Random idPregunta = new Random();
            int nPreg5 = DamenumTotalPreg();
            int idP = idPregunta.Next(1, nPreg5);

            if (oldImage != null)
            {
                oldImage.Dispose();
            }

            if (contGiros < 5)
            {
                button3.Enabled = false;
                button1.BackColor = Color.White;
                button2.BackColor = Color.White;
                button4.BackColor = Color.White;

                if ( ((grados < 54) || (grados >= 298)) && (grados >= 0))
                {
                    //pedimos al servidor una pregunta de ciencia

                    MessageBox.Show("Ciencia");
                    string categoria = "20/" + "C/" + idP + '/' + nPartida + '/' + nombre;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(categoria);
                    server.Send(msg);
                    // cuando le de aceptar empieza el tiempo
                    timeLeft = 60;
                    timeLabel.Text = "60 seconds";
                    timer1.Start();
                }

                else if ((grados >= 54) && (grados < 178))
                {
                    //pedimos al servidor una pregunta de historia


                    MessageBox.Show("Historia");
                    string categoria = "20/" + "H/" + idP + '/' + nPartida + '/' + nombre;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(categoria);
                    server.Send(msg);
                    timeLeft = 60;
                    timeLabel.Text = "60 seconds";
                    timer1.Start();
                }


                else if ((grados >= 178) && (grados < 298))
                {
                    //pedimos al servidor una pregunta de deportes

                    MessageBox.Show("Deportes");
                    string categoria = "20/" + "D/" + idP + '/' + nPartida + '/' + nombre;
                    byte[] msg = System.Text.Encoding.ASCII.GetBytes(categoria);
                    server.Send(msg);

                    timeLeft = 60;
                    timeLabel.Text = "60 seconds";
                    timer1.Start();
                }
            }

            if ((contGiros == 4) && (timeLeft < 1))
            {

                MessageBox.Show("La partida ha acabado");

                button5.Enabled = false;
                button3.Enabled = true;
                

                string mensajeP = "21/" + contPuntos + '/' + nPartida + '/' + nombre;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensajeP);
                server.Send(msg);

                


                string DameGanador = "30/" + nPartida;
                byte[] msg1 = System.Text.Encoding.ASCII.GetBytes(DameGanador);
                server.Send(msg1);

                

            }
        }



        // This integer variable keeps track of the 
        // remaining time.
        int timeLeft;

        private void timer1_Tick(object sender, EventArgs e)
        {


            if (timeLeft > 0)
            {
                // Display the new time left
                // by updating the Time Left label.
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " segundos";
                button5.Enabled = false;
                button6.Enabled = false;
                button3.Enabled = false;
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                
                button5.Enabled = true;
                button6.Enabled = false;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button2.BackColor = Color.Brown;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            button4.BackColor = Color.Brown;
        }

        private void comoIntroduzcoUnaPreguntaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para introducir una pregunta en el juego debes escribir la pregunta en la casilla que está debajo de 'Pregunta' a continuación" +
                "debes escribir la categoria de la pregunta: historia, ciencia o deporte" +
                "después debes escribir 3 posibles respuestas a la pregunta en las 3 casillas de abajo ordenadas por: opcion a) opcion b) opcion c). Y finalmente" +
                "debes poner la respuesta correcta (de las 3 opciones que has escrito) en la casilla 'Respuesta'");
        }

        private void comoPidoLosPuntosDeMiRivalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para pedir los puntos de tu rival (solo puedes pedir los de 1 jugador) introduce el nombre del rival en la casilla y a continuación presiona" +
                "el botón 'Dame puntos'. Espera la respuesta, llegará enseguida! Dato importante: solo podrás pedir los puntos de un rival cuando haya acabado la partida.");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int numeroPreg = DamenumTotalPreg();
            numeroPreg++;
            string pregunta = textBox3.Text;
            string categoria = textBox2.Text;
            string opcionA = textBox4.Text;
            string opcionB = textBox5.Text;
            string opcionC = textBox6.Text;
            string respuesta = textBox7.Text;

            if ( ((opcionA != respuesta) && (opcionB != respuesta) && (opcionC != respuesta)) || ((categoria != "ciencia") && (categoria!= "deporte") && (categoria != "historia")) )
            {
                MessageBox.Show("La respuesta no coincide con ninguna de las opciones o te has equivocado al escribir la categoria, en el menu puedes encontrar " +
                    "más información. ");
            }

            else
            {
                string IntroducePregunta = "77/" + categoria + "/" + numeroPreg + "/" + pregunta + "/" + opcionA + "/" + opcionB + "/" + opcionC + "/" + respuesta;
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(IntroducePregunta);
                server.Send(msg);
            }
            

        }
    }
}
