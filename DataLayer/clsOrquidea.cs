using System;
using System.Linq;
using System.Text;

namespace DataLayer {
    public partial class Orquidea {
        public override string ToString() {
            var s = new StringBuilder();
            s.Append($"{Genero.GeneroAbrev}");
            if (!string.IsNullOrEmpty(Especie)) {
                s.Append($" { Especie}");
            }

            if (!string.IsNullOrEmpty(CorPrincipal)) {
                s.Append($" {CorPrincipal}");
            }

            if (!string.IsNullOrEmpty(CorSecundaria)) {
                s.Append($"/{CorSecundaria}");
            }
            //if (Numero != 1) s.Append($" {Numero}");
            if (Sequencial != null) {
                s.Append($" ({Matriz}.{Sequencial})");
            }

            return s.ToString().Trim();
        }

        public Orquidea Muda() {
            var muda = new Orquidea {
                GeneroID = this.GeneroID,
                Especie = this.Especie,
                CorPrincipal = this.CorPrincipal,
                CorSecundaria = this.CorSecundaria,
                Observacoes = this.Observacoes,
                Data = DateTime.Today,
                Origem = "casa",
                Matriz = this.OrquideaID,
                Sequencial = this.UltimoSequencial + 1
            };
            return muda;
        }

        public string Descricao => ToString();

        public string GeneroNome => Genero.Nome;

        public string GeneroAbrev => Genero.GeneroAbrev;

        public int UltimoSequencial => Mudas.Any() ? (int)Mudas.Max(m => m.Sequencial) : 0;

        public string Foto(string path) => $"{path}{OrquideaID:0000}.jpg";
    }

    public partial class Genero {
        public override string ToString() {
            return Nome;
        }
    }
}
