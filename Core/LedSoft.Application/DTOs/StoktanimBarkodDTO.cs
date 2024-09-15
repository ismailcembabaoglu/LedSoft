using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedSoft.Application.DTOs
{
    public class StoktanimBarkodDTO
    {
        public long Id { get; set; }

        public long? Stokid { get; set; }

        public string? Barkod { get; set; }

        public long? Birimid { get; set; }

        public long? Sablonid { get; set; }

        public decimal? Carpan { get; set; }

        public int? Ambalajbirimid { get; set; }

        public decimal? Ambalajmiktar { get; set; }

        public bool? Esikdegerkullan { get; set; }

        public long? Varyasyonid { get; set; }
        public string? BirimName { get; set; }
    }
}
