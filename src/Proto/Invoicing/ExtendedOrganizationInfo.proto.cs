//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Invoicing/ExtendedOrganizationInfo.proto
// Note: requires additional types generated from: Address.proto
namespace Diadoc.Api.Proto.Invoicing.Organizations
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExtendedOrganizationInfo")]
  public partial class ExtendedOrganizationInfo : global::ProtoBuf.IExtensible
  {
    public ExtendedOrganizationInfo() {}
    

    private string _BoxId = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"BoxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BoxId
    {
      get { return _BoxId; }
      set { _BoxId = value; }
    }

    private string _OrgName = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OrgName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OrgName
    {
      get { return _OrgName; }
      set { _OrgName = value; }
    }

    private string _Inn = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Inn", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Inn
    {
      get { return _Inn; }
      set { _Inn = value; }
    }

    private string _Kpp = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Kpp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Kpp
    {
      get { return _Kpp; }
      set { _Kpp = value; }
    }

    private Diadoc.Api.Proto.Address _Address = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Address", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Diadoc.Api.Proto.Address Address
    {
      get { return _Address; }
      set { _Address = value; }
    }

    private string _FnsParticipantId = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"FnsParticipantId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string FnsParticipantId
    {
      get { return _FnsParticipantId; }
      set { _FnsParticipantId = value; }
    }
    private Diadoc.Api.Proto.Invoicing.Organizations.OrgType _OrgType;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"OrgType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public Diadoc.Api.Proto.Invoicing.Organizations.OrgType OrgType
    {
      get { return _OrgType; }
      set { _OrgType = value; }
    }

    private string _Okopf = "";
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Okopf", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Okopf
    {
      get { return _Okopf; }
      set { _Okopf = value; }
    }

    private string _Okpo = "";
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Okpo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Okpo
    {
      get { return _Okpo; }
      set { _Okpo = value; }
    }

    private string _Okdp = "";
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Okdp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Okdp
    {
      get { return _Okdp; }
      set { _Okdp = value; }
    }

    private string _Phone = "";
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Phone
    {
      get { return _Phone; }
      set { _Phone = value; }
    }

    private string _Email = "";
    [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Email", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Email
    {
      get { return _Email; }
      set { _Email = value; }
    }

    private string _CorrespondentAccount = "";
    [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CorrespondentAccount", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string CorrespondentAccount
    {
      get { return _CorrespondentAccount; }
      set { _CorrespondentAccount = value; }
    }

    private string _BankAccountNumber = "";
    [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"BankAccountNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BankAccountNumber
    {
      get { return _BankAccountNumber; }
      set { _BankAccountNumber = value; }
    }

    private string _BankName = "";
    [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"BankName", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BankName
    {
      get { return _BankName; }
      set { _BankName = value; }
    }

    private string _BankId = "";
    [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"BankId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string BankId
    {
      get { return _BankId; }
      set { _BankId = value; }
    }

    private string _Department = "";
    [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"Department", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Department
    {
      get { return _Department; }
      set { _Department = value; }
    }

    private string _OrganizationAdditionalInfo = "";
    [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"OrganizationAdditionalInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OrganizationAdditionalInfo
    {
      get { return _OrganizationAdditionalInfo; }
      set { _OrganizationAdditionalInfo = value; }
    }

    private string _OrganizationOrPersonInfo = "";
    [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"OrganizationOrPersonInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string OrganizationOrPersonInfo
    {
      get { return _OrganizationOrPersonInfo; }
      set { _OrganizationOrPersonInfo = value; }
    }

    private string _IndividualEntityRegistrationCertificate = "";
    [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"IndividualEntityRegistrationCertificate", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string IndividualEntityRegistrationCertificate
    {
      get { return _IndividualEntityRegistrationCertificate; }
      set { _IndividualEntityRegistrationCertificate = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"OrgType")]
    public enum OrgType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"LegalEntity", Value=1)]
      LegalEntity = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"IndividualEntity", Value=2)]
      IndividualEntity = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ForeignEntity", Value=3)]
      ForeignEntity = 3
    }
  
}