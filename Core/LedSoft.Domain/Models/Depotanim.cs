using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Depotanim
{
    public long Id { get; set; }

    /// <summary>
    /// Depo Kodu
    /// </summary>
    public string? Kod { get; set; }

    /// <summary>
    /// Depo İsmi
    /// </summary>
    public string? Isim { get; set; }

    public string? Aciklama { get; set; }

    public string? Tel { get; set; }

    public string? Adres { get; set; }

    public string? Yetkili { get; set; }

    public string? Yetkilitel1 { get; set; }

    public string? Yetkilitel2 { get; set; }

    public int? Fiyatkriter { get; set; }

    public int? Fiyatlisteid { get; set; }

    public int? Depotip { get; set; }

    public string? Aciklama2 { get; set; }

    public bool? Aktif { get; set; }

    public long? Subeid { get; set; }

    public string? Entegrasyonkod { get; set; }

    public string? Ozelkod1 { get; set; }

    public string? Ozelkod2 { get; set; }

    public long? Kategori1id { get; set; }

    public long? Kategori2id { get; set; }

    public string? Ozelkod3 { get; set; }

    public string? Il { get; set; }

    public string? Ilce { get; set; }

    public string? Vergidaire { get; set; }

    public string? Vergino { get; set; }

    public string? Plasiyerad { get; set; }

    public string? Plasiyersoyad { get; set; }

    public string? Plasiyeraracplaka { get; set; }

    public string? Plasiyertckn { get; set; }

    public string? Depohareketonaytip { get; set; }

    public string? Postakodu { get; set; }

    public virtual ICollection<Depotransfer> DepotransferHedefdepos { get; set; } = new List<Depotransfer>();

    public virtual ICollection<Depotransfer> DepotransferKaynakdepos { get; set; } = new List<Depotransfer>();
}
