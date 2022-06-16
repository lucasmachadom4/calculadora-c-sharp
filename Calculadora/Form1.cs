using System;
using System.Windows.Forms;
using Calculadora.Utilitarios;
using Calculadora.Personalizacoes;
using System.Runtime.InteropServices;
using System.Linq;
using Microsoft.Win32;
using System.Drawing;

namespace Calculadora
{
    public partial class formCalculadora : Form
    {
        private UserPreferenceChangedEventHandler UserPreferenceChanged;

        private void CarregarTema()
        {
            var themaColor = WindowsTema.GetAccentColor();
            var lightColor = ControlPaint.Light(themaColor);
            var lightLightColor = ControlPaint.LightLight(themaColor);
            var darkColor = ControlPaint.Dark(themaColor);
            var darkDarkColor = ControlPaint.DarkDark(themaColor);

            BackColor = darkColor;
            btnIgualdade.BackColor = lightLightColor;

            txtBoxSaida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtBoxSaida.BackColor = this.BackColor;
            txtBoxEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            txtBoxEntrada.BackColor = this.BackColor;

            foreach (Button button in this.Controls.OfType<Button>())
            {
                button.FlatStyle = FlatStyle.Flat;
                button.FlatAppearance.BorderColor = Color.White;
                button.FlatAppearance.BorderSize = 2;
            }
        }
        private void SystemEvents_UserPreferenceChanged(object sender, UserPreferenceChangedEventArgs e)
        {
            if (e.Category == UserPreferenceCategory.General || e.Category == UserPreferenceCategory.VisualStyle)
            {
                CarregarTema();
            }
        }
        private void Form_Dispose(object sender, EventArgs e)
        {
            SystemEvents.UserPreferenceChanged -= UserPreferenceChanged;
        }

        public formCalculadora()
        {
            InitializeComponent();
            CarregarTema();

            UserPreferenceChanged = new UserPreferenceChangedEventHandler(SystemEvents_UserPreferenceChanged);
            SystemEvents.UserPreferenceChanged += UserPreferenceChanged;
            this.Disposed += new EventHandler(Form_Dispose);
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Equals("0") ? "0" : txtBoxEntrada.Text + "0";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
               "1" : txtBoxEntrada.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "2" : txtBoxEntrada.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "3" : txtBoxEntrada.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "4" : txtBoxEntrada.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "5" : txtBoxEntrada.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "6" : txtBoxEntrada.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "7" : txtBoxEntrada.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "8" : txtBoxEntrada.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = txtBoxEntrada.Text.Substring(0, 1).Equals("0") && !txtBoxEntrada.Text.Contains(",") ?
                "9" : txtBoxEntrada.Text + "9";
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            if (!txtBoxEntrada.Text.Contains(","))
                txtBoxEntrada.Text += ",";
            
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            OperacaoMatematica operacao = new OperacaoMatematica();
            if (txtBoxSaida.Text.Equals(""))
            {
                operacao.Numero1 = txtBoxEntrada.Text;
            }
            else
            {
                operacao.Numero1 = txtBoxSaida.Text.Substring(0, txtBoxSaida.Text.Length - 1);
                operacao.Numero2 = txtBoxEntrada.Text;
            }
            txtBoxSaida.Text = operacao.Somar() + "+";
            txtBoxEntrada.Text = "0";
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            OperacaoMatematica operacao = new OperacaoMatematica();
            if (txtBoxSaida.Text.Equals(""))
            {
                operacao.Numero1 = txtBoxEntrada.Text;
            }
            else
            {
                operacao.Numero1 = txtBoxSaida.Text.Substring(0, txtBoxSaida.Text.Length - 1);
                operacao.Numero2 = txtBoxEntrada.Text;
            }
            txtBoxSaida.Text = operacao.Subtrair() + "-";
            txtBoxEntrada.Text = "0";
        }

        private void btnMultiplicacao_Click(object sender, EventArgs e)
        {
            OperacaoMatematica operacao = new OperacaoMatematica();
            if (txtBoxSaida.Text.Equals(""))
            {
                operacao.Numero1 = txtBoxEntrada.Text;
            }
            else
            {
                operacao.Numero1 = txtBoxSaida.Text.Substring(0, txtBoxSaida.Text.Length - 1);
                operacao.Numero2 = txtBoxEntrada.Text;
            }
            txtBoxSaida.Text = operacao.Multiplicar() + "x";
            txtBoxEntrada.Text = "0";
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            OperacaoMatematica operacao = new OperacaoMatematica();
            if (txtBoxSaida.Text.Equals(""))
            {
                operacao.Numero1 = txtBoxEntrada.Text;
            }
            else
            {
                operacao.Numero1 = txtBoxSaida.Text.Substring(0, txtBoxSaida.Text.Length - 1);
                operacao.Numero2 = txtBoxEntrada.Text;
            }           
            txtBoxSaida.Text = operacao.Dividir() + "/";
            txtBoxEntrada.Text = "0";
        }

        private void btnIgualdade_Click(object sender, EventArgs e)
        {
            if (!txtBoxSaida.Text.Equals(""))
            {
                OperacaoMatematica operacao = new OperacaoMatematica();

                operacao.Numero1 = txtBoxSaida.Text.Substring(0, txtBoxSaida.Text.Length - 1);
                operacao.Numero2 = txtBoxEntrada.Text;

                string operador = txtBoxSaida.Text.Substring(txtBoxSaida.Text.Length - 1);
                if (operador.Equals("+"))
                {
                    txtBoxSaida.Text = operacao.Somar() + "+";
                }
                if (operador.Equals("-"))
                {
                    txtBoxSaida.Text = operacao.Subtrair() + "-";
                }
                if (operador.Equals("x"))
                {
                    txtBoxSaida.Text = operacao.Multiplicar() + "x";
                }
                if (operador.Equals("/"))
                {
                    txtBoxSaida.Text = operacao.Dividir() + "/";
                }
                txtBoxEntrada.Text = "0";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = "0";
            txtBoxSaida.Clear();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtBoxEntrada.Text = "0";
        }
        
        private void formCalculadora_KeyPress(object sender, KeyPressEventArgs e) //KeyPressEventArgs
        {
            if (e.KeyChar == (char)Keys.D0) { btn0_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D1) { btn1_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D2) { btn2_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D3) { btn3_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D4) { btn4_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D5) { btn5_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D6) { btn6_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D7) { btn7_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D8) { btn8_Click(sender, e); }
            if (e.KeyChar == (char)Keys.D9) { btn9_Click(sender, e); }
           
            if (e.KeyChar == '+') { btnSoma_Click(sender, e); }
            if (e.KeyChar == '-') { btnSubtracao_Click(sender, e); }
            if (e.KeyChar == '*') { btnMultiplicacao_Click(sender, e); }
            if (e.KeyChar == '/') { btnDivisao_Click(sender, e); }
            if (e.KeyChar == ',') { btnVirgula_Click(sender, e); }
            if (e.KeyChar == '=') { btnIgualdade_Click(sender, e); }
            if (e.KeyChar == (char)Keys.Escape) { btnCancelar_Click(sender, e); }            

            if (e.KeyChar == (char)Keys.Back)
            {
                txtBoxEntrada.Text = txtBoxEntrada.Text.Length == 1 ?
                   "0" : txtBoxEntrada.Text.Substring(0, txtBoxEntrada.Text.Length - 1);
                e.Handled = true; 
            } 
        }

        //Console para teste
        /*private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole(); */
    }
}
