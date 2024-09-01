using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class IslemYolcutasimaizin
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Belgeno { get; set; }

    public long? Aracid { get; set; }

    public long? Tasinanacentaid { get; set; }

    public DateTime? Gecerliliktarih { get; set; }
}
