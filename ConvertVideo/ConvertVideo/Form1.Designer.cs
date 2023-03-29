namespace ConvertVideo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            textBox1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnconvertir = new Button();
            label5 = new Label();
            button3 = new Button();
            textBox3 = new TextBox();
            button4 = new Button();
            label6 = new Label();
            txbIncrementarFPS = new TextBox();
            fpsini = new TextBox();
            fpsfin = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 33);
            label1.Name = "label1";
            label1.Size = new Size(173, 25);
            label1.TabIndex = 0;
            label1.Text = "Ubicacion de Videos";
            // 
            // folderBrowserDialog1
            // 
            folderBrowserDialog1.Description = "Carpeta con Videos";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(225, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 31);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(534, 33);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 2;
            button1.Text = "Seleccionar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(534, 92);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "Seleccionar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(225, 92);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 31);
            textBox2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 92);
            label2.Name = "label2";
            label2.Size = new Size(150, 25);
            label2.TabIndex = 3;
            label2.Text = "Carpeta de Salida";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 223);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 6;
            label3.Text = "FPS Inicial";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 264);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 7;
            label4.Text = "FPS Final";
            // 
            // btnconvertir
            // 
            btnconvertir.Location = new Point(295, 329);
            btnconvertir.Name = "btnconvertir";
            btnconvertir.Size = new Size(112, 34);
            btnconvertir.TabIndex = 12;
            btnconvertir.Text = "Convertir";
            btnconvertir.UseVisualStyleBackColor = true;
            btnconvertir.Click += btnconvertir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(29, 141);
            label5.Name = "label5";
            label5.Size = new Size(182, 25);
            label5.TabIndex = 13;
            label5.Text = "Ubicacion del ffmpeg";
            // 
            // button3
            // 
            button3.Location = new Point(534, 141);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 15;
            button3.Text = "Seleccionar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(225, 141);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 31);
            textBox3.TabIndex = 14;
            // 
            // button4
            // 
            button4.Location = new Point(534, 418);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 16;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(326, 245);
            label6.Name = "label6";
            label6.Size = new Size(102, 25);
            label6.TabIndex = 17;
            label6.Text = "Incremento";
            // 
            // txbIncrementarFPS
            // 
            txbIncrementarFPS.Location = new Point(440, 247);
            txbIncrementarFPS.Name = "txbIncrementarFPS";
            txbIncrementarFPS.Size = new Size(150, 31);
            txbIncrementarFPS.TabIndex = 18;
            // 
            // fpsini
            // 
            fpsini.Location = new Point(127, 217);
            fpsini.Name = "fpsini";
            fpsini.Size = new Size(84, 31);
            fpsini.TabIndex = 19;
            // 
            // fpsfin
            // 
            fpsfin.Location = new Point(127, 264);
            fpsfin.Name = "fpsfin";
            fpsfin.Size = new Size(84, 31);
            fpsfin.TabIndex = 20;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(682, 470);
            Controls.Add(fpsfin);
            Controls.Add(fpsini);
            Controls.Add(txbIncrementarFPS);
            Controls.Add(label6);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(btnconvertir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Convertidor de FPS para videos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FolderBrowserDialog folderBrowserDialog1;
        private TextBox textBox1;
        private Button button1;
        private Button button2;
        private TextBox textBox2;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnconvertir;
        private Label label5;
        private Button button3;
        private TextBox textBox3;
        private Button button4;
        private Label label6;
        private TextBox txbIncrementarFPS;
        private TextBox fpsini;
        private TextBox fpsfin;
    }
}