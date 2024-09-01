using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Depotransfer
{
    public long Id { get; set; }

    /// <summary>
    /// depotanim.ID
    /// </summary>
    public long? Kaynakdepoid { get; set; }

    /// <summary>
    /// depotanim.ID
    /// </summary>
    public long? Hedefdepoid { get; set; }

    public DateTime? Tarih { get; set; }

    public string? Evrakno { get; set; }

    public string? Aciklama { get; set; }

    public string? Tip { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakseri { get; set; }

    public string? Evraksira { get; set; }

    public bool? Onaylandi { get; set; }

    public long? Deposiparisid { get; set; }

    public int? Subeid { get; set; }

    public int? Temsilciid { get; set; }

    public long? Gpsenlem { get; set; }

    public long? Gpsboylam { get; set; }

    public bool? Yazdirildi { get; set; }

    public Guid? Udid { get; set; }

    public DateTime? Teslimtarih { get; set; }

    public DateTime? Teslimsaat { get; set; }

    public bool? Teslimtarihvar { get; set; }

    public long? FiloAracid { get; set; }

    public string? Eirsaliyeno { get; set; }

    public string? Eirsaliyetip { get; set; }

    public bool? Eirsaliyedegil { get; set; }

    public virtual ICollection<DepotransferDetay> DepotransferDetays { get; set; } = new List<DepotransferDetay>();

    public virtual Depotanim? Hedefdepo { get; set; }

    public virtual Depotanim? Kaynakdepo { get; set; }
}
