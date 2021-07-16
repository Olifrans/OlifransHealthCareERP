using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlifransHealthCareERP.CoreShared.ModelViews
{
    public class ClienteNovo  // Vai comter os dados do clinte enviado pela pessoa que faz uso da API
    {
        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public char Sexo { get; set; }

        public string Telefone { get; set; }

        public string Documento { get; set; }
    }
}
