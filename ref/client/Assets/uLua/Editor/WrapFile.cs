﻿using UnityEngine;
using UnityEditor;
using UnityEngine.Rendering;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using System.Runtime.InteropServices;
using System.Reflection;
using fogs.proto.msg;
using fogs.proto.config;

public static class WrapFile
{
    //自定义生成wrap列表
    public static BindType[] CustomBinds = new BindType[]
    {
		_GT(typeof(ParticleSystemRenderer)),
	};
    public static BindType[] binds = new BindType[]
    {
        //System
        _GT(typeof(object)),
        _GT(typeof(System.String)),
        _GT(typeof(System.Enum)),
        _GT(typeof(System.Delegate)),
        _GT(typeof(IEnumerator)),
        _GT(typeof(System.Delegate)),
        _GT(typeof(Type)).SetBaseName("System.Object"),
        

        //UnityEngine
        _GT(typeof(UnityEngine.Animator)),
        _GT(typeof(UnityEngine.Experimental.Director.DirectorPlayer)),
        _GT(typeof(UnityEngine.AnimatorStateInfo)),
        _GT(typeof(UnityEngine.GameObject)),
        _GT(typeof(UnityEngine.MeshFilter)),
        _GT(typeof(UnityEngine.Object)),
        _GT(typeof(UnityEngine.TextAsset)),
        _GT(typeof(UnityEngine.Texture2D)),
        _GT(typeof(UnityEngine.Transform)),
        _GT(typeof(Animation)),
        _GT(typeof(AnimationBlendMode)),
        _GT(typeof(AnimationClip)),
        _GT(typeof(AnimationState)),
        _GT(typeof(Application)),
        _GT(typeof(AssetBundle)),
        _GT(typeof(AsyncOperation)),
        _GT(typeof(AudioListener)),
        _GT(typeof(AudioClip)),
        _GT(typeof(AudioSource)),
        _GT(typeof(Behaviour)),
        _GT(typeof(BlendWeights)),
        _GT(typeof(BoxCollider)),
        _GT(typeof(Camera)),
        _GT(typeof(CameraClearFlags)),
        _GT(typeof(CharacterController)),
        _GT(typeof(Collider)),
        _GT(typeof(Component)),
        _GT(typeof(Input)),
        _GT(typeof(KeyCode)),
        _GT(typeof(LayerMask)),
        _GT(typeof(Light)),
        _GT(typeof(LightType)),
        _GT(typeof(Material)),
        _GT(typeof(Mesh)),
        _GT(typeof(MeshCollider)),
        _GT(typeof(MeshRenderer)),
        _GT(typeof(MonoBehaviour)),
        _GT(typeof(Motion)),
        _GT(typeof(ParticleAnimator)),
        _GT(typeof(ParticleEmitter)),
        _GT(typeof(ParticleRenderer)),
        _GT(typeof(ParticleSystem)),
        _GT(typeof(ParticleSystemRenderer)),
        _GT(typeof(Physics)),
        _GT(typeof(PlayMode)),
        _GT(typeof(PlaySoundManager)),
        _GT(typeof(Profiler)),
        _GT(typeof(QualitySettings)),
        _GT(typeof(QueueMode)),
        _GT(typeof(Resources)),
        _GT(typeof(Renderer)),
        _GT(typeof(RenderSettings)),
        _GT(typeof(RenderTexture)),
        _GT(typeof(Screen)),
        _GT(typeof(Shader)),
        _GT(typeof(SkinnedMeshRenderer)),
        _GT(typeof(SleepTimeout)),
        _GT(typeof(Space)),
        _GT(typeof(SphereCollider)),
        _GT(typeof(Texture)),
        _GT(typeof(Time)).SetWrapName("UnityTime").SetLibName("UnityTime"),
        _GT(typeof(TouchPhase)),
        _GT(typeof(TrackedReference)),
        _GT(typeof(YieldInstruction)),
        _GT(typeof(PlayerPrefs)),
        
        //NGUI
        _GT(typeof(EventDelegate)),
        _GT(typeof(Localization)),
        _GT(typeof(NGUIText)),
        _GT(typeof(NGUIText.Alignment)),
        _GT(typeof(NGUITools)),
        _GT(typeof(TweenPosition)),
        _GT(typeof(TweenRotation)),
        _GT(typeof(TweenScale)),
        _GT(typeof(TweenWidth)),
        _GT(typeof(UIAtlas)),
        _GT(typeof(UIBasicSprite)),
        _GT(typeof(UIButton)),
        _GT(typeof(UIButtonColor)),
        _GT(typeof(UICamera)),
        _GT(typeof(UICenterOnChild)),
        _GT(typeof(UIChallengeLoading)),
        _GT(typeof(UIDragDropItem)),
        _GT(typeof(UIDragDropItemEvent)),
        _GT(typeof(UIDragScrollView)),
        _GT(typeof(UIEventListener)),
        _GT(typeof(UIGrid)),
        _GT(typeof(UIGrid.Arrangement)),
        _GT(typeof(UIInput)),
        _GT(typeof(UILabel)),
        _GT(typeof(UIPanel)),
        _GT(typeof(UIProgressBar)),
        _GT(typeof(UIRect)),
        _GT(typeof(UIRect.AnchorPoint)),
        _GT(typeof(UIScrollView)),
        _GT(typeof(UIScrollBar)),
        _GT(typeof(UISlider)),
        _GT(typeof(UISprite)),
        _GT(typeof(UISprite.Flip)),
        _GT(typeof(UITable)),
        _GT(typeof(UITexture)),
        _GT(typeof(UIToggle)),
        _GT(typeof(UITweener)),
        _GT(typeof(UITweener.Method)),
        _GT(typeof(UIViewport)),
        _GT(typeof(UIWidget)),
        _GT(typeof(UIWidget.Pivot)),
        _GT(typeof(UIWidgetContainer)),
        _GT(typeof(UIWrapContent)),
        _GT(typeof(SpringPanel)),


        //fogs.proto.msg
        _GT(typeof(fogs.proto.msg.ActivityInfo)),
        _GT(typeof(fogs.proto.msg.BadgeSlotStatus)),
        _GT(typeof(fogs.proto.msg.BadgeBook)),
        _GT(typeof(fogs.proto.msg.BadgeSlot)),
        _GT(typeof(fogs.proto.msg.BadgeCG)),
        _GT(typeof(fogs.proto.msg.BullFight)),
        _GT(typeof(fogs.proto.msg.ChatBroadcast)).SetWrapName("ChatBroadcast").SetLibName("ChatBroadcast"),
        _GT(typeof(fogs.proto.msg.ChatChannelType)).SetLibName("fogs.proto.msg.ChatChannelType"),
        _GT(typeof(fogs.proto.msg.ChatContent)).SetWrapName("ChatContent").SetLibName("ChatContent"),
        _GT(typeof(fogs.proto.msg.EnhanceLevelResp)),
        _GT(typeof(fogs.proto.msg.EnhanceExerciseResp)),
        _GT(typeof(fogs.proto.msg.EquipmentType)).SetLibName("fogs.proto.msg.EquipmentType"),
        _GT(typeof(fogs.proto.msg.EquipmentOperationType)).SetLibName("fogs.proto.msg.EquipmentOperationType"),
        _GT(typeof(fogs.proto.msg.EquipmentSlotID)).SetLibName("fogs.proto.msg.EquipmentSlotID"),
        _GT(typeof(fogs.proto.msg.EquipInfo)).SetWrapName("EquipInfo").SetLibName("EquipInfo"),
        _GT(typeof(fogs.proto.msg.EquipmentSlot)).SetWrapName("EquipmentSlot").SetLibName("EquipmentSlot"),
        _GT(typeof(fogs.proto.msg.ErrorID)).SetLibName("fogs.proto.msg.ErrorID"),
        _GT(typeof(fogs.proto.msg.ExerciseInfo)).SetWrapName("ExerciseInfo").SetLibName("ExerciseInfo"),
        _GT(typeof(fogs.proto.msg.FashionOperationType)).SetLibName("fogs.proto.msg.FashionOperationType"),
        _GT(typeof(fogs.proto.msg.FashionSlotProto)).SetWrapName("FashionSlotProto").SetLibName("FashionSlotProto"),
        _GT(typeof(fogs.proto.msg.FightRoleInfo)),
        _GT(typeof(fogs.proto.msg.FightRole)),
        _GT(typeof(fogs.proto.msg.FightStatus)),
        _GT(typeof(fogs.proto.msg.FriendOperationType)).SetLibName("fogs.proto.msg.FriendOperationType"),
        _GT(typeof(fogs.proto.msg.FriendInfo)).SetLibName("fogs.proto.msg.FriendInfo"),
        _GT(typeof(fogs.proto.msg.GameMode)).SetLibName("fogs.proto.msg.GameMode"),
        _GT(typeof(fogs.proto.msg.GameModeInfo)).SetLibName("fogs.proto.msg.GameModeInfo"),
        _GT(typeof(fogs.proto.msg.GenderType)).SetLibName("fogs.proto.msg.GenderType"),
        _GT(typeof(fogs.proto.msg.GoodsCategory)).SetLibName("fogs.proto.msg.GoodsCategory"),
        _GT(typeof(fogs.proto.msg.GoodsProto)),
        _GT(typeof(fogs.proto.msg.GoodsQuality)).SetLibName("fogs.proto.msg.GoodsQuality"),
        _GT(typeof(fogs.proto.msg.InviteRoleResp)),
        _GT(typeof(fogs.proto.msg.ImproveQualityResp)),
        _GT(typeof(fogs.proto.msg.KeyValueData)).SetWrapName("KeyValueData").SetLibName("KeyValueData"),
        _GT(typeof(fogs.proto.msg.LotteryInfo)),
        _GT(typeof(fogs.proto.msg.PvpLadderInfo)),
        _GT(typeof(fogs.proto.msg.PvpRegularInfo)).SetLibName("PvpRegularInfo").SetWrapName("PvpRegularInfo"),
        _GT(typeof(fogs.proto.msg.MailInfo)),
        _GT(typeof(fogs.proto.msg.MatchType)),
        _GT(typeof(fogs.proto.msg.NewComerInfo)),
        _GT(typeof(fogs.proto.msg.NewComerTrialInfo)).SetWrapName("NewComerTrialInfo").SetLibName("NewComerTrialInfo"),
        _GT(typeof(fogs.proto.msg.PlayerData)),
        _GT(typeof(fogs.proto.msg.PositionType)).SetLibName("fogs.proto.msg.PositionType"),
        _GT(typeof(fogs.proto.msg.PvpPlusInfo)),
        _GT(typeof(fogs.proto.msg.QualifyingInfo)),
        _GT(typeof(fogs.proto.msg.QualifyingNewInfo)),
        _GT(typeof(fogs.proto.msg.QualifyingNewerInfo)),
        _GT(typeof(fogs.proto.msg.RankType)).SetLibName("fogs.proto.msg.RankType").SetWrapName("RankType"),
        _GT(typeof(fogs.proto.msg.RankSubType)).SetLibName("fogs.proto.msg.RankSubType").SetWrapName("RankSubType"),
        _GT(typeof(fogs.proto.msg.ResetRoleResp)),
        _GT(typeof(fogs.proto.msg.RoleInfo)).SetLibName("fogs.proto.msg.RoleInfo"),
        _GT(typeof(fogs.proto.msg.ShootInfo)),
        _GT(typeof(fogs.proto.msg.SignInfo)),
        _GT(typeof(fogs.proto.msg.SkillSlotProto)).SetWrapName("SkillSlotPro").SetLibName("SkillSlotProto"),
        _GT(typeof(fogs.proto.msg.StoreType)).SetLibName("fogs.proto.msg.StoreType"),
        _GT(typeof(fogs.proto.msg.TaskData)),
        _GT(typeof(fogs.proto.msg.TaskInfo)),
        _GT(typeof(fogs.proto.msg.TaskType)).SetLibName("fogs.proto.msg.TaskType"),
        _GT(typeof(fogs.proto.msg.TattooType)).SetLibName("fogs.proto.msg.TattooType"),
        _GT(typeof(fogs.proto.msg.TeamType)),
        _GT(typeof(fogs.proto.msg.TourInfo)),
        _GT(typeof(fogs.proto.msg.TrainingInfo)).SetLibName("fogs.proto.msg.TrainingInfo"),
        _GT(typeof(fogs.proto.msg.TrainingState)).SetLibName("fogs.proto.msg.TrainingState"),
        _GT(typeof(fogs.proto.msg.vipOperType)).SetLibName("fogs.proto.msg.vipOperType"),
       
        
        //fogs.proto.config
        _GT(typeof(fogs.proto.config.AwardConfig)),
        _GT(typeof(fogs.proto.config.AwardPackConfig)),
        _GT(typeof(fogs.proto.config.ChapterConfig)),
        _GT(typeof(fogs.proto.config.DataConstruction)),
        _GT(typeof(fogs.proto.config.GenerateNewGoodsArgConfig)).SetLibName("fogs.proto.msg.GenerateNewGoodsArgConfig"),
        _GT(typeof(fogs.proto.config.GoodsAttrConfig)),
        _GT(typeof(fogs.proto.config.GoodsCompositeConfig)),
        _GT(typeof(fogs.proto.config.GoodsUseConfig)),
        _GT(typeof(fogs.proto.config.LotteryConfig)),
        _GT(typeof(fogs.proto.config.NPCConfig)),
        _GT(typeof(fogs.proto.config.QualifyingNewConfig)),
        _GT(typeof(fogs.proto.config.QualifyingNewSeasonConfig)),
        _GT(typeof(fogs.proto.config.QualifyingNewerConfig)),
        _GT(typeof(fogs.proto.config.QualifyingNewerSeasonConfig)),
        _GT(typeof(fogs.proto.config.QualifyingNewerLeagueAwardsConfig)),
        _GT(typeof(fogs.proto.config.RankConfig)),
        _GT(typeof(fogs.proto.config.SectionConfig)),
        _GT(typeof(fogs.proto.config.StoreRefreshConsumeConfig)),
        _GT(typeof(fogs.proto.config.TaskConfig)),


        //Config
        _GT(typeof(BadgeAttrConfig)),
        _GT(typeof(BadgeAttrBaseConfig)),
        _GT(typeof(ActivityConfig)),
        _GT(typeof(AnnouncementConfig)),
        _GT(typeof(AttrNameConfig)),
        _GT(typeof(AwardPackDataConfig)),
        _GT(typeof(AIConfig)),
        _GT(typeof(BadgeSlotBaseConfig)),
        _GT(typeof(BadgeSlotConfig)),
        _GT(typeof(BaseDataBuyConfig)),
        _GT(typeof(BaseDataConfig2)),
        _GT(typeof(BullFightConfig)),
        _GT(typeof(CareerConfig)),
        _GT(typeof(CommonConfig)),
        _GT(typeof(EquipmentBaseDataConfig)),
        _GT(typeof(EquipmentConfig)),
        _GT(typeof(FashionConfig)),
        _GT(typeof(FashionShopConfig)),
        _GT(typeof(FunctionConditionConfig)),
        _GT(typeof(GameModeConfig)),
        _GT(typeof(GoodsConfig)),
        _GT(typeof(GoodsComposeBaseNewConfig)),
        _GT(typeof(GoodsComposeNewConfig)),
        _GT(typeof(LadderConfig)),
        _GT(typeof(LadderLevel)),
        _GT(typeof(LadderSeason)),
        _GT(typeof(LadderReward)),
        _GT(typeof(LotteryConfig)),
        _GT(typeof(MapConfig)),
        _GT(typeof(NewComerSignConfig)),
        _GT(typeof(NPCDataConfig)),
        _GT(typeof(PractiseConfig)),
        _GT(typeof(PracticePveConfig)),
        _GT(typeof(PresentHpConfig)),
        _GT(typeof(QualityAttrCorConfig)),
        _GT(typeof(QualifyingConfig)),
        _GT(typeof(QualifyingNewConfig)),
        _GT(typeof(QualifyingNewerConfig)),
        _GT(typeof(RoleGiftConfig)),
        _GT(typeof(RoleLevelConfig)),
        _GT(typeof(RoleShapeConfig)),
        _GT(typeof(RankConfig)),
        _GT(typeof(SignConfig)),
        _GT(typeof(SkillConfig)),
        _GT(typeof(SkillUpConfig)),
        _GT(typeof(StarAttrConfig)),
        _GT(typeof(StoreGoodsConfig)),
        _GT(typeof(ShootGameConfig)),
        _GT(typeof(TaskDataConfig)),
        _GT(typeof(TeamLevelConfig)),
        _GT(typeof(TourConfig)),
        _GT(typeof(TalentConfig)),
        _GT(typeof(TrialConfig)),
        _GT(typeof(VipPrivilegeConfig)),
       

        //custom
        _GT(typeof(ActivityData)),
        _GT(typeof(AnimationResp)),
        _GT(typeof(AnnouncementItem)),
        _GT(typeof(AttrData)),
        _GT(typeof(AttrNameData)),
        _GT(typeof(AttributeType)),
        _GT(typeof(AsyncItem)),
        _GT(typeof(BadgeSystemInfo)),
        _GT(typeof(Blockable)),
        _GT(typeof(BullFightLevel)),
        _GT(typeof(BuyData)),
        _GT(typeof(Chapter)),
        _GT(typeof(Client)),
        _GT(typeof(ConditionType)),
        _GT(typeof(ConditionValidator)),
        _GT(typeof(CommonFunction)),
        _GT(typeof(DataById)),
        _GT(typeof(DaySignData)),
        _GT(typeof(DBG_0)),
        _GT(typeof(DBG_1)),
        _GT(typeof(Debugger)),
        _GT(typeof(DynamicStringManager)),
        _GT(typeof(FashionAttr)),
        _GT(typeof(FashionData)),
        _GT(typeof(FashionShopConfigItem)),
        _GT(typeof(FuncCondition)),
        _GT(typeof(FriendData)),
        _GT(typeof(GameMode)),
        _GT(typeof(GameObjectPlaceholder)),
        _GT(typeof(GameScene)),
        _GT(typeof(GameSystem)),
        _GT(typeof(AudioManager)),
        _GT(typeof(PlaySoundManager)),
		_GT(typeof(Scheduler)),
        _GT(typeof(GameUtils)),
        _GT(typeof(GlobalConst)),
        _GT(typeof(Goods)),
        _GT(typeof(GuideModule)),
        _GT(typeof(GuideSystem)),
        _GT(typeof(GuideTip)),
        _GT(typeof(LoginIDManager)),    
        _GT(typeof(LuaComponent)),
        _GT(typeof(LuaHelper)),
        _GT(typeof(MainPlayer)),
        _GT(typeof(MapGroupData)),
        _GT(typeof(ModelShowItem)),
        _GT(typeof(MonthSignData)),
        _GT(typeof(MultiLabel)),
        _GT(typeof(NetworkConn)),
        _GT(typeof(NetworkManager)),
        _GT(typeof(NetworkProfiler)),
        _GT(typeof(NewComerSignData)),
        _GT(typeof(NewComerTotalData)),
        _GT(typeof(PlatNetwork)),    
        _GT(typeof(Player)),
        _GT(typeof(PlayerDataBridge)),
        _GT(typeof(PlayerInfoVisualizer)),
        _GT(typeof(PlayerModel)),
        _GT(typeof(PractiseData)),
        _GT(typeof(PracticePveData)),
        _GT(typeof(PractiseData.Type)),
        _GT(typeof(ParticleSystemRenderer)),
        _GT(typeof(QualifyingAwardsData)),
        _GT(typeof(Recharge)),
        _GT(typeof(ResourceLoadManager)),
        _GT(typeof(RoleBaseData2)),
        _GT(typeof(RoleShape)),
        _GT(typeof(ScrollViewIncLoad)),
        _GT(typeof(ScrollViewAsyncLoadItem)),
        _GT(typeof(Section)),
        _GT(typeof(ShootGame)),
        _GT(typeof(SkillAttr)),
        _GT(typeof(SkillConsumable)),
        _GT(typeof(SkillLevel)),
        _GT(typeof(SkillType)).SetLibName("SkillType"),
        _GT(typeof(StarAttr)),
        _GT(typeof(StoreGoodsData)),
        _GT(typeof(StrengthBar)),
        _GT(typeof(SuitAddnAttrData)),
        _GT(typeof(TeamLevelData)),
        _GT(typeof(TextLabelReplace)),     
        _GT(typeof(TourData)),
        _GT(typeof(TrialData)),
        _GT(typeof(TalentItem)),
        _GT(typeof(UBasket)),
        _GT(typeof(UBasketball)),
        _GT(typeof(UIStoreFashion)),
        _GT(typeof(UIManager)),
        _GT(typeof(Util)),
        _GT(typeof(UIForm.ShowHideDirection)),
        _GT(typeof(VipData)),
        _GT(typeof(VipState)),
        _GT(typeof(WidgetPlaceholder)),
      

        //match
        _GT(typeof(IM.Number)),
        _GT(typeof(IM.Vector3)),
		_GT(typeof(PlayerStateMachine.Listener)),
        _GT(typeof(GameMatch)),		
        _GT(typeof(GameMatch_Practice1V1)),
		_GT(typeof(GameMatch_MultiPlayer)),
		_GT(typeof(GameMatch_AsynPVP3ON3)),
        _GT(typeof(GameMatch.Config)),
        _GT(typeof(GameMatch.LeagueType)),
        _GT(typeof(GameMatch.Type)),
        _GT(typeof(GameMatch_1ON1)),
        _GT(typeof(MatchState)),
        _GT(typeof(MatchStateBegin)),
        _GT(typeof(MatchStateFoul)),
        _GT(typeof(MatchStateGoal)),
        _GT(typeof(MatchStateMachine)),
        _GT(typeof(MatchStateOpening)),
        _GT(typeof(MatchStateOver)),
        _GT(typeof(MatchStatePlayerCloseUp)),
        _GT(typeof(MatchStatePlaying)),
        _GT(typeof(MatchStatePlot)),
        _GT(typeof(MatchStateShowRule)),
        _GT(typeof(MatchStateTipOff)),
        _GT(typeof(MatchState.State)),
        _GT(typeof(PlayerState)),
        _GT(typeof(PlayerStateMachine)),
        _GT(typeof(PlayerStateMachine.Listener)),
        _GT(typeof(PlayerState.State)),        
        _GT(typeof(PlayerState_Layup)),
		_GT(typeof(PlayerState_LayupFailed)),
        _GT(typeof(PlayerState_Block)),
        _GT(typeof(PlayerState_BodyThrowCatch)),
        _GT(typeof(PlayerState_Crossed)),
        _GT(typeof(PlayerState_CrossOver)),
        _GT(typeof(PlayerState_Defense)),
        _GT(typeof(PlayerState_DefenseCross)),
        _GT(typeof(PlayerState_Dunk)),
        _GT(typeof(PlayerState_GoalPose)),
        _GT(typeof(PlayerState_Hold)),
        _GT(typeof(PlayerState_Pickup)),
        _GT(typeof(PlayerState_PrepareToShoot)),
        _GT(typeof(PlayerState_Rebound)),
        _GT(typeof(PlayerState_ResultPose)),
        _GT(typeof(PlayerState_Run)),
        _GT(typeof(PlayerState_Rush)),
        _GT(typeof(PlayerState_Shoot)),
        _GT(typeof(PlayerState_Stand)),
        _GT(typeof(PlayerState_Steal)),
        _GT(typeof(PlayerState_Stolen)),
        _GT(typeof(PlayerState_Skill)),
        _GT(typeof(PlayerState_FallGround)),
        _GT(typeof(PlayerState_Disturb)),

		_GT(typeof(PlayerState_BackBlock)),
		_GT(typeof(PlayerState_BackCompete)),
		_GT(typeof(PlayerState_BackToBack)),
		_GT(typeof(PlayerState_BackToBackForward)),
		_GT(typeof(PlayerState_BackToStand)),
		_GT(typeof(PlayerState_BackTurnRun)),
        _GT(typeof(PlayerState_Knocked)),
        _GT(typeof(PlayerState_FallLostBall)),

        //Singleton
        _GT(typeof(Singleton<ConditionValidator>)),
        _GT(typeof(Singleton<Debugger>)),
        _GT(typeof(Singleton<GuideSystem>)),
        _GT(typeof(Singleton<MainPlayer>)),
        _GT(typeof(Singleton<PlatNetwork>)),
        _GT(typeof(Singleton<ResourceLoadManager>)),
        _GT(typeof(Singleton<AudioManager>)),
        
        //List
        _GT(typeof(List<int>)).SetWrapName("IntList").SetLibName("IntList"),
        _GT(typeof(List<uint>)).SetWrapName("UintList").SetLibName("UintList"),
        _GT(typeof(List<string>)).SetWrapName("StringList").SetLibName("StringList"),
        
        _GT(typeof(List<fogs.proto.msg.BadgeSlot>)).SetWrapName("BadgeSlotList").SetLibName("BadgeSlotList"),
        _GT(typeof(List<fogs.proto.msg.BadgeBook>)).SetWrapName("BadgeBookList").SetLibName("BadgeBookList"),
        _GT(typeof(List<fogs.proto.msg.ChatBroadcast>)).SetWrapName("ChatBroadcastList").SetLibName("ChatBroadcastList"),
        _GT(typeof(List<fogs.proto.msg.EquipInfo>)).SetWrapName("EquipInfoList").SetLibName("EquipInfoList"),
        _GT(typeof(List<fogs.proto.msg.EquipmentSlot>)).SetWrapName("EquipmentSlotList").SetLibName("EquipmentSlotList"),
        _GT(typeof(List<fogs.proto.msg.ExerciseInfo>)).SetWrapName("ExerciseInfoList").SetLibName("ExerciseInfoList"),
        _GT(typeof(List<fogs.proto.msg.FashionSlotProto>)).SetWrapName("FashionSlotProtoList").SetLibName("FashionSlotProtoList"),
        _GT(typeof(List<fogs.proto.msg.FightRole>)).SetWrapName("FightRoleInfoList").SetLibName("FightRoleInfoList"),
        _GT(typeof(List<fogs.proto.msg.GameModeInfo>)).SetWrapName("GameModeInfoList").SetLibName("GameModeInfoList"),
        _GT(typeof(List<fogs.proto.msg.MailInfo>)).SetWrapName("MailInfoList").SetLibName("MailInfoList"),
        _GT(typeof(List<fogs.proto.msg.RoleInfo>)).SetWrapName("RoleInfoList").SetLibName("RoleInfoList"),
        _GT(typeof(List<fogs.proto.msg.SkillSlotProto>)).SetWrapName("SkillSlotProtoList").SetLibName("SkillSlotProtoList"),
        _GT(typeof(List<fogs.proto.msg.TaskData>)).SetWrapName("TaskDataList").SetLibName("TaskDataList"),

        _GT(typeof(List<fogs.proto.config.AwardConfig>)).SetWrapName("AwardConfigList").SetLibName("AwardConfigList"),
        _GT(typeof(List<fogs.proto.config.GenerateNewGoodsArgConfig>)).SetWrapName("GenerateNewGoodsArgConfigList").SetLibName("GenerateNewGoodsArgConfigList"),
        
        _GT(typeof(List<BaseDataConfig2>)).SetWrapName("BaseDataConfig2List").SetLibName("BaseDataConfig2List"),
        _GT(typeof(List<DataById>)).SetWrapName("DataByIdList").SetLibName("DataByIdList"),
        _GT(typeof(List<EventDelegate>)).SetWrapName("EventDelegateList").SetLibName("EventDelegateList"),
        _GT(typeof(List<FashionShopConfigItem>)).SetWrapName("FashionShopConfigItemList").SetLibName("FashionShopConfigItemList"),
        _GT(typeof(List<Goods>)).SetWrapName("GoodsList").SetLibName("GoodsList"),
        _GT(typeof(List<KeyValueData>)).SetWrapName("KeyValueDataList").SetLibName("KeyValueDataList"),
        _GT(typeof(List<KeyValuePair<uint, bool> >)).SetWrapName("UintBooleanList").SetLibName("UintBooleanList"),
//        _GT(typeof(List<NewComerTrial>)).SetWrapName("NewComerTrialList").SetLibName("NewComerTrialList"),
        _GT(typeof(List<Player>)).SetWrapName("PlayerList").SetLibName("PlayerList"),
        _GT(typeof(List<QualifyingAwardsData>)).SetWrapName("QualifyingAwardsDataList").SetLibName("QualifyingAwardsDataList"),
        _GT(typeof(List<RobotPlayer>)).SetWrapName("RobotPlayerList").SetLibName("RobotPlayerList"),
        _GT(typeof(List<RoleBaseData2>)).SetWrapName("RoleBaseData2List").SetLibName("RoleBaseData2List"),
        _GT(typeof(List<StoreGoodsData>)).SetWrapName("StoreGoodsDataList").SetLibName("StoreGoodsDataList"),
        _GT(typeof(List<SkillConsumable>)).SetWrapName("SkillConsumableList").SetLibName("SkillConsumableList"),
        _GT(typeof(List<TrialData>)).SetWrapName("TrialDataList").SetLibName("TrialDataList"),
       
        //Dictionary & KeyValuePair  
        _GT(typeof(Dictionary<uint,BadgeAttrBaseConfig>)).SetWrapName("BadgeAttrConfigDictionary").SetLibName("BadgeAttrConfigDictionary"),

        _GT(typeof(Dictionary<uint,BadgeSlotBaseConfig>)).SetWrapName("BadgeSlotBaseConfigDictionary").SetLibName("BadgeSlotBaseConfigDictionary"),
        _GT(typeof(KeyValuePair<uint,BadgeSlotBaseConfig>)).SetWrapName("BadgeSlotBaseConfigKeyValuePair").SetLibName("BadgeSlotBaseConfigKeyValuePair"),

        _GT(typeof(Dictionary<uint, uint>)).SetWrapName("UintDictionary").SetLibName("UintDictionary"),
        _GT(typeof(KeyValuePair<uint, uint>)).SetWrapName("UintKeyValuePair").SetLibName("UintKeyValuePair"),

        _GT(typeof(Dictionary<string, uint>)).SetWrapName("StringUintDictionary").SetLibName("StringUintDictionary"),
        _GT(typeof(KeyValuePair<string, uint>)).SetWrapName("StringUintKeyValuePair").SetLibName("StringUintKeyValuePair"),

        _GT(typeof(Dictionary<uint, Dictionary<uint, uint> >)).SetWrapName("UintDictionaryDictionary").SetLibName("UintDictionaryDictionary"),
        _GT(typeof(KeyValuePair<uint, Dictionary<uint, uint> >)).SetWrapName("UintDictionaryKeyValuePair").SetLibName("UintDictionaryKeyValuePair"),

        _GT(typeof(KeyValuePair<uint, bool>)).SetWrapName("UintBooleanKeyValuePair").SetLibName("UintBooleanKeyValuePair"),        

        _GT(typeof(Dictionary<uint, Chapter>)).SetWrapName("ChapterDictionary").SetLibName("ChapterDictionary"),
        _GT(typeof(KeyValuePair<uint, Chapter>)).SetWrapName("ChapterKeyValuePair").SetLibName("ChapterKeyValuePair"),

        _GT(typeof(Dictionary<uint, Section>)).SetWrapName("SectionDictionary").SetLibName("SectionDictionary"),
        _GT(typeof(KeyValuePair<uint, Section>)).SetWrapName("SectionKeyValuePair").SetLibName("SectionKeyValuePair"),

        _GT(typeof(Dictionary<uint, PractiseData>)).SetWrapName("PractiseDataDictionary").SetLibName("PractiseDataDictionary"),
        _GT(typeof(KeyValuePair<uint, PractiseData>)).SetWrapName("PractiseDataKeyValuePair").SetLibName("PractiseDataKeyValuePair"),

        _GT(typeof(Dictionary<uint, NewComerSignData>)).SetWrapName("NewComerSignDataDictionary").SetLibName("NewComerSignDataDictionary"),
        _GT(typeof(KeyValuePair<uint, NewComerSignData>)).SetWrapName("NewComerSignDataKeyValuePair").SetLibName("NewComerSignDataKeyValuePair"),
        
        _GT(typeof(Dictionary<uint, NewComerTotalData>)).SetWrapName("NewComerTotalDataDictionary").SetLibName("NewComerTotalDataDictionary"),
        _GT(typeof(KeyValuePair<uint, NewComerTotalData>)).SetWrapName("NewComerTotalDataKeyValuePair").SetLibName("NewComerTotalDataKeyValuePair"),
        
        _GT(typeof(Dictionary<uint, List<ExerciseInfo> >)).SetWrapName("ExerciseInfoListDictionary").SetLibName("ExerciseInfoListDictionary"),
        _GT(typeof(KeyValuePair<uint, List<ExerciseInfo> >)).SetWrapName("ExerciseInfoKeyValuePair").SetLibName("ExerciseInfoKeyValuePair"),
        
        _GT(typeof(Dictionary<uint, List<StoreGoodsData> >)).SetWrapName("StoreGoodsDataListDictionary").SetLibName("StoreGoodsDataListDictionary"),
        _GT(typeof(KeyValuePair<uint, List<StoreGoodsData> >)).SetWrapName("StoreGoodsDataListKeyValuePair").SetLibName("StoreGoodsDataListKeyValuePair"),

        _GT(typeof(Dictionary<ulong, Goods>)).SetWrapName("GoodsDictionary").SetLibName("GoodsDictionary"),
        _GT(typeof(KeyValuePair<ulong, Goods>)).SetWrapName("GoodsKeyValuePair").SetLibName("GoodsKeyValuePair"),
        
        _GT(typeof(Dictionary<uint, BullFightLevel>)).SetWrapName("BullFightLevelDictionary").SetLibName("BullFightLevelDictionary"),
        _GT(typeof(KeyValuePair<uint, BullFightLevel>)).SetWrapName("BullFightLevelKeyValuePair").SetLibName("BullFightLevelKeyValuePair"),
        
        _GT(typeof(Dictionary<uint, fogs.proto.config.ChapterConfig>)).SetWrapName("ChapterConfigDictionary").SetLibName("ChapterConfigDictionary"),
        _GT(typeof(KeyValuePair<uint, fogs.proto.config.ChapterConfig>)).SetWrapName("ChapterConfigKeyValuePair").SetLibName("ChapterConfigKeyValuePair"),
        
        _GT(typeof(Dictionary<uint, Recharge>)).SetWrapName("RechargeDictionary").SetLibName("RechargeDictionary"),
        _GT(typeof(KeyValuePair<uint, Recharge>)).SetWrapName("RechargeKeyValuePair").SetLibName("RechargeKeyValuePair"),

        _GT(typeof(Dictionary<uint, RoleShape>)).SetWrapName("RoleShapeDictionary").SetLibName("RoleShapeDictionary"),
        _GT(typeof(KeyValuePair<uint, RoleShape>)).SetWrapName("RoleShapeKeyValuePair").SetLibName("RoleShapeKeyValuePair"),        

        _GT(typeof(Dictionary<uint, fogs.proto.config.GoodsAttrConfig>)).SetWrapName("GoodsAttrConfigDictionary").SetLibName("GoodsAttrConfigDictionary"),
		_GT(typeof(KeyValuePair<uint, fogs.proto.config.GoodsAttrConfig>)).SetWrapName("GoodsAttrConfigKeyValuePair").SetLibName("GoodsAttrConfigKeyValuePair"),
		
        _GT(typeof(Dictionary<uint, fogs.proto.config.SectionConfig>)).SetWrapName("SectionConfigDictionary").SetLibName("SectionConfigDictionary"),
        _GT(typeof(Dictionary<fogs.proto.msg.GameMode, List<fogs.proto.msg.FightRole> >)).SetWrapName("FightRoleListDictionary").SetLibName("FightRoleListDictionary"),
        _GT(typeof(Dictionary<fogs.proto.msg.PositionType, uint>)).SetWrapName("PositionTypeUintDictionary").SetLibName("PositionTypeUintDictionary"),
        _GT(typeof(Dictionary<uint, FashionShopConfigItem>)).SetWrapName("FashionShopConfigItemDictionary").SetLibName("FashionShopConfigItemDictionary"),
        _GT(typeof(Dictionary<uint, SkillLevel>)).SetWrapName("SkillLevelDictionary").SetLibName("SkillLevelDictionary"),
		_GT(typeof(Dictionary<uint, RoleBaseData2>)).SetWrapName("RoleBaseDataDictionarry").SetLibName("RoleBaseDataDictionarry"),
		//_GT(typeof(Dictionary<uint, RoleBaseData2>.Enumerator)).SetWrapName("RoleBaseDataEnumerator").SetLibName("RoleBaseDataEnumerator"),
		_GT(typeof(KeyValuePair<uint, RoleBaseData2>)).SetWrapName("RoleBaseDataKeyValuePair").SetLibName("RoleBaseDataKeyValuePair"),
    };

    public static BindType _GT(Type t)
    {
        return new BindType(t);
    }
}