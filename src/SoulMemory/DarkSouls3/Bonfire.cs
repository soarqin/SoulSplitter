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
    public enum Bonfire : uint
    {
        [AnnotationAttribute(Name = "传火祭祀场", Description = "灰烬墓地")]
        FirelinkShrine = 14000000,

        [AnnotationAttribute(Name = "灰烬墓地", Description = "灰烬墓地")]
        CemeteryOfAsh = 14000001,

        [AnnotationAttribute(Name = "“灰烬审判者”古达", Description = "灰烬墓地")]
        IudexGundyr = 14000002,

        [AnnotationAttribute(Name = "无主墓地", Description = "灰烬墓地")]
        UntendedGraves = 14000003,

        [AnnotationAttribute(Name = "英雄古达", Description = "灰烬墓地")]
        ChampionGundyr = 14000004,

        [AnnotationAttribute(Name = "洛斯里克的高墙", Description = "洛斯里克的高墙")]
        HighWallOfLothric = 13000009,

        [AnnotationAttribute(Name = "高墙边塔", Description = "洛斯里克的高墙")]
        TowerOnTheWall = 13000005,

        [AnnotationAttribute(Name = "冷冽谷的玻尔多", Description = "洛斯里克的高墙")]
        VordtOfTheBorealValley = 13000002,

        [AnnotationAttribute(Name = "冷冽谷的舞娘", Description = "洛斯里克的高墙")]
        DancerOfTheBorealValley = 13000004,

        [AnnotationAttribute(Name = "妖王欧斯罗艾斯", Description = "洛斯里克的高墙")]
        OceirosTheConsumedKing = 13000001,

        [AnnotationAttribute(Name = "高墙下方", Description = "不死聚落")]
        FootOfTheHighWall = 13100004,

        [AnnotationAttribute(Name = "不死聚落", Description = "不死聚落")]
        UndeadSettlement = 13100000,

        [AnnotationAttribute(Name = "悬崖下地下室", Description = "不死聚落")]
        CliffUnderside = 13100002,

        [AnnotationAttribute(Name = "颓旧桥端", Description = "不死聚落")]
        DilapidatedBridge = 13100003,

        [AnnotationAttribute(Name = "游魂的穴屋", Description = "不死聚落")]
        PitOfHollows = 13100001,

        [AnnotationAttribute(Name = "活祭品之路", Description = "活祭品之路")]
        RoadOfSacrifices = 13300006,

        [AnnotationAttribute(Name = "路半边寨", Description = "活祭品之路")]
        HalfwayFortress = 13300000,

        [AnnotationAttribute(Name = "磔罚森林", Description = "活祭品之路")]
        CrucifixionWoods = 13300007,

        [AnnotationAttribute(Name = "结晶老者", Description = "活祭品之路")]
        CrystalSage = 13300002,

        [AnnotationAttribute(Name = "法兰要塞", Description = "活祭品之路")]
        FarronKeep = 13300003,

        [AnnotationAttribute(Name = "要塞遗迹", Description = "活祭品之路")]
        KeepRuins = 13300004,

        [AnnotationAttribute(Name = "要塞外围", Description = "活祭品之路")]
        FarronKeepPerimeter = 13300008,

        [AnnotationAttribute(Name = "法兰老狼", Description = "活祭品之路")]
        OldWolfOfFarron = 13300005,

        [AnnotationAttribute(Name = "深渊的监视者", Description = "活祭品之路")]
        AbyssWatchers = 13300001,

        [AnnotationAttribute(Name = "幽邃教堂", Description = "幽邃教堂")]
        CathedralOfTheDeep = 13500003,

        [AnnotationAttribute(Name = "净身小教会", Description = "幽邃教堂")]
        CleansingChapel = 13500000,

        [AnnotationAttribute(Name = "罗莎莉亚寝室", Description = "幽邃教堂")]
        RosariasBedChamber = 13500002,

        [AnnotationAttribute(Name = "幽邃主教群", Description = "幽邃教堂")]
        DeaconsOfTheDeep = 13500001,

        [AnnotationAttribute(Name = "卡萨斯的地下墓地", Description = "卡萨斯的地下墓地")]
        CatacombsOfCarthus = 13800006,

        [AnnotationAttribute(Name = "霸王沃尼尔", Description = "卡萨斯的地下墓地")]
        HighLordWolnir = 13800000,

        [AnnotationAttribute(Name = "废弃地下墓地", Description = "卡萨斯的地下墓地")]
        AbandonedTomb = 13800001,

        [AnnotationAttribute(Name = "老王门厅", Description = "卡萨斯的地下墓地")]
        OldKingsAntechamber = 13800002,

        [AnnotationAttribute(Name = "Demon Ruins", Description = "卡萨斯的地下墓地")]
        DemonRuins = 13800003,

        [AnnotationAttribute(Name = "老恶魔王", Description = "卡萨斯的地下墓地")]
        OldDemonKing = 13800004,

        [AnnotationAttribute(Name = "冷冽谷的伊鲁席尔", Description = "冷冽谷的伊鲁席尔")]
        IrithyllOfTheBorealValley = 13700007,

        [AnnotationAttribute(Name = "伊鲁席尔街道", Description = "冷冽谷的伊鲁席尔")]
        CentralIrithyll = 13700004,

        [AnnotationAttribute(Name = "幽儿希卡教会", Description = "冷冽谷的伊鲁席尔")]
        ChurchOfYorshka = 13700000,

        [AnnotationAttribute(Name = "离街废屋", Description = "冷冽谷的伊鲁席尔")]
        DistantManor = 13700005,

        [AnnotationAttribute(Name = "教宗沙力万", Description = "冷冽谷的伊鲁席尔")]
        PontiffSulyvahn = 13700001,

        [AnnotationAttribute(Name = "储水槽", Description = "冷冽谷的伊鲁席尔")]
        WaterReserve = 13700006,

        [AnnotationAttribute(Name = "亚诺尔隆德", Description = "冷冽谷的伊鲁席尔")]
        AnorLondo = 13700003,

        [AnnotationAttribute(Name = "俘虏之塔", Description = "冷冽谷的伊鲁席尔")]
        PrisonTower = 13700008,

        [AnnotationAttribute(Name = "吞噬神明的艾尔德利奇", Description = "冷冽谷的伊鲁席尔")]
        AldrichDevourerOfGods = 13700002,

        [AnnotationAttribute(Name = "伊鲁席尔地下监牢", Description = "伊鲁席尔地下监牢")]
        IrithyllDungeon = 13900000,

        [AnnotationAttribute(Name = "罪业之都", Description = "伊鲁席尔地下监牢")]
        ProfanedCapital = 13900002,

        [AnnotationAttribute(Name = "巨人尤姆", Description = "伊鲁席尔地下监牢")]
        YhormTheGiant = 13900001,

        [AnnotationAttribute(Name = "洛斯里克城", Description = "洛斯里克城")]
        LothricCastle = 13010000,

        [AnnotationAttribute(Name = "龙训练场", Description = "洛斯里克城")]
        DragonBarracks = 13010002,

        [AnnotationAttribute(Name = "猎龙铠甲", Description = "洛斯里克城")]
        DragonslayerArmour = 13010001,

        [AnnotationAttribute(Name = "大书库", Description = "洛斯里克城")]
        GrandArchives = 13410001,

        [AnnotationAttribute(Name = "孪生王子", Description = "洛斯里克城")]
        TwinPrinces = 13410000,

        [AnnotationAttribute(Name = "古龙顶端", Description = "古龙顶端")]
        ArchdragonPeak = 13200000,

        [AnnotationAttribute(Name = "龙人灵庙", Description = "古龙顶端")]
        DragonKinMausoleum = 13200003,

        [AnnotationAttribute(Name = "大钟楼", Description = "古龙顶端")]
        GreatBelfry = 13200002,

        [AnnotationAttribute(Name = "无名王者", Description = "古龙顶端")]
        NamelessKing = 13200001,

        [AnnotationAttribute(Name = "火已消逝的祭祀场", Description = "初始之火的火炉")]
        FlamelessShrine = 14100000,

        [AnnotationAttribute(Name = "初始之火的火炉", Description = "初始之火的火炉")]
        KilnOfTheFirstFlame = 14100001,

        [AnnotationAttribute(Name = "雪原", Description = "艾雷德尔的绘画世界")]
        Snowfield = 14500001,

        [AnnotationAttribute(Name = "吊桥近窟", Description = "艾雷德尔的绘画世界")]
        RopeBridgeCave = 14500002,

        [AnnotationAttribute(Name = "鸦村", Description = "艾雷德尔的绘画世界")]
        CorvianSettlement = 14500003,

        [AnnotationAttribute(Name = "覆雪山径", Description = "艾雷德尔的绘画世界")]
        SnowyMountainPass = 14500004,

        [AnnotationAttribute(Name = "艾雷德尔礼拜堂", Description = "艾雷德尔的绘画世界")]
        AriandelChapel = 14500005,

        [AnnotationAttribute(Name = "芙莉德修女", Description = "艾雷德尔的绘画世界")]
        SisterFriede = 14500000,

        [AnnotationAttribute(Name = "绘画底端", Description = "艾雷德尔的绘画世界")]
        DepthsOfThePainting = 14500007,

        [AnnotationAttribute(Name = "王者的守墓人", Description = "艾雷德尔的绘画世界")]
        ChampionsGravetender = 14500006,

        [AnnotationAttribute(Name = "聚集地", Description = "聚集地")]
        TheDregHeap = 15000001,

        [AnnotationAttribute(Name = "堆土塔残骸", Description = "聚集地")]
        EarthenPeakRuins = 15000002,

        [AnnotationAttribute(Name = "堆土塔残骸：内部", Description = "聚集地")]
        WithinTheEarthenPeakRuins = 15000003,

        [AnnotationAttribute(Name = "恶魔王子", Description = "聚集地")]
        TheDemonPrince = 15000000,

        [AnnotationAttribute(Name = "王庙守卫", Description = "环印城")]
        MausoleumLookout = 15100002,

        [AnnotationAttribute(Name = "环状墙内部", Description = "环印城")]
        RingedInnerWall = 15100003,

        [AnnotationAttribute(Name = "环印城市街", Description = "环印城")]
        RingedCityStreets = 15100004,

        [AnnotationAttribute(Name = "公墓", Description = "环印城")]
        SharedGrave = 15100005,

        [AnnotationAttribute(Name = "费莲诺尔教堂", Description = "环印城")]
        ChurchOfFilianore = 15100000,

        [AnnotationAttribute(Name = "吞噬黑暗的米狄尔", Description = "环印城")]
        DarkeaterMidir = 15100001,

        [AnnotationAttribute(Name = "费莲诺尔寝房", Description = "环印城")]
        FilianoresRest = 15110001,

        [AnnotationAttribute(Name = "奴隶骑士盖尔", Description = "环印城")]
        SlaveKnightGael = 15110000,
    }
}