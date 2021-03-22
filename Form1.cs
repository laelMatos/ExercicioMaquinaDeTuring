using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaquinaDeTuring
{
    public partial class Form1 : Form
    {

        private char caratere = '*';
        private int estado;

        private string Resul;
        private string proc;
        string posicoes;

        public Form1()
        {
            InitializeComponent();

            clear();
        }
        //atualiza a visualização de cada modificação para o usuario
        private void clear()
        {
            this.Entrada.Text = "-";
            this.Resultado.Text = "-";
            this.posicoes = "";
            this.estado = 0;
            this.Resul = "";
            this.proc = "";
        }
        private void Bt_iniciar_Click(object sender, EventArgs e)
        {
            clear();
            
            int[] valores = new int[2];

            //captura valores digitados pelo usuario
            valores[0] = int.Parse(Val1.Text);
            valores[1] = int.Parse(Val2.Text);

            //pega o retorno da função listaPosiçôes
            this.posicoes = listaPosicoes(valores);

            //atribui o valor para Entrada, para que fique visivel para o usuario
            Resul = posicoes;
            Vsoma = this.posicoes.ToArray();
            timer1.Start();
            //soma();
            //timer1.Stop();

        }
        /// <summary>
        /// Gera uma string com caractere('*')*valor(n) + (' ')
        /// </summary>
        /// <param name="entrada"></param>
        /// <returns></returns>
        public string listaPosicoes(int[] entrada)
        {
            string saida = "";
            foreach (var item in entrada)
            {
                for(int i =0; i< item; i++)
                {
                    saida += this.caratere;
                }

                saida += ' ';
            }
            return saida;
        }

        private string position(int posi, string valor)
        {
            char[] carac = valor.Replace(' ', '#').ToArray<char>();

            carac[posi] = '+';
            string t = SetText(carac);
            //inserir o valor da posição varrida
            return t.Replace("+", (posi+1).ToString());
        }

        private string SetText(char[] val_Result)
        {
            string result = "";
            foreach (var item in val_Result)
            {
                result += item;
            }
            return result;
        }
        private void view()
        {
            if (!string.IsNullOrEmpty(Resul))
            {
                this.Entrada.Text = Resul;
                this.Resultado.Text = proc;
            }
        }
        int i = 0;
        char[] Vsoma;
        private void timer1_Tick(object sender, EventArgs e)
        {

            if (this.estado == 0)
            {
                if (Vsoma[i] == this.caratere)
                {
                    this.estado = 0;
                }
                else
                {
                    this.estado = 1;
                    Vsoma[i] = this.caratere;
                }
            }
            else if (this.estado == 1)
            {
                if (Vsoma[i] == this.caratere)
                {
                    this.estado = 1;
                }
                else
                {
                    estado = 2;
                }
            }
            else
            {
                i = i - 1;
                Vsoma[i - 1] = ' ';
                i = i - 1;
                this.Resul = SetText(Vsoma);
                this.proc = this.posicoes.Replace(this.caratere, ' ');
                this.proc = position(i, proc);
                view();
                timer1.Stop();
            }

            this.Resul = SetText(Vsoma);
            this.proc = this.posicoes.Replace(this.caratere, ' ');
            this.proc = position(i, proc);
            i+=1;
            view();
        }
    }
}
