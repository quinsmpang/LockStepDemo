//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Base.proto
namespace fogs.proto.msg
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SVector3")]
  public partial class SVector3 : global::ProtoBuf.IExtensible
  {
    public SVector3() {}
    
    private double _x;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"x", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double x
    {
      get { return _x; }
      set { _x = value; }
    }
    private double _y;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"y", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double y
    {
      get { return _y; }
      set { _y = value; }
    }
    private double _z;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"z", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public double z
    {
      get { return _z; }
      set { _z = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"KeyValueData")]
  public partial class KeyValueData : global::ProtoBuf.IExtensible
  {
    public KeyValueData() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _value = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint value
    {
      get { return _value; }
      set { _value = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FightRole")]
  public partial class FightRole : global::ProtoBuf.IExtensible
  {
    public FightRole() {}
    
    private uint _role_id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"role_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint role_id
    {
      get { return _role_id; }
      set { _role_id = value; }
    }
    private fogs.proto.msg.FightStatus _status = fogs.proto.msg.FightStatus.FS_NONE;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(fogs.proto.msg.FightStatus.FS_NONE)]
    public fogs.proto.msg.FightStatus status
    {
      get { return _status; }
      set { _status = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FightRoleInfo")]
  public partial class FightRoleInfo : global::ProtoBuf.IExtensible
  {
    public FightRoleInfo() {}
    
    private fogs.proto.msg.GameMode _game_mode = fogs.proto.msg.GameMode.GM_None;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"game_mode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(fogs.proto.msg.GameMode.GM_None)]
    public fogs.proto.msg.GameMode game_mode
    {
      get { return _game_mode; }
      set { _game_mode = value; }
    }
    private readonly global::System.Collections.Generic.List<fogs.proto.msg.FightRole> _fighters = new global::System.Collections.Generic.List<fogs.proto.msg.FightRole>();
    [global::ProtoBuf.ProtoMember(2, Name=@"fighters", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<fogs.proto.msg.FightRole> fighters
    {
      get { return _fighters; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MatchRoleInfo")]
  public partial class MatchRoleInfo : global::ProtoBuf.IExtensible
  {
    public MatchRoleInfo() {}
    
    private uint _id = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _exp = default(uint);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    [global::ProtoBuf.ProtoContract(Name=@"PlayerType")]
    public enum PlayerType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_CAPTAIN", Value=1)]
      PT_CAPTAIN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_MEMBER", Value=2)]
      PT_MEMBER = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"QualityType")]
    public enum QualityType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_NONE", Value=0)]
      QT_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_D_MINUS", Value=1)]
      QT_D_MINUS = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_D", Value=2)]
      QT_D = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_D_PLUS", Value=3)]
      QT_D_PLUS = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_C_MINUS", Value=4)]
      QT_C_MINUS = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_C", Value=5)]
      QT_C = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_C_PLUS", Value=6)]
      QT_C_PLUS = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_B_MINUS", Value=7)]
      QT_B_MINUS = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_B", Value=8)]
      QT_B = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_B_PLUS", Value=9)]
      QT_B_PLUS = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_A_MINUS", Value=10)]
      QT_A_MINUS = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_A", Value=11)]
      QT_A = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_A_PLUS", Value=12)]
      QT_A_PLUS = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_S_MINUS", Value=13)]
      QT_S_MINUS = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_S", Value=14)]
      QT_S = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QT_S_PLUS", Value=15)]
      QT_S_PLUS = 15
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"QualityGrade")]
    public enum QualityGrade
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_NONE", Value=0)]
      QG_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_WHITE", Value=1)]
      QG_WHITE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_GREEN", Value=2)]
      QG_GREEN = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_GREEN_1", Value=3)]
      QG_GREEN_1 = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_BLUE", Value=4)]
      QG_BLUE = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_BLUE_1", Value=5)]
      QG_BLUE_1 = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_BLUE_2", Value=6)]
      QG_BLUE_2 = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_PURPLE", Value=7)]
      QG_PURPLE = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_PURPLE_1", Value=8)]
      QG_PURPLE_1 = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_PURPLE_2", Value=9)]
      QG_PURPLE_2 = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_PURPLE_3", Value=10)]
      QG_PURPLE_3 = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_GOLD", Value=11)]
      QG_GOLD = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_GOLD_1", Value=12)]
      QG_GOLD_1 = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_GOLD_2", Value=13)]
      QG_GOLD_2 = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_GOLD_3", Value=14)]
      QG_GOLD_3 = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"QG_GOLD_4", Value=15)]
      QG_GOLD_4 = 15
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"CaptainBias")]
    public enum CaptainBias
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"CB_NONE", Value=0)]
      CB_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CB_ATTACK", Value=1)]
      CB_ATTACK = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CB_DEFENCE", Value=2)]
      CB_DEFENCE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"CB_BALANCE", Value=3)]
      CB_BALANCE = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"GenderType")]
    public enum GenderType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GT_COMMON", Value=0)]
      GT_COMMON = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GT_MALE", Value=1)]
      GT_MALE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GT_FEMALE", Value=2)]
      GT_FEMALE = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"PositionType")]
    public enum PositionType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_NONE", Value=0)]
      PT_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_PF", Value=1)]
      PT_PF = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_SF", Value=2)]
      PT_SF = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_C", Value=3)]
      PT_C = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_PG", Value=4)]
      PT_PG = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_SG", Value=5)]
      PT_SG = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PT_TOTAL", Value=6)]
      PT_TOTAL = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"StarLevel")]
    public enum StarLevel
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SL_NONE", Value=0)]
      SL_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SL_0", Value=1)]
      SL_0 = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SL_1", Value=2)]
      SL_1 = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SL_2", Value=3)]
      SL_2 = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SL_3", Value=4)]
      SL_3 = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SL_4", Value=5)]
      SL_4 = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SL_5", Value=6)]
      SL_5 = 6
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"FightStatus")]
    public enum FightStatus
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"FS_NONE", Value=0)]
      FS_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FS_MAIN", Value=1)]
      FS_MAIN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FS_ASSIST1", Value=2)]
      FS_ASSIST1 = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"FS_ASSIST2", Value=3)]
      FS_ASSIST2 = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"MatchType")]
    public enum MatchType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_NONE", Value=0)]
      MT_NONE = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_PRACTICE", Value=1)]
      MT_PRACTICE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_CAREER", Value=2)]
      MT_CAREER = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_TOUR", Value=3)]
      MT_TOUR = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_REGULAR", Value=4)]
      MT_REGULAR = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_QUALIFYING", Value=5)]
      MT_QUALIFYING = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_1V1", Value=7)]
      MT_1V1 = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_1V1_PLUS", Value=8)]
      MT_1V1_PLUS = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_3V3", Value=9)]
      MT_3V3 = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_PVP_1V1", Value=10)]
      MT_PVP_1V1 = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_PVP_1V1_PLUS", Value=11)]
      MT_PVP_1V1_PLUS = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_PVP_3V3", Value=12)]
      MT_PVP_3V3 = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_REGULAR_RACE", Value=13)]
      MT_REGULAR_RACE = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_QUALIFYING_NEW", Value=14)]
      MT_QUALIFYING_NEW = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_QUALIFYING_NEWER", Value=15)]
      MT_QUALIFYING_NEWER = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_BULLFIGHT", Value=20)]
      MT_BULLFIGHT = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_SHOOT", Value=21)]
      MT_SHOOT = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MT_PRACTICE_1V1", Value=22)]
      MT_PRACTICE_1V1 = 22
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"GameMode")]
    public enum GameMode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_None", Value=0)]
      GM_None = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_Practise", Value=1)]
      GM_Practise = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_Ready", Value=2)]
      GM_Ready = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_1On1", Value=3)]
      GM_1On1 = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_3On3", Value=4)]
      GM_3On3 = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_Career1On1", Value=5)]
      GM_Career1On1 = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_Career3On3", Value=6)]
      GM_Career3On3 = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_AsynPVP3On3", Value=7)]
      GM_AsynPVP3On3 = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_Practice1On1", Value=8)]
      GM_Practice1On1 = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_PVP", Value=10)]
      GM_PVP = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_PVP_1V1_PLUS", Value=11)]
      GM_PVP_1V1_PLUS = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_PVP_3V3", Value=12)]
      GM_PVP_3V3 = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_PVP_REGULAR", Value=13)]
      GM_PVP_REGULAR = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_QUALIFYING", Value=14)]
      GM_QUALIFYING = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_QUALIFYING_NEWER", Value=15)]
      GM_QUALIFYING_NEWER = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_ReboundStorm", Value=100)]
      GM_ReboundStorm = 100,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_BlockStorm", Value=101)]
      GM_BlockStorm = 101,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_Ultimate21", Value=102)]
      GM_Ultimate21 = 102,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_MassBall", Value=103)]
      GM_MassBall = 103,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_GrabZone", Value=104)]
      GM_GrabZone = 104,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_GrabPoint", Value=105)]
      GM_GrabPoint = 105,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GM_BullFight", Value=106)]
      GM_BullFight = 106
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ExitMatchType")]
    public enum ExitMatchType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_END", Value=1)]
      EMT_END = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_OPTION", Value=2)]
      EMT_OPTION = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_OFFLINE", Value=3)]
      EMT_OFFLINE = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_OFFLINE_END", Value=4)]
      EMT_OFFLINE_END = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_OTHER", Value=5)]
      EMT_OTHER = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_BLANK", Value=6)]
      EMT_BLANK = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_CHEAT", Value=7)]
      EMT_CHEAT = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_OFFLINE_WIN", Value=8)]
      EMT_OFFLINE_WIN = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_OFFLINE_LOSE", Value=9)]
      EMT_OFFLINE_LOSE = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"EMT_END_WIN", Value=10)]
      EMT_END_WIN = 10
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"CharacterState")]
    public enum CharacterState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"eNone", Value=0)]
      eNone = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eStand", Value=8)]
      eStand = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eHold", Value=9)]
      eHold = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRun", Value=10)]
      eRun = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eCrossOver", Value=11)]
      eCrossOver = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eSwitchBall", Value=12)]
      eSwitchBall = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRush", Value=13)]
      eRush = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRushTurning", Value=14)]
      eRushTurning = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eKnocked", Value=20)]
      eKnocked = 20,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eFallLostBall", Value=21)]
      eFallLostBall = 21,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eFallGround", Value=22)]
      eFallGround = 22,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ePickup", Value=23)]
      ePickup = 23,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eCatch", Value=24)]
      eCatch = 24,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eIdlePose", Value=25)]
      eIdlePose = 25,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eStolen", Value=26)]
      eStolen = 26,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eDefenseCross", Value=27)]
      eDefenseCross = 27,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eCrossed", Value=28)]
      eCrossed = 28,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eDisturb", Value=29)]
      eDisturb = 29,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRequireBall", Value=30)]
      eRequireBall = 30,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eRebound", Value=31)]
      eRebound = 31,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ePass", Value=32)]
      ePass = 32,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eLayup", Value=33)]
      eLayup = 33,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ePrepareToShoot", Value=34)]
      ePrepareToShoot = 34,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eShoot", Value=35)]
      eShoot = 35,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eDunk", Value=36)]
      eDunk = 36,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eGoalPose", Value=37)]
      eGoalPose = 37,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eDefense", Value=38)]
      eDefense = 38,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eSteal", Value=39)]
      eSteal = 39,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBlock", Value=40)]
      eBlock = 40,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eMoveStep", Value=41)]
      eMoveStep = 41,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eResultPose", Value=42)]
      eResultPose = 42,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ePickAndRoll", Value=43)]
      ePickAndRoll = 43,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBePickAndRoll", Value=44)]
      eBePickAndRoll = 44,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBodyThrowCatch", Value=45)]
      eBodyThrowCatch = 45,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eCutIn", Value=46)]
      eCutIn = 46,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eInterception", Value=47)]
      eInterception = 47,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eInput", Value=48)]
      eInput = 48,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eLayupFailed", Value=49)]
      eLayupFailed = 49,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBackToBack", Value=50)]
      eBackToBack = 50,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBackCompete", Value=51)]
      eBackCompete = 51,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBackBlock", Value=52)]
      eBackBlock = 52,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBackToStand", Value=53)]
      eBackToStand = 53,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBackTurnRun", Value=54)]
      eBackTurnRun = 54,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eBackToBackForward", Value=55)]
      eBackToBackForward = 55,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eMax", Value=60)]
      eMax = 60
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"AnimType")]
    public enum AnimType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_1", Value=1)]
      B_TYPE_1 = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_2", Value=2)]
      B_TYPE_2 = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_3", Value=3)]
      B_TYPE_3 = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_4", Value=4)]
      B_TYPE_4 = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_5", Value=5)]
      B_TYPE_5 = 5,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_6", Value=6)]
      B_TYPE_6 = 6,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_7", Value=7)]
      B_TYPE_7 = 7,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_8", Value=8)]
      B_TYPE_8 = 8,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_9", Value=9)]
      B_TYPE_9 = 9,
            
      [global::ProtoBuf.ProtoEnum(Name=@"B_TYPE_0", Value=10)]
      B_TYPE_0 = 10,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_1", Value=11)]
      N_TYPE_1 = 11,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_2", Value=12)]
      N_TYPE_2 = 12,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_3", Value=13)]
      N_TYPE_3 = 13,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_4", Value=14)]
      N_TYPE_4 = 14,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_5", Value=15)]
      N_TYPE_5 = 15,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_6", Value=16)]
      N_TYPE_6 = 16,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_7", Value=17)]
      N_TYPE_7 = 17,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_8", Value=18)]
      N_TYPE_8 = 18,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_9", Value=19)]
      N_TYPE_9 = 19,
            
      [global::ProtoBuf.ProtoEnum(Name=@"N_TYPE_0", Value=20)]
      N_TYPE_0 = 20
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"Area")]
    public enum Area
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"eInvalid", Value=0)]
      eInvalid = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eFar", Value=1)]
      eFar = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eMiddle", Value=2)]
      eMiddle = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eNear", Value=3)]
      eNear = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"eSpecial", Value=4)]
      eSpecial = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"BallState")]
    public enum BallState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"none", Value=0)]
      none = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"useBall", Value=1)]
      useBall = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"loseBall", Value=2)]
      loseBall = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"rebound", Value=3)]
      rebound = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"useBall_Shoot", Value=4)]
      useBall_Shoot = 4,
            
      [global::ProtoBuf.ProtoEnum(Name=@"useBall_Pass", Value=5)]
      useBall_Pass = 5
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"CharacterType")]
    public enum CharacterType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ROBOT", Value=1)]
      ROBOT = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PLAYER", Value=2)]
      PLAYER = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"TeamType")]
    public enum TeamType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"TT_HOME", Value=0)]
      TT_HOME = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"TT_AWAY", Value=1)]
      TT_AWAY = 1
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"GameResult")]
    public enum GameResult
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"GR_WIN", Value=1)]
      GR_WIN = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GR_FAILURE", Value=2)]
      GR_FAILURE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"GR_DRAW", Value=3)]
      GR_DRAW = 3
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SignType")]
    public enum SignType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"ST_NORMAL", Value=1)]
      ST_NORMAL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"ST_APPEND", Value=2)]
      ST_APPEND = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SignState")]
    public enum SignState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SS_NORMAL", Value=1)]
      SS_NORMAL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SS_VIP", Value=2)]
      SS_VIP = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"SignAwardType")]
    public enum SignAwardType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SAT_DAY", Value=1)]
      SAT_DAY = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SAT_VIP", Value=2)]
      SAT_VIP = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ServerState")]
    public enum ServerState
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SS_CLOSE", Value=1)]
      SS_CLOSE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SS_IDLE", Value=2)]
      SS_IDLE = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SS_BUSY", Value=3)]
      SS_BUSY = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SS_FULL", Value=4)]
      SS_FULL = 4
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"NewComerTrialAwardsType")]
    public enum NewComerTrialAwardsType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"NCTAT_NORMAL", Value=1)]
      NCTAT_NORMAL = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"NCTAT_TOTAL", Value=2)]
      NCTAT_TOTAL = 2
    }
  
    [global::ProtoBuf.ProtoContract(Name=@"ShootDiamondTurnCardType")]
    public enum ShootDiamondTurnCardType
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDTCT_EXPENSIVE", Value=1)]
      SDTCT_EXPENSIVE = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDTCT_MEDIUM", Value=2)]
      SDTCT_MEDIUM = 2,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDTCT_CHEAP", Value=3)]
      SDTCT_CHEAP = 3,
            
      [global::ProtoBuf.ProtoEnum(Name=@"SDTCT_NONE", Value=4)]
      SDTCT_NONE = 4
    }
  
}