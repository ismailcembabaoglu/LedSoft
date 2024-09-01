using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class CarihareketFi
{
    public long Id { get; set; }

    public long? Chid { get; set; }

    public string? Tip { get; set; }

    public DateTime? Tarih { get; set; }

    public DateTime? Saat { get; set; }

    public string? Evrakseri { get; set; }

    public string? Evraksira { get; set; }

    public string? Evrakno { get; set; }

    public long? Subeid { get; set; }

    public long? Projeid { get; set; }

    public string? Hareketozelkod { get; set; }

    public string? Dovizcinsi { get; set; }

    public decimal? Dovizkur { get; set; }

    public long? Bankahesapid { get; set; }

    public long? Poskomisyonhesapid { get; set; }

    public long? Nakitkasaid { get; set; }

    public long? Posid { get; set; }

    public long? Bankakrediid { get; set; }

    public long? Bktaksitid { get; set; }

    public decimal? Tutar { get; set; }

    public string? Aciklama { get; set; }

    public long? Temsilciid { get; set; }

    public long? Sevkadresid { get; set; }

    public long? Kredikartiid { get; set; }

    public string? Posanlasmaid { get; set; }

    public decimal? Poskomisyon { get; set; }
}
