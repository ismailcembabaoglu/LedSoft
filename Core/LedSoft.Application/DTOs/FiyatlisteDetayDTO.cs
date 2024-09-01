using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class FiyatlisteDetayDTO
    {
        public long Id { get; set; }

        public long? Fiyataltlisteid { get; set; }

        public long? Stokid { get; set; }

        public decimal? Fiyat { get; set; }

        public decimal? Iskonto1 { get; set; }

        public decimal? Iskonto2 { get; set; }

        public decimal? Iskonto3 { get; set; }

        public long? Birimid { get; set; }

        public DateTime? Duzenlemetarih { get; set; }

        public long? Fiyatlisteid { get; set; }

        public decimal? Oncekifiyat { get; set; }

        public decimal? Maxiskonto { get; set; }
    }
}
