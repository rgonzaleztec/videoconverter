using System.Diagnostics;
using System;

namespace ConvertVideo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.RootFolder = Environment.SpecialFolder.Desktop;

            //DialogResult = diag.ShowDialog();
            if (DialogResult.OK == diag.ShowDialog())
            {
                textBox1.Text = @diag.SelectedPath.ToString();
            }
            else { textBox1.Text = ""; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog diag = new FolderBrowserDialog();
            diag.RootFolder = Environment.SpecialFolder.Desktop;

            if (DialogResult.OK == diag.ShowDialog())
            {
                textBox2.Text = @diag.SelectedPath;
            }
            else
            { textBox2.Text = ""; }
        }

        private void btnconvertir_Click(object sender, EventArgs e)
        {
            string folderPath = ""; // Ruta de la carpeta
            int fileCount = 0; // Contador de archivos
            int incremento = 0;

            if ((textBox1.Text.Length > 0) && (textBox2.Text.Length > 0))
            {
                folderPath = textBox1.Text;

                // Contar archivos en la carpeta
                DirectoryInfo directory = new DirectoryInfo(folderPath);
                FileInfo[] files = directory.GetFiles();
                fileCount = files.Length;

                MessageBox.Show($"Se van a convertir {fileCount} archivos", "Iniciado proceso de convertir FPS");

                incremento = Int32.Parse(txbIncrementarFPS.Text.ToString());

                // Abrir cada archivo en Notepad
                foreach (FileInfo file in files)
                {

                    MessageBox.Show($"Convertiendo archivo: {file.FullName}", "Convirtiendo");
                    for (int fps = Int32.Parse(fpsini.Text.ToString()); fps <= Int32.Parse(fpsfin.Text.ToString());)
                    {
                        string fulltask = @"-i " + "\"" + file.FullName + "\"" + " -filter:v fps=" + fps.ToString() + " \"" + textBox2.Text + "\\" + fps.ToString() + "-" + file.Name + "\"";

                        Process ffmpegProcess = new Process();
                        ffmpegProcess.StartInfo.FileName = "\"" + textBox3.Text + "\"";
                        ffmpegProcess.StartInfo.Arguments = @fulltask;
                        //MessageBox.Show(fulltask);
                        ffmpegProcess.StartInfo.UseShellExecute = false;
                        ffmpegProcess.StartInfo.RedirectStandardError = true;
                        ffmpegProcess.Start();
                        ffmpegProcess.WaitForExit();
                        fps = fps + incremento;
                    }
                    MessageBox.Show("El archivo se ha convertido con éxito con ffmpeg.", file.Name);

                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog diag = new OpenFileDialog();
            diag.ShowDialog();

            if (diag.FileName.Length > 0)
            {
                textBox3.Text = @diag.FileName;
            }
            else
            { textBox3.Text = ""; }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}