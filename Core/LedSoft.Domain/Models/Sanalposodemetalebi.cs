using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Sanalposodemetalebi
{
    public long Id { get; set; }

    public Guid? Udid { get; set; }

    public long? Faturaid { get; set; }

    public long? Chid { get; set; }

    public long? Sevkadresid { get; set; }

    public long? Posid { get; set; }

    public long? Posanlasmaid { get; set; }

    public long? Temsilciid { get; set; }

    public long? Subeid { get; set; }

    public string? Aciklama { get; set; }

    public string? Musteriaciklama { get; set; }

    public string? Tutarcalismasekli { get; set; }

    public decimal? Tutar { get; set; }

    public DateTime? Linkgecerlilikzaman { get; set; }

    public DateTime? Talepzaman { get; set; }

    public DateTime? Odemezaman { get; set; }

    public bool? Odemeyapildi { get; set; }

    public long? Tahsilatid { get; set; }

    public string? Provizyonkod { get; set; }

    public bool? Smsgonder { get; set; }

    public bool? Smsgonderildi { get; set; }

    public DateTime? GonderimzamanSms { get; set; }

    public bool? Emailgonder { get; set; }

    public bool? Emailgonderildi { get; set; }

    public DateTime? GonderimzamanEmail { get; set; }

    public int? Goruntulemesayisi { get; set; }

    public DateTime? Songoruntulemezaman { get; set; }
}
