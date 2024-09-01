using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Arac
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Imei { get; set; }

    public string? Gsm { get; set; }

    public bool? Sicakliksensoruvar { get; set; }

    public string? Marka { get; set; }

    public string? Model { get; set; }

    public int? Modelyili { get; set; }

    public bool? Sicakliksensoru2var { get; set; }

    public bool? Kapisensoruvar { get; set; }

    public bool? Kapisensoru2var { get; set; }

    public bool? Yakitsensoruvar { get; set; }

    public string? Ozelkod1 { get; set; }

    public byte[]? Gorsel { get; set; }

    public bool? Aktif { get; set; }

    public string? Surucuadsoyad { get; set; }

    public string? Surucutelno { get; set; }

    public long? Surucuid { get; set; }

    public decimal? Maxyakit { get; set; }

    public decimal? Ortyakit { get; set; }

    public decimal? Minyakit { get; set; }

    public string? Aciklama { get; set; }

    public string? HgsOgs { get; set; }

    public bool? Motorblokaj { get; set; }

    public bool? Motorblokajbeklemede { get; set; }

    public DateTime? BdKt1 { get; set; }

    public DateTime? BdKt2 { get; set; }

    public int? BdHl { get; set; }

    public DateTime? BdHt1 { get; set; }

    public DateTime? BdHt2 { get; set; }

    public int? BdSx { get; set; }

    public int? BdSn { get; set; }

    public DateTime? BdSt1 { get; set; }

    public DateTime? BdSt2 { get; set; }

    public bool? BdKtv { get; set; }

    public bool? BdHtv { get; set; }

    public bool? BdStv { get; set; }

    public bool? BdKhv { get; set; }

    public DateTime? BdKht1 { get; set; }

    public DateTime? BdKht2 { get; set; }

    public bool? BdTv { get; set; }

    public DateTime? BdTt1 { get; set; }

    public DateTime? BdTt2 { get; set; }

    public long? EntegrasyonChid { get; set; }

    public long? EntegrasyonTrafikcezagiderid { get; set; }

    public long? EntegrasyonTamirgiderid { get; set; }

    public long? EntegrasyonPeriyodikbakimgiderid { get; set; }

    public long? EntegrasyonMuayenegiderid { get; set; }

    public long? EntegrasyonKaskogiderid { get; set; }

    public long? EntegrasyonSigortagiderid { get; set; }

    public long? EntegrasyonTrafiksigortagiderid { get; set; }

    public long? EntegrasyonYesilkartsigortagiderid { get; set; }

    public long? EntegrasyonFerdikoltuksigortagiderid { get; set; }

    public long? EntegrasyonIhtiyarimalisigortagiderid { get; set; }

    public long? EntegrasyonYakitgiderid { get; set; }

    public long? NotfChecksum { get; set; }

    public string? Donanimsifre { get; set; }

    public string? Plaka { get; set; }

    public DateTime? Ilktesciltarih { get; set; }

    public DateTime? Tesciltarih { get; set; }

    public string? Tescilsirano { get; set; }

    public string? Modelyil { get; set; }

    public string? Aracsinif { get; set; }

    public string? Renk { get; set; }

    public string? Motorno { get; set; }

    public string? Saseno { get; set; }

    public string? Yakitcinsi { get; set; }

    public string? Kullanimamaci { get; set; }

    public string? Noter { get; set; }
}
