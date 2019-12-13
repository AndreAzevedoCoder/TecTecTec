using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;

namespace TecTecTec.Models
{
    public class Imagem
    {
        public static int _inc;
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public string Tipo { get; set; }
        public int Tamanho { get; set; }

        public Imagem() {
            Id = Interlocked.Increment(ref _inc);
        }
    }
}




