using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class FaturaDetay
{
    public long Id { get; set; }

    public long? Faturaid { get; set; }

    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public long? Birimid { get; set; }

    public decimal? Carpan { get; set; }

    public decimal? Fiyat { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public decimal? Iskonto3 { get; set; }

    public decimal? Iskonto4 { get; set; }

    public decimal? Kdv { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public string? Ambalajbirim { get; set; }

    public long? Varyasyonid { get; set; }

    public string? Partino { get; set; }

    public string? Serino { get; set; }

    public string? Stokdovizcinsi { get; set; }

    public decimal? Stokdovizkur { get; set; }

    public DateTime? Stokvadetarih { get; set; }

    public decimal? Otv { get; set; }

    /// <summary>
    /// Özel İletişim Vergisi
    /// </summary>
    public decimal? Oiv { get; set; }

    public int? Ambalajbirimid { get; set; }

    public long? Temsilciid { get; set; }

    public int? Fiyatfarkifaturadetayid { get; set; }

    public string? Serinolar { get; set; }

    public DateTime? Sevktarih { get; set; }

    public long? Depoid { get; set; }

    public decimal? Eiskonto1 { get; set; }

    public decimal? Eiskonto2 { get; set; }

    public decimal? Eiskonto3 { get; set; }

    public decimal? Eiskonto4 { get; set; }

    public decimal? Eiskonto5 { get; set; }

    public decimal? Eiskonto6 { get; set; }

    public decimal? Eiskonto7 { get; set; }

    public decimal? Tevkifat { get; set; }

    public decimal? Birimekmaliyet { get; set; }

    public long? Iadesebepid { get; set; }

    public string? IhracatKapno { get; set; }

    public string? IhracatKapcinsi { get; set; }

    public decimal? IhracatKapadet { get; set; }

    public string? Kdvmuafiyetkod { get; set; }

    public DateTime? Skt { get; set; }

    public decimal? Planlanansatisfiyat { get; set; }

    public decimal? Birimmaliyet { get; set; }

    public string? Tevkifatkod { get; set; }

    public decimal? Konaklama { get; set; }
}
