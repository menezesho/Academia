using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace academia.Class
{
    public class Verificacao
    {
        public static bool verificarCpf(string cpf)
        {
            var regExp = new Regex(@"^\d{11}"); //@"^\d{3}.\d{3}.\d{3}-\d{2}"
            return regExp.IsMatch(cpf);
        }

        public static bool verificarCelular(string celular)
        {
            var regExp = new Regex(@"^\d{11}");
            return regExp.IsMatch(celular);
        }

        public bool verificarEmail(string email)
        {
            bool validacao = email.Contains("@") && email.Contains(".com");
            if (validacao)
                return true;
            else
                return false;
        }

        /*public static bool verificarData(string data)
        {
            var regExp = new Regex(@"^\d{2}.\d{2}.\d{4}");
            return regExp.IsMatch(data);
        }*/
    }
}
