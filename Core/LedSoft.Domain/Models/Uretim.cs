using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Uretim
{
    public long Id { get; set; }

    public string? Tip { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public long? Depoid { get; set; }

    public string? Aciklama { get; set; }

    public long? Receteid { get; set; }

    public long? Stokid { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public string? Maliyettip { get; set; }

    public long? Maliyetfiyatlisteid { get; set; }

    public DateTime? Maliyetilktarih { get; set; }

    public DateTime? Maliyetsontarih { get; set; }

    public string? Durum { get; set; }

    public long? Subeid { get; set; }

    public long? Sipariskalemid { get; set; }

    public decimal? Birimmaliyet { get; set; }

    public long? Temsilciid { get; set; }

    public string? Uretimtip { get; set; }

    public long? Usturetimid { get; set; }

    public long? Projeid { get; set; }
}
