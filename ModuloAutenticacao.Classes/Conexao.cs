/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
*/
using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    internal class Conexao
    {
        public static SqlConnection _conn;
        public static SqlConnection MinhaInstancia
        {// A chave da propiedade
            get
            {
                //se não existe conexão.
                if (_conn == null)
                {// chave do if
                    //criar a conexão com SQLserver   //nos parênteses -connection string
                    _conn = new SqlConnection(@"Server = localhost; Database = projetoestoquev; Uid = sa; Pwd = teste*123;");
                }
                //retorna a conexão
                return _conn;
            }
        }
    }
}


                                                                                                                                                                                                                                                        
