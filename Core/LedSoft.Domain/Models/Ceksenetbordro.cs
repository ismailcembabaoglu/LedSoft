using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Ceksenetbordro
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Bordrono { get; set; }

    public string? Tip { get; set; }

    public DateTime? Saat { get; set; }

    public long? Chid { get; set; }

    public int? Subeid { get; set; }

    public long? Sevkadresid { get; set; }

    public string? Dovizcinsi { get; set; }

    public virtual ICollection<Carihareket> Cariharekets { get; set; } = new List<Carihareket>();

    public virtual Chtanim? Ch { get; set; }
}
