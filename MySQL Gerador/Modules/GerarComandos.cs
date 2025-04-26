using System;

namespace MySQL_Gerador.Modules
{
    public static class GerarComandos
    {
        public static string _campo = string.Empty;
        public static string _tipoMySql = string.Empty;
        public static string _tipoPropriedade = string.Empty;
        public static string _parametros = string.Empty;
        public static string _propriedades = string.Empty;
        public static string _insertCampos = string.Empty;
        public static string _insertValues = string.Empty;
        public static string _update = string.Empty;

        public static string[] Gerar(string campos)
        {
            LimparCampos();

            var branco = 0;

            for (int i = 0; i < campos.Length; i++)
            {
                if ((campos.Substring(i, 1) != ";") &&
                    (campos.Substring(i, 1) != "\n"))
                {
                    if (campos.Substring(i, 1) == " ")
                    {
                        branco++;
                    }
                    else if (branco == 0)
                    {
                        _campo += campos.Substring(i, 1);
                    }
                    else
                    {
                        _tipoPropriedade += campos.Substring(i, 1);
                    }
                }
                else if (campos.Substring(i, 1) == ";")
                {
                    AtribuirTipo(_tipoPropriedade);
                    Parametros();
                    Comandos();
                    Propriedades();
                    _campo = string.Empty;
                    _tipoMySql = string.Empty;
                    _tipoPropriedade = string.Empty;
                    branco = 0;
                }
            }
            Finalizar_Comandos();

            string[] resultado =
            {
                _propriedades,
                _parametros,
                _insertCampos,
                _insertValues,
                _update
            };

            return resultado;
        }

        private static void AtribuirTipo(string tipo)
        {
            switch (tipo)
            {
                case "varchar":
                    _tipoPropriedade = "string";
                    break;
                case "decimal":
                    _tipoPropriedade = "decimal";
                    break;
                case "int":
                    _tipoPropriedade = "int";
                    break;
                case "datetime":
                    _tipoPropriedade = "DateTime";
                    break;
                case "double":
                    _tipoPropriedade = "double";
                    break;
                case "longblob":
                    _tipoPropriedade = "Image";
                    break;
                case "mediumblob":
                    _tipoPropriedade = "Image";
                    break;
            }
        }

        private static void Parametros()
        {
            string cp1 = "\"@" + _campo + "\"";
            string cp2 = Convert.ToString(char.ToUpper(_campo[0]) + _campo.Substring(1));
            string prm = "cl_Conexao.dbcom.Parameters.AddWithValue(" + cp1 + ", " + cp2 + ");";

            _parametros += prm + "\n";
        }

        private static void Comandos()
        {
            if ((_insertCampos == string.Empty) &&
                (_insertValues == string.Empty) &&
                (_update == string.Empty))
            {
                _insertCampos += _campo;
                _insertValues += "@" + _campo;
                _update += _campo + "=@" + _campo;
            }
            else
            {
                _insertCampos += "," + _campo;
                _insertValues += ",@" + _campo;
                _update += "," + _campo + "=@" + _campo;
            }
        }

        private static void Finalizar_Comandos()
        {
            _insertCampos = "(" + _insertCampos + ")";
            _insertValues = "VALUES(" + _insertValues + ")";
        }

        private static void Propriedades()
        {
            string cp = Convert.ToString(char.ToUpper(_campo[0]) + _campo.Substring(1));

            _propriedades += "public " + _tipoMySql + " " + cp + " { get; set; }\n";
        }

        private static void LimparCampos()
        {
            _campo = string.Empty;
            _tipoMySql = string.Empty;
            _tipoPropriedade = string.Empty;
            _parametros = string.Empty;
            _propriedades = string.Empty;
            _insertCampos = string.Empty;
            _insertValues = string.Empty;
            _update = string.Empty;
        }
    }
}
