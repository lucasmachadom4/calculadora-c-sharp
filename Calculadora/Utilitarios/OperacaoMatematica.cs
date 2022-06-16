using System;

namespace Calculadora.Utilitarios
{
    internal class OperacaoMatematica
    {
        string numero1;
        string numero2;
        double numero1Covertido;
        double numero2Covertido;
        
        public string Numero1
        {
            get { return numero1; }
            set { numero1 = value; }
        }
        public string Numero2
        {
            get { return numero2; }
            set { numero2 = value; }
        }

        void ConverterParaDouble()
        {            
            double.TryParse(numero1, out numero1Covertido);
            double.TryParse(numero2, out numero2Covertido);
        }

        public string Somar()
        {
            ConverterParaDouble();
            double resultado = numero1Covertido + numero2Covertido;               
            return resultado.ToString();           
        }
        public string Subtrair()
        {
            ConverterParaDouble();
            double resultado = numero1Covertido - numero2Covertido;
            return resultado.ToString();
        }
        
        public string Multiplicar()
        {
            ConverterParaDouble();
            double resultado = 0;            
            if (numero1Covertido != 0 && numero2Covertido != 0)
            {
                resultado = numero1Covertido * numero2Covertido;
            }
            else
            {
                resultado = numero1Covertido;
            }                        
            return resultado.ToString();
        }

        public string Dividir()
        {
            ConverterParaDouble();
            double resultado = 0;
            if (numero1Covertido != 0 && numero2Covertido != 0)
            {
                resultado = numero1Covertido / numero2Covertido;
            }
            else
            {
                resultado = numero1Covertido;
            }
            return resultado.ToString();
        }
    }
}
