using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SiparisDetay
{
    public long Id { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public decimal? Fiyat { get; set; }

    public long? Siparisid { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public decimal? Iskonto3 { get; set; }

    public decimal? Iskonto4 { get; set; }

    public decimal? Kdv { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public string? Ambalajbirim { get; set; }

    public decimal? Faturafiyat { get; set; }

    public string? Stokdovizcinsi { get; set; }

    public decimal? Stokdovizkur { get; set; }

    public long? Varyasyonid { get; set; }

    public int? Birimid { get; set; }

    public string? Partino { get; set; }

    public string? Serino { get; set; }

    public decimal? Carpan { get; set; }

    public DateTime? Stokvadetarih { get; set; }

    public decimal? Otv { get; set; }

    public int? Ambalajbirimid { get; set; }

    public decimal? Eiskonto1 { get; set; }

    public decimal? Eiskonto2 { get; set; }

    public decimal? Eiskonto3 { get; set; }

    public decimal? Eiskonto4 { get; set; }

    public decimal? Eiskonto5 { get; set; }

    public decimal? Eiskonto6 { get; set; }

    public decimal? Eiskonto7 { get; set; }
}
