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

        public Form1()
        {
            InitializeComponent();

            CheckForIllegalCrossThreadCalls = false; 
            //hace que los elementos de los formularios puedan ser accedidos por threads diferentes

        }

        private void AtenderServidor()
        {
            while(true)
            {
                //Recibimos mensaje del servidor
                byte[] msg2 = new byte[200];
                server.Receive(msg2);

                string [] trozos = Encoding.ASCII.GetString(msg2).Split('/');
                int codigo = Convert.ToInt32(trozos[0]);
                string mensaje = trozos[1].Split('\0')[0];

                switch (codigo)
                {
                   

                    case 1: //quieren loguearse


                        if (mensaje == "SI")
                        {

                            MessageBox.Show("Te has conectado correctamente");
                            button3.Enabled = true;
                            button4.Enabled = true;
                            button5.Enabled = true;

                        }

                        else if (mensaje == "NO")
                        {
                            MessageBox.Show("Usuario o contraseña incorrectos");
                        }
                        break;


                    case 2: //piden registrarse

                      
                        if (mensaje == "Registrado")
                        {
                            MessageBox.Show("Te has registrado correctamente");
                            button3.Enabled = true;
                            button4.Enabled = true;
                            button5.Enabled = true;
                            
                        }

                        else
                        {
                            MessageBox.Show("Ya existe ese nombre de usuario, por favor, usa otro");
                        }
                        break;

                    case 3: //pide los puntos de Juan

   
                        MessageBox.Show(mensaje);
                        break;

                    case 4: //recibo notificacion

                        int NumConectados = Convert.ToInt32(mensaje);
                        dataGridView1.RowCount = NumConectados;
                        dataGridView1.ColumnCount = 1;
                        for (int n = 2; n < trozos.Length;) // añadimos a los usuarios al datagridview
                        {
                            dataGridView1.Rows[n - 2].Cells[0].Value = trozos[n];
                            n++;
                        }
                        break;


                }

            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("147.83.117.22");
            IPEndPoint ipep = new IPEndPoint(direc, 50016);


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

        private void button3_Click(object sender, EventArgs e)
        {
            string mensaje = "2/";
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            /*
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[200];
            server.Receive(msg2);
            
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(mensaje);
            */
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string contraseña = textBoxContraseña.Text;
            string mensaje= "1/"+textBoxNombre.Text+"/"+textBoxContraseña.Text;

            //Enviamos al servidor el nombre y la contraseña tecleados
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);
            
            /*
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
            */
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
            atender.Abort();
            byte[] msg2 = new byte[200];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(mensaje);
            dataGridView1.Rows.Clear();
            

            textBoxNombre.Clear();
            textBoxContraseña.Clear();
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
             /*
            //Recibimos la respuesta del servidor
            byte[] msg2 = new byte[200];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(mensaje);
             */
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string mensaje = "4/";
            //Enviamos el mensaje
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

           
        }

        private void button7_Click(object sender, EventArgs e)
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
    }
}



