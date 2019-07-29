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
        public bool valid;
        public string[] Palabras;
        public string ruta, result, autoName = "Sumador";

        public Form1() {
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

        private void save_Click(object sender, EventArgs e) {
            StreamWriter escribir = new StreamWriter(ruta, true);
            try {
                if (inputData.Text != null || inputData.Text != "") {
                    escribir.WriteLine(inputData.Text);
                    escribir.Close();
                    inputMessage.AppendText(inputData.Text + "\n");
                    switch (autoName) {
                        case "doubleCero":
                            result = doubleCero(inputData.Text);
                            break;
                        case "Restador":
                            result = restador(inputData.Text);
                            break;
                        case "Sumador":
                            result = sumador(inputData.Text);
                            break;
                    }
                    inputMessage.AppendText(result + "\n\n");
                }
                inputData.Text = "";
            }
            catch {
                MessageBox.Show("error");
            }
        }

        private void sumadorToolStripMenuItem_Click(object sender, EventArgs e) {
            autoName = "Sumador";
            nameAuto.Text = autoName;
        }

        private void restadorToolStripMenuItem_Click(object sender, EventArgs e) {
            autoName = "Restador";
            nameAuto.Text = autoName;
        }

        private void parDe0ToolStripMenuItem_Click(object sender, EventArgs e) {
            autoName = "doubleCero";
            nameAuto.Text = "Numero par de ceros";
        }

        private void label1_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void minimizar_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        private string sumador(string word) {
            string finishWord = "", status = "q0";
            char[] l, res;
            int i = 0;

            if (int.TryParse(word, out i)) {
                word = 'b' + word + 'b';
                l = word.ToCharArray();
                res = l;
                for (int j = 0; j < word.Length;) {
                    switch (status) {
                        case "q0":
                            if (j == 0 && l[j] == 'b' || j != 0 && l[j] != 'b') {
                                res[j] = l[j];
                                j++;
                            }
                            else {
                                status = "q1";
                                j--;
                            }
                            if (l[j] != 'b' && l[j] != '1' && l[j] != '0') {
                                status = "failure";
                            }
                            break;
                        case "q1":
                            if (res[j] == '0' || res[j] == 'b') {
                                res[j] = '1';
                                status = "finish";
                            }
                            else if (res[j] == '1') {
                                res[j] = '0';
                                j--;
                            }
                            break;
                        case "finish":
                            j = word.Length+2;
                            break;
                        case "failure":
                            return "El digito no es binario";
                    }
                }
                for (int j = 0; j < word.Length - 1; j++) {
                    if (res[j] != 'b') {
                        finishWord = finishWord + res[j];
                    }
                }
                return finishWord;
            }
            else {
                return "No se puede realizar la operación";
            }
        }

        private string restador(string word) {
            string finishWord = "", status = "q0";
            char[] l, res;
            int i = 0;

            if (int.TryParse(word, out i)) {
                word = 'b' + word + 'b';
                l = word.ToCharArray();
                res = l;
                for (int j = 0; j < word.Length;) {
                    switch (status) {
                        case "q0":
                            if (j == 0 && l[j] == 'b' || j != 0 && l[j] != 'b') {
                                res[j] = l[j];
                                j++;
                            }
                            else {
                                status = "q1";
                                j--;
                            }
                            if (l[j] != 'b' && l[j] != '1' && l[j] != '0') {
                                status = "failure";
                            }
                            break;
                        case "q1":
                            if (res[j] == '1') {
                                res[j] = '0';
                                status = "finish";
                            }else if (res[j] == '0') {
                                res[j] = '1';
                                j--;
                            }
                            else {
                                status = "failure";
                            }
                            break;
                        case "finish":
                            j = word.Length+2;
                            break;
                        case "failure":
                            return "El digito no se puede restar con este proseso";
                    }
                }
                for (int j = 0; j < word.Length - 1; j++) {
                    if (res[j] != 'b') {
                        finishWord = finishWord + res[j];
                    }
                }
                return finishWord;
            }
            else {
                return "No se puede realizar la operación";
            }
        }

        private string doubleCero(string word) {
            string finishWord ="", status = "q0";
            char[] l;
            int i = 0;

            if (int.TryParse(word, out i)) {
                word = word + 'b';
                l = word.ToCharArray();
                for (int j = 0; j < word.Length;) {
                    switch (status) {
                        case "q0":
                            if (l[j] == '0') {
                                status = "q1";
                                j++;
                            }
                            else if (l[j] == '1') {
                                j++;
                            }else if (l[j] == 'b') {
                                status = "finish";
                            }
                            if (l[j] != 'b' && l[j] != '1' && l[j] != '0') {
                                status = "failure";
                            }
                            break;
                        case "q1":
                            if (l[j] == '0') {
                                status = "q0";
                                j++;
                            }else if(l[j] == '1') {
                                j++;
                            }else if (j != 0 && l[j] == 'b') {
                                status = "error";
                            }
                            break;
                        case "finish":
                            j++;
                            finishWord = "Si cuenta con par de 0";
                            break;
                        case "error":
                            j++;
                            finishWord = "No cuenta con par de 0";
                            break;
                        case "failure":
                            j++;
                            finishWord = "El digito no es binario";
                            break;
                    }
                }
                return finishWord;
            }
            else {
                return "No se puede realizar la operación";
            }
        }

    }
}
