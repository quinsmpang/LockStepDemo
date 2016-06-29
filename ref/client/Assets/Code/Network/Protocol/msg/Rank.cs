//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Rank.proto
// Note: requires additional types generated from: Player.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankInfo")]
  public partial class RankInfo : global::ProtoBuf.IExtensible
  {
    public RankInfo() {}
    
    private uint _acc_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"acc_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint acc_id
    {
      get { return _acc_id; }
      set { _acc_id = value; }
    }
    private string _name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private uint _level = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private uint _wealth = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"wealth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint wealth
    {
      get { return _wealth; }
      set { _wealth = value; }
    }
    private uint _points = default(uint);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"points", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint points
    {
      get { return _points; }
      set { _points = value; }
    }
    private uint _vip_exp = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"vip_exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint vip_exp
    {
      get { return _vip_exp; }
      set { _vip_exp = value; }
    }
    private string _show_id = "";
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"show_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string show_id
    {
      get { return _show_id; }
      set { _show_id = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.RoleInfo> _role_info = new global::System.Collections.Generic.List<fogs.proto.msg.RoleInfo>();
    [global::ProtoBuf.ProtoMember(8, Name=@"role_info", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.RoleInfo> role_info
    {
      get { return _role_info; }
    }
  
    private uint _ranking = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ranking", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint ranking
    {
      get { return _ranking; }
      set { _ranking = value; }
    }
    private uint _rank_time = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"rank_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint rank_time
    {
      get { return _rank_time; }
      set { _rank_time = value; }
    }
    private uint _fight_power = default(uint);
    [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"fight_power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint fight_power
    {
      get { return _fight_power; }
      set { _fight_power = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FetchRankListReq")]
  public partial class FetchRankListReq : global::ProtoBuf.IExtensible
  {
    public FetchRankListReq() {}
    
    private fogs.proto.msg.RankType _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.RankType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _server_id = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"server_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint server_id
    {
      get { return _server_id; }
      set { _server_id = value; }
    }
    private uint _max_item = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"max_item", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint max_item
    {
      get { return _max_item; }
      set { _max_item = value; }
    }
    private uint _max_enable_item = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"max_enable_item", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint max_enable_item
    {
      get { return _max_enable_item; }
      set { _max_enable_item = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FetchRankListResp")]
  public partial class FetchRankListResp : global::ProtoBuf.IExtensible
  {
    public FetchRankListResp() {}
    
    private fogs.proto.msg.RankType _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.RankType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _result = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.RankInfo> _rank_list = new global::System.Collections.Generic.List<fogs.proto.msg.RankInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rank_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.RankInfo> rank_list
    {
      get { return _rank_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateRankList")]
  public partial class UpdateRankList : global::ProtoBuf.IExtensible
  {
    public UpdateRankList() {}
    
    private fogs.proto.msg.RankType _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.RankType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private fogs.proto.msg.RankInfo _challenger = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"challenger", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public fogs.proto.msg.RankInfo challenger
    {
      get { return _challenger; }
      set { _challenger = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.RankInfo> _rank_list = new global::System.Collections.Generic.List<fogs.proto.msg.RankInfo>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rank_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.RankInfo> rank_list
    {
      get { return _rank_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankListReq")]
  public partial class RankListReq : global::ProtoBuf.IExtensible
  {
    public RankListReq() {}
    
    private fogs.proto.msg.RankType _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.RankType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private fogs.proto.msg.RankSubType _sub_type = fogs.proto.msg.RankSubType.RST_POSITION_C;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"sub_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(fogs.proto.msg.RankSubType.RST_POSITION_C)]
    public fogs.proto.msg.RankSubType sub_type
    {
      get { return _sub_type; }
      set { _sub_type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RankListResp")]
  public partial class RankListResp : global::ProtoBuf.IExtensible
  {
    public RankListResp() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private fogs.proto.msg.RankType _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public fogs.proto.msg.RankType type
    {
      get { return _type; }
      set { _type = value; }
    }
    private fogs.proto.msg.RankSubType _sub_type = fogs.proto.msg.RankSubType.RST_POSITION_C;
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"sub_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(fogs.proto.msg.RankSubType.RST_POSITION_C)]
    public fogs.proto.msg.RankSubType sub_type
    {
      get { return _sub_type; }
      set { _sub_type = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.RankInfo> _rank_list = new global::System.Collections.Generic.List<fogs.proto.msg.RankInfo>();
    [global::ProtoBuf.ProtoMember(4, Name=@"rank_list", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.RankInfo> rank_list
    {
      get { return _rank_list; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"RankType")]
    public enum RankType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_LEVEL", Value=1)]
      RT_LEVEL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_WEALTH", Value=2)]
      RT_WEALTH = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_CUR_REGULAR_POINTS", Value=3)]
      RT_CUR_REGULAR_POINTS = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_LAST_REGULAR_POINTS", Value=4)]
      RT_LAST_REGULAR_POINTS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_QUALIFYING", Value=5)]
      RT_QUALIFYING = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_PVP", Value=6)]
      RT_PVP = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_QUALIFYING_NEW", Value=7)]
      RT_QUALIFYING_NEW = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_LADDER", Value=8)]
      RT_LADDER = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_POSITION", Value=9)]
      RT_POSITION = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_ACHIEVEMENT", Value=10)]
      RT_ACHIEVEMENT = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RT_TOTAL", Value=11)]
      RT_TOTAL = 11
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"RankSubType")]
    public enum RankSubType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"RST_POSITION_C", Value=1)]
      RST_POSITION_C = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RST_POSITION_PF", Value=2)]
      RST_POSITION_PF = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RST_POSITION_SF", Value=3)]
      RST_POSITION_SF = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RST_POSITION_PG", Value=4)]
      RST_POSITION_PG = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"RST_POSITION_SG", Value=5)]
      RST_POSITION_SG = 5
    }
  
}