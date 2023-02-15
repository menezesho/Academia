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
            var regExp = new Regex(@"[\w]+@+[a-zA-Z.]+[.]+[a-zA-Z.]{2,6}$");
            return regExp.IsMatch(email);
        }

        public bool verificarSenha(string senha)
        {
            string caracteresEspeciais = ".+-[]*~_@#:?";
            string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string numeros = "0123456789";

            bool validacao = false;
            for (int i = 0; i < caracteresEspeciais.Length; i++)
            {
                if (senha.Contains(caracteresEspeciais[i].ToString()) && senha.Length >= 8)
                {
                    for (int j = 0; j < alfabeto.Length; j++)
                    {
                        if (senha.Contains(alfabeto[j].ToString()))
                            for (int k = 0; k < numeros.Length; k++)
                            {
                                if (senha.Contains(numeros[k].ToString()))
                                    validacao = true;
                            }
                    }
                }  
            }
            return validacao;
        }

        /*public static bool verificarData(string data)
        {
            var regExp = new Regex(@"^\d{2}.\d{2}.\d{4}");
            return regExp.IsMatch(data);
        }*/

        /*public bool verificarEmail(string email)
        {
            bool validacao = email.Contains("@") && email.Contains(".com");
            if (validacao)
                return true;
            else
                return false;
        }*/
    }
}
