
namespace ClienteInterfaz
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.numPartida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnviarChat2 = new System.Windows.Forms.Button();
            this.mensajeChat2 = new System.Windows.Forms.TextBox();
            this.chatForm2 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.preguntaTrivial = new System.Windows.Forms.Label();
            this.opcion1 = new System.Windows.Forms.Label();
            this.opcion2 = new System.Windows.Forms.Label();
            this.opcion3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NombreJugador = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PuntosJugador = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.preguntasFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoIntroduzcoUnaPreguntaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comoPidoLosPuntosDeMiRivalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(840, 154);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(139, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "DAME PUNTOS \r\n";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numPartida
            // 
            this.numPartida.AutoSize = true;
            this.numPartida.BackColor = System.Drawing.Color.Transparent;
            this.numPartida.Location = new System.Drawing.Point(705, 47);
            this.numPartida.Name = "numPartida";
            this.numPartida.Size = new System.Drawing.Size(82, 17);
            this.numPartida.TabIndex = 3;
            this.numPartida.Text = "NumPartida";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.EnviarChat2);
            this.groupBox1.Controls.Add(this.mensajeChat2);
            this.groupBox1.Controls.Add(this.chatForm2);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Location = new System.Drawing.Point(1225, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 247);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHAT DE JUEGO";
            // 
            // EnviarChat2
            // 
            this.EnviarChat2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.EnviarChat2.Location = new System.Drawing.Point(155, 199);
            this.EnviarChat2.Name = "EnviarChat2";
            this.EnviarChat2.Size = new System.Drawing.Size(104, 32);
            this.EnviarChat2.TabIndex = 2;
            this.EnviarChat2.Text = "ENVIAR";
            this.EnviarChat2.UseVisualStyleBackColor = true;
            this.EnviarChat2.Click += new System.EventHandler(this.EnviarChat2_Click);
            // 
            // mensajeChat2
            // 
            this.mensajeChat2.Location = new System.Drawing.Point(21, 201);
            this.mensajeChat2.Name = "mensajeChat2";
            this.mensajeChat2.Size = new System.Drawing.Size(107, 35);
            this.mensajeChat2.TabIndex = 1;
            // 
            // chatForm2
            // 
            this.chatForm2.Location = new System.Drawing.Point(21, 34);
            this.chatForm2.Name = "chatForm2";
            this.chatForm2.Size = new System.Drawing.Size(238, 161);
            this.chatForm2.TabIndex = 0;
            this.chatForm2.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(520, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de Partida:";
            // 
            // preguntaTrivial
            // 
            this.preguntaTrivial.BackColor = System.Drawing.Color.Transparent;
            this.preguntaTrivial.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.preguntaTrivial.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.preguntaTrivial.Location = new System.Drawing.Point(31, 522);
            this.preguntaTrivial.Name = "preguntaTrivial";
            this.preguntaTrivial.Size = new System.Drawing.Size(1134, 59);
            this.preguntaTrivial.TabIndex = 7;
            this.preguntaTrivial.Text = "Pregunta";
            this.preguntaTrivial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // opcion1
            // 
            this.opcion1.AutoSize = true;
            this.opcion1.BackColor = System.Drawing.Color.Transparent;
            this.opcion1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opcion1.Location = new System.Drawing.Point(194, 598);
            this.opcion1.Name = "opcion1";
            this.opcion1.Size = new System.Drawing.Size(65, 17);
            this.opcion1.TabIndex = 10;
            this.opcion1.Text = "Opcion a";
            this.opcion1.Click += new System.EventHandler(this.opcion1_historia_Click);
            // 
            // opcion2
            // 
            this.opcion2.AutoSize = true;
            this.opcion2.BackColor = System.Drawing.Color.Transparent;
            this.opcion2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opcion2.Location = new System.Drawing.Point(195, 632);
            this.opcion2.Name = "opcion2";
            this.opcion2.Size = new System.Drawing.Size(65, 17);
            this.opcion2.TabIndex = 11;
            this.opcion2.Text = "Opcion b";
            // 
            // opcion3
            // 
            this.opcion3.AutoSize = true;
            this.opcion3.BackColor = System.Drawing.Color.Transparent;
            this.opcion3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.opcion3.Location = new System.Drawing.Point(195, 666);
            this.opcion3.Name = "opcion3";
            this.opcion3.Size = new System.Drawing.Size(64, 17);
            this.opcion3.TabIndex = 12;
            this.opcion3.Text = "Opcion c";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(385, 598);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 19;
            this.button1.Text = "a";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(385, 632);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 27);
            this.button2.TabIndex = 20;
            this.button2.Text = "b";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(385, 666);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 29);
            this.button4.TabIndex = 21;
            this.button4.Text = "c";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.ForeColor = System.Drawing.Color.Black;
            this.button5.Location = new System.Drawing.Point(571, 230);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 227);
            this.button5.TabIndex = 22;
            this.button5.Text = "GIRAR RULETA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1012, 165);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(134, 22);
            this.textBox1.TabIndex = 23;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::ClienteInterfaz.Properties.Resources.flecha__1_;
            this.pictureBox2.Location = new System.Drawing.Point(230, 44);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 25;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(12, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 413);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.Color.Transparent;
            this.timeLabel.Font = new System.Drawing.Font("Ravie", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.timeLabel.Location = new System.Drawing.Point(543, 133);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(156, 54);
            this.timeLabel.TabIndex = 26;
            this.timeLabel.Text = "label2";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(828, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "JUGADOR:";
            // 
            // NombreJugador
            // 
            this.NombreJugador.AutoSize = true;
            this.NombreJugador.BackColor = System.Drawing.Color.Transparent;
            this.NombreJugador.Location = new System.Drawing.Point(918, 46);
            this.NombreJugador.Name = "NombreJugador";
            this.NombreJugador.Size = new System.Drawing.Size(110, 17);
            this.NombreJugador.TabIndex = 28;
            this.NombreJugador.Text = "NombreJugador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(910, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 29;
            this.label3.Text = "PUNTOS:";
            // 
            // PuntosJugador
            // 
            this.PuntosJugador.AutoSize = true;
            this.PuntosJugador.BackColor = System.Drawing.Color.Transparent;
            this.PuntosJugador.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PuntosJugador.ForeColor = System.Drawing.Color.Linen;
            this.PuntosJugador.Location = new System.Drawing.Point(1020, 213);
            this.PuntosJugador.Name = "PuntosJugador";
            this.PuntosJugador.Size = new System.Drawing.Size(66, 26);
            this.PuntosJugador.TabIndex = 30;
            this.PuntosJugador.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(567, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 31;
            this.label4.Text = "Te quedan:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(742, 435);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 32;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(776, 370);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(436, 22);
            this.textBox3.TabIndex = 33;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(831, 435);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 34;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(944, 435);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 35;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(1050, 435);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 36;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(1165, 435);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkBlue;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(863, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(262, 19);
            this.label5.TabIndex = 38;
            this.label5.Text = "AÑADE TU PREGUNTA AL JUEGO!";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(863, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(278, 19);
            this.label6.TabIndex = 39;
            this.label6.Text = "PIDE LOS PUNTOS DE TUS RIVALES!";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(944, 482);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(105, 37);
            this.button6.TabIndex = 40;
            this.button6.Text = "ENVIAR";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(717, 409);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(618, 23);
            this.label7.TabIndex = 41;
            this.label7.Text = "Categoria        Opcion a)            Opcion b)          Opcion c)        Respues" +
    "ta correcta";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Text = "Menu";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.preguntasFrecuentesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1506, 28);
            this.menuStrip1.TabIndex = 43;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // preguntasFrecuentesToolStripMenuItem
            // 
            this.preguntasFrecuentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comoIntroduzcoUnaPreguntaToolStripMenuItem,
            this.comoPidoLosPuntosDeMiRivalToolStripMenuItem});
            this.preguntasFrecuentesToolStripMenuItem.Name = "preguntasFrecuentesToolStripMenuItem";
            this.preguntasFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(160, 24);
            this.preguntasFrecuentesToolStripMenuItem.Text = "Preguntas frecuentes";
            // 
            // comoIntroduzcoUnaPreguntaToolStripMenuItem
            // 
            this.comoIntroduzcoUnaPreguntaToolStripMenuItem.Name = "comoIntroduzcoUnaPreguntaToolStripMenuItem";
            this.comoIntroduzcoUnaPreguntaToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.comoIntroduzcoUnaPreguntaToolStripMenuItem.Text = "¿Como introduzco una pregunta?";
            this.comoIntroduzcoUnaPreguntaToolStripMenuItem.Click += new System.EventHandler(this.comoIntroduzcoUnaPreguntaToolStripMenuItem_Click);
            // 
            // comoPidoLosPuntosDeMiRivalToolStripMenuItem
            // 
            this.comoPidoLosPuntosDeMiRivalToolStripMenuItem.Name = "comoPidoLosPuntosDeMiRivalToolStripMenuItem";
            this.comoPidoLosPuntosDeMiRivalToolStripMenuItem.Size = new System.Drawing.Size(327, 26);
            this.comoPidoLosPuntosDeMiRivalToolStripMenuItem.Text = "¿Como pido los puntos de mi rival?";
            this.comoPidoLosPuntosDeMiRivalToolStripMenuItem.Click += new System.EventHandler(this.comoPidoLosPuntosDeMiRivalToolStripMenuItem_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(961, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Pregunta";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = global::ClienteInterfaz.Properties.Resources.fondo_final1;
            this.ClientSize = new System.Drawing.Size(1506, 732);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PuntosJugador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NombreJugador);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.opcion3);
            this.Controls.Add(this.opcion2);
            this.Controls.Add(this.opcion1);
            this.Controls.Add(this.preguntaTrivial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numPartida);
            this.Controls.Add(this.button3);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label numPartida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mensajeChat2;
        private System.Windows.Forms.RichTextBox chatForm2;
        private System.Windows.Forms.Button EnviarChat2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label preguntaTrivial;
        private System.Windows.Forms.Label opcion1;
        private System.Windows.Forms.Label opcion2;
        private System.Windows.Forms.Label opcion3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label NombreJugador;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label PuntosJugador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem preguntasFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoIntroduzcoUnaPreguntaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comoPidoLosPuntosDeMiRivalToolStripMenuItem;
        private System.Windows.Forms.Label label8;
    }
}