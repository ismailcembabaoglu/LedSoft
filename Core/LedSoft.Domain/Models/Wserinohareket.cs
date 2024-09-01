using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wserinohareket
{
    public long? Faturaid { get; set; }

    public long? Faturadetayid { get; set; }

    public long? Depoharid { get; set; }

    public long? Depodetayid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public string? Tip { get; set; }

    public long? Chid { get; set; }

    public long? Depoid { get; set; }

    public long? Stokid { get; set; }

    public string? Serino { get; set; }

    public int? Miktar { get; set; }
}
