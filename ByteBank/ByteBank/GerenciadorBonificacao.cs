using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _TotalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            _TotalBonificacao += funcionario.GetBonificacao();
        }

        public double GetTotalBonificacao()
        {
            return _TotalBonificacao;
        }
    }
}
