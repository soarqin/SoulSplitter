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

namespace SoulMemory.EldenRing
{
    public enum Boss : uint
    {
        [Annotation(Name = "“接肢”葛瑞克 - 史东薇尔城", Description = "史东薇尔城")]
        GodrickTheGraftedStormveilCastle = 10000800,

        [Annotation(Name = "“恶兆妖鬼”玛尔基特 - 史东薇尔城", Description = "史东薇尔城")]
        MargitTheFellOmenStormveilCastle = 10000850,

        [Annotation(Name = "“接肢”贵族后裔 - 候王礼拜堂", Description = "宁姆格福")]
        GraftedScionChapelOfAnticipation = 10010800,

        [Annotation(Name = "“恶兆王”蒙葛特 - 王城罗德尔", Description = "王城罗德尔")]
        MorgottTheOmenKingLeyndell = 11000800,

        [Annotation(Name = "“初始之王”葛孚雷 - 王城罗德尔", Description = "王城罗德尔")]
        GodfreyFirstEldenLordLeyndell = 11000850,

        [Annotation(Name = "战士荷莱·露 - 王城罗德尔", Description = "王城罗德尔")]
        HoarahLouxLeyndell = 11050800,

        [Annotation(Name = "“百智爵士”基甸·奥夫尼尔 - 王城罗德尔", Description = "王城罗德尔")]
        SirGideonOfnirTheAllKnowingLeyndell = 11050850,

        [Annotation(Name = "诺克史黛拉的龙人士兵 - 安瑟尔河", Description = "安瑟尔河")]
        DragonkinSoldierOfNokstellaAinselRiver = 12010800,

        [Annotation(Name = "龙人士兵 - 腐败湖", Description = "腐败湖")]
        DragonkinSoldierLakeOfRot = 12010850,

        [Annotation(Name = "英雄石像鬼 (双) - 希芙拉河", Description = "希芙拉河")]
        ValiantGargoylesSiofraRiver = 12020800,

        [Annotation(Name = "龙人士兵 - 希芙拉河", Description = "希芙拉河")]
        DragonkinSoldierSiofraRiver = 12020830,

        [Annotation(Name = "仿身泪滴 - 希芙拉河", Description = "希芙拉河")]
        MimicTearSiofraRiver = 12020850,

        [Annotation(Name = "“熔炉骑士”志留亚 - 深根底层", Description = "深根底层")]
        CrucibleKnightSiruliaDeeprootDepths = 12030390,

        [Annotation(Name = "菲雅的英雄 - 深根底层", Description = "深根底层")]
        FiasChampionDeeprootDepths = 12030800,

        [Annotation(Name = "“死龙”弗尔桑克斯 - 深根底层", Description = "深根底层")]
        LichdragonFortissaxDeeprootDepths = 12030850,

        [Annotation(Name = "“黑暗弃子”艾丝缇 - 腐败湖", Description = "腐败湖")]
        AstelNaturalbornOfTheVoidLakeOfRot = 12040800,

        [Annotation(Name = "“鲜血君王”蒙格 - 蒙格温王朝", Description = "蒙格温王朝")]
        MohgLordOfBloodMohgwynPalace = 12050800,

        [Annotation(Name = "祖灵 - 希芙拉河", Description = "希芙拉河")]
        AncestorSpiritSiofraRiver = 12080800,

        [Annotation(Name = "祖灵之王 - “永恒之城”诺克隆恩", Description = "“永恒之城”诺克隆恩")]
        RegalAncestorSpiritNokronEternalCity = 12090800,

        [Annotation(Name = "“黑剑”玛利喀斯 - 逐渐崩毁的法姆·亚兹拉", Description = "逐渐崩毁的法姆·亚兹拉")]
        MalikethTheBlackBladeCrumblingFarumAzula = 13000800,

        [Annotation(Name = "“龙王”普拉顿桑克斯 - 逐渐崩毁的法姆·亚兹拉", Description = "逐渐崩毁的法姆·亚兹拉")]
        DragonlordPlacidusaxCrumblingFarumAzula = 13000830,

        [Annotation(Name = "神皮双人组 - 逐渐崩毁的法姆·亚兹拉", Description = "逐渐崩毁的法姆·亚兹拉")]
        GodskinDuoCrumblingFarumAzula = 13000850,

        [Annotation(Name = "“满月女王”蕾娜菈 - 魔法学院雷亚卢卡利亚", Description = "魔法学院雷亚卢卡利亚")]
        RennalaQueenOfTheFullMoonAcademyOfRayaLucaria = 14000800,

        [Annotation(Name = "拉达冈的红狼 - 魔法学院雷亚卢卡利亚", Description = "魔法学院雷亚卢卡利亚")]
        RedWolfOfRadagonAcademyOfRayaLucaria = 14000850,

        [Annotation(Name = "“米凯拉的锋刃”玛莲妮亚 - 米凯拉的圣树", Description = "米凯拉的圣树")]
        MaleniaBladeOfMiquellaMiquellasHaligtree = 15000800,

        [Annotation(Name = "“圣树骑士”罗蕾塔 - 米凯拉的圣树", Description = "米凯拉的圣树")]
        LorettaKnightOfTheHaligtreeMiquellasHaligtree = 15000850,

        [Annotation(Name = "“亵渎君王”拉卡德 - 火山官邸", Description = "火山官邸")]
        RykardLordOfBlasphemyVolcanoManor = 16000800,

        [Annotation(Name = "神皮贵族 - 火山官邸", Description = "火山官邸")]
        GodskinNobleVolcanoManor = 16000850,

        [Annotation(Name = "掳人少女人偶 (双) - 火山官邸", Description = "火山官邸")]
        AbductorVirginsVolcanoManor = 16000860,

        [Annotation(Name = "腐烂树灵 - 漂流墓地", Description = "漂流墓地")]
        UlceratedTreeSpiritStrandedGraveyard = 18000800,

        [Annotation(Name = "葛瑞克的士兵 - 漂流墓地", Description = "漂流墓地")]
        SoldierOfGodrickStrandedGraveyard = 18000850,

        [Annotation(Name = "艾尔登之兽 - 艾尔登宝座", Description = "王城罗德尔")]
        EldenBeastEldenThrone = 19000800,

        [Annotation(Name = "“恶兆之子”蒙格 - 弃置恶兆的地底 (王城罗德尔)", Description = "弃置恶兆的地底")]
        MohgTheOmenSubterraneanShunningGroundsLeyndell = 35000800,

        [Annotation(Name = "“鲜血祭司”艾斯加 - 弃置恶兆的地底 (王城罗德尔)", Description = "弃置恶兆的地底")]
        EsgarPriestOfBloodSubterraneanShunningGroundsLeyndell = 35000850,

        [Annotation(Name = "“熔岩土龙”马卡尔 - 古遗迹断崖 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        MagmaWyrmMakarRuinStrewnPrecipiceLiurnia = 39200800,

        [Annotation(Name = "墓地影子 - 灵庙原野地下墓地 (宁姆格福)", Description = "宁姆格福")]
        CemeteryShadeTombswardCatacombsLimgrave = 30000800,

        [Annotation(Name = "归树看门犬 - 穿刺地下墓地 (啜泣半岛)", Description = "啜泣半岛")]
        ErdtreeBurialWatchdogImpalersCatacombsWeepingPenisula = 30010800,

        [Annotation(Name = "归树看门犬 - 风暴根脚的地下墓地 (宁姆格福)", Description = "宁姆格福")]
        ErdtreeBurialWatchdogStormfootCatacombsLimgrave = 30020800,

        [Annotation(Name = "黑刀刺客 - 死亡降临的地下墓地 (宁姆格福)", Description = "宁姆格福")]
        BlackKnifeAssassinDeathtouchedCatacombsLimgrave = 30110800,

        [Annotation(Name = "守墓斗士 - 蒙流地下墓地 (宁姆格福)", Description = "宁姆格福")]
        GraveWardenDuelistMurkwaterCatacombsLimgrave = 30040800,

        [Annotation(Name = "墓地影子 - 黑刀地下墓地 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        CemeteryShadeBlackKnifeCatacombsLiurnia = 30050800,

        [Annotation(Name = "黑刀刺客 - 黑刀地下墓地 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        BlackKnifeAssassinBlackKnifeCatacombsLiurnia = 30050850,

        [Annotation(Name = "唤灵蜗牛 - 绝路地下墓地 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        SpiritCallerSnailRoadsEndCatacombsLiurnia = 30030800,

        [Annotation(Name = "归树看门犬 - 断崖下的地下墓地 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        ErdtreeBurialWatchdogCliffbottomCatacombsLiurnia = 30060800,

        [Annotation(Name = "萨米尔的古英雄 - 尊贵者的英雄墓地 (亚坛高原)", Description = "亚坛高原")]
        AncientHeroOfZamorSaintedHerosGraveAltusPlateau = 30080800,

        [Annotation(Name = "英雄的红狼 - 格密尔英雄墓地 (格密尔火山)", Description = "格密尔火山")]
        RedWolfOfTheChampionGelmirHerosGraveMtGelmir = 30090800,

        [Annotation(Name = "“熔炉骑士”奥陶琵斯 - 亚雷萨英雄墓地 (亚坛高原)", Description = "亚坛高原")]
        CrucibleKnightOrdovisAurizaHerosGraveAltusPlateau = 30100800,

        [Annotation(Name = "熔炉骑士 (大树矛) - 亚雷萨英雄墓地 (亚坛高原)", Description = "亚坛高原")]
        CrucibleKnightTreeSpearAurizaHerosGraveAltusPlateau = 30100800,

        [Annotation(Name = "混种战士 - 丑恶地下墓地 (格密尔火山)", Description = "格密尔火山")]
        MisbegottenWarriorUnsightlyCatacombsMtGelmir = 30120800,

        [Annotation(Name = "调香师托莉夏 - 丑恶地下墓地 (格密尔火山)", Description = "格密尔火山")]
        PerfumerTriciaUnsightlyCatacombsMtGelmir = 30120800,

        [Annotation(Name = "归树看门犬 - 威达姆地下墓地 (亚坛高原)", Description = "亚坛高原")]
        ErdtreeBurialWatchdogWyndhamCatacombsAltusPlateau = 30070800,

        [Annotation(Name = "守墓斗士 - 亚雷萨副墓地 (亚坛高原)", Description = "亚坛高原")]
        GraveWardenDuelistAurizaSideTombAltusPlateau = 30130800,

        [Annotation(Name = "归树看门犬 - 小黄金树地下墓地 (盖利德)", Description = "盖利德")]
        ErdtreeBurialWatchdogMinorErdtreeCatacombsCaelid = 30140800,

        [Annotation(Name = "墓地影子 - 盖利德地下墓地 (盖利德)", Description = "盖利德")]
        CemeteryShadeCaelidCatacombsCaelid = 30150800,

        [Annotation(Name = "腐败树灵 - 英灵地下墓地 (盖利德)", Description = "盖利德")]
        PutridTreeSpiritWarDeadCatacombsCaelid = 30160800,

        [Annotation(Name = "萨米尔的古英雄 - 巨人战争的英雄墓地 (巨人山顶)", Description = "巨人山顶")]
        AncientHeroOfZamorGiantConqueringHerosGraveMountaintops = 30170800,

        [Annotation(Name = "腐烂树灵 - 巨人山顶地下墓地 (巨人山顶)", Description = "巨人山顶")]
        UlceratedTreeSpritGiantsMountaintopCatacombsMountaintops = 30180800,

        [Annotation(Name = "腐败守墓斗士 - 化圣雪原地下墓地 (化圣雪原)", Description = "化圣雪原")]
        PutridGraveWardenDuelistConsecratedSnowfieldCatacombsSnowfield = 30190800,

        [Annotation(Name = "离群仿身泪滴 - 通往圣树的密道", Description = "禁域")]
        StrayMimicTearHiddenPathToTheHaligtree = 30202800,

        [Annotation(Name = "帕奇 - 蒙流洞窟 (宁姆格福)", Description = "宁姆格福")]
        PatchesMurkwaterCaveLimgrave = 31000800,

        [Annotation(Name = "卢恩熊 - 垂穴洞窟 (啜泣半岛)", Description = "啜泣半岛")]
        RunebearEarthboreCaveWeepingPenisula = 31010800,

        [Annotation(Name = "“病花”米兰达 - 灵庙原野洞窟 (宁姆格福)", Description = "宁姆格福")]
        MirandaTheBlightedBloomTombswardCaveLimgrave = 31020800,

        [Annotation(Name = "法姆·亚兹拉的兽人 - 近林洞窟 (宁姆格福)", Description = "宁姆格福")]
        BeastmanOfFarumAzulaGrovesideCaveLimgrave = 31030800,

        [Annotation(Name = "亚人首领 - 海岸洞窟 (宁姆格福)", Description = "宁姆格福")]
        DemiHumanChiefCoastalCaveLimgrave = 31150800,

        [Annotation(Name = "魔像守卫 - 大道下的洞窟 (宁姆格福)", Description = "宁姆格福")]
        GuardianGolemHighroadCaveLimgrave = 31170800,

        [Annotation(Name = "玛莲妮亚的尊腐骑士 - 留水洞窟 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        CleanrotKnightStillwaterCaveLiurnia = 31040800,

        [Annotation(Name = "猎犬骑士 - 湖旁结晶洞窟 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        BloodhoundKnightLakesideCrystalCaveLiurnia = 31050800,

        [Annotation(Name = "结晶人 (双) - 学院结晶洞窟 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        CrystaliansAcademyCrystalCaveLiurnia = 31060800,

        [Annotation(Name = "腐败眷属 - 沸滚河洞窟 (格密尔火山)", Description = "格密尔火山")]
        KindredOfRotSeethewaterCaveMtGelmir = 31070800,

        [Annotation(Name = "“亚人女王”玛格 - 火山洞窟 (格密尔火山)", Description = "格密尔火山")]
        DemiHumanQueenMargotVolcanoCaveMtGelmir = 31090800,

        [Annotation(Name = "“病花”米兰达 - 调香师的隐藏洞窟 (亚坛高原)", Description = "亚坛高原")]
        MirandaTheBlightedBloomPerfumersGrottoAltusPlateau = 31180800,

        [Annotation(Name = "黑刀刺客 - 贤者的洞窟 (亚坛高原)", Description = "亚坛高原")]
        BlackKnifeAssassinSagesCaveAltusPlateau = 31190800,

        [Annotation(Name = "死术师哥瑞斯 - 贤者的洞窟 (亚坛高原)", Description = "亚坛高原")]
        NecromancerGarrisSagesCaveAltusPlateau = 31190850,

        [Annotation(Name = "发狂斗士 - 牢狱洞窟 (盖利德)", Description = "盖利德")]
        FrenziedDuelistGaolCaveCaelid = 31210800,

        [Annotation(Name = "法姆·亚兹拉的兽人 - 龙墓洞窟 (桂奥尔龙墓)", Description = "桂奥尔龙墓")]
        BeastmanOfFarumAzulaDragonbarrowCaveDragonbarrow = 31100800,

        [Annotation(Name = "玛莲妮亚的尊腐骑士 - 废弃洞窟 (盖利德)", Description = "盖利德")]
        CleanrotKnightAbandonedCaveCaelid = 31200800,

        [Annotation(Name = "腐败结晶人 (三) - 瑟利亚隐藏洞窟 (盖利德)", Description = "盖利德")]
        PutridCrystaliansSelliaHideawayCaelid = 31110800,

        [Annotation(Name = "混种圣骑士 - 安身洞窟 (巨人山顶)", Description = "巨人山顶")]
        MisbegottenCrusaderCaveOfTheForlornMountaintops = 31120800,

        [Annotation(Name = "唤灵蜗牛 - 唤灵洞窟 (巨人山顶)", Description = "巨人山顶")]
        SpiritCallerSnailSpiritcallersCaveMountaintops = 31220800,

        [Annotation(Name = "片鳞混种 - 摩恩坑道 (啜泣半岛)", Description = "啜泣半岛")]
        ScalyMisbegottenMorneTunnelWeepingPenisula = 32000800,

        [Annotation(Name = "挖石山妖 - 宁姆格福坑道 (宁姆格福)", Description = "宁姆格福")]
        StonediggerTrollLimgraveTunnelsLimgrave = 32010800,

        [Annotation(Name = "结晶人（圆刃刀） - 雷亚卢卡利亚结晶坑道 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        CrystalianRingbladeRayaLucariaCrystalTunnelLiurnia = 32020800,

        [Annotation(Name = "挖石山妖 - 旧亚坛坑道 (亚坛高原)", Description = "亚坛高原")]
        StonediggerTrollOldAltusTunnelAltusPlateau = 32040800,

        [Annotation(Name = "石肤黑王 - 西亚坛神授塔 (亚坛高原)", Description = "亚坛高原")]
        OnyxLordDivineTowerOfWestAltusAltusPlateau = 34120800,

        [Annotation(Name = "结晶人 (双) - 亚坛坑道 (亚坛高原)", Description = "亚坛高原")]
        CrystalianSpearAltusTunnelAltusPlateau = 32050800,

        [Annotation(Name = "熔岩土龙 - 盖尔坑道 (盖利德)", Description = "盖利德")]
        MagmaWyrmGaelTunnelCaelid = 32070800,

        [Annotation(Name = "坠星兽物 - 瑟利亚结晶坑道 (盖利德)", Description = "盖利德")]
        FallingstarBeastSelliaCrystalTunnelCaelid = 32080800,

        [Annotation(Name = "“黑暗繁星”艾丝缇 - 耶罗·亚尼斯坑道 (化圣雪原)", Description = "化圣雪原")]
        AstelStarsOfDarknessYeloughAnixTunnelSnowfield = 32110800,

        [Annotation(Name = "神皮使徒 - 盖利德神授塔 (盖利德)", Description = "盖利德")]
        GodskinApostleDivineTowerOfCaelidCaelid = 34130800,

        [Annotation(Name = "恶兆孪生子 (双) - 东亚坛神授塔 (王城城墙外)", Description = "王城城墙外")]
        FellTwinsDivineTowerOfEastAltusCapitalOutskirts = 34140850,

        [Annotation(Name = "发狂南瓜头士兵 - 驿站街遗迹 (宁姆格福)", Description = "宁姆格福")]
        MadPumpkinHeadWaypointRuinsLimgrave = 1044360800,

        [Annotation(Name = "黑夜骑兵 - 亚基尔湖北方 (宁姆格福)", Description = "宁姆格福")]
        NightsCavalryAgheelLakeNorthLimgrave = 1043370800,

        [Annotation(Name = "死之鸟 - 风暴关卡 (宁姆格福)", Description = "宁姆格福")]
        DeathRiteBirdStormgateLimgrave = 1042380800,

        [Annotation(Name = "铃珠猎人 - 习战者的破屋 (宁姆格福)", Description = "宁姆格福")]
        BallBearingHunterWarmastersShackLimgrave = 1042380850,

        [Annotation(Name = "萨米尔的古英雄 - 啜泣的封印监牢 (啜泣半岛)", Description = "啜泣半岛")]
        AncientHeroOfZamorWeepingEvergaolWeepingPenisula = 1042330800,

        [Annotation(Name = "“猎犬骑士”达瑞威尔 - 无主猎犬的封印监牢 (宁姆格福)", Description = "宁姆格福")]
        BloodhoundKnightDarriwillForlornHoundEvergaolLimgrave = 1044350800,

        [Annotation(Name = "熔炉骑士 - 风暴山丘的封印监牢 (宁姆格福)", Description = "宁姆格福")]
        CrucibleKnightStormhillEvergaolLimgrave = 1042370800,

        [Annotation(Name = "黄金树的化身 - 小黄金树 (啜泣半岛)", Description = "啜泣半岛")]
        ErdtreeAvatarMinorErdtreeWeepingPenisula = 1043330800,

        [Annotation(Name = "黑夜骑兵 - 摩恩城（城墙前方） (啜泣半岛)", Description = "啜泣半岛")]
        NightsCavalryCastleMorneApproachWeepingPenisula = 1044320850,

        [Annotation(Name = "死之鸟 - 摩恩城（城墙前方） (啜泣半岛)", Description = "啜泣半岛")]
        DeathRiteBirdCastleMorneApproachWeepingPenisula = 1044320800,

        [Annotation(Name = "狮子混种 - 摩恩城 (啜泣半岛)", Description = "啜泣半岛")]
        LeonineMisbegottenCastleMorneWeepingPenisula = 1043300800,

        [Annotation(Name = "大树守卫 - 艾雷教堂 (宁姆格福)", Description = "宁姆格福")]
        TreeSentinelChurchOfEllehLimgrave = 1042360800,

        [Annotation(Name = "“飞龙”亚基尔 - 龙息废墟 (宁姆格福)", Description = "宁姆格福")]
        FlyingDragonAgheelDragonBurntRuinsLimgrave = 1043360800,

        [Annotation(Name = "提比亚的唤声船 - 水唤村 (宁姆格福)", Description = "宁姆格福")]
        TibiaMarinerSummonwaterVillageLimgrave = 1045390800,

        [Annotation(Name = "王室幽魂 - 王室领地废墟 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        RoyalRevenantKingsrealmRuinsLiurnia = 1034480800,

        [Annotation(Name = "“盗火”亚当 - 小偷的封印监牢 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        AdanThiefOfFireMalefactorsEvergaolLiurnia = 1038410800,

        [Annotation(Name = "“卡利亚骑士”波尔斯 - 杜鹃的封印监牢 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        BolsCarianKnightCuckoosEvergaolLiurnia = 1033450800,

        [Annotation(Name = "石肤黑王 - 王室墓地的封印监牢 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        OnyxLordRoyalGraveEvergaolLiurnia = 1036500800,

        [Annotation(Name = "“黑刀之首”亚勒托 - 月光祭坛 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        AlectoBlackKnifeRingleaderMoonlightAltarLiurnia = 1033420800,

        [Annotation(Name = "黄金树的化身 - 复仇者的破屋 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        ErdtreeAvatarRevengersShackLiurnia = 1033430800,

        [Annotation(Name = "黄金树的化身 - 小黄金树 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        ErdtreeAvatarMinorErdtreeLiurnia = 1038480800,

        [Annotation(Name = "禁卫骑士罗蕾塔 - 卡利亚城寨 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        RoyalKnightLorettaCarianManorLiurnia = 1035500800,

        [Annotation(Name = "铃珠猎人 - 结缘教堂 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        BallBearingHunterChurchOfVowsLiurnia = 1037460800,

        [Annotation(Name = "黑夜骑兵 - 利耶尼亚大道（北方） (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        NightsCavalryLiurniaHighwayFarNorthLiurnia = 1039430800,

        [Annotation(Name = "黑夜骑兵 - 雷亚卢卡利亚（东门） (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        NightsCavalryEastRayaLucariaGateLiurnia = 1036480800,

        [Annotation(Name = "死之鸟 - 拉斯卡废墟 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        DeathRiteBirdLaskyarRuinsLiurnia = 1037420800,

        [Annotation(Name = "死亡仪式鸟 - 门前镇的北方 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        DeathRiteBirdGateTownNorthwestLiurnia = 1036450800,

        [Annotation(Name = "“辉石龙”史玛拉格 - 会合处 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        GlintstoneDragonSmaragMeetingPlaceLiurnia = 1034450800,

        //[Display(Name = "Glintstone Dragon Adula - Ranni's Rise (Liurnia)", Description = "Liurnia of the Lakes")]
        //GlintstoneDragonAdulaRannisRiseLiurnia = 1034500800,

        [Annotation(Name = "“辉石龙”亚杜拉 - 月之民废墟 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        GlintstoneDragonAdulaMoonfolkRuinsLiurnia = 1034420800,

        [Annotation(Name = "恶兆猎人 - 白金村 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        OmenkillerVillageOfTheAlbinauricsLiurnia = 1035420800,

        [Annotation(Name = "提比亚的唤声船 - 壶村 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        TibiaMarinerJarburgLiurnia = 1039440800,

        [Annotation(Name = "“古龙”兰斯桑克斯 - 弃置棺材 (亚坛高原)", Description = "亚坛高原")]
        AncientDragonLansseaxAbandonedCoffinAltusPlateau = 1037510800,

        [Annotation(Name = "“古龙”兰斯桑克斯 - 城墙旁小径 (亚坛高原)", Description = "亚坛高原")]
        AncientDragonLansseaxRampartsidePathAltusPlateau = 1041520800,

        [Annotation(Name = "“亚人女王”姬丽卡 - 卢克斯废墟 (亚坛高原)", Description = "亚坛高原")]
        DemiHumanQueenLuxRuinsAltusPlateau = 1038510800,

        [Annotation(Name = "坠星兽物 - 双大树守卫以南 (亚坛高原)", Description = "亚坛高原")]
        FallingstarBeastSouthOfTreeSentinelDuoAltusPlateau = 1041500800,

        [Annotation(Name = "鲜血贵族 - 蠕血废墟 (亚坛高原)", Description = "亚坛高原")]
        SanguineNobleWrithebloodRuinsAltusPlateau = 1040530800,

        [Annotation(Name = "大树守卫 - 大树守卫 (亚坛高原)", Description = "亚坛高原")]
        TreeSentinelTreeSentinelDuoAltusPlateau = 1041510800,

        [Annotation(Name = "神皮使徒 - 风车村高台 (亚坛高原)", Description = "亚坛高原")]
        GodskinApostleWindmillHeightsAltusPlateau = 1042550800,

        [Annotation(Name = "黑刀刺客 - 尊贵者的英雄墓地 (亚坛高原)", Description = "亚坛高原")]
        BlackKnifeAssassinSaintedHerosGraveEntranceAltusPlateau = 1040520800,

        [Annotation(Name = "龙装大树守卫 - 王城城墙前方 (王城城墙外)", Description = "王城城墙外")]
        DraconicTreeSentinelCapitalRampartCapitalOutskirts = 1045520800,

        [Annotation(Name = "“接肢”葛孚亚 - 黄金一族的封印监牢 (亚坛高原)", Description = "亚坛高原")]
        GodefroyTheGraftedGoldenLineageEvergaolAltusPlateau = 1039500800,

        [Annotation(Name = "蚯蚓脸 - 森林之民的废墟 (亚坛高原)", Description = "亚坛高原")]
        WormfaceWoodfolkRuinsAltusPlateau = 1041530800,

        [Annotation(Name = "死之鸟 - 小黄金树 (王城城墙外)", Description = "王城城墙外")]
        DeathRiteBirdMinorErdtreeCapitalOutskirts = 1044530800,

        [Annotation(Name = "铃珠猎人 - 遁世商人的破屋 (王城城墙外)", Description = "王城城墙外")]
        BallBearingHunterHermitMerchantsShackCapitalOutskirts = 1043530800,

        [Annotation(Name = "“亚人女王”玛姬 - “起源魔法师”亚兹勒 (格密尔火山)", Description = "格密尔火山")]
        DemiHumanQueenPrimevalSorcererAzurMtGelmir = 1037530800,

        [Annotation(Name = "熔岩土龙 - 沸滚河终点 (格密尔火山)", Description = "格密尔火山")]
        MagmaWyrmSeethewaterTerminusMtGelmir = 1035530800,

        [Annotation(Name = "坠星成兽 - 格密尔火山（第９休息站） (格密尔火山)", Description = "格密尔火山")]
        FullGrownFallingstarBeastCraterMtGelmir = 1036540800,

        [Annotation(Name = "“铁棘”艾隆梅尔 - 日荫城 (亚坛高原)", Description = "亚坛高原")]
        ElemerOfTheBriarShadedCastleAltusPlateau = 1039540800,

        [Annotation(Name = "腐烂树灵 - 小黄金树 (格密尔火山)", Description = "格密尔火山")]
        UlceratedTreeSpiritMinorErdtreeMtGelmir = 1037540810,

        [Annotation(Name = "提比亚的唤声船 - 威达姆废墟 (亚坛高原)", Description = "亚坛高原")]
        TibiaMarinerWyndhamRuinsAltusPlateau = 1038520800,

        [Annotation(Name = "腐败化身 - 小黄金树 (盖利德)", Description = "盖利德")]
        PutridAvatarMinorErdtreeCaelid = 1047400800,

        [Annotation(Name = "“步入腐败”艾格基斯 - 盖利德大道南方 (盖利德)", Description = "盖利德")]
        DecayingEkzykesCaelidHighwaySouthCaelid = 1048370800,

        [Annotation(Name = "黑夜骑兵 - 艾奥尼亚沼泽（南岸） (盖利德)", Description = "盖利德")]
        NightsCavalrySouthernAeoniaSwampBankCaelid = 1049370800,

        [Annotation(Name = "死亡仪式鸟 - 艾奥尼亚沼泽（南岸） (盖利德)", Description = "盖利德")]
        DeathRiteBirdSouthernAeoniaSwampBankCaelid = 1049370850,

        [Annotation(Name = "老将欧尼尔 - 艾奥尼亚沼泽东 (盖利德)", Description = "盖利德")]
        CommanderONeilEastAeoniaSwampCaelid = 1049380800,

        [Annotation(Name = "熔炉骑士 - 红狮子城 (盖利德)", Description = "盖利德")]
        CrucibleKnightRedmaneCastleCaelid = 1051360800,

        [Annotation(Name = "“碎星”拉塔恩 - 战场 (盖利德)", Description = "盖利德")]
        StarscourgeRadahnBattlefieldCaelid = 1252380800,

        [Annotation(Name = "诺克斯修士 (双) - 瑟利亚椅子庙 (盖利德)", Description = "盖利德")]
        NoxPriestWestSelliaCaelid = 1049390800,

        [Annotation(Name = "铃珠猎人 - 隐居商人的破屋 (桂奥尔龙墓)", Description = "桂奥尔龙墓")]
        BallBearingHunterIsolatedMerchantsShackDragonbarrow = 1048410800,

        [Annotation(Name = "战场魔法师犹格 - 瑟利亚的封印监牢 (盖利德)", Description = "盖利德")]
        BattlemageHuguesSelliaCrystalTunnelEntranceCaelid = 1049390850,

        [Annotation(Name = "腐败化身 - 龙墓的岔路 (盖利德)", Description = "盖利德")]
        PutridAvatarDragonbarrowForkCaelid = 1051400800,

        [Annotation(Name = "“飞龙”桂雷尔 - 桂奥尔龙墓 (盖利德)", Description = "盖利德")]
        FlyingDragonGreyllDragonbarrowCaelid = 1052410800,

        [Annotation(Name = "黑夜骑兵 - 桂奥尔龙墓 (盖利德)", Description = "盖利德")]
        NightsCavalryDragonbarrowCaelid = 1052410850,

        [Annotation(Name = "黑剑眷属 - 野兽神殿 (盖利德)", Description = "盖利德")]
        BlackBladeKindredBestialSanctumCaelid = 1051430800,

        [Annotation(Name = "黑夜骑兵 - 禁域 (巨人山顶)", Description = "巨人山顶")]
        NightsCavalryForbiddenLandsMountaintops = 1048510800,

        [Annotation(Name = "黑剑眷属 - 洛德大升降机 (巨人山顶)", Description = "巨人山顶")]
        BlackBladeKindredBeforeGrandLiftOfRoldMountaintops = 1049520800,

        [Annotation(Name = "“冻结冰雾”玻列琉斯 - 结冰湖 (巨人山顶)", Description = "巨人山顶")]
        BorealisTheFreezingFogFreezingFieldsMountaintops = 1254560800,

        [Annotation(Name = "“圆桌骑士”维克 - 准王者的封印监牢 (巨人山顶)", Description = "巨人山顶")]
        RoundtableKnightVykeLordContendersEvergaolMountaintops = 1053560800,

        [Annotation(Name = "火焰巨人 - 巨人火焰大锅 (巨人山顶)", Description = "巨人山顶")]
        FireGiantGiantsForgeMountaintops = 1052520800,

        [Annotation(Name = "黄金树的化身 - 小黄金树 (巨人山顶)", Description = "巨人山顶")]
        ErdtreeAvatarMinorErdtreeMountaintops = 1052560800,

        [Annotation(Name = "死亡仪式鸟 - 索尔城西 (巨人山顶)", Description = "巨人山顶")]
        DeathRiteBirdWestOfCastleSoMountaintops = 1050570800,

        [Annotation(Name = "腐败化身 - 小黄金树 (化圣雪原)", Description = "化圣雪原")]
        PutridAvatarMinorErdtreeSnowfield = 1050570850,

        [Annotation(Name = "老将尼奥 - 索尔城 (巨人山顶)", Description = "巨人山顶")]
        CommanderNiallCastleSoulMountaintops = 1051570800,

        [Annotation(Name = "“大土龙”席欧朵利克 - 白金魔法师塔 (巨人山顶)", Description = "巨人山顶")]
        GreatWyrmTheodorixAlbinauricRiseMountaintops = 1050560800,

        [Annotation(Name = "黑夜骑兵 - 禁域 (巨人山顶)", Description = "巨人山顶")]
        NightsCavalrySourthwestMountaintops = 1248550800,

        [Annotation(Name = "死亡仪式鸟 - “仪典镇”奥缇那 (化圣雪原)", Description = "化圣雪原")]
        DeathRiteBirdOrdinaLiturgicalTownSnowfield = 1048570800,

        [Annotation(Name = "发狂南瓜头士兵 (双) - 奇列姆废墟 (盖利德)", Description = "盖利德")]
        PumpkinheadDuoCaelemRuinsCaelid = 1048400800,

        [Annotation(Name = "黑夜骑兵 - 亚坛大道的三叉口 (亚坛高原)", Description = "亚坛高原")]
        NightsCavalryAltusHighwayAltusPlateau = 1039510800,

        [Annotation(Name = "灵火龙 - 墓地平原 (西北)", Description = "墓地平原")]
        GhostflameDragonGravesitePlain = 2045440800,

        [Annotation(Name = "孤牢骑士 - 西方无名灵庙", Description = "墓地平原")]
        BlackgaolKnightWesternNamelessMausoleum = 2046410800,

        [Annotation(Name = "血怪之首 - 河尾洞窟", Description = "墓地平原")]
        ChiefBloodfiendRivermouthCave = 43000800,

        [Annotation(Name = "喟叹者 - 喟叹监牢", Description = "墓地平原")]
        LamenterLamentersGaol = 41020800,

        [Annotation(Name = "“亚人剑圣”翁吉 - 贝瑞特监牢", Description = "墓地平原")]
        DemiHumanSwordmasterOnzeBeluratGaol = 41000800,

        [Annotation(Name = "神兽舞狮 - “塔之镇”贝瑞特", Description = "“塔之镇”贝瑞特")]
        DivineBeastDancingLionBeluratTowerSettlement = 20000800,

        [Annotation(Name = "“双月骑士”蕾菈娜 - 恩希斯城", Description = "恩希斯城")]
        RellanaTwinMoonKnightCastleEnsis = 2048440800,

        [Annotation(Name = "灵火龙", Description = "幽影亚坛")]
        GhostflameDragon = 2049430800,

        [Annotation(Name = "大红熊拉鲁瓦", Description = "幽影亚坛")]
        RalvatheGreatRedBear = 2049450800,

        [Annotation(Name = "大红熊鲁格利亚 - 劳弗下方 (西北)", Description = "幽影亚坛")]
        RugaleatheGreatRedBearRauhBase = 2044470800,

        [Annotation(Name = "“落叶”丹恩 - 穆斯废墟", Description = "幽影亚坛")]
        DryleafDaneMoorthRuins = 2049440800,

        [Annotation(Name = "“黑骑士”艾瑞德 - 惩罚要塞", Description = "幽影亚坛")]
        BlackKnightEdreddFortofReprimand = 2049430850,

        [Annotation(Name = "“黑骑士”迦鲁 - 雾谷要塞", Description = "幽影亚坛")]
        BlackKnightGarrewFogRiftFort = 2047450800,

        [Annotation(Name = "红熊 - 北方无名灵庙", Description = "幽影亚坛")]
        RedBearNorthernNamelessMausoleum = 2046450800,

        [Annotation(Name = "罗刹 - 东方无名灵庙", Description = "幽影亚坛")]
        RakshasaEasternNamelessMausoleum = 2051440800,

        [Annotation(Name = "“指头之母”梅蒂尔 - 玛努斯·美特大教堂", Description = "幽影亚坛")]
        MetyrMotherofFingersCathedralofManusMetyr = 25000800,

        [Annotation(Name = "“指头之母”尤弥尔 - 玛努斯·美特大教堂", Description = "幽影亚坛")]
        CountYmirMotherofFingersCathedralofManusMetyr = 2051450800,

        [Annotation(Name = "死骑士 - 雾谷地下墓地", Description = "幽影亚坛")]
        DeathKnightFogRiftCatacombs = 40000800,

        [Annotation(Name = "死骑士 - 蝎河地下墓地", Description = "幽影亚坛")]
        DeathKnightScorpionRiverCatacombs = 40010800,

        [Annotation(Name = "咒剑士拉比利士 - 波尼监牢", Description = "幽影亚坛")]
        CursebladeLabirithBonnyGaol = 41010800,

        [Annotation(Name = "黄金河马 - 正门广场", Description = "幽影城")]
        GoldenHippopotamusMainGatePlaza = 21000850,

        [Annotation(Name = "“恶之蛇”梅瑟莫 - 梅瑟莫的暗室", Description = "幽影城")]
        BaseSerpentMessmerMessmersDarkChamber = 21010800,

        [Annotation(Name = "神兽舞狮 - 劳弗古遗迹", Description = "劳弗古遗迹")]
        DivineBeastDancingLionAncientRuinsofRauh = 2046460800,

        [Annotation(Name = "“花蕾圣女”萝蜜娜 - 花蕾教堂", Description = "花蕾教堂")]
        RominaSaintoftheBudChurchoftheBud = 2044450800,

        [Annotation(Name = "灵火龙 - 青蓝海岸", Description = "青蓝海岸")]
        GhostflameDragonCeruleanCoast = 2048380850,

        [Annotation(Name = "拉纳舞娘 - 南方无名灵庙", Description = "青蓝海岸")]
        DancerofRanahSouthernNamelessMausoleum = 2046380800,

        [Annotation(Name = "融泥骑士 - 石棺大洞", Description = "青蓝海岸")]
        PutrescentKnightStoneCoffinFissure = 22000800,

        [Annotation(Name = "死亡仪式鸟 - 卡罗隐藏墓地", Description = "卡罗隐藏墓地")]
        DeathRiteBirdCharosHiddenGrave = 2047390800,

        [Annotation(Name = "“亚人女王”玛丽戈 - 卡罗隐藏墓地 (西)", Description = "卡罗隐藏墓地")]
        DemiHumanQueenMariggaCharosHiddenGrave = 2046400800,

        [Annotation(Name = "尖刺山的飞龙 - 尖刺山的山脚", Description = "尖刺山")]
        JaggedPeakDrakeFootoftheJaggedPeak = 2049410800,

        [Annotation(Name = "尖刺山的飞龙 - 尖刺山（中段）", Description = "尖刺山")]
        JaggedPeakDrakeJaggedPeakMountainside = 2052400800,

        [Annotation(Name = "古龙人 - 龙洞", Description = "尖刺山")]
        AncientDragonManDragonsPit = 43010800,

        [Annotation(Name = "“古龙”瑟涅桑克斯 - 尖刺山（中段）", Description = "尖刺山")]
        AncientDragonSenessaxJaggedPeakMountainside = 2054390850,

        [Annotation(Name = "“狂龙”贝勒 - 尖刺山（山顶）", Description = "尖刺山")]
        BayletheDreadJaggedPeakSummit = 2054390800,

        [Annotation(Name = "大树守卫 - 隐匿之地", Description = "望影露台")]
        TreeSentinelHinterland = 2050470800,

        [Annotation(Name = "大树守卫 - 隐匿之地（桥边）", Description = "望影露台")]
        TreeSentinelHinterlandBridge = 2050480860,

        [Annotation(Name = "坠星兽物 - 指岩山丘", Description = "望影露台")]
        FallingstarBeastFingerstoneHill = 2052480800,

        [Annotation(Name = "老将盖乌斯 - 望影露台", Description = "望影露台")]
        CommanderGaiusScaduview = 2049480800,

        [Annotation(Name = "幽影树的化身 - 幽影树的树脚", Description = "望影露台")]
        ScadutreeAvatarScadutreeBase = 2050480800,

        [Annotation(Name = "“拷问老者”约里 - 驱暗地下墓地", Description = "谷底森林")]
        JoriElderInquisitorDarklightCatacombs = 2052430800,

        [Annotation(Name = "“癫火之王”米德拉 - 米德拉府邸", Description = "谷底森林")]
        MidraLordofFrenziedFlameMidrasManse = 28000800,

        [Annotation(Name = "“米凯拉的王”拉塔恩 - 艾尼尔·伊利姆", Description = "艾尼尔·伊利姆")]
        RadahnConsortofMiquellaEnirIlim = 20010800,
    }
}