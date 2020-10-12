using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Paginas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Conteudo { get; set; }
        public DateTime? Data { get; set; }
    }
}
