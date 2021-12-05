
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.numPartida = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chatForm2 = new System.Windows.Forms.RichTextBox();
            this.mensajeChat2 = new System.Windows.Forms.TextBox();
            this.EnviarChat2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "DAME GANADORES DE JUAN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(318, 53);
            this.button2.TabIndex = 1;
            this.button2.Text = "DAME GANADORES DEL 30/03/21";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 282);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(318, 52);
            this.button3.TabIndex = 2;
            this.button3.Text = "DAME PUNTOS DE JUAN";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // numPartida
            // 
            this.numPartida.AutoSize = true;
            this.numPartida.Location = new System.Drawing.Point(240, 42);
            this.numPartida.Name = "numPartida";
            this.numPartida.Size = new System.Drawing.Size(82, 17);
            this.numPartida.TabIndex = 3;
            this.numPartida.Text = "NumPartida";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox1.Controls.Add(this.EnviarChat2);
            this.groupBox1.Controls.Add(this.mensajeChat2);
            this.groupBox1.Controls.Add(this.chatForm2);
            this.groupBox1.Location = new System.Drawing.Point(414, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 313);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CHAT DE JUEGO";
            // 
            // chatForm2
            // 
            this.chatForm2.Location = new System.Drawing.Point(21, 34);
            this.chatForm2.Name = "chatForm2";
            this.chatForm2.Size = new System.Drawing.Size(267, 226);
            this.chatForm2.TabIndex = 0;
            this.chatForm2.Text = "";
            // 
            // mensajeChat2
            // 
            this.mensajeChat2.Location = new System.Drawing.Point(21, 271);
            this.mensajeChat2.Name = "mensajeChat2";
            this.mensajeChat2.Size = new System.Drawing.Size(164, 22);
            this.mensajeChat2.TabIndex = 1;
            // 
            // EnviarChat2
            // 
            this.EnviarChat2.Location = new System.Drawing.Point(191, 266);
            this.EnviarChat2.Name = "EnviarChat2";
            this.EnviarChat2.Size = new System.Drawing.Size(97, 32);
            this.EnviarChat2.TabIndex = 2;
            this.EnviarChat2.Text = "ENVIAR";
            this.EnviarChat2.UseVisualStyleBackColor = true;
            this.EnviarChat2.Click += new System.EventHandler(this.EnviarChat2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightYellow;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Numero de Partida:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.numPartida);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label numPartida;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mensajeChat2;
        private System.Windows.Forms.RichTextBox chatForm2;
        private System.Windows.Forms.Button EnviarChat2;
        private System.Windows.Forms.Label label1;
    }
}