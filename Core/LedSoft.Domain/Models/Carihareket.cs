using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Carihareket
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    /// <summary>
    /// chtanim.ID
    /// </summary>
    public long? Chid { get; set; }

    /// <summary>
    /// chtanim.ID
    /// </summary>
    public long? Chid2 { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? Vadetarih { get; set; }

    public string? Tip { get; set; }

    public string? Aciklama { get; set; }

    public long? Cekid { get; set; }

    public long? Senetid { get; set; }

    public long? Temsilciid { get; set; }

    public string? Dovizcinsi { get; set; }

    public double? Dovizkur { get; set; }

    public long? Bordroid { get; set; }

    public int? Projeid { get; set; }

    public string? Hareketozelkod { get; set; }

    public long? Faturaid { get; set; }

    public int? Ziyaretid { get; set; }

    public string? Posonayno { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public int? Subeid { get; set; }

    public int? Carihareketfisid { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public long? Posanlasmaid { get; set; }

    public decimal? Poskomisyon { get; set; }

    public long? Posslipid { get; set; }

    public int? Kktaksitsayisi { get; set; }

    public long? PerSubeid { get; set; }

    public long? PerKasaid { get; set; }

    public long? PerPersonelid { get; set; }

    public long? Bktaksitid { get; set; }

    public long? Bankakrediid { get; set; }

    public Guid? Udid { get; set; }

    public long? Sevkadresid { get; set; }

    public long? Sevkadresid2 { get; set; }

    public bool? Smsgonderildi { get; set; }

    public byte[]? Gorsel { get; set; }

    public long? FiloAracislemid { get; set; }

    public string? FiloAracislemtip { get; set; }

    public string? Posodemekartnobilgi { get; set; }

    public virtual Ceksenetbordro? Bordro { get; set; }

    public virtual Cek? Cek { get; set; }

    public virtual Chtanim? Ch { get; set; }

    public virtual Chtanim? Chid2Navigation { get; set; }

    public virtual Senet? Senet { get; set; }
}
