//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Training.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TrainingInfo")]
  public partial class TrainingInfo : global::ProtoBuf.IExtensible
  {
    public TrainingInfo() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _level = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private fogs.proto.msg.TrainingState _state = fogs.proto.msg.TrainingState.TS_IDLE;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(fogs.proto.msg.TrainingState.TS_IDLE)]
    public fogs.proto.msg.TrainingState state
    {
      get { return _state; }
      set { _state = value; }
    }
    private uint _remaining_time = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"remaining_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint remaining_time
    {
      get { return _remaining_time; }
      set { _remaining_time = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OpenTraining")]
  public partial class OpenTraining : global::ProtoBuf.IExtensible
  {
    public OpenTraining() {}
    
    private uint _captain_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"captain_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint captain_id
    {
      get { return _captain_id; }
      set { _captain_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OpenTrainingResp")]
  public partial class OpenTrainingResp : global::ProtoBuf.IExtensible
  {
    public OpenTrainingResp() {}
    
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _captain_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"captain_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint captain_id
    {
      get { return _captain_id; }
      set { _captain_id = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.TrainingInfo> _training = new global::System.Collections.Generic.List<fogs.proto.msg.TrainingInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"training", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.TrainingInfo> training
    {
      get { return _training; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StartTraining")]
  public partial class StartTraining : global::ProtoBuf.IExtensible
  {
    public StartTraining() {}
    
    private uint _captain_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"captain_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint captain_id
    {
      get { return _captain_id; }
      set { _captain_id = value; }
    }
    private uint _training_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"training_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint training_id
    {
      get { return _training_id; }
      set { _training_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StartTrainingResp")]
  public partial class StartTrainingResp : global::ProtoBuf.IExtensible
  {
    public StartTrainingResp() {}
    
    private uint _captain_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"captain_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint captain_id
    {
      get { return _captain_id; }
      set { _captain_id = value; }
    }
    private uint _training_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"training_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint training_id
    {
      get { return _training_id; }
      set { _training_id = value; }
    }
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NotifyTrainingInfo")]
  public partial class NotifyTrainingInfo : global::ProtoBuf.IExtensible
  {
    public NotifyTrainingInfo() {}
    
    private uint _captain_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"captain_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint captain_id
    {
      get { return _captain_id; }
      set { _captain_id = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.TrainingInfo> _training = new global::System.Collections.Generic.List<fogs.proto.msg.TrainingInfo>();
    [global::ProtoBuf.ProtoMember(2, Name=@"training", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.TrainingInfo> training
    {
      get { return _training; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"TrainingState")]
    public enum TrainingState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TS_IDLE", Value=1)]
      TS_IDLE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TS_COOLING", Value=2)]
      TS_COOLING = 2
    }
  
}