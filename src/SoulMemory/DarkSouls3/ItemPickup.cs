// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2022 Frank van der Stam.
// https://github.com/FrankvdStam/SoulSplitter/blob/main/LICENSE
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, version 3.
//
// This program is distributed in the hope that it will be useful, but
// WITHOUT ANY WARRANTY without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the GNU
// General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <http://www.gnu.org/licenses/>.

using System.Xml.Serialization;

namespace SoulMemory.DarkSouls3
{
    [XmlType(Namespace = "DarkSouls3")]
    public enum ItemPickup : uint
    {
        [Annotation(Name = "[Boss] 冷冽谷的玻尔多的灵魂 50002000")]
        BossSoulOfBorealValleyVordt = 50002000,

        [Annotation(Name = "[Boss] 舞娘的灵魂 50002010")]
        BossSoulOfTheDancer = 50002010,

        [Annotation(Name = "[Boss] 妖王欧斯罗艾斯的灵魂 50002020")]
        BossSoulOfConsumedOceiros = 50002020,

        [Annotation(Name = "[Boss] 猎龙铠甲的灵魂 50002030")]
        BossSoulOfDragonslayerArmour = 50002030,

        [Annotation(Name = "[Boss] 薪王柴薪 50002040")]
        BossCindersOfaLord = 50002040,

        [Annotation(Name = "[Boss] 咒蚀大树的灵魂 50002060")]
        BossSoulOfTheRottedGreatwood = 50002060,

        [Annotation(Name = "[Boss] 龙头石 50002070")]
        BossDragonHeadStone = 50002070,

        [Annotation(Name = "[Boss] 无名王者的灵魂 50002080")]
        BossSoulOfTheNamelessKing = 50002080,

        [Annotation(Name = "[Boss] 结晶老者的灵魂 50002090")]
        BossSoulOfaCrystalSage = 50002090,

        [Annotation(Name = "[Boss] 薪王柴薪 50002100")]
        BossCindersOfaLord_ = 50002100,

        [Annotation(Name = "[Boss] 小人偶 50002110")]
        BossSmallDoll = 50002110,

        [Annotation(Name = "[Boss] 幽邃主教群的灵魂 50002111")]
        BossSoulOfTheDeaconsOfTheDeep = 50002111,

        [Annotation(Name = "[Boss] 教宗沙力万的灵魂 50002120")]
        BossSoulOfPontiffSulyvahn = 50002120,

        [Annotation(Name = "[Boss] 薪王柴薪 50002130")]
        BossCindersOfaLord__ = 50002130,

        [Annotation(Name = "[Boss] 霸王沃尼尔的灵魂 50002140")]
        BossSoulOfHighLordWolnir = 50002140,

        [Annotation(Name = "[Boss] 老恶魔王的灵魂 50002150")]
        BossSoulOfTheOldDemonKing = 50002150,

        [Annotation(Name = "[Boss] 薪王柴薪 50002170")]
        BossCindersOfaLord___ = 50002170,

        [Annotation(Name = "[Boss] 螺旋剑 50002180")]
        BossCoiledSword = 50002180,

        [Annotation(Name = "[Boss] 英雄古达的灵魂 50002190")]
        BossSoulOfChampionGundyr = 50002190,

        [Annotation(Name = "[Boss] 薪王们的灵魂 50002200")]
        BossSoulOfTheLords = 50002200,

        [Annotation(Name = "[Boss] 芙莉德修女的灵魂 50002300")]
        BossSoulOfSisterFriede = 50002300,

        [Annotation(Name = "[Boss] 王者遗骨 50002310")]
        BossChampionsBones = 50002310,

        [Annotation(Name = "[Boss] 果敢心 50002320")]
        BossValorheart = 50002320,

        [Annotation(Name = "[Boss] 恶魔王子的灵魂 50002330")]
        BossSoulOfTheDemonPrince = 50002330,

        [Annotation(Name = "[Boss] 楔形石原盘 50002340")]
        BossTitaniteSlab = 50002340,

        [Annotation(Name = "[Boss] 费莲诺尔枪饰 50002341")]
        BossFilianoresSpearOrnament = 50002341,

        [Annotation(Name = "[Boss] 吞噬黑暗的米狄尔的灵魂 50002350")]
        BossSoulOfDarkeaterMidir = 50002350,

        [Annotation(Name = "[Boss] 教堂之枪 6830")]
        BossSpearsOfTheChurch = 6830,

        [Annotation(Name = "[Boss] 奴隶骑士盖尔的灵魂 50002360")]
        BossSoulOfSlaveKnightGael = 50002360,

        [Annotation(Name = "螺旋剑 50002500")]
        CoiledSword = 50002500,

        [Annotation(Name = "罗莎莉亚的指头 - 誓约徽章 54004010")]
        RosariasFingersEmblem = 54004010,

        [Annotation(Name = "太阳战士 - 誓约徽章 6700")]
        WarriorOfSunlightEmblem = 6700,

        [Annotation(Name = "[誓约] 太阳战士 Rank 2 - 太阳直剑 6702")]
        CovenantWarriorOfSunlightRank2SunlightStraightSword = 6702,

        [Annotation(Name = "[誓约] 太阳战士 Rank 1 - 太阳纹盾 6701")]
        CovenantWarriorOfSunlightRank1SunlightShield = 6701,

        [Annotation(Name = "累积者 - 誓约徽章 6710")]
        MoundmakersEmblem = 6710,

        [Annotation(Name = "[誓约] 累积者 Rank 2 - 温暖的火 6712")]
        CovenantMoundmakersRank2Warmth = 6712,

        [Annotation(Name = "[誓约] 累积者 Rank 1 - 血癫狂 6711")]
        CovenantMoundmakersRank1Bloodlust = 6711,

        [Annotation(Name = "法兰守卫 - 誓约徽章 6720")]
        WatchdogsOfFarronEmblem = 6720,

        [Annotation(Name = "[誓约] 法兰守卫 Rank 2 - 狼骑士大盾 6722")]
        CovenantWatchdogsOfFarronRank2WolfKnightsGreatshield = 6722,

        [Annotation(Name = "[誓约] 法兰守卫 Rank 1 - 老狼曲剑 6721")]
        CovenantWatchdogsOfFarronRank1OldWolfCurvedSword = 6721,

        [Annotation(Name = "吞噬神明的守护人 - 誓约徽章 6730")]
        AldrichFaithfulEmblem = 6730,

        [Annotation(Name = "[誓约] 吞噬神明的守护人 Rank 2 - 大主教的大杖 6732")]
        CovenantAldrichFaithfulRank2ArchdeaconsGreatStaff = 6732,

        [Annotation(Name = "[誓约] 吞噬神明的守护人 Rank 1 - 强力幽邃灵魂 6731")]
        CovenantAldrichFaithfulRank1GreatDeepSoul = 6731,

        [Annotation(Name = "青之守护者 - 誓约徽章 6740")]
        BlueSentinelsEmblem = 6740,

        [Annotation(Name = "火焰壶 6742")]
        Firebomb = 6742,

        [Annotation(Name = "廓尔喀弯刀 6741")]
        Kukri = 6741,

        [Annotation(Name = "暗月之剑 - 誓约徽章 6750")]
        BladeOfTheDarkmoonEmblem = 6750,

        [Annotation(Name = "火焰壶 6752")]
        Firebomb_ = 6752,

        [Annotation(Name = "火焰壶 6751")]
        Firebomb__ = 6751,

        [Annotation(Name = "罗莎莉亚的指头 - 誓约徽章 6760")]
        RosariasFingersEmblem_ = 6760,

        [Annotation(Name = "[誓约] 罗莎莉亚的指头 Rank 2 - 蛆人杖 6762")]
        CovenantRosariasFingersRank2MangrubsStaff = 6762,

        [Annotation(Name = "[誓约] 罗莎莉亚的指头 Rank 1 - 幻肢戒指 6761")]
        CovenantRosariasFingersRank1ObscuringRing = 6761,

        [Annotation(Name = "青教 - 誓约徽章 6770")]
        WayOfBlueEmblem = 6770,

        [Annotation(Name = "火焰壶 6772")]
        Firebomb___ = 6772,

        [Annotation(Name = "火焰壶 6771")]
        Firebomb____ = 6771,

        [Annotation(Name = "圣枪的碎片 6832")]
        DivineSpearFragment = 6832,

        [Annotation(Name = "嫩芽泪滴石 6831")]
        YoungGrassDew = 6831,

        [Annotation(Name = "[鸟巢女孩] 铁臂套 50004300")]
        CrowIronBracelets = 50004300,

        [Annotation(Name = "[鸟巢女孩] 牺牲戒指 50004301")]
        CrowRingOfSacrifice = 50004301,

        [Annotation(Name = "[鸟巢女孩] 隶兽盾 50004302")]
        CrowPorcineShield = 50004302,

        [Annotation(Name = "[鸟巢女孩] 鲁卡提耶面具 50004303")]
        CrowLucatielsMask = 50004303,

        [Annotation(Name = "[鸟巢女孩] 人脸“不错啊！” 50004304")]
        CrowVerygoodCarving = 50004304,

        [Annotation(Name = "[鸟巢女孩] 人脸“谢谢你” 50004305")]
        CrowThankyouCarving = 50004305,

        [Annotation(Name = "[鸟巢女孩] 人脸“很抱歉” 50004306")]
        CrowImsorryCarving = 50004306,

        [Annotation(Name = "[鸟巢女孩] 太阳纹盾 50004307")]
        CrowSunlightShield = 50004307,

        [Annotation(Name = "[鸟巢女孩] 游魂宝石 50004308")]
        CrowHollowGem = 50004308,

        [Annotation(Name = "[鸟巢女孩] 龙鳞楔形石 50004309")]
        CrowTitaniteScale = 50004309,

        [Annotation(Name = "[鸟巢女孩] 人脸“救命啊！” 50004310")]
        CrowHelpmeCarving = 50004310,

        [Annotation(Name = "[鸟巢女孩] 楔形石原盘 50004311")]
        CrowTitaniteSlab = 50004311,

        [Annotation(Name = "[鸟巢女孩] 人脸“你好啊” 50004320")]
        CrowHelloCarving = 50004320,

        [Annotation(Name = "[鸟巢女孩] 太阳纹铠甲 50004321")]
        CrowArmorOfTheSun = 50004321,

        [Annotation(Name = "[鸟巢女孩] 楔形石大碎片 50004322")]
        CrowLargeTitaniteShard = 50004322,

        [Annotation(Name = "[鸟巢女孩] 楔形石块 50004323")]
        CrowTitaniteChunk = 50004323,

        [Annotation(Name = "[鸟巢女孩] 铁头盔 50004324")]
        CrowIronHelm = 50004324,

        [Annotation(Name = "[鸟巢女孩] 光辉楔形石 50004325")]
        CrowTwinklingTitanite = 50004325,

        [Annotation(Name = "[鸟巢女孩] 铁腿甲 50004326")]
        CrowIronLeggings = 50004326,

        [Annotation(Name = "[鸟巢女孩] 雷电宝石 50004327")]
        CrowLightningGem = 50004327,

        [Annotation(Name = "[鸟巢女孩] 光辉楔形石 50004328")]
        CrowTwinklingTitanite_ = 50004328,

        [Annotation(Name = "[鸟巢女孩] 祝福宝石 50004329")]
        CrowBlessedGem = 50004329,

        [Annotation(Name = "[鸟巢女孩] 龙鳞楔形石 50004330")]
        CrowTitaniteScale_ = 50004330,

        [Annotation(Name = "楔形石原盘 50004700")]
        TitaniteSlab = 50004700,

        [Annotation(Name = "[库尔兰的鲁道斯] 头盖骨戒指 50006031")]
        LudlethOfCourlandSkullRing = 50006031,

        [Annotation(Name = "[隆道尔的尤莉雅] 暗胧 50006041")]
        YuriaOfLondorDarkdrift = 50006041,

        [Annotation(Name = "[隆道尔的尤莉雅] 尤莉雅的骨灰 50006043")]
        YuriaOfLondorYuriasAshes = 50006043,

        [Annotation(Name = "[骑士团团长幽儿希卡] 幽儿希卡圣铃 50006060")]
        CompanyCaptainYorshkaYorshkasChime = 50006060,

        [Annotation(Name = "[脱逃者霍克伍德] 厚重宝石 50006070")]
        HawkwoodTheDeserterHeavyGem = 50006070,

        [Annotation(Name = "[薄暮之国的希里丝] 薄暮护符 50006082")]
        SirrisOfTheSunlessRealmsSunlessTalisman = 50006082,

        [Annotation(Name = "[无名指的李奥纳德] 龟裂血红眼眸宝珠 50006090")]
        RingfingerLeonhardCrackedRedEyeOrb = 50006090,

        [Annotation(Name = "[无名指的李奥纳德] 银面具 50006093")]
        RingfingerLeonhardSilverMask = 50006093,

        [Annotation(Name = "[无名指的李奥纳德] 升降机房间的钥匙 50006091")]
        RingfingerLeonhardLiftChamberKey = 50006091,

        [Annotation(Name = "[祭祀场侍女] 主祭戒指 50006110")]
        ShrineHandmaidPriestessRing = 50006110,

        [Annotation(Name = "[不死聚落的葛雷瑞特] 蓝泪石戒指 50006120")]
        GreiratOfTheUndeadSettlementBlueTearstoneRing = 50006120,

        [Annotation(Name = "[不死聚落的葛雷瑞特] 葛雷瑞特的骨灰 50006121")]
        GreiratOfTheUndeadSettlementGreiratsAshes = 50006121,

        [Annotation(Name = "[彼海姆的欧贝克] 欧贝克的骨灰 50006132")]
        OrbeckOfVinheimOrbecksAshes = 50006132,

        [Annotation(Name = "[大沼的柯弭库斯] 咒术之火 50006140")]
        CornyxOfTheGreatSwampPyromancyFlame = 50006140,

        [Annotation(Name = "[大沼的柯弭库斯] 师长遮眼布 50006141")]
        CornyxOfTheGreatSwampOldSagesBlindfold = 50006141,

        [Annotation(Name = "[大沼的柯弭库斯] 柯弭库斯的骨灰 50006142")]
        CornyxOfTheGreatSwampCornyxsAshes = 50006142,

        [Annotation(Name = "[卡露拉] 卡露拉三角帽子 50006150")]
        KarlaKarlasPointedHat = 50006150,

        [Annotation(Name = "[卡露拉] 卡露拉的骨灰 50006151")]
        KarlaKarlasAshes = 50006151,

        [Annotation(Name = "[卡利姆的伊莉娜] 塔的钥匙 50006160")]
        IrinaOfCarimTowerKey = 50006160,

        [Annotation(Name = "[卡利姆的伊莉娜] 伊莉娜的骨灰 50006164")]
        IrinaOfCarimIrinasAshes = 50006164,

        [Annotation(Name = "[卡利姆的伊果] 摩恩大锤 50006170")]
        EygonOfCarimMornesGreatHammer = 50006170,

        [Annotation(Name = "[亚斯特拉的安里 #1] 安里的直剑 50006030")]
        AnriOfAstora1AnrisStraightSword = 50006030,

        [Annotation(Name = "[亚斯特拉的安里 #2] 邪眼戒指 50006190")]
        AnriOfAstora2RingOfTheEvilEye = 50006190,

        [Annotation(Name = "[不屈不挠的帕奇 #1] 雁翅枪 50006202")]
        UnbreakablePatches1WingedSpear = 50006202,

        [Annotation(Name = "[不屈不挠的帕奇 #1] 帕奇的骨灰 50006203")]
        UnbreakablePatches1PatchesAshes = 50006203,

        [Annotation(Name = "[不屈不挠的帕奇 #3] 突刺盾 73501050")]
        UnbreakablePatches3PierceShield = 73501050,

        [Annotation(Name = "[不屈不挠的帕奇 #3] 卡塔利纳头盔 73501010")]
        UnbreakablePatches3CatarinaHelm = 73501010,

        [Annotation(Name = "[不屈不挠的帕奇 #3] 卡塔利纳护甲 73501020")]
        UnbreakablePatches3CatarinaArmor = 73501020,

        [Annotation(Name = "[不屈不挠的帕奇 #3] 卡塔利纳护臂 73501030")]
        UnbreakablePatches3CatarinaGauntlets = 73501030,

        [Annotation(Name = "[不屈不挠的帕奇 #3] 卡塔利纳护腿 73501040")]
        UnbreakablePatches3CatarinaLeggings = 73501040,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多 #1] 卡塔利纳头盔 50006217")]
        SiegwardOfCatarina1CatarinaHelm = 50006217,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多 #1] 风暴管束者 50006218")]
        SiegwardOfCatarina1StormRuler = 50006218,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多 #3] 楔形石原盘 50006215")]
        SiegwardOfCatarina3TitaniteSlab = 50006215,

        [Annotation(Name = "[主祭艾玛] 洛斯里克小环旗 50006232")]
        HighPriestessEmmaSmallLothricBanner = 50006232,

        [Annotation(Name = "[主祭艾玛] 誓言水盆 50006230")]
        HighPriestessEmmaBasinOfVows = 50006230,

        [Annotation(Name = "[巨人] 老鹰戒指 50006251")]
        GiantHawkRing = 50006251,

        [Annotation(Name = "[沉默骑士霍拉斯] 林德盾 50006260")]
        HoraceTheHushedLlewellynShield = 50006260,

        [Annotation(Name = "[隆道尔朝圣者] 拟态 50006300")]
        LondorPilgrimChameleon = 50006300,

        [Annotation(Name = "[隆道尔朝圣者] 定约剑 50006301")]
        LondorPilgrimSwordOfAvowal = 50006301,

        [Annotation(Name = "[酣梦禁忌者] 返回骨片 50006311")]
        DrowsyForlornHomewardBone = 50006311,

        [Annotation(Name = "[骑士维赫勒] 机关钥匙 50006520")]
        SirVilhelmContraptionKey = 50006520,

        [Annotation(Name = "[骑士维赫勒] 缟玛瑙刃剑 50006521")]
        SirVilhelmOnyxBlade = 50006521,

        [Annotation(Name = "[鸦村的禁忌者] 楔形石原盘 50006540")]
        ForlornCorvianSettlerTitaniteSlab = 50006540,

        [Annotation(Name = "[芙莉德修女] 咬霜戒指 50006550")]
        SisterFriedeChillbiteRing = 50006550,

        [Annotation(Name = "[丧失记忆的拉普 #1] 王者遗骨 50006623")]
        AmnesiacLapp1ChampionsBones = 50006623,

        [Annotation(Name = "[丧失记忆的拉普 #2] 杰克的酒 50006620")]
        AmnesiacLapp2Siegbräu = 50006620,

        [Annotation(Name = "[丧失记忆的拉普 #3] 杰克的酒 50006622")]
        AmnesiacLapp3Siegbräu = 50006622,

        [Annotation(Name = "[丧失记忆的拉普 #6] 楔形石原盘 50006621")]
        AmnesiacLapp6TitaniteSlab = 50006621,

        [Annotation(Name = "[“费莲诺尔的骑士”希拉 #1] 费莲诺尔圣铃 50006630")]
        ShiraKnightOfFilianore1SacredChimeOfFilianore = 50006630,

        [Annotation(Name = "[“费莲诺尔的骑士”希拉 #1] 楔形石原盘 50006631")]
        ShiraKnightOfFilianore1TitaniteSlab = 50006631,

        [Annotation(Name = "[“费莲诺尔的骑士”希拉 #1] 狂王磔枪 50006632")]
        ShiraKnightOfFilianore1CrucifixOfTheMadKing = 50006632,

        [Annotation(Name = "[背盖子的老妪] 老妪骨灰 50006660")]
        StonehumpedHagOldWomansAshes = 50006660,

        [Annotation(Name = "[黑手的歌德希尔特] 大书库的钥匙 50006700")]
        BlackHandGotthardGrandArchivesKey = 50006700,

        [Annotation(Name = "[黑手神威] 鬼切与姥断 50006705")]
        BlackHandKamuiOnikiriandUbadachi = 50006705,

        [Annotation(Name = "[坚石的哈维尔] 大龙牙 50006710")]
        HavelTheRockDragonTooth = 50006710,

        [Annotation(Name = "[专家] 打刀 50006720")]
        SwordMasterUchigatana = 50006720,

        [Annotation(Name = "[山贼] 蜘蛛纹盾 50006730")]
        BrigandSpiderShield = 50006730,

        [Annotation(Name = "[龙血骑士] 龙血大剑 50006740")]
        DrakebloodKnightDrakebloodGreatsword = 50006740,

        [Annotation(Name = "[细剑斗士] 里卡尔刺剑 50006750")]
        RapierChampionRicardsRapier = 50006750,

        [Annotation(Name = "[法兰流放者守卫] 流放者大刀 50006760")]
        ExileWatchdogExileGreatsword = 50006760,

        [Annotation(Name = "[法兰流放者守卫] 巨型棍棒 50006770")]
        ExileWatchdogGreatClub = 50006770,

        [Annotation(Name = "[黄指头的海泽儿] 海泽儿的十字镐 50006780")]
        YellowfingerHeyselHeyselPick = 50006780,

        [Annotation(Name = "[隆道尔的白色影子] 傀儡钩爪 50006790")]
        LondorPaleShadeManikinClaws = 50006790,

        [Annotation(Name = "[狮子骑士艾伯特] 金翼图纹盾 50006800")]
        LionKnightAlbertGoldenWingCrestShield = 50006800,

        [Annotation(Name = "[“结晶的女儿”克琳姆希德] 老者结晶杖 50006810")]
        DaughterOfCrystalKriemhildSagesCrystalStaff = 50006810,

        [Annotation(Name = "[宫廷魔法师] 罗根卷轴 50006820")]
        CourtSorcererLogansScroll = 50006820,

        [Annotation(Name = "[多兰骑士] 多兰对枪 50006830")]
        DrangKnightDrangTwinspears = 50006830,

        [Annotation(Name = "[猎杀骑士卓力格 #1] 猎杀骑士戒指 50006840")]
        KnightSlayerTsorig1KnightSlayersRing = 50006840,

        [Annotation(Name = "[猎杀骑士卓力格 #2] 漫烟特大剑 50006845")]
        KnightSlayerTsorig2FumeUltraGreatsword = 50006845,

        [Annotation(Name = "[流浪的克雷顿] 屠龙斧 50006850")]
        CreightonTheWandererDragonslayersAxe = 50006850,

        [Annotation(Name = "[探寻禁忌的亚瓦] 丛云 50006860")]
        AlvaSeekerOfTheSpurnedMurakumo = 50006860,

        [Annotation(Name = "[中指的寇克] 刺针直剑 50006870")]
        LongfingerKirkBarbedStraightSword = 50006870,

        [Annotation(Name = "[疯女伊莎贝拉] 切肉菜刀 50006880")]
        IsabellaTheMadButcherKnife = 50006880,

        [Annotation(Name = "[“尸斑咒术师”丹涅尔] 浮空混沌 50006920")]
        LividPyromancerDunnelFloatingChaos = 50006920,

        [Annotation(Name = "[“费莲诺尔的骑士”希拉] 狂王磔枪 50006939")]
        ShiraKnightOfFilianoreCrucifixOfTheMadKing = 50006939,

        [Annotation(Name = "[未知] 白树弓 50006940")]
        UnkWhiteBirchBow = 50006940,

        [Annotation(Name = "[“沙之咒术师”卓伊] 火焰扇 50006950")]
        DesertPyromancerZoeyFlameFan = 50006950,

        [Annotation(Name = "[银骑士雷多] 雷多大锤 50006960")]
        SilverKnightLedoLedosGreatHammer = 50006960,

        [Annotation(Name = "[探寻禁忌的亚瓦] 狼戒指＋3 50006970")]
        AlvaSeekerOfTheSpurnedWolfRing3 = 50006970,

        [Annotation(Name = "[呻吟骑士] 覆眼面具 50006980")]
        MoaningKnightBlindfoldMask = 50006980,

        [Annotation(Name = "[无主墓地] 防火女的眼眸 50006020")]
        UntendedGravesEyesOfaFireKeeper = 50006020,

        [Annotation(Name = "[隆道尔的尤莉雅] 摩利安刃剑 50006040")]
        YuriaOfLondorMorionBlade = 50006040,

        [Annotation(Name = "[隆道尔的尤莉雅] 鸟喙面具 - 游魂之王奖励 50006042")]
        YuriaOfLondorBilledMaskLordOfHollowreward = 50006042,

        [Annotation(Name = "廓尔喀弯刀 50006063")]
        Kukri_ = 50006063,

        [Annotation(Name = "[古龙顶端] 光辉龙体石 - 在祭坛祈祷 50006071")]
        ArchdragonPeakTwinklingDragonTorsoStonePrayatAltar = 50006071,

        [Annotation(Name = "[脱逃者霍克伍德] 光辉龙头石 50006072")]
        HawkwoodTwinklingDragonHeadStone = 50006072,

        [Annotation(Name = "[脱逃者霍克伍德] 法兰戒指 50006073")]
        HawkwoodFarronRing = 50006073,

        [Annotation(Name = "[脱逃者霍克伍德] 霍克伍德盾 50006074")]
        HawkwoodHawkwoodsShield = 50006074,

        [Annotation(Name = "[薄暮之国的希里丝] 祝福破甲细剑 50006080")]
        SirrisOfTheSunlessRealmsBlessedMailBreaker = 50006080,

        [Annotation(Name = "[薄暮之国的希里丝] 黄昏盾 50006081")]
        SirrisOfTheSunlessRealmsSunsetShield = 50006081,

        [Annotation(Name = "[薄暮之国的希里丝] 黄昏头盔 50006083")]
        SirrisOfTheSunlessRealmsSunsetHelm = 50006083,

        [Annotation(Name = "[无名指的李奥纳德] 漆黑眼眸宝珠 50006092")]
        RingfingerLeonhardBlackEyeOrb = 50006092,

        [Annotation(Name = "[无名指的李奥纳德] 血红眼眸宝珠 6780")]
        RingfingerLeonhardRedEyeOrb = 6780,

        [Annotation(Name = "[铁匠安德烈] 霍克伍德的剑草 50006100")]
        AndreHawkwoodsSwordgrass = 50006100,

        [Annotation(Name = "[彼海姆的欧贝克] 稚嫩龙徽戒指 50006130")]
        OrbeckOfVinheimYoungDragonRing = 50006130,

        [Annotation(Name = "[彼海姆的欧贝克] 沉眠龙徽戒指 50006131")]
        OrbeckOfVinheimSlumberingDragoncrestRing = 50006131,

        [Annotation(Name = "[不死聚落] 圣女护符 50006161")]
        UndeadSettlementSaintsTalisman = 50006161,

        [Annotation(Name = "[幽邃教堂] 幽邃点字圣典 - 宝箱怪掉落 50006162")]
        CathedralOfTheDeepDeepBrailleDivineTomeMimicdrop = 50006162,

        [Annotation(Name = "[隆道尔的尤莉雅] 隆道尔点字圣典 50006163")]
        YuriaOfLondorLondorBrailleDivineTome = 50006163,

        [Annotation(Name = "[隆道尔的尤艾尔] 黑暗印记 50006193")]
        YoelOfLondorDarkSigil = 50006193,

        [Annotation(Name = "锈斑硬币 50006200")]
        RustedCoin = 50006200,

        [Annotation(Name = "锈斑金币 50006201")]
        RustedGoldCoin = 50006201,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多] 杰克的酒 50006210")]
        SiegwardOfCatarinaSiegbräu = 50006210,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多] 杰克的酒 50006211")]
        SiegwardOfCatarinaSiegbräu_ = 50006211,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多] 杰克的酒 50006212")]
        SiegwardOfCatarinaSiegbräu__ = 50006212,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多] 廓尔喀弯刀 50006213")]
        SiegwardOfCatarinaKukri = 50006213,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多] 原力并射 50006214")]
        SiegwardOfCatarinaEmitForce = 50006214,

        [Annotation(Name = "[卡塔利纳的杰克巴尔多] 风暴管束者 50006216")]
        SiegwardOfCatarinaStormRuler = 50006216,

        [Annotation(Name = "[巨人] 嫩白树枝 50006250")]
        GiantYoungWhiteBranch = 50006250,

        [Annotation(Name = "[丧失记忆的拉普] 拉普头盔 50006624")]
        AmnesiacLappLappsHelm = 50006624,

        [Annotation(Name = "[洛斯里克的高墙] 原素碎片 53000000")]
        HighWallOfLothricEstusShard = 53000000,

        [Annotation(Name = "[洛斯里克的高墙] 绿花草 53000010")]
        HighWallOfLothricGreenBlossom = 53000010,

        [Annotation(Name = "[洛斯里克的高墙] 黄金松脂 53000020")]
        HighWallOfLothricGoldPineResin = 53000020,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的大块灵魂 53000030")]
        HighWallOfLothricLargeSoulOfaDesertedCorpse = 53000030,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的灵魂 53000040")]
        HighWallOfLothricSoulOfaDesertedCorpse = 53000040,

        [Annotation(Name = "[洛斯里克的高墙] 长弓 53000060")]
        HighWallOfLothricLongbow = 53000060,

        [Annotation(Name = "[洛斯里克的高墙] 火焰壶 53000070")]
        HighWallOfLothricFirebomb = 53000070,

        [Annotation(Name = "[洛斯里克的高墙] 飞刀 53000090")]
        HighWallOfLothricThrowingKnife = 53000090,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的灵魂 53000110")]
        HighWallOfLothricSoulOfaDesertedCorpse_ = 53000110,

        [Annotation(Name = "[洛斯里克的高墙] 棍棒 53000120")]
        HighWallOfLothricClub = 53000120,

        [Annotation(Name = "[洛斯里克的高墙] 大剑 53000130")]
        HighWallOfLothricClaymore = 53000130,

        [Annotation(Name = "[洛斯里克的高墙] 余火 53000140")]
        HighWallOfLothricEmber = 53000140,

        [Annotation(Name = "[洛斯里克的高墙] 火焰壶 53000150")]
        HighWallOfLothricFirebomb_ = 53000150,

        [Annotation(Name = "[洛斯里克的高墙] 楔形石碎片 53000160")]
        HighWallOfLothricTitaniteShard = 53000160,

        [Annotation(Name = "[洛斯里克的高墙] 猎捕不死人护符 53000170")]
        HighWallOfLothricUndeadHunterCharm = 53000170,

        [Annotation(Name = "[洛斯里克的高墙] 火焰壶 53000180")]
        HighWallOfLothricFirebomb__ = 53000180,

        [Annotation(Name = "[洛斯里克的高墙] 监牢的钥匙 53000210")]
        HighWallOfLothricCellKey = 53000210,

        [Annotation(Name = "[洛斯里克的高墙] 余火 53000230")]
        HighWallOfLothricEmber_ = 53000230,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的灵魂 53000240")]
        HighWallOfLothricSoulOfaDesertedCorpse__ = 53000240,

        [Annotation(Name = "[洛斯里克的高墙] 鹤嘴戟 53000250")]
        HighWallOfLothricLucerne = 53000250,

        [Annotation(Name = "[洛斯里克的高墙] 破甲细剑 53000270")]
        HighWallOfLothricMailBreaker = 53000270,

        [Annotation(Name = "[洛斯里克的高墙] 楔形石碎片 53000280")]
        HighWallOfLothricTitaniteShard_ = 53000280,

        [Annotation(Name = "[洛斯里克的高墙] 细剑 53000290")]
        HighWallOfLothricRapier = 53000290,

        [Annotation(Name = "[洛斯里克的高墙] 楔形石碎片 53000300")]
        HighWallOfLothricTitaniteShard__ = 53000300,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的大块灵魂 53000310")]
        HighWallOfLothricLargeSoulOfaDesertedCorpse_ = 53000310,

        [Annotation(Name = "[洛斯里克的高墙] 黑火焰壶 53000320")]
        HighWallOfLothricBlackFirebomb = 53000320,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的灵魂 53000340")]
        HighWallOfLothricSoulOfaDesertedCorpse___ = 53000340,

        [Annotation(Name = "[洛斯里克的高墙] 余火 53000360")]
        HighWallOfLothricEmber__ = 53000360,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的大块灵魂 53000370")]
        HighWallOfLothricLargeSoulOfaDesertedCorpse__ = 53000370,

        [Annotation(Name = "[洛斯里克的高墙] 望远镜 53000380")]
        HighWallOfLothricBinoculars = 53000380,

        [Annotation(Name = "[洛斯里克的高墙] 牺牲戒指 53000390")]
        HighWallOfLothricRingOfSacrifice = 53000390,

        [Annotation(Name = "[洛斯里克的高墙] 飞刀 53000400")]
        HighWallOfLothricThrowingKnife_ = 53000400,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的灵魂 53000410")]
        HighWallOfLothricSoulOfaDesertedCorpse____ = 53000410,

        [Annotation(Name = "[洛斯里克的高墙] 绿花草 53000420")]
        HighWallOfLothricGreenBlossom_ = 53000420,

        [Annotation(Name = "[妖王庭院] 黑影蒙面布 53000430")]
        ConsumedKingsGardenShadowMask = 53000430,

        [Annotation(Name = "[洛斯里克的高墙] 阔剑 53000440")]
        HighWallOfLothricBroadsword = 53000440,

        [Annotation(Name = "[洛斯里克的高墙] 弃尸的灵魂 53000450")]
        HighWallOfLothricSoulOfaDesertedCorpse_____ = 53000450,

        [Annotation(Name = "[洛斯里克的高墙] 黑火焰壶 53000470")]
        HighWallOfLothricBlackFirebomb_ = 53000470,

        [Annotation(Name = "[妖王庭院] 钩爪 53000480")]
        ConsumedKingsGardenClaw = 53000480,

        [Annotation(Name = "[妖王庭院] 楔形石大碎片 53000490")]
        ConsumedKingsGardenLargeTitaniteShard = 53000490,

        [Annotation(Name = "[妖王庭院] 龙鳞戒指 53000500")]
        ConsumedKingsGardenDragonscaleRing = 53000500,

        [Annotation(Name = "[妖王庭院] 人松脂 53000510")]
        ConsumedKingsGardenHumanPineResin = 53000510,

        [Annotation(Name = "[妖王庭院] 楔形石块 53000520")]
        ConsumedKingsGardenTitaniteChunk = 53000520,

        [Annotation(Name = "[妖王庭院] 楔形石块 53000530")]
        ConsumedKingsGardenTitaniteChunk_ = 53000530,

        [Annotation(Name = "[妖王庭院] 竭力战士的灵魂 53000540")]
        ConsumedKingsGardenSoulOfaWearyWarrior = 53000540,

        [Annotation(Name = "[妖王庭院] 暗宝石 53000550")]
        ConsumedKingsGardenDarkGem = 53000550,

        [Annotation(Name = "[妖王庭院] 熟练宝石 53000570")]
        ConsumedKingsGardenRefinedGem = 53000570,

        [Annotation(Name = "[妖王庭院] 火焰壶 53000580")]
        ConsumedKingsGardenFirebomb = 53000580,

        [Annotation(Name = "[妖王庭院] 弃尸的灵魂 53000610")]
        ConsumedKingsGardenSoulOfaDesertedCorpse = 53000610,

        [Annotation(Name = "[妖王庭院] 人松脂 53000620")]
        ConsumedKingsGardenHumanPineResin_ = 53000620,

        [Annotation(Name = "[妖王庭院] 楔形石块 53000630")]
        ConsumedKingsGardenTitaniteChunk__ = 53000630,

        [Annotation(Name = "[妖王庭院] 牺牲戒指 53000640")]
        ConsumedKingsGardenRingOfSacrifice = 53000640,

        [Annotation(Name = "[洛斯里克的高墙] 原素碎片 53000650")]
        HighWallOfLothricEstusShard_ = 53000650,

        [Annotation(Name = "[洛斯里克的高墙] 咬人戒指＋1 53000700")]
        HighWallOfLothricFleshbiteRing1 = 53000700,

        [Annotation(Name = "[洛斯里克的高墙] 木纹戒指＋1 53000710")]
        HighWallOfLothricWoodGrainRing1 = 53000710,

        [Annotation(Name = "[洛斯里克的高墙] 邪眼戒指＋2 53000720")]
        HighWallOfLothricRingOfTheEvilEye2 = 53000720,

        [Annotation(Name = "[妖王庭院] 老者戒指＋2 53000730")]
        ConsumedKingsGardenSageRing2 = 53000730,

        [Annotation(Name = "[妖王庭院] 龙鳞楔形石 53000800")]
        ConsumedKingsGardenTitaniteScale = 53000800,

        [Annotation(Name = "[洛斯里克的高墙] 银鹫鸢形盾 53000820")]
        HighWallOfLothricSilverEagleKiteShield = 53000820,

        [Annotation(Name = "[洛斯里克的高墙] 亚斯特拉直剑 53000830")]
        HighWallOfLothricAstoraStraightSword = 53000830,

        [Annotation(Name = "[妖王庭院] 龙鳞楔形石 53000840")]
        ConsumedKingsGardenTitaniteScale_ = 53000840,

        [Annotation(Name = "[妖王庭院] 龙血头盔 53000950")]
        ConsumedKingsGardenDrakebloodHelm = 53000950,

        [Annotation(Name = "[洛斯里克城] 狙击弩 53010000")]
        LothricCastleSniperCrossbow = 53010000,

        [Annotation(Name = "[洛斯里克城] 龙鳞楔形石 53010010")]
        LothricCastleTitaniteScale = 53010010,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010020")]
        LothricCastleTitaniteChunk = 53010020,

        [Annotation(Name = "[洛斯里克城] 巨骑枪 53010030")]
        LothricCastleGreatlance = 53010030,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010040")]
        LothricCastleTitaniteChunk_ = 53010040,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010050")]
        LothricCastleTitaniteChunk__ = 53010050,

        [Annotation(Name = "[洛斯里克城] 圣花盾 53010060")]
        LothricCastleSacredBloomShield = 53010060,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010070")]
        LothricCastleTitaniteChunk___ = 53010070,

        [Annotation(Name = "[洛斯里克城] 熟练宝石 53010080")]
        LothricCastleRefinedGem = 53010080,

        [Annotation(Name = "[洛斯里克城] 受挫骑士的灵魂 53010090")]
        LothricCastleSoulOfaCrestfallenKnight = 53010090,

        [Annotation(Name = "[洛斯里克城] 不死人遗骨 53010100")]
        LothricCastleUndeadBoneShard = 53010100,

        [Annotation(Name = "[洛斯里克城] 雷壶 53010110")]
        LothricCastleLightningUrn = 53010110,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010120")]
        LothricCastleTitaniteChunk____ = 53010120,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010130")]
        LothricCastleTitaniteChunk_____ = 53010130,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010140")]
        LothricCastleTitaniteChunk______ = 53010140,

        [Annotation(Name = "[大书库] 夸特铃铛 53010150")]
        GrandArchivesCaithasChime = 53010150,

        [Annotation(Name = "[洛斯里克城] 雷壶 53010160")]
        LothricCastleLightningUrn_ = 53010160,

        [Annotation(Name = "[洛斯里克城] 余火 53010170")]
        LothricCastleEmber = 53010170,

        [Annotation(Name = "[洛斯里克城] 粗制宝石 53010180")]
        LothricCastleRawGem = 53010180,

        [Annotation(Name = "[洛斯里克城] 黑火焰壶 53010190")]
        LothricCastleBlackFirebomb = 53010190,

        [Annotation(Name = "[洛斯里克城] 青白色松脂 53010200")]
        LothricCastlePalePineResin = 53010200,

        [Annotation(Name = "[洛斯里克城] 竭力战士的大块灵魂 53010210")]
        LothricCastleLargeSoulOfaWearyWarrior = 53010210,

        [Annotation(Name = "[洛斯里克城] 太阳徽章 53010220")]
        LothricCastleSunlightMedal = 53010220,

        [Annotation(Name = "[洛斯里克城] 受挫骑士的灵魂 53010230")]
        LothricCastleSoulOfaCrestfallenKnight_ = 53010230,

        [Annotation(Name = "[洛斯里克城] 楔形石块 53010240")]
        LothricCastleTitaniteChunk_______ = 53010240,

        [Annotation(Name = "[洛斯里克城] 龙鳞楔形石 53010250")]
        LothricCastleTitaniteScale_ = 53010250,

        [Annotation(Name = "[洛斯里克城] 无名士兵的大块灵魂 53010260")]
        LothricCastleLargeSoulOfaNamelessSoldier = 53010260,

        [Annotation(Name = "[洛斯里克城] 骑士戒指 53010270")]
        LothricCastleKnightsRing = 53010270,

        [Annotation(Name = "[洛斯里克城] 余火 53010280")]
        LothricCastleEmber_ = 53010280,

        [Annotation(Name = "[洛斯里克城] 竭力战士的大块灵魂 53010290")]
        LothricCastleLargeSoulOfaWearyWarrior_ = 53010290,

        [Annotation(Name = "[洛斯里克城] 余火 53010300")]
        LothricCastleEmber__ = 53010300,

        [Annotation(Name = "[洛斯里克城] 光辉楔形石 53010310")]
        LothricCastleTwinklingTitanite = 53010310,

        [Annotation(Name = "[洛斯里克城] 无名士兵的大块灵魂 53010320")]
        LothricCastleLargeSoulOfaNamelessSoldier_ = 53010320,

        [Annotation(Name = "[洛斯里克城] 余火 53010330")]
        LothricCastleEmber___ = 53010330,

        [Annotation(Name = "[洛斯里克城] 羽翼骑士头盔 53010340")]
        LothricCastleWingedKnightHelm = 53010340,

        [Annotation(Name = "[洛斯里克城] 锈斑硬币 53010350")]
        LothricCastleRustedCoin = 53010350,

        [Annotation(Name = "[洛斯里克城] 楔形石原盘 53010360")]
        LothricCastleTitaniteSlab = 53010360,

        [Annotation(Name = "[洛斯里克城] 洛斯里克点字圣典 53010370")]
        LothricCastleBrailleDivineTomeOfLothric = 53010370,

        [Annotation(Name = "[洛斯里克城] 红泪石戒指 53010380")]
        LothricCastleRedTearstoneRing = 53010380,

        [Annotation(Name = "[洛斯里克城] 光辉楔形石 53010400")]
        LothricCastleTwinklingTitanite_ = 53010400,

        [Annotation(Name = "[洛斯里克城] 无名士兵的大块灵魂 53010420")]
        LothricCastleLargeSoulOfaNamelessSoldier__ = 53010420,

        [Annotation(Name = "[洛斯里克城] 龙鳞楔形石 53010500")]
        LothricCastleTitaniteScale__ = 53010500,

        [Annotation(Name = "[洛斯里克城] 龙鳞楔形石 53010520")]
        LothricCastleTitaniteScale___ = 53010520,

        [Annotation(Name = "[洛斯里克城] 祈祷风帽 53010530")]
        LothricCastleHoodOfPrayer = 53010530,

        [Annotation(Name = "[洛斯里克城] 神木图纹盾 53010600")]
        LothricCastleSpiritTreeCrestShield = 53010600,

        [Annotation(Name = "[洛斯里克城] 龙鳞楔形石 53010610")]
        LothricCastleTitaniteScale____ = 53010610,

        [Annotation(Name = "[洛斯里克城] 光辉楔形石 53010620")]
        LothricCastleTwinklingTitanite__ = 53010620,

        [Annotation(Name = "[洛斯里克城] 光辉楔形石 53010640")]
        LothricCastleTwinklingTitanite___ = 53010640,

        [Annotation(Name = "[洛斯里克城] 生命戒指＋2 53010700")]
        LothricCastleLifeRing2 = 53010700,

        [Annotation(Name = "[洛斯里克城] 暗方石戒指＋1 53010710")]
        LothricCastleDarkStoneplateRing1 = 53010710,

        [Annotation(Name = "[洛斯里克城] 雷方石戒指＋2 53010720")]
        LothricCastleThunderStoneplateRing2 = 53010720,

        [Annotation(Name = "[不死聚落] 弗林戒指 53100000")]
        UndeadSettlementFlynnsRing = 53100000,

        [Annotation(Name = "[不死聚落] 不死人遗骨 53100010")]
        UndeadSettlementUndeadBoneShard = 53100010,

        [Annotation(Name = "[不死聚落] 诱敌头盖骨 53100020")]
        UndeadSettlementAlluringSkull = 53100020,

        [Annotation(Name = "[不死聚落] 安葬者骨灰 53100030")]
        UndeadSettlementMorticiansAshes = 53100030,

        [Annotation(Name = "[不死聚落] 返回骨片 53100040")]
        UndeadSettlementHomewardBone = 53100040,

        [Annotation(Name = "[不死聚落] 孪生蛇纹圆盾 53100050")]
        UndeadSettlementCaduceusRoundShield = 53100050,

        [Annotation(Name = "[不死聚落] 余火 53100060")]
        UndeadSettlementEmber = 53100060,

        [Annotation(Name = "[不死聚落] 来历不明旅人的灵魂 53100070")]
        UndeadSettlementSoulOfanUnknownTraveler = 53100070,

        [Annotation(Name = "[不死聚落] 修理光粉 53100080")]
        UndeadSettlementRepairPowder = 53100080,

        [Annotation(Name = "[不死聚落] 返回骨片 53100090")]
        UndeadSettlementHomewardBone_ = 53100090,

        [Annotation(Name = "[不死聚落] 斑斓鞭 53100100")]
        UndeadSettlementSpottedWhip = 53100100,

        [Annotation(Name = "[不死聚落] 楔形石碎片 53100110")]
        UndeadSettlementTitaniteShard = 53100110,

        [Annotation(Name = "[不死聚落] 战神木盾 53100120")]
        UndeadSettlementWargodWoodenShield = 53100120,

        [Annotation(Name = "[不死聚落] 弃尸的大块灵魂 53100130")]
        UndeadSettlementLargeSoulOfaDesertedCorpse = 53100130,

        [Annotation(Name = "[不死聚落] 余火 53100140")]
        UndeadSettlementEmber_ = 53100140,

        [Annotation(Name = "[不死聚落] 弃尸的大块灵魂 53100150")]
        UndeadSettlementLargeSoulOfaDesertedCorpse_ = 53100150,

        [Annotation(Name = "[不死聚落] 楔形石碎片 53100160")]
        UndeadSettlementTitaniteShard_ = 53100160,

        [Annotation(Name = "[不死聚落] 诱敌头盖骨 53100170")]
        UndeadSettlementAlluringSkull_ = 53100170,

        [Annotation(Name = "[不死聚落] 散装焦炭松脂 53100180")]
        UndeadSettlementCharcoalPineBundle = 53100180,

        [Annotation(Name = "[不死聚落] 蓝木盾 53100190")]
        UndeadSettlementBlueWoodenShield = 53100190,

        [Annotation(Name = "[不死聚落] 来历不明旅人的灵魂 53100200")]
        UndeadSettlementSoulOfanUnknownTraveler_ = 53100200,

        [Annotation(Name = "[不死聚落] 焦炭松脂 53100210")]
        UndeadSettlementCharcoalPineResin = 53100210,

        [Annotation(Name = "[不死聚落] 兜裆布 53100220")]
        UndeadSettlementLoincloth = 53100220,

        [Annotation(Name = "[不死聚落] 散装焦炭松脂 53100230")]
        UndeadSettlementCharcoalPineBundle_ = 53100230,

        [Annotation(Name = "[不死聚落] 来历不明旅人的灵魂 53100240")]
        UndeadSettlementSoulOfanUnknownTraveler__ = 53100240,

        [Annotation(Name = "[不死聚落] 楔形石碎片 53100250")]
        UndeadSettlementTitaniteShard__ = 53100250,

        [Annotation(Name = "[不死聚落] 红柄戟 53100260")]
        UndeadSettlementRedHiltedHalberd = 53100260,

        [Annotation(Name = "[不死聚落] 锈斑硬币 53100270")]
        UndeadSettlementRustedCoin = 53100270,

        [Annotation(Name = "[不死聚落] 护手带 53100280")]
        UndeadSettlementCaestus = 53100280,

        [Annotation(Name = "[不死聚落] 圣女护符 53100300")]
        UndeadSettlementSaintsTalisman_ = 53100300,

        [Annotation(Name = "[不死聚落] 诱敌头盖骨 53100310")]
        UndeadSettlementAlluringSkull__ = 53100310,

        [Annotation(Name = "[不死聚落] 大型棍棒 53100320")]
        UndeadSettlementLargeClub = 53100320,

        [Annotation(Name = "[不死聚落] 楔形石碎片 53100330")]
        UndeadSettlementTitaniteShard___ = 53100330,

        [Annotation(Name = "[不死聚落] 楔形石碎片 53100340")]
        UndeadSettlementTitaniteShard____ = 53100340,

        [Annotation(Name = "[不死聚落] 即将消逝的灵魂 53100350")]
        UndeadSettlementFadingSoul = 53100350,

        [Annotation(Name = "[不死聚落] 楔形石碎片 53100360")]
        UndeadSettlementTitaniteShard_____ = 53100360,

        [Annotation(Name = "[不死聚落] 手斧 53100370")]
        UndeadSettlementHandAxe = 53100370,

        [Annotation(Name = "[不死聚落] 来历不明旅人的灵魂 53100380")]
        UndeadSettlementSoulOfanUnknownTraveler___ = 53100380,

        [Annotation(Name = "[不死聚落] 余火 53100390")]
        UndeadSettlementEmber__ = 53100390,

        [Annotation(Name = "[不死聚落] 米勒背心 53100400")]
        UndeadSettlementMirrahVest = 53100400,

        [Annotation(Name = "[不死聚落] 木板盾 53100410")]
        UndeadSettlementPlankShield = 53100410,

        [Annotation(Name = "[不死聚落] 红虫药丸 53100420")]
        UndeadSettlementRedBugPellet = 53100420,

        [Annotation(Name = "[不死聚落] 绿花戒指 53100430")]
        UndeadSettlementChloranthyRing = 53100430,

        [Annotation(Name = "[不死聚落] 火焰怪手戒指 53100440")]
        UndeadSettlementFireClutchRing = 53100440,

        [Annotation(Name = "[不死聚落] 原素碎片 53100450")]
        UndeadSettlementEstusShard = 53100450,

        [Annotation(Name = "[不死聚落] 火焰壶 53100460")]
        UndeadSettlementFirebomb = 53100460,

        [Annotation(Name = "[不死聚落] 软鞭 53100490")]
        UndeadSettlementWhip = 53100490,

        [Annotation(Name = "[不死聚落] 大镰刀 53100500")]
        UndeadSettlementGreatScythe = 53100500,

        [Annotation(Name = "[不死聚落] 返回骨片 53100540")]
        UndeadSettlementHomewardBone__ = 53100540,

        [Annotation(Name = "[不死聚落] 弃尸的大块灵魂 53100550")]
        UndeadSettlementLargeSoulOfaDesertedCorpse__ = 53100550,

        [Annotation(Name = "[不死聚落] 余火 53100570")]
        UndeadSettlementEmber___ = 53100570,

        [Annotation(Name = "[不死聚落] 弃尸的大块灵魂 53100610")]
        UndeadSettlementLargeSoulOfaDesertedCorpse___ = 53100610,

        [Annotation(Name = "[不死聚落] 即将消逝的灵魂 53100620")]
        UndeadSettlementFadingSoul_ = 53100620,

        [Annotation(Name = "[不死聚落] 嫩白树枝 53100630")]
        UndeadSettlementYoungWhiteBranch = 53100630,

        [Annotation(Name = "[不死聚落] 余火 53100640")]
        UndeadSettlementEmber____ = 53100640,

        [Annotation(Name = "[不死聚落] 弃尸的大块灵魂 53100650")]
        UndeadSettlementLargeSoulOfaDesertedCorpse____ = 53100650,

        [Annotation(Name = "[不死聚落] 嫩白树枝 53100660")]
        UndeadSettlementYoungWhiteBranch_ = 53100660,

        [Annotation(Name = "[不死聚落] 强化棍棒 53100670")]
        UndeadSettlementReinforcedClub = 53100670,

        [Annotation(Name = "[不死聚落] 无名士兵的灵魂 53100680")]
        UndeadSettlementSoulOfaNamelessSoldier = 53100680,

        [Annotation(Name = "[不死聚落] 罗蕾塔的骨头 53100700")]
        UndeadSettlementLorettasBone = 53100700,

        [Annotation(Name = "[不死聚落] 北方头盔 53100710")]
        UndeadSettlementNorthernHelm = 53100710,

        [Annotation(Name = "[不死聚落] 游击枪 53100720")]
        UndeadSettlementPartizan = 53100720,

        [Annotation(Name = "[不死聚落] 火方石戒指 53100730")]
        UndeadSettlementFlameStoneplateRing = 53100730,

        [Annotation(Name = "[不死聚落] 红白圆盾 53100740")]
        UndeadSettlementRedandWhiteRoundShield = 53100740,

        [Annotation(Name = "[不死聚落] 小皮盾 53100750")]
        UndeadSettlementSmallLeatherShield = 53100750,

        [Annotation(Name = "[不死聚落] 发青舌头 53100760")]
        UndeadSettlementPaleTongue = 53100760,

        [Annotation(Name = "[不死聚落] 弃尸的大块灵魂 53100770")]
        UndeadSettlementLargeSoulOfaDesertedCorpse_____ = 53100770,

        [Annotation(Name = "[不死聚落] 廓尔喀弯刀 53100800")]
        UndeadSettlementKukri = 53100800,

        [Annotation(Name = "[不死聚落] 生命戒指＋1 53100850")]
        UndeadSettlementLifeRing1 = 53100850,

        [Annotation(Name = "[不死聚落] 咬毒戒指＋1 53100860")]
        UndeadSettlementPoisonbiteRing1 = 53100860,

        [Annotation(Name = "[不死聚落] 贪婪银蛇戒指＋2 53100870")]
        UndeadSettlementCovetousSilverSerpentRing2 = 53100870,

        [Annotation(Name = "[不死聚落] 人松脂 53100910")]
        UndeadSettlementHumanPineResin = 53100910,

        [Annotation(Name = "[不死聚落] 返回骨片 53100950")]
        UndeadSettlementHomewardBone___ = 53100950,

        [Annotation(Name = "[古龙顶端] 雷电怪手戒指 53200000")]
        ArchdragonPeakLightningClutchRing = 53200000,

        [Annotation(Name = "[古龙顶端] 含草屎块 53200010")]
        ArchdragonPeakStalkDungPie = 53200010,

        [Annotation(Name = "[古龙顶端] 楔形石块 53200020")]
        ArchdragonPeakTitaniteChunk = 53200020,

        [Annotation(Name = "[古龙顶端] 龙鳞楔形石 53200030")]
        ArchdragonPeakTitaniteScale = 53200030,

        [Annotation(Name = "[古龙顶端] 竭力战士的灵魂 53200040")]
        ArchdragonPeakSoulOfaWearyWarrior = 53200040,

        [Annotation(Name = "[古龙顶端] 楔形石块 53200050")]
        ArchdragonPeakTitaniteChunk_ = 53200050,

        [Annotation(Name = "[古龙顶端] 雷电宝石 53200060")]
        ArchdragonPeakLightningGem = 53200060,

        [Annotation(Name = "[古龙顶端] 返回骨片 53200070")]
        ArchdragonPeakHomewardBone = 53200070,

        [Annotation(Name = "[古龙顶端] 无名士兵的灵魂 53200080")]
        ArchdragonPeakSoulOfaNamelessSoldier = 53200080,

        [Annotation(Name = "[古龙顶端] 楔形石块 53200090")]
        ArchdragonPeakTitaniteChunk__ = 53200090,

        [Annotation(Name = "[古龙顶端] 余火 53200100")]
        ArchdragonPeakEmber = 53200100,

        [Annotation(Name = "[古龙顶端] 竭力战士的大块灵魂 53200110")]
        ArchdragonPeakLargeSoulOfaWearyWarrior = 53200110,

        [Annotation(Name = "[古龙顶端] 无名士兵的大块灵魂 53200120")]
        ArchdragonPeakLargeSoulOfaNamelessSoldier = 53200120,

        [Annotation(Name = "[古龙顶端] 雷壶 53200130")]
        ArchdragonPeakLightningUrn = 53200130,

        [Annotation(Name = "[古龙顶端] 雷弩箭 53200140")]
        ArchdragonPeakLightningBolt = 53200140,

        [Annotation(Name = "[古龙顶端] 楔形石块 53200150")]
        ArchdragonPeakTitaniteChunk___ = 53200150,

        [Annotation(Name = "[古龙顶端] 屎块 53200160")]
        ArchdragonPeakDungPie = 53200160,

        [Annotation(Name = "[古龙顶端] 龙鳞楔形石 53200170")]
        ArchdragonPeakTitaniteScale_ = 53200170,

        [Annotation(Name = "[古龙顶端] 竭力战士的灵魂 53200180")]
        ArchdragonPeakSoulOfaWearyWarrior_ = 53200180,

        [Annotation(Name = "[古龙顶端] 受挫骑士的灵魂 53200190")]
        ArchdragonPeakSoulOfaCrestfallenKnight = 53200190,

        [Annotation(Name = "[古龙顶端] 楔形石块 53200200")]
        ArchdragonPeakTitaniteChunk____ = 53200200,

        [Annotation(Name = "[古龙顶端] 余火 53200210")]
        ArchdragonPeakEmber_ = 53200210,

        [Annotation(Name = "[古龙顶端] 雷方石戒指 53200220")]
        ArchdragonPeakThunderStoneplateRing = 53200220,

        [Annotation(Name = "[古龙顶端] 龙鳞楔形石 53200230")]
        ArchdragonPeakTitaniteScale__ = 53200230,

        [Annotation(Name = "[古龙顶端] 余火 53200240")]
        ArchdragonPeakEmber__ = 53200240,

        [Annotation(Name = "[古龙顶端] 古龙绘大盾 53200260")]
        ArchdragonPeakAncientDragonGreatshield = 53200260,

        [Annotation(Name = "[古龙顶端] 受挫骑士的大块灵魂 53200270")]
        ArchdragonPeakLargeSoulOfaCrestfallenKnight = 53200270,

        [Annotation(Name = "[古龙顶端] 逐龙者骨灰 53200280")]
        ArchdragonPeakDragonChasersAshes = 53200280,

        [Annotation(Name = "[古龙顶端] 余火 53200290")]
        ArchdragonPeakEmber___ = 53200290,

        [Annotation(Name = "[古龙顶端] 猎龙枪 53200300")]
        ArchdragonPeakDragonslayerSpear = 53200300,

        [Annotation(Name = "[古龙顶端] 猎龙头盔 53200310")]
        ArchdragonPeakDragonslayerHelm = 53200310,

        [Annotation(Name = "[古龙顶端] 光辉楔形石 53200330")]
        ArchdragonPeakTwinklingTitanite = 53200330,

        [Annotation(Name = "[古龙顶端] 光辉楔形石 53200340")]
        ArchdragonPeakTwinklingTitanite_ = 53200340,

        [Annotation(Name = "[古龙顶端] 楔形石原盘 53200350")]
        ArchdragonPeakTitaniteSlab = 53200350,

        [Annotation(Name = "[古龙顶端] 大魔力防护 53200360")]
        ArchdragonPeakGreatMagicBarrier = 53200360,

        [Annotation(Name = "[古龙顶端] 楔形石原盘 53200370")]
        ArchdragonPeakTitaniteSlab_ = 53200370,

        [Annotation(Name = "[古龙顶端] 钢铁庇佑戒指 53200380")]
        ArchdragonPeakRingOfSteelProtection = 53200380,

        [Annotation(Name = "[古龙顶端] 哈维尔戒指＋1 53200500")]
        ArchdragonPeakHavelsRing1 = 53200500,

        [Annotation(Name = "[古龙顶端] 贪婪金蛇戒指＋2 53200510")]
        ArchdragonPeakCovetousGoldSerpentRing2 = 53200510,

        [Annotation(Name = "[古龙顶端] 龙鳞楔形石 53200700")]
        ArchdragonPeakTitaniteScale___ = 53200700,

        [Annotation(Name = "[古龙顶端] 光辉楔形石 53200710")]
        ArchdragonPeakTwinklingTitanite__ = 53200710,

        [Annotation(Name = "[古龙顶端] 光辉龙体石 53200900")]
        ArchdragonPeakTwinklingDragonTorsoStone = 53200900,

        [Annotation(Name = "[古龙顶端] 灾难戒指 53200910")]
        ArchdragonPeakCalamityRing = 53200910,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300000")]
        RoadOfSacrificesTitaniteShard = 53300000,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300010")]
        RoadOfSacrificesTitaniteShard_ = 53300010,

        [Annotation(Name = "[活祭品之路] 绿花草 53300020")]
        RoadOfSacrificesGreenBlossom = 53300020,

        [Annotation(Name = "[活祭品之路] 原素碎片 53300030")]
        RoadOfSacrificesEstusShard = 53300030,

        [Annotation(Name = "[活祭品之路] 牺牲戒指 53300040")]
        RoadOfSacrificesRingOfSacrifice = 53300040,

        [Annotation(Name = "[活祭品之路] 来历不明旅人的灵魂 53300050")]
        RoadOfSacrificesSoulOfanUnknownTraveler = 53300050,

        [Annotation(Name = "[活祭品之路] 亡命骑士头盔 53300060")]
        RoadOfSacrificesFallenKnightHelm = 53300060,

        [Annotation(Name = "[活祭品之路] 异端杖 53300070")]
        RoadOfSacrificesHereticsStaff = 53300070,

        [Annotation(Name = "[活祭品之路] 来历不明旅人的大块灵魂 53300080")]
        RoadOfSacrificesLargeSoulOfanUnknownTraveler = 53300080,

        [Annotation(Name = "[活祭品之路] 诅咒师风帽 53300090")]
        RoadOfSacrificesConjuratorHood = 53300090,

        [Annotation(Name = "[活祭品之路] 来历不明旅人的灵魂 53300100")]
        RoadOfSacrificesSoulOfanUnknownTraveler_ = 53300100,

        [Annotation(Name = "[活祭品之路] 绿花草 53300110")]
        RoadOfSacrificesGreenBlossom_ = 53300110,

        [Annotation(Name = "[活祭品之路] 大沼咒术书 53300120")]
        RoadOfSacrificesGreatSwampPyromancyTome = 53300120,

        [Annotation(Name = "[活祭品之路] 返回骨片 53300130")]
        RoadOfSacrificesHomewardBone = 53300130,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300140")]
        RoadOfSacrificesTitaniteShard__ = 53300140,

        [Annotation(Name = "[活祭品之路] 毒紫苔藓球 53300150")]
        RoadOfSacrificesPurpleMossClump = 53300150,

        [Annotation(Name = "[活祭品之路] 毒紫苔藓球 53300160")]
        RoadOfSacrificesPurpleMossClump_ = 53300160,

        [Annotation(Name = "[活祭品之路] 巨剑 53300170")]
        RoadOfSacrificesGreatsword = 53300170,

        [Annotation(Name = "[活祭品之路] 双龙大盾 53300180")]
        RoadOfSacrificesTwinDragonGreatshield = 53300180,

        [Annotation(Name = "[活祭品之路] 游魂宝石 53300190")]
        RoadOfSacrificesHollowGem = 53300190,

        [Annotation(Name = "[活祭品之路] 即将消逝的灵魂 53300210")]
        RoadOfSacrificesFadingSoul = 53300210,

        [Annotation(Name = "[活祭品之路] 魔法师头巾 53300220")]
        RoadOfSacrificesSorcererHood = 53300220,

        [Annotation(Name = "[活祭品之路] 老者戒指 53300230")]
        RoadOfSacrificesSageRing = 53300230,

        [Annotation(Name = "[活祭品之路] 毒紫苔藓球 53300240")]
        RoadOfSacrificesPurpleMossClump__ = 53300240,

        [Annotation(Name = "[活祭品之路] 不死人遗骨 53300270")]
        RoadOfSacrificesUndeadBoneShard = 53300270,

        [Annotation(Name = "[活祭品之路] 赎罪 53300280")]
        RoadOfSacrificesAtonement = 53300280,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300290")]
        RoadOfSacrificesTitaniteShard___ = 53300290,

        [Annotation(Name = "[活祭品之路] 铁身躯 53300300")]
        RoadOfSacrificesIronFlesh = 53300300,

        [Annotation(Name = "[活祭品之路] 草纹盾 53300310")]
        RoadOfSacrificesGrassCrestShield = 53300310,

        [Annotation(Name = "[活祭品之路] 石像圆盾 53300320")]
        RoadOfSacrificesStoneParma = 53300320,

        [Annotation(Name = "[活祭品之路] 腐败松脂 53300340")]
        RoadOfSacrificesRottenPineResin = 53300340,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300350")]
        RoadOfSacrificesTitaniteShard____ = 53300350,

        [Annotation(Name = "[活祭品之路] 锈斑金币 53300360")]
        RoadOfSacrificesRustedGoldCoin = 53300360,

        [Annotation(Name = "[活祭品之路] 无名骑士头盔 53300370")]
        RoadOfSacrificesNamelessKnightHelm = 53300370,

        [Annotation(Name = "[活祭品之路] 丧失石 53300380")]
        RoadOfSacrificesShrivingStone = 53300380,

        [Annotation(Name = "[活祭品之路] 修理光粉 53300390")]
        RoadOfSacrificesRepairPowder = 53300390,

        [Annotation(Name = "[活祭品之路] 黄金卷轴 53300400")]
        RoadOfSacrificesGoldenScroll = 53300400,

        [Annotation(Name = "[活祭品之路] 老者卷轴 53300410")]
        RoadOfSacrificesSagesScroll = 53300410,

        [Annotation(Name = "[活祭品之路] 逐梦者骨灰 53300420")]
        RoadOfSacrificesDreamchasersAshes = 53300420,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300430")]
        RoadOfSacrificesTitaniteShard_____ = 53300430,

        [Annotation(Name = "[活祭品之路] 狼血剑草 53300440")]
        RoadOfSacrificesWolfsBloodSwordgrass = 53300440,

        [Annotation(Name = "[活祭品之路] 强力魔力武器 53300450")]
        RoadOfSacrificesGreatMagicWeapon = 53300450,

        [Annotation(Name = "[活祭品之路] 余火 53300460")]
        RoadOfSacrificesEmber = 53300460,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300470")]
        RoadOfSacrificesTitaniteShard______ = 53300470,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300480")]
        RoadOfSacrificesTitaniteShard_______ = 53300480,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300490")]
        RoadOfSacrificesTitaniteShard________ = 53300490,

        [Annotation(Name = "[活祭品之路] 黑虫药丸 53300500")]
        RoadOfSacrificesBlackBugPellet = 53300500,

        [Annotation(Name = "[活祭品之路] 腐败松脂 53300510")]
        RoadOfSacrificesRottenPineResin_ = 53300510,

        [Annotation(Name = "[活祭品之路] 毒宝石 53300520")]
        RoadOfSacrificesPoisonGem = 53300520,

        [Annotation(Name = "[活祭品之路] 破布面罩 53300525")]
        RoadOfSacrificesRaggedMask = 53300525,

        [Annotation(Name = "[活祭品之路] 原素碎片 53300530")]
        RoadOfSacrificesEstusShard_ = 53300530,

        [Annotation(Name = "[活祭品之路] 返回骨片 53300535")]
        RoadOfSacrificesHomewardBone_ = 53300535,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300540")]
        RoadOfSacrificesTitaniteShard_________ = 53300540,

        [Annotation(Name = "[活祭品之路] 无名士兵的大块灵魂 53300545")]
        RoadOfSacrificesLargeSoulOfaNamelessSoldier = 53300545,

        [Annotation(Name = "[活祭品之路] 七色石 53300550")]
        RoadOfSacrificesPrismStone = 53300550,

        [Annotation(Name = "[活祭品之路] 无名士兵的大块灵魂 53300555")]
        RoadOfSacrificesLargeSoulOfaNamelessSoldier_ = 53300555,

        [Annotation(Name = "[活祭品之路] 余火 53300560")]
        RoadOfSacrificesEmber_ = 53300560,

        [Annotation(Name = "[活祭品之路] 老者余烬 53300570")]
        RoadOfSacrificesSagesCoal = 53300570,

        [Annotation(Name = "[活祭品之路] 雷枪 53300580")]
        RoadOfSacrificesLightningSpear = 53300580,

        [Annotation(Name = "[活祭品之路] 蓝虫药丸 53300590")]
        RoadOfSacrificesBlueBugPellet = 53300590,

        [Annotation(Name = "[活祭品之路] 来历不明旅人的灵魂 53300600")]
        RoadOfSacrificesSoulOfanUnknownTraveler__ = 53300600,

        [Annotation(Name = "[活祭品之路] 丧失石 53300610")]
        RoadOfSacrificesShrivingStone_ = 53300610,

        [Annotation(Name = "[活祭品之路] 楔形石碎片 53300620")]
        RoadOfSacrificesTitaniteShard__________ = 53300620,

        [Annotation(Name = "[活祭品之路] 成对山贼短刀 53300630")]
        RoadOfSacrificesBrigandTwindaggers = 53300630,

        [Annotation(Name = "[活祭品之路] 卡利姆点字圣典 53300640")]
        RoadOfSacrificesBrailleDivineTomeOfCarim = 53300640,

        [Annotation(Name = "[活祭品之路] 余火 53300650")]
        RoadOfSacrificesEmber__ = 53300650,

        [Annotation(Name = "[活祭品之路] 散装黄金松脂 53300680")]
        RoadOfSacrificesGoldPineBundle = 53300680,

        [Annotation(Name = "[活祭品之路] 余火 53300690")]
        RoadOfSacrificesEmber___ = 53300690,

        [Annotation(Name = "[活祭品之路] 无名士兵的灵魂 53300700")]
        RoadOfSacrificesSoulOfaNamelessSoldier = 53300700,

        [Annotation(Name = "[活祭品之路] 来历不明旅人的大块灵魂 53300710")]
        RoadOfSacrificesLargeSoulOfanUnknownTraveler_ = 53300710,

        [Annotation(Name = "[活祭品之路] 佣兵对刀 53300720")]
        RoadOfSacrificesSellswordTwinblades = 53300720,

        [Annotation(Name = "[活祭品之路] 金鹰小盾 53300730")]
        RoadOfSacrificesGoldenFalconShield = 53300730,

        [Annotation(Name = "[活祭品之路] 传令者头盔 53300740")]
        RoadOfSacrificesHeraldHelm = 53300740,

        [Annotation(Name = "[活祭品之路] 山贼斧 53300750")]
        RoadOfSacrificesBrigandAxe = 53300750,

        [Annotation(Name = "[活祭品之路] 山贼头巾 53300760")]
        RoadOfSacrificesBrigandHood = 53300760,

        [Annotation(Name = "[活祭品之路] 摩恩戒指 53300770")]
        RoadOfSacrificesMornesRing = 53300770,

        [Annotation(Name = "[活祭品之路] 佣兵头盔 53300780")]
        RoadOfSacrificesSellswordHelm = 53300780,

        [Annotation(Name = "[活祭品之路] 法兰余烬 53300790")]
        RoadOfSacrificesFarronCoal = 53300790,

        [Annotation(Name = "[法兰要塞] 哈维尔头盔 53300800")]
        FarronKeepHavelsHelm = 53300800,

        [Annotation(Name = "[法兰要塞] 巨斧 53300810")]
        FarronKeepGreataxe = 53300810,

        [Annotation(Name = "[法兰要塞] 斑方石戒指 53300820")]
        FarronKeepSpeckledStoneplateRing = 53300820,

        [Annotation(Name = "[法兰要塞] 余火 53300830")]
        FarronKeepEmber = 53300830,

        [Annotation(Name = "[法兰要塞] 龙图纹盾 53300840")]
        FarronKeepDragonCrestShield = 53300840,

        [Annotation(Name = "[法兰要塞] 暗方石戒指＋2 53300850")]
        FarronKeepDarkStoneplateRing2 = 53300850,

        [Annotation(Name = "[法兰要塞] 绿花戒指＋2 53300860")]
        FarronKeepChloranthyRing2 = 53300860,

        [Annotation(Name = "[法兰要塞] 伫立龙徽戒指＋1 53300870")]
        FarronKeepLingeringDragoncrestRing1 = 53300870,

        [Annotation(Name = "[法兰要塞] 魔力方石戒指＋1 53300880")]
        FarronKeepMagicStoneplateRing1 = 53300880,

        [Annotation(Name = "[法兰要塞] 狼戒指＋1 53300890")]
        FarronKeepWolfRing1 = 53300890,

        [Annotation(Name = "[法兰要塞] 古典礼服 53300940")]
        FarronKeepAntiquatedDress = 53300940,

        [Annotation(Name = "[法兰要塞] 太阳护符 53300950")]
        FarronKeepSunlightTalisman = 53300950,

        [Annotation(Name = "[法兰要塞] 嫩白树枝 53300960")]
        FarronKeepYoungWhiteBranch = 53300960,

        [Annotation(Name = "[法兰要塞] 嫩白树枝 53300970")]
        FarronKeepYoungWhiteBranch_ = 53300970,

        [Annotation(Name = "[法兰要塞] 幽暗头冠 53300980")]
        FarronKeepCrownOfDusk = 53300980,

        [Annotation(Name = "[大书库] 楔形石块 53410000")]
        GrandArchivesTitaniteChunk = 53410000,

        [Annotation(Name = "[大书库] 楔形石块 53410010")]
        GrandArchivesTitaniteChunk_ = 53410010,

        [Annotation(Name = "[大书库] 受挫骑士的灵魂 53410020")]
        GrandArchivesSoulOfaCrestfallenKnight = 53410020,

        [Annotation(Name = "[大书库] 楔形石块 53410030")]
        GrandArchivesTitaniteChunk__ = 53410030,

        [Annotation(Name = "[大书库] 咬人戒指 53410040")]
        GrandArchivesFleshbiteRing = 53410040,

        [Annotation(Name = "[大书库] 受挫骑士的灵魂 53410060")]
        GrandArchivesSoulOfaCrestfallenKnight_ = 53410060,

        [Annotation(Name = "[大书库] 无名士兵的灵魂 53410070")]
        GrandArchivesSoulOfaNamelessSoldier = 53410070,

        [Annotation(Name = "[大书库] 结晶圣铃 53410080")]
        GrandArchivesCrystalChime = 53410080,

        [Annotation(Name = "[大书库] 龙鳞楔形石 53410090")]
        GrandArchivesTitaniteScale = 53410090,

        [Annotation(Name = "[大书库] 原素碎片 53410100")]
        GrandArchivesEstusShard = 53410100,

        [Annotation(Name = "[大书库] 返回骨片 53410110")]
        GrandArchivesHomewardBone = 53410110,

        [Annotation(Name = "[大书库] 龙鳞楔形石 53410120")]
        GrandArchivesTitaniteScale_ = 53410120,

        [Annotation(Name = "[大书库] 楔形石块 53410130")]
        GrandArchivesTitaniteChunk___ = 53410130,

        [Annotation(Name = "[大书库] 游魂宝石 53410140")]
        GrandArchivesHollowGem = 53410140,

        [Annotation(Name = "[大书库] 龙鳞楔形石 53410150")]
        GrandArchivesTitaniteScale__ = 53410150,

        [Annotation(Name = "[大书库] 龙鳞楔形石 53410160")]
        GrandArchivesTitaniteScale___ = 53410160,

        [Annotation(Name = "[大书库] 龙鳞楔形石 53410180")]
        GrandArchivesTitaniteScale____ = 53410180,

        [Annotation(Name = "[大书库] 丧失石 53410200")]
        GrandArchivesShrivingStone = 53410200,

        [Annotation(Name = "[大书库] 受挫骑士的大块灵魂 53410210")]
        GrandArchivesLargeSoulOfaCrestfallenKnight = 53410210,

        [Annotation(Name = "[大书库] 楔形石块 53410220")]
        GrandArchivesTitaniteChunk____ = 53410220,

        [Annotation(Name = "[大书库] 龙鳞楔形石 53410240")]
        GrandArchivesTitaniteScale_____ = 53410240,

        [Annotation(Name = "[大书库] 楔形石块 53410250")]
        GrandArchivesTitaniteChunk_____ = 53410250,

        [Annotation(Name = "[大书库] 竭力战士的灵魂 53410260")]
        GrandArchivesSoulOfaWearyWarrior = 53410260,

        [Annotation(Name = "[大书库] 楔形石块 53410280")]
        GrandArchivesTitaniteChunk______ = 53410280,

        [Annotation(Name = "[大书库] 余火 53410290")]
        GrandArchivesEmber = 53410290,

        [Annotation(Name = "[大书库] 祝福宝石 53410300")]
        GrandArchivesBlessedGem = 53410300,

        [Annotation(Name = "[大书库] 楔形石块 53410320")]
        GrandArchivesTitaniteChunk_______ = 53410320,

        [Annotation(Name = "[大书库] 受挫骑士的大块灵魂 53410330")]
        GrandArchivesLargeSoulOfaCrestfallenKnight_ = 53410330,

        [Annotation(Name = "[大书库] 雅帆琳 53410350")]
        GrandArchivesAvelyn = 53410350,

        [Annotation(Name = "[大书库] 楔形石块 53410360")]
        GrandArchivesTitaniteChunk________ = 53410360,

        [Annotation(Name = "[大书库] 猎人戒指 53410370")]
        GrandArchivesHuntersRing = 53410370,

        [Annotation(Name = "[大书库] 天使光柱 53410380")]
        GrandArchivesDivinePillarsOfLight = 53410380,

        [Annotation(Name = "[大书库] 楔形石块 53410410")]
        GrandArchivesTitaniteChunk_________ = 53410410,

        [Annotation(Name = "[大书库] 内在潜力 53410420")]
        GrandArchivesPowerWithin = 53410420,

        [Annotation(Name = "[大书库] 老者戒指＋1 53410450")]
        GrandArchivesSageRing1 = 53410450,

        [Annotation(Name = "[大书库] 伫立龙徽戒指＋2 53410470")]
        GrandArchivesLingeringDragoncrestRing2 = 53410470,

        [Annotation(Name = "[大书库] 女神的祝福 53410500")]
        GrandArchivesDivineBlessing = 53410500,

        [Annotation(Name = "[大书库] 光辉楔形石 53410510")]
        GrandArchivesTwinklingTitanite = 53410510,

        [Annotation(Name = "[大书库] 魔女黑发 53410520")]
        GrandArchivesWitchsLocks = 53410520,

        [Annotation(Name = "[大书库] 楔形石原盘 53410530")]
        GrandArchivesTitaniteSlab = 53410530,

        [Annotation(Name = "[大书库] 龙鳞楔形石 53410540")]
        GrandArchivesTitaniteScale______ = 53410540,

        [Annotation(Name = "[大书库] 灵魂激流 53410600")]
        GrandArchivesSoulStream = 53410600,

        [Annotation(Name = "[大书库] 贤者戒指 53410610")]
        GrandArchivesScholarRing = 53410610,

        [Annotation(Name = "[大书库] 不死人遗骨 53410620")]
        GrandArchivesUndeadBoneShard = 53410620,

        [Annotation(Name = "[幽邃教堂] 荆棘软鞭 53500000")]
        CathedralOfTheDeepNotchedWhip = 53500000,

        [Annotation(Name = "[幽邃教堂] 楔形石碎片 53500010")]
        CathedralOfTheDeepTitaniteShard = 53500010,

        [Annotation(Name = "[幽邃教堂] 亚斯特拉大剑 53500020")]
        CathedralOfTheDeepAstoraGreatsword = 53500020,

        [Annotation(Name = "[幽邃教堂] 处刑者大剑 53500030")]
        CathedralOfTheDeepExecutionersGreatsword = 53500030,

        [Annotation(Name = "[幽邃教堂] 不死人遗骨 53500040")]
        CathedralOfTheDeepUndeadBoneShard = 53500040,

        [Annotation(Name = "[幽邃教堂] 抗咒大盾 53500050")]
        CathedralOfTheDeepCurseWardGreatshield = 53500050,

        [Annotation(Name = "[幽邃教堂] 楔形石碎片 53500060")]
        CathedralOfTheDeepTitaniteShard_ = 53500060,

        [Annotation(Name = "[幽邃教堂] 来历不明旅人的大块灵魂 53500070")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler = 53500070,

        [Annotation(Name = "[幽邃教堂] 圣骑士骨灰 53500080")]
        CathedralOfTheDeepPaladinsAshes = 53500080,

        [Annotation(Name = "[幽邃教堂] 亚伯里斯 53500090")]
        CathedralOfTheDeepArbalest = 53500090,

        [Annotation(Name = "[幽邃教堂] 余火 53500110")]
        CathedralOfTheDeepEmber = 53500110,

        [Annotation(Name = "[幽邃教堂] 余火 53500130")]
        CathedralOfTheDeepEmber_ = 53500130,

        [Annotation(Name = "[幽邃教堂] 咬毒戒指 53500140")]
        CathedralOfTheDeepPoisonbiteRing = 53500140,

        [Annotation(Name = "[幽邃教堂] 多兰铠甲 53500150")]
        CathedralOfTheDeepDrangArmor = 53500150,

        [Annotation(Name = "[幽邃教堂] 余火 53500160")]
        CathedralOfTheDeepEmber__ = 53500160,

        [Annotation(Name = "[幽邃教堂] 决斗护符 53500170")]
        CathedralOfTheDeepDuelCharm = 53500170,

        [Annotation(Name = "[幽邃教堂] 寻求建言 53500180")]
        CathedralOfTheDeepSeekGuidance = 53500180,

        [Annotation(Name = "[幽邃教堂] 原素碎片 53500200")]
        CathedralOfTheDeepEstusShard = 53500200,

        [Annotation(Name = "[幽邃教堂] 圣女风帽 53500210")]
        CathedralOfTheDeepMaidenHood = 53500210,

        [Annotation(Name = "[幽邃教堂] 发青舌头 53500220")]
        CathedralOfTheDeepPaleTongue = 53500220,

        [Annotation(Name = "[幽邃教堂] 即将消逝的灵魂 53500230")]
        CathedralOfTheDeepFadingSoul = 53500230,

        [Annotation(Name = "[幽邃教堂] 祝福宝石 53500240")]
        CathedralOfTheDeepBlessedGem = 53500240,

        [Annotation(Name = "[幽邃教堂] 红虫药丸 53500260")]
        CathedralOfTheDeepRedBugPellet = 53500260,

        [Annotation(Name = "[幽邃教堂] 无名士兵的灵魂 53500270")]
        CathedralOfTheDeepSoulOfaNamelessSoldier = 53500270,

        [Annotation(Name = "[幽邃教堂] 决斗护符 53500280")]
        CathedralOfTheDeepDuelCharm_ = 53500280,

        [Annotation(Name = "[幽邃教堂] 来历不明旅人的大块灵魂 53500300")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler_ = 53500300,

        [Annotation(Name = "[幽邃教堂] 余火 53500310")]
        CathedralOfTheDeepEmber___ = 53500310,

        [Annotation(Name = "[幽邃教堂] 修理光粉 53500320")]
        CathedralOfTheDeepRepairPowder = 53500320,

        [Annotation(Name = "[幽邃教堂] 来历不明旅人的大块灵魂 53500330")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler__ = 53500330,

        [Annotation(Name = "[幽邃教堂] 来历不明旅人的大块灵魂 53500340")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler___ = 53500340,

        [Annotation(Name = "[幽邃教堂] 猎捕不死人护符 53500370")]
        CathedralOfTheDeepUndeadHunterCharm = 53500370,

        [Annotation(Name = "[幽邃教堂] 红虫药丸 53500380")]
        CathedralOfTheDeepRedBugPellet_ = 53500380,

        [Annotation(Name = "[幽邃教堂] 楔形石碎片 53500390")]
        CathedralOfTheDeepTitaniteShard__ = 53500390,

        [Annotation(Name = "[幽邃教堂] 楔形石碎片 53500400")]
        CathedralOfTheDeepTitaniteShard___ = 53500400,

        [Annotation(Name = "[幽邃教堂] 锈斑硬币 53500420")]
        CathedralOfTheDeepRustedCoin = 53500420,

        [Annotation(Name = "[幽邃教堂] 多兰对槌 53500430")]
        CathedralOfTheDeepDrangHammers = 53500430,

        [Annotation(Name = "[幽邃教堂] 多兰靴子 53500450")]
        CathedralOfTheDeepDrangShoes = 53500450,

        [Annotation(Name = "[幽邃教堂] 来历不明旅人的大块灵魂 53500460")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler____ = 53500460,

        [Annotation(Name = "[幽邃教堂] 发青舌头 53500470")]
        CathedralOfTheDeepPaleTongue_ = 53500470,

        [Annotation(Name = "[幽邃教堂] 多兰护手 53500480")]
        CathedralOfTheDeepDrangGauntlets = 53500480,

        [Annotation(Name = "[幽邃教堂] 无名士兵的灵魂 53500490")]
        CathedralOfTheDeepSoulOfaNamelessSoldier_ = 53500490,

        [Annotation(Name = "[幽邃教堂] 刺针头盔 53500500")]
        CathedralOfTheDeepHelmOfThorns = 53500500,

        [Annotation(Name = "[幽邃教堂] 爆裂弩箭 53500540")]
        CathedralOfTheDeepExplodingBolt = 53500540,

        [Annotation(Name = "[幽邃教堂] 洛伊德剑徽戒指 53500550")]
        CathedralOfTheDeepLloydsSwordRing = 53500550,

        [Annotation(Name = "[幽邃教堂] 无名士兵的灵魂 53500560")]
        CathedralOfTheDeepSoulOfaNamelessSoldier__ = 53500560,

        [Annotation(Name = "[幽邃教堂] 返回骨片 53500620")]
        CathedralOfTheDeepHomewardBone = 53500620,

        [Annotation(Name = "[幽邃教堂] 幽邃宝石 53500630")]
        CathedralOfTheDeepDeepGem = 53500630,

        [Annotation(Name = "[幽邃教堂] 楔形石碎片 53500680")]
        CathedralOfTheDeepTitaniteShard____ = 53500680,

        [Annotation(Name = "[幽邃教堂] 来历不明旅人的大块灵魂 53500690")]
        CathedralOfTheDeepLargeSoulOfanUnknownTraveler_____ = 53500690,

        [Annotation(Name = "[幽邃教堂] 邪眼戒指＋1 53500800")]
        CathedralOfTheDeepRingOfTheEvilEye1 = 53500800,

        [Annotation(Name = "[幽邃教堂] 宠爱戒指＋2 53500810")]
        CathedralOfTheDeepRingOfFavor2 = 53500810,

        [Annotation(Name = "[幽邃教堂] 图纹盾 53500850")]
        CathedralOfTheDeepCrestShield = 53500850,

        [Annotation(Name = "[幽邃教堂] 嫩白树枝 53500860")]
        CathedralOfTheDeepYoungWhiteBranch = 53500860,

        [Annotation(Name = "[幽邃教堂] 嫩白树枝 53500870")]
        CathedralOfTheDeepYoungWhiteBranch_ = 53500870,

        [Annotation(Name = "[幽邃教堂] 神木铃草 53500880")]
        CathedralOfTheDeepSainttreeBellvine = 53500880,

        [Annotation(Name = "[幽邃教堂] 圣者双叉枪 53500890")]
        CathedralOfTheDeepSaintBident = 53500890,

        [Annotation(Name = "[幽邃教堂] 大主教白冠 53500950")]
        CathedralOfTheDeepArchdeaconWhiteCrown = 53500950,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600000")]
        LargeSoulOfanUnknownTraveler = 53600000,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600010")]
        LargeSoulOfanUnknownTraveler_ = 53600010,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600020")]
        LargeSoulOfanUnknownTraveler__ = 53600020,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600030")]
        LargeSoulOfanUnknownTraveler___ = 53600030,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600040")]
        LargeSoulOfanUnknownTraveler____ = 53600040,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600050")]
        LargeSoulOfanUnknownTraveler_____ = 53600050,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600060")]
        LargeSoulOfanUnknownTraveler______ = 53600060,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600070")]
        LargeSoulOfanUnknownTraveler_______ = 53600070,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600080")]
        LargeSoulOfanUnknownTraveler________ = 53600080,

        [Annotation(Name = "来历不明旅人的大块灵魂 53600090")]
        LargeSoulOfanUnknownTraveler_________ = 53600090,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 克雷顿铁面罩 53700000")]
        IrithyllCreightonsSteelMask = 53700000,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 返回骨片 53700010")]
        IrithyllHomewardBone = 53700010,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 无名士兵的大块灵魂 53700020")]
        IrithyllLargeSoulOfaNamelessSoldier = 53700020,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700030")]
        IrithyllLargeTitaniteShard = 53700030,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 竭力战士的灵魂 53700040")]
        IrithyllSoulOfaWearyWarrior = 53700040,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 竭力战士的灵魂 53700050")]
        IrithyllSoulOfaWearyWarrior_ = 53700050,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 蓝冻苔藓球 53700060")]
        IrithyllRimeblueMossClump = 53700060,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 妖树枝条 53700070")]
        IrithyllWitchtreeBranch = 53700070,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700080")]
        IrithyllLargeTitaniteShard_ = 53700080,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 原素碎片 53700090")]
        IrithyllEstusShard = 53700090,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 开花绿花草 53700100")]
        IrithyllBuddingGreenBlossom = 53700100,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 蓝冻苔藓球 53700110")]
        IrithyllRimeblueMossClump_ = 53700110,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700120")]
        IrithyllLargeTitaniteShard__ = 53700120,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700130")]
        IrithyllLargeTitaniteShard___ = 53700130,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 太阳长男戒指 53700140")]
        IrithyllRingOfTheSunsFirstBorn = 53700140,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 无名士兵的大块灵魂 53700150")]
        IrithyllLargeSoulOfaNamelessSoldier_ = 53700150,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700160")]
        IrithyllLargeTitaniteShard____ = 53700160,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700170")]
        IrithyllLargeTitaniteShard_____ = 53700170,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 竭力战士的灵魂 53700180")]
        IrithyllSoulOfaWearyWarrior__ = 53700180,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 魔力怪手戒指 53700190")]
        IrithyllMagicClutchRing = 53700190,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 即将消逝的灵魂 53700200")]
        IrithyllFadingSoul = 53700200,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 即将消逝的灵魂 53700210")]
        IrithyllFadingSoul_ = 53700210,

        [Annotation(Name = "[亚诺尔隆德] 绘画使者曲剑 53700220")]
        AnorLondoPaintingGuardiansCurvedSword = 53700220,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 返回骨片 53700230")]
        IrithyllHomewardBone_ = 53700230,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 不死人遗骨 53700240")]
        IrithyllUndeadBoneShard = 53700240,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 廓尔喀弯刀 53700250")]
        IrithyllKukri = 53700250,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 锈斑金币 53700260")]
        IrithyllRustedGoldCoin = 53700260,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 黄铜头盔 53700270")]
        IrithyllBrassHelm = 53700270,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 蓝虫药丸 53700280")]
        IrithyllBlueBugPellet = 53700280,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 丧失石 53700290")]
        IrithyllShrivingStone = 53700290,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 人心沉淀物 53700300")]
        IrithyllHumanDregs = 53700300,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 骑士名簿 6782")]
        IrithyllRosterOfKnights = 6782,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 血宝石 53700320")]
        IrithyllBloodGem = 53700320,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 绿花草 53700330")]
        IrithyllGreenBlossom = 53700330,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 牺牲戒指 53700340")]
        IrithyllRingOfSacrifice = 53700340,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 大恢复 53700350")]
        IrithyllGreatHeal = 53700350,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 无名士兵的大块灵魂 53700360")]
        IrithyllLargeSoulOfaNamelessSoldier__ = 53700360,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 绿花草 53700370")]
        IrithyllGreenBlossom_ = 53700370,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 屎块 53700380")]
        IrithyllDungPie = 53700380,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 屎块 53700390")]
        IrithyllDungPie_ = 53700390,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 沾屎骨灰 53700400")]
        IrithyllExcrementcoveredAshes = 53700400,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 余火 53700410")]
        IrithyllEmber = 53700410,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700420")]
        IrithyllLargeTitaniteShard______ = 53700420,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 无名士兵的大块灵魂 53700430")]
        IrithyllLargeSoulOfaNamelessSoldier___ = 53700430,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 竭力战士的灵魂 53700440")]
        IrithyllSoulOfaWearyWarrior___ = 53700440,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700450")]
        IrithyllLargeTitaniteShard_______ = 53700450,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 蓝虫药丸 53700460")]
        IrithyllBlueBugPellet_ = 53700460,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 余火 53700470")]
        IrithyllEmber_ = 53700470,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700480")]
        IrithyllLargeTitaniteShard________ = 53700480,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700490")]
        IrithyllLargeTitaniteShard_________ = 53700490,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 竭力战士的灵魂 53700500")]
        IrithyllSoulOfaWearyWarrior____ = 53700500,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 余火 53700510")]
        IrithyllEmber__ = 53700510,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 余火 53700520")]
        IrithyllEmber___ = 53700520,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700530")]
        IrithyllLargeTitaniteShard__________ = 53700530,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 暗方石戒指 53700540")]
        IrithyllDarkStoneplateRing = 53700540,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 楔形石大碎片 53700550")]
        IrithyllLargeTitaniteShard___________ = 53700550,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 绿花草 53700560")]
        IrithyllGreenBlossom__ = 53700560,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 幽邃宝石 53700600")]
        IrithyllDeepGem = 53700600,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 龙鳞楔形石 53700610")]
        IrithyllTitaniteScale = 53700610,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 猎龙大弓 53700620")]
        IrithyllDragonslayerGreatbow = 53700620,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 东方人骨灰 53700630")]
        IrithyllEasternersAshes = 53700630,

        [Annotation(Name = "[亚诺尔隆德] 绘画使者头巾 53700640")]
        AnorLondoPaintingGuardianHood = 53700640,

        [Annotation(Name = "[亚诺尔隆德] 受挫骑士的灵魂 53700660")]
        AnorLondoSoulOfaCrestfallenKnight = 53700660,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 雷电宝石 53700670")]
        IrithyllLightningGem = 53700670,

        [Annotation(Name = "[亚诺尔隆德] 月光箭 53700690")]
        AnorLondoMoonlightArrow = 53700690,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 约定之证 53700700")]
        IrithyllProofOfaConcordKept = 53700700,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 无名士兵的大块灵魂 53700720")]
        IrithyllLargeSoulOfaNamelessSoldier____ = 53700720,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 竭力战士的灵魂 53700740")]
        IrithyllSoulOfaWearyWarrior_____ = 53700740,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 约定之证 53700750")]
        IrithyllProofOfaConcordKept_ = 53700750,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 锈斑金币 53700760")]
        IrithyllRustedGoldCoin_ = 53700760,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 竭力战士的大块灵魂 53700770")]
        IrithyllLargeSoulOfaWearyWarrior = 53700770,

        [Annotation(Name = "[亚诺尔隆德] 巨人余烬 53700800")]
        AnorLondoGiantsCoal = 53700800,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 绿花戒指＋1 53700810")]
        IrithyllChloranthyRing1 = 53700810,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 哈维尔戒指＋2 53700820")]
        IrithyllHavelsRing2 = 53700820,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 宠爱戒指＋1 53700830")]
        IrithyllRingOfFavor1 = 53700830,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 太阳公主戒指 53700840")]
        IrithyllSunPrincessRing = 53700840,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 贪婪金蛇戒指＋1 53700850")]
        IrithyllCovetousGoldSerpentRing1 = 53700850,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 木纹戒指＋2 53700860")]
        IrithyllWoodGrainRing2 = 53700860,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 女神的祝福 53700900")]
        IrithyllDivineBlessing = 53700900,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 斯摩的锤子 53700920")]
        IrithyllSmoughsGreatHammer = 53700920,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 化生戒指 53700940")]
        IrithyllReversalRing = 53700940,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] 幽儿希卡枪 53700950")]
        IrithyllYorshkasSpear = 53700950,

        [Annotation(Name = "[冷冽谷的伊鲁席尔] Leo Ring 53700960")]
        IrithyllLeoRing = 53700960,

        [Annotation(Name = "[卡萨斯的地下墓地] 卡萨斯红刀 53800000")]
        CatacombsOfCarthusCarthusRouge = 53800000,

        [Annotation(Name = "[卡萨斯的地下墓地] 锋利宝石 53800010")]
        CatacombsOfCarthusSharpGem = 53800010,

        [Annotation(Name = "[卡萨斯的地下墓地] 无名士兵的灵魂 53800020")]
        CatacombsOfCarthusSoulOfaNamelessSoldier = 53800020,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石碎片 53800030")]
        CatacombsOfCarthusTitaniteShard = 53800030,

        [Annotation(Name = "[卡萨斯的地下墓地] 血红苔藓球 53800040")]
        CatacombsOfCarthusBloodredMossClump = 53800040,

        [Annotation(Name = "[卡萨斯的地下墓地] 卡萨斯乳白戒指 53800050")]
        CatacombsOfCarthusCarthusMilkring = 53800050,

        [Annotation(Name = "[卡萨斯的地下墓地] 余火 53800060")]
        CatacombsOfCarthusEmber = 53800060,

        [Annotation(Name = "[卡萨斯的地下墓地] 卡萨斯红刀 53800070")]
        CatacombsOfCarthusCarthusRouge_ = 53800070,

        [Annotation(Name = "[卡萨斯的地下墓地] 余火 53800080")]
        CatacombsOfCarthusEmber_ = 53800080,

        [Annotation(Name = "[卡萨斯的地下墓地] 卡萨斯血环 53800090")]
        CatacombsOfCarthusCarthusBloodring = 53800090,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石碎片 53800100")]
        CatacombsOfCarthusTitaniteShard_ = 53800100,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石碎片 53800110")]
        CatacombsOfCarthusTitaniteShard__ = 53800110,

        [Annotation(Name = "[卡萨斯的地下墓地] 余火 53800120")]
        CatacombsOfCarthusEmber__ = 53800120,

        [Annotation(Name = "[卡萨斯的地下墓地] 卡萨斯咒术书 53800130")]
        CatacombsOfCarthusCarthusPyromancyTome = 53800130,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800140")]
        CatacombsOfCarthusLargeTitaniteShard = 53800140,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800150")]
        CatacombsOfCarthusLargeTitaniteShard_ = 53800150,

        [Annotation(Name = "[卡萨斯的地下墓地] 黄虫药丸 53800160")]
        CatacombsOfCarthusYellowBugPellet = 53800160,

        [Annotation(Name = "[卡萨斯的地下墓地] 无名士兵的大块灵魂 53800170")]
        CatacombsOfCarthusLargeSoulOfaNamelessSoldier = 53800170,

        [Annotation(Name = "[卡萨斯的地下墓地] 黑虫药丸 53800180")]
        CatacombsOfCarthusBlackBugPellet = 53800180,

        [Annotation(Name = "[卡萨斯的地下墓地] 守墓人骨灰 53800190")]
        CatacombsOfCarthusGraveWardensAshes = 53800190,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800200")]
        CatacombsOfCarthusLargeTitaniteShard__ = 53800200,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800210")]
        CatacombsOfCarthusLargeTitaniteShard___ = 53800210,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800220")]
        CatacombsOfCarthusLargeTitaniteShard____ = 53800220,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800230")]
        CatacombsOfCarthusLargeTitaniteShard_____ = 53800230,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800240")]
        CatacombsOfCarthusLargeTitaniteShard______ = 53800240,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800250")]
        CatacombsOfCarthusLargeTitaniteShard_______ = 53800250,

        [Annotation(Name = "[卡萨斯的地下墓地] 黄虫药丸 53800260")]
        CatacombsOfCarthusYellowBugPellet_ = 53800260,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800270")]
        CatacombsOfCarthusLargeTitaniteShard________ = 53800270,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800280")]
        CatacombsOfCarthusLargeTitaniteShard_________ = 53800280,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800290")]
        CatacombsOfCarthusLargeTitaniteShard__________ = 53800290,

        [Annotation(Name = "[卡萨斯的地下墓地] 斑方石戒指 53800300")]
        CatacombsOfCarthusSpeckledStoneplateRing = 53800300,

        [Annotation(Name = "[卡萨斯的地下墓地] 返回骨片 53800310")]
        CatacombsOfCarthusHomewardBone = 53800310,

        [Annotation(Name = "[卡萨斯的地下墓地] 余火 53800330")]
        CatacombsOfCarthusEmber___ = 53800330,

        [Annotation(Name = "[卡萨斯的地下墓地] 混沌宝石 53800340")]
        CatacombsOfCarthusChaosGem = 53800340,

        [Annotation(Name = "[卡萨斯的地下墓地] 余火 53800350")]
        CatacombsOfCarthusEmber____ = 53800350,

        [Annotation(Name = "[卡萨斯的地下墓地] 伊札里斯咒术书 53800360")]
        CatacombsOfCarthusIzalithPyromancyTome = 53800360,

        [Annotation(Name = "[卡萨斯的地下墓地] 黑骑士剑 53800370")]
        CatacombsOfCarthusBlackKnightSword = 53800370,

        [Annotation(Name = "[卡萨斯的地下墓地] 无名士兵的大块灵魂 53800380")]
        CatacombsOfCarthusLargeSoulOfaNamelessSoldier_ = 53800380,

        [Annotation(Name = "[卡萨斯的地下墓地] 师长遮眼布 53800390")]
        CatacombsOfCarthusOldSagesBlindfold = 53800390,

        [Annotation(Name = "[卡萨斯的地下墓地] 余火 53800400")]
        CatacombsOfCarthusEmber_____ = 53800400,

        [Annotation(Name = "[卡萨斯的地下墓地] 克拉娜的咒术书 53800410")]
        CatacombsOfCarthusQuelanaPyromancyTome = 53800410,

        [Annotation(Name = "[卡萨斯的地下墓地] 伊札里斯杖 53800420")]
        CatacombsOfCarthusIzalithStaff = 53800420,

        [Annotation(Name = "[卡萨斯的地下墓地] 白发护符 53800430")]
        CatacombsOfCarthusWhiteHairTalisman = 53800430,

        [Annotation(Name = "[卡萨斯的地下墓地] 猛毒雾 53800440")]
        CatacombsOfCarthusToxicMist = 53800440,

        [Annotation(Name = "[卡萨斯的地下墓地] 不死人遗骨 53800450")]
        CatacombsOfCarthusUndeadBoneShard = 53800450,

        [Annotation(Name = "[卡萨斯的地下墓地] 龙鳞楔形石 53800460")]
        CatacombsOfCarthusTitaniteScale = 53800460,

        [Annotation(Name = "[卡萨斯的地下墓地] 无名士兵的灵魂 53800470")]
        CatacombsOfCarthusSoulOfaNamelessSoldier_ = 53800470,

        [Annotation(Name = "[卡萨斯的地下墓地] 守墓人咒术书 53800500")]
        CatacombsOfCarthusGraveWardenPyromancyTome = 53800500,

        [Annotation(Name = "[卡萨斯的地下墓地] 渴望盾 53800520")]
        CatacombsOfCarthusShieldOfWant = 53800520,

        [Annotation(Name = "[卡萨斯的地下墓地] 受挫骑士的灵魂 53800530")]
        CatacombsOfCarthusSoulOfaCrestfallenKnight = 53800530,

        [Annotation(Name = "[卡萨斯的地下墓地] 余火 53800540")]
        CatacombsOfCarthusEmber______ = 53800540,

        [Annotation(Name = "[卡萨斯的地下墓地] 净化火焰 53800560")]
        CatacombsOfCarthusSacredFlame = 53800560,

        [Annotation(Name = "[卡萨斯的地下墓地] 来历不明旅人的大块灵魂 53800570")]
        CatacombsOfCarthusLargeSoulOfanUnknownTraveler = 53800570,

        [Annotation(Name = "[卡萨斯的地下墓地] 龙骑兵弓 53800580")]
        CatacombsOfCarthusDragonriderBow = 53800580,

        [Annotation(Name = "[卡萨斯的地下墓地] 原素碎片 53800590")]
        CatacombsOfCarthusEstusShard = 53800590,

        [Annotation(Name = "[卡萨斯的地下墓地] 钢铁庇佑戒指＋2 53800600")]
        CatacombsOfCarthusRingOfSteelProtection2 = 53800600,

        [Annotation(Name = "[卡萨斯的地下墓地] 雷方石戒指＋1 53800610")]
        CatacombsOfCarthusThunderStoneplateRing1 = 53800610,

        [Annotation(Name = "[卡萨斯的地下墓地] 咬血戒指＋1 53800620")]
        CatacombsOfCarthusBloodbiteRing1 = 53800620,

        [Annotation(Name = "[卡萨斯的地下墓地] 火方石戒指＋2 53800630")]
        CatacombsOfCarthusFlameStoneplateRing2 = 53800630,

        [Annotation(Name = "[卡萨斯的地下墓地] 楔形石大碎片 53800760")]
        CatacombsOfCarthusLargeTitaniteShard___________ = 53800760,

        [Annotation(Name = "[卡萨斯的地下墓地] 不死人遗骨 53800900")]
        CatacombsOfCarthusUndeadBoneShard_ = 53800900,

        [Annotation(Name = "[卡萨斯的地下墓地] 暗宝石 53800910")]
        CatacombsOfCarthusDarkGem = 53800910,

        [Annotation(Name = "[伊鲁席尔地下监牢] 楔形石大碎片 53900000")]
        IrithyllDungeonLargeTitaniteShard = 53900000,

        [Annotation(Name = "[伊鲁席尔地下监牢] 即将消逝的灵魂 53900010")]
        IrithyllDungeonFadingSoul = 53900010,

        [Annotation(Name = "[伊鲁席尔地下监牢] 无名士兵的大块灵魂 53900030")]
        IrithyllDungeonLargeSoulOfaNamelessSoldier = 53900030,

        [Annotation(Name = "[伊鲁席尔地下监牢] 窗栏的钥匙 53900040")]
        IrithyllDungeonJailbreakersKey = 53900040,

        [Annotation(Name = "[伊鲁席尔地下监牢] 青白色松脂 53900050")]
        IrithyllDungeonPalePineResin = 53900050,

        [Annotation(Name = "[伊鲁席尔地下监牢] 愚人宝石 53900060")]
        IrithyllDungeonSimpleGem = 53900060,

        [Annotation(Name = "[伊鲁席尔地下监牢] 无名士兵的大块灵魂 53900070")]
        IrithyllDungeonLargeSoulOfaNamelessSoldier_ = 53900070,

        [Annotation(Name = "[伊鲁席尔地下监牢] 楔形石大碎片 53900080")]
        IrithyllDungeonLargeTitaniteShard_ = 53900080,

        [Annotation(Name = "[伊鲁席尔地下监牢] 返回骨片 53900090")]
        IrithyllDungeonHomewardBone = 53900090,

        [Annotation(Name = "[伊鲁席尔地下监牢] 狂吼龙徽戒指 53900100")]
        IrithyllDungeonBellowingDragoncrestRing = 53900100,

        [Annotation(Name = "[伊鲁席尔地下监牢] 竭力战士的灵魂 53900110")]
        IrithyllDungeonSoulOfaWearyWarrior = 53900110,

        [Annotation(Name = "[伊鲁席尔地下监牢] 受挫骑士的灵魂 53900120")]
        IrithyllDungeonSoulOfaCrestfallenKnight = 53900120,

        [Annotation(Name = "[伊鲁席尔地下监牢] 亚瓦头盔 53900130")]
        IrithyllDungeonAlvaHelm = 53900130,

        [Annotation(Name = "[伊鲁席尔地下监牢] 雷弩箭 53900140")]
        IrithyllDungeonLightningBolt = 53900140,

        [Annotation(Name = "[伊鲁席尔地下监牢] 楔形石大碎片 53900150")]
        IrithyllDungeonLargeTitaniteShard__ = 53900150,

        [Annotation(Name = "[伊鲁席尔地下监牢] 罪业火焰 53900160")]
        IrithyllDungeonProfanedFlame = 53900160,

        [Annotation(Name = "[伊鲁席尔地下监牢] 楔形石大碎片 53900180")]
        IrithyllDungeonLargeTitaniteShard___ = 53900180,

        [Annotation(Name = "[伊鲁席尔地下监牢] 竭力战士的灵魂 53900190")]
        IrithyllDungeonSoulOfaWearyWarrior_ = 53900190,

        [Annotation(Name = "[伊鲁席尔地下监牢] 屎块 53900200")]
        IrithyllDungeonDungPie = 53900200,

        [Annotation(Name = "[伊鲁席尔地下监牢] 解咒石 53900210")]
        IrithyllDungeonPurgingStone = 53900210,

        [Annotation(Name = "[伊鲁席尔地下监牢] 余火 53900220")]
        IrithyllDungeonEmber = 53900220,

        [Annotation(Name = "[伊鲁席尔地下监牢] 余火 53900230")]
        IrithyllDungeonEmber_ = 53900230,

        [Annotation(Name = "[伊鲁席尔地下监牢] 罪业余烬 53900240")]
        IrithyllDungeonProfanedCoal = 53900240,

        [Annotation(Name = "[伊鲁席尔地下监牢] 楔形石大碎片 53900250")]
        IrithyllDungeonLargeTitaniteShard____ = 53900250,

        [Annotation(Name = "[伊鲁席尔地下监牢] 古老魔法师帽子 53900260")]
        IrithyllDungeonOldSorcererHat = 53900260,

        [Annotation(Name = "[伊鲁席尔地下监牢] 竭力战士的大块灵魂 53900270")]
        IrithyllDungeonLargeSoulOfaWearyWarrior = 53900270,

        [Annotation(Name = "[罪业之都] 锈斑硬币 53900280")]
        ProfanedCapitalRustedCoin = 53900280,

        [Annotation(Name = "[罪业之都] 锈斑金币 53900290")]
        ProfanedCapitalRustedGoldCoin = 53900290,

        [Annotation(Name = "[罪业之都] 解咒石 53900300")]
        ProfanedCapitalPurgingStone = 53900300,

        [Annotation(Name = "[罪业之都] 咬咒戒指 53900310")]
        ProfanedCapitalCursebiteRing = 53900310,

        [Annotation(Name = "[罪业之都] 毒宝石 53900320")]
        ProfanedCapitalPoisonGem = 53900320,

        [Annotation(Name = "[罪业之都] 丧失石 53900330")]
        ProfanedCapitalShrivingStone = 53900330,

        [Annotation(Name = "[罪业之都] 毒箭 53900340")]
        ProfanedCapitalPoisonArrow = 53900340,

        [Annotation(Name = "[罪业之都] 垃圾残渣 53900350")]
        ProfanedCapitalRubbish = 53900350,

        [Annotation(Name = "[罪业之都] 伐鬼大箭 53900360")]
        ProfanedCapitalOnislayerGreatarrow = 53900360,

        [Annotation(Name = "[罪业之都] 竭力战士的大块灵魂 53900370")]
        ProfanedCapitalLargeSoulOfaWearyWarrior = 53900370,

        [Annotation(Name = "[罪业之都] 锈斑硬币 53900380")]
        ProfanedCapitalRustedCoin_ = 53900380,

        [Annotation(Name = "[罪业之都] 锈斑硬币 53900390")]
        ProfanedCapitalRustedCoin__ = 53900390,

        [Annotation(Name = "[罪业之都] 贪婪金蛇戒指 53900400")]
        ProfanedCapitalCovetousGoldSerpentRing = 53900400,

        [Annotation(Name = "[罪业之都] 毒紫花苔藓球 53900410")]
        ProfanedCapitalBloomingPurpleMossClump = 53900410,

        [Annotation(Name = "[罪业之都] 诸神之怒 53900420")]
        ProfanedCapitalWrathOfTheGods = 53900420,

        [Annotation(Name = "[伊鲁席尔地下监牢] 雷电剑 53900430")]
        IrithyllDungeonLightningBlade = 53900430,

        [Annotation(Name = "[伊鲁席尔地下监牢] 楔形石大碎片 53900440")]
        IrithyllDungeonLargeTitaniteShard_____ = 53900440,

        [Annotation(Name = "[伊鲁席尔地下监牢] 锈斑硬币 53900450")]
        IrithyllDungeonRustedCoin = 53900450,

        [Annotation(Name = "[伊鲁席尔地下监牢] 幽暗宝冠戒指 53900460")]
        IrithyllDungeonDuskCrownRing = 53900460,

        [Annotation(Name = "[伊鲁席尔地下监牢] 十字镐 53900470")]
        IrithyllDungeonPickaxe = 53900470,

        [Annotation(Name = "[伊鲁席尔地下监牢] 研究者骨灰 53900480")]
        IrithyllDungeonXanthousAshes = 53900480,

        [Annotation(Name = "[伊鲁席尔地下监牢] 伐鬼大弓 53900490")]
        IrithyllDungeonOnislayerGreatbow = 53900490,

        [Annotation(Name = "[伊鲁席尔地下监牢] 锈斑金币 53900500")]
        IrithyllDungeonRustedGoldCoin = 53900500,

        [Annotation(Name = "[伊鲁席尔地下监牢] 楔形石大碎片 53900510")]
        IrithyllDungeonLargeTitaniteShard______ = 53900510,

        [Annotation(Name = "[伊鲁席尔地下监牢] 狱卒的钥匙 53900520")]
        IrithyllDungeonJailersKeyRing = 53900520,

        [Annotation(Name = "[伊鲁席尔地下监牢] 余火 53900590")]
        IrithyllDungeonEmber__ = 53900590,

        [Annotation(Name = "[伊鲁席尔地下监牢] 古老监牢的钥匙 53900610")]
        IrithyllDungeonOldCellKey = 53900610,

        [Annotation(Name = "[伊鲁席尔地下监牢] 火方石戒指＋1 53900710")]
        IrithyllDungeonFlameStoneplateRing1 = 53900710,

        [Annotation(Name = "[伊鲁席尔地下监牢] 贪婪银蛇戒指＋1 53900720")]
        IrithyllDungeonCovetousSilverSerpentRing1 = 53900720,

        [Annotation(Name = "[伊鲁席尔地下监牢] 魔力方石戒指＋2 53900730")]
        IrithyllDungeonMagicStoneplateRing2 = 53900730,

        [Annotation(Name = "[伊鲁席尔地下监牢] 龙体石 53900750")]
        IrithyllDungeonDragonTorsoStone = 53900750,

        [Annotation(Name = "[罪业之都] 宫廷魔法师风帽 53900800")]
        ProfanedCapitalCourtSorcererHood = 53900800,

        [Annotation(Name = "[罪业之都] 风暴管束者 53900810")]
        ProfanedCapitalStormRuler = 53900810,

        [Annotation(Name = "[伊鲁席尔地下监牢] 监牢老大骨灰 53900820")]
        IrithyllDungeonPrisonerChiefsAshes = 53900820,

        [Annotation(Name = "[伊鲁席尔地下监牢] 不死人遗骨 53900900")]
        IrithyllDungeonUndeadBoneShard = 53900900,

        [Annotation(Name = "[灰烬墓地] 已折断的直剑 54000010")]
        CemeteryOfAshBrokenStraightSword = 54000010,

        [Annotation(Name = "[灰烬墓地] 弃尸的灵魂 54000020")]
        CemeteryOfAshSoulOfaDesertedCorpse = 54000020,

        [Annotation(Name = "[灰烬墓地] 火焰壶 54000030")]
        CemeteryOfAshFirebomb = 54000030,

        [Annotation(Name = "[灰烬墓地] 楔形石碎片 54000050")]
        CemeteryOfAshTitaniteShard = 54000050,

        [Annotation(Name = "[灰烬墓地] 返回骨片 54000060")]
        CemeteryOfAshHomewardBone = 54000060,

        [Annotation(Name = "[灰烬墓地] 余火 54000070")]
        CemeteryOfAshEmber = 54000070,

        [Annotation(Name = "[灰烬墓地] 弃尸的灵魂 54000080")]
        CemeteryOfAshSoulOfaDesertedCorpse_ = 54000080,

        [Annotation(Name = "[灰烬墓地] 双鸟纹木盾 54000090")]
        CemeteryOfAshEastWestShield = 54000090,

        [Annotation(Name = "[灰烬墓地] 返回骨片 54000100")]
        CemeteryOfAshHomewardBone_ = 54000100,

        [Annotation(Name = "[灰烬墓地] 来历不明旅人的灵魂 54000110")]
        CemeteryOfAshSoulOfanUnknownTraveler = 54000110,

        [Annotation(Name = "[灰烬墓地] 余火 54000120")]
        CemeteryOfAshEmber_ = 54000120,

        [Annotation(Name = "[灰烬墓地] 微笑面具 54000140")]
        CemeteryOfAshSneeringMask = 54000140,

        [Annotation(Name = "[灰烬墓地] 返回骨片 54000160")]
        CemeteryOfAshHomewardBone__ = 54000160,

        [Annotation(Name = "[灰烬墓地] 原素戒指 54000170")]
        CemeteryOfAshEstusRing = 54000170,

        [Annotation(Name = "[灰烬墓地] 原素碎片 54000180")]
        CemeteryOfAshEstusShard = 54000180,

        [Annotation(Name = "[灰烬墓地] 被污染的防火女灵魂 54000190")]
        CemeteryOfAshFireKeeperSoul = 54000190,

        [Annotation(Name = "[灰烬墓地] 丧失石 54000200")]
        CemeteryOfAshShrivingStone = 54000200,

        [Annotation(Name = "[灰烬墓地] 楔形石块 54000220")]
        CemeteryOfAshTitaniteChunk = 54000220,

        [Annotation(Name = "[灰烬墓地] 受挫骑士的灵魂 54000230")]
        CemeteryOfAshSoulOfaCrestfallenKnight = 54000230,

        [Annotation(Name = "[灰烬墓地] 楔形石块 54000240")]
        CemeteryOfAshTitaniteChunk_ = 54000240,

        [Annotation(Name = "[灰烬墓地] 原素灰戒指 54000250")]
        CemeteryOfAshAshenEstusRing = 54000250,

        [Annotation(Name = "[灰烬墓地] 黑骑士剑刃戟 54000260")]
        CemeteryOfAshBlackKnightGlaive = 54000260,

        [Annotation(Name = "[灰烬墓地] 防火女的眼眸 54000280")]
        CemeteryOfAshEyesOfaFireKeeper = 54000280,

        [Annotation(Name = "[灰烬墓地] 受挫骑士的灵魂 54000290")]
        CemeteryOfAshSoulOfaCrestfallenKnight_ = 54000290,

        [Annotation(Name = "[灰烬墓地] 铁匠铁锤 54000300")]
        CemeteryOfAshBlacksmithHammer = 54000300,

        [Annotation(Name = "[灰烬墓地] 混沌刀刃 54000310")]
        CemeteryOfAshChaosBlade = 54000310,

        [Annotation(Name = "[灰烬墓地] 游魂骨灰 54000320")]
        CemeteryOfAshHollowsAshes = 54000320,

        [Annotation(Name = "[灰烬墓地] 黄蜂戒指 54000330")]
        CemeteryOfAshHornetRing = 54000330,

        [Annotation(Name = "[灰烬墓地] 螺旋剑的残破碎片 54000340")]
        CemeteryOfAshCoiledSwordFragment = 54000340,

        [Annotation(Name = "[灰烬墓地] 防火女长袍 54000350")]
        CemeteryOfAshFireKeeperRobe = 54000350,

        [Annotation(Name = "[灰烬墓地] 生命戒指＋3 54000400")]
        CemeteryOfAshLifeRing3 = 54000400,

        [Annotation(Name = "[灰烬墓地] 钢铁庇佑戒指＋1 54000410")]
        CemeteryOfAshRingOfSteelProtection1 = 54000410,

        [Annotation(Name = "[灰烬墓地] 斑方石戒指＋1 54000420")]
        CemeteryOfAshSpeckledStoneplateRing1 = 54000420,

        [Annotation(Name = "[灰烬墓地] 狼戒指＋2 54000430")]
        CemeteryOfAshWolfRing2 = 54000430,

        [Annotation(Name = "原素灰瓶 6600")]
        AshenEstusFlask = 6600,

        [Annotation(Name = "[灰烬墓地] 贪婪银蛇戒指 54000700")]
        CemeteryOfAshCovetousSilverSerpentRing = 54000700,

        [Annotation(Name = "[艾雷德尔的绘画世界] 蓝冻苔藓球 54500000")]
        AriandelRimeblueMossClump = 54500000,

        [Annotation(Name = "[艾雷德尔的绘画世界] 毒宝石 54500010")]
        AriandelPoisonGem = 54500010,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500020")]
        AriandelLargeSoulOfanUnknownTraveler = 54500020,

        [Annotation(Name = "[艾雷德尔的绘画世界] 幽魂投枪 54500030")]
        AriandelFollowerJavelin = 54500030,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500040")]
        AriandelLargeSoulOfanUnknownTraveler_ = 54500040,

        [Annotation(Name = "[艾雷德尔的绘画世界] 返回骨片 54500050")]
        AriandelHomewardBone = 54500050,

        [Annotation(Name = "[艾雷德尔的绘画世界] 祝福宝石 54500060")]
        AriandelBlessedGem = 54500060,

        [Annotation(Name = "[艾雷德尔的绘画世界] 骑士长的骨灰 54500070")]
        AriandelCaptainsAshes = 54500070,

        [Annotation(Name = "[艾雷德尔的绘画世界] 黑火焰壶 54500080")]
        AriandelBlackFirebomb = 54500080,

        [Annotation(Name = "[艾雷德尔的绘画世界] 丧失石 54500090")]
        AriandelShrivingStone = 54500090,

        [Annotation(Name = "[艾雷德尔的绘画世界] 米尔伍德大弓 54500100")]
        AriandelMillwoodGreatbow = 54500100,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500110")]
        AriandelLargeSoulOfanUnknownTraveler__ = 54500110,

        [Annotation(Name = "[艾雷德尔的绘画世界] 锈斑硬币 54500120")]
        AriandelRustedCoin = 54500120,

        [Annotation(Name = "[艾雷德尔的绘画世界] 楔形石大碎片 54500130")]
        AriandelLargeTitaniteShard = 54500130,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500140")]
        AriandelLargeSoulOfanUnknownTraveler___ = 54500140,

        [Annotation(Name = "[艾雷德尔的绘画世界] 鸦羽 54500150")]
        AriandelCrowQuills = 54500150,

        [Annotation(Name = "[艾雷德尔的绘画世界] 愚人宝石 54500160")]
        AriandelSimpleGem = 54500160,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500170")]
        AriandelLargeSoulOfanUnknownTraveler____ = 54500170,

        [Annotation(Name = "[艾雷德尔的绘画世界] 奴隶骑士头巾 54500180")]
        AriandelSlaveKnightHood = 54500180,

        [Annotation(Name = "[艾雷德尔的绘画世界] 余火 54500190")]
        AriandelEmber = 54500190,

        [Annotation(Name = "[艾雷德尔的绘画世界] 暗宝石 54500200")]
        AriandelDarkGem = 54500200,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500220")]
        AriandelLargeSoulOfanUnknownTraveler_____ = 54500220,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500230")]
        AriandelLargeSoulOfanUnknownTraveler______ = 54500230,

        [Annotation(Name = "[艾雷德尔的绘画世界] 锈斑金币 54500240")]
        AriandelRustedGoldCoin = 54500240,

        [Annotation(Name = "[艾雷德尔的绘画世界] 受挫骑士的灵魂 54500250")]
        AriandelSoulOfaCrestfallenKnight = 54500250,

        [Annotation(Name = "[艾雷德尔的绘画世界] 白教光环 54500260")]
        AriandelWayOfWhiteCorona = 54500260,

        [Annotation(Name = "[艾雷德尔的绘画世界] 锈斑硬币 54500270")]
        AriandelRustedCoin_ = 54500270,

        [Annotation(Name = "[艾雷德尔的绘画世界] 嫩白树枝 54500280")]
        AriandelYoungWhiteBranch = 54500280,

        [Annotation(Name = "[艾雷德尔的绘画世界] 开花绿花草 54500290")]
        AriandelBuddingGreenBlossom = 54500290,

        [Annotation(Name = "[艾雷德尔的绘画世界] 鸦爪 54500300")]
        AriandelCrowTalons = 54500300,

        [Annotation(Name = "[艾雷德尔的绘画世界] 七色石 54500310")]
        AriandelPrismStone = 54500310,

        [Annotation(Name = "[艾雷德尔的绘画世界] 楔形石块 54500320")]
        AriandelTitaniteChunk = 54500320,

        [Annotation(Name = "[艾雷德尔的绘画世界] 楔形石块 54500330")]
        AriandelTitaniteChunk_ = 54500330,

        [Annotation(Name = "[艾雷德尔的绘画世界] 幽魂盾 54500340")]
        AriandelFollowerShield = 54500340,

        [Annotation(Name = "[艾雷德尔的绘画世界] 楔形石大碎片 54500350")]
        AriandelLargeTitaniteShard_ = 54500350,

        [Annotation(Name = "[艾雷德尔的绘画世界] 地鸣岩槌 54500360")]
        AriandelQuakestoneHammer = 54500360,

        [Annotation(Name = "[艾雷德尔的绘画世界] 余火 54500370")]
        AriandelEmber_ = 54500370,

        [Annotation(Name = "[艾雷德尔的绘画世界] 楔形石大碎片 54500380")]
        AriandelLargeTitaniteShard__ = 54500380,

        [Annotation(Name = "[艾雷德尔的绘画世界] 受挫骑士的灵魂 54500390")]
        AriandelSoulOfaCrestfallenKnight_ = 54500390,

        [Annotation(Name = "[艾雷德尔的绘画世界] 受挫骑士的灵魂 54500400")]
        AriandelSoulOfaCrestfallenKnight__ = 54500400,

        [Annotation(Name = "[艾雷德尔的绘画世界] 受挫骑士的大块灵魂 54500410")]
        AriandelLargeSoulOfaCrestfallenKnight = 54500410,

        [Annotation(Name = "[艾雷德尔的绘画世界] 追地者 54500420")]
        AriandelEarthSeeker = 54500420,

        [Annotation(Name = "[艾雷德尔的绘画世界] 幽魂火把 54500430")]
        AriandelFollowerTorch = 54500430,

        [Annotation(Name = "[艾雷德尔的绘画世界] 屎块 54500460")]
        AriandelDungPie = 54500460,

        [Annotation(Name = "[艾雷德尔的绘画世界] 维赫勒头盔 54500470")]
        AriandelVilhelmsHelm = 54500470,

        [Annotation(Name = "[艾雷德尔的绘画世界] 血宝石 54500480")]
        AriandelBloodGem = 54500480,

        [Annotation(Name = "[艾雷德尔的绘画世界] 游魂宝石 54500490")]
        AriandelHollowGem = 54500490,

        [Annotation(Name = "[艾雷德尔的绘画世界] 蓝冻苔藓球 54500530")]
        AriandelRimeblueMossClump_ = 54500530,

        [Annotation(Name = "[艾雷德尔的绘画世界] 幽魂军刀 54500540")]
        AriandelFollowerSabre = 54500540,

        [Annotation(Name = "[艾雷德尔的绘画世界] 余火 54500550")]
        AriandelEmber__ = 54500550,

        [Annotation(Name = "[艾雷德尔的绘画世界] 瞬间冻结 54500560")]
        AriandelSnapFreeze = 54500560,

        [Annotation(Name = "[艾雷德尔的绘画世界] 咒术送灵火 54500570")]
        AriandelPyromancersPartingFlame = 54500570,

        [Annotation(Name = "[艾雷德尔的绘画世界] 蓝冻苔藓球 54500600")]
        AriandelRimeblueMossClump__ = 54500600,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500610")]
        AriandelLargeSoulOfanUnknownTraveler_______ = 54500610,

        [Annotation(Name = "[艾雷德尔的绘画世界] 余火 54500620")]
        AriandelEmber___ = 54500620,

        [Annotation(Name = "[艾雷德尔的绘画世界] 冰冷武器 54500630")]
        AriandelFrozenWeapon = 54500630,

        [Annotation(Name = "[艾雷德尔的绘画世界] 楔形石原盘 54500640")]
        AriandelTitaniteSlab = 54500640,

        [Annotation(Name = "[艾雷德尔的绘画世界] 返回骨片 54500650")]
        AriandelHomewardBone_ = 54500650,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500660")]
        AriandelLargeSoulOfanUnknownTraveler________ = 54500660,

        [Annotation(Name = "[艾雷德尔的绘画世界] 竭力战士的大块灵魂 54500670")]
        AriandelLargeSoulOfaWearyWarrior = 54500670,

        [Annotation(Name = "[艾雷德尔的绘画世界] 来历不明旅人的大块灵魂 54500680")]
        AriandelLargeSoulOfanUnknownTraveler_________ = 54500680,

        [Annotation(Name = "[艾雷德尔的绘画世界] 厚重宝石 54500690")]
        AriandelHeavyGem = 54500690,

        [Annotation(Name = "[艾雷德尔的绘画世界] 竭力战士的大块灵魂 54500800")]
        AriandelLargeSoulOfaWearyWarrior_ = 54500800,

        [Annotation(Name = "[艾雷德尔的绘画世界] 米尔伍德战斧 54500810")]
        AriandelMillwoodBattleAxe = 54500810,

        [Annotation(Name = "[艾雷德尔的绘画世界] 灵树盾 54500820")]
        AriandelEtherealOakShield = 54500820,

        [Annotation(Name = "[艾雷德尔的绘画世界] 竭力战士的灵魂 54500830")]
        AriandelSoulOfaWearyWarrior = 54500830,

        [Annotation(Name = "[The Dreg Heap] 余火 55000000")]
        DregHeapEmber = 55000000,

        [Annotation(Name = "[The Dreg Heap] 竭力战士的灵魂 55000010")]
        DregHeapSoulOfaWearyWarrior = 55000010,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000020")]
        DregHeapTitaniteChunk = 55000020,

        [Annotation(Name = "[The Dreg Heap] 蓝宝珠短剑 55000030")]
        DregHeapAquamarineDagger = 55000030,

        [Annotation(Name = "[The Dreg Heap] 光辉楔形石 55000040")]
        DregHeapTwinklingTitanite = 55000040,

        [Annotation(Name = "[The Dreg Heap] 濡湿小镰刀 55000050")]
        DregHeapMurkyHandScythe = 55000050,

        [Annotation(Name = "[The Dreg Heap] 女神的祝福 55000060")]
        DregHeapDivineBlessing = 55000060,

        [Annotation(Name = "[The Dreg Heap] 钢铁庇佑戒指＋3 55000070")]
        DregHeapRingOfSteelProtection3 = 55000070,

        [Annotation(Name = "[The Dreg Heap] 受挫骑士的灵魂 55000080")]
        DregHeapSoulOfaCrestfallenKnight = 55000080,

        [Annotation(Name = "[The Dreg Heap] 锈斑硬币 55000090")]
        DregHeapRustedCoin = 55000090,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000100")]
        DregHeapTitaniteChunk_ = 55000100,

        [Annotation(Name = "[The Dreg Heap] 濡湿长柄杖 55000110")]
        DregHeapMurkyLongstaff = 55000110,

        [Annotation(Name = "[The Dreg Heap] 余火 55000120")]
        DregHeapEmber_ = 55000120,

        [Annotation(Name = "[The Dreg Heap] 大块灵魂沉淀物 55000130")]
        DregHeapGreatSoulDregs = 55000130,

        [Annotation(Name = "[The Dreg Heap] 贪婪银蛇戒指＋3 55000140")]
        DregHeapCovetousSilverSerpentRing3 = 55000140,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000150")]
        DregHeapFadingSoul = 55000150,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000160")]
        DregHeapTitaniteChunk__ = 55000160,

        [Annotation(Name = "[The Dreg Heap] 返回骨片 55000170")]
        DregHeapHomewardBone = 55000170,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000180")]
        DregHeapFadingSoul_ = 55000180,

        [Annotation(Name = "[The Dreg Heap] 雷壶 55000190")]
        DregHeapLightningUrn = 55000190,

        [Annotation(Name = "[The Dreg Heap] 释放恢复 55000200")]
        DregHeapProjectedHeal = 55000200,

        [Annotation(Name = "[The Dreg Heap] 竭力战士的大块灵魂 55000210")]
        DregHeapLargeSoulOfaWearyWarrior = 55000210,

        [Annotation(Name = "[The Dreg Heap] 洛斯里克军旗 55000220")]
        DregHeapLothricWarBanner = 55000220,

        [Annotation(Name = "[The Dreg Heap] 龙鳞楔形石 55000230")]
        DregHeapTitaniteScale = 55000230,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000240")]
        DregHeapFadingSoul__ = 55000240,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000250")]
        DregHeapFadingSoul___ = 55000250,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000260")]
        DregHeapFadingSoul____ = 55000260,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000270")]
        DregHeapFadingSoul_____ = 55000270,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000280")]
        DregHeapFadingSoul______ = 55000280,

        [Annotation(Name = "[The Dreg Heap] 即将消逝的灵魂 55000290")]
        DregHeapFadingSoul_______ = 55000290,

        [Annotation(Name = "[The Dreg Heap] 黑火焰壶 55000300")]
        DregHeapBlackFirebomb = 55000300,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000310")]
        DregHeapTitaniteChunk___ = 55000310,

        [Annotation(Name = "[The Dreg Heap] 光辉楔形石 55000320")]
        DregHeapTwinklingTitanite_ = 55000320,

        [Annotation(Name = "[The Dreg Heap] 沙之咒术师外衣 55000330")]
        DregHeapDesertPyromancerGarb = 55000330,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000340")]
        DregHeapTitaniteChunk____ = 55000340,

        [Annotation(Name = "[The Dreg Heap] 大门盾 55000350")]
        DregHeapGiantDoorShield = 55000350,

        [Annotation(Name = "[The Dreg Heap] 余火 55000360")]
        DregHeapEmber__ = 55000360,

        [Annotation(Name = "[The Dreg Heap] 沙之咒术师风帽 55000370")]
        DregHeapDesertPyromancerHood = 55000370,

        [Annotation(Name = "[The Dreg Heap] 沙之咒术师手套 55000380")]
        DregHeapDesertPyromancerGloves = 55000380,

        [Annotation(Name = "[The Dreg Heap] 沙之咒术师裙子 55000390")]
        DregHeapDesertPyromancerSkirt = 55000390,

        [Annotation(Name = "[The Dreg Heap] 龙鳞楔形石 55000400")]
        DregHeapTitaniteScale_ = 55000400,

        [Annotation(Name = "[The Dreg Heap] 毒紫苔藓球 55000410")]
        DregHeapPurpleMossClump = 55000410,

        [Annotation(Name = "[The Dreg Heap] 宠爱戒指＋3 55000420")]
        DregHeapRingOfFavor3 = 55000420,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000430")]
        DregHeapTitaniteChunk_____ = 55000430,

        [Annotation(Name = "[The Dreg Heap] 竭力战士的大块灵魂 55000440")]
        DregHeapLargeSoulOfaWearyWarrior_ = 55000440,

        [Annotation(Name = "[The Dreg Heap] 楔形石原盘 55000450")]
        DregHeapTitaniteSlab = 55000450,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000460")]
        DregHeapTitaniteChunk______ = 55000460,

        [Annotation(Name = "[The Dreg Heap] 兜裆布 55000470")]
        DregHeapLoincloth = 55000470,

        [Annotation(Name = "[The Dreg Heap] 楔形石块 55000480")]
        DregHeapTitaniteChunk_______ = 55000480,

        [Annotation(Name = "[The Dreg Heap] 竭力战士的大块灵魂 55000490")]
        DregHeapLargeSoulOfaWearyWarrior__ = 55000490,

        [Annotation(Name = "[The Dreg Heap] 哈兰得大曲剑 55000500")]
        DregHeapHaraldCurvedGreatsword = 55000500,

        [Annotation(Name = "[The Dreg Heap] 返回骨片 55000510")]
        DregHeapHomewardBone_ = 55000510,

        [Annotation(Name = "[The Dreg Heap] 七色石 55000520")]
        DregHeapPrismStone = 55000520,

        [Annotation(Name = "[The Dreg Heap] 沙之咒术师风帽 55000530")]
        DregHeapDesertPyromancerHood_ = 55000530,

        [Annotation(Name = "[The Dreg Heap] 光辉楔形石 55000540")]
        DregHeapTwinklingTitanite__ = 55000540,

        [Annotation(Name = "[The Dreg Heap] 女神的祝福 55000550")]
        DregHeapDivineBlessing_ = 55000550,

        [Annotation(Name = "[The Dreg Heap] 余火 55000560")]
        DregHeapEmber___ = 55000560,

        [Annotation(Name = "[The Dreg Heap] 特使小环旗 55000600")]
        DregHeapSmallEnvoyBanner = 55000600,

        [Annotation(Name = "[The Dreg Heap] 龙鳞楔形石 55100000")]
        DregHeapTitaniteScale__ = 55100000,

        [Annotation(Name = "[The Ringed City] 虚空头盔 55100010")]
        RingedCityRuinHelm = 55100010,

        [Annotation(Name = "[The Ringed City] 开花绿花草 55100020")]
        RingedCityBuddingGreenBlossom = 55100020,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100030")]
        RingedCityTitaniteChunk = 55100030,

        [Annotation(Name = "[The Ringed City] 余火 55100040")]
        RingedCityEmber = 55100040,

        [Annotation(Name = "[The Ringed City] 开花绿花草 55100050")]
        RingedCityBuddingGreenBlossom_ = 55100050,

        [Annotation(Name = "[The Ringed City] 秘藏的祝福 55100060")]
        RingedCityHiddenBlessing = 55100060,

        [Annotation(Name = "[The Ringed City] 受挫骑士的灵魂 55100070")]
        RingedCitySoulOfaCrestfallenKnight = 55100070,

        [Annotation(Name = "[The Ringed City] 竭力战士的大块灵魂 55100080")]
        RingedCityLargeSoulOfaWearyWarrior = 55100080,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100090")]
        RingedCityFadingSoul = 55100090,

        [Annotation(Name = "[The Ringed City] 受挫骑士的灵魂 55100100")]
        RingedCitySoulOfaCrestfallenKnight_ = 55100100,

        [Annotation(Name = "[The Ringed City] 余火 55100110")]
        RingedCityEmber_ = 55100110,

        [Annotation(Name = "[The Ringed City] 解咒石 55100120")]
        RingedCityPurgingStone = 55100120,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100130")]
        RingedCityFadingSoul_ = 55100130,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100140")]
        RingedCityFadingSoul__ = 55100140,

        [Annotation(Name = "[The Ringed City] 游魂宝石 55100150")]
        RingedCityHollowGem = 55100150,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100160")]
        RingedCityTitaniteChunk_ = 55100160,

        [Annotation(Name = "[The Ringed City] 光辉楔形石 55100170")]
        RingedCityTwinklingTitanite = 55100170,

        [Annotation(Name = "[The Ringed City] 丧失石 55100180")]
        RingedCityShrivingStone = 55100180,

        [Annotation(Name = "[The Ringed City] 希拉头冠 55100190")]
        RingedCityShirasCrown = 55100190,

        [Annotation(Name = "[The Ringed City] 苔藓球果实 55100200")]
        RingedCityMossfruit = 55100200,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100210")]
        RingedCityFadingSoul___ = 55100210,

        [Annotation(Name = "[The Ringed City] 受挫骑士的大块灵魂 55100220")]
        RingedCityLargeSoulOfaCrestfallenKnight = 55100220,

        [Annotation(Name = "[The Ringed City] 环印骑士枪 55100230")]
        RingedCityRingedKnightSpear = 55100230,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100240")]
        RingedCityFadingSoul____ = 55100240,

        [Annotation(Name = "[The Ringed City] 黑魔女帽子 55100250")]
        RingedCityBlackWitchHat = 55100250,

        [Annotation(Name = "[The Ringed City] 龙头盾 55100260")]
        RingedCityDragonheadShield = 55100260,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100270")]
        RingedCityTitaniteChunk__ = 55100270,

        [Annotation(Name = "[The Ringed City] 苔藓球果实 55100280")]
        RingedCityMossfruit_ = 55100280,

        [Annotation(Name = "[The Ringed City] 受挫骑士的大块灵魂 55100290")]
        RingedCityLargeSoulOfaCrestfallenKnight_ = 55100290,

        [Annotation(Name = "[The Ringed City] 贪婪金蛇戒指＋3 55100300")]
        RingedCityCovetousGoldSerpentRing3 = 55100300,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100310")]
        RingedCityFadingSoul_____ = 55100310,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100320")]
        RingedCityFadingSoul______ = 55100320,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100330")]
        RingedCityTitaniteChunk___ = 55100330,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100340")]
        RingedCityFadingSoul_______ = 55100340,

        [Annotation(Name = "[The Ringed City] 暗宝石 55100350")]
        RingedCityDarkGem = 55100350,

        [Annotation(Name = "[The Ringed City] 七色石 55100360")]
        RingedCityPrismStone = 55100360,

        [Annotation(Name = "[The Ringed City] 环印骑士直剑 55100370")]
        RingedCityRingedKnightStraightSword = 55100370,

        [Annotation(Name = "[The Ringed City] 哈维尔戒指＋3 55100380")]
        RingedCityHavelsRing3 = 55100380,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100390")]
        RingedCityTitaniteChunk____ = 55100390,

        [Annotation(Name = "[The Ringed City] 光辉楔形石 55100400")]
        RingedCityTwinklingTitanite_ = 55100400,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100410")]
        RingedCityFadingSoul________ = 55100410,

        [Annotation(Name = "[The Ringed City] 竭力战士的灵魂 55100420")]
        RingedCitySoulOfaWearyWarrior = 55100420,

        [Annotation(Name = "[The Ringed City] 说客右臂 55100430")]
        RingedCityPreachersRightArm = 55100430,

        [Annotation(Name = "[The Ringed City] 垃圾残渣 55100440")]
        RingedCityRubbish = 55100440,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100450")]
        RingedCityTitaniteChunk_____ = 55100450,

        [Annotation(Name = "[The Ringed City] 黑魔女面纱 55100460")]
        RingedCityBlackWitchVeil = 55100460,

        [Annotation(Name = "[The Ringed City] 教堂守护者薄刀 6660")]
        RingedCityChurchGuardianShiv = 6660,

        [Annotation(Name = "[The Ringed City] 光辉楔形石 55100480")]
        RingedCityTwinklingTitanite__ = 55100480,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100490")]
        RingedCityFadingSoul_________ = 55100490,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100500")]
        RingedCityFadingSoul__________ = 55100500,

        [Annotation(Name = "[The Ringed City] 受挫骑士的灵魂 55100510")]
        RingedCitySoulOfaCrestfallenKnight__ = 55100510,

        [Annotation(Name = "[The Ringed City] 说客白色头部 55100520")]
        RingedCityWhitePreacherHead = 55100520,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100530")]
        RingedCityFadingSoul___________ = 55100530,

        [Annotation(Name = "[The Ringed City] 龙鳞楔形石 55100540")]
        RingedCityTitaniteScale = 55100540,

        [Annotation(Name = "[The Ringed City] 龙鳞楔形石 55100550")]
        RingedCityTitaniteScale_ = 55100550,

        [Annotation(Name = "[The Ringed City] 龙头大盾 55100560")]
        RingedCityDragonheadGreatshield = 55100560,

        [Annotation(Name = "[The Ringed City] 龙鳞楔形石 55100570")]
        RingedCityTitaniteScale__ = 55100570,

        [Annotation(Name = "[The Ringed City] 垃圾残渣 55100580")]
        RingedCityRubbish_ = 55100580,

        [Annotation(Name = "[The Ringed City] 竭力战士的大块灵魂 55100590")]
        RingedCityLargeSoulOfaWearyWarrior_ = 55100590,

        [Annotation(Name = "[The Ringed City] 龙鳞楔形石 55100600")]
        RingedCityTitaniteScale___ = 55100600,

        [Annotation(Name = "[The Ringed City] 龙鳞楔形石 55100610")]
        RingedCityTitaniteScale____ = 55100610,

        [Annotation(Name = "[The Ringed City] 雷电宝石 55100620")]
        RingedCityLightningGem = 55100620,

        [Annotation(Name = "[The Ringed City] 祝福宝石 55100630")]
        RingedCityBlessedGem = 55100630,

        [Annotation(Name = "[The Ringed City] 愚人宝石 55100640")]
        RingedCitySimpleGem = 55100640,

        [Annotation(Name = "[The Ringed City] 竭力战士的大块灵魂 55100650")]
        RingedCityLargeSoulOfaWearyWarrior__ = 55100650,

        [Annotation(Name = "[The Ringed City] 雷电箭 55100660")]
        RingedCityLightningArrow = 55100660,

        [Annotation(Name = "[The Ringed City] 绿花戒指＋3 55100670")]
        RingedCityChloranthyRing3 = 55100670,

        [Annotation(Name = "[The Ringed City] 余火 55100680")]
        RingedCityEmber__ = 55100680,

        [Annotation(Name = "[The Ringed City] 费莲诺尔枪饰 55100690")]
        RingedCityFilianoresSpearOrnament = 55100690,

        [Annotation(Name = "[The Ringed City] 古式便服 55100700")]
        RingedCityAntiquatedPlainGarb = 55100700,

        [Annotation(Name = "[The Ringed City] 竭力战士的灵魂 55100710")]
        RingedCitySoulOfaWearyWarrior_ = 55100710,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100720")]
        RingedCityFadingSoul____________ = 55100720,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100730")]
        RingedCityFadingSoul_____________ = 55100730,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100740")]
        RingedCityFadingSoul______________ = 55100740,

        [Annotation(Name = "[The Ringed City] 光辉楔形石 55100750")]
        RingedCityTwinklingTitanite___ = 55100750,

        [Annotation(Name = "[The Ringed City] 仪式枪的碎片 6835")]
        RingedCityRitualSpearFragment = 6835,

        [Annotation(Name = "[The Ringed City] 开花绿花草 55100770")]
        RingedCityBuddingGreenBlossom__ = 55100770,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100780")]
        RingedCityFadingSoul_______________ = 55100780,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100790")]
        RingedCityFadingSoul________________ = 55100790,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100800")]
        RingedCityTitaniteChunk______ = 55100800,

        [Annotation(Name = "[The Ringed City] 竭力战士的大块灵魂 55100810")]
        RingedCityLargeSoulOfaWearyWarrior___ = 55100810,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100820")]
        RingedCityFadingSoul_________________ = 55100820,

        [Annotation(Name = "[The Ringed City] 竭力战士的灵魂 55100830")]
        RingedCitySoulOfaWearyWarrior__ = 55100830,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100840")]
        RingedCityFadingSoul__________________ = 55100840,

        [Annotation(Name = "[The Ringed City] 龙鳞楔形石 55100850")]
        RingedCityTitaniteScale_____ = 55100850,

        [Annotation(Name = "[The Ringed City] 受挫骑士的灵魂 55100860")]
        RingedCitySoulOfaCrestfallenKnight___ = 55100860,

        [Annotation(Name = "[The Ringed City] 白树弓 55100870")]
        RingedCityWhiteBirchBow = 55100870,

        [Annotation(Name = "[The Ringed City] 楔形石块 55100880")]
        RingedCityTitaniteChunk_______ = 55100880,

        [Annotation(Name = "[The Ringed City] 即将消逝的灵魂 55100890")]
        RingedCityFadingSoul___________________ = 55100890,

        [Annotation(Name = "[The Ringed City] 嫩白树枝 55100900")]
        RingedCityYoungWhiteBranch = 55100900,

        [Annotation(Name = "[The Ringed City] 嫩白树枝 55100910")]
        RingedCityYoungWhiteBranch_ = 55100910,

        [Annotation(Name = "[The Ringed City] 嫩白树枝 55100920")]
        RingedCityYoungWhiteBranch__ = 55100920,

        [Annotation(Name = "[人之脓 #1] 楔形石碎片 53000980")]
        PusOfMan1TitaniteShard = 53000980,

        [Annotation(Name = "[人之脓 #2] 楔形石碎片 53000981")]
        PusOfMan2TitaniteShard = 53000981,

        [Annotation(Name = "[教堂骑士 - 妖王欧斯罗艾斯] 魔力方石戒指 53010955")]
        CathedralKnightOceirosMagicStoneplateRing = 53010955,

        [Annotation(Name = "[教堂导师 #4] 朵丽丝的侵蚀 53700975")]
        CathedralEvangelist4DorhysGnawing = 53700975,

        [Annotation(Name = "[洛斯里克骑士] 粗制宝石 53010980")]
        LothricKnightRawGem = 53010980,

        [Annotation(Name = "[翼骑士 #3 - 大书库] 楔形石原盘 53410900")]
        WingedKnight3GrandArchivesTitaniteSlab = 53410900,

        [Annotation(Name = "[冷冽征战骑士] 征战骑士头盔 53410905")]
        BorealOutriderKnightOutriderKnightHelm = 53410905,

        [Annotation(Name = "[冷冽征战骑士] 伊鲁席尔直剑 53100980")]
        BorealOutriderKnightIrithyllStraightSword = 53100980,

        [Annotation(Name = "[冷冽征战骑士] 伊鲁席尔刺剑 53010995")]
        BorealOutriderKnightIrithyllRapier = 53010995,

        [Annotation(Name = "[结晶老者] 结晶卷轴 53410908")]
        CrystalSageCrystalScroll = 53410908,

        [Annotation(Name = "[银骑士 #1]  53700983")]
        SilverKnight1 = 53700983,

        [Annotation(Name = "[银骑士 #2]  53700984")]
        SilverKnight2 = 53700984,

        [Annotation(Name = "[银骑士 #3]  53700985")]
        SilverKnight3 = 53700985,

        [Annotation(Name = "[罪业之都畸形之民 #3] 艾莲诺拉 53900910")]
        MonstrosityOfSin3Eleonora = 53900910,

        [Annotation(Name = "[尸怪 #2] 强力魔力盾牌 53900920")]
        Corpsegrub2GreatMagicShield = 53900920,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53500981")]
        MimicSymbolOfAvarice = 53500981,

        [Annotation(Name = "[宝箱怪] 幽邃点字圣典 53500980")]
        MimicDeepBrailleDivineTome = 53500980,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53010951")]
        MimicSymbolOfAvarice_ = 53010951,

        [Annotation(Name = "[宝箱怪] 太阳直剑 53010950")]
        MimicSunlightStraightSword = 53010950,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53010961")]
        MimicSymbolOfAvarice__ = 53010961,

        [Annotation(Name = "[宝箱怪] 龙鳞楔形石 53010960")]
        MimicTitaniteScale = 53010960,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53800945")]
        MimicSymbolOfAvarice___ = 53800945,

        [Annotation(Name = "[宝箱怪] 黑刀 53800940")]
        MimicBlackBlade = 53800940,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53900941")]
        MimicSymbolOfAvarice____ = 53900941,

        [Annotation(Name = "[宝箱怪] 猎龙雷箭 53900940")]
        MimicDragonslayerLightningArrow = 53900940,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53900951")]
        MimicSymbolOfAvarice_____ = 53900951,

        [Annotation(Name = "[宝箱怪] 龙鳞楔形石 53900950")]
        MimicTitaniteScale_ = 53900950,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53900961")]
        MimicSymbolOfAvarice______ = 53900961,

        [Annotation(Name = "[宝箱怪] 锈斑金币 53900960")]
        MimicRustedGoldCoin = 53900960,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53900971")]
        MimicSymbolOfAvarice_______ = 53900971,

        [Annotation(Name = "[宝箱怪] 宫廷魔法师杖 53900970")]
        MimicCourtSorcerersStaff = 53900970,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53900981")]
        MimicSymbolOfAvarice________ = 53900981,

        [Annotation(Name = "[宝箱怪] 荣誉大盾 53900980")]
        MimicGreatshieldOfGlory = 53900980,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53900996")]
        MimicSymbolOfAvarice_________ = 53900996,

        [Annotation(Name = "[宝箱怪] 原素碎片 53900995")]
        MimicEstusShard = 53900995,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53900991")]
        MimicSymbolOfAvarice__________ = 53900991,

        [Annotation(Name = "[宝箱怪] 暗怪手戒指 53900990")]
        MimicDarkClutchRing = 53900990,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53700981")]
        MimicSymbolOfAvarice___________ = 53700981,

        [Annotation(Name = "[宝箱怪] 金枝杖枪 53700980")]
        MimicGoldenRitualSpear = 53700980,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 53000961")]
        MimicSymbolOfAvarice____________ = 53000961,

        [Annotation(Name = "[宝箱怪] 幽邃战斧 53000960")]
        MimicDeepBattleAxe = 53000960,

        [Annotation(Name = "[宝箱怪] 贪欲者的烙印 55100985")]
        MimicSymbolOfAvarice_____________ = 55100985,

        [Annotation(Name = "[宝箱怪] 邪眼戒指＋3 55100986")]
        MimicRingOfTheEvilEye3 = 55100986,

        [Annotation(Name = "[黄指头的海泽儿] 海泽儿的十字镐 53500960")]
        YellowfingerHeyselHeyselPick_ = 53500960,

        [Annotation(Name = "红标记蜡石 6781")]
        RedSignSoapstone = 6781,

        [Annotation(Name = "[卡萨斯沙虫] 雷电柱 53800941")]
        CarthusSandwormLightningStake = 53800941,

        [Annotation(Name = "[狱卒 #2] 狱卒的钥匙 53900930")]
        Jailer2JailersKeyRing = 53900930,

        [Annotation(Name = "[沙力万的野兽 #1] 教宗右眼 53700995")]
        SulyvahnsBeast1PontiffsRightEye = 53700995,

        [Annotation(Name = "[沙力万的野兽 #2] 宠爱戒指 53700990")]
        SulyvahnsBeast2RingOfFavor = 53700990,

        [Annotation(Name = "[大螃蟹 - 活祭品之路] 大沼戒指 53300990")]
        GreatCrabRoadOfSacrificesGreatSwampRing = 53300990,

        [Annotation(Name = "[大螃蟹 - 法兰要塞] 伫立龙徽戒指 53300991")]
        GreatCrabFarronKeepLingeringDragoncrestRing = 53300991,

        [Annotation(Name = "[大老鼠] 咬血戒指 53100228")]
        GiantRatBloodbiteRing = 53100228,

        [Annotation(Name = "[恶魔] 火焰宝石 53100985")]
        DemonFireGem = 53100985,

        [Annotation(Name = "[咕鲁长老 #3] 法里斯帽子 53300995")]
        ElderGhru3PharissHat = 53300995,

        [Annotation(Name = "[咕鲁长老 #4] 法里斯弓 53300996")]
        ElderGhru4BlackBowOfPharis = 53300996,

        [Annotation(Name = "[古老飞龙] 楔形石大碎片 53000985")]
        AncientWyvernLargeTitaniteShard = 53000985,

        [Annotation(Name = "[古老飞龙] 楔形石块 53010990")]
        AncientWyvernTitaniteChunk = 53010990,

        [Annotation(Name = "[古老飞龙] 楔形石块 53010991")]
        AncientWyvernTitaniteChunk_ = 53010991,

        [Annotation(Name = "[猎龙铠甲] 镕铁猎龙头盔 55100987")]
        DragonslayerArmourIronDragonslayerHelm = 55100987,

        [Annotation(Name = "[主教 #1 - 冷冽谷的伊鲁席尔] 幽邃戒指 53500970")]
        Deacon1IrithyllDeepRing = 53500970,

        [Annotation(Name = "绿花草 53400040")]
        GreenBlossom = 53400040,
    }
}