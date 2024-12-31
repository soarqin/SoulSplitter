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
    public enum Boss : uint
    {
        //Academy of Raya Lucaria

        [Annotation(Name = "“灰烬审判者”古达", Description = "灰烬墓地")]
        IudexGundyr = 14000800,

        [Annotation(Name = "冷冽谷的玻尔多", Description = "洛斯里克的高墙")]
        VordtOfTheBorealValley = 13000800,

        [Annotation(Name = "咒蚀大树", Description = "不死聚落")]
        CurseRottedGreatwood = 13100800,

        [Annotation(Name = "结晶老者", Description = "活祭品之路")]
        CrystalSage = 13300850,

        [Annotation(Name = "深渊的监视者", Description = "法兰要塞")]
        AbyssWatchers = 13300800,

        [Annotation(Name = "幽邃主教群", Description = "幽邃教堂")]
        DeaconsOfTheDeep = 13500800,

        [Annotation(Name = "霸王沃尼尔", Description = "卡萨斯的地下墓地")]
        HighLordWolnir = 13800800,

        [Annotation(Name = "老恶魔王", Description = "熏烟湖")]
        OldDemonKing = 13800830,

        [Annotation(Name = "教宗沙力万", Description = "冷冽谷的伊鲁席尔")]
        PontiffSulyvahn = 13700850,

        [Annotation(Name = "巨人尤姆", Description = "罪业之都")]
        YhormTheGiant = 13900800,

        [Annotation(Name = "吞噬神明的艾尔德利奇", Description = "亚诺尔隆德")]
        AldrichDevourerOfGods = 13700800,

        [Annotation(Name = "冷冽谷的舞娘", Description = "洛斯里克的高墙")]
        DancerOfTheBorealValley = 13000890,

        [Annotation(Name = "猎龙铠甲", Description = "洛斯里克城")]
        DragonslayerArmour = 13010800,

        [Annotation(Name = "妖王欧斯罗艾斯", Description = "妖王庭院")]
        OceirosTheConsumedKing = 13000830,

        [Annotation(Name = "英雄古达", Description = "无主墓地")]
        ChampionGundyr = 14000830,

        [Annotation(Name = "洛斯里克王子", Description = "洛斯里克城")]
        LothricYoungerPrince = 13410830,

        [Annotation(Name = "古老飞龙", Description = "古龙顶端")]
        AncientWyvern = 13200800,

        [Annotation(Name = "无名王者", Description = "古龙顶端")]
        NamelessKing = 13200850,

        [Annotation(Name = "薪王们的化身", Description = "初始之火的火炉")]
        SoulOfCinder = 14100800,

        [Annotation(Name = "芙莉德修女", Description = "艾雷德尔的绘画世界")]
        SisterFriede = 14500800,

        [Annotation(Name = "王者的守墓人 & 守墓大狼", Description = "艾雷德尔的绘画世界")]
        ChampionsGravetenderAndGravetenderGreatwolf = 14500860,

        [Annotation(Name = "负伤恶魔 & 洞底恶魔 / 恶魔王子", Description = "聚集地")]
        DemonInPainAndDemonFromBelowDemonPrince = 15000800,

        [Annotation(Name = "“教堂之枪”贺弗莱特", Description = "环印城")]
        HalflightSpearOfTheChurch = 15100800,

        [Annotation(Name = "吞噬黑暗的米狄尔", Description = "环印城")]
        DarkeaterMidir = 15100850,

        [Annotation(Name = "奴隶骑士盖尔", Description = "环印城")]
        SlaveKnightGael = 15110800,
    }
}