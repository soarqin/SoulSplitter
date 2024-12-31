// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
// Copyright (c) 2024 Frank van der Stam.
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
    public enum KnownFlag : uint
    {
        [Annotation(Name = "开始第一周目 50")]
        NewGame = 50,

        [Annotation(Name = "开始第二周目 51")]
        NewGame1 = 51,

        [Annotation(Name = "开始第三周目 52")]
        NewGame2 = 52,

        [Annotation(Name = "开始第四周目 53")]
        NewGame3 = 53,

        [Annotation(Name = "开始第五周目 54")]
        NewGame4 = 54,

        [Annotation(Name = "开始第六周目 55")]
        NewGame5 = 55,

        [Annotation(Name = "开始第七周目 56")]
        NewGame6 = 56,

        [Annotation(Name = "开始第八周目 57")]
        NewGame7 = 57,

        [Annotation(Name = "开始第九周目 58")]
        NewGame8 = 58,

        [Annotation(Name = "开始游戏 100")]
        GameStarts = 100,

        [Annotation(Name = "抵达漂流墓地 101")]
        ReachesStrandedGraveyard = 101,

        [Annotation(Name = "抵达宁姆格福开放区域 102")]
        ReachesLimgraveOpenField = 102,

        [Annotation(Name = "抵达圆桌厅堂 105")]
        ReachesRoundtable = 105,

        [Annotation(Name = "触摸癫火 108")]
        TouchestheFrenziedFlame = 108,

        [Annotation(Name = "在巨人火焰大锅点燃黄金树 110")]
        BurnstheErdtreeatForgeoftheGiants = 110,

        [Annotation(Name = "看了结局过场动画 120")]
        SawEndingScene = 120,

        [Annotation(Name = "获得第一个大卢恩 181")]
        Gets1stGreatRune = 181,

        [Annotation(Name = "获得第二个大卢恩 182")]
        Gets2ndGreatRune = 182,

        [Annotation(Name = "获得第三个大卢恩 183")]
        Gets3rdGreatRune = 183,

        [Annotation(Name = "获得第四个大卢恩 184")]
        Gets4thGreatRune = 184,

        [Annotation(Name = "获得第五个大卢恩 185")]
        Gets5thGreatRune = 185,

        [Annotation(Name = "获得第六个大卢恩 186")]
        Gets6thGreatRune = 186,

        [Annotation(Name = "获得第七个大卢恩 187")]
        Gets7thGreatRune = 187,

        [Annotation(Name = "和梅琳娜会面 951")]
        MeetsMelina = 951,

        [Annotation(Name = "看了结局过场动画2 6010")]
        SawEndingScene2 = 6010,

        [Annotation(Name = "获得了红/蓝露滴圣杯瓶 60000")]
        GetsFlasksofCrimsonCeruleanTears = 60000,

        [Annotation(Name = "获得了灵药圣杯瓶 60020")]
        GetsFlaskofWondrousPhysick = 60020,

        [Annotation(Name = "解锁功能：骑马(托雷特) 60100")]
        UnlocksFunctionRidingTorrent = 60100,

        [Annotation(Name = "解锁功能：召唤灵魂骨灰 60110")]
        UnlocksFunctionSummoningSpirits = 60110,

        [Annotation(Name = "解锁功能：制作道具 60120")]
        UnlocksFunctionCrafting = 60120,

        [Annotation(Name = "解锁功能：为武器附加战灰 60130")]
        UnlocksFunctionApplyingAshesofWartoArmaments = 60130,

        [Annotation(Name = "解锁功能：裁缝衣物 60140")]
        UnlocksFunctionArmorAlterations = 60140,

        [Annotation(Name = "解锁功能：裁缝半神衣物 60150")]
        UnlocksFunctionDemigodsArmorAlterations = 60150,

        [Annotation(Name = "解锁第一个法术记忆位 60400")]
        UnlocksMemorySlot0 = 60400,

        [Annotation(Name = "解锁第二个法术记忆位 60410")]
        UnlocksMemorySlot1 = 60410,

        [Annotation(Name = "解锁第三个法术记忆位 60420")]
        UnlocksMemorySlot2 = 60420,

        [Annotation(Name = "解锁第四个法术记忆位 60430")]
        UnlocksMemorySlot3 = 60430,

        [Annotation(Name = "解锁第五个法术记忆位 60440")]
        UnlocksMemorySlot4 = 60440,

        [Annotation(Name = "解锁第六个法术记忆位 60450")]
        UnlocksMemorySlot5 = 60450,

        [Annotation(Name = "解锁第七个法术记忆位 60460")]
        UnlocksMemorySlot6 = 60460,

        [Annotation(Name = "解锁第八个法术记忆位 60470")]
        UnlocksMemorySlot7 = 60470,

        [Annotation(Name = "解锁第一个护符位 60500")]
        UnlocksTalismanSlot0 = 60500,

        [Annotation(Name = "解锁第二个护符位 60510")]
        UnlocksTalismanSlot1 = 60510,

        [Annotation(Name = "解锁第三个护符位 60520")]
        UnlocksTalismanSlot2 = 60520,

        [Annotation(Name = "解锁地下地图 62001")]
        UnlocksUndergroundMap = 62001,

        [Annotation(Name = "普通结局A 9400")]
        NormalEndingA = 9400,

        [Annotation(Name = "普通结局B 9401")]
        NormalEndingB = 9401,

        [Annotation(Name = "普通结局C 9402")]
        NormalEndingC = 9402,

        [Annotation(Name = "普通结局D 9403")]
        NormalEndingD = 9403,

        [Annotation(Name = "菈妮结局A 9404")]
        RanniEndingA = 9404,

        [Annotation(Name = "菈妮结局B 9405")]
        RanniEndingB = 9405,

        [Annotation(Name = "癫火结局A 9406")]
        FrenziedFlameEndingA = 9406,

        [Annotation(Name = "癫火结局B 9407")]
        FrenziedFlameEndingB = 9407,

        [Annotation(Name = "拉塔恩祭典：准备中 9410")]
        RadahnFestivalPreparation = 9410,

        [Annotation(Name = "拉塔恩祭典：开始 9411")]
        RadahnFestivalBegins = 9411,

        [Annotation(Name = "拉塔恩祭典：余韵 9412")]
        RadahnFestivalAftermath = 9412,

        [Annotation(Name = "拉塔恩祭典：结束 9413")]
        RadahnFestivalEnds = 9413,

        [Annotation(Name = "癫火眼 9431")]
        FrenziedFlameEyes = 9431,

        [Annotation(Name = "龙飨眼 9433")]
        DragonEyes = 9433,

        [Annotation(Name = "乘坐迪可达斯升降机 1038500500")]
        TakesDectusLift = 1038500500,

        [Annotation(Name = "乘坐洛德升降机 1050542200")]
        TakeGoldLift = 1050542200,
    }
}