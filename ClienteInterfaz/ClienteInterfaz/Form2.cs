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
    public partial class Form2 : Form
    {
        public string mensaje_chat;
       
        int nForm;
        Socket server;
        string nombre;

        

        public Form2(int nForm, Socket server, string nombre)
        {
            InitializeComponent();
            this.nForm = nForm;
            this.server = server;
            this.nombre = nombre;
            CheckForIllegalCrossThreadCalls = false;
          
        }
        public int DameNumForm() //funcion para obtener el numero de formulario (id de la partida)
        {
            return nForm;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            string mensaje = "2/" + nForm ;
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mensaje = "3/" + nForm ;
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "4/" + nForm;
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
        }

        private void Form2_Load(object sender, EventArgs e) //muestra el numero de partida
        {
            numPartida.Text = nForm.ToString();
            
        }

        public void TomaPuntosJuan(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public void ReciboMensaje(string autor10, string msg) //funcion que muestra los mensajes en el chat del juego 
        {
            if (autor10 == nombre)
            {
                chatForm2.SelectionFont = new Font("Microsoft Sans Serif", 9, FontStyle.Bold);
                chatForm2.SelectionColor = Color.PeachPuff;
                chatForm2.AppendText(autor10);
                chatForm2.SelectionAlignment = HorizontalAlignment.Right;
                chatForm2.SelectionFont = new Font("Microsoft Sans Serif", 8);
                chatForm2.SelectionColor = Color.Black;
                chatForm2.AppendText(" :\n" + msg + "\r\n");
                chatForm2.SelectionAlignment = HorizontalAlignment.Right;
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
                chatForm2.AppendText(" :\n" + msg + "\r\n");
                chatForm2.SelectionAlignment = HorizontalAlignment.Left;
                chatForm2.ScrollToCaret();
            }

        }

        private void EnviarChat2_Click(object sender, EventArgs e)
        {
            int partida_enviada = nForm;
            string mensaje_chat = "10/" + partida_enviada + "/" + nombre + "/" + mensajeChat2.Text;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje_chat);
            server.Send(msg);
            mensajeChat2.Text = "";
        }
    }
}
