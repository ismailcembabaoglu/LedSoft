using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Cek
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public long? Portfoyid { get; set; }

    /// <summary>
    /// Çek Tipi M1 Müşteri Çeki K1: Firma Çeki
    /// </summary>
    public string? Tip { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Vadetarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Cekno { get; set; }

    public string? Evrakno { get; set; }

    public string? Hesapno { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Tutar { get; set; }

    public bool? Cirolu { get; set; }

    public string? Kaside { get; set; }

    public string? Banka { get; set; }

    public string? Sube { get; set; }

    public int? Projeid { get; set; }

    public string? Hareketozelkod { get; set; }

    public long? Faturaid { get; set; }

    public int? Bordroid { get; set; }

    public string? Evrakseri { get; set; }

    public string? Evraksira { get; set; }

    public int? Subeid { get; set; }

    public int? Temsilciid { get; set; }

    public string? Cekdurum { get; set; }

    public int? Cekportfoyid { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public byte[]? GorselOnyuz { get; set; }

    public byte[]? GorselArkayuz { get; set; }

    public long? Ziyaretid { get; set; }

    public Guid? Udid { get; set; }

    public long? Sevkadresid { get; set; }

    public string? Dovizcinsi { get; set; }

    public decimal? Dovizkur { get; set; }

    public virtual ICollection<Carihareket> Cariharekets { get; set; } = new List<Carihareket>();

    public virtual Chtanim? Ch { get; set; }

    public virtual Chtanim? Portfoy { get; set; }
}
