using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokempo.Core.Model
{
    public class Jogador(string nome)
    {
        public string Nome { get; set; } = nome;
    }
}
