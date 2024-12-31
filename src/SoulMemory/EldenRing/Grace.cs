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
    public enum Grace : uint
    {
        //Academy of Raya Lucaria

        [Annotation(Name = "雷亚卢卡利亚大书库", Description = "魔法学院雷亚卢卡利亚")]
        RayaLucariaGrandLibrary = 71400,

        [Annotation(Name = "讨论室", Description = "魔法学院雷亚卢卡利亚")]
        DebateParlor = 71401,

        [Annotation(Name = "杜鹃教堂", Description = "魔法学院雷亚卢卡利亚")]
        ChurchOfTheCuckoo = 71402,

        [Annotation(Name = "校舍内的教室", Description = "魔法学院雷亚卢卡利亚")]
        SchoolhouseClassroom = 71403,

        //Ainsel River

        [Annotation(Name = "诺克史黛拉的龙人士兵", Description = "安瑟尔河")]
        DragonkinSoldierOfNokstella = 71210,

        [Annotation(Name = "安瑟尔河（井底）", Description = "安瑟尔河")]
        AinselRiverWellDepths = 71211,

        [Annotation(Name = "安瑟尔河（水门）", Description = "安瑟尔河")]
        AinselRiverSluiceGate = 71212,

        [Annotation(Name = "安瑟尔河（下游）", Description = "安瑟尔河")]
        AinselRiverDownstream = 71213,

        [Annotation(Name = "“黑暗弃子”艾丝缇", Description = "安瑟尔河")]
        AstelNaturalbornOfTheVoid = 71240,

        //Ainsel River Main

        [Annotation(Name = "安瑟尔河主流", Description = "安瑟尔河主流")]
        AinselRiverMain = 71214,

        [Annotation(Name = "“永恒之城”诺克史黛拉", Description = "安瑟尔河主流")]
        NokstellaEternalCity = 71215,

        [Annotation(Name = "诺克史黛拉水潭", Description = "安瑟尔河主流")]
        NokstellaWaterfallBasin = 71219,

        //Altus Plateau

        [Annotation(Name = "尊贵者的英雄墓地", Description = "亚坛高原")]
        SaintedHerosGrave = 73008,

        [Annotation(Name = "丑恶地下墓地", Description = "亚坛高原")]
        UnsightlyCatacombs = 73012,

        [Annotation(Name = "调香师的隐藏洞窟", Description = "亚坛高原")]
        PerfumersGrotto = 73118,

        [Annotation(Name = "贤者的洞窟", Description = "亚坛高原")]
        SagesCave = 73119,

        [Annotation(Name = "旧亚坛坑道", Description = "亚坛高原")]
        OldAltusTunnel = 73204,

        [Annotation(Name = "亚坛坑道", Description = "亚坛高原")]
        AltusTunnel = 73205,

        [Annotation(Name = "弃置棺材", Description = "亚坛高原")]
        AbandonedCoffin = 76300,

        [Annotation(Name = "亚坛高原", Description = "亚坛高原")]
        AltusPlateau = 76301,

        [Annotation(Name = "近黄金树的山丘", Description = "亚坛高原")]
        ErdtreeGazingHill = 76302,

        [Annotation(Name = "亚坛大道的三叉口", Description = "亚坛高原")]
        AltusHighwayJunction = 76303,

        [Annotation(Name = "穿林大桥", Description = "亚坛高原")]
        ForestSpanningGreatbridge = 76304,

        [Annotation(Name = "城墙旁小径", Description = "亚坛高原")]
        RampartsidePath = 76305,

        [Annotation(Name = "丰饶森林", Description = "亚坛高原")]
        BowerOfBounty = 76306,

        [Annotation(Name = "移送罪人之路（路旁）", Description = "亚坛高原")]
        RoadOfIniquitySidePath = 76307,

        [Annotation(Name = "风车村", Description = "亚坛高原")]
        WindmillVillage = 76308,

        [Annotation(Name = "风车村高台", Description = "亚坛高原")]
        WindmillHeights = 76313,

        [Annotation(Name = "日荫城（城墙）", Description = "亚坛高原")]
        ShadedCastleRamparts = 76320,

        [Annotation(Name = "日荫城（内门）", Description = "亚坛高原")]
        ShadedCastleInnerGate = 76321,

        [Annotation(Name = "城主大厅", Description = "亚坛高原")]
        CastellansHall = 76322,

        //Bellum Highway

        [Annotation(Name = "雷亚卢卡利亚（东门）", Description = "彼鲁姆大道")]
        EastRayaLucariaGate = 76207,

        [Annotation(Name = "彼鲁姆教堂", Description = "彼鲁姆大道")]
        BellumChurch = 76208,

        [Annotation(Name = "癫火村外", Description = "彼鲁姆大道")]
        FrenziedFlameVillageOutskirts = 76239,

        [Annotation(Name = "镇静教堂", Description = "彼鲁姆大道")]
        ChurchOfInhibition = 76240,

        //Caelid

        [Annotation(Name = "小黄金树地下墓地", Description = "盖利德")]
        MinorErdtreeCatacombs = 73014,

        [Annotation(Name = "盖利德地下墓地", Description = "盖利德")]
        CaelidCatacombs = 73015,

        [Annotation(Name = "英灵地下墓地", Description = "盖利德")]
        WarDeadCatacombs = 73016,

        [Annotation(Name = "废弃洞窟", Description = "盖利德")]
        AbandonedCave = 73120,

        [Annotation(Name = "牢狱洞窟", Description = "盖利德")]
        GaolCave = 73121,

        [Annotation(Name = "盖尔坑道", Description = "盖利德")]
        GaelTunnel = 73207,

        [Annotation(Name = "盖尔坑道（侧门口）", Description = "盖利德")]
        RearGaelTunnelEntrance = 73207,

        [Annotation(Name = "瑟利亚结晶坑道", Description = "盖利德")]
        SelliaCrystalTunnel = 73208,

        [Annotation(Name = "熏火教堂", Description = "盖利德")]
        SmolderingChurch = 76400,

        [Annotation(Name = "腐败旁露台", Description = "盖利德")]
        RotviewBalcony = 76401,

        [Annotation(Name = "盖尔要塞北方", Description = "盖利德")]
        FortGaelNorth = 76402,

        [Annotation(Name = "奇列姆废墟", Description = "盖利德")]
        CaelemRuins = 76403,

        [Annotation(Name = "龙飨大教堂", Description = "盖利德")]
        CathedralOfDragonCommunion = 76404,

        [Annotation(Name = "盖利德大道南方", Description = "盖利德")]
        CaelidHighwaySouth = 76405,

        [Annotation(Name = "熏烧火墙", Description = "盖利德")]
        SmolderingWall = 76409,

        [Annotation(Name = "希芙拉河的出口井", Description = "盖利德")]
        DeepSiofraWell = 76410,

        [Annotation(Name = "艾奥尼亚沼泽（南岸）", Description = "盖利德")]
        SouthernAeoniaSwampBank = 76411,

        [Annotation(Name = "瑟利亚镇后侧", Description = "盖利德")]
        SelliaBackstreets = 76414,

        [Annotation(Name = "瑟利亚椅子庙", Description = "盖利德")]
        ChairCryptOfSellia = 76415,

        [Annotation(Name = "瑟利亚镇（楼梯下方）", Description = "盖利德")]
        SelliaUnderStair = 76416,

        [Annotation(Name = "不破大桥", Description = "盖利德")]
        ImpassableGreatbridge = 76417,

        [Annotation(Name = "腐败病教堂", Description = "盖利德")]
        ChurchOfThePlague = 76418,

        [Annotation(Name = "红狮子城（广场）", Description = "盖利德")]
        RedmaneCastlePlaza = 76419,

        [Annotation(Name = "广场前房间", Description = "盖利德")]
        ChamberOutsideThePlaza = 76420,

        [Annotation(Name = "“碎星”拉塔恩", Description = "盖利德")]
        StarscourgeRadahn = 76422,

        //Capital Outskirts

        [Annotation(Name = "亚雷萨英雄墓地", Description = "王城城墙外")]
        AurizaHerosGrave = 73010,

        [Annotation(Name = "亚雷萨副墓地", Description = "王城城墙外")]
        AurizaSideTomb = 73013,

        [Annotation(Name = "西亚坛神授塔", Description = "王城城墙外")]
        DivineTowerOfWestAltus = 73430,

        [Annotation(Name = "封印坑道", Description = "王城城墙外")]
        SealedTunnel = 73431,

        [Annotation(Name = "西亚坛神授塔（门口）", Description = "王城城墙外")]
        DivineTowerOfWestAltusGate = 73432,

        [Annotation(Name = "城外幻影树", Description = "王城城墙外")]
        OuterWallPhantomTree = 76309,

        [Annotation(Name = "小黄金树教堂", Description = "王城城墙外")]
        MinorErdtreeChurch = 76310,

        [Annotation(Name = "遁世商人的破屋", Description = "王城城墙外")]
        HermitMerchantsShack = 76311,

        [Annotation(Name = "城外战场遗迹", Description = "王城城墙外")]
        OuterWallBattleground = 76312,

        [Annotation(Name = "王城城墙前方", Description = "王城城墙外")]
        CapitalRampart = 76314,

        //Consecrated Snowfield

        [Annotation(Name = "化圣雪原地下墓地", Description = "化圣雪原")]
        ConsecratedSnowfieldCatacombs = 73019,

        [Annotation(Name = "安身洞窟", Description = "化圣雪原")]
        CaveOfTheForlorn = 73112,

        [Annotation(Name = "耶罗·亚尼斯坑道", Description = "化圣雪原")]
        YeloughAnixTunnel = 73211,

        [Annotation(Name = "化圣雪原", Description = "化圣雪原")]
        ConsecratedSnowfield = 76550,

        [Annotation(Name = "化圣雪原（深处）", Description = "化圣雪原")]
        InnerConsecratedSnowfield = 76551,

        [Annotation(Name = "“仪典镇”奥缇那", Description = "化圣雪原")]
        OrdinaLiturgicalTown = 76652,

        [Annotation(Name = "离教废屋", Description = "化圣雪原")]
        ApostateDerelict = 76653,

        //Crumbling Farum Azula

        [Annotation(Name = "“黑剑”玛利喀斯", Description = "逐渐崩毁的法姆·亚兹拉")]
        MalikethTheBlackBlade = 71300,

        [Annotation(Name = "“龙王”普拉顿桑克斯", Description = "逐渐崩毁的法姆·亚兹拉")]
        DragonlordPlacidusax = 71301,

        [Annotation(Name = "龙教堂祭坛", Description = "逐渐崩毁的法姆·亚兹拉")]
        DragonTempleAltar = 71302,

        [Annotation(Name = "渐毁野兽墓", Description = "逐渐崩毁的法姆·亚兹拉")]
        CrumblingBeastGrave = 71303,

        [Annotation(Name = "渐毁野兽墓（深处）", Description = "逐渐崩毁的法姆·亚兹拉")]
        CrumblingBeastGraveDepths = 71304,

        [Annotation(Name = "龙卷旁露台", Description = "逐渐崩毁的法姆·亚兹拉")]
        TempestFacingBalcony = 71305,

        [Annotation(Name = "龙教堂", Description = "逐渐崩毁的法姆·亚兹拉")]
        DragonTemple = 71306,

        [Annotation(Name = "龙教堂（耳堂）", Description = "逐渐崩毁的法姆·亚兹拉")]
        DragonTempleTransept = 71307,

        [Annotation(Name = "龙教堂（升降机前）", Description = "逐渐崩毁的法姆·亚兹拉")]
        DragonTempleLift = 71308,

        [Annotation(Name = "龙教堂（屋顶）", Description = "逐渐崩毁的法姆·亚兹拉")]
        DragonTempleRooftop = 71309,

        [Annotation(Name = "大桥侧边", Description = "逐渐崩毁的法姆·亚兹拉")]
        BesideTheGreatBridge = 71310,

        //Deeproot Depths

        [Annotation(Name = "死王子宝座", Description = "深根底层")]
        PrinceOfDeathsThrone = 71230,

        [Annotation(Name = "树根旁断崖", Description = "深根底层")]
        RootFacingCliffs = 71231,

        [Annotation(Name = "大瀑布顶端", Description = "深根底层")]
        GreatWaterfallCrest = 71232,

        [Annotation(Name = "深根底层", Description = "深根底层")]
        DeeprootDepths = 71233,

        [Annotation(Name = "无名永恒之城", Description = "深根底层")]
        TheNamelessEternalCity = 71234,

        [Annotation(Name = "树根前路", Description = "深根底层")]
        AcrossTheRoots = 71235,

        //Elden Throne

        [Annotation(Name = "濒毁玛莉卡", Description = "艾尔登宝座")]
        FracturedMarika = 71900,

        //Elphael, Brace of the Haligtree

        [Annotation(Name = "“腐败女神”玛莲妮亚", Description = "“圣树分枝”艾布雷菲尔")]
        MaleniaGoddessOfRot = 71500,

        [Annotation(Name = "祈祷室", Description = "“圣树分枝”艾布雷菲尔")]
        PrayerRoom = 71501,

        [Annotation(Name = "艾布雷菲尔城墙内部", Description = "“圣树分枝”艾布雷菲尔")]
        ElphaelInnerWall = 71502,

        [Annotation(Name = "排水通道", Description = "“圣树分枝”艾布雷菲尔")]
        DrainageChannel = 71503,

        [Annotation(Name = "圣树底层", Description = "“圣树分枝”艾布雷菲尔")]
        HaligtreeRoots = 71504,

        //Flame Peak

        [Annotation(Name = "巨人战争的英雄墓地", Description = "火焰之巅")]
        GiantConqueringHerosGrave = 73017,

        [Annotation(Name = "巨人山顶地下墓地", Description = "火焰之巅")]
        GiantsMountaintopCatacombs = 73018,

        [Annotation(Name = "巨人墓碑", Description = "火焰之巅")]
        GiantsGravepost = 76506,

        [Annotation(Name = "安歇教堂", Description = "火焰之巅")]
        ChurchOfRepose = 76507,

        [Annotation(Name = "火焰大锅下方", Description = "火焰之巅")]
        FootOfTheForge = 76508,

        [Annotation(Name = "火焰巨人", Description = "火焰之巅")]
        FireGiant = 76509,

        [Annotation(Name = "巨人火焰大锅", Description = "火焰之巅")]
        ForgeOfTheGiants = 76510,

        //Forbidden Lands

        [Annotation(Name = "通往圣树的密道", Description = "禁域")]
        HiddenPathToTheHaligtree = 73020,

        [Annotation(Name = "东亚坛神授塔（门口）", Description = "禁域")]
        DivineTowerOfEastAltusGate = 73450,

        [Annotation(Name = "东亚坛神授塔", Description = "禁域")]
        DivineTowerOfEastAltus = 73451,

        [Annotation(Name = "禁域", Description = "禁域")]
        ForbiddenLands = 76500,

        [Annotation(Name = "洛德大升降机", Description = "禁域")]
        GrandLiftOfRold = 76502,

        //Greyoll's Dragonbarrow

        [Annotation(Name = "龙墓洞窟", Description = "桂奥尔龙墓")]
        DragonbarrowCave = 73110,

        [Annotation(Name = "瑟利亚隐藏洞窟", Description = "桂奥尔龙墓")]
        SelliaHideaway = 73111,

        [Annotation(Name = "盖利德神授塔", Description = "桂奥尔龙墓")]
        DivineTowerOfCaelid = 73440,

        [Annotation(Name = "盖利德神授塔（中段）", Description = "桂奥尔龙墓")]
        DivineTowerOfCaelidCenter = 73441,

        [Annotation(Name = "孤立神授塔", Description = "桂奥尔龙墓")]
        IsolatedDivineTower = 73460,

        [Annotation(Name = "龙墓西方", Description = "桂奥尔龙墓")]
        DragonbarrowWest = 76450,

        [Annotation(Name = "隐居商人的破屋 (桂奥尔龙墓)", Description = "桂奥尔龙墓")]
        IsolatedMerchantsShackGreyollsDragonbarrow = 76451,

        [Annotation(Name = "龙墓的岔路", Description = "桂奥尔龙墓")]
        DragonbarrowFork = 76452,

        [Annotation(Name = "法洛斯要塞", Description = "桂奥尔龙墓")]
        FortFaroth = 76453,

        [Annotation(Name = "野兽神殿", Description = "桂奥尔龙墓")]
        BestialSanctum = 76454,

        [Annotation(Name = "雷恩魔法师塔", Description = "桂奥尔龙墓")]
        LennesRise = 76455,

        [Annotation(Name = "法姆大桥", Description = "桂奥尔龙墓")]
        FarumGreatbridge = 76456,

        //Lake of Rot

        [Annotation(Name = "腐败湖畔", Description = "腐败湖")]
        LakeOfRotShoreside = 71216,

        [Annotation(Name = "大回廊", Description = "腐败湖")]
        GrandCloister = 71218,

        //Leyndell, Ashen Capital

        [Annotation(Name = "艾尔登宝座 (灰城罗德尔)", Description = "灰城罗德尔")]
        EldenThroneLeyndellAshenCapital = 71120,

        [Annotation(Name = "黄金树大教堂 (灰城罗德尔)", Description = "灰城罗德尔")]
        ErdtreeSanctuaryLeyndellAshenCapital = 71121,

        [Annotation(Name = "王城东边城墙 (灰城罗德尔)", Description = "灰城罗德尔")]
        EastCapitalRampartLeyndellAshenCapital = 71122,

        [Annotation(Name = "“灰烬王城”罗德尔", Description = "灰城罗德尔")]
        LeyndellCapitalOfAsh = 71123,

        [Annotation(Name = "女王闺阁 (灰城罗德尔)", Description = "灰城罗德尔")]
        QueensBedchamberLeyndellAshenCapital = 71124,

        [Annotation(Name = "神授桥 (灰城罗德尔)", Description = "灰城罗德尔")]
        DivineBridgeLeyndellAshenCapital = 71125,

        //Leyndell, Royal Capital

        [Annotation(Name = "艾尔登宝座 (王城罗德尔)", Description = "王城罗德尔")]
        EldenThroneLeyndellRoyalCapital = 71100,

        [Annotation(Name = "黄金树大教堂 (王城罗德尔)", Description = "王城罗德尔")]
        ErdtreeSanctuaryLeyndellRoyalCapital = 71101,

        [Annotation(Name = "王城东边城墙 (王城罗德尔)", Description = "王城罗德尔")]
        EastCapitalRampartLeyndellRoyalCapital = 71102,

        [Annotation(Name = "王城底层教堂", Description = "王城罗德尔")]
        LowerCapitalChurch = 71103,

        [Annotation(Name = "大道旁露台", Description = "王城罗德尔")]
        AvenueBalcony = 71104,

        [Annotation(Name = "王城西边城墙", Description = "王城罗德尔")]
        WestCapitalRampart = 71105,

        [Annotation(Name = "女王闺阁 (王城罗德尔)", Description = "王城罗德尔")]
        QueensBedchamberLeyndellRoyalCapital = 71107,

        [Annotation(Name = "城寨一楼", Description = "王城罗德尔")]
        FortifiedManorFirstFloor = 71108,

        [Annotation(Name = "神授桥 (王城罗德尔)", Description = "王城罗德尔")]
        DivineBridgeLeyndellRoyalCapital = 71109,

        //Limgrave

        [Annotation(Name = "风暴根脚的地下墓地", Description = "宁姆格福")]
        StormfootCatacombs = 73002,

        [Annotation(Name = "蒙流地下墓地", Description = "宁姆格福")]
        MurkwaterCatacombs = 73004,

        [Annotation(Name = "蒙流洞窟", Description = "宁姆格福")]
        MurkwaterCave = 73100,

        [Annotation(Name = "近林洞窟", Description = "宁姆格福")]
        GrovesideCave = 73103,

        [Annotation(Name = "海岸洞窟", Description = "宁姆格福")]
        CoastalCave = 73115,

        [Annotation(Name = "大道下的洞窟", Description = "宁姆格福")]
        HighroadCave = 73117,

        [Annotation(Name = "宁姆格福坑道", Description = "宁姆格福")]
        LimgraveTunnels = 73201,

        [Annotation(Name = "艾雷教堂", Description = "宁姆格福")]
        ChurchOfElleh = 76100,

        [Annotation(Name = "引导之始", Description = "宁姆格福")]
        TheFirstStep = 76101,

        [Annotation(Name = "画家的破屋 (宁姆格福)", Description = "宁姆格福")]
        ArtistsShackLimgrave = 76103,

        [Annotation(Name = "玛莉卡第三教堂", Description = "宁姆格福")]
        ThirdChurchOfMarika = 76104,

        [Annotation(Name = "海德要塞西方", Description = "宁姆格福")]
        FortHaightWest = 76105,

        [Annotation(Name = "亚基尔湖南方", Description = "宁姆格福")]
        AgheelLakeSouth = 76106,

        [Annotation(Name = "亚基尔湖北方", Description = "宁姆格福")]
        AgheelLakeNorth = 76108,

        [Annotation(Name = "龙飨教堂", Description = "宁姆格福")]
        ChurchOfDragonCommunion = 76110,

        [Annotation(Name = "关卡前方", Description = "宁姆格福")]
        Gatefront = 76111,

        [Annotation(Name = "傍海古遗迹", Description = "宁姆格福")]
        SeasideRuins = 76113,

        [Annotation(Name = "雾林边缘", Description = "宁姆格福")]
        MistwoodOutskirts = 76114,

        [Annotation(Name = "蒙流岸边", Description = "宁姆格福")]
        MurkwaterCoast = 76116,

        [Annotation(Name = "水唤村外", Description = "宁姆格福")]
        SummonwaterVillageOutskirts = 76119,

        [Annotation(Name = "驿站街遗迹的地下室", Description = "宁姆格福")]
        WaypointRuinsCellar = 76120,

        //Liurnia of the Lakes

        [Annotation(Name = "绝路地下墓地", Description = "湖之利耶尼亚")]
        RoadsEndCatacombs = 73003,

        [Annotation(Name = "黑刀地下墓地", Description = "湖之利耶尼亚")]
        BlackKnifeCatacombs = 73005,

        [Annotation(Name = "断崖下的地下墓地", Description = "湖之利耶尼亚")]
        CliffbottomCatacombs = 73006,

        [Annotation(Name = "留水洞窟", Description = "湖之利耶尼亚")]
        StillwaterCave = 73104,

        [Annotation(Name = "湖旁结晶洞窟", Description = "湖之利耶尼亚")]
        LakesideCrystalCave = 73105,

        [Annotation(Name = "学院结晶洞窟", Description = "湖之利耶尼亚")]
        AcademyCrystalCave = 73106,

        [Annotation(Name = "雷亚卢卡利亚结晶坑道", Description = "湖之利耶尼亚")]
        RayaLucariaCrystalTunnel = 73202,

        [Annotation(Name = "书斋入口", Description = "湖之利耶尼亚")]
        StudyHallEntrance = 73420,

        [Annotation(Name = "利耶尼亚神授塔（桥上）", Description = "湖之利耶尼亚")]
        LiurniaTowerBridge = 73421,

        [Annotation(Name = "利耶尼亚神授塔", Description = "湖之利耶尼亚")]
        DivineTowerOfLiurnia = 73422,

        [Annotation(Name = "傍湖断崖", Description = "湖之利耶尼亚")]
        LakeFacingCliffs = 76200,

        [Annotation(Name = "利耶尼亚湖（湖边）", Description = "湖之利耶尼亚")]
        LiurniaLakeShore = 76201,

        [Annotation(Name = "拉斯卡废墟", Description = "湖之利耶尼亚")]
        LaskyarRuins = 76202,

        [Annotation(Name = "远眺岛", Description = "湖之利耶尼亚")]
        ScenicIsle = 76203,

        [Annotation(Name = "学院门前镇", Description = "湖之利耶尼亚")]
        AcademyGateTown = 76204,

        [Annotation(Name = "雷亚卢卡利亚（南门）", Description = "湖之利耶尼亚")]
        SouthRayaLucariaGate = 76205,

        [Annotation(Name = "学院正门口", Description = "湖之利耶尼亚")]
        MainAcademyGate = 76206,

        [Annotation(Name = "迪可达斯大升降机", Description = "湖之利耶尼亚")]
        GrandLiftOfDectus = 76209,

        [Annotation(Name = "四钟楼山脚", Description = "湖之利耶尼亚")]
        FootOfTheFourBelfries = 76210,

        [Annotation(Name = "魔法师塔的小岛", Description = "湖之利耶尼亚")]
        SorcerersIsle = 76211,

        [Annotation(Name = "利耶尼亚湖（北岸）", Description = "湖之利耶尼亚")]
        NorthernLiurniaLakeShore = 76212,

        [Annotation(Name = "通往城寨的道路", Description = "湖之利耶尼亚")]
        RoadToTheManor = 76213,

        [Annotation(Name = "卡利亚城寨（正门）", Description = "湖之利耶尼亚")]
        MainCariaManorGate = 76214,

        [Annotation(Name = "眠狼的破屋", Description = "湖之利耶尼亚")]
        SlumberingWolfsShack = 76215,

        [Annotation(Name = "煮虾子的破屋", Description = "湖之利耶尼亚")]
        BoilprawnShack = 76216,

        [Annotation(Name = "画家的破屋 (湖之利耶尼亚)", Description = "湖之利耶尼亚")]
        ArtistsShackLiurniaOfTheLakes = 76217,

        [Annotation(Name = "复仇者的破屋", Description = "湖之利耶尼亚")]
        RevengersShack = 76218,

        [Annotation(Name = "湖畔凉亭", Description = "湖之利耶尼亚")]
        FollyonTheLake = 76219,

        [Annotation(Name = "白金村", Description = "湖之利耶尼亚")]
        VillageOfTheAlbinaurics = 76220,

        [Annotation(Name = "利耶尼亚大道（北方）", Description = "湖之利耶尼亚")]
        LiurniaHighwayNorth = 76221,

        [Annotation(Name = "门前镇大桥", Description = "湖之利耶尼亚")]
        GateTownBridge = 76222,

        [Annotation(Name = "利耶尼亚湖（东岸）", Description = "湖之利耶尼亚")]
        EasternLiurniaLakeShore = 76223,

        [Annotation(Name = "结缘教堂", Description = "湖之利耶尼亚")]
        ChurchOfVows = 76224,

        [Annotation(Name = "遗迹迷宫", Description = "湖之利耶尼亚")]
        RuinedLabyrinth = 76225,

        [Annotation(Name = "群集灵庙", Description = "湖之利耶尼亚")]
        MausoleumCompound = 76226,

        [Annotation(Name = "四钟楼", Description = "湖之利耶尼亚")]
        TheFourBelfries = 76227,

        [Annotation(Name = "菈妮魔法师塔", Description = "湖之利耶尼亚")]
        RannisRise = 76228,

        [Annotation(Name = "谷底秘村", Description = "湖之利耶尼亚")]
        RavineVeiledVillage = 76229,

        [Annotation(Name = "城寨上部", Description = "湖之利耶尼亚")]
        ManorUpperLevel = 76230,

        [Annotation(Name = "城寨下部", Description = "湖之利耶尼亚")]
        ManorLowerLevel = 76231,

        [Annotation(Name = "王室赏月地", Description = "湖之利耶尼亚")]
        RoyalMoongazingGrounds = 76232,

        [Annotation(Name = "门前镇的北方", Description = "湖之利耶尼亚")]
        GateTownNorth = 76233,

        [Annotation(Name = "东边台地", Description = "湖之利耶尼亚")]
        EasternTableland = 76234,

        [Annotation(Name = "谷底", Description = "湖之利耶尼亚")]
        TheRavine = 76235,

        [Annotation(Name = "湖中坠落遗迹", Description = "湖之利耶尼亚")]
        FallenRuinsOfTheLake = 76236,

        [Annotation(Name = "改宗塔", Description = "湖之利耶尼亚")]
        ConvertedTower = 76237,

        [Annotation(Name = "卡利亚城寨（后方）", Description = "湖之利耶尼亚")]
        BehindCariaManor = 76238,

        [Annotation(Name = "教堂区", Description = "湖之利耶尼亚")]
        TempleQuarter = 76241,

        [Annotation(Name = "东门桥的桥柱", Description = "湖之利耶尼亚")]
        EastGateBridgeTrestle = 76242,

        [Annotation(Name = "结晶森林", Description = "湖之利耶尼亚")]
        CrystallineWoods = 76243,

        [Annotation(Name = "利耶尼亚大道（南方）", Description = "湖之利耶尼亚")]
        LiurniaHighwaySouth = 76244,

        [Annotation(Name = "壶村", Description = "湖之利耶尼亚")]
        Jarburg = 76245,

        [Annotation(Name = "菈妮的房间", Description = "湖之利耶尼亚")]
        RannisChamber = 76247,

        //Miquella's Haligtree

        [Annotation(Name = "圣树大舞台", Description = "米凯拉的圣树")]
        HaligtreePromenade = 71505,

        [Annotation(Name = "圣树树冠", Description = "米凯拉的圣树")]
        HaligtreeCanopy = 71506,

        [Annotation(Name = "圣树镇", Description = "米凯拉的圣树")]
        HaligtreeTown = 71507,

        [Annotation(Name = "圣树镇（广场）", Description = "米凯拉的圣树")]
        HaligtreeTownPlaza = 71508,

        //Mohgwyn Palace

        [Annotation(Name = "神人坠眠之茧", Description = "蒙格温王朝")]
        CocoonOfTheEmpyrean = 71250,

        [Annotation(Name = "通往王朝的崖上道路", Description = "蒙格温王朝")]
        PalaceApproachLedgeRoad = 71251,

        [Annotation(Name = "王朝庙（入口）", Description = "蒙格温王朝")]
        DynastyMausoleumEntrance = 71252,

        [Annotation(Name = "王朝庙（中段）", Description = "蒙格温王朝")]
        DynastyMausoleumMidpoint = 71253,

        //Moonlight Altar

        [Annotation(Name = "月光祭坛", Description = "月光祭坛")]
        MoonlightAltar = 76250,

        [Annotation(Name = "玛努斯·瑟利斯大教堂", Description = "月光祭坛")]
        CathedralOfManusCeles = 76251,

        [Annotation(Name = "祭坛南方", Description = "月光祭坛")]
        AltarSouth = 76252,

        //Mountaintops of the Giants

        [Annotation(Name = "唤灵洞窟", Description = "巨人山顶")]
        SpiritcallersCave = 73122,

        [Annotation(Name = "萨米尔废墟", Description = "巨人山顶")]
        ZamorRuins = 76501,

        [Annotation(Name = "古遗迹降雪谷", Description = "巨人山顶")]
        AncientSnowValleyRuins = 76503,

        [Annotation(Name = "结冰湖", Description = "巨人山顶")]
        FreezingLake = 76504,

        [Annotation(Name = "玛莉卡第一教堂", Description = "巨人山顶")]
        FirstChurchOfMarika = 76505,

        [Annotation(Name = "降雪棱线路", Description = "巨人山顶")]
        WhiteridgeRoad = 76520,

        [Annotation(Name = "古遗迹山谷的山崖上", Description = "巨人山顶")]
        SnowValleyRuinsOverlook = 76521,

        [Annotation(Name = "索尔城（正门）", Description = "巨人山顶")]
        CastleSolMainGate = 76522,

        [Annotation(Name = "日蚀教堂", Description = "巨人山顶")]
        ChurchOfTheEclipse = 76523,

        [Annotation(Name = "索尔城（屋顶）", Description = "巨人山顶")]
        CastleSolRooftop = 76524,

        //Mt. Gelmir

        [Annotation(Name = "威达姆地下墓地", Description = "格密尔火山")]
        WyndhamCatacombs = 73007,

        [Annotation(Name = "格密尔英雄墓地", Description = "格密尔火山")]
        GelmirHerosGrave = 73009,

        [Annotation(Name = "沸滚河洞窟", Description = "格密尔火山")]
        SeethewaterCave = 73107,

        [Annotation(Name = "火山洞窟", Description = "格密尔火山")]
        VolcanoCave = 73109,

        [Annotation(Name = "罪人桥", Description = "格密尔火山")]
        BridgeOfIniquity = 76350,

        [Annotation(Name = "格密尔火山（第１休息站）", Description = "格密尔火山")]
        FirstMtGelmirCampsite = 76351,

        [Annotation(Name = "格密尔火山（第９休息站）", Description = "格密尔火山")]
        NinthMtGelmirCampsite = 76352,

        [Annotation(Name = "移送罪人之路", Description = "格密尔火山")]
        RoadOfIniquity = 76353,

        [Annotation(Name = "沸滚河", Description = "格密尔火山")]
        SeethewaterRiver = 76354,

        [Annotation(Name = "沸滚河终点", Description = "格密尔火山")]
        SeethewaterTerminus = 76355,

        [Annotation(Name = "匠人的破屋", Description = "格密尔火山")]
        CraftsmansShack = 76356,

        [Annotation(Name = "“起源魔法师”亚兹勒", Description = "格密尔火山")]
        PrimevalSorcererAzur = 76357,

        //Nokron, Eternal City

        [Annotation(Name = "大瀑布水潭", Description = "“永恒之城”诺克隆恩")]
        GreatWaterfallBasin = 71220,

        [Annotation(Name = "仿身泪滴", Description = "“永恒之城”诺克隆恩")]
        MimicTear = 71221,

        [Annotation(Name = "祖灵森林", Description = "“永恒之城”诺克隆恩")]
        AncestralWoods = 71224,

        [Annotation(Name = "导水桥旁断崖", Description = "“永恒之城”诺克隆恩")]
        AqueductFacingCliffs = 71225,

        [Annotation(Name = "黑夜神域", Description = "“永恒之城”诺克隆恩")]
        NightsSacredGround = 71226,

        [Annotation(Name = "“永恒之城”诺克隆恩", Description = "“永恒之城”诺克隆恩")]
        NokronEternalCity = 71271,

        //Roundtable Hold

        [Annotation(Name = "大赐福", Description = "圆桌厅堂")]
        TableOfLostGrace = 71190,

        //Ruin-Strewn Precipice

        [Annotation(Name = "熔岩土龙", Description = "古遗迹断崖")]
        MagmaWyrm = 73900,

        [Annotation(Name = "古遗迹断崖", Description = "古遗迹断崖")]
        RuinStrewnPrecipice = 73901,

        [Annotation(Name = "古遗迹断崖（对岸）", Description = "古遗迹断崖")]
        RuinStrewnPrecipiceOverlook = 73902,

        //Siofra River

        [Annotation(Name = "希芙拉河（岸边）", Description = "希芙拉河")]
        SiofraRiverBank = 71222,

        [Annotation(Name = "信仰者森林", Description = "希芙拉河")]
        WorshippersWoods = 71223,

        [Annotation(Name = "出口井的下方", Description = "希芙拉河")]
        BelowTheWell = 71227,

        [Annotation(Name = "希芙拉河（井底）", Description = "希芙拉河")]
        SiofraRiverWellDepths = 71270,

        //Stormhill

        [Annotation(Name = "死亡降临的地下墓地", Description = "风暴山丘")]
        DeathtouchedCatacombs = 73011,

        [Annotation(Name = "宁姆格福神授塔（桥上）", Description = "风暴山丘")]
        LimgraveTowerBridge = 73410,

        [Annotation(Name = "宁姆格福神授塔", Description = "风暴山丘")]
        DivineTowerOfLimgrave = 73412,

        [Annotation(Name = "风暴山丘的破屋", Description = "风暴山丘")]
        StormhillShack = 76102,

        [Annotation(Name = "圣人桥", Description = "风暴山丘")]
        Saintsbridge = 76117,

        [Annotation(Name = "习战者的破屋", Description = "风暴山丘")]
        WarmastersShack = 76118,

        //Stormveil Castle

        [Annotation(Name = "“接肢”葛瑞克", Description = "史东薇尔城")]
        GodrickTheGrafted = 71000,

        [Annotation(Name = "“恶兆妖鬼”玛尔基特", Description = "史东薇尔城")]
        MargitTheFellOmen = 71001,

        [Annotation(Name = "通城隧道", Description = "史东薇尔城")]
        CastlewardTunnel = 71002,

        [Annotation(Name = "门旁小屋", Description = "史东薇尔城")]
        GatesideChamber = 71003,

        [Annotation(Name = "史东薇尔断崖", Description = "史东薇尔城")]
        StormveilCliffside = 71004,

        [Annotation(Name = "城墙塔", Description = "史东薇尔城")]
        RampartTower = 71005,

        [Annotation(Name = "升降机旁房间", Description = "史东薇尔城")]
        LiftsideChamber = 71006,

        [Annotation(Name = "深处小房间", Description = "史东薇尔城")]
        SecludedCell = 71007,

        [Annotation(Name = "史东薇尔正门", Description = "史东薇尔城")]
        StormveilMainGate = 71008,

        //Stranded Graveyard

        [Annotation(Name = "求学洞窟", Description = "漂流墓地")]
        CaveOfKnowledge = 71800,

        [Annotation(Name = "漂流墓地", Description = "漂流墓地")]
        StrandedGraveyard = 71801,

        //Subterranean Shunning-Grounds

        [Annotation(Name = "弃置恶兆的大教堂", Description = "弃置恶兆的地底")]
        CathedralOfTheForsaken = 73500,

        [Annotation(Name = "地底大道旁", Description = "弃置恶兆的地底")]
        UndergroundRoadside = 73501,

        [Annotation(Name = "弃置恶兆的底层", Description = "弃置恶兆的地底")]
        ForsakenDepths = 73502,

        [Annotation(Name = "罗德尔地下墓地", Description = "弃置恶兆的地底")]
        LeyndellCatacombs = 73503,

        [Annotation(Name = "癫火封印", Description = "弃置恶兆的地底")]
        FrenziedFlameProscription = 73504,

        //Swamp of Aeonia

        [Annotation(Name = "艾奥尼亚沼泽（岸边）", Description = "艾奥尼亚沼泽")]
        AeoniaSwampShore = 76406,

        [Annotation(Name = "盖利德大道北方（偏离大道后）", Description = "艾奥尼亚沼泽")]
        AstrayfromCaelidHighwayNorth = 76407,

        [Annotation(Name = "艾奥尼亚中心地", Description = "艾奥尼亚沼泽")]
        HeartOfAeonia = 76412,

        [Annotation(Name = "艾奥尼亚沼泽（深处）", Description = "艾奥尼亚沼泽")]
        InnerAeonia = 76413,

        //Volcano Manor

        [Annotation(Name = "“亵渎君王”拉卡德", Description = "火山官邸")]
        RykardLordOfBlasphemy = 71600,

        [Annotation(Name = "艾格蕾教堂", Description = "火山官邸")]
        TempleOfEiglay = 71601,

        [Annotation(Name = "火山官邸", Description = "火山官邸")]
        VolcanoManor = 71602,

        [Annotation(Name = "牢镇教堂", Description = "火山官邸")]
        PrisonTownChurch = 71603,

        [Annotation(Name = "迎宾厅", Description = "火山官邸")]
        GuestHall = 71604,

        [Annotation(Name = "谒见之路", Description = "火山官邸")]
        AudiencePathway = 71605,

        [Annotation(Name = "掳人少女人偶", Description = "火山官邸")]
        AbductorVirgin = 71606,

        [Annotation(Name = "地底拷问所", Description = "火山官邸")]
        SubterraneanInquisitionChamber = 71607,

        //Weeping Peninsula

        [Annotation(Name = "灵庙原野地下墓地", Description = "啜泣半岛")]
        TombswardCatacombs = 73000,

        [Annotation(Name = "穿刺地下墓地", Description = "啜泣半岛")]
        ImpalersCatacombs = 73001,

        [Annotation(Name = "垂穴洞窟", Description = "啜泣半岛")]
        EarthboreCave = 73101,

        [Annotation(Name = "灵庙原野洞窟", Description = "啜泣半岛")]
        TombswardCave = 73102,

        [Annotation(Name = "摩恩坑道", Description = "啜泣半岛")]
        MorneTunnel = 73200,

        [Annotation(Name = "巡礼教堂", Description = "啜泣半岛")]
        ChurchOfPilgrimage = 76150,

        [Annotation(Name = "摩恩城（城墙前方）", Description = "啜泣半岛")]
        CastleMorneRampart = 76151,

        [Annotation(Name = "灵庙原野", Description = "啜泣半岛")]
        Tombsward = 76152,

        [Annotation(Name = "监视塔的南方", Description = "啜泣半岛")]
        SouthOfTheLookoutTower = 76153,

        [Annotation(Name = "病村外", Description = "啜泣半岛")]
        AilingVillageOutskirts = 76154,

        [Annotation(Name = "地坑旁", Description = "啜泣半岛")]
        BesideTheCraterPockedGlade = 76155,

        [Annotation(Name = "隐居商人的破屋 (啜泣半岛)", Description = "啜泣半岛")]
        IsolatedMerchantsShackWeepingPeninsula = 76156,

        [Annotation(Name = "献祭大桥", Description = "啜泣半岛")]
        BridgeOfSacrifice = 76157,

        [Annotation(Name = "摩恩城（升降机前方）", Description = "啜泣半岛")]
        CastleMorneLift = 76158,

        [Annotation(Name = "城堡后方", Description = "啜泣半岛")]
        BehindTheCastle = 76159,

        [Annotation(Name = "城墙监牢旁", Description = "啜泣半岛")]
        BesideTheRampartGaol = 76160,

        [Annotation(Name = "摩恩悲叹墓", Description = "啜泣半岛")]
        MorneMoangrave = 76161,

        [Annotation(Name = "玛莉卡第四教堂", Description = "啜泣半岛")]
        FourthChurchOfMarika = 76162,

        // The Realm of Shadow
        [Annotation(Name = "神兽舞台", Description = "“塔之镇”贝瑞特")]
        TheatreoftheDivineBeast = 72000,

        [Annotation(Name = "“塔之镇”贝瑞特", Description = "“塔之镇”贝瑞特")]
        BeluratTowerSettlement = 72001,

        [Annotation(Name = "民宅小祭坛", Description = "“塔之镇”贝瑞特")]
        SmallPrivateAltar = 72002,

        [Annotation(Name = "舞台前方", Description = "“塔之镇”贝瑞特")]
        Stagefront = 72003,

        [Annotation(Name = "神之门", Description = "艾尼尔·伊利姆")]
        GateofDivinity = 72010,

        [Annotation(Name = "艾尼尔·伊利姆外墙", Description = "艾尼尔·伊利姆")]
        EnirIlimOuterWall = 72012,

        [Annotation(Name = "第一塔", Description = "艾尼尔·伊利姆")]
        FirstRise = 72013,

        [Annotation(Name = "螺旋塔", Description = "艾尼尔·伊利姆")]
        SpiralRise = 72014,

        [Annotation(Name = "净身厅前室", Description = "艾尼尔·伊利姆")]
        CleansingChamberAnteroom = 72015,

        [Annotation(Name = "神之门（门前楼梯平台）", Description = "艾尼尔·伊利姆")]
        DivineGateFrontStaircase = 72016,

        [Annotation(Name = "正门广场", Description = "幽影城")]
        MainGatePlaza = 72101,

        [Annotation(Name = "幽影城（正门）", Description = "幽影城")]
        ShadowKeepMainGate = 72102,

        [Annotation(Name = "教区入口", Description = "幽影城（教区）")]
        ChurchDistrictEntrance = 72106,

        [Annotation(Name = "沉水礼拜堂", Description = "幽影城（教区）")]
        SunkenChapel = 72107,

        [Annotation(Name = "礼树暗道", Description = "幽影城（教区）")]
        TreeWorshipPassage = 72108,

        [Annotation(Name = "礼树教堂", Description = "幽影城（教区）")]
        TreeWorshipSanctum = 72109,

        [Annotation(Name = "梅瑟莫的暗室", Description = "物种保藏库")]
        MessmersDarkChamber = 72110,

        [Annotation(Name = "保藏库（一楼）", Description = "物种保藏库")]
        StorehouseFirstFloor = 72111,

        [Annotation(Name = "保藏库（四楼）", Description = "物种保藏库")]
        StorehouseFourthFloor = 72112,

        [Annotation(Name = "保藏库（七楼）", Description = "物种保藏库")]
        StorehouseSeventhFloor = 72113,

        [Annotation(Name = "暗室门前", Description = "物种保藏库")]
        DarkChamberEntrance = 72114,

        [Annotation(Name = "保藏库（内区）", Description = "物种保藏库")]
        StorehouseBackSection = 72116,

        [Annotation(Name = "保藏库（阁楼）", Description = "物种保藏库")]
        StorehouseLoft = 72117,

        [Annotation(Name = "西边城墙", Description = "物种保藏库")]
        WestRampart = 72120,

        [Annotation(Name = "深紫花园", Description = "石棺大洞")]
        GardenofDeepPurple = 72200,

        [Annotation(Name = "石棺大洞", Description = "石棺大洞")]
        StoneCoffinFissure = 72201,

        [Annotation(Name = "大洞的十字记号", Description = "石棺大洞")]
        FissureCross = 72202,

        [Annotation(Name = "大洞中段", Description = "石棺大洞")]
        FissureWaypoint = 72203,

        [Annotation(Name = "大洞深处", Description = "石棺大洞")]
        FissureDepths = 72204,

        [Annotation(Name = "指头产房", Description = "幽影亚坛")]
        FingerBirthingGrounds = 72500,

        [Annotation(Name = "对谈室", Description = "米德拉府邸")]
        DiscussionChamber = 72800,

        [Annotation(Name = "府邸大厅", Description = "米德拉府邸")]
        ManseHall = 72801,

        [Annotation(Name = "米德拉的书库", Description = "米德拉府邸")]
        MidrasLibrary = 72802,

        [Annotation(Name = "二楼小房间", Description = "米德拉府邸")]
        SecondFloorChamber = 72803,

        [Annotation(Name = "雾谷地下墓地", Description = "墓地平原")]
        FogRiftCatacombs = 74000,

        [Annotation(Name = "熔岩管锻造遗迹", Description = "墓地平原")]
        RuinedForgeLavaIntake = 74200,

        [Annotation(Name = "河尾洞窟", Description = "墓地平原")]
        RivermouthCave = 74300,

        [Annotation(Name = "龙洞", Description = "墓地平原")]
        DragonsPit = 74301,

        [Annotation(Name = "龙洞（终点）", Description = "墓地平原")]
        DragonsPitTerminus = 74351,

        [Annotation(Name = "崖上道路的终点", Description = "墓地平原")]
        CliffroadTerminus = 76804,

        [Annotation(Name = "正门前方的十字记号", Description = "墓地平原")]
        MainGateCross = 76803,

        [Annotation(Name = "墓地平原", Description = "墓地平原")]
        GravesitePlain = 76800,

        [Annotation(Name = "三叉口的十字记号", Description = "墓地平原")]
        ThreePathCross = 76802,

        [Annotation(Name = "大桥北方", Description = "墓地平原")]
        GreatbridgeNorth = 76805,

        [Annotation(Name = "火吻废墟", Description = "墓地平原")]
        ScorchedRuins = 76801,

        [Annotation(Name = "艾拉克河洞窟", Description = "墓地平原")]
        EllacRiverCave = 76812,

        [Annotation(Name = "城的前方", Description = "墓地平原")]
        CastleFront = 76813,

        [Annotation(Name = "通柱坡中段", Description = "墓地平原")]
        PillarPathWaypoint = 76811,

        [Annotation(Name = "通柱坡的十字记号", Description = "墓地平原")]
        PillarPathCross = 76810,

        [Annotation(Name = "贝瑞特监牢", Description = "墓地平原")]
        BeluratGaol = 74100,

        [Annotation(Name = "艾拉克河下游", Description = "墓地平原")]
        EllacRiverDownstream = 76830,

        [Annotation(Name = "卡罗隐藏墓地", Description = "卡罗隐藏墓地")]
        CharosHiddenGrave = 76841,

        [Annotation(Name = "喟叹监牢", Description = "卡罗隐藏墓地")]
        LamentersGaol = 74102,

        [Annotation(Name = "恩希斯城（关卡）", Description = "恩希斯城")]
        CastleEnsisCheckpoint = 76821,

        [Annotation(Name = "恩希斯赏月地", Description = "恩希斯城")]
        EnsisMoongazingGrounds = 76823,

        [Annotation(Name = "城主的房间", Description = "恩希斯城")]
        CastleLordsChamber = 76822,

        [Annotation(Name = "青蓝海岸西边", Description = "青蓝海岸")]
        CeruleanCoastWest = 76832,

        [Annotation(Name = "大洞", Description = "青蓝海岸")]
        TheFissure = 76833,

        [Annotation(Name = "青蓝海岸的十字记号", Description = "青蓝海岸")]
        CeruleanCoastCross = 76835,

        [Annotation(Name = "青蓝海岸", Description = "青蓝海岸")]
        CeruleanCoast = 76831,

        [Annotation(Name = "利亚指头遗迹", Description = "青蓝海岸")]
        FingerRuinsofRhia = 76834,

        [Annotation(Name = "龙飨大祭坛", Description = "尖刺山的山脚")]
        GrandAltarofDragonCommunion = 76840,

        [Annotation(Name = "水帘瀑布", Description = "谷底森林")]
        DividedFalls = 76861,

        [Annotation(Name = "谷底森林", Description = "谷底森林")]
        AbyssalWoods = 76860,

        [Annotation(Name = "荒废墓地", Description = "谷底森林")]
        ForsakenGraveyard = 76862,

        [Annotation(Name = "废弃教堂", Description = "谷底森林")]
        ChurchRuins = 76864,

        [Annotation(Name = "林中兽径", Description = "谷底森林")]
        WoodlandTrail = 76863,

        [Annotation(Name = "尖刺山的山脚", Description = "尖刺山的山脚")]
        FootoftheJaggedPeak = 76850,

        [Annotation(Name = "尖刺山（中段）", Description = "尖刺山")]
        JaggedPeakMountainside = 76851,

        [Annotation(Name = "尖刺山（山顶）", Description = "尖刺山")]
        JaggedPeakSummit = 76852,

        [Annotation(Name = "狂龙之席", Description = "尖刺山")]
        RestoftheDreadDragon = 76853,

        [Annotation(Name = "古遗迹（大楼梯）", Description = "劳弗古遗迹")]
        AncientRuinsGrandStairway = 76944,

        [Annotation(Name = "花蕾教堂", Description = "劳弗古遗迹")]
        ChurchoftheBud = 76945,

        [Annotation(Name = "花蕾教堂（正门口）", Description = "劳弗古遗迹")]
        ChurchoftheBudMainEntrance = 76943,

        [Annotation(Name = "劳弗古遗迹（西方）", Description = "劳弗古遗迹")]
        RauhAncientRuinsWest = 76942,

        [Annotation(Name = "劳弗古遗迹（东方）", Description = "劳弗古遗迹")]
        RauhAncientRuinsEast = 76941,

        [Annotation(Name = "高架桥的小塔", Description = "劳弗古遗迹")]
        ViaductMinorTower = 76940,

        [Annotation(Name = "神殿镇废墟", Description = "劳弗下方")]
        TempleTownRuins = 76913,

        [Annotation(Name = "峡谷北方", Description = "劳弗下方")]
        RavineNorth = 76914,

        [Annotation(Name = "蝎河地下墓地", Description = "劳弗下方")]
        ScorpionRiverCatacombs = 74001,

        [Annotation(Name = "泰乌尔锻造遗迹", Description = "劳弗下方")]
        TaylewsRuinedForge = 74203,

        [Annotation(Name = "古遗迹下方", Description = "劳弗下方")]
        AncientRuinsBase = 76912,

        [Annotation(Name = "驱暗地下墓地", Description = "幽影亚坛")]
        DarklightCatacombs = 74002,

        [Annotation(Name = "波尼监牢", Description = "幽影亚坛")]
        BonnyGaol = 74101,

        [Annotation(Name = "大道旁的十字记号", Description = "幽影亚坛")]
        HighroadCross = 76900,

        [Annotation(Name = "幽影亚坛（西方）", Description = "幽影亚坛")]
        ScaduAltusWest = 76907,

        [Annotation(Name = "穆斯大道（南方）", Description = "幽影亚坛")]
        MoorthHighwaySouth = 76908,

        [Annotation(Name = "惩罚要塞", Description = "幽影亚坛")]
        FortofReprimand = 76909,

        [Annotation(Name = "惩罚要塞（后方）", Description = "幽影亚坛")]
        BehindtheFortofReprimand = 76910,

        [Annotation(Name = "穆斯废墟", Description = "幽影亚坛")]
        MoorthRuins = 76902,

        [Annotation(Name = "波尼村", Description = "幽影亚坛")]
        BonnyVillage = 76903,

        [Annotation(Name = "城底积水处", Description = "幽影亚坛")]
        CastleWateringHole = 76916,

        [Annotation(Name = "古铁陨石锻造遗迹", Description = "幽影亚坛")]
        RuinedForgeofStarfallPast = 74202,

        [Annotation(Name = "远望幽影树的十字记号", Description = "幽影亚坛")]
        ScaduviewCross = 76911,

        [Annotation(Name = "隐者河下游", Description = "幽影亚坛")]
        ReclusesRiverDownstream = 76918,

        [Annotation(Name = "隐者河上游", Description = "幽影亚坛")]
        ReclusesRiverUpstream = 76917,

        [Annotation(Name = "通村吊桥", Description = "幽影亚坛")]
        BridgeLeadingtotheVillage = 76904,

        [Annotation(Name = "玛努斯·美特大教堂", Description = "幽影亚坛")]
        CathedralofManusMetyr = 76906,

        [Annotation(Name = "教区大道", Description = "幽影亚坛")]
        ChurchDistrictHighroad = 76905,

        [Annotation(Name = "望影露台", Description = "望影露台")]
        Scaduview = 76930,

        [Annotation(Name = "幽影城（后门）", Description = "望影露台")]
        ShadowKeepBackGate = 76931,

        [Annotation(Name = "指岩山丘", Description = "望影露台")]
        FingerstoneHill = 76936,

        [Annotation(Name = "隐匿之地（桥边）", Description = "望影露台")]
        HinterlandBridge = 76937,

        [Annotation(Name = "隐匿之地", Description = "望影露台")]
        Hinterland = 76935,

        [Annotation(Name = "幽影树的树脚", Description = "望影露台")]
        ScadutreeBase = 76960,
    }
}