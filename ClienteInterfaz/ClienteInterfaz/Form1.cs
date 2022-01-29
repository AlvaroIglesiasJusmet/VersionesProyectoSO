using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ClienteInterfaz
{
    public partial class Form1 : Form
    {
        Socket server;
        Thread atender;
        int nForm = 0;
        string autor;

        
        string mensaje_chat;
       

        public string mensaje_gamers;
        public int cont_invitados = 0;
        string usuarioMaquina;
        List<String> invitar_gamers = new List<String>(); //lista de invitados
        List<Form2> formularios = new List<Form2>(); // lista de invitados
        bool anadirInv = true; //para poder añadir a los invitados a una partida



        delegate void DelegadoListaConectados(int NumConectados, string[] trozos); //lista de conectados
        delegate void DelegadoParaFormulario(Thread atender); //atiende mensajes servidor
        delegate void DelegadoParaEnviarChatGlobal(string autor9, string mensaje); //chat del form 1
        delegate void DelegadoParaEnviarChatJuego(int partida, string autor, string mensaje); //chat del form 2
        delegate void DelegadoEmpezarPartida(int partida, int i, int nPregTrivial); //para iniciar una partida jugadores que dicen YES
        delegate void DelegadoParaEnviarPregunta(int partida20, string nombre20, string pregunta, string opcionA, string opcionB, string opcionC, string respuesta); //preguntas del juego
        delegate void DelegadoParaEnviarGanador(string GanadorPartida, int numPartida); //enviamos a la partida correspondiente el ganador
        public Form1()
        {
            InitializeComponent();
            
        }

        public void ServicioPartida(string nombre, int partida, int nPreg) // thread que se ocupa de las nuevas partidas
        {

            ThreadStart ts = delegate { PonerMarchaFormulario(nombre, partida, nPreg); };
            Thread T = new Thread(ts);
            T.Start();
        }

        public void PonerEnGrid(int NumConectados, string[] trozos) //funcion que pone en el GRID a los conectados
        {
            if (NumConectados == 0)
                dataGridView1.Rows.Clear();
            else
            {
                dataGridView1.RowCount = NumConectados;
                dataGridView1.ColumnCount = 1;
                for (int n = 2; n < trozos.Length;)
                {
                    dataGridView1.Rows[n - 2].Cells[0].Value = trozos[n];
                    n++;
                }
            }
            
        }

        public void PartidaStart(int partida, int i, int nPreguntas) //funcion que permite que se abra el formulario 2 con la partida para los jugadores que han dicho YES
        {
            
            if (i == 0)
            {
                ServicioPartida(Invitado1.Text, partida, nPreguntas);
            }

            if ((Invitado2.Text != null) && (i == 1))
            {
                ServicioPartida(Invitado2.Text, partida, nPreguntas);
            }
            if ((Invitado3.Text != null) && (i == 2))
            {
                ServicioPartida(Invitado3.Text, partida, nPreguntas);
            }
            if ((Invitado4.Text != null) && (i == 3))
            {
                ServicioPartida(Invitado4.Text, partida, nPreguntas);
            }
            if ((Invitado5.Text != null) && (i == 4))
            {
                ServicioPartida(Invitado5.Text, partida, nPreguntas);
            }


        }
        public void RecibirChat(string autor, string msg) //funcion para el chat del Formulario Principal
        {
            ChatMensajes.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
            ChatMensajes.SelectionColor = Color.Orange;
            ChatMensajes.AppendText(autor);
            ChatMensajes.SelectionFont = new Font("Microsoft Sans Serif", 8);
            ChatMensajes.SelectionColor = Color.Black;
            ChatMensajes.AppendText(" :\n" + msg + "\r\n");
            ChatMensajes.ScrollToCaret();
        }


        private void AtenderServidor()
        {
            while (true)
            {
                //Recibimos mensaje del servidor
                byte[] msg2 = new byte[200];
                server.Receive(msg2);


                
                string mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                string[] trozos = mensaje.Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                switch (codigo)
                {


                    case 1: //quieren loguearse


                        if (trozos[1] == "SI")
                        {

                            MessageBox.Show("Te has conectado correctamente");

                        }

                        else if (trozos[1] == "NO")
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                        break;


                    case 2: //piden registrarse


                        if (trozos[1] == "Registrado")
                        {
                            MessageBox.Show("Te has registrado correctamente");

                        }

                        else
                        {
                            MessageBox.Show("Ya existe ese nombre de usuario, por favor, usa otro");
                        }
                        break;

                    case 40: //recibimos puntos de un jugador
                        int puntos40= Convert.ToInt32(trozos[1]);
                        int partida40  = Convert.ToInt32(trozos[2]);
                        string nombre40 = trozos[3];
                        int n = 0;
                        bool res = false;

                        while ((n < nForm) && (res == false))

                        {

                            if ((formularios[n].DameNumPartida() == partida40) && (formularios[n].DameJugador() == nombre40))
                            {
                                formularios[n].ReciboPuntosJugador(puntos40);
                                res = true;
                            }

                            n++;
                        }
                        break;

                    case 4: //recibo notificacion de Lista de Conectados
                        int NumConectados = Convert.ToInt32(trozos[1]);
                        DelegadoListaConectados delegadoLC = new DelegadoListaConectados(PonerEnGrid);
                        dataGridView1.Invoke(delegadoLC, new object[] { NumConectados, trozos });
                        break;

                    case 7: //enviamos las invitaciones

                        string anfitrion = trozos[2];
                        int partida = Convert.ToInt32(trozos[1]);
                        string MessageBoxTitle = "Invitación de partida de Trivial";
                        string MessageBoxContent = anfitrion + " te ha invitado a la partida" + partida + "\n Deseas aceptarla? ";
                        string respuesta_invitation;
                        DialogResult result = MessageBox.Show(MessageBoxContent, MessageBoxTitle, MessageBoxButtons.YesNo);
                        switch (result)
                        {
                            case DialogResult.Yes:

                                respuesta_invitation = "8/" + anfitrion + "/" + partida + "/" + textBoxNombre.Text + "/" + Convert.ToString(result) + "/1";
                                byte[] accept = System.Text.Encoding.ASCII.GetBytes(respuesta_invitation);
                                server.Send(accept);
                                break;



                            case DialogResult.No:
                                respuesta_invitation = "8/" + anfitrion + "/" + partida + "/" + textBoxNombre.Text + "/" + Convert.ToString(result) + "/0";
                                byte[] decline = System.Text.Encoding.ASCII.GetBytes(respuesta_invitation);
                                server.Send(decline);
                                break;
                        }

                        break;

                    case 8: //recibimos respuesta de los invitados
                        partida = Convert.ToInt32(trozos[1]);
                        string invitado = trozos[2];
                        string respuesta_inv = trozos[3];
                        MessageBox.Show("Respuesta del invitado " + invitado + " a la partida " + partida + " del juego  es " + respuesta_inv);
                        break;

                    case 25: //enviamos notificacion a todos y creamos la partida (todos los invitados han aceptado)

                        partida = Convert.ToInt32(trozos[1]);
                        int NumInvitados = Convert.ToInt32(trozos[2]);
                        int NumJugadores = NumInvitados + 1;
                        string anfitrion25 = trozos[3];
                        int nPreguntas = Convert.ToInt32(trozos[4]);
                        int i = 0;
                        while (i < NumJugadores)
                        {
                            string MessageBoxContent1 = " Va a empezar la partida ";
                            string MessageBoxTitle1 = "Partida de Trivial";
                            DialogResult result1 = MessageBox.Show(MessageBoxContent1, MessageBoxTitle1, MessageBoxButtons.OK);

                            switch (result1)
                            {
                                case DialogResult.OK:

                                    DelegadoEmpezarPartida delegado25 = new DelegadoEmpezarPartida(PartidaStart);
                                    this.Invoke(delegado25, new object[] { partida, i, nPreguntas });
                                    i++;
                                    break;
                                  }
                             }
                        
                        break;

                    case 9: //Enviar mensajes mediante el chat del formulario 1
                        autor = trozos[1];
                        mensaje_chat = trozos[2];
                        DelegadoParaEnviarChatGlobal delegado9 = new DelegadoParaEnviarChatGlobal(RecibirChat);
                        this.Invoke(delegado9, new object[] {autor, mensaje_chat });
                        break;

                    case 10: //recibo mensajes del chat2
                        int partida10 = Convert.ToInt32(trozos[1]);
                        string autor10 = trozos[2];
                        string mensaje_chat10 = trozos[3];
                        DelegadoParaEnviarChatJuego delegado10 = new DelegadoParaEnviarChatJuego(EnviarChatForm);
                        this.Invoke(delegado10, new object[] { partida10, autor10, mensaje_chat10 });
                        break;

                    case 20: //recibo la pregunta del servidor
                        int partida20 = Convert.ToInt32(trozos[1]);
                        string nombre20 = trozos[2];
                        string pregunta = trozos[3];
                        string opcionA = trozos[4];
                        string opcionB = trozos[5];
                        string opcionC = trozos[6];
                        string respuesta = trozos[7];
                        DelegadoParaEnviarPregunta delegado20 = new DelegadoParaEnviarPregunta(EnviarPregunta);
                        this.Invoke(delegado20, new object[] {partida20, nombre20, pregunta, opcionA, opcionB, opcionC, respuesta });
                        break;


                    case 30: //recibo Ganador
                        string Ganador = trozos[1];
                        int IDpartida = Convert.ToInt32(trozos[2]);
                        DelegadoParaEnviarGanador delegado30 = new DelegadoParaEnviarGanador(EnviarGanador);
                        this.Invoke(delegado30, new object[] { Ganador, IDpartida });
                        break;
                }

                



            }
        }
        private void Button1_Click(object sender, EventArgs e) //boton conectar
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("147.83.117.22");
            IPEndPoint ipep = new IPEndPoint(direc, 50017);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }

            //pongo en marcha el thread que atendera los mensajes del servidor
            ThreadStart ts = delegate { AtenderServidor(); };
            atender = new Thread(ts);
            atender.Start();

        }

        private void PonerMarchaFormulario(string nombre, int partida, int nTotalPreg) //creamos formulario para cada jugador
        {
            nForm = nForm + 1;
            
            Form2 f = new Form2(partida, server, nombre, nTotalPreg);
            formularios.Add(f);
            f.ShowDialog();

        }

        
        public void EnviarChatForm(int partida10, string autor10, string mensaje_chat10) //enviar mensaje chat del form 2
        {//metodo para enviar chat al form correspondiente
            int n;

            for (n = 0; n < nForm; n++)
            {
                if (formularios[n].DameNumPartida() == partida10)
                {
                    formularios[n].ReciboMensaje(autor10, mensaje_chat10);
                }

            }
        }

        public void EnviarPregunta(int partida20, string nombre20, string pregunta, string opcionA, string opcionB, string opcionC, string respuesta) //enviamos pregunta al form2
        {
            
            int n = 0;
            bool res = false;

            while ((n < nForm) && (res == false))
            
            {
                
                if ((formularios[n].DameNumPartida() == partida20) && (formularios[n].DameJugador() == nombre20))
                {
                    formularios[n].ReciboPregunta(pregunta, opcionA, opcionB, opcionC, respuesta);
                    res = true;
                }

                n++;
                
                

            }
        }

        public void EnviarGanador(string Ganador, int IDpartida)//enviamos ganador al form2
        {
            int n;

            for (n = 0; n < nForm; n++)
            {
                if ((formularios[n].DameNumPartida() == IDpartida))
                {
                    formularios[n].ReciboGanador(Ganador);
                }

            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button6_Click(object sender, EventArgs e) // boton Log In
        {
            string nombre = textBoxNombre.Text;
            string contraseña = textBoxContraseña.Text;
            string mensaje= "1/"+ textBoxNombre.Text+ "/" +textBoxContraseña.Text;
            usuarioMaquina = textBoxNombre.Text;

            //Enviamos al servidor el nombre y la contraseña tecleados
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);


            Invitado1.Text = "";
            Invitado1.SelectionColor = Color.Black;
            Invitado1.AppendText(usuarioMaquina);
            Invitado1.SelectionAlignment = HorizontalAlignment.Center;


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e) //boton de desconectar
        {
            //Mensaje de desconexión 
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Nos desconectamos
            atender.Abort();
            byte[] msg2 = new byte[200];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            dataGridView1.Rows.Clear();

            mensajeChat.Clear();
            ChatMensajes.Clear();
            textBoxNombre.Clear();
            textBoxContraseña.Clear();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
             
        }

        private void button5_Click(object sender, EventArgs e)
        {
            

           
        }

        private void button7_Click(object sender, EventArgs e) // funcion registrar
        {
            string nombre = textBoxNombre.Text;
            string contraseña = textBoxContraseña.Text;
            string mensaje = "5/" + textBoxNombre.Text + "/" + textBoxContraseña.Text;
            
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            
          
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e) // Boton para invitar varios jugadores (máximo 5)
        {
            if (anadirInv)
            {
                if (dataGridView1.CurrentRow != null && dataGridView1.CurrentRow.Cells[0].Value != null)
                {
                    int i;
                    int encontrado = 0;
                    for (i = 0; i < invitar_gamers.Count(); i++)
                    {
                        if (invitar_gamers[i] == Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value))
                        {
                            MessageBox.Show("El usuario ya ha sido invitado");
                            encontrado = 1;
                            break;
                        }

                    }
                    if (encontrado == 0)
                    {
                        invitar_gamers.Add(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                        cont_invitados++;
                        if (cont_invitados == 1)
                        {

                            Invitado2.SelectionColor = Color.Black;
                            Invitado2.AppendText(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                            Invitado2.SelectionAlignment = HorizontalAlignment.Center;
                        }
                        else if (cont_invitados == 2)
                        {

                            Invitado3.SelectionColor = Color.Black;
                            Invitado3.AppendText(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                            Invitado3.SelectionAlignment = HorizontalAlignment.Center;
                        }
                        else if (cont_invitados == 3)
                        {

                            Invitado4.SelectionColor = Color.Black;
                            Invitado4.AppendText(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                            Invitado4.SelectionAlignment = HorizontalAlignment.Center;
                        }
                        else if (cont_invitados == 4)
                        {

                            Invitado5.SelectionColor = Color.Black;
                            Invitado5.AppendText(Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value));
                            Invitado5.SelectionAlignment = HorizontalAlignment.Center;
                        }
                        else
                            MessageBox.Show("No se pueden añadir más jugadores");
                    }
                }
                else
                    MessageBox.Show("Seleccione con quien jugar");
            }



        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) // Funcion para que no se quede bloqueado si cerramos form 1
                                                                              // desde la pestaña
        {
            //Mensaje de desconexión 
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Nos desconectamos
            atender.Abort();
            byte[] msg2 = new byte[200];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            dataGridView1.Rows.Clear();

            ChatMensajes.Clear();
            textBoxNombre.Clear();
            textBoxContraseña.Clear();
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();

        }

        private void button3_Click_2(object sender, EventArgs e) //el usuario quiere enviar un mensaje, BOTON ENVIAR FORM 1
        {
          
            string mensaje_chat = "9/" + textBoxNombre.Text + "/" + mensajeChat.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje_chat);
            server.Send(msg);
        }

        private void Crear_Partida_Click(object sender, EventArgs e) //crear partida con múltiples invitados
        {
            if (invitar_gamers.Count() == 0)
            {
                MessageBox.Show("Por favor seleccione a alguien");
            }
            else
            { }
                mensaje_gamers = "7/" +  textBoxNombre.Text + "/";

                int i;
                for (i = 0; i < invitar_gamers.Count(); i++)
                {
                    mensaje_gamers = mensaje_gamers + invitar_gamers[i] + "/";
                }
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje_gamers);
                server.Send(msg);
            }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e) // Eliminar invitados de la partida
        {
            if (cont_invitados != 0)
            {
                invitar_gamers.Remove(invitar_gamers[cont_invitados - 1]);

                if (cont_invitados == 1)
                {
                    Invitado2.Clear();
                }
                else if (cont_invitados == 2)
                {
                    Invitado3.Clear();
                }
                else if (cont_invitados == 3)
                {
                    Invitado4.Clear();
                }
                else if (cont_invitados == 4)
                {
                    Invitado5.Clear();
                }
                cont_invitados = cont_invitados - 1;
            }

            else
            {
                MessageBox.Show("Ningún usuario añadido");
            }
        }

        private void comoSeJuegaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El juego consiste en contestar preguntas de 3 categorías diferentes: historia, deporte y ciencia. Tendrás 60 segundos para girar" +
                "la ruleta y contestar a cada pregunta. Marca la opción que creas correcta. También podrás escribir a tus oponentes o pedir los puntos de un jugador. " +
                "Al final de la partida se revelará el ganador. Suerte! ");
        }

        private void comoInvitoAMisAmigosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para invitar a tus amigos observe los jugadores que estan conectados, presione su nombre y a continuación presione el boton de 'Añadir a partida'. " +
                "Solo podeis ser 5 jugadores en la partida");
        }

        private void normasDeComportamientoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1)Respetar a todos los jugadores de la comunidad. " +
                "2)No usar vocabulario ilícito en el chat. " +
                "3)Las preguntas tienen que responderse sin uso de ayuda externa, solo con el conocimiento de uno mismo." +
                " 4)Es un juego, no pasa nada si pierdes ");
        }
    }
}



