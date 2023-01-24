using System;
using System.Collections.Generic;
using System.Text;

namespace academia.Class
{
    public class Conexao
    {
        public string ConexaoBD()
        {
            string strConexao = @"Data Source=HENRY;Initial Catalog=BD_ACADEMIA;Integrated Security=True";
            return strConexao;
        }
    }
}
