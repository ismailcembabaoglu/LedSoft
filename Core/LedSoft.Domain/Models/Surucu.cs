using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Surucu
{
    public long Id { get; set; }

    public byte[]? Resim { get; set; }

    public string? Isim { get; set; }

    public string? Kod { get; set; }

    public string? Adres { get; set; }

    public string? BelgeNo { get; set; }

    public string? Kangrubu { get; set; }

    public string? Uyruk { get; set; }

    public DateTime? BelgeVerilisTarihi { get; set; }

    public DateTime? BelgeGecerlilikTarihi { get; set; }

    public string? SurucuSicilNo { get; set; }

    public string? SurucuTc { get; set; }

    public DateTime? DogumTarihi { get; set; }

    public string? SrcBelge { get; set; }

    public DateTime? SrcTarih { get; set; }

    public string? K1 { get; set; }

    public DateTime? K1Tarih { get; set; }

    public string? UluslararasiDolasimBelgesi { get; set; }

    public DateTime? UluslararasiDolasimBelgesiTarih { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? EMail { get; set; }

    public string? EvTel { get; set; }

    public string? DogumYeri { get; set; }

    public byte[]? EhliyetOn { get; set; }

    public byte[]? EhliyetArka { get; set; }

    public bool? Tip { get; set; }

    public long? Personelid { get; set; }

    public string? Kullaniciadi { get; set; }

    public string? Sifre { get; set; }
}
