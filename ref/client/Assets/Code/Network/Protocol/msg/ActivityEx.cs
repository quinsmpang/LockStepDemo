//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ActivityEx.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MainActivityInfo")]
  public partial class MainActivityInfo : global::ProtoBuf.IExtensible
  {
    public MainActivityInfo() {}
    
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.MatchActivity> _match_activities = new global::System.Collections.Generic.List<fogs.proto.msg.MatchActivity>();
    [global::ProtoBuf.ProtoMember(1, Name=@"match_activities", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.MatchActivity> match_activities
    {
      get { return _match_activities; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MatchActivity")]
  public partial class MatchActivity : global::ProtoBuf.IExtensible
  {
    public MatchActivity() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _race_times = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"race_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint race_times
    {
      get { return _race_times; }
      set { _race_times = value; }
    }
    private uint _reset_time = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"reset_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint reset_time
    {
      get { return _reset_time; }
      set { _reset_time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}