using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemSigortum
{
    public long Id { get; set; }

    public long? Aracid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? SonrakiTarih { get; set; }

    public string? Sigortafirma { get; set; }

    public string? SigortaYetkili { get; set; }

    public string? SigortaYetkiliTel { get; set; }

    public decimal? Tutar { get; set; }

    public string? Tip { get; set; }

    public string? Evrakno { get; set; }

    public long? Chid { get; set; }

    public string? AcilTel { get; set; }

    public string? Aciklama { get; set; }

    public string? AcentaNo { get; set; }

    public string? Carikart { get; set; }

    public string? Sigortatip { get; set; }

    public long? Carihareketid { get; set; }
}
