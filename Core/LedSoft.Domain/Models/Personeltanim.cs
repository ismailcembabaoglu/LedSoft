using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Personeltanim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Kullaniciadi { get; set; }

    public string? Parola { get; set; }

    public string? Kartid { get; set; }

    public string? Gsm { get; set; }

    public byte[]? Foto { get; set; }

    public long? Subeid { get; set; }

    public bool? Aktif { get; set; }

    public bool? YetkiFiyatdegistirme { get; set; }

    public bool? YetkiMiktardegistirme { get; set; }

    public bool? YetkiSatirsilme { get; set; }

    public long? LedentegrasyonUserid { get; set; }

    public bool? YetkiFatura { get; set; }

    public bool? YetkiFaturacariiskonto { get; set; }

    public bool? YetkiFaturafiyatdegistirme { get; set; }

    public bool? YetkiCaritahsilat { get; set; }

    public bool? YetkiGiderodeme { get; set; }

    public string? YetkiOncekifisler { get; set; }

    public bool? YetkiRaporStok { get; set; }

    public bool? YetkiRaporHareket { get; set; }

    public long? LedentegrasyonChid { get; set; }

    public string? Subeyetki { get; set; }

    public bool? YetkiIrsaliye { get; set; }

    public bool? YetkiBarkodsatirsilme { get; set; }

    public bool? YetkiYkZrapor { get; set; }

    public bool? YetkiYkXrapor { get; set; }

    public bool? YetkiYkSatis { get; set; }
}
