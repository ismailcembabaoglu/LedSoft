using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Fatura
{
    public long Id { get; set; }

    /// <summary>
    /// chtanim.ID
    /// </summary>
    public long? Chid { get; set; }

    /// <summary>
    /// depotanim.ID
    /// </summary>
    public long? Depoid { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakno { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Iskonto1 { get; set; }

    public decimal? Iskonto2 { get; set; }

    public string? Tip { get; set; }

    public DateTime? Vadetarih { get; set; }

    public long? Projeid { get; set; }

    public string? Ozelkod { get; set; }

    public long? Temsilciid { get; set; }

    public bool? Kdvdahil { get; set; }

    public string? Dovizcinsi { get; set; }

    public decimal? Dovizkur { get; set; }

    public string? Siparisno { get; set; }

    public DateTime? Siparistarih { get; set; }

    /// <summary>
    /// led.chtanim_chadres.ID
    /// </summary>
    public int? Sevkadresid { get; set; }

    public bool? Yazdirildi { get; set; }

    public decimal? Bagkur { get; set; }

    public decimal? Stopaj { get; set; }

    public decimal? Borsa { get; set; }

    public string? Irsaliyeno { get; set; }

    public DateTime? Irsaliyetarih { get; set; }

    public int? Ziyaretid { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public int? Subeid { get; set; }

    public bool? Kapalifatura { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public long? PerSubeid { get; set; }

    public long? PerKasaid { get; set; }

    public long? PerPersonelid { get; set; }

    public bool? Proformacarietki { get; set; }

    public string? Yuklemeirsaliyeno { get; set; }

    public bool? Iptal { get; set; }

    public Guid? Udid { get; set; }

    public bool? Birlesmisfatura { get; set; }

    public string? Detayaciklama { get; set; }

    public string? Odemetip { get; set; }

    public bool? Aktarildi { get; set; }

    public bool? Smsgonderildi { get; set; }

    public long? FiloAracid { get; set; }

    public decimal? FarkToplam { get; set; }

    public decimal? FarkMatrah { get; set; }

    public string? Ekmaliyettip { get; set; }

    public string? Odemeaciklama { get; set; }

    public long? Odemebankahesapid { get; set; }

    public string? Earsivno { get; set; }

    public string? Iptalaciklama { get; set; }

    public string? Eirsaliyeno { get; set; }

    public string? Eirsaliyetip { get; set; }

    public string? Efaturano { get; set; }

    public long? Lojistikprojeid { get; set; }

    public bool? Lojistikstokhareketetki { get; set; }

    public bool? Fiyatliyazdirildi { get; set; }

    public long? Lojistikfaturaid { get; set; }

    public bool? HariciBilgikullan { get; set; }

    public string? HariciUnvan { get; set; }

    public string? HariciAdres { get; set; }

    public string? HariciVergino { get; set; }

    public string? HariciVergidaire { get; set; }

    public string? HariciIl { get; set; }

    public string? HariciIlce { get; set; }

    public string? HariciEarsiveposta { get; set; }

    public string? HariciPostakodu { get; set; }

    public string? HariciTel { get; set; }

    public string? HariciTckn { get; set; }

    public string? HariciAd { get; set; }

    public string? HariciSoyad { get; set; }

    public decimal? FarkKdv { get; set; }

    public long? Odemechid { get; set; }
}
