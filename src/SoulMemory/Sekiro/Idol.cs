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

namespace SoulMemory.Sekiro
{
    [XmlType(Namespace = "Sekiro")]
    public enum Idol
    {
        [Annotation(Name = "破旧寺院", Description = "苇名城 城邑")]
        DilapidatedTemple = 11100000,

        [Annotation(Name = "苇名城 城邑", Description = "苇名城 城邑")]
        AshinaOutskirts = 11100006,

        [Annotation(Name = "城邑外围 城门道", Description = "苇名城 城邑")]
        OutskirtsWallGatePath = 11100001,

        [Annotation(Name = "城邑外围 虎口阶梯", Description = "苇名城 城邑")]
        OutskirtsWallStairway = 11100002,

        [Annotation(Name = "桥下山谷", Description = "苇名城 城邑")]
        UnderbridgeValley = 11100003,

        [Annotation(Name = "正门外城区", Description = "苇名城 城邑")]
        AshinaCastleFortress = 11100004,

        [Annotation(Name = "正门", Description = "苇名城 城邑")]
        AshinaCastleGate = 11100005,

        [Annotation(Name = "怨恨之火", Description = "苇名城 城邑")]
        FlamesOfHatred = 11100007,

        [Annotation(Name = "龙泉河畔 平田宅邸", Description = "龙泉河畔 平田宅邸")]
        DragonspringHirataEstate = 11000000,

        [Annotation(Name = "宅邸街", Description = "龙泉河畔 平田宅邸")]
        EstatePath = 11000001,

        [Annotation(Name = "竹林坡", Description = "龙泉河畔 平田宅邸")]
        BambooThicketSlope = 11000002,

        [Annotation(Name = "平田宅邸 主宅", Description = "龙泉河畔 平田宅邸")]
        HirataEstateMainHall = 11000003,

        [Annotation(Name = "平田宅邸 回廊", Description = "龙泉河畔 平田宅邸")]
        HirataAudienceChamber = 11000005,

        [Annotation(Name = "平田宅邸 隐藏佛堂", Description = "龙泉河畔 平田宅邸")]
        HirataEstateHiddenTemple = 11000004,

        [Annotation(Name = "苇名城 主城", Description = "苇名城 主城")]
        AshinaCastle = 11110000,

        [Annotation(Name = "天守阁上层 武士候命室", Description = "苇名城 主城")]
        UpperTowerAntechamber = 11110001,

        [Annotation(Name = "天守阁上层 苇名流道场", Description = "苇名城 主城")]
        UpperTowerAshinaDojo = 11110007,

        [Annotation(Name = "天守阁望楼", Description = "苇名城 主城")]
        CastleTowerLookout = 11110002,

        [Annotation(Name = "天守阁上层 神子居室", Description = "苇名城 主城")]
        UpperTowerKurosRoom = 11110003,

        [Annotation(Name = "遗冢", Description = "苇名城 主城")]
        OldGrave = 11110006,

        [Annotation(Name = "白蛇神社", Description = "苇名城 主城")]
        GreatSerpentShrine = 11110004,

        [Annotation(Name = "地牢入口", Description = "苇名城 主城")]
        AbandonedDungeonEntrance = 11110005,

        [Annotation(Name = "苇名城 贮水城区", Description = "苇名城 主城")]
        AshinaReservoir = 11120001,

        [Annotation(Name = "暗道前", Description = "苇名城 主城")]
        NearSecretPassage = 11120000,

        [Annotation(Name = "地下水道", Description = "地牢")]
        UndergroundWaterway = 11300000,

        [Annotation(Name = "投身之所", Description = "地牢")]
        BottomlessHole = 11300001,

        [Annotation(Name = "金刚山 仙峰寺", Description = "金刚山 仙峰寺")]
        SenpouTempleMtKongo = 12000000,

        [Annotation(Name = "修炼道", Description = "金刚山 仙峰寺")]
        Shugendo = 12000001,

        [Annotation(Name = "寺院境内", Description = "金刚山 仙峰寺")]
        TempleGrounds = 12000002,

        [Annotation(Name = "正殿", Description = "金刚山 仙峰寺")]
        MainHall = 12000003,

        [Annotation(Name = "内殿", Description = "金刚山 仙峰寺")]
        InnerSanctum = 12000004,

        [Annotation(Name = "坠落之谷洞窟", Description = "金刚山 仙峰寺")]
        SunkenValleyCavern = 12000005,

        [Annotation(Name = "钟鬼佛堂", Description = "金刚山 仙峰寺")]
        BellDemonsTemple = 12000006,

        [Annotation(Name = "社下山谷", Description = "坠落之谷")]
        UnderShrineValley = 11700007,

        [Annotation(Name = "坠落之谷", Description = "坠落之谷")]
        SunkenValley = 11700000,

        [Annotation(Name = "铁炮要塞", Description = "坠落之谷")]
        GunFort = 11700001,

        [Annotation(Name = "裂缝洞窟", Description = "坠落之谷")]
        RivenCave = 11700002,

        [Annotation(Name = "菩萨谷", Description = "坠落之谷")]
        BodhisattvaValley = 11700008,

        [Annotation(Name = "狮子猿饮水处", Description = "坠落之谷")]
        GuardianApesWateringHole = 11700003,

        [Annotation(Name = "苇名之底", Description = "苇名之底")]
        AshinaDepths = 11700005,

        [Annotation(Name = "毒沼", Description = "苇名之底")]
        PoisonPool = 11700004,

        [Annotation(Name = "狮子猿巢穴", Description = "苇名之底")]
        GuardianApesBurrow = 11700006,

        [Annotation(Name = "隐藏森林", Description = "苇名之底")]
        HiddenForest = 11500000,

        [Annotation(Name = "水生村", Description = "苇名之底")]
        MibuVillage = 11500001,

        [Annotation(Name = "水车小屋", Description = "苇名之底")]
        WaterMill = 11500002,

        [Annotation(Name = "乘轿石洞", Description = "苇名之底")]
        WeddingCaveDoor = 11500003,

        [Annotation(Name = "源之宫", Description = "源之宫")]
        FountainheadPalace = 12500000,

        [Annotation(Name = "朱桥", Description = "源之宫")]
        VermilionBridge = 12500001,

        [Annotation(Name = "水生宅邸", Description = "源之宫")]
        MibuManor = 12500006,

        [Annotation(Name = "赏花舞台", Description = "源之宫")]
        FlowerViewingStage = 12500002,

        [Annotation(Name = "巨大樱树", Description = "源之宫")]
        GreatSakura = 12500003,

        [Annotation(Name = "皇宫内", Description = "源之宫")]
        PalaceGrounds = 12500004,

        [Annotation(Name = "喂食处", Description = "源之宫")]
        FeedingGrounds = 12500007,

        [Annotation(Name = "坛子贵人", Description = "源之宫")]
        NearPotNoble = 12500008,

        [Annotation(Name = "神域", Description = "源之宫")]
        Sanctuary = 12500005,
    }
}