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

namespace ClienteInterfaz
{
    public partial class Form1 : Form
    {
        Socket server;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.1");
            IPEndPoint ipep = new IPEndPoint(direc, 9060);


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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "2/";
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            //Queremos recibir un mensaje y dependiendo de si coinciden el usuario y la contraseña o no el servidor devolverá una cosa u otra
            //en nuestro caso enviará un "SI" si coinciden o un "NO" si no lo hacen
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string contraseña = textBoxContraseña.Text;
            string mensaje= "1/"+textBoxNombre.Text+"/"+textBoxContraseña.Text;

            //Enviamos al servidor el nombre y la contraseña tecleados
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            

            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            //Queremos recibir un mensaje y dependiendo de si coinciden el usuario y la contraseña o no el servidor devolverá una cosa u otra
            //en nuestro caso enviará un "SI" si coinciden o un "NO" si no lo hacen
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];

            if (mensaje=="SI")
            {
                
                MessageBox.Show("Te has conectado correctamente");
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                

            }
            if (mensaje=="NO")
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión 
            string mensaje = "0/";
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            //Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string mensaje = "3/";
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            //Queremos recibir un mensaje y dependiendo de si coinciden el usuario y la contraseña o no el servidor devolverá una cosa u otra
            //en nuestro caso enviará un "SI" si coinciden o un "NO" si no lo hacen
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mensaje = "4/";
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            //Queremos recibir un mensaje y dependiendo de si coinciden el usuario y la contraseña o no el servidor devolverá una cosa u otra
            //en nuestro caso enviará un "SI" si coinciden o un "NO" si no lo hacen
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
        }
    }

}

