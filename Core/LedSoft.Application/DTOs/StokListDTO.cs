using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
   public class StokListDTO
    {
        public long Id { get; set; }
        public string? StokKod { get; set; }
        public string? Isim { get; set; }
        public string? Kisaisim { get; set; }

        public long? Birimid { get; set; }
        public string? Birim { get; set; }
        public int? Kategori1id { get; set; }
        public string? Kategori { get; set; }
        public decimal? AlisFiyat { get; set; }
        public decimal? SatisFiyat { get; set; }

    }
}
