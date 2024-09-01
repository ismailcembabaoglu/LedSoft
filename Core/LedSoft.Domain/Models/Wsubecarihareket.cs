using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wsubecarihareket
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadetarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public long? Chid { get; set; }

    public long? Depoid { get; set; }

    public long? Depoid2 { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public int Sira { get; set; }

    public long? Temsilciid { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }

    public int Subeid { get; set; }

    public long? Projeid { get; set; }

    public int? Ozelkod { get; set; }

    public long? PerSubeid { get; set; }

    public long? PerKasaid { get; set; }

    public long? PerPersonelid { get; set; }
}
