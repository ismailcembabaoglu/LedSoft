using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimBankakredi
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public int? Taksitsayisi { get; set; }

    public decimal? Faizoran { get; set; }

    public decimal? Kreditutar { get; set; }

    public long? Bankahesapid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Kreditip { get; set; }

    public decimal? Kkdf { get; set; }

    public decimal? Bsmv { get; set; }

    public decimal? Dosyamasraf { get; set; }

    public long? Masrafgiderid { get; set; }

    public long? Kkdfgiderid { get; set; }

    public long? Bsmvgiderid { get; set; }

    public long? Faizgiderid { get; set; }

    public int? Taksittarih { get; set; }

    public string? Teminattip { get; set; }

    public string? Entegrasyonkod { get; set; }

    public string? Muhasebekodu { get; set; }

    public long? LedmuhHesapid { get; set; }

    public bool? Kapama { get; set; }

    public long? Kapamafisid { get; set; }

    public decimal? Dovizkur { get; set; }
}
