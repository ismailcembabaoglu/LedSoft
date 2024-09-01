using System;
using System.Collections.Generic;

namespace LedSoft.Persistence;

public partial class MobileFaturatasarim
{
    public long Id { get; set; }

    public string? Kod { get; set; }

    public string? Isim { get; set; }

    public bool? Aktif { get; set; }

    public bool? CarikodVar { get; set; }

    public int? CarikodX { get; set; }

    public int? CarikodY { get; set; }

    public int? CarikodW { get; set; }

    public string? CarikodTxt { get; set; }

    public bool? ChunvanVar { get; set; }

    public int? ChunvanX { get; set; }

    public int? ChunvanY { get; set; }

    public int? ChunvanW { get; set; }

    public string? ChunvanTxt { get; set; }

    public bool? AdresVar { get; set; }

    public int? AdresX { get; set; }

    public int? AdresY { get; set; }

    public int? AdresW { get; set; }

    public string? AdresTxt { get; set; }

    public bool? IlVar { get; set; }

    public int? IlX { get; set; }

    public int? IlY { get; set; }

    public int? IlW { get; set; }

    public string? IlTxt { get; set; }

    public bool? IlceVar { get; set; }

    public int? IlceX { get; set; }

    public int? IlceY { get; set; }

    public int? IlceW { get; set; }

    public string? IlceTxt { get; set; }

    public bool? VergidairesiVar { get; set; }

    public int? VergidairesiX { get; set; }

    public int? VergidairesiY { get; set; }

    public int? VergidairesiW { get; set; }

    public string? VergidairesiTxt { get; set; }

    public bool? VerginoVar { get; set; }

    public int? VerginoX { get; set; }

    public int? VerginoY { get; set; }

    public int? VerginoW { get; set; }

    public string? VerginoTxt { get; set; }

    public bool? StokkodVar { get; set; }

    public int? StokkodX { get; set; }

    public int? StokkodW { get; set; }

    public bool? StokisimVar { get; set; }

    public int? StokisimX { get; set; }

    public int? StokisimW { get; set; }

    public bool? MiktarVar { get; set; }

    public int? MiktarX { get; set; }

    public int? MiktarW { get; set; }

    public bool? BirimVar { get; set; }

    public int? BirimX { get; set; }

    public int? BirimW { get; set; }

    public bool? MambalajVar { get; set; }

    public int? MambalajX { get; set; }

    public int? MambalajW { get; set; }

    public bool? FiyatVar { get; set; }

    public int? FiyatX { get; set; }

    public int? FiyatW { get; set; }

    public bool? TemelmiktarVar { get; set; }

    public int? TemelmiktarX { get; set; }

    public int? TemelmiktarW { get; set; }

    public bool? TemelbirimVar { get; set; }

    public int? TemelbirimX { get; set; }

    public int? TemelbirimW { get; set; }

    public bool? TemelfiyatVar { get; set; }

    public int? TemelfiyatX { get; set; }

    public int? TemelfiyatW { get; set; }

    public bool? KdvVar { get; set; }

    public int? KdvX { get; set; }

    public int? KdvW { get; set; }

    public string? KdvTxt { get; set; }

    public bool? Kisk1Var { get; set; }

    public int? Kisk1X { get; set; }

    public int? Kisk1W { get; set; }

    public bool? Kisk2Var { get; set; }

    public int? Kisk2X { get; set; }

    public int? Kisk2W { get; set; }

    public bool? Kisk3Var { get; set; }

    public int? Kisk3X { get; set; }

    public int? Kisk3W { get; set; }

    public bool? TutarVar { get; set; }

    public int? TutarX { get; set; }

    public int? TutarW { get; set; }

    public bool? FaturanoVar { get; set; }

    public int? FaturanoX { get; set; }

    public int? FaturanoY { get; set; }

    public int? FaturanoW { get; set; }

    public string? FaturanoTxt { get; set; }

    public bool? TarihVar { get; set; }

    public int? TarihX { get; set; }

    public int? TarihY { get; set; }

    public int? TarihW { get; set; }

    public string? TarihTxt { get; set; }

    public bool? FiilitarihVar { get; set; }

    public int? FiilitarihX { get; set; }

    public int? FiilitarihY { get; set; }

    public int? FiilitarihW { get; set; }

    public string? FiilitarihTxt { get; set; }

    public bool? SaatVar { get; set; }

    public int? SaatX { get; set; }

    public int? SaatY { get; set; }

    public int? SaatW { get; set; }

    public string? SaatTxt { get; set; }

    public bool? Ekmetin1Var { get; set; }

    public int? Ekmetin1X { get; set; }

    public int? Ekmetin1Y { get; set; }

    public int? Ekmetin1W { get; set; }

    public string? Ekmetin1Txt { get; set; }

    public bool? Ekmetin2Var { get; set; }

    public int? Ekmetin2X { get; set; }

    public int? Ekmetin2Y { get; set; }

    public int? Ekmetin2W { get; set; }

    public string? Ekmetin2Txt { get; set; }

    public bool? Ekmetin3Var { get; set; }

    public int? Ekmetin3X { get; set; }

    public int? Ekmetin3Y { get; set; }

    public int? Ekmetin3W { get; set; }

    public string? Ekmetin3Txt { get; set; }

    public bool? Ekmetin4Var { get; set; }

    public int? Ekmetin4X { get; set; }

    public int? Ekmetin4Y { get; set; }

    public int? Ekmetin4W { get; set; }

    public string? Ekmetin4Txt { get; set; }

    public bool? Ekmetin5Var { get; set; }

    public int? Ekmetin5X { get; set; }

    public int? Ekmetin5Y { get; set; }

    public int? Ekmetin5W { get; set; }

    public string? Ekmetin5Txt { get; set; }

    public bool? BirimalttoplamVar { get; set; }

    public bool? BirimambalajalttoplamVar { get; set; }

    public bool? TapdknoVar { get; set; }

    public int? TapdknoX { get; set; }

    public int? TapdknoY { get; set; }

    public int? TapdknoW { get; set; }

    public string? TapdknoTxt { get; set; }

    public bool? SonbakiyeVar { get; set; }

    public bool? SimdikibakiyeVar { get; set; }

    public bool? HaricbakiyeVar { get; set; }

    public bool? IrsaliyenoVar { get; set; }

    public int? IrsaliyenoX { get; set; }

    public int? IrsaliyenoY { get; set; }

    public int? IrsaliyenoW { get; set; }

    public string? IrsaliyenoTxt { get; set; }

    public bool? VadetarihVar { get; set; }

    public int? VadetarihX { get; set; }

    public int? VadetarihY { get; set; }

    public int? VadetarihW { get; set; }

    public string? VadetarihTxt { get; set; }

    public bool? AlttoplambaslangicVar { get; set; }

    public bool? AlttoplamaciklamalariyazVar { get; set; }

    public bool? KalemiskontotoplamVar { get; set; }

    public bool? CariiskontotoplamVar { get; set; }

    public bool? Cariiskonto1toplamVar { get; set; }

    public bool? Cariiskonto2toplamVar { get; set; }

    public bool? IskontotoplamVar { get; set; }

    public bool? MatrahVar { get; set; }

    public bool? KdvtoplamVar { get; set; }

    public bool? GeneltoplamVar { get; set; }

    public bool? Matrah1Var { get; set; }

    public bool? Matrah8Var { get; set; }

    public bool? Matrah18Var { get; set; }

    public bool? Kdv1Var { get; set; }

    public bool? Kdv8Var { get; set; }

    public bool? Kdv18Var { get; set; }

    public bool? FaturaaltigeneltoplamyaziylaVar { get; set; }

    public bool? MaltoplamVar { get; set; }

    public bool? BambalajVar { get; set; }

    public int? BambalajX { get; set; }

    public int? BambalajW { get; set; }

    public int? SayfaboyuY { get; set; }

    public int? SayfaboyuX { get; set; }

    public int? Kagitboyu { get; set; }

    public int? KalembaslangicY { get; set; }

    public bool? FaturaaltigeneltoplamrakamlaVar { get; set; }

    public bool? YuklemeirsaliyenoVar { get; set; }

    public int? YuklemeirsaliyenoX { get; set; }

    public int? YuklemeirsaliyenoY { get; set; }

    public int? YuklemeirsaliyenoW { get; set; }

    public string? YuklemeirsaliyenoTxt { get; set; }

    public bool? SevkadresVar { get; set; }

    public int? SevkadresX { get; set; }

    public int? SevkadresY { get; set; }

    public int? SevkadresW { get; set; }

    public string? SevkadresTxt { get; set; }

    public bool? SevkkodVar { get; set; }

    public int? SevkkodX { get; set; }

    public int? SevkkodY { get; set; }

    public int? SevkkodW { get; set; }

    public string? SevkkodTxt { get; set; }

    public bool? SevkilVar { get; set; }

    public int? SevkilX { get; set; }

    public int? SevkilY { get; set; }

    public int? SevkilW { get; set; }

    public string? SevkilTxt { get; set; }

    public bool? SevkilceVar { get; set; }

    public int? SevkilceX { get; set; }

    public int? SevkilceY { get; set; }

    public int? SevkilceW { get; set; }

    public string? SevkilceTxt { get; set; }

    public int? Kalemsatirsayisi { get; set; }

    public int? Yazdirmamilisaniye { get; set; }

    public string? Yaziciozelayar { get; set; }

    public int? TahsilattoplamX { get; set; }

    public int? TahsilattoplamY { get; set; }

    public int? TahsilattoplamyaziylaX { get; set; }

    public int? TahsilattoplamyaziylaY { get; set; }

    public bool? TahsilatsonbakiyeVar { get; set; }

    public int? TahsilatsonbakiyeX { get; set; }

    public int? TahsilatsonbakiyeY { get; set; }

    public bool? TahsilatoncekibakiyeVar { get; set; }

    public int? TahsilatoncekibakiyeX { get; set; }

    public int? TahsilatoncekibakiyeY { get; set; }

    public bool? CariiskontoyuzdeVar { get; set; }

    public bool? Cariiskonto1yuzdeVar { get; set; }

    public bool? Cariiskonto2yuzdeVar { get; set; }

    public bool? EvrakFatura { get; set; }

    public bool? EvrakPerakendefatura { get; set; }

    public bool? EvrakIrsaliye { get; set; }

    public int? KullaniciX { get; set; }

    public int? KullaniciY { get; set; }

    public int? KullaniciW { get; set; }

    public string? KullaniciTxt { get; set; }

    public bool? KullaniciVar { get; set; }

    public int? AciklamaX { get; set; }

    public int? AciklamaY { get; set; }

    public int? AciklamaW { get; set; }

    public string? AciklamaTxt { get; set; }

    public bool? AciklamaVar { get; set; }

    public string? Ozelkod { get; set; }

    public int? Sayfakalemsayisi { get; set; }

    public bool? OtvVar { get; set; }

    public bool? OtvtoplamVar { get; set; }

    public int? OtvX { get; set; }

    public int? OtvW { get; set; }

    public bool? OdemetipVar { get; set; }

    public int? OdemetipX { get; set; }

    public int? OdemetipY { get; set; }

    public int? OdemetipW { get; set; }

    public string? OdemetipTxt { get; set; }

    public bool? Tahsilatekmetin1Var { get; set; }

    public int? Tahsilatekmetin1X { get; set; }

    public int? Tahsilatekmetin1Y { get; set; }

    public int? Tahsilatekmetin1W { get; set; }

    public string? Tahsilatekmetin1Txt { get; set; }

    public bool? Tahsilatekmetin2Var { get; set; }

    public int? Tahsilatekmetin2X { get; set; }

    public int? Tahsilatekmetin2Y { get; set; }

    public int? Tahsilatekmetin2W { get; set; }

    public string? Tahsilatekmetin2Txt { get; set; }

    public bool? TahsilatsimdikibakiyeVar { get; set; }

    public bool? EvrakseriVar { get; set; }

    public int? EvrakseriX { get; set; }

    public int? EvrakseriY { get; set; }

    public int? EvrakseriW { get; set; }

    public string? EvrakseriTxt { get; set; }

    public bool? EvraksiraVar { get; set; }

    public int? EvraksiraX { get; set; }

    public int? EvraksiraY { get; set; }

    public int? EvraksiraW { get; set; }

    public string? EvraksiraTxt { get; set; }

    public bool? EttnVar { get; set; }

    public int? EttnX { get; set; }

    public int? EttnY { get; set; }

    public int? EttnW { get; set; }

    public string? EttnTxt { get; set; }

    public bool? TabelaisimVar { get; set; }

    public int? TabelaisimX { get; set; }

    public int? TabelaisimY { get; set; }

    public int? TabelaisimW { get; set; }

    public string? TabelaisimTxt { get; set; }

    public bool? Farkliambalajbirimbirlestir { get; set; }

    public bool? EarsivEvraknoVar { get; set; }

    public int? EarsivEvraknoX { get; set; }

    public int? EarsivEvraknoY { get; set; }

    public int? EarsivEvraknoW { get; set; }

    public string? EarsivEvraknoTxt { get; set; }

    public bool? Irsaliyeekmetin1Var { get; set; }

    public int? Irsaliyeekmetin1X { get; set; }

    public int? Irsaliyeekmetin1Y { get; set; }

    public int? Irsaliyeekmetin1W { get; set; }

    public string? Irsaliyeekmetin1Txt { get; set; }

    public bool? Irsaliyeekmetin2Var { get; set; }

    public int? Irsaliyeekmetin2X { get; set; }

    public int? Irsaliyeekmetin2Y { get; set; }

    public int? Irsaliyeekmetin2W { get; set; }

    public string? Irsaliyeekmetin2Txt { get; set; }

    public bool? Irsaliyeekmetin3Var { get; set; }

    public int? Irsaliyeekmetin3X { get; set; }

    public int? Irsaliyeekmetin3Y { get; set; }

    public int? Irsaliyeekmetin3W { get; set; }

    public string? Irsaliyeekmetin3Txt { get; set; }

    public bool? Irsaliyeekmetin4Var { get; set; }

    public int? Irsaliyeekmetin4X { get; set; }

    public int? Irsaliyeekmetin4Y { get; set; }

    public int? Irsaliyeekmetin4W { get; set; }

    public string? Irsaliyeekmetin4Txt { get; set; }

    public bool? Irsaliyeekmetin5Var { get; set; }

    public int? Irsaliyeekmetin5X { get; set; }

    public int? Irsaliyeekmetin5Y { get; set; }

    public int? Irsaliyeekmetin5W { get; set; }

    public string? Irsaliyeekmetin5Txt { get; set; }

    public string? Ciktitip { get; set; }

    public bool? TrmStokkodVar { get; set; }

    public bool? TrmAmbalajVar { get; set; }

    public bool? TrmTutarVar { get; set; }

    public bool? TrmKdvyuzdeVar { get; set; }

    public bool? TrmSonbakiyeVar { get; set; }

    public string? TrmEfaturaAltaciklama { get; set; }

    public string? TrmEirsaliyeAltaciklama { get; set; }

    public string? TrmEarsivAltaciklama { get; set; }

    public string? TrmFirmalogoGorsel { get; set; }

    public string? TrmFirmaimzaGorsel { get; set; }

    public string? TrmFirmabilgi { get; set; }

    public bool? EirsaliyeEvraknoVar { get; set; }

    public int? EirsaliyeEvraknoX { get; set; }

    public int? EirsaliyeEvraknoY { get; set; }

    public int? EirsaliyeEvraknoW { get; set; }

    public string? EirsaliyeEvraknoTxt { get; set; }

    public string? TrmNusha { get; set; }

    public string? TrmTahsilatAltaciklama { get; set; }

    public bool? TrmTetaVar { get; set; }

    public bool? TrmVadetarihVar { get; set; }

    public bool? TrmSonbakiyeIrsaliyeVar { get; set; }

    public bool? TrmNushaDurdurVar { get; set; }

    public bool? TrmEirsaliyenoBarkodVar { get; set; }

    public bool? TrmMatrahdetayVar { get; set; }

    public bool? TrmKdvdetayVar { get; set; }

    public bool? TrmSonbakiyeTahsilatVar { get; set; }

    public bool? TrmHaricbakiyeVar { get; set; }

    public bool? TrmGrafikkullan { get; set; }

    public bool? TrmEvrakaciklamaVar { get; set; }

    public bool? TrmDepozitobakiyeVar { get; set; }

    public bool? TrmKalemiskontoVar { get; set; }

    public bool? TrmYazdirildigitarihsaatVar { get; set; }

    public string? TrmEbelgeEkaciklama { get; set; }

    public string? TrmEbelgeEkaciklama2 { get; set; }
}
