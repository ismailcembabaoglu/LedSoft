using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class ChtanimPersonel
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Tckn { get; set; }

    public byte[]? Fotograf { get; set; }

    public DateTime? Dogumtarihi { get; set; }

    public string? Dogumyeri { get; set; }

    public string? Anaadi { get; set; }

    public string? Babaadi { get; set; }

    public int? Medenihali { get; set; }

    public string? Kangrubu { get; set; }

    public decimal? Maas { get; set; }

    public int? Gorevid { get; set; }

    public int? Departmanid { get; set; }

    public int? Ailekisisayisi { get; set; }

    public int? Ailecocuksayisi { get; set; }

    public bool? Ailecocukvar { get; set; }

    public string? Sgkno { get; set; }

    public string? Sicilno { get; set; }

    public bool? Istenciktimi { get; set; }

    public DateTime? Isgiristarih { get; set; }

    public DateTime? Iscikistarih { get; set; }

    public DateTime? Evliliktarih { get; set; }

    public string? Beden { get; set; }

    public decimal? Boy { get; set; }

    public decimal? Kilo { get; set; }

    public string? Evdurum { get; set; }

    public string? Oncekiis { get; set; }

    public string? Askerlik { get; set; }

    public DateTime? Teciltarih { get; set; }

    public DateTime? Terhistarih { get; set; }

    public string? Askerlikaciklama { get; set; }

    public string? Aracmarkamodel { get; set; }

    public string? Instagram { get; set; }

    public string? Twitter { get; set; }

    public string? Facebook { get; set; }

    public string? Linkedin { get; set; }

    public bool? Sosyalmedyakullanimi { get; set; }

    public long? Depoid { get; set; }

    public string? Googleplus { get; set; }

    public string? Isbaslangicsaat { get; set; }

    public string? Isbitissaat { get; set; }

    public string? Eposta { get; set; }

    public string? Eposta2 { get; set; }

    public string? Tel1 { get; set; }

    public string? Tel2 { get; set; }

    public string? Tel3 { get; set; }

    public string? Adres { get; set; }

    public decimal? Agi { get; set; }

    public long? Maasgiderid { get; set; }

    public long? Agigiderid { get; set; }

    public string? Egitimdurum { get; set; }

    public string? Okul { get; set; }

    public string? Isayrilisneden { get; set; }

    public string? Referans { get; set; }

    public string? Entegrasyonkod { get; set; }

    public long? Kategori1id { get; set; }

    public long? Kategori2id { get; set; }

    public long? Kategori3id { get; set; }

    public string? Muhasebekod { get; set; }

    public long? LedmuhPersonelhesapid { get; set; }

    public string? Ebelgekullan { get; set; }
}
