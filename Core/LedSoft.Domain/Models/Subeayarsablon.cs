using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class Subeayarsablon
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public long? FrxFiscikti { get; set; }

    public long? FrxSipariscikti { get; set; }

    public long? FrxCekmececikti { get; set; }

    public long? FrxOturumsonucikti { get; set; }

    public long? FrxMalkabulcikti { get; set; }

    public long? DllPerakendemodul { get; set; }

    public long? GorselLogo { get; set; }

    public long? GorselMusteriekran { get; set; }

    public long? FrxBeklemefiscikti { get; set; }

    public long? FrxVeresiyetahsilatfiscikti { get; set; }

    public long? FrxVeresiyeekstrecikti { get; set; }

    public long? FrxFaturacikti { get; set; }

    public long? FrxTahsilatcikti { get; set; }

    public string? MusteriekranVideolink { get; set; }

    public bool? MusteriekranVideolinkAyri { get; set; }

    public bool? FaturaciktiText { get; set; }

    public bool? TahsilatciktiText { get; set; }

    public bool? MusteriekranKullan { get; set; }

    public long? FrxFaturaciktiEfatura { get; set; }

    public long? FrxFaturaciktiEarsivfatura { get; set; }
}
