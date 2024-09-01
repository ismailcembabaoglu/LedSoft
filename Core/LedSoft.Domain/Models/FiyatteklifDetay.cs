using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FiyatteklifDetay
{
    public long Id { get; set; }

    public long? Fiyatteklifid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public decimal? Iskonto3 { get; set; }

    public decimal? Iskonto4 { get; set; }

    public decimal? Iskontolufiyat { get; set; }

    public decimal? Kdvdahiliskontolufiyat { get; set; }

    public decimal? Onerilenfiyat { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Kdvyuzde { get; set; }

    public long? Ambalajbirimid { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public string? Aciklama { get; set; }
}
