using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer {
    public partial class Orquidea {
        public override string ToString() {
            var s = new StringBuilder();
            s.Append($"{Genero.GeneroAbrev} {Especie}");
            if (CorPrincipal != null) s.Append($" {CorPrincipal}");
            if (!string.IsNullOrEmpty(CorSecundaria)) s.Append($"/{CorSecundaria}");
            //if (Numero != 1) s.Append($" {Numero}");
            if (Sequencial != null) s.Append($" ({Matriz}.{Sequencial})");
            return s.ToString().Trim();
        }

        public string Descricao => ToString();

        public string GeneroNome => Genero.Nome;

        public int UltimoSequencial => Mudas.Any() ? (int)Mudas.Max(m => m.Sequencial) : 0;
    }

    public partial class Genero {
        public override string ToString() {
            return Nome;
        }
    }
}
