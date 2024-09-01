using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class DepotransferDetay
{
    public long Id { get; set; }

    /// <summary>
    /// stoktanim.ID
    /// </summary>
    public long? Stokid { get; set; }

    public decimal? Miktar { get; set; }

    public int? Birimid { get; set; }

    public decimal? Fiyat { get; set; }

    public long? Depotransferid { get; set; }

    public string? Aciklama { get; set; }

    public decimal? Ambalajmiktar { get; set; }

    public string? Ambalajbirim { get; set; }

    public decimal? Miktar2 { get; set; }

    public string? Birim2 { get; set; }

    public decimal? Fiyat2 { get; set; }

    public decimal? Carpan { get; set; }

    public string? Partino { get; set; }

    public string? Serino { get; set; }

    public int? Varyasyonid { get; set; }

    public int? Ambalajbirimid { get; set; }

    public string? Serinolar { get; set; }

    public DateTime? Skt { get; set; }

    public virtual Depotransfer? Depotransfer { get; set; }

    public virtual Stoktanim? Stok { get; set; }
}
