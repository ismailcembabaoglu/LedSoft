using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Wmasrafdetay
{
    public long Carihareketid { get; set; }

    public long? Faturaid { get; set; }

    public long Giderfisid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public long? Gelirgiderid { get; set; }

    public long? Chid { get; set; }

    public long? Hizmetid { get; set; }

    public string? Evrakno { get; set; }

    public string? Belgeno { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public long? Temsilciid { get; set; }

    public long? Subeid { get; set; }

    public long? Projeid { get; set; }

    public string? Hareketozelkod { get; set; }

    public int? Kategori1id { get; set; }

    public int? Kategori2id { get; set; }

    public int? Kategori3id { get; set; }

    public long? Kategori4id { get; set; }

    public long? Kategori5id { get; set; }

    public decimal? Kdvyuzde { get; set; }

    public double? Borc { get; set; }

    public double? Alacak { get; set; }
}
