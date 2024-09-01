using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class KategoriDTO
    {
        public long Id { get; set; }

        public string? Tip { get; set; }

        public string? Kod { get; set; }

        public string? Isim { get; set; }
    }
}
