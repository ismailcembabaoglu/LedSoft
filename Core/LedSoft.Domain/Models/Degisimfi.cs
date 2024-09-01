using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Degisimfi
{
    public long Id { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Tip { get; set; }

    public string? Evrakseri { get; set; }

    public long? Evraksira { get; set; }

    public long? Chid { get; set; }

    public long? Sevkadresid { get; set; }

    public long? Depoid { get; set; }

    public long? Subeid { get; set; }

    public long? Temsilciid { get; set; }

    public string? Aciklama { get; set; }

    public Guid? Udid { get; set; }

    public string? Evrakno { get; set; }
}
