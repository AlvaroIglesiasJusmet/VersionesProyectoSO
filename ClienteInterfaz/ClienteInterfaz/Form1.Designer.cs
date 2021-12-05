
namespace ClienteInterfaz
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.InvitarBttn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.mensajeChat = new System.Windows.Forms.TextBox();
            this.ChatMensajes = new System.Windows.Forms.RichTextBox();
            this.Crear_Partida = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Invitado5 = new System.Windows.Forms.RichTextBox();
            this.Invitado4 = new System.Windows.Forms.RichTextBox();
            this.Invitado3 = new System.Windows.Forms.RichTextBox();
            this.Invitado2 = new System.Windows.Forms.RichTextBox();
            this.Invitado1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Button1.Location = new System.Drawing.Point(62, 110);
            this.Button1.Margin = new System.Windows.Forms.Padding(4);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(140, 71);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Conectar";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(210, 110);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 71);
            this.button2.TabIndex = 1;
            this.button2.Text = "Desconectar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxNombre.Location = new System.Drawing.Point(188, 221);
            this.textBoxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(177, 22);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 221);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 271);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBoxContraseña.Location = new System.Drawing.Point(188, 271);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.Size = new System.Drawing.Size(177, 22);
            this.textBoxContraseña.TabIndex = 5;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(62, 357);
            this.button6.Margin = new System.Windows.Forms.Padding(4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(129, 65);
            this.button6.TabIndex = 9;
            this.button6.Text = "LOGIN";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(210, 357);
            this.button7.Margin = new System.Windows.Forms.Padding(4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 65);
            this.button7.TabIndex = 10;
            this.button7.Text = "REGISTRARSE";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(31, 74);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(260, 241);
            this.dataGridView1.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.LemonChiffon;
            this.label3.Location = new System.Drawing.Point(48, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 28);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lista de Conectados";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // InvitarBttn
            // 
            this.InvitarBttn.BackColor = System.Drawing.SystemColors.Control;
            this.InvitarBttn.Location = new System.Drawing.Point(31, 333);
            this.InvitarBttn.Name = "InvitarBttn";
            this.InvitarBttn.Size = new System.Drawing.Size(260, 39);
            this.InvitarBttn.TabIndex = 14;
            this.InvitarBttn.Text = "AÑADIR A PARTIDA";
            this.InvitarBttn.UseVisualStyleBackColor = false;
            this.InvitarBttn.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.mensajeChat);
            this.groupBox1.Controls.Add(this.ChatMensajes);
            this.groupBox1.Location = new System.Drawing.Point(387, 59);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 430);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHAT GLOBAL";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(234, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(90, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "ENVIAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // mensajeChat
            // 
            this.mensajeChat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mensajeChat.Location = new System.Drawing.Point(21, 341);
            this.mensajeChat.Name = "mensajeChat";
            this.mensajeChat.Size = new System.Drawing.Size(180, 22);
            this.mensajeChat.TabIndex = 1;
            // 
            // ChatMensajes
            // 
            this.ChatMensajes.Location = new System.Drawing.Point(21, 26);
            this.ChatMensajes.Name = "ChatMensajes";
            this.ChatMensajes.Size = new System.Drawing.Size(303, 286);
            this.ChatMensajes.TabIndex = 0;
            this.ChatMensajes.Text = "";
            // 
            // Crear_Partida
            // 
            this.Crear_Partida.BackColor = System.Drawing.SystemColors.Control;
            this.Crear_Partida.Location = new System.Drawing.Point(360, 333);
            this.Crear_Partida.Name = "Crear_Partida";
            this.Crear_Partida.Size = new System.Drawing.Size(137, 63);
            this.Crear_Partida.TabIndex = 16;
            this.Crear_Partida.Text = "CREAR PARTIDA";
            this.Crear_Partida.UseVisualStyleBackColor = false;
            this.Crear_Partida.Click += new System.EventHandler(this.Crear_Partida_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.Invitado5);
            this.groupBox2.Controls.Add(this.Invitado4);
            this.groupBox2.Controls.Add(this.Invitado3);
            this.groupBox2.Controls.Add(this.Invitado2);
            this.groupBox2.Controls.Add(this.Invitado1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.Crear_Partida);
            this.groupBox2.Controls.Add(this.InvitarBttn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(742, 59);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(544, 433);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "JUEGA CON TUS AMIGOS";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(31, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 38);
            this.button4.TabIndex = 23;
            this.button4.Text = "ELIMINAR DE LA PARTIDA";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.LemonChiffon;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(334, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "Lista de Invitados";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Invitado5
            // 
            this.Invitado5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Invitado5.Location = new System.Drawing.Point(360, 280);
            this.Invitado5.Name = "Invitado5";
            this.Invitado5.Size = new System.Drawing.Size(137, 32);
            this.Invitado5.TabIndex = 21;
            this.Invitado5.Text = "";
            // 
            // Invitado4
            // 
            this.Invitado4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Invitado4.Location = new System.Drawing.Point(360, 224);
            this.Invitado4.Name = "Invitado4";
            this.Invitado4.Size = new System.Drawing.Size(137, 32);
            this.Invitado4.TabIndex = 20;
            this.Invitado4.Text = "";
            // 
            // Invitado3
            // 
            this.Invitado3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Invitado3.Location = new System.Drawing.Point(360, 174);
            this.Invitado3.Name = "Invitado3";
            this.Invitado3.Size = new System.Drawing.Size(137, 33);
            this.Invitado3.TabIndex = 19;
            this.Invitado3.Text = "";
            // 
            // Invitado2
            // 
            this.Invitado2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Invitado2.Location = new System.Drawing.Point(360, 124);
            this.Invitado2.Name = "Invitado2";
            this.Invitado2.Size = new System.Drawing.Size(137, 32);
            this.Invitado2.TabIndex = 18;
            this.Invitado2.Text = "";
            // 
            // Invitado1
            // 
            this.Invitado1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Invitado1.Location = new System.Drawing.Point(360, 74);
            this.Invitado1.Name = "Invitado1";
            this.Invitado1.Size = new System.Drawing.Size(137, 32);
            this.Invitado1.TabIndex = 17;
            this.Invitado1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1329, 592);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Button1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button InvitarBttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox ChatMensajes;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox mensajeChat;
        private System.Windows.Forms.Button Crear_Partida;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Invitado5;
        private System.Windows.Forms.RichTextBox Invitado4;
        private System.Windows.Forms.RichTextBox Invitado3;
        private System.Windows.Forms.RichTextBox Invitado2;
        private System.Windows.Forms.RichTextBox Invitado1;
        private System.Windows.Forms.Button button4;
    }
}

