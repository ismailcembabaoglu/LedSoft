using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class SubetanimKasa
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public string? Terazitip { get; set; }

    public string? Terazicomport { get; set; }

    public string? Bilgiekrancomport { get; set; }

    public bool? Tahsilatkullan { get; set; }

    public bool? Gunsonukullan { get; set; }

    public bool? Dogrudanalimkullan { get; set; }

    public long? Subeid { get; set; }

    public bool? Aktif { get; set; }

    public long? Subesablonid { get; set; }

    public string? Satiskullanimtip { get; set; }

    public bool? Faturakullan { get; set; }

    public long? Carikategori1id { get; set; }

    public long? Carikategori2id { get; set; }

    public long? Carikategori3id { get; set; }

    public long? Carikategori4id { get; set; }

    public long? Carikategori5id { get; set; }

    public string? Bagliyazarkasa { get; set; }

    public string? Hariciterazitip { get; set; }

    public long? Temsilciid { get; set; }

    public long? Carigrupid { get; set; }

    public string? Baglicekmeceport { get; set; }

    public string? Baglicekmece { get; set; }

    public string? Fisbekletkullan { get; set; }

    public bool? Irsaliyekullan { get; set; }

    public string? Teraziserbestmiktar { get; set; }

    public bool? Personelfaturakullan { get; set; }

    public string? Sabitfisyazici { get; set; }

    public string? Sabitfaturayazici { get; set; }

    public bool? Yazarkasagiderpusulasikullan { get; set; }

    public bool? Yazarkasafaturakullan { get; set; }

    public bool? Masahesapkullan { get; set; }
}
