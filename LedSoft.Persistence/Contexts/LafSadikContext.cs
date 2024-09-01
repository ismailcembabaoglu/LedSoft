using System;
using System.Collections.Generic;
using LedSoft.Persistence;
using Microsoft.EntityFrameworkCore;

namespace LedSoft.Persistence.Contexts;

public partial class LafSadikContext : DbContext
{
    public LafSadikContext()
    {
    }

    public LafSadikContext(DbContextOptions<LafSadikContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Arac> Aracs { get; set; }

    public virtual DbSet<AracEkekipman> AracEkekipmen { get; set; }

    public virtual DbSet<Aracbilinmeyenkonum> Aracbilinmeyenkonums { get; set; }

    public virtual DbSet<Aracbilinmeyensicaklik> Aracbilinmeyensicakliks { get; set; }

    public virtual DbSet<Araccanbusveri> Araccanbusveris { get; set; }

    public virtual DbSet<Aracgrup> Aracgrups { get; set; }

    public virtual DbSet<AracgrupDetay> AracgrupDetays { get; set; }

    public virtual DbSet<Aracguncelbilgi> Aracguncelbilgis { get; set; }

    public virtual DbSet<Aracisi> Aracisis { get; set; }

    public virtual DbSet<Arackm> Arackms { get; set; }

    public virtual DbSet<Arackmduzeltme> Arackmduzeltmes { get; set; }

    public virtual DbSet<Arackmozet> Arackmozets { get; set; }

    public virtual DbSet<Arackonum> Arackonums { get; set; }

    public virtual DbSet<Aracsicaklik> Aracsicakliks { get; set; }

    public virtual DbSet<Aracyakit> Aracyakits { get; set; }

    public virtual DbSet<Bakim> Bakims { get; set; }

    public virtual DbSet<Binaryfile> Binaryfiles { get; set; }

    public virtual DbSet<Borc> Borcs { get; set; }

    public virtual DbSet<Borç> Borçs { get; set; }

    public virtual DbSet<Carihareket> Cariharekets { get; set; }

    public virtual DbSet<CarihareketDovizislem> CarihareketDovizislems { get; set; }

    public virtual DbSet<CarihareketDovizkurfarki> CarihareketDovizkurfarkis { get; set; }

    public virtual DbSet<CarihareketFi> CarihareketFis { get; set; }

    public virtual DbSet<CarihareketKktaksit> CarihareketKktaksits { get; set; }

    public virtual DbSet<Cek> Ceks { get; set; }

    public virtual DbSet<CekCirodetay> CekCirodetays { get; set; }

    public virtual DbSet<Ceksenetbordro> Ceksenetbordros { get; set; }

    public virtual DbSet<Chtanim> Chtanims { get; set; }

    public virtual DbSet<ChtanimB2bYenimusteri> ChtanimB2bYenimusteris { get; set; }

    public virtual DbSet<ChtanimB2bkullanici> ChtanimB2bkullanicis { get; set; }

    public virtual DbSet<ChtanimB2bkullaniciFavoristok> ChtanimB2bkullaniciFavoristoks { get; set; }

    public virtual DbSet<ChtanimB2blog> ChtanimB2blogs { get; set; }

    public virtual DbSet<ChtanimBankakredi> ChtanimBankakredis { get; set; }

    public virtual DbSet<ChtanimBankakrediodemeplan> ChtanimBankakrediodemeplans { get; set; }

    public virtual DbSet<ChtanimBh> ChtanimBhs { get; set; }

    public virtual DbSet<ChtanimBhgrup> ChtanimBhgrups { get; set; }

    public virtual DbSet<ChtanimBhgrupdetay> ChtanimBhgrupdetays { get; set; }

    public virtual DbSet<ChtanimCh> ChtanimChes { get; set; }

    public virtual DbSet<ChtanimChadre> ChtanimChadres { get; set; }

    public virtual DbSet<ChtanimChbankabilgi> ChtanimChbankabilgis { get; set; }

    public virtual DbSet<ChtanimChemanet> ChtanimChemanets { get; set; }

    public virtual DbSet<ChtanimChgrup> ChtanimChgrups { get; set; }

    public virtual DbSet<ChtanimChgrupdetay> ChtanimChgrupdetays { get; set; }

    public virtual DbSet<ChtanimChiletisim> ChtanimChiletisims { get; set; }

    public virtual DbSet<ChtanimChnot> ChtanimChnots { get; set; }

    public virtual DbSet<ChtanimGg> ChtanimGgs { get; set; }

    public virtual DbSet<ChtanimGgkalem> ChtanimGgkalems { get; set; }

    public virtual DbSet<ChtanimGidergrup> ChtanimGidergrups { get; set; }

    public virtual DbSet<ChtanimGidergrupdetay> ChtanimGidergrupdetays { get; set; }

    public virtual DbSet<ChtanimK> ChtanimKs { get; set; }

    public virtual DbSet<ChtanimKk> ChtanimKks { get; set; }

    public virtual DbSet<ChtanimP> ChtanimPs { get; set; }

    public virtual DbSet<ChtanimPersonel> ChtanimPersonels { get; set; }

    public virtual DbSet<ChtanimPortfoy> ChtanimPortfoys { get; set; }

    public virtual DbSet<ChtanimPosgrup> ChtanimPosgrups { get; set; }

    public virtual DbSet<ChtanimPosgrupdetay> ChtanimPosgrupdetays { get; set; }

    public virtual DbSet<ChtanimPsAnlasma> ChtanimPsAnlasmas { get; set; }

    public virtual DbSet<ChtanimTeminatmektup> ChtanimTeminatmektups { get; set; }

    public virtual DbSet<ChtanimTeminatmektupHukumluluk> ChtanimTeminatmektupHukumluluks { get; set; }

    public virtual DbSet<Cv> Cvs { get; set; }

    public virtual DbSet<CvCalisma> CvCalismas { get; set; }

    public virtual DbSet<CvEgitim> CvEgitims { get; set; }

    public virtual DbSet<Degisimfi> Degisimfis { get; set; }

    public virtual DbSet<DegisimfisDetay> DegisimfisDetays { get; set; }

    public virtual DbSet<Deposipari> Deposiparis { get; set; }

    public virtual DbSet<DeposiparisDetay> DeposiparisDetays { get; set; }

    public virtual DbSet<Depotanim> Depotanims { get; set; }

    public virtual DbSet<DepotanimAdre> DepotanimAdres { get; set; }

    public virtual DbSet<DepotanimDepogrup> DepotanimDepogrups { get; set; }

    public virtual DbSet<DepotanimDepogrupdetay> DepotanimDepogrupdetays { get; set; }

    public virtual DbSet<Depotransfer> Depotransfers { get; set; }

    public virtual DbSet<DepotransferBarkoddetay> DepotransferBarkoddetays { get; set; }

    public virtual DbSet<DepotransferDetay> DepotransferDetays { get; set; }

    public virtual DbSet<DepotransferSevkiyat> DepotransferSevkiyats { get; set; }

    public virtual DbSet<DepotransferTumdepoirsaliyedetay> DepotransferTumdepoirsaliyedetays { get; set; }

    public virtual DbSet<Dovizkur> Dovizkurs { get; set; }

    public virtual DbSet<Emanettanim> Emanettanims { get; set; }

    public virtual DbSet<Excelcari> Excelcaris { get; set; }

    public virtual DbSet<Excelstok> Excelstoks { get; set; }

    public virtual DbSet<Fatura> Faturas { get; set; }

    public virtual DbSet<FaturaBarkoddetay> FaturaBarkoddetays { get; set; }

    public virtual DbSet<FaturaDeger> FaturaDegers { get; set; }

    public virtual DbSet<FaturaDetay> FaturaDetays { get; set; }

    public virtual DbSet<FaturaEvrakbaglanti> FaturaEvrakbaglantis { get; set; }

    public virtual DbSet<FaturaFiyatfarkidetay> FaturaFiyatfarkidetays { get; set; }

    public virtual DbSet<FaturaIhracat> FaturaIhracats { get; set; }

    public virtual DbSet<FaturaInternetsati> FaturaInternetsatis { get; set; }

    public virtual DbSet<FaturaMasrafkalem> FaturaMasrafkalems { get; set; }

    public virtual DbSet<FaturaSevkiyat> FaturaSevkiyats { get; set; }

    public virtual DbSet<Fiyatanlasma> Fiyatanlasmas { get; set; }

    public virtual DbSet<FiyatanlasmaDetay> FiyatanlasmaDetays { get; set; }

    public virtual DbSet<Fiyatliste> Fiyatlistes { get; set; }

    public virtual DbSet<FiyatlisteAlt> FiyatlisteAlts { get; set; }

    public virtual DbSet<FiyatlisteAltsevkadre> FiyatlisteAltsevkadres { get; set; }

    public virtual DbSet<FiyatlisteCari> FiyatlisteCaris { get; set; }

    public virtual DbSet<FiyatlisteCarigrup> FiyatlisteCarigrups { get; set; }

    public virtual DbSet<FiyatlisteCarikategori> FiyatlisteCarikategoris { get; set; }

    public virtual DbSet<FiyatlisteDetay> FiyatlisteDetays { get; set; }

    public virtual DbSet<Fiyatteklif> Fiyatteklifs { get; set; }

    public virtual DbSet<FiyatteklifDetay> FiyatteklifDetays { get; set; }

    public virtual DbSet<FiyatyonetimSablon> FiyatyonetimSablons { get; set; }

    public virtual DbSet<FiyatyonetimSablondetay> FiyatyonetimSablondetays { get; set; }

    public virtual DbSet<FiyatyonetimStokdeger> FiyatyonetimStokdegers { get; set; }

    public virtual DbSet<Gecicistokhareket> Gecicistokharekets { get; set; }

    public virtual DbSet<Giderfi> Giderfis { get; set; }

    public virtual DbSet<GiderfisDetay> GiderfisDetays { get; set; }

    public virtual DbSet<GrdLayout> GrdLayouts { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupsAuth> GroupsAuths { get; set; }

    public virtual DbSet<GroupsMenu> GroupsMenus { get; set; }

    public virtual DbSet<GroupsUser> GroupsUsers { get; set; }

    public virtual DbSet<Grup> Grups { get; set; }

    public virtual DbSet<GrupDetay> GrupDetays { get; set; }

    public virtual DbSet<Hatirlatma> Hatirlatmas { get; set; }

    public virtual DbSet<Hatirlatmadetay> Hatirlatmadetays { get; set; }

    public virtual DbSet<Hedef> Hedefs { get; set; }

    public virtual DbSet<HedefDetay> HedefDetays { get; set; }

    public virtual DbSet<Hediyeceki> Hediyecekis { get; set; }

    public virtual DbSet<Iadesebeptanim> Iadesebeptanims { get; set; }

    public virtual DbSet<Iskontoliste> Iskontolistes { get; set; }

    public virtual DbSet<IskontolisteCari> IskontolisteCaris { get; set; }

    public virtual DbSet<IskontolisteDetay> IskontolisteDetays { get; set; }

    public virtual DbSet<IslemBakim> IslemBakims { get; set; }

    public virtual DbSet<IslemBakimDetay> IslemBakimDetays { get; set; }

    public virtual DbSet<IslemCeza> IslemCezas { get; set; }

    public virtual DbSet<IslemKasko> IslemKaskos { get; set; }

    public virtual DbSet<IslemMuayene> IslemMuayenes { get; set; }

    public virtual DbSet<IslemSigortum> IslemSigorta { get; set; }

    public virtual DbSet<IslemTamir> IslemTamirs { get; set; }

    public virtual DbSet<IslemTamirDetay> IslemTamirDetays { get; set; }

    public virtual DbSet<IslemYolcutasimaizin> IslemYolcutasimaizins { get; set; }

    public virtual DbSet<Izin> Izins { get; set; }

    public virtual DbSet<Izlemelink> Izlemelinks { get; set; }

    public virtual DbSet<Kampanya> Kampanyas { get; set; }

    public virtual DbSet<KampanyaCaridetay> KampanyaCaridetays { get; set; }

    public virtual DbSet<KampanyaCarigrupdetay> KampanyaCarigrupdetays { get; set; }

    public virtual DbSet<KampanyaCarikategoridetay> KampanyaCarikategoridetays { get; set; }

    public virtual DbSet<KampanyaKosuldetay> KampanyaKosuldetays { get; set; }

    public virtual DbSet<KampanyaSonucdetay> KampanyaSonucdetays { get; set; }

    public virtual DbSet<Kampanyatanim> Kampanyatanims { get; set; }

    public virtual DbSet<KampanyatanimK1Haricstok> KampanyatanimK1Haricstoks { get; set; }

    public virtual DbSet<KampanyatanimK1Kosul> KampanyatanimK1Kosuls { get; set; }

    public virtual DbSet<KampanyatanimK1Sonuc> KampanyatanimK1Sonucs { get; set; }

    public virtual DbSet<Kasaesitleme> Kasaesitlemes { get; set; }

    public virtual DbSet<KasaesitlemeLog> KasaesitlemeLogs { get; set; }

    public virtual DbSet<Kategori> Kategoris { get; set; }

    public virtual DbSet<Kategori1> Kategoris1 { get; set; }

    public virtual DbSet<Kategoriagac> Kategoriagacs { get; set; }

    public virtual DbSet<Konumetiket> Konumetikets { get; set; }

    public virtual DbSet<Kullanicimobilbildirim> Kullanicimobilbildirims { get; set; }

    public virtual DbSet<La> Las { get; set; }

    public virtual DbSet<LogAuth> LogAuths { get; set; }

    public virtual DbSet<LogDbexec> LogDbexecs { get; set; }

    public virtual DbSet<LogIndex> LogIndices { get; set; }

    public virtual DbSet<LogLaf> LogLafs { get; set; }

    public virtual DbSet<LogLogin> LogLogins { get; set; }

    public virtual DbSet<LogSm> LogSms { get; set; }

    public virtual DbSet<LogWmKeyauth> LogWmKeyauths { get; set; }

    public virtual DbSet<Lojistikprojetanim> Lojistikprojetanims { get; set; }

    public virtual DbSet<LojistikprojetanimCari> LojistikprojetanimCaris { get; set; }

    public virtual DbSet<LojistikprojetanimStok> LojistikprojetanimStoks { get; set; }

    public virtual DbSet<LojistikprojetanimTemsilci> LojistikprojetanimTemsilcis { get; set; }

    public virtual DbSet<LrfPrintlayout> LrfPrintlayouts { get; set; }

    public virtual DbSet<Maillist> Maillists { get; set; }

    public virtual DbSet<MaillistDetail> MaillistDetails { get; set; }

    public virtual DbSet<Malkabul> Malkabuls { get; set; }

    public virtual DbSet<MalkabulDetay> MalkabulDetays { get; set; }

    public virtual DbSet<Masatanim> Masatanims { get; set; }

    public virtual DbSet<Mesaj> Mesajs { get; set; }

    public virtual DbSet<Mesajdetay> Mesajdetays { get; set; }

    public virtual DbSet<Mobilbildirimlog> Mobilbildirimlogs { get; set; }

    public virtual DbSet<MobileFaturatasarim> MobileFaturatasarims { get; set; }

    public virtual DbSet<Mobilkullanici> Mobilkullanicis { get; set; }

    public virtual DbSet<Msg> Msgs { get; set; }

    public virtual DbSet<MsgRcv> MsgRcvs { get; set; }

    public virtual DbSet<Musteri> Musteris { get; set; }

    public virtual DbSet<Musteritalepsikayet> Musteritalepsikayets { get; set; }

    public virtual DbSet<Musteriveresiye> Musteriveresiyes { get; set; }

    public virtual DbSet<Mutabakat> Mutabakats { get; set; }

    public virtual DbSet<Mutabakatdetay> Mutabakatdetays { get; set; }

    public virtual DbSet<ObjAuth> ObjAuths { get; set; }

    public virtual DbSet<ObjClu> ObjClus { get; set; }

    public virtual DbSet<ObjDb> ObjDbs { get; set; }

    public virtual DbSet<ObjFile> ObjFiles { get; set; }

    public virtual DbSet<ObjLaf> ObjLafs { get; set; }

    public virtual DbSet<ObjLafprn> ObjLafprns { get; set; }

    public virtual DbSet<ObjLang> ObjLangs { get; set; }

    public virtual DbSet<ObjLangre> ObjLangres { get; set; }

    public virtual DbSet<ObjLic> ObjLics { get; set; }

    public virtual DbSet<ObjLrf> ObjLrves { get; set; }

    public virtual DbSet<ObjMauth> ObjMauths { get; set; }

    public virtual DbSet<ObjMenu> ObjMenus { get; set; }

    public virtual DbSet<ObjPlg> ObjPlgs { get; set; }

    public virtual DbSet<ObjSetting> ObjSettings { get; set; }

    public virtual DbSet<ObjSrc> ObjSrcs { get; set; }

    public virtual DbSet<ObjUpdate> ObjUpdates { get; set; }

    public virtual DbSet<ObjUser> ObjUsers { get; set; }

    public virtual DbSet<ObjVar> ObjVars { get; set; }

    public virtual DbSet<ObjWmFilebin> ObjWmFilebins { get; set; }

    public virtual DbSet<ObjWmKeyauth> ObjWmKeyauths { get; set; }

    public virtual DbSet<ObjWmLang> ObjWmLangs { get; set; }

    public virtual DbSet<ObjWmLangre> ObjWmLangres { get; set; }

    public virtual DbSet<ObjWmMenu> ObjWmMenus { get; set; }

    public virtual DbSet<ObjWmModule> ObjWmModules { get; set; }

    public virtual DbSet<Oturum> Oturums { get; set; }

    public virtual DbSet<Palet> Palets { get; set; }

    public virtual DbSet<PaletDetay> PaletDetays { get; set; }

    public virtual DbSet<PaletYazici> PaletYazicis { get; set; }

    public virtual DbSet<Partino> Partinos { get; set; }

    public virtual DbSet<PersonelBanka> PersonelBankas { get; set; }

    public virtual DbSet<PersonelDigerhakedi> PersonelDigerhakedis { get; set; }

    public virtual DbSet<PersonelIzindetay> PersonelIzindetays { get; set; }

    public virtual DbSet<PersonelKesinti> PersonelKesintis { get; set; }

    public virtual DbSet<PersonelSube> PersonelSubes { get; set; }

    public virtual DbSet<Personelailebilgi> Personelailebilgis { get; set; }

    public virtual DbSet<Personeldepartman> Personeldepartmen { get; set; }

    public virtual DbSet<Personelgirisciki> Personelgiriscikis { get; set; }

    public virtual DbSet<Personelgorev> Personelgorevs { get; set; }

    public virtual DbSet<Personelistek> Personelisteks { get; set; }

    public virtual DbSet<Personelizin> Personelizins { get; set; }

    public virtual DbSet<Personeltanim> Personeltanims { get; set; }

    public virtual DbSet<PosyazarkasaPlu> PosyazarkasaPlus { get; set; }

    public virtual DbSet<PosyazarkasaPlulog> PosyazarkasaPlulogs { get; set; }

    public virtual DbSet<PosyazarkasaTransferlog> PosyazarkasaTransferlogs { get; set; }

    public virtual DbSet<Printlayout> Printlayouts { get; set; }

    public virtual DbSet<PrintlayoutsUser> PrintlayoutsUsers { get; set; }

    public virtual DbSet<Projetanim> Projetanims { get; set; }

    public virtual DbSet<PropLaf> PropLafs { get; set; }

    public virtual DbSet<Recete> Recetes { get; set; }

    public virtual DbSet<ReceteAmbalajdetay> ReceteAmbalajdetays { get; set; }

    public virtual DbSet<ReceteDetay> ReceteDetays { get; set; }

    public virtual DbSet<ReceteKalemciki> ReceteKalemcikis { get; set; }

    public virtual DbSet<ReceteKalemgiris> ReceteKalemgirises { get; set; }

    public virtual DbSet<Recetesablon> Recetesablons { get; set; }

    public virtual DbSet<RecetesablonAmbalajdetay> RecetesablonAmbalajdetays { get; set; }

    public virtual DbSet<RecetesablonDetay> RecetesablonDetays { get; set; }

    public virtual DbSet<Restaurantsati> Restaurantsatis { get; set; }

    public virtual DbSet<Rutplani> Rutplanis { get; set; }

    public virtual DbSet<RutplaniDetay> RutplaniDetays { get; set; }

    public virtual DbSet<Sabitgider> Sabitgiders { get; set; }

    public virtual DbSet<SahaRafduzenleme> SahaRafduzenlemes { get; set; }

    public virtual DbSet<Sanalposodemetalebi> Sanalposodemetalebis { get; set; }

    public virtual DbSet<Sati> Satis { get; set; }

    public virtual DbSet<Satisdetay> Satisdetays { get; set; }

    public virtual DbSet<Satisteklif> Satisteklifs { get; set; }

    public virtual DbSet<SatisteklifDetay> SatisteklifDetays { get; set; }

    public virtual DbSet<Sayim> Sayims { get; set; }

    public virtual DbSet<SayimDetay> SayimDetays { get; set; }

    public virtual DbSet<Senet> Senets { get; set; }

    public virtual DbSet<ServiceLog> ServiceLogs { get; set; }

    public virtual DbSet<Sevkiyateleman> Sevkiyatelemen { get; set; }

    public virtual DbSet<Sipari> Siparis { get; set; }

    public virtual DbSet<SiparisDeger> SiparisDegers { get; set; }

    public virtual DbSet<SiparisDetay> SiparisDetays { get; set; }

    public virtual DbSet<Smskontak> Smskontaks { get; set; }

    public virtual DbSet<Smtplist> Smtplists { get; set; }

    public virtual DbSet<Stoktanim> Stoktanims { get; set; }

    public virtual DbSet<StoktanimAmbalajbirim> StoktanimAmbalajbirims { get; set; }

    public virtual DbSet<StoktanimAmbalajkullanim> StoktanimAmbalajkullanims { get; set; }

    public virtual DbSet<StoktanimBarkod> StoktanimBarkods { get; set; }

    public virtual DbSet<StoktanimBarkodsablon> StoktanimBarkodsablons { get; set; }

    public virtual DbSet<StoktanimBirim> StoktanimBirims { get; set; }

    public virtual DbSet<StoktanimBirimcevrim> StoktanimBirimcevrims { get; set; }

    public virtual DbSet<StoktanimDepo> StoktanimDepos { get; set; }

    public virtual DbSet<StoktanimDepoadre> StoktanimDepoadres { get; set; }

    public virtual DbSet<StoktanimEtiketfi> StoktanimEtiketfis { get; set; }

    public virtual DbSet<StoktanimEtiketfisdetay> StoktanimEtiketfisdetays { get; set; }

    public virtual DbSet<StoktanimGrup> StoktanimGrups { get; set; }

    public virtual DbSet<StoktanimGrupdetay> StoktanimGrupdetays { get; set; }

    public virtual DbSet<StoktanimGrupdetaygrup> StoktanimGrupdetaygrups { get; set; }

    public virtual DbSet<StoktanimHizmetkdv> StoktanimHizmetkdvs { get; set; }

    public virtual DbSet<StoktanimKoddonusum> StoktanimKoddonusums { get; set; }

    public virtual DbSet<StoktanimKoddonusumCari> StoktanimKoddonusumCaris { get; set; }

    public virtual DbSet<StoktanimKoddonusumDetay> StoktanimKoddonusumDetays { get; set; }

    public virtual DbSet<StoktanimLisan> StoktanimLisans { get; set; }

    public virtual DbSet<StoktanimPerakendedepartman> StoktanimPerakendedepartmen { get; set; }

    public virtual DbSet<StoktanimRecete> StoktanimRecetes { get; set; }

    public virtual DbSet<StoktanimSubedetay> StoktanimSubedetays { get; set; }

    public virtual DbSet<StoktanimTedarikci> StoktanimTedarikcis { get; set; }

    public virtual DbSet<StoktanimVaryasyon> StoktanimVaryasyons { get; set; }

    public virtual DbSet<Stokuretimetiket> Stokuretimetikets { get; set; }

    public virtual DbSet<Stokuretimetiketdepartman> Stokuretimetiketdepartmen { get; set; }

    public virtual DbSet<Stokuretimetiketdetay> Stokuretimetiketdetays { get; set; }

    public virtual DbSet<Stokuretimetiketdizayn> Stokuretimetiketdizayns { get; set; }

    public virtual DbSet<Stokvirman> Stokvirmen { get; set; }

    public virtual DbSet<StokvirmanCiki> StokvirmanCikis { get; set; }

    public virtual DbSet<StokvirmanGiris> StokvirmanGirises { get; set; }

    public virtual DbSet<Subeayarsablon> Subeayarsablons { get; set; }

    public virtual DbSet<Subeizlemenot> Subeizlemenots { get; set; }

    public virtual DbSet<Subetanim> Subetanims { get; set; }

    public virtual DbSet<Subetanim1> Subetanims1 { get; set; }

    public virtual DbSet<SubetanimKasa> SubetanimKasas { get; set; }

    public virtual DbSet<SubetanimKasaPo> SubetanimKasaPos { get; set; }

    public virtual DbSet<SubetanimKullanici> SubetanimKullanicis { get; set; }

    public virtual DbSet<SubetanimSabitmasraf> SubetanimSabitmasrafs { get; set; }

    public virtual DbSet<SubetanimSatisdanisman> SubetanimSatisdanismen { get; set; }

    public virtual DbSet<SubetanimSiparisplan> SubetanimSiparisplans { get; set; }

    public virtual DbSet<SubetanimSiparisplandetay> SubetanimSiparisplandetays { get; set; }

    public virtual DbSet<SubetanimStokbarkod> SubetanimStokbarkods { get; set; }

    public virtual DbSet<SubetanimYazarkasa> SubetanimYazarkasas { get; set; }

    public virtual DbSet<Surucu> Surucus { get; set; }

    public virtual DbSet<SurucuEhliyet> SurucuEhliyets { get; set; }

    public virtual DbSet<Template> Templates { get; set; }

    public virtual DbSet<TemplatesAuth> TemplatesAuths { get; set; }

    public virtual DbSet<Temsilci> Temsilcis { get; set; }

    public virtual DbSet<Temsilcisahahareket> Temsilcisahaharekets { get; set; }

    public virtual DbSet<Temsilcitanim> Temsilcitanims { get; set; }

    public virtual DbSet<TemsilcitanimDeposipari> TemsilcitanimDeposiparis { get; set; }

    public virtual DbSet<Uretim> Uretims { get; set; }

    public virtual DbSet<UretimDetay> UretimDetays { get; set; }

    public virtual DbSet<Uretimplan> Uretimplans { get; set; }

    public virtual DbSet<UretimplanDeposipari> UretimplanDeposiparis { get; set; }

    public virtual DbSet<UretimplanSipari> UretimplanSiparis { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UsersAuth> UsersAuths { get; set; }

    public virtual DbSet<UsersMenu> UsersMenus { get; set; }

    public virtual DbSet<UsersMenufav> UsersMenufavs { get; set; }

    public virtual DbSet<UsersMobileauth> UsersMobileauths { get; set; }

    public virtual DbSet<UsersMobilemenu> UsersMobilemenus { get; set; }

    public virtual DbSet<Vardiya> Vardiyas { get; set; }

    public virtual DbSet<VardiyaDetay> VardiyaDetays { get; set; }

    public virtual DbSet<Variable> Variables { get; set; }

    public virtual DbSet<Wbakiye> Wbakiyes { get; set; }

    public virtual DbSet<Wbanka> Wbankas { get; set; }

    public virtual DbSet<Wcarihareket> Wcariharekets { get; set; }

    public virtual DbSet<Wcariharekettip> Wcariharekettips { get; set; }

    public virtual DbSet<Wcarikart> Wcarikarts { get; set; }

    public virtual DbSet<Wdepotransferdetay> Wdepotransferdetays { get; set; }

    public virtual DbSet<Wdepozitohareket> Wdepozitoharekets { get; set; }

    public virtual DbSet<Wfatura> Wfaturas { get; set; }

    public virtual DbSet<Wfaturadeger> Wfaturadegers { get; set; }

    public virtual DbSet<Wfaturadetay> Wfaturadetays { get; set; }

    public virtual DbSet<Wfiyat> Wfiyats { get; set; }

    public virtual DbSet<Wfiyatham> Wfiyathams { get; set; }

    public virtual DbSet<Whatirlatmalar> Whatirlatmalars { get; set; }

    public virtual DbSet<Wililce> Wililces { get; set; }

    public virtual DbSet<Windexstatus> Windexstatuses { get; set; }

    public virtual DbSet<Wkasa> Wkasas { get; set; }

    public virtual DbSet<Wkdvmuafiyet> Wkdvmuafiyets { get; set; }

    public virtual DbSet<Wkonumetiket> Wkonumetikets { get; set; }

    public virtual DbSet<Wkredikart> Wkredikarts { get; set; }

    public virtual DbSet<Wkullanici> Wkullanicis { get; set; }

    public virtual DbSet<Wkurfarki> Wkurfarkis { get; set; }

    public virtual DbSet<Wmaliyet> Wmaliyets { get; set; }

    public virtual DbSet<Wmasrafdetay> Wmasrafdetays { get; set; }

    public virtual DbSet<Wmusteri> Wmusteris { get; set; }

    public virtual DbSet<Wpersonel> Wpersonels { get; set; }

    public virtual DbSet<Wpo> Wpos { get; set; }

    public virtual DbSet<Wportfoy> Wportfoys { get; set; }

    public virtual DbSet<WraporSiparisliste> WraporSiparislistes { get; set; }

    public virtual DbSet<WraporSiparislistedetay> WraporSiparislistedetays { get; set; }

    public virtual DbSet<WsToken> WsTokens { get; set; }

    public virtual DbSet<WsToken1> WsTokens1 { get; set; }

    public virtual DbSet<WsTokenChtanimB2b> WsTokenChtanimB2bs { get; set; }

    public virtual DbSet<WsTokenSurucu> WsTokenSurucus { get; set; }

    public virtual DbSet<WsTokenTemsilci> WsTokenTemsilcis { get; set; }

    public virtual DbSet<Wsati> Wsatis { get; set; }

    public virtual DbSet<Wsatisdetay> Wsatisdetays { get; set; }

    public virtual DbSet<Wsatismaliyet> Wsatismaliyets { get; set; }

    public virtual DbSet<Wserinohareket> Wserinoharekets { get; set; }

    public virtual DbSet<Wsipari> Wsiparis { get; set; }

    public virtual DbSet<Wsiparisdetay> Wsiparisdetays { get; set; }

    public virtual DbSet<Wstokbakiye> Wstokbakiyes { get; set; }

    public virtual DbSet<Wstokhareket> Wstokharekets { get; set; }

    public virtual DbSet<Wstokhareketdetay> Wstokhareketdetays { get; set; }

    public virtual DbSet<Wstokkoddonusum> Wstokkoddonusums { get; set; }

    public virtual DbSet<Wsubeayar> Wsubeayars { get; set; }

    public virtual DbSet<Wsubecarihareket> Wsubecariharekets { get; set; }

    public virtual DbSet<Wtevkifatkod> Wtevkifatkods { get; set; }

    public virtual DbSet<Wulke> Wulkes { get; set; }

    public virtual DbSet<Wyakitfi> Wyakitfis { get; set; }

    public virtual DbSet<WyakitfisTamdolum> WyakitfisTamdolums { get; set; }

    public virtual DbSet<Yakitfi> Yakitfis { get; set; }

    public virtual DbSet<Ziyaret> Ziyarets { get; set; }

    public virtual DbSet<ZiyaretB> ZiyaretBs { get; set; }

    public virtual DbSet<Zrapor> Zrapors { get; set; }

    public virtual DbSet<ZraporDepartmantanim> ZraporDepartmantanims { get; set; }

    public virtual DbSet<ZraporDetay> ZraporDetays { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=192.168.1.144, 1433;Database=LAF_SADIK;User Id=sa;Password=17421742;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Arac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_arac");

            entity.ToTable("arac", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Aracsinif)
                .HasMaxLength(50)
                .HasColumnName("ARACSINIF");
            entity.Property(e => e.BdHl).HasColumnName("BD_HL");
            entity.Property(e => e.BdHt1)
                .HasColumnType("datetime")
                .HasColumnName("BD_HT1");
            entity.Property(e => e.BdHt2)
                .HasColumnType("datetime")
                .HasColumnName("BD_HT2");
            entity.Property(e => e.BdHtv).HasColumnName("BD_HTV");
            entity.Property(e => e.BdKht1)
                .HasColumnType("datetime")
                .HasColumnName("BD_KHT1");
            entity.Property(e => e.BdKht2)
                .HasColumnType("datetime")
                .HasColumnName("BD_KHT2");
            entity.Property(e => e.BdKhv).HasColumnName("BD_KHV");
            entity.Property(e => e.BdKt1)
                .HasColumnType("datetime")
                .HasColumnName("BD_KT1");
            entity.Property(e => e.BdKt2)
                .HasColumnType("datetime")
                .HasColumnName("BD_KT2");
            entity.Property(e => e.BdKtv).HasColumnName("BD_KTV");
            entity.Property(e => e.BdSn).HasColumnName("BD_SN");
            entity.Property(e => e.BdSt1)
                .HasColumnType("datetime")
                .HasColumnName("BD_ST1");
            entity.Property(e => e.BdSt2)
                .HasColumnType("datetime")
                .HasColumnName("BD_ST2");
            entity.Property(e => e.BdStv).HasColumnName("BD_STV");
            entity.Property(e => e.BdSx).HasColumnName("BD_SX");
            entity.Property(e => e.BdTt1)
                .HasColumnType("datetime")
                .HasColumnName("BD_TT1");
            entity.Property(e => e.BdTt2)
                .HasColumnType("datetime")
                .HasColumnName("BD_TT2");
            entity.Property(e => e.BdTv).HasColumnName("BD_TV");
            entity.Property(e => e.Donanimsifre)
                .HasMaxLength(10)
                .HasColumnName("DONANIMSIFRE");
            entity.Property(e => e.EntegrasyonChid).HasColumnName("ENTEGRASYON_CHID");
            entity.Property(e => e.EntegrasyonFerdikoltuksigortagiderid).HasColumnName("ENTEGRASYON_FERDIKOLTUKSIGORTAGIDERID");
            entity.Property(e => e.EntegrasyonIhtiyarimalisigortagiderid).HasColumnName("ENTEGRASYON_IHTIYARIMALISIGORTAGIDERID");
            entity.Property(e => e.EntegrasyonKaskogiderid).HasColumnName("ENTEGRASYON_KASKOGIDERID");
            entity.Property(e => e.EntegrasyonMuayenegiderid).HasColumnName("ENTEGRASYON_MUAYENEGIDERID");
            entity.Property(e => e.EntegrasyonPeriyodikbakimgiderid).HasColumnName("ENTEGRASYON_PERIYODIKBAKIMGIDERID");
            entity.Property(e => e.EntegrasyonSigortagiderid).HasColumnName("ENTEGRASYON_SIGORTAGIDERID");
            entity.Property(e => e.EntegrasyonTamirgiderid).HasColumnName("ENTEGRASYON_TAMIRGIDERID");
            entity.Property(e => e.EntegrasyonTrafikcezagiderid).HasColumnName("ENTEGRASYON_TRAFIKCEZAGIDERID");
            entity.Property(e => e.EntegrasyonTrafiksigortagiderid).HasColumnName("ENTEGRASYON_TRAFIKSIGORTAGIDERID");
            entity.Property(e => e.EntegrasyonYakitgiderid).HasColumnName("ENTEGRASYON_YAKITGIDERID");
            entity.Property(e => e.EntegrasyonYesilkartsigortagiderid).HasColumnName("ENTEGRASYON_YESILKARTSIGORTAGIDERID");
            entity.Property(e => e.Gorsel)
                .HasColumnType("image")
                .HasColumnName("GORSEL");
            entity.Property(e => e.Gsm)
                .HasMaxLength(50)
                .HasColumnName("GSM");
            entity.Property(e => e.HgsOgs)
                .HasMaxLength(255)
                .HasColumnName("HGS_OGS");
            entity.Property(e => e.Ilktesciltarih)
                .HasColumnType("datetime")
                .HasColumnName("ILKTESCILTARIH");
            entity.Property(e => e.Imei)
                .HasMaxLength(20)
                .HasColumnName("IMEI");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kapisensoru2var).HasColumnName("KAPISENSORU2VAR");
            entity.Property(e => e.Kapisensoruvar).HasColumnName("KAPISENSORUVAR");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Kullanimamaci)
                .HasMaxLength(255)
                .HasColumnName("KULLANIMAMACI");
            entity.Property(e => e.Marka)
                .HasMaxLength(100)
                .HasColumnName("MARKA");
            entity.Property(e => e.Maxyakit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MAXYAKIT");
            entity.Property(e => e.Minyakit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MINYAKIT");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Modelyil)
                .HasMaxLength(100)
                .HasColumnName("MODELYIL");
            entity.Property(e => e.Modelyili).HasColumnName("MODELYILI");
            entity.Property(e => e.Motorblokaj).HasColumnName("MOTORBLOKAJ");
            entity.Property(e => e.Motorblokajbeklemede).HasColumnName("MOTORBLOKAJBEKLEMEDE");
            entity.Property(e => e.Motorno)
                .HasMaxLength(255)
                .HasColumnName("MOTORNO");
            entity.Property(e => e.Noter)
                .HasMaxLength(255)
                .HasColumnName("NOTER");
            entity.Property(e => e.NotfChecksum).HasColumnName("NOTF_CHECKSUM");
            entity.Property(e => e.Ortyakit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ORTYAKIT");
            entity.Property(e => e.Ozelkod1)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD1");
            entity.Property(e => e.Plaka)
                .HasMaxLength(100)
                .HasColumnName("PLAKA");
            entity.Property(e => e.Renk)
                .HasMaxLength(100)
                .HasColumnName("RENK");
            entity.Property(e => e.Saseno)
                .HasMaxLength(255)
                .HasColumnName("SASENO");
            entity.Property(e => e.Sicakliksensoru2var).HasColumnName("SICAKLIKSENSORU2VAR");
            entity.Property(e => e.Sicakliksensoruvar).HasColumnName("SICAKLIKSENSORUVAR");
            entity.Property(e => e.Surucuadsoyad)
                .HasMaxLength(255)
                .HasColumnName("SURUCUADSOYAD");
            entity.Property(e => e.Surucuid).HasColumnName("SURUCUID");
            entity.Property(e => e.Surucutelno)
                .HasMaxLength(100)
                .HasColumnName("SURUCUTELNO");
            entity.Property(e => e.Tescilsirano)
                .HasMaxLength(100)
                .HasColumnName("TESCILSIRANO");
            entity.Property(e => e.Tesciltarih)
                .HasColumnType("datetime")
                .HasColumnName("TESCILTARIH");
            entity.Property(e => e.Yakitcinsi)
                .HasMaxLength(5)
                .HasColumnName("YAKITCINSI");
            entity.Property(e => e.Yakitsensoruvar).HasColumnName("YAKITSENSORUVAR");
        });

        modelBuilder.Entity<AracEkekipman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_arac_ekekipman");

            entity.ToTable("arac_ekekipman", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Serino)
                .HasMaxLength(255)
                .HasColumnName("SERINO");
            entity.Property(e => e.Tip)
                .HasMaxLength(255)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Aracbilinmeyenkonum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracbilinmeyenkonum");

            entity.ToTable("aracbilinmeyenkonum", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Boylam).HasColumnName("BOYLAM");
            entity.Property(e => e.Enlem).HasColumnName("ENLEM");
            entity.Property(e => e.Imei)
                .HasMaxLength(100)
                .HasColumnName("IMEI");
        });

        modelBuilder.Entity<Aracbilinmeyensicaklik>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracbilinmeyensicaklik");

            entity.ToTable("aracbilinmeyensicaklik", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Imei)
                .HasMaxLength(100)
                .HasColumnName("IMEI");
            entity.Property(e => e.Sicaklik)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SICAKLIK");
        });

        modelBuilder.Entity<Araccanbusveri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_araccanbusveri");

            entity.ToTable("araccanbusveri", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Ect).HasColumnName("ECT");
            entity.Property(e => e.Es).HasColumnName("ES");
            entity.Property(e => e.Fl).HasColumnName("FL");
            entity.Property(e => e.Hrvd).HasColumnName("HRVD");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
            entity.Property(e => e.Ws).HasColumnName("WS");
        });

        modelBuilder.Entity<Aracgrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracgrup");

            entity.ToTable("aracgrup", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<AracgrupDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracgrup_detay");

            entity.ToTable("aracgrup_detay", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Grupid).HasColumnName("GRUPID");
        });

        modelBuilder.Entity<Aracguncelbilgi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracguncelbilgi");

            entity.ToTable("aracguncelbilgi", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Bat).HasColumnName("BAT");
            entity.Property(e => e.Batarya).HasColumnName("BATARYA");
            entity.Property(e => e.Batsarj).HasColumnName("BATSARJ");
            entity.Property(e => e.Battarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("BATTARIHSAAT");
            entity.Property(e => e.Boylam).HasColumnName("BOYLAM");
            entity.Property(e => e.Enlem).HasColumnName("ENLEM");
            entity.Property(e => e.Hiz).HasColumnName("HIZ");
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Kmtarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("KMTARIHSAAT");
            entity.Property(e => e.Kontak).HasColumnName("KONTAK");
            entity.Property(e => e.Konumtip)
                .HasMaxLength(4)
                .HasColumnName("KONUMTIP");
            entity.Property(e => e.Mesafe).HasColumnName("MESAFE");
            entity.Property(e => e.Sicaklik).HasColumnName("SICAKLIK");
            entity.Property(e => e.Sicakliktarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("SICAKLIKTARIHSAAT");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
            entity.Property(e => e.Yakitbirim)
                .HasMaxLength(20)
                .HasColumnName("YAKITBIRIM");
            entity.Property(e => e.Yakitdeger)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YAKITDEGER");
            entity.Property(e => e.Yakittarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("YAKITTARIHSAAT");
            entity.Property(e => e.Yon).HasColumnName("YON");
            entity.Property(e => e.Yukseklik).HasColumnName("YUKSEKLIK");
        });

        modelBuilder.Entity<Aracisi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracisi");

            entity.ToTable("aracisi", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Sicaklik).HasColumnName("SICAKLIK");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
        });

        modelBuilder.Entity<Arackm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_arackm");

            entity.ToTable("arackm", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
        });

        modelBuilder.Entity<Arackmduzeltme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_arackmduzeltme");

            entity.ToTable("arackmduzeltme", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
        });

        modelBuilder.Entity<Arackmozet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_arackmozet");

            entity.ToTable("arackmozet", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Km).HasColumnName("KM");
            entity.Property(e => e.Mesafe).HasColumnName("MESAFE");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Arackonum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_arackonum");

            entity.ToTable("arackonum", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Batarya).HasColumnName("BATARYA");
            entity.Property(e => e.Boylam).HasColumnName("BOYLAM");
            entity.Property(e => e.Enlem).HasColumnName("ENLEM");
            entity.Property(e => e.Hiz).HasColumnName("HIZ");
            entity.Property(e => e.Kontak).HasColumnName("KONTAK");
            entity.Property(e => e.Mesafe).HasColumnName("MESAFE");
            entity.Property(e => e.Sicaklik).HasColumnName("SICAKLIK");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Uydusayisi).HasColumnName("UYDUSAYISI");
            entity.Property(e => e.Yon).HasColumnName("YON");
            entity.Property(e => e.Yukseklik).HasColumnName("YUKSEKLIK");
        });

        modelBuilder.Entity<Aracsicaklik>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracsicaklik");

            entity.ToTable("aracsicaklik", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Bolgeno).HasColumnName("BOLGENO");
            entity.Property(e => e.Sicaklik).HasColumnName("SICAKLIK");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
        });

        modelBuilder.Entity<Aracyakit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_aracyakit");

            entity.ToTable("aracyakit", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
            entity.Property(e => e.Yakitbirim)
                .HasMaxLength(20)
                .HasColumnName("YAKITBIRIM");
            entity.Property(e => e.Yakitdeger)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YAKITDEGER");
        });

        modelBuilder.Entity<Bakim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_bakim");

            entity.ToTable("bakim", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bakim1)
                .HasMaxLength(255)
                .HasColumnName("BAKIM");
        });

        modelBuilder.Entity<Binaryfile>(entity =>
        {
            entity.ToTable("binaryfile", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Changetime)
                .HasColumnType("datetime")
                .HasColumnName("CHANGETIME");
            entity.Property(e => e.Createtime)
                .HasColumnType("datetime")
                .HasColumnName("CREATETIME");
            entity.Property(e => e.Description).HasColumnName("DESCRIPTION");
            entity.Property(e => e.Filebinary).HasColumnName("FILEBINARY");
            entity.Property(e => e.Filehash)
                .HasMaxLength(100)
                .HasColumnName("FILEHASH");
            entity.Property(e => e.Filename)
                .HasMaxLength(255)
                .HasColumnName("FILENAME");
            entity.Property(e => e.Ownercode)
                .HasMaxLength(255)
                .HasColumnName("OWNERCODE");
            entity.Property(e => e.Ownerid).HasColumnName("OWNERID");
            entity.Property(e => e.Ownertype)
                .HasMaxLength(5)
                .HasColumnName("OWNERTYPE");
            entity.Property(e => e.Size).HasColumnName("SIZE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Borc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BORC");

            entity.Property(e => e.Borc1)
                .HasColumnType("decimal(8, 2)")
                .HasColumnName("BORC");
            entity.Property(e => e.Isim)
                .HasMaxLength(50)
                .HasColumnName("ISIM");
        });

        modelBuilder.Entity<Borç>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("borç$");

            entity.Property(e => e.AkelPen)
                .HasMaxLength(255)
                .HasColumnName("AKEL PEN");
        });

        modelBuilder.Entity<Carihareket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_carihareket");

            entity.ToTable("carihareket", "led", tb => tb.HasTrigger("tg_ceksenetdurum_update"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bankakrediid).HasColumnName("BANKAKREDIID");
            entity.Property(e => e.Bktaksitid).HasColumnName("BKTAKSITID");
            entity.Property(e => e.Bordroid).HasColumnName("BORDROID");
            entity.Property(e => e.Carihareketfisid).HasColumnName("CARIHAREKETFISID");
            entity.Property(e => e.Cekid).HasColumnName("CEKID");
            entity.Property(e => e.Chid)
                .HasComment("chtanim.ID")
                .HasColumnName("CHID");
            entity.Property(e => e.Chid2)
                .HasComment("chtanim.ID")
                .HasColumnName("CHID2");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur).HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.FiloAracislemid).HasColumnName("FILO_ARACISLEMID");
            entity.Property(e => e.FiloAracislemtip)
                .HasMaxLength(10)
                .HasColumnName("FILO_ARACISLEMTIP");
            entity.Property(e => e.Gorsel)
                .HasColumnType("image")
                .HasColumnName("GORSEL");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Kktaksitsayisi).HasColumnName("KKTAKSITSAYISI");
            entity.Property(e => e.PerKasaid).HasColumnName("PER_KASAID");
            entity.Property(e => e.PerPersonelid).HasColumnName("PER_PERSONELID");
            entity.Property(e => e.PerSubeid).HasColumnName("PER_SUBEID");
            entity.Property(e => e.Posanlasmaid).HasColumnName("POSANLASMAID");
            entity.Property(e => e.Poskomisyon)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("POSKOMISYON");
            entity.Property(e => e.Posodemekartnobilgi)
                .HasMaxLength(100)
                .HasColumnName("POSODEMEKARTNOBILGI");
            entity.Property(e => e.Posonayno)
                .HasMaxLength(255)
                .HasColumnName("POSONAYNO");
            entity.Property(e => e.Posslipid).HasColumnName("POSSLIPID");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Senetid).HasColumnName("SENETID");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Sevkadresid2).HasColumnName("SEVKADRESID2");
            entity.Property(e => e.Smsgonderildi).HasColumnName("SMSGONDERILDI");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasDefaultValueSql("((0))")
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");

            entity.HasOne(d => d.Bordro).WithMany(p => p.Cariharekets)
                .HasForeignKey(d => d.Bordroid)
                .HasConstraintName("FK_LAF_led_carihareket_BORDROID");

            entity.HasOne(d => d.Cek).WithMany(p => p.Cariharekets)
                .HasForeignKey(d => d.Cekid)
                .HasConstraintName("FK_LAF_led_carihareket_CEKID");

            entity.HasOne(d => d.Ch).WithMany(p => p.CarihareketChes)
                .HasForeignKey(d => d.Chid)
                .HasConstraintName("FK_LAF_led_carihareket_CHID");

            entity.HasOne(d => d.Chid2Navigation).WithMany(p => p.CarihareketChid2Navigations)
                .HasForeignKey(d => d.Chid2)
                .HasConstraintName("FK_LAF_led_carihareket_CH2ID");

            entity.HasOne(d => d.Senet).WithMany(p => p.Cariharekets)
                .HasForeignKey(d => d.Senetid)
                .HasConstraintName("FK_LAF_led_carihareket_SENETID");
        });

        modelBuilder.Entity<CarihareketDovizislem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_carihareket_dovizislem");

            entity.ToTable("carihareket_dovizislem", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Chid2).HasColumnName("CHID2");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizcinsi2)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI2");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Dovizkur2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("DOVIZKUR2");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Tutar2)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR2");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
        });

        modelBuilder.Entity<CarihareketDovizkurfarki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_carihareket_dovizkurfarki");

            entity.ToTable("carihareket_dovizkurfarki", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Cekid).HasColumnName("CEKID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Chid2).HasColumnName("CHID2");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizcinsi2)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI2");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
        });

        modelBuilder.Entity<CarihareketFi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_carihareket_fis");

            entity.ToTable("carihareket_fis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bankahesapid).HasColumnName("BANKAHESAPID");
            entity.Property(e => e.Bankakrediid).HasColumnName("BANKAKREDIID");
            entity.Property(e => e.Bktaksitid).HasColumnName("BKTAKSITID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Kredikartiid).HasColumnName("KREDIKARTIID");
            entity.Property(e => e.Nakitkasaid).HasColumnName("NAKITKASAID");
            entity.Property(e => e.Posanlasmaid)
                .HasMaxLength(100)
                .HasColumnName("POSANLASMAID");
            entity.Property(e => e.Posid).HasColumnName("POSID");
            entity.Property(e => e.Poskomisyon)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("POSKOMISYON");
            entity.Property(e => e.Poskomisyonhesapid).HasColumnName("POSKOMISYONHESAPID");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<CarihareketKktaksit>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_carihareket_kktaksit");

            entity.ToTable("carihareket_kktaksit", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Cek>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_cek");

            entity.ToTable("cek", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Banka)
                .HasMaxLength(100)
                .HasColumnName("BANKA");
            entity.Property(e => e.Bordroid).HasColumnName("BORDROID");
            entity.Property(e => e.Cekdurum)
                .HasMaxLength(4)
                .HasColumnName("CEKDURUM");
            entity.Property(e => e.Cekno)
                .HasMaxLength(100)
                .HasColumnName("CEKNO");
            entity.Property(e => e.Cekportfoyid).HasColumnName("CEKPORTFOYID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Cirolu).HasColumnName("CIROLU");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.GorselArkayuz)
                .HasColumnType("image")
                .HasColumnName("GORSEL_ARKAYUZ");
            entity.Property(e => e.GorselOnyuz)
                .HasColumnType("image")
                .HasColumnName("GORSEL_ONYUZ");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(255)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.Kaside)
                .HasMaxLength(255)
                .HasColumnName("KASIDE");
            entity.Property(e => e.Portfoyid).HasColumnName("PORTFOYID");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Sube)
                .HasMaxLength(100)
                .HasColumnName("SUBE");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasComment("Çek Tipi M1 Müşteri Çeki K1: Firma Çeki")
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");

            entity.HasOne(d => d.Ch).WithMany(p => p.CekChes)
                .HasForeignKey(d => d.Chid)
                .HasConstraintName("FK_LAF_led_cek_CHID");

            entity.HasOne(d => d.Portfoy).WithMany(p => p.CekPortfoys)
                .HasForeignKey(d => d.Portfoyid)
                .HasConstraintName("FK_LAF_led_cek_PORTFOYID");
        });

        modelBuilder.Entity<CekCirodetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_cek_cirodetay");

            entity.ToTable("cek_cirodetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(600)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Cekid).HasColumnName("CEKID");
        });

        modelBuilder.Entity<Ceksenetbordro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_ceksenetbordro");

            entity.ToTable("ceksenetbordro", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bordrono)
                .HasMaxLength(255)
                .HasColumnName("BORDRONO");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");

            entity.HasOne(d => d.Ch).WithMany(p => p.Ceksenetbordros)
                .HasForeignKey(d => d.Chid)
                .HasConstraintName("FK_LAF_led_ceksenetbordro_CHID");
        });

        modelBuilder.Entity<Chtanim>(entity =>
        {
            entity.ToTable("chtanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<ChtanimB2bYenimusteri>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_b2b_yenimusteri");

            entity.ToTable("chtanim_b2b_yenimusteri", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres).HasColumnName("ADRES");
            entity.Property(e => e.Durum)
                .HasMaxLength(4)
                .HasColumnName("DURUM");
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Gsm)
                .HasMaxLength(255)
                .HasColumnName("GSM");
            entity.Property(e => e.Isim).HasColumnName("ISIM");
            entity.Property(e => e.Not).HasColumnName("NOT");
            entity.Property(e => e.Yetkili).HasColumnName("YETKILI");
        });

        modelBuilder.Entity<ChtanimB2bkullanici>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_b2bkullanici");

            entity.ToTable("chtanim_b2bkullanici", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Anahtar)
                .HasMaxLength(100)
                .HasColumnName("ANAHTAR");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Eposta)
                .HasMaxLength(100)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(100)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.Parola)
                .HasMaxLength(100)
                .HasColumnName("PAROLA");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Songiris)
                .HasColumnType("datetime")
                .HasColumnName("SONGIRIS");
            entity.Property(e => e.YetkiEkstre).HasColumnName("YETKI_EKSTRE");
            entity.Property(e => e.YetkiIstegebagliodeme).HasColumnName("YETKI_ISTEGEBAGLIODEME");
            entity.Property(e => e.YetkiSiparis).HasColumnName("YETKI_SIPARIS");
            entity.Property(e => e.YetkiSiparisfiyat).HasColumnName("YETKI_SIPARISFIYAT");
        });

        modelBuilder.Entity<ChtanimB2bkullaniciFavoristok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_b2bkullanici_favoristok");

            entity.ToTable("chtanim_b2bkullanici_favoristok", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<ChtanimB2blog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_b2blog");

            entity.ToTable("chtanim_b2blog", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.B2bkullaniciid).HasColumnName("B2BKULLANICIID");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
        });

        modelBuilder.Entity<ChtanimBankakredi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_bankakredi");

            entity.ToTable("chtanim_bankakredi", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bankahesapid).HasColumnName("BANKAHESAPID");
            entity.Property(e => e.Bsmv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BSMV");
            entity.Property(e => e.Bsmvgiderid).HasColumnName("BSMVGIDERID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Dosyamasraf)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("DOSYAMASRAF");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Faizgiderid).HasColumnName("FAIZGIDERID");
            entity.Property(e => e.Faizoran)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("FAIZORAN");
            entity.Property(e => e.Kapama).HasColumnName("KAPAMA");
            entity.Property(e => e.Kapamafisid).HasColumnName("KAPAMAFISID");
            entity.Property(e => e.Kkdf)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KKDF");
            entity.Property(e => e.Kkdfgiderid).HasColumnName("KKDFGIDERID");
            entity.Property(e => e.Kreditip)
                .HasMaxLength(2)
                .HasColumnName("KREDITIP");
            entity.Property(e => e.Kreditutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KREDITUTAR");
            entity.Property(e => e.LedmuhHesapid).HasColumnName("LEDMUH_HESAPID");
            entity.Property(e => e.Masrafgiderid).HasColumnName("MASRAFGIDERID");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(255)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Taksitsayisi).HasColumnName("TAKSITSAYISI");
            entity.Property(e => e.Taksittarih).HasColumnName("TAKSITTARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Teminattip)
                .HasMaxLength(2)
                .HasColumnName("TEMINATTIP");
        });

        modelBuilder.Entity<ChtanimBankakrediodemeplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_bankakredi_odemeplan");

            entity.ToTable("chtanim_bankakrediodemeplan", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Anapara)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ANAPARA");
            entity.Property(e => e.Bakiye)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BAKIYE");
            entity.Property(e => e.Bankakrediid).HasColumnName("BANKAKREDIID");
            entity.Property(e => e.Bsmv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BSMV");
            entity.Property(e => e.Faiztutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FAIZTUTAR");
            entity.Property(e => e.Kkdf)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KKDF");
            entity.Property(e => e.Taksitno).HasColumnName("TAKSITNO");
            entity.Property(e => e.Taksittutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TAKSITTUTAR");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
        });

        modelBuilder.Entity<ChtanimBh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_bh");

            entity.ToTable("chtanim_bh", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Banka)
                .HasMaxLength(255)
                .HasColumnName("BANKA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(100)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.Iban)
                .HasMaxLength(100)
                .HasColumnName("IBAN");
            entity.Property(e => e.LedmuhHesapid).HasColumnName("LEDMUH_HESAPID");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Sube)
                .HasMaxLength(255)
                .HasColumnName("SUBE");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(100)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkilitel)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL");
        });

        modelBuilder.Entity<ChtanimBhgrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_bhgrup");

            entity.ToTable("chtanim_bhgrup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<ChtanimBhgrupdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_bhgrupdetay");

            entity.ToTable("chtanim_bhgrupdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Bhgrupid).HasColumnName("BHGRUPID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
        });

        modelBuilder.Entity<ChtanimCh>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_ch");

            entity.ToTable("chtanim_ch", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acilistarih)
                .HasColumnType("datetime")
                .HasColumnName("ACILISTARIH");
            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .HasColumnName("AD");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("ADRES");
            entity.Property(e => e.Alisfiyatlisteid).HasColumnName("ALISFIYATLISTEID");
            entity.Property(e => e.Anachid).HasColumnName("ANACHID");
            entity.Property(e => e.Anachidvar).HasColumnName("ANACHIDVAR");
            entity.Property(e => e.AsistanEposta)
                .HasMaxLength(50)
                .HasColumnName("ASISTAN_EPOSTA");
            entity.Property(e => e.B2bkullaniciadi)
                .HasMaxLength(100)
                .HasColumnName("B2BKULLANICIADI");
            entity.Property(e => e.B2bparola)
                .HasMaxLength(100)
                .HasColumnName("B2BPAROLA");
            entity.Property(e => e.Barkod)
                .HasMaxLength(255)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Bilgisayarciktiprofilid).HasColumnName("BILGISAYARCIKTIPROFILID");
            entity.Property(e => e.Carisecimnotu).HasColumnName("CARISECIMNOTU");
            entity.Property(e => e.CarisecimnotuMasaustu).HasColumnName("CARISECIMNOTU_MASAUSTU");
            entity.Property(e => e.CarisecimnotuMobil).HasColumnName("CARISECIMNOTU_MOBIL");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Dijitaltel).HasColumnName("DIJITALTEL");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(50)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.EarsivEposta)
                .HasMaxLength(80)
                .HasColumnName("EARSIV_EPOSTA");
            entity.Property(e => e.EbabsEposta)
                .HasMaxLength(100)
                .HasColumnName("EBABS_EPOSTA");
            entity.Property(e => e.Ebelgekullan)
                .HasMaxLength(4)
                .HasColumnName("EBELGEKULLAN");
            entity.Property(e => e.EfaturaFaturaozeldizaynisim)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_FATURAOZELDIZAYNISIM");
            entity.Property(e => e.EfaturaIrsaliyeozeldizaynisim)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_IRSALIYEOZELDIZAYNISIM");
            entity.Property(e => e.EfaturaOzeldeger)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_OZELDEGER");
            entity.Property(e => e.EfaturaOzeldeger2)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_OZELDEGER2");
            entity.Property(e => e.EfaturaOzelkod)
                .HasMaxLength(100)
                .HasColumnName("EFATURA_OZELKOD");
            entity.Property(e => e.EfaturaOzelkod2)
                .HasMaxLength(100)
                .HasColumnName("EFATURA_OZELKOD2");
            entity.Property(e => e.EfaturaSenaryo)
                .HasMaxLength(4)
                .HasColumnName("EFATURA_SENARYO");
            entity.Property(e => e.Efaturaetiket)
                .HasMaxLength(255)
                .HasColumnName("EFATURAETIKET");
            entity.Property(e => e.Efaturakullaniyor).HasColumnName("EFATURAKULLANIYOR");
            entity.Property(e => e.Eirsaliyeetiket)
                .HasMaxLength(255)
                .HasColumnName("EIRSALIYEETIKET");
            entity.Property(e => e.Eirsaliyekullaniyor).HasColumnName("EIRSALIYEKULLANIYOR");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan10)
                .HasMaxLength(255)
                .HasColumnName("EKALAN10");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3)
                .HasMaxLength(255)
                .HasColumnName("EKALAN3");
            entity.Property(e => e.Ekalan4)
                .HasMaxLength(255)
                .HasColumnName("EKALAN4");
            entity.Property(e => e.Ekalan5)
                .HasMaxLength(255)
                .HasColumnName("EKALAN5");
            entity.Property(e => e.Ekalan6)
                .HasMaxLength(255)
                .HasColumnName("EKALAN6");
            entity.Property(e => e.Ekalan7)
                .HasMaxLength(255)
                .HasColumnName("EKALAN7");
            entity.Property(e => e.Ekalan8)
                .HasMaxLength(255)
                .HasColumnName("EKALAN8");
            entity.Property(e => e.Ekalan9)
                .HasMaxLength(255)
                .HasColumnName("EKALAN9");
            entity.Property(e => e.EmutabakatEposta)
                .HasMaxLength(255)
                .HasColumnName("EMUTABAKAT_EPOSTA");
            entity.Property(e => e.EmutabakatYetkili)
                .HasMaxLength(255)
                .HasColumnName("EMUTABAKAT_YETKILI");
            entity.Property(e => e.Emutabakatkullaniyor).HasColumnName("EMUTABAKATKULLANIYOR");
            entity.Property(e => e.Entegrasyonkod1)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD1");
            entity.Property(e => e.Entegrasyonkod2)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD2");
            entity.Property(e => e.Entegrasyonkod3)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD3");
            entity.Property(e => e.Entegrasyonkod4)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD4");
            entity.Property(e => e.Entegrasyonkod5)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD5");
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Epostaizin).HasColumnName("EPOSTAIZIN");
            entity.Property(e => e.Farklisevkadreskullaniliyor).HasColumnName("FARKLISEVKADRESKULLANILIYOR");
            entity.Property(e => e.Faturastokdil)
                .HasMaxLength(20)
                .HasColumnName("FATURASTOKDIL");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .HasColumnName("FAX");
            entity.Property(e => e.Fiyatkriteri).HasColumnName("FIYATKRITERI");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Il)
                .HasMaxLength(50)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ILCE");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskontolisteid).HasColumnName("ISKONTOLISTEID");
            entity.Property(e => e.Kategori10id).HasColumnName("KATEGORI10ID");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kategori4id).HasColumnName("KATEGORI4ID");
            entity.Property(e => e.Kategori5id).HasColumnName("KATEGORI5ID");
            entity.Property(e => e.Kategori6id).HasColumnName("KATEGORI6ID");
            entity.Property(e => e.Kategori7id).HasColumnName("KATEGORI7ID");
            entity.Property(e => e.Kategori8id).HasColumnName("KATEGORI8ID");
            entity.Property(e => e.Kategori9id).HasColumnName("KATEGORI9ID");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Kdvkriteri).HasColumnName("KDVKRITERI");
            entity.Property(e => e.Kredilimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KREDILIMIT");
            entity.Property(e => e.LedmuhMusterihesapid).HasColumnName("LEDMUH_MUSTERIHESAPID");
            entity.Property(e => e.LedmuhSaticihesapid).HasColumnName("LEDMUH_SATICIHESAPID");
            entity.Property(e => e.MobilCevrimicilimitkontrol)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_CEVRIMICILIMITKONTROL");
            entity.Property(e => e.MobilEvraknoayritakipet).HasColumnName("MOBIL_EVRAKNOAYRITAKIPET");
            entity.Property(e => e.MobilFiyatdegistirme)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_FIYATDEGISTIRME");
            entity.Property(e => e.MobilFiyatliirsaliye)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_FIYATLIIRSALIYE");
            entity.Property(e => e.MobilGpskonumkisitlama)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_GPSKONUMKISITLAMA");
            entity.Property(e => e.MobilIskontofiyatyansitma)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_ISKONTOFIYATYANSITMA");
            entity.Property(e => e.MobilKredilimityetki)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_KREDILIMITYETKI");
            entity.Property(e => e.MobilMaxiskonto1kullanim)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_MAXISKONTO1KULLANIM");
            entity.Property(e => e.MobilMaxiskonto2kullanim)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_MAXISKONTO2KULLANIM");
            entity.Property(e => e.MobilMaxiskonto3kullanim)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_MAXISKONTO3KULLANIM");
            entity.Property(e => e.MobilMaxiskontokullanim)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_MAXISKONTOKULLANIM");
            entity.Property(e => e.MobilPartinotakip).HasColumnName("MOBIL_PARTINOTAKIP");
            entity.Property(e => e.MobilRisklimityetki)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_RISKLIMITYETKI");
            entity.Property(e => e.MobilVadelimityetki)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_VADELIMITYETKI");
            entity.Property(e => e.Muafiyet).HasColumnName("MUAFIYET");
            entity.Property(e => e.Musterimuhasebekodu)
                .HasMaxLength(50)
                .HasColumnName("MUSTERIMUHASEBEKODU");
            entity.Property(e => e.Odemebankahesapid).HasColumnName("ODEMEBANKAHESAPID");
            entity.Property(e => e.Odemetip)
                .HasMaxLength(4)
                .HasColumnName("ODEMETIP");
            entity.Property(e => e.Ozelkod1)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD1");
            entity.Property(e => e.Ozelkod2)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD2");
            entity.Property(e => e.Ozelkod3)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD3");
            entity.Property(e => e.Ozelkod4)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD4");
            entity.Property(e => e.Ozelkod5)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD5");
            entity.Property(e => e.Postakodu)
                .HasMaxLength(5)
                .HasColumnName("POSTAKODU");
            entity.Property(e => e.Renkkodu)
                .HasMaxLength(6)
                .HasColumnName("RENKKODU");
            entity.Property(e => e.Resim1)
                .HasColumnType("image")
                .HasColumnName("RESIM1");
            entity.Property(e => e.Resim2)
                .HasColumnType("image")
                .HasColumnName("RESIM2");
            entity.Property(e => e.Resim3)
                .HasColumnType("image")
                .HasColumnName("RESIM3");
            entity.Property(e => e.Resim4)
                .HasColumnType("image")
                .HasColumnName("RESIM4");
            entity.Property(e => e.Resim5)
                .HasColumnType("image")
                .HasColumnName("RESIM5");
            entity.Property(e => e.Risklimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RISKLIMIT");
            entity.Property(e => e.Saticimuhasebekodu)
                .HasMaxLength(50)
                .HasColumnName("SATICIMUHASEBEKODU");
            entity.Property(e => e.Satisyapma).HasColumnName("SATISYAPMA");
            entity.Property(e => e.SatisyapmaSebep)
                .HasMaxLength(255)
                .HasColumnName("SATISYAPMA_SEBEP");
            entity.Property(e => e.Smsizin).HasColumnName("SMSIZIN");
            entity.Property(e => e.Soyad)
                .HasMaxLength(255)
                .HasColumnName("SOYAD");
            entity.Property(e => e.Stokiskonto1var).HasColumnName("STOKISKONTO1VAR");
            entity.Property(e => e.Stokiskonto2var).HasColumnName("STOKISKONTO2VAR");
            entity.Property(e => e.Stokiskonto3var).HasColumnName("STOKISKONTO3VAR");
            entity.Property(e => e.Tabelaisim)
                .HasMaxLength(255)
                .HasColumnName("TABELAISIM");
            entity.Property(e => e.Tapdkno)
                .HasMaxLength(50)
                .HasColumnName("TAPDKNO");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(100)
                .HasColumnName("TEL2");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.TerminalciktiprofilidF2).HasColumnName("TERMINALCIKTIPROFILID_F2");
            entity.Property(e => e.TerminalciktiprofilidFb).HasColumnName("TERMINALCIKTIPROFILID_FB");
            entity.Property(e => e.TerminalciktiprofilidI2).HasColumnName("TERMINALCIKTIPROFILID_I2");
            entity.Property(e => e.TerminalciktiprofilidN2).HasColumnName("TERMINALCIKTIPROFILID_N2");
            entity.Property(e => e.TerminalislemF2).HasColumnName("TERMINALISLEM_F2");
            entity.Property(e => e.TerminalislemFb).HasColumnName("TERMINALISLEM_FB");
            entity.Property(e => e.TerminalislemI2).HasColumnName("TERMINALISLEM_I2");
            entity.Property(e => e.TerminalislemKullan).HasColumnName("TERMINALISLEM_KULLAN");
            entity.Property(e => e.TerminalislemN2).HasColumnName("TERMINALISLEM_N2");
            entity.Property(e => e.TerminalyetkiFiyatdegistirme).HasColumnName("TERMINALYETKI_FIYATDEGISTIRME");
            entity.Property(e => e.TerminalyetkiGpskonum).HasColumnName("TERMINALYETKI_GPSKONUM");
            entity.Property(e => e.Ticarisicilno)
                .HasMaxLength(50)
                .HasColumnName("TICARISICILNO");
            entity.Property(e => e.Ulke)
                .HasMaxLength(100)
                .HasColumnName("ULKE");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(50)
                .HasColumnName("VERGIDAIRE");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .HasColumnName("VERGINO");
            entity.Property(e => e.Web)
                .HasMaxLength(50)
                .HasColumnName("WEB");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(255)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkiliadres)
                .HasMaxLength(400)
                .HasColumnName("YETKILIADRES");
            entity.Property(e => e.Zorunluparabirimi).HasColumnName("ZORUNLUPARABIRIMI");
        });

        modelBuilder.Entity<ChtanimChadre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_chadres");

            entity.ToTable("chtanim_chadres", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(400)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Barkod)
                .HasMaxLength(255)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.EarsivEposta)
                .HasMaxLength(80)
                .HasColumnName("EARSIV_EPOSTA");
            entity.Property(e => e.EfaturaOzeldeger)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_OZELDEGER");
            entity.Property(e => e.EfaturaOzeldeger2)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_OZELDEGER2");
            entity.Property(e => e.EfaturaOzelkod)
                .HasMaxLength(100)
                .HasColumnName("EFATURA_OZELKOD");
            entity.Property(e => e.EfaturaOzelkod2)
                .HasMaxLength(100)
                .HasColumnName("EFATURA_OZELKOD2");
            entity.Property(e => e.Efaturaetiket)
                .HasMaxLength(255)
                .HasColumnName("EFATURAETIKET");
            entity.Property(e => e.Eirsaliyeetiket)
                .HasMaxLength(255)
                .HasColumnName("EIRSALIYEETIKET");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan10)
                .HasMaxLength(255)
                .HasColumnName("EKALAN10");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3)
                .HasMaxLength(255)
                .HasColumnName("EKALAN3");
            entity.Property(e => e.Ekalan4)
                .HasMaxLength(255)
                .HasColumnName("EKALAN4");
            entity.Property(e => e.Ekalan5)
                .HasMaxLength(255)
                .HasColumnName("EKALAN5");
            entity.Property(e => e.Ekalan6)
                .HasMaxLength(255)
                .HasColumnName("EKALAN6");
            entity.Property(e => e.Ekalan7)
                .HasMaxLength(255)
                .HasColumnName("EKALAN7");
            entity.Property(e => e.Ekalan8)
                .HasMaxLength(255)
                .HasColumnName("EKALAN8");
            entity.Property(e => e.Ekalan9)
                .HasMaxLength(255)
                .HasColumnName("EKALAN9");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Entegrasyonkod2)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD2");
            entity.Property(e => e.Entegrasyonkod3)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD3");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .HasColumnName("FAX");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Il)
                .HasMaxLength(100)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(100)
                .HasColumnName("ILCE");
            entity.Property(e => e.Isim)
                .HasMaxLength(100)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kategori10id).HasColumnName("KATEGORI10ID");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kategori4id).HasColumnName("KATEGORI4ID");
            entity.Property(e => e.Kategori5id).HasColumnName("KATEGORI5ID");
            entity.Property(e => e.Kategori6id).HasColumnName("KATEGORI6ID");
            entity.Property(e => e.Kategori7id).HasColumnName("KATEGORI7ID");
            entity.Property(e => e.Kategori8id).HasColumnName("KATEGORI8ID");
            entity.Property(e => e.Kategori9id).HasColumnName("KATEGORI9ID");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Postakodu)
                .HasMaxLength(5)
                .HasColumnName("POSTAKODU");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(100)
                .HasColumnName("TEL2");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(255)
                .HasColumnName("YETKILI");
            entity.Property(e => e.YetkiliTel)
                .HasMaxLength(50)
                .HasColumnName("YETKILI_TEL");
        });

        modelBuilder.Entity<ChtanimChbankabilgi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_chbankabilgi");

            entity.ToTable("chtanim_chbankabilgi", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(255)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.Ibanno)
                .HasMaxLength(255)
                .HasColumnName("IBANNO");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Subeisim)
                .HasMaxLength(255)
                .HasColumnName("SUBEISIM");
            entity.Property(e => e.Subekod)
                .HasMaxLength(255)
                .HasColumnName("SUBEKOD");
        });

        modelBuilder.Entity<ChtanimChemanet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_chemanet");

            entity.ToTable("chtanim_chemanet", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Baslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIH");
            entity.Property(e => e.Bitistarih)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIH");
            entity.Property(e => e.Bitistarihvar).HasColumnName("BITISTARIHVAR");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Emanetid).HasColumnName("EMANETID");
            entity.Property(e => e.Marka)
                .HasMaxLength(255)
                .HasColumnName("MARKA");
            entity.Property(e => e.Model)
                .HasMaxLength(255)
                .HasColumnName("MODEL");
            entity.Property(e => e.Resim1)
                .HasColumnType("image")
                .HasColumnName("RESIM1");
            entity.Property(e => e.Resim2)
                .HasColumnType("image")
                .HasColumnName("RESIM2");
            entity.Property(e => e.Resim3)
                .HasColumnType("image")
                .HasColumnName("RESIM3");
            entity.Property(e => e.Resim4)
                .HasColumnType("image")
                .HasColumnName("RESIM4");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
        });

        modelBuilder.Entity<ChtanimChgrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_chgrup");

            entity.ToTable("chtanim_chgrup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<ChtanimChgrupdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_chgrupdetay");

            entity.ToTable("chtanim_chgrupdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chgrupid).HasColumnName("CHGRUPID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
        });

        modelBuilder.Entity<ChtanimChiletisim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_chiletisim");

            entity.ToTable("chtanim_chiletisim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Deger).HasColumnName("DEGER");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<ChtanimChnot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_chnot");

            entity.ToTable("chtanim_chnot", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<ChtanimGg>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_gg");

            entity.ToTable("chtanim_gg", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Kalemozelkodvar).HasColumnName("KALEMOZELKODVAR");
            entity.Property(e => e.Karttip).HasColumnName("KARTTIP");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kategori4id).HasColumnName("KATEGORI4ID");
            entity.Property(e => e.Kategori5id).HasColumnName("KATEGORI5ID");
            entity.Property(e => e.Kdvmuhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("KDVMUHASEBEKODU");
            entity.Property(e => e.LedmuhHesapid).HasColumnName("LEDMUH_HESAPID");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD");
        });

        modelBuilder.Entity<ChtanimGgkalem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_ggkalem");

            entity.ToTable("chtanim_ggkalem", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<ChtanimGidergrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_gidergrup");

            entity.ToTable("chtanim_gidergrup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<ChtanimGidergrupdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_gidergrupdetay");

            entity.ToTable("chtanim_gidergrupdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Gidergrupid).HasColumnName("GIDERGRUPID");
        });

        modelBuilder.Entity<ChtanimK>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_ks");

            entity.ToTable("chtanim_ks", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.LedmuhHesapid).HasColumnName("LEDMUH_HESAPID");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
        });

        modelBuilder.Entity<ChtanimKk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_kk");

            entity.ToTable("chtanim_kk", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Banka)
                .HasMaxLength(255)
                .HasColumnName("BANKA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Hesapkesim).HasColumnName("HESAPKESIM");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(100)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.LedmuhHesapid).HasColumnName("LEDMUH_HESAPID");
            entity.Property(e => e.Limit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LIMIT");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Sonodeme).HasColumnName("SONODEME");
            entity.Property(e => e.Sube)
                .HasMaxLength(255)
                .HasColumnName("SUBE");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(100)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkilitel)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL");
        });

        modelBuilder.Entity<ChtanimP>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_ps");

            entity.ToTable("chtanim_ps", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Banka)
                .HasMaxLength(255)
                .HasColumnName("BANKA");
            entity.Property(e => e.Bankaid).HasColumnName("BANKAID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Gelirgiderid).HasColumnName("GELIRGIDERID");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(100)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.LedmuhHesapid).HasColumnName("LEDMUH_HESAPID");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Sanalpos).HasColumnName("SANALPOS");
            entity.Property(e => e.SanalposKullaniciadi)
                .HasMaxLength(400)
                .HasColumnName("SANALPOS_KULLANICIADI");
            entity.Property(e => e.SanalposLink)
                .HasMaxLength(4000)
                .HasColumnName("SANALPOS_LINK");
            entity.Property(e => e.SanalposSifre)
                .HasMaxLength(400)
                .HasColumnName("SANALPOS_SIFRE");
            entity.Property(e => e.Sube)
                .HasMaxLength(255)
                .HasColumnName("SUBE");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(255)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkilitel)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL");
        });

        modelBuilder.Entity<ChtanimPersonel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_personel");

            entity.ToTable("chtanim_personel", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres).HasColumnName("ADRES");
            entity.Property(e => e.Agi)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AGI");
            entity.Property(e => e.Agigiderid).HasColumnName("AGIGIDERID");
            entity.Property(e => e.Ailecocuksayisi).HasColumnName("AILECOCUKSAYISI");
            entity.Property(e => e.Ailecocukvar).HasColumnName("AILECOCUKVAR");
            entity.Property(e => e.Ailekisisayisi).HasColumnName("AILEKISISAYISI");
            entity.Property(e => e.Anaadi)
                .HasMaxLength(100)
                .HasColumnName("ANAADI");
            entity.Property(e => e.Aracmarkamodel)
                .HasMaxLength(255)
                .HasColumnName("ARACMARKAMODEL");
            entity.Property(e => e.Askerlik)
                .HasMaxLength(50)
                .HasColumnName("ASKERLIK");
            entity.Property(e => e.Askerlikaciklama)
                .HasMaxLength(255)
                .HasColumnName("ASKERLIKACIKLAMA");
            entity.Property(e => e.Babaadi)
                .HasMaxLength(100)
                .HasColumnName("BABAADI");
            entity.Property(e => e.Beden)
                .HasMaxLength(100)
                .HasColumnName("BEDEN");
            entity.Property(e => e.Boy)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("BOY");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Departmanid).HasColumnName("DEPARTMANID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Dogumtarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOGUMTARIHI");
            entity.Property(e => e.Dogumyeri)
                .HasMaxLength(100)
                .HasColumnName("DOGUMYERI");
            entity.Property(e => e.Ebelgekullan)
                .HasMaxLength(4)
                .HasColumnName("EBELGEKULLAN");
            entity.Property(e => e.Egitimdurum)
                .HasMaxLength(3)
                .HasColumnName("EGITIMDURUM");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(100)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Eposta)
                .HasMaxLength(100)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Eposta2)
                .HasMaxLength(100)
                .HasColumnName("EPOSTA2");
            entity.Property(e => e.Evdurum)
                .HasMaxLength(100)
                .HasColumnName("EVDURUM");
            entity.Property(e => e.Evliliktarih)
                .HasColumnType("datetime")
                .HasColumnName("EVLILIKTARIH");
            entity.Property(e => e.Facebook)
                .HasMaxLength(100)
                .HasColumnName("FACEBOOK");
            entity.Property(e => e.Fotograf)
                .HasColumnType("image")
                .HasColumnName("FOTOGRAF");
            entity.Property(e => e.Googleplus)
                .HasMaxLength(100)
                .HasColumnName("GOOGLEPLUS");
            entity.Property(e => e.Gorevid).HasColumnName("GOREVID");
            entity.Property(e => e.Instagram)
                .HasMaxLength(100)
                .HasColumnName("INSTAGRAM");
            entity.Property(e => e.Isayrilisneden)
                .HasMaxLength(255)
                .HasColumnName("ISAYRILISNEDEN");
            entity.Property(e => e.Isbaslangicsaat)
                .HasMaxLength(20)
                .HasColumnName("ISBASLANGICSAAT");
            entity.Property(e => e.Isbitissaat)
                .HasMaxLength(20)
                .HasColumnName("ISBITISSAAT");
            entity.Property(e => e.Iscikistarih)
                .HasColumnType("datetime")
                .HasColumnName("ISCIKISTARIH");
            entity.Property(e => e.Isgiristarih)
                .HasColumnType("datetime")
                .HasColumnName("ISGIRISTARIH");
            entity.Property(e => e.Istenciktimi).HasColumnName("ISTENCIKTIMI");
            entity.Property(e => e.Kangrubu)
                .HasMaxLength(2)
                .HasColumnName("KANGRUBU");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kilo)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("KILO");
            entity.Property(e => e.LedmuhPersonelhesapid).HasColumnName("LEDMUH_PERSONELHESAPID");
            entity.Property(e => e.Linkedin)
                .HasMaxLength(100)
                .HasColumnName("LINKEDIN");
            entity.Property(e => e.Maas)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MAAS");
            entity.Property(e => e.Maasgiderid).HasColumnName("MAASGIDERID");
            entity.Property(e => e.Medenihali).HasColumnName("MEDENIHALI");
            entity.Property(e => e.Muhasebekod)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBEKOD");
            entity.Property(e => e.Okul)
                .HasMaxLength(255)
                .HasColumnName("OKUL");
            entity.Property(e => e.Oncekiis).HasColumnName("ONCEKIIS");
            entity.Property(e => e.Referans)
                .HasMaxLength(255)
                .HasColumnName("REFERANS");
            entity.Property(e => e.Sgkno)
                .HasMaxLength(100)
                .HasColumnName("SGKNO");
            entity.Property(e => e.Sicilno)
                .HasMaxLength(100)
                .HasColumnName("SICILNO");
            entity.Property(e => e.Sosyalmedyakullanimi).HasColumnName("SOSYALMEDYAKULLANIMI");
            entity.Property(e => e.Tckn)
                .HasMaxLength(100)
                .HasColumnName("TCKN");
            entity.Property(e => e.Teciltarih)
                .HasColumnType("datetime")
                .HasColumnName("TECILTARIH");
            entity.Property(e => e.Tel1)
                .HasMaxLength(50)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(50)
                .HasColumnName("TEL2");
            entity.Property(e => e.Tel3)
                .HasMaxLength(50)
                .HasColumnName("TEL3");
            entity.Property(e => e.Terhistarih)
                .HasColumnType("datetime")
                .HasColumnName("TERHISTARIH");
            entity.Property(e => e.Twitter)
                .HasMaxLength(100)
                .HasColumnName("TWITTER");
        });

        modelBuilder.Entity<ChtanimPortfoy>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_portfoy");

            entity.ToTable("chtanim_portfoy", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bankaid).HasColumnName("BANKAID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.LedmuhHesapid).HasColumnName("LEDMUH_HESAPID");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
        });

        modelBuilder.Entity<ChtanimPosgrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_posgrup");

            entity.ToTable("chtanim_posgrup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<ChtanimPosgrupdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_posgrupdetay");

            entity.ToTable("chtanim_posgrupdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Posgrupid).HasColumnName("POSGRUPID");
        });

        modelBuilder.Entity<ChtanimPsAnlasma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_ps_anlasma");

            entity.ToTable("chtanim_ps_anlasma", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Kesinti)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("KESINTI");
            entity.Property(e => e.Posid).HasColumnName("POSID");
            entity.Property(e => e.Vadegun).HasColumnName("VADEGUN");
        });

        modelBuilder.Entity<ChtanimTeminatmektup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_teminatmektup");

            entity.ToTable("chtanim_teminatmektup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Banka).HasColumnName("BANKA");
            entity.Property(e => e.Bankasube).HasColumnName("BANKASUBE");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Gorsel)
                .HasColumnType("image")
                .HasColumnName("GORSEL");
            entity.Property(e => e.Konu).HasColumnName("KONU");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Teminattip)
                .HasMaxLength(10)
                .HasColumnName("TEMINATTIP");
            entity.Property(e => e.Teminatyonu)
                .HasMaxLength(10)
                .HasColumnName("TEMINATYONU");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
        });

        modelBuilder.Entity<ChtanimTeminatmektupHukumluluk>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_chtanim_teminatmektup_hukumluluk");

            entity.ToTable("chtanim_teminatmektup_hukumluluk", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hukumluluk).HasColumnName("HUKUMLULUK");
            entity.Property(e => e.Teminatmektupid).HasColumnName("TEMINATMEKTUPID");
        });

        modelBuilder.Entity<Cv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_cv");

            entity.ToTable("cv", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adi)
                .HasMaxLength(255)
                .HasColumnName("ADI");
            entity.Property(e => e.Adres).HasColumnName("ADRES");
            entity.Property(e => e.Ceptel)
                .HasMaxLength(100)
                .HasColumnName("CEPTEL");
            entity.Property(e => e.Cv1).HasColumnName("CV");
            entity.Property(e => e.Dusunceler).HasColumnName("DUSUNCELER");
            entity.Property(e => e.Evtel)
                .HasMaxLength(100)
                .HasColumnName("EVTEL");
            entity.Property(e => e.Il)
                .HasMaxLength(255)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(255)
                .HasColumnName("ILCE");
            entity.Property(e => e.Notlar).HasColumnName("NOTLAR");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("RESIM");
            entity.Property(e => e.Soyadi)
                .HasMaxLength(255)
                .HasColumnName("SOYADI");
            entity.Property(e => e.Tckimlikno)
                .HasMaxLength(100)
                .HasColumnName("TCKIMLIKNO");
        });

        modelBuilder.Entity<CvCalisma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_cv_calisma");

            entity.ToTable("cv_calisma", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Calismasure)
                .HasMaxLength(255)
                .HasColumnName("CALISMASURE");
            entity.Property(e => e.Cvid).HasColumnName("CVID");
            entity.Property(e => e.Departman)
                .HasMaxLength(255)
                .HasColumnName("DEPARTMAN");
            entity.Property(e => e.Firma)
                .HasMaxLength(255)
                .HasColumnName("FIRMA");
            entity.Property(e => e.Gorev)
                .HasMaxLength(255)
                .HasColumnName("GOREV");
        });

        modelBuilder.Entity<CvEgitim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_cv_egitim");

            entity.ToTable("cv_egitim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bolum)
                .HasMaxLength(255)
                .HasColumnName("BOLUM");
            entity.Property(e => e.Cvid).HasColumnName("CVID");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Okul)
                .HasMaxLength(255)
                .HasColumnName("OKUL");
        });

        modelBuilder.Entity<Degisimfi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_degisimfis");

            entity.ToTable("degisimfis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Udid).HasColumnName("UDID");
        });

        modelBuilder.Entity<DegisimfisDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_degisimfis_detay");

            entity.ToTable("degisimfis_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Degisimfisid).HasColumnName("DEGISIMFISID");
            entity.Property(e => e.Degisimpartino)
                .HasMaxLength(100)
                .HasColumnName("DEGISIMPARTINO");
            entity.Property(e => e.Iadesebepid).HasColumnName("IADESEBEPID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Deposipari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_deposiparis");

            entity.ToTable("deposiparis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Depohareketid).HasColumnName("DEPOHAREKETID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Durum)
                .HasMaxLength(2)
                .HasColumnName("DURUM");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.PerSiparisplandetayid).HasColumnName("PER_SIPARISPLANDETAYID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkedildi).HasColumnName("SEVKEDILDI");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Teslimtarih)
                .HasColumnType("datetime")
                .HasColumnName("TESLIMTARIH");
            entity.Property(e => e.Udid).HasColumnName("UDID");
        });

        modelBuilder.Entity<DeposiparisDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_deposiparis_detay");

            entity.ToTable("deposiparis_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Deposiparisid).HasColumnName("DEPOSIPARISID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<Depotanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotanim");

            entity.ToTable("depotanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aciklama2)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA2");
            entity.Property(e => e.Adres)
                .HasMaxLength(400)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Depohareketonaytip)
                .HasMaxLength(10)
                .HasColumnName("DEPOHAREKETONAYTIP");
            entity.Property(e => e.Depotip).HasColumnName("DEPOTIP");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(100)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Fiyatkriter).HasColumnName("FIYATKRITER");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Il)
                .HasMaxLength(255)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(255)
                .HasColumnName("ILCE");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasComment("Depo İsmi")
                .HasColumnName("ISIM");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasComment("Depo Kodu")
                .HasColumnName("KOD");
            entity.Property(e => e.Ozelkod1)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD1");
            entity.Property(e => e.Ozelkod2)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD2");
            entity.Property(e => e.Ozelkod3)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD3");
            entity.Property(e => e.Plasiyerad)
                .HasMaxLength(255)
                .HasColumnName("PLASIYERAD");
            entity.Property(e => e.Plasiyeraracplaka)
                .HasMaxLength(50)
                .HasColumnName("PLASIYERARACPLAKA");
            entity.Property(e => e.Plasiyersoyad)
                .HasMaxLength(255)
                .HasColumnName("PLASIYERSOYAD");
            entity.Property(e => e.Plasiyertckn)
                .HasMaxLength(11)
                .HasColumnName("PLASIYERTCKN");
            entity.Property(e => e.Postakodu)
                .HasMaxLength(5)
                .HasColumnName("POSTAKODU");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .HasColumnName("TEL");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(50)
                .HasColumnName("VERGIDAIRE");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .HasColumnName("VERGINO");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(100)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkilitel1)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL1");
            entity.Property(e => e.Yetkilitel2)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL2");
        });

        modelBuilder.Entity<DepotanimAdre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotanim_adres");

            entity.ToTable("depotanim_adres", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Barkod)
                .HasMaxLength(100)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<DepotanimDepogrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotanim_depogrup");

            entity.ToTable("depotanim_depogrup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<DepotanimDepogrupdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotanim_depogrupdetay");

            entity.ToTable("depotanim_depogrupdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Depogrupid).HasColumnName("DEPOGRUPID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
        });

        modelBuilder.Entity<Depotransfer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotransfer");

            entity.ToTable("depotransfer", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Deposiparisid).HasColumnName("DEPOSIPARISID");
            entity.Property(e => e.Eirsaliyedegil).HasColumnName("EIRSALIYEDEGIL");
            entity.Property(e => e.Eirsaliyeno)
                .HasMaxLength(16)
                .HasColumnName("EIRSALIYENO");
            entity.Property(e => e.Eirsaliyetip)
                .HasMaxLength(50)
                .HasColumnName("EIRSALIYETIP");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.FiloAracid).HasColumnName("FILO_ARACID");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Hedefdepoid)
                .HasComment("depotanim.ID")
                .HasColumnName("HEDEFDEPOID");
            entity.Property(e => e.Kaynakdepoid)
                .HasComment("depotanim.ID")
                .HasColumnName("KAYNAKDEPOID");
            entity.Property(e => e.Onaylandi)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("ONAYLANDI");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Teslimsaat)
                .HasColumnType("datetime")
                .HasColumnName("TESLIMSAAT");
            entity.Property(e => e.Teslimtarih)
                .HasColumnType("datetime")
                .HasColumnName("TESLIMTARIH");
            entity.Property(e => e.Teslimtarihvar).HasColumnName("TESLIMTARIHVAR");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");

            entity.HasOne(d => d.Hedefdepo).WithMany(p => p.DepotransferHedefdepos)
                .HasForeignKey(d => d.Hedefdepoid)
                .HasConstraintName("FK_depotransfer_depotanim1");

            entity.HasOne(d => d.Kaynakdepo).WithMany(p => p.DepotransferKaynakdepos)
                .HasForeignKey(d => d.Kaynakdepoid)
                .HasConstraintName("FK_depotransfer_depotanim");
        });

        modelBuilder.Entity<DepotransferBarkoddetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotransfer_barkoddetay");

            entity.ToTable("depotransfer_barkoddetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barkod)
                .HasMaxLength(100)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Depotransferid).HasColumnName("DEPOTRANSFERID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Skt)
                .HasColumnType("datetime")
                .HasColumnName("SKT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<DepotransferDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotransfer_detay");

            entity.ToTable("depotransfer_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ambalajbirim)
                .HasMaxLength(100)
                .HasColumnName("AMBALAJBIRIM");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birim2)
                .HasMaxLength(50)
                .HasColumnName("BIRIM2");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depotransferid).HasColumnName("DEPOTRANSFERID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyat2)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("FIYAT2");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Miktar2)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR2");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Serinolar)
                .HasColumnType("xml")
                .HasColumnName("SERINOLAR");
            entity.Property(e => e.Skt)
                .HasColumnType("datetime")
                .HasColumnName("SKT");
            entity.Property(e => e.Stokid)
                .HasComment("stoktanim.ID")
                .HasColumnName("STOKID");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");

            entity.HasOne(d => d.Depotransfer).WithMany(p => p.DepotransferDetays)
                .HasForeignKey(d => d.Depotransferid)
                .HasConstraintName("FK_LAF_led_depotransfer_detay_DEPOTRANSFERID");

            entity.HasOne(d => d.Stok).WithMany(p => p.DepotransferDetays)
                .HasForeignKey(d => d.Stokid)
                .HasConstraintName("FK_depotransfer_detay_stoktanim");
        });

        modelBuilder.Entity<DepotransferSevkiyat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotransfer_sevkiyat");

            entity.ToTable("depotransfer_sevkiyat", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Depotransferid).HasColumnName("DEPOTRANSFERID");
            entity.Property(e => e.SevkiyatAd)
                .HasMaxLength(255)
                .HasColumnName("SEVKIYAT_AD");
            entity.Property(e => e.SevkiyatPlaka)
                .HasMaxLength(100)
                .HasColumnName("SEVKIYAT_PLAKA");
            entity.Property(e => e.SevkiyatSoyad)
                .HasMaxLength(255)
                .HasColumnName("SEVKIYAT_SOYAD");
            entity.Property(e => e.SevkiyatTasiyicichid).HasColumnName("SEVKIYAT_TASIYICICHID");
            entity.Property(e => e.SevkiyatTasiyiciunvan)
                .HasMaxLength(255)
                .HasColumnName("SEVKIYAT_TASIYICIUNVAN");
            entity.Property(e => e.SevkiyatTasiyicivkn)
                .HasMaxLength(100)
                .HasColumnName("SEVKIYAT_TASIYICIVKN");
            entity.Property(e => e.SevkiyatTckn)
                .HasMaxLength(100)
                .HasColumnName("SEVKIYAT_TCKN");
        });

        modelBuilder.Entity<DepotransferTumdepoirsaliyedetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_depotransfer_tumdepoirsaliyedetay");

            entity.ToTable("depotransfer_tumdepoirsaliyedetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depotransferid).HasColumnName("DEPOTRANSFERID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Dovizkur>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_dovizkur");

            entity.ToTable("dovizkur", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Emanettanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_emanettanim");

            entity.ToTable("emanettanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim).HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Excelcari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_excelcari");

            entity.ToTable("excelcari", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.B2bkullaniciadi)
                .HasMaxLength(100)
                .HasColumnName("B2BKULLANICIADI");
            entity.Property(e => e.B2bparola)
                .HasMaxLength(100)
                .HasColumnName("B2BPAROLA");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan10)
                .HasMaxLength(255)
                .HasColumnName("EKALAN10");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3)
                .HasMaxLength(255)
                .HasColumnName("EKALAN3");
            entity.Property(e => e.Ekalan4)
                .HasMaxLength(255)
                .HasColumnName("EKALAN4");
            entity.Property(e => e.Ekalan5)
                .HasMaxLength(255)
                .HasColumnName("EKALAN5");
            entity.Property(e => e.Ekalan6)
                .HasMaxLength(255)
                .HasColumnName("EKALAN6");
            entity.Property(e => e.Ekalan7)
                .HasMaxLength(255)
                .HasColumnName("EKALAN7");
            entity.Property(e => e.Ekalan8)
                .HasMaxLength(255)
                .HasColumnName("EKALAN8");
            entity.Property(e => e.Ekalan9)
                .HasMaxLength(255)
                .HasColumnName("EKALAN9");
            entity.Property(e => e.Entegrasyonkod1)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD1");
            entity.Property(e => e.Entegrasyonkod2)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD2");
            entity.Property(e => e.Entegrasyonkod3)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD3");
            entity.Property(e => e.Eposta)
                .HasMaxLength(50)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .HasColumnName("FAX");
            entity.Property(e => e.Fiyatkriteri).HasColumnName("FIYATKRITERI");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Il)
                .HasMaxLength(50)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ILCE");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Kategoriaciklama1)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA1");
            entity.Property(e => e.Kategoriaciklama2)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA2");
            entity.Property(e => e.Kategoriaciklama3)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA3");
            entity.Property(e => e.Kategoriaciklama4)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA4");
            entity.Property(e => e.Kategoriaciklama5)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA5");
            entity.Property(e => e.Kategorikod1)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD1");
            entity.Property(e => e.Kategorikod2)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD2");
            entity.Property(e => e.Kategorikod3)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD3");
            entity.Property(e => e.Kategorikod4)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD4");
            entity.Property(e => e.Kategorikod5)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD5");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Kdvkriteri).HasColumnName("KDVKRITERI");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Kredilimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KREDILIMIT");
            entity.Property(e => e.Muafiyet).HasColumnName("MUAFIYET");
            entity.Property(e => e.Musterimuhasebekodu)
                .HasMaxLength(50)
                .HasColumnName("MUSTERIMUHASEBEKODU");
            entity.Property(e => e.Risklimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RISKLIMIT");
            entity.Property(e => e.Saticimuhasebekodu)
                .HasMaxLength(50)
                .HasColumnName("SATICIMUHASEBEKODU");
            entity.Property(e => e.Stokiskonto1var).HasColumnName("STOKISKONTO1VAR");
            entity.Property(e => e.Stokiskonto2var).HasColumnName("STOKISKONTO2VAR");
            entity.Property(e => e.Stokiskonto3var).HasColumnName("STOKISKONTO3VAR");
            entity.Property(e => e.Tapdkno)
                .HasMaxLength(50)
                .HasColumnName("TAPDKNO");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(100)
                .HasColumnName("TEL2");
            entity.Property(e => e.Ticarisicilno)
                .HasMaxLength(50)
                .HasColumnName("TICARISICILNO");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(50)
                .HasColumnName("VERGIDAIRE");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .HasColumnName("VERGINO");
            entity.Property(e => e.Web)
                .HasMaxLength(50)
                .HasColumnName("WEB");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(50)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkiliadres)
                .HasMaxLength(255)
                .HasColumnName("YETKILIADRES");
            entity.Property(e => e.Zorunluparabirimi).HasColumnName("ZORUNLUPARABIRIMI");
        });

        modelBuilder.Entity<Excelstok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_excelstok");

            entity.ToTable("excelstok", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Ambalajbirim)
                .HasMaxLength(100)
                .HasColumnName("AMBALAJBIRIM");
            entity.Property(e => e.Ambalajkullanim).HasColumnName("AMBALAJKULLANIM");
            entity.Property(e => e.Barkod1)
                .HasMaxLength(100)
                .HasColumnName("BARKOD1");
            entity.Property(e => e.Barkod10)
                .HasMaxLength(100)
                .HasColumnName("BARKOD10");
            entity.Property(e => e.Barkod2)
                .HasMaxLength(100)
                .HasColumnName("BARKOD2");
            entity.Property(e => e.Barkod3)
                .HasMaxLength(100)
                .HasColumnName("BARKOD3");
            entity.Property(e => e.Barkod4)
                .HasMaxLength(100)
                .HasColumnName("BARKOD4");
            entity.Property(e => e.Barkod5)
                .HasMaxLength(100)
                .HasColumnName("BARKOD5");
            entity.Property(e => e.Barkod6)
                .HasMaxLength(100)
                .HasColumnName("BARKOD6");
            entity.Property(e => e.Barkod7)
                .HasMaxLength(100)
                .HasColumnName("BARKOD7");
            entity.Property(e => e.Barkod8)
                .HasMaxLength(100)
                .HasColumnName("BARKOD8");
            entity.Property(e => e.Barkod9)
                .HasMaxLength(100)
                .HasColumnName("BARKOD9");
            entity.Property(e => e.Birim)
                .HasMaxLength(100)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(5)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kategoriaciklama1)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA1");
            entity.Property(e => e.Kategoriaciklama2)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA2");
            entity.Property(e => e.Kategoriaciklama3)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA3");
            entity.Property(e => e.Kategoriaciklama4)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA4");
            entity.Property(e => e.Kategoriaciklama5)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA5");
            entity.Property(e => e.Kategoriaciklama6)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA6");
            entity.Property(e => e.Kategoriaciklama7)
                .HasMaxLength(255)
                .HasColumnName("KATEGORIACIKLAMA7");
            entity.Property(e => e.Kategorikod1)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD1");
            entity.Property(e => e.Kategorikod2)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD2");
            entity.Property(e => e.Kategorikod3)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD3");
            entity.Property(e => e.Kategorikod4)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD4");
            entity.Property(e => e.Kategorikod5)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD5");
            entity.Property(e => e.Kategorikod6)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD6");
            entity.Property(e => e.Kategorikod7)
                .HasMaxLength(100)
                .HasColumnName("KATEGORIKOD7");
            entity.Property(e => e.Kdvyuzde).HasColumnName("KDVYUZDE");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.MuhasebeAlisiade).HasColumnName("MUHASEBE_ALISIADE");
            entity.Property(e => e.MuhasebeAliskod)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBE_ALISKOD");
            entity.Property(e => e.MuhasebeIndirilenkdv)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBE_INDIRILENKDV");
            entity.Property(e => e.MuhasebeKod1)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBE_KOD1");
            entity.Property(e => e.MuhasebeKod2)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBE_KOD2");
            entity.Property(e => e.MuhasebeSatisiade)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBE_SATISIADE");
            entity.Property(e => e.MuhasebeSatiskdv)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBE_SATISKDV");
            entity.Property(e => e.MuhasebeSatiskod)
                .HasMaxLength(50)
                .HasColumnName("MUHASEBE_SATISKOD");
            entity.Property(e => e.PerakendekdvYuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PERAKENDEKDV_YUZDE");
            entity.Property(e => e.Tip).HasColumnName("TIP");
        });

        modelBuilder.Entity<Fatura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura");

            entity.ToTable("fatura", "led", tb => tb.HasTrigger("tg_fatura_update"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarildi).HasColumnName("AKTARILDI");
            entity.Property(e => e.Bagkur)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BAGKUR");
            entity.Property(e => e.Birlesmisfatura).HasColumnName("BIRLESMISFATURA");
            entity.Property(e => e.Borsa)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BORSA");
            entity.Property(e => e.Chid)
                .HasComment("chtanim.ID")
                .HasColumnName("CHID");
            entity.Property(e => e.Depoid)
                .HasComment("depotanim.ID")
                .HasColumnName("DEPOID");
            entity.Property(e => e.Detayaciklama).HasColumnName("DETAYACIKLAMA");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Earsivno)
                .HasMaxLength(16)
                .HasColumnName("EARSIVNO");
            entity.Property(e => e.Efaturano)
                .HasMaxLength(16)
                .HasColumnName("EFATURANO");
            entity.Property(e => e.Eirsaliyeno)
                .HasMaxLength(16)
                .HasColumnName("EIRSALIYENO");
            entity.Property(e => e.Eirsaliyetip)
                .HasMaxLength(50)
                .HasColumnName("EIRSALIYETIP");
            entity.Property(e => e.Ekmaliyettip)
                .HasMaxLength(10)
                .HasColumnName("EKMALIYETTIP");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.FarkKdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FARK_KDV");
            entity.Property(e => e.FarkMatrah)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FARK_MATRAH");
            entity.Property(e => e.FarkToplam)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FARK_TOPLAM");
            entity.Property(e => e.FiloAracid).HasColumnName("FILO_ARACID");
            entity.Property(e => e.Fiyatliyazdirildi).HasColumnName("FIYATLIYAZDIRILDI");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.HariciAd)
                .HasMaxLength(100)
                .HasColumnName("HARICI_AD");
            entity.Property(e => e.HariciAdres)
                .HasMaxLength(255)
                .HasColumnName("HARICI_ADRES");
            entity.Property(e => e.HariciBilgikullan).HasColumnName("HARICI_BILGIKULLAN");
            entity.Property(e => e.HariciEarsiveposta)
                .HasMaxLength(100)
                .HasColumnName("HARICI_EARSIVEPOSTA");
            entity.Property(e => e.HariciIl)
                .HasMaxLength(100)
                .HasColumnName("HARICI_IL");
            entity.Property(e => e.HariciIlce)
                .HasMaxLength(100)
                .HasColumnName("HARICI_ILCE");
            entity.Property(e => e.HariciPostakodu)
                .HasMaxLength(100)
                .HasColumnName("HARICI_POSTAKODU");
            entity.Property(e => e.HariciSoyad)
                .HasMaxLength(100)
                .HasColumnName("HARICI_SOYAD");
            entity.Property(e => e.HariciTckn)
                .HasMaxLength(11)
                .HasColumnName("HARICI_TCKN");
            entity.Property(e => e.HariciTel)
                .HasMaxLength(100)
                .HasColumnName("HARICI_TEL");
            entity.Property(e => e.HariciUnvan)
                .HasMaxLength(255)
                .HasColumnName("HARICI_UNVAN");
            entity.Property(e => e.HariciVergidaire)
                .HasMaxLength(255)
                .HasColumnName("HARICI_VERGIDAIRE");
            entity.Property(e => e.HariciVergino)
                .HasMaxLength(11)
                .HasColumnName("HARICI_VERGINO");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Iptalaciklama)
                .HasMaxLength(255)
                .HasColumnName("IPTALACIKLAMA");
            entity.Property(e => e.Irsaliyeno)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYENO");
            entity.Property(e => e.Irsaliyetarih)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYETARIH");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Kapalifatura).HasColumnName("KAPALIFATURA");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Lojistikfaturaid).HasColumnName("LOJISTIKFATURAID");
            entity.Property(e => e.Lojistikprojeid).HasColumnName("LOJISTIKPROJEID");
            entity.Property(e => e.Lojistikstokhareketetki).HasColumnName("LOJISTIKSTOKHAREKETETKI");
            entity.Property(e => e.Odemeaciklama)
                .HasMaxLength(255)
                .HasColumnName("ODEMEACIKLAMA");
            entity.Property(e => e.Odemebankahesapid).HasColumnName("ODEMEBANKAHESAPID");
            entity.Property(e => e.Odemechid).HasColumnName("ODEMECHID");
            entity.Property(e => e.Odemetip)
                .HasMaxLength(4)
                .HasColumnName("ODEMETIP");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.PerKasaid).HasColumnName("PER_KASAID");
            entity.Property(e => e.PerPersonelid).HasColumnName("PER_PERSONELID");
            entity.Property(e => e.PerSubeid).HasColumnName("PER_SUBEID");
            entity.Property(e => e.Proformacarietki).HasColumnName("PROFORMACARIETKI");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid)
                .HasComment("led.chtanim_chadres.ID")
                .HasColumnName("SEVKADRESID");
            entity.Property(e => e.Siparisno)
                .HasMaxLength(100)
                .HasColumnName("SIPARISNO");
            entity.Property(e => e.Siparistarih)
                .HasColumnType("datetime")
                .HasColumnName("SIPARISTARIH");
            entity.Property(e => e.Smsgonderildi).HasColumnName("SMSGONDERILDI");
            entity.Property(e => e.Stopaj)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("STOPAJ");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
            entity.Property(e => e.Yuklemeirsaliyeno)
                .HasMaxLength(100)
                .HasColumnName("YUKLEMEIRSALIYENO");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
        });

        modelBuilder.Entity<FaturaBarkoddetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_barkoddetay");

            entity.ToTable("fatura_barkoddetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barkod)
                .HasMaxLength(100)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Skt)
                .HasColumnType("datetime")
                .HasColumnName("SKT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<FaturaDeger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_deger");

            entity.ToTable("fatura_deger", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bagkurtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BAGKURTOPLAM");
            entity.Property(e => e.Borsatoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BORSATOPLAM");
            entity.Property(e => e.Cisk1tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CISK1TUTAR");
            entity.Property(e => e.Cisk2tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CISK2TUTAR");
            entity.Property(e => e.Ekisk1tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK1TUTAR");
            entity.Property(e => e.Ekisk2tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK2TUTAR");
            entity.Property(e => e.Ekisk3tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK3TUTAR");
            entity.Property(e => e.Ekisk4tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK4TUTAR");
            entity.Property(e => e.Ekisk5tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK5TUTAR");
            entity.Property(e => e.Ekisk6tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK6TUTAR");
            entity.Property(e => e.Ekisk7tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK7TUTAR");
            entity.Property(e => e.Faturadetayid).HasColumnName("FATURADETAYID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Iskontotoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTOTOPLAM");
            entity.Property(e => e.Kdvtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KDVTOPLAM");
            entity.Property(e => e.KdvtoplamHam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KDVTOPLAM_HAM");
            entity.Property(e => e.Kisk1tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KISK1TUTAR");
            entity.Property(e => e.Kisk2tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KISK2TUTAR");
            entity.Property(e => e.Kisk3tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KISK3TUTAR");
            entity.Property(e => e.Konaklamatoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KONAKLAMATOPLAM");
            entity.Property(e => e.Maltoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MALTOPLAM");
            entity.Property(e => e.Matrahtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MATRAHTOPLAM");
            entity.Property(e => e.MatrahtoplamHam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MATRAHTOPLAM_HAM");
            entity.Property(e => e.Oivtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("OIVTOPLAM");
            entity.Property(e => e.Otvtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("OTVTOPLAM");
            entity.Property(e => e.Stopajtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("STOPAJTOPLAM");
            entity.Property(e => e.Tevkifattoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TEVKIFATTOPLAM");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<FaturaDetay>(entity =>
        {
            entity.ToTable("fatura_detay", "led", tb =>
                {
                    tb.HasTrigger("tg_faturadetay_delete");
                    tb.HasTrigger("tg_faturadetay_insert");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ambalajbirim)
                .HasMaxLength(50)
                .HasColumnName("AMBALAJBIRIM");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimekmaliyet)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BIRIMEKMALIYET");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Birimmaliyet)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BIRIMMALIYET");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Eiskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO1");
            entity.Property(e => e.Eiskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO2");
            entity.Property(e => e.Eiskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO3");
            entity.Property(e => e.Eiskonto4)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO4");
            entity.Property(e => e.Eiskonto5)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO5");
            entity.Property(e => e.Eiskonto6)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO6");
            entity.Property(e => e.Eiskonto7)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO7");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyatfarkifaturadetayid).HasColumnName("FIYATFARKIFATURADETAYID");
            entity.Property(e => e.Iadesebepid).HasColumnName("IADESEBEPID");
            entity.Property(e => e.IhracatKapadet)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("IHRACAT_KAPADET");
            entity.Property(e => e.IhracatKapcinsi)
                .HasMaxLength(10)
                .HasColumnName("IHRACAT_KAPCINSI");
            entity.Property(e => e.IhracatKapno)
                .HasMaxLength(100)
                .HasColumnName("IHRACAT_KAPNO");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Iskonto4)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO4");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvmuafiyetkod)
                .HasMaxLength(10)
                .HasColumnName("KDVMUAFIYETKOD");
            entity.Property(e => e.Konaklama)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KONAKLAMA");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Oiv)
                .HasComment("Özel İletişim Vergisi")
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OIV");
            entity.Property(e => e.Otv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OTV");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Planlanansatisfiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PLANLANANSATISFIYAT");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Serinolar)
                .HasColumnType("xml")
                .HasColumnName("SERINOLAR");
            entity.Property(e => e.Sevktarih)
                .HasColumnType("datetime")
                .HasColumnName("SEVKTARIH");
            entity.Property(e => e.Skt)
                .HasColumnType("datetime")
                .HasColumnName("SKT");
            entity.Property(e => e.Stokdovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("STOKDOVIZCINSI");
            entity.Property(e => e.Stokdovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("STOKDOVIZKUR");
            entity.Property(e => e.Stokid)
                .HasComment("")
                .HasColumnName("STOKID");
            entity.Property(e => e.Stokvadetarih)
                .HasColumnType("datetime")
                .HasColumnName("STOKVADETARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tevkifat)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TEVKIFAT");
            entity.Property(e => e.Tevkifatkod)
                .HasMaxLength(10)
                .HasColumnName("TEVKIFATKOD");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<FaturaEvrakbaglanti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_evrakbaglanti");

            entity.ToTable("fatura_evrakbaglanti", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Irsaliyeid).HasColumnName("IRSALIYEID");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
        });

        modelBuilder.Entity<FaturaFiyatfarkidetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_fiyatfarkidetay");

            entity.ToTable("fatura_fiyatfarkidetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Faturdetayid).HasColumnName("FATURDETAYID");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<FaturaIhracat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_ihracat");

            entity.ToTable("fatura_ihracat", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracibanka)
                .HasMaxLength(255)
                .HasColumnName("ARACIBANKA");
            entity.Property(e => e.Brutagirlik)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BRUTAGIRLIK");
            entity.Property(e => e.Efaturadovizcevrimkullan).HasColumnName("EFATURADOVIZCEVRIMKULLAN");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Fobtutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FOBTUTAR");
            entity.Property(e => e.Kapadet).HasColumnName("KAPADET");
            entity.Property(e => e.Kapcins)
                .HasMaxLength(2)
                .HasColumnName("KAPCINS");
            entity.Property(e => e.Kapno)
                .HasMaxLength(255)
                .HasColumnName("KAPNO");
            entity.Property(e => e.Konteynerno)
                .HasMaxLength(255)
                .HasColumnName("KONTEYNERNO");
            entity.Property(e => e.Mensei)
                .HasMaxLength(255)
                .HasColumnName("MENSEI");
            entity.Property(e => e.Muhurno)
                .HasMaxLength(100)
                .HasColumnName("MUHURNO");
            entity.Property(e => e.Navlunbedel)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NAVLUNBEDEL");
            entity.Property(e => e.NavlunbedelDovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("NAVLUNBEDEL_DOVIZCINSI");
            entity.Property(e => e.Netagirlik)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NETAGIRLIK");
            entity.Property(e => e.Odemesekli)
                .HasMaxLength(4)
                .HasColumnName("ODEMESEKLI");
            entity.Property(e => e.Plaka)
                .HasMaxLength(100)
                .HasColumnName("PLAKA");
            entity.Property(e => e.Sigortabedel)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SIGORTABEDEL");
            entity.Property(e => e.Tasima)
                .HasMaxLength(2)
                .HasColumnName("TASIMA");
            entity.Property(e => e.Teslimsekli)
                .HasMaxLength(4)
                .HasColumnName("TESLIMSEKLI");
            entity.Property(e => e.Yukleme)
                .HasMaxLength(255)
                .HasColumnName("YUKLEME");
        });

        modelBuilder.Entity<FaturaInternetsati>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_internetsatis");

            entity.ToTable("fatura_internetsatis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.InternetsatisGonderimtarih)
                .HasColumnType("datetime")
                .HasColumnName("INTERNETSATIS_GONDERIMTARIH");
            entity.Property(e => e.InternetsatisOdemesekli)
                .HasMaxLength(100)
                .HasColumnName("INTERNETSATIS_ODEMESEKLI");
            entity.Property(e => e.InternetsatisOdemesekliaraci)
                .HasMaxLength(400)
                .HasColumnName("INTERNETSATIS_ODEMESEKLIARACI");
            entity.Property(e => e.InternetsatisOdemetarih)
                .HasColumnType("datetime")
                .HasColumnName("INTERNETSATIS_ODEMETARIH");
            entity.Property(e => e.InternetsatisTasiyicichid).HasColumnName("INTERNETSATIS_TASIYICICHID");
            entity.Property(e => e.InternetsatisVar).HasColumnName("INTERNETSATIS_VAR");
            entity.Property(e => e.InternetsatisWebadres)
                .HasMaxLength(255)
                .HasColumnName("INTERNETSATIS_WEBADRES");
        });

        modelBuilder.Entity<FaturaMasrafkalem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_masrafkalem");

            entity.ToTable("fatura_masrafkalem", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Borc)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BORC");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutartip)
                .HasMaxLength(2)
                .HasColumnName("TUTARTIP");
        });

        modelBuilder.Entity<FaturaSevkiyat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fatura_sevkiyat");

            entity.ToTable("fatura_sevkiyat", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.SevkiyatAd)
                .HasMaxLength(255)
                .HasColumnName("SEVKIYAT_AD");
            entity.Property(e => e.SevkiyatGsm)
                .HasMaxLength(100)
                .HasColumnName("SEVKIYAT_GSM");
            entity.Property(e => e.SevkiyatPlaka)
                .HasMaxLength(255)
                .HasColumnName("SEVKIYAT_PLAKA");
            entity.Property(e => e.SevkiyatSoyad)
                .HasMaxLength(255)
                .HasColumnName("SEVKIYAT_SOYAD");
            entity.Property(e => e.SevkiyatTckn)
                .HasMaxLength(100)
                .HasColumnName("SEVKIYAT_TCKN");
            entity.Property(e => e.TasiyiciUnvan)
                .HasMaxLength(255)
                .HasColumnName("TASIYICI_UNVAN");
            entity.Property(e => e.TasiyiciVkn)
                .HasMaxLength(100)
                .HasColumnName("TASIYICI_VKN");
        });

        modelBuilder.Entity<Fiyatanlasma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_fiyatanlasma");

            entity.ToTable("fiyatanlasma", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Baslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIH");
            entity.Property(e => e.Bitistarih)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tedarikciid).HasColumnName("TEDARIKCIID");
        });

        modelBuilder.Entity<FiyatanlasmaDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_fiyatanlasma_detay");

            entity.ToTable("fiyatanlasma_detay", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyatanlasmaid).HasColumnName("FIYATANLASMAID");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Iskonto4)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO4");
            entity.Property(e => e.Iskonto5)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO5");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Fiyatliste>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatliste");

            entity.ToTable("fiyatliste", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Carisecimtip).HasColumnName("CARISECIMTIP");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Islemtip)
                .HasMaxLength(4)
                .HasColumnName("ISLEMTIP");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Onay1).HasColumnName("ONAY1");
            entity.Property(e => e.Onay1userid).HasColumnName("ONAY1USERID");
            entity.Property(e => e.Onay2).HasColumnName("ONAY2");
            entity.Property(e => e.Onay2userid).HasColumnName("ONAY2USERID");
            entity.Property(e => e.Ozelkod1)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD1");
            entity.Property(e => e.Ozelkod2)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD2");
            entity.Property(e => e.Ozelkod3)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD3");
            entity.Property(e => e.ReferansCarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("REFERANS_CARPAN");
            entity.Property(e => e.ReferansListeid).HasColumnName("REFERANS_LISTEID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<FiyatlisteAlt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatliste_alt");

            entity.ToTable("fiyatliste_alt", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Ilktarih)
                .HasColumnType("datetime")
                .HasColumnName("ILKTARIH");
            entity.Property(e => e.Ilktarihvar).HasColumnName("ILKTARIHVAR");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Onay1).HasColumnName("ONAY1");
            entity.Property(e => e.Onay1userid).HasColumnName("ONAY1USERID");
            entity.Property(e => e.Onay2).HasColumnName("ONAY2");
            entity.Property(e => e.Onay2userid).HasColumnName("ONAY2USERID");
            entity.Property(e => e.Sevkadressecimtip).HasColumnName("SEVKADRESSECIMTIP");
            entity.Property(e => e.Sontarih)
                .HasColumnType("datetime")
                .HasColumnName("SONTARIH");
            entity.Property(e => e.Sontarihvar).HasColumnName("SONTARIHVAR");
        });

        modelBuilder.Entity<FiyatlisteAltsevkadre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatliste_altsevkadres");

            entity.ToTable("fiyatliste_altsevkadres", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyataltlisteid).HasColumnName("FIYATALTLISTEID");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
        });

        modelBuilder.Entity<FiyatlisteCari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatliste_cari");

            entity.ToTable("fiyatliste_cari", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
        });

        modelBuilder.Entity<FiyatlisteCarigrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatliste_carigrup");

            entity.ToTable("fiyatliste_carigrup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Grupid).HasColumnName("GRUPID");
        });

        modelBuilder.Entity<FiyatlisteCarikategori>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatliste_carikategori");

            entity.ToTable("fiyatliste_carikategori", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Kategoriid).HasColumnName("KATEGORIID");
            entity.Property(e => e.Kategoritip)
                .HasMaxLength(4)
                .HasColumnName("KATEGORITIP");
        });

        modelBuilder.Entity<FiyatlisteDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatliste_detay");

            entity.ToTable("fiyatliste_detay", "led", tb => tb.HasTrigger("tg_fiyatlistedetay_update"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Duzenlemetarih)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEMETARIH");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyataltlisteid).HasColumnName("FIYATALTLISTEID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Maxiskonto)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MAXISKONTO");
            entity.Property(e => e.Oncekifiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ONCEKIFIYAT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Fiyatteklif>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatteklif");

            entity.ToTable("fiyatteklif", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Gecerlilikbaslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("GECERLILIKBASLANGICTARIH");
            entity.Property(e => e.Gecerlilikbitistarih)
                .HasColumnType("datetime")
                .HasColumnName("GECERLILIKBITISTARIH");
            entity.Property(e => e.Kosul).HasColumnName("KOSUL");
            entity.Property(e => e.Notlar).HasColumnName("NOTLAR");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<FiyatteklifDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatteklif_detay");

            entity.ToTable("fiyatteklif_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyatteklifid).HasColumnName("FIYATTEKLIFID");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Iskonto4)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO4");
            entity.Property(e => e.Iskontolufiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTOLUFIYAT");
            entity.Property(e => e.Kdvdahiliskontolufiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KDVDAHILISKONTOLUFIYAT");
            entity.Property(e => e.Kdvyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVYUZDE");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Onerilenfiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ONERILENFIYAT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<FiyatyonetimSablon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatyonetim_sablon");

            entity.ToTable("fiyatyonetim_sablon", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Varsayilan).HasColumnName("VARSAYILAN");
        });

        modelBuilder.Entity<FiyatyonetimSablondetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatyonetim_sablondetay");

            entity.ToTable("fiyatyonetim_sablondetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyataltlisteid).HasColumnName("FIYATALTLISTEID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Sablonid).HasColumnName("SABLONID");
        });

        modelBuilder.Entity<FiyatyonetimStokdeger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_fiyatyonetim_stokdeger");

            entity.ToTable("fiyatyonetim_stokdeger", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Artirimtutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ARTIRIMTUTAR");
            entity.Property(e => e.Artirimyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ARTIRIMYUZDE");
            entity.Property(e => e.Indirimtutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("INDIRIMTUTAR");
            entity.Property(e => e.Indirimyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("INDIRIMYUZDE");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Gecicistokhareket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_gecicistokhareket");

            entity.ToTable("gecicistokhareket", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Barkod)
                .HasMaxLength(100)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Fisid).HasColumnName("FISID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Mobileuserid).HasColumnName("MOBILEUSERID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
            entity.Property(e => e.Tip)
                .HasMaxLength(10)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Giderfi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_giderfis");

            entity.ToTable("giderfis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Kdvtutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<GiderfisDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_giderfis_detay");

            entity.ToTable("giderfis_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Fisid).HasColumnName("FISID");
            entity.Property(e => e.Fisno)
                .HasMaxLength(255)
                .HasColumnName("FISNO");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Hizmetid).HasColumnName("HIZMETID");
            entity.Property(e => e.Kdvoran)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVORAN");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
        });

        modelBuilder.Entity<GrdLayout>(entity =>
        {
            entity.ToTable("grd_layouts", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gridname)
                .HasMaxLength(100)
                .HasColumnName("GRIDNAME");
            entity.Property(e => e.Layoutxml)
                .HasColumnType("xml")
                .HasColumnName("LAYOUTXML");
            entity.Property(e => e.Layoutxmlhash)
                .HasMaxLength(100)
                .HasColumnName("LAYOUTXMLHASH");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Objectcode)
                .HasMaxLength(100)
                .HasColumnName("OBJECTCODE");
            entity.Property(e => e.Objecttype)
                .HasMaxLength(5)
                .HasColumnName("OBJECTTYPE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.ToTable("groups", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<GroupsAuth>(entity =>
        {
            entity.ToTable("groups_auth", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Authoritycode)
                .HasMaxLength(100)
                .HasColumnName("AUTHORITYCODE");
            entity.Property(e => e.Authorityid).HasColumnName("AUTHORITYID");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<GroupsMenu>(entity =>
        {
            entity.ToTable("groups_menu", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Menuitemcode)
                .HasMaxLength(50)
                .HasColumnName("MENUITEMCODE");
            entity.Property(e => e.Show).HasColumnName("SHOW");
        });

        modelBuilder.Entity<GroupsUser>(entity =>
        {
            entity.ToTable("groups_users", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Grup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_grup");

            entity.ToTable("grup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<GrupDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_grup_detay");

            entity.ToTable("grup_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Grupid).HasColumnName("GRUPID");
            entity.Property(e => e.Kartid).HasColumnName("KARTID");
        });

        modelBuilder.Entity<Hatirlatma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_hatirlatma");

            entity.ToTable("hatirlatma", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Hatirlatmatarih)
                .HasColumnType("datetime")
                .HasColumnName("HATIRLATMATARIH");
            entity.Property(e => e.Hatirlatmatarih2)
                .HasColumnType("datetime")
                .HasColumnName("HATIRLATMATARIH2");
            entity.Property(e => e.Hatirlatmatarihtip)
                .HasMaxLength(10)
                .HasColumnName("HATIRLATMATARIHTIP");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Kullanicitip)
                .HasMaxLength(2)
                .HasColumnName("KULLANICITIP");
            entity.Property(e => e.Renk)
                .HasMaxLength(100)
                .HasColumnName("RENK");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Hatirlatmadetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_hatirlatmadetay");

            entity.ToTable("hatirlatmadetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Hatirlatmaid).HasColumnName("HATIRLATMAID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Hedef>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_hedef");

            entity.ToTable("hedef", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Baslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIH");
            entity.Property(e => e.Bitistarih)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIH");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<HedefDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_hedef_detay");

            entity.ToTable("hedef_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Faturavade)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FATURAVADE");
            entity.Property(e => e.Hedefid).HasColumnName("HEDEFID");
            entity.Property(e => e.Satismiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("SATISMIKTAR");
            entity.Property(e => e.Satistutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SATISTUTAR");
            entity.Property(e => e.Tahsilattutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TAHSILATTUTAR");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
        });

        modelBuilder.Entity<Hediyeceki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_hediyeceki");

            entity.ToTable("hediyeceki", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fisid).HasColumnName("FISID");
            entity.Property(e => e.Hediyecekno)
                .HasMaxLength(255)
                .HasColumnName("HEDIYECEKNO");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Iadesebeptanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_iadesebeptanim");

            entity.ToTable("iadesebeptanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim).HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Iskontoliste>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_iskontoliste");

            entity.ToTable("iskontoliste", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<IskontolisteCari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_iskontoliste_cari");

            entity.ToTable("iskontoliste_cari", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Iskontolisteid).HasColumnName("ISKONTOLISTEID");
        });

        modelBuilder.Entity<IskontolisteDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_iskontoliste_detay");

            entity.ToTable("iskontoliste_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<IslemBakim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_bakim");

            entity.ToTable("islem_bakim", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.Carihareketoptip)
                .HasMaxLength(100)
                .HasColumnName("CARIHAREKETOPTIP");
            entity.Property(e => e.Carikart)
                .HasMaxLength(255)
                .HasColumnName("CARIKART");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Chidisim)
                .HasMaxLength(255)
                .HasColumnName("CHIDISIM");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Gosterme).HasColumnName("GOSTERME");
            entity.Property(e => e.IlkKm)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("ILK_KM");
            entity.Property(e => e.SonrakiKm)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("SONRAKI_KM");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<IslemBakimDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_bakim_detay");

            entity.ToTable("islem_bakim_detay", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bakim)
                .HasMaxLength(255)
                .HasColumnName("BAKIM");
            entity.Property(e => e.Bakimid).HasColumnName("BAKIMID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("FIYAT");
        });

        modelBuilder.Entity<IslemCeza>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_ceza");

            entity.ToTable("islem_ceza", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.IndirimTarihi)
                .HasColumnType("datetime")
                .HasColumnName("INDIRIM_TARIHI");
            entity.Property(e => e.Odeme)
                .HasMaxLength(100)
                .HasColumnName("ODEME");
            entity.Property(e => e.SonodemeTarihi)
                .HasColumnType("datetime")
                .HasColumnName("SONODEME_TARIHI");
            entity.Property(e => e.Surucu).HasColumnName("SURUCU");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.TebligTarihi)
                .HasColumnType("datetime")
                .HasColumnName("TEBLIG_TARIHI");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.TutarIndirim)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR_INDIRIM");
        });

        modelBuilder.Entity<IslemKasko>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_kasko");

            entity.ToTable("islem_kasko", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcentaNo)
                .HasMaxLength(255)
                .HasColumnName("ACENTA_NO");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AcilTel)
                .HasMaxLength(255)
                .HasColumnName("ACIL_TEL");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.Carikart)
                .HasMaxLength(255)
                .HasColumnName("CARIKART");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.SigortaYetkili)
                .HasMaxLength(255)
                .HasColumnName("SIGORTA_YETKILI");
            entity.Property(e => e.SigortaYetkiliTel)
                .HasMaxLength(255)
                .HasColumnName("SIGORTA_YETKILI_TEL");
            entity.Property(e => e.Sigortafirma)
                .HasMaxLength(255)
                .HasColumnName("SIGORTAFIRMA");
            entity.Property(e => e.SonrakiTarih)
                .HasColumnType("datetime")
                .HasColumnName("SONRAKI_TARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<IslemMuayene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_muayene");

            entity.ToTable("islem_muayene", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.SonrakiTarih)
                .HasColumnType("datetime")
                .HasColumnName("SONRAKI_TARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<IslemSigortum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_sigorta");

            entity.ToTable("islem_sigorta", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcentaNo)
                .HasMaxLength(255)
                .HasColumnName("ACENTA_NO");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.AcilTel)
                .HasMaxLength(255)
                .HasColumnName("ACIL_TEL");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.Carikart)
                .HasMaxLength(255)
                .HasColumnName("CARIKART");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.SigortaYetkili)
                .HasMaxLength(255)
                .HasColumnName("SIGORTA_YETKILI");
            entity.Property(e => e.SigortaYetkiliTel)
                .HasMaxLength(255)
                .HasColumnName("SIGORTA_YETKILI_TEL");
            entity.Property(e => e.Sigortafirma)
                .HasMaxLength(255)
                .HasColumnName("SIGORTAFIRMA");
            entity.Property(e => e.Sigortatip)
                .HasMaxLength(255)
                .HasColumnName("SIGORTATIP");
            entity.Property(e => e.SonrakiTarih)
                .HasColumnType("datetime")
                .HasColumnName("SONRAKI_TARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<IslemTamir>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_tamir");

            entity.ToTable("islem_tamir", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.Carihareketoptip)
                .HasMaxLength(100)
                .HasColumnName("CARIHAREKETOPTIP");
            entity.Property(e => e.Carikart)
                .HasMaxLength(255)
                .HasColumnName("CARIKART");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Chidisim)
                .HasMaxLength(255)
                .HasColumnName("CHIDISIM");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Muhasebe).HasColumnName("MUHASEBE");
            entity.Property(e => e.Sebep)
                .HasMaxLength(100)
                .HasColumnName("SEBEP");
            entity.Property(e => e.Servistegecensure).HasColumnName("SERVISTEGECENSURE");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<IslemTamirDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_tamir_detay");

            entity.ToTable("islem_tamir_detay", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Tamirid).HasColumnName("TAMIRID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Yapilan)
                .HasMaxLength(255)
                .HasColumnName("YAPILAN");
        });

        modelBuilder.Entity<IslemYolcutasimaizin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_islem_yolcutasimaizin");

            entity.ToTable("islem_yolcutasimaizin", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Belgeno)
                .HasMaxLength(100)
                .HasColumnName("BELGENO");
            entity.Property(e => e.Gecerliliktarih)
                .HasColumnType("datetime")
                .HasColumnName("GECERLILIKTARIH");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tasinanacentaid).HasColumnName("TASINANACENTAID");
        });

        modelBuilder.Entity<Izin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_izin");

            entity.ToTable("izin", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Izlemelink>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_izlemelink");

            entity.ToTable("izlemelink", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Gonderimzaman)
                .HasColumnType("datetime")
                .HasColumnName("GONDERIMZAMAN");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Songecerlilikzaman)
                .HasColumnType("datetime")
                .HasColumnName("SONGECERLILIKZAMAN");
            entity.Property(e => e.Udid).HasColumnName("UDID");
        });

        modelBuilder.Entity<Kampanya>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kampanya");

            entity.ToTable("kampanya", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Carisecimtip).HasColumnName("CARISECIMTIP");
            entity.Property(e => e.Ilktarih)
                .HasColumnType("datetime")
                .HasColumnName("ILKTARIH");
            entity.Property(e => e.Ilktarihvar).HasColumnName("ILKTARIHVAR");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Sontarih)
                .HasColumnType("datetime")
                .HasColumnName("SONTARIH");
            entity.Property(e => e.Sontarihvar).HasColumnName("SONTARIHVAR");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Toplammiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TOPLAMMIKTAR");
        });

        modelBuilder.Entity<KampanyaCaridetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kampanya_caridetay");

            entity.ToTable("kampanya_caridetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
        });

        modelBuilder.Entity<KampanyaCarigrupdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kampanya_carigrupdetay");

            entity.ToTable("kampanya_carigrupdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chgrupid).HasColumnName("CHGRUPID");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
        });

        modelBuilder.Entity<KampanyaCarikategoridetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kampanya_carikategoridetay");

            entity.ToTable("kampanya_carikategoridetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
            entity.Property(e => e.Kategoriid).HasColumnName("KATEGORIID");
            entity.Property(e => e.Kategoritip)
                .HasMaxLength(4)
                .HasColumnName("KATEGORITIP");
        });

        modelBuilder.Entity<KampanyaKosuldetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kampanya_kosuldetay");

            entity.ToTable("kampanya_kosuldetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Minmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MINMIKTAR");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<KampanyaSonucdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kampanya_sonucdetay");

            entity.ToTable("kampanya_sonucdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Kampanyatanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_kampanyatanim");

            entity.ToTable("kampanyatanim", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ilktarih)
                .HasColumnType("datetime")
                .HasColumnName("ILKTARIH");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
            entity.Property(e => e.Sontarih)
                .HasColumnType("datetime")
                .HasColumnName("SONTARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<KampanyatanimK1Haricstok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_kampanyatanim_k1_haricstok");

            entity.ToTable("kampanyatanim_k1_haricstok", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<KampanyatanimK1Kosul>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_kampanyatanim_k1_kosul");

            entity.ToTable("kampanyatanim_k1_kosul", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
            entity.Property(e => e.Toplamtutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TOPLAMTUTAR");
        });

        modelBuilder.Entity<KampanyatanimK1Sonuc>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_kampanyatanim_k1_sonuc");

            entity.ToTable("kampanyatanim_k1_sonuc", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Kampanyaid).HasColumnName("KAMPANYAID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Kasaesitleme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_kasaesitleme");

            entity.ToTable("kasaesitleme", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.BC)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("B_C");
            entity.Property(e => e.BKl).HasColumnName("B_KL");
            entity.Property(e => e.BKw).HasColumnName("B_KW");
            entity.Property(e => e.BM).HasColumnName("B_M");
            entity.Property(e => e.BMc)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("B_MC");
            entity.Property(e => e.BMl).HasColumnName("B_ML");
            entity.Property(e => e.BMw).HasColumnName("B_MW");
            entity.Property(e => e.Barkod)
                .HasMaxLength(30)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birim)
                .HasMaxLength(30)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Goster).HasColumnName("GOSTER");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("GRUP");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.KIsim)
                .HasMaxLength(100)
                .HasColumnName("K_ISIM");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Maxisk)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MAXISK");
            entity.Property(e => e.Plu).HasColumnName("PLU");
            entity.Property(e => e.Sfiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("SFIYAT");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Terazi).HasColumnName("TERAZI");
            entity.Property(e => e.Terazigonder).HasColumnName("TERAZIGONDER");
            entity.Property(e => e.Varyasyon).HasColumnName("VARYASYON");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
            entity.Property(e => e.Veresiyeiskontooran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("VERESIYEISKONTOORAN");
            entity.Property(e => e.Veresiyeiskontostr)
                .HasMaxLength(255)
                .HasColumnName("VERESIYEISKONTOSTR");
            entity.Property(e => e.Veresiyeiskontotip)
                .HasMaxLength(4)
                .HasColumnName("VERESIYEISKONTOTIP");
            entity.Property(e => e.YDk)
                .HasMaxLength(50)
                .HasColumnName("Y_DK");
        });

        modelBuilder.Entity<KasaesitlemeLog>(entity =>
        {
            entity.ToTable("kasaesitleme_log", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barkod)
                .HasMaxLength(100)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Checkdata)
                .HasMaxLength(255)
                .HasColumnName("CHECKDATA");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Kategori>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kategori");

            entity.ToTable("kategori", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Kategori1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_kategori");

            entity.ToTable("kategori", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Kategoriagac>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_kategoriagac");

            entity.ToTable("kategoriagac", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kategoriagacid).HasColumnName("KATEGORIAGACID");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Konumetiket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_konumetiket");

            entity.ToTable("konumetiket", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Kullanicimobilbildirim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_kullanicimobilbildirim");

            entity.ToTable("kullanicimobilbildirim", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Ayar)
                .HasMaxLength(255)
                .HasColumnName("AYAR");
            entity.Property(e => e.Checksum).HasColumnName("CHECKSUM");
            entity.Property(e => e.Kullaniciid).HasColumnName("KULLANICIID");
            entity.Property(e => e.Kullaniciudid)
                .HasMaxLength(50)
                .HasColumnName("KULLANICIUDID");
        });

        modelBuilder.Entity<La>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_las");

            entity.ToTable("las", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Attachmentfilename)
                .HasMaxLength(255)
                .HasColumnName("ATTACHMENTFILENAME");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Conditionsql).HasColumnName("CONDITIONSQL");
            entity.Property(e => e.Datasql).HasColumnName("DATASQL");
            entity.Property(e => e.Frxfile).HasColumnName("FRXFILE");
            entity.Property(e => e.Frxfilehash)
                .HasMaxLength(100)
                .HasColumnName("FRXFILEHASH");
            entity.Property(e => e.Frxfilename)
                .HasMaxLength(255)
                .HasColumnName("FRXFILENAME");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Resultsql).HasColumnName("RESULTSQL");
            entity.Property(e => e.Servicetype)
                .HasMaxLength(4)
                .HasColumnName("SERVICETYPE");
            entity.Property(e => e.Timerule)
                .HasMaxLength(20)
                .HasColumnName("TIMERULE");
        });

        modelBuilder.Entity<LogAuth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_log_auth");

            entity.ToTable("log_auth", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Authcode)
                .HasMaxLength(100)
                .HasColumnName("AUTHCODE");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Detail)
                .HasColumnType("xml")
                .HasColumnName("DETAIL");
            entity.Property(e => e.Modifieduserid).HasColumnName("MODIFIEDUSERID");
            entity.Property(e => e.Newvalue).HasColumnName("NEWVALUE");
            entity.Property(e => e.Oldvalue).HasColumnName("OLDVALUE");
            entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<LogDbexec>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_log_dbexec");

            entity.ToTable("log_dbexec", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Affected).HasColumnName("AFFECTED");
            entity.Property(e => e.Duration).HasColumnName("DURATION");
            entity.Property(e => e.Error).HasColumnName("ERROR");
            entity.Property(e => e.Execdatetime)
                .HasColumnType("datetime")
                .HasColumnName("EXECDATETIME");
            entity.Property(e => e.Rows).HasColumnName("ROWS");
            entity.Property(e => e.Sellength).HasColumnName("SELLENGTH");
            entity.Property(e => e.Selstart).HasColumnName("SELSTART");
            entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");
            entity.Property(e => e.Sqlcode).HasColumnName("SQLCODE");
            entity.Property(e => e.Stopped).HasColumnName("STOPPED");
            entity.Property(e => e.Tables).HasColumnName("TABLES");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<LogIndex>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_log_index");

            entity.ToTable("log_index", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Endtime)
                .HasColumnType("datetime")
                .HasColumnName("ENDTIME");
            entity.Property(e => e.Finalratio)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FINALRATIO");
            entity.Property(e => e.Indexname)
                .HasMaxLength(255)
                .HasColumnName("INDEXNAME");
            entity.Property(e => e.Operation)
                .HasMaxLength(50)
                .HasColumnName("OPERATION");
            entity.Property(e => e.Ratio)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RATIO");
            entity.Property(e => e.Starttime)
                .HasColumnType("datetime")
                .HasColumnName("STARTTIME");
            entity.Property(e => e.Tablename)
                .HasMaxLength(100)
                .HasColumnName("TABLENAME");
        });

        modelBuilder.Entity<LogLaf>(entity =>
        {
            entity.ToTable("log_laf", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Detail)
                .HasColumnType("xml")
                .HasColumnName("DETAIL");
            entity.Property(e => e.Objectcode)
                .HasMaxLength(100)
                .HasColumnName("OBJECTCODE");
            entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            entity.Property(e => e.Operationid).HasColumnName("OPERATIONID");
            entity.Property(e => e.Recordid).HasColumnName("RECORDID");
            entity.Property(e => e.Sessionid).HasColumnName("SESSIONID");
            entity.Property(e => e.Smsgonderildi).HasColumnName("SMSGONDERILDI");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<LogLogin>(entity =>
        {
            entity.ToTable("log_login", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Clientip)
                .HasMaxLength(100)
                .HasColumnName("CLIENTIP");
            entity.Property(e => e.Clientmac)
                .HasMaxLength(50)
                .HasColumnName("CLIENTMAC");
            entity.Property(e => e.Clientwanip)
                .HasMaxLength(50)
                .HasColumnName("CLIENTWANIP");
            entity.Property(e => e.LoginDatetime)
                .HasColumnType("datetime")
                .HasColumnName("LOGIN_DATETIME");
            entity.Property(e => e.LogoutDatetime)
                .HasColumnType("datetime")
                .HasColumnName("LOGOUT_DATETIME");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<LogSm>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_log_sms");

            entity.ToTable("log_sms", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Caption)
                .HasMaxLength(255)
                .HasColumnName("CAPTION");
            entity.Property(e => e.Counter).HasColumnName("COUNTER");
            entity.Property(e => e.Counterused).HasColumnName("COUNTERUSED");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Message).HasColumnName("MESSAGE");
            entity.Property(e => e.Receiver).HasColumnName("RECEIVER");
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("SOURCE");
            entity.Property(e => e.Sourceobj)
                .HasMaxLength(255)
                .HasColumnName("SOURCEOBJ");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<LogWmKeyauth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_log_wm_keyauth");

            entity.ToTable("log_wm_keyauth", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Clu1caption)
                .HasMaxLength(255)
                .HasColumnName("CLU1CAPTION");
            entity.Property(e => e.Clu1id).HasColumnName("CLU1ID");
            entity.Property(e => e.Clu2caption)
                .HasMaxLength(255)
                .HasColumnName("CLU2CAPTION");
            entity.Property(e => e.Clu2id).HasColumnName("CLU2ID");
            entity.Property(e => e.Clu3caption)
                .HasMaxLength(255)
                .HasColumnName("CLU3CAPTION");
            entity.Property(e => e.Clu3id).HasColumnName("CLU3ID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Definition).HasColumnName("DEFINITION");
            entity.Property(e => e.Expiredatetime)
                .HasColumnType("datetime")
                .HasColumnName("EXPIREDATETIME");
            entity.Property(e => e.Keyauthcode)
                .HasMaxLength(100)
                .HasColumnName("KEYAUTHCODE");
            entity.Property(e => e.Mobileuserid).HasColumnName("MOBILEUSERID");
            entity.Property(e => e.Smsgonderildi).HasColumnName("SMSGONDERILDI");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Lojistikprojetanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_lojistikprojetanim");

            entity.ToTable("lojistikprojetanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
            entity.Property(e => e.SiparisnosorFatura)
                .HasMaxLength(10)
                .HasColumnName("SIPARISNOSOR_FATURA");
            entity.Property(e => e.SiparisnosorIrsaliye)
                .HasMaxLength(10)
                .HasColumnName("SIPARISNOSOR_IRSALIYE");
            entity.Property(e => e.Stokhareketetki).HasColumnName("STOKHAREKETETKI");
            entity.Property(e => e.Tumstok).HasColumnName("TUMSTOK");
        });

        modelBuilder.Entity<LojistikprojetanimCari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_lojistikprojetanim_cari");

            entity.ToTable("lojistikprojetanim_cari", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Lojistikprojeid).HasColumnName("LOJISTIKPROJEID");
        });

        modelBuilder.Entity<LojistikprojetanimStok>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_lojistikprojetanim_stok");

            entity.ToTable("lojistikprojetanim_stok", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Lojistikprojeid).HasColumnName("LOJISTIKPROJEID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<LojistikprojetanimTemsilci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_lojistikprojetanim_temsilci");

            entity.ToTable("lojistikprojetanim_temsilci", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Lojistikprojeid).HasColumnName("LOJISTIKPROJEID");
            entity.Property(e => e.Serino)
                .HasMaxLength(3)
                .HasColumnName("SERINO");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
        });

        modelBuilder.Entity<LrfPrintlayout>(entity =>
        {
            entity.ToTable("lrf_printlayouts", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Lrfobjectcode)
                .HasMaxLength(100)
                .HasColumnName("LRFOBJECTCODE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Printlayout).HasColumnName("PRINTLAYOUT");
            entity.Property(e => e.PrintlayoutHash)
                .HasMaxLength(100)
                .HasColumnName("PRINTLAYOUT_HASH");
        });

        modelBuilder.Entity<Maillist>(entity =>
        {
            entity.ToTable("maillist", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<MaillistDetail>(entity =>
        {
            entity.ToTable("maillist_detail", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("EMAIL");
            entity.Property(e => e.Maillistid).HasColumnName("MAILLISTID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Malkabul>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_malkabul");

            entity.ToTable("malkabul", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(256)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Evrakid).HasColumnName("EVRAKID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Udid).HasColumnName("UDID");
        });

        modelBuilder.Entity<MalkabulDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_malkabul_detay");

            entity.ToTable("malkabul_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Malkabulid).HasColumnName("MALKABULID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Skt)
                .HasColumnType("datetime")
                .HasColumnName("SKT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<Masatanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_masatanim");

            entity.ToTable("masatanim", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("GRUP");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Mesaj>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_mesaj");

            entity.ToTable("mesaj", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gondericiid).HasColumnName("GONDERICIID");
            entity.Property(e => e.Mesaj1).HasColumnName("MESAJ");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Mesajdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_mesajdetay");

            entity.ToTable("mesajdetay", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aliciid).HasColumnName("ALICIID");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Mesajid).HasColumnName("MESAJID");
            entity.Property(e => e.Okundu).HasColumnName("OKUNDU");
        });

        modelBuilder.Entity<Mobilbildirimlog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_mobilbildirimlog");

            entity.ToTable("mobilbildirimlog", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Kullanicilar).HasColumnName("KULLANICILAR");
            entity.Property(e => e.Tarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("TARIHSAAT");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<MobileFaturatasarim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_mobile_faturatasarim");

            entity.ToTable("mobile_faturatasarim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AciklamaTxt)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA_TXT");
            entity.Property(e => e.AciklamaVar).HasColumnName("ACIKLAMA_VAR");
            entity.Property(e => e.AciklamaW).HasColumnName("ACIKLAMA_W");
            entity.Property(e => e.AciklamaX).HasColumnName("ACIKLAMA_X");
            entity.Property(e => e.AciklamaY).HasColumnName("ACIKLAMA_Y");
            entity.Property(e => e.AdresTxt)
                .HasMaxLength(255)
                .HasColumnName("ADRES_TXT");
            entity.Property(e => e.AdresVar).HasColumnName("ADRES_VAR");
            entity.Property(e => e.AdresW).HasColumnName("ADRES_W");
            entity.Property(e => e.AdresX).HasColumnName("ADRES_X");
            entity.Property(e => e.AdresY).HasColumnName("ADRES_Y");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.AlttoplamaciklamalariyazVar).HasColumnName("ALTTOPLAMACIKLAMALARIYAZ_VAR");
            entity.Property(e => e.AlttoplambaslangicVar).HasColumnName("ALTTOPLAMBASLANGIC_VAR");
            entity.Property(e => e.BambalajVar).HasColumnName("BAMBALAJ_VAR");
            entity.Property(e => e.BambalajW).HasColumnName("BAMBALAJ_W");
            entity.Property(e => e.BambalajX).HasColumnName("BAMBALAJ_X");
            entity.Property(e => e.BirimVar).HasColumnName("BIRIM_VAR");
            entity.Property(e => e.BirimW).HasColumnName("BIRIM_W");
            entity.Property(e => e.BirimX).HasColumnName("BIRIM_X");
            entity.Property(e => e.BirimalttoplamVar).HasColumnName("BIRIMALTTOPLAM_VAR");
            entity.Property(e => e.BirimambalajalttoplamVar).HasColumnName("BIRIMAMBALAJALTTOPLAM_VAR");
            entity.Property(e => e.Cariiskonto1toplamVar).HasColumnName("CARIISKONTO1TOPLAM_VAR");
            entity.Property(e => e.Cariiskonto1yuzdeVar).HasColumnName("CARIISKONTO1YUZDE_VAR");
            entity.Property(e => e.Cariiskonto2toplamVar).HasColumnName("CARIISKONTO2TOPLAM_VAR");
            entity.Property(e => e.Cariiskonto2yuzdeVar).HasColumnName("CARIISKONTO2YUZDE_VAR");
            entity.Property(e => e.CariiskontotoplamVar).HasColumnName("CARIISKONTOTOPLAM_VAR");
            entity.Property(e => e.CariiskontoyuzdeVar).HasColumnName("CARIISKONTOYUZDE_VAR");
            entity.Property(e => e.CarikodTxt)
                .HasMaxLength(255)
                .HasColumnName("CARIKOD_TXT");
            entity.Property(e => e.CarikodVar).HasColumnName("CARIKOD_VAR");
            entity.Property(e => e.CarikodW).HasColumnName("CARIKOD_W");
            entity.Property(e => e.CarikodX).HasColumnName("CARIKOD_X");
            entity.Property(e => e.CarikodY).HasColumnName("CARIKOD_Y");
            entity.Property(e => e.ChunvanTxt)
                .HasMaxLength(255)
                .HasColumnName("CHUNVAN_TXT");
            entity.Property(e => e.ChunvanVar).HasColumnName("CHUNVAN_VAR");
            entity.Property(e => e.ChunvanW).HasColumnName("CHUNVAN_W");
            entity.Property(e => e.ChunvanX).HasColumnName("CHUNVAN_X");
            entity.Property(e => e.ChunvanY).HasColumnName("CHUNVAN_Y");
            entity.Property(e => e.Ciktitip)
                .HasMaxLength(4)
                .HasColumnName("CIKTITIP");
            entity.Property(e => e.EarsivEvraknoTxt)
                .HasMaxLength(255)
                .HasColumnName("EARSIV_EVRAKNO_TXT");
            entity.Property(e => e.EarsivEvraknoVar).HasColumnName("EARSIV_EVRAKNO_VAR");
            entity.Property(e => e.EarsivEvraknoW).HasColumnName("EARSIV_EVRAKNO_W");
            entity.Property(e => e.EarsivEvraknoX).HasColumnName("EARSIV_EVRAKNO_X");
            entity.Property(e => e.EarsivEvraknoY).HasColumnName("EARSIV_EVRAKNO_Y");
            entity.Property(e => e.EirsaliyeEvraknoTxt)
                .HasMaxLength(255)
                .HasColumnName("EIRSALIYE_EVRAKNO_TXT");
            entity.Property(e => e.EirsaliyeEvraknoVar).HasColumnName("EIRSALIYE_EVRAKNO_VAR");
            entity.Property(e => e.EirsaliyeEvraknoW).HasColumnName("EIRSALIYE_EVRAKNO_W");
            entity.Property(e => e.EirsaliyeEvraknoX).HasColumnName("EIRSALIYE_EVRAKNO_X");
            entity.Property(e => e.EirsaliyeEvraknoY).HasColumnName("EIRSALIYE_EVRAKNO_Y");
            entity.Property(e => e.Ekmetin1Txt)
                .HasMaxLength(255)
                .HasColumnName("EKMETIN1_TXT");
            entity.Property(e => e.Ekmetin1Var).HasColumnName("EKMETIN1_VAR");
            entity.Property(e => e.Ekmetin1W).HasColumnName("EKMETIN1_W");
            entity.Property(e => e.Ekmetin1X).HasColumnName("EKMETIN1_X");
            entity.Property(e => e.Ekmetin1Y).HasColumnName("EKMETIN1_Y");
            entity.Property(e => e.Ekmetin2Txt)
                .HasMaxLength(255)
                .HasColumnName("EKMETIN2_TXT");
            entity.Property(e => e.Ekmetin2Var).HasColumnName("EKMETIN2_VAR");
            entity.Property(e => e.Ekmetin2W).HasColumnName("EKMETIN2_W");
            entity.Property(e => e.Ekmetin2X).HasColumnName("EKMETIN2_X");
            entity.Property(e => e.Ekmetin2Y).HasColumnName("EKMETIN2_Y");
            entity.Property(e => e.Ekmetin3Txt)
                .HasMaxLength(255)
                .HasColumnName("EKMETIN3_TXT");
            entity.Property(e => e.Ekmetin3Var).HasColumnName("EKMETIN3_VAR");
            entity.Property(e => e.Ekmetin3W).HasColumnName("EKMETIN3_W");
            entity.Property(e => e.Ekmetin3X).HasColumnName("EKMETIN3_X");
            entity.Property(e => e.Ekmetin3Y).HasColumnName("EKMETIN3_Y");
            entity.Property(e => e.Ekmetin4Txt)
                .HasMaxLength(255)
                .HasColumnName("EKMETIN4_TXT");
            entity.Property(e => e.Ekmetin4Var).HasColumnName("EKMETIN4_VAR");
            entity.Property(e => e.Ekmetin4W).HasColumnName("EKMETIN4_W");
            entity.Property(e => e.Ekmetin4X).HasColumnName("EKMETIN4_X");
            entity.Property(e => e.Ekmetin4Y).HasColumnName("EKMETIN4_Y");
            entity.Property(e => e.Ekmetin5Txt)
                .HasMaxLength(255)
                .HasColumnName("EKMETIN5_TXT");
            entity.Property(e => e.Ekmetin5Var).HasColumnName("EKMETIN5_VAR");
            entity.Property(e => e.Ekmetin5W).HasColumnName("EKMETIN5_W");
            entity.Property(e => e.Ekmetin5X).HasColumnName("EKMETIN5_X");
            entity.Property(e => e.Ekmetin5Y).HasColumnName("EKMETIN5_Y");
            entity.Property(e => e.EttnTxt)
                .HasMaxLength(255)
                .HasColumnName("ETTN_TXT");
            entity.Property(e => e.EttnVar).HasColumnName("ETTN_VAR");
            entity.Property(e => e.EttnW).HasColumnName("ETTN_W");
            entity.Property(e => e.EttnX).HasColumnName("ETTN_X");
            entity.Property(e => e.EttnY).HasColumnName("ETTN_Y");
            entity.Property(e => e.EvrakFatura).HasColumnName("EVRAK_FATURA");
            entity.Property(e => e.EvrakIrsaliye).HasColumnName("EVRAK_IRSALIYE");
            entity.Property(e => e.EvrakPerakendefatura).HasColumnName("EVRAK_PERAKENDEFATURA");
            entity.Property(e => e.EvrakseriTxt)
                .HasMaxLength(255)
                .HasColumnName("EVRAKSERI_TXT");
            entity.Property(e => e.EvrakseriVar).HasColumnName("EVRAKSERI_VAR");
            entity.Property(e => e.EvrakseriW).HasColumnName("EVRAKSERI_W");
            entity.Property(e => e.EvrakseriX).HasColumnName("EVRAKSERI_X");
            entity.Property(e => e.EvrakseriY).HasColumnName("EVRAKSERI_Y");
            entity.Property(e => e.EvraksiraTxt)
                .HasMaxLength(255)
                .HasColumnName("EVRAKSIRA_TXT");
            entity.Property(e => e.EvraksiraVar).HasColumnName("EVRAKSIRA_VAR");
            entity.Property(e => e.EvraksiraW).HasColumnName("EVRAKSIRA_W");
            entity.Property(e => e.EvraksiraX).HasColumnName("EVRAKSIRA_X");
            entity.Property(e => e.EvraksiraY).HasColumnName("EVRAKSIRA_Y");
            entity.Property(e => e.Farkliambalajbirimbirlestir).HasColumnName("FARKLIAMBALAJBIRIMBIRLESTIR");
            entity.Property(e => e.FaturaaltigeneltoplamrakamlaVar).HasColumnName("FATURAALTIGENELTOPLAMRAKAMLA_VAR");
            entity.Property(e => e.FaturaaltigeneltoplamyaziylaVar).HasColumnName("FATURAALTIGENELTOPLAMYAZIYLA_VAR");
            entity.Property(e => e.FaturanoTxt)
                .HasMaxLength(255)
                .HasColumnName("FATURANO_TXT");
            entity.Property(e => e.FaturanoVar).HasColumnName("FATURANO_VAR");
            entity.Property(e => e.FaturanoW).HasColumnName("FATURANO_W");
            entity.Property(e => e.FaturanoX).HasColumnName("FATURANO_X");
            entity.Property(e => e.FaturanoY).HasColumnName("FATURANO_Y");
            entity.Property(e => e.FiilitarihTxt)
                .HasMaxLength(255)
                .HasColumnName("FIILITARIH_TXT");
            entity.Property(e => e.FiilitarihVar).HasColumnName("FIILITARIH_VAR");
            entity.Property(e => e.FiilitarihW).HasColumnName("FIILITARIH_W");
            entity.Property(e => e.FiilitarihX).HasColumnName("FIILITARIH_X");
            entity.Property(e => e.FiilitarihY).HasColumnName("FIILITARIH_Y");
            entity.Property(e => e.FiyatVar).HasColumnName("FIYAT_VAR");
            entity.Property(e => e.FiyatW).HasColumnName("FIYAT_W");
            entity.Property(e => e.FiyatX).HasColumnName("FIYAT_X");
            entity.Property(e => e.GeneltoplamVar).HasColumnName("GENELTOPLAM_VAR");
            entity.Property(e => e.HaricbakiyeVar).HasColumnName("HARICBAKIYE_VAR");
            entity.Property(e => e.IlTxt)
                .HasMaxLength(255)
                .HasColumnName("IL_TXT");
            entity.Property(e => e.IlVar).HasColumnName("IL_VAR");
            entity.Property(e => e.IlW).HasColumnName("IL_W");
            entity.Property(e => e.IlX).HasColumnName("IL_X");
            entity.Property(e => e.IlY).HasColumnName("IL_Y");
            entity.Property(e => e.IlceTxt)
                .HasMaxLength(255)
                .HasColumnName("ILCE_TXT");
            entity.Property(e => e.IlceVar).HasColumnName("ILCE_VAR");
            entity.Property(e => e.IlceW).HasColumnName("ILCE_W");
            entity.Property(e => e.IlceX).HasColumnName("ILCE_X");
            entity.Property(e => e.IlceY).HasColumnName("ILCE_Y");
            entity.Property(e => e.Irsaliyeekmetin1Txt)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYEEKMETIN1_TXT");
            entity.Property(e => e.Irsaliyeekmetin1Var).HasColumnName("IRSALIYEEKMETIN1_VAR");
            entity.Property(e => e.Irsaliyeekmetin1W).HasColumnName("IRSALIYEEKMETIN1_W");
            entity.Property(e => e.Irsaliyeekmetin1X).HasColumnName("IRSALIYEEKMETIN1_X");
            entity.Property(e => e.Irsaliyeekmetin1Y).HasColumnName("IRSALIYEEKMETIN1_Y");
            entity.Property(e => e.Irsaliyeekmetin2Txt)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYEEKMETIN2_TXT");
            entity.Property(e => e.Irsaliyeekmetin2Var).HasColumnName("IRSALIYEEKMETIN2_VAR");
            entity.Property(e => e.Irsaliyeekmetin2W).HasColumnName("IRSALIYEEKMETIN2_W");
            entity.Property(e => e.Irsaliyeekmetin2X).HasColumnName("IRSALIYEEKMETIN2_X");
            entity.Property(e => e.Irsaliyeekmetin2Y).HasColumnName("IRSALIYEEKMETIN2_Y");
            entity.Property(e => e.Irsaliyeekmetin3Txt)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYEEKMETIN3_TXT");
            entity.Property(e => e.Irsaliyeekmetin3Var).HasColumnName("IRSALIYEEKMETIN3_VAR");
            entity.Property(e => e.Irsaliyeekmetin3W).HasColumnName("IRSALIYEEKMETIN3_W");
            entity.Property(e => e.Irsaliyeekmetin3X).HasColumnName("IRSALIYEEKMETIN3_X");
            entity.Property(e => e.Irsaliyeekmetin3Y).HasColumnName("IRSALIYEEKMETIN3_Y");
            entity.Property(e => e.Irsaliyeekmetin4Txt)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYEEKMETIN4_TXT");
            entity.Property(e => e.Irsaliyeekmetin4Var).HasColumnName("IRSALIYEEKMETIN4_VAR");
            entity.Property(e => e.Irsaliyeekmetin4W).HasColumnName("IRSALIYEEKMETIN4_W");
            entity.Property(e => e.Irsaliyeekmetin4X).HasColumnName("IRSALIYEEKMETIN4_X");
            entity.Property(e => e.Irsaliyeekmetin4Y).HasColumnName("IRSALIYEEKMETIN4_Y");
            entity.Property(e => e.Irsaliyeekmetin5Txt)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYEEKMETIN5_TXT");
            entity.Property(e => e.Irsaliyeekmetin5Var).HasColumnName("IRSALIYEEKMETIN5_VAR");
            entity.Property(e => e.Irsaliyeekmetin5W).HasColumnName("IRSALIYEEKMETIN5_W");
            entity.Property(e => e.Irsaliyeekmetin5X).HasColumnName("IRSALIYEEKMETIN5_X");
            entity.Property(e => e.Irsaliyeekmetin5Y).HasColumnName("IRSALIYEEKMETIN5_Y");
            entity.Property(e => e.IrsaliyenoTxt)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYENO_TXT");
            entity.Property(e => e.IrsaliyenoVar).HasColumnName("IRSALIYENO_VAR");
            entity.Property(e => e.IrsaliyenoW).HasColumnName("IRSALIYENO_W");
            entity.Property(e => e.IrsaliyenoX).HasColumnName("IRSALIYENO_X");
            entity.Property(e => e.IrsaliyenoY).HasColumnName("IRSALIYENO_Y");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.IskontotoplamVar).HasColumnName("ISKONTOTOPLAM_VAR");
            entity.Property(e => e.Kagitboyu).HasColumnName("KAGITBOYU");
            entity.Property(e => e.KalembaslangicY).HasColumnName("KALEMBASLANGIC_Y");
            entity.Property(e => e.KalemiskontotoplamVar).HasColumnName("KALEMISKONTOTOPLAM_VAR");
            entity.Property(e => e.Kalemsatirsayisi).HasColumnName("KALEMSATIRSAYISI");
            entity.Property(e => e.Kdv18Var).HasColumnName("KDV18_VAR");
            entity.Property(e => e.Kdv1Var).HasColumnName("KDV1_VAR");
            entity.Property(e => e.Kdv8Var).HasColumnName("KDV8_VAR");
            entity.Property(e => e.KdvTxt)
                .HasMaxLength(255)
                .HasColumnName("KDV_TXT");
            entity.Property(e => e.KdvVar).HasColumnName("KDV_VAR");
            entity.Property(e => e.KdvW).HasColumnName("KDV_W");
            entity.Property(e => e.KdvX).HasColumnName("KDV_X");
            entity.Property(e => e.KdvtoplamVar).HasColumnName("KDVTOPLAM_VAR");
            entity.Property(e => e.Kisk1Var).HasColumnName("KISK1_VAR");
            entity.Property(e => e.Kisk1W).HasColumnName("KISK1_W");
            entity.Property(e => e.Kisk1X).HasColumnName("KISK1_X");
            entity.Property(e => e.Kisk2Var).HasColumnName("KISK2_VAR");
            entity.Property(e => e.Kisk2W).HasColumnName("KISK2_W");
            entity.Property(e => e.Kisk2X).HasColumnName("KISK2_X");
            entity.Property(e => e.Kisk3Var).HasColumnName("KISK3_VAR");
            entity.Property(e => e.Kisk3W).HasColumnName("KISK3_W");
            entity.Property(e => e.Kisk3X).HasColumnName("KISK3_X");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.KullaniciTxt)
                .HasMaxLength(255)
                .HasColumnName("KULLANICI_TXT");
            entity.Property(e => e.KullaniciVar).HasColumnName("KULLANICI_VAR");
            entity.Property(e => e.KullaniciW).HasColumnName("KULLANICI_W");
            entity.Property(e => e.KullaniciX).HasColumnName("KULLANICI_X");
            entity.Property(e => e.KullaniciY).HasColumnName("KULLANICI_Y");
            entity.Property(e => e.MaltoplamVar).HasColumnName("MALTOPLAM_VAR");
            entity.Property(e => e.MambalajVar).HasColumnName("MAMBALAJ_VAR");
            entity.Property(e => e.MambalajW).HasColumnName("MAMBALAJ_W");
            entity.Property(e => e.MambalajX).HasColumnName("MAMBALAJ_X");
            entity.Property(e => e.Matrah18Var).HasColumnName("MATRAH18_VAR");
            entity.Property(e => e.Matrah1Var).HasColumnName("MATRAH1_VAR");
            entity.Property(e => e.Matrah8Var).HasColumnName("MATRAH8_VAR");
            entity.Property(e => e.MatrahVar).HasColumnName("MATRAH_VAR");
            entity.Property(e => e.MiktarVar).HasColumnName("MIKTAR_VAR");
            entity.Property(e => e.MiktarW).HasColumnName("MIKTAR_W");
            entity.Property(e => e.MiktarX).HasColumnName("MIKTAR_X");
            entity.Property(e => e.OdemetipTxt)
                .HasMaxLength(255)
                .HasColumnName("ODEMETIP_TXT");
            entity.Property(e => e.OdemetipVar).HasColumnName("ODEMETIP_VAR");
            entity.Property(e => e.OdemetipW).HasColumnName("ODEMETIP_W");
            entity.Property(e => e.OdemetipX).HasColumnName("ODEMETIP_X");
            entity.Property(e => e.OdemetipY).HasColumnName("ODEMETIP_Y");
            entity.Property(e => e.OtvVar).HasColumnName("OTV_VAR");
            entity.Property(e => e.OtvW).HasColumnName("OTV_W");
            entity.Property(e => e.OtvX).HasColumnName("OTV_X");
            entity.Property(e => e.OtvtoplamVar).HasColumnName("OTVTOPLAM_VAR");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.SaatTxt)
                .HasMaxLength(255)
                .HasColumnName("SAAT_TXT");
            entity.Property(e => e.SaatVar).HasColumnName("SAAT_VAR");
            entity.Property(e => e.SaatW).HasColumnName("SAAT_W");
            entity.Property(e => e.SaatX).HasColumnName("SAAT_X");
            entity.Property(e => e.SaatY).HasColumnName("SAAT_Y");
            entity.Property(e => e.SayfaboyuX).HasColumnName("SAYFABOYU_X");
            entity.Property(e => e.SayfaboyuY).HasColumnName("SAYFABOYU_Y");
            entity.Property(e => e.Sayfakalemsayisi).HasColumnName("SAYFAKALEMSAYISI");
            entity.Property(e => e.SevkadresTxt)
                .HasMaxLength(255)
                .HasColumnName("SEVKADRES_TXT");
            entity.Property(e => e.SevkadresVar).HasColumnName("SEVKADRES_VAR");
            entity.Property(e => e.SevkadresW).HasColumnName("SEVKADRES_W");
            entity.Property(e => e.SevkadresX).HasColumnName("SEVKADRES_X");
            entity.Property(e => e.SevkadresY).HasColumnName("SEVKADRES_Y");
            entity.Property(e => e.SevkilTxt)
                .HasMaxLength(255)
                .HasColumnName("SEVKIL_TXT");
            entity.Property(e => e.SevkilVar).HasColumnName("SEVKIL_VAR");
            entity.Property(e => e.SevkilW).HasColumnName("SEVKIL_W");
            entity.Property(e => e.SevkilX).HasColumnName("SEVKIL_X");
            entity.Property(e => e.SevkilY).HasColumnName("SEVKIL_Y");
            entity.Property(e => e.SevkilceTxt)
                .HasMaxLength(255)
                .HasColumnName("SEVKILCE_TXT");
            entity.Property(e => e.SevkilceVar).HasColumnName("SEVKILCE_VAR");
            entity.Property(e => e.SevkilceW).HasColumnName("SEVKILCE_W");
            entity.Property(e => e.SevkilceX).HasColumnName("SEVKILCE_X");
            entity.Property(e => e.SevkilceY).HasColumnName("SEVKILCE_Y");
            entity.Property(e => e.SevkkodTxt)
                .HasMaxLength(255)
                .HasColumnName("SEVKKOD_TXT");
            entity.Property(e => e.SevkkodVar).HasColumnName("SEVKKOD_VAR");
            entity.Property(e => e.SevkkodW).HasColumnName("SEVKKOD_W");
            entity.Property(e => e.SevkkodX).HasColumnName("SEVKKOD_X");
            entity.Property(e => e.SevkkodY).HasColumnName("SEVKKOD_Y");
            entity.Property(e => e.SimdikibakiyeVar).HasColumnName("SIMDIKIBAKIYE_VAR");
            entity.Property(e => e.SonbakiyeVar).HasColumnName("SONBAKIYE_VAR");
            entity.Property(e => e.StokisimVar).HasColumnName("STOKISIM_VAR");
            entity.Property(e => e.StokisimW).HasColumnName("STOKISIM_W");
            entity.Property(e => e.StokisimX).HasColumnName("STOKISIM_X");
            entity.Property(e => e.StokkodVar).HasColumnName("STOKKOD_VAR");
            entity.Property(e => e.StokkodW).HasColumnName("STOKKOD_W");
            entity.Property(e => e.StokkodX).HasColumnName("STOKKOD_X");
            entity.Property(e => e.TabelaisimTxt)
                .HasMaxLength(255)
                .HasColumnName("TABELAISIM_TXT");
            entity.Property(e => e.TabelaisimVar).HasColumnName("TABELAISIM_VAR");
            entity.Property(e => e.TabelaisimW).HasColumnName("TABELAISIM_W");
            entity.Property(e => e.TabelaisimX).HasColumnName("TABELAISIM_X");
            entity.Property(e => e.TabelaisimY).HasColumnName("TABELAISIM_Y");
            entity.Property(e => e.Tahsilatekmetin1Txt)
                .HasMaxLength(255)
                .HasColumnName("TAHSILATEKMETIN1_TXT");
            entity.Property(e => e.Tahsilatekmetin1Var).HasColumnName("TAHSILATEKMETIN1_VAR");
            entity.Property(e => e.Tahsilatekmetin1W).HasColumnName("TAHSILATEKMETIN1_W");
            entity.Property(e => e.Tahsilatekmetin1X).HasColumnName("TAHSILATEKMETIN1_X");
            entity.Property(e => e.Tahsilatekmetin1Y).HasColumnName("TAHSILATEKMETIN1_Y");
            entity.Property(e => e.Tahsilatekmetin2Txt)
                .HasMaxLength(255)
                .HasColumnName("TAHSILATEKMETIN2_TXT");
            entity.Property(e => e.Tahsilatekmetin2Var).HasColumnName("TAHSILATEKMETIN2_VAR");
            entity.Property(e => e.Tahsilatekmetin2W).HasColumnName("TAHSILATEKMETIN2_W");
            entity.Property(e => e.Tahsilatekmetin2X).HasColumnName("TAHSILATEKMETIN2_X");
            entity.Property(e => e.Tahsilatekmetin2Y).HasColumnName("TAHSILATEKMETIN2_Y");
            entity.Property(e => e.TahsilatoncekibakiyeVar).HasColumnName("TAHSILATONCEKIBAKIYE_VAR");
            entity.Property(e => e.TahsilatoncekibakiyeX).HasColumnName("TAHSILATONCEKIBAKIYE_X");
            entity.Property(e => e.TahsilatoncekibakiyeY).HasColumnName("TAHSILATONCEKIBAKIYE_Y");
            entity.Property(e => e.TahsilatsimdikibakiyeVar).HasColumnName("TAHSILATSIMDIKIBAKIYE_VAR");
            entity.Property(e => e.TahsilatsonbakiyeVar).HasColumnName("TAHSILATSONBAKIYE_VAR");
            entity.Property(e => e.TahsilatsonbakiyeX).HasColumnName("TAHSILATSONBAKIYE_X");
            entity.Property(e => e.TahsilatsonbakiyeY).HasColumnName("TAHSILATSONBAKIYE_Y");
            entity.Property(e => e.TahsilattoplamX).HasColumnName("TAHSILATTOPLAM_X");
            entity.Property(e => e.TahsilattoplamY).HasColumnName("TAHSILATTOPLAM_Y");
            entity.Property(e => e.TahsilattoplamyaziylaX).HasColumnName("TAHSILATTOPLAMYAZIYLA_X");
            entity.Property(e => e.TahsilattoplamyaziylaY).HasColumnName("TAHSILATTOPLAMYAZIYLA_Y");
            entity.Property(e => e.TapdknoTxt)
                .HasMaxLength(255)
                .HasColumnName("TAPDKNO_TXT");
            entity.Property(e => e.TapdknoVar).HasColumnName("TAPDKNO_VAR");
            entity.Property(e => e.TapdknoW).HasColumnName("TAPDKNO_W");
            entity.Property(e => e.TapdknoX).HasColumnName("TAPDKNO_X");
            entity.Property(e => e.TapdknoY).HasColumnName("TAPDKNO_Y");
            entity.Property(e => e.TarihTxt)
                .HasMaxLength(255)
                .HasColumnName("TARIH_TXT");
            entity.Property(e => e.TarihVar).HasColumnName("TARIH_VAR");
            entity.Property(e => e.TarihW).HasColumnName("TARIH_W");
            entity.Property(e => e.TarihX).HasColumnName("TARIH_X");
            entity.Property(e => e.TarihY).HasColumnName("TARIH_Y");
            entity.Property(e => e.TemelbirimVar).HasColumnName("TEMELBIRIM_VAR");
            entity.Property(e => e.TemelbirimW).HasColumnName("TEMELBIRIM_W");
            entity.Property(e => e.TemelbirimX).HasColumnName("TEMELBIRIM_X");
            entity.Property(e => e.TemelfiyatVar).HasColumnName("TEMELFIYAT_VAR");
            entity.Property(e => e.TemelfiyatW).HasColumnName("TEMELFIYAT_W");
            entity.Property(e => e.TemelfiyatX).HasColumnName("TEMELFIYAT_X");
            entity.Property(e => e.TemelmiktarVar).HasColumnName("TEMELMIKTAR_VAR");
            entity.Property(e => e.TemelmiktarW).HasColumnName("TEMELMIKTAR_W");
            entity.Property(e => e.TemelmiktarX).HasColumnName("TEMELMIKTAR_X");
            entity.Property(e => e.TrmAmbalajVar).HasColumnName("TRM_AMBALAJ_VAR");
            entity.Property(e => e.TrmDepozitobakiyeVar).HasColumnName("TRM_DEPOZITOBAKIYE_VAR");
            entity.Property(e => e.TrmEarsivAltaciklama).HasColumnName("TRM_EARSIV_ALTACIKLAMA");
            entity.Property(e => e.TrmEbelgeEkaciklama)
                .HasMaxLength(4)
                .HasColumnName("TRM_EBELGE_EKACIKLAMA");
            entity.Property(e => e.TrmEbelgeEkaciklama2)
                .HasMaxLength(4)
                .HasColumnName("TRM_EBELGE_EKACIKLAMA2");
            entity.Property(e => e.TrmEfaturaAltaciklama).HasColumnName("TRM_EFATURA_ALTACIKLAMA");
            entity.Property(e => e.TrmEirsaliyeAltaciklama).HasColumnName("TRM_EIRSALIYE_ALTACIKLAMA");
            entity.Property(e => e.TrmEirsaliyenoBarkodVar).HasColumnName("TRM_EIRSALIYENO_BARKOD_VAR");
            entity.Property(e => e.TrmEvrakaciklamaVar).HasColumnName("TRM_EVRAKACIKLAMA_VAR");
            entity.Property(e => e.TrmFirmabilgi).HasColumnName("TRM_FIRMABILGI");
            entity.Property(e => e.TrmFirmaimzaGorsel).HasColumnName("TRM_FIRMAIMZA_GORSEL");
            entity.Property(e => e.TrmFirmalogoGorsel).HasColumnName("TRM_FIRMALOGO_GORSEL");
            entity.Property(e => e.TrmGrafikkullan).HasColumnName("TRM_GRAFIKKULLAN");
            entity.Property(e => e.TrmHaricbakiyeVar).HasColumnName("TRM_HARICBAKIYE_VAR");
            entity.Property(e => e.TrmKalemiskontoVar).HasColumnName("TRM_KALEMISKONTO_VAR");
            entity.Property(e => e.TrmKdvdetayVar).HasColumnName("TRM_KDVDETAY_VAR");
            entity.Property(e => e.TrmKdvyuzdeVar).HasColumnName("TRM_KDVYUZDE_VAR");
            entity.Property(e => e.TrmMatrahdetayVar).HasColumnName("TRM_MATRAHDETAY_VAR");
            entity.Property(e => e.TrmNusha)
                .HasMaxLength(4)
                .HasColumnName("TRM_NUSHA");
            entity.Property(e => e.TrmNushaDurdurVar).HasColumnName("TRM_NUSHA_DURDUR_VAR");
            entity.Property(e => e.TrmSonbakiyeIrsaliyeVar).HasColumnName("TRM_SONBAKIYE_IRSALIYE_VAR");
            entity.Property(e => e.TrmSonbakiyeTahsilatVar).HasColumnName("TRM_SONBAKIYE_TAHSILAT_VAR");
            entity.Property(e => e.TrmSonbakiyeVar).HasColumnName("TRM_SONBAKIYE_VAR");
            entity.Property(e => e.TrmStokkodVar).HasColumnName("TRM_STOKKOD_VAR");
            entity.Property(e => e.TrmTahsilatAltaciklama).HasColumnName("TRM_TAHSILAT_ALTACIKLAMA");
            entity.Property(e => e.TrmTetaVar).HasColumnName("TRM_TETA_VAR");
            entity.Property(e => e.TrmTutarVar).HasColumnName("TRM_TUTAR_VAR");
            entity.Property(e => e.TrmVadetarihVar).HasColumnName("TRM_VADETARIH_VAR");
            entity.Property(e => e.TrmYazdirildigitarihsaatVar).HasColumnName("TRM_YAZDIRILDIGITARIHSAAT_VAR");
            entity.Property(e => e.TutarVar).HasColumnName("TUTAR_VAR");
            entity.Property(e => e.TutarW).HasColumnName("TUTAR_W");
            entity.Property(e => e.TutarX).HasColumnName("TUTAR_X");
            entity.Property(e => e.VadetarihTxt)
                .HasMaxLength(255)
                .HasColumnName("VADETARIH_TXT");
            entity.Property(e => e.VadetarihVar).HasColumnName("VADETARIH_VAR");
            entity.Property(e => e.VadetarihW).HasColumnName("VADETARIH_W");
            entity.Property(e => e.VadetarihX).HasColumnName("VADETARIH_X");
            entity.Property(e => e.VadetarihY).HasColumnName("VADETARIH_Y");
            entity.Property(e => e.VergidairesiTxt)
                .HasMaxLength(255)
                .HasColumnName("VERGIDAIRESI_TXT");
            entity.Property(e => e.VergidairesiVar).HasColumnName("VERGIDAIRESI_VAR");
            entity.Property(e => e.VergidairesiW).HasColumnName("VERGIDAIRESI_W");
            entity.Property(e => e.VergidairesiX).HasColumnName("VERGIDAIRESI_X");
            entity.Property(e => e.VergidairesiY).HasColumnName("VERGIDAIRESI_Y");
            entity.Property(e => e.VerginoTxt)
                .HasMaxLength(255)
                .HasColumnName("VERGINO_TXT");
            entity.Property(e => e.VerginoVar).HasColumnName("VERGINO_VAR");
            entity.Property(e => e.VerginoW).HasColumnName("VERGINO_W");
            entity.Property(e => e.VerginoX).HasColumnName("VERGINO_X");
            entity.Property(e => e.VerginoY).HasColumnName("VERGINO_Y");
            entity.Property(e => e.Yazdirmamilisaniye).HasColumnName("YAZDIRMAMILISANIYE");
            entity.Property(e => e.Yaziciozelayar)
                .HasMaxLength(50)
                .HasColumnName("YAZICIOZELAYAR");
            entity.Property(e => e.YuklemeirsaliyenoTxt)
                .HasMaxLength(255)
                .HasColumnName("YUKLEMEIRSALIYENO_TXT");
            entity.Property(e => e.YuklemeirsaliyenoVar).HasColumnName("YUKLEMEIRSALIYENO_VAR");
            entity.Property(e => e.YuklemeirsaliyenoW).HasColumnName("YUKLEMEIRSALIYENO_W");
            entity.Property(e => e.YuklemeirsaliyenoX).HasColumnName("YUKLEMEIRSALIYENO_X");
            entity.Property(e => e.YuklemeirsaliyenoY).HasColumnName("YUKLEMEIRSALIYENO_Y");
        });

        modelBuilder.Entity<Mobilkullanici>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_mobilkullanici");

            entity.ToTable("mobilkullanici", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Aracgrupkod)
                .HasMaxLength(100)
                .HasColumnName("ARACGRUPKOD");
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Grup)
                .HasMaxLength(100)
                .HasColumnName("GRUP");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(100)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.Kullanicigrupkod)
                .HasMaxLength(100)
                .HasColumnName("KULLANICIGRUPKOD");
            entity.Property(e => e.OnesignalUser).HasColumnName("ONESIGNAL_USER");
            entity.Property(e => e.Parola)
                .HasMaxLength(100)
                .HasColumnName("PAROLA");
        });

        modelBuilder.Entity<Msg>(entity =>
        {
            entity.ToTable("msg", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Body).HasColumnName("BODY");
            entity.Property(e => e.Sender).HasColumnName("SENDER");
            entity.Property(e => e.Subject)
                .HasMaxLength(255)
                .HasColumnName("SUBJECT");
        });

        modelBuilder.Entity<MsgRcv>(entity =>
        {
            entity.ToTable("msg_rcv", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Messageid)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("MESSAGEID");
            entity.Property(e => e.Seendatetime)
                .HasColumnType("datetime")
                .HasColumnName("SEENDATETIME");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Musteri>(entity =>
        {
            entity.ToTable("musteri", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcikhesapKullan)
                .HasMaxLength(4)
                .HasColumnName("ACIKHESAP_KULLAN");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(250)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Eposta)
                .HasMaxLength(100)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Fotograf)
                .HasColumnType("image")
                .HasColumnName("FOTOGRAF");
            entity.Property(e => e.Grup)
                .HasMaxLength(255)
                .HasColumnName("GRUP");
            entity.Property(e => e.Gsm)
                .HasMaxLength(20)
                .HasColumnName("GSM");
            entity.Property(e => e.Il)
                .HasMaxLength(100)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(100)
                .HasColumnName("ILCE");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskonto)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO");
            entity.Property(e => e.Iskontotip)
                .HasMaxLength(4)
                .HasColumnName("ISKONTOTIP");
            entity.Property(e => e.Kartid)
                .HasMaxLength(1000)
                .HasColumnName("KARTID");
            entity.Property(e => e.Kasiyerbilgimesaj)
                .HasMaxLength(1000)
                .HasColumnName("KASIYERBILGIMESAJ");
            entity.Property(e => e.Kayittarih)
                .HasColumnType("datetime")
                .HasColumnName("KAYITTARIH");
            entity.Property(e => e.Pin)
                .HasMaxLength(20)
                .HasColumnName("PIN");
            entity.Property(e => e.Sorumlusubeid).HasColumnName("SORUMLUSUBEID");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(100)
                .HasColumnName("TEL2");
            entity.Property(e => e.VeresiyeKredilimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("VERESIYE_KREDILIMIT");
            entity.Property(e => e.VeresiyeKullan).HasColumnName("VERESIYE_KULLAN");
            entity.Property(e => e.VeresiyeUyarilimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("VERESIYE_UYARILIMIT");
            entity.Property(e => e.VeresiyeVadegun).HasColumnName("VERESIYE_VADEGUN");
        });

        modelBuilder.Entity<Musteritalepsikayet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_musteritalepsikayet");

            entity.ToTable("musteritalepsikayet", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Il)
                .HasMaxLength(100)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(100)
                .HasColumnName("ILCE");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kapali).HasColumnName("KAPALI");
            entity.Property(e => e.Konu)
                .HasMaxLength(255)
                .HasColumnName("KONU");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sonuc).HasColumnName("SONUC");
            entity.Property(e => e.Sorumlu)
                .HasMaxLength(255)
                .HasColumnName("SORUMLU");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Telefon)
                .HasMaxLength(100)
                .HasColumnName("TELEFON");
        });

        modelBuilder.Entity<Musteriveresiye>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_musteriveresiye");

            entity.ToTable("musteriveresiye", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Borc)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BORC");
            entity.Property(e => e.Fisid).HasColumnName("FISID");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Musteriid).HasColumnName("MUSTERIID");
            entity.Property(e => e.Oturumid).HasColumnName("OTURUMID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Mutabakat>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_mutabakat");

            entity.ToTable("mutabakat", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ay).HasColumnName("AY");
            entity.Property(e => e.Bakiyetarih)
                .HasColumnType("datetime")
                .HasColumnName("BAKIYETARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
            entity.Property(e => e.Yil).HasColumnName("YIL");
        });

        modelBuilder.Entity<Mutabakatdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_mutabakatdetay");

            entity.ToTable("mutabakatdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Faturaadet).HasColumnName("FATURAADET");
            entity.Property(e => e.Gorsel1)
                .HasColumnType("image")
                .HasColumnName("GORSEL1");
            entity.Property(e => e.Gorsel2)
                .HasColumnType("image")
                .HasColumnName("GORSEL2");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Matrah)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MATRAH");
            entity.Property(e => e.Mutabakatid).HasColumnName("MUTABAKATID");
            entity.Property(e => e.Onay)
                .HasMaxLength(20)
                .HasColumnName("ONAY");
            entity.Property(e => e.Smsgonderildi).HasColumnName("SMSGONDERILDI");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<ObjAuth>(entity =>
        {
            entity.ToTable("obj_auth", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Defaultvalue)
                .HasMaxLength(255)
                .HasColumnName("DEFAULTVALUE");
            entity.Property(e => e.Items).HasColumnName("ITEMS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Ord).HasColumnName("ORD");
            entity.Property(e => e.Parent)
                .HasMaxLength(100)
                .HasColumnName("PARENT");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<ObjClu>(entity =>
        {
            entity.ToTable("obj_clu", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Data)
                .HasColumnType("xml")
                .HasColumnName("DATA");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Systemlocked).HasColumnName("SYSTEMLOCKED");
        });

        modelBuilder.Entity<ObjDb>(entity =>
        {
            entity.ToTable("obj_db", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Ord).HasColumnName("ORD");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Scriptcode).HasColumnName("SCRIPTCODE");
            entity.Property(e => e.Scriptcodexml)
                .HasColumnType("xml")
                .HasColumnName("SCRIPTCODEXML");
        });

        modelBuilder.Entity<ObjFile>(entity =>
        {
            entity.ToTable("obj_file", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Fl).HasColumnName("FL");
            entity.Property(e => e.FlHash)
                .HasMaxLength(100)
                .HasColumnName("FL_HASH");
            entity.Property(e => e.FlName)
                .HasMaxLength(100)
                .HasColumnName("FL_NAME");
            entity.Property(e => e.FlPath)
                .HasMaxLength(255)
                .HasColumnName("FL_PATH");
            entity.Property(e => e.Modifydatetime)
                .HasColumnType("datetime")
                .HasColumnName("MODIFYDATETIME");
            entity.Property(e => e.Plgobjectid).HasColumnName("PLGOBJECTID");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjLaf>(entity =>
        {
            entity.ToTable("obj_laf", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Codedll).HasColumnName("CODEDLL");
            entity.Property(e => e.CodedllHash)
                .HasMaxLength(100)
                .HasColumnName("CODEDLL_HASH");
            entity.Property(e => e.Codefile).HasColumnName("CODEFILE");
            entity.Property(e => e.Contentxml)
                .HasColumnType("xml")
                .HasColumnName("CONTENTXML");
            entity.Property(e => e.Createdatetime)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATETIME");
            entity.Property(e => e.Formheight).HasColumnName("FORMHEIGHT");
            entity.Property(e => e.Formwidth).HasColumnName("FORMWIDTH");
            entity.Property(e => e.Gridsxml)
                .HasColumnType("xml")
                .HasColumnName("GRIDSXML");
            entity.Property(e => e.Layoutxml).HasColumnName("LAYOUTXML");
            entity.Property(e => e.LayoutxmlHash)
                .HasMaxLength(100)
                .HasColumnName("LAYOUTXML_HASH");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Modifydatetime)
                .HasColumnType("datetime")
                .HasColumnName("MODIFYDATETIME");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Printlayout).HasColumnName("PRINTLAYOUT");
            entity.Property(e => e.PrintlayoutHash)
                .HasMaxLength(100)
                .HasColumnName("PRINTLAYOUT_HASH");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Propertiesxml)
                .HasColumnType("xml")
                .HasColumnName("PROPERTIESXML");
            entity.Property(e => e.Publishdatetime)
                .HasColumnType("datetime")
                .HasColumnName("PUBLISHDATETIME");
            entity.Property(e => e.Systemlocked).HasColumnName("SYSTEMLOCKED");
            entity.Property(e => e.Weblayout)
                .HasColumnType("xml")
                .HasColumnName("WEBLAYOUT");
        });

        modelBuilder.Entity<ObjLafprn>(entity =>
        {
            entity.ToTable("obj_lafprn", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Lafobjectcode)
                .HasMaxLength(100)
                .HasColumnName("LAFOBJECTCODE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Printlayout).HasColumnName("PRINTLAYOUT");
            entity.Property(e => e.PrintlayoutHash)
                .HasMaxLength(100)
                .HasColumnName("PRINTLAYOUT_HASH");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Show).HasColumnName("SHOW");
        });

        modelBuilder.Entity<ObjLang>(entity =>
        {
            entity.ToTable("obj_lang", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(25)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjLangre>(entity =>
        {
            entity.ToTable("obj_langres", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("CODE");
            entity.Property(e => e.Def).HasColumnName("DEF");
            entity.Property(e => e.Langcode)
                .HasMaxLength(5)
                .HasColumnName("LANGCODE");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Text).HasColumnName("TEXT");
        });

        modelBuilder.Entity<ObjLic>(entity =>
        {
            entity.ToTable("obj_lic", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("CODE");
            entity.Property(e => e.Grp)
                .HasMaxLength(100)
                .HasColumnName("GRP");
            entity.Property(e => e.Value).HasColumnName("VALUE");
        });

        modelBuilder.Entity<ObjLrf>(entity =>
        {
            entity.ToTable("obj_lrf", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(255)
                .HasColumnName("CODE");
            entity.Property(e => e.Createdatetime)
                .HasColumnType("datetime")
                .HasColumnName("CREATEDATETIME");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Modifydatetime)
                .HasColumnType("datetime")
                .HasColumnName("MODIFYDATETIME");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Publishdatetime)
                .HasColumnType("datetime")
                .HasColumnName("PUBLISHDATETIME");
            entity.Property(e => e.Reportxml)
                .HasColumnType("xml")
                .HasColumnName("REPORTXML");
            entity.Property(e => e.Systemlocked).HasColumnName("SYSTEMLOCKED");
        });

        modelBuilder.Entity<ObjMauth>(entity =>
        {
            entity.ToTable("obj_mauth", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Defaultvalue)
                .HasMaxLength(255)
                .HasColumnName("DEFAULTVALUE");
            entity.Property(e => e.Items).HasColumnName("ITEMS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Ord).HasColumnName("ORD");
            entity.Property(e => e.Parent)
                .HasMaxLength(100)
                .HasColumnName("PARENT");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<ObjMenu>(entity =>
        {
            entity.ToTable("obj_menu", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Autostart).HasColumnName("AUTOSTART");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Decleration).HasColumnName("DECLERATION");
            entity.Property(e => e.Imagecode)
                .HasMaxLength(100)
                .HasColumnName("IMAGECODE");
            entity.Property(e => e.Keyfunction)
                .HasMaxLength(50)
                .HasColumnName("KEYFUNCTION");
            entity.Property(e => e.Longcaption)
                .HasMaxLength(255)
                .HasColumnName("LONGCAPTION");
            entity.Property(e => e.Menushortcut)
                .HasMaxLength(10)
                .HasColumnName("MENUSHORTCUT");
            entity.Property(e => e.Module)
                .HasMaxLength(100)
                .HasColumnName("MODULE");
            entity.Property(e => e.Ord).HasColumnName("ORD");
            entity.Property(e => e.Parameter)
                .HasMaxLength(50)
                .HasColumnName("PARAMETER");
            entity.Property(e => e.Parent)
                .HasMaxLength(100)
                .HasColumnName("PARENT");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Screencode)
                .HasMaxLength(50)
                .HasColumnName("SCREENCODE");
            entity.Property(e => e.Shortcaption)
                .HasMaxLength(50)
                .HasColumnName("SHORTCAPTION");
            entity.Property(e => e.ShowatCross).HasColumnName("SHOWAT_CROSS");
            entity.Property(e => e.ShowatDesktop).HasColumnName("SHOWAT_DESKTOP");
            entity.Property(e => e.ShowatWeb).HasColumnName("SHOWAT_WEB");
            entity.Property(e => e.Showdefault).HasColumnName("SHOWDEFAULT");
            entity.Property(e => e.Value)
                .HasMaxLength(50)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<ObjPlg>(entity =>
        {
            entity.ToTable("obj_plg", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Dll).HasColumnName("DLL");
            entity.Property(e => e.DllHash)
                .HasMaxLength(100)
                .HasColumnName("DLL_HASH");
            entity.Property(e => e.DllName)
                .HasMaxLength(100)
                .HasColumnName("DLL_NAME");
            entity.Property(e => e.Modifydatetime)
                .HasColumnType("datetime")
                .HasColumnName("MODIFYDATETIME");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjSetting>(entity =>
        {
            entity.ToTable("obj_settings", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Value)
                .HasMaxLength(100)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<ObjSrc>(entity =>
        {
            entity.ToTable("obj_src", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Data)
                .HasColumnType("xml")
                .HasColumnName("DATA");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjUpdate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledsys_obj_update");

            entity.ToTable("obj_update", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Brief)
                .HasMaxLength(100)
                .HasColumnName("BRIEF");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Declaration).HasColumnName("DECLARATION");
            entity.Property(e => e.DevDate)
                .HasColumnType("datetime")
                .HasColumnName("DEV_DATE");
            entity.Property(e => e.DevTime)
                .HasColumnType("datetime")
                .HasColumnName("DEV_TIME");
            entity.Property(e => e.Developeruser)
                .HasMaxLength(100)
                .HasColumnName("DEVELOPERUSER");
            entity.Property(e => e.Image)
                .HasColumnType("image")
                .HasColumnName("IMAGE");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Updategroup)
                .HasMaxLength(100)
                .HasColumnName("UPDATEGROUP");
        });

        modelBuilder.Entity<ObjUser>(entity =>
        {
            entity.ToTable("obj_user", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Coder).HasColumnName("CODER");
            entity.Property(e => e.Decleration)
                .HasMaxLength(255)
                .HasColumnName("DECLERATION");
            entity.Property(e => e.Designer).HasColumnName("DESIGNER");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<ObjVar>(entity =>
        {
            entity.ToTable("obj_var", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Defaultvalue)
                .HasMaxLength(255)
                .HasColumnName("DEFAULTVALUE");
            entity.Property(e => e.Items).HasColumnName("ITEMS");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Ord).HasColumnName("ORD");
            entity.Property(e => e.Parent)
                .HasMaxLength(100)
                .HasColumnName("PARENT");
            entity.Property(e => e.Parentid).HasColumnName("PARENTID");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Type).HasColumnName("TYPE");
        });

        modelBuilder.Entity<ObjWmFilebin>(entity =>
        {
            entity.ToTable("obj_wm_filebin", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Binary).HasColumnName("BINARY");
            entity.Property(e => e.Hash)
                .HasMaxLength(100)
                .HasColumnName("HASH");
            entity.Property(e => e.Modifydatetime)
                .HasColumnType("datetime")
                .HasColumnName("MODIFYDATETIME");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjWmKeyauth>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledsys_obj_wm_keyauth");

            entity.ToTable("obj_wm_keyauth", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Authcode)
                .HasMaxLength(255)
                .HasColumnName("AUTHCODE");
            entity.Property(e => e.Clu1caption)
                .HasMaxLength(255)
                .HasColumnName("CLU1CAPTION");
            entity.Property(e => e.Clu1code)
                .HasMaxLength(100)
                .HasColumnName("CLU1CODE");
            entity.Property(e => e.Clu1infosqlcode).HasColumnName("CLU1INFOSQLCODE");
            entity.Property(e => e.Clu2caption)
                .HasMaxLength(255)
                .HasColumnName("CLU2CAPTION");
            entity.Property(e => e.Clu2code)
                .HasMaxLength(100)
                .HasColumnName("CLU2CODE");
            entity.Property(e => e.Clu2infosqlcode).HasColumnName("CLU2INFOSQLCODE");
            entity.Property(e => e.Clu3caption)
                .HasMaxLength(255)
                .HasColumnName("CLU3CAPTION");
            entity.Property(e => e.Clu3code)
                .HasMaxLength(100)
                .HasColumnName("CLU3CODE");
            entity.Property(e => e.Clu3infosqlcode).HasColumnName("CLU3INFOSQLCODE");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjWmLang>(entity =>
        {
            entity.ToTable("obj_wm_lang", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .HasColumnName("CODE");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjWmLangre>(entity =>
        {
            entity.ToTable("obj_wm_langres", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Keystr).HasColumnName("KEYSTR");
            entity.Property(e => e.Langcode)
                .HasMaxLength(10)
                .HasColumnName("LANGCODE");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
            entity.Property(e => e.Valuestr).HasColumnName("VALUESTR");
        });

        modelBuilder.Entity<ObjWmMenu>(entity =>
        {
            entity.ToTable("obj_wm_menu", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Caption)
                .HasMaxLength(255)
                .HasColumnName("CAPTION");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Function)
                .HasMaxLength(255)
                .HasColumnName("FUNCTION");
            entity.Property(e => e.Imagecode)
                .HasMaxLength(255)
                .HasColumnName("IMAGECODE");
            entity.Property(e => e.Module)
                .HasMaxLength(255)
                .HasColumnName("MODULE");
            entity.Property(e => e.Order).HasColumnName("ORDER");
            entity.Property(e => e.Parentcode)
                .HasMaxLength(255)
                .HasColumnName("PARENTCODE");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<ObjWmModule>(entity =>
        {
            entity.ToTable("obj_wm_module", "ledsys");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Binary).HasColumnName("BINARY");
            entity.Property(e => e.Hash)
                .HasMaxLength(100)
                .HasColumnName("HASH");
            entity.Property(e => e.Modifydatetime)
                .HasColumnType("datetime")
                .HasColumnName("MODIFYDATETIME");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("NAME");
            entity.Property(e => e.Projectcode)
                .HasMaxLength(100)
                .HasColumnName("PROJECTCODE");
        });

        modelBuilder.Entity<Oturum>(entity =>
        {
            entity.ToTable("oturum", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baslangicsaat)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICSAAT");
            entity.Property(e => e.Baslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIH");
            entity.Property(e => e.Bitissaat)
                .HasColumnType("datetime")
                .HasColumnName("BITISSAAT");
            entity.Property(e => e.Bitistarih)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIH");
            entity.Property(e => e.Kapali).HasColumnName("KAPALI");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Oturumkod)
                .HasMaxLength(30)
                .HasColumnName("OTURUMKOD");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<Palet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_palet");

            entity.ToTable("palet", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoadresid).HasColumnName("DEPOADRESID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.IptalTarihsaat)
                .HasColumnType("datetime")
                .HasColumnName("IPTAL_TARIHSAAT");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Skt)
                .HasColumnType("date")
                .HasColumnName("SKT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
            entity.Property(e => e.Yaziciid).HasColumnName("YAZICIID");
        });

        modelBuilder.Entity<PaletDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_palet_detay");

            entity.ToTable("palet_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimcarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BIRIMCARPAN");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Paletid).HasColumnName("PALETID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<PaletYazici>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_palet_yazici");

            entity.ToTable("palet_yazici", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Partino>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_partino");

            entity.ToTable("partino", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Partino1)
                .HasMaxLength(255)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<PersonelBanka>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personel_banka");

            entity.ToTable("personel_banka", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bankaisim)
                .HasMaxLength(255)
                .HasColumnName("BANKAISIM");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(100)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.Iban)
                .HasMaxLength(100)
                .HasColumnName("IBAN");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Subeisim)
                .HasMaxLength(255)
                .HasColumnName("SUBEISIM");
        });

        modelBuilder.Entity<PersonelDigerhakedi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personel_digerhakedis");

            entity.ToTable("personel_digerhakedis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Giderid).HasColumnName("GIDERID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<PersonelIzindetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personel_izindetay");

            entity.ToTable("personel_izindetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Izingunsayisi).HasColumnName("IZINGUNSAYISI");
            entity.Property(e => e.Izinid).HasColumnName("IZINID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
        });

        modelBuilder.Entity<PersonelKesinti>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personel_kesinti");

            entity.ToTable("personel_kesinti", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Giderid).HasColumnName("GIDERID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<PersonelSube>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_personel_sube");

            entity.ToTable("personel_sube", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<Personelailebilgi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personelailebilgi");

            entity.ToTable("personelailebilgi", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Calismadurum)
                .HasMaxLength(4)
                .HasColumnName("CALISMADURUM");
            entity.Property(e => e.Calismayer)
                .HasMaxLength(255)
                .HasColumnName("CALISMAYER");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Egitimdurum)
                .HasMaxLength(4)
                .HasColumnName("EGITIMDURUM");
            entity.Property(e => e.Egitimokul)
                .HasMaxLength(255)
                .HasColumnName("EGITIMOKUL");
            entity.Property(e => e.Egitimokulbolum)
                .HasMaxLength(100)
                .HasColumnName("EGITIMOKULBOLUM");
            entity.Property(e => e.Engel)
                .HasMaxLength(255)
                .HasColumnName("ENGEL");
            entity.Property(e => e.Engellidurum)
                .HasMaxLength(4)
                .HasColumnName("ENGELLIDURUM");
            entity.Property(e => e.Isim)
                .HasMaxLength(100)
                .HasColumnName("ISIM");
            entity.Property(e => e.Okuldurum)
                .HasMaxLength(4)
                .HasColumnName("OKULDURUM");
            entity.Property(e => e.Tckn)
                .HasMaxLength(100)
                .HasColumnName("TCKN");
            entity.Property(e => e.Tel)
                .HasMaxLength(100)
                .HasColumnName("TEL");
            entity.Property(e => e.Yakinlik)
                .HasMaxLength(4)
                .HasColumnName("YAKINLIK");
        });

        modelBuilder.Entity<Personeldepartman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personeldepartman");

            entity.ToTable("personeldepartman", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Personelgirisciki>(entity =>
        {
            entity.ToTable("personelgiriscikis", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Giris).HasColumnName("GIRIS");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Personelgorev>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personelgorev");

            entity.ToTable("personelgorev", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Personelistek>(entity =>
        {
            entity.ToTable("personelistek", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Kapali).HasColumnName("KAPALI");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Oturumid).HasColumnName("OTURUMID");
            entity.Property(e => e.Ozet)
                .HasMaxLength(255)
                .HasColumnName("OZET");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sonucaciklama).HasColumnName("SONUCACIKLAMA");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Personelizin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_personelizin");

            entity.ToTable("personelizin", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIH");
            entity.Property(e => e.Bitistarih)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIH");
            entity.Property(e => e.Izinid).HasColumnName("IZINID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
        });

        modelBuilder.Entity<Personeltanim>(entity =>
        {
            entity.ToTable("personeltanim", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Foto)
                .HasColumnType("image")
                .HasColumnName("FOTO");
            entity.Property(e => e.Gsm)
                .HasMaxLength(30)
                .HasColumnName("GSM");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kartid)
                .HasMaxLength(1000)
                .HasColumnName("KARTID");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(100)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.LedentegrasyonChid).HasColumnName("LEDENTEGRASYON_CHID");
            entity.Property(e => e.LedentegrasyonUserid).HasColumnName("LEDENTEGRASYON_USERID");
            entity.Property(e => e.Parola)
                .HasMaxLength(100)
                .HasColumnName("PAROLA");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Subeyetki)
                .HasMaxLength(2)
                .HasColumnName("SUBEYETKI");
            entity.Property(e => e.YetkiBarkodsatirsilme).HasColumnName("YETKI_BARKODSATIRSILME");
            entity.Property(e => e.YetkiCaritahsilat).HasColumnName("YETKI_CARITAHSILAT");
            entity.Property(e => e.YetkiFatura).HasColumnName("YETKI_FATURA");
            entity.Property(e => e.YetkiFaturacariiskonto).HasColumnName("YETKI_FATURACARIISKONTO");
            entity.Property(e => e.YetkiFaturafiyatdegistirme).HasColumnName("YETKI_FATURAFIYATDEGISTIRME");
            entity.Property(e => e.YetkiFiyatdegistirme).HasColumnName("YETKI_FIYATDEGISTIRME");
            entity.Property(e => e.YetkiGiderodeme).HasColumnName("YETKI_GIDERODEME");
            entity.Property(e => e.YetkiIrsaliye).HasColumnName("YETKI_IRSALIYE");
            entity.Property(e => e.YetkiMiktardegistirme).HasColumnName("YETKI_MIKTARDEGISTIRME");
            entity.Property(e => e.YetkiOncekifisler)
                .HasMaxLength(2)
                .HasColumnName("YETKI_ONCEKIFISLER");
            entity.Property(e => e.YetkiRaporHareket).HasColumnName("YETKI_RAPOR_HAREKET");
            entity.Property(e => e.YetkiRaporStok).HasColumnName("YETKI_RAPOR_STOK");
            entity.Property(e => e.YetkiSatirsilme).HasColumnName("YETKI_SATIRSILME");
            entity.Property(e => e.YetkiYkSatis).HasColumnName("YETKI_YK_SATIS");
            entity.Property(e => e.YetkiYkXrapor).HasColumnName("YETKI_YK_XRAPOR");
            entity.Property(e => e.YetkiYkZrapor).HasColumnName("YETKI_YK_ZRAPOR");
        });

        modelBuilder.Entity<PosyazarkasaPlu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_posyazarkasa_plu");

            entity.ToTable("posyazarkasa_plu", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birim)
                .HasMaxLength(50)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Birim2)
                .HasMaxLength(50)
                .HasColumnName("BIRIM2");
            entity.Property(e => e.Birim2barkod)
                .HasMaxLength(50)
                .HasColumnName("BIRIM2BARKOD");
            entity.Property(e => e.Birim2carpan)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIM2CARPAN");
            entity.Property(e => e.Birim3)
                .HasMaxLength(50)
                .HasColumnName("BIRIM3");
            entity.Property(e => e.Birim3barkod)
                .HasMaxLength(50)
                .HasColumnName("BIRIM3BARKOD");
            entity.Property(e => e.Birim3carpan)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIM3CARPAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyat2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT2");
            entity.Property(e => e.Grupkod)
                .HasMaxLength(50)
                .HasColumnName("GRUPKOD");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskontomiktar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTOMIKTAR");
            entity.Property(e => e.Iskontoyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTOYUZDE");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kdvdepartman)
                .HasMaxLength(50)
                .HasColumnName("KDVDEPARTMAN");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Pluno).HasColumnName("PLUNO");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tartili)
                .HasMaxLength(10)
                .HasColumnName("TARTILI");
        });

        modelBuilder.Entity<PosyazarkasaPlulog>(entity =>
        {
            entity.ToTable("posyazarkasa_plulog", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Checkdata)
                .HasMaxLength(255)
                .HasColumnName("CHECKDATA");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<PosyazarkasaTransferlog>(entity =>
        {
            entity.ToTable("posyazarkasa_transferlog", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Deger).HasColumnName("DEGER");
            entity.Property(e => e.Islem)
                .HasMaxLength(50)
                .HasColumnName("ISLEM");
            entity.Property(e => e.Kasacevapid).HasColumnName("KASACEVAPID");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Kasamesaj)
                .HasMaxLength(255)
                .HasColumnName("KASAMESAJ");
            entity.Property(e => e.Kasamesajdurum).HasColumnName("KASAMESAJDURUM");
            entity.Property(e => e.Kasamesajid).HasColumnName("KASAMESAJID");
            entity.Property(e => e.Kasamesajtarih)
                .HasColumnType("datetime")
                .HasColumnName("KASAMESAJTARIH");
            entity.Property(e => e.Subeid)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Printlayout>(entity =>
        {
            entity.ToTable("printlayouts", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.Designmode)
                .HasMaxLength(5)
                .HasColumnName("DESIGNMODE");
            entity.Property(e => e.Lafobjectcode)
                .HasMaxLength(100)
                .HasColumnName("LAFOBJECTCODE");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Printlayout1).HasColumnName("PRINTLAYOUT");
            entity.Property(e => e.PrintlayoutHash)
                .HasMaxLength(100)
                .HasColumnName("PRINTLAYOUT_HASH");
            entity.Property(e => e.Printlayoutfr3).HasColumnName("PRINTLAYOUTFR3");
            entity.Property(e => e.Printlayoutfr3Hash)
                .HasMaxLength(100)
                .HasColumnName("PRINTLAYOUTFR3_HASH");
            entity.Property(e => e.Textmode).HasColumnName("TEXTMODE");
            entity.Property(e => e.Users)
                .HasMaxLength(10)
                .HasColumnName("USERS");
        });

        modelBuilder.Entity<PrintlayoutsUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_printlayouts_users");

            entity.ToTable("printlayouts_users", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Printlayoutid).HasColumnName("PRINTLAYOUTID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Projetanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_projetanim");

            entity.ToTable("projetanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<PropLaf>(entity =>
        {
            entity.ToTable("prop_laf", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Declaration)
                .HasMaxLength(255)
                .HasColumnName("DECLARATION");
            entity.Property(e => e.Lafobjectcode)
                .HasMaxLength(100)
                .HasColumnName("LAFOBJECTCODE");
            entity.Property(e => e.Locked).HasColumnName("LOCKED");
            entity.Property(e => e.Recordid).HasColumnName("RECORDID");
            entity.Property(e => e.Updatecount).HasColumnName("UPDATECOUNT");
        });

        modelBuilder.Entity<Recete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recetetanim");

            entity.ToTable("recete", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Birimcarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BIRIMCARPAN");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Cikanfiyatlisteid).HasColumnName("CIKANFIYATLISTEID");
            entity.Property(e => e.Girenfiyatlisteid).HasColumnName("GIRENFIYATLISTEID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Uretimbirimcarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("URETIMBIRIMCARPAN");
            entity.Property(e => e.Uretimbirimid).HasColumnName("URETIMBIRIMID");
            entity.Property(e => e.Uretimbirimmiktartoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("URETIMBIRIMMIKTARTOPLAM");
        });

        modelBuilder.Entity<ReceteAmbalajdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recete_ambalajdetay");

            entity.ToTable("recete_ambalajdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Receteid).HasColumnName("RECETEID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<ReceteDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recete_detay");

            entity.ToTable("recete_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Receteid).HasColumnName("RECETEID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Uretimbirimcarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("URETIMBIRIMCARPAN");
            entity.Property(e => e.Uretimbirimid).HasColumnName("URETIMBIRIMID");
            entity.Property(e => e.Yuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YUZDE");
        });

        modelBuilder.Entity<ReceteKalemciki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recetekalemcikis");

            entity.ToTable("recete_kalemcikis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Receteid).HasColumnName("RECETEID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<ReceteKalemgiris>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recetekalemgiris");

            entity.ToTable("recete_kalemgiris", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Receteid).HasColumnName("RECETEID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Recetesablon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recetesablon");

            entity.ToTable("recetesablon", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<RecetesablonAmbalajdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recetesablon_ambalajdetay");

            entity.ToTable("recetesablon_ambalajdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Recetesablonid).HasColumnName("RECETESABLONID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<RecetesablonDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_recetesablon_detay");

            entity.ToTable("recetesablon_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Recetesablonid).HasColumnName("RECETESABLONID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Uretimbirimcarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("URETIMBIRIMCARPAN");
            entity.Property(e => e.Uretimbirimid).HasColumnName("URETIMBIRIMID");
            entity.Property(e => e.Yuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YUZDE");
        });

        modelBuilder.Entity<Restaurantsati>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_restaurantsatis");

            entity.ToTable("restaurantsatis", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Masaid).HasColumnName("MASAID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Odendi).HasColumnName("ODENDI");
            entity.Property(e => e.Odenenmiktar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ODENENMIKTAR");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Siparisno)
                .HasMaxLength(100)
                .HasColumnName("SIPARISNO");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
        });

        modelBuilder.Entity<Rutplani>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_rutplani");

            entity.ToTable("rutplani", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<RutplaniDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_rutplani_detay");

            entity.ToTable("rutplani_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chgrupid).HasColumnName("CHGRUPID");
            entity.Property(e => e.Gun)
                .HasMaxLength(4)
                .HasColumnName("GUN");
            entity.Property(e => e.Rutplanid).HasColumnName("RUTPLANID");
        });

        modelBuilder.Entity<Sabitgider>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_sabitgider");

            entity.ToTable("sabitgider", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<SahaRafduzenleme>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_saha_rafduzenleme");

            entity.ToTable("saha_rafduzenleme", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.FotografEski)
                .HasColumnType("image")
                .HasColumnName("FOTOGRAF_ESKI");
            entity.Property(e => e.FotografYeni)
                .HasColumnType("image")
                .HasColumnName("FOTOGRAF_YENI");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
        });

        modelBuilder.Entity<Sanalposodemetalebi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_sanalposodemetalebi");

            entity.ToTable("sanalposodemetalebi", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(4000)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Emailgonder).HasColumnName("EMAILGONDER");
            entity.Property(e => e.Emailgonderildi).HasColumnName("EMAILGONDERILDI");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.GonderimzamanEmail)
                .HasColumnType("datetime")
                .HasColumnName("GONDERIMZAMAN_EMAIL");
            entity.Property(e => e.GonderimzamanSms)
                .HasColumnType("datetime")
                .HasColumnName("GONDERIMZAMAN_SMS");
            entity.Property(e => e.Goruntulemesayisi).HasColumnName("GORUNTULEMESAYISI");
            entity.Property(e => e.Linkgecerlilikzaman)
                .HasColumnType("datetime")
                .HasColumnName("LINKGECERLILIKZAMAN");
            entity.Property(e => e.Musteriaciklama)
                .HasMaxLength(4000)
                .HasColumnName("MUSTERIACIKLAMA");
            entity.Property(e => e.Odemeyapildi).HasColumnName("ODEMEYAPILDI");
            entity.Property(e => e.Odemezaman)
                .HasColumnType("datetime")
                .HasColumnName("ODEMEZAMAN");
            entity.Property(e => e.Posanlasmaid).HasColumnName("POSANLASMAID");
            entity.Property(e => e.Posid).HasColumnName("POSID");
            entity.Property(e => e.Provizyonkod)
                .HasMaxLength(100)
                .HasColumnName("PROVIZYONKOD");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Smsgonder).HasColumnName("SMSGONDER");
            entity.Property(e => e.Smsgonderildi).HasColumnName("SMSGONDERILDI");
            entity.Property(e => e.Songoruntulemezaman)
                .HasColumnType("datetime")
                .HasColumnName("SONGORUNTULEMEZAMAN");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tahsilatid).HasColumnName("TAHSILATID");
            entity.Property(e => e.Talepzaman)
                .HasColumnType("datetime")
                .HasColumnName("TALEPZAMAN");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Tutarcalismasekli)
                .HasMaxLength(4)
                .HasColumnName("TUTARCALISMASEKLI");
            entity.Property(e => e.Udid).HasColumnName("UDID");
        });

        modelBuilder.Entity<Sati>(entity =>
        {
            entity.ToTable("satis", "pt");

            entity.HasIndex(e => e.Udid, "INDEX_UNIGUE_UDID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Fisno).HasColumnName("FISNO");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Ledrefid).HasColumnName("LEDREFID");
            entity.Property(e => e.Musteriid).HasColumnName("MUSTERIID");
            entity.Property(e => e.Nakit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NAKIT");
            entity.Property(e => e.Oturumid).HasColumnName("OTURUMID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Pos)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("POS");
            entity.Property(e => e.Posid).HasColumnName("POSID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Satisdanismanid).HasColumnName("SATISDANISMANID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.YkFisno).HasColumnName("YK_FISNO");
            entity.Property(e => e.YkKredino).HasColumnName("YK_KREDINO");
            entity.Property(e => e.YkZno).HasColumnName("YK_ZNO");
        });

        modelBuilder.Entity<Satisdetay>(entity =>
        {
            entity.ToTable("satisdetay", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Iskonto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Satisdanismanid).HasColumnName("SATISDANISMANID");
            entity.Property(e => e.Satisid).HasColumnName("SATISID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Temsilci)
                .HasMaxLength(255)
                .HasColumnName("TEMSILCI");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<Satisteklif>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_satisteklif");

            entity.ToTable("satisteklif", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Ekdokumansayisi).HasColumnName("EKDOKUMANSAYISI");
            entity.Property(e => e.Konu)
                .HasMaxLength(255)
                .HasColumnName("KONU");
            entity.Property(e => e.Kosul).HasColumnName("KOSUL");
            entity.Property(e => e.Odemegun).HasColumnName("ODEMEGUN");
            entity.Property(e => e.Opsiyongun).HasColumnName("OPSIYONGUN");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Teklifno)
                .HasMaxLength(100)
                .HasColumnName("TEKLIFNO");
            entity.Property(e => e.Teklifnot).HasColumnName("TEKLIFNOT");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Teslimgun).HasColumnName("TESLIMGUN");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(255)
                .HasColumnName("YETKILI");
        });

        modelBuilder.Entity<SatisteklifDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_satisteklifdetay");

            entity.ToTable("satisteklif_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Brutgramaj)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BRUTGRAMAJ");
            entity.Property(e => e.Brutgramajbirim)
                .HasMaxLength(3)
                .HasColumnName("BRUTGRAMAJBIRIM");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Gramaj)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("GRAMAJ");
            entity.Property(e => e.Gramajbirim)
                .HasMaxLength(3)
                .HasColumnName("GRAMAJBIRIM");
            entity.Property(e => e.Gtipno)
                .HasMaxLength(100)
                .HasColumnName("GTIPNO");
            entity.Property(e => e.Hacim)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("HACIM");
            entity.Property(e => e.Hacimbirim)
                .HasMaxLength(3)
                .HasColumnName("HACIMBIRIM");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Satisteklifid).HasColumnName("SATISTEKLIFID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Sayim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_sayim");

            entity.ToTable("sayim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktarildi).HasColumnName("AKTARILDI");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Coklusayim).HasColumnName("COKLUSAYIM");
            entity.Property(e => e.Depocikisid).HasColumnName("DEPOCIKISID");
            entity.Property(e => e.Depogirisid).HasColumnName("DEPOGIRISID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sayimtip)
                .HasMaxLength(2)
                .HasColumnName("SAYIMTIP");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip).HasColumnName("TIP");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Uyarlamatarih)
                .HasColumnType("datetime")
                .HasColumnName("UYARLAMATARIH");
        });

        modelBuilder.Entity<SayimDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_sayim_detay");

            entity.ToTable("sayim_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Sayimid).HasColumnName("SAYIMID");
            entity.Property(e => e.Skt)
                .HasColumnType("datetime")
                .HasColumnName("SKT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<Senet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_senet");

            entity.ToTable("senet", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bordroid).HasColumnName("BORDROID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Cirolu).HasColumnName("CIROLU");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.GorselArkayuz)
                .HasColumnType("image")
                .HasColumnName("GORSEL_ARKAYUZ");
            entity.Property(e => e.GorselOnyuz)
                .HasColumnType("image")
                .HasColumnName("GORSEL_ONYUZ");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Kaside)
                .HasMaxLength(255)
                .HasColumnName("KASIDE");
            entity.Property(e => e.Portfoyid).HasColumnName("PORTFOYID");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Senetdurum)
                .HasMaxLength(4)
                .HasColumnName("SENETDURUM");
            entity.Property(e => e.Senetkalantutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("SENETKALANTUTAR");
            entity.Property(e => e.Senetno)
                .HasMaxLength(100)
                .HasColumnName("SENETNO");
            entity.Property(e => e.Senetportfoyid).HasColumnName("SENETPORTFOYID");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");

            entity.HasOne(d => d.Ch).WithMany(p => p.SenetChes)
                .HasForeignKey(d => d.Chid)
                .HasConstraintName("FK_LAF_led_senet_CHıD");

            entity.HasOne(d => d.Portfoy).WithMany(p => p.SenetPortfoys)
                .HasForeignKey(d => d.Portfoyid)
                .HasConstraintName("FK_LAF_led_senet_PORTFOYID");
        });

        modelBuilder.Entity<ServiceLog>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledmobil_service_log");

            entity.ToTable("service_log", "ledmobil");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Mobileuserid).HasColumnName("MOBILEUSERID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Terminalid).HasColumnName("TERMINALID");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Version)
                .HasMaxLength(255)
                .HasColumnName("VERSION");
            entity.Property(e => e.Xmldata)
                .HasColumnType("xml")
                .HasColumnName("XMLDATA");
        });

        modelBuilder.Entity<Sevkiyateleman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_sevkiyateleman");

            entity.ToTable("sevkiyateleman", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .HasColumnName("AD");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Plaka)
                .HasMaxLength(255)
                .HasColumnName("PLAKA");
            entity.Property(e => e.Soyad)
                .HasMaxLength(255)
                .HasColumnName("SOYAD");
            entity.Property(e => e.TasiyiciChid).HasColumnName("TASIYICI_CHID");
            entity.Property(e => e.TasiyiciUnvan)
                .HasMaxLength(255)
                .HasColumnName("TASIYICI_UNVAN");
            entity.Property(e => e.TasiyiciVkn)
                .HasMaxLength(100)
                .HasColumnName("TASIYICI_VKN");
            entity.Property(e => e.Tckn)
                .HasMaxLength(100)
                .HasColumnName("TCKN");
        });

        modelBuilder.Entity<Sipari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_siparis");

            entity.ToTable("siparis", "led", tb => tb.HasTrigger("tg_siparis_update"));

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.B2b).HasColumnName("B2B");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Detayaciklama).HasColumnName("DETAYACIKLAMA");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Gorsel)
                .HasColumnType("image")
                .HasColumnName("GORSEL");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Odemesekli).HasColumnName("ODEMESEKLI");
            entity.Property(e => e.Odemetip)
                .HasMaxLength(4)
                .HasColumnName("ODEMETIP");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadres).HasColumnName("SEVKADRES");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Sevkiyatnotu)
                .HasMaxLength(255)
                .HasColumnName("SEVKIYATNOTU");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Teslimtarih)
                .HasColumnType("datetime")
                .HasColumnName("TESLIMTARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Udid).HasColumnName("UDID");
            entity.Property(e => e.Uretimdurum)
                .HasMaxLength(4)
                .HasColumnName("URETIMDURUM");
            entity.Property(e => e.Uretimtarih)
                .HasColumnType("datetime")
                .HasColumnName("URETIMTARIH");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
        });

        modelBuilder.Entity<SiparisDeger>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_siparis_deger");

            entity.ToTable("siparis_deger", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cisk1tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CISK1TUTAR");
            entity.Property(e => e.Cisk2tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CISK2TUTAR");
            entity.Property(e => e.Ekisk1tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK1TUTAR");
            entity.Property(e => e.Ekisk2tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK2TUTAR");
            entity.Property(e => e.Ekisk3tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK3TUTAR");
            entity.Property(e => e.Ekisk4tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK4TUTAR");
            entity.Property(e => e.Ekisk5tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK5TUTAR");
            entity.Property(e => e.Ekisk6tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK6TUTAR");
            entity.Property(e => e.Ekisk7tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKISK7TUTAR");
            entity.Property(e => e.Iskontotoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTOTOPLAM");
            entity.Property(e => e.Kdvtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KDVTOPLAM");
            entity.Property(e => e.KdvtoplamHam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KDVTOPLAM_HAM");
            entity.Property(e => e.Kisk1tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KISK1TUTAR");
            entity.Property(e => e.Kisk2tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KISK2TUTAR");
            entity.Property(e => e.Kisk3tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KISK3TUTAR");
            entity.Property(e => e.Maltoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MALTOPLAM");
            entity.Property(e => e.Matrahtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MATRAHTOPLAM");
            entity.Property(e => e.MatrahtoplamHam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MATRAHTOPLAM_HAM");
            entity.Property(e => e.Otvtoplam)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("OTVTOPLAM");
            entity.Property(e => e.Siparisdetayid).HasColumnName("SIPARISDETAYID");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<SiparisDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_siparis_detay");

            entity.ToTable("siparis_detay", "led", tb =>
                {
                    tb.HasTrigger("tg_siparisdetay_delete");
                    tb.HasTrigger("tg_siparisdetay_insert");
                });

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ambalajbirim)
                .HasMaxLength(100)
                .HasColumnName("AMBALAJBIRIM");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Eiskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO1");
            entity.Property(e => e.Eiskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO2");
            entity.Property(e => e.Eiskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO3");
            entity.Property(e => e.Eiskonto4)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO4");
            entity.Property(e => e.Eiskonto5)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO5");
            entity.Property(e => e.Eiskonto6)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO6");
            entity.Property(e => e.Eiskonto7)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EISKONTO7");
            entity.Property(e => e.Faturafiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FATURAFIYAT");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Iskonto4)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO4");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Otv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OTV");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Stokdovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("STOKDOVIZCINSI");
            entity.Property(e => e.Stokdovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("STOKDOVIZKUR");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Stokvadetarih)
                .HasColumnType("datetime")
                .HasColumnName("STOKVADETARIH");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<Smskontak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_smskontak");

            entity.ToTable("smskontak", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad).HasColumnName("AD");
            entity.Property(e => e.Adres).HasColumnName("ADRES");
            entity.Property(e => e.Dijitaltel)
                .HasMaxLength(255)
                .HasColumnName("DIJITALTEL");
            entity.Property(e => e.Il).HasColumnName("IL");
            entity.Property(e => e.Ilce).HasColumnName("ILCE");
            entity.Property(e => e.Mahalle).HasColumnName("MAHALLE");
            entity.Property(e => e.Ozelkod1).HasColumnName("OZELKOD1");
            entity.Property(e => e.Ozelkod2).HasColumnName("OZELKOD2");
            entity.Property(e => e.Ozelkod3).HasColumnName("OZELKOD3");
            entity.Property(e => e.Soyad).HasColumnName("SOYAD");
        });

        modelBuilder.Entity<Smtplist>(entity =>
        {
            entity.ToTable("smtplist", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Active).HasColumnName("ACTIVE");
            entity.Property(e => e.Code)
                .HasMaxLength(100)
                .HasColumnName("CODE");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.EmailName)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_NAME");
            entity.Property(e => e.EmailPassword)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_PASSWORD");
            entity.Property(e => e.EmailSmtpPort).HasColumnName("EMAIL_SMTP_PORT");
            entity.Property(e => e.EmailSmtpServer)
                .HasMaxLength(100)
                .HasColumnName("EMAIL_SMTP_SERVER");
            entity.Property(e => e.EmailUsername)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_USERNAME");
            entity.Property(e => e.EmailUsessl).HasColumnName("EMAIL_USESSL");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<Stoktanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim");

            entity.ToTable("stoktanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Ambalajvar).HasColumnName("AMBALAJVAR");
            entity.Property(e => e.Anastokid).HasColumnName("ANASTOKID");
            entity.Property(e => e.Anastokvar).HasColumnName("ANASTOKVAR");
            entity.Property(e => e.Birimalan)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMALAN");
            entity.Property(e => e.BirimalanVar).HasColumnName("BIRIMALAN_VAR");
            entity.Property(e => e.Birimalanbirim).HasColumnName("BIRIMALANBIRIM");
            entity.Property(e => e.Birimbrutgramaj)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMBRUTGRAMAJ");
            entity.Property(e => e.BirimbrutgramajVar).HasColumnName("BIRIMBRUTGRAMAJ_VAR");
            entity.Property(e => e.Birimbrutgramajbirim).HasColumnName("BIRIMBRUTGRAMAJBIRIM");
            entity.Property(e => e.BirimeknitelikVar).HasColumnName("BIRIMEKNITELIK_VAR");
            entity.Property(e => e.Birimeknitelikbirim)
                .HasMaxLength(50)
                .HasColumnName("BIRIMEKNITELIKBIRIM");
            entity.Property(e => e.Birimeknitelikbolen)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMEKNITELIKBOLEN");
            entity.Property(e => e.Birimeknitelikcarpan)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMEKNITELIKCARPAN");
            entity.Property(e => e.Birimgramaj)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMGRAMAJ");
            entity.Property(e => e.BirimgramajVar).HasColumnName("BIRIMGRAMAJ_VAR");
            entity.Property(e => e.Birimgramajbirim).HasColumnName("BIRIMGRAMAJBIRIM");
            entity.Property(e => e.Birimhacim)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMHACIM");
            entity.Property(e => e.BirimhacimVar).HasColumnName("BIRIMHACIM_VAR");
            entity.Property(e => e.Birimhacimbirim).HasColumnName("BIRIMHACIMBIRIM");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.BirimidDepohar).HasColumnName("BIRIMID_DEPOHAR");
            entity.Property(e => e.BirimidF1).HasColumnName("BIRIMID_F1");
            entity.Property(e => e.BirimidF2).HasColumnName("BIRIMID_F2");
            entity.Property(e => e.BirimidFiyatliste).HasColumnName("BIRIMID_FIYATLISTE");
            entity.Property(e => e.BirimidS1).HasColumnName("BIRIMID_S1");
            entity.Property(e => e.BirimidS2).HasColumnName("BIRIMID_S2");
            entity.Property(e => e.BirimidU1).HasColumnName("BIRIMID_U1");
            entity.Property(e => e.BirimidU2).HasColumnName("BIRIMID_U2");
            entity.Property(e => e.Birimsivihacim)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMSIVIHACIM");
            entity.Property(e => e.BirimsivihacimVar).HasColumnName("BIRIMSIVIHACIM_VAR");
            entity.Property(e => e.Birimsivihacimbirim).HasColumnName("BIRIMSIVIHACIMBIRIM");
            entity.Property(e => e.Birimuzunluk)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BIRIMUZUNLUK");
            entity.Property(e => e.BirimuzunlukVar).HasColumnName("BIRIMUZUNLUK_VAR");
            entity.Property(e => e.Birimuzunlukbirim).HasColumnName("BIRIMUZUNLUKBIRIM");
            entity.Property(e => e.Depozitostokid).HasColumnName("DEPOZITOSTOKID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.EfaturaStokisim)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_STOKISIM");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Fiyat1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT1");
            entity.Property(e => e.Fiyat2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT2");
            entity.Property(e => e.Fiyat3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT3");
            entity.Property(e => e.Fiyat4)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT4");
            entity.Property(e => e.Fiyat5)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT5");
            entity.Property(e => e.Fiyatalis)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYATALIS");
            entity.Property(e => e.Fiyatperakende)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYATPERAKENDE");
            entity.Property(e => e.Gtipno)
                .HasMaxLength(100)
                .HasColumnName("GTIPNO");
            entity.Property(e => e.Icindekiler).HasColumnName("ICINDEKILER");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasDefaultValueSql("(N'')")
                .HasComment("Stok Kartı İsmi")
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Kategori10id).HasColumnName("KATEGORI10ID");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kategori4id).HasColumnName("KATEGORI4ID");
            entity.Property(e => e.Kategori5id).HasColumnName("KATEGORI5ID");
            entity.Property(e => e.Kategori6id).HasColumnName("KATEGORI6ID");
            entity.Property(e => e.Kategori7id).HasColumnName("KATEGORI7ID");
            entity.Property(e => e.Kategori8id).HasColumnName("KATEGORI8ID");
            entity.Property(e => e.Kategori9id).HasColumnName("KATEGORI9ID");
            entity.Property(e => e.Kategoriagacid).HasColumnName("KATEGORIAGACID");
            entity.Property(e => e.Kdvyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVYUZDE");
            entity.Property(e => e.Kdvyuzde2)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVYUZDE2");
            entity.Property(e => e.Kdvyuzde3)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVYUZDE3");
            entity.Property(e => e.Kisaisim)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasColumnName("KISAISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasDefaultValueSql("(N'')")
                .HasComment("Stok Kartı Kodu")
                .HasColumnName("KOD");
            entity.Property(e => e.Kritikstok)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KRITIKSTOK");
            entity.Property(e => e.LedmuhAlisfiyatfarkihesapid).HasColumnName("LEDMUH_ALISFIYATFARKIHESAPID");
            entity.Property(e => e.LedmuhAlisfiyatfarkikdvhesapid).HasColumnName("LEDMUH_ALISFIYATFARKIKDVHESAPID");
            entity.Property(e => e.LedmuhAlishesapid).HasColumnName("LEDMUH_ALISHESAPID");
            entity.Property(e => e.LedmuhAlisiadehesapid).HasColumnName("LEDMUH_ALISIADEHESAPID");
            entity.Property(e => e.LedmuhAlisiadekdvhesapid).HasColumnName("LEDMUH_ALISIADEKDVHESAPID");
            entity.Property(e => e.LedmuhDigerkdvhesapid).HasColumnName("LEDMUH_DIGERKDVHESAPID");
            entity.Property(e => e.LedmuhIhracatsatishesapid).HasColumnName("LEDMUH_IHRACATSATISHESAPID");
            entity.Property(e => e.LedmuhIndirilenkdvhesapid).HasColumnName("LEDMUH_INDIRILENKDVHESAPID");
            entity.Property(e => e.LedmuhSatisfiyatfarkihesapid).HasColumnName("LEDMUH_SATISFIYATFARKIHESAPID");
            entity.Property(e => e.LedmuhSatisfiyatfarkikdvhesapid).HasColumnName("LEDMUH_SATISFIYATFARKIKDVHESAPID");
            entity.Property(e => e.LedmuhSatishesapid).HasColumnName("LEDMUH_SATISHESAPID");
            entity.Property(e => e.LedmuhSatisiadehesapid).HasColumnName("LEDMUH_SATISIADEHESAPID");
            entity.Property(e => e.LedmuhSatisiadekdvhesapid).HasColumnName("LEDMUH_SATISIADEKDVHESAPID");
            entity.Property(e => e.LedmuhSatiskdvhesapid).HasColumnName("LEDMUH_SATISKDVHESAPID");
            entity.Property(e => e.LedmuhTevkifatkdvhesapid).HasColumnName("LEDMUH_TEVKIFATKDVHESAPID");
            entity.Property(e => e.LedmuhYurtdisialishesapid).HasColumnName("LEDMUH_YURTDISIALISHESAPID");
            entity.Property(e => e.LedmuhYurtdisiindirilenkdvhesapid).HasColumnName("LEDMUH_YURTDISIINDIRILENKDVHESAPID");
            entity.Property(e => e.LedmuhYurtdisisatishesapid).HasColumnName("LEDMUH_YURTDISISATISHESAPID");
            entity.Property(e => e.LedmuhYurtdisisatiskdvhesapid).HasColumnName("LEDMUH_YURTDISISATISKDVHESAPID");
            entity.Property(e => e.Maxfiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MAXFIYAT");
            entity.Property(e => e.Maxisk1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MAXISK1");
            entity.Property(e => e.Maxisk2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MAXISK2");
            entity.Property(e => e.Maxisk3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MAXISK3");
            entity.Property(e => e.Maxstok)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MAXSTOK");
            entity.Property(e => e.Mensei)
                .HasMaxLength(100)
                .HasColumnName("MENSEI");
            entity.Property(e => e.Minfiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MINFIYAT");
            entity.Property(e => e.Minisk1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MINISK1");
            entity.Property(e => e.Minisk2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MINISK2");
            entity.Property(e => e.Minisk3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MINISK3");
            entity.Property(e => e.MuhasebeAlisfiyatfarki)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_ALISFIYATFARKI");
            entity.Property(e => e.MuhasebeAlisfiyatfarkikdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_ALISFIYATFARKIKDV");
            entity.Property(e => e.MuhasebeAlisiade)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_ALISIADE");
            entity.Property(e => e.MuhasebeAliskod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_ALISKOD");
            entity.Property(e => e.MuhasebeIhracatsatiskod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_IHRACATSATISKOD");
            entity.Property(e => e.MuhasebeIndirilenkdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_INDIRILENKDV");
            entity.Property(e => e.MuhasebeIskontokod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_ISKONTOKOD");
            entity.Property(e => e.MuhasebeIthalataliskdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_ITHALATALISKDV");
            entity.Property(e => e.MuhasebeIthalataliskod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_ITHALATALISKOD");
            entity.Property(e => e.MuhasebeKod1)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_KOD1");
            entity.Property(e => e.MuhasebeKod2)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_KOD2");
            entity.Property(e => e.MuhasebePerakendekdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_PERAKENDEKDV");
            entity.Property(e => e.MuhasebePerakendekod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_PERAKENDEKOD");
            entity.Property(e => e.MuhasebeSatisfiyatfarki)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_SATISFIYATFARKI");
            entity.Property(e => e.MuhasebeSatisfiyatfarkikdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_SATISFIYATFARKIKDV");
            entity.Property(e => e.MuhasebeSatisiade)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_SATISIADE");
            entity.Property(e => e.MuhasebeSatiskdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_SATISKDV");
            entity.Property(e => e.MuhasebeSatiskod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_SATISKOD");
            entity.Property(e => e.MuhasebeStopajkod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_STOPAJKOD");
            entity.Property(e => e.MuhasebeTevkifatkdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_TEVKIFATKDV");
            entity.Property(e => e.MuhasebeYurtdisialiskod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_YURTDISIALISKOD");
            entity.Property(e => e.MuhasebeYurtdisiindirilenkdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_YURTDISIINDIRILENKDV");
            entity.Property(e => e.MuhasebeYurtdisisatiskdv)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_YURTDISISATISKDV");
            entity.Property(e => e.MuhasebeYurtdisisatiskod)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBE_YURTDISISATISKOD");
            entity.Property(e => e.Otvkullaniliyor).HasColumnName("OTVKULLANILIYOR");
            entity.Property(e => e.Otvyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OTVYUZDE");
            entity.Property(e => e.Ozelkod1)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD1");
            entity.Property(e => e.Ozelkod2)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD2");
            entity.Property(e => e.Ozelkod3)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD3");
            entity.Property(e => e.Ozelkod4)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD4");
            entity.Property(e => e.Ozelkod5)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD5");
            entity.Property(e => e.Ozelmatrahfiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("OZELMATRAHFIYAT");
            entity.Property(e => e.Ozelmatrahvar).HasColumnName("OZELMATRAHVAR");
            entity.Property(e => e.Partinovar).HasColumnName("PARTINOVAR");
            entity.Property(e => e.PerakendeB2ckullan).HasColumnName("PERAKENDE_B2CKULLAN");
            entity.Property(e => e.PerakendeDepartmanid).HasColumnName("PERAKENDE_DEPARTMANID");
            entity.Property(e => e.PerakendeHedefkarmarji)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PERAKENDE_HEDEFKARMARJI");
            entity.Property(e => e.PerakendeKdvyuzde1)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PERAKENDE_KDVYUZDE");
            entity.Property(e => e.PerakendeKullan).HasColumnName("PERAKENDE_KULLAN");
            entity.Property(e => e.PerakendeMaxiskonto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PERAKENDE_MAXISKONTO");
            entity.Property(e => e.PerakendeOzelkdv).HasColumnName("PERAKENDE_OZELKDV");
            entity.Property(e => e.PerakendePluno).HasColumnName("PERAKENDE_PLUNO");
            entity.Property(e => e.PerakendeSonkullanmagun).HasColumnName("PERAKENDE_SONKULLANMAGUN");
            entity.Property(e => e.PerakendeTerazigonder).HasColumnName("PERAKENDE_TERAZIGONDER");
            entity.Property(e => e.PerakendeUrunlisteGorsel)
                .HasColumnType("image")
                .HasColumnName("PERAKENDE_URUNLISTE_GORSEL");
            entity.Property(e => e.PerakendeUrunlisteGoster).HasColumnName("PERAKENDE_URUNLISTE_GOSTER");
            entity.Property(e => e.PerakendeUrunlisteGrup)
                .HasMaxLength(255)
                .HasColumnName("PERAKENDE_URUNLISTE_GRUP");
            entity.Property(e => e.PerakendeUrunlisteSira).HasColumnName("PERAKENDE_URUNLISTE_SIRA");
            entity.Property(e => e.PerakendeUrunlisteTerazikullan)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PERAKENDE_URUNLISTE_TERAZIKULLAN");
            entity.Property(e => e.PerakendeVeresiyeiskonto)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("PERAKENDE_VERESIYEISKONTO");
            entity.Property(e => e.PerakendeVeresiyeiskontotip)
                .HasMaxLength(4)
                .HasColumnName("PERAKENDE_VERESIYEISKONTOTIP");
            entity.Property(e => e.Perakendekdvyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("PERAKENDEKDVYUZDE");
            entity.Property(e => e.PerakendesiparisKullan).HasColumnName("PERAKENDESIPARIS_KULLAN");
            entity.Property(e => e.Programkod)
                .HasMaxLength(127)
                .HasColumnName("PROGRAMKOD");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Rafomru).HasColumnName("RAFOMRU");
            entity.Property(e => e.Receteid).HasColumnName("RECETEID");
            entity.Property(e => e.Recetesabloncarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("RECETESABLONCARPAN");
            entity.Property(e => e.Recetesablonid).HasColumnName("RECETESABLONID");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("RESIM");
            entity.Property(e => e.Resim2)
                .HasColumnType("image")
                .HasColumnName("RESIM2");
            entity.Property(e => e.Resim3)
                .HasColumnType("image")
                .HasColumnName("RESIM3");
            entity.Property(e => e.Resim4)
                .HasColumnType("image")
                .HasColumnName("RESIM4");
            entity.Property(e => e.Serinokullaniliyor)
                .HasMaxLength(4)
                .HasColumnName("SERINOKULLANILIYOR");
            entity.Property(e => e.Serinovar).HasColumnName("SERINOVAR");
            entity.Property(e => e.Sktgun).HasColumnName("SKTGUN");
            entity.Property(e => e.Sktkullaniliyor)
                .HasMaxLength(4)
                .HasColumnName("SKTKULLANILIYOR");
            entity.Property(e => e.Stokvadegun).HasColumnName("STOKVADEGUN");
            entity.Property(e => e.Stokvadekullaniliyor).HasColumnName("STOKVADEKULLANILIYOR");
            entity.Property(e => e.Stokvadetip).HasColumnName("STOKVADETIP");
            entity.Property(e => e.Tevkifatyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TEVKIFATYUZDE");
            entity.Property(e => e.Tip).HasColumnName("TIP");
            entity.Property(e => e.Urunlistesira).HasColumnName("URUNLISTESIRA");
            entity.Property(e => e.Uruntip)
                .HasMaxLength(4)
                .HasColumnName("URUNTIP");
            entity.Property(e => e.Vadekullaniliyor).HasColumnName("VADEKULLANILIYOR");
            entity.Property(e => e.Varyasyonvar).HasColumnName("VARYASYONVAR");
        });

        modelBuilder.Entity<StoktanimAmbalajbirim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_ambalajbirim");

            entity.ToTable("stoktanim_ambalajbirim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(100)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<StoktanimAmbalajkullanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_ambalajkullanim");

            entity.ToTable("stoktanim_ambalajkullanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Esikbuyukdeger)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ESIKBUYUKDEGER");
            entity.Property(e => e.Esikdegerkullan).HasColumnName("ESIKDEGERKULLAN");
            entity.Property(e => e.Esikkucukdeger)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ESIKKUCUKDEGER");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimBarkod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_barkod");

            entity.ToTable("stoktanim_barkod", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Barkod)
                .HasMaxLength(100)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Esikdegerkullan).HasColumnName("ESIKDEGERKULLAN");
            entity.Property(e => e.Sablonid).HasColumnName("SABLONID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<StoktanimBarkodsablon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim.barkodsablon");

            entity.ToTable("stoktanim_barkodsablon", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Ambalajmiktarbaslangic).HasColumnName("AMBALAJMIKTARBASLANGIC");
            entity.Property(e => e.Ambalajmiktargenislik).HasColumnName("AMBALAJMIKTARGENISLIK");
            entity.Property(e => e.Ambalajmiktarkullan).HasColumnName("AMBALAJMIKTARKULLAN");
            entity.Property(e => e.Fiyatbaslangic).HasColumnName("FIYATBASLANGIC");
            entity.Property(e => e.Fiyatgenislik).HasColumnName("FIYATGENISLIK");
            entity.Property(e => e.Fiyatkullan).HasColumnName("FIYATKULLAN");
            entity.Property(e => e.Isim)
                .HasMaxLength(100)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(50)
                .HasColumnName("KOD");
            entity.Property(e => e.Kodbaslangic).HasColumnName("KODBASLANGIC");
            entity.Property(e => e.Kodgenislik).HasColumnName("KODGENISLIK");
            entity.Property(e => e.Miktarbaslangic).HasColumnName("MIKTARBASLANGIC");
            entity.Property(e => e.Miktarcarpan)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("MIKTARCARPAN");
            entity.Property(e => e.Miktargenislik).HasColumnName("MIKTARGENISLIK");
            entity.Property(e => e.Miktarkullan).HasColumnName("MIKTARKULLAN");
            entity.Property(e => e.Partinobaslangic).HasColumnName("PARTINOBASLANGIC");
            entity.Property(e => e.Partinogenislik).HasColumnName("PARTINOGENISLIK");
            entity.Property(e => e.Partinokullan).HasColumnName("PARTINOKULLAN");
            entity.Property(e => e.Serinobaslangic).HasColumnName("SERINOBASLANGIC");
            entity.Property(e => e.Serinogenislik).HasColumnName("SERINOGENISLIK");
            entity.Property(e => e.Serinokullan).HasColumnName("SERINOKULLAN");
            entity.Property(e => e.Sktbaslangic).HasColumnName("SKTBASLANGIC");
            entity.Property(e => e.Sktbicim)
                .HasMaxLength(30)
                .HasColumnName("SKTBICIM");
            entity.Property(e => e.Sktgenislik).HasColumnName("SKTGENISLIK");
            entity.Property(e => e.Sktkullan).HasColumnName("SKTKULLAN");
        });

        modelBuilder.Entity<StoktanimBirim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_birimtanim");

            entity.ToTable("stoktanim_birim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(100)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(10)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<StoktanimBirimcevrim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_birimcevrim");

            entity.ToTable("stoktanim_birimcevrim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimDepo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_depo");

            entity.ToTable("stoktanim_depo", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Maxmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MAXMIKTAR");
            entity.Property(e => e.Minmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MINMIKTAR");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Uygunmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("UYGUNMIKTAR");
        });

        modelBuilder.Entity<StoktanimDepoadre>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_depoadres");

            entity.ToTable("stoktanim_depoadres", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Depoadresid).HasColumnName("DEPOADRESID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimEtiketfi>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_etiketfis");

            entity.ToTable("stoktanim_etiketfis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Fiyat2listeid).HasColumnName("FIYAT2LISTEID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Fiyatlistekullan).HasColumnName("FIYATLISTEKULLAN");
            entity.Property(e => e.Gorselkullan).HasColumnName("GORSELKULLAN");
            entity.Property(e => e.Sabitetiketadet).HasColumnName("SABITETIKETADET");
            entity.Property(e => e.Sabitetiketadetkullan).HasColumnName("SABITETIKETADETKULLAN");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
        });

        modelBuilder.Entity<StoktanimEtiketfisdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_etiketfisdetay");

            entity.ToTable("stoktanim_etiketfisdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Etiketadet).HasColumnName("ETIKETADET");
            entity.Property(e => e.Etiketfisid).HasColumnName("ETIKETFISID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyat2)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FIYAT2");
            entity.Property(e => e.Sonkullanmatarih)
                .HasColumnType("datetime")
                .HasColumnName("SONKULLANMATARIH");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Uretimtarih)
                .HasColumnType("datetime")
                .HasColumnName("URETIMTARIH");
        });

        modelBuilder.Entity<StoktanimGrup>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_grup");

            entity.ToTable("stoktanim_grup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<StoktanimGrupdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_grupdetay");

            entity.ToTable("stoktanim_grupdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Stokgrupid).HasColumnName("STOKGRUPID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimGrupdetaygrup>(entity =>
        {
            entity.ToTable("stoktanim_grupdetaygrup", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Grupid).HasColumnName("GRUPID");
            entity.Property(e => e.Stokgrupid).HasColumnName("STOKGRUPID");
        });

        modelBuilder.Entity<StoktanimHizmetkdv>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_hizmetkdv");

            entity.ToTable("stoktanim_hizmetkdv", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Indirilecekkdv)
                .HasMaxLength(100)
                .HasColumnName("INDIRILECEKKDV");
            entity.Property(e => e.Kdvyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVYUZDE");
            entity.Property(e => e.Satiskdvkod)
                .HasMaxLength(100)
                .HasColumnName("SATISKDVKOD");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimKoddonusum>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_koddonusum");

            entity.ToTable("stoktanim_koddonusum", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<StoktanimKoddonusumCari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_koddonusum_cari");

            entity.ToTable("stoktanim_koddonusum_cari", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Urunanlasmaid).HasColumnName("URUNANLASMAID");
        });

        modelBuilder.Entity<StoktanimKoddonusumDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_koddonusum_detay");

            entity.ToTable("stoktanim_koddonusum_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Urunanlasmaid).HasColumnName("URUNANLASMAID");
        });

        modelBuilder.Entity<StoktanimLisan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_lisan");

            entity.ToTable("stoktanim_lisan", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Dil)
                .HasMaxLength(10)
                .HasColumnName("DIL");
            entity.Property(e => e.Isim).HasColumnName("ISIM");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimPerakendedepartman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_perakendedepartman");

            entity.ToTable("stoktanim_perakendedepartman", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(100)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kdvyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVYUZDE");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<StoktanimRecete>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_recete");

            entity.ToTable("stoktanim_recete", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Recetestokid).HasColumnName("RECETESTOKID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimSubedetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_subedetay");

            entity.ToTable("stoktanim_subedetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<StoktanimTedarikci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_tedarikci");

            entity.ToTable("stoktanim_tedarikci", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<StoktanimVaryasyon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stoktanim_varyasyon");

            entity.ToTable("stoktanim_varyasyon", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");

            entity.HasOne(d => d.Stok).WithMany(p => p.StoktanimVaryasyons)
                .HasForeignKey(d => d.Stokid)
                .HasConstraintName("FK_LAF_led_stoktanim_varyasyon_STOKID");
        });

        modelBuilder.Entity<Stokuretimetiket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stokuretimetiket");

            entity.ToTable("stokuretimetiket", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama1)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA1");
            entity.Property(e => e.Aciklama2)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA2");
            entity.Property(e => e.Aciklama3)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA3");
            entity.Property(e => e.Aciklama4)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA4");
            entity.Property(e => e.Aciklama5)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA5");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Barkod)
                .HasMaxLength(50)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Dizaynid).HasColumnName("DIZAYNID");
            entity.Property(e => e.Kategori1)
                .HasMaxLength(100)
                .HasColumnName("KATEGORI1");
            entity.Property(e => e.Kategori2)
                .HasMaxLength(100)
                .HasColumnName("KATEGORI2");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Stokisim)
                .HasMaxLength(100)
                .HasColumnName("STOKISIM");
            entity.Property(e => e.Stokkod)
                .HasMaxLength(50)
                .HasColumnName("STOKKOD");
            entity.Property(e => e.Stokuretimetiketdepartmanid).HasColumnName("STOKURETIMETIKETDEPARTMANID");
        });

        modelBuilder.Entity<Stokuretimetiketdepartman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stokuretimetiketdepartman");

            entity.ToTable("stokuretimetiketdepartman", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Stokuretimetiketdetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stokuertimetiketdetay");

            entity.ToTable("stokuretimetiketdetay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ciktiid).HasColumnName("CIKTIID");
            entity.Property(e => e.Istasyonkod)
                .HasMaxLength(50)
                .HasColumnName("ISTASYONKOD");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Personelkod)
                .HasMaxLength(100)
                .HasColumnName("PERSONELKOD");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Skt)
                .HasColumnType("datetime")
                .HasColumnName("SKT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Stokuretimetiketdizayn>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stokuretimetiketdizayn");

            entity.ToTable("stokuretimetiketdizayn", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Frxdosyaid).HasColumnName("FRXDOSYAID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Stokvirman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stokvirman");

            entity.ToTable("stokvirman", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<StokvirmanCiki>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stokvirman_cikis");

            entity.ToTable("stokvirman_cikis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Stokvirmanid).HasColumnName("STOKVIRMANID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<StokvirmanGiris>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_stokvirman_giris");

            entity.ToTable("stokvirman_giris", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Stokvirmanid).HasColumnName("STOKVIRMANID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Subeayarsablon>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subeayarsablon");

            entity.ToTable("subeayarsablon", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DllPerakendemodul).HasColumnName("DLL_PERAKENDEMODUL");
            entity.Property(e => e.FaturaciktiText).HasColumnName("FATURACIKTI_TEXT");
            entity.Property(e => e.FrxBeklemefiscikti).HasColumnName("FRX_BEKLEMEFISCIKTI");
            entity.Property(e => e.FrxCekmececikti).HasColumnName("FRX_CEKMECECIKTI");
            entity.Property(e => e.FrxFaturacikti).HasColumnName("FRX_FATURACIKTI");
            entity.Property(e => e.FrxFaturaciktiEarsivfatura).HasColumnName("FRX_FATURACIKTI_EARSIVFATURA");
            entity.Property(e => e.FrxFaturaciktiEfatura).HasColumnName("FRX_FATURACIKTI_EFATURA");
            entity.Property(e => e.FrxFiscikti).HasColumnName("FRX_FISCIKTI");
            entity.Property(e => e.FrxMalkabulcikti).HasColumnName("FRX_MALKABULCIKTI");
            entity.Property(e => e.FrxOturumsonucikti).HasColumnName("FRX_OTURUMSONUCIKTI");
            entity.Property(e => e.FrxSipariscikti).HasColumnName("FRX_SIPARISCIKTI");
            entity.Property(e => e.FrxTahsilatcikti).HasColumnName("FRX_TAHSILATCIKTI");
            entity.Property(e => e.FrxVeresiyeekstrecikti).HasColumnName("FRX_VERESIYEEKSTRECIKTI");
            entity.Property(e => e.FrxVeresiyetahsilatfiscikti).HasColumnName("FRX_VERESIYETAHSILATFISCIKTI");
            entity.Property(e => e.GorselLogo).HasColumnName("GORSEL_LOGO");
            entity.Property(e => e.GorselMusteriekran).HasColumnName("GORSEL_MUSTERIEKRAN");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.MusteriekranKullan).HasColumnName("MUSTERIEKRAN_KULLAN");
            entity.Property(e => e.MusteriekranVideolink)
                .HasMaxLength(255)
                .HasColumnName("MUSTERIEKRAN_VIDEOLINK");
            entity.Property(e => e.MusteriekranVideolinkAyri).HasColumnName("MUSTERIEKRAN_VIDEOLINK_AYRI");
            entity.Property(e => e.TahsilatciktiText).HasColumnName("TAHSILATCIKTI_TEXT");
        });

        modelBuilder.Entity<Subeizlemenot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subeizlemenot");

            entity.ToTable("subeizlemenot", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Konu)
                .HasMaxLength(1000)
                .HasColumnName("KONU");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Personelisim)
                .HasMaxLength(255)
                .HasColumnName("PERSONELISIM");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sonuc).HasColumnName("SONUC");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Yildiz).HasColumnName("YILDIZ");
            entity.Property(e => e.Yoneticiaciklama).HasColumnName("YONETICIACIKLAMA");
        });

        modelBuilder.Entity<Subetanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_subetanim");

            entity.ToTable("subetanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Adres).HasColumnName("ADRES");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(100)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Il)
                .HasMaxLength(255)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(255)
                .HasColumnName("ILCE");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Subetanim1>(entity =>
        {
            entity.ToTable("subetanim", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Acilistarih)
                .HasColumnType("datetime")
                .HasColumnName("ACILISTARIH");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Ammyyid)
                .HasMaxLength(10)
                .HasColumnName("AMMYYID");
            entity.Property(e => e.B2ckullan).HasColumnName("B2CKULLAN");
            entity.Property(e => e.Calisansayisi).HasColumnName("CALISANSAYISI");
            entity.Property(e => e.Chgrupid).HasColumnName("CHGRUPID");
            entity.Property(e => e.Earsivserino)
                .HasMaxLength(3)
                .HasColumnName("EARSIVSERINO");
            entity.Property(e => e.Efaturaserino)
                .HasMaxLength(3)
                .HasColumnName("EFATURASERINO");
            entity.Property(e => e.Entegrasyonkod1)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD1");
            entity.Property(e => e.Entegrasyonkod2)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD2");
            entity.Property(e => e.Entegrasyonkod3)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD3");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Gidergrupid).HasColumnName("GIDERGRUPID");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Gsm)
                .HasMaxLength(15)
                .HasColumnName("GSM");
            entity.Property(e => e.Gsmkisa)
                .HasMaxLength(10)
                .HasColumnName("GSMKISA");
            entity.Property(e => e.Il)
                .HasMaxLength(50)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ILCE");
            entity.Property(e => e.Insertfiyatlisteid).HasColumnName("INSERTFIYATLISTEID");
            entity.Property(e => e.Ipadres)
                .HasMaxLength(20)
                .HasColumnName("IPADRES");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kapanissebep)
                .HasMaxLength(255)
                .HasColumnName("KAPANISSEBEP");
            entity.Property(e => e.Kapanistarih)
                .HasColumnType("datetime")
                .HasColumnName("KAPANISTARIH");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.LedentegrasyonChid).HasColumnName("LEDENTEGRASYON_CHID");
            entity.Property(e => e.LedentegrasyonDepoid).HasColumnName("LEDENTEGRASYON_DEPOID");
            entity.Property(e => e.LedentegrasyonEvraktip)
                .HasMaxLength(4)
                .HasColumnName("LEDENTEGRASYON_EVRAKTIP");
            entity.Property(e => e.LedentegrasyonGunsonuayar)
                .HasMaxLength(4)
                .HasColumnName("LEDENTEGRASYON_GUNSONUAYAR");
            entity.Property(e => e.LedentegrasyonKasaid).HasColumnName("LEDENTEGRASYON_KASAID");
            entity.Property(e => e.LedentegrasyonKdvdahil).HasColumnName("LEDENTEGRASYON_KDVDAHIL");
            entity.Property(e => e.LedentegrasyonPosid).HasColumnName("LEDENTEGRASYON_POSID");
            entity.Property(e => e.LedentegrasyonSevkadresid).HasColumnName("LEDENTEGRASYON_SEVKADRESID");
            entity.Property(e => e.LedentegrasyonSubeid).HasColumnName("LEDENTEGRASYON_SUBEID");
            entity.Property(e => e.LedentegrasyonTeslimatkasaid).HasColumnName("LEDENTEGRASYON_TESLIMATKASAID");
            entity.Property(e => e.Ozelfiyatlisteid).HasColumnName("OZELFIYATLISTEID");
            entity.Property(e => e.Ozelkod1)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD1");
            entity.Property(e => e.Ozelkod2)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD2");
            entity.Property(e => e.Posterminalno)
                .HasMaxLength(30)
                .HasColumnName("POSTERMINALNO");
            entity.Property(e => e.Posuyeisyerino)
                .HasMaxLength(30)
                .HasColumnName("POSUYEISYERINO");
            entity.Property(e => e.Sevkdepogrupid).HasColumnName("SEVKDEPOGRUPID");
            entity.Property(e => e.Sfiyatlisteid).HasColumnName("SFIYATLISTEID");
            entity.Property(e => e.Siparisplanid).HasColumnName("SIPARISPLANID");
            entity.Property(e => e.Stokgrupid).HasColumnName("STOKGRUPID");
            entity.Property(e => e.Subekapandi).HasColumnName("SUBEKAPANDI");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
        });

        modelBuilder.Entity<SubetanimKasa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_kasa");

            entity.ToTable("subetanim_kasa", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Baglicekmece)
                .HasMaxLength(100)
                .HasColumnName("BAGLICEKMECE");
            entity.Property(e => e.Baglicekmeceport)
                .HasMaxLength(100)
                .HasColumnName("BAGLICEKMECEPORT");
            entity.Property(e => e.Bagliyazarkasa)
                .HasMaxLength(20)
                .HasColumnName("BAGLIYAZARKASA");
            entity.Property(e => e.Bilgiekrancomport)
                .HasMaxLength(10)
                .HasColumnName("BILGIEKRANCOMPORT");
            entity.Property(e => e.Carigrupid).HasColumnName("CARIGRUPID");
            entity.Property(e => e.Carikategori1id).HasColumnName("CARIKATEGORI1ID");
            entity.Property(e => e.Carikategori2id).HasColumnName("CARIKATEGORI2ID");
            entity.Property(e => e.Carikategori3id).HasColumnName("CARIKATEGORI3ID");
            entity.Property(e => e.Carikategori4id).HasColumnName("CARIKATEGORI4ID");
            entity.Property(e => e.Carikategori5id).HasColumnName("CARIKATEGORI5ID");
            entity.Property(e => e.Dogrudanalimkullan).HasColumnName("DOGRUDANALIMKULLAN");
            entity.Property(e => e.Faturakullan).HasColumnName("FATURAKULLAN");
            entity.Property(e => e.Fisbekletkullan)
                .HasMaxLength(4)
                .HasColumnName("FISBEKLETKULLAN");
            entity.Property(e => e.Gunsonukullan).HasColumnName("GUNSONUKULLAN");
            entity.Property(e => e.Hariciterazitip)
                .HasMaxLength(20)
                .HasColumnName("HARICITERAZITIP");
            entity.Property(e => e.Irsaliyekullan).HasColumnName("IRSALIYEKULLAN");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Masahesapkullan).HasColumnName("MASAHESAPKULLAN");
            entity.Property(e => e.Personelfaturakullan).HasColumnName("PERSONELFATURAKULLAN");
            entity.Property(e => e.Sabitfaturayazici)
                .HasMaxLength(255)
                .HasColumnName("SABITFATURAYAZICI");
            entity.Property(e => e.Sabitfisyazici)
                .HasMaxLength(255)
                .HasColumnName("SABITFISYAZICI");
            entity.Property(e => e.Satiskullanimtip)
                .HasMaxLength(4)
                .HasColumnName("SATISKULLANIMTIP");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Subesablonid).HasColumnName("SUBESABLONID");
            entity.Property(e => e.Tahsilatkullan).HasColumnName("TAHSILATKULLAN");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Terazicomport)
                .HasMaxLength(10)
                .HasColumnName("TERAZICOMPORT");
            entity.Property(e => e.Teraziserbestmiktar)
                .HasMaxLength(4)
                .HasColumnName("TERAZISERBESTMIKTAR");
            entity.Property(e => e.Terazitip)
                .HasMaxLength(100)
                .HasColumnName("TERAZITIP");
            entity.Property(e => e.Yazarkasafaturakullan).HasColumnName("YAZARKASAFATURAKULLAN");
            entity.Property(e => e.Yazarkasagiderpusulasikullan).HasColumnName("YAZARKASAGIDERPUSULASIKULLAN");
        });

        modelBuilder.Entity<SubetanimKasaPo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_kasa_pos");

            entity.ToTable("subetanim_kasa_pos", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Posid).HasColumnName("POSID");
        });

        modelBuilder.Entity<SubetanimKullanici>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_subetanim_kullanici");

            entity.ToTable("subetanim_kullanici", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<SubetanimSabitmasraf>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_sabitmasraf");

            entity.ToTable("subetanim_sabitmasraf", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aylik)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("AYLIK");
            entity.Property(e => e.Baslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIH");
            entity.Property(e => e.Bitistarih)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIH");
            entity.Property(e => e.Sabitgiderid).HasColumnName("SABITGIDERID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<SubetanimSatisdanisman>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_satisdanisman");

            entity.ToTable("subetanim_satisdanisman", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<SubetanimSiparisplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_siparisplan");

            entity.ToTable("subetanim_siparisplan", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<SubetanimSiparisplandetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_siparisplandetay");

            entity.ToTable("subetanim_siparisplandetay", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Baslangicsaat)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICSAAT");
            entity.Property(e => e.Bitissaat)
                .HasColumnType("datetime")
                .HasColumnName("BITISSAAT");
            entity.Property(e => e.Siparisizin).HasColumnName("SIPARISIZIN");
            entity.Property(e => e.Siparisplanid).HasColumnName("SIPARISPLANID");
            entity.Property(e => e.Stokkategoriid).HasColumnName("STOKKATEGORIID");
            entity.Property(e => e.Teslimgun).HasColumnName("TESLIMGUN");
        });

        modelBuilder.Entity<SubetanimStokbarkod>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_stokbarkod");

            entity.ToTable("subetanim_stokbarkod", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Barkod)
                .HasMaxLength(100)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<SubetanimYazarkasa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_subetanim_yazarkasa");

            entity.ToTable("subetanim_yazarkasa", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Dosyauzanti)
                .HasMaxLength(100)
                .HasColumnName("DOSYAUZANTI");
            entity.Property(e => e.Iletisimdizin)
                .HasMaxLength(255)
                .HasColumnName("ILETISIMDIZIN");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Kontroldizin)
                .HasMaxLength(255)
                .HasColumnName("KONTROLDIZIN");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Veridizin)
                .HasMaxLength(255)
                .HasColumnName("VERIDIZIN");
            entity.Property(e => e.Yazarkasarefid).HasColumnName("YAZARKASAREFID");
            entity.Property(e => e.Yazarkasatip)
                .HasMaxLength(20)
                .HasColumnName("YAZARKASATIP");
        });

        modelBuilder.Entity<Surucu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_surucu");

            entity.ToTable("surucu", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("ADRES");
            entity.Property(e => e.BelgeGecerlilikTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BELGE_GECERLILIK_TARIHI");
            entity.Property(e => e.BelgeNo)
                .HasMaxLength(255)
                .HasColumnName("BELGE_NO");
            entity.Property(e => e.BelgeVerilisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("BELGE_VERILIS_TARIHI");
            entity.Property(e => e.DogumTarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOGUM_TARIHI");
            entity.Property(e => e.DogumYeri)
                .HasMaxLength(255)
                .HasColumnName("DOGUM_YERI");
            entity.Property(e => e.EMail)
                .HasMaxLength(255)
                .HasColumnName("E_MAIL");
            entity.Property(e => e.EhliyetArka)
                .HasColumnType("image")
                .HasColumnName("EHLIYET_ARKA");
            entity.Property(e => e.EhliyetOn)
                .HasColumnType("image")
                .HasColumnName("EHLIYET_ON");
            entity.Property(e => e.EvTel)
                .HasMaxLength(100)
                .HasColumnName("EV_TEL");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.K1)
                .HasMaxLength(100)
                .HasColumnName("K_1");
            entity.Property(e => e.K1Tarih)
                .HasColumnType("datetime")
                .HasColumnName("K_1_TARIH");
            entity.Property(e => e.Kangrubu)
                .HasMaxLength(100)
                .HasColumnName("KANGRUBU");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(255)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Resim)
                .HasColumnType("image")
                .HasColumnName("RESIM");
            entity.Property(e => e.Sifre)
                .HasMaxLength(255)
                .HasColumnName("SIFRE");
            entity.Property(e => e.SrcBelge)
                .HasMaxLength(100)
                .HasColumnName("SRC_BELGE");
            entity.Property(e => e.SrcTarih)
                .HasColumnType("datetime")
                .HasColumnName("SRC_TARIH");
            entity.Property(e => e.SurucuSicilNo)
                .HasMaxLength(100)
                .HasColumnName("SURUCU_SICIL_NO");
            entity.Property(e => e.SurucuTc)
                .HasMaxLength(11)
                .HasColumnName("SURUCU_TC");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(100)
                .HasColumnName("TEL2");
            entity.Property(e => e.Tip).HasColumnName("TIP");
            entity.Property(e => e.UluslararasiDolasimBelgesi)
                .HasMaxLength(100)
                .HasColumnName("ULUSLARARASI_DOLASIM_BELGESI");
            entity.Property(e => e.UluslararasiDolasimBelgesiTarih)
                .HasColumnType("datetime")
                .HasColumnName("ULUSLARARASI_DOLASIM_BELGESI_TARIH");
            entity.Property(e => e.Uyruk)
                .HasMaxLength(100)
                .HasColumnName("UYRUK");
        });

        modelBuilder.Entity<SurucuEhliyet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_surucu_ehliyet");

            entity.ToTable("surucu_ehliyet", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EhliyetSinif)
                .HasMaxLength(255)
                .HasColumnName("EHLIYET_SINIF");
            entity.Property(e => e.GecerlilikTarihi)
                .HasColumnType("datetime")
                .HasColumnName("GECERLILIK_TARIHI");
            entity.Property(e => e.Surucuid).HasColumnName("SURUCUID");
            entity.Property(e => e.VerilisTarihi)
                .HasColumnType("datetime")
                .HasColumnName("VERILIS_TARIHI");
        });

        modelBuilder.Entity<Template>(entity =>
        {
            entity.ToTable("templates", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
        });

        modelBuilder.Entity<TemplatesAuth>(entity =>
        {
            entity.ToTable("templates_auth", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Authorityid).HasColumnName("AUTHORITYID");
            entity.Property(e => e.Templateid).HasColumnName("TEMPLATEID");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<Temsilci>(entity =>
        {
            entity.ToTable("temsilci", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Bolge)
                .HasMaxLength(100)
                .HasColumnName("BOLGE");
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.Telefon)
                .HasMaxLength(100)
                .HasColumnName("TELEFON");
            entity.Property(e => e.Telefonkisa)
                .HasMaxLength(30)
                .HasColumnName("TELEFONKISA");
        });

        modelBuilder.Entity<Temsilcisahahareket>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_temsilcisahahareket");

            entity.ToTable("temsilcisahahareket", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Gbgpsboylam).HasColumnName("GBGPSBOYLAM");
            entity.Property(e => e.Gbgpsenlem).HasColumnName("GBGPSENLEM");
            entity.Property(e => e.Gbkm).HasColumnName("GBKM");
            entity.Property(e => e.Gbsaat)
                .HasColumnType("datetime")
                .HasColumnName("GBSAAT");
            entity.Property(e => e.Gsgpsboylam).HasColumnName("GSGPSBOYLAM");
            entity.Property(e => e.Gsgpsenlem).HasColumnName("GSGPSENLEM");
            entity.Property(e => e.Gskm).HasColumnName("GSKM");
            entity.Property(e => e.Gssaat)
                .HasColumnType("datetime")
                .HasColumnName("GSSAAT");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
        });

        modelBuilder.Entity<Temsilcitanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_temsilcitanim");

            entity.ToTable("temsilcitanim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .HasColumnName("AD");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Aracplakano)
                .HasMaxLength(50)
                .HasColumnName("ARACPLAKANO");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(100)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Isim)
                .HasMaxLength(200)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(255)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.Sifre)
                .HasMaxLength(255)
                .HasColumnName("SIFRE");
            entity.Property(e => e.Soyad)
                .HasMaxLength(255)
                .HasColumnName("SOYAD");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tckimlikno)
                .HasMaxLength(11)
                .HasColumnName("TCKIMLIKNO");
            entity.Property(e => e.Terminalvar).HasColumnName("TERMINALVAR");
        });

        modelBuilder.Entity<TemsilcitanimDeposipari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_temsilcitanim_deposiparis");

            entity.ToTable("temsilcitanim_deposiparis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DsDepogrupid).HasColumnName("DS_DEPOGRUPID");
            entity.Property(e => e.DsDepoid).HasColumnName("DS_DEPOID");
            entity.Property(e => e.DsDeposecimtip)
                .HasMaxLength(10)
                .HasColumnName("DS_DEPOSECIMTIP");
            entity.Property(e => e.DsStokgruplamasekli)
                .HasMaxLength(10)
                .HasColumnName("DS_STOKGRUPLAMASEKLI");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
        });

        modelBuilder.Entity<Uretim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_uretim");

            entity.ToTable("uretim", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Birimmaliyet)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BIRIMMALIYET");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Durum)
                .HasMaxLength(4)
                .HasColumnName("DURUM");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Maliyetfiyatlisteid).HasColumnName("MALIYETFIYATLISTEID");
            entity.Property(e => e.Maliyetilktarih)
                .HasColumnType("datetime")
                .HasColumnName("MALIYETILKTARIH");
            entity.Property(e => e.Maliyetsontarih)
                .HasColumnType("datetime")
                .HasColumnName("MALIYETSONTARIH");
            entity.Property(e => e.Maliyettip)
                .HasMaxLength(4)
                .HasColumnName("MALIYETTIP");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Receteid).HasColumnName("RECETEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sipariskalemid).HasColumnName("SIPARISKALEMID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Uretimtip)
                .HasMaxLength(4)
                .HasColumnName("URETIMTIP");
            entity.Property(e => e.Usturetimid).HasColumnName("USTURETIMID");
        });

        modelBuilder.Entity<UretimDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_uretim_detay");

            entity.ToTable("uretim_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARPAN");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Recetemiktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("RECETEMIKTAR");
            entity.Property(e => e.Recetemiktaryuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RECETEMIKTARYUZDE");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Uretimid).HasColumnName("URETIMID");
        });

        modelBuilder.Entity<Uretimplan>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_uretimplan");

            entity.ToTable("uretimplan", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Durum)
                .HasMaxLength(4)
                .HasColumnName("DURUM");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Uretimtarih)
                .HasColumnType("datetime")
                .HasColumnName("URETIMTARIH");
        });

        modelBuilder.Entity<UretimplanDeposipari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_uretimplan_deposiparis");

            entity.ToTable("uretimplan_deposiparis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Deposiparisid).HasColumnName("DEPOSIPARISID");
            entity.Property(e => e.Uretimplanid).HasColumnName("URETIMPLANID");
        });

        modelBuilder.Entity<UretimplanSipari>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_uretimplan_siparis");

            entity.ToTable("uretimplan_siparis", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Uretimplanid).HasColumnName("URETIMPLANID");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("users", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.AllowCrosslogin).HasColumnName("ALLOW_CROSSLOGIN");
            entity.Property(e => e.AllowDesktoplogin).HasColumnName("ALLOW_DESKTOPLOGIN");
            entity.Property(e => e.AllowMobileusermanagement).HasColumnName("ALLOW_MOBILEUSERMANAGEMENT");
            entity.Property(e => e.AllowProjectmanagement).HasColumnName("ALLOW_PROJECTMANAGEMENT");
            entity.Property(e => e.AllowUsermanagement).HasColumnName("ALLOW_USERMANAGEMENT");
            entity.Property(e => e.AllowViewlog).HasColumnName("ALLOW_VIEWLOG");
            entity.Property(e => e.AllowWeblogin).HasColumnName("ALLOW_WEBLOGIN");
            entity.Property(e => e.Changepassword).HasColumnName("CHANGEPASSWORD");
            entity.Property(e => e.Decleration)
                .HasMaxLength(255)
                .HasColumnName("DECLERATION");
            entity.Property(e => e.Disableafterfail).HasColumnName("DISABLEAFTERFAIL");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.EmailName)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_NAME");
            entity.Property(e => e.EmailPassword)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_PASSWORD");
            entity.Property(e => e.EmailSmtpPort).HasColumnName("EMAIL_SMTP_PORT");
            entity.Property(e => e.EmailSmtpServer)
                .HasMaxLength(100)
                .HasColumnName("EMAIL_SMTP_SERVER");
            entity.Property(e => e.EmailUsername)
                .HasMaxLength(255)
                .HasColumnName("EMAIL_USERNAME");
            entity.Property(e => e.EmailUsessl).HasColumnName("EMAIL_USESSL");
            entity.Property(e => e.Enforcepasswordexpiration).HasColumnName("ENFORCEPASSWORDEXPIRATION");
            entity.Property(e => e.Enforcepasswordpolicy).HasColumnName("ENFORCEPASSWORDPOLICY");
            entity.Property(e => e.Failedcount).HasColumnName("FAILEDCOUNT");
            entity.Property(e => e.Groupid).HasColumnName("GROUPID");
            entity.Property(e => e.Gsm)
                .HasMaxLength(30)
                .HasColumnName("GSM");
            entity.Property(e => e.Mobilelicenceid).HasColumnName("MOBILELICENCEID");
            entity.Property(e => e.Mobileuser).HasColumnName("MOBILEUSER");
            entity.Property(e => e.Name)
                .HasMaxLength(255)
                .HasColumnName("NAME");
            entity.Property(e => e.Oldpassword)
                .HasMaxLength(30)
                .HasColumnName("OLDPASSWORD");
            entity.Property(e => e.Oldpassword2)
                .HasMaxLength(30)
                .HasColumnName("OLDPASSWORD2");
            entity.Property(e => e.Password)
                .HasMaxLength(30)
                .HasColumnName("PASSWORD");
            entity.Property(e => e.Passworddate)
                .HasColumnType("datetime")
                .HasColumnName("PASSWORDDATE");
            entity.Property(e => e.Refcode)
                .HasMaxLength(100)
                .HasColumnName("REFCODE");
            entity.Property(e => e.Showmenu).HasColumnName("SHOWMENU");
            entity.Property(e => e.Username)
                .HasMaxLength(30)
                .HasColumnName("USERNAME");
        });

        modelBuilder.Entity<UsersAuth>(entity =>
        {
            entity.ToTable("users_auth", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Authoritycode)
                .HasMaxLength(100)
                .HasColumnName("AUTHORITYCODE");
            entity.Property(e => e.Authorityid).HasColumnName("AUTHORITYID");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<UsersMenu>(entity =>
        {
            entity.ToTable("users_menu", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Menuitemcode)
                .HasMaxLength(50)
                .HasColumnName("MENUITEMCODE");
            entity.Property(e => e.Show).HasColumnName("SHOW");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<UsersMenufav>(entity =>
        {
            entity.ToTable("users_menufav", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Menuitemcode)
                .HasMaxLength(100)
                .HasColumnName("MENUITEMCODE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<UsersMobileauth>(entity =>
        {
            entity.ToTable("users_mobileauth", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Authoritycode)
                .HasMaxLength(100)
                .HasColumnName("AUTHORITYCODE");
            entity.Property(e => e.Userid).HasColumnName("USERID");
            entity.Property(e => e.Value)
                .HasMaxLength(255)
                .HasColumnName("VALUE");
        });

        modelBuilder.Entity<UsersMobilemenu>(entity =>
        {
            entity.ToTable("users_mobilemenu", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Menuitemcode)
                .HasMaxLength(50)
                .HasColumnName("MENUITEMCODE");
            entity.Property(e => e.Show).HasColumnName("SHOW");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Vardiya>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_vardiya");

            entity.ToTable("vardiya", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baslangicsaat)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICSAAT");
            entity.Property(e => e.Bitissaat)
                .HasColumnType("datetime")
                .HasColumnName("BITISSAAT");
            entity.Property(e => e.Vardiyano)
                .HasMaxLength(50)
                .HasColumnName("VARDIYANO");
        });

        modelBuilder.Entity<VardiyaDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_vardiya_detay");

            entity.ToTable("vardiya_detay", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Vardiyaid).HasColumnName("VARDIYAID");
        });

        modelBuilder.Entity<Variable>(entity =>
        {
            entity.ToTable("variables", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Value).HasColumnName("VALUE");
            entity.Property(e => e.Variablecode)
                .HasMaxLength(100)
                .HasColumnName("VARIABLECODE");
        });

        modelBuilder.Entity<Wbakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wbakiye", "led");

            entity.Property(e => e.Alacak)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Borc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("BORC");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur).HasColumnName("DOVIZKUR");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Wbanka>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wbanka", "led");

            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Banka)
                .HasMaxLength(255)
                .HasColumnName("BANKA");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(100)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.Iban)
                .HasMaxLength(100)
                .HasColumnName("IBAN");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Sube)
                .HasMaxLength(255)
                .HasColumnName("SUBE");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(100)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkilitel)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL");
        });

        modelBuilder.Entity<Wcarihareket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wcarihareket", "led");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Borc)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("BORC");
            entity.Property(e => e.Bordroid).HasColumnName("BORDROID");
            entity.Property(e => e.Carihareketfisid).HasColumnName("CARIHAREKETFISID");
            entity.Property(e => e.Cekid).HasColumnName("CEKID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur).HasColumnName("DOVIZKUR");
            entity.Property(e => e.Doviztutar).HasColumnName("DOVIZTUTAR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.Posanlasmaid).HasColumnName("POSANLASMAID");
            entity.Property(e => e.Poskomisyon)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("POSKOMISYON");
            entity.Property(e => e.Posonayno)
                .HasMaxLength(255)
                .HasColumnName("POSONAYNO");
            entity.Property(e => e.Posslipid).HasColumnName("POSSLIPID");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Senetid).HasColumnName("SENETID");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
        });

        modelBuilder.Entity<Wcariharekettip>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wcariharekettip", "led");

            entity.Property(e => e.Isim)
                .HasMaxLength(36)
                .IsUnicode(false)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Wcarikart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wcarikart", "led");

            entity.Property(e => e.Acilistarih)
                .HasColumnType("datetime")
                .HasColumnName("ACILISTARIH");
            entity.Property(e => e.Ad)
                .HasMaxLength(255)
                .HasColumnName("AD");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Alisfiyatlisteid).HasColumnName("ALISFIYATLISTEID");
            entity.Property(e => e.AsistanEposta)
                .HasMaxLength(50)
                .HasColumnName("ASISTAN_EPOSTA");
            entity.Property(e => e.B2bkullaniciadi)
                .HasMaxLength(100)
                .HasColumnName("B2BKULLANICIADI");
            entity.Property(e => e.B2bparola)
                .HasMaxLength(100)
                .HasColumnName("B2BPAROLA");
            entity.Property(e => e.Barkod)
                .HasMaxLength(255)
                .HasColumnName("BARKOD");
            entity.Property(e => e.Carisecimnotu).HasColumnName("CARISECIMNOTU");
            entity.Property(e => e.CarisecimnotuMasaustu).HasColumnName("CARISECIMNOTU_MASAUSTU");
            entity.Property(e => e.CarisecimnotuMobil).HasColumnName("CARISECIMNOTU_MOBIL");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Detayid).HasColumnName("DETAYID");
            entity.Property(e => e.Dijitaltel).HasColumnName("DIJITALTEL");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.EarsivEposta)
                .HasMaxLength(80)
                .HasColumnName("EARSIV_EPOSTA");
            entity.Property(e => e.EbabsEposta)
                .HasMaxLength(100)
                .HasColumnName("EBABS_EPOSTA");
            entity.Property(e => e.Ebelgekullan)
                .HasMaxLength(4)
                .HasColumnName("EBELGEKULLAN");
            entity.Property(e => e.EfaturaOzeldeger)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_OZELDEGER");
            entity.Property(e => e.EfaturaOzeldeger2)
                .HasMaxLength(255)
                .HasColumnName("EFATURA_OZELDEGER2");
            entity.Property(e => e.EfaturaOzelkod)
                .HasMaxLength(100)
                .HasColumnName("EFATURA_OZELKOD");
            entity.Property(e => e.EfaturaOzelkod2)
                .HasMaxLength(100)
                .HasColumnName("EFATURA_OZELKOD2");
            entity.Property(e => e.EfaturaSenaryo)
                .HasMaxLength(4)
                .HasColumnName("EFATURA_SENARYO");
            entity.Property(e => e.Efaturakullaniyor).HasColumnName("EFATURAKULLANIYOR");
            entity.Property(e => e.Eirsaliyekullaniyor).HasColumnName("EIRSALIYEKULLANIYOR");
            entity.Property(e => e.Ekalan1)
                .HasMaxLength(255)
                .HasColumnName("EKALAN1");
            entity.Property(e => e.Ekalan10)
                .HasMaxLength(255)
                .HasColumnName("EKALAN10");
            entity.Property(e => e.Ekalan2)
                .HasMaxLength(255)
                .HasColumnName("EKALAN2");
            entity.Property(e => e.Ekalan3)
                .HasMaxLength(255)
                .HasColumnName("EKALAN3");
            entity.Property(e => e.Ekalan4)
                .HasMaxLength(255)
                .HasColumnName("EKALAN4");
            entity.Property(e => e.Ekalan5)
                .HasMaxLength(255)
                .HasColumnName("EKALAN5");
            entity.Property(e => e.Ekalan6)
                .HasMaxLength(255)
                .HasColumnName("EKALAN6");
            entity.Property(e => e.Ekalan7)
                .HasMaxLength(255)
                .HasColumnName("EKALAN7");
            entity.Property(e => e.Ekalan8)
                .HasMaxLength(255)
                .HasColumnName("EKALAN8");
            entity.Property(e => e.Ekalan9)
                .HasMaxLength(255)
                .HasColumnName("EKALAN9");
            entity.Property(e => e.EmutabakatEposta)
                .HasMaxLength(255)
                .HasColumnName("EMUTABAKAT_EPOSTA");
            entity.Property(e => e.EmutabakatYetkili)
                .HasMaxLength(255)
                .HasColumnName("EMUTABAKAT_YETKILI");
            entity.Property(e => e.Entegrasyonkod1)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD1");
            entity.Property(e => e.Entegrasyonkod2)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD2");
            entity.Property(e => e.Entegrasyonkod3)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD3");
            entity.Property(e => e.Entegrasyonkod4)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD4");
            entity.Property(e => e.Entegrasyonkod5)
                .HasMaxLength(50)
                .HasColumnName("ENTEGRASYONKOD5");
            entity.Property(e => e.Eposta)
                .HasMaxLength(255)
                .HasColumnName("EPOSTA");
            entity.Property(e => e.Epostaizin).HasColumnName("EPOSTAIZIN");
            entity.Property(e => e.Fax)
                .HasMaxLength(100)
                .HasColumnName("FAX");
            entity.Property(e => e.Fiyatkriteri).HasColumnName("FIYATKRITERI");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Gsm)
                .HasMaxLength(100)
                .HasColumnName("GSM");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Il)
                .HasMaxLength(50)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(50)
                .HasColumnName("ILCE");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskontolisteid).HasColumnName("ISKONTOLISTEID");
            entity.Property(e => e.Kategori10id).HasColumnName("KATEGORI10ID");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kategori4id).HasColumnName("KATEGORI4ID");
            entity.Property(e => e.Kategori5id).HasColumnName("KATEGORI5ID");
            entity.Property(e => e.Kategori6id).HasColumnName("KATEGORI6ID");
            entity.Property(e => e.Kategori7id).HasColumnName("KATEGORI7ID");
            entity.Property(e => e.Kategori8id).HasColumnName("KATEGORI8ID");
            entity.Property(e => e.Kategori9id).HasColumnName("KATEGORI9ID");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Kdvkriteri).HasColumnName("KDVKRITERI");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Kredilimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KREDILIMIT");
            entity.Property(e => e.LedmuhMusterihesapid).HasColumnName("LEDMUH_MUSTERIHESAPID");
            entity.Property(e => e.LedmuhSaticihesapid).HasColumnName("LEDMUH_SATICIHESAPID");
            entity.Property(e => e.MobilCevrimicilimitkontrol)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_CEVRIMICILIMITKONTROL");
            entity.Property(e => e.MobilEvraknoayritakipet).HasColumnName("MOBIL_EVRAKNOAYRITAKIPET");
            entity.Property(e => e.MobilFiyatdegistirme)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_FIYATDEGISTIRME");
            entity.Property(e => e.MobilFiyatliirsaliye)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_FIYATLIIRSALIYE");
            entity.Property(e => e.MobilGpskonumkisitlama)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_GPSKONUMKISITLAMA");
            entity.Property(e => e.MobilIskontofiyatyansitma)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_ISKONTOFIYATYANSITMA");
            entity.Property(e => e.MobilKredilimityetki)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_KREDILIMITYETKI");
            entity.Property(e => e.MobilMaxiskonto1kullanim)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_MAXISKONTO1KULLANIM");
            entity.Property(e => e.MobilMaxiskonto2kullanim)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_MAXISKONTO2KULLANIM");
            entity.Property(e => e.MobilMaxiskonto3kullanim)
                .HasMaxLength(4)
                .HasColumnName("MOBIL_MAXISKONTO3KULLANIM");
            entity.Property(e => e.MobilPartinotakip).HasColumnName("MOBIL_PARTINOTAKIP");
            entity.Property(e => e.MobilRisklimityetki)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_RISKLIMITYETKI");
            entity.Property(e => e.MobilVadelimityetki)
                .HasMaxLength(2)
                .HasColumnName("MOBIL_VADELIMITYETKI");
            entity.Property(e => e.Muafiyet).HasColumnName("MUAFIYET");
            entity.Property(e => e.Musterimuhasebekodu)
                .HasMaxLength(50)
                .HasColumnName("MUSTERIMUHASEBEKODU");
            entity.Property(e => e.Ozelkod1)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD1");
            entity.Property(e => e.Ozelkod2)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD2");
            entity.Property(e => e.Ozelkod3)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD3");
            entity.Property(e => e.Ozelkod4)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD4");
            entity.Property(e => e.Ozelkod5)
                .HasMaxLength(100)
                .HasColumnName("OZELKOD5");
            entity.Property(e => e.Postakodu)
                .HasMaxLength(5)
                .HasColumnName("POSTAKODU");
            entity.Property(e => e.Renkkodu)
                .HasMaxLength(6)
                .HasColumnName("RENKKODU");
            entity.Property(e => e.Risklimit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RISKLIMIT");
            entity.Property(e => e.Saticimuhasebekodu)
                .HasMaxLength(50)
                .HasColumnName("SATICIMUHASEBEKODU");
            entity.Property(e => e.Satisyapma).HasColumnName("SATISYAPMA");
            entity.Property(e => e.SatisyapmaSebep)
                .HasMaxLength(255)
                .HasColumnName("SATISYAPMA_SEBEP");
            entity.Property(e => e.Smsizin).HasColumnName("SMSIZIN");
            entity.Property(e => e.Soyad)
                .HasMaxLength(255)
                .HasColumnName("SOYAD");
            entity.Property(e => e.Stokiskonto1var).HasColumnName("STOKISKONTO1VAR");
            entity.Property(e => e.Stokiskonto2var).HasColumnName("STOKISKONTO2VAR");
            entity.Property(e => e.Stokiskonto3var).HasColumnName("STOKISKONTO3VAR");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tabelaisim)
                .HasMaxLength(255)
                .HasColumnName("TABELAISIM");
            entity.Property(e => e.Tapdkno)
                .HasMaxLength(50)
                .HasColumnName("TAPDKNO");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(100)
                .HasColumnName("TEL2");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.TerminalciktiprofilidF2).HasColumnName("TERMINALCIKTIPROFILID_F2");
            entity.Property(e => e.TerminalciktiprofilidFb).HasColumnName("TERMINALCIKTIPROFILID_FB");
            entity.Property(e => e.TerminalciktiprofilidI2).HasColumnName("TERMINALCIKTIPROFILID_I2");
            entity.Property(e => e.TerminalislemF2).HasColumnName("TERMINALISLEM_F2");
            entity.Property(e => e.TerminalislemFb).HasColumnName("TERMINALISLEM_FB");
            entity.Property(e => e.TerminalislemI2).HasColumnName("TERMINALISLEM_I2");
            entity.Property(e => e.TerminalislemKullan).HasColumnName("TERMINALISLEM_KULLAN");
            entity.Property(e => e.TerminalyetkiFiyatdegistirme).HasColumnName("TERMINALYETKI_FIYATDEGISTIRME");
            entity.Property(e => e.Ticarisicilno)
                .HasMaxLength(50)
                .HasColumnName("TICARISICILNO");
            entity.Property(e => e.Ulke)
                .HasMaxLength(100)
                .HasColumnName("ULKE");
            entity.Property(e => e.Vergidaire)
                .HasMaxLength(50)
                .HasColumnName("VERGIDAIRE");
            entity.Property(e => e.Vergino)
                .HasMaxLength(50)
                .HasColumnName("VERGINO");
            entity.Property(e => e.Web)
                .HasMaxLength(50)
                .HasColumnName("WEB");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(255)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkiliadres)
                .HasMaxLength(400)
                .HasColumnName("YETKILIADRES");
            entity.Property(e => e.Zorunluparabirimi).HasColumnName("ZORUNLUPARABIRIMI");
        });

        modelBuilder.Entity<Wdepotransferdetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wdepotransferdetay", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(100)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Hedefdepoid).HasColumnName("HEDEFDEPOID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Kaynakdepoid).HasColumnName("KAYNAKDEPOID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 9)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Wdepozitohareket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wdepozitohareket", "led");

            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(23, 6)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
        });

        modelBuilder.Entity<Wfatura>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wfatura", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Doviztutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("DOVIZTUTAR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.Proformacarietki).HasColumnName("PROFORMACARIETKI");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
        });

        modelBuilder.Entity<Wfaturadeger>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wfaturadeger", "led");

            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Doviztutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("DOVIZTUTAR");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("KDV");
            entity.Property(e => e.Matrah)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MATRAH");
            entity.Property(e => e.Otv)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("OTV");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Wfaturadetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wfaturadetay", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Birlesmisfatura).HasColumnName("BIRLESMISFATURA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Doviztutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("DOVIZTUTAR");
            entity.Property(e => e.Ettn).HasColumnName("ETTN");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iptal).HasColumnName("IPTAL");
            entity.Property(e => e.Irsaliyeno)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYENO");
            entity.Property(e => e.Irsaliyetarih)
                .HasColumnType("datetime")
                .HasColumnName("IRSALIYETARIH");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("KDV");
            entity.Property(e => e.Matrah)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MATRAH");
            entity.Property(e => e.Odemetip)
                .HasMaxLength(4)
                .HasColumnName("ODEMETIP");
            entity.Property(e => e.Otv)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("OTV");
            entity.Property(e => e.Ozelkod)
                .HasMaxLength(255)
                .HasColumnName("OZELKOD");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Siparisno)
                .HasMaxLength(100)
                .HasColumnName("SIPARISNO");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
            entity.Property(e => e.Yazdirildi).HasColumnName("YAZDIRILDI");
            entity.Property(e => e.Ziyaretid).HasColumnName("ZIYARETID");
        });

        modelBuilder.Entity<Wfiyat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wfiyat", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Birimcarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BIRIMCARPAN");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Carisecimtip).HasColumnName("CARISECIMTIP");
            entity.Property(e => e.Duzenlemetarih)
                .HasColumnType("datetime")
                .HasColumnName("DUZENLEMETARIH");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyataltlisteid).HasColumnName("FIYATALTLISTEID");
            entity.Property(e => e.Fiyatlistedetayid).HasColumnName("FIYATLISTEDETAYID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Ilktarih)
                .HasColumnType("datetime")
                .HasColumnName("ILKTARIH");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Islemtip)
                .HasMaxLength(4)
                .HasColumnName("ISLEMTIP");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Maxiskonto)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("MAXISKONTO");
            entity.Property(e => e.Sevkadressecimtip).HasColumnName("SEVKADRESSECIMTIP");
            entity.Property(e => e.Sontarih)
                .HasColumnType("datetime")
                .HasColumnName("SONTARIH");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Wfiyatham>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wfiyatham", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Carisecimtip).HasColumnName("CARISECIMTIP");
            entity.Property(e => e.Fiyataltlisteid).HasColumnName("FIYATALTLISTEID");
            entity.Property(e => e.Fiyatlisteid).HasColumnName("FIYATLISTEID");
            entity.Property(e => e.Ilktarih)
                .HasColumnType("datetime")
                .HasColumnName("ILKTARIH");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Islemtip)
                .HasMaxLength(4)
                .HasColumnName("ISLEMTIP");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Sevkadressecimtip).HasColumnName("SEVKADRESSECIMTIP");
            entity.Property(e => e.Sontarih)
                .HasColumnType("datetime")
                .HasColumnName("SONTARIH");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Whatirlatmalar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("whatirlatmalar", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kalan).HasColumnName("KALAN");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Marka)
                .HasMaxLength(100)
                .HasColumnName("MARKA");
            entity.Property(e => e.Model)
                .HasMaxLength(100)
                .HasColumnName("MODEL");
            entity.Property(e => e.Renk)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("RENK");
            entity.Property(e => e.SonrakiKm).HasColumnName("SONRAKI_KM");
            entity.Property(e => e.SonrakiTarih)
                .HasColumnType("datetime")
                .HasColumnName("SONRAKI_TARIH");
            entity.Property(e => e.Surucuadsoyad)
                .HasMaxLength(255)
                .HasColumnName("SURUCUADSOYAD");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(100)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Wililce>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wililce", "led");

            entity.Property(e => e.Il)
                .HasMaxLength(14)
                .IsUnicode(false)
                .HasColumnName("IL");
            entity.Property(e => e.Ilce)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("ILCE");
        });

        modelBuilder.Entity<Windexstatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("windexstatus", "ledsys");

            entity.Property(e => e.Indexid).HasColumnName("INDEXID");
            entity.Property(e => e.Indexname)
                .HasMaxLength(128)
                .HasColumnName("INDEXNAME");
            entity.Property(e => e.Objectid).HasColumnName("OBJECTID");
            entity.Property(e => e.Primarykey).HasColumnName("PRIMARYKEY");
            entity.Property(e => e.Ratio)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("RATIO");
            entity.Property(e => e.Tablename)
                .HasMaxLength(128)
                .HasColumnName("TABLENAME");
            entity.Property(e => e.Tableschema)
                .HasMaxLength(128)
                .HasColumnName("TABLESCHEMA");
        });

        modelBuilder.Entity<Wkasa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wkasa", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
        });

        modelBuilder.Entity<Wkdvmuafiyet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wkdvmuafiyet", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("KOD");
            entity.Property(e => e.Tip)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Wkonumetiket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wkonumetiket", "filo");

            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Wkredikart>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wkredikart", "led");

            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Banka)
                .HasMaxLength(255)
                .HasColumnName("BANKA");
            entity.Property(e => e.Hesapkesim).HasColumnName("HESAPKESIM");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(100)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Limit)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("LIMIT");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Sonodeme).HasColumnName("SONODEME");
            entity.Property(e => e.Sube)
                .HasMaxLength(255)
                .HasColumnName("SUBE");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(100)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkilitel)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL");
        });

        modelBuilder.Entity<Wkullanici>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wkullanici", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kartid)
                .HasMaxLength(1000)
                .HasColumnName("KARTID");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Kullaniciadi)
                .HasMaxLength(100)
                .HasColumnName("KULLANICIADI");
            entity.Property(e => e.Parola)
                .HasMaxLength(100)
                .HasColumnName("PAROLA");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.YetkiBarkodsatirsilme).HasColumnName("YETKI_BARKODSATIRSILME");
            entity.Property(e => e.YetkiCaritahsilat).HasColumnName("YETKI_CARITAHSILAT");
            entity.Property(e => e.YetkiFatura).HasColumnName("YETKI_FATURA");
            entity.Property(e => e.YetkiFaturacariiskonto).HasColumnName("YETKI_FATURACARIISKONTO");
            entity.Property(e => e.YetkiFaturafiyatdegistirme).HasColumnName("YETKI_FATURAFIYATDEGISTIRME");
            entity.Property(e => e.YetkiFiyatdegistirme).HasColumnName("YETKI_FIYATDEGISTIRME");
            entity.Property(e => e.YetkiGiderodeme).HasColumnName("YETKI_GIDERODEME");
            entity.Property(e => e.YetkiIrsaliye).HasColumnName("YETKI_IRSALIYE");
            entity.Property(e => e.YetkiMiktardegistirme).HasColumnName("YETKI_MIKTARDEGISTIRME");
            entity.Property(e => e.YetkiOncekifisler)
                .HasMaxLength(2)
                .HasColumnName("YETKI_ONCEKIFISLER");
            entity.Property(e => e.YetkiRaporHareket).HasColumnName("YETKI_RAPOR_HAREKET");
            entity.Property(e => e.YetkiRaporStok).HasColumnName("YETKI_RAPOR_STOK");
            entity.Property(e => e.YetkiSatirsilme).HasColumnName("YETKI_SATIRSILME");
        });

        modelBuilder.Entity<Wkurfarki>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wkurfarki", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ALACAK");
            entity.Property(e => e.Borc)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("BORC");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizcinsi2)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI2");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Wmaliyet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wmaliyet", "led");

            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(38, 20)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Uretimid).HasColumnName("URETIMID");
        });

        modelBuilder.Entity<Wmasrafdetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wmasrafdetay", "led");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak).HasColumnName("ALACAK");
            entity.Property(e => e.Belgeno)
                .HasMaxLength(255)
                .HasColumnName("BELGENO");
            entity.Property(e => e.Borc).HasColumnName("BORC");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(53)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Gelirgiderid).HasColumnName("GELIRGIDERID");
            entity.Property(e => e.Giderfisid).HasColumnName("GIDERFISID");
            entity.Property(e => e.Hareketozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAREKETOZELKOD");
            entity.Property(e => e.Hizmetid).HasColumnName("HIZMETID");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kategori4id).HasColumnName("KATEGORI4ID");
            entity.Property(e => e.Kategori5id).HasColumnName("KATEGORI5ID");
            entity.Property(e => e.Kdvyuzde)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVYUZDE");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Wmusteri>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wmusteri", "pt");

            entity.Property(e => e.Acikhesap)
                .HasMaxLength(4)
                .HasColumnName("ACIKHESAP");
            entity.Property(e => e.Adres)
                .HasMaxLength(255)
                .HasColumnName("ADRES");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Gsm)
                .HasMaxLength(20)
                .HasColumnName("GSM");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskonto)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO");
            entity.Property(e => e.Iskontotip)
                .HasMaxLength(4)
                .HasColumnName("ISKONTOTIP");
            entity.Property(e => e.Kartid)
                .HasMaxLength(1000)
                .HasColumnName("KARTID");
            entity.Property(e => e.Msg)
                .HasMaxLength(1000)
                .HasColumnName("MSG");
            entity.Property(e => e.Pin)
                .HasMaxLength(20)
                .HasColumnName("PIN");
            entity.Property(e => e.Sid).HasColumnName("SID");
            entity.Property(e => e.Tel1)
                .HasMaxLength(100)
                .HasColumnName("TEL1");
            entity.Property(e => e.Tel2)
                .HasMaxLength(100)
                .HasColumnName("TEL2");
            entity.Property(e => e.Vrs).HasColumnName("VRS");
            entity.Property(e => e.Vrskl)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("VRSKL");
            entity.Property(e => e.Vrsul)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("VRSUL");
            entity.Property(e => e.Vrsvd).HasColumnName("VRSVD");
        });

        modelBuilder.Entity<Wpersonel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wpersonel", "led");

            entity.Property(e => e.Agi)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("AGI");
            entity.Property(e => e.Agigiderid).HasColumnName("AGIGIDERID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Anaadi)
                .HasMaxLength(100)
                .HasColumnName("ANAADI");
            entity.Property(e => e.Babaadi)
                .HasMaxLength(100)
                .HasColumnName("BABAADI");
            entity.Property(e => e.Departmanid).HasColumnName("DEPARTMANID");
            entity.Property(e => e.Dogumtarihi)
                .HasColumnType("datetime")
                .HasColumnName("DOGUMTARIHI");
            entity.Property(e => e.Dogumyeri)
                .HasMaxLength(100)
                .HasColumnName("DOGUMYERI");
            entity.Property(e => e.Gorevid).HasColumnName("GOREVID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kangrubu)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("KANGRUBU");
            entity.Property(e => e.Kategori1id).HasColumnName("KATEGORI1ID");
            entity.Property(e => e.Kategori2id).HasColumnName("KATEGORI2ID");
            entity.Property(e => e.Kategori3id).HasColumnName("KATEGORI3ID");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Maas)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("MAAS");
            entity.Property(e => e.Maasgiderid).HasColumnName("MAASGIDERID");
            entity.Property(e => e.Medenihali)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("MEDENIHALI");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tckn)
                .HasMaxLength(100)
                .HasColumnName("TCKN");
        });

        modelBuilder.Entity<Wpo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wpos", "led");

            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Banka)
                .HasMaxLength(255)
                .HasColumnName("BANKA");
            entity.Property(e => e.Hesapno)
                .HasMaxLength(100)
                .HasColumnName("HESAPNO");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Sanalpos).HasColumnName("SANALPOS");
            entity.Property(e => e.SanalposLink)
                .HasMaxLength(4000)
                .HasColumnName("SANALPOS_LINK");
            entity.Property(e => e.Sube)
                .HasMaxLength(255)
                .HasColumnName("SUBE");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Yetkili)
                .HasMaxLength(255)
                .HasColumnName("YETKILI");
            entity.Property(e => e.Yetkilitel)
                .HasMaxLength(100)
                .HasColumnName("YETKILITEL");
        });

        modelBuilder.Entity<Wportfoy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wportfoy", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Bankaid).HasColumnName("BANKAID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Muhasebekodu)
                .HasMaxLength(100)
                .HasColumnName("MUHASEBEKODU");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<WraporSiparisliste>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wrapor_siparisliste", "ledmobil");

            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Chisim)
                .HasMaxLength(255)
                .HasColumnName("CHISIM");
            entity.Property(e => e.Chkod)
                .HasMaxLength(100)
                .HasColumnName("CHKOD");
            entity.Property(e => e.Depoisim)
                .HasMaxLength(255)
                .HasColumnName("DEPOISIM");
            entity.Property(e => e.Depokod)
                .HasMaxLength(100)
                .HasColumnName("DEPOKOD");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Durum).HasColumnName("DURUM");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("KDV");
            entity.Property(e => e.Matrah)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MATRAH");
            entity.Property(e => e.Siparismiktar)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("SIPARISMIKTAR");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<WraporSiparislistedetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wrapor_siparislistedetay", "ledmobil");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Birim)
                .HasMaxLength(10)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(37, 10)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Iskonto4)
                .HasColumnType("numeric(37, 6)")
                .HasColumnName("ISKONTO4");
            entity.Property(e => e.Kalanmiktar)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("KALANMIKTAR");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDV");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Sevkmiktar)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("SEVKMIKTAR");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Toplamtutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TOPLAMTUTAR");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<WsToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_ws_token");

            entity.ToTable("ws_token", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Token).HasColumnName("TOKEN");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<WsToken1>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_ledusr_ws_token");

            entity.ToTable("ws_token", "ledusr");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.App)
                .HasMaxLength(30)
                .HasColumnName("APP");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Token).HasColumnName("TOKEN");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<WsTokenChtanimB2b>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_ws_token_chtanim_b2b");

            entity.ToTable("ws_token_chtanim_b2b", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Token).HasColumnName("TOKEN");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<WsTokenSurucu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_ws_token_surucu");

            entity.ToTable("ws_token_surucu", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Token).HasColumnName("TOKEN");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<WsTokenTemsilci>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_filo_ws_token_temsilci");

            entity.ToTable("ws_token_temsilci", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Datetime)
                .HasColumnType("datetime")
                .HasColumnName("DATETIME");
            entity.Property(e => e.Token).HasColumnName("TOKEN");
            entity.Property(e => e.Userid).HasColumnName("USERID");
        });

        modelBuilder.Entity<Wsati>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsatis", "pt");

            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iskonto)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Ledrefid).HasColumnName("LEDREFID");
            entity.Property(e => e.Maltoplam)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("MALTOPLAM");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Musteriid).HasColumnName("MUSTERIID");
            entity.Property(e => e.Oturumid).HasColumnName("OTURUMID");
            entity.Property(e => e.Personelid).HasColumnName("PERSONELID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Satisid).HasColumnName("SATISID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 9)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<Wsatisdetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsatisdetay", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Harozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAROZELKOD");
            entity.Property(e => e.Netsatisfiyat)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("NETSATISFIYAT");
            entity.Property(e => e.Netsatismiktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("NETSATISMIKTAR");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Satisfiyat)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("SATISFIYAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Wsatismaliyet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsatismaliyet", "led");

            entity.Property(e => e.Birimekmaliyet)
                .HasColumnType("numeric(37, 10)")
                .HasColumnName("BIRIMEKMALIYET");
            entity.Property(e => e.Depotransferid).HasColumnName("DEPOTRANSFERID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Satisfiyat)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("SATISFIYAT");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Uretimid).HasColumnName("URETIMID");
        });

        modelBuilder.Entity<Wserinohareket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wserinohareket", "led");

            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depodetayid).HasColumnName("DEPODETAYID");
            entity.Property(e => e.Depoharid).HasColumnName("DEPOHARID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturadetayid).HasColumnName("FATURADETAYID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Miktar).HasColumnName("MIKTAR");
            entity.Property(e => e.Serino)
                .HasMaxLength(255)
                .HasColumnName("SERINO");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
        });

        modelBuilder.Entity<Wsipari>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsiparis", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.B2b).HasColumnName("B2B");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Onaystr)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("ONAYSTR");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
        });

        modelBuilder.Entity<Wsiparisdetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsiparisdetay", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.B2b).HasColumnName("B2B");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Iskonto1)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO1");
            entity.Property(e => e.Iskonto2)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("ISKONTO2");
            entity.Property(e => e.Iskonto3)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ISKONTO3");
            entity.Property(e => e.Kdv)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("KDV");
            entity.Property(e => e.Matrah)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("MATRAH");
            entity.Property(e => e.Onay).HasColumnName("ONAY");
            entity.Property(e => e.Otv)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("OTV");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Teslimtarih)
                .HasColumnType("datetime")
                .HasColumnName("TESLIMTARIH");
            entity.Property(e => e.Tip)
                .HasMaxLength(2)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("TUTAR");
        });

        modelBuilder.Entity<Wstokbakiye>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wstokbakiye", "led");

            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(23, 6)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(38, 8)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Sevktarih)
                .HasColumnType("datetime")
                .HasColumnName("SEVKTARIH");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Varyasyonid).HasColumnName("VARYASYONID");
        });

        modelBuilder.Entity<Wstokhareket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wstokhareket", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aciklama2)
                .HasMaxLength(400)
                .HasColumnName("ACIKLAMA2");
            entity.Property(e => e.Ambalajbirim)
                .HasMaxLength(100)
                .HasColumnName("AMBALAJBIRIM");
            entity.Property(e => e.Birim)
                .HasMaxLength(100)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Cikanambalajmiktar)
                .HasColumnType("numeric(21, 6)")
                .HasColumnName("CIKANAMBALAJMIKTAR");
            entity.Property(e => e.Cikanmiktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("CIKANMIKTAR");
            entity.Property(e => e.Depohardetayid).HasColumnName("DEPOHARDETAYID");
            entity.Property(e => e.Depoharid).HasColumnName("DEPOHARID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Dovizcinsi)
                .HasMaxLength(3)
                .HasColumnName("DOVIZCINSI");
            entity.Property(e => e.Dovizkur)
                .HasColumnType("numeric(18, 4)")
                .HasColumnName("DOVIZKUR");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturadetayid).HasColumnName("FATURADETAYID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(38, 15)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Gc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GC");
            entity.Property(e => e.Girenambalajmiktar)
                .HasColumnType("numeric(21, 6)")
                .HasColumnName("GIRENAMBALAJMIKTAR");
            entity.Property(e => e.Girenmiktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("GIRENMIKTAR");
            entity.Property(e => e.Harozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAROZELKOD");
            entity.Property(e => e.Kdvoran)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVORAN");
            entity.Property(e => e.Matrah)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("MATRAH");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Netfiyat)
                .HasColumnType("numeric(38, 17)")
                .HasColumnName("NETFIYAT");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .HasColumnName("SAAT");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Sevktarih)
                .HasColumnType("datetime")
                .HasColumnName("SEVKTARIH");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Stokvadetarih)
                .HasColumnType("datetime")
                .HasColumnName("STOKVADETARIH");
            entity.Property(e => e.Stokvirmanid).HasColumnName("STOKVIRMANID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Uretimid).HasColumnName("URETIMID");
        });

        modelBuilder.Entity<Wstokhareketdetay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wstokhareketdetay", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Ambalajbirim)
                .HasMaxLength(10)
                .HasColumnName("AMBALAJBIRIM");
            entity.Property(e => e.Ambalajbirimid).HasColumnName("AMBALAJBIRIMID");
            entity.Property(e => e.Ambalajmiktar)
                .HasColumnType("numeric(21, 6)")
                .HasColumnName("AMBALAJMIKTAR");
            entity.Property(e => e.Birim)
                .HasMaxLength(100)
                .HasColumnName("BIRIM");
            entity.Property(e => e.Birim2)
                .HasMaxLength(100)
                .HasColumnName("BIRIM2");
            entity.Property(e => e.Birimcarpan)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("BIRIMCARPAN");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Birimid2).HasColumnName("BIRIMID2");
            entity.Property(e => e.Cariiskonto1miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARIISKONTO1MIKTAR");
            entity.Property(e => e.Cariiskonto1oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARIISKONTO1ORAN");
            entity.Property(e => e.Cariiskonto2miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARIISKONTO2MIKTAR");
            entity.Property(e => e.Cariiskonto2oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("CARIISKONTO2ORAN");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Cikanambalajmiktar)
                .HasColumnType("numeric(21, 6)")
                .HasColumnName("CIKANAMBALAJMIKTAR");
            entity.Property(e => e.Cikanmiktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("CIKANMIKTAR");
            entity.Property(e => e.Cikanmiktar2)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("CIKANMIKTAR2");
            entity.Property(e => e.Depoharid).HasColumnName("DEPOHARID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Ekkalemiskonto1miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO1MIKTAR");
            entity.Property(e => e.Ekkalemiskonto1oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO1ORAN");
            entity.Property(e => e.Ekkalemiskonto2miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO2MIKTAR");
            entity.Property(e => e.Ekkalemiskonto2oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO2ORAN");
            entity.Property(e => e.Ekkalemiskonto3miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO3MIKTAR");
            entity.Property(e => e.Ekkalemiskonto3oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO3ORAN");
            entity.Property(e => e.Ekkalemiskonto4miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO4MIKTAR");
            entity.Property(e => e.Ekkalemiskonto4oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO4ORAN");
            entity.Property(e => e.Ekkalemiskonto5miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO5MIKTAR");
            entity.Property(e => e.Ekkalemiskonto5oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO5ORAN");
            entity.Property(e => e.Ekkalemiskonto6miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO6MIKTAR");
            entity.Property(e => e.Ekkalemiskonto6oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO6ORAN");
            entity.Property(e => e.Ekkalemiskonto7miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO7MIKTAR");
            entity.Property(e => e.Ekkalemiskonto7oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("EKKALEMISKONTO7ORAN");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira)
                .HasMaxLength(50)
                .HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Faturafiyat)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("FATURAFIYAT");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(38, 15)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Fiyat2)
                .HasColumnType("numeric(38, 21)")
                .HasColumnName("FIYAT2");
            entity.Property(e => e.Gc)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("GC");
            entity.Property(e => e.Girenambalajmiktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("GIRENAMBALAJMIKTAR");
            entity.Property(e => e.Girenmiktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("GIRENMIKTAR");
            entity.Property(e => e.Girenmiktar2)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("GIRENMIKTAR2");
            entity.Property(e => e.Harozelkod)
                .HasMaxLength(255)
                .HasColumnName("HAROZELKOD");
            entity.Property(e => e.Irsaliyeno)
                .HasMaxLength(255)
                .HasColumnName("IRSALIYENO");
            entity.Property(e => e.Kalemiskonto1miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KALEMISKONTO1MIKTAR");
            entity.Property(e => e.Kalemiskonto1oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KALEMISKONTO1ORAN");
            entity.Property(e => e.Kalemiskonto2miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KALEMISKONTO2MIKTAR");
            entity.Property(e => e.Kalemiskonto2oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KALEMISKONTO2ORAN");
            entity.Property(e => e.Kalemiskonto3miktar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KALEMISKONTO3MIKTAR");
            entity.Property(e => e.Kalemiskonto3oran)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("KALEMISKONTO3ORAN");
            entity.Property(e => e.Kdvdahil).HasColumnName("KDVDAHIL");
            entity.Property(e => e.Kdvoran)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVORAN");
            entity.Property(e => e.Kdvtutar)
                .HasColumnType("numeric(19, 6)")
                .HasColumnName("KDVTUTAR");
            entity.Property(e => e.Kisk4miktar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KISK4MIKTAR");
            entity.Property(e => e.Matrah)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("MATRAH");
            entity.Property(e => e.Miktar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("MIKTAR");
            entity.Property(e => e.Miktar2)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("MIKTAR2");
            entity.Property(e => e.Oivoran)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OIVORAN");
            entity.Property(e => e.Oivtutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("OIVTUTAR");
            entity.Property(e => e.Otvoran)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("OTVORAN");
            entity.Property(e => e.Otvtutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("OTVTUTAR");
            entity.Property(e => e.Partino)
                .HasMaxLength(100)
                .HasColumnName("PARTINO");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasMaxLength(10)
                .HasColumnName("SAAT");
            entity.Property(e => e.Serino)
                .HasMaxLength(100)
                .HasColumnName("SERINO");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Sevktarih)
                .HasColumnType("datetime")
                .HasColumnName("SEVKTARIH");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
            entity.Property(e => e.Stokvirmanid).HasColumnName("STOKVIRMANID");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tevkifattutar)
                .HasColumnType("numeric(18, 6)")
                .HasColumnName("TEVKIFATTUTAR");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(37, 9)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Uretimid).HasColumnName("URETIMID");
        });

        modelBuilder.Entity<Wstokkoddonusum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wstokkoddonusum", "led");

            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
            entity.Property(e => e.Stokid).HasColumnName("STOKID");
        });

        modelBuilder.Entity<Wsubeayar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsubeayar", "pt");

            entity.Property(e => e.B2ckullan).HasColumnName("B2CKULLAN");
            entity.Property(e => e.Baglicekmece)
                .HasMaxLength(100)
                .HasColumnName("BAGLICEKMECE");
            entity.Property(e => e.Baglicekmeceport)
                .HasMaxLength(100)
                .HasColumnName("BAGLICEKMECEPORT");
            entity.Property(e => e.Bagliyazarkasa)
                .HasMaxLength(20)
                .HasColumnName("BAGLIYAZARKASA");
            entity.Property(e => e.Barkodokumasesi).HasColumnName("BARKODOKUMASESI");
            entity.Property(e => e.Bilgiekrancomport)
                .HasMaxLength(10)
                .HasColumnName("BILGIEKRANCOMPORT");
            entity.Property(e => e.DllPerakendemodul).HasColumnName("DLL_PERAKENDEMODUL");
            entity.Property(e => e.Dogrudanalimkullan).HasColumnName("DOGRUDANALIMKULLAN");
            entity.Property(e => e.FaturaCaribakiyegoster).HasColumnName("FATURA_CARIBAKIYEGOSTER");
            entity.Property(e => e.FaturaKdvdahil).HasColumnName("FATURA_KDVDAHIL");
            entity.Property(e => e.FaturaciktiText).HasColumnName("FATURACIKTI_TEXT");
            entity.Property(e => e.Faturakullan).HasColumnName("FATURAKULLAN");
            entity.Property(e => e.Favkullan).HasColumnName("FAVKULLAN");
            entity.Property(e => e.Firmaunvan).HasColumnName("FIRMAUNVAN");
            entity.Property(e => e.Fisbekletkullan)
                .HasMaxLength(4)
                .HasColumnName("FISBEKLETKULLAN");
            entity.Property(e => e.FrxBeklemefiscikti).HasColumnName("FRX_BEKLEMEFISCIKTI");
            entity.Property(e => e.FrxCekmececikti).HasColumnName("FRX_CEKMECECIKTI");
            entity.Property(e => e.FrxFaturacikti).HasColumnName("FRX_FATURACIKTI");
            entity.Property(e => e.FrxFaturaciktiEarsivfatura).HasColumnName("FRX_FATURACIKTI_EARSIVFATURA");
            entity.Property(e => e.FrxFaturaciktiEfatura).HasColumnName("FRX_FATURACIKTI_EFATURA");
            entity.Property(e => e.FrxFiscikti).HasColumnName("FRX_FISCIKTI");
            entity.Property(e => e.FrxMalkabulcikti).HasColumnName("FRX_MALKABULCIKTI");
            entity.Property(e => e.FrxOturumsonucikti).HasColumnName("FRX_OTURUMSONUCIKTI");
            entity.Property(e => e.FrxSipariscikti).HasColumnName("FRX_SIPARISCIKTI");
            entity.Property(e => e.FrxTahsilatcikti).HasColumnName("FRX_TAHSILATCIKTI");
            entity.Property(e => e.FrxVeresiyeekstrecikti).HasColumnName("FRX_VERESIYEEKSTRECIKTI");
            entity.Property(e => e.FrxVeresiyetahsilatfiscikti).HasColumnName("FRX_VERESIYETAHSILATFISCIKTI");
            entity.Property(e => e.GorselLogo).HasColumnName("GORSEL_LOGO");
            entity.Property(e => e.GorselMusteriekran).HasColumnName("GORSEL_MUSTERIEKRAN");
            entity.Property(e => e.Gunsonukullan).HasColumnName("GUNSONUKULLAN");
            entity.Property(e => e.Hariciterazitip)
                .HasMaxLength(20)
                .HasColumnName("HARICITERAZITIP");
            entity.Property(e => e.HashDllPerakendemodul)
                .HasMaxLength(100)
                .HasColumnName("HASH_DLL_PERAKENDEMODUL");
            entity.Property(e => e.HashFrxBeklemefiscikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_BEKLEMEFISCIKTI");
            entity.Property(e => e.HashFrxCekmececikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_CEKMECECIKTI");
            entity.Property(e => e.HashFrxFaturacikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_FATURACIKTI");
            entity.Property(e => e.HashFrxFaturaciktiEarsivfatura)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_FATURACIKTI_EARSIVFATURA");
            entity.Property(e => e.HashFrxFaturaciktiEfatura)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_FATURACIKTI_EFATURA");
            entity.Property(e => e.HashFrxFiscikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_FISCIKTI");
            entity.Property(e => e.HashFrxMalkabulcikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_MALKABULCIKTI");
            entity.Property(e => e.HashFrxOturumsonucikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_OTURUMSONUCIKTI");
            entity.Property(e => e.HashFrxSipariscikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_SIPARISCIKTI");
            entity.Property(e => e.HashFrxTahsilatcikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_TAHSILATCIKTI");
            entity.Property(e => e.HashFrxVeresiyeekstrecikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_VERESIYEEKSTRECIKTI");
            entity.Property(e => e.HashFrxVeresiyetahsilatfiscikti)
                .HasMaxLength(100)
                .HasColumnName("HASH_FRX_VERESIYETAHSILATFISCIKTI");
            entity.Property(e => e.HashGorselLogo)
                .HasMaxLength(100)
                .HasColumnName("HASH_GORSEL_LOGO");
            entity.Property(e => e.HashGorselMusteriekran)
                .HasMaxLength(100)
                .HasColumnName("HASH_GORSEL_MUSTERIEKRAN");
            entity.Property(e => e.Ipadres)
                .HasMaxLength(20)
                .HasColumnName("IPADRES");
            entity.Property(e => e.Irsaliyekullan).HasColumnName("IRSALIYEKULLAN");
            entity.Property(e => e.Kasaid).HasColumnName("KASAID");
            entity.Property(e => e.Kasaisim)
                .HasMaxLength(255)
                .HasColumnName("KASAISIM");
            entity.Property(e => e.Kasakod)
                .HasMaxLength(100)
                .HasColumnName("KASAKOD");
            entity.Property(e => e.MalkabulStokfiyatgoster).HasColumnName("MALKABUL_STOKFIYATGOSTER");
            entity.Property(e => e.Masahesapkullan).HasColumnName("MASAHESAPKULLAN");
            entity.Property(e => e.MusteriekranKullan).HasColumnName("MUSTERIEKRAN_KULLAN");
            entity.Property(e => e.MusteriekranVideolink)
                .HasMaxLength(255)
                .HasColumnName("MUSTERIEKRAN_VIDEOLINK");
            entity.Property(e => e.MusteriekranVideolinkAyri).HasColumnName("MUSTERIEKRAN_VIDEOLINK_AYRI");
            entity.Property(e => e.Oncekifislercalismasekli).HasColumnName("ONCEKIFISLERCALISMASEKLI");
            entity.Property(e => e.Sabitfaturayazici)
                .HasMaxLength(255)
                .HasColumnName("SABITFATURAYAZICI");
            entity.Property(e => e.Sabitfisyazici)
                .HasMaxLength(255)
                .HasColumnName("SABITFISYAZICI");
            entity.Property(e => e.SatisBarkoddaarama).HasColumnName("SATIS_BARKODDAARAMA");
            entity.Property(e => e.SatisMaxkusurat).HasColumnName("SATIS_MAXKUSURAT");
            entity.Property(e => e.SatisPossorulsun).HasColumnName("SATIS_POSSORULSUN");
            entity.Property(e => e.SatisSatisdanismancalismasekli).HasColumnName("SATIS_SATISDANISMANCALISMASEKLI");
            entity.Property(e => e.SatisTutardegistirme).HasColumnName("SATIS_TUTARDEGISTIRME");
            entity.Property(e => e.SatisUrunlisteButtonboyut).HasColumnName("SATIS_URUNLISTE_BUTTONBOYUT");
            entity.Property(e => e.Satiskullanimtip)
                .HasMaxLength(4)
                .HasColumnName("SATISKULLANIMTIP");
            entity.Property(e => e.SayimSatisfisyukle).HasColumnName("SAYIM_SATISFISYUKLE");
            entity.Property(e => e.SayimStokfiyatgoster).HasColumnName("SAYIM_STOKFIYATGOSTER");
            entity.Property(e => e.SevkiyatSatisfisyukle).HasColumnName("SEVKIYAT_SATISFISYUKLE");
            entity.Property(e => e.SiparisStokfiyatgoster).HasColumnName("SIPARIS_STOKFIYATGOSTER");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Subeisim)
                .HasMaxLength(255)
                .HasColumnName("SUBEISIM");
            entity.Property(e => e.Subekod)
                .HasMaxLength(100)
                .HasColumnName("SUBEKOD");
            entity.Property(e => e.SubetransferStokfiyatgoster).HasColumnName("SUBETRANSFER_STOKFIYATGOSTER");
            entity.Property(e => e.TahsilatciktiText).HasColumnName("TAHSILATCIKTI_TEXT");
            entity.Property(e => e.Tahsilatkullan).HasColumnName("TAHSILATKULLAN");
            entity.Property(e => e.Terazicomport)
                .HasMaxLength(10)
                .HasColumnName("TERAZICOMPORT");
            entity.Property(e => e.Teraziserbestmiktar)
                .HasMaxLength(4)
                .HasColumnName("TERAZISERBESTMIKTAR");
            entity.Property(e => e.Terazitip)
                .HasMaxLength(100)
                .HasColumnName("TERAZITIP");
            entity.Property(e => e.Varyasyonkullan).HasColumnName("VARYASYONKULLAN");
            entity.Property(e => e.VeresiyeAciklamavar).HasColumnName("VERESIYE_ACIKLAMAVAR");
            entity.Property(e => e.VeresiyeIskontoyuzde).HasColumnName("VERESIYE_ISKONTOYUZDE");
            entity.Property(e => e.VeresiyeKredilimitasimi).HasColumnName("VERESIYE_KREDILIMITASIMI");
            entity.Property(e => e.VeresiyeMusteriara).HasColumnName("VERESIYE_MUSTERIARA");
            entity.Property(e => e.VeresiyeMusteribaglisubedecalisir).HasColumnName("VERESIYE_MUSTERIBAGLISUBEDECALISIR");
            entity.Property(e => e.VeresiyeSatisfisiyazdirilsin).HasColumnName("VERESIYE_SATISFISIYAZDIRILSIN");
            entity.Property(e => e.VeresiyeTahsilatgoster).HasColumnName("VERESIYE_TAHSILATGOSTER");
            entity.Property(e => e.Yazarkasafaturakullan).HasColumnName("YAZARKASAFATURAKULLAN");
            entity.Property(e => e.Yazarkasagiderpusulasikullan).HasColumnName("YAZARKASAGIDERPUSULASIKULLAN");
        });

        modelBuilder.Entity<Wsubecarihareket>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wsubecarihareket", "pt");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Alacak).HasColumnName("ALACAK");
            entity.Property(e => e.Borc).HasColumnName("BORC");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Depoid).HasColumnName("DEPOID");
            entity.Property(e => e.Depoid2).HasColumnName("DEPOID2");
            entity.Property(e => e.Evrakno)
                .HasMaxLength(255)
                .HasColumnName("EVRAKNO");
            entity.Property(e => e.Evrakseri)
                .HasMaxLength(3)
                .HasColumnName("EVRAKSERI");
            entity.Property(e => e.Evraksira).HasColumnName("EVRAKSIRA");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Ozelkod).HasColumnName("OZELKOD");
            entity.Property(e => e.PerKasaid).HasColumnName("PER_KASAID");
            entity.Property(e => e.PerPersonelid).HasColumnName("PER_PERSONELID");
            entity.Property(e => e.PerSubeid).HasColumnName("PER_SUBEID");
            entity.Property(e => e.Projeid).HasColumnName("PROJEID");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Sira).HasColumnName("SIRA");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Tip)
                .HasMaxLength(4)
                .HasColumnName("TIP");
            entity.Property(e => e.Vadetarih)
                .HasColumnType("datetime")
                .HasColumnName("VADETARIH");
        });

        modelBuilder.Entity<Wtevkifatkod>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wtevkifatkod", "led");

            entity.Property(e => e.Aciklama)
                .HasMaxLength(141)
                .IsUnicode(false)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Kesinti)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("KESINTI");
            entity.Property(e => e.Kod)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("KOD");
            entity.Property(e => e.Oran).HasColumnName("ORAN");
        });

        modelBuilder.Entity<Wulke>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wulke", "led");

            entity.Property(e => e.Isim)
                .HasMaxLength(26)
                .IsUnicode(false)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Wyakitfi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wyakitfis", "filo");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Km)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KM");
            entity.Property(e => e.Oncekitamdolumzaman)
                .HasColumnType("datetime")
                .HasColumnName("ONCEKITAMDOLUMZAMAN");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Surucuid).HasColumnName("SURUCUID");
            entity.Property(e => e.Tamdolum).HasColumnName("TAMDOLUM");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Yakitlitre)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("YAKITLITRE");
            entity.Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        });

        modelBuilder.Entity<WyakitfisTamdolum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("wyakitfis_tamdolum", "filo");

            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Km)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KM");
            entity.Property(e => e.Oncekikm)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("ONCEKIKM");
            entity.Property(e => e.Oncekitamdolumzaman)
                .HasColumnType("datetime")
                .HasColumnName("ONCEKITAMDOLUMZAMAN");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Surucuid).HasColumnName("SURUCUID");
            entity.Property(e => e.Tamdolum).HasColumnName("TAMDOLUM");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Toplamlitre)
                .HasColumnType("numeric(38, 3)")
                .HasColumnName("TOPLAMLITRE");
            entity.Property(e => e.Toplamtutar)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("TOPLAMTUTAR");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Yakitlitre)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("YAKITLITRE");
            entity.Property(e => e.Zaman)
                .HasColumnType("datetime")
                .HasColumnName("ZAMAN");
        });

        modelBuilder.Entity<Yakitfi>(entity =>
        {
            entity.ToTable("yakitfis", "filo");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama).HasColumnName("ACIKLAMA");
            entity.Property(e => e.Aracid).HasColumnName("ARACID");
            entity.Property(e => e.Cari)
                .HasMaxLength(255)
                .HasColumnName("CARI");
            entity.Property(e => e.Carihareketid).HasColumnName("CARIHAREKETID");
            entity.Property(e => e.Carihareketoptip)
                .HasMaxLength(100)
                .HasColumnName("CARIHAREKETOPTIP");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Gorsel1)
                .HasColumnType("image")
                .HasColumnName("GORSEL_1");
            entity.Property(e => e.Gorsel2)
                .HasColumnType("image")
                .HasColumnName("GORSEL_2");
            entity.Property(e => e.Km)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KM");
            entity.Property(e => e.Muhasebe).HasColumnName("MUHASEBE");
            entity.Property(e => e.Saat)
                .HasColumnType("datetime")
                .HasColumnName("SAAT");
            entity.Property(e => e.Surucuid).HasColumnName("SURUCUID");
            entity.Property(e => e.Tamdolum).HasColumnName("TAMDOLUM");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Yakitlitre)
                .HasColumnType("numeric(18, 3)")
                .HasColumnName("YAKITLITRE");
        });

        modelBuilder.Entity<Ziyaret>(entity =>
        {
            entity.ToTable("ziyaret", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Baslangicsaat)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICSAAT");
            entity.Property(e => e.Baslangictarih)
                .HasColumnType("datetime")
                .HasColumnName("BASLANGICTARIH");
            entity.Property(e => e.Bitissaat)
                .HasColumnType("datetime")
                .HasColumnName("BITISSAAT");
            entity.Property(e => e.Bitistarih)
                .HasColumnType("datetime")
                .HasColumnName("BITISTARIH");
            entity.Property(e => e.Bsid).HasColumnName("BSID");
            entity.Property(e => e.Chid).HasColumnName("CHID");
            entity.Property(e => e.Faturaid).HasColumnName("FATURAID");
            entity.Property(e => e.Gpsboylam).HasColumnName("GPSBOYLAM");
            entity.Property(e => e.Gpsenlem).HasColumnName("GPSENLEM");
            entity.Property(e => e.Gpsonay).HasColumnName("GPSONAY");
            entity.Property(e => e.Islemtip)
                .HasMaxLength(4)
                .HasColumnName("ISLEMTIP");
            entity.Property(e => e.Sevkadresid).HasColumnName("SEVKADRESID");
            entity.Property(e => e.Siparisid).HasColumnName("SIPARISID");
            entity.Property(e => e.Tahsilatid).HasColumnName("TAHSILATID");
            entity.Property(e => e.Temsilciid).HasColumnName("TEMSILCIID");
            entity.Property(e => e.Ziyaretnot)
                .HasMaxLength(255)
                .HasColumnName("ZIYARETNOT");
        });

        modelBuilder.Entity<ZiyaretB>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_led_ziyaret_bs");

            entity.ToTable("ziyaret_bs", "led");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kod)
                .HasMaxLength(255)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<Zrapor>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_zrapor");

            entity.ToTable("zrapor", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aciklama)
                .HasMaxLength(255)
                .HasColumnName("ACIKLAMA");
            entity.Property(e => e.Faturatutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FATURATUTAR");
            entity.Property(e => e.Nakittutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("NAKITTUTAR");
            entity.Property(e => e.Postutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("POSTUTAR");
            entity.Property(e => e.Subeid).HasColumnName("SUBEID");
            entity.Property(e => e.Tarih)
                .HasColumnType("datetime")
                .HasColumnName("TARIH");
            entity.Property(e => e.Yemekcekitutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("YEMEKCEKITUTAR");
            entity.Property(e => e.Zfisno)
                .HasMaxLength(100)
                .HasColumnName("ZFISNO");
        });

        modelBuilder.Entity<ZraporDepartmantanim>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_zrapor_departmantanim");

            entity.ToTable("zrapor_departmantanim", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aktif).HasColumnName("AKTIF");
            entity.Property(e => e.Birimid).HasColumnName("BIRIMID");
            entity.Property(e => e.Entegrasyonkod)
                .HasMaxLength(255)
                .HasColumnName("ENTEGRASYONKOD");
            entity.Property(e => e.Fiyat)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("FIYAT");
            entity.Property(e => e.Isim)
                .HasMaxLength(255)
                .HasColumnName("ISIM");
            entity.Property(e => e.Kdvoran)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("KDVORAN");
            entity.Property(e => e.Kod)
                .HasMaxLength(100)
                .HasColumnName("KOD");
        });

        modelBuilder.Entity<ZraporDetay>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_pt_zrapor_detay");

            entity.ToTable("zrapor_detay", "pt");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Departmanid).HasColumnName("DEPARTMANID");
            entity.Property(e => e.Tutar)
                .HasColumnType("numeric(18, 2)")
                .HasColumnName("TUTAR");
            entity.Property(e => e.Zraporid).HasColumnName("ZRAPORID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
