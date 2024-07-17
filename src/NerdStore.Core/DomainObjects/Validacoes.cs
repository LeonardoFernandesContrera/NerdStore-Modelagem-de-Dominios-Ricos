using System.Diagnostics.Contracts;
using System.Text.RegularExpressions;

namespace NerdStore.Core.DomainObjects
{
    //Preocupacao de assercao
    public class Validacoes //Validacoes
    {
        public static void ValidarSerIgual(object object1, object object2, string mensagem)
        {
            if (object1.Equals(object2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSerDiferente(object object1, object object2, string mensagem)
        {
            if (!object1.Equals(object2))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSerDiferente(string pattern, string valor, string mensagem)
        {
            if (!pattern.Equals(valor))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarCaracteres(string valor, int maximo, string mensagem)
        {
            int length = valor.Trim().Length;
            if (length > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarCaracteres(string valor, int minimo, int maximo, string mensagem)
        {
            int length = valor.Trim().Length;
            if (length < minimo || length > maximo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarExpressao(string pattern, string valor, string mensagem)
        {
            var regex = new Regex(pattern);

            if (!regex.IsMatch(valor))
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeVazio(string valor, string mensagem)
        {
            if (valor == null || valor.Trim().Length == 0)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeNulo(object object1, string message)
        {
            if (object1 == null)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(double value, double minimum, double maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(float value, float minimum, float maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(int value, int minimum, int maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarMinimoMaximo(long value, long minimum, long maximum, string message)
        {
            if (value < minimum || value > maximum)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSerMenorQue(long valor, long minimo, string mensagem)
        {
            if(valor < minimo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSerMenorQue(int valor, int minimo, string mensagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSerMenorQue(decimal valor, decimal minimo, string mensagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSerMenorQue(float valor, float minimo, string mensagem)
        {
            if (valor < minimo)
            {
                throw new DomainException(mensagem);
            }
        }

        public static void ValidarSeVerdadeiro(bool boolValue, string message)
        {
            if (boolValue)
            {
                throw new DomainException(message);
            }
        }

        public static void ValidarSeFalso(bool boolValue, string message)
        {
            if (!boolValue)
            {
                throw new DomainException(message);
            }
        }

    }
}
