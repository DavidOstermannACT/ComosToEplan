//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// Dieser Quellcode wurde automatisch generiert von xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="...\\Schemas\\ComosToXML.xsd")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="...\\Schemas\\ComosToXML.xsd", IsNullable=false)]
public partial class ComosToXML {
    
    private ComosToXMLData[] comosField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Data", IsNullable=false)]
    public ComosToXMLData[] Comos {
        get {
            return this.comosField;
        }
        set {
            this.comosField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="...\\Schemas\\ComosToXML.xsd")]
public partial class ComosToXMLData {
    
    private byte ePC_RevisionField;
    
    private string ePC_Rev_KommentarField;
    
    private string mSRStatusField;
    
    private byte rev_PMSField;
    
    private string pMS_KommentarField;
    
    private byte rev_ACTField;
    
    private string aCT_KommentarField;
    
    private string funktion_erzeugt_amField;
    
    private string funktionField;
    
    private string tag_NrField;
    
    private string tag_NameField;
    
    private string tag_Name_ActemiumField;
    
    private byte teilanlageField;
    
    private string beschreibungField;
    
    private string ebeneField;
    
    private string xYZ_KoordinateField;
    
    private string herstellerField;
    
    private string typ_GeraetField;
    
    private string gereäte_BeschreibungField;
    
    private string anbindungField;
    
    private string signalrichtungField;
    
    private string wertebereichField;
    
    private string signalphysikField;
    
    private string safetypositionField;
    
    private string sW_TypicalField;
    
    private string oS_BildbausteinField;
    
    private string signal_erzeugt_amField;
    
    private string signalerweiterungField;
    
    private string signal_StatusField;
    
    private string signalbezeichnungField;
    
    private string verbalbeschreibungField;
    
    private string pLS_SignalField;
    
    private string signalgrundtypField;
    
    private string mB_minField;
    
    private string mB_maxField;
    
    private string einheit_MessbereichField;
    
    private string hystereseField;
    
    private string reglerwirkungField;
    
    private string stellgrenze_LField;
    
    private string stellgrenze_HField;
    
    private string alarm_untenField;
    
    private string warnung_untenField;
    
    private string toleranz_untenField;
    
    private string alarm_obenField;
    
    private string warnung_obenField;
    
    private string toleranz_obenField;
    
    private string bedeutung_0Field;
    
    private string bedeutung_1Field;
    
    private string reversField;
    
    private string busstrangField;
    
    private byte sK3Field;
    
    private byte trunkField;
    
    private byte feldbarriereField;
    
    private string aS_ZuordnungField;
    
    private string iO_StationField;
    
    private string rackField;
    
    private byte steckplatzField;
    
    private byte kanalField;
    
    private string hW_TypicalField;
    
    private string hW_AdresseField;
    
    private byte pB_AdresseField;
    
    private string kartentypField;
    
    private string slaveTypField;
    
    private string archivierungszyklusField;
    
    private string kurzname_BildField;
    
    private string ruIField;
    
    private string planungsoptionField;
    
    private string ausbaustufe_filterField;
    
    /// <remarks/>
    public byte EPC_Revision {
        get {
            return this.ePC_RevisionField;
        }
        set {
            this.ePC_RevisionField = value;
        }
    }
    
    /// <remarks/>
    public string EPC_Rev_Kommentar {
        get {
            return this.ePC_Rev_KommentarField;
        }
        set {
            this.ePC_Rev_KommentarField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("MSR-Status")]
    public string MSRStatus {
        get {
            return this.mSRStatusField;
        }
        set {
            this.mSRStatusField = value;
        }
    }
    
    /// <remarks/>
    public byte Rev_PMS {
        get {
            return this.rev_PMSField;
        }
        set {
            this.rev_PMSField = value;
        }
    }
    
    /// <remarks/>
    public string PMS_Kommentar {
        get {
            return this.pMS_KommentarField;
        }
        set {
            this.pMS_KommentarField = value;
        }
    }
    
    /// <remarks/>
    public byte Rev_ACT {
        get {
            return this.rev_ACTField;
        }
        set {
            this.rev_ACTField = value;
        }
    }
    
    /// <remarks/>
    public string ACT_Kommentar {
        get {
            return this.aCT_KommentarField;
        }
        set {
            this.aCT_KommentarField = value;
        }
    }
    
    /// <remarks/>
    public string Funktion_erzeugt_am {
        get {
            return this.funktion_erzeugt_amField;
        }
        set {
            this.funktion_erzeugt_amField = value;
        }
    }
    
    /// <remarks/>
    public string Funktion {
        get {
            return this.funktionField;
        }
        set {
            this.funktionField = value;
        }
    }
    
    /// <remarks/>
    public string Tag_Nr {
        get {
            return this.tag_NrField;
        }
        set {
            this.tag_NrField = value;
        }
    }
    
    /// <remarks/>
    public string Tag_Name {
        get {
            return this.tag_NameField;
        }
        set {
            this.tag_NameField = value;
        }
    }
    
    /// <remarks/>
    public string Tag_Name_Actemium {
        get {
            return this.tag_Name_ActemiumField;
        }
        set {
            this.tag_Name_ActemiumField = value;
        }
    }
    
    /// <remarks/>
    public byte Teilanlage {
        get {
            return this.teilanlageField;
        }
        set {
            this.teilanlageField = value;
        }
    }
    
    /// <remarks/>
    public string Beschreibung {
        get {
            return this.beschreibungField;
        }
        set {
            this.beschreibungField = value;
        }
    }
    
    /// <remarks/>
    public string Ebene {
        get {
            return this.ebeneField;
        }
        set {
            this.ebeneField = value;
        }
    }
    
    /// <remarks/>
    public string XYZ_Koordinate {
        get {
            return this.xYZ_KoordinateField;
        }
        set {
            this.xYZ_KoordinateField = value;
        }
    }
    
    /// <remarks/>
    public string Hersteller {
        get {
            return this.herstellerField;
        }
        set {
            this.herstellerField = value;
        }
    }
    
    /// <remarks/>
    public string Typ_Geraet {
        get {
            return this.typ_GeraetField;
        }
        set {
            this.typ_GeraetField = value;
        }
    }
    
    /// <remarks/>
    public string Gereäte_Beschreibung {
        get {
            return this.gereäte_BeschreibungField;
        }
        set {
            this.gereäte_BeschreibungField = value;
        }
    }
    
    /// <remarks/>
    public string Anbindung {
        get {
            return this.anbindungField;
        }
        set {
            this.anbindungField = value;
        }
    }
    
    /// <remarks/>
    public string Signalrichtung {
        get {
            return this.signalrichtungField;
        }
        set {
            this.signalrichtungField = value;
        }
    }
    
    /// <remarks/>
    public string Wertebereich {
        get {
            return this.wertebereichField;
        }
        set {
            this.wertebereichField = value;
        }
    }
    
    /// <remarks/>
    public string Signalphysik {
        get {
            return this.signalphysikField;
        }
        set {
            this.signalphysikField = value;
        }
    }
    
    /// <remarks/>
    public string Safetyposition {
        get {
            return this.safetypositionField;
        }
        set {
            this.safetypositionField = value;
        }
    }
    
    /// <remarks/>
    public string SW_Typical {
        get {
            return this.sW_TypicalField;
        }
        set {
            this.sW_TypicalField = value;
        }
    }
    
    /// <remarks/>
    public string OS_Bildbaustein {
        get {
            return this.oS_BildbausteinField;
        }
        set {
            this.oS_BildbausteinField = value;
        }
    }
    
    /// <remarks/>
    public string Signal_erzeugt_am {
        get {
            return this.signal_erzeugt_amField;
        }
        set {
            this.signal_erzeugt_amField = value;
        }
    }
    
    /// <remarks/>
    public string Signalerweiterung {
        get {
            return this.signalerweiterungField;
        }
        set {
            this.signalerweiterungField = value;
        }
    }
    
    /// <remarks/>
    public string Signal_Status {
        get {
            return this.signal_StatusField;
        }
        set {
            this.signal_StatusField = value;
        }
    }
    
    /// <remarks/>
    public string Signalbezeichnung {
        get {
            return this.signalbezeichnungField;
        }
        set {
            this.signalbezeichnungField = value;
        }
    }
    
    /// <remarks/>
    public string Verbalbeschreibung {
        get {
            return this.verbalbeschreibungField;
        }
        set {
            this.verbalbeschreibungField = value;
        }
    }
    
    /// <remarks/>
    public string PLS_Signal {
        get {
            return this.pLS_SignalField;
        }
        set {
            this.pLS_SignalField = value;
        }
    }
    
    /// <remarks/>
    public string Signalgrundtyp {
        get {
            return this.signalgrundtypField;
        }
        set {
            this.signalgrundtypField = value;
        }
    }
    
    /// <remarks/>
    public string MB_min {
        get {
            return this.mB_minField;
        }
        set {
            this.mB_minField = value;
        }
    }
    
    /// <remarks/>
    public string MB_max {
        get {
            return this.mB_maxField;
        }
        set {
            this.mB_maxField = value;
        }
    }
    
    /// <remarks/>
    public string Einheit_Messbereich {
        get {
            return this.einheit_MessbereichField;
        }
        set {
            this.einheit_MessbereichField = value;
        }
    }
    
    /// <remarks/>
    public string Hysterese {
        get {
            return this.hystereseField;
        }
        set {
            this.hystereseField = value;
        }
    }
    
    /// <remarks/>
    public string Reglerwirkung {
        get {
            return this.reglerwirkungField;
        }
        set {
            this.reglerwirkungField = value;
        }
    }
    
    /// <remarks/>
    public string Stellgrenze_L {
        get {
            return this.stellgrenze_LField;
        }
        set {
            this.stellgrenze_LField = value;
        }
    }
    
    /// <remarks/>
    public string Stellgrenze_H {
        get {
            return this.stellgrenze_HField;
        }
        set {
            this.stellgrenze_HField = value;
        }
    }
    
    /// <remarks/>
    public string Alarm_unten {
        get {
            return this.alarm_untenField;
        }
        set {
            this.alarm_untenField = value;
        }
    }
    
    /// <remarks/>
    public string Warnung_unten {
        get {
            return this.warnung_untenField;
        }
        set {
            this.warnung_untenField = value;
        }
    }
    
    /// <remarks/>
    public string Toleranz_unten {
        get {
            return this.toleranz_untenField;
        }
        set {
            this.toleranz_untenField = value;
        }
    }
    
    /// <remarks/>
    public string Alarm_oben {
        get {
            return this.alarm_obenField;
        }
        set {
            this.alarm_obenField = value;
        }
    }
    
    /// <remarks/>
    public string Warnung_oben {
        get {
            return this.warnung_obenField;
        }
        set {
            this.warnung_obenField = value;
        }
    }
    
    /// <remarks/>
    public string Toleranz_oben {
        get {
            return this.toleranz_obenField;
        }
        set {
            this.toleranz_obenField = value;
        }
    }
    
    /// <remarks/>
    public string Bedeutung_0 {
        get {
            return this.bedeutung_0Field;
        }
        set {
            this.bedeutung_0Field = value;
        }
    }
    
    /// <remarks/>
    public string Bedeutung_1 {
        get {
            return this.bedeutung_1Field;
        }
        set {
            this.bedeutung_1Field = value;
        }
    }
    
    /// <remarks/>
    public string revers {
        get {
            return this.reversField;
        }
        set {
            this.reversField = value;
        }
    }
    
    /// <remarks/>
    public string Busstrang {
        get {
            return this.busstrangField;
        }
        set {
            this.busstrangField = value;
        }
    }
    
    /// <remarks/>
    public byte SK3 {
        get {
            return this.sK3Field;
        }
        set {
            this.sK3Field = value;
        }
    }
    
    /// <remarks/>
    public byte Trunk {
        get {
            return this.trunkField;
        }
        set {
            this.trunkField = value;
        }
    }
    
    /// <remarks/>
    public byte Feldbarriere {
        get {
            return this.feldbarriereField;
        }
        set {
            this.feldbarriereField = value;
        }
    }
    
    /// <remarks/>
    public string AS_Zuordnung {
        get {
            return this.aS_ZuordnungField;
        }
        set {
            this.aS_ZuordnungField = value;
        }
    }
    
    /// <remarks/>
    public string IO_Station {
        get {
            return this.iO_StationField;
        }
        set {
            this.iO_StationField = value;
        }
    }
    
    /// <remarks/>
    public string Rack {
        get {
            return this.rackField;
        }
        set {
            this.rackField = value;
        }
    }
    
    /// <remarks/>
    public byte Steckplatz {
        get {
            return this.steckplatzField;
        }
        set {
            this.steckplatzField = value;
        }
    }
    
    /// <remarks/>
    public byte Kanal {
        get {
            return this.kanalField;
        }
        set {
            this.kanalField = value;
        }
    }
    
    /// <remarks/>
    public string HW_Typical {
        get {
            return this.hW_TypicalField;
        }
        set {
            this.hW_TypicalField = value;
        }
    }
    
    /// <remarks/>
    public string HW_Adresse {
        get {
            return this.hW_AdresseField;
        }
        set {
            this.hW_AdresseField = value;
        }
    }
    
    /// <remarks/>
    public byte PB_Adresse {
        get {
            return this.pB_AdresseField;
        }
        set {
            this.pB_AdresseField = value;
        }
    }
    
    /// <remarks/>
    public string Kartentyp {
        get {
            return this.kartentypField;
        }
        set {
            this.kartentypField = value;
        }
    }
    
    /// <remarks/>
    public string SlaveTyp {
        get {
            return this.slaveTypField;
        }
        set {
            this.slaveTypField = value;
        }
    }
    
    /// <remarks/>
    public string Archivierungszyklus {
        get {
            return this.archivierungszyklusField;
        }
        set {
            this.archivierungszyklusField = value;
        }
    }
    
    /// <remarks/>
    public string Kurzname_Bild {
        get {
            return this.kurzname_BildField;
        }
        set {
            this.kurzname_BildField = value;
        }
    }
    
    /// <remarks/>
    public string RuI {
        get {
            return this.ruIField;
        }
        set {
            this.ruIField = value;
        }
    }
    
    /// <remarks/>
    public string Planungsoption {
        get {
            return this.planungsoptionField;
        }
        set {
            this.planungsoptionField = value;
        }
    }
    
    /// <remarks/>
    public string Ausbaustufe_filter {
        get {
            return this.ausbaustufe_filterField;
        }
        set {
            this.ausbaustufe_filterField = value;
        }
    }
}
