using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Btnlimpar_Click(object sender, EventArgs e)
        {
            // Limpa o TextBox
            TxtbTela.Clear();
        }

        private void Numero_Click(object sender, EventArgs e)
        {
            // Recebe qual número o usuário digitou
            Button botaoclicado = (Button)sender;
            string numero = botaoclicado.Text;
            // Adiciona o número ao TextBox
            TxtbTela.Text += numero;
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            Button botaoclicado = (Button)sender;
            string operador = botaoclicado.Text;

            //Não permite comecar com operador
            if (string.IsNullOrEmpty(TxtbTela.Text))
            {
                return;
            }
            // Pega o último caractere que foi digitado no TextBox
            char ultimoChar = TxtbTela.Text[TxtbTela.Text.Length - 1];
            if ("+-x÷".Contains(ultimoChar))
            {
                // Substitui operador anterior pelo novo operador
                TxtbTela.Text = TxtbTela.Text.Remove(TxtbTela.Text.Length - 1) + operador;
            }
            else
            {
                // Adiciona o operador normalmente
                TxtbTela.Text += operador;
            }
        }

        private void Btnigual_Click(object sender, EventArgs e)
        {
            // Troca os operadores para os símbolos que o DataTable entende   
            string expressao = TxtbTela.Text.Replace("÷", "/").Replace("x", "*").Replace(",",".");
            if (expressao.Contains("/0"))
            {
                // Não calcula, mantém a tela como está
                return;
            }

            try
            {

                DataTable dt = new DataTable();
                var resultado = dt.Compute(expressao, "");
                TxtbTela.Text = resultado.ToString();
            }
            catch
            {
                // Se ocorrer qualquer erro, não altera a tela
            }
        }

        private void TxtbTela_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permite digitar números    
            char key = e.KeyChar;

            //Permite digitar números e operadores
            if (!char.IsControl(key) && !char.IsDigit(key) && !"+-*/".Contains(key))
            {
                e.Handled = true;
                return;
            }
            //Recebe se a pessoa digitou algum operador 
            if ("+-*/".Contains(key))
            {
                // Lógica para impedir zeros inválidos
                if (TxtbTela.Text.Length == 0)
                {
                    e.Handled = true;
                    return;
                }

                // Se for operador, verifica se já tem um no final e substitui
                char ultimoChar = TxtbTela.Text[TxtbTela.Text.Length - 1];
                if ("+-x÷*/".Contains(ultimoChar))
                {
                    // Substitui o operador anterior
                    TxtbTela.Text = TxtbTela.Text.Remove(TxtbTela.Text.Length - 1);
                }

                // Substitui '/' por '÷' e '*' por 'x'
                if (key == '/')
                {
                    TxtbTela.Text += '÷';
                }
                else if (key == '*')
                {
                    TxtbTela.Text += 'x';
                }
                else
                {
                    TxtbTela.Text += key;
                }

                e.Handled = true;
                return;
            }

        }
        private void TxtbTela_TextChanged(object sender, EventArgs e)
        {
            // Posiciona o cursor sempre no final do texto
            TxtbTela.SelectionStart = TxtbTela.Text.Length;
            TxtbTela.SelectionLength = 0;
        }
        private void TxtbTela_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true; 
                e.SuppressKeyPress = true;

                Btnigual_Click(sender, e);
            }
        }
    }
}
