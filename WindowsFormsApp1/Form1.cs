using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string[] Palabras;
        public string ruta, result, autoName = "Sumador";

        public Form1()
        {
            InitializeComponent();
            nameAuto.Text = autoName;
        }

        private void Archivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos txt(*.txt)|*.txt";
            open.Title = "Archivos txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta = open.FileName;
                //inputMessage.AppendText(ruta);
            }
            open.Dispose();
        }

        private void restadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoName = "Restador";
            nameAuto.Text = autoName;
        }

        private void parDe0ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            autoName = "doubleCero";
            nameAuto.Text = "Numero par de ceros";
        }

        private void subirArchivoToolStripMenuItem_Click(object sender, EventArgs e){
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Archivos txt(*.txt)|*.txt";
            open.Title = "Archivos txt";
            if (open.ShowDialog() == DialogResult.OK)
            {
                ruta = open.FileName;
                inputMessage.AppendText(ruta);
            }
            open.Dispose();
        }

        private void Star_Click(object sender, EventArgs e){
            StreamReader leer = new StreamReader(ruta);
            string linea;
            inputMessage.Clear();
            try{
                linea = leer.ReadLine();
                while (linea != null){
                    inputMessage.AppendText(linea + "\n");
                    switch (autoName) {
                        case "doubleCero":
                            result = doubleCero(linea);
                            break;
                        case "Restador":
                            result = restador(linea);
                            break;
                        case "Sumador":
                            result = sumador(linea);
                            break;
                    }
                    inputMessage.AppendText(result + "\n\n");
                    linea = leer.ReadLine();
                }
            }
            catch{
                MessageBox.Show("error");
            }
            leer.Close();
        }

        private void sumadorToolStripMenuItem_Click(object sender, EventArgs e){
            autoName = "Sumador";
            nameAuto.Text = autoName;
        }

        private string sumador(string word){
            string res = "";
            int i=0;

            if(int.TryParse(word, out i)){
                return (i+1).ToString();
            }
            else {
                return "No se puede realizar la operación";
            }
        }

        private string restador(string word) {
            string res = "";
            return res;
        }

        private string doubleCero(string word) {
            string res = "";
            return res;
        }
    }
}
