﻿//------------------------------------------------------------------------------
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
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace="", IsNullable=false)]
public partial class MSRKaesten {
    
    private MSRKaestenBMKPA[] pABestueckungField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("BMKPA", IsNullable=false)]
    public MSRKaestenBMKPA[] PABestueckung {
        get {
            return this.pABestueckungField;
        }
        set {
            this.pABestueckungField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true)]
public partial class MSRKaestenBMKPA {
    
    private string bMKField;
    
    private byte anzahlFeldbarrierenField;
    
    private byte anzahlPAPt100Field;
    
    private byte anzahlMultiinputField;
    
    /// <remarks/>
    public string BMK {
        get {
            return this.bMKField;
        }
        set {
            this.bMKField = value;
        }
    }
    
    /// <remarks/>
    public byte anzahlFeldbarrieren {
        get {
            return this.anzahlFeldbarrierenField;
        }
        set {
            this.anzahlFeldbarrierenField = value;
        }
    }
    
    /// <remarks/>
    public byte anzahlPAPt100 {
        get {
            return this.anzahlPAPt100Field;
        }
        set {
            this.anzahlPAPt100Field = value;
        }
    }
    
    /// <remarks/>
    public byte anzahlMultiinput {
        get {
            return this.anzahlMultiinputField;
        }
        set {
            this.anzahlMultiinputField = value;
        }
    }
}
