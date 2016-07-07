//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Documents/UniversalTransferDocument.proto
namespace Diadoc.Api.Proto.Documents.UniversalTransferDocument
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UniversalTransferDocumentMetadata")]
  public partial class UniversalTransferDocumentMetadata : global::ProtoBuf.IExtensible
  {
    public UniversalTransferDocumentMetadata() {}
    

    private Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus _Status = Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus.OutboundWaitingForReceipt;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus.OutboundWaitingForReceipt)]
    public Diadoc.Api.Proto.Documents.UniversalTransferDocument.UniversalTransferDocumentStatus Status
    {
      get { return _Status; }
      set { _Status = value; }
    }
    private string _Total;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"Total", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Total
    {
      get { return _Total; }
      set { _Total = value; }
    }
    private string _Vat;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"Vat", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string Vat
    {
      get { return _Vat; }
      set { _Vat = value; }
    }
    private int _Currency;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"Currency", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int Currency
    {
      get { return _Currency; }
      set { _Currency = value; }
    }
    private long _ConfirmationDateTimeTicks;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"ConfirmationDateTimeTicks", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public long ConfirmationDateTimeTicks
    {
      get { return _ConfirmationDateTimeTicks; }
      set { _ConfirmationDateTimeTicks = value; }
    }
    private int _AmendmentFlags;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"AmendmentFlags", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int AmendmentFlags
    {
      get { return _AmendmentFlags; }
      set { _AmendmentFlags = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"UniversalTransferDocumentStatus")]
    public enum UniversalTransferDocumentStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForReceipt", Value=1)]
      OutboundWaitingForReceipt = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundNotFinished", Value=2)]
      OutboundNotFinished = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundFinished", Value=3)]
      OutboundFinished = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundWaitingForSenderSignature", Value=6)]
      OutboundWaitingForSenderSignature = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"OutboundInvalidSenderSignature", Value=7)]
      OutboundInvalidSenderSignature = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundNotFinished", Value=4)]
      InboundNotFinished = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"InboundFinished", Value=5)]
      InboundFinished = 5
    }
  
}