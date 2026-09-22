using System.Collections.Generic;

namespace csharp_wpf_calculator.Services
{
    public class CalculadoraService
    {
        public List<string> Numeros { get; private set; } = new List<string>();
        public List<string> Operadores { get; private set; } = new List<string>();
        public List<double> NumerosConvertidos { get; private set; } = new List<double>();
             

        public void ResolverExpressao(string expressao)
        {
            string numeroAtual = "";

            foreach (char c in expressao)
            {
                if (char.IsDigit(c))
                {
                    numeroAtual += c;
                }
                else
                {
                    Numeros.Add(numeroAtual);
                    numeroAtual = "";
                    Operadores.Add(c.ToString());
                }
            }

            if (!string.IsNullOrWhiteSpace(numeroAtual))
            {
                Numeros.Add(numeroAtual);
            }

            foreach (string numero in Numeros)
            {
                NumerosConvertidos.Add(double.Parse(numero));
            }

            int i = 0;
            while (i < Operadores.Count)
            {
                if (Operadores[i] == "*" || Operadores[i] == "/")
                {
                    double resultado;

                    if (Operadores[i] == "*")
                    {
                        resultado = NumerosConvertidos[i] * NumerosConvertidos[i + 1];
                    }
                    else
                    {
                        resultado = NumerosConvertidos[i] / NumerosConvertidos[i + 1];
                    }

                    NumerosConvertidos[i] = resultado;
                    NumerosConvertidos.RemoveAt(i + 1);
                    Operadores.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }

            i = 0;
            while (i < Operadores.Count)
            {
                double resultadoSoma;

                if (Operadores[i] == "+")
                {
                    resultadoSoma = NumerosConvertidos[i] + NumerosConvertidos[i + 1];
                }
                else
                {
                    resultadoSoma = NumerosConvertidos[i] - NumerosConvertidos[i + 1];
                }

                NumerosConvertidos[i] = resultadoSoma;
                NumerosConvertidos.RemoveAt(i + 1);
                Operadores.RemoveAt(i);
            }
        }      
    }
}