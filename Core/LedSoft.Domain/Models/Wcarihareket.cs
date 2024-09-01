using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wcarihareket
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadetarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public long? Chid { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public int Sira { get; set; }

    public long? Faturaid { get; set; }

    public long? Cekid { get; set; }

    public long? Senetid { get; set; }

    public long? Temsilciid { get; set; }

    public decimal? Borc { get; set; }

    public decimal? Alacak { get; set; }

    public string? Dovizcinsi { get; set; }

    public double? Dovizkur { get; set; }

    public double? Doviztutar { get; set; }

    public long? Bordroid { get; set; }

    public long? Sevkadresid { get; set; }

    public long? Subeid { get; set; }

    public int? Carihareketfisid { get; set; }

    public long? Projeid { get; set; }

    public string? Posonayno { get; set; }

    public long? Posanlasmaid { get; set; }

    public long? Posslipid { get; set; }

    public decimal? Poskomisyon { get; set; }

    public long? Ziyaretid { get; set; }

    public string? Ozelkod { get; set; }
}
