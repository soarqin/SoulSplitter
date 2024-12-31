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
    public enum ItemPickup : uint
    {
        [Annotation(Name = "红露滴圣杯瓶 60000")]
        FlaskOfCrimsonTears = 60000,

        [Annotation(Name = "附绳火焰壶 500010")]
        RopedFirePot = 500010,

        [Annotation(Name = "金色小雕像 60230")]
        SmallGoldenEffigy = 60230,

        [Annotation(Name = "灵药圣杯瓶 6700")]
        FlaskOfWondrousPhysick = 6700,

        [Annotation(Name = "床帘恩泽 0")]
        BaldachinsBlessing = 0,

        [Annotation(Name = "完美律法的修复卢恩 9500")]
        MendingRuneOfPerfectOrder = 9500,

        [Annotation(Name = "死王子的修复卢恩 9502")]
        MendingRuneOfTheDeathPrince = 9502,

        [Annotation(Name = "忌讳诅咒的修复卢恩 9504")]
        MendingRuneOfTheFellCurse = 9504,

        [Annotation(Name = "[史东薇尔城 - “恶兆妖鬼”玛尔基特] 护符皮袋 60510")]
        StormveilMargitTalismanPouch = 60510,

        [Annotation(Name = "[史东薇尔城 - “接肢”葛瑞克] 葛瑞克的大卢恩 171")]
        StormveilGodrickGodricksGreatRune = 171,

        [Annotation(Name = "[史东薇尔城 - “接肢”葛瑞克] 接肢的追忆 510010")]
        StormveilGodrickRemembranceOfTheGrafted = 510010,

        [Annotation(Name = "[候王礼拜堂 - “接肢”贵族后裔] 仪式直剑 510030")]
        ChapelOfAnticipationGrafedScionOrnamentalStraightSword = 510030,

        [Annotation(Name = "[王城罗德尔 - “恶兆王”蒙葛特] 恶兆王的追忆 510040")]
        LeyndellMorgottRemembranceOfTheOmenKing = 510040,

        [Annotation(Name = "[王城罗德尔 - “恶兆王”蒙葛特] 蒙葛特的大卢恩 173")]
        LeyndellMorgottMorgottsGreatRune = 173,

        [Annotation(Name = "[“解指”恩雅 - 获取两个大卢恩后] 护符皮袋 60520")]
        Enia2GreatRunesTalismanPouch = 60520,

        [Annotation(Name = "[灰城罗德尔 - “百智爵士”基甸·奥夫尼尔] 百智权杖 510060")]
        AshenLeyndellGideonScepterOfTheAllKnowing = 510060,

        [Annotation(Name = "[灰城罗德尔 - 战士荷莱·露] 荷莱·露的追忆 510070")]
        AshenLeyndellHoarahLouxRemembranceOfHoarahLoux = 510070,

        [Annotation(Name = "[腐败湖 - “黑暗弃子”艾丝缇] 黑暗弃子的追忆 510080")]
        LakeorRotAstelRemembranceOfTheNaturalborn = 510080,

        [Annotation(Name = "[安瑟尔河 - 龙人士兵] 冰雷枪 510090")]
        AinselDragonkinSoldierFrozenLightningSpear = 510090,

        [Annotation(Name = "[希芙拉河 - 英雄石像鬼] 石像鬼大剑 510100")]
        SiofraValiantGargoyleGargoylesGreatsword = 510100,

        [Annotation(Name = "[深根底层 - “死龙”弗尔桑克斯] 死龙的追忆 510110")]
        DeeprootDepthsFortissaxRemembranceOfTheLichdragon = 510110,

        [Annotation(Name = "[蒙格温王朝 - “鲜血君王”蒙格] 鲜血君王的追忆 510120")]
        MohgwynPalaceMohgRemembranceOfTheBloodLord = 510120,

        [Annotation(Name = "[蒙格温王朝 - “鲜血君王”蒙格] 蒙格的大卢恩 175")]
        MohgwynPalaceMohgMohgsGreatRune = 175,

        [Annotation(Name = "[逐渐崩毁的法姆·亚兹拉 - 神皮双人组] 锻造石矿工的铃珠【４】 510140")]
        FarumAzulaGodskinDuoSmithingStoneMinersBellBearing4 = 510140,

        [Annotation(Name = "[逐渐崩毁的法姆·亚兹拉 - “龙王”普拉顿桑克斯] 龙王的追忆 510150")]
        FarumAzulaDragonlordPlacidusaxRemembranceOfTheDragonlord = 510150,

        [Annotation(Name = "[逐渐崩毁的法姆·亚兹拉 - “黑剑”玛利喀斯] 黑剑的追忆 510160")]
        FarumAzulaMalikethRemembranceOfTheBlackBlade = 510160,

        [Annotation(Name = "[魔法学院雷亚卢卡利亚 - 拉达冈的红狼] 记忆石 60440")]
        RayaLucariaRedWolfOfRadagonMemoryStone = 60440,

        [Annotation(Name = "[魔法学院雷亚卢卡利亚 - “满月女王”蕾娜菈] 满月女王的追忆 197")]
        RayaLucariaRennalaRemembranceOfTheFullMoonQueen = 197,

        [Annotation(Name = "[魔法学院雷亚卢卡利亚 - “满月女王”蕾娜菈] 无 177")]
        RayaLucariaRennalaNone = 177,

        [Annotation(Name = "[米凯拉的圣树 - “圣树骑士”罗蕾塔] 罗蕾塔的绝招 510190")]
        HaligtreeLorettaLorettasMastery = 510190,

        [Annotation(Name = "[米凯拉的圣树 - “腐败女神”玛莲妮亚] 腐败女神的追忆 510200")]
        HaligtreeMaleniaRemembranceOfTheRotGoddess = 510200,

        [Annotation(Name = "[米凯拉的圣树 - “腐败女神”玛莲妮亚] 玛莲妮亚的大卢恩 176")]
        HaligtreeMaleniaMaleniasGreatRune = 176,

        [Annotation(Name = "[火山官邸 - 神皮贵族] 神皮缝针 510210")]
        VolcanoManorGodskinNobleGodskinStitcher = 510210,

        [Annotation(Name = "[格密尔火山 - “亵渎君王”拉卡德] 亵渎君王的追忆 510220")]
        MtGelmirRykardRemembranceOfTheBlasphemous = 510220,

        [Annotation(Name = "[格密尔火山 - “亵渎君王”拉卡德] 拉卡德的大卢恩 174")]
        MtGelmirRykardRykardsGreatRune = 174,

        [Annotation(Name = "[艾尔登宝座 - 艾尔登之兽] 艾尔登的追忆 510230")]
        ErdtreeEldenBeastEldenRemembrance = 510230,

        [Annotation(Name = "[蒙格温王朝 - “鲜血君王”蒙格] 血焰爪痕 510250")]
        MohgwynPalaceMohgBloodflameTalons = 510250,

        [Annotation(Name = "[古遗迹断崖 - “熔岩土龙”马卡尔] 土龙鳞剑 510260")]
        RuinStrewnPrecipiceMagmaWyrmMakarMagmaWyrmsScalesword = 510260,

        [Annotation(Name = "[边境英雄墓地 - 腐烂树灵] 黄金种子 510280")]
        FringefolkHerosGraveUlceratedTreeSpiritGoldenSeed = 510280,

        [Annotation(Name = "[火山官邸 - Abducator Virgin] 拷问烛台 510290")]
        VolcanoManorAbducatorVirginsInquisitorsGirandole = 510290,

        [Annotation(Name = "[盖利德 - “碎星”拉塔恩] 碎星的追忆 510300")]
        CaelidRadahnRemembranceOfTheStarscourge = 510300,

        [Annotation(Name = "[盖利德 - “碎星”拉塔恩] 拉塔恩的大卢恩 172")]
        CaelidRadahnRadahnsGreatRune = 172,

        [Annotation(Name = "[巨人山顶 - 火焰巨人] 火焰巨人的追忆 510310")]
        MountaintopsFireGiantRemembranceOfTheFireGiant = 510310,

        [Annotation(Name = "[希芙拉河 - 祖灵] 祖灵之民的骨灰 510320")]
        SiofraAncestorSpiritAncestralFollowerAshes = 510320,

        [Annotation(Name = "[“永恒之城”诺克隆恩 - 祖灵之王] 祖灵之王的追忆 510330")]
        NokronRegalAncestorSpiritRemembranceOfTheRegalAncestor = 510330,

        [Annotation(Name = "[“永恒之城”诺克隆恩 - 仿身泪滴] 泪滴幼体 510340")]
        NokronMimicTearLarvalTear = 510340,

        [Annotation(Name = "[深根底层 - 菲雅的英雄] 菲雅烟雾 510350")]
        DeeprootDepthsFiasChampionsFiasMist = 510350,

        [Annotation(Name = "[巨人山顶 - 鲜血贵族] 鲜血贵族风帽 510730")]
        MountaintopsSanguineNobleSanguineNobleHood = 510730,

        [Annotation(Name = "[王城城墙外 - 恶兆孪生子] 恶兆猎人罗洛 510740")]
        CapitalOutskirtsFellTwinsOmenkillerRollo = 510740,

        [Annotation(Name = "[啜泣半岛 - 狮子混种] 剑骸大剑 510800")]
        WeepingPenisulaLeonineMisbegottenBladeGreatsword = 510800,

        [Annotation(Name = "[卡利亚城寨 - “圣树骑士”罗蕾塔] 罗蕾塔的大弓 510810")]
        CariaManorLorettaLorettasGreatbow = 510810,

        [Annotation(Name = "[日荫城 - “铁棘”艾隆梅尔] 玛雷家行刑剑 510820")]
        ShadedCastleElemerOfTheBriarMaraisExecutionersSword = 510820,

        [Annotation(Name = "[红狮子城 - 混种战士/熔炉骑士] 遗迹大剑 510830")]
        RedmaneCastleMisbegottenWarriorCrucibleKnightRuinsGreatsword = 510830,

        [Annotation(Name = "[索尔城 - 老将尼奥] 老将的义足 510840")]
        CastleSolCommanderNiallVeteransProsthesis = 510840,

        [Annotation(Name = "[灵庙原野地下墓地 - 墓地影子] “无头骑士”露缇尔 520000")]
        TombswardCatacombsCemeteryShadeLhutelTheHeadless = 520000,

        [Annotation(Name = "[穿刺地下墓地 - 归树看门犬] 亚人集团的骨灰 520010")]
        ImpalersCatacombsErdtreeBurialWatchdogDemiHumanAshes = 520010,

        [Annotation(Name = "[风暴根脚的地下墓地 - 归树看门犬] 权贵魔法师的骨灰 520020")]
        StormfootCatacombsErdtreeBurialWatchdogNobleSorcererAshes = 520020,

        [Annotation(Name = "[死亡降临的地下墓地 - 黑刀刺客] 染红凶刀 520030")]
        DeathtouchedCatacombsBlackKnifeAssassinAssassinsCrimsonDagger = 520030,

        [Annotation(Name = "[蒙流地下墓地 - 守墓斗士] 斗技锤 520040")]
        MurkwaterCatacombsGraveWardenDuelistBattleHammer = 520040,

        [Annotation(Name = "[黑刀地下墓地 - 墓地影子] 双贤魔法师的骨灰 520050")]
        BlackKnifeCatacombsCemeteryShadeTwinsageSorcererAshes = 520050,

        [Annotation(Name = "[绝路地下墓地 - 唤灵蜗牛] 辉石魔法师的骨灰 520060")]
        RoadsEndCatacombsSpiritcallerSnailGlintstoneSorcererAshes = 520060,

        [Annotation(Name = "[断崖下的地下墓地 - 归树看门犬] 凯丹佣兵的骨灰 520070")]
        CliffbottomCatacombsErdtreeBurialWatchdogKaidenSellswordAshes = 520070,

        [Annotation(Name = "[尊贵者的英雄墓地 - 王城罗德尔] “古龙骑士”克里斯托福 520080")]
        SaintedHerosGraveLeyndellAncientDragonKnightKristoff = 520080,

        [Annotation(Name = "[格密尔英雄墓地 - 格密尔火山] “猎犬骑士”弗罗 520090")]
        GelmirsHeosGraveMtGelmirBloodhoundKnightFloh = 520090,

        [Annotation(Name = "[亚雷萨英雄墓地 - “熔炉骑士”奥陶琵斯] 奥陶琵斯大剑 520100")]
        AurizaHerosGraveCrucibleKnighOrdovisOrdovissGreatsword = 520100,

        [Annotation(Name = "[丑恶地下墓地 - 调香师托莉夏] 调香师托莉夏 520110")]
        UnslightlyCatacombsPerfumerTriciaPerfumerTricia = 520110,

        [Annotation(Name = "[威达姆地下墓地 - 归树看门犬] 铃兰摘采工的铃珠【１】 520120")]
        WyndhamCatacombsErdtreeBurialWatchdogGlovewortPickersBellBearing1 = 520120,

        [Annotation(Name = "[亚雷萨副墓地 - 守墓斗士] 特攻先锋群的骨灰 520130")]
        AurizaSideTombGraveWardenDuelistSoldjarsOfFortuneAshes = 520130,

        [Annotation(Name = "[小黄金树地下墓地 - 归树看门犬] 发狂南瓜头士兵的骨灰 520140")]
        MinorErdtreeCatacombsErdtreeBurialWatchdogMadPumpkinHeadAshes = 520140,

        [Annotation(Name = "[盖利德地下墓地 - 墓地影子] 腐败眷属的骨灰 520150")]
        CaelidCatacombsCemeteryShadeKindredOfRotAshes = 520150,

        [Annotation(Name = "[英灵地下墓地 - 腐败树灵] “红狮子骑士”奥加 520160")]
        WarDeadCatacombsPutridTreeSpiritRedmaneKnightOgha = 520160,

        [Annotation(Name = "[巨人战争的英雄墓地 - 萨米尔的古英雄] 萨米尔弯刀 520170")]
        GiantConqueringHerosGraveAncientHeroOfZamorZamorCurvedSword = 520170,

        [Annotation(Name = "[巨人山顶地下墓地 - 腐烂树灵] 黄金种子 520180")]
        GiantsMountaintopCatacombsUlceratedTreeSpiritGoldenSeed = 520180,

        [Annotation(Name = "[化圣雪原地下墓地 - 腐败守墓斗士] 大朵墓地铃兰 520190")]
        ConsecratedSnowfiledCatacombsPutridGraveWardenDuelistGreatGraveGlovewort = 520190,

        [Annotation(Name = "[通往圣树的密道 - 离群仿身泪滴] 黑焰习武修士亚蒙 520200")]
        HiddenPathotTheHaligtreeStrayMimicTearBlackflameMonkAmon = 520200,

        [Annotation(Name = "[黑刀地下墓地 - 黑刀刺客] 染蓝凶刀 520210")]
        BlackKnifeCatacombsBlackKnifeAssassinAssassinsCeruleanDagger = 520210,

        [Annotation(Name = "[罗德尔地下墓地 - “鲜血祭司”艾斯加] 鲜血君王的欢愉 520220")]
        LeyndellCatacombsEsgarPriestOfBloodLordOfBloodsExultation = 520220,

        [Annotation(Name = "[灵庙原野洞窟 - “病花”米兰达] 绿琥珀链坠 520300")]
        TombswardCaveMirandaTheBlightedBloomViridianAmberMedallion = 520300,

        [Annotation(Name = "[垂穴洞窟 - 卢恩熊] 魔力龙徽护符 520310")]
        EarthboreCaveRunebearSpelldrakeTalisman = 520310,

        [Annotation(Name = "[近林洞窟 - 法姆·亚兹拉的兽人] 火龙徽护符 520330")]
        GrovesideCaveBeastmanOfFarumAzulaFlamedrakeTalisman = 520330,

        [Annotation(Name = "[海岸洞窟 - 亚人首领] 缝衣针 520340")]
        CoastalCaveDemiHumanChiefSewingNeedle = 520340,

        [Annotation(Name = "[海岸洞窟 - 亚人首领] 裁缝工具 60140")]
        CoastalCaveDemiHumanChiefTailoringTools = 60140,

        [Annotation(Name = "[大道下的洞窟 - 魔像守卫] 蓝色舞娘 520350")]
        HighroadCaveGuardianGolemBlueDancerCharm = 520350,

        [Annotation(Name = "[留水洞窟 - 玛莲妮亚的尊腐骑士] 带翼剑徽章 520360")]
        StillwaterCaveCleanrotKnightWingedSwordInsignia = 520360,

        [Annotation(Name = "[湖旁结晶洞窟 - 猎犬骑士] 蓝琥珀链坠 520370")]
        LakesideCrystalCaveBloodhoundKnightCeruleanAmberMedallion = 520370,

        [Annotation(Name = "[学院结晶洞窟 - 结晶人] 飞散结晶 520380")]
        AcademyCrystalCaveCrystaliansCrystalRelease = 520380,

        [Annotation(Name = "[沸滚河洞窟 - 腐败眷属] 腐败眷属的欢愉 520390")]
        SeethewaterCaveKindredOfRotKindredOfRotsExultation = 520390,

        [Annotation(Name = "[火山洞窟 - “亚人女王”玛格] 壶大炮 520400")]
        VolcanoCaveDemihumanQueenMargotJarCannon = 520400,

        [Annotation(Name = "[恶兆猎人 - 调香师的隐藏洞窟] 恶兆猎人大柴刀 520410")]
        OmenkillerPerfumersGrottoGreatOmenkillerCleaver = 520410,

        [Annotation(Name = "[贤者的洞窟 - 黑刀刺客] 隐身面纱 520420")]
        SagesCaveBlackKnifeAssassinConcealingVeil = 520420,

        [Annotation(Name = "[牢狱洞窟 - 发狂斗士] 腐烂长生者的骨灰 520430")]
        GoalCaveFrenziedDuelistPutridCorpseAshes = 520430,

        [Annotation(Name = "[龙墓洞窟 - 法姆·亚兹拉的兽人] 火龙徽护符＋２ 520440")]
        DragonbarrowCaveBeastmanOfFarumAzulaFlamedrakeTalisman2 = 520440,

        [Annotation(Name = "[废弃洞窟 - 玛莲妮亚的尊腐骑士] 金色粪金龟 520450")]
        AbandonedCaveCleanrotKnightDuoGoldScarab = 520450,

        [Annotation(Name = "[瑟利亚隐藏洞窟 - Putrid Crystalian] 奔放结晶 520460")]
        SelliaHideawayPutridCrystaliansCrystalTorrent = 520460,

        [Annotation(Name = "[安身洞窟 - 混种圣骑士] 黄金律法大剑 520470")]
        CaveOfTheForlornMisbegottenCrusaderGoldenOrderGreatsword = 520470,

        [Annotation(Name = "[唤灵洞窟 - 唤灵蜗牛] 神皮襁褓 520480")]
        SpiritcallersCaveGodskinApostleNobleGodskinSwaddlingCloth = 520480,

        [Annotation(Name = "[贤者的洞窟 - 死术师哥瑞斯] 家族头连枷 520490")]
        SagesCaveNecromancerGarrisFamilyHeads = 520490,

        [Annotation(Name = "[摩恩坑道 - 片鳞混种] 锈蚀船锚 520600")]
        MorneTunnelScalyMisbegottenRustedAnchor = 520600,

        [Annotation(Name = "[宁姆格福坑道 - 挖石山妖] 咆哮链坠 520610")]
        LimgraveTunnelsStonediggerTrollRoarMedallion = 520610,

        [Annotation(Name = "[雷亚卢卡利亚结晶坑道 - 结晶人] 锻造石矿工的铃珠【１】 520620")]
        RayaLucariaCrystalTunnelCrystalianSmithingStoneMinersBellBearing1 = 520620,

        [Annotation(Name = "[旧亚坛坑道 - 挖石山妖] 巨型棍棒 520630")]
        OldAltusTunnelStonediggerTrollGreatClub = 520630,

        [Annotation(Name = "[封印坑道 - 石肤黑王] 黑王大剑 520640")]
        SealedTunnelOnyxLordOnyxLordsGreatsword = 520640,

        [Annotation(Name = "[亚坛坑道 - 结晶人] 失色石矿工的铃珠【２】 520650")]
        AltusTunnelCrystaliansSomberstoneMinersBellBearing2 = 520650,

        [Annotation(Name = "[盖尔坑道 - 熔岩土龙] 龙心脏 520660")]
        GaelTunnelMagmaWyrmDragonHeart = 520660,

        [Annotation(Name = "[瑟利亚结晶坑道 - 坠星兽物] 失色锻造石【６】 520670")]
        SelliaCrystalTunnelFallingstarBeastSomberSmithingStone6 = 520670,

        [Annotation(Name = "[耶罗·亚尼斯坑道 - “黑暗弃子”艾丝缇] 艾丝缇陨石 520680")]
        YeloughAnixTunnelAstelMeteoriteOfAstel = 520680,

        [Annotation(Name = "[宁姆格福 - 大树守卫] 黄金戟 530100")]
        LimgraveFieldTreeSentinelGoldenHalberd = 530100,

        [Annotation(Name = "[宁姆格福 - “飞龙”亚基尔] 龙心脏 530110")]
        LimgraveFieldFlyingDragonAgheelDragonHeart = 530110,

        [Annotation(Name = "[宁姆格福 - 熔炉骑士] 熔炉百相之尾 530120")]
        LimgraveEvergaolCrucibleKnightAspectsOfTheCrucibleTail = 530120,

        [Annotation(Name = "[宁姆格福 - “猎犬骑士”达瑞威尔] 猎犬长牙 530130")]
        LimgraveEvergaolBloodhoundKnightDarriwilBloodhoundsFang = 530130,

        [Annotation(Name = "[宁姆格福 - 提比亚的唤声船] 死根 530170")]
        LimgraveFieldTibiaMarinerDeathroot = 530170,

        [Annotation(Name = "[啜泣半岛 - 黄金树的化身] 涌红结晶露滴 65090")]
        WeepingPenisulaFieldErdtreeAvatarCrimsonburstCrystalTear = 65090,

        [Annotation(Name = "[啜泣半岛 - 黄金树的化身] 珍珠泡状露滴 65080")]
        WeepingPenisulaFieldErdtreeAvatarOpalineBubbletear = 65080,

        [Annotation(Name = "[湖之利耶尼亚 - 黄金树的化身] 带魔力破露滴 65290")]
        LiurniaFieldErdtreeAvatarMagicShroudingCrackedTear = 65290,

        [Annotation(Name = "[湖之利耶尼亚 - 黄金树的化身] 带雷破露滴 65300")]
        LiurniaFieldErdtreeAvatarLightningShroudingCrackedTear = 65300,

        [Annotation(Name = "[湖之利耶尼亚 - 黄金树的化身] 带圣破露滴 65310")]
        LiurniaFieldErdtreeAvatarHolyShroudingCrackedTear = 65310,

        [Annotation(Name = "[湖之利耶尼亚 - 黄金树的化身] 蓝结晶露滴 65040")]
        LiurniaFieldErdtreeAvatarCeruleanCrystalTear = 65040,

        [Annotation(Name = "[湖之利耶尼亚 - 黄金树的化身] 爆裂结晶露滴 65160")]
        LiurniaFieldErdtreeAvatarRupturedCrystalTear = 65160,

        [Annotation(Name = "[湖之利耶尼亚 - “辉石龙”史玛拉格] 龙心脏 530210")]
        LiurniaFieldGlintstoneDragonSmaragDragonHeart = 530210,

        [Annotation(Name = "[湖之利耶尼亚 - 恶兆猎人] 熔炉瘤护符 530225")]
        LiurniaFieldOmenkillerCrucibleKnotTalisman = 530225,

        [Annotation(Name = "[湖之利耶尼亚 - 提比亚的唤声船] 死根 530240")]
        LiurniaFieldTibiaMarinerDeathroot = 530240,

        [Annotation(Name = "[湖之利耶尼亚 - “盗火”亚当] 恶神火焰 530245")]
        LiurniaEvergaolAdanThiefOfFireFlameOfTheFellGod = 530245,

        [Annotation(Name = "[湖之利耶尼亚 - “卡利亚骑士”波尔斯] 巨剑阵 530250")]
        LiurniaEvergaolBolsCarianKnightGreatbladePhalanx = 530250,

        [Annotation(Name = "[湖之利耶尼亚 - 石肤黑王] 陨石 530255")]
        LiurniaEvergaolOnyxLordMeteorite = 530255,

        [Annotation(Name = "[湖之利耶尼亚 - “辉石龙”亚杜拉] 龙心脏 530260")]
        LiurniaFieldGlintstoneDragonAdulaDragonHeart = 530260,

        [Annotation(Name = "[湖之利耶尼亚 - “黑刀之首”亚勒托] “黑刀”狄希 530265")]
        LiurniaEvergaolAlectoBlackKnifeRingleaderBlackKnifeTiche = 530265,

        [Annotation(Name = "[亚坛高原 - “古龙”兰斯桑克斯] 兰斯桑克斯的刀 530300")]
        AltusPlateauFieldAncientDragonLansseaxLansseaxsGlaive = 530300,

        [Annotation(Name = "[亚坛高原 - 坠星兽物] 失色锻造石【５】 530310")]
        AltusPlateauFieldFallingstarBeastSomberSmithingStone5 = 530310,

        [Annotation(Name = "[王城城墙外 - 龙装大树守卫] 大龙爪 530315")]
        CapitalOutskirtsFieldDraconicTreeSentinelDragonGreatclaw = 530315,

        [Annotation(Name = "[亚坛高原 - 蚯蚓脸] 斑斓硬露滴 65060")]
        AltusPlateauFieldWormfaceSpeckledHardtear = 65060,

        [Annotation(Name = "[亚坛高原 - 蚯蚓脸] 漫红结晶露滴 65000")]
        AltusPlateauFieldWormfaceCrimsonspillCrystalTear = 65000,

        [Annotation(Name = "[亚坛高原 - 神皮使徒] 神皮剥制剑 530325")]
        AltusPlateauFieldGodskinApostleGodskinPeeler = 530325,

        [Annotation(Name = "[王城城墙外 - 双大树守卫] 黄金树大盾 530335")]
        CapitalOutskirtsFieldTreeSentinelDuoErdtreeGreatshield = 530335,

        [Annotation(Name = "[亚坛高原 - 黑刀刺客] 黑刀 530350")]
        AltusPlateauFieldBlackKnifeAssassinBlackKnife = 530350,

        [Annotation(Name = "[格密尔火山 - 坠星成兽] 失色锻造石【６】 530375")]
        MtGelmirFieldFullgrownFallingstarBeastSomberSmithingStone6 = 530375,

        [Annotation(Name = "[格密尔火山 - 腐烂树灵] 铅化硬露滴 65180")]
        MtGelmirFieldUlceratedTreeSpiritLeadenHardtear = 65180,

        [Annotation(Name = "[格密尔火山 - 腐烂树灵] 蓝秘密露滴 65250")]
        MtGelmirFieldUlceratedTreeSpiritCeruleanHiddenTear = 65250,

        [Annotation(Name = "[亚坛高原 - 提比亚的唤声船] 死根 530385")]
        AltusPlateauFieldTibiaMarinerDeathroot = 530385,

        [Annotation(Name = "[格密尔火山 - 熔岩土龙] 龙心脏 530390")]
        MtGelmirFieldMagmaWyrmDragonHeart = 530390,

        [Annotation(Name = "[格密尔火山 - “亚人女王”玛姬] 记忆石 60450")]
        MtGelmirFieldDemiHumanQueenMaggieMemoryStone = 60450,

        [Annotation(Name = "[格密尔火山 - 熔岩土龙] 龙心脏 530400")]
        MtGelmirFieldMagmaWyrmDragonHeart_ = 530400,

        [Annotation(Name = "[盖利德 - 老将欧尼尔] 老将的军旗 530405")]
        CaelidFieldCommanderONeilCommandersStandard = 530405,

        [Annotation(Name = "[盖利德 - 黄金树的化身] 涌绿结晶露滴 65100")]
        CaelidFieldErdtreeAvatarGreenburstCrystalTear = 65100,

        [Annotation(Name = "[盖利德 - 黄金树的化身] 带火破露滴 65280")]
        CaelidFieldErdtreeAvatarFlameShroudingCrackedTear = 65280,

        [Annotation(Name = "[盖利德 - 腐败化身] 珍珠硬露滴 65110")]
        CaelidFieldPutridAvatarOpalineHardtear = 65110,

        [Annotation(Name = "[盖利德 - 腐败化身] 岩刺破露滴 65260")]
        CaelidFieldPutridAvatarStonebarbCrackedTear = 65260,

        [Annotation(Name = "[盖利德 - “飞龙”桂雷尔] 龙心脏 530420")]
        CaelidFieldFlyingDragonGreyllDragonHeart = 530420,

        [Annotation(Name = "[盖利德 - 黑剑眷属] 石像鬼黑剑 530425")]
        CaelidFieldBladeBladeKindredGargoylesBlackblade = 530425,

        [Annotation(Name = "[禁域 - 黑剑眷属] 石像鬼黑双头剑 530505")]
        ForbiddenLandsFieldBlackBladeKindredGargoylesBlackBlades = 530505,

        [Annotation(Name = "[巨人山顶 - “冻结冰雾”玻列琉斯] 龙心脏 530510")]
        MountaintopsOfTheGiantsFieldBorealisTheFreezingFogDragonHeart = 530510,

        [Annotation(Name = "[巨人山顶 - “圆桌骑士”维克] 维克的龙雷 530515")]
        MountaintopsOfTheGiantsEvergaolRoundtableKnightVykeVykesDragonbolt = 530515,

        [Annotation(Name = "[巨人山顶 - 黄金树的化身] 蓝结晶露滴 65050")]
        MountaintopsOfTheGiantsFieldErdtreeAvatarCeruleanCrystalTear = 65050,

        [Annotation(Name = "[巨人山顶 - 黄金树的化身] 红泡状露滴 65070")]
        MountaintopsOfTheGiantsFieldErdtreeAvatarCrimsonBubbletear = 65070,

        [Annotation(Name = "[巨人山顶 - 死亡仪式鸟] 死亡仪式矛 530530")]
        MountaintopsOfTheGiantsFieldDeathRiteBirdDeathRitualSpear = 530530,

        [Annotation(Name = "[巨人山顶 - “大土龙”席欧朵利克] 龙心脏 530550")]
        MountaintopsOfTheGiantsFieldGreatWyrmTheodorixDragonHeart = 530550,

        [Annotation(Name = "[化圣雪原 - 腐败化身] 连刺破露滴 65130")]
        ConsecratedSnowfieldFieldPutridAvatarThornyCrackedTear = 65130,

        [Annotation(Name = "[化圣雪原 - 腐败化身] 爆裂结晶露滴 65170")]
        ConsecratedSnowfieldFieldPutridAvatarRupturedCrystalTear = 65170,

        [Annotation(Name = "[腐败湖 - 龙人士兵] 龙鳞刀 530600")]
        LakeOfRotDragonkinSoldierDragonscaleBlade = 530600,

        [Annotation(Name = "[希芙拉河 - 龙人士兵] 龙戟 530620")]
        SiofraRiverDragonkinSoldierDragonHalberd = 530620,

        [Annotation(Name = "[粪金龟 - 风暴山丘] 战灰：风暴障壁 540100")]
        TeardropScarabStormhillAshOfWarStormWall = 540100,

        [Annotation(Name = "[粪金龟 - 风暴山丘] 战灰：盲击 540104")]
        TeardropScarabStormhillAshOfWarWildStrikes = 540104,

        [Annotation(Name = "[粪金龟 - 亚基尔湖] 战灰：决心 540108")]
        TeardropScarabAgheelLakeAshOfWarDetermination = 540108,

        [Annotation(Name = "[粪金龟 - 亚基尔湖] 战灰：居合 540112")]
        TeardropScarabAgheelLakeAshOfWarUnsheathe = 540112,

        [Annotation(Name = "[粪金龟 - 雾林] 战灰：坠落震击 540116")]
        TeardropScarabMistwoodAshOfWarGroundSlam = 540116,

        [Annotation(Name = "[粪金龟 - 玛莉卡第三教堂] 战灰：神圣刀刃 540118")]
        TeardropScarabThirdChuchOfMarikaAshOfWarSacredBlade = 540118,

        [Annotation(Name = "[粪金龟 - 宁姆格福海岸] 战灰：箭步（回旋斩） 540120")]
        TeardropScarabLimgraveCoastAshOfWarStampSweep = 540120,

        [Annotation(Name = "[粪金龟 - 啜泣半岛] 圣防护 540132")]
        TeardropScarabWeepingPeninsulaDivineFortification = 540132,

        [Annotation(Name = "[粪金龟 - 啜泣半岛] 雷击 540136")]
        TeardropScarabWeepingPeninsulaLightningStrike = 540136,

        [Annotation(Name = "[粪金龟 - 啜泣半岛] 毒雾 540138")]
        TeardropScarabWeepingPeninsulaPoisonMist = 540138,

        [Annotation(Name = "[粪金龟 - 啜泣半岛] 战灰：拉满弓 540140")]
        TeardropScarabWeepingPeninsulaAshOfWarMightyShot = 540140,

        [Annotation(Name = "[粪金龟 - 宁姆格福] 失色锻造石【１】 540142")]
        TeardropScarabLimgraveSomberSmithingStone1 = 540142,

        [Annotation(Name = "[粪金龟 - 宁姆格福] 失色锻造石【１】 540144")]
        TeardropScarabLimgraveSomberSmithingStone1_ = 540144,

        [Annotation(Name = "[粪金龟 - 宁姆格福] 失色锻造石【１】 540146")]
        TeardropScarabLimgraveSomberSmithingStone1__ = 540146,

        [Annotation(Name = "[粪金龟 - 史东薇尔城] 战灰：风暴袭击 540170")]
        TeardropScarabStormveilCastleAshOfWarStormAssault = 540170,

        [Annotation(Name = "[粪金龟 - 史东薇尔城] 战灰：唤起风暴 540172")]
        TeardropScarabStormveilCastleAshOfWarStormcaller = 540172,

        [Annotation(Name = "[粪金龟 - 史东薇尔城] 召唤怨魂 540174")]
        TeardropScarabStormveilCastleRancorcall = 540174,

        [Annotation(Name = "[粪金龟 - 三姊妹塔] 战灰：寒气冻雾 540200")]
        TeardropScarabThreeSistersAshOfWarChillingMist = 540200,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 战灰：突击 540202")]
        TeardropScarabLiurniaAshOfWarChargeForth = 540202,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 战灰：冻霜踏地 540204")]
        TeardropScarabLiurniaAshOfWarHoarfrostStomp = 540204,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 战灰：托普斯的力场 540206")]
        TeardropScarabLiurniaAshOfWarThopssBarrier = 540206,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 战灰：无敌 540208")]
        TeardropScarabLiurniaAshOfWarVowOfTheIndomitable = 540208,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 战灰：盾牌冲击 540210")]
        TeardropScarabLiurniaAshOfWarShieldBash = 540210,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 血焰刀刃 540218")]
        TeardropScarabLiurniaBloodflameBlade = 540218,

        [Annotation(Name = "[粪金龟 - 卡利亚城寨] 卡利亚贯刺 540220")]
        TeardropScarabCariaManorCarianPiercer = 540220,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 战灰：野蛮咆哮 540224")]
        TeardropScarabLiurniaAshOfWarBarbaricRoar = 540224,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 划空癫火 540236")]
        TeardropScarabLiurniaFrenziedBurst = 540236,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 战灰：剑舞 540238")]
        TeardropScarabLiurniaAshOfWarSwordDance = 540238,

        [Annotation(Name = "[粪金龟 - 卡利亚城寨] 结冰武器 540250")]
        TeardropScarabCariaManorFrozenArmament = 540250,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 失色锻造石【２】 540252")]
        TeardropScarabLiurniaSomberSmithingStone2 = 540252,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 失色锻造石【２】 540254")]
        TeardropScarabLiurniaSomberSmithingStone2_ = 540254,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 失色锻造石【３】 540256")]
        TeardropScarabLiurniaSomberSmithingStone3 = 540256,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 失色锻造石【３】 540258")]
        TeardropScarabLiurniaSomberSmithingStone3_ = 540258,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 失色锻造石【２】 540260")]
        TeardropScarabLiurniaSomberSmithingStone2__ = 540260,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 失色锻造石【２】 540262")]
        TeardropScarabLiurniaSomberSmithingStone2___ = 540262,

        [Annotation(Name = "[粪金龟 - 湖之利耶尼亚] 失色锻造石【２】 540264")]
        TeardropScarabLiurniaSomberSmithingStone2____ = 540264,

        [Annotation(Name = "[粪金龟 - 魔法学院雷亚卢卡利亚] 战灰：幻影枪 540272")]
        TeardropScarabRayaLucariaAcademyAshOfWarSpectralLance = 540272,

        [Annotation(Name = "[粪金龟 - 魔法学院雷亚卢卡利亚] 失色锻造石【４】 540290")]
        TeardropScarabRayaLucariaAcademySomberSmithingStone4 = 540290,

        [Annotation(Name = "[粪金龟 - 亚坛高原] 战灰：圣律 540300")]
        TeardropScarabAltusPlateauAshOfWarSacredOrder = 540300,

        [Annotation(Name = "[粪金龟 - 亚坛高原] 战灰：突进冲击 540302")]
        TeardropScarabAltusPlateauAshOfWarShieldCrash = 540302,

        [Annotation(Name = "[粪金龟 - 亚坛高原] 战灰：撼地 540304")]
        TeardropScarabAltusPlateauAshOfWarEarthshaker = 540304,

        [Annotation(Name = "[粪金龟 - 亚坛高原] 战灰：血刃 540306")]
        TeardropScarabAltusPlateauAshOfWarBloodBlade = 540306,

        [Annotation(Name = "[粪金龟 - 亚坛高原] 战灰：黄金坠落震击 540308")]
        TeardropScarabAltusPlateauAshOfWarGoldenSlam = 540308,

        [Annotation(Name = "[粪金龟 - 亚坛高原] 战灰：雷电羊球 540310")]
        TeardropScarabAltusPlateauAshOfWarLightningRam = 540310,

        [Annotation(Name = "[粪金龟 - 亚坛高原] 黄金树庇佑 540312")]
        TeardropScarabAltusPlateauProtectionOfTheErdtree = 540312,

        [Annotation(Name = "[粪金龟 - 王城城墙外] 战灰：祈祷一击 540314")]
        TeardropScarabCapitalOutskirtsAshOfWarPrayerfulStrike = 540314,

        [Annotation(Name = "[粪金龟 - 王城城墙外] 战灰：黄金格挡 540316")]
        TeardropScarabCapitalOutskirtsAshOfWarGoldenParry = 540316,

        [Annotation(Name = "[粪金龟 - 王城城墙外] 战灰：雷击斩 540318")]
        TeardropScarabCapitalOutskirtsAshOfWarLightningSlash = 540318,

        [Annotation(Name = "[粪金龟 - 王城城墙外] 失色锻造石【５】 540320")]
        TeardropScarabCapitalOutskirtsSomberSmithingStone5 = 540320,

        [Annotation(Name = "[粪金龟 - 格密尔火山] 战灰：连续射击 540332")]
        TeardropScarabMtGelmirAshOfWarBarrage = 540332,

        [Annotation(Name = "[粪金龟 - 格密尔火山] 战灰：贯穿射击 540334")]
        TeardropScarabMtGelmirAshOfWarThroughandThrough = 540334,

        [Annotation(Name = "[粪金龟 - 王城罗德尔] 黄金魔力防护 540370")]
        TeardropScarabLeyndellBarrierOfGold = 540370,

        [Annotation(Name = "[粪金龟 - 王城罗德尔] 战灰：落雷 540372")]
        TeardropScarabLeyndellAshOfWarThunderbolt = 540372,

        [Annotation(Name = "[粪金龟 - 盖利德] 火焰啊，缠绕吧 540400")]
        TeardropScarabCaelidWhirlOFlame = 540400,

        [Annotation(Name = "[粪金龟 - 盖利德] 战灰：夺命拳 540402")]
        TeardropScarabCaelidAshOfWarLifestealFist = 540402,

        [Annotation(Name = "[粪金龟 - 盖利德] 战灰：神圣光环 540404")]
        TeardropScarabCaelidAshOfWarSacredRingOfLight = 540404,

        [Annotation(Name = "[粪金龟 - 盖利德] 战灰：毒雾 540406")]
        TeardropScarabCaelidAshOfWarPoisonousMist = 540406,

        [Annotation(Name = "[粪金龟 - 红狮子城] 战灰：炎击 540408")]
        TeardropScarabRedmaneCastleAshOfWarFlamingStrike = 540408,

        [Annotation(Name = "[粪金龟 - 盖利德] 战灰：红狮子火焰 540410")]
        TeardropScarabCaelidAshOfWarFlameOfTheRedmanes = 540410,

        [Annotation(Name = "[粪金龟 - 桂奥尔龙墓] 战灰：对空射击 540412")]
        TeardropScarabDragonbarrowAshOfWarSkyShot = 540412,

        [Annotation(Name = "[粪金龟 - 桂奥尔龙墓] 战灰：岩石剑 540414")]
        TeardropScarabDragonbarrowAshOfWarCragblade = 540414,

        [Annotation(Name = "[粪金龟 - 盖利德] 毒刃 540416")]
        TeardropScarabCaelidPoisonArmament = 540416,

        [Annotation(Name = "[粪金龟 - 盖利德] 战灰：二连斩 540418")]
        TeardropScarabCaelidAshOfWarDoubleSlash = 540418,

        [Annotation(Name = "[粪金龟 - 盖利德] 野兽健壮 540420")]
        TeardropScarabCaelidBestialConstitution = 540420,

        [Annotation(Name = "[粪金龟 - 盖利德] 失色锻造石【４】 540422")]
        TeardropScarabCaelidSomberSmithingStone4 = 540422,

        [Annotation(Name = "[粪金龟 - 盖利德] 失色锻造石【４】 540424")]
        TeardropScarabCaelidSomberSmithingStone4_ = 540424,

        [Annotation(Name = "[粪金龟 - 盖利德] 失色锻造石【８】 540426")]
        TeardropScarabCaelidSomberSmithingStone8 = 540426,

        [Annotation(Name = "[粪金龟 - 盖利德] 失色锻造石【９】 540428")]
        TeardropScarabCaelidSomberSmithingStone9 = 540428,

        [Annotation(Name = "锻造石【１】 540500")]
        SmithingStone1 = 540500,

        [Annotation(Name = "锻造石【１】 540502")]
        SmithingStone1_ = 540502,

        [Annotation(Name = "锻造石【１】 540504")]
        SmithingStone1__ = 540504,

        [Annotation(Name = "锻造石【１】 540506")]
        SmithingStone1___ = 540506,

        [Annotation(Name = "锻造石【１】 540508")]
        SmithingStone1____ = 540508,

        [Annotation(Name = "[粪金龟 - 巨人山顶] 战灰：切腹 540510")]
        TeardropScarabMountaintopsOfTheGiantsAshOfWarSeppuku = 540510,

        [Annotation(Name = "[粪金龟 - 巨人山顶] 战灰：山妖咆哮 540512")]
        TeardropScarabMountaintopsOfTheGiantsAshOfWarTrollsRoar = 540512,

        [Annotation(Name = "[粪金龟 - 巨人战争的英雄墓地] 火焰的庇佑啊 540514")]
        TeardropScarabGiantConqueringHerosGraveFlameProtectMe = 540514,

        [Annotation(Name = "[粪金龟 - 禁域] 战灰：主教冲锋 540516")]
        TeardropScarabForbiddenLandsAshOfWarPrelatesCharge = 540516,

        [Annotation(Name = "锻造石【１】 540520")]
        SmithingStone1_____ = 540520,

        [Annotation(Name = "锻造石【１】 540522")]
        SmithingStone1______ = 540522,

        [Annotation(Name = "[粪金龟 - 化圣雪原] 战灰：白影诱惑 540524")]
        TeardropScarabConsecratedSnowfieldAshOfWarWhiteShadowsLure = 540524,

        [Annotation(Name = "锻造石【１】 540526")]
        SmithingStone1_______ = 540526,

        [Annotation(Name = "锻造石【１】 540528")]
        SmithingStone1________ = 540528,

        [Annotation(Name = "黄金卢恩【１】 540570")]
        GoldenRune1 = 540570,

        [Annotation(Name = "黄金卢恩【１】 540572")]
        GoldenRune1_ = 540572,

        [Annotation(Name = "黄金卢恩【１】 540574")]
        GoldenRune1__ = 540574,

        [Annotation(Name = "黄金卢恩【１】 540576")]
        GoldenRune1___ = 540576,

        [Annotation(Name = "[粪金龟 - 希芙拉河] 失色锻造石【５】 540590")]
        TeardropScarabSiofraRiverSomberSmithingStone5 = 540590,

        [Annotation(Name = "[粪金龟 - 希芙拉河] 失色锻造石【５】 540592")]
        TeardropScarabSiofraRiverSomberSmithingStone5_ = 540592,

        [Annotation(Name = "[粪金龟 - 希芙拉河] 失色锻造石【６】 540600")]
        TeardropScarabSiofraRiverSomberSmithingStone6 = 540600,

        [Annotation(Name = "[粪金龟 - 希芙拉河] 失色锻造石【６】 540602")]
        TeardropScarabSiofraRiverSomberSmithingStone6_ = 540602,

        [Annotation(Name = "[粪金龟 - 希芙拉河] 神谕大泡泡 540610")]
        TeardropScarabSiofraRiverGreatOracularBubble = 540610,

        [Annotation(Name = "黄金卢恩【１】 540612")]
        GoldenRune1____ = 540612,

        [Annotation(Name = "黄金卢恩【１】 540614")]
        GoldenRune1_____ = 540614,

        [Annotation(Name = "黄金卢恩【１】 540616")]
        GoldenRune1______ = 540616,

        [Annotation(Name = "黄金卢恩【１】 540618")]
        GoldenRune1_______ = 540618,

        [Annotation(Name = "[粪金龟 - 希芙拉河] 战灰：准备架式 540630")]
        TeardropScarabSiofraRiverAshOfWarSquareOff = 540630,

        [Annotation(Name = "黄金卢恩【１】 540632")]
        GoldenRune1________ = 540632,

        [Annotation(Name = "黄金卢恩【１】 540634")]
        GoldenRune1_________ = 540634,

        [Annotation(Name = "黄金卢恩【１】 540636")]
        GoldenRune1__________ = 540636,

        [Annotation(Name = "黄金卢恩【１】 540638")]
        GoldenRune1___________ = 540638,

        [Annotation(Name = "黄金卢恩【１】 540640")]
        GoldenRune1____________ = 540640,

        [Annotation(Name = "[粪金龟 - “永恒之城”诺克隆恩] 失色锻造石【５】 540642")]
        TeardropScarabNokronSomberSmithingStone5 = 540642,

        [Annotation(Name = "黄金卢恩【１】 540644")]
        GoldenRune1_____________ = 540644,

        [Annotation(Name = "[粪金龟 - “永恒之城”诺克隆恩] 战灰：宿灵射击 540646")]
        TeardropScarabNokronAshOfWarEnchantedShot = 540646,

        [Annotation(Name = "[粪金龟 - “永恒之城”诺克隆恩] 圣律疗愈 540648")]
        TeardropScarabNokronOrderHealing = 540648,

        [Annotation(Name = "黄金卢恩【１】 540650")]
        GoldenRune1______________ = 540650,

        [Annotation(Name = "[粪金龟 - 希芙拉河] 神谕泡泡 540652")]
        TeardropScarabSiofraRiverOracleBubbles = 540652,

        [Annotation(Name = "[粪金龟 - 深根底层] 战灰：黄金大地 540660")]
        TeardropScarabDeeprootDepthsAshOfWarGoldenLand = 540660,

        [Annotation(Name = "黄金卢恩【１】 540662")]
        GoldenRune1_______________ = 540662,

        [Annotation(Name = "黄金卢恩【１】 540664")]
        GoldenRune1________________ = 540664,

        [Annotation(Name = "黄金卢恩【１】 540666")]
        GoldenRune1_________________ = 540666,

        [Annotation(Name = "失色锻造石【６】 540668")]
        SomberSmithingStone6 = 540668,

        [Annotation(Name = "失色锻造石【６】 540670")]
        SomberSmithingStone6_ = 540670,

        [Annotation(Name = "黄金卢恩【１】 540680")]
        GoldenRune1__________________ = 540680,

        [Annotation(Name = "黄金卢恩【１】 540682")]
        GoldenRune1___________________ = 540682,

        [Annotation(Name = "黄金卢恩【１】 540684")]
        GoldenRune1____________________ = 540684,

        [Annotation(Name = "[粪金龟 - 蒙格温王朝庙] 战灰：鲜血征收 540686")]
        TeardropScarabMohgwynDynastyAshOfWarBloodTax = 540686,

        [Annotation(Name = "[粪金龟 - 逐渐崩毁的法姆·亚兹拉] 黄金雷防护 540772")]
        TeardropScarabCrumblingFarumAzulaGoldenLightningFortification = 540772,

        [Annotation(Name = "[提示物品] 说明：赐福 550000")]
        InfoItemAboutSitesOfGrace = 550000,

        [Annotation(Name = "[提示物品] 说明：魔法与祷告 550010")]
        InfoItemAboutSorceriesandIncantations = 550010,

        [Annotation(Name = "[提示物品] 说明：弓 550020")]
        InfoItemAboutBows = 550020,

        [Annotation(Name = "[提示物品] 说明：蹲下 550030")]
        InfoItemAboutCrouching = 550030,

        [Annotation(Name = "[提示物品] 说明：失去平衡 550040")]
        InfoItemAboutStanceBreaking = 550040,

        [Annotation(Name = "[提示物品] 说明：玛莉卡楔石 550050")]
        InfoItemAboutStakesOfMarika = 550050,

        [Annotation(Name = "[提示物品] 说明：防御反击 550060")]
        InfoItemAboutGuardCounters = 550060,

        [Annotation(Name = "[提示物品] 说明：地图 550070")]
        InfoItemAboutTheMap = 550070,

        [Annotation(Name = "[提示物品] 说明：赐福的指引 550080")]
        InfoItemAboutGuidanceOfGrace = 550080,

        [Annotation(Name = "[提示物品] 说明：骑马 550090")]
        InfoItemAboutHorsebackRiding = 550090,

        [Annotation(Name = "[提示物品] 说明：死亡 550100")]
        InfoItemAboutDeath = 550100,

        [Annotation(Name = "[提示物品] 说明：召唤灵魂 550110")]
        InfoItemAboutSummoningSpirits = 550110,

        [Annotation(Name = "[提示物品] 说明：防御 550120")]
        InfoItemAboutGuarding = 550120,

        [Annotation(Name = "[提示物品] 说明：制作道具 550130")]
        InfoItemAboutItemCrafting = 550130,

        [Annotation(Name = "[提示物品] 说明：灵药圣杯瓶 550150")]
        InfoItemAboutFlaskOfWondrousPhysick = 550150,

        [Annotation(Name = "[提示物品] 说明：赋予战技 550160")]
        InfoItemAboutAddingSkills = 550160,

        [Annotation(Name = "[提示物品] 说明：鸟瞰镜 550170")]
        InfoItemAboutBirdseyeTelescopes = 550170,

        [Annotation(Name = "[提示物品] 说明：灵魂气流跳跃 550180")]
        InfoItemAboutSpiritspringJumping = 550180,

        [Annotation(Name = "[提示物品] 说明：打败敌对团体 550190")]
        InfoItemAboutVanquishingEnemyGroups = 550190,

        [Annotation(Name = "[提示物品] 说明：露滴粪金龟 550200")]
        InfoItemAboutTeardropScarabs = 550200,

        [Annotation(Name = "[提示物品] 说明：召唤其他玩家 550210")]
        InfoItemAboutSummoningOtherPlayers = 550210,

        [Annotation(Name = "[提示物品] 说明：协力多人联机游玩 550220")]
        InfoItemAboutCooperativeMultiplayer = 550220,

        [Annotation(Name = "[提示物品] 说明：敌对多人联机游玩 550230")]
        InfoItemAboutCompetitiveMultiplayer = 550230,

        [Annotation(Name = "[提示物品] 说明：入侵多人联机游玩 550240")]
        InfoItemAboutInvasionMultiplayer = 550240,

        [Annotation(Name = "[提示物品] 说明：猎人多人联机游玩 550250")]
        InfoItemAboutHunterMultiplayer = 550250,

        [Annotation(Name = "[提示物品] 说明：记号聚集处 550260")]
        InfoItemAboutSummoningPools = 550260,

        [Annotation(Name = "[提示物品] 说明：碑文图案 550270")]
        InfoItemAboutMonumentIcon = 550270,

        [Annotation(Name = "[提示物品] 说明：召唤猎人 550280")]
        InfoItemAboutRequestingHelpfromHunters = 550280,

        [Annotation(Name = "[提示物品] 说明：战技 550290")]
        InfoItemAboutSkills = 550290,

        [Annotation(Name = "[宁姆格福 - 画家的破屋] 绘画《归巢》 580000")]
        LimgraveArtistsShackHomingInstinctPainting = 580000,

        [Annotation(Name = "[湖之利耶尼亚 - 画家的破屋] 绘画《再世》 580010")]
        LiurniaArtistsShackResurrectionPainting = 580010,

        [Annotation(Name = "[亚坛高原 - 日荫城] 绘画《英雄之歌》 580020")]
        AltusPlateauShadedCastleChampionsSongPainting = 580020,

        [Annotation(Name = "[化圣雪原 - 索尔城] 绘画《魔法师》 580030")]
        ConsecratedSnowfieldCastleSolSorcererPainting = 580030,

        [Annotation(Name = "[史东薇尔城] 绘画《预言》 580040")]
        StormveilCastleProphecyPainting = 580040,

        [Annotation(Name = "[王城罗德尔 - 城寨一楼] 绘画《不飞之鸟》 580050")]
        LeyndellFortifedManorFlightlessBirdPainting = 580050,

        [Annotation(Name = "[盖利德 - 魔法镇瑟利亚] 绘画《红狮子》 580060")]
        CaelidSelliaRedmanePainting = 580060,

        [Annotation(Name = "[奖励 - 绘画《归巢》] 祷告粪金龟 580300")]
        RewardHomingInstinctPaintingIncantationScarab = 580300,

        [Annotation(Name = "[奖励 - 绘画《再世》] 年幼学徒帽子 580310")]
        RewardResurrectionPaintingJuvenileScholarCap = 580310,

        [Annotation(Name = "[奖励 - 绘画《英雄之歌》] 竖琴弓 580320")]
        RewardChampionsSongPaintingHarpBow = 580320,

        [Annotation(Name = "[奖励 - 绘画《魔法师》] 大风帽 580330")]
        RewardSorcererPaintingGreathood = 580330,

        [Annotation(Name = "[奖励 - 绘画《预言》] 战鹰的骨灰 580340")]
        RewardProphecyPaintingWarhawkAshes = 580340,

        [Annotation(Name = "[奖励 - 绘画《不飞之鸟》] 火焰重罪 580350")]
        RewardFlightlessBirdPaintingFiresDeadlySin = 580350,

        [Annotation(Name = "[奖励 - 绘画《红狮子》] 战灰：箭雨 580360")]
        RewardRedmanePaintingAshOfWarRainOfArrows = 580360,

        [Annotation(Name = "[梅琳娜 - 关卡前方] 灵马哨笛 60100")]
        MelinaThirdGraceFoundSpectralSteedWhistle = 60100,

        [Annotation(Name = "[梅琳娜 - 击杀蒙葛特] 洛德符节 400001")]
        MelinaMorgottKilledRoldMedallion = 400001,

        [Annotation(Name = "[未知]  400010")]
        Unknown = 400010,

        [Annotation(Name = "[未知] 中毒苔药 400020")]
        UnknownNeutralizingBoluses = 400020,

        [Annotation(Name = "[未知]  400021")]
        Unknown_ = 400021,

        [Annotation(Name = "[“白面具”梵雷 - ?] 溃烂血指 400030")]
        WhiteFacedVarreFesteringBloodyFinger = 400030,

        [Annotation(Name = "[“白面具”梵雷 - 女巫染血] 鲜血君王的立誓布 400031")]
        WhiteFacedVarreMaidenKillLordOfBloodsFavor = 400031,

        [Annotation(Name = "[“白面具”梵雷 - 三次入侵] 纯血骑士勋章 400032")]
        WhiteFacedVarre3InvasionsPurebloodKnightsMedal = 400032,

        [Annotation(Name = "[“白面具”梵雷 - 女巫染血] 鲜血君王的立誓布 400033")]
        WhiteFacedVarreMaidenKillLordOfBloodsFavor_ = 400033,

        [Annotation(Name = "[“白面具”梵雷 - 染血归来] 血指 60270")]
        WhiteFacedVarreReturnedOathClothBloodyFinger = 60270,

        [Annotation(Name = "[“白面具”梵雷]  400035")]
        WhiteFacedVarre = 400035,

        [Annotation(Name = "[“白面具”梵雷 - 入侵] 梵雷的花束 400037")]
        WhiteFacedVarreInvasionVarresBouquet = 400037,

        [Annotation(Name = "[“白面具”梵雷 - 入侵] 溃烂血指 400036")]
        WhiteFacedVarreInvasionFesteringBloodyFinger = 400036,

        [Annotation(Name = "[未知]  400040")]
        Unknown__ = 400040,

        [Annotation(Name = "[未知] 调香瓶 400041")]
        UnknownPerfumeBottle = 400041,

        [Annotation(Name = "[未知] 照明石 400042")]
        UnknownGlowstone = 400042,

        [Annotation(Name = "[门卫葛托克 - 初次抓获] 拟态赐福 400050")]
        GatekeeperGostocFirstMeetingGraceMimic = 400050,

        [Annotation(Name = "[门卫葛托克 - 击杀葛托克] 葛托克的铃珠 400051")]
        GatekeeperGostocGostocKilledGostocsBellBearing = 400051,

        [Annotation(Name = "[城主艾德格] 牺牲细枝 400060")]
        EdgarSacrificialTwig = 400060,

        [Annotation(Name = "[城主艾德格] 夏玻利利葡萄 400061")]
        EdgarShabririGrape = 400061,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 遗忘秘药 400070")]
        TanithTonicOfForgetfulness = 400070,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 侧室面具 400071")]
        TanithConsortsMask = 400071,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 客房钥匙 400072")]
        TanithDrawingRoomKey = 400072,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 来自火山官邸的信 400073")]
        TanithLetterfromVolcanoManor = 400073,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 来自火山官邸的信 400074")]
        TanithLetterfromVolcanoManor_ = 400074,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 鲜红书信 400075")]
        TanithRedLetter = 400075,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 熔岩球 400076")]
        TanithMagmaShot = 400076,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 蛇骨刀 400077")]
        TanithSerpentboneBlade = 400077,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 掠夺浮雕坠饰 400078")]
        TanithTakersCameo = 400078,

        [Annotation(Name = "[“火山官邸之主”塔妮丝] 熔炉百相之喉囊 400079")]
        TanithAspectsOfTheCrucibleBreath = 400079,

        [Annotation(Name = "[摩恩的伊蕾娜] 伊蕾娜的信 400080")]
        IrinaIrinasLetter = 400080,

        [Annotation(Name = "[“招募者”菈雅] 菈雅的项链 400081")]
        RyaRyasNecklace = 400081,

        [Annotation(Name = "[“探寻灯火”海妲] 癫火圣印记 400089")]
        HyettaFrenziedFlameSeal = 400089,

        [Annotation(Name = "[“招募者”菈雅] 火山官邸的邀请函 400090")]
        RyaVolcanoManorInvitation = 400090,

        [Annotation(Name = "[“招募者”菈雅] 泽菈雅丝的信 400091")]
        RyaZorayassLetter = 400091,

        [Annotation(Name = "[魔法师瑟濂] 瑟濂的源辉石 400100")]
        SorceressSellenSellensPrimalGlintstone = 400100,

        [Annotation(Name = "[魔法师瑟濂] 辉石克力士 400101")]
        SorceressSellenGlintstoneKris = 400101,

        [Annotation(Name = "[魔法师瑟濂] 瑟利亚封印钥匙 400102")]
        SorceressSellenSellianSealbreaker = 400102,

        [Annotation(Name = "[魔法师瑟濂] 星光碎片 400103")]
        SorceressSellenStarlightShards = 400103,

        [Annotation(Name = "[魔法师瑟濂] 彗星亚兹勒 400104")]
        SorceressSellenCometAzur = 400104,

        [Annotation(Name = "[魔法师瑟濂] 毁灭流星 400105")]
        SorceressSellenStarsOfRuin = 400105,

        [Annotation(Name = "[魔法师瑟濂] 瑟濂的铃珠 400106")]
        SorceressSellenSellensBellBearing = 400106,

        [Annotation(Name = "[魔法师瑟濂] 魔女辉石头罩 400107")]
        SorceressSellenWitchsGlintstoneCrown = 400107,

        [Annotation(Name = "[“解指”恩雅 - “初始之王”葛孚雷] 护符皮袋 60500")]
        FingerReaderEniaGodfreyTalismanPouch = 60500,

        [Annotation(Name = "[未知] 照明石 400120")]
        UnknownGlowstone_ = 400120,

        [Annotation(Name = "[未知] 照明石 400121")]
        UnknownGlowstone__ = 400121,

        [Annotation(Name = "[艾尔帕斯] 圣树秘密符节（右） 400130")]
        AlbusHaligtreeSecretMedallionRight = 400130,

        [Annotation(Name = "[魔法教授赛尔维斯] 赛尔维斯的药水 400140")]
        SeluvisSeluvissPotion = 400140,

        [Annotation(Name = "[魔法教授赛尔维斯] 魔力对蝎 400141")]
        SeluvisMagicScorpionCharm = 400141,

        [Annotation(Name = "[魔法教授赛尔维斯]  400142")]
        Seluvis = 400142,

        [Annotation(Name = "[魔法教授赛尔维斯] 赛尔维斯的介绍信 400143")]
        SeluvisSeluvissIntroduction = 400143,

        [Annotation(Name = "[魔法教授赛尔维斯] 照明石 400144")]
        SeluvisGlowstone = 400144,

        [Annotation(Name = "[魔法教授赛尔维斯] 琥珀色药水 400145")]
        SeluvisAmberDraught = 400145,

        [Annotation(Name = "[魔法教授赛尔维斯]  400146")]
        Seluvis_ = 400146,

        [Annotation(Name = "[魔法教授赛尔维斯] 赛尔维斯的铃珠 400148")]
        SeluvisSeluvissBellBearing = 400148,

        [Annotation(Name = "[仆人毕迪] 毕迪的铃珠 400149")]
        PidiaCarianServantPidiasBellBearing = 400149,

        [Annotation(Name = "[“半狼”布莱泽] 失色锻造石【２】 400150")]
        BlaiddisTheHalfWolfSomberSmithingStone2 = 400150,

        [Annotation(Name = "[“半狼”布莱泽] 王室巨剑 400158")]
        BlaiddisTheHalfWolfRoyalGreatsword = 400158,

        [Annotation(Name = "[“半狼”布莱泽] 被丢弃的王室钥匙 400159")]
        BlaiddisTheHalfWolfDiscardedPalaceKey = 400159,

        [Annotation(Name = "[未知] 白秘文戒指 60280")]
        UnknownWhiteCipherRing = 60280,

        [Annotation(Name = "[未知] 锻造石【５】 400161")]
        UnknownSmithingStone5 = 400161,

        [Annotation(Name = "[“纯紫血指”艾琉诺拉] 净血结晶露滴 65270")]
        EleonoraVioletBloodyFingerPurifyingCrystalTear = 65270,

        [Annotation(Name = "[“纯紫血指”艾琉诺拉] 艾琉诺拉的双头刀 400162")]
        EleonoraVioletBloodyFingerEleonorasPoleblade = 400162,

        [Annotation(Name = "[“血指猎人”尤拉] 长牙 - 战灰：突刺 400163")]
        BloodyFingerHunterYuraNagakiba0PiercingFang = 400163,

        [Annotation(Name = "[“血指猎人”尤拉] 铁笠帽 400164")]
        BloodyFingerHunterYuraIronKasa = 400164,

        [Annotation(Name = "[“战士壶”亚历山大] 勇者肉块 400170")]
        IronFistAlexanderExaltedFlesh = 400170,

        [Annotation(Name = "[“战士壶”亚历山大] 勇者肉块 400171")]
        IronFistAlexanderExaltedFlesh_ = 400171,

        [Annotation(Name = "[“战士壶”亚历山大] 壶头罩 400172")]
        IronFistAlexanderJar = 400172,

        [Annotation(Name = "[“战士壶”亚历山大] 战士壶碎片 400173")]
        IronFistAlexanderWarriorJarShard = 400173,

        [Annotation(Name = "[“战士壶”亚历山大] 亚历山大的碎片 400174")]
        IronFistAlexanderShardOfAlexander = 400174,

        [Annotation(Name = "[未知]  400179")]
        Unknown___ = 400179,

        [Annotation(Name = "[帕奇] 给帕奇的信 400180")]
        PatchesLettertoPatches = 400180,

        [Annotation(Name = "[帕奇] 舞娘的打击乐器 400181")]
        PatchesDancersCastanets = 400181,

        [Annotation(Name = "[帕奇] 熔岩烛台鞭 400182")]
        PatchesMagmaWhipCandlestick = 400182,

        [Annotation(Name = "[帕奇] 黄金卢恩【１】 400183")]
        PatchesGoldenRune1 = 400183,

        [Annotation(Name = "[帕奇] 矛+7 400184")]
        PatchesSpear7 = 400184,

        [Annotation(Name = "[罗德莉卡] 灵魂水母的骨灰 400190")]
        RoderikaSpiritJellyfishAshes = 400190,

        [Annotation(Name = "[罗德莉卡] 黄金种子 400191")]
        RoderikaGoldenSeed = 400191,

        [Annotation(Name = "[宝箱 - 关卡前废墟] 砥石小刀 400210")]
        ChestGatefrontRuinsWhetstoneKnife = 400210,

        [Annotation(Name = "[“领主的嫡长子”肯尼斯·海德] 黄铜短刀 400221")]
        KennethHaightErdsteelDagger = 400221,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第4个死根] 战灰：野兽咆哮 400235")]
        Gurranq4thDeathrootAshOfWarBeastsRoar = 400235,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第3个死根] 野兽活力 400236")]
        Gurranq3rdDeathrootBestialVitality = 400236,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第2个死根] 兽石 400237")]
        Gurranq2ndDeathrootBestialSling = 400237,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第1个死根] 爪痕圣印记 400238")]
        Gurranq1stDeathrootClawmarkSeal = 400238,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第1个死根] 野兽眼眸 400239")]
        Gurranq1stDeathrootBeastEye = 400239,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第9个死根] 古龙岩锻造石 400230")]
        Gurranq9thDeathrootDragonSmithingStone = 400230,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第8个死根] 古兰格的兽爪 400231")]
        Gurranq8thDeathrootGurranqsBeastClaw = 400231,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第7个死根] 兽爪大锤 400232")]
        Gurranq7thDeathrootBeastclawGreathammer = 400232,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第6个死根] 古兰格的岩石 400233")]
        Gurranq6thDeathrootStoneOfGurranq = 400233,

        [Annotation(Name = "[“野兽祭司”古兰格 - 第5个死根] 兽爪 400234")]
        Gurranq5thDeathrootBeastClaw = 400234,

        [Annotation(Name = "[军师伊吉] 伊吉的铃珠 400240")]
        WarCounselorIjiIjisBellBearing = 400240,

        [Annotation(Name = "[军师伊吉] 伊吉镜面盔 400241")]
        WarCounselorIjiIjisMirrorhelm = 400241,

        [Annotation(Name = "[未知] 照明石 400260")]
        UnknownGlowstone___ = 400260,

        [Annotation(Name = "[未知] 蘑菇 400271")]
        UnknownMushroom = 400271,

        //duplicate of 1051587800
        //[Annotation(Name = "[Castle Sol] Haligtree Secret Medallion (Left) 400280")]
        //CastleSolHaligtreeSecretMedallionLeft = 400280,

        [Annotation(Name = "[未知]  400281")]
        Unknown____ = 400281,

        [Annotation(Name = "[“百智爵士”基甸·奥夫尼尔 - 圣树秘密符节] 黑焰庇佑 400282")]
        GideonOfnirSecretMedallionBlackFlamesProtection = 400282,

        [Annotation(Name = "[“百智爵士”基甸·奥夫尼尔 - 米凯拉的圣树] 王之圣防护 400283")]
        GideonOfnirHaligtreeLordsDivineFortification = 400283,

        [Annotation(Name = "[“百智爵士”基甸·奥夫尼尔 - 蒙格温王朝庙] 法力斯的制作笔记【３】 68210")]
        GideonOfnirMohgwynDynastyMausoleumFevorsCookbook3 = 68210,

        [Annotation(Name = "[“百智爵士”基甸·奥夫尼尔 - 击杀蒙格] 因果性原理 400285")]
        GideonOfnirMohgKilledLawOfCausality = 400285,

        [Annotation(Name = "[“百智爵士”基甸·奥夫尼尔 - Boss掉落] 百智臂甲 400284")]
        GideonOfnirBossDropAllKnowingGauntlets = 400284,

        [Annotation(Name = "[骑士贝纳尔] 给贝纳尔的信 400290")]
        KnightBernahlLettertoBernahl = 400290,

        [Annotation(Name = "[骑士贝纳尔] 格密尔之怒 400291")]
        KnightBernahlGelmirsFury = 400291,

        [Annotation(Name = "[骑士贝纳尔] 亵渎兽爪 400292")]
        KnightBernahlBlasphemousClaw = 400292,

        [Annotation(Name = "[骑士贝纳尔] 吞世权杖 400293")]
        KnightBernahlDevourersScepter = 400293,

        [Annotation(Name = "[骑士贝纳尔] 聚兽头盔 400294")]
        KnightBernahlBeastChampionHelm = 400294,

        [Annotation(Name = "[骑士贝纳尔] 格密尔之怒 400295")]
        KnightBernahlGelmirsFury_ = 400295,

        [Annotation(Name = "[流氓] 菈雅的项链 400300")]
        BigBoggartRyasNecklace = 400300,

        [Annotation(Name = "[流氓] 铁球拳套 - 战灰：夸耀咆哮 400309")]
        BigBoggartIronBall0BraggartsRoar = 400309,

        [Annotation(Name = "[流氓] 温床的诅咒 400308")]
        BigBoggartSeedbedCurse = 400308,

        [Annotation(Name = "[贤者格威] 纯净金针 400310")]
        GowryUnalloyedGoldNeedle = 400310,

        [Annotation(Name = "[贤者格威] 瑟利亚镇的秘密 400311")]
        GowrySelliasSecret = 400311,

        [Annotation(Name = "[贤者格威] 群聚信徒的立誓布 400312")]
        GowryFlocksCanvasTalisman = 400312,

        [Annotation(Name = "[米莉森] 义手剑士的传说 400320")]
        MillicentProsthesisWearerHeirloom = 400320,

        [Annotation(Name = "[米莉森] 纯净金针 400321")]
        MillicentUnalloyedGoldNeedle = 400321,

        [Annotation(Name = "[米莉森] 米莉森的义手 400323")]
        MillicentMillicentsProsthesis = 400323,

        [Annotation(Name = "[米莉森] 米凯拉的针 400324")]
        MillicentMiquellasNeedle = 400324,

        [Annotation(Name = "[米莉森] 古龙岩失色锻造石 400325")]
        MillicentSomberAncientDragonSmithingStone = 400325,

        [Annotation(Name = "[“死眠少女”菲雅] 侵蚀短剑 400331")]
        FiaWeatheredDagger = 400331,

        [Annotation(Name = "[“死眠少女”菲雅] 牺牲细枝 400332")]
        FiaSacrificialTwig = 400332,

        [Annotation(Name = "[“死眠少女”菲雅] 透光床帘恩泽 400333")]
        FiaRadiantBaldachinsBlessing = 400333,

        [Annotation(Name = "[“死眠少女”菲雅] 烙印的线索 400334")]
        FiaKnifeprintClue = 400334,

        [Annotation(Name = "[“狩猎死亡”Ｄ] Ｄ的铃珠 400349")]
        DHunterOfTheDeadDsBellBearing = 400349,

        [Annotation(Name = "[死王子宝座] 紧密孪生剑 400348")]
        PrinceOfDeathsThroneInseparableSword = 400348,

        [Annotation(Name = "[魔法师罗杰尔] 罗杰尔的刺剑+8 - 战灰：辉剑圆阵 400358")]
        SorcererRogierRogiersRapier8GlintbladePhalanx = 400358,

        [Annotation(Name = "[魔法师罗杰尔] 黑刀烙印 400357")]
        SorcererRogierBlackKnifeprint = 400357,

        [Annotation(Name = "[魔法师罗杰尔] 罗杰尔的信 400356")]
        SorcererRogierRogiersLetter = 400356,

        [Annotation(Name = "[魔法师罗杰尔] 罗杰尔的铃珠 400359")]
        SorcererRogierRogiersBellBearing = 400359,

        [Annotation(Name = "[魔法师托普斯] 托普斯的铃珠 400360")]
        ThopsThopssBellBearing = 400360,

        [Annotation(Name = "[魔法师托普斯] 学院辉石杖 400361")]
        ThopsAcademyGlintstoneStaff = 400361,

        [Annotation(Name = "[魔法师托普斯] 托普斯的力场 400362")]
        ThopsThopssBarrier = 400362,

        [Annotation(Name = "[圣职人员柯林] 柯林的铃珠 400370")]
        BrotherCorhynCorhynsBellBearing = 400370,

        [Annotation(Name = "[食粪者] 下水道监牢钥匙 400380")]
        DungEaterSewerGaolKey = 400380,

        [Annotation(Name = "[食粪者] 忌讳头盔 400382")]
        DungEaterOmenHelm = 400382,

        [Annotation(Name = "[魔女菈妮] 召魂铃 60110")]
        RanniTheWitchSpiritCallingBell = 60110,

        [Annotation(Name = "[魔女菈妮] 离群野狼的骨灰 400390")]
        RanniTheWitchLoneWolfAshes = 400390,

        [Annotation(Name = "[魔女菈妮] 卡利亚颠倒像 400391")]
        RanniTheWitchCarianInvertedStatue = 400391,

        [Annotation(Name = "[魔女菈妮] 暗月大剑 400393")]
        RanniTheWitchDarkMoonGreatsword = 400393,

        [Annotation(Name = "[魔女菈妮] 娇小菈妮 400394")]
        RanniTheWitchMiniatureRanni = 400394,

        [Annotation(Name = "[魔女菈妮] 猎杀指头刀 400395")]
        RanniTheWitchFingerslayerBlade = 400395,

        [Annotation(Name = "[“魔女猎人”杰廉] 古龙岩锻造石 400400")]
        WitchHunterJerrenAncientDragonSmithingStone = 400400,

        [Annotation(Name = "[“魔女猎人”杰廉] 奇异骑士风帽 400401")]
        WitchHunterJerrenEccentricsHood = 400401,

        [Annotation(Name = "[白金之子勒缇娜] 白金之子勒缇娜 400410")]
        LatennaLatennaTheAlbinauric = 400410,

        [Annotation(Name = "[白金之子勒缇娜] 古龙岩失色锻造石 400411")]
        LatennaSomberAncientDragonSmithingStone = 400411,

        [Annotation(Name = "[白金之子勒缇娜] 苍银风帽 400412")]
        LatennaBlueSilverMailHood = 400412,

        [Annotation(Name = "[战士涅斐丽·露] 众武护符 400420")]
        NepheliLouxArsenalCharm = 400420,

        [Annotation(Name = "[战士涅斐丽·露] 古龙岩锻造石 400422")]
        NepheliLouxAncientDragonSmithingStone = 400422,

        [Annotation(Name = "[“起源魔法师”卢瑟特] 毁灭流星 400430")]
        MasterLusatStarsOfRuin = 400430,

        [Annotation(Name = "[“起源魔法师”亚兹勒] 彗星亚兹勒 400440")]
        MasterAzurCometAzur = 400440,

        [Annotation(Name = "[“血言骑士”尤诺·霍斯劳] 霍斯劳花瓣鞭 400451")]
        JunoHoslowHoslowsPetalWhip = 400451,

        [Annotation(Name = "[“血言骑士”尤诺·霍斯劳] 友好壶 400452")]
        JunoHoslowCompanionJar = 400452,

        [Annotation(Name = "[小壶] 友好壶 400460")]
        JarBairnCompanionJar = 400460,

        [Annotation(Name = "[大壶] 大壶众武护符 400470")]
        TheGreatJarGreatJarsArsenal = 400470,

        [Annotation(Name = "[米莉森 - 击败姐妹们] 腐败翼剑徽章 400480")]
        MillicentKilledSistersRottenWingedSwordInsignia = 400480,

        [Annotation(Name = "[“王骸”恩夏] 王骸头盔 400490")]
        EnshaOfTheRoyalRemainsRoyalRemainsHelm = 400490,

        [Annotation(Name = "[金面具] 金面具的破布 400500")]
        GoldmaskGoldmasksRags = 400500,

        [Annotation(Name = "[“兽爪”玛格纳斯 - 蠕血废墟] 巨星锤 400510")]
        MagnustheBeastClawWrithebloodRuinsGreatStars = 400510,

        [Annotation(Name = "[“流浪商人”咖列] 咖列的铃珠 400049")]
        MerchantKaleKalesBellBearing = 400049,

        [Annotation(Name = "[尸体 - 城主艾德格] 失乡骑士戟+8 - 战灰：回旋击 400069")]
        CorpseEdgarBanishedKnightsHalberd8SpinningStrikes = 400069,

        [Annotation(Name = "[尸体 - 未知] 照明石 400108")]
        CorpseUnknownGlowstone = 400108,

        [Annotation(Name = "[尸体 - 未知] 照明石 400109")]
        CorpseUnknownGlowstone_ = 400109,

        [Annotation(Name = "[尸体 - “战士壶”亚历山大] 战士壶碎片 400175")]
        CorpseIronFistAlexanderWarriorJarShard = 400175,

        [Annotation(Name = "[尸体 - 帕奇] 帕奇的铃珠 400189")]
        CorpsePatchesPatchesBellBearing = 400189,

        [Annotation(Name = "[尸体 - 未知] 照明石 400209")]
        CorpseUnknownGlowstone__ = 400209,

        [Annotation(Name = "[尸体 - 未知] 黄金种子 400220")]
        CorpseUnknownGoldenSeed = 400220,

        [Annotation(Name = "[尸体 - 骑士贝纳尔] 贝纳尔的铃珠 400299")]
        CorpseKnightBernahlBernahlsBellBearing = 400299,

        [Annotation(Name = "[尸体 - “死眠少女”菲雅] 菲雅风帽 400339")]
        CorpseFiaFiasHood = 400339,

        [Annotation(Name = "[尸体 - 食粪者] 灭洛斯剑 400381")]
        CorpseDungEaterSwordOfMilos = 400381,

        [Annotation(Name = "[尸体 - 战士涅斐丽·露] 风暴鹰斧 400421")]
        CorpseNepheliLouxStormhawkAxe = 400421,

        [Annotation(Name = "[尸体 - “起源魔法师”卢瑟特] 卢瑟特辉石头冠 400431")]
        CorpseMasterLusatLusatsGlintstoneCrown = 400431,

        [Annotation(Name = "[尸体 - “起源魔法师”亚兹勒] 亚兹勒辉石头冠 400441")]
        CorpseMasterAzurAzursGlintstoneCrown = 400441,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【１】 400901")]
        CorpseMerchantNomadicMerchantsBellBearing1 = 400901,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【２】 400902")]
        CorpseMerchantNomadicMerchantsBellBearing2 = 400902,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【３】 400903")]
        CorpseMerchantNomadicMerchantsBellBearing3 = 400903,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【４】 400904")]
        CorpseMerchantNomadicMerchantsBellBearing4 = 400904,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【５】 400905")]
        CorpseMerchantNomadicMerchantsBellBearing5 = 400905,

        [Annotation(Name = "[尸体 - 商人] 隐居商人的铃珠【１】 400906")]
        CorpseMerchantIsolatedMerchantsBellBearing1 = 400906,

        [Annotation(Name = "[尸体 - 商人] 隐居商人的铃珠【２】 400907")]
        CorpseMerchantIsolatedMerchantsBellBearing2 = 400907,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【６】 400908")]
        CorpseMerchantNomadicMerchantsBellBearing6 = 400908,

        [Annotation(Name = "[尸体 - 商人] 遁世商人的铃珠【１】 400909")]
        CorpseMerchantHermitMerchantsBellBearing1 = 400909,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【７】 400910")]
        CorpseMerchantNomadicMerchantsBellBearing7 = 400910,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【８】 400911")]
        CorpseMerchantNomadicMerchantsBellBearing8 = 400911,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【９】 400912")]
        CorpseMerchantNomadicMerchantsBellBearing9 = 400912,

        [Annotation(Name = "[尸体 - 商人] 流浪商人的铃珠【１０】 400913")]
        CorpseMerchantNomadicMerchantsBellBearing10 = 400913,

        [Annotation(Name = "[尸体 - 商人] [ERROR]流浪商人的铃珠【１１】 400914")]
        CorpseMerchantNomadicMerchantsBellBearing11 = 400914,

        [Annotation(Name = "[尸体 - 商人] 隐居商人的铃珠【３】 400915")]
        CorpseMerchantIsolatedMerchantsBellBearing3 = 400915,

        [Annotation(Name = "[尸体 - 商人] 遁世商人的铃珠【２】 400916")]
        CorpseMerchantHermitMerchantsBellBearing2 = 400916,

        [Annotation(Name = "[尸体 - 商人] 见弃商人的铃珠 400917")]
        CorpseMerchantAbandonedMerchantsBellBearing = 400917,

        [Annotation(Name = "[尸体 - 商人] 遁世商人的铃珠【３】 400918")]
        CorpseMerchantHermitMerchantsBellBearing3 = 400918,

        [Annotation(Name = "[尸体 - 商人] 受囚商人的铃珠 400919")]
        CorpseMerchantImprisonedMerchantsBellBearing = 400919,

        [Annotation(Name = "[LD - 史东薇尔城] 唤勾指药 10007030")]
        LDStormveilFurlcallingFingerRemedy = 10007030,

        [Annotation(Name = "[LD - 史东薇尔城] 火油脂 10007040")]
        LDStormveilFireGrease = 10007040,

        [Annotation(Name = "[LD - 史东薇尔城] 腌制黄金鸟爪 10007050")]
        LDStormveilGoldPickledFowlFoot = 10007050,

        [Annotation(Name = "[LD - 史东薇尔城] 溃烂血指 10007060")]
        LDStormveilFesteringBloodyFinger = 10007060,

        [Annotation(Name = "[LD - 史东薇尔城] 箭矢 10007080")]
        LDStormveilArrow = 10007080,

        [Annotation(Name = "[LD - 史东薇尔城] 城寨塔盾 10007090")]
        LDStormveilManorTowershield = 10007090,

        [Annotation(Name = "[LD - 史东薇尔城] 侵蚀皮盾 10007100")]
        LDStormveilMarredLeatherShield = 10007100,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【１】 10007110")]
        LDStormveilGoldenRune1 = 10007110,

        [Annotation(Name = "[LD - 史东薇尔城] 弩箭 10007120")]
        LDStormveilBolt = 10007120,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【３】 10007130")]
        LDStormveilSmithingStone3 = 10007130,

        [Annotation(Name = "[LD - 史东薇尔城] 遗迹石 10007140")]
        LDStormveilRuinFragment = 10007140,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007150")]
        LDStormveilSmithingStone2 = 10007150,

        [Annotation(Name = "[LD - 史东薇尔城] 腌制白银鸟爪 10007160")]
        LDStormveilSilverPickledFowlFoot = 10007160,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007170")]
        LDStormveilGoldenRune2 = 10007170,

        [Annotation(Name = "[LD - 史东薇尔城] 钩爪 10007180")]
        LDStormveilHookclaws = 10007180,

        [Annotation(Name = "[LD - 史东薇尔城] 投掷匕首 10007190")]
        LDStormveilThrowingDagger = 10007190,

        [Annotation(Name = "[LD - 史东薇尔城] 托莉娜箭 10007200")]
        LDStormveilStTrinasArrow = 10007200,

        [Annotation(Name = "[LD - 史东薇尔城] 火星蝶 10007210")]
        LDStormveilSmolderingButterfly = 10007210,

        [Annotation(Name = "[LD - 史东薇尔城] 火油脂 10007220")]
        LDStormveilFireGrease_ = 10007220,

        [Annotation(Name = "[LD - 史东薇尔城] 钩爪护符 10007230")]
        LDStormveilClawTalisman = 10007230,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007240")]
        LDStormveilGoldenRune2_ = 10007240,

        [Annotation(Name = "[LD - 史东薇尔城] 亚缇莉亚叶 10007250")]
        LDStormveilArteriaLeaf = 10007250,

        [Annotation(Name = "[LD - 史东薇尔城] 投掷匕首 10007260")]
        LDStormveilThrowingDagger_ = 10007260,

        [Annotation(Name = "[LD - 史东薇尔城] 蘑菇 10007270")]
        LDStormveilMushroom = 10007270,

        [Annotation(Name = "[LD - 史东薇尔城] 附绳火油脂 10007280")]
        LDStormveilDrawstringFireGrease = 10007280,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007290")]
        LDStormveilGoldenRune2__ = 10007290,

        [Annotation(Name = "[LD - 史东薇尔城] 失色锻造石【２】 10007300")]
        LDStormveilSomberSmithingStone2 = 10007300,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007310")]
        LDStormveilSmithingStone2_ = 10007310,

        [Annotation(Name = "[LD - 史东薇尔城] 侵蚀木盾 10007320")]
        LDStormveilMarredWoodenShield = 10007320,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007330")]
        LDStormveilGoldenRune2___ = 10007330,

        [Annotation(Name = "[LD - 史东薇尔城] 高地斧 10007340")]
        LDStormveilHighlandAxe = 10007340,

        [Annotation(Name = "[LD - 史东薇尔城] 廓尔喀弯刀 10007350")]
        LDStormveilKukri = 10007350,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007360")]
        LDStormveilGoldenRune2____ = 10007360,

        [Annotation(Name = "[LD - 史东薇尔城] 石剑钥匙 10007370")]
        LDStormveilStoneswordKey = 10007370,

        [Annotation(Name = "[LD - 史东薇尔城] 勇者肉块 10007380")]
        LDStormveilExaltedFlesh = 10007380,

        [Annotation(Name = "[LD - 史东薇尔城] 野兽肉块 10007390")]
        LDStormveilLumpOfFlesh = 10007390,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【１】 10007400")]
        LDStormveilGoldenRune1_ = 10007400,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007410")]
        LDStormveilSmithingStone2__ = 10007410,

        [Annotation(Name = "[LD - 史东薇尔城] 铁制砥石刀 65610")]
        LDStormveilIronWhetblade = 65610,

        [Annotation(Name = "[LD - 史东薇尔城] 箭矢 10007430")]
        LDStormveilArrow_ = 10007430,

        [Annotation(Name = "[LD - 史东薇尔城] 抗火肝脏干 10007440")]
        LDStormveilFireproofDriedLiver = 10007440,

        [Annotation(Name = "[LD - 史东薇尔城] 蛹群的遗物 10007450")]
        LDStormveilChrysalidsMemento = 10007450,

        [Annotation(Name = "[LD - 史东薇尔城] 暗红风帽 10007452")]
        LDStormveilCrimsonHood = 10007452,

        [Annotation(Name = "[LD - 史东薇尔城] 出血苔药 10007460")]
        LDStormveilStanchingBoluses = 10007460,

        [Annotation(Name = "[LD - 史东薇尔城] 石剑钥匙 10007470")]
        LDStormveilStoneswordKey_ = 10007470,

        [Annotation(Name = "[LD - 史东薇尔城] 流浪战士的制作笔记【１０】 67030")]
        LDStormveilNomadicWarriorsCookbook10 = 67030,

        [Annotation(Name = "[LD - 史东薇尔城] 生锈钥匙 10007500")]
        LDStormveilRustyKey = 10007500,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【１】 10007510")]
        LDStormveilSmithingStone1 = 10007510,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【１】 10007520")]
        LDStormveilGoldenRune1__ = 10007520,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007530")]
        LDStormveilGoldenRune2_____ = 10007530,

        [Annotation(Name = "[LD - 史东薇尔城] 弩炮箭 10007540")]
        LDStormveilBallistaBolt = 10007540,

        [Annotation(Name = "[LD - 史东薇尔城] 钢弩 10007550")]
        LDStormveilArbalest = 10007550,

        [Annotation(Name = "[LD - 史东薇尔城] 居民便衣 10007560")]
        LDStormveilCommonersSimpleGarb = 10007560,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007570")]
        LDStormveilGoldenRune2______ = 10007570,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【５】 10007580")]
        LDStormveilGoldenRune5 = 10007580,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007590")]
        LDStormveilSmithingStone2___ = 10007590,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【４】 10007600")]
        LDStormveilGoldenRune4 = 10007600,

        [Annotation(Name = "[LD - 史东薇尔城] 火箭 10007610")]
        LDStormveilFireArrow = 10007610,

        [Annotation(Name = "[LD - 史东薇尔城] 长矛 10007620")]
        LDStormveilPike = 10007620,

        [Annotation(Name = "[LD - 史东薇尔城] 唤勾指药 10007630")]
        LDStormveilFurlcallingFingerRemedy_ = 10007630,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【１】 10007640")]
        LDStormveilSmithingStone1_ = 10007640,

        [Annotation(Name = "[LD - 史东薇尔城] 火星蝶 10007650")]
        LDStormveilSmolderingButterfly_ = 10007650,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【４】 10007660")]
        LDStormveilGoldenRune4_ = 10007660,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【１】 10007670")]
        LDStormveilGoldenRune1___ = 10007670,

        [Annotation(Name = "[LD - 史东薇尔城] 蘑菇 10007680")]
        LDStormveilMushroom_ = 10007680,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007690")]
        LDStormveilGoldenRune2_______ = 10007690,

        [Annotation(Name = "[LD - 史东薇尔城] 魔力油脂 10007700")]
        LDStormveilMagicGrease = 10007700,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007710")]
        LDStormveilSmithingStone2____ = 10007710,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007720")]
        LDStormveilGoldenRune2________ = 10007720,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金种子 10007730")]
        LDStormveilGoldenSeed = 10007730,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007740")]
        LDStormveilSmithingStone2_____ = 10007740,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【１】 10007750")]
        LDStormveilSmithingStone1__ = 10007750,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【５】 10007760")]
        LDStormveilGoldenRune5_ = 10007760,

        [Annotation(Name = "[LD - 史东薇尔城] 龟裂壶 66010")]
        LDStormveilCrackedPot = 66010,

        [Annotation(Name = "[LD - 史东薇尔城] 龟裂壶 66020")]
        LDStormveilCrackedPot_ = 66020,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【１】 10007780")]
        LDStormveilSmithingStone1___ = 10007780,

        [Annotation(Name = "[LD - 史东薇尔城] 廓尔喀弯刀 10007790")]
        LDStormveilKukri_ = 10007790,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007800")]
        LDStormveilSmithingStone2______ = 10007800,

        [Annotation(Name = "[LD - 史东薇尔城] 野兽肉块 10007810")]
        LDStormveilLumpOfFlesh_ = 10007810,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【１】 10007820")]
        LDStormveilSmithingStone1____ = 10007820,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007830")]
        LDStormveilGoldenRune2_________ = 10007830,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【３】 10007840")]
        LDStormveilSmithingStone3_ = 10007840,

        [Annotation(Name = "[LD - 史东薇尔城] 夏玻利利葡萄 10007850")]
        LDStormveilShabririGrape = 10007850,

        [Annotation(Name = "[LD - 史东薇尔城] 虹彩石 10007860")]
        LDStormveilRainbowStone = 10007860,

        [Annotation(Name = "[LD - 史东薇尔城] 锻造石【２】 10007870")]
        LDStormveilSmithingStone2_______ = 10007870,

        [Annotation(Name = "[LD - 史东薇尔城] 亚缇莉亚叶 10007880")]
        LDStormveilArteriaLeaf_ = 10007880,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金卢恩【２】 10007890")]
        LDStormveilGoldenRune2__________ = 10007890,

        [Annotation(Name = "[LD - 史东薇尔城] 毒花 10007900")]
        LDStormveilPoisonbloom = 10007900,

        [Annotation(Name = "[LD - 史东薇尔城] 火星蝶 10007910")]
        LDStormveilSmolderingButterfly__ = 10007910,

        [Annotation(Name = "[LD - 史东薇尔城] 石剑钥匙 10007920")]
        LDStormveilStoneswordKey__ = 10007920,

        [Annotation(Name = "[LD - 史东薇尔城] 投掷匕首 10007930")]
        LDStormveilThrowingDagger__ = 10007930,

        [Annotation(Name = "[LD - 史东薇尔城] 死王子的脓疮 10007940")]
        LDStormveilPrinceOfDeathsPustule = 10007940,

        [Annotation(Name = "[LD - 史东薇尔城] 廓尔喀弯刀 10007950")]
        LDStormveilKukri__ = 10007950,

        [Annotation(Name = "[LD - 史东薇尔城] 腌制龟颈肉 10007960")]
        LDStormveilPickledTurtleNeck = 10007960,

        [Annotation(Name = "[LD - 史东薇尔城] 狩猎神祇圣印记 10007965")]
        LDStormveilGodslayersSeal = 10007965,

        [Annotation(Name = "[LD - 史东薇尔城] 拟态面纱 10007970")]
        LDStormveilMimicsVeil = 10007970,

        [Annotation(Name = "[LD - 史东薇尔城] 曲剑护符 10007975")]
        LDStormveilCurvedSwordTalisman = 10007975,

        [Annotation(Name = "[LD - 史东薇尔城] 失色锻造石【２】 10007980")]
        LDStormveilSomberSmithingStone2_ = 10007980,

        [Annotation(Name = "[LD - 史东薇尔城] 神皮祷告书 10007990")]
        LDStormveilGodskinPrayerbook = 10007990,

        [Annotation(Name = "[LD - 史东薇尔城] 失色锻造石【１】 10007085")]
        LDStormveilSomberSmithingStone1 = 10007085,

        [Annotation(Name = "[LD - 史东薇尔城] 黄金种子 10007195")]
        LDStormveilGoldenSeed_ = 10007195,

        [Annotation(Name = "[LD - 史东薇尔城] [祷告] 熔炉百相之角 10007295")]
        LDStormveilIncantationAspectsOfTheCrucibleHorns = 10007295,

        [Annotation(Name = "[LD - 史东薇尔城] 木制大盾 10007005")]
        LDStormveilWoodenGreatshield = 10007005,

        [Annotation(Name = "[LD - 史东薇尔城] 鹰纹木盾 10007015")]
        LDStormveilHawkCrestWoodenShield = 10007015,

        [Annotation(Name = "[LD - 史东薇尔城] 慈悲短剑 10007025")]
        LDStormveilMisericorde = 10007025,

        [Annotation(Name = "[LD - 史东薇尔城] 砌石槌 10007035")]
        LDStormveilBrickHammer = 10007035,

        [Annotation(Name = "[LD - 候王礼拜堂] 褪色者老指 60210")]
        LDChapelOfAnticipationTarnishedsWizenedFinger = 60210,

        [Annotation(Name = "[LD - 候王礼拜堂] 风暴鹰古王 10017010")]
        LDChapelOfAnticipationTheStormhawkKing = 10017010,

        [Annotation(Name = "[LD - 候王礼拜堂] 风暴鹰汀涅 10017900")]
        LDChapelOfAnticipationStormhawkDeenh = 10017900,

        [Annotation(Name = "[LD - 王城罗德尔] 魔力油脂 11007000")]
        LDLeyndellMagicGrease = 11007000,

        [Annotation(Name = "[LD - 王城罗德尔] 唤勾指药 11007010")]
        LDLeyndellFurlcallingFingerRemedy = 11007010,

        [Annotation(Name = "[LD - 王城罗德尔] 粗大兽骨 11007020")]
        LDLeyndellHeftyBeastBone = 11007020,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【４】 11007030")]
        LDLeyndellSmithingStone4 = 11007030,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【７】 11007040")]
        LDLeyndellGoldenRune7 = 11007040,

        [Annotation(Name = "[LD - 王城罗德尔] 洞窟苔藓 11007050")]
        LDLeyndellCaveMoss = 11007050,

        [Annotation(Name = "[LD - 王城罗德尔] 腐败苔药 11007060")]
        LDLeyndellPreservingBoluses = 11007060,

        [Annotation(Name = "[LD - 王城罗德尔] 绳索 11007070")]
        LDLeyndellString = 11007070,

        [Annotation(Name = "[LD - 王城罗德尔] 上流阶级长袍 11007080")]
        LDLeyndellUpperClassRobe = 11007080,

        [Annotation(Name = "[LD - 王城罗德尔] 米兰达花粉 11007090")]
        LDLeyndellMirandaPowder = 11007090,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007100")]
        LDLeyndellSmithingStone6 = 11007100,

        [Annotation(Name = "[LD - 王城罗德尔] 温热石 11007110")]
        LDLeyndellWarmingStone = 11007110,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１０】 11007120")]
        LDLeyndellGoldenRune10 = 11007120,

        [Annotation(Name = "[LD - 王城罗德尔] 调香瓶 66710")]
        LDLeyndellPerfumeBottle = 66710,

        [Annotation(Name = "[LD - 王城罗德尔] 扇形暗器 11007140")]
        LDLeyndellFanDaggers = 11007140,

        [Annotation(Name = "[LD - 王城罗德尔] 金色萤火虫 3x 11007150")]
        LDLeyndellMarikasGoldenSiigl = 11007150,

        [Annotation(Name = "[LD - 王城罗德尔] 圣油脂 11007160")]
        LDLeyndellHolyGrease = 11007160,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【８】 11007170")]
        LDLeyndellGoldenRune8 = 11007170,

        [Annotation(Name = "[LD - 王城罗德尔] 古牙 11007180")]
        LDLeyndellOldFang = 11007180,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【４】 11007190")]
        LDLeyndellSmithingStone4_ = 11007190,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【８】 11007200")]
        LDLeyndellGoldenRune8_ = 11007200,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【５】 11007210")]
        LDLeyndellSomberSmithingStone5 = 11007210,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【８】 11007220")]
        LDLeyndellGoldenRune8__ = 11007220,

        [Annotation(Name = "[LD - 王城罗德尔] 君王军弩箭 11007230")]
        LDLeyndellLordswornsBolt = 11007230,

        [Annotation(Name = "[LD - 王城罗德尔] 褪色金轮草 11007240")]
        LDLeyndellTarnishedGoldenSunflower = 11007240,

        [Annotation(Name = "[LD - 王城罗德尔] 石剑钥匙 11007250")]
        LDLeyndellStoneswordKey = 11007250,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１０】 11007260")]
        LDLeyndellGoldenRune10_ = 11007260,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【８】 11007270")]
        LDLeyndellGoldenRune8___ = 11007270,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007280")]
        LDLeyndellGoldenRune9 = 11007280,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007290")]
        LDLeyndellSmithingStone6_ = 11007290,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007300")]
        LDLeyndellGoldenRune9_ = 11007300,

        [Annotation(Name = "[LD - 王城罗德尔] 亚缇莉亚叶 11007310")]
        LDLeyndellArteriaLeaf = 11007310,

        [Annotation(Name = "[LD - 王城罗德尔] 小恶魔头罩（长生者） 11007320")]
        LDLeyndellImpHeadCorpse = 11007320,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007330")]
        LDLeyndellGoldenRune9__ = 11007330,

        [Annotation(Name = "[LD - 王城罗德尔] 温床的诅咒 11007340")]
        LDLeyndellSeedbedCurse = 11007340,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007350")]
        LDLeyndellSmithingStone6__ = 11007350,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007360")]
        LDLeyndellGoldenRune9___ = 11007360,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【５】 11007370")]
        LDLeyndellSmithingStone5 = 11007370,

        [Annotation(Name = "[LD - 王城罗德尔] 石剑钥匙 11007380")]
        LDLeyndellStoneswordKey_ = 11007380,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１２】 11007390")]
        LDLeyndellGoldenRune12 = 11007390,

        [Annotation(Name = "[LD - 王城罗德尔] 野兽血液 11007400")]
        LDLeyndellBeastBlood = 11007400,

        [Annotation(Name = "[LD - 王城罗德尔] 蜕生蝶 11007410")]
        LDLeyndellNascentButterfly = 11007410,

        [Annotation(Name = "[LD - 王城罗德尔] 勇者肉块 11007420")]
        LDLeyndellExaltedFlesh = 11007420,

        [Annotation(Name = "[LD - 王城罗德尔] 催眠油脂 11007430")]
        LDLeyndellSoporificGrease = 11007430,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【６】 11007440")]
        LDLeyndellSomberSmithingStone6 = 11007440,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007450")]
        LDLeyndellGoldenRune9____ = 11007450,

        [Annotation(Name = "[LD - 王城罗德尔] 抗雷肝脏干 11007460")]
        LDLeyndellLightningproofDriedLiver = 11007460,

        [Annotation(Name = "[LD - 王城罗德尔] 调香瓶 66720")]
        LDLeyndellPerfumeBottle_ = 66720,

        [Annotation(Name = "[LD - 王城罗德尔] 碎石 11007480")]
        LDLeyndellGravelStone = 11007480,

        [Annotation(Name = "[LD - 王城罗德尔] 石剑钥匙 11007490")]
        LDLeyndellStoneswordKey__ = 11007490,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007500")]
        LDLeyndellGoldenRune9_____ = 11007500,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【４】 11007510")]
        LDLeyndellSmithingStone4__ = 11007510,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金箭 11007520")]
        LDLeyndellGoldenArrow = 11007520,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007530")]
        LDLeyndellSmithingStone6___ = 11007530,

        [Annotation(Name = "[LD - 王城罗德尔] 发狂苔药 11007540")]
        LDLeyndellClarifyingBoluses = 11007540,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【８】 11007550")]
        LDLeyndellGoldenRune8____ = 11007550,

        [Annotation(Name = "[LD - 王城罗德尔] 龟裂壶 66130")]
        LDLeyndellCrackedPot = 66130,

        [Annotation(Name = "[LD - 王城罗德尔] 失力战灰 11007570")]
        LDLeyndellLostAshesOfWar = 11007570,

        [Annotation(Name = "[LD - 王城罗德尔] 卢恩弯弧 11007580")]
        LDLeyndellRuneArc = 11007580,

        [Annotation(Name = "[LD - 王城罗德尔] 黄铜短刀 11007590")]
        LDLeyndellErdsteelDagger = 11007590,

        [Annotation(Name = "[LD - 王城罗德尔] 兽骨毒飞刀 11007600")]
        LDLeyndellPoisonboneDart = 11007600,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【６】 11007610")]
        LDLeyndellSomberSmithingStone6_ = 11007610,

        [Annotation(Name = "[LD - 王城罗德尔] 白金凝血 11007620")]
        LDLeyndellAlbinauricBloodclot = 11007620,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【５】 11007630")]
        LDLeyndellSmithingStone5_ = 11007630,

        [Annotation(Name = "[LD - 王城罗德尔] 腌制龟颈肉 11007640")]
        LDLeyndellPickledTurtleNeck = 11007640,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007650")]
        LDLeyndellSmithingStone6____ = 11007650,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007660")]
        LDLeyndellGoldenRune9______ = 11007660,

        [Annotation(Name = "[LD - 王城罗德尔] 黑弓 11007670")]
        LDLeyndellBlackBow = 11007670,

        [Annotation(Name = "[LD - 王城罗德尔] 伤龙油脂 11007680")]
        LDLeyndellDragonwoundGrease = 11007680,

        [Annotation(Name = "[LD - 王城罗德尔] 双指祷告书 11007690")]
        LDLeyndellTwoFingersPrayerbook = 11007690,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【５】 11007700")]
        LDLeyndellSmithingStone5__ = 11007700,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007710")]
        LDLeyndellGoldenRune9_______ = 11007710,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007720")]
        LDLeyndellSmithingStone6_____ = 11007720,

        [Annotation(Name = "[LD - 王城罗德尔] 抗圣肝脏干 11007730")]
        LDLeyndellHolyproofDriedLiver = 11007730,

        [Annotation(Name = "[LD - 王城罗德尔] 唤勾指药 11007740")]
        LDLeyndellFurlcallingFingerRemedy_ = 11007740,

        [Annotation(Name = "[LD - 王城罗德尔] 碎石 11007750")]
        LDLeyndellGravelStone_ = 11007750,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【５】 11007760")]
        LDLeyndellSmithingStone5___ = 11007760,

        [Annotation(Name = "[LD - 王城罗德尔] 古牙 11007770")]
        LDLeyndellOldFang_ = 11007770,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007780")]
        LDLeyndellSmithingStone6______ = 11007780,

        [Annotation(Name = "[LD - 王城罗德尔] 蜕生蝶 11007790")]
        LDLeyndellNascentButterfly_ = 11007790,

        [Annotation(Name = "[LD - 王城罗德尔] 石剑钥匙 11007800")]
        LDLeyndellStoneswordKey___ = 11007800,

        [Annotation(Name = "[LD - 王城罗德尔] 扇形暗器 11007810")]
        LDLeyndellFanDaggers_ = 11007810,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007820")]
        LDLeyndellSmithingStone6_______ = 11007820,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【９】 11007830")]
        LDLeyndellGoldenRune9________ = 11007830,

        [Annotation(Name = "[LD - 王城罗德尔] 碎石 11007840")]
        LDLeyndellGravelStone__ = 11007840,

        [Annotation(Name = "[LD - 王城罗德尔] 温床的诅咒 11007850")]
        LDLeyndellSeedbedCurse_ = 11007850,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【５】 11007860")]
        LDLeyndellSmithingStone5____ = 11007860,

        [Annotation(Name = "[LD - 王城罗德尔] 唤勾指药 11007870")]
        LDLeyndellFurlcallingFingerRemedy__ = 11007870,

        [Annotation(Name = "[LD - 王城罗德尔] 晨星拳套 11007880")]
        LDLeyndellStarFist = 11007880,

        [Annotation(Name = "[LD - 王城罗德尔] 圣油脂 11007890")]
        LDLeyndellHolyGrease_ = 11007890,

        [Annotation(Name = "[LD - 王城罗德尔] 锻造石【６】 11007900")]
        LDLeyndellSmithingStone6________ = 11007900,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金律法原本 11007910")]
        LDLeyndellGoldenOrderPrincipia = 11007910,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【５】 11007920")]
        LDLeyndellSomberSmithingStone5_ = 11007920,

        [Annotation(Name = "[LD - 王城罗德尔] 圣油脂 11007930")]
        LDLeyndellHolyGrease__ = 11007930,

        [Annotation(Name = "[LD - 王城罗德尔] 圣油脂 11007940")]
        LDLeyndellHolyGrease___ = 11007940,

        [Annotation(Name = "[LD - 王城罗德尔] 卢恩弯弧 11007950")]
        LDLeyndellRuneArc_ = 11007950,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金树圣印记 11007960")]
        LDLeyndellErdtreeSeal = 11007960,

        [Annotation(Name = "[LD - 王城罗德尔] 秘文剑 11007970")]
        LDLeyndellCodedSword = 11007970,

        [Annotation(Name = "[LD - 王城罗德尔] 石剑钥匙 11007980")]
        LDLeyndellStoneswordKey____ = 11007980,

        [Annotation(Name = "[LD - 王城罗德尔] 战鬼头盔 11007985")]
        LDLeyndellRagingWolfHelm = 11007985,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金种子 11007990")]
        LDLeyndellGoldenSeed = 11007990,

        [Annotation(Name = "[LD - 王城罗德尔] [祷告] 黄金树恩惠 11007991")]
        LDLeyndellIncantationBlessingOfTheErdtree = 11007991,

        [Annotation(Name = "[LD - 王城罗德尔] 神圣砥石刀 65660")]
        LDLeyndellSanctifiedWhetblade = 65660,

        [Annotation(Name = "[LD - 王城罗德尔] 恩惠露滴护符 11007994")]
        LDLeyndellBlessedDewTalisman = 11007994,

        [Annotation(Name = "[LD - 王城罗德尔] 献斗盾护符 11007996")]
        LDLeyndellRitualShieldTalisman = 11007996,

        [Annotation(Name = "[LD - 王城罗德尔] 古兰桑克斯的雷电 11007997")]
        LDLeyndellBoltOfGransax = 11007997,

        [Annotation(Name = "[LD - 王城罗德尔] 石像鬼戟 11007987")]
        LDLeyndellGargoylesHalberd = 11007987,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金种子 11007993")]
        LDLeyndellGoldenSeed_ = 11007993,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【７】 11007995")]
        LDLeyndellSomberSmithingStone7 = 11007995,

        [Annotation(Name = "[LD - 王城罗德尔] 王之卢恩 11007998")]
        LDLeyndellLordsRune = 11007998,

        [Annotation(Name = "[LD - 王城罗德尔] 阿尔佩利希尖帽 11007005")]
        LDLeyndellAlberichsPointedHat = 11007005,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金树弓 11007015")]
        LDLeyndellErdtreeBow = 11007015,

        [Annotation(Name = "[LD - 王城罗德尔] 星星泪滴 11007025")]
        LDLeyndellCelestialDew = 11007025,

        [Annotation(Name = "[LD - 王城罗德尔] 死眠连身裙 11007035")]
        LDLeyndellDeathbedDress = 11007035,

        [Annotation(Name = "[LD - 王城罗德尔] 莱恩尼尔头盔 11007045")]
        LDLeyndellLionelsHelm = 11007045,

        [Annotation(Name = "[LD - 王城罗德尔] 石槌 11007055")]
        LDLeyndellHammer = 11007055,

        [Annotation(Name = "[LD - 王城罗德尔] 卢恩弯弧 11007065")]
        LDLeyndellRuneArc__ = 11007065,

        [Annotation(Name = "[LD - 王城罗德尔] 英雄卢恩【１】 11007075")]
        LDLeyndellHerosRune1 = 11007075,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１２】 11007085")]
        LDLeyndellGoldenRune12_ = 11007085,

        [Annotation(Name = "[LD - 王城罗德尔] 罪人风帽 11007095")]
        LDLeyndellGuiltyHood = 11007095,

        [Annotation(Name = "[LD - 王城罗德尔] 风暴鹰斧 11007105")]
        LDLeyndellStormhawkAxe = 11007105,

        [Annotation(Name = "[LD - 王城罗德尔] 手杖剑 11007115")]
        LDLeyndellCaneSword = 11007115,

        [Annotation(Name = "[LD - 王城罗德尔] 黑键木桩 11007125")]
        LDLeyndellBlackKeyBolt = 11007125,

        [Annotation(Name = "[LD - 王城罗德尔] 碎石 11007135")]
        LDLeyndellGravelStone___ = 11007135,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【６】 11007145")]
        LDLeyndellSomberSmithingStone6__ = 11007145,

        [Annotation(Name = "[LD - 王城罗德尔] 英雄卢恩【５】 11007155")]
        LDLeyndellHerosRune5 = 11007155,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１１】 11007165")]
        LDLeyndellGoldenRune11 = 11007165,

        [Annotation(Name = "[LD - 王城罗德尔] 英雄卢恩【２】 11007175")]
        LDLeyndellHerosRune2 = 11007175,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【６】 11007185")]
        LDLeyndellSomberSmithingStone6___ = 11007185,

        [Annotation(Name = "[LD - 王城罗德尔] 失色锻造石【６】 11007195")]
        LDLeyndellSomberSmithingStone6____ = 11007195,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１３】 11007205")]
        LDLeyndellGoldenRune13 = 11007205,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１０】 11007215")]
        LDLeyndellGoldenRune10__ = 11007215,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１２】 11007225")]
        LDLeyndellGoldenRune12__ = 11007225,

        [Annotation(Name = "[LD - 王城罗德尔] 抗雷肝脏干 11007235")]
        LDLeyndellLightningproofDriedLiver_ = 11007235,

        [Annotation(Name = "[LD - 王城罗德尔] 黄金卢恩【１１】 11007245")]
        LDLeyndellGoldenRune11_ = 11007245,

        [Annotation(Name = "[LD - 灰城罗德尔] 黄金树恢复 11057000")]
        LDAshenLeyndellErdtreeHeal = 11057000,

        [Annotation(Name = "[LD - 灰城罗德尔] 古龙岩失色锻造石 11057010")]
        LDAshenLeyndellSomberAncientDragonSmithingStone = 11057010,

        [Annotation(Name = "[LD - 灰城罗德尔] 褪色金轮草 11057020")]
        LDAshenLeyndellTarnishedGoldenSunflower = 11057020,

        [Annotation(Name = "[LD - 灰城罗德尔] 卢恩弯弧 11057030")]
        LDAshenLeyndellRuneArc = 11057030,

        [Annotation(Name = "[LD - 灰城罗德尔] 金轮草 11057040")]
        LDAshenLeyndellGoldenSunflower = 11057040,

        [Annotation(Name = "[LD - 灰城罗德尔] 英雄卢恩【４】 11057050")]
        LDAshenLeyndellHerosRune4 = 11057050,

        [Annotation(Name = "[LD - 灰城罗德尔] 黄金树的恩惠＋２ 11057100")]
        LDAshenLeyndellErdtreesFavor2 = 11057100,

        [Annotation(Name = "[LD - 圆桌厅堂] 秘文帕塔剑 11107000")]
        LDRoundtableHoldCipherPata = 11107000,

        [Annotation(Name = "[LD - 圆桌厅堂] 刺客祷告书 11107700")]
        LDRoundtableHoldAssassinsPrayerbook = 11107700,

        [Annotation(Name = "[LD - 圆桌厅堂] 克雷普的黑键 11107710")]
        LDRoundtableHoldCrepussBlackKeyCrossbow = 11107710,

        [Annotation(Name = "[LD - 圆桌厅堂] 嘲弄者舌头 60300")]
        LDRoundtableHoldTauntersTongue = 60300,

        [Annotation(Name = "[LD - 圆桌厅堂] 攀附手骨 11107900")]
        LDRoundtableHoldClingingBone = 11107900,

        [Annotation(Name = "[LD - 腐败湖] 地图碎片：安瑟尔河 62060")]
        LDAinselLakeOfRotMapAinsel = 62060,

        [Annotation(Name = "[LD - 腐败湖] 地图碎片：腐败湖 62061")]
        LDAinselLakeOfRotMapLakeOfRot = 62061,

        [Annotation(Name = "[LD - 腐败湖] 流浪战士的制作笔记【２２】 67890")]
        LDAinselLakeOfRotNomadicWarriorsCookbook22 = 67890,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【８】 12017030")]
        LDAinselLakeOfRotSomberSmithingStone8 = 12017030,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１】 12017040")]
        LDAinselLakeOfRotGoldenRune1 = 12017040,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【２】 12017050")]
        LDAinselLakeOfRotGoldenRune2 = 12017050,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【１】 12017060")]
        LDAinselLakeOfRotSmithingStone1 = 12017060,

        [Annotation(Name = "[LD - 腐败湖] 魔力油脂 12017070")]
        LDAinselLakeOfRotMagicGrease = 12017070,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【３】 12017080")]
        LDAinselLakeOfRotGoldenRune3 = 12017080,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【９】 12017090")]
        LDAinselLakeOfRotSomberSmithingStone9 = 12017090,

        [Annotation(Name = "[LD - 腐败湖] 黄金种子 12017100")]
        LDAinselLakeOfRotGoldenSeed = 12017100,

        [Annotation(Name = "[LD - 腐败湖] 腐败油脂 12017110")]
        LDAinselLakeOfRotRotGrease = 12017110,

        [Annotation(Name = "[LD - 腐败湖] 黑键木桩 12017120")]
        LDAinselLakeOfRotBlackKeyBolt = 12017120,

        [Annotation(Name = "[LD - 腐败湖] 温热石 12017130")]
        LDAinselLakeOfRotWarmingStone = 12017130,

        [Annotation(Name = "[LD - 腐败湖] 抗雷肝脏干 12017140")]
        LDAinselLakeOfRotLightningproofDriedLiver = 12017140,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【３】 12017150")]
        LDAinselLakeOfRotSmithingStone3 = 12017150,

        [Annotation(Name = "[LD - 腐败湖] 碎片生音箭（附箭羽） 12017160")]
        LDAinselLakeOfRotShattershardArrowFletched = 12017160,

        [Annotation(Name = "[LD - 腐败湖] 拟态赐福 12017170")]
        LDAinselLakeOfRotGraceMimic = 12017170,

        [Annotation(Name = "[LD - 腐败湖] 免疫角饰品 12017180")]
        LDAinselLakeOfRotImmunizingHornCharm = 12017180,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【３】 12017190")]
        LDAinselLakeOfRotSmithingStone3_ = 12017190,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１】 12017200")]
        LDAinselLakeOfRotGoldenRune1_ = 12017200,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【３】 12017210")]
        LDAinselLakeOfRotSmithingStone3__ = 12017210,

        [Annotation(Name = "[LD - 腐败湖] 投掷匕首 12017220")]
        LDAinselLakeOfRotThrowingDagger = 12017220,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【３】 12017230")]
        LDAinselLakeOfRotSmithingStone3___ = 12017230,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【２】 12017240")]
        LDAinselLakeOfRotGoldenRune2_ = 12017240,

        [Annotation(Name = "[LD - 腐败湖] 坚盾油脂 12017250")]
        LDAinselLakeOfRotShieldGrease = 12017250,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【３】 12017260")]
        LDAinselLakeOfRotSmithingStone3____ = 12017260,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【４】 12017270")]
        LDAinselLakeOfRotSmithingStone4 = 12017270,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【２】 12017280")]
        LDAinselLakeOfRotSmithingStone2 = 12017280,

        [Annotation(Name = "[LD - 腐败湖] 蚁酸石 12017290")]
        LDAinselLakeOfRotFormicRock = 12017290,

        [Annotation(Name = "[LD - 腐败湖] 结晶飞刀 12017300")]
        LDAinselLakeOfRotCrystalDart = 12017300,

        [Annotation(Name = "[LD - 腐败湖] 肥皂 12017310")]
        LDAinselLakeOfRotSoap = 12017310,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【３】 12017320")]
        LDAinselLakeOfRotSomberSmithingStone3 = 12017320,

        [Annotation(Name = "[LD - 腐败湖] 稠液蘑菇 12017330")]
        LDAinselLakeOfRotMeltedMushroom = 12017330,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【３】 12017340")]
        LDAinselLakeOfRotGoldenRune3_ = 12017340,

        [Annotation(Name = "[LD - 腐败湖] 星星泪滴 12017350")]
        LDAinselLakeOfRotCelestialDew = 12017350,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【３】 12017360")]
        LDAinselLakeOfRotGoldenRune3__ = 12017360,

        [Annotation(Name = "[LD - 腐败湖] 艾奥尼亚蝶 12017370")]
        LDAinselLakeOfRotAeonianButterfly = 12017370,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【７】 12017380")]
        LDAinselLakeOfRotSomberSmithingStone7 = 12017380,

        [Annotation(Name = "[LD - 腐败湖] 银色萤火虫 12017390")]
        LDAinselLakeOfRotSilverFirefly = 12017390,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【３】 12017400")]
        LDAinselLakeOfRotGoldenRune3___ = 12017400,

        [Annotation(Name = "[LD - 腐败湖] 魔力油脂 12017410")]
        LDAinselLakeOfRotMagicGrease_ = 12017410,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【３】 12017420")]
        LDAinselLakeOfRotGoldenRune3____ = 12017420,

        [Annotation(Name = "[LD - 腐败湖] 唤勾指药 12017430")]
        LDAinselLakeOfRotFurlcallingFingerRemedy = 12017430,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【１】 12017440")]
        LDAinselLakeOfRotSmithingStone1_ = 12017440,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【９】 12017450")]
        LDAinselLakeOfRotGoldenRune9 = 12017450,

        [Annotation(Name = "[LD - 腐败湖] 蘑菇王冠 12017460")]
        LDAinselLakeOfRotMushroomCrown = 12017460,

        [Annotation(Name = "[LD - 腐败湖] 腐败苔药 12017470")]
        LDAinselLakeOfRotPreservingBoluses = 12017470,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【７】 12017480")]
        LDAinselLakeOfRotGoldenRune7 = 12017480,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017490")]
        LDAinselLakeOfRotGoldenRune10 = 12017490,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【７】 12017500")]
        LDAinselLakeOfRotGoldenRune7_ = 12017500,

        [Annotation(Name = "[LD - 腐败湖] 人骨碎片 12017510")]
        LDAinselLakeOfRotHumanBoneShard = 12017510,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【６】 12017520")]
        LDAinselLakeOfRotSomberSmithingStone6 = 12017520,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【４】 12017530")]
        LDAinselLakeOfRotSmithingStone4_ = 12017530,

        [Annotation(Name = "[LD - 腐败湖] 催眠苔药 12017540")]
        LDAinselLakeOfRotStimulatingBoluses = 12017540,

        [Annotation(Name = "[LD - 腐败湖] 坚盾油脂 12017550")]
        LDAinselLakeOfRotShieldGrease_ = 12017550,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017560")]
        LDAinselLakeOfRotGoldenRune10_ = 12017560,

        [Annotation(Name = "[LD - 腐败湖] 艾丝缇薄翼 12017570")]
        LDAinselLakeOfRotWingOfAstel = 12017570,

        [Annotation(Name = "[LD - 腐败湖] 石剑钥匙 12017580")]
        LDAinselLakeOfRotStoneswordKey = 12017580,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【７】 12017590")]
        LDAinselLakeOfRotGoldenRune7__ = 12017590,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017600")]
        LDAinselLakeOfRotGoldenRune10__ = 12017600,

        [Annotation(Name = "[LD - 腐败湖] 扇形暗器 12017610")]
        LDAinselLakeOfRotFanDaggers = 12017610,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【６】 12017620")]
        LDAinselLakeOfRotSmithingStone6 = 12017620,

        [Annotation(Name = "[LD - 腐败湖] 操弓士兵的骨灰 12017630")]
        LDAinselLakeOfRotArcherAshes = 12017630,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017640")]
        LDAinselLakeOfRotGoldenRune10___ = 12017640,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017650")]
        LDAinselLakeOfRotGoldenRune10____ = 12017650,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017660")]
        LDAinselLakeOfRotGoldenRune10_____ = 12017660,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【６】 12017670")]
        LDAinselLakeOfRotSmithingStone6_ = 12017670,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017680")]
        LDAinselLakeOfRotGoldenRune10______ = 12017680,

        [Annotation(Name = "[LD - 腐败湖] 大朵灵依墓地铃兰 12017690")]
        LDAinselLakeOfRotGreatGhostGlovewort = 12017690,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【７】 12017700")]
        LDAinselLakeOfRotSomberSmithingStone7_ = 12017700,

        [Annotation(Name = "[LD - 腐败湖] 泥人的骨灰 12017710")]
        LDAinselLakeOfRotClaymanAshes = 12017710,

        [Annotation(Name = "[LD - 腐败湖] 石剑钥匙 12017720")]
        LDAinselLakeOfRotStoneswordKey_ = 12017720,

        [Annotation(Name = "[LD - 腐败湖] 魔力油脂 12017730")]
        LDAinselLakeOfRotMagicGrease__ = 12017730,

        [Annotation(Name = "[LD - 腐败湖] 附绳圣油脂 12017740")]
        LDAinselLakeOfRotDrawstringHolyGrease = 12017740,

        [Annotation(Name = "[LD - 腐败湖] 银色泪滴空壳 12017750")]
        LDAinselLakeOfRotSilverTearHusk = 12017750,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【６】 12017760")]
        LDAinselLakeOfRotSmithingStone6__ = 12017760,

        [Annotation(Name = "[LD - 腐败湖] 星星泪滴 12017770")]
        LDAinselLakeOfRotCelestialDew_ = 12017770,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【７】 12017780")]
        LDAinselLakeOfRotSomberSmithingStone7__ = 12017780,

        [Annotation(Name = "[LD - 腐败湖] 星星泪滴 12017790")]
        LDAinselLakeOfRotCelestialDew__ = 12017790,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【４】 12017800")]
        LDAinselLakeOfRotSmithingStone4__ = 12017800,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【５】 12017810")]
        LDAinselLakeOfRotSmithingStone5 = 12017810,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017820")]
        LDAinselLakeOfRotGoldenRune10_______ = 12017820,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【５】 12017830")]
        LDAinselLakeOfRotSmithingStone5_ = 12017830,

        [Annotation(Name = "[LD - 腐败湖] 扇形暗器 12017840")]
        LDAinselLakeOfRotFanDaggers_ = 12017840,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017850")]
        LDAinselLakeOfRotGoldenRune10________ = 12017850,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【７】 12017860")]
        LDAinselLakeOfRotSmithingStone7 = 12017860,

        [Annotation(Name = "[LD - 腐败湖] 锻造石【６】 12017870")]
        LDAinselLakeOfRotSmithingStone6___ = 12017870,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【８】 12017880")]
        LDAinselLakeOfRotSomberSmithingStone8_ = 12017880,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【７】 12017890")]
        LDAinselLakeOfRotSomberSmithingStone7___ = 12017890,

        [Annotation(Name = "[LD - 腐败湖] 艾丝缇薄翼 12017900")]
        LDAinselLakeOfRotWingOfAstel_ = 12017900,

        [Annotation(Name = "[LD - 腐败湖] 大朵灵依墓地铃兰 12017910")]
        LDAinselLakeOfRotGreatGhostGlovewort_ = 12017910,

        [Annotation(Name = "[LD - 腐败湖] 蝎尾针 12017920")]
        LDAinselLakeOfRotScorpionsStinger = 12017920,

        [Annotation(Name = "[LD - 腐败湖] 火焰长剑 12017930")]
        LDAinselLakeOfRotFireLongsword = 12017930,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【７】 12017940")]
        LDAinselLakeOfRotSomberSmithingStone7____ = 12017940,

        [Annotation(Name = "[LD - 腐败湖] 灵依墓地铃兰【９】 12017950")]
        LDAinselLakeOfRotGhostGlovewort9 = 12017950,

        [Annotation(Name = "[LD - 腐败湖] 诺克史黛拉之月 12017960")]
        LDAinselLakeOfRotMoonOfNokstella = 12017960,

        [Annotation(Name = "[LD - 腐败湖] 蚂蚁头盾 12017970")]
        LDAinselLakeOfRotAntsSkullPlate = 12017970,

        [Annotation(Name = "[LD - 腐败湖] 灵依摘采工的铃珠【２】 12017980")]
        LDAinselLakeOfRotGhostGlovewortPickersBellBearing2 = 12017980,

        [Annotation(Name = "[LD - 腐败湖] 黑夜女巫与剑士的傀儡 12017990")]
        LDAinselLakeOfRotNightmaidenSwordstressPuppets = 12017990,

        [Annotation(Name = "[LD - 腐败湖] 失色锻造石【７】 12017995")]
        LDAinselLakeOfRotSomberSmithingStone7_____ = 12017995,

        [Annotation(Name = "[LD - 腐败湖] 黄金种子 12017997")]
        LDAinselLakeOfRotGoldenSeed_ = 12017997,

        [Annotation(Name = "[LD - 腐败湖] 黄金卢恩【１０】 12017105")]
        LDAinselLakeOfRotGoldenRune10_________ = 12017105,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 斑斓项链 12027000")]
        LDNokronSiofraMottledNecklace = 12027000,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 漆黑砥石刀 65720")]
        LDNokronSiofraBlackWhetblade = 65720,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 传道士的制作笔记【５】 67630")]
        LDNokronSiofraMissionarysCookbook5 = 67630,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 亚缇莉亚叶 12027030")]
        LDNokronSiofraArteriaLeaf = 12027030,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金种子 12027040")]
        LDNokronSiofraGoldenSeed = 12027040,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 玛莉卡的烙印 12027050")]
        LDNokronSiofraMarikasScarseal = 12027050,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 地图碎片：希芙拉河 62063")]
        LDNokronSiofraMapSiofraRiver = 62063,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 雷电混种大剑 12027070")]
        LDNokronSiofraLightningBastardSword = 12027070,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 猎杀指头刀 12027080")]
        LDNokronSiofraFingerslayerBlade = 12027080,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 稚幼祖灵头部 12027090")]
        LDNokronSiofraAncestralInfantsHead = 12027090,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 蟹卵 12027100")]
        LDNokronSiofraCrabEggs = 12027100,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 野兽肝 12027110")]
        LDNokronSiofraBeastLiver = 12027110,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【３】 12027120")]
        LDNokronSiofraGoldenRune3 = 12027120,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 武器工匠的制作笔记【６】 67300")]
        LDNokronSiofraArmorersCookbook6 = 67300,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 逆鹰纹熨斗形盾 12027140")]
        LDNokronSiofraInvertedHawkHeaterShield = 12027140,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 失色锻造石【２】 12027150")]
        LDNokronSiofraSomberSmithingStone2 = 12027150,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 古牙 12027160")]
        LDNokronSiofraOldFang = 12027160,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【２】 12027170")]
        LDNokronSiofraGoldenRune2 = 12027170,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 坚盾油脂 12027180")]
        LDNokronSiofraShieldGrease = 12027180,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【３】 12027190")]
        LDNokronSiofraGoldenRune3_ = 12027190,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 斑斓肉干 12027200")]
        LDNokronSiofraDappledCuredMeat = 12027200,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 失色锻造石【２】 12027210")]
        LDNokronSiofraSomberSmithingStone2_ = 12027210,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【３】 12027220")]
        LDNokronSiofraSmithingStone3 = 12027220,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【２】 12027230")]
        LDNokronSiofraSmithingStone2 = 12027230,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 宿灵箭 12027240")]
        LDNokronSiofraDwellingArrow = 12027240,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 腌制黄金鸟爪 12027250")]
        LDNokronSiofraGoldPickledFowlFoot = 12027250,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027260")]
        LDNokronSiofraGoldenRune4 = 12027260,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027270")]
        LDNokronSiofraGoldenRune4_ = 12027270,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 唤勾指药 12027280")]
        LDNokronSiofraFurlcallingFingerRemedy = 12027280,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027290")]
        LDNokronSiofraGoldenRune4__ = 12027290,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【４】 12027300")]
        LDNokronSiofraSmithingStone4 = 12027300,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 粗大兽骨 12027310")]
        LDNokronSiofraHeftyBeastBone = 12027310,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【６】 12027320")]
        LDNokronSiofraGoldenRune6 = 12027320,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【３】 12027330")]
        LDNokronSiofraGoldenRune3__ = 12027330,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 肉片 12027340")]
        LDNokronSiofraSliverOfMeat = 12027340,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【３】 12027350")]
        LDNokronSiofraSmithingStone3_ = 12027350,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 腌制黄金鸟爪 12027360")]
        LDNokronSiofraGoldPickledFowlFoot_ = 12027360,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027370")]
        LDNokronSiofraGoldenRune4___ = 12027370,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 宿灵箭 12027380")]
        LDNokronSiofraDwellingArrow_ = 12027380,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 石剑钥匙 12027390")]
        LDNokronSiofraStoneswordKey = 12027390,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027400")]
        LDNokronSiofraGoldenRune4____ = 12027400,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【２】 12027410")]
        LDNokronSiofraSmithingStone2_ = 12027410,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 角弓 12027420")]
        LDNokronSiofraHornBow = 12027420,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027430")]
        LDNokronSiofraGoldenRune4_____ = 12027430,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 肉片 12027440")]
        LDNokronSiofraSliverOfMeat_ = 12027440,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 石剑钥匙 12027450")]
        LDNokronSiofraStoneswordKey_ = 12027450,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 卢恩弯弧 12027460")]
        LDNokronSiofraRuneArc = 12027460,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 理智角饰品 12027470")]
        LDNokronSiofraClarifyingHornCharm = 12027470,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 野兽肉块 12027480")]
        LDNokronSiofraLumpOfFlesh = 12027480,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 理智角饰品＋１ 12027490")]
        LDNokronSiofraClarifyingHornCharm1 = 12027490,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027500")]
        LDNokronSiofraGoldenRune4______ = 12027500,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 宿灵箭 12027510")]
        LDNokronSiofraDwellingArrow__ = 12027510,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 蜕生蝶 12027520")]
        LDNokronSiofraNascentButterfly = 12027520,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 金色排泄物 12027530")]
        LDNokronSiofraGoldTingedExcrement = 12027530,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 抗火肝脏干 12027540")]
        LDNokronSiofraFireproofDriedLiver = 12027540,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12027550")]
        LDNokronSiofraGoldenRune4_______ = 12027550,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 光角头带 12027560")]
        LDNokronSiofraShiningHornedHeadband = 12027560,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 古牙 12027570")]
        LDNokronSiofraOldFang_ = 12027570,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【５】 12027580")]
        LDNokronSiofraGoldenRune5 = 12027580,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 廓尔喀弯刀 12027590")]
        LDNokronSiofraKukri = 12027590,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 粗大兽骨 12027600")]
        LDNokronSiofraHeftyBeastBone_ = 12027600,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【５】 12027610")]
        LDNokronSiofraSmithingStone5 = 12027610,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 斑斓项链＋１ 12027620")]
        LDNokronSiofraMottledNecklace1 = 12027620,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 古牙 12027630")]
        LDNokronSiofraOldFang__ = 12027630,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 粗大兽骨 12027640")]
        LDNokronSiofraHeftyBeastBone__ = 12027640,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【４】 12027650")]
        LDNokronSiofraSmithingStone4_ = 12027650,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 野兽血液 12027660")]
        LDNokronSiofraBeastBlood = 12027660,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 野兽血液 12027670")]
        LDNokronSiofraBeastBlood_ = 12027670,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 失色锻造石【５】 12027680")]
        LDNokronSiofraSomberSmithingStone5 = 12027680,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１２】 12027690")]
        LDNokronSiofraGoldenRune12 = 12027690,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12027700")]
        LDNokronSiofraGoldenRune1 = 12027700,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【５】 12027710")]
        LDNokronSiofraSmithingStone5_ = 12027710,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【２】 12027720")]
        LDNokronSiofraSmithingStone2__ = 12027720,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 星星泪滴 12027730")]
        LDNokronSiofraCelestialDew = 12027730,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【５】 12027740")]
        LDNokronSiofraSmithingStone5__ = 12027740,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 石剑钥匙 12027750")]
        LDNokronSiofraStoneswordKey__ = 12027750,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 银色泪滴空壳 12027760")]
        LDNokronSiofraSilverTearHusk = 12027760,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12027770")]
        LDNokronSiofraGoldenRune1_ = 12027770,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１３】 12027780")]
        LDNokronSiofraGoldenRune13 = 12027780,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【７】 12027790")]
        LDNokronSiofraGoldenRune7 = 12027790,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【５】 12027800")]
        LDNokronSiofraSmithingStone5___ = 12027800,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【６】 12027810")]
        LDNokronSiofraGoldenRune6_ = 12027810,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 卢恩弯弧 12027820")]
        LDNokronSiofraRuneArc_ = 12027820,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【４】 12027830")]
        LDNokronSiofraSmithingStone4__ = 12027830,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12027840")]
        LDNokronSiofraGoldenRune1__ = 12027840,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 死亡苔药 12027850")]
        LDNokronSiofraVoidbaneTalisman = 12027850,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 卢恩弯弧 12027860")]
        LDNokronSiofraRuneArc__ = 12027860,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 星星泪滴 12027870")]
        LDNokronSiofraCelestialDew_ = 12027870,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 仿身泪滴的骨灰 12027880")]
        LDNokronSiofraMimicTearAshes = 12027880,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【７】 12027890")]
        LDNokronSiofraGoldenRune7_ = 12027890,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【３】 12027900")]
        LDNokronSiofraSmithingStone3__ = 12027900,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 诺克斯流体锤 12027910")]
        LDNokronSiofraNoxFlowingHammer = 12027910,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 星星泪滴 12027920")]
        LDNokronSiofraCelestialDew__ = 12027920,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【７】 12027930")]
        LDNokronSiofraGoldenRune7__ = 12027930,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 柔软棉花 12027940")]
        LDNokronSiofraSoftCotton = 12027940,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 失色锻造石【５】 12027950")]
        LDNokronSiofraSomberSmithingStone5_ = 12027950,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 伤龙油脂 12027960")]
        LDNokronSiofraDragonwoundGrease = 12027960,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 眠卵 12027970")]
        LDNokronSiofraSlumberingEgg = 12027970,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【７】 12027980")]
        LDNokronSiofraGoldenRune7___ = 12027980,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【７】 12027990")]
        LDNokronSiofraGoldenRune7____ = 12027990,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 熔炉角盾 12027435")]
        LDNokronSiofraCrucibleHornshield = 12027435,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 失色锻造石【６】 12027445")]
        LDNokronSiofraSomberSmithingStone6 = 12027445,

        [Annotation(Name = "[LD - 深根底层] 地图碎片：深根底层 62064")]
        LDDeeprootDepthsMapDeeprootDepths = 62064,

        [Annotation(Name = "[LD - 深根底层] 石剑钥匙 12037010")]
        LDDeeprootDepthsStoneswordKey = 12037010,

        [Annotation(Name = "[LD - 深根底层] 蚁酸石 12037020")]
        LDDeeprootDepthsFormicRock = 12037020,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【５】 12037030")]
        LDDeeprootDepthsGoldenRune5 = 12037030,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037040")]
        LDDeeprootDepthsGoldenRune8 = 12037040,

        [Annotation(Name = "[LD - 深根底层] 黄金箭 12037050")]
        LDDeeprootDepthsGoldenArrow = 12037050,

        [Annotation(Name = "[LD - 深根底层] 锻造石【６】 12037060")]
        LDDeeprootDepthsSmithingStone6 = 12037060,

        [Annotation(Name = "[LD - 深根底层] 圣油脂 12037070")]
        LDDeeprootDepthsHolyGrease = 12037070,

        [Annotation(Name = "[LD - 深根底层] [祷告] 艾尔登流星 12037080")]
        LDDeeprootDepthsIncantationEldenStars = 12037080,

        [Annotation(Name = "[LD - 深根底层] 锻造石【４】 12037090")]
        LDDeeprootDepthsSmithingStone4 = 12037090,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【５】 12037100")]
        LDDeeprootDepthsGoldenRune5_ = 12037100,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【６】 12037110")]
        LDDeeprootDepthsGoldenRune6 = 12037110,

        [Annotation(Name = "[LD - 深根底层] 温热石 12037120")]
        LDDeeprootDepthsWarmingStone = 12037120,

        [Annotation(Name = "[LD - 深根底层] 锻造石【４】 12037130")]
        LDDeeprootDepthsSmithingStone4_ = 12037130,

        [Annotation(Name = "[LD - 深根底层] 战灰：真空斩 12037140")]
        LDDeeprootDepthsAshOfWarVacuumSlice = 12037140,

        [Annotation(Name = "[LD - 深根底层] 伤龙油脂 12037150")]
        LDDeeprootDepthsDragonwoundGrease = 12037150,

        [Annotation(Name = "[LD - 深根底层] 粗大兽骨 12037160")]
        LDDeeprootDepthsHeftyBeastBone = 12037160,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【１】 12037170")]
        LDDeeprootDepthsGoldenRune1 = 12037170,

        [Annotation(Name = "[LD - 深根底层] 死王子杖 12037180")]
        LDDeeprootDepthsPrinceOfDeathsStaff = 12037180,

        [Annotation(Name = "[LD - 深根底层] 锻造石【６】 12037190")]
        LDDeeprootDepthsSmithingStone6_ = 12037190,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【５】 12037200")]
        LDDeeprootDepthsGoldenRune5__ = 12037200,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037210")]
        LDDeeprootDepthsGoldenRune8_ = 12037210,

        [Annotation(Name = "[LD - 深根底层] 蜕生蝶 12037220")]
        LDDeeprootDepthsNascentButterfly = 12037220,

        [Annotation(Name = "[LD - 深根底层] 失色锻造石【７】 12037230")]
        LDDeeprootDepthsSomberSmithingStone7 = 12037230,

        [Annotation(Name = "[LD - 深根底层] 失色锻造石【７】 12037240")]
        LDDeeprootDepthsSomberSmithingStone7_ = 12037240,

        [Annotation(Name = "[LD - 深根底层] 失色锻造石【７】 12037250")]
        LDDeeprootDepthsSomberSmithingStone7__ = 12037250,

        [Annotation(Name = "[LD - 深根底层] 扇形暗器 12037260")]
        LDDeeprootDepthsFanDaggers = 12037260,

        [Annotation(Name = "[LD - 深根底层] 失色锻造石【６】 12037270")]
        LDDeeprootDepthsSomberSmithingStone6 = 12037270,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037280")]
        LDDeeprootDepthsGoldenRune8__ = 12037280,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037290")]
        LDDeeprootDepthsGoldenRune8___ = 12037290,

        [Annotation(Name = "[LD - 深根底层] 熔炉树形盔 12037300")]
        LDDeeprootDepthsCrucibleTreeHelm = 12037300,

        [Annotation(Name = "[LD - 深根底层] 锻造石【６】 12037310")]
        LDDeeprootDepthsSmithingStone6__ = 12037310,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037320")]
        LDDeeprootDepthsGoldenRune8____ = 12037320,

        [Annotation(Name = "[LD - 深根底层] 失色锻造石【７】 12037330")]
        LDDeeprootDepthsSomberSmithingStone7___ = 12037330,

        [Annotation(Name = "[LD - 深根底层] 亚缇莉亚叶 12037340")]
        LDDeeprootDepthsArteriaLeaf = 12037340,

        [Annotation(Name = "[LD - 深根底层] 锻造石【７】 12037350")]
        LDDeeprootDepthsSmithingStone7 = 12037350,

        [Annotation(Name = "[LD - 深根底层] 雷电大弩箭 12037360")]
        LDDeeprootDepthsLightningGreatbolt = 12037360,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037370")]
        LDDeeprootDepthsGoldenRune8_____ = 12037370,

        [Annotation(Name = "[LD - 深根底层] 锻造石【６】 12037380")]
        LDDeeprootDepthsSmithingStone6___ = 12037380,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037390")]
        LDDeeprootDepthsGoldenRune8______ = 12037390,

        [Annotation(Name = "[LD - 深根底层] 发狂苔药 12037400")]
        LDDeeprootDepthsClarifyingBoluses = 12037400,

        [Annotation(Name = "[LD - 深根底层] 锻造石【４】 12037410")]
        LDDeeprootDepthsSmithingStone4__ = 12037410,

        [Annotation(Name = "[LD - 深根底层] 人骨碎片 12037420")]
        LDDeeprootDepthsHumanBoneShard = 12037420,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037430")]
        LDDeeprootDepthsGoldenRune8_______ = 12037430,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【９】 12037440")]
        LDDeeprootDepthsGoldenRune9 = 12037440,

        [Annotation(Name = "[LD - 深根底层] 锻造石【４】 12037450")]
        LDDeeprootDepthsSmithingStone4___ = 12037450,

        [Annotation(Name = "[LD - 深根底层] 蜕生蝶 12037460")]
        LDDeeprootDepthsNascentButterfly_ = 12037460,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037470")]
        LDDeeprootDepthsGoldenRune8________ = 12037470,

        [Annotation(Name = "[LD - 深根底层] 锻造石【５】 12037480")]
        LDDeeprootDepthsSmithingStone5 = 12037480,

        [Annotation(Name = "[LD - 深根底层] 锻造石【５】 12037490")]
        LDDeeprootDepthsSmithingStone5_ = 12037490,

        [Annotation(Name = "[LD - 深根底层] 锻造石【６】 12037500")]
        LDDeeprootDepthsSmithingStone6____ = 12037500,

        [Annotation(Name = "[LD - 深根底层] 卢恩弯弧 12037510")]
        LDDeeprootDepthsRuneArc = 12037510,

        [Annotation(Name = "[LD - 深根底层] 灵庙士兵的骨灰 12037520")]
        LDDeeprootDepthsMausoleumSoldierAshes = 12037520,

        [Annotation(Name = "[LD - 深根底层] 失色锻造石【７】 12037530")]
        LDDeeprootDepthsSomberSmithingStone7____ = 12037530,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【８】 12037540")]
        LDDeeprootDepthsGoldenRune8_________ = 12037540,

        [Annotation(Name = "[LD - 深根底层] 失色锻造石【６】 12037550")]
        LDDeeprootDepthsSomberSmithingStone6_ = 12037550,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【１】 12037560")]
        LDDeeprootDepthsGoldenRune1_ = 12037560,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【１】 12037570")]
        LDDeeprootDepthsGoldenRune1__ = 12037570,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【１】 12037580")]
        LDDeeprootDepthsGoldenRune1___ = 12037580,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【１】 12037590")]
        LDDeeprootDepthsGoldenRune1____ = 12037590,

        [Annotation(Name = "[LD - 深根底层] 雷电混种大剑 12037900")]
        LDDeeprootDepthsLightningBastardSword = 12037900,

        [Annotation(Name = "[LD - 深根底层] 黄金卢恩【１】 12037910")]
        LDDeeprootDepthsGoldenRune1_____ = 12037910,

        [Annotation(Name = "[LD - 深根底层] 志留亚的树矛 12037950")]
        LDDeeprootDepthsSiluriasTree = 12037950,

        [Annotation(Name = "[LD - 深根底层] 化身仪式杖 12037960")]
        LDDeeprootDepthsStaffOfTheAvatar = 12037960,

        [Annotation(Name = "[LD - 深根底层] 稀人卢恩 12037800")]
        LDDeeprootDepthsNumensRune = 12037800,

        [Annotation(Name = "[LD - 深根底层] 稀人卢恩 12037810")]
        LDDeeprootDepthsNumensRune_ = 12037810,

        [Annotation(Name = "[LD - 深根底层] 稀人卢恩 12037820")]
        LDDeeprootDepthsNumensRune__ = 12037820,

        [Annotation(Name = "[LD - 深根底层] 稀人卢恩 12037830")]
        LDDeeprootDepthsNumensRune___ = 12037830,

        [Annotation(Name = "[LD - 深根底层] 稀人卢恩 12037840")]
        LDDeeprootDepthsNumensRune____ = 12037840,

        [Annotation(Name = "[LD - 深根底层] 稀人卢恩 12037850")]
        LDDeeprootDepthsNumensRune_____ = 12037850,

        [Annotation(Name = "[LD - 蒙格温王朝] 地图碎片：蒙格温王朝 62062")]
        LDMohgwynMapMohgwynPalace = 62062,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金种子 12057010")]
        LDMohgwynGoldenSeed = 12057010,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１１】 12057020")]
        LDMohgwynGoldenRune11 = 12057020,

        [Annotation(Name = "[LD - 蒙格温王朝] 锻造石【６】 12057030")]
        LDMohgwynSmithingStone6 = 12057030,

        [Annotation(Name = "[LD - 蒙格温王朝] 血蔷薇 12057040")]
        LDMohgwynBloodrose = 12057040,

        [Annotation(Name = "[LD - 蒙格温王朝] 流浪战士的制作笔记【２４】 67910")]
        LDMohgwynNomadicWarriorsCookbook24 = 67910,

        [Annotation(Name = "[LD - 蒙格温王朝] 英雄卢恩【４】 12057060")]
        LDMohgwynHerosRune4 = 12057060,

        [Annotation(Name = "[LD - 蒙格温王朝] 锻造石【８】 12057070")]
        LDMohgwynSmithingStone8 = 12057070,

        [Annotation(Name = "[LD - 蒙格温王朝] 英雄卢恩【３】 12057080")]
        LDMohgwynHerosRune3 = 12057080,

        [Annotation(Name = "[LD - 蒙格温王朝] 和血排泄物 12057090")]
        LDMohgwynBloodTaintedExcrement = 12057090,

        [Annotation(Name = "[LD - 蒙格温王朝] 失色锻造石【９】 12057100")]
        LDMohgwynSomberSmithingStone9 = 12057100,

        [Annotation(Name = "[LD - 蒙格温王朝] [祷告] 蝇群 12057110")]
        LDMohgwynIncantationSwarmOfFlies = 12057110,

        [Annotation(Name = "[LD - 蒙格温王朝] 附绳出血油脂 12057120")]
        LDMohgwynDrawstringBloodGrease = 12057120,

        [Annotation(Name = "[LD - 蒙格温王朝] 和血排泄物 12057130")]
        LDMohgwynBloodTaintedExcrement_ = 12057130,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１２】 12057140")]
        LDMohgwynGoldenRune12 = 12057140,

        [Annotation(Name = "[LD - 蒙格温王朝] 锻造石【７】 12057150")]
        LDMohgwynSmithingStone7 = 12057150,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１２】 12057160")]
        LDMohgwynGoldenRune12_ = 12057160,

        [Annotation(Name = "[LD - 蒙格温王朝] 圣血木芽 12057170")]
        LDMohgwynSacramentalBud = 12057170,

        [Annotation(Name = "[LD - 蒙格温王朝] 蜕生蝶 12057180")]
        LDMohgwynNascentButterfly = 12057180,

        [Annotation(Name = "[LD - 蒙格温王朝] 卢恩弯弧 12057190")]
        LDMohgwynRuneArc = 12057190,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057200")]
        LDMohgwynGoldenRune1 = 12057200,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１３】 12057210")]
        LDMohgwynGoldenRune13 = 12057210,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057220")]
        LDMohgwynGoldenRune1_ = 12057220,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057230")]
        LDMohgwynGoldenRune1__ = 12057230,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057240")]
        LDMohgwynGoldenRune1___ = 12057240,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057250")]
        LDMohgwynGoldenRune1____ = 12057250,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057260")]
        LDMohgwynGoldenRune1_____ = 12057260,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057270")]
        LDMohgwynGoldenRune1______ = 12057270,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057280")]
        LDMohgwynGoldenRune1_______ = 12057280,

        [Annotation(Name = "[LD - 蒙格温王朝] 血蔷薇 12057290")]
        LDMohgwynBloodrose_ = 12057290,

        [Annotation(Name = "[LD - 蒙格温王朝] 圣油脂 12057300")]
        LDMohgwynHolyGrease = 12057300,

        [Annotation(Name = "[LD - 蒙格温王朝] 石剑钥匙 12057310")]
        LDMohgwynStoneswordKey = 12057310,

        [Annotation(Name = "[LD - 蒙格温王朝] 锻造石【６】 12057320")]
        LDMohgwynSmithingStone6_ = 12057320,

        [Annotation(Name = "[LD - 蒙格温王朝] 亚缇莉亚叶 12057330")]
        LDMohgwynArteriaLeaf = 12057330,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１３】 12057340")]
        LDMohgwynGoldenRune13_ = 12057340,

        [Annotation(Name = "[LD - 蒙格温王朝] 发狂苔药 12057350")]
        LDMohgwynClarifyingBoluses = 12057350,

        [Annotation(Name = "[LD - 蒙格温王朝] 腐败油脂 12057360")]
        LDMohgwynRotGrease = 12057360,

        [Annotation(Name = "[LD - 蒙格温王朝] 圣龙徽护符＋２ 12057370")]
        LDMohgwynHaligdrakeTalisman2 = 12057370,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057380")]
        LDMohgwynGoldenRune1________ = 12057380,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057390")]
        LDMohgwynGoldenRune1_________ = 12057390,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057400")]
        LDMohgwynGoldenRune1__________ = 12057400,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057410")]
        LDMohgwynGoldenRune1___________ = 12057410,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057420")]
        LDMohgwynGoldenRune1____________ = 12057420,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057430")]
        LDMohgwynGoldenRune1_____________ = 12057430,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057440")]
        LDMohgwynGoldenRune1______________ = 12057440,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057450")]
        LDMohgwynGoldenRune1_______________ = 12057450,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057460")]
        LDMohgwynGoldenRune1________________ = 12057460,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057470")]
        LDMohgwynGoldenRune1_________________ = 12057470,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057480")]
        LDMohgwynGoldenRune1__________________ = 12057480,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057490")]
        LDMohgwynGoldenRune1___________________ = 12057490,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057500")]
        LDMohgwynGoldenRune1____________________ = 12057500,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057510")]
        LDMohgwynGoldenRune1_____________________ = 12057510,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057520")]
        LDMohgwynGoldenRune1______________________ = 12057520,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057530")]
        LDMohgwynGoldenRune1_______________________ = 12057530,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057540")]
        LDMohgwynGoldenRune1________________________ = 12057540,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057550")]
        LDMohgwynGoldenRune1_________________________ = 12057550,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057560")]
        LDMohgwynGoldenRune1__________________________ = 12057560,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057570")]
        LDMohgwynGoldenRune1___________________________ = 12057570,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057580")]
        LDMohgwynGoldenRune1____________________________ = 12057580,

        [Annotation(Name = "[LD - 蒙格温王朝] 锻造石【７】 12057590")]
        LDMohgwynSmithingStone7_ = 12057590,

        [Annotation(Name = "[LD - 蒙格温王朝] 出血苔药 12057600")]
        LDMohgwynStanchingBoluses = 12057600,

        [Annotation(Name = "[LD - 蒙格温王朝] 石剑钥匙 12057610")]
        LDMohgwynStoneswordKey_ = 12057610,

        [Annotation(Name = "[LD - 蒙格温王朝] 血蔷薇 12057620")]
        LDMohgwynBloodrose__ = 12057620,

        [Annotation(Name = "[LD - 蒙格温王朝] 火焰长剑 12057630")]
        LDMohgwynFireLongsword = 12057630,

        [Annotation(Name = "[LD - 蒙格温王朝] 锻造石【８】 12057640")]
        LDMohgwynSmithingStone8_ = 12057640,

        [Annotation(Name = "[LD - 蒙格温王朝] 稀人卢恩 12057650")]
        LDMohgwynNumensRune = 12057650,

        [Annotation(Name = "[LD - 蒙格温王朝]  12057660")]
        LDMohgwyn = 12057660,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１３】 12057670")]
        LDMohgwynGoldenRune13__ = 12057670,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１１】 12057680")]
        LDMohgwynGoldenRune11_ = 12057680,

        [Annotation(Name = "[LD - 蒙格温王朝] 王之卢恩 12057690")]
        LDMohgwynLordsRune = 12057690,

        [Annotation(Name = "[LD - 蒙格温王朝] 锻造石【６】 12057700")]
        LDMohgwynSmithingStone6__ = 12057700,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057710")]
        LDMohgwynGoldenRune1_____________________________ = 12057710,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057720")]
        LDMohgwynGoldenRune1______________________________ = 12057720,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057730")]
        LDMohgwynGoldenRune1_______________________________ = 12057730,

        [Annotation(Name = "[LD - 蒙格温王朝] 黄金卢恩【１】 12057740")]
        LDMohgwynGoldenRune1________________________________ = 12057740,

        [Annotation(Name = "[LD - 蒙格温王朝] 古龙岩失色锻造石 12057900")]
        LDMohgwynSomberAncientDragonSmithingStone = 12057900,

        [Annotation(Name = "[LD - 蒙格温王朝] 白面具 12057950")]
        LDMohgwynWhiteMask = 12057950,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 唤勾指药 12077000")]
        LDNokronSiofraFurlcallingFingerRemedy_ = 12077000,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 银色萤火虫 12077010")]
        LDNokronSiofraSilverFirefly = 12077010,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【３】 12077020")]
        LDNokronSiofraGoldenRune3___ = 12077020,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【２】 12077030")]
        LDNokronSiofraGoldenRune2_ = 12077030,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【４】 12077040")]
        LDNokronSiofraSmithingStone4___ = 12077040,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【２】 12077050")]
        LDNokronSiofraSmithingStone2___ = 12077050,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【２】 12077060")]
        LDNokronSiofraGoldenRune2__ = 12077060,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 免疫肉干 12077070")]
        LDNokronSiofraImmunizingCuredMeat = 12077070,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【２】 12077080")]
        LDNokronSiofraGoldenRune2___ = 12077080,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 虹彩石 12077090")]
        LDNokronSiofraRainbowStone = 12077090,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12077100")]
        LDNokronSiofraGoldenRune4________ = 12077100,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 芽角 12077110")]
        LDNokronSiofraBuddingHorn = 12077110,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 投掷匕首 12077120")]
        LDNokronSiofraThrowingDagger = 12077120,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【３】 12077130")]
        LDNokronSiofraSmithingStone3___ = 12077130,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【４】 12077140")]
        LDNokronSiofraGoldenRune4_________ = 12077140,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【４】 12077150")]
        LDNokronSiofraSmithingStone4____ = 12077150,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 肥皂 12077160")]
        LDNokronSiofraSoap = 12077160,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 腐败苔药 12077170")]
        LDNokronSiofraPreservingBoluses = 12077170,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 腌制白银鸟爪 12077180")]
        LDNokronSiofraSilverPickledFowlFoot = 12077180,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077190")]
        LDNokronSiofraGoldenRune1___ = 12077190,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077200")]
        LDNokronSiofraGoldenRune1____ = 12077200,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077210")]
        LDNokronSiofraGoldenRune1_____ = 12077210,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077220")]
        LDNokronSiofraGoldenRune1______ = 12077220,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077230")]
        LDNokronSiofraGoldenRune1_______ = 12077230,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077240")]
        LDNokronSiofraGoldenRune1________ = 12077240,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077250")]
        LDNokronSiofraGoldenRune1_________ = 12077250,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077260")]
        LDNokronSiofraGoldenRune1__________ = 12077260,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077270")]
        LDNokronSiofraGoldenRune1___________ = 12077270,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077280")]
        LDNokronSiofraGoldenRune1____________ = 12077280,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077290")]
        LDNokronSiofraGoldenRune1_____________ = 12077290,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【５】 12077300")]
        LDNokronSiofraGoldenRune5_ = 12077300,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 催眠油脂 12077310")]
        LDNokronSiofraSoporificGrease = 12077310,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 倒刺弩箭 12077320")]
        LDNokronSiofraBurredBolt = 12077320,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 蜕生蝶 12077330")]
        LDNokronSiofraNascentButterfly_ = 12077330,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 卢恩弯弧 12077340")]
        LDNokronSiofraRuneArc___ = 12077340,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【６】 12077350")]
        LDNokronSiofraGoldenRune6__ = 12077350,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【５】 12077360")]
        LDNokronSiofraSmithingStone5____ = 12077360,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 唤勾指药 12077370")]
        LDNokronSiofraFurlcallingFingerRemedy__ = 12077370,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 理智白肉干 12077380")]
        LDNokronSiofraClarifyingWhiteCuredMeat = 12077380,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【６】 12077390")]
        LDNokronSiofraGoldenRune6___ = 12077390,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 灵依摘采工的铃珠【１】 12077400")]
        LDNokronSiofraGhostGlovewortPickersBellBearing1 = 12077400,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【３】 12077410")]
        LDNokronSiofraSmithingStone3____ = 12077410,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 失色锻造石【４】 12077420")]
        LDNokronSiofraSomberSmithingStone4 = 12077420,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 锻造石【５】 12077430")]
        LDNokronSiofraSmithingStone5_____ = 12077430,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 大盾士兵的骨灰 12077440")]
        LDNokronSiofraGreatshieldSoldierAshes = 12077440,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【７】 12077450")]
        LDNokronSiofraGoldenRune7_____ = 12077450,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【７】 12077460")]
        LDNokronSiofraGoldenRune7______ = 12077460,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 卢恩弯弧 12077470")]
        LDNokronSiofraRuneArc____ = 12077470,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 泪滴幼体 12077480")]
        LDNokronSiofraLarvalTear = 12077480,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 泪滴幼体 12077490")]
        LDNokronSiofraLarvalTear_ = 12077490,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 灵火火把 12077500")]
        LDNokronSiofraGhostflameTorch = 12077500,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077510")]
        LDNokronSiofraGoldenRune1______________ = 12077510,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077520")]
        LDNokronSiofraGoldenRune1_______________ = 12077520,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077530")]
        LDNokronSiofraGoldenRune1________________ = 12077530,

        [Annotation(Name = "[LD - “永恒之城”诺克隆恩] 黄金卢恩【１】 12077540")]
        LDNokronSiofraGoldenRune1_________________ = 12077540,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007000")]
        LDCrumblingFarumAzulaSmithingStone8 = 13007000,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【９】 13007010")]
        LDCrumblingFarumAzulaGoldenRune9 = 13007010,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古牙 13007020")]
        LDCrumblingFarumAzulaOldFang = 13007020,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 抗雷肝脏干 13007030")]
        LDCrumblingFarumAzulaLightningproofDriedLiver = 13007030,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【６】 13007040")]
        LDCrumblingFarumAzulaSmithingStone6 = 13007040,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007050")]
        LDCrumblingFarumAzulaSmithingStone8_ = 13007050,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 伤龙油脂 13007060")]
        LDCrumblingFarumAzulaDragonwoundGrease = 13007060,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007070")]
        LDCrumblingFarumAzulaSmithingStone8__ = 13007070,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007080")]
        LDCrumblingFarumAzulaSmithingStone8___ = 13007080,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 雷电大弩箭 13007090")]
        LDCrumblingFarumAzulaLightningGreatbolt = 13007090,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007100")]
        LDCrumblingFarumAzula = 13007100,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007110")]
        LDCrumblingFarumAzulaGoldenRune12 = 13007110,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古龙祷告书 13007120")]
        LDCrumblingFarumAzulaAncientDragonPrayerbook = 13007120,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 英雄卢恩【２】 13007130")]
        LDCrumblingFarumAzulaHerosRune2 = 13007130,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【６】 13007140")]
        LDCrumblingFarumAzulaSmithingStone6_ = 13007140,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色石矿工的铃珠【４】 13007150")]
        LDCrumblingFarumAzulaSomberstoneMinersBellBearing4 = 13007150,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007160")]
        LDCrumblingFarumAzula_ = 13007160,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【９】 13007170")]
        LDCrumblingFarumAzulaSomberSmithingStone9 = 13007170,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 雷电花 13007180")]
        LDCrumblingFarumAzulaFulgurbloom = 13007180,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007190")]
        LDCrumblingFarumAzulaSmithingStone8____ = 13007190,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 死亡苔药 13007200")]
        LDCrumblingFarumAzulaRejuvenatingBoluses = 13007200,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007210")]
        LDCrumblingFarumAzula__ = 13007210,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007220")]
        LDCrumblingFarumAzulaSmithingStone8_____ = 13007220,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007230")]
        LDCrumblingFarumAzula___ = 13007230,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 碎石 13007240")]
        LDCrumblingFarumAzulaGravelStone = 13007240,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【７】 13007250")]
        LDCrumblingFarumAzulaSomberSmithingStone7 = 13007250,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【９】 13007260")]
        LDCrumblingFarumAzulaGoldenRune9_ = 13007260,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金箭 13007270")]
        LDCrumblingFarumAzulaGoldenArrow = 13007270,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007280")]
        LDCrumblingFarumAzula____ = 13007280,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 碎石 13007290")]
        LDCrumblingFarumAzulaGravelStone_ = 13007290,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１０】 13007300")]
        LDCrumblingFarumAzulaGoldenRune10 = 13007300,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007310")]
        LDCrumblingFarumAzulaGoldenRune12_ = 13007310,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【６】 13007320")]
        LDCrumblingFarumAzulaSmithingStone6__ = 13007320,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１１】 13007330")]
        LDCrumblingFarumAzulaGoldenRune11 = 13007330,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007340")]
        LDCrumblingFarumAzula_____ = 13007340,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 石剑钥匙 13007350")]
        LDCrumblingFarumAzulaStoneswordKey = 13007350,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007360")]
        LDCrumblingFarumAzulaGoldenRune12__ = 13007360,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007370")]
        LDCrumblingFarumAzula______ = 13007370,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 卢恩弯弧 13007380")]
        LDCrumblingFarumAzulaRuneArc = 13007380,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【９】 13007390")]
        LDCrumblingFarumAzulaSomberSmithingStone9_ = 13007390,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007400")]
        LDCrumblingFarumAzula_______ = 13007400,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007410")]
        LDCrumblingFarumAzula________ = 13007410,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１１】 13007420")]
        LDCrumblingFarumAzulaGoldenRune11_ = 13007420,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古牙 5x 13007430")]
        LDCrumblingFarumAzulaGodskinWard = 13007430,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 英雄卢恩【５】 13007440")]
        LDCrumblingFarumAzulaHerosRune5 = 13007440,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【７】 13007450")]
        LDCrumblingFarumAzulaSmithingStone7 = 13007450,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 雷油脂 13007460")]
        LDCrumblingFarumAzulaLightningGrease = 13007460,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【９】 13007470")]
        LDCrumblingFarumAzulaSomberSmithingStone9__ = 13007470,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古龙岩锻造石 13007480")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone = 13007480,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007490")]
        LDCrumblingFarumAzulaGoldenRune12___ = 13007490,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 龙徽盾护符＋２ 13007500")]
        LDCrumblingFarumAzulaDragoncrestShieldTalisman2 = 13007500,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 斑斓肉干 13007510")]
        LDCrumblingFarumAzulaDappledCuredMeat = 13007510,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007520")]
        LDCrumblingFarumAzulaSmithingStone8______ = 13007520,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 王之卢恩 13007530")]
        LDCrumblingFarumAzulaLordsRune = 13007530,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 蜕生蝶 13007540")]
        LDCrumblingFarumAzulaNascentButterfly = 13007540,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007550")]
        LDCrumblingFarumAzulaGoldenRune12____ = 13007550,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007560")]
        LDCrumblingFarumAzulaSmithingStone8_______ = 13007560,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 卢恩弯弧 13007570")]
        LDCrumblingFarumAzulaRuneArc_ = 13007570,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【７】 13007580")]
        LDCrumblingFarumAzulaSmithingStone7_ = 13007580,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 伤龙油脂 13007590")]
        LDCrumblingFarumAzulaDragonwoundGrease_ = 13007590,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007600")]
        LDCrumblingFarumAzulaSmithingStone8________ = 13007600,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007610")]
        LDCrumblingFarumAzula_________ = 13007610,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007620")]
        LDCrumblingFarumAzulaGoldenRune12_____ = 13007620,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007630")]
        LDCrumblingFarumAzula__________ = 13007630,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【７】 13007640")]
        LDCrumblingFarumAzulaSmithingStone7__ = 13007640,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古龙信徒的制作笔记【４】 68020")]
        LDCrumblingFarumAzulaAncientDragonApostlesCookbook4 = 68020,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【８】 13007660")]
        LDCrumblingFarumAzulaSomberSmithingStone8 = 13007660,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【６】 13007670")]
        LDCrumblingFarumAzulaSmithingStone6___ = 13007670,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 亚缇莉亚叶 13007680")]
        LDCrumblingFarumAzulaArteriaLeaf = 13007680,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007690")]
        LDCrumblingFarumAzula___________ = 13007690,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 雷电大弩箭 13007700")]
        LDCrumblingFarumAzulaLightningGreatbolt_ = 13007700,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 雷电花 13007710")]
        LDCrumblingFarumAzulaFulgurbloom_ = 13007710,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007720")]
        LDCrumblingFarumAzulaGoldenRune12______ = 13007720,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【７】 13007730")]
        LDCrumblingFarumAzulaSmithingStone7___ = 13007730,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007740")]
        LDCrumblingFarumAzulaGoldenRune12_______ = 13007740,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007750")]
        LDCrumblingFarumAzula____________ = 13007750,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 雷龙徽护符＋２ 13007760")]
        LDCrumblingFarumAzulaBoltdrakeTalisman2 = 13007760,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【７】 13007770")]
        LDCrumblingFarumAzulaSomberSmithingStone7_ = 13007770,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007780")]
        LDCrumblingFarumAzula_____________ = 13007780,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色石矿工的铃珠【５】 13007790")]
        LDCrumblingFarumAzulaSomberstoneMinersBellBearing5 = 13007790,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金卢恩【１２】 13007800")]
        LDCrumblingFarumAzulaGoldenRune12________ = 13007800,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【７】 13007810")]
        LDCrumblingFarumAzulaSomberSmithingStone7__ = 13007810,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【８】 13007820")]
        LDCrumblingFarumAzulaSomberSmithingStone8_ = 13007820,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 珍珠龙徽护符 13007830")]
        LDCrumblingFarumAzulaPearldrakeTalisman = 13007830,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007840")]
        LDCrumblingFarumAzula______________ = 13007840,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【７】 13007850")]
        LDCrumblingFarumAzulaSmithingStone7____ = 13007850,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 碎石 13007860")]
        LDCrumblingFarumAzulaGravelStone__ = 13007860,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 失色锻造石【９】 13007870")]
        LDCrumblingFarumAzulaSomberSmithingStone9___ = 13007870,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 锻造石【８】 13007880")]
        LDCrumblingFarumAzulaSmithingStone8_________ = 13007880,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 亚兹拉的兽人的骨灰 13007890")]
        LDCrumblingFarumAzulaAzulaBeastmanAshes = 13007890,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古龙岩锻造石 13007900")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone_ = 13007900,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 铃兰摘采工的铃珠【３】 13007910")]
        LDCrumblingFarumAzulaGlovewortPickersBellBearing3 = 13007910,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 龙骑士头盔 13007920")]
        LDCrumblingFarumAzulaDrakeKnightHelm = 13007920,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉]  13007930")]
        LDCrumblingFarumAzula_______________ = 13007930,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 龙塔盾 13007940")]
        LDCrumblingFarumAzulaDragonTowershield = 13007940,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古王护符 13007950")]
        LDCrumblingFarumAzulaOldLordsTalisman = 13007950,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金种子 13007980")]
        LDCrumblingFarumAzulaGoldenSeed = 13007980,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 黄金种子 13007990")]
        LDCrumblingFarumAzulaGoldenSeed_ = 13007990,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古龙岩锻造石 13007991")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone__ = 13007991,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古龙岩锻造石 13007993")]
        LDCrumblingFarumAzulaAncientDragonSmithingStone___ = 13007993,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 异形龙盔 13007995")]
        LDCrumblingFarumAzulaMalformedDragonHelm = 13007995,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 古龙岩失色锻造石 13007005")]
        LDCrumblingFarumAzulaSomberAncientDragonSmithingStone = 13007005,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 伤龙油脂 13007015")]
        LDCrumblingFarumAzulaDragonwoundGrease__ = 13007015,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 大朵墓地铃兰 13007025")]
        LDCrumblingFarumAzulaGreatGraveGlovewort = 13007025,

        [Annotation(Name = "[LD - 逐渐崩毁的法姆·亚兹拉] 大朵墓地铃兰 13007035")]
        LDCrumblingFarumAzulaGreatGraveGlovewort_ = 13007035,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 魔力油脂 14007000")]
        LDAcademyOfRayaLucariaMagicGrease = 14007000,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 卢恩弯弧 14007020")]
        LDAcademyOfRayaLucariaRuneArc = 14007020,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【２】 14007030")]
        LDAcademyOfRayaLucariaGoldenRune2 = 14007030,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 失色锻造石【３】 14007040")]
        LDAcademyOfRayaLucariaSomberSmithingStone3 = 14007040,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 拟态赐福 14007070")]
        LDAcademyOfRayaLucariaGraceMimic = 14007070,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 锻造石【４】 14007090")]
        LDAcademyOfRayaLucariaSmithingStone4 = 14007090,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 抗魔肝脏干 14007120")]
        LDAcademyOfRayaLucariaSpellproofDriedLiver = 14007120,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 人偶士兵的骨灰 14007150")]
        LDAcademyOfRayaLucariaMarionetteSoldierAshes = 14007150,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 腌制白银鸟爪 14007160")]
        LDAcademyOfRayaLucariaSilverPickledFowlFoot = 14007160,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 魔力油脂 14007190")]
        LDAcademyOfRayaLucariaMagicGrease_ = 14007190,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007200")]
        LDAcademyOfRayaLucariaGoldenRune4 = 14007200,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 蘑菇 14007220")]
        LDAcademyOfRayaLucariaMushroom = 14007220,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007250")]
        LDAcademyOfRayaLucariaGoldenRune4_ = 14007250,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【３】 14007280")]
        LDAcademyOfRayaLucariaGoldenRune3 = 14007280,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 鸟身人偶士兵的骨灰 14007290")]
        LDAcademyOfRayaLucariaAvionetteSoldierAshes = 14007290,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 锻造石【５】 14007300")]
        LDAcademyOfRayaLucariaSmithingStone5 = 14007300,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 长尾猫别针 14007320")]
        LDAcademyOfRayaLucariaLongtailCatTalisman = 14007320,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 结晶飞刀 14007330")]
        LDAcademyOfRayaLucariaCrystalDart = 14007330,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007350")]
        LDAcademyOfRayaLucariaGoldenRune4__ = 14007350,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 教室卷轴 14007360")]
        LDAcademyOfRayaLucariaConspectusScroll = 14007360,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 锻造石【４】 14007370")]
        LDAcademyOfRayaLucariaSmithingStone4_ = 14007370,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 石剑钥匙 14007380")]
        LDAcademyOfRayaLucariaStoneswordKey = 14007380,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 唤勾指药 14007390")]
        LDAcademyOfRayaLucariaFurlcallingFingerRemedy = 14007390,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 活壶碎片 14007410")]
        LDAcademyOfRayaLucariaLivingJarShard = 14007410,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 石剑钥匙 14007420")]
        LDAcademyOfRayaLucariaStoneswordKey_ = 14007420,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 辉石萤火虫 14007430")]
        LDAcademyOfRayaLucariaGlintstoneFirefly = 14007430,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【２】 14007440")]
        LDAcademyOfRayaLucariaGoldenRune2_ = 14007440,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007450")]
        LDAcademyOfRayaLucariaGoldenRune4___ = 14007450,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 结晶木芽 14007460")]
        LDAcademyOfRayaLucariaCrystalBud = 14007460,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007470")]
        LDAcademyOfRayaLucariaGoldenRune4____ = 14007470,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 锻造石【５】 14007480")]
        LDAcademyOfRayaLucariaSmithingStone5_ = 14007480,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【２】 14007490")]
        LDAcademyOfRayaLucariaGoldenRune2__ = 14007490,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 辉石砥石刀 65680")]
        LDAcademyOfRayaLucariaGlintstoneWhetblade = 65680,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【３】 14007510")]
        LDAcademyOfRayaLucariaGoldenRune3_ = 14007510,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 结晶飞刀 14007520")]
        LDAcademyOfRayaLucariaCrystalDart_ = 14007520,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007530")]
        LDAcademyOfRayaLucariaGoldenRune4_____ = 14007530,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 唤勾指药 14007540")]
        LDAcademyOfRayaLucariaFurlcallingFingerRemedy_ = 14007540,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【７】 14007560")]
        LDAcademyOfRayaLucariaGoldenRune7 = 14007560,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007600")]
        LDAcademyOfRayaLucariaGoldenRune4______ = 14007600,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 结晶飞刀 14007620")]
        LDAcademyOfRayaLucariaCrystalDart__ = 14007620,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 魔石剑钥匙 14007630")]
        LDAcademyOfRayaLucariaImbuedSwordKey = 14007630,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 流星弩箭 14007660")]
        LDAcademyOfRayaLucariaMeteorBolt = 14007660,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 锻造石【４】 14007670")]
        LDAcademyOfRayaLucariaSmithingStone4__ = 14007670,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【４】 14007710")]
        LDAcademyOfRayaLucariaGoldenRune4_______ = 14007710,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 锻造石【３】 14007720")]
        LDAcademyOfRayaLucariaSmithingStone3 = 14007720,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 魔力油脂 14007740")]
        LDAcademyOfRayaLucariaMagicGrease__ = 14007740,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金卢恩【３】 14007750")]
        LDAcademyOfRayaLucariaGoldenRune3__ = 14007750,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 失色锻造石【４】 14007760")]
        LDAcademyOfRayaLucariaSomberSmithingStone4 = 14007760,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] [魔法] 爆散结晶 14007770")]
        LDAcademyOfRayaLucariaSorceryShatteringCrystal = 14007770,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 龟裂壶 66120")]
        LDAcademyOfRayaLucariaCrackedPot = 66120,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 亚兹勒的辉石杖 14007840")]
        LDAcademyOfRayaLucariaAzursGlintstoneStaff = 14007840,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 卡利亚骑士头盔 14007850")]
        LDAcademyOfRayaLucariaCarianKnightHelm = 14007850,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 失色锻造石【３】 14007860")]
        LDAcademyOfRayaLucariaSomberSmithingStone3_ = 14007860,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 失力战灰 14007870")]
        LDAcademyOfRayaLucariaLostAshesOfWar = 14007870,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] [魔法] 帚星 14007880")]
        LDAcademyOfRayaLucariaSorceryComet = 14007880,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 魔法师球护符 14007890")]
        LDAcademyOfRayaLucariaGravenSchoolTalisman = 14007890,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 仪式壶 66410")]
        LDAcademyOfRayaLucariaRitualPot = 66410,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 辉石粪金龟 14007910")]
        LDAcademyOfRayaLucariaGlintstoneScarab = 14007910,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 魔法之境 14007920")]
        LDAcademyOfRayaLucariaTerraMagicus = 14007920,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 拉达冈的肖像 14007940")]
        LDAcademyOfRayaLucariaRadagonIcon = 14007940,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 辉石工匠的制作笔记【５】 67420")]
        LDAcademyOfRayaLucariaGlintstoneCraftsmansCookbook5 = 67420,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 暗月戒指 114")]
        LDAcademyOfRayaLucariaDarkMoonRing = 114,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 圆月弩 14007970")]
        LDAcademyOfRayaLucariaFullMoonCrossbow = 14007970,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 卡利亚骑士盾 14007980")]
        LDAcademyOfRayaLucariaCarianKnightsShield = 14007980,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 黄金种子 14007990")]
        LDAcademyOfRayaLucariaGoldenSeed = 14007990,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 双贤辉石头罩 14007005")]
        LDAcademyOfRayaLucariaTwinsageGlintstoneCrown = 14007005,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 奥利维尼斯辉石头罩 14007015")]
        LDAcademyOfRayaLucariaOlivinusGlintstoneCrown = 14007015,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 拉兹利辉石头罩 14007025")]
        LDAcademyOfRayaLucariaLazuliGlintstoneCrown = 14007025,

        [Annotation(Name = "[LD - 魔法学院雷亚卢卡利亚] 卡勒罗斯辉石头罩 14007035")]
        LDAcademyOfRayaLucariaKarolosGlintstoneCrown = 14007035,

        [Annotation(Name = "[LD - 米凯拉的圣树] 石剑钥匙 15007000")]
        LDElphaelMiquellasHaligtreeStoneswordKey = 15007000,

        [Annotation(Name = "[LD - 米凯拉的圣树] 圣血木芽 15007010")]
        LDElphaelMiquellasHaligtreeSacramentalBud = 15007010,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１０】 15007020")]
        LDElphaelMiquellasHaligtreeGoldenRune10 = 15007020,

        [Annotation(Name = "[LD - 米凯拉的圣树] 石剑钥匙 15007030")]
        LDElphaelMiquellasHaligtreeStoneswordKey_ = 15007030,

        [Annotation(Name = "[LD - 米凯拉的圣树] 火油脂 15007040")]
        LDElphaelMiquellasHaligtreeFireGrease = 15007040,

        [Annotation(Name = "[LD - 米凯拉的圣树] 艾奥尼亚蝶 15007050")]
        LDElphaelMiquellasHaligtreeAeonianButterfly = 15007050,

        [Annotation(Name = "[LD - 米凯拉的圣树] 腐败苔药 15007060")]
        LDElphaelMiquellasHaligtreePreservingBoluses = 15007060,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１０】 15007070")]
        LDElphaelMiquellasHaligtreeGoldenRune10_ = 15007070,

        [Annotation(Name = "[LD - 米凯拉的圣树] 众使者大头冠 15007080")]
        LDElphaelMiquellasHaligtreeEnvoyCrown = 15007080,

        [Annotation(Name = "[LD - 米凯拉的圣树] 斑斓肉干 15007090")]
        LDElphaelMiquellasHaligtreeDappledCuredMeat = 15007090,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【８】 15007100")]
        LDElphaelMiquellasHaligtreeSmithingStone8 = 15007100,

        [Annotation(Name = "[LD - 米凯拉的圣树] 唤声泥颅“我爱你” 15007110")]
        LDElphaelMiquellasHaligtreePrattlingPateMybeloved = 15007110,

        [Annotation(Name = "[LD - 米凯拉的圣树] 温热石 15007120")]
        LDElphaelMiquellasHaligtreeWarmingStone = 15007120,

        [Annotation(Name = "[LD - 米凯拉的圣树] 猛火弩箭 15007130")]
        LDElphaelMiquellasHaligtreeFlamingBolt = 15007130,

        [Annotation(Name = "[LD - 米凯拉的圣树] 稀人卢恩 15007140")]
        LDElphaelMiquellasHaligtreeNumensRune = 15007140,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１３】 15007150")]
        LDElphaelMiquellasHaligtreeGoldenRune13 = 15007150,

        [Annotation(Name = "[LD - 米凯拉的圣树] 失力战灰 15007160")]
        LDElphaelMiquellasHaligtreeLostAshesOfWar = 15007160,

        [Annotation(Name = "[LD - 米凯拉的圣树] 神谕众使者的骨灰 15007170")]
        LDElphaelMiquellasHaligtreeOracleEnvoyAshes = 15007170,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007180")]
        LDElphaelMiquellasHaligtreeGoldenRune1 = 15007180,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007190")]
        LDElphaelMiquellasHaligtreeGoldenRune1_ = 15007190,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１０】 15007200")]
        LDElphaelMiquellasHaligtreeGoldenRune10__ = 15007200,

        [Annotation(Name = "[LD - 米凯拉的圣树] 腐败油脂 15007210")]
        LDElphaelMiquellasHaligtreeRotGrease = 15007210,

        [Annotation(Name = "[LD - 米凯拉的圣树] 珍珠龙徽护符＋２ 15007220")]
        LDElphaelMiquellasHaligtreePearldrakeTalisman2 = 15007220,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【８】 15007230")]
        LDElphaelMiquellasHaligtreeSmithingStone8_ = 15007230,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１３】 15007240")]
        LDElphaelMiquellasHaligtreeGoldenRune13_ = 15007240,

        [Annotation(Name = "[LD - 米凯拉的圣树] 粗大兽骨 15007250")]
        LDElphaelMiquellasHaligtreeHeftyBeastBone = 15007250,

        [Annotation(Name = "[LD - 米凯拉的圣树] 火油脂 15007260")]
        LDElphaelMiquellasHaligtreeFireGrease_ = 15007260,

        [Annotation(Name = "[LD - 米凯拉的圣树] 古龙岩锻造石 15007270")]
        LDElphaelMiquellasHaligtreeAncientDragonSmithingStone = 15007270,

        [Annotation(Name = "[LD - 米凯拉的圣树] 失色锻造石【８】 15007280")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone8 = 15007280,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１２】 15007290")]
        LDElphaelMiquellasHaligtreeGoldenRune12 = 15007290,

        [Annotation(Name = "[LD - 米凯拉的圣树] 艾奥尼亚蝶 15007300")]
        LDElphaelMiquellasHaligtreeAeonianButterfly_ = 15007300,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【６】 15007310")]
        LDElphaelMiquellasHaligtreeSmithingStone6 = 15007310,

        [Annotation(Name = "[LD - 米凯拉的圣树] 失色锻造石【９】 15007320")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9 = 15007320,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１０】 15007330")]
        LDElphaelMiquellasHaligtreeGoldenRune10___ = 15007330,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１２】 15007340")]
        LDElphaelMiquellasHaligtreeGoldenRune12_ = 15007340,

        [Annotation(Name = "[LD - 米凯拉的圣树] 绿琥珀链坠＋２ 15007350")]
        LDElphaelMiquellasHaligtreeViridianAmberMedallion2 = 15007350,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【６】 15007360")]
        LDElphaelMiquellasHaligtreeSmithingStone6_ = 15007360,

        [Annotation(Name = "[LD - 米凯拉的圣树] 圣血木芽 15007370")]
        LDElphaelMiquellasHaligtreeSacramentalBud_ = 15007370,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【７】 15007380")]
        LDElphaelMiquellasHaligtreeSmithingStone7 = 15007380,

        [Annotation(Name = "[LD - 米凯拉的圣树] 英雄卢恩【４】 15007390")]
        LDElphaelMiquellasHaligtreeHerosRune4 = 15007390,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【８】 15007400")]
        LDElphaelMiquellasHaligtreeSmithingStone8__ = 15007400,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007410")]
        LDElphaelMiquellasHaligtreeGoldenRune1__ = 15007410,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007420")]
        LDElphaelMiquellasHaligtreeGoldenRune1___ = 15007420,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007430")]
        LDElphaelMiquellasHaligtreeGoldenRune1____ = 15007430,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007440")]
        LDElphaelMiquellasHaligtreeGoldenRune1_____ = 15007440,

        [Annotation(Name = "[LD - 米凯拉的圣树] 失色锻造石【９】 15007450")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9_ = 15007450,

        [Annotation(Name = "[LD - 米凯拉的圣树] 古龙岩锻造石 15007460")]
        LDElphaelMiquellasHaligtreeAncientDragonSmithingStone_ = 15007460,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007470")]
        LDElphaelMiquellasHaligtreeGoldenRune1______ = 15007470,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007480")]
        LDElphaelMiquellasHaligtreeGoldenRune1_______ = 15007480,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007490")]
        LDElphaelMiquellasHaligtreeGoldenRune1________ = 15007490,

        [Annotation(Name = "[LD - 米凯拉的圣树] 圣油脂 15007500")]
        LDElphaelMiquellasHaligtreeHolyGrease = 15007500,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１２】 15007510")]
        LDElphaelMiquellasHaligtreeGoldenRune12__ = 15007510,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【８】 15007520")]
        LDElphaelMiquellasHaligtreeSmithingStone8___ = 15007520,

        [Annotation(Name = "[LD - 米凯拉的圣树] 米凯拉骑士剑 15007530")]
        LDElphaelMiquellasHaligtreeMiquellanKnightsSword = 15007530,

        [Annotation(Name = "[LD - 米凯拉的圣树] 雷电大弩箭 15007540")]
        LDElphaelMiquellasHaligtreeLightningGreatbolt = 15007540,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【７】 15007550")]
        LDElphaelMiquellasHaligtreeSmithingStone7_ = 15007550,

        [Annotation(Name = "[LD - 米凯拉的圣树] [祷告] 化三光环 15007560")]
        LDElphaelMiquellasHaligtreeIncantationTripleRingsOfLight = 15007560,

        [Annotation(Name = "[LD - 米凯拉的圣树] 免疫白肉干 15007570")]
        LDElphaelMiquellasHaligtreeImmunizingWhiteCuredMeat = 15007570,

        [Annotation(Name = "[LD - 米凯拉的圣树] “尊腐骑士”芬雷 15007580")]
        LDElphaelMiquellasHaligtreeCleanrotKnightFinlay = 15007580,

        [Annotation(Name = "[LD - 米凯拉的圣树] 古龙岩失色锻造石 15007590")]
        LDElphaelMiquellasHaligtreeSomberAncientDragonSmithingStone = 15007590,

        [Annotation(Name = "[LD - 米凯拉的圣树] 稀人卢恩 15007600")]
        LDElphaelMiquellasHaligtreeNumensRune_ = 15007600,

        [Annotation(Name = "[LD - 米凯拉的圣树] 古龙岩失色锻造石 15007610")]
        LDElphaelMiquellasHaligtreeSomberAncientDragonSmithingStone_ = 15007610,

        [Annotation(Name = "[LD - 米凯拉的圣树] 失色锻造石【９】 15007620")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9__ = 15007620,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１０】 15007630")]
        LDElphaelMiquellasHaligtreeGoldenRune10____ = 15007630,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【７】 15007640")]
        LDElphaelMiquellasHaligtreeSmithingStone7__ = 15007640,

        [Annotation(Name = "[LD - 米凯拉的圣树] 古牙 15007650")]
        LDElphaelMiquellasHaligtreeOldFang = 15007650,

        [Annotation(Name = "[LD - 米凯拉的圣树] 温热石 15007660")]
        LDElphaelMiquellasHaligtreeWarmingStone_ = 15007660,

        [Annotation(Name = "[LD - 米凯拉的圣树] 灵火箭 15007670")]
        LDElphaelMiquellasHaligtreeSpiritflameArrow = 15007670,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【８】 15007680")]
        LDElphaelMiquellasHaligtreeSmithingStone8____ = 15007680,

        [Annotation(Name = "[LD - 米凯拉的圣树] 圣树士兵的骨灰 15007690")]
        LDElphaelMiquellasHaligtreeHaligtreeSoldierAshes = 15007690,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１１】 15007700")]
        LDElphaelMiquellasHaligtreeGoldenRune11 = 15007700,

        [Annotation(Name = "[LD - 米凯拉的圣树] 亚缇莉亚叶 15007710")]
        LDElphaelMiquellasHaligtreeArteriaLeaf = 15007710,

        [Annotation(Name = "[LD - 米凯拉的圣树] 圣血木芽 15007720")]
        LDElphaelMiquellasHaligtreeSacramentalBud__ = 15007720,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【８】 15007730")]
        LDElphaelMiquellasHaligtreeSmithingStone8_____ = 15007730,

        [Annotation(Name = "[LD - 米凯拉的圣树] 王之卢恩 15007740")]
        LDElphaelMiquellasHaligtreeLordsRune = 15007740,

        [Annotation(Name = "[LD - 米凯拉的圣树] 温床的诅咒 15007750")]
        LDElphaelMiquellasHaligtreeSeedbedCurse = 15007750,

        [Annotation(Name = "[LD - 米凯拉的圣树] 失色锻造石【９】 15007760")]
        LDElphaelMiquellasHaligtreeSomberSmithingStone9___ = 15007760,

        [Annotation(Name = "[LD - 米凯拉的圣树] 腌制龟颈肉 15007770")]
        LDElphaelMiquellasHaligtreePickledTurtleNeck = 15007770,

        [Annotation(Name = "[LD - 米凯拉的圣树] 野兽血液 15007780")]
        LDElphaelMiquellasHaligtreeBeastBlood = 15007780,

        [Annotation(Name = "[LD - 米凯拉的圣树] 艾奥尼亚蝶 15007790")]
        LDElphaelMiquellasHaligtreeAeonianButterfly__ = 15007790,

        [Annotation(Name = "[LD - 米凯拉的圣树] 玛莉卡的糜烂烙印 15007800")]
        LDElphaelMiquellasHaligtreeMarikasSoreseal = 15007800,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１２】 15007810")]
        LDElphaelMiquellasHaligtreeGoldenRune12___ = 15007810,

        [Annotation(Name = "[LD - 米凯拉的圣树] 圣树骑士头盔 15007820")]
        LDElphaelMiquellasHaligtreeHaligtreeKnightHelm = 15007820,

        [Annotation(Name = "[LD - 米凯拉的圣树] 锻造石【６】 15007830")]
        LDElphaelMiquellasHaligtreeSmithingStone6__ = 15007830,

        [Annotation(Name = "[LD - 米凯拉的圣树] 温床的诅咒 15007840")]
        LDElphaelMiquellasHaligtreeSeedbedCurse_ = 15007840,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１】 15007850")]
        LDElphaelMiquellasHaligtreeGoldenRune1_________ = 15007850,

        [Annotation(Name = "[LD - 米凯拉的圣树] 腐败结晶剑 15007860")]
        LDElphaelMiquellasHaligtreeRottenCrystalSword = 15007860,

        [Annotation(Name = "[LD - 米凯拉的圣树] 英雄卢恩【５】 15007870")]
        LDElphaelMiquellasHaligtreeHerosRune5 = 15007870,

        [Annotation(Name = "[LD - 米凯拉的圣树] 腐败油脂 15007880")]
        LDElphaelMiquellasHaligtreeRotGrease_ = 15007880,

        [Annotation(Name = "[LD - 米凯拉的圣树] 大朵墓地铃兰 15007890")]
        LDElphaelMiquellasHaligtreeGreatGraveGlovewort = 15007890,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金卢恩【１０】 15007900")]
        LDElphaelMiquellasHaligtreeGoldenRune10_____ = 15007900,

        [Annotation(Name = "[LD - 米凯拉的圣树] 灵依摘采工的铃珠【３】 15007910")]
        LDElphaelMiquellasHaligtreeGhostGlovewortPickersBellBearing3 = 15007910,

        [Annotation(Name = "[LD - 米凯拉的圣树] 蜕生蝶 15007920")]
        LDElphaelMiquellasHaligtreeNascentButterfly = 15007920,

        [Annotation(Name = "[LD - 米凯拉的圣树] 龙徽大盾护符 15007930")]
        LDElphaelMiquellasHaligtreeDragoncrestGreatshieldTalisman = 15007930,

        [Annotation(Name = "[LD - 米凯拉的圣树] 艾奥尼亚蝶 15007940")]
        LDElphaelMiquellasHaligtreeAeonianButterfly___ = 15007940,

        [Annotation(Name = "[LD - 米凯拉的圣树] 亚缇莉亚叶 15007950")]
        LDElphaelMiquellasHaligtreeArteriaLeaf_ = 15007950,

        [Annotation(Name = "[LD - 米凯拉的圣树] 英雄卢恩【５】 15007960")]
        LDElphaelMiquellasHaligtreeHerosRune5_ = 15007960,

        [Annotation(Name = "[LD - 米凯拉的圣树] 稀人卢恩 15007970")]
        LDElphaelMiquellasHaligtreeNumensRune__ = 15007970,

        [Annotation(Name = "[LD - 米凯拉的圣树] 旅行上衣 15007980")]
        LDElphaelMiquellasHaligtreeTravelersClothes = 15007980,

        [Annotation(Name = "[LD - 米凯拉的圣树] 米凯拉的针 15007990")]
        LDElphaelMiquellasHaligtreeMiquellasNeedle = 15007990,

        [Annotation(Name = "[LD - 米凯拉的圣树] 黄金种子 15001200")]
        LDElphaelMiquellasHaligtreeGoldenSeed = 15001200,

        [Annotation(Name = "[LD - 米凯拉的圣树]  15001210")]
        LDElphaelMiquellasHaligtree = 15001210,

        [Annotation(Name = "[LD - 米凯拉的圣树]  15001250")]
        LDElphaelMiquellasHaligtree_ = 15001250,

        [Annotation(Name = "[LD - 米凯拉的圣树]  15001260")]
        LDElphaelMiquellasHaligtree__ = 15001260,

        [Annotation(Name = "[LD - 米凯拉的圣树] 王之卢恩 15001270")]
        LDElphaelMiquellasHaligtreeLordsRune_ = 15001270,

        [Annotation(Name = "[LD - 米凯拉的圣树] 腐败仪式杖 15001280")]
        LDElphaelMiquellasHaligtreeRottenStaff = 15001280,

        [Annotation(Name = "[LD - 米凯拉的圣树]  15001290")]
        LDElphaelMiquellasHaligtree___ = 15001290,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【６】 16007000")]
        LDVolcanoManorSmithingStone6 = 16007000,

        [Annotation(Name = "[LD - 火山官邸] “堕落调香师”卡尔曼 16007010")]
        LDVolcanoManorDepravedPerfumerCarmaan = 16007010,

        [Annotation(Name = "[LD - 火山官邸] 战灰：侍王骑士的决心 16007020")]
        LDVolcanoManorAshOfWarRoyalKnightsResolve = 16007020,

        [Annotation(Name = "[LD - 火山官邸] 芽角 16007030")]
        LDVolcanoManorBuddingHorn = 16007030,

        [Annotation(Name = "[LD - 火山官邸] 抗火肝脏干 16007040")]
        LDVolcanoManorFireproofDriedLiver = 16007040,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【９】 16007050")]
        LDVolcanoManorGoldenRune9 = 16007050,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【５】 16007060")]
        LDVolcanoManorGoldenRune5 = 16007060,

        [Annotation(Name = "[LD - 火山官邸] 石剑钥匙 16007070")]
        LDVolcanoManorStoneswordKey = 16007070,

        [Annotation(Name = "[LD - 火山官邸] 唤勾指药 16007080")]
        LDVolcanoManorFurlcallingFingerRemedy = 16007080,

        [Annotation(Name = "[LD - 火山官邸] 流浪战士的制作笔记【２１】 67120")]
        LDVolcanoManorNomadicWarriorsCookbook21 = 67120,

        [Annotation(Name = "[LD - 火山官邸] 失色锻造石【７】 16007100")]
        LDVolcanoManorSomberSmithingStone7 = 16007100,

        [Annotation(Name = "[LD - 火山官邸] 调香瓶 66700")]
        LDVolcanoManorPerfumeBottle = 66700,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【６】 16007120")]
        LDVolcanoManorSmithingStone6_ = 16007120,

        [Annotation(Name = "[LD - 火山官邸] 黄金树圣印记 16007130")]
        LDVolcanoManorErdtreeSeal = 16007130,

        [Annotation(Name = "[LD - 火山官邸] 附绳火油脂 16007140")]
        LDVolcanoManorDrawstringFireGrease = 16007140,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【６】 16007150")]
        LDVolcanoManorGoldenRune6 = 16007150,

        [Annotation(Name = "[LD - 火山官邸] 火箭 16007160")]
        LDVolcanoManorFireArrow = 16007160,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【９】 16007170")]
        LDVolcanoManorGoldenRune9_ = 16007170,

        [Annotation(Name = "[LD - 火山官邸] 爆炸大弩箭 16007190")]
        LDVolcanoManorExplosiveGreatbolt = 16007190,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【９】 16007200")]
        LDVolcanoManorGoldenRune9__ = 16007200,

        [Annotation(Name = "[LD - 火山官邸] 失色锻造石【６】 16007210")]
        LDVolcanoManorSomberSmithingStone6 = 16007210,

        [Annotation(Name = "[LD - 火山官邸] 抗火肝脏干 16007220")]
        LDVolcanoManorFireproofDriedLiver_ = 16007220,

        [Annotation(Name = "[LD - 火山官邸] 白金凝血 16007230")]
        LDVolcanoManorAlbinauricBloodclot = 16007230,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【４】 16007240")]
        LDVolcanoManorSmithingStone4 = 16007240,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【６】 16007250")]
        LDVolcanoManorSmithingStone6__ = 16007250,

        [Annotation(Name = "[LD - 火山官邸] 火星蝶 16007270")]
        LDVolcanoManorSmolderingButterfly = 16007270,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【７】 16007280")]
        LDVolcanoManorSmithingStone7 = 16007280,

        [Annotation(Name = "[LD - 火山官邸] 失色锻造石【５】 16007290")]
        LDVolcanoManorSomberSmithingStone5 = 16007290,

        [Annotation(Name = "[LD - 火山官邸] 火星蝶 16007310")]
        LDVolcanoManorSmolderingButterfly_ = 16007310,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【９】 16007320")]
        LDVolcanoManorGoldenRune9___ = 16007320,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【１０】 16007330")]
        LDVolcanoManorGoldenRune10 = 16007330,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【６】 16007350")]
        LDVolcanoManorSmithingStone6___ = 16007350,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【９】 16007360")]
        LDVolcanoManorGoldenRune9____ = 16007360,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【５】 16007380")]
        LDVolcanoManorSmithingStone5 = 16007380,

        [Annotation(Name = "[LD - 火山官邸] 火星蝶 16007390")]
        LDVolcanoManorSmolderingButterfly__ = 16007390,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【１２】 16007400")]
        LDVolcanoManorGoldenRune12 = 16007400,

        [Annotation(Name = "[LD - 火山官邸] 唤勾指药 16007410")]
        LDVolcanoManorFurlcallingFingerRemedy_ = 16007410,

        [Annotation(Name = "[LD - 火山官邸] 野兽血液 16007420")]
        LDVolcanoManorBeastBlood = 16007420,

        [Annotation(Name = "[LD - 火山官邸] 白金杖 16007430")]
        LDVolcanoManorAlbinauricStaff = 16007430,

        [Annotation(Name = "[LD - 火山官邸] 附绳火油脂 16007440")]
        LDVolcanoManorDrawstringFireGrease_ = 16007440,

        [Annotation(Name = "[LD - 火山官邸] 传道士的制作笔记【６】 67130")]
        LDVolcanoManorMissionarysCookbook6 = 67130,

        [Annotation(Name = "[LD - 火山官邸] 红露滴粪金龟 16007480")]
        LDVolcanoManorCrimsonTearScarab = 16007480,

        [Annotation(Name = "[LD - 火山官邸] 石剑钥匙 16007490")]
        LDVolcanoManorStoneswordKey_ = 16007490,

        [Annotation(Name = "[LD - 火山官邸] 卢恩弯弧 16007500")]
        LDVolcanoManorRuneArc = 16007500,

        [Annotation(Name = "[LD - 火山官邸] 居民头巾 16007510")]
        LDVolcanoManorCommonersHeadband = 16007510,

        [Annotation(Name = "[LD - 火山官邸] 蛇人的骨灰 16007520")]
        LDVolcanoManorManSerpentAshes = 16007520,

        [Annotation(Name = "[LD - 火山官邸] 失色锻造石【６】 16007530")]
        LDVolcanoManorSomberSmithingStone6_ = 16007530,

        [Annotation(Name = "[LD - 火山官邸] 红琥珀链坠＋１ 16007540")]
        LDVolcanoManorCrimsonAmberMedallion1 = 16007540,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【６】 16007550")]
        LDVolcanoManorSmithingStone6____ = 16007550,

        [Annotation(Name = "[LD - 火山官邸] 锻造石【４】 16007560")]
        LDVolcanoManorSmithingStone4_ = 16007560,

        [Annotation(Name = "[LD - 火山官邸] 熏烧盾 16007610")]
        LDVolcanoManorSmolderingShield = 16007610,

        [Annotation(Name = "[LD - 火山官邸] 短剑护符 16007620")]
        LDVolcanoManorDaggerTalisman = 16007620,

        [Annotation(Name = "[LD - 火山官邸] 大蛇狩猎矛 16007690")]
        LDVolcanoManorSerpentHunter = 16007690,

        [Annotation(Name = "[LD - 火山官邸] 温床的诅咒 16007700")]
        LDVolcanoManorSeedbedCurse = 16007700,

        [Annotation(Name = "[LD - 火山官邸] 蛇的羊膜 16007710")]
        LDVolcanoManorSerpentsAmnion = 16007710,

        [Annotation(Name = "[LD - 火山官邸] 叛律指头 60260")]
        LDVolcanoManorRecusantFinger = 60260,

        [Annotation(Name = "[LD - 火山官邸] 眼眸筒形外衣 16007730")]
        LDVolcanoManorEyeSurcoat = 16007730,

        [Annotation(Name = "[LD - 火山官邸] 基萨的刺轮 16007940")]
        LDVolcanoManorGhizasWheel = 16007940,

        [Annotation(Name = "[LD - 火山官邸] [祷告] 熔炉百相之喉囊 16007950")]
        LDVolcanoManorIncantationAspectsOfTheCrucibleBreath = 16007950,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【１】 16007991")]
        LDVolcanoManorGoldenRune1 = 16007991,

        [Annotation(Name = "[LD - 火山官邸] 黄金卢恩【１】 16007992")]
        LDVolcanoManorGoldenRune1_ = 16007992,

        [Annotation(Name = "[LD - 火山官邸] 龙心脏 16007999")]
        LDVolcanoManorDragonHeart = 16007999,

        [Annotation(Name = "[LD - 漂流墓地] 兽骨毒飞刀 18007000")]
        LDStrandedGraveyardPoisonboneDart = 18007000,

        [Annotation(Name = "[LD - 漂流墓地] 石剑钥匙 18007010")]
        LDStrandedGraveyardStoneswordKey = 18007010,

        [Annotation(Name = "[LD - 漂流墓地] 黄金卢恩【５】 18007020")]
        LDStrandedGraveyardGoldenRune5 = 18007020,

        [Annotation(Name = "[LD - 漂流墓地] 伤龙油脂 18007030")]
        LDStrandedGraveyardDragonwoundGrease = 18007030,

        [Annotation(Name = "[LD - 漂流墓地] 雷油脂 18007040")]
        LDStrandedGraveyardLightningGrease = 18007040,

        [Annotation(Name = "[LD - 漂流墓地] 黄金树的恩惠 18007050")]
        LDStrandedGraveyardErdtreesFavor = 18007050,

        [Annotation(Name = "[LD - 漂流墓地] 墓地铃兰【１】 18007060")]
        LDStrandedGraveyardGraveGlovewort1 = 18007060,

        [Annotation(Name = "[LD - 漂流墓地] 圣龙徽护符 18007070")]
        LDStrandedGraveyardHaligdrakeTalisman = 18007070,

        [Annotation(Name = "[LD - 漂流墓地] 褪色者勾指 60220")]
        LDStrandedGraveyardTarnishedsFurledFinger = 60220,

        [Annotation(Name = "[LD - 漂流墓地] 断指刀 60310")]
        LDStrandedGraveyardFingerSeverer = 60310,

        [Annotation(Name = "[LD - 漂流墓地] 黄金树大弓 18007900")]
        LDStrandedGraveyardErdtreeGreatbow = 18007900,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野地下墓地] 人骨碎片 30007010")]
        WeepingPeninsulaTombswardCatacombsHumanBoneShard = 30007010,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野地下墓地] 黄金卢恩【２】 30007020")]
        WeepingPeninsulaTombswardCatacombsGoldenRune2 = 30007020,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野地下墓地] 流浪战士的制作笔记【９】 67430")]
        WeepingPeninsulaTombswardCatacombsNomadicWarriorsCookbook9 = 67430,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野地下墓地] 唤声泥颅“谢谢” 30007040")]
        WeepingPeninsulaTombswardCatacombsPrattlingPateThankyou = 30007040,

        [Annotation(Name = "[啜泣半岛 - 穿刺地下墓地] 根脂 30017010")]
        WeepingPeninsulaImpalersCatacombsRootResin = 30017010,

        [Annotation(Name = "[啜泣半岛 - 穿刺地下墓地] 唤声泥颅“救命啊……” 30017020")]
        WeepingPeninsulaImpalersCatacombsPrattlingPatePleasehelp = 30017020,

        [Annotation(Name = "[宁姆格福 - 风暴根脚的地下墓地] 根脂 30027000")]
        LimgraveStormfootCatacombsRootResin = 30027000,

        [Annotation(Name = "[宁姆格福 - 风暴根脚的地下墓地] 火星蝶 30027010")]
        LimgraveStormfootCatacombsSmolderingButterfly = 30027010,

        [Annotation(Name = "[宁姆格福 - 风暴根脚的地下墓地] 徘徊权贵的骨灰 30027020")]
        LimgraveStormfootCatacombsWanderingNobleAshes = 30027020,

        [Annotation(Name = "[宁姆格福 - 风暴根脚的地下墓地] 唤声泥颅“你好” 30027030")]
        LimgraveStormfootCatacombsPrattlingPateHello = 30027030,

        [Annotation(Name = "[湖之利耶尼亚 - 绝路地下墓地] 根脂 30037000")]
        LiurniaRoadsEndCatacombsRootResin = 30037000,

        [Annotation(Name = "[湖之利耶尼亚 - 绝路地下墓地] 雷亚卢卡利亚士兵的骨灰 30037010")]
        LiurniaRoadsEndCatacombsRayaLucariaSoldierAshes = 30037010,

        [Annotation(Name = "[湖之利耶尼亚 - 绝路地下墓地] 人骨碎片 30037020")]
        LiurniaRoadsEndCatacombsHumanBoneShard = 30037020,

        [Annotation(Name = "[湖之利耶尼亚 - 绝路地下墓地] 卢恩弯弧 30037030")]
        LiurniaRoadsEndCatacombsRuneArc = 30037030,

        [Annotation(Name = "[湖之利耶尼亚 - 绝路地下墓地] 看门犬锡杖 30037040")]
        LiurniaRoadsEndCatacombsWatchdogsStaff = 30037040,

        [Annotation(Name = "[宁姆格福 - 蒙流地下墓地] 根脂 30047000")]
        LimgraveMurkwaterCatacombsRootResin = 30047000,

        [Annotation(Name = "[湖之利耶尼亚 - 黑刀地下墓地] 罗泽司的斧 30057000")]
        LiurniaBlackKnifeCatacombsRosusAxe = 30057000,

        [Annotation(Name = "[湖之利耶尼亚 - 黑刀地下墓地] 卢恩弯弧 30057010")]
        LiurniaBlackKnifeCatacombsRuneArc = 30057010,

        [Annotation(Name = "[湖之利耶尼亚 - 黑刀地下墓地] 死根 30057030")]
        LiurniaBlackKnifeCatacombsDeathroot = 30057030,

        [Annotation(Name = "[湖之利耶尼亚 - 黑刀地下墓地] 抗魔肝脏干 30057040")]
        LiurniaBlackKnifeCatacombsSpellproofDriedLiver = 30057040,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 根脂 30067000")]
        LiurniaCliffbottomCatacombsRootResin = 30067000,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 诺克斯镜面盔 30067010")]
        LiurniaCliffbottomCatacombsNoxMirrorhelm = 30067010,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 黄金卢恩【３】 30067020")]
        LiurniaCliffbottomCatacombsGoldenRune3 = 30067020,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 随从的骨灰 30067030")]
        LiurniaCliffbottomCatacombsPageAshes = 30067030,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 卢恩弯弧 30067040")]
        LiurniaCliffbottomCatacombsRuneArc = 30067040,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 古牙 30067050")]
        LiurniaCliffbottomCatacombsOldFang = 30067050,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 粗大兽骨 30067060")]
        LiurniaCliffbottomCatacombsHeftyBeastBone = 30067060,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 大镰刀 30067070")]
        LiurniaCliffbottomCatacombsScythe = 30067070,

        [Annotation(Name = "[湖之利耶尼亚 - 断崖下的地下墓地] 唤声泥颅“太棒了！” 30067080")]
        LiurniaCliffbottomCatacombsPrattlingPateWonderful = 30067080,

        [Annotation(Name = "[格密尔火山 - 威达姆地下墓地] 古龙信徒的制作笔记【１】 68000")]
        MtGelmirWyndhamCatacombsAncientDragonApostlesCookbook1 = 68000,

        [Annotation(Name = "[格密尔火山 - 威达姆地下墓地] 黄金卢恩【５】 30077010")]
        MtGelmirWyndhamCatacombsGoldenRune5 = 30077010,

        [Annotation(Name = "[格密尔火山 - 威达姆地下墓地] 魔力油脂 30077020")]
        MtGelmirWyndhamCatacombsMagicGrease = 30077020,

        [Annotation(Name = "[格密尔火山 - 威达姆地下墓地] 雷对蝎 30077600")]
        MtGelmirWyndhamCatacombsLightningScorpionCharm = 30077600,

        [Annotation(Name = "[格密尔火山 - 威达姆地下墓地] 黄金卢恩【１】 30077900")]
        MtGelmirWyndhamCatacombsGoldenRune1 = 30077900,

        [Annotation(Name = "[亚坛高原 - 尊贵者的英雄墓地] 红种子护符 30087010")]
        AltusPlateauSaintedHerosGraveCrimsonSeedTalisman = 30087010,

        [Annotation(Name = "[亚坛高原 - 尊贵者的英雄墓地] 罗德尔士兵的骨灰 30087020")]
        AltusPlateauSaintedHerosGraveLeyndellSoldierAshes = 30087020,

        [Annotation(Name = "[亚坛高原 - 尊贵者的英雄墓地] 龙徽盾护符＋１ 30087030")]
        AltusPlateauSaintedHerosGraveDragoncrestShieldTalisman1 = 30087030,

        [Annotation(Name = "[亚坛高原 - 尊贵者的英雄墓地] 根脂 30087040")]
        AltusPlateauSaintedHerosGraveRootResin = 30087040,

        [Annotation(Name = "[亚坛高原 - 尊贵者的英雄墓地] 唤声泥颅“我们开始吧” 30087050")]
        AltusPlateauSaintedHerosGravePrattlingPateLetsgettoit = 30087050,

        [Annotation(Name = "[亚坛高原 - 尊贵者的英雄墓地] 人骨碎片 30087060")]
        AltusPlateauSaintedHerosGraveHumanBoneShard = 30087060,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 死根 30097000")]
        MtGelmirGelmirHerosGraveDeathroot = 30097000,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 戒指指头 30097010")]
        MtGelmirGelmirHerosGraveRingedFinger = 30097010,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 黄金卢恩【６】 30097020")]
        MtGelmirGelmirHerosGraveGoldenRune6 = 30097020,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 火星蝶 30097030")]
        MtGelmirGelmirHerosGraveSmolderingButterfly = 30097030,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 石剑钥匙 30097040")]
        MtGelmirGelmirHerosGraveStoneswordKey = 30097040,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 格密尔骑士头盔 30097050")]
        MtGelmirGelmirHerosGraveGelmirKnightHelm = 30097050,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 根脂 30097060")]
        MtGelmirGelmirHerosGraveRootResin = 30097060,

        [Annotation(Name = "[格密尔火山 - 格密尔英雄墓地] 野兽血液 30097070")]
        MtGelmirGelmirHerosGraveBeastBlood = 30097070,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 圣油脂 30107010")]
        CapitalOutskirtsAurizaHerosGraveHolyGrease = 30107010,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 扇形暗器 30107020")]
        CapitalOutskirtsAurizaHerosGraveFanDaggers = 30107020,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 黄金卢恩【７】 30107030")]
        CapitalOutskirtsAurizaHerosGraveGoldenRune7 = 30107030,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 熔炉羽护符 30107040")]
        CapitalOutskirtsAurizaHerosGraveCrucibleFeatherTalisman = 30107040,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 黄金墓碑 30107050")]
        CapitalOutskirtsAurizaHerosGraveGoldenEpitaph = 30107050,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 大蜻蜓头部 30107060")]
        CapitalOutskirtsAurizaHerosGraveGreatDragonflyHead = 30107060,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 石剑钥匙 30107070")]
        CapitalOutskirtsAurizaHerosGraveStoneswordKey = 30107070,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 恶兵的骨灰 30107080")]
        CapitalOutskirtsAurizaHerosGraveVulgarMilitiaAshes = 30107080,

        [Annotation(Name = "[王城城墙外 - 亚雷萨英雄墓地] 战灰：圣域 30107100")]
        CapitalOutskirtsAurizaHerosGraveAshOfWarHolyGround = 30107100,

        [Annotation(Name = "[风暴山丘 - 死亡降临的地下墓地] 死根 30117000")]
        StormhillDeathtouchedCatacombsDeathroot = 30117000,

        [Annotation(Name = "[风暴山丘 - 死亡降临的地下墓地] 血蔷薇 30117010")]
        StormhillDeathtouchedCatacombsBloodrose = 30117010,

        [Annotation(Name = "[风暴山丘 - 死亡降临的地下墓地] 打刀 30117020")]
        StormhillDeathtouchedCatacombsUchigatana = 30117020,

        [Annotation(Name = "[亚坛高原 - 丑恶地下墓地] 圣油脂 30127000")]
        AltusPlateauUnsightlyCatacombsHolyGrease = 30127000,

        [Annotation(Name = "[亚坛高原 - 丑恶地下墓地] 带翼混种的骨灰 30127010")]
        AltusPlateauUnsightlyCatacombsWingedMisbegottenAshes = 30127010,

        [Annotation(Name = "[亚坛高原 - 丑恶地下墓地] 卢恩弯弧 30127020")]
        AltusPlateauUnsightlyCatacombsRuneArc = 30127020,

        [Annotation(Name = "[亚坛高原 - 丑恶地下墓地] 唤声泥颅“对不起” 30127030")]
        AltusPlateauUnsightlyCatacombsPrattlingPateApologies = 30127030,

        [Annotation(Name = "[亚坛高原 - 丑恶地下墓地] 黄金卢恩【１】 30127900")]
        AltusPlateauUnsightlyCatacombsGoldenRune1 = 30127900,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 调香师的制作笔记【３】 67860")]
        CapitalOutskirtsAurizaSideTombPerfumersCookbook3 = 67860,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 黄金卢恩【７】 30137020")]
        CapitalOutskirtsAurizaSideTombGoldenRune7 = 30137020,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 锻造石【５】 30137030")]
        CapitalOutskirtsAurizaSideTombSmithingStone5 = 30137030,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 根脂 30137040")]
        CapitalOutskirtsAurizaSideTombRootResin = 30137040,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 龟裂壶 66140")]
        CapitalOutskirtsAurizaSideTombCrackedPot = 66140,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 龟裂壶 66150")]
        CapitalOutskirtsAurizaSideTombCrackedPot_ = 66150,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 龟裂壶 66160")]
        CapitalOutskirtsAurizaSideTombCrackedPot__ = 66160,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 龟裂壶 66170")]
        CapitalOutskirtsAurizaSideTombCrackedPot___ = 66170,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 仪式壶 66470")]
        CapitalOutskirtsAurizaSideTombRitualPot = 66470,

        [Annotation(Name = "[王城城墙外 - 亚雷萨副墓地] 仪式壶 66480")]
        CapitalOutskirtsAurizaSideTombRitualPot_ = 66480,

        [Annotation(Name = "[盖利德 - 小黄金树地下墓地] 小恶魔头罩（狼） 30147000")]
        CaelidMinorErdtreeCatacombsImpHeadWolf = 30147000,

        [Annotation(Name = "[盖利德 - 小黄金树地下墓地] 墓地紫花 30147010")]
        CaelidMinorErdtreeCatacombsGraveViolet = 30147010,

        [Annotation(Name = "[盖利德 - 小黄金树地下墓地] 圣血木芽 30147020")]
        CaelidMinorErdtreeCatacombsSacramentalBud = 30147020,

        [Annotation(Name = "[盖利德 - 小黄金树地下墓地] 艾奥尼亚蝶 30147030")]
        CaelidMinorErdtreeCatacombsAeonianButterfly = 30147030,

        [Annotation(Name = "[盖利德 - 小黄金树地下墓地] 黄金卢恩【４】 30147040")]
        CaelidMinorErdtreeCatacombsGoldenRune4 = 30147040,

        [Annotation(Name = "[盖利德 - 小黄金树地下墓地] 黄金卢恩【１】 30147900")]
        CaelidMinorErdtreeCatacombsGoldenRune1 = 30147900,

        [Annotation(Name = "[盖利德 - 盖利德地下墓地] 小米兰达的骨灰 30157000")]
        CaelidCaelidCatacombsMirandaSproutAshes = 30157000,

        [Annotation(Name = "[盖利德 - 英灵地下墓地] 黄金卢恩【６】 30167000")]
        CaelidWarDeadCatacombsGoldenRune6 = 30167000,

        [Annotation(Name = "[盖利德 - 英灵地下墓地] 魔力油脂 30167010")]
        CaelidWarDeadCatacombsMagicGrease = 30167010,

        [Annotation(Name = "[盖利德 - 英灵地下墓地] 拉塔恩士兵的骨灰 30167020")]
        CaelidWarDeadCatacombsRadahnSoldierAshes = 30167020,

        [Annotation(Name = "[盖利德 - 英灵地下墓地] 腌制白银鸟爪 30167030")]
        CaelidWarDeadCatacombsSilverPickledFowlFoot = 30167030,

        [Annotation(Name = "[盖利德 - 英灵地下墓地] [魔法] 碎星 30167040")]
        CaelidWarDeadCatacombsSorceryCollapsingStars = 30167040,

        [Annotation(Name = "[火焰之巅 - 巨人战争的英雄墓地] 尊容烛台 30177000")]
        FlamePeakGiantConqueringHerosGraveCranialVesselCandlestand = 30177000,

        [Annotation(Name = "[火焰之巅 - 巨人战争的英雄墓地] [祷告] 火焰的庇佑啊 30177010")]
        FlamePeakGiantConqueringHerosGraveIncantationFlame = 30177010,

        [Annotation(Name = "[火焰之巅 - 巨人战争的英雄墓地] 雷电混种大剑 30177020")]
        FlamePeakGiantConqueringHerosGraveLightningBastardSword = 30177020,

        [Annotation(Name = "[火焰之巅 - 巨人战争的英雄墓地] 巨人圣印记 30177030")]
        FlamePeakGiantConqueringHerosGraveGiantsSeal = 30177030,

        [Annotation(Name = "[火焰之巅 - 巨人战争的英雄墓地] 结冰油脂 30177040")]
        FlamePeakGiantConqueringHerosGraveFreezingGrease = 30177040,

        [Annotation(Name = "[火焰之巅 - 巨人战争的英雄墓地] 黄金卢恩【１１】 30177050")]
        FlamePeakGiantConqueringHerosGraveGoldenRune11 = 30177050,

        [Annotation(Name = "[火焰之巅 - 巨人战争的英雄墓地] 黄金卢恩【１】 30177060")]
        FlamePeakGiantConqueringHerosGraveGoldenRune1 = 30177060,

        [Annotation(Name = "[火焰之巅 - 巨人山顶地下墓地] 黄金卢恩【１０】 30187000")]
        FlamePeakGiantsMountaintopCatacombsGoldenRune10 = 30187000,

        [Annotation(Name = "[火焰之巅 - 巨人山顶地下墓地] 催眠苔药 30187010")]
        FlamePeakGiantsMountaintopCatacombsStimulatingBoluses = 30187010,

        [Annotation(Name = "[火焰之巅 - 巨人山顶地下墓地] 蜕生蝶 30187020")]
        FlamePeakGiantsMountaintopCatacombsNascentButterfly = 30187020,

        [Annotation(Name = "[火焰之巅 - 巨人山顶地下墓地] 根脂 30187030")]
        FlamePeakGiantsMountaintopCatacombsRootResin = 30187030,

        [Annotation(Name = "[火焰之巅 - 巨人山顶地下墓地] 仪式壶 66400")]
        FlamePeakGiantsMountaintopCatacombsRitualPot = 66400,

        [Annotation(Name = "[火焰之巅 - 巨人山顶地下墓地] 火焰习武修士的骨灰 30187070")]
        FlamePeakGiantsMountaintopCatacombsFireMonkAshes = 30187070,

        [Annotation(Name = "[火焰之巅 - 巨人山顶地下墓地] 死根 30187900")]
        FlamePeakGiantsMountaintopCatacombsDeathroot = 30187900,

        [Annotation(Name = "[火焰之巅 - 化圣雪原地下墓地] 黄金卢恩【１２】 30197000")]
        FlamePeakConsecratedSnowfieldCatacombsGoldenRune12 = 30197000,

        [Annotation(Name = "[火焰之巅 - 化圣雪原地下墓地] 死亡苔药 30197010")]
        FlamePeakConsecratedSnowfieldCatacombsRejuvenatingBoluses = 30197010,

        [Annotation(Name = "[火焰之巅 - 化圣雪原地下墓地] 根脂 30197020")]
        FlamePeakConsecratedSnowfieldCatacombsRootResin = 30197020,

        [Annotation(Name = "[火焰之巅 - 化圣雪原地下墓地] 人骨碎片 30197030")]
        FlamePeakConsecratedSnowfieldCatacombsHumanBoneShard = 30197030,

        [Annotation(Name = "[火焰之巅 - 化圣雪原地下墓地] 小恶魔头罩（长老） 30197040")]
        FlamePeakConsecratedSnowfieldCatacombsImpHeadElder = 30197040,

        [Annotation(Name = "[火焰之巅 - 化圣雪原地下墓地] 黄金卢恩【１】 30197900")]
        FlamePeakConsecratedSnowfieldCatacombsGoldenRune1 = 30197900,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 温热石 30207000")]
        ForbiddenLandsHiddenPathtoTheHaligtreeWarmingStone = 30207000,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 圣血木芽 30207010")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSacramentalBud = 30207010,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 英雄卢恩【１】 30207020")]
        ForbiddenLandsHiddenPathtoTheHaligtreeHerosRune1 = 30207020,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 古牙 30207030")]
        ForbiddenLandsHiddenPathtoTheHaligtreeOldFang = 30207030,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 根脂 30207040")]
        ForbiddenLandsHiddenPathtoTheHaligtreeRootResin = 30207040,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 结冰油脂 30207050")]
        ForbiddenLandsHiddenPathtoTheHaligtreeFreezingGrease = 30207050,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 魔力龙徽护符＋２ 30207060")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSpelldrakeTalisman2 = 30207060,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 银色粪金龟 30207900")]
        ForbiddenLandsHiddenPathtoTheHaligtreeSilverScarab = 30207900,

        [Annotation(Name = "[禁域 - 通往圣树的密道] 死根 30207910")]
        ForbiddenLandsHiddenPathtoTheHaligtreeDeathroot = 30207910,

        [Annotation(Name = "[宁姆格福 - 蒙流洞窟] 蘑菇 31007000")]
        LimgraveMurkwaterCaveMushroom = 31007000,

        [Annotation(Name = "[宁姆格福 - 蒙流洞窟] 布质上衣 31007010")]
        LimgraveMurkwaterCaveClothGarb = 31007010,

        [Annotation(Name = "[啜泣半岛 - 垂穴洞窟] 黄金卢恩【１】 31017000")]
        WeepingPeninsulaEarthboreCaveGoldenRune1 = 31017000,

        [Annotation(Name = "[啜泣半岛 - 垂穴洞窟] 照明石 31017010")]
        WeepingPeninsulaEarthboreCaveGlowstone = 31017010,

        [Annotation(Name = "[啜泣半岛 - 垂穴洞窟] 廓尔喀弯刀 31017020")]
        WeepingPeninsulaEarthboreCaveKukri = 31017020,

        [Annotation(Name = "[啜泣半岛 - 垂穴洞窟] 火星蝶 31017030")]
        WeepingPeninsulaEarthboreCaveSmolderingButterfly = 31017030,

        [Annotation(Name = "[啜泣半岛 - 垂穴洞窟] 托莉娜睡莲 31017040")]
        WeepingPeninsulaEarthboreCaveTrinasLily = 31017040,

        [Annotation(Name = "[啜泣半岛 - 垂穴洞窟] 腌制龟颈肉 31017060")]
        WeepingPeninsulaEarthboreCavePickledTurtleNeck = 31017060,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野洞窟] 黄金卢恩【２】 31027000")]
        WeepingPeninsulaTombswardCaveGoldenRune2 = 31027000,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野洞窟] 唤勾指药 31027010")]
        WeepingPeninsulaTombswardCaveFurlcallingFingerRemedy = 31027010,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野洞窟] 兽骨毒飞刀 31027020")]
        WeepingPeninsulaTombswardCavePoisonboneDart = 31027020,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野洞窟] 亚缇莉亚叶 31027030")]
        WeepingPeninsulaTombswardCaveArteriaLeaf = 31027030,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野洞窟] 流浪战士的制作笔记【８】 67880")]
        WeepingPeninsulaTombswardCaveNomadicWarriorsCookbook8 = 67880,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野洞窟] 免疫白肉干 31027050")]
        WeepingPeninsulaTombswardCaveImmunizingWhiteCuredMeat = 31027050,

        [Annotation(Name = "[宁姆格福 - 近林洞窟] 黄金卢恩【１】 31037000")]
        LimgraveGrovesideCaveGoldenRune1 = 31037000,

        [Annotation(Name = "[宁姆格福 - 近林洞窟] 照明石 31037010")]
        LimgraveGrovesideCaveGlowstone = 31037010,

        [Annotation(Name = "[宁姆格福 - 近林洞窟] 龟裂壶 66000")]
        LimgraveGrovesideCaveCrackedPot = 66000,

        [Annotation(Name = "[湖之利耶尼亚 - 留水洞窟] 黄金卢恩【３】 31047000")]
        LiurniaStillwaterCaveGoldenRune3 = 31047000,

        [Annotation(Name = "[湖之利耶尼亚 - 留水洞窟] 黄金卢恩【４】 31047010")]
        LiurniaStillwaterCaveGoldenRune4 = 31047010,

        [Annotation(Name = "[湖之利耶尼亚 - 留水洞窟] 飞蛇毒箭 31047020")]
        LiurniaStillwaterCaveSerpentArrow = 31047020,

        [Annotation(Name = "[湖之利耶尼亚 - 留水洞窟] 黄金卢恩【５】 31047030")]
        LiurniaStillwaterCaveGoldenRune5 = 31047030,

        [Annotation(Name = "[湖之利耶尼亚 - 留水洞窟] 照明石 31047040")]
        LiurniaStillwaterCaveGlowstone = 31047040,

        [Annotation(Name = "[湖之利耶尼亚 - 留水洞窟] 中毒油脂 31047050")]
        LiurniaStillwaterCavePoisonGrease = 31047050,

        [Annotation(Name = "[湖之利耶尼亚 - 留水洞窟] 贤者风帽 31047060")]
        LiurniaStillwaterCaveSageHood = 31047060,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 粗大兽骨 31057000")]
        LiurniaLakesideCrystalCaveHeftyBeastBone = 31057000,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 投掷匕首 31057010")]
        LiurniaLakesideCrystalCaveThrowingDagger = 31057010,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 黄金卢恩【５】 31057020")]
        LiurniaLakesideCrystalCaveGoldenRune5 = 31057020,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 柔软棉花 31057030")]
        LiurniaLakesideCrystalCaveSoftCotton = 31057030,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 锻造石【４】 31057040")]
        LiurniaLakesideCrystalCaveSmithingStone4 = 31057040,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 锻造石【２】 31057050")]
        LiurniaLakesideCrystalCaveSmithingStone2 = 31057050,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 野兽肉块 31057060")]
        LiurniaLakesideCrystalCaveLumpOfFlesh = 31057060,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 亚缇莉亚叶 31057070")]
        LiurniaLakesideCrystalCaveArteriaLeaf = 31057070,

        [Annotation(Name = "[湖之利耶尼亚 - 湖旁结晶洞窟] 矛护符 31057100")]
        LiurniaLakesideCrystalCaveSpearTalisman = 31057100,

        [Annotation(Name = "[湖之利耶尼亚 - 学院结晶洞窟] 杜鹃辉石 31067000")]
        LiurniaAcademyCrystalCaveCuckooGlintstone = 31067000,

        [Annotation(Name = "[湖之利耶尼亚 - 学院结晶洞窟] 石剑钥匙 31067010")]
        LiurniaAcademyCrystalCaveStoneswordKey = 31067010,

        [Annotation(Name = "[湖之利耶尼亚 - 学院结晶洞窟] 卢恩弯弧 31067100")]
        LiurniaAcademyCrystalCaveRuneArc = 31067100,

        [Annotation(Name = "[湖之利耶尼亚 - 学院结晶洞窟] 结晶杖 31067030")]
        LiurniaAcademyCrystalCaveCrystalStaff = 31067030,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 中毒油脂 31077000")]
        MtGelmirSeethewaterCavePoisonGrease = 31077000,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 野兽肉块 31077010")]
        MtGelmirSeethewaterCaveLumpOfFlesh = 31077010,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 腐败苔药 31077020")]
        MtGelmirSeethewaterCavePreservingBoluses = 31077020,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 蘑菇头部 31077030")]
        MtGelmirSeethewaterCaveMushroomHead = 31077030,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 兽骨毒飞刀 31077040")]
        MtGelmirSeethewaterCavePoisonboneDart = 31077040,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 黄金卢恩【６】 31077050")]
        MtGelmirSeethewaterCaveGoldenRune6 = 31077050,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 黄金卢恩【７】 31077060")]
        MtGelmirSeethewaterCaveGoldenRune7 = 31077060,

        [Annotation(Name = "[格密尔火山 - 沸滚河洞窟] 免疫肉干 31077070")]
        MtGelmirSeethewaterCaveImmunizingCuredMeat = 31077070,

        [Annotation(Name = "[格密尔火山 - 火山洞窟] 黄金卢恩【６】 31097000")]
        MtGelmirVolcanoCaveGoldenRune6 = 31097000,

        [Annotation(Name = "[格密尔火山 - 火山洞窟] 肉片 31097010")]
        MtGelmirVolcanoCaveSliverOfMeat = 31097010,

        [Annotation(Name = "[格密尔火山 - 火山洞窟] 亚缇莉亚叶 31097020")]
        MtGelmirVolcanoCaveArteriaLeaf = 31097020,

        [Annotation(Name = "[格密尔火山 - 火山洞窟] 野兽肉块 31097030")]
        MtGelmirVolcanoCaveLumpOfFlesh = 31097030,

        [Annotation(Name = "[格密尔火山 - 火山洞窟] 盘蛇盾 31097040")]
        MtGelmirVolcanoCaveCoilShield = 31097040,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 调香瓶 66780")]
        AltusPlateauPerfumersGrottoPerfumeBottle = 66780,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 活壶碎片 31187020")]
        AltusPlateauPerfumersGrottoLivingJarShard = 31187020,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 活壶碎片 31187030")]
        AltusPlateauPerfumersGrottoLivingJarShard_ = 31187030,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 亚缇莉亚叶 31187040")]
        AltusPlateauPerfumersGrottoArteriaLeaf = 31187040,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 黄金卢恩【５】 31187050")]
        AltusPlateauPerfumersGrottoGoldenRune5 = 31187050,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 米兰达花粉 31187060")]
        AltusPlateauPerfumersGrottoMirandaPowder = 31187060,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 温热石 31187070")]
        AltusPlateauPerfumersGrottoWarmingStone = 31187070,

        [Annotation(Name = "[亚坛高原 - 调香师的隐藏洞窟] 黄金卢恩【５】 31187080")]
        AltusPlateauPerfumersGrottoGoldenRune5_ = 31187080,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 死亡苔药 31197000")]
        AltusPlateauSagesCaveRejuvenatingBoluses = 31197000,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 失力战灰 31197010")]
        AltusPlateauSagesCaveLostAshesOfWar = 31197010,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 烛树纹木盾 31197030")]
        AltusPlateauSagesCaveCandletreeWoodenShield = 31197030,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 腌制白银鸟爪 31197040")]
        AltusPlateauSagesCaveSilverPickledFowlFoot = 31197040,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 黑布风帽 31197050")]
        AltusPlateauSagesCaveBlackHood = 31197050,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 蜕生蝶 31197060")]
        AltusPlateauSagesCaveNascentButterfly = 31197060,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 石剑钥匙 31197080")]
        AltusPlateauSagesCaveStoneswordKey = 31197080,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 伤龙油脂 31197090")]
        AltusPlateauSagesCaveDragonwoundGrease = 31197090,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 猛禽钩爪 31197100")]
        AltusPlateauSagesCaveRaptorTalons = 31197100,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 黄金大箭 31197110")]
        AltusPlateauSagesCaveGoldenGreatArrow = 31197110,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 猛禽黑羽 31197120")]
        AltusPlateauSagesCaveRaptorsBlackFeathers = 31197120,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 亡骨面具 31197130")]
        AltusPlateauSagesCaveSkeletalMask = 31197130,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 黄金卢恩【５】 31197200")]
        AltusPlateauSagesCaveGoldenRune5 = 31197200,

        [Annotation(Name = "[亚坛高原 - 贤者的洞窟] 黄金卢恩【５】 31197210")]
        AltusPlateauSagesCaveGoldenRune5_ = 31197210,

        [Annotation(Name = "[桂奥尔龙墓 - 龙墓洞窟] 温热石 31107000")]
        GreyollsDragonbarrowDragonbarrowCaveWarmingStone = 31107000,

        [Annotation(Name = "[桂奥尔龙墓 - 龙墓洞窟] 黄金卢恩【１２】 31107010")]
        GreyollsDragonbarrowDragonbarrowCaveGoldenRune12 = 31107010,

        [Annotation(Name = "[桂奥尔龙墓 - 龙墓洞窟] 大山羊护符 31107050")]
        GreyollsDragonbarrowDragonbarrowCaveBullGoatsTalisman = 31107050,

        [Annotation(Name = "[桂奥尔龙墓 - 龙墓洞窟] 黄金卢恩【８】 31107110")]
        GreyollsDragonbarrowDragonbarrowCaveGoldenRune8 = 31107110,

        [Annotation(Name = "[桂奥尔龙墓 - 龙墓洞窟] 野兽血液 31107120")]
        GreyollsDragonbarrowDragonbarrowCaveBeastBlood = 31107120,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 黄金卢恩【３】 31117000")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune3 = 31117000,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 失力战灰 31117010")]
        GreyollsDragonbarrowSelliaHideawayLostAshesOfWar = 31117010,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 黄金卢恩【５】 31117020")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune5 = 31117020,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 催眠苔药 31117030")]
        GreyollsDragonbarrowSelliaHideawayStimulatingBoluses = 31117030,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 失色锻造石【４】 31117040")]
        GreyollsDragonbarrowSelliaHideawaySomberSmithingStone4 = 31117040,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 腐败苔药 31117080")]
        GreyollsDragonbarrowSelliaHideawayPreservingBoluses = 31117080,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 结晶飞刀 31117090")]
        GreyollsDragonbarrowSelliaHideawayCrystalDart = 31117090,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 黄金卢恩【５】 31117100")]
        GreyollsDragonbarrowSelliaHideawayGoldenRune5_ = 31117100,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 照明石 31117110")]
        GreyollsDragonbarrowSelliaHideawayGlowstone = 31117110,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 结晶矛 31117200")]
        GreyollsDragonbarrowSelliaHideawayCrystalSpear = 31117200,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 结晶人的骨灰 31117220")]
        GreyollsDragonbarrowSelliaHideawayCrystalianAshes = 31117220,

        [Annotation(Name = "[桂奥尔龙墓 - 瑟利亚隐藏洞窟] 锻造石【１】 31117300")]
        GreyollsDragonbarrowSelliaHideawaySmithingStone1 = 31117300,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 黄金卢恩【７】 31127000")]
        ConsecratedSnowfieldCaveOfTheForlornGoldenRune7 = 31127000,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 结冰油脂 31127010")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease = 31127010,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 英雄卢恩【２】 31127020")]
        ConsecratedSnowfieldCaveOfTheForlornHerosRune2 = 31127020,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 卢恩弯弧 31127030")]
        ConsecratedSnowfieldCaveOfTheForlornRuneArc = 31127030,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 米凯拉睡莲 31127040")]
        ConsecratedSnowfieldCaveOfTheForlornMiquellasLily = 31127040,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 蜕生蝶 31127050")]
        ConsecratedSnowfieldCaveOfTheForlornNascentButterfly = 31127050,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 冻伤苔药 31127060")]
        ConsecratedSnowfieldCaveOfTheForlornThawfrostBoluses = 31127060,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 结晶飞刀 31127070")]
        ConsecratedSnowfieldCaveOfTheForlornCrystalDart = 31127070,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 冻伤苔药 31127080")]
        ConsecratedSnowfieldCaveOfTheForlornThawfrostBoluses_ = 31127080,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 结冰油脂 31127090")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease_ = 31127090,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 结冰油脂 31127100")]
        ConsecratedSnowfieldCaveOfTheForlornFreezingGrease__ = 31127100,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 黄金卢恩【１０】 31127110")]
        ConsecratedSnowfieldCaveOfTheForlornGoldenRune10 = 31127110,

        [Annotation(Name = "[化圣雪原 - 安身洞窟] 灵火箭 31127120")]
        ConsecratedSnowfieldCaveOfTheForlornSpiritflameArrow = 31127120,

        [Annotation(Name = "[宁姆格福 - 海岸洞窟] 章鱼卵 31157010")]
        LimgraveCoastalCaveLandOctopusOvary = 31157010,

        [Annotation(Name = "[宁姆格福 - 海岸洞窟] 火星蝶 31157020")]
        LimgraveCoastalCaveSmolderingButterfly = 31157020,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 黄金卢恩【１】 31177010")]
        LimgraveHighroadCaveGoldenRune1 = 31177010,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 亚缇莉亚叶 31177020")]
        LimgraveHighroadCaveArteriaLeaf = 31177020,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 锻造石【１】 31177030")]
        LimgraveHighroadCaveSmithingStone1 = 31177030,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 锻造石【２】 31177040")]
        LimgraveHighroadCaveSmithingStone2 = 31177040,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 黄金卢恩【４】 31177050")]
        LimgraveHighroadCaveGoldenRune4 = 31177050,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 火油脂 31177060")]
        LimgraveHighroadCaveFireGrease = 31177060,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 唤勾指药 31177070")]
        LimgraveHighroadCaveFurlcallingFingerRemedy = 31177070,

        [Annotation(Name = "[宁姆格福 - 大道下的洞窟] 赛施尔长刀 31177080")]
        LimgraveHighroadCaveShamshir = 31177080,

        [Annotation(Name = "[盖利德 - 废弃洞窟] 伤龙油脂 31207000")]
        CaelidAbandonedCaveDragonwoundGrease = 31207000,

        [Annotation(Name = "[盖利德 - 废弃洞窟] 毒蛇牙 31207010")]
        CaelidAbandonedCaveVenomousFang = 31207010,

        [Annotation(Name = "[盖利德 - 废弃洞窟] 蛇弓 31207020")]
        CaelidAbandonedCaveSerpentBow = 31207020,

        [Annotation(Name = "[盖利德 - 废弃洞窟] 火油脂 31207030")]
        CaelidAbandonedCaveFireGrease = 31207030,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 黄金卢恩【２】 31217000")]
        CaelidGaolCaveGoldenRune2 = 31217000,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 黄金卢恩【２】 31217030")]
        CaelidGaolCaveGoldenRune2_ = 31217030,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 古牙 31217040")]
        CaelidGaolCaveOldFang = 31217040,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 黄金卢恩【２】 31217070")]
        CaelidGaolCaveGoldenRune2__ = 31217070,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 黄金卢恩【４】 31217080")]
        CaelidGaolCaveGoldenRune4 = 31217080,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 石剑钥匙 31217090")]
        CaelidGaolCaveStoneswordKey = 31217090,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 胁差 31217100")]
        CaelidGaolCaveWakizashi = 31217100,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 黄金卢恩【４】 31217110")]
        CaelidGaolCaveGoldenRune4_ = 31217110,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 龟颈肉块 31217120")]
        CaelidGaolCaveTurtleNeckMeat = 31217120,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 黄金卢恩【５】 31217140")]
        CaelidGaolCaveGoldenRune5 = 31217140,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 虹彩石 31217150")]
        CaelidGaolCaveRainbowStone = 31217150,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 黄金卢恩【４】 31217160")]
        CaelidGaolCaveGoldenRune4__ = 31217160,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 照明石 31217190")]
        CaelidGaolCaveGlowstone = 31217190,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 失色锻造石【５】 31217200")]
        CaelidGaolCaveSomberSmithingStone5 = 31217200,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 枷锁盾 31217210")]
        CaelidGaolCavePilloryShield = 31217210,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 欧赫宝剑 31217350")]
        CaelidGaolCaveRegaliaOfEochaid = 31217350,

        [Annotation(Name = "[盖利德 - 牢狱洞窟] 卢恩弯弧 31217400")]
        CaelidGaolCaveRuneArc = 31217400,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 待殓铠甲 31227000")]
        MountaintopsOfTheGiantsSpiritcallersCaveWhiteReedArmor = 31227000,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 黄金卢恩【６】 31227010")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune6 = 31227010,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 黄金卢恩【１２】 31227020")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune12 = 31227020,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 结冰油脂 31227030")]
        MountaintopsOfTheGiantsSpiritcallersCaveFreezingGrease = 31227030,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 黄金卢恩【１０】 31227040")]
        MountaintopsOfTheGiantsSpiritcallersCaveGoldenRune10 = 31227040,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 英雄卢恩【１】 31227050")]
        MountaintopsOfTheGiantsSpiritcallersCaveHerosRune1 = 31227050,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 卢恩弯弧 31227060")]
        MountaintopsOfTheGiantsSpiritcallersCaveRuneArc = 31227060,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 健壮白肉干 31227070")]
        MountaintopsOfTheGiantsSpiritcallersCaveInvigoratingWhiteCuredMeat = 31227070,

        [Annotation(Name = "[巨人山顶 - 唤灵洞窟] 亚缇莉亚叶 31227080")]
        MountaintopsOfTheGiantsSpiritcallersCaveArteriaLeaf = 31227080,

        [Annotation(Name = "[啜泣半岛 - 摩恩坑道] 黄金卢恩【２】 32007000")]
        WeepingPeninsulaMorneTunnelGoldenRune2 = 32007000,

        [Annotation(Name = "[啜泣半岛 - 摩恩坑道] 黄金卢恩【４】 32007010")]
        WeepingPeninsulaMorneTunnelGoldenRune4 = 32007010,

        [Annotation(Name = "[啜泣半岛 - 摩恩坑道] 大块崩裂辉石 32007020")]
        WeepingPeninsulaMorneTunnelLargeGlintstoneScrap = 32007020,

        [Annotation(Name = "[啜泣半岛 - 摩恩坑道] 出血苔药 32007030")]
        WeepingPeninsulaMorneTunnelStanchingBoluses = 32007030,

        [Annotation(Name = "[啜泣半岛 - 摩恩坑道] 柔软棉花 32007060")]
        WeepingPeninsulaMorneTunnelSoftCotton = 32007060,

        [Annotation(Name = "[啜泣半岛 - 摩恩坑道] 亚缇莉亚叶 32007070")]
        WeepingPeninsulaMorneTunnelArteriaLeaf = 32007070,

        [Annotation(Name = "[啜泣半岛 - 摩恩坑道] 勇者肉块 32007900")]
        WeepingPeninsulaMorneTunnelExaltedFlesh = 32007900,

        [Annotation(Name = "[宁姆格福 - 宁姆格福坑道] 锻造石【１】 32017000")]
        LimgraveLimgraveTunnelsSmithingStone1 = 32017000,

        [Annotation(Name = "[宁姆格福 - 宁姆格福坑道] 黄金卢恩【４】 32017010")]
        LimgraveLimgraveTunnelsGoldenRune4 = 32017010,

        [Annotation(Name = "[宁姆格福 - 宁姆格福坑道] 大块崩裂辉石 32017020")]
        LimgraveLimgraveTunnelsLargeGlintstoneScrap = 32017020,

        [Annotation(Name = "[宁姆格福 - 宁姆格福坑道] 黄金卢恩【１】 32017030")]
        LimgraveLimgraveTunnelsGoldenRune1 = 32017030,

        [Annotation(Name = "[宁姆格福 - 宁姆格福坑道] 崩裂辉石 32017040")]
        LimgraveLimgraveTunnelsGlintstoneScrap = 32017040,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] 失色锻造石【２】 32027000")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone2 = 32027000,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] 失色锻造石【３】 32027010")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone3 = 32027010,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] 黄金卢恩【３】 32027020")]
        LiurniaRayaLucariaCrystalTunnelGoldenRune3 = 32027020,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] 锻造石【３】 32027030")]
        LiurniaRayaLucariaCrystalTunnelSmithingStone3 = 32027030,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] 失色锻造石【３】 32027040")]
        LiurniaRayaLucariaCrystalTunnelSomberSmithingStone3_ = 32027040,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] 锻造石【１】 32027060")]
        LiurniaRayaLucariaCrystalTunnelSmithingStone1 = 32027060,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] [魔法] 爆碎岩盘 32027070")]
        LiurniaRayaLucariaCrystalTunnelSorceryShatterEarth = 32027070,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚结晶坑道] 结晶小刀 32027900")]
        LiurniaRayaLucariaCrystalTunnelCrystalKnife = 32027900,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道] 黄金卢恩【６】 32047000")]
        AltusPlateauOldAltusTunnelGoldenRune6 = 32047000,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道] 出血苔药 32047010")]
        AltusPlateauOldAltusTunnelStanchingBoluses = 32047010,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道] 失色锻造石【４】 32047020")]
        AltusPlateauOldAltusTunnelSomberSmithingStone4 = 32047020,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道] 爆炸石块 32047030")]
        AltusPlateauOldAltusTunnelExplosiveStoneClump = 32047030,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道] 雷龙徽护符＋１ 32047040")]
        AltusPlateauOldAltusTunnelBoltdrakeTalisman1 = 32047040,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道] 山妖大槌 32047050")]
        AltusPlateauOldAltusTunnelTrollsHammer = 32047050,

        [Annotation(Name = "[亚坛高原 - 亚坛坑道] 结晶飞刀 32057000")]
        AltusPlateauAltusTunnelCrystalDart = 32057000,

        [Annotation(Name = "[亚坛高原 - 亚坛坑道] 亚缇莉亚叶 32057010")]
        AltusPlateauAltusTunnelArteriaLeaf = 32057010,

        [Annotation(Name = "[亚坛高原 - 亚坛坑道] 黄金卢恩【７】 32057020")]
        AltusPlateauAltusTunnelGoldenRune7 = 32057020,

        [Annotation(Name = "[亚坛高原 - 亚坛坑道] 众武护符＋１ 32057030")]
        AltusPlateauAltusTunnelArsenalCharm1 = 32057030,

        [Annotation(Name = "[亚坛高原 - 亚坛坑道] 崩裂辉石 32057040")]
        AltusPlateauAltusTunnelGlintstoneScrap = 32057040,

        [Annotation(Name = "[亚坛高原 - 亚坛坑道]  32057900")]
        AltusPlateauAltusTunnel = 32057900,

        [Annotation(Name = "[亚坛高原 - 亚坛坑道] 卢恩弯弧 32057910")]
        AltusPlateauAltusTunnelRuneArc = 32057910,

        [Annotation(Name = "[盖利德 - 盖尔坑道] 失色锻造石【２】 32077000")]
        CaelidGaelTunnelSomberSmithingStone2 = 32077000,

        [Annotation(Name = "[盖利德 - 盖尔坑道] 黄金卢恩【５】 32077010")]
        CaelidGaelTunnelGoldenRune5 = 32077010,

        [Annotation(Name = "[盖利德 - 盖尔坑道] 十字刀 32077020")]
        CaelidGaelTunnelCrossNaginata = 32077020,

        [Annotation(Name = "[盖利德 - 盖尔坑道] 腌制黄金鸟爪 32077030")]
        CaelidGaelTunnelDragonbaneTalisman = 32077030,

        [Annotation(Name = "[盖利德 - 盖尔坑道] 大块崩裂辉石 32077060")]
        CaelidGaelTunnelLargeGlintstoneScrap = 32077060,

        [Annotation(Name = "[盖利德 - 盖尔坑道] 拟态赐福 32077070")]
        CaelidGaelTunnelGraceMimic = 32077070,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 腐败油脂 32087000")]
        CaelidSelliaCrystalTunnelRotGrease = 32087000,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 黄金卢恩【５】 32087020")]
        CaelidSelliaCrystalTunnelGoldenRune5 = 32087020,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 崩裂辉石 32087030")]
        CaelidSelliaCrystalTunnelGlintstoneScrap = 32087030,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 卢恩弯弧 32087050")]
        CaelidSelliaCrystalTunnelRuneArc = 32087050,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 杜鹃辉石 32087060")]
        CaelidSelliaCrystalTunnelCuckooGlintstone = 32087060,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 失色锻造石【４】 32087070")]
        CaelidSelliaCrystalTunnelSomberSmithingStone4 = 32087070,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 黄金卢恩【４】 32087100")]
        CaelidSelliaCrystalTunnelGoldenRune4 = 32087100,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 伤龙油脂 32087110")]
        CaelidSelliaCrystalTunnelDragonwoundGrease = 32087110,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 信徒的立誓布 32087120")]
        CaelidSelliaCrystalTunnelFaithfulsCanvasTalisman = 32087120,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] 扇形重力石 32087900")]
        CaelidSelliaCrystalTunnelGravityStoneFan = 32087900,

        [Annotation(Name = "[盖利德 - 瑟利亚结晶坑道] [魔法] 爆破岩盘 32087910")]
        CaelidSelliaCrystalTunnelSorceryRockBlaster = 32087910,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯坑道] 结冰油脂 32117000")]
        ConsecratedSnowfieldYeloughAnixTunnelFreezingGrease = 32117000,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯坑道] 黄金卢恩【１０】 32117020")]
        ConsecratedSnowfieldYeloughAnixTunnelGoldenRune10 = 32117020,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯坑道] 古龙岩锻造石 32117030")]
        ConsecratedSnowfieldYeloughAnixTunnelAncientDragonSmithingStone = 32117030,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯坑道] 卢恩弯弧 32117040")]
        ConsecratedSnowfieldYeloughAnixTunnelRuneArc = 32117040,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯坑道] 爆炸石块 32117060")]
        ConsecratedSnowfieldYeloughAnixTunnelExplosiveStoneClump = 32117060,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯坑道] 英雄卢恩【５】 32117080")]
        ConsecratedSnowfieldYeloughAnixTunnelHerosRune5 = 32117080,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 温热石 34107000")]
        StormhillDivineTowerOfLimgraveWarmingStone = 34107000,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 柔软棉花 34107010")]
        StormhillDivineTowerOfLimgraveSoftCotton = 34107010,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 风暴鹰羽毛 34107070")]
        StormhillDivineTowerOfLimgraveStormhawkFeather = 34107070,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 腌制白银鸟爪 34107080")]
        StormhillDivineTowerOfLimgraveSilverPickledFowlFoot = 34107080,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 黄金卢恩【２】 34107090")]
        StormhillDivineTowerOfLimgraveGoldenRune2 = 34107090,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 雷龙徽护符 34107100")]
        StormhillDivineTowerOfLimgraveBoltdrakeTalisman = 34107100,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 战灰粪金龟 34107110")]
        StormhillDivineTowerOfLimgraveAshofWarScarab = 34107110,

        [Annotation(Name = "[风暴山丘 - 宁姆格福神授塔] 葛瑞克的大卢恩 191")]
        StormhillDivineTowerOfLimgraveGodricksGreatRune = 191,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 黄金卢恩【３】 34117010")]
        LiurniaDivineTowerOfLiurniaGoldenRune3 = 34117010,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 黄金卢恩【４】 34117060")]
        LiurniaDivineTowerOfLiurniaGoldenRune4 = 34117060,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 蓝种子护符 34117080")]
        LiurniaDivineTowerOfLiurniaCeruleanSeedTalisman = 34117080,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 隐匿面具 34117100")]
        LiurniaDivineTowerOfLiurniaMaskOfConfidence = 34117100,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 抗圣肝脏干 34117110")]
        LiurniaDivineTowerOfLiurniaHolyproofDriedLiver = 34117110,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 辉石萤火虫 34117120")]
        LiurniaDivineTowerOfLiurniaGlintstoneFirefly = 34117120,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 卡利亚辉石杖 34117200")]
        LiurniaDivineTowerOfLiurniaCarianGlintstoneStaff = 34117200,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 神皮使徒风帽 34117400")]
        LiurniaDivineTowerOfLiurniaGodskinApostleHood = 34117400,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 神皮使徒长袍 34117401")]
        LiurniaDivineTowerOfLiurniaGodskinApostleRobe = 34117401,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 使徒手环 34117402")]
        LiurniaDivineTowerOfLiurniaGodskinApostleBracelets = 34117402,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 使徒长裤 34117403")]
        LiurniaDivineTowerOfLiurniaGodskinApostleTrousers = 34117403,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] 死亡的咒痕 34117500")]
        LiurniaDivineTowerOfLiurniaCursemarkOfDeath = 34117500,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] [魔法] 天降魔力 34117700")]
        LiurniaDivineTowerOfLiurniaSorceryMagicDownpour = 34117700,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚神授塔] [魔法] 镇定 34117710")]
        LiurniaDivineTowerOfLiurniaSorceryLucidity = 34117710,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 黄金卢恩【５】 34127010")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune5 = 34127010,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 黄金卢恩【５】 34127020")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune5_ = 34127020,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔]  34127030")]
        CapitalOutskirtsDivineTowerOfWestAltus = 34127030,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 粗大兽骨 34127040")]
        CapitalOutskirtsDivineTowerOfWestAltusHeftyBeastBone = 34127040,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 腌制黄金鸟爪 34127050")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldPickledFowlFoot = 34127050,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 石剑钥匙 34127060")]
        CapitalOutskirtsDivineTowerOfWestAltusStoneswordKey = 34127060,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 卢恩弯弧 34127070")]
        CapitalOutskirtsDivineTowerOfWestAltusRuneArc = 34127070,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 黄金卢恩【１】 34127080")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune1 = 34127080,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 唤勾指药 34127090")]
        CapitalOutskirtsDivineTowerOfWestAltusFurlcallingFingerRemedy = 34127090,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 古牙 34127100")]
        CapitalOutskirtsDivineTowerOfWestAltusOldFang = 34127100,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 拟态赐福 34127110")]
        CapitalOutskirtsDivineTowerOfWestAltusGraceMimic = 34127110,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 大块崩裂辉石 34127120")]
        CapitalOutskirtsDivineTowerOfWestAltusLargeGlintstoneScrap = 34127120,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 锻造石【６】 34127130")]
        CapitalOutskirtsDivineTowerOfWestAltusSmithingStone6 = 34127130,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔]  34127140")]
        CapitalOutskirtsDivineTowerOfWestAltus_ = 34127140,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 雷油脂 34127150")]
        CapitalOutskirtsDivineTowerOfWestAltusLightningGrease = 34127150,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 黄金卢恩【９】 34127160")]
        CapitalOutskirtsDivineTowerOfWestAltusGoldenRune9 = 34127160,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 拉卡德的大卢恩 194")]
        CapitalOutskirtsDivineTowerOfWestAltusRykardsGreatRune = 194,

        [Annotation(Name = "[王城城墙外 - 西亚坛神授塔] 锻造石矿工的铃珠【２】 34127900")]
        CapitalOutskirtsDivineTowerOfWestAltusSmithingStoneMinersBellBearing2 = 34127900,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔] 石剑钥匙 34137000")]
        GreyollsDragonbarrowDivineTowerOfCaelidStoneswordKey = 34137000,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔] 卢恩弯弧 34137010")]
        GreyollsDragonbarrowDivineTowerOfCaelidRuneArc = 34137010,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔] 黄金卢恩【１２】 34137020")]
        GreyollsDragonbarrowDivineTowerOfCaelidGoldenRune12 = 34137020,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔] 拉塔恩的大卢恩 192")]
        GreyollsDragonbarrowDivineTowerOfCaelidRadahnsGreatRune = 192,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔] 狩猎神祇大剑 34137900")]
        GreyollsDragonbarrowDivineTowerOfCaelidGodslayersGreatsword = 34137900,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 健壮白肉干 34147000")]
        ForbiddenLandsDivineTowerOfEastAltusInvigoratingWhiteCuredMeat = 34147000,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 官吏上衣 34147010")]
        ForbiddenLandsDivineTowerOfEastAltusOfficialsAttire = 34147010,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 火龙徽护符＋１ 34147020")]
        ForbiddenLandsDivineTowerOfEastAltusFlamedrakeTalisman1 = 34147020,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 蒙葛特的大卢恩 193")]
        ForbiddenLandsDivineTowerOfEastAltusMorgottsGreatRune = 193,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 蒙格的大卢恩 195")]
        ForbiddenLandsDivineTowerOfEastAltusMohgsGreatRune = 195,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 失色锻造石【６】 34147720")]
        ForbiddenLandsDivineTowerOfEastAltusSomberSmithingStone6 = 34147720,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 黄金卢恩【９】 34147800")]
        ForbiddenLandsDivineTowerOfEastAltusGoldenRune9 = 34147800,

        [Annotation(Name = "[禁域 - 东亚坛神授塔] 使命短刀 34147810")]
        ForbiddenLandsDivineTowerOfEastAltusBladeOfCalling = 34147810,

        [Annotation(Name = "[桂奥尔龙墓 - 孤立神授塔] 玛莲妮亚的大卢恩 196")]
        GreyollsDragonbarrowIsolatedDivineTowerMaleniasGreatRune = 196,

        [Annotation(Name = "[弃置恶兆的地底] 兽骨毒飞刀 35007000")]
        SubterraneanShunningGroundsPoisonboneDart = 35007000,

        [Annotation(Name = "[弃置恶兆的地底] 玻璃碎片 35007010")]
        SubterraneanShunningGroundsGlassShard = 35007010,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１】 35007020")]
        SubterraneanShunningGroundsGoldenRune1 = 35007020,

        [Annotation(Name = "[弃置恶兆的地底] 红琥珀链坠＋２ 35007030")]
        SubterraneanShunningGroundsCrimsonAmberMedallion2 = 35007030,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１１】 35007040")]
        SubterraneanShunningGroundsGoldenRune11 = 35007040,

        [Annotation(Name = "[弃置恶兆的地底] 渗血腕套 35007050")]
        SubterraneanShunningGroundsBloodsoakedManchettes = 35007050,

        [Annotation(Name = "[弃置恶兆的地底] 耶罗眼珠 35007060")]
        SubterraneanShunningGroundsEyeOfYelough = 35007060,

        [Annotation(Name = "[弃置恶兆的地底] 文件：关于米凯拉的针 69740")]
        SubterraneanShunningGroundsNoteMiquellasNeedle = 69740,

        [Annotation(Name = "[弃置恶兆的地底] 腐败苔药 35007080")]
        SubterraneanShunningGroundsPreservingBoluses = 35007080,

        [Annotation(Name = "[弃置恶兆的地底] 唤勾指药 35007090")]
        SubterraneanShunningGroundsFurlcallingFingerRemedy = 35007090,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１】 35007100")]
        SubterraneanShunningGroundsGoldenRune1_ = 35007100,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１１】 35007110")]
        SubterraneanShunningGroundsGoldenRune11_ = 35007110,

        [Annotation(Name = "[弃置恶兆的地底] 卢恩弯弧 35007120")]
        SubterraneanShunningGroundsRuneArc = 35007120,

        [Annotation(Name = "[弃置恶兆的地底] 失力战灰 35007130")]
        SubterraneanShunningGroundsLostAshesOfWar = 35007130,

        [Annotation(Name = "[弃置恶兆的地底] 玻璃碎片 35007150")]
        SubterraneanShunningGroundsGlassShard_ = 35007150,

        [Annotation(Name = "[弃置恶兆的地底] 石剑钥匙 35007160")]
        SubterraneanShunningGroundsStoneswordKey = 35007160,

        [Annotation(Name = "[弃置恶兆的地底] 虹彩石箭（附箭羽） 35007170")]
        SubterraneanShunningGroundsRainbowStoneArrowFletched = 35007170,

        [Annotation(Name = "[弃置恶兆的地底] 墓地紫花 35007180")]
        SubterraneanShunningGroundsGraveViolet = 35007180,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【７】 35007190")]
        SubterraneanShunningGroundsSmithingStone7 = 35007190,

        [Annotation(Name = "[弃置恶兆的地底] 抗火肝脏干 35007200")]
        SubterraneanShunningGroundsFireproofDriedLiver = 35007200,

        [Annotation(Name = "[弃置恶兆的地底] 失色锻造石【８】 35007210")]
        SubterraneanShunningGroundsSomberSmithingStone8 = 35007210,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【７】 35007220")]
        SubterraneanShunningGroundsSmithingStone7_ = 35007220,

        [Annotation(Name = "[弃置恶兆的地底] 拟态赐福 35007240")]
        SubterraneanShunningGroundsGraceMimic = 35007240,

        [Annotation(Name = "[弃置恶兆的地底] 绳索 35007250")]
        SubterraneanShunningGroundsString = 35007250,

        [Annotation(Name = "[弃置恶兆的地底] 火油脂 35007260")]
        SubterraneanShunningGroundsFireGrease = 35007260,

        [Annotation(Name = "[弃置恶兆的地底] 流浪民族的骨灰 35007270")]
        SubterraneanShunningGroundsNomadAshes = 35007270,

        [Annotation(Name = "[弃置恶兆的地底] 腐败苔药 35007280")]
        SubterraneanShunningGroundsPreservingBoluses_ = 35007280,

        [Annotation(Name = "[弃置恶兆的地底] 玻璃碎片 35007300")]
        SubterraneanShunningGroundsGlassShard__ = 35007300,

        [Annotation(Name = "[弃置恶兆的地底] 蒙格的囚具 35007310")]
        SubterraneanShunningGroundsMohgsShackle = 35007310,

        [Annotation(Name = "[弃置恶兆的地底] 斑斓白肉干 35007320")]
        SubterraneanShunningGroundsDappledWhiteCuredMeat = 35007320,

        [Annotation(Name = "[弃置恶兆的地底] 玻璃碎片 35007330")]
        SubterraneanShunningGroundsGlassShard___ = 35007330,

        [Annotation(Name = "[弃置恶兆的地底] 黄金百足 35007340")]
        SubterraneanShunningGroundsGoldenCentipede = 35007340,

        [Annotation(Name = "[弃置恶兆的地底] 毒石 35007350")]
        SubterraneanShunningGroundsPoisonedStone = 35007350,

        [Annotation(Name = "[弃置恶兆的地底] 结冰油脂 35007370")]
        SubterraneanShunningGroundsFreezingGrease = 35007370,

        [Annotation(Name = "[弃置恶兆的地底] 飞蛇毒箭 35007380")]
        SubterraneanShunningGroundsSerpentArrow = 35007380,

        [Annotation(Name = "[弃置恶兆的地底] 火油脂 35007390")]
        SubterraneanShunningGroundsFireGrease_ = 35007390,

        [Annotation(Name = "[弃置恶兆的地底] 失色锻造石【６】 35007400")]
        SubterraneanShunningGroundsSomberSmithingStone6 = 35007400,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【７】 35007410")]
        SubterraneanShunningGroundsSmithingStone7__ = 35007410,

        [Annotation(Name = "[弃置恶兆的地底] [祷告] 诱敌幻影 35007420")]
        SubterraneanShunningGroundsIncantationShadowBait = 35007420,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１０】 35007430")]
        SubterraneanShunningGroundsGoldenRune10 = 35007430,

        [Annotation(Name = "[弃置恶兆的地底] 失色锻造石【７】 35007450")]
        SubterraneanShunningGroundsSomberSmithingStone7 = 35007450,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【７】 35007460")]
        SubterraneanShunningGroundsSmithingStone7___ = 35007460,

        [Annotation(Name = "[弃置恶兆的地底] 玻璃碎片 35007470")]
        SubterraneanShunningGroundsGlassShard____ = 35007470,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【７】 35007480")]
        SubterraneanShunningGroundsSmithingStone7____ = 35007480,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【９】 35007500")]
        SubterraneanShunningGroundsGoldenRune9 = 35007500,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１１】 35007510")]
        SubterraneanShunningGroundsGoldenRune11__ = 35007510,

        [Annotation(Name = "[弃置恶兆的地底] 温热石 35007530")]
        SubterraneanShunningGroundsWarmingStone = 35007530,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【８】 35007540")]
        SubterraneanShunningGroundsSmithingStone8 = 35007540,

        [Annotation(Name = "[弃置恶兆的地底] 耶罗眼珠 35007550")]
        SubterraneanShunningGroundsEyeOfYelough_ = 35007550,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【８】 35007560")]
        SubterraneanShunningGroundsGoldenRune8 = 35007560,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【７】 35007570")]
        SubterraneanShunningGroundsSmithingStone7_____ = 35007570,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１】 35007580")]
        SubterraneanShunningGroundsGoldenRune1__ = 35007580,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１１】 35007590")]
        SubterraneanShunningGroundsGoldenRune11___ = 35007590,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【５】 35007600")]
        SubterraneanShunningGroundsSmithingStone5 = 35007600,

        [Annotation(Name = "[弃置恶兆的地底] 仪式壶 66490")]
        SubterraneanShunningGroundsRitualPot = 66490,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【６】 35007630")]
        SubterraneanShunningGroundsSmithingStone6 = 35007630,

        [Annotation(Name = "[弃置恶兆的地底] 拟态赐福 35007650")]
        SubterraneanShunningGroundsGraceMimic_ = 35007650,

        [Annotation(Name = "[弃置恶兆的地底] 黄金卢恩【１１】 35007660")]
        SubterraneanShunningGroundsGoldenRune11____ = 35007660,

        [Annotation(Name = "[弃置恶兆的地底] 粗大兽骨 35007670")]
        SubterraneanShunningGroundsHeftyBeastBone = 35007670,

        [Annotation(Name = "[弃置恶兆的地底] [祷告] 发狂扩散 35007680")]
        SubterraneanShunningGroundsIncantationInescapableFrenzy = 35007680,

        [Annotation(Name = "[弃置恶兆的地底] 黄金树的恩惠＋１ 35007700")]
        SubterraneanShunningGroundsErdtreesFavor1 = 35007700,

        [Annotation(Name = "[弃置恶兆的地底] 流浪商人帽子 35007710")]
        SubterraneanShunningGroundsNomadicMerchantsChapeau = 35007710,

        [Annotation(Name = "[弃置恶兆的地底] 指纹石盾 35007720")]
        SubterraneanShunningGroundsFingerprintStoneShield = 35007720,

        [Annotation(Name = "[弃置恶兆的地底] 温热石 35007730")]
        SubterraneanShunningGroundsWarmingStone_ = 35007730,

        [Annotation(Name = "[弃置恶兆的地底] 毒石 35007740")]
        SubterraneanShunningGroundsPoisonedStone_ = 35007740,

        [Annotation(Name = "[弃置恶兆的地底] 锻造石【１】 35007750")]
        SubterraneanShunningGroundsSmithingStone1 = 35007750,

        [Annotation(Name = "[弃置恶兆的地底] 火焰长剑 35007770")]
        SubterraneanShunningGroundsFireLongsword = 35007770,

        [Annotation(Name = "[弃置恶兆的地底] 卢恩弯弧 35007780")]
        SubterraneanShunningGroundsRuneArc_ = 35007780,

        [Annotation(Name = "[弃置恶兆的地底] 罹病者的制作笔记【２】 68410")]
        SubterraneanShunningGroundsFrenziedsCookbook2 = 68410,

        [Annotation(Name = "[弃置恶兆的地底] 灵依墓地铃兰【６】 35007900")]
        SubterraneanShunningGroundsGhostGlovewort6 = 35007900,

        [Annotation(Name = "[弃置恶兆的地底] 根脂 35007910")]
        SubterraneanShunningGroundsRootResin = 35007910,

        [Annotation(Name = "[弃置恶兆的地底] 蘑菇 35007920")]
        SubterraneanShunningGroundsMushroom = 35007920,

        [Annotation(Name = "[弃置恶兆的地底] 圣血木芽 35007930")]
        SubterraneanShunningGroundsSacramentalBud = 35007930,

        [Annotation(Name = "[弃置恶兆的地底] 熔炉鳞护符 35007940")]
        SubterraneanShunningGroundsCrucibleScaleTalisman = 35007940,

        [Annotation(Name = "[弃置恶兆的地底] 圣龙徽护符＋１ 35007950")]
        SubterraneanShunningGroundsHaligdrakeTalisman1 = 35007950,

        [Annotation(Name = "[弃置恶兆的地底] 卢恩弯弧 35007960")]
        SubterraneanShunningGroundsRuneArc__ = 35007960,

        [Annotation(Name = "[弃置恶兆的地底] 失色锻造石【６】 35007970")]
        SubterraneanShunningGroundsSomberSmithingStone6_ = 35007970,

        [Annotation(Name = "[弃置恶兆的地底] 失色锻造石【７】 35007980")]
        SubterraneanShunningGroundsSomberSmithingStone7_ = 35007980,

        [Annotation(Name = "[古遗迹断崖] 黄金卢恩【１】 39207000")]
        RuinStrewnPrecipiceGoldenRune1 = 39207000,

        [Annotation(Name = "[古遗迹断崖] 锻造石【５】 39207010")]
        RuinStrewnPrecipiceSmithingStone5 = 39207010,

        [Annotation(Name = "[古遗迹断崖] 卢恩弯弧 39207020")]
        RuinStrewnPrecipiceRuneArc = 39207020,

        [Annotation(Name = "[古遗迹断崖] 失色锻造石【３】 39207030")]
        RuinStrewnPrecipiceSomberSmithingStone3 = 39207030,

        [Annotation(Name = "[古遗迹断崖] 蛇神弯刀 39207040")]
        RuinStrewnPrecipiceSerpentGodsCurvedSword = 39207040,

        [Annotation(Name = "[古遗迹断崖] 锻造石【４】 39207050")]
        RuinStrewnPrecipiceSmithingStone4 = 39207050,

        [Annotation(Name = "[古遗迹断崖] 黄金卢恩【４】 39207060")]
        RuinStrewnPrecipiceGoldenRune4 = 39207060,

        [Annotation(Name = "[古遗迹断崖] 黄金卢恩【５】 39207070")]
        RuinStrewnPrecipiceGoldenRune5 = 39207070,

        [Annotation(Name = "[古遗迹断崖] 卢恩弯弧 39207080")]
        RuinStrewnPrecipiceRuneArc_ = 39207080,

        [Annotation(Name = "[古遗迹断崖] 柔软棉花 39207090")]
        RuinStrewnPrecipiceSoftCotton = 39207090,

        [Annotation(Name = "[古遗迹断崖] 黄金卢恩【５】 39207100")]
        RuinStrewnPrecipiceGoldenRune5_ = 39207100,

        [Annotation(Name = "[古遗迹断崖] 黄金卢恩【５】 39207110")]
        RuinStrewnPrecipiceGoldenRune5__ = 39207110,

        [Annotation(Name = "[古遗迹断崖] 失力战灰 39207120")]
        RuinStrewnPrecipiceLostAshesOfWar = 39207120,

        [Annotation(Name = "[古遗迹断崖] 锻造石【３】 39207130")]
        RuinStrewnPrecipiceSmithingStone3 = 39207130,

        [Annotation(Name = "[古遗迹断崖] 锻造石【３】 39207140")]
        RuinStrewnPrecipiceSmithingStone3_ = 39207140,

        [Annotation(Name = "[古遗迹断崖] 锻造石【３】 39207150")]
        RuinStrewnPrecipiceSmithingStone3__ = 39207150,

        [Annotation(Name = "[古遗迹断崖] 雷油脂 39207160")]
        RuinStrewnPrecipiceLightningGrease = 39207160,

        [Annotation(Name = "[古遗迹断崖] 圣杯露滴 39207170")]
        RuinStrewnPrecipiceSacredTear = 39207170,

        [Annotation(Name = "[古遗迹断崖] 锻造石【１】 39207200")]
        RuinStrewnPrecipiceSmithingStone1 = 39207200,

        [Annotation(Name = "[古遗迹断崖] 大山羊头盔 39207500")]
        RuinStrewnPrecipiceBullGoatHelm = 39207500,

        [Annotation(Name = "黄金卢恩【１】 99017000")]
        GoldenRune1_____________________ = 99017000,

        [Annotation(Name = "龟裂壶 99997020")]
        CrackedPot = 99997020,

        [Annotation(Name = "调香瓶 99997030")]
        PerfumeBottle = 99997030,

        [Annotation(Name = "老将头盔 59930000")]
        VeteransHelm = 59930000,

        [Annotation(Name = "柔软棉花 59931000")]
        SoftCotton = 59931000,

        [Annotation(Name = "[宁姆格福 - 雾林] 大刺破露滴 65140")]
        LimgraveMistwoodSpikedCrackedTear = 65140,

        [Annotation(Name = "[宁姆格福 - 雾林] 漫绿结晶露滴 65010")]
        LimgraveMistwoodGreenspillCrystalTear = 65010,

        [Annotation(Name = "[宁姆格福 - 玛莉卡第三教堂] 灵药圣杯瓶 60020")]
        LimgraveThirdChurchOfMarikaFlaskOfWondrousPhysick = 60020,

        [Annotation(Name = "[宁姆格福 - 玛莉卡第三教堂] 红结晶露滴 65020")]
        LimgraveThirdChurchOfMarikaCrimsonCrystalTear = 65020,

        [Annotation(Name = "[宁姆格福 - 玛莉卡第三教堂] 圣杯露滴 1046387100")]
        LimgraveThirdChurchOfMarikaSacredTear = 1046387100,

        [Annotation(Name = "[啜泣半岛 - 玛莉卡第四教堂] 圣杯露滴 1041337200")]
        WeepingPeninsulaFourthChurchOfMarikaSacredTear = 1041337200,

        [Annotation(Name = "[宁姆格福 - 傍海古遗迹] 圣杯露滴 1043357100")]
        LimgraveSeasideRuinsSacredTear = 1043357100,

        [Annotation(Name = "[啜泣半岛 - 病村外] 圣杯露滴 1044337100")]
        WeepingPeninsulaAilingVillageOutskirtsSacredTear = 1044337100,

        [Annotation(Name = "[风暴山丘 - 风暴山丘的破屋] 黄金种子 1041387100")]
        StormhillStormhillShackGoldenSeed = 1041387100,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 黄金种子 1044327020")]
        WeepingPeninsulaCastleMorneApproachGoldenSeed = 1044327020,

        [Annotation(Name = "[宁姆格福 - 海德要塞] 黄金种子 1046367100")]
        LimgraveFortHaightGoldenSeed = 1046367100,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖北方] 战灰：连击 1043377400")]
        LimgraveAgheelLakeNorthAshOfWarRepeatingThrust = 1043377400,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 蓝羽七刃剑 1042387400")]
        StormhillWarmastersShackBlueFeatheredBranchsword = 1042387400,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 兽骨贩子的铃珠 1042387410")]
        StormhillWarmastersShackBonePeddlersBellBearing = 1042387410,

        [Annotation(Name = "[风暴山丘 - 森林西边悬崖] 锻造石【１】 1040387000")]
        StormhillForestedWestCliffsideSmithingStone1 = 1040387000,

        [Annotation(Name = "[风暴山丘 - 森林西边悬崖] 流浪战士的制作笔记【７】 67050")]
        StormhillForestedWestCliffsideNomadicWarriorsCookbook7 = 67050,

        [Annotation(Name = "[宁姆格福 - 龙飨教堂] 大蜻蜓头部 1041357000")]
        LimgraveChurchOfDragonCommunionGreatDragonflyHead = 1041357000,

        [Annotation(Name = "[宁姆格福 - 龙飨教堂] 锻造石【２】 1041357010")]
        LimgraveChurchOfDragonCommunionSmithingStone2 = 1041357010,

        [Annotation(Name = "[宁姆格福 - 龙飨教堂] 勇者肉块 1041357020")]
        LimgraveChurchOfDragonCommunionExaltedFlesh = 1041357020,

        [Annotation(Name = "[宁姆格福 - 海岸洞窟入口] 章鱼卵 1041367000")]
        LimgraveCoastalCaveEntranceLandOctopusOvary = 1041367000,

        [Annotation(Name = "[宁姆格福 - 风暴根脚的地下墓地入口] 白色肉片 1041377000")]
        LimgraveStormfootCatacombsEntranceStripOfWhiteFlesh = 1041377000,

        [Annotation(Name = "[宁姆格福 - 风暴根脚的地下墓地入口] 星光碎片 1041377020")]
        LimgraveStormfootCatacombsEntranceStarlightShards = 1041377020,

        [Annotation(Name = "[风暴山丘 - 风暴山丘的破屋] 魔力油脂 1041387010")]
        StormhillStormhillShackMagicGrease = 1041387010,

        [Annotation(Name = "[风暴山丘 - 风暴山丘的破屋] 锻造石【１】 1041387030")]
        StormhillStormhillShackSmithingStone1 = 1041387030,

        [Annotation(Name = "[风暴山丘 - 风暴山丘的破屋] 石剑钥匙 1041387040")]
        StormhillStormhillShackStoneswordKey = 1041387040,

        [Annotation(Name = "[风暴山丘 - 风暴山丘的破屋] 葛瑞克士兵的骨灰 1041387050")]
        StormhillStormhillShackGodrickSoldierAshes = 1041387050,

        [Annotation(Name = "[风暴山丘 - 风暴山丘的破屋] 血蔷薇 1041387200")]
        StormhillStormhillShackBloodrose = 1041387200,

        [Annotation(Name = "[风暴山丘 - 风暴山丘的破屋以北] 野兽肉块 1041397000")]
        StormhillNorthOfStormhillShackLumpOfFlesh = 1041397000,

        [Annotation(Name = "[风暴山丘 - 西北悬崖边] 斗士勾指 60240")]
        StormhillNorthwestCliffsideDuelistsFurledFinger = 60240,

        [Annotation(Name = "[风暴山丘 - 西北悬崖边] 红色小雕像 60250")]
        StormhillNorthwestCliffsideSmallRedEffigy = 60250,

        [Annotation(Name = "[宁姆格福 - 漂流墓地南] 腌制黄金鸟爪 1042357010")]
        LimgraveSouthOfStrandedGraveyardGoldPickledFowlFoot = 1042357010,

        [Annotation(Name = "[宁姆格福 - 漂流墓地南] 野兽肉块 1042357000")]
        LimgraveSouthOfStrandedGraveyardLumpOfFlesh = 1042357000,

        [Annotation(Name = "[宁姆格福 - 艾雷教堂] 腌制白银鸟爪 1042367010")]
        LimgraveChurchOfEllehSilverPickledFowlFoot = 1042367010,

        [Annotation(Name = "[宁姆格福 - 艾雷教堂] 黄金卢恩【２】 1042367030")]
        LimgraveChurchOfEllehGoldenRune2 = 1042367030,

        [Annotation(Name = "[宁姆格福 - 艾雷教堂] 黄金卢恩【１】 1042367040")]
        LimgraveChurchOfEllehGoldenRune1 = 1042367040,

        [Annotation(Name = "[宁姆格福 - 艾雷教堂] 锻造石【１】 1042367050")]
        LimgraveChurchOfEllehSmithingStone1 = 1042367050,

        [Annotation(Name = "[宁姆格福 - 艾雷教堂] 锻造石【１】 1042367060")]
        LimgraveChurchOfEllehSmithingStone1_ = 1042367060,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 遗迹石 1042377000")]
        LimgraveGatefrontRuinFragment = 1042377000,

        [Annotation(Name = "[山妖运输车 - 关卡前废墟] 连枷 1042377060")]
        TrollCarriageGatefrontRuinsFlail = 1042377060,

        [Annotation(Name = "[山妖运输车 - 关卡前废墟] 君王军大剑 1042377070")]
        TrollCarriageGatefrontRuinsLordswornsGreatsword = 1042377070,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 砥石小刀 60130")]
        LimgraveGatefrontWhetstoneKnife = 60130,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 战灰：风暴足 1042377110")]
        LimgraveGatefrontAshOfWarStormStomp = 1042377110,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 廓尔喀弯刀 1042377010")]
        LimgraveGatefrontKukri = 1042377010,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 远箭护符 1042377300")]
        LimgraveGatefrontArrowsReachTalisman = 1042377300,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 染红凶刀 1042377100")]
        LimgraveGatefrontAssassinsCrimsonDagger = 1042377100,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 野兽肝 1042387000")]
        StormhillWarmastersShackBeastLiver = 1042387000,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【１】 1042387010")]
        StormhillWarmastersShackGoldenRune1 = 1042387010,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 火箭 1042387020")]
        StormhillWarmastersShackFireArrow = 1042387020,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【５】 1042387030")]
        StormhillWarmastersShackGoldenRune5 = 1042387030,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【１】 1042387040")]
        StormhillWarmastersShackGoldenRune1_ = 1042387040,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【３】 1042387050")]
        StormhillWarmastersShackGoldenRune3 = 1042387050,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【２】 1042387070")]
        StormhillWarmastersShackGoldenRune2 = 1042387070,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【１】 1042387080")]
        StormhillWarmastersShackGoldenRune1__ = 1042387080,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【２】 1042387090")]
        StormhillWarmastersShackGoldenRune2_ = 1042387090,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【１】 1042387100")]
        StormhillWarmastersShackGoldenRune1___ = 1042387100,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【１】 1042387110")]
        StormhillWarmastersShackGoldenRune1____ = 1042387110,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 黄金卢恩【２】 1042387120")]
        StormhillWarmastersShackGoldenRune2__ = 1042387120,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 野兽肉块 1042387140")]
        StormhillWarmastersShackLumpOfFlesh = 1042387140,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 锻造石【１】 1042387600")]
        StormhillWarmastersShackSmithingStone1 = 1042387600,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋] 火星蝶 1042387200")]
        StormhillWarmastersShackSmolderingButterfly = 1042387200,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋以北] 力气瘤结晶露滴 65210")]
        StormhillNorthOfWarmastersShackStrengthknotCrystalTear = 65210,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋以北] 骑兵长矛 1042397010")]
        StormhillNorthOfWarmastersShackLance = 1042397010,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋以北] 兽纹熨斗形盾 1042397900")]
        StormhillNorthOfWarmastersShackBeastCrestHeaterShield = 1042397900,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋以北] 鳞片头盔 1042397500")]
        StormhillNorthOfWarmastersShackScaledHelm = 1042397500,

        [Annotation(Name = "[风暴山丘 - 习战者的破屋以北] 大槌护符 1042397700")]
        StormhillNorthOfWarmastersShackHammerTalisman = 1042397700,

        [Annotation(Name = "[宁姆格福 - 傍海古遗迹] 蟹卵 1043357000")]
        LimgraveSeasideRuinsCrabEggs = 1043357000,

        [Annotation(Name = "[宁姆格福 - 傍海古遗迹] 黄金卢恩【１】 1043357010")]
        LimgraveSeasideRuinsGoldenRune1 = 1043357010,

        [Annotation(Name = "[宁姆格福 - 傍海古遗迹] 眠卵 1043357030")]
        LimgraveSeasideRuinsSlumberingEgg = 1043357030,

        [Annotation(Name = "[宁姆格福 - 龙息废墟] 石剑钥匙 1043367010")]
        LimgraveDragonBurntRuinsStoneswordKey = 1043367010,

        [Annotation(Name = "[宁姆格福 - 龙息废墟] 黄金卢恩【２】 1043367020")]
        LimgraveDragonBurntRuinsGoldenRune2 = 1043367020,

        [Annotation(Name = "[宁姆格福 - 龙息废墟] 蟹卵 1043367040")]
        LimgraveDragonBurntRuinsCrabEggs = 1043367040,

        [Annotation(Name = "[宁姆格福 - 龙息废墟] 双头剑 1043367110")]
        LimgraveDragonBurntRuinsTwinblade = 1043367110,

        [Annotation(Name = "[宁姆格福 - 龙息废墟] 亚缇莉亚叶 1043367070")]
        LimgraveDragonBurntRuinsArteriaLeaf = 1043367070,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖北方] 锻造石【１】 1043377000")]
        LimgraveAgheelLakeNorthSmithingStone1 = 1043377000,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖北方] 火油脂 1043377010")]
        LimgraveAgheelLakeNorthFireGrease = 1043377010,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖北方] 亚缇莉亚叶 1043377020")]
        LimgraveAgheelLakeNorthArteriaLeaf = 1043377020,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 地图碎片：宁姆格福（西） 62010")]
        LimgraveGatefrontMapLimgraveWest = 62010,

        [Annotation(Name = "[宁姆格福 - 关卡前方] 逆刺 1042377700")]
        LimgraveGatefrontReduvia = 1042377700,

        [Annotation(Name = "[宁姆格福 - 蒙流岸边] 武器工匠的制作笔记【１】 67200")]
        LimgraveMurkwaterCoastArmorersCookbook1 = 67200,

        [Annotation(Name = "[宁姆格福 - 蒙流岸边] 锻造石【１】 1043387010")]
        LimgraveMurkwaterCoastSmithingStone1 = 1043387010,

        [Annotation(Name = "[宁姆格福 - 蒙流岸边] 黄金卢恩【２】 1043387020")]
        LimgraveMurkwaterCoastGoldenRune2 = 1043387020,

        [Annotation(Name = "[风暴山丘 - 圣人桥] 勇者肉块 1043397010")]
        StormhillSaintsbridgeExaltedFlesh = 1043397010,

        [Annotation(Name = "[风暴山丘 - 圣人桥] 锻造石【１】 1043397020")]
        StormhillSaintsbridgeSmithingStone1 = 1043397020,

        [Annotation(Name = "[风暴山丘 - 圣人桥] 黄金卢恩【３】 1043397200")]
        StormhillSaintsbridgeGoldenRune3 = 1043397200,

        [Annotation(Name = "[风暴山丘 - 圣人桥] 龟颈肉块 1043397030")]
        StormhillSaintsbridgeTurtleNeckMeat = 1043397030,

        [Annotation(Name = "[风暴山丘 - 葛瑞克骑士] 黄金树立誓 1043397500")]
        StormhillGodrickKnightGoldenVow = 1043397500,

        [Annotation(Name = "[风暴山丘 - 东北悬崖边] 催眠油脂 1043407000")]
        StormhillNortheastCliffsideSoporificGrease = 1043407000,

        [Annotation(Name = "[风暴山丘 - 东北悬崖边] 骑枪护符 1043407010")]
        StormhillNortheastCliffsideLanceTalisman = 1043407010,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 地图碎片：啜泣半岛 62011")]
        WeepingPeninsulaCastleMorneApproachMapWeepingPeninsula = 62011,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 石剑钥匙 1044347000")]
        WeepingPeninsulaBridgeOfSacrificeStoneswordKey = 1044347000,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 锻造石【１】 1044347010")]
        WeepingPeninsulaBridgeOfSacrificeSmithingStone1 = 1044347010,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 遗迹石 1044347050")]
        WeepingPeninsulaBridgeOfSacrificeRuinFragment = 1044347050,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 大棍棒 1044347080")]
        WeepingPeninsulaBridgeOfSacrificeLargeClub = 1044347080,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 黄金卢恩【２】 1044357000")]
        LimgraveAgheelLakeSouthGoldenRune2 = 1044357000,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 王室卷轴 1044357010")]
        LimgraveAgheelLakeSouthRoyalHouseScroll = 1044357010,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 黄金卢恩【１】 1044357020")]
        LimgraveAgheelLakeSouthGoldenRune1 = 1044357020,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 肉片 1044357030")]
        LimgraveAgheelLakeSouthSliverOfMeat = 1044357030,

        [Annotation(Name = "投火 1044357050")]
        FlameSling = 1044357050,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 蟹卵 1044357040")]
        LimgraveAgheelLakeSouthCrabEggs = 1044357040,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 黄金卢恩【１】 1044357060")]
        LimgraveAgheelLakeSouthGoldenRune1_ = 1044357060,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 星光碎片 1044357070")]
        LimgraveAgheelLakeSouthStarlightShards = 1044357070,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 泪滴幼体 1044357100")]
        LimgraveAgheelLakeSouthLarvalTear = 1044357100,

        [Annotation(Name = "[宁姆格福 - 亚基尔湖南方] 大重剑 1044357900")]
        LimgraveAgheelLakeSouthGreatepee = 1044357900,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 照明石 1044367000")]
        LimgraveWaypointRuinsGlowstone = 1044367000,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 黄金卢恩【１】 1044367010")]
        LimgraveWaypointRuinsGoldenRune1 = 1044367010,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 免疫肉干 1044367020")]
        LimgraveWaypointRuinsImmunizingCuredMeat = 1044367020,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 托莉娜睡莲 1044367100")]
        LimgraveWaypointRuinsTrinasLily = 1044367100,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 火星蝶 1044367030")]
        LimgraveWaypointRuinsSmolderingButterfly = 1044367030,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 失色锻造石【１】 1044367040")]
        LimgraveWaypointRuinsSomberSmithingStone1 = 1044367040,

        [Annotation(Name = "[山妖运输车 - 驿站街遗迹] 巨斧 1044367200")]
        TrollCarriageWaypointRuinsGreataxe = 1044367200,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 黄金卢恩【１】 1044367300")]
        LimgraveWaypointRuinsGoldenRune1_ = 1044367300,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 黄金卢恩【１】 1044367310")]
        LimgraveWaypointRuinsGoldenRune1__ = 1044367310,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 黄金卢恩【２】 1044367320")]
        LimgraveWaypointRuinsGoldenRune2 = 1044367320,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 黄金卢恩【１】 1044367330")]
        LimgraveWaypointRuinsGoldenRune1___ = 1044367330,

        [Annotation(Name = "[宁姆格福 - 驿站街遗迹] 黄金卢恩【３】 1044367340")]
        LimgraveWaypointRuinsGoldenRune3 = 1044367340,

        [Annotation(Name = "[宁姆格福 - 雾林边缘] 黄金卢恩【１】 1044377010")]
        LimgraveMistwoodOutskirtsGoldenRune1 = 1044377010,

        [Annotation(Name = "[宁姆格福 - 雾林边缘] 腌制黄金鸟爪 1044377200")]
        LimgraveMistwoodOutskirtsGoldPickledFowlFoot = 1044377200,

        [Annotation(Name = "[宁姆格福 - 雾林边缘] 牺牲细枝 1044377020")]
        LimgraveMistwoodOutskirtsSacrificialTwig = 1044377020,

        [Annotation(Name = "[宁姆格福 - 画家的破屋] 锻造石【１】 1044387010")]
        LimgraveArtistsShackSmithingStone1 = 1044387010,

        [Annotation(Name = "[宁姆格福 - 画家的破屋] 毒花 1044387040")]
        LimgraveArtistsShackPoisonbloom = 1044387040,

        [Annotation(Name = "[宁姆格福 - 画家的破屋] 黄金卢恩【１】 1044387100")]
        LimgraveArtistsShackGoldenRune1 = 1044387100,

        [Annotation(Name = "[王城罗德尔 - 小黄金树]  1045337400")]
        LeyndellMinorErdtree = 1045337400,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【１】 1045357000")]
        LimgraveSouthwestOfFortHaightGoldenRune1 = 1045357000,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【１】 1045357020")]
        LimgraveSouthwestOfFortHaightGoldenRune1_ = 1045357020,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【４】 1045357030")]
        LimgraveSouthwestOfFortHaightGoldenRune4 = 1045357030,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【３】 1045357040")]
        LimgraveSouthwestOfFortHaightGoldenRune3 = 1045357040,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【２】 1045357050")]
        LimgraveSouthwestOfFortHaightGoldenRune2 = 1045357050,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【１】 1045357060")]
        LimgraveSouthwestOfFortHaightGoldenRune1__ = 1045357060,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【２】 1045357070")]
        LimgraveSouthwestOfFortHaightGoldenRune2_ = 1045357070,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【１】 1045357080")]
        LimgraveSouthwestOfFortHaightGoldenRune1___ = 1045357080,

        [Annotation(Name = "[宁姆格福 - 海德要塞西南] 黄金卢恩【１】 1045357090")]
        LimgraveSouthwestOfFortHaightGoldenRune1____ = 1045357090,

        [Annotation(Name = "[宁姆格福 - 雾林] 黄金卢恩【２】 1045377000")]
        LimgraveMistwoodGoldenRune2 = 1045377000,

        [Annotation(Name = "[宁姆格福 - 雾林] 锻造石【２】 1045377010")]
        LimgraveMistwoodSmithingStone2 = 1045377010,

        [Annotation(Name = "[宁姆格福 - 雾林] 地图碎片：宁姆格福（东） 62012")]
        LimgraveMistwoodMapLimgraveEast = 62012,

        [Annotation(Name = "[宁姆格福 - 雾林] 流浪战士的制作笔记【４】 67800")]
        LimgraveMistwoodNomadicWarriorsCookbook4 = 67800,

        [Annotation(Name = "[宁姆格福 - 雾林] 斧护符 1045377100")]
        LimgraveMistwoodAxeTalisman = 1045377100,

        [Annotation(Name = "[宁姆格福 - 雾林] 黄金卢恩【１】 1045377050")]
        LimgraveMistwoodGoldenRune1 = 1045377050,

        [Annotation(Name = "[宁姆格福 - 雾林] 细小兽骨 1045377060")]
        LimgraveMistwoodThinBeastBones = 1045377060,

        [Annotation(Name = "[宁姆格福 - 雾林] 金色排泄物 1045377070")]
        LimgraveMistwoodGoldTingedExcrement = 1045377070,

        [Annotation(Name = "[宁姆格福 - 雾林] 投掷匕首 1045377080")]
        LimgraveMistwoodThrowingDagger = 1045377080,

        [Annotation(Name = "[宁姆格福 - 雾林] 黄金卢恩【５】 1045377090")]
        LimgraveMistwoodGoldenRune5 = 1045377090,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 魔力油脂 1045387000")]
        LimgraveSouthOfSummonwaterVillageMagicGrease = 1045387000,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 法力斯的制作笔记【１】 68200")]
        LimgraveSouthOfSummonwaterVillageFevorsCookbook1 = 68200,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 黄金卢恩【１】 1045387020")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1 = 1045387020,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 黄金卢恩【１】 1045387030")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1_ = 1045387030,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 黄金卢恩【１】 1045387040")]
        LimgraveSouthOfSummonwaterVillageGoldenRune1__ = 1045387040,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 黄金卢恩【２】 1045387050")]
        LimgraveSouthOfSummonwaterVillageGoldenRune2 = 1045387050,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 黄金卢恩【４】 1045387060")]
        LimgraveSouthOfSummonwaterVillageGoldenRune4 = 1045387060,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 黄金卢恩【４】 1045387070")]
        LimgraveSouthOfSummonwaterVillageGoldenRune4_ = 1045387070,

        [Annotation(Name = "[宁姆格福 - 水唤村以南] 黄金卢恩【６】 1045387080")]
        LimgraveSouthOfSummonwaterVillageGoldenRune6 = 1045387080,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【４】 1045397000")]
        LimgraveSummonwaterVillageGoldenRune4 = 1045397000,

        [Annotation(Name = "[宁姆格福 - 水唤村] 蘑菇 1045397020")]
        LimgraveSummonwaterVillageMushroom = 1045397020,

        [Annotation(Name = "[宁姆格福 - 水唤村] 锻造石【１】 1045397140")]
        LimgraveSummonwaterVillageSmithingStone1 = 1045397140,

        [Annotation(Name = "[宁姆格福 - 水唤村] 绿龟护符 1045397120")]
        LimgraveSummonwaterVillageGreenTurtleTalisman = 1045397120,

        [Annotation(Name = "[宁姆格福 - 水唤村] 锻造石【２】 1045397040")]
        LimgraveSummonwaterVillageSmithingStone2 = 1045397040,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【１】 1045397050")]
        LimgraveSummonwaterVillageGoldenRune1 = 1045397050,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【１】 1045397060")]
        LimgraveSummonwaterVillageGoldenRune1_ = 1045397060,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【１】 1045397070")]
        LimgraveSummonwaterVillageGoldenRune1__ = 1045397070,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【１】 1045397080")]
        LimgraveSummonwaterVillageGoldenRune1___ = 1045397080,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【５】 1045397090")]
        LimgraveSummonwaterVillageGoldenRune5 = 1045397090,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【２】 1045397100")]
        LimgraveSummonwaterVillageGoldenRune2 = 1045397100,

        [Annotation(Name = "[宁姆格福 - 水唤村] 黄金卢恩【１】 1045397110")]
        LimgraveSummonwaterVillageGoldenRune1____ = 1045397110,

        [Annotation(Name = "[宁姆格福 - 海德要塞] 锻造石【１】 1046367000")]
        LimgraveFortHaightSmithingStone1 = 1046367000,

        [Annotation(Name = "[宁姆格福 - 海德要塞] 血蔷薇 1046367010")]
        LimgraveFortHaightBloodrose = 1046367010,

        [Annotation(Name = "[宁姆格福 - 海德要塞] 流浪战士的制作笔记【６】 67020")]
        LimgraveFortHaightNomadicWarriorsCookbook6 = 67020,

        [Annotation(Name = "[宁姆格福 - 海德要塞] 血蔷薇 1046367030")]
        LimgraveFortHaightBloodrose_ = 1046367030,

        [Annotation(Name = "[宁姆格福 - 海德要塞] 迪可达斯符节（左） 1046367500")]
        LimgraveFortHaightDectusMedallionLeft = 1046367500,

        [Annotation(Name = "[宁姆格福 - 海德要塞] 战灰：鲜血斩击 1046367700")]
        LimgraveFortHaightAshOfWarBloodySlash = 1046367700,

        [Annotation(Name = "[宁姆格福 - 希芙拉河入口井以东] 白色肉片 1046377000")]
        LimgraveEastOfSiofraRiverWellStripOfWhiteFlesh = 1046377000,

        [Annotation(Name = "[宁姆格福 - 玛莉卡第三教堂] 中毒苔药 1046387010")]
        LimgraveThirdChurchOfMarikaNeutralizingBoluses = 1046387010,

        [Annotation(Name = "[啜泣半岛 - 隐居商人的破屋] 黄金卢恩【１】 1041327000")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1 = 1041327000,

        [Annotation(Name = "[啜泣半岛 - 隐居商人的破屋] 黄金卢恩【１】 1041327010")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1_ = 1041327010,

        [Annotation(Name = "[啜泣半岛 - 隐居商人的破屋] 黄金卢恩【２】 1041327020")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune2 = 1041327020,

        [Annotation(Name = "[啜泣半岛 - 隐居商人的破屋] 黄金卢恩【１】 1041327030")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1__ = 1041327030,

        [Annotation(Name = "[啜泣半岛 - 隐居商人的破屋] 黄金卢恩【１】 1041327040")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune1___ = 1041327040,

        [Annotation(Name = "[啜泣半岛 - 隐居商人的破屋] 黄金卢恩【３】 1041327050")]
        WeepingPeninsulaIsolatedMerchantsShackGoldenRune3 = 1041327050,

        [Annotation(Name = "[啜泣半岛 - 玛莉卡第四教堂] 黄金卢恩【１】 1041337000")]
        WeepingPeninsulaFourthChurchOfMarikaGoldenRune1 = 1041337000,

        [Annotation(Name = "[啜泣半岛 - 玛莉卡第四教堂] 黄金卢恩【５】 1041337010")]
        WeepingPeninsulaFourthChurchOfMarikaGoldenRune5 = 1041337010,

        [Annotation(Name = "[啜泣半岛 - 玛莉卡第四教堂] 大蜻蜓头部 1041337030")]
        WeepingPeninsulaFourthChurchOfMarikaGreatDragonflyHead = 1041337030,

        [Annotation(Name = "[啜泣半岛 - 玛莉卡第四教堂] 奇袭魔砾 1041337100")]
        WeepingPeninsulaFourthChurchOfMarikaAmbushShard = 1041337100,

        [Annotation(Name = "[啜泣半岛 - 归还塔] 大蜻蜓头部 1042327000")]
        WeepingPeninsulaTowerOfReturnGreatDragonflyHead = 1042327000,

        [Annotation(Name = "[啜泣半岛 - 归还塔] 蘑菇 1042327020")]
        WeepingPeninsulaTowerOfReturnMushroom = 1042327020,

        [Annotation(Name = "[啜泣半岛 - 归还塔] 复合弓 1042327100")]
        WeepingPeninsulaTowerOfReturnCompositeBow = 1042327100,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野] 日蚀纹熨斗形盾 1042337000")]
        WeepingPeninsulaTombswardEclipseCrestHeaterShield = 1042337000,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野] 拉达冈的烙印 1042337100")]
        WeepingPeninsulaTombswardRadagonsScarseal = 1042337100,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野的废墟] 出血油脂 1042347000")]
        WeepingPeninsulaTombswardRuinsBloodGrease = 1042347000,

        [Annotation(Name = "[宁姆格福 - 漂流墓地南] 肉片 1042357020")]
        LimgraveSouthOfStrandedGraveyardSliverOfMeat = 1042357020,

        [Annotation(Name = "[宁姆格福 - 漂流墓地南] 魅惑树枝 1042357030")]
        LimgraveSouthOfStrandedGraveyardBewitchingBranch = 1042357030,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野的废墟] 野兽肝 1042347010")]
        WeepingPeninsulaTombswardRuinsBeastLiver = 1042347010,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野的废墟] 展翼镰刀 1042347100")]
        WeepingPeninsulaTombswardRuinsWingedScythe = 1042347100,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野的废墟] 黄金卢恩【２】 1042347020")]
        WeepingPeninsulaTombswardRuinsGoldenRune2 = 1042347020,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野的废墟] 金黄铁盾 1042347030")]
        WeepingPeninsulaTombswardRuinsGildedIronShield = 1042347030,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 黄色余火 1043327000")]
        WeepingPeninsulaCastleMorneApproachYellowEmber = 1043327000,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 肉片 1043327010")]
        WeepingPeninsulaCastleMorneApproachSliverOfMeat = 1043327010,

        [Annotation(Name = "[啜泣半岛 - 小黄金树] 黄金卢恩【２】 1043337000")]
        WeepingPeninsulaMinorErdtreeGoldenRune2 = 1043337000,

        [Annotation(Name = "[啜泣半岛 - 小黄金树] 黄金卢恩【２】 1043337010")]
        WeepingPeninsulaMinorErdtreeGoldenRune2_ = 1043337010,

        [Annotation(Name = "[啜泣半岛 - 巡礼教堂] 亚缇莉亚叶 1043347000")]
        WeepingPeninsulaChurchOfPilgrimageArteriaLeaf = 1043347000,

        [Annotation(Name = "[啜泣半岛 - 巡礼教堂] 罪人盾 1043347100")]
        WeepingPeninsulaChurchOfPilgrimageShieldOfTheGuilty = 1043347100,

        [Annotation(Name = "[啜泣半岛 - 巡礼教堂] 信仰瘤结晶露滴 65240")]
        WeepingPeninsulaChurchOfPilgrimageFaithknotCrystalTear = 65240,

        [Annotation(Name = "[啜泣半岛 - 巡礼教堂] 金色排泄物 1043347040")]
        WeepingPeninsulaChurchOfPilgrimageGoldTingedExcrement = 1043347040,

        [Annotation(Name = "[啜泣半岛 - 巡礼教堂] 绳索 1043347050")]
        WeepingPeninsulaChurchOfPilgrimageString = 1043347050,

        [Annotation(Name = "[啜泣半岛 - 巡礼教堂] 亚人女王杖 1043347400")]
        WeepingPeninsulaChurchOfPilgrimageDemiHumanQueensStaff = 1043347400,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 黄金卢恩【４】 1044317010")]
        WeepingPeninsulaCastleMorneApproachGoldenRune4 = 1044317010,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 亚缇莉亚叶 1044317020")]
        WeepingPeninsulaCastleMorneApproachArteriaLeaf = 1044317020,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 失色锻造石【２】 1044317030")]
        WeepingPeninsulaCastleMorneApproachSomberSmithingStone2 = 1044317030,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 锻造石【１】 1044327010")]
        WeepingPeninsulaCastleMorneApproachSmithingStone1 = 1044327010,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 温热石 1044327030")]
        WeepingPeninsulaCastleMorneApproachWarmingStone = 1044327030,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 大乌龟壳 1044327040")]
        WeepingPeninsulaCastleMorneApproachGreatTurtleShell = 1044327040,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 活祭品斧 1044327400")]
        WeepingPeninsulaCastleMorneApproachSacrificialAxe = 1044327400,

        [Annotation(Name = "[啜泣半岛 - 摩恩城（城墙前方）] 战灰：铁壁盾防 1044327410")]
        WeepingPeninsulaCastleMorneApproachAshOfWarBarricadeShield = 1044327410,

        [Annotation(Name = "[啜泣半岛 - 病村外] 火纹木盾 1044337000")]
        WeepingPeninsulaAilingVillageOutskirtsCrestWoodenShield = 1044337000,

        [Annotation(Name = "[啜泣半岛 - 病村外] 虹彩石 1044337020")]
        WeepingPeninsulaAilingVillageOutskirtsRainbowStone = 1044337020,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 携带型弩炮 1044347100")]
        WeepingPeninsulaBridgeOfSacrificeHandBallista = 1044347100,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 虹彩石 1044347040")]
        WeepingPeninsulaBridgeOfSacrificeRainbowStone = 1044347040,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 黄金卢恩【１】 1044347060")]
        WeepingPeninsulaBridgeOfSacrificeGoldenRune1 = 1044347060,

        [Annotation(Name = "[啜泣半岛 - 献祭大桥] 黄金卢恩【１】 1044347070")]
        WeepingPeninsulaBridgeOfSacrificeGoldenRune1_ = 1044347070,

        [Annotation(Name = "[王城罗德尔 - 小黄金树] 星光碎片 1045337000")]
        LeyndellMinorErdtreeStarlightShards = 1045337000,

        [Annotation(Name = "[王城罗德尔 - 小黄金树] 记忆石 60400")]
        LeyndellMinorErdtreeMemoryStone = 60400,

        [Annotation(Name = "[啜泣半岛 - 穿刺地下墓地入口] 石剑钥匙 1045347000")]
        WeepingPeninsulaImpalersCatacombsEntranceStoneswordKey = 1045347000,

        [Annotation(Name = "[啜泣半岛 - 灵庙原野] 黄金卢恩【１】 1042337200")]
        WeepingPeninsulaTombswardGoldenRune1 = 1042337200,

        [Annotation(Name = "[啜泣半岛 - 摩恩悲叹墓] 失色锻造石【１】 1043307000")]
        WeepingPeninsulaMorneMoangraveSomberSmithingStone1 = 1043307000,

        [Annotation(Name = "[啜泣半岛 - 摩恩悲叹墓] 火箭 1043307010")]
        WeepingPeninsulaMorneMoangraveFireArrow = 1043307010,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 火油脂 1043317000")]
        WeepingPeninsulaCastleMorneFireGrease = 1043317000,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317010")]
        WeepingPeninsulaCastleMorne = 1043317010,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 锻造石【２】 1043317020")]
        WeepingPeninsulaCastleMorneSmithingStone2 = 1043317020,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317030")]
        WeepingPeninsulaCastleMorne_ = 1043317030,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317040")]
        WeepingPeninsulaCastleMorne__ = 1043317040,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317050")]
        WeepingPeninsulaCastleMorne___ = 1043317050,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317060")]
        WeepingPeninsulaCastleMorne____ = 1043317060,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317070")]
        WeepingPeninsulaCastleMorne_____ = 1043317070,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 黄金卢恩【２】 1043317080")]
        WeepingPeninsulaCastleMorneGoldenRune2 = 1043317080,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 锻造石【２】 1043317090")]
        WeepingPeninsulaCastleMorneSmithingStone2_ = 1043317090,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317100")]
        WeepingPeninsulaCastleMorne______ = 1043317100,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 黄金卢恩【２】 1043317110")]
        WeepingPeninsulaCastleMorneGoldenRune2_ = 1043317110,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317120")]
        WeepingPeninsulaCastleMorne_______ = 1043317120,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317130")]
        WeepingPeninsulaCastleMorne________ = 1043317130,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 腌制龟颈肉 1043317140")]
        WeepingPeninsulaCastleMornePickledTurtleNeck = 1043317140,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317150")]
        WeepingPeninsulaCastleMorne_________ = 1043317150,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317160")]
        WeepingPeninsulaCastleMorne__________ = 1043317160,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 石剑钥匙 1043317170")]
        WeepingPeninsulaCastleMorneStoneswordKey = 1043317170,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317180")]
        WeepingPeninsulaCastleMorne___________ = 1043317180,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317190")]
        WeepingPeninsulaCastleMorne____________ = 1043317190,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317200")]
        WeepingPeninsulaCastleMorne_____________ = 1043317200,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317210")]
        WeepingPeninsulaCastleMorne______________ = 1043317210,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 褪色金轮草 1043317220")]
        WeepingPeninsulaCastleMorneTarnishedGoldenSunflower = 1043317220,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317230")]
        WeepingPeninsulaCastleMorne_______________ = 1043317230,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 锻造石【２】 1043317240")]
        WeepingPeninsulaCastleMorneSmithingStone2__ = 1043317240,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317250")]
        WeepingPeninsulaCastleMorne________________ = 1043317250,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317260")]
        WeepingPeninsulaCastleMorne_________________ = 1043317260,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317270")]
        WeepingPeninsulaCastleMorne__________________ = 1043317270,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 投掷匕首 1043317280")]
        WeepingPeninsulaCastleMorneThrowingDagger = 1043317280,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317290")]
        WeepingPeninsulaCastleMorne___________________ = 1043317290,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317300")]
        WeepingPeninsulaCastleMorne____________________ = 1043317300,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317310")]
        WeepingPeninsulaCastleMorne_____________________ = 1043317310,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 唤勾指药 1043317320")]
        WeepingPeninsulaCastleMorneFurlcallingFingerRemedy = 1043317320,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 钢丝火把 1043317330")]
        WeepingPeninsulaCastleMorneSteelWireTorch = 1043317330,

        [Annotation(Name = "[啜泣半岛 - 摩恩城]  1043317340")]
        WeepingPeninsulaCastleMorne______________________ = 1043317340,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 锻造石【１】 1043317350")]
        WeepingPeninsulaCastleMorneSmithingStone1 = 1043317350,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 弩炮箭 1043317360")]
        WeepingPeninsulaCastleMorneBallistaBolt = 1043317360,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 软鞭 1043317370")]
        WeepingPeninsulaCastleMorneWhip = 1043317370,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 黄金卢恩【１】 1043317400")]
        WeepingPeninsulaCastleMorneGoldenRune1 = 1043317400,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 锻造石【１】 1043317500")]
        WeepingPeninsulaCastleMorneSmithingStone1_ = 1043317500,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 双头剑护符 1043317900")]
        WeepingPeninsulaCastleMorneTwinbladeTalisman = 1043317900,

        [Annotation(Name = "[啜泣半岛 - 摩恩城] 大剑 1043317910")]
        WeepingPeninsulaCastleMorneClaymore = 1043317910,

        [Annotation(Name = "[啜泣半岛 - 病村外] 白色肉片 1044337030")]
        WeepingPeninsulaAilingVillageOutskirtsStripOfWhiteFlesh = 1044337030,

        [Annotation(Name = "[啜泣半岛 - 病村外]  1044337040")]
        WeepingPeninsulaAilingVillageOutskirts = 1044337040,

        [Annotation(Name = "[啜泣半岛 - 病村外] 黄金卢恩【２】 1044337050")]
        WeepingPeninsulaAilingVillageOutskirtsGoldenRune2 = 1044337050,

        [Annotation(Name = "[啜泣半岛 - 病村外]  1044337060")]
        WeepingPeninsulaAilingVillageOutskirts_ = 1044337060,

        [Annotation(Name = "[啜泣半岛 - 病村外] 黄金卢恩【２】 1044337070")]
        WeepingPeninsulaAilingVillageOutskirtsGoldenRune2_ = 1044337070,

        [Annotation(Name = "[啜泣半岛 - 病村外] 癫火 1044337080")]
        WeepingPeninsulaAilingVillageOutskirtsTheFlameOfFrenzy = 1044337080,

        [Annotation(Name = "[啜泣半岛 - 病村外] 锻造石【２】 1044337200")]
        WeepingPeninsulaAilingVillageOutskirtsSmithingStone2 = 1044337200,

        [Annotation(Name = "[啜泣半岛 - 病村外] 晨星锤 1044337210")]
        WeepingPeninsulaAilingVillageOutskirtsMorningStar = 1044337210,

        [Annotation(Name = "[宁姆格福 - 盖尔坑道（侧门口）] 黄金卢恩【１】 1046397000")]
        LimgraveRearGaelTunnelEntranceGoldenRune1 = 1046397000,

        [Annotation(Name = "[宁姆格福 - 盖尔坑道（侧门口）] 黄金卢恩【２】 1046397010")]
        LimgraveRearGaelTunnelEntranceGoldenRune2 = 1046397010,

        [Annotation(Name = "[宁姆格福 - 盖尔坑道（侧门口）] 黄金卢恩【３】 1046397020")]
        LimgraveRearGaelTunnelEntranceGoldenRune3 = 1046397020,

        [Annotation(Name = "[盖利德 - 熏火教堂] 蜕生蝶 1046407000")]
        CaelidSmolderingChurchNascentButterfly = 1046407000,

        [Annotation(Name = "[盖利德 - 熏火教堂] 卢恩弯弧 1046407010")]
        CaelidSmolderingChurchRuneArc = 1046407010,

        [Annotation(Name = "[盖利德 - 熏火教堂] 黄金卢恩【３】 1046407020")]
        CaelidSmolderingChurchGoldenRune3 = 1046407020,

        [Annotation(Name = "[盖利德 - 熏火教堂] 传道士的制作笔记【３】 67650")]
        CaelidSmolderingChurchMissionarysCookbook3 = 67650,

        [Annotation(Name = "[盖利德 - 熏火教堂] 腐败苔药 1046407040")]
        CaelidSmolderingChurchPreservingBoluses = 1046407040,

        [Annotation(Name = "[盖利德 - 熏火教堂] 流浪战士的制作笔记【１４】 67870")]
        CaelidSmolderingChurchNomadicWarriorsCookbook14 = 67870,

        [Annotation(Name = "[盖利德 - 熏火教堂] 附绳雷油脂 1046407060")]
        CaelidSmolderingChurchDrawstringLightningGrease = 1046407060,

        [Annotation(Name = "[盖利德 - 熏火教堂] 圣对蝎 1046407700")]
        CaelidSmolderingChurchSacredScorpionCharm = 1046407700,

        [Annotation(Name = "[盖利德 - 盖利德大道南方以西] 黄金卢恩【１】 1047377000")]
        CaelidWestOfCaelidHighwaySouthGoldenRune1 = 1047377000,

        [Annotation(Name = "[盖利德 - 盖利德大道南方以西] 黄金卢恩【５】 1047377010")]
        CaelidWestOfCaelidHighwaySouthGoldenRune5 = 1047377010,

        [Annotation(Name = "[盖利德 - 盖利德大道南方以西] 黄金卢恩【１】 1047377020")]
        CaelidWestOfCaelidHighwaySouthGoldenRune1_ = 1047377020,

        [Annotation(Name = "[盖利德 - 盖利德大道南方以西] 黄金卢恩【２】 1047377030")]
        CaelidWestOfCaelidHighwaySouthGoldenRune2 = 1047377030,

        [Annotation(Name = "[盖利德 - 盖利德大道南方以西] 毒花 1047377040")]
        CaelidWestOfCaelidHighwaySouthPoisonbloom = 1047377040,

        [Annotation(Name = "[盖利德 - 盖利德大道南方以西] 星光碎片 1047377050")]
        CaelidWestOfCaelidHighwaySouthStarlightShards = 1047377050,

        [Annotation(Name = "[盖利德 - 盖利德大道南方以西] 泪滴幼体 1047377100")]
        CaelidWestOfCaelidHighwaySouthLarvalTear = 1047377100,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 失色锻造石【４】 1047387010")]
        CaelidFortGaelSomberSmithingStone4 = 1047387010,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 大蜻蜓头部 1047387030")]
        CaelidFortGaelGreatDragonflyHead = 1047387030,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 腐败油脂 1047387040")]
        CaelidFortGaelRotGrease = 1047387040,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 卢恩弯弧 1047387070")]
        CaelidFortGaelRuneArc = 1047387070,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 温热石 1047387080")]
        CaelidFortGaelWarmingStone = 1047387080,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 火星蝶 1047387100")]
        CaelidFortGaelSmolderingButterfly = 1047387100,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 蘑菇 1047387110")]
        CaelidFortGaelMushroom = 1047387110,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 火焰啊，赐予我力量！ 1047387120")]
        CaelidFortGaelFlameGrantMeStrength = 1047387120,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 爆炸大弩箭 1047387130")]
        CaelidFortGaelExplosiveGreatbolt = 1047387130,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 战灰：狮子斩 1047387700")]
        CaelidFortGaelAshOfWarLionsClaw = 1047387700,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 碎星的传说 1047387900")]
        CaelidFortGaelStarscourgeHeirloom = 1047387900,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 铁陨石刀 1047387910")]
        CaelidFortGaelMeteoricOreBlade = 1047387910,

        [Annotation(Name = "[盖利德 - 盖尔要塞] 拳剑 1047387920")]
        CaelidFortGaelKatar = 1047387920,

        [Annotation(Name = "[盖利德 - 盖尔要塞北方] 锻造石【５】 1047397000")]
        CaelidFortGaelNorthSmithingStone5 = 1047397000,

        [Annotation(Name = "[盖利德 - 盖尔要塞北方] 黄金卢恩【９】 1047397040")]
        CaelidFortGaelNorthGoldenRune9 = 1047397040,

        [Annotation(Name = "[盖利德 - 盖尔要塞北方] 眠卵 1047397080")]
        CaelidFortGaelNorthSlumberingEgg = 1047397080,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 黄金卢恩【５】 1047407000")]
        CaelidCaelemRuinsGoldenRune5 = 1047407000,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 龟裂壶 66190")]
        CaelidCaelemRuinsCrackedPot = 66190,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 锻造石【４】 1047407020")]
        CaelidCaelemRuinsSmithingStone4 = 1047407020,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 失色锻造石【４】 1047407030")]
        CaelidCaelemRuinsSomberSmithingStone4 = 1047407030,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 爆炸弩箭 1047407040")]
        CaelidCaelemRuinsExplosiveBolt = 1047407040,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 附绳火油脂 1047407070")]
        CaelidCaelemRuinsDrawstringFireGrease = 1047407070,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 火星蝶 1047407080")]
        CaelidCaelemRuinsSmolderingButterfly = 1047407080,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 卢恩弯弧 1047407900")]
        CaelidCaelemRuinsRuneArc = 1047407900,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 托莉娜剑 1047407910")]
        CaelidCaelemRuinsSwordOfStTrina = 1047407910,

        [Annotation(Name = "[盖利德 - 奇列姆废墟] 巨剑 1047407920")]
        CaelidCaelemRuinsGreatsword = 1047407920,

        [Annotation(Name = "[盖利德 - 龙飨大教堂] 古龙信徒的制作笔记【３】 68030")]
        CaelidCathedralOfDragonCommunionAncientDragonApostlesCookbook3 = 68030,

        [Annotation(Name = "[盖利德 - 盖利德大道南方] 蟹卵 1048377000")]
        CaelidCaelidHighwaySouthCrabEggs = 1048377000,

        [Annotation(Name = "[盖利德 - 盖利德大道南方] 黄金卢恩【３】 1048377020")]
        CaelidCaelidHighwaySouthGoldenRune3 = 1048377020,

        [Annotation(Name = "[盖利德 - 盖利德大道南方] 黄金卢恩【４】 1048377030")]
        CaelidCaelidHighwaySouthGoldenRune4 = 1048377030,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽西] 黄金卢恩【４】 1048387000")]
        CaelidWestAeoniaSwampGoldenRune4 = 1048387000,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽西] 调香瓶 66790")]
        CaelidWestAeoniaSwampPerfumeBottle = 66790,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽西] 旅行帽子 1048387010")]
        CaelidWestAeoniaSwampTravelersHat = 1048387010,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽西] 黄金卢恩【５】 1048387020")]
        CaelidWestAeoniaSwampGoldenRune5 = 1048387020,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽西] 圣血木芽 1048387500")]
        CaelidWestAeoniaSwampSacramentalBud = 1048387500,

        [Annotation(Name = "[盖利德 - 熏烧火墙] 圣血木芽 1048397000")]
        CaelidSmolderingWallSacramentalBud = 1048397000,

        [Annotation(Name = "[盖利德 - 熏烧火墙] 失色锻造石【５】 1048397010")]
        CaelidSmolderingWallSomberSmithingStone5 = 1048397010,

        [Annotation(Name = "[盖利德 - 熏烧火墙] 大蜻蜓头部 1048397040")]
        CaelidSmolderingWallGreatDragonflyHead = 1048397040,

        [Annotation(Name = "[盖利德 - 熏烧火墙] 石剑钥匙 1048397050")]
        CaelidSmolderingWallStoneswordKey = 1048397050,

        [Annotation(Name = "[盖利德 - 熏烧火墙] 岩石球 1048397900")]
        CaelidSmolderingWallRockSling = 1048397900,

        [Annotation(Name = "[盖利德 - 希芙拉河的出口井] 黄金卢恩【１】 1048407010")]
        CaelidDeepSiofraWellGoldenRune1 = 1048407010,

        [Annotation(Name = "[盖利德 - 希芙拉河的出口井] 黄金卢恩【６】 1048407020")]
        CaelidDeepSiofraWellGoldenRune6 = 1048407020,

        [Annotation(Name = "[盖利德 - 希芙拉河的出口井] 黄金卢恩【２】 1048407030")]
        CaelidDeepSiofraWellGoldenRune2 = 1048407030,

        [Annotation(Name = "[盖利德 - 希芙拉河的出口井] 圣血木芽 1048407040")]
        CaelidDeepSiofraWellSacramentalBud = 1048407040,

        [Annotation(Name = "[盖利德 - 希芙拉河的出口井] 粗大兽骨 1048407050")]
        CaelidDeepSiofraWellHeftyBeastBone = 1048407050,

        [Annotation(Name = "[盖利德 - 希芙拉河的出口井] 钉墙盾 1048407060")]
        CaelidDeepSiofraWellSpikedPalisadeShield = 1048407060,

        [Annotation(Name = "[盖利德 - 希芙拉河的出口井] 颜面盾 1048407900")]
        CaelidDeepSiofraWellVisageShield = 1048407900,

        [Annotation(Name = "[桂奥尔龙墓 - 隐居商人的破屋] 重力贩子的铃珠 1048417800")]
        GreyollsDragonbarrowIsolatedMerchantsShackGravityStonePeddlersBellBearing = 1048417800,

        [Annotation(Name = "[盖利德 - 盖利德大道南方西南] 火星蝶 1049367000")]
        CaelidSouthwestOfCaelidHighwaySouthSmolderingButterfly = 1049367000,

        [Annotation(Name = "[盖利德 - 盖利德大道南方西南] 扇形暗器 1049367010")]
        CaelidSouthwestOfCaelidHighwaySouthFanDaggers = 1049367010,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 风结晶露滴 65150")]
        CaelidSouthernAeoniaSwampBankWindyCrystalTear = 65150,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 野兽血液 1049377010")]
        CaelidSouthernAeoniaSwampBankBeastBlood = 1049377010,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 黄金种子 1049377020")]
        CaelidSouthernAeoniaSwampBankGoldenSeed = 1049377020,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 野兽血液 1049377050")]
        CaelidSouthernAeoniaSwampBankBeastBlood_ = 1049377050,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 黄金卢恩【２】 1049377070")]
        CaelidSouthernAeoniaSwampBankGoldenRune2 = 1049377070,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 战灰：双吻毒蛾 1049377100")]
        CaelidSouthernAeoniaSwampBankAshOfWarPoisonMothFlight = 1049377100,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 死亡钩棒 1049377110")]
        CaelidSouthernAeoniaSwampBankDeathsPoker = 1049377110,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 失色锻造石【４】 1049377700")]
        CaelidSouthernAeoniaSwampBankSomberSmithingStone4 = 1049377700,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 亘古黑暗 1049387800")]
        CaelidEastAeoniaSwampEternalDarkness = 1049387800,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 失色锻造石【４】 1049387010")]
        CaelidEastAeoniaSwampSomberSmithingStone4 = 1049387010,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 艾奥尼亚蝶 1049387020")]
        CaelidEastAeoniaSwampAeonianButterfly = 1049387020,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 锻造石【４】 1049387030")]
        CaelidEastAeoniaSwampSmithingStone4 = 1049387030,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 黑键木桩 1049387040")]
        CaelidEastAeoniaSwampBlackKeyBolt = 1049387040,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 圣血木芽 1049387060")]
        CaelidEastAeoniaSwampSacramentalBud = 1049387060,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 卢恩弯弧 1049387070")]
        CaelidEastAeoniaSwampRuneArc = 1049387070,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 黄金卢恩【４】 1049387080")]
        CaelidEastAeoniaSwampGoldenRune4 = 1049387080,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 黄金卢恩【５】 1049387110")]
        CaelidEastAeoniaSwampGoldenRune5 = 1049387110,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽东] 玻璃碎片 1049387120")]
        CaelidEastAeoniaSwampGlassShard = 1049387120,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 石剑钥匙 1049397000")]
        CaelidWestSelliaStoneswordKey = 1049397000,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 毒花 1049397010")]
        CaelidWestSelliaPoisonbloom = 1049397010,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 卢恩弯弧 1049397020")]
        CaelidWestSelliaRuneArc = 1049397020,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 丧失杖 1049397030")]
        CaelidWestSelliaStaffOfLoss = 1049397030,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 腐败野狗的骨灰 1049397040")]
        CaelidWestSelliaRottenStrayAshes = 1049397040,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 诺克斯流体剑 1049397800")]
        CaelidWestSelliaNoxFlowingSword = 1049397800,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 战场魔法师犹格 1049397850")]
        CaelidWestSelliaBattlemageHugues = 1049397850,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 卢瑟特的辉石杖 1049397900")]
        CaelidWestSelliaLusatsGlintstoneStaff = 1049397900,

        [Annotation(Name = "[盖利德 - 瑟利亚以西] 魔力龙徽护符＋１ 1049397910")]
        CaelidWestSelliaSpelldrakeTalisman1 = 1049397910,

        [Annotation(Name = "[桂奥尔龙墓 - 希芙拉河的出口井] 地图碎片：龙墓 62041")]
        GreyollsDragonbarrowDeepSiofraWellMapDragonbarrow = 62041,

        [Annotation(Name = "[盖利德 - 艾奥尼亚沼泽（南岸）] 地图碎片：盖利德 62040")]
        CaelidSouthernAeoniaSwampBankMapCaelid = 62040,

        [Annotation(Name = "[桂奥尔龙墓 - 希芙拉河的出口井] 黄金卢恩【５】 1049407000")]
        GreyollsDragonbarrowDeepSiofraWellGoldenRune5 = 1049407000,

        [Annotation(Name = "[桂奥尔龙墓 - 希芙拉河的出口井] 碎石 1049407010")]
        GreyollsDragonbarrowDeepSiofraWellGravelStone = 1049407010,

        [Annotation(Name = "[桂奥尔龙墓 - 希芙拉河的出口井] 肉片 1049407020")]
        GreyollsDragonbarrowDeepSiofraWellSliverOfMeat = 1049407020,

        [Annotation(Name = "[桂奥尔龙墓 - 希芙拉河的出口井] 锻造石【５】 1049407040")]
        GreyollsDragonbarrowDeepSiofraWellSmithingStone5 = 1049407040,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔入口] 亚缇莉亚叶 1049417040")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceArteriaLeaf = 1049417040,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔入口] 伤龙油脂 1049417070")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceDragonwoundGrease = 1049417070,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔入口] 卢恩弯弧 1049417080")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceRuneArc = 1049417080,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔入口] 失色锻造石【９】 1049417090")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceSomberSmithingStone9 = 1049417090,

        [Annotation(Name = "[桂奥尔龙墓 - 盖利德神授塔入口] 稀人卢恩 1049417100")]
        GreyollsDragonbarrowDivineTowerOfCaelidEntranceNumensRune = 1049417100,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 黑夜彗星 1050397900")]
        CaelidEastSelliaNightComet = 1050397900,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 魔石剑钥匙 1050397910")]
        CaelidEastSelliaImbuedSwordKey = 1050397910,

        [Annotation(Name = "[盖利德 - 不破大桥] 蘑菇 1050367000")]
        CaelidImpassableGreatbridgeMushroom = 1050367000,

        [Annotation(Name = "[盖利德 - 不破大桥] 硬箭护符 1050367900")]
        CaelidImpassableGreatbridgeArrowsStingTalisman = 1050367900,

        [Annotation(Name = "[盖利德 - 格威的破屋] 黄金卢恩【５】 1050387000")]
        CaelidGowrysShackGoldenRune5 = 1050387000,

        [Annotation(Name = "[盖利德 - 格威的破屋] 附绳中毒油脂 1050387010")]
        CaelidGowrysShackDrawstringPoisonGrease = 1050387010,

        [Annotation(Name = "[盖利德 - 格威的破屋] 圣杯露滴 1050387020")]
        CaelidGowrysShackSacredTear = 1050387020,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 中毒油脂 1050397000")]
        CaelidEastSelliaPoisonGrease = 1050397000,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 毒霉蘑菇 1050397010")]
        CaelidEastSelliaToxicMushroom = 1050397010,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 锻造石【７】 1050397020")]
        CaelidEastSelliaSmithingStone7 = 1050397020,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 锻造石【７】 1050397030")]
        CaelidEastSelliaSmithingStone7_ = 1050397030,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 石剑钥匙 1050397040")]
        CaelidEastSelliaStoneswordKey = 1050397040,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 锻造石【８】 1050397050")]
        CaelidEastSelliaSmithingStone8 = 1050397050,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 星光碎片 1050397060")]
        CaelidEastSelliaStarlightShards = 1050397060,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 蓝露滴粪金龟 1050397070")]
        CaelidEastSelliaCeruleanTearScarab = 1050397070,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 野兽血液 1050397090")]
        CaelidEastSelliaBeastBlood = 1050397090,

        [Annotation(Name = "[盖利德 - 瑟利亚以东] 黄金种子 1050397100")]
        CaelidEastSelliaGoldenSeed = 1050397100,

        [Annotation(Name = "[桂奥尔龙墓 - 龙墓的岔路] 龙心脏 1050407800")]
        GreyollsDragonbarrowDragonbarrowForkDragonHeart = 1050407800,

        [Annotation(Name = "[盖利德 - 红狮子城南边悬崖] 火星蝶 1051357000")]
        CaelidRedmaneCastleSouthCliffsideSmolderingButterfly = 1051357000,

        [Annotation(Name = "[盖利德 - 红狮子城] 黄金卢恩【６】 1051367000")]
        CaelidRedmaneCastleGoldenRune6 = 1051367000,

        [Annotation(Name = "[盖利德 - 红狮子城] 武器工匠的制作笔记【４】 67260")]
        CaelidRedmaneCastleArmorersCookbook4 = 67260,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【６】 1051367020")]
        CaelidRedmaneCastleSmithingStone6 = 1051367020,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【３】 1051367030")]
        CaelidRedmaneCastleSmithingStone3 = 1051367030,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【４】 1051367040")]
        CaelidRedmaneCastleSmithingStone4 = 1051367040,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【３】 1051367050")]
        CaelidRedmaneCastleSmithingStone3_ = 1051367050,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【５】 1051367060")]
        CaelidRedmaneCastleSmithingStone5 = 1051367060,

        [Annotation(Name = "[盖利德 - 红狮子城] 灼热砥石刀 65640")]
        CaelidRedmaneCastleRedHotWhetblade = 65640,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【５】 1051367080")]
        CaelidRedmaneCastleSmithingStone5_ = 1051367080,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【４】 1051367090")]
        CaelidRedmaneCastleSmithingStone4_ = 1051367090,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【６】 1051367100")]
        CaelidRedmaneCastleSmithingStone6_ = 1051367100,

        [Annotation(Name = "[盖利德 - 红狮子城] 失色锻造石【５】 1051367110")]
        CaelidRedmaneCastleSomberSmithingStone5 = 1051367110,

        [Annotation(Name = "[盖利德 - 红狮子城] 武器工匠的制作笔记【５】 67310")]
        CaelidRedmaneCastleArmorersCookbook5 = 67310,

        [Annotation(Name = "[盖利德 - 红狮子城] 焰形大剑 1051367130")]
        CaelidRedmaneCastleFlamberge = 1051367130,

        [Annotation(Name = "[盖利德 - 红狮子城] 失色锻造石【４】 1051367700")]
        CaelidRedmaneCastleSomberSmithingStone4 = 1051367700,

        [Annotation(Name = "[盖利德 - 红狮子城] 失色锻造石【４】 1051367800")]
        CaelidRedmaneCastleSomberSmithingStone4_ = 1051367800,

        [Annotation(Name = "[盖利德 - 红狮子城] 锻造石【６】 1051367910")]
        CaelidRedmaneCastleSmithingStone6__ = 1051367910,

        [Annotation(Name = "[盖利德 - 拉塔恩战场西边] 拉塔恩的矛 1051387000")]
        CaelidWestRadahnArenaRadahnsSpear = 1051387000,

        [Annotation(Name = "[盖利德 - 拉塔恩战场西边] 拉塔恩的矛 1051387010")]
        CaelidWestRadahnArenaRadahnsSpear_ = 1051387010,

        [Annotation(Name = "[盖利德 - 拉塔恩战场西边] 拉塔恩的矛 1051387020")]
        CaelidWestRadahnArenaRadahnsSpear__ = 1051387020,

        [Annotation(Name = "[桂奥尔龙墓 - 法洛斯要塞] 黄金卢恩【１２】 1051397040")]
        GreyollsDragonbarrowFortFarothGoldenRune12 = 1051397040,

        [Annotation(Name = "[桂奥尔龙墓 - 法洛斯要塞] 中毒苔药 1051397050")]
        GreyollsDragonbarrowFortFarothNeutralizingBoluses = 1051397050,

        [Annotation(Name = "[桂奥尔龙墓 - 法洛斯要塞] 拉达冈的糜烂烙印 1051397060")]
        GreyollsDragonbarrowFortFarothRadagonsSoreseal = 1051397060,

        [Annotation(Name = "[桂奥尔龙墓 - 法洛斯要塞] 迪可达斯符节（右） 1051397900")]
        GreyollsDragonbarrowFortFarothDectusMedallionRight = 1051397900,

        [Annotation(Name = "[桂奥尔龙墓 - 小黄金树] 卢恩弯弧 1051407040")]
        GreyollsDragonbarrowMinorErdtreeRuneArc = 1051407040,

        [Annotation(Name = "[桂奥尔龙墓 - 野兽神殿] 柔软棉花 1051417000")]
        GreyollsDragonbarrowBestialSanctumSoftCotton = 1051417000,

        [Annotation(Name = "[桂奥尔龙墓 - 野兽神殿] 五指剑 1051417010")]
        GreyollsDragonbarrowBestialSanctumCinquedea = 1051417010,

        [Annotation(Name = "[桂奥尔龙墓 - 野兽神殿] 黄金种子 1051437020")]
        GreyollsDragonbarrowBestialSanctumGoldenSeed = 1051437020,

        [Annotation(Name = "[桂奥尔龙墓 - 野兽神殿] 龙徽盾护符 1051417030")]
        GreyollsDragonbarrowBestialSanctumDragoncrestShieldTalisman = 1051417030,

        [Annotation(Name = "[桂奥尔龙墓 - 法姆大桥东南] 黄金卢恩【８】 1052417000")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune8 = 1052417000,

        [Annotation(Name = "[桂奥尔龙墓 - 法姆大桥东南] 黄金卢恩【６】 1052417010")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune6 = 1052417010,

        [Annotation(Name = "[桂奥尔龙墓 - 法姆大桥东南] 黄金卢恩【３】 1052417020")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune3 = 1052417020,

        [Annotation(Name = "[桂奥尔龙墓 - 法姆大桥东南] 黄金卢恩【１】 1052417030")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeGoldenRune1 = 1052417030,

        [Annotation(Name = "[桂奥尔龙墓 - 法姆大桥东南] 战灰：猎犬步法 1052417100")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeAshOfWarBloodhoundsStep = 1052417100,

        [Annotation(Name = "[桂奥尔龙墓 - 法姆大桥东南] 记忆石 60460")]
        GreyollsDragonbarrowSoutheastFarumGreatbridgeMemoryStone = 60460,

        [Annotation(Name = "[桂奥尔龙墓 - 东北悬崖边] 星光碎片 1052437000")]
        GreyollsDragonbarrowNortheastCliffsideStarlightShards = 1052437000,

        [Annotation(Name = "[湖之利耶尼亚 - 学院正门口] 黄金种子 1035467100")]
        LiurniaOfTheLakesMainAcademyGateGoldenSeed = 1035467100,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西南] 黄金种子 1036447300")]
        LiurniaOfTheLakesGateTownSouthwestGoldenSeed = 1036447300,

        [Annotation(Name = "[湖之利耶尼亚 - 伊利斯教堂] 圣杯露滴 1039397000")]
        LiurniaOfTheLakesChurchOfIrithSacredTear = 1039397000,

        [Annotation(Name = "[湖之利耶尼亚 - 谷底东南] 圣杯露滴 1036497000")]
        LiurniaOfTheLakesSoutheastRavineSacredTear = 1036497000,

        [Annotation(Name = "[彼鲁姆大道 - 镇静教堂] 圣杯露滴 1037497100")]
        BellumHighwayChurchOfInhibitionSacredTear = 1037497100,

        [Annotation(Name = "[湖之利耶尼亚 - 远眺岛以西] 灵巧瘤结晶露滴 65220")]
        LiurniaOfTheLakesWestOfScenicIsleDexterityknotCrystalTear = 65220,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨以南] 智力瘤结晶露滴 65230")]
        LiurniaOfTheLakesSouthOfCariaManorIntelligenceknotCrystalTear = 65230,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西北] 古老死亡怨魂 1036457400")]
        LiurniaOfTheLakesGateTownNorthwestAncientDeathRancor = 1036457400,

        [Annotation(Name = "[彼鲁姆大道 - 雷亚卢卡利亚（东门）] 战灰：狩猎巨人 1036487400")]
        BellumHighwayEastRayaLucariaGateAshOfWarGiantHunt = 1036487400,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 红羽七刃剑 1037427400")]
        LiurniaOfTheLakesLaskyarRuinsRedFeatheredBranchsword = 1037427400,

        [Annotation(Name = "[湖之利耶尼亚 - 结缘教堂] 兽肉贩子的铃珠 1037467400")]
        LiurniaOfTheLakesChurchOfVowsMeatPeddlersBellBearing = 1037467400,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 战灰：冰枪 1039437400")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthAshOfWarIceSpear = 1039437400,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇大桥以北] 龙信仰祷告书 1038447100")]
        LiurniaOfTheLakesNorthOfGateTownBridgeDragonCultPrayerbook = 1038447100,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427200")]
        MoonlightAltarCathedralOfManusCelesStarlightShards = 1035427200,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 星光碎片 1039437100")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthStarlightShards = 1039437100,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨（后方）] 黄金卢恩【３】 1036507010")]
        LiurniaOfTheLakesBehindCariaManorGoldenRune3 = 1036507010,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨（后方）] 冻伤苔药 1036507020")]
        LiurniaOfTheLakesBehindCariaManorThawfrostBoluses = 1036507020,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨（后方）] 白金之子的骨灰 1036507030")]
        LiurniaOfTheLakesBehindCariaManorAlbinauricAshes = 1036507030,

        [Annotation(Name = "[湖之利耶尼亚 - 傍湖断崖] 学院卷轴 1039407000")]
        LiurniaOfTheLakesLakeFacingCliffsAcademyScroll = 1039407000,

        [Annotation(Name = "[湖之利耶尼亚 - 伊利斯教堂以西] 温热石 1038397000")]
        LiurniaOfTheLakesWestOfChurchOfIrithWarmingStone = 1038397000,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚湖（湖边）] 火星蝶 1038407000")]
        LiurniaOfTheLakesLiurniaLakeShoreSmolderingButterfly = 1038407000,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚湖（湖边）] 辉石工匠的制作笔记【１】 67410")]
        LiurniaOfTheLakesLiurniaLakeShoreGlintstoneCraftsmansCookbook1 = 67410,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 黄金卢恩【３】 1039417000")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune3 = 1039417000,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 杜鹃辉石 1039417010")]
        LiurniaOfTheLakesPurifiedRuinsCuckooGlintstone = 1039417010,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 失色锻造石【２】 1039417020")]
        LiurniaOfTheLakesPurifiedRuinsSomberSmithingStone2 = 1039417020,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 风暴鹰羽毛 1039417030")]
        LiurniaOfTheLakesPurifiedRuinsStormhawkFeather = 1039417030,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 双指的传说 1039417100")]
        LiurniaOfTheLakesPurifiedRuinsTwoFingersHeirloom = 1039417100,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 夏玻利利葡萄 1039417200")]
        LiurniaOfTheLakesPurifiedRuinsShabririGrape = 1039417200,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 黄金卢恩【６】 1039417300")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune6 = 1039417300,

        [Annotation(Name = "[湖之利耶尼亚 - 受净化的废墟] 黄金卢恩【６】 1039417310")]
        LiurniaOfTheLakesPurifiedRuinsGoldenRune6_ = 1039417310,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 蘑菇 1039427000")]
        LiurniaOfTheLakesLiurniaHighwayNorthMushroom = 1039427000,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 结晶飞刀 1039427010")]
        LiurniaOfTheLakesLiurniaHighwayNorthCrystalDart = 1039427010,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【６】 1039427020")]
        LiurniaOfTheLakesLiurniaHighwayNorthGoldenRune6 = 1039427020,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【３】 1039427030")]
        LiurniaOfTheLakesLiurniaHighwayNorthGoldenRune3 = 1039427030,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 野兽血液 1039427040")]
        LiurniaOfTheLakesLiurniaHighwayNorthBeastBlood = 1039427040,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 琉森戟 1039427050")]
        LiurniaOfTheLakesLiurniaHighwayNorthLucerne = 1039427050,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 黄金卢恩【３】 1037427000")]
        LiurniaOfTheLakesLaskyarRuinsGoldenRune3 = 1037427000,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 玻璃碎片 1037427030")]
        LiurniaOfTheLakesLaskyarRuinsGlassShard = 1037427030,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 仪式壶 66420")]
        LiurniaOfTheLakesLaskyarRuinsRitualPot = 66420,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 召咒魂铃 1037427900")]
        LiurniaOfTheLakesLaskyarRuinsWraithCallingBell = 1037427900,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙以南] 墓地紫花 1037477000")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundGraveViolet = 1037477000,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙以南] 亚缇莉亚叶 1037477010")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundArteriaLeaf = 1037477010,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙以南] 健壮角饰品 1037477020")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundStalwartHornCharm = 1037477020,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙以南] 旋角盾 1037477030")]
        LiurniaOfTheLakesSouthOfMausoleumCompoundSpiralhornShield = 1037477030,

        [Annotation(Name = "[湖之利耶尼亚 - 眠狼的破屋] 火焰习武修士祷告书 1036417000")]
        LiurniaOfTheLakesSlumberingWolfsShackFireMonksPrayerbook = 1036417000,

        [Annotation(Name = "[湖之利耶尼亚 - 眠狼的破屋] 斑斓肉干 1036417010")]
        LiurniaOfTheLakesSlumberingWolfsShackDappledCuredMeat = 1036417010,

        [Annotation(Name = "[湖之利耶尼亚 - 眠狼的破屋] 卢恩弯弧 1036417020")]
        LiurniaOfTheLakesSlumberingWolfsShackRuneArc = 1036417020,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西南] 结晶木芽 1036447000")]
        LiurniaOfTheLakesGateTownSouthwestCrystalBud = 1036447000,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西南] 亚缇莉亚叶 1036447010")]
        LiurniaOfTheLakesGateTownSouthwestArteriaLeaf = 1036447010,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西南] 锻造石【２】 1036447040")]
        LiurniaOfTheLakesGateTownSouthwestSmithingStone2 = 1036447040,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西南] 碎片生音箭（附箭羽） 1036447050")]
        LiurniaOfTheLakesGateTownSouthwestShattershardArrowFletched = 1036447050,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西南] 辉石萤火虫 1036447060")]
        LiurniaOfTheLakesGateTownSouthwestGlintstoneFirefly = 1036447060,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西南] 辉石工匠的制作笔记【４】 67400")]
        LiurniaOfTheLakesGateTownSouthwestGlintstoneCraftsmansCookbook4 = 67400,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西北] 洞窟苔藓的结晶 1036457020")]
        LiurniaOfTheLakesGateTownNorthwestCrystalCaveMoss = 1036457020,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇西北] 石剑钥匙 1036457110")]
        LiurniaOfTheLakesGateTownNorthwestStoneswordKey = 1036457110,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以南] 失色锻造石【１】 1035437010")]
        LiurniaOfTheLakesSouthRoseChurchSomberSmithingStone1 = 1035437010,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以南] 泪滴幼体 1035437100")]
        LiurniaOfTheLakesSouthRoseChurchLarvalTear = 1035437100,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 锻造石【３】 1035447000")]
        LiurniaOfTheLakesNorthRoseChurchSmithingStone3 = 1035447000,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【１】 1035447010")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune1 = 1035447010,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【４】 1035447020")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune4 = 1035447020,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【３】 1035447030")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune3 = 1035447030,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【２】 1035447040")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2 = 1035447040,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【４】 1035447050")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune4_ = 1035447050,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【２】 1035447060")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2_ = 1035447060,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【１】 1035447070")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune1_ = 1035447070,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【５】 1035447080")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune5 = 1035447080,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【２】 1035447090")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune2__ = 1035447090,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 黄金卢恩【３】 1035447100")]
        LiurniaOfTheLakesNorthRoseChurchGoldenRune3_ = 1035447100,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 锻造石【２】 1035447110")]
        LiurniaOfTheLakesNorthRoseChurchSmithingStone2 = 1035447110,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 蓝白木盾 1035447120")]
        LiurniaOfTheLakesNorthRoseChurchBlueWhiteWoodenShield = 1035447120,

        [Annotation(Name = "[湖之利耶尼亚 - 蔷薇教堂以北] 流浪战士的制作笔记【１２】 67060")]
        LiurniaOfTheLakesNorthRoseChurchNomadicWarriorsCookbook12 = 67060,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚（南门）] 星星泪滴 1035457000")]
        LiurniaOfTheLakesSouthRayaLucariaGateCelestialDew = 1035457000,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚（南门）] 白色肉片 1035457030")]
        LiurniaOfTheLakesSouthRayaLucariaGateStripOfWhiteFlesh = 1035457030,

        [Annotation(Name = "[湖之利耶尼亚 - 学院正门口] 石剑钥匙 1035467020")]
        LiurniaOfTheLakesMainAcademyGateStoneswordKey = 1035467020,

        [Annotation(Name = "[湖之利耶尼亚 - 学院正门口] 战灰：潜雾猛禽 1035467700")]
        LiurniaOfTheLakesMainAcademyGateAshOfWarRaptorOfTheMists = 1035467700,

        [Annotation(Name = "[湖之利耶尼亚 - 提斯魔法师塔] 黄金卢恩【１】 1035477000")]
        LiurniaOfTheLakesTestusRiseGoldenRune1 = 1035477000,

        [Annotation(Name = "[湖之利耶尼亚 - 教堂区] 冰结晶木芽 1034447000")]
        LiurniaOfTheLakesTempleQuarterRimedCrystalBud = 1034447000,

        [Annotation(Name = "[湖之利耶尼亚 - 教堂区] 锻造石【２】 1034447010")]
        LiurniaOfTheLakesTempleQuarterSmithingStone2 = 1034447010,

        [Annotation(Name = "[湖之利耶尼亚 - 教堂区] 冻壳斧 1034447900")]
        LiurniaOfTheLakesTempleQuarterIcerindHatchet = 1034447900,

        [Annotation(Name = "[湖之利耶尼亚 - 结缘教堂] 黄金缝衣针 1037467000")]
        LiurniaOfTheLakesChurchOfVowsGoldSewingNeedle = 1037467000,

        [Annotation(Name = "[湖之利耶尼亚 - 结缘教堂] 黄金裁缝工具 60150")]
        LiurniaOfTheLakesChurchOfVowsGoldenTailoringTools = 60150,

        [Annotation(Name = "[湖之利耶尼亚 - 结缘教堂] 风暴鹰羽毛 1037467010")]
        LiurniaOfTheLakesChurchOfVowsStormhawkFeather = 1037467010,

        [Annotation(Name = "[湖之利耶尼亚 - 大道监视塔] 锻造石【２】 1038427000")]
        LiurniaOfTheLakesHighwayLookoutTowerSmithingStone2 = 1038427000,

        [Annotation(Name = "[湖之利耶尼亚 - 大道监视塔] 黄金卢恩【４】 1038427010")]
        LiurniaOfTheLakesHighwayLookoutTowerGoldenRune4 = 1038427010,

        [Annotation(Name = "[湖之利耶尼亚 - 大道监视塔] 卡利亚辉剑杖 1038427020")]
        LiurniaOfTheLakesHighwayLookoutTowerCarianGlintbladeStaff = 1038427020,

        [Annotation(Name = "[湖之利耶尼亚 - 大道监视塔] 辉石工匠的制作笔记【３】 67480")]
        LiurniaOfTheLakesHighwayLookoutTowerGlintstoneCraftsmansCookbook3 = 67480,

        [Annotation(Name = "[湖之利耶尼亚 - 提斯魔法师塔] 锻造石【２】 1035477010")]
        LiurniaOfTheLakesTestusRiseSmithingStone2 = 1035477010,

        [Annotation(Name = "[湖之利耶尼亚 - 提斯魔法师塔] 记忆石 60420")]
        LiurniaOfTheLakesTestusRiseMemoryStone = 60420,

        [Annotation(Name = "[彼鲁姆大道 - 改宗边境塔] 结晶飞刀 1039487000")]
        BellumHighwayConvertedFringeTowerCrystalDart = 1039487000,

        [Annotation(Name = "[彼鲁姆大道 - 改宗边境塔] 海摩炮弹 1039487100")]
        BellumHighwayConvertedFringeTowerCannonOfHaima = 1039487100,

        [Annotation(Name = "[月光祭坛] 菈妮的暗月 1033407100")]
        MoonlightAltarRannisDarkMoon = 1033407100,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼山脚] 白色肉片 1033467000")]
        LiurniaOfTheLakesFootOfTheFourBelfriesStripOfWhiteFlesh = 1033467000,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼山脚] 出血油脂 1033467030")]
        LiurniaOfTheLakesFootOfTheFourBelfriesBloodGrease = 1033467030,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼山脚] 水母盾 1033467040")]
        LiurniaOfTheLakesFootOfTheFourBelfriesJellyfishShield = 1033467040,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼] 魔石剑钥匙 1033477020")]
        LiurniaOfTheLakesTheFourBelfriesImbuedSwordKey = 1033477020,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼] 白金凝血 1033477900")]
        LiurniaOfTheLakesTheFourBelfriesAlbinauricBloodclot = 1033477900,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼] 杜鹃辉石 1033477910")]
        LiurniaOfTheLakesTheFourBelfriesCuckooGlintstone = 1033477910,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【３】 1034507010")]
        LiurniaOfTheLakesRannisRiseGoldenRune3 = 1034507010,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【４】 1034507020")]
        LiurniaOfTheLakesRannisRiseGoldenRune4 = 1034507020,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【５】 1034507030")]
        LiurniaOfTheLakesRannisRiseGoldenRune5 = 1034507030,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【１】 1034507040")]
        LiurniaOfTheLakesRannisRiseGoldenRune1 = 1034507040,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【３】 1034507050")]
        LiurniaOfTheLakesRannisRiseGoldenRune3_ = 1034507050,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【３】 1034507060")]
        LiurniaOfTheLakesRannisRiseGoldenRune3__ = 1034507060,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【２】 1034507070")]
        LiurniaOfTheLakesRannisRiseGoldenRune2 = 1034507070,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黄金卢恩【３】 1034507080")]
        LiurniaOfTheLakesRannisRiseGoldenRune3___ = 1034507080,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 黑狼面具 1034507090")]
        LiurniaOfTheLakesRannisRiseBlackWolfMask = 1034507090,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔] 记忆石 60430")]
        LiurniaOfTheLakesRannisRiseMemoryStone = 60430,

        [Annotation(Name = "[湖之利耶尼亚 - 菈妮魔法师塔]  1034507200")]
        LiurniaOfTheLakesRannisRise = 1034507200,

        [Annotation(Name = "[湖之利耶尼亚 - 蕾娜魔法师塔] 雪魔女长裙 1034517900")]
        LiurniaOfTheLakesRennasRiseSnowWitchSkirt = 1034517900,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 投掷匕首 1034477000")]
        LiurniaOfTheLakesSorcerersIsleWestThrowingDagger = 1034477000,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【２】 1034477500")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2 = 1034477500,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【１】 1034477110")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune1 = 1034477110,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【３】 1034477120")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3 = 1034477120,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【３】 1034477130")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3_ = 1034477130,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【１】 1034477140")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune1_ = 1034477140,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【５】 1034477150")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune5 = 1034477150,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【３】 1034477160")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3__ = 1034477160,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【２】 1034477170")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2_ = 1034477170,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【３】 1034477180")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3___ = 1034477180,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【３】 1034477190")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune3____ = 1034477190,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【４】 1034477200")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune4 = 1034477200,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【２】 1034477210")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune2__ = 1034477210,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【４】 1034477220")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune4_ = 1034477220,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【６】 1034477300")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune6 = 1034477300,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以西] 黄金卢恩【６】 1034477310")]
        LiurniaOfTheLakesSorcerersIsleWestGoldenRune6_ = 1034477310,

        [Annotation(Name = "[湖之利耶尼亚 - 王室领地废墟] 黄金卢恩【６】 1034487300")]
        LiurniaOfTheLakesKingsrealmRuinsGoldenRune6 = 1034487300,

        [Annotation(Name = "[湖之利耶尼亚 - 王室领地废墟] 黄金卢恩【６】 1034487310")]
        LiurniaOfTheLakesKingsrealmRuinsGoldenRune6_ = 1034487310,

        [Annotation(Name = "[湖之利耶尼亚 - 王室领地废墟] 冰结晶木芽 1034487000")]
        LiurniaOfTheLakesKingsrealmRuinsRimedCrystalBud = 1034487000,

        [Annotation(Name = "[湖之利耶尼亚 - 王室领地废墟] 辉石萤火虫 1034487010")]
        LiurniaOfTheLakesKingsrealmRuinsGlintstoneFirefly = 1034487010,

        [Annotation(Name = "[湖之利耶尼亚 - 王室领地废墟] 结冰针 1034487100")]
        LiurniaOfTheLakesKingsrealmRuinsFrozenNeedle = 1034487100,

        [Annotation(Name = "[湖之利耶尼亚 - 画家的破屋] 火星蝶 1038457000")]
        LiurniaOfTheLakesArtistsShackSmolderingButterfly = 1038457000,

        [Annotation(Name = "[湖之利耶尼亚 - 画家的破屋] 火焰的疗愈啊 1038457010")]
        LiurniaOfTheLakesArtistsShackFlameCleanseMe = 1038457010,

        [Annotation(Name = "[湖之利耶尼亚 - 画家的破屋] 锻造石【４】 1038457020")]
        LiurniaOfTheLakesArtistsShackSmithingStone4 = 1038457020,

        [Annotation(Name = "[彼鲁姆大道 - 癫火村] 罹病者的制作笔记【１】 68400")]
        BellumHighwayFrenziedFlameVillageFrenziedsCookbook1 = 68400,

        [Annotation(Name = "[彼鲁姆大道 - 癫火村] 耶罗眼珠 1038487020")]
        BellumHighwayFrenziedFlameVillageEyeOfYelough = 1038487020,

        [Annotation(Name = "[彼鲁姆大道 - 癫火村] 石剑钥匙 1038487030")]
        BellumHighwayFrenziedFlameVillageStoneswordKey = 1038487030,

        [Annotation(Name = "[彼鲁姆大道 - 癫火村] 文件：关于癫火之主 69760")]
        BellumHighwayFrenziedFlameVillageNoteTheLordOfFrenziedFlame = 69760,

        [Annotation(Name = "[彼鲁姆大道 - 癫火村] 夏玻利利之祸 1038487100")]
        BellumHighwayFrenziedFlameVillageShabririsWoe = 1038487100,

        [Annotation(Name = "[彼鲁姆大道 - 癫火村] 耶罗眼珠 1038487120")]
        BellumHighwayFrenziedFlameVillageEyeOfYelough_ = 1038487120,

        [Annotation(Name = "[彼鲁姆大道 - 癫火村] 癫火石 1038487130")]
        BellumHighwayFrenziedFlameVillageFrenzyflameStone = 1038487130,

        [Annotation(Name = "[湖之利耶尼亚 - 谷底秘村] 锻造石【５】 1038507000")]
        LiurniaOfTheLakesRavineVeiledVillageSmithingStone5 = 1038507000,

        [Annotation(Name = "[湖之利耶尼亚 - 谷底秘村] 伤龙油脂 1038507010")]
        LiurniaOfTheLakesRavineVeiledVillageDragonwoundGrease = 1038507010,

        [Annotation(Name = "[彼鲁姆大道 - 镇静教堂] 杜鹃辉石 1037497000")]
        BellumHighwayChurchOfInhibitionCuckooGlintstone = 1037497000,

        [Annotation(Name = "[彼鲁姆大道 - 镇静教堂] 卢恩弯弧 1037497010")]
        BellumHighwayChurchOfInhibitionRuneArc = 1037497010,

        [Annotation(Name = "[彼鲁姆大道 - 镇静教堂] 指头女巫帽子 1037497030")]
        BellumHighwayChurchOfInhibitionFingerMaidenFillet = 1037497030,

        [Annotation(Name = "[彼鲁姆大道 - 镇静教堂] 巨型锤矛 1037497200")]
        BellumHighwayChurchOfInhibitionGreatMace = 1037497200,

        [Annotation(Name = "[彼鲁姆大道 - 镇静教堂] 指痕葡萄 1037497300")]
        BellumHighwayChurchOfInhibitionFingerprintGrape = 1037497300,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【２】 1039437010")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune2 = 1039437010,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【６】 1039437020")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune6 = 1039437020,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【１】 1039437030")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune1 = 1039437030,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【３】 1039437040")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune3 = 1039437040,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【２】 1039437050")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune2_ = 1039437050,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道（北方）] 黄金卢恩【３】 1039437060")]
        LiurniaOfTheLakesLiurniaHighwayFarNorthGoldenRune3_ = 1039437060,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇大桥] 白色肉片 1038437000")]
        LiurniaOfTheLakesGateTownBridgeStripOfWhiteFlesh = 1038437000,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇大桥] 肉片 1038437010")]
        LiurniaOfTheLakesGateTownBridgeSliverOfMeat = 1038437010,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇大桥] 腌制白银鸟爪 1038437020")]
        LiurniaOfTheLakesGateTownBridgeSilverPickledFowlFoot = 1038437020,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇大桥] 黄金卢恩【６】 1038437100")]
        LiurniaOfTheLakesGateTownBridgeGoldenRune6 = 1038437100,

        [Annotation(Name = "[湖之利耶尼亚 - 远眺岛以南] 弩炮箭 1037417010")]
        LiurniaOfTheLakesSouthOfScenicIsleBallistaBolt = 1037417010,

        [Annotation(Name = "[湖之利耶尼亚 - 远眺岛以北] 黄金卢恩【３】 1037437000")]
        LiurniaOfTheLakesNorthOfScenicIsleGoldenRune3 = 1037437000,

        [Annotation(Name = "[湖之利耶尼亚 - 远眺岛以北] 锻造石【３】 1037437010")]
        LiurniaOfTheLakesNorthOfScenicIsleSmithingStone3 = 1037437010,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇东南] 黄金卢恩【４】 1037447000")]
        LiurniaOfTheLakesGateTownSoutheastGoldenRune4 = 1037447000,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇东南] 魔力油脂 1037447010")]
        LiurniaOfTheLakesGateTownSoutheastMagicGrease = 1037447010,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇东北] 锻造石【３】 1037457100")]
        LiurniaOfTheLakesGateTownNortheastSmithingStone3 = 1037457100,

        [Annotation(Name = "[湖之利耶尼亚 - 煮虾子的破屋] 锻造石【２】 1036437000")]
        LiurniaOfTheLakesBoilprawnShackSmithingStone2 = 1036437000,

        [Annotation(Name = "[湖之利耶尼亚 - 煮虾子的破屋] 密使风帽 1036437010")]
        LiurniaOfTheLakesBoilprawnShackConfessorHood = 1036437010,

        [Annotation(Name = "[湖之利耶尼亚 - 煮虾子的破屋] 褪色金轮草 1036437020")]
        LiurniaOfTheLakesBoilprawnShackTarnishedGoldenSunflower = 1036437020,

        [Annotation(Name = "[湖之利耶尼亚 - 煮虾子的破屋] 虹彩石 1036437030")]
        LiurniaOfTheLakesBoilprawnShackRainbowStone = 1036437030,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 锻造石【３】 1039447000")]
        LiurniaOfTheLakesJarburgSmithingStone3 = 1039447000,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 大蜻蜓头部 1039447010")]
        LiurniaOfTheLakesJarburgGreatDragonflyHead = 1039447010,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 托莉娜睡莲 1039447020")]
        LiurniaOfTheLakesJarburgTrinasLily = 1039447020,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 锻造石【３】 1039447030")]
        LiurniaOfTheLakesJarburgSmithingStone3_ = 1039447030,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 活壶碎片 1039447040")]
        LiurniaOfTheLakesJarburgLivingJarShard = 1039447040,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 龟裂壶 66080")]
        LiurniaOfTheLakesJarburgCrackedPot = 66080,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 龟裂壶 66090")]
        LiurniaOfTheLakesJarburgCrackedPot_ = 66090,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 龟裂壶 66100")]
        LiurniaOfTheLakesJarburgCrackedPot__ = 66100,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 仪式壶 66430")]
        LiurniaOfTheLakesJarburgRitualPot = 66430,

        [Annotation(Name = "[湖之利耶尼亚 - 壶村] 仪式壶 66440")]
        LiurniaOfTheLakesJarburgRitualPot_ = 66440,

        [Annotation(Name = "[湖之利耶尼亚 - 结晶森林] 锻造石【３】 1034467100")]
        LiurniaOfTheLakesCrystallineWoodsSmithingStone3 = 1034467100,

        [Annotation(Name = "[湖之利耶尼亚 - 会合处] 伤龙油脂 1034457010")]
        LiurniaOfTheLakesMeetingPlaceDragonwoundGrease = 1034457010,

        [Annotation(Name = "[湖之利耶尼亚 - 会合处] 廓尔喀弯刀 1034457020")]
        LiurniaOfTheLakesMeetingPlaceKukri = 1034457020,

        [Annotation(Name = "[湖之利耶尼亚 - 会合处] 学院辉石钥匙 1034457100")]
        LiurniaOfTheLakesMeetingPlaceAcademyGlintstoneKey = 1034457100,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 锻造石【３】 1037427010")]
        LiurniaOfTheLakesLaskyarRuinsSmithingStone3 = 1037427010,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 流浪战士的制作笔记【１１】 67220")]
        LiurniaOfTheLakesLaskyarRuinsNomadicWarriorsCookbook11 = 67220,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 锻造石【２】 1035427010")]
        MoonlightAltarCathedralOfManusCelesSmithingStone2 = 1035427010,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 卢恩弯弧 1035427030")]
        MoonlightAltarCathedralOfManusCelesRuneArc = 1035427030,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 象牙小镰刀 1035427040")]
        MoonlightAltarCathedralOfManusCelesIvorySickle = 1035427040,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427100")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_ = 1035427100,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427110")]
        MoonlightAltarCathedralOfManusCelesStarlightShards__ = 1035427110,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427120")]
        MoonlightAltarCathedralOfManusCelesStarlightShards___ = 1035427120,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427130")]
        MoonlightAltarCathedralOfManusCelesStarlightShards____ = 1035427130,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427140")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_____ = 1035427140,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427150")]
        MoonlightAltarCathedralOfManusCelesStarlightShards______ = 1035427150,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427160")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_______ = 1035427160,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427170")]
        MoonlightAltarCathedralOfManusCelesStarlightShards________ = 1035427170,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427180")]
        MoonlightAltarCathedralOfManusCelesStarlightShards_________ = 1035427180,

        [Annotation(Name = "[月光祭坛 - 玛努斯·瑟利斯大教堂] 星光碎片 1035427190")]
        MoonlightAltarCathedralOfManusCelesStarlightShards__________ = 1035427190,

        [Annotation(Name = "[湖之利耶尼亚 - 雷亚卢卡利亚（南门）] 会合用的地图 1035457100")]
        LiurniaOfTheLakesSouthRayaLucariaGateMeetingPlaceMap = 1035457100,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨以南] 失色锻造石【４】 1035497020")]
        LiurniaOfTheLakesSouthOfCariaManorSomberSmithingStone4 = 1035497020,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以北] 古牙 1035487010")]
        LiurniaOfTheLakesNorthOfSorcerersIsleOldFang = 1035487010,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以北] 催眠油脂 1035487020")]
        LiurniaOfTheLakesNorthOfSorcerersIsleSoporificGrease = 1035487020,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以北] 野兽肉块 1035487030")]
        LiurniaOfTheLakesNorthOfSorcerersIsleLumpOfFlesh = 1035487030,

        [Annotation(Name = "[湖之利耶尼亚 - 魔法师塔的小岛以北] 黄金卢恩【６】 1035487100")]
        LiurniaOfTheLakesNorthOfSorcerersIsleGoldenRune6 = 1035487100,

        [Annotation(Name = "[彼鲁姆大道 - 雷亚卢卡利亚（东门）] 神殿石 1036487000")]
        BellumHighwayEastRayaLucariaGateSanctuaryStone = 1036487000,

        [Annotation(Name = "[彼鲁姆大道 - 雷亚卢卡利亚（东门）] 黄金卢恩【１】 1036487100")]
        BellumHighwayEastRayaLucariaGateGoldenRune1 = 1036487100,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 眠卵 1037487000")]
        LiurniaOfTheLakesMausoleumCompoundSlumberingEgg = 1037487000,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【３】 1037487010")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3 = 1037487010,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【３】 1037487020")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3_ = 1037487020,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【１】 1037487030")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune1 = 1037487030,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【７】 1037487040")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune7 = 1037487040,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【３】 1037487050")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3__ = 1037487050,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【２】 1037487060")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune2 = 1037487060,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【４】 1037487070")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune4 = 1037487070,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【３】 1037487080")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune3___ = 1037487080,

        [Annotation(Name = "[湖之利耶尼亚 - 群集灵庙] 黄金卢恩【１】 1037487100")]
        LiurniaOfTheLakesMausoleumCompoundGoldenRune1_ = 1037487100,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼] 失色锻造石【３】 1033477000")]
        LiurniaOfTheLakesTheFourBelfriesSomberSmithingStone3 = 1033477000,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼] 锻造石【４】 1033477010")]
        LiurniaOfTheLakesTheFourBelfriesSmithingStone4 = 1033477010,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼] 卢恩弯弧 1033477030")]
        LiurniaOfTheLakesTheFourBelfriesRuneArc = 1033477030,

        [Annotation(Name = "[湖之利耶尼亚 - 四钟楼] 卡利亚骑士剑 1033477200")]
        LiurniaOfTheLakesTheFourBelfriesCarianKnightsSword = 1033477200,

        [Annotation(Name = "[湖之利耶尼亚 - 遗迹迷宫] 癫火石 1038477010")]
        LiurniaOfTheLakesRuinedLabyrinthFrenzyflameStone = 1038477010,

        [Annotation(Name = "[湖之利耶尼亚 - 遗迹迷宫] 石剑钥匙 1038477030")]
        LiurniaOfTheLakesRuinedLabyrinthStoneswordKey = 1038477030,

        [Annotation(Name = "[湖之利耶尼亚 - 遗迹迷宫] 黄金卢恩【１】 1038477100")]
        LiurniaOfTheLakesRuinedLabyrinthGoldenRune1 = 1038477100,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇大桥以北] 锻造石【３】 1038447030")]
        LiurniaOfTheLakesNorthOfGateTownBridgeSmithingStone3 = 1038447030,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇大桥以北] 陆生海鞘的骨灰 1038447040")]
        LiurniaOfTheLakesNorthOfGateTownBridgeLandSquirtAshes = 1038447040,

        [Annotation(Name = "[湖之利耶尼亚 - 利耶尼亚大道南边尽头] 大树矛 1040407000")]
        LiurniaLiurniaHighwaySouthEndpointTreespear = 1040407000,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 辉石工匠的制作笔记【２】 67450")]
        LiurniaOfTheLakesLaskyarRuinsGlintstoneCraftsmansCookbook2 = 67450,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 牺牲细枝 1038417010")]
        LiurniaOfTheLakesLaskyarRuinsSacrificialTwig = 1038417010,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] Unknown Gem 1007 1038417100")]
        LiurniaOfTheLakesLaskyarRuinsGravitas = 1038417100,

        [Annotation(Name = "[湖之利耶尼亚 - 杜鹃的封印监牢] 龙鳞刀 1033457100")]
        LiurniaOfTheLakesCuckoosEvergaolDragonscaleBlade = 1033457100,

        [Annotation(Name = "[湖之利耶尼亚 - 彼鲁姆大道] 失色锻造石【３】 1036477000")]
        LiurniaOfTheLakesBellumHighwaySomberSmithingStone3 = 1036477000,

        [Annotation(Name = "[湖之利耶尼亚 - 彼鲁姆大道] 黄金卢恩【１】 1036477100")]
        LiurniaOfTheLakesBellumHighwayGoldenRune1 = 1036477100,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 白金凝血 1034427020")]
        MoonlightAltarMoonfolkRuinsAlbinauricBloodclot = 1034427020,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 锻造石【２】 1034427030")]
        MoonlightAltarMoonfolkRuinsSmithingStone2 = 1034427030,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 结晶剑 1034427050")]
        MoonlightAltarMoonfolkRuinsCrystalSword = 1034427050,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 泪滴幼体 1034427060")]
        MoonlightAltarMoonfolkRuinsLarvalTear = 1034427060,

        [Annotation(Name = "[湖之利耶尼亚 - 改宗塔] 魔力油脂 1034437000")]
        LiurniaOfTheLakesConvertedTowerMagicGrease = 1034437000,

        [Annotation(Name = "[湖之利耶尼亚 - 改宗塔] 记忆石 60410")]
        LiurniaOfTheLakesConvertedTowerMemoryStone = 60410,

        [Annotation(Name = "[湖之利耶尼亚 - 改宗塔] 黄金卢恩【６】 1034437200")]
        LiurniaOfTheLakesConvertedTowerGoldenRune6 = 1034437200,

        [Annotation(Name = "[湖之利耶尼亚 - 改宗塔] 杜鹃辉石 1034437300")]
        LiurniaOfTheLakesConvertedTowerCuckooGlintstone = 1034437300,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 卢恩弯弧 1035507000")]
        LiurniaOfTheLakesCariaManorRuneArc = 1035507000,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 黄金卢恩【４】 1035507010")]
        LiurniaOfTheLakesCariaManorGoldenRune4 = 1035507010,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 石剑钥匙 1035507020")]
        LiurniaOfTheLakesCariaManorStoneswordKey = 1035507020,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 眠卵 1035507030")]
        LiurniaOfTheLakesCariaManorSlumberingEgg = 1035507030,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 辉石工匠的制作笔记【６】 67460")]
        LiurniaOfTheLakesCariaManorGlintstoneCraftsmansCookbook6 = 67460,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 失色锻造石【３】 1035507050")]
        LiurniaOfTheLakesCariaManorSomberSmithingStone3 = 1035507050,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 黄金卢恩【３】 1035507060")]
        LiurniaOfTheLakesCariaManorGoldenRune3 = 1035507060,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 结晶飞刀 1035507070")]
        LiurniaOfTheLakesCariaManorCrystalDart = 1035507070,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 锻造石【４】 1035507080")]
        LiurniaOfTheLakesCariaManorSmithingStone4 = 1035507080,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 战灰：伟哉卡利亚 1035507090")]
        LiurniaOfTheLakesCariaManorAshOfWarCarianGrandeur = 1035507090,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 失色锻造石【３】 1035507100")]
        LiurniaOfTheLakesCariaManorSomberSmithingStone3_ = 1035507100,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 抗魔肝脏干 1035507110")]
        LiurniaOfTheLakesCariaManorSpellproofDriedLiver = 1035507110,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰结晶木芽 1035507120")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud = 1035507120,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 锻造石【２】 1035507130")]
        LiurniaOfTheLakesCariaManorSmithingStone2 = 1035507130,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 锻造石【４】 1035507140")]
        LiurniaOfTheLakesCariaManorSmithingStone4_ = 1035507140,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 软鞭剑 1035507150")]
        LiurniaOfTheLakesCariaManorUrumi = 1035507150,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 锻造石【３】 1035507160")]
        LiurniaOfTheLakesCariaManorSmithingStone3 = 1035507160,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 黄金卢恩【４】 1035507170")]
        LiurniaOfTheLakesCariaManorGoldenRune4_ = 1035507170,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 古牙 1035507180")]
        LiurniaOfTheLakesCariaManorOldFang = 1035507180,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 辉石萤火虫 1035507190")]
        LiurniaOfTheLakesCariaManorGlintstoneFirefly = 1035507190,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰纹铁盾 1035507200")]
        LiurniaOfTheLakesCariaManorIceCrestShield = 1035507200,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 魔力油脂 1035507220")]
        LiurniaOfTheLakesCariaManorMagicGrease = 1035507220,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰结晶木芽 1035507230")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud_ = 1035507230,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰结晶木芽 1035507240")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud__ = 1035507240,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰结晶木芽 1035507250")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud___ = 1035507250,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰结晶木芽 1035507260")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud____ = 1035507260,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰结晶木芽 1035507270")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud_____ = 1035507270,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 冰结晶木芽 1035507280")]
        LiurniaOfTheLakesCariaManorRimedCrystalBud______ = 1035507280,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 黄金种子 1035507300")]
        LiurniaOfTheLakesCariaManorGoldenSeed = 1035507300,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 龟裂壶 66110")]
        LiurniaOfTheLakesCariaManorCrackedPot = 66110,

        [Annotation(Name = "[湖之利耶尼亚 - 卡利亚城寨] 夜与火之剑 1035507900")]
        LiurniaOfTheLakesCariaManorSwordOfNightandFlame = 1035507900,

        [Annotation(Name = "[彼鲁姆大道 - 镇静教堂] 卢恩弯弧 1037497020")]
        BellumHighwayChurchOfInhibitionRuneArc_ = 1037497020,

        [Annotation(Name = "[湖之利耶尼亚 - 东边台地] 免疫白肉干 1038467000")]
        LiurniaOfTheLakesEasternTablelandImmunizingWhiteCuredMeat = 1038467000,

        [Annotation(Name = "[湖之利耶尼亚 - 东边台地] 黄金卢恩【１】 1038467400")]
        LiurniaOfTheLakesEasternTablelandGoldenRune1 = 1038467400,

        [Annotation(Name = "[彼鲁姆大道 - 癫火灯塔] 黄色余火 1038497000")]
        BellumHighwayFrenzyFlamingTowerYellowEmber = 1038497000,

        [Annotation(Name = "[彼鲁姆大道 - 癫火灯塔] 锻造石【２】 1038497010")]
        BellumHighwayFrenzyFlamingTowerSmithingStone2 = 1038497010,

        [Annotation(Name = "[彼鲁姆大道 - 癫火灯塔] 倒刺弩箭 1038497030")]
        BellumHighwayFrenzyFlamingTowerBurredBolt = 1038497030,

        [Annotation(Name = "[彼鲁姆大道 - 癫火灯塔] 黄金卢恩【３】 1038497040")]
        BellumHighwayFrenzyFlamingTowerGoldenRune3 = 1038497040,

        [Annotation(Name = "[彼鲁姆大道 - 癫火灯塔] 夏玻利利的嘶吼 1038497900")]
        BellumHighwayFrenzyFlamingTowerHowlOfShabriri = 1038497900,

        [Annotation(Name = "[月光祭坛] 锻造石【７】 1033417000")]
        MoonlightAltarSmithingStone7 = 1033417000,

        [Annotation(Name = "[月光祭坛] 锻造石【８】 1033417010")]
        MoonlightAltarSmithingStone8 = 1033417010,

        [Annotation(Name = "[月光祭坛] 锻造石【７】 1033417020")]
        MoonlightAltarSmithingStone7_ = 1033417020,

        [Annotation(Name = "[月光祭坛] 龙心脏 1033417400")]
        MoonlightAltarDragonHeart = 1033417400,

        [Annotation(Name = "[月光祭坛] 龙心脏 1033417410")]
        MoonlightAltarDragonHeart_ = 1033417410,

        [Annotation(Name = "[湖之利耶尼亚 - 复仇者的破屋] 生肉丸 1033447000")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling = 1033447000,

        [Annotation(Name = "[湖之利耶尼亚 - 复仇者的破屋] 生肉丸 1033447010")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling_ = 1033447010,

        [Annotation(Name = "[湖之利耶尼亚 - 复仇者的破屋] 生肉丸 1033447020")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling__ = 1033447020,

        [Annotation(Name = "[湖之利耶尼亚 - 复仇者的破屋] 生肉丸 1033447030")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling___ = 1033447030,

        [Annotation(Name = "[湖之利耶尼亚 - 复仇者的破屋] 生肉丸 1033447040")]
        LiurniaOfTheLakesRevengersShackRawMeatDumpling____ = 1033447040,

        [Annotation(Name = "[月光祭坛 - 安瑟尔河的出口井] 碎石 1034417000")]
        MoonlightAltarDeepAinselWellGravelStone = 1034417000,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 黄金卢恩【９】 1034427000")]
        MoonlightAltarMoonfolkRuinsGoldenRune9 = 1034427000,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 魔力油脂 1034427010")]
        MoonlightAltarMoonfolkRuinsMagicGrease = 1034427010,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 卢恩弯弧 1034427040")]
        MoonlightAltarMoonfolkRuinsRuneArc = 1034427040,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 失色锻造石【８】 1034427100")]
        MoonlightAltarMoonfolkRuinsSomberSmithingStone8 = 1034427100,

        [Annotation(Name = "[月光祭坛 - 月之民废墟] 龙心脏 1034427400")]
        MoonlightAltarMoonfolkRuinsDragonHeart = 1034427400,

        [Annotation(Name = "[月光祭坛 - 月之贵族废墟] 黄金卢恩【１０】 1035417000")]
        MoonlightAltarLunarEstateRuinsGoldenRune10 = 1035417000,

        [Annotation(Name = "[月光祭坛 - 月之贵族废墟] 辉石萤火虫 1035417010")]
        MoonlightAltarLunarEstateRuinsGlintstoneFirefly = 1035417010,

        [Annotation(Name = "[月光祭坛 - 月之贵族废墟] 蓝琥珀链坠＋２ 1035417100")]
        MoonlightAltarLunarEstateRuinsCeruleanAmberMedallion2 = 1035417100,

        [Annotation(Name = "[月光祭坛 - 月之贵族废墟] 锻造石【８】 1035417110")]
        MoonlightAltarLunarEstateRuinsSmithingStone8 = 1035417110,

        [Annotation(Name = "[湖之利耶尼亚 - 拉斯卡废墟] 地图碎片：利耶尼亚（东） 62020")]
        LiurniaOfTheLakesLaskyarRuinsMapLiurniaEast = 62020,

        [Annotation(Name = "[湖之利耶尼亚 - 门前镇东南] 地图碎片：利耶尼亚（北） 62021")]
        LiurniaOfTheLakesGateTownSoutheastMapLiurniaNorth = 62021,

        [Annotation(Name = "[湖之利耶尼亚 - 王室领地废墟] 地图碎片：利耶尼亚（西） 62022")]
        LiurniaOfTheLakesKingsrealmRuinsMapLiurniaWest = 62022,

        [Annotation(Name = "[格密尔火山 - 遁世商人的破屋前] 黄金卢恩【２】 1035527010")]
        MtGelmirBeforeHermitShackGoldenRune2 = 1035527010,

        [Annotation(Name = "[格密尔火山 - 遁世商人的破屋前] 黄金卢恩【４】 1035527020")]
        MtGelmirBeforeHermitShackGoldenRune4 = 1035527020,

        [Annotation(Name = "[格密尔火山 - 遁世商人的破屋前] 黄金卢恩【２】 1035527030")]
        MtGelmirBeforeHermitShackGoldenRune2_ = 1035527030,

        [Annotation(Name = "[格密尔火山 - 遁世商人的破屋前] 黄金卢恩【６】 1035527040")]
        MtGelmirBeforeHermitShackGoldenRune6 = 1035527040,

        [Annotation(Name = "[格密尔火山 - 沸滚河终点] 火星蝶 1035537000")]
        MtGelmirSeethewaterTerminusSmolderingButterfly = 1035537000,

        [Annotation(Name = "[格密尔火山 - 沸滚河终点] 黄金卢恩【３】 1035537010")]
        MtGelmirSeethewaterTerminusGoldenRune3 = 1035537010,

        [Annotation(Name = "[格密尔火山 - 沸滚河终点] 蘑菇 1035537020")]
        MtGelmirSeethewaterTerminusMushroom = 1035537020,

        [Annotation(Name = "[格密尔火山 - 沸滚河终点] 火星蝶 1035537030")]
        MtGelmirSeethewaterTerminusSmolderingButterfly_ = 1035537030,

        [Annotation(Name = "[格密尔火山 - 沸滚河终点] 火星蝶 1035537040")]
        MtGelmirSeethewaterTerminusSmolderingButterfly__ = 1035537040,

        [Annotation(Name = "[格密尔火山 - 沸滚河终点] 黄金卢恩【５】 1035537050")]
        MtGelmirSeethewaterTerminusGoldenRune5 = 1035537050,

        [Annotation(Name = "[格密尔火山 - 莱多要塞] 伤龙油脂 1035547000")]
        MtGelmirFortLaieddDragonwoundGrease = 1035547000,

        [Annotation(Name = "[格密尔火山 - 莱多要塞] 黄金卢恩【３】 1035547010")]
        MtGelmirFortLaieddGoldenRune3 = 1035547010,

        [Annotation(Name = "[格密尔火山 - 莱多要塞] 石剑钥匙 1035547020")]
        MtGelmirFortLaieddStoneswordKey = 1035547020,

        [Annotation(Name = "[格密尔火山 - 莱多要塞] 武器工匠的制作笔记【７】 67250")]
        MtGelmirFortLaieddArmorersCookbook7 = 67250,

        [Annotation(Name = "[格密尔火山 - 莱多要塞] 火对蝎 1035547050")]
        MtGelmirFortLaieddFireScorpionCharm = 1035547050,

        [Annotation(Name = "[格密尔火山 - 莱多要塞] 黄金卢恩【８】 1035547060")]
        MtGelmirFortLaieddGoldenRune8 = 1035547060,

        [Annotation(Name = "[格密尔火山 - 莱多要塞] 眠卵 1035547070")]
        MtGelmirFortLaieddSlumberingEgg = 1035547070,

        [Annotation(Name = "[亚坛高原 - 调香师的废墟] 黄金卢恩【５】 1036517000")]
        AltusPlateauPerfumersRuinsGoldenRune5 = 1036517000,

        [Annotation(Name = "[亚坛高原 - 调香师的废墟] 调香师的制作笔记【１】 67840")]
        AltusPlateauPerfumersRuinsPerfumersCookbook1 = 67840,

        [Annotation(Name = "[亚坛高原 - 调香师的废墟] 调香瓶 66730")]
        AltusPlateauPerfumersRuinsPerfumeBottle = 66730,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 锻造石【６】 1036527000")]
        MtGelmirCraftsmansShackSmithingStone6 = 1036527000,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 调香师护符 1036527010")]
        MtGelmirCraftsmansShackPerfumersTalisman = 1036527010,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 洞窟苔藓的花苞 1036527020")]
        MtGelmirCraftsmansShackBuddingCaveMoss = 1036527020,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 蜕生蝶 1036527030")]
        MtGelmirCraftsmansShackNascentButterfly = 1036527030,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 碎石 1036527040")]
        MtGelmirCraftsmansShackGravelStone = 1036527040,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 滚烫熔岩 1036527050")]
        MtGelmirCraftsmansShackRoilingMagma = 1036527050,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 滑轮弩 1036527060")]
        MtGelmirCraftsmansShackPulleyCrossbow = 1036527060,

        [Annotation(Name = "[格密尔火山 - 匠人的破屋] 调香瓶 66740")]
        MtGelmirCraftsmansShackPerfumeBottle = 66740,

        [Annotation(Name = "[格密尔火山 - 火山官邸外] 黄金卢恩【６】 1036537000")]
        MtGelmirOutsideVolcanoManorGoldenRune6 = 1036537000,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 黄金卢恩【３】 1036547000")]
        MtGelmirVolcanoManorEntranceGoldenRune3 = 1036547000,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 火星蝶 1036547010")]
        MtGelmirVolcanoManorEntranceSmolderingButterfly = 1036547010,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 黄金卢恩【７】 1036547020")]
        MtGelmirVolcanoManorEntranceGoldenRune7 = 1036547020,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 火星蝶 1036547030")]
        MtGelmirVolcanoManorEntranceSmolderingButterfly_ = 1036547030,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 星光碎片 1036547040")]
        MtGelmirVolcanoManorEntranceStarlightShards = 1036547040,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 抗火肝脏干 1036547050")]
        MtGelmirVolcanoManorEntranceFireproofDriedLiver = 1036547050,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 泪滴幼体 1036547100")]
        MtGelmirVolcanoManorEntranceLarvalTear = 1036547100,

        [Annotation(Name = "[亚坛高原 - 弃置棺材] 锻造石【５】 1037517000")]
        AltusPlateauAbandonedCoffinSmithingStone5 = 1037517000,

        [Annotation(Name = "[亚坛高原 - 弃置棺材] 雷电花 1037517010")]
        AltusPlateauAbandonedCoffinFulgurbloom = 1037517010,

        [Annotation(Name = "[亚坛高原 - 弃置棺材] 领主面具 1037517020")]
        AltusPlateauAbandonedCoffinRulersMask = 1037517020,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 箭矢 1037527020")]
        MtGelmirSeethewaterRiverArrow = 1037527020,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 圣血木芽 1037527030")]
        MtGelmirSeethewaterRiverSacramentalBud = 1037527030,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 绳索 1037527040")]
        MtGelmirSeethewaterRiverString = 1037527040,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 金色排泄物 1037527050")]
        MtGelmirSeethewaterRiverGoldTingedExcrement = 1037527050,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 金色萤火虫 1037527060")]
        MtGelmirSeethewaterRiverGoldFirefly = 1037527060,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 唤声泥颅“你长得很好看” 1037527070")]
        MtGelmirSeethewaterRiverPrattlingPateYourebeautiful = 1037527070,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 星光碎片 1037527080")]
        MtGelmirSeethewaterRiverStarlightShards = 1037527080,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 亚罗塔斯辉石头罩 1037527090")]
        MtGelmirSeethewaterRiverHierodasGlintstoneCrown = 1037527090,

        [Annotation(Name = "[格密尔火山 - 沸滚河] 离群魔法师腕套 1037527100")]
        MtGelmirSeethewaterRiverErrantSorcererManchettes = 1037527100,

        [Annotation(Name = "[格密尔火山 - “起源魔法师”亚兹勒] 蘑菇 1037537000")]
        MtGelmirPrimevalSorcererAzurMushroom = 1037537000,

        [Annotation(Name = "[格密尔火山 - “起源魔法师”亚兹勒] 黄金卢恩【６】 1037537010")]
        MtGelmirPrimevalSorcererAzurGoldenRune6 = 1037537010,

        [Annotation(Name = "[格密尔火山 - “起源魔法师”亚兹勒] 锻造石【５】 1037537020")]
        MtGelmirPrimevalSorcererAzurSmithingStone5 = 1037537020,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 野兽血液 1037547000")]
        MtGelmirMinorErdtreeBeastBlood = 1037547000,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 石剑钥匙 1037547010")]
        MtGelmirMinorErdtreeStoneswordKey = 1037547010,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 催眠油脂 1037547020")]
        MtGelmirMinorErdtreeSoporificGrease = 1037547020,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 赫帕草 1037547030")]
        MtGelmirMinorErdtreeHerba = 1037547030,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 耶罗眼珠 1037547040")]
        MtGelmirMinorErdtreeEyeOfYelough = 1037547040,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 黄金箭 1037547050")]
        MtGelmirMinorErdtreeGoldenArrow = 1037547050,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 玻璃碎片 1037547060")]
        MtGelmirMinorErdtreeGlassShard = 1037547060,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 蜕生蝶 1037547070")]
        MtGelmirMinorErdtreeNascentButterfly = 1037547070,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 死亡苔药 1037547080")]
        MtGelmirMinorErdtreeRejuvenatingBoluses = 1037547080,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 粗大兽骨 1037547090")]
        MtGelmirMinorErdtreeHeftyBeastBone = 1037547090,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 黄金卢恩【６】 1037547100")]
        MtGelmirMinorErdtreeGoldenRune6 = 1037547100,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 大箭 1037547110")]
        MtGelmirMinorErdtreeGreatArrow = 1037547110,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 扇形暗器 1037547120")]
        MtGelmirMinorErdtreeFanDaggers = 1037547120,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 附绳火油脂 1037547130")]
        MtGelmirMinorErdtreeDrawstringFireGrease = 1037547130,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 黄金卢恩【４】 1037547140")]
        MtGelmirMinorErdtreeGoldenRune4 = 1037547140,

        [Annotation(Name = "[格密尔火山 - 小黄金树] 剥尸曲剑 1037547150")]
        MtGelmirMinorErdtreeScavengersCurvedSword = 1037547150,

        [Annotation(Name = "[格密尔火山 - 火山洞窟入口] 中毒油脂 1037557000")]
        MtGelmirVolcanoCaveEntrancePoisonGrease = 1037557000,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 蜕生蝶 1038517000")]
        AltusPlateauLuxRuinsNascentButterfly = 1038517000,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 绳索 1038517010")]
        AltusPlateauLuxRuinsString = 1038517010,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 抗雷肝脏干 1038517020")]
        AltusPlateauLuxRuinsLightningproofDriedLiver = 1038517020,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 大盾护符 1038517030")]
        AltusPlateauLuxRuinsGreatshieldTalisman = 1038517030,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 抗雷肝脏干 1038517040")]
        AltusPlateauLuxRuinsLightningproofDriedLiver_ = 1038517040,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 献斗剑护符 1038517050")]
        AltusPlateauLuxRuinsRitualSwordTalisman = 1038517050,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 雷油脂 1038517060")]
        AltusPlateauLuxRuinsLightningGrease = 1038517060,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 绳索 1038517070")]
        AltusPlateauLuxRuinsString_ = 1038517070,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 黄金卢恩【３】 1038517080")]
        AltusPlateauLuxRuinsGoldenRune3 = 1038517080,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 山妖黄金剑 1038517090")]
        AltusPlateauLuxRuinsTrollsGoldenSword = 1038517090,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 珍珠龙徽护符＋１ 1038527000")]
        AltusPlateauWyndhamRuinsPearldrakeTalisman1 = 1038527000,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 锻造石【５】 1038527010")]
        AltusPlateauWyndhamRuinsSmithingStone5 = 1038527010,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 黄金卢恩【３】 1038527020")]
        AltusPlateauWyndhamRuinsGoldenRune3 = 1038527020,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 黄金卢恩【７】 1038527030")]
        AltusPlateauWyndhamRuinsGoldenRune7 = 1038527030,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 斑斓白肉干 1038527040")]
        AltusPlateauWyndhamRuinsDappledWhiteCuredMeat = 1038527040,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 风暴鹰羽毛 1038527050")]
        AltusPlateauWyndhamRuinsStormhawkFeather = 1038527050,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 黄金卢恩【４】 1038527060")]
        AltusPlateauWyndhamRuinsGoldenRune4 = 1038527060,

        [Annotation(Name = "[亚坛高原 - 威达姆废墟] 人骨碎片 1038527070")]
        AltusPlateauWyndhamRuinsHumanBoneShard = 1038527070,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道入口] 黄金卢恩【２】 1038537000")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune2 = 1038537000,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道入口] 黄金卢恩【３】 1038537010")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune3 = 1038537010,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道入口] 黄金卢恩【４】 1038537020")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune4 = 1038537020,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道入口] 黄金卢恩【７】 1038537030")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune7 = 1038537030,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道入口] 黄金卢恩【３】 1038537040")]
        AltusPlateauOldAltusTunnelEntranceGoldenRune3_ = 1038537040,

        [Annotation(Name = "[亚坛高原 - 旧亚坛坑道入口] 失色锻造石【６】 1038537050")]
        AltusPlateauOldAltusTunnelEntranceSomberSmithingStone6 = 1038537050,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 血蔷薇 1038547000")]
        AltusPlateauWestOfShadedCastleBloodrose = 1038547000,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 爆炸大弩箭 1038547010")]
        AltusPlateauWestOfShadedCastleExplosiveGreatbolt = 1038547010,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 黄金卢恩【８】 1038547020")]
        AltusPlateauWestOfShadedCastleGoldenRune8 = 1038547020,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 火箭 1038547030")]
        AltusPlateauWestOfShadedCastleFireArrow = 1038547030,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 黄金树立誓 1038547050")]
        AltusPlateauWestOfShadedCastleGoldenVow = 1038547050,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 亚缇莉亚叶 1038547060")]
        AltusPlateauWestOfShadedCastleArteriaLeaf = 1038547060,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 投掷匕首 1038547070")]
        AltusPlateauWestOfShadedCastleThrowingDagger = 1038547070,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 野兽血液 1038547080")]
        AltusPlateauWestOfShadedCastleBeastBlood = 1038547080,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 锻造石【５】 1038547090")]
        AltusPlateauWestOfShadedCastleSmithingStone5 = 1038547090,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 蚁刺细剑 1038547100")]
        AltusPlateauWestOfShadedCastleAntspurRapier = 1038547100,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 滑轮弓 1038547110")]
        AltusPlateauWestOfShadedCastlePulleyBow = 1038547110,

        [Annotation(Name = "[亚坛高原 - 日荫城西边] 神圣肢解菜刀 1038547700")]
        AltusPlateauWestOfShadedCastleSacredButcheringKnife = 1038547700,

        [Annotation(Name = "[亚坛高原 - 黄金一族的封印监牢] 粗大兽骨 1039507000")]
        AltusPlateauGoldenLineageEvergaolHeftyBeastBone = 1039507000,

        [Annotation(Name = "[亚坛高原 - 黄金一族的封印监牢] 石剑钥匙 1039507010")]
        AltusPlateauGoldenLineageEvergaolStoneswordKey = 1039507010,

        [Annotation(Name = "[亚坛高原 - 黄金一族的封印监牢] 黄金卢恩【４】 1039507020")]
        AltusPlateauGoldenLineageEvergaolGoldenRune4 = 1039507020,

        [Annotation(Name = "[亚坛高原 - 黄金一族的封印监牢] 葛孚雷的肖像 1039507100")]
        AltusPlateauGoldenLineageEvergaolGodfreyIcon = 1039507100,

        [Annotation(Name = "[亚坛高原 - 亚坛大道的三叉口] 调香瓶 66760")]
        AltusPlateauAltusHighwayJunctionPerfumeBottle = 66760,

        [Annotation(Name = "[亚坛高原 - 亚坛大道的三叉口] 扇形暗器 1039517010")]
        AltusPlateauAltusHighwayJunctionFanDaggers = 1039517010,

        [Annotation(Name = "[亚坛高原 - 亚坛大道的三叉口] 牺牲细枝 1039517020")]
        AltusPlateauAltusHighwayJunctionSacrificialTwig = 1039517020,

        [Annotation(Name = "[亚坛高原 - 亚坛大道的三叉口] 温热石 1039517030")]
        AltusPlateauAltusHighwayJunctionWarmingStone = 1039517030,

        [Annotation(Name = "[亚坛高原 - 亚坛大道的三叉口] 龟颈肉块 1039517040")]
        AltusPlateauAltusHighwayJunctionTurtleNeckMeat = 1039517040,

        [Annotation(Name = "[亚坛高原 - 亚坛大道的三叉口] 战灰：共享圣律 1039517200")]
        AltusPlateauAltusHighwayJunctionAshOfWarSharedOrder = 1039517200,

        [Annotation(Name = "[亚坛高原 - 玛莉卡第二教堂] 人骨碎片 1039527000")]
        AltusPlateauSecondChurchOfMarikaHumanBoneShard = 1039527000,

        [Annotation(Name = "[亚坛高原 - 玛莉卡第二教堂] 魔力油脂 1039527020")]
        AltusPlateauSecondChurchOfMarikaMagicGrease = 1039527020,

        [Annotation(Name = "[亚坛高原 - 玛莉卡第二教堂] 艾琉诺拉的双头刀 1039527700")]
        AltusPlateauSecondChurchOfMarikaEleonorasPoleblade = 1039527700,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 黄金卢恩【４】 1039537000")]
        AltusPlateauMirageRiseGoldenRune4 = 1039537000,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 出血油脂 1039537010")]
        AltusPlateauMirageRiseBloodGrease = 1039537010,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 黄金卢恩【３】 1039537020")]
        AltusPlateauMirageRiseGoldenRune3 = 1039537020,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 米凯拉睡莲 1039537030")]
        AltusPlateauMirageRiseMiquellasLily = 1039537030,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 蜕生蝶 1039537040")]
        AltusPlateauMirageRiseNascentButterfly = 1039537040,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 无形刀刃 1039537050")]
        AltusPlateauMirageRiseUnseenBlade = 1039537050,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 眠卵 1039537060")]
        AltusPlateauMirageRiseSlumberingEgg = 1039537060,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 黄金卢恩【３】 1039537070")]
        AltusPlateauMirageRiseGoldenRune3_ = 1039537070,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 海市蜃楼的谜题 1039537080")]
        AltusPlateauMirageRiseMirageRiddle = 1039537080,

        [Annotation(Name = "[亚坛高原 - 海市蜃楼魔法师塔] 克雷普的小瓶子 1039537700")]
        AltusPlateauMirageRiseCrepussVial = 1039537700,

        [Annotation(Name = "[亚坛高原 - 日荫城] 腐败油脂 1039570000")]
        AltusPlateauShadedCastleRotGrease = 1039570000,

        [Annotation(Name = "[亚坛高原 - 日荫城] 黄金卢恩【３】 1039547010")]
        AltusPlateauShadedCastleGoldenRune3 = 1039547010,

        [Annotation(Name = "[亚坛高原 - 日荫城] 锻造石【５】 1039547020")]
        AltusPlateauShadedCastleSmithingStone5 = 1039547020,

        [Annotation(Name = "[亚坛高原 - 日荫城] 毒花 1039547030")]
        AltusPlateauShadedCastlePoisonbloom = 1039547030,

        [Annotation(Name = "[亚坛高原 - 日荫城] 调香瓶 66770")]
        AltusPlateauShadedCastlePerfumeBottle = 66770,

        [Annotation(Name = "[亚坛高原 - 日荫城] 兽骨毒飞刀 1039547050")]
        AltusPlateauShadedCastlePoisonboneDart = 1039547050,

        [Annotation(Name = "[亚坛高原 - 日荫城] 黄金卢恩【６】 1039547060")]
        AltusPlateauShadedCastleGoldenRune6 = 1039547060,

        [Annotation(Name = "[亚坛高原 - 日荫城] 锻造石【４】 1039547070")]
        AltusPlateauShadedCastleSmithingStone4 = 1039547070,

        [Annotation(Name = "[亚坛高原 - 日荫城] 失色锻造石【５】 1039547080")]
        AltusPlateauShadedCastleSomberSmithingStone5 = 1039547080,

        [Annotation(Name = "[亚坛高原 - 日荫城] 锻造石【５】 1039547090")]
        AltusPlateauShadedCastleSmithingStone5_ = 1039547090,

        [Annotation(Name = "[亚坛高原 - 日荫城] 附绳火油脂 1039547100")]
        AltusPlateauShadedCastleDrawstringFireGrease = 1039547100,

        [Annotation(Name = "[亚坛高原 - 日荫城] 黄金卢恩【６】 1039547110")]
        AltusPlateauShadedCastleGoldenRune6_ = 1039547110,

        [Annotation(Name = "[亚坛高原 - 日荫城] 野兽血液 1039547120")]
        AltusPlateauShadedCastleBeastBlood = 1039547120,

        [Annotation(Name = "[亚坛高原 - 日荫城] 中毒苔药 1039547130")]
        AltusPlateauShadedCastleNeutralizingBoluses = 1039547130,

        [Annotation(Name = "[亚坛高原 - 日荫城] 玻璃碎片 1039547140")]
        AltusPlateauShadedCastleGlassShard = 1039547140,

        [Annotation(Name = "[亚坛高原 - 日荫城] 石剑钥匙 1039547150")]
        AltusPlateauShadedCastleStoneswordKey = 1039547150,

        [Annotation(Name = "[亚坛高原 - 日荫城] 黄金卢恩【６】 1039547160")]
        AltusPlateauShadedCastleGoldenRune6__ = 1039547160,

        [Annotation(Name = "[亚坛高原 - 日荫城] 中毒油脂 1039547170")]
        AltusPlateauShadedCastlePoisonGrease = 1039547170,

        [Annotation(Name = "[亚坛高原 - 日荫城] 粗大兽骨 1039547180")]
        AltusPlateauShadedCastleHeftyBeastBone = 1039547180,

        [Annotation(Name = "[亚坛高原 - 日荫城] 调香师的制作笔记【２】 67850")]
        AltusPlateauShadedCastlePerfumersCookbook2 = 67850,

        [Annotation(Name = "[亚坛高原 - 日荫城] 锻造石【５】 1039547200")]
        AltusPlateauShadedCastleSmithingStone5__ = 1039547200,

        [Annotation(Name = "[亚坛高原 - 日荫城] 金色萤火虫 1039547210")]
        AltusPlateauShadedCastleGoldFirefly = 1039547210,

        [Annotation(Name = "[亚坛高原 - 日荫城] 玻璃碎片 1039547220")]
        AltusPlateauShadedCastleGlassShard_ = 1039547220,

        [Annotation(Name = "[亚坛高原 - 日荫城] 锻造石【５】 1039547230")]
        AltusPlateauShadedCastleSmithingStone5___ = 1039547230,

        [Annotation(Name = "[亚坛高原 - 日荫城] 锻造石【５】 1039547240")]
        AltusPlateauShadedCastleSmithingStone5____ = 1039547240,

        [Annotation(Name = "[亚坛高原 - 日荫城] 黄金卢恩【４】 1039547250")]
        AltusPlateauShadedCastleGoldenRune4 = 1039547250,

        [Annotation(Name = "[亚坛高原 - 日荫城] 锻造石【４】 1039547260")]
        AltusPlateauShadedCastleSmithingStone4_ = 1039547260,

        [Annotation(Name = "[亚坛高原 - 日荫城] 女武神的义手 1039547300")]
        AltusPlateauShadedCastleValkyriesProsthesis = 1039547300,

        [Annotation(Name = "[亚坛高原 - 日荫城] 星光碎片 1039547350")]
        AltusPlateauShadedCastleStarlightShards = 1039547350,

        [Annotation(Name = "[亚坛高原 - 双大树守卫西南] 扇形重力石 1040507000")]
        AltusPlateauSouthwestOfTreeSentinelDuoGravityStoneFan = 1040507000,

        [Annotation(Name = "[亚坛高原 - 唤雷教堂] 星星泪滴 1040517000")]
        AltusPlateauStormcallerChurchCelestialDew = 1040517000,

        [Annotation(Name = "[亚坛高原 - 唤雷教堂] 古牙 1040517010")]
        AltusPlateauStormcallerChurchOldFang = 1040517010,

        [Annotation(Name = "[亚坛高原 - 唤雷教堂] 龙雷庇佑 1040517020")]
        AltusPlateauStormcallerChurchDragonboltBlessing = 1040517020,

        [Annotation(Name = "[亚坛高原 - 唤雷教堂] 野兽血液 1040517030")]
        AltusPlateauStormcallerChurchBeastBlood = 1040517030,

        [Annotation(Name = "[亚坛高原 - 唤雷教堂] 雷电大弩箭 1040517040")]
        AltusPlateauStormcallerChurchLightningGreatbolt = 1040517040,

        [Annotation(Name = "[亚坛高原 - 穿林大桥] 琥珀星光 1040527000")]
        AltusPlateauForestSpanningGreatbridgeAmberStarlight = 1040527000,

        [Annotation(Name = "[亚坛高原 - 穿林大桥] 黄金卢恩【６】 1040527010")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune6 = 1040527010,

        [Annotation(Name = "[亚坛高原 - 穿林大桥] 黄金卢恩【６】 1040527020")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune6_ = 1040527020,

        [Annotation(Name = "[亚坛高原 - 穿林大桥] 黄金卢恩【４】 1040527030")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune4 = 1040527030,

        [Annotation(Name = "[亚坛高原 - 穿林大桥] 黄金卢恩【３】 1040527040")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune3 = 1040527040,

        [Annotation(Name = "[亚坛高原 - 穿林大桥] 黄金卢恩【４】 1040527050")]
        AltusPlateauForestSpanningGreatbridgeGoldenRune4_ = 1040527050,

        [Annotation(Name = "[亚坛高原 - 蠕血废墟] 黄金卢恩【５】 1040537000")]
        AltusPlateauWrithebloodRuinsGoldenRune5 = 1040537000,

        [Annotation(Name = "[亚坛高原 - 蠕血废墟] 鲜血旋流 1040537010")]
        AltusPlateauWrithebloodRuinsBloodyHelice = 1040537010,

        [Annotation(Name = "[亚坛高原 - 蠕血废墟] 蜕生蝶 1040537020")]
        AltusPlateauWrithebloodRuinsNascentButterfly = 1040537020,

        [Annotation(Name = "[亚坛高原 - 蠕血废墟] 雷电花 1040537030")]
        AltusPlateauWrithebloodRuinsFulgurbloom = 1040537030,

        [Annotation(Name = "[亚坛高原 - 蠕血废墟] 黄金箭 1040537040")]
        AltusPlateauWrithebloodRuinsGoldenArrow = 1040537040,

        [Annotation(Name = "[亚坛高原 - 蠕血废墟] 野兽肉块 1040537050")]
        AltusPlateauWrithebloodRuinsLumpOfFlesh = 1040537050,

        [Annotation(Name = "[亚坛高原 - 蠕血废墟] 粗大兽骨 1040537060")]
        AltusPlateauWrithebloodRuinsHeftyBeastBone = 1040537060,

        [Annotation(Name = "[亚坛高原 - 移送罪人之路（路旁）] 巨星锤 1040547000")]
        AltusPlateauRoadOfIniquitySidePathGreatStars = 1040547000,

        [Annotation(Name = "[亚坛高原 - 移送罪人之路（路旁）] 碎石 1040547010")]
        AltusPlateauRoadOfIniquitySidePathGravelStone = 1040547010,

        [Annotation(Name = "[亚坛高原 - 移送罪人之路（路旁）] 催眠苔药 1040547030")]
        AltusPlateauRoadOfIniquitySidePathStimulatingBoluses = 1040547030,

        [Annotation(Name = "[亚坛高原 - 移送罪人之路（路旁）] 伤龙油脂 1040547050")]
        AltusPlateauRoadOfIniquitySidePathDragonwoundGrease = 1040547050,

        [Annotation(Name = "[亚坛高原 - 移送罪人之路（路旁）] 光耀金面具 1040547090")]
        AltusPlateauRoadOfIniquitySidePathRadiantGoldMask = 1040547090,

        [Annotation(Name = "[亚坛高原 - 西边风车牧场] 大老鼠的骨灰 1040557000")]
        AltusPlateauWestWindmillPastureGiantRatAshes = 1040557000,

        [Annotation(Name = "[亚坛高原 - 双大树守卫] 黄金卢恩【３】 1041517000")]
        AltusPlateauTreeSentinelDuoGoldenRune3 = 1041517000,

        [Annotation(Name = "[亚坛高原 - 双大树守卫] 黄金卢恩【６】 1041517010")]
        AltusPlateauTreeSentinelDuoGoldenRune6 = 1041517010,

        [Annotation(Name = "[亚坛高原 - 双大树守卫] 腌制白银鸟爪 1041517020")]
        AltusPlateauTreeSentinelDuoSilverPickledFowlFoot = 1041517020,

        [Annotation(Name = "[亚坛高原 - 双大树守卫] 块状重力石 1041517030")]
        AltusPlateauTreeSentinelDuoGravityStoneChunk = 1041517030,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 黄金卢恩【８】 1041527000")]
        AltusPlateauRampartsidePathGoldenRune8 = 1041527000,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 黄金卢恩【６】 1041527010")]
        AltusPlateauRampartsidePathGoldenRune6 = 1041527010,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 黄金卢恩【４】 1041527020")]
        AltusPlateauRampartsidePathGoldenRune4 = 1041527020,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 黄金卢恩【３】 1041527030")]
        AltusPlateauRampartsidePathGoldenRune3 = 1041527030,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 黄金卢恩【１】 1041527040")]
        AltusPlateauRampartsidePathGoldenRune1 = 1041527040,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 野兽肉块 1041527070")]
        AltusPlateauRampartsidePathLumpOfFlesh = 1041527070,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 章鱼卵 1041527080")]
        AltusPlateauRampartsidePathLandOctopusOvary = 1041527080,

        [Annotation(Name = "[亚坛高原 - 城墙旁小径] 石剑钥匙 1041527090")]
        AltusPlateauRampartsidePathStoneswordKey = 1041527090,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 兽骨毒飞刀 1041537010")]
        AltusPlateauWoodfolkRuinsPoisonboneDart = 1041537010,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 黄金之怒 1041537020")]
        AltusPlateauWoodfolkRuinsWrathOfGold = 1041537020,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 健壮白肉干 1041537030")]
        AltusPlateauWoodfolkRuinsInvigoratingWhiteCuredMeat = 1041537030,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 野兽血液 1041537040")]
        AltusPlateauWoodfolkRuinsBeastBlood = 1041537040,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 流浪战士的制作笔记【１９】 67070")]
        AltusPlateauWoodfolkRuinsNomadicWarriorsCookbook19 = 67070,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 碎石 1041537060")]
        AltusPlateauWoodfolkRuinsGravelStone = 1041537060,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 柔软棉花 1041537070")]
        AltusPlateauWoodfolkRuinsSoftCotton = 1041537070,

        [Annotation(Name = "[亚坛高原 - 森林之民的废墟] 神圣绘画盾 1041537080")]
        AltusPlateauWoodfolkRuinsIconShield = 1041537080,

        [Annotation(Name = "[亚坛高原 - 风车村西] 中毒油脂 1041547000")]
        AltusPlateauWestWindmillVillagePoisonGrease = 1041547000,

        [Annotation(Name = "[亚坛高原 - 东边风车牧场] 骑士双头剑 1041557000")]
        AltusPlateauEastWindmillPastureTwinnedKnightSwords = 1041557000,

        [Annotation(Name = "[亚坛高原 - 东边风车牧场] 生肉丸 1041557010")]
        AltusPlateauEastWindmillPastureRawMeatDumpling = 1041557010,

        [Annotation(Name = "[亚坛高原 - 东边风车牧场] 深蓝风帽 1041557020")]
        AltusPlateauEastWindmillPastureNavyHood = 1041557020,

        [Annotation(Name = "[王城罗德尔 - 城外幻影树以南] 粉碎巨人槌 1042507000")]
        LeyndellSouthOfOuterWallPhantomTreeGiantCrusher = 1042507000,

        [Annotation(Name = "[王城罗德尔 - 城外幻影树以南] 黄金种子 1042507020")]
        LeyndellSouthOfOuterWallPhantomTreeGoldenSeed = 1042507020,

        [Annotation(Name = "[王城罗德尔 - 城外幻影树] 圣油脂 1042517000")]
        LeyndellOuterWallPhantomTreeHolyGrease = 1042517000,

        [Annotation(Name = "[王城罗德尔 - 城外幻影树] 石像鬼大斧 1042517900")]
        LeyndellOuterWallPhantomTreeGargoylesGreatAxe = 1042517900,

        [Annotation(Name = "[王城罗德尔 - 城外战场西南] 古牙 1042527000")]
        LeyndellSouthwestOuterWallBattlegroundOldFang = 1042527000,

        [Annotation(Name = "[王城罗德尔 - 城外战场西南] 黄金卢恩【４】 1042527010")]
        LeyndellSouthwestOuterWallBattlegroundGoldenRune4 = 1042527010,

        [Annotation(Name = "[王城罗德尔 - 城外战场西南] 虹彩石 1042527020")]
        LeyndellSouthwestOuterWallBattlegroundRainbowStone = 1042527020,

        [Annotation(Name = "[王城罗德尔 - 城外战场西南] 黄金卢恩【１０】 1042527030")]
        LeyndellSouthwestOuterWallBattlegroundGoldenRune10 = 1042527030,

        [Annotation(Name = "[王城罗德尔 - 城外战场西南] 亚缇莉亚叶 1042527040")]
        LeyndellSouthwestOuterWallBattlegroundArteriaLeaf = 1042527040,

        [Annotation(Name = "[王城罗德尔 - 城外战场西北] 雷电大弩箭 1042537000")]
        LeyndellNorthwestOuterWallBattlegroundLightningGreatbolt = 1042537000,

        [Annotation(Name = "[王城罗德尔 - 城外战场西北] 失色锻造石【５】 1042537010")]
        LeyndellNorthwestOuterWallBattlegroundSomberSmithingStone5 = 1042537010,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 四趾鸟爪 1042547000")]
        AltusPlateauHighwayLookoutTowerFourToedFowlFoot = 1042547000,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 黄金卢恩【５】 1042547010")]
        AltusPlateauHighwayLookoutTowerGoldenRune5 = 1042547010,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 抗圣肝脏干 1042547020")]
        AltusPlateauHighwayLookoutTowerHolyproofDriedLiver = 1042547020,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 风暴鹰羽毛 1042547030")]
        AltusPlateauHighwayLookoutTowerStormhawkFeather = 1042547030,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 粗大兽骨 1042547040")]
        AltusPlateauHighwayLookoutTowerHeftyBeastBone = 1042547040,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 黄金箭 1042547050")]
        AltusPlateauHighwayLookoutTowerGoldenArrow = 1042547050,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 大弓 1042547060")]
        AltusPlateauHighwayLookoutTowerGreatbow = 1042547060,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 金色萤火虫 1042547070")]
        AltusPlateauHighwayLookoutTowerGoldFirefly = 1042547070,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 雷油脂 1042547080")]
        AltusPlateauHighwayLookoutTowerLightningGrease = 1042547080,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 勇者肉块 1042547090")]
        AltusPlateauHighwayLookoutTowerExaltedFlesh = 1042547090,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 卢恩弯弧 1042547100")]
        AltusPlateauHighwayLookoutTowerRuneArc = 1042547100,

        [Annotation(Name = "[亚坛高原 - 风车村高台] 庆典大头盖骨 1042557000")]
        AltusPlateauWindmillHeightsCelebrantsSkull = 1042557000,

        [Annotation(Name = "[王城罗德尔 - 小黄金树教堂] 黄金律法圣印记 1043507000")]
        LeyndellMinorErdtreeChurchGoldenOrderSeal = 1043507000,

        [Annotation(Name = "[王城罗德尔 - 小黄金树教堂] 火星蝶 1043507010")]
        LeyndellMinorErdtreeChurchSmolderingButterfly = 1043507010,

        [Annotation(Name = "[王城罗德尔 - 小黄金树教堂] 传道士的制作笔记【４】 67640")]
        LeyndellMinorErdtreeChurchMissionarysCookbook4 = 67640,

        [Annotation(Name = "[王城罗德尔 - 城外战场东南] 失力战灰 1043527000")]
        LeyndellSoutheastOuterWallBattlegroundLostAshesOfWar = 1043527000,

        [Annotation(Name = "[王城罗德尔 - 城外战场东南] 黄金卢恩【５】 1043527030")]
        LeyndellSoutheastOuterWallBattlegroundGoldenRune5 = 1043527030,

        [Annotation(Name = "[王城罗德尔 - 城外战场东南] 绿琥珀链坠＋１ 1043527500")]
        LeyndellSoutheastOuterWallBattlegroundViridianAmberMedallion1 = 1043527500,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 黄金卢恩【９】 1043537000")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune9 = 1043537000,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 黄金卢恩【１０】 1043537010")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune10 = 1043537010,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 泪滴幼体 1043537100")]
        LeyndellNortheastOuterWallBattlegroundLarvalTear = 1043537100,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 拟态赐福 1043537020")]
        LeyndellNortheastOuterWallBattlegroundGraceMimic = 1043537020,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 附绳圣油脂 1043537030")]
        LeyndellNortheastOuterWallBattlegroundDrawstringHolyGrease = 1043537030,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 锻造石【５】 1043537040")]
        LeyndellNortheastOuterWallBattlegroundSmithingStone5 = 1043537040,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 黄金卢恩【５】 1043537050")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune5 = 1043537050,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 黄金卢恩【７】 1043537060")]
        LeyndellNortheastOuterWallBattlegroundGoldenRune7 = 1043537060,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 蘑菇 1043537070")]
        LeyndellNortheastOuterWallBattlegroundMushroom = 1043537070,

        [Annotation(Name = "[王城罗德尔 - 城外战场东北] 苔药贩子的铃珠 1043537400")]
        LeyndellNortheastOuterWallBattlegroundMedicinePeddlersBellBearing = 1043537400,

        [Annotation(Name = "[王城罗德尔 - 小黄金树以南] 大箭 1044527000")]
        LeyndellSouthOfMinorErdtreeGreatArrow = 1044527000,

        [Annotation(Name = "[王城罗德尔 - 小黄金树以南] 黄金卢恩【６】 1044527010")]
        LeyndellSouthOfMinorErdtreeGoldenRune6 = 1044527010,

        [Annotation(Name = "[王城罗德尔 - 小黄金树以南] 黄金卢恩【２】 1044527020")]
        LeyndellSouthOfMinorErdtreeGoldenRune2 = 1044527020,

        [Annotation(Name = "[王城罗德尔 - 小黄金树] 黄金卢恩【４】 1044537010")]
        LeyndellMinorErdtreeGoldenRune4 = 1044537010,

        [Annotation(Name = "[王城罗德尔 - 王城城墙前方] 扇形重力石 1045527000")]
        LeyndellCapitalRampartGravityStoneFan = 1045527000,

        [Annotation(Name = "[王城罗德尔 - 王城城墙前方] 碎石 1045527010")]
        LeyndellCapitalRampartGravelStone = 1045527010,

        [Annotation(Name = "[王城罗德尔 - 王城城墙前方] 锻造石【６】 1045527020")]
        LeyndellCapitalRampartSmithingStone6 = 1045527020,

        [Annotation(Name = "[王城罗德尔 - 王城城墙前方] 锻造石【５】 1045527030")]
        LeyndellCapitalRampartSmithingStone5 = 1045527030,

        [Annotation(Name = "[王城罗德尔 - 小黄金树] 红结晶露滴 65030")]
        LeyndellMinorErdtreeCrimsonCrystalTear = 65030,

        [Annotation(Name = "[王城罗德尔 - 小黄金树] 细枝破露滴 65190")]
        LeyndellMinorErdtreeTwiggyCrackedTear = 65190,

        [Annotation(Name = "[王城罗德尔 - 小黄金树] 羽毛结晶露滴 65120")]
        LeyndellMinorErdtreeWingedCrystalTear = 65120,

        [Annotation(Name = "[王城罗德尔 - 小黄金树] 双鸟鸢形盾 1044537300")]
        LeyndellMinorErdtreeTwinbirdKiteShield = 1044537300,

        [Annotation(Name = "[亚坛高原 - 卢克斯废墟] 黄金种子 1038517400")]
        AltusPlateauLuxRuinsGoldenSeed = 1038517400,

        [Annotation(Name = "[亚坛高原 - 亚坛大道的三叉口] 黄金种子 1039517400")]
        AltusPlateauAltusHighwayJunctionGoldenSeed = 1039517400,

        [Annotation(Name = "[亚坛高原 - 玛莉卡第二教堂] 圣杯露滴 1039527400")]
        AltusPlateauSecondChurchOfMarikaSacredTear = 1039527400,

        [Annotation(Name = "[亚坛高原 - 风车村西] 黄金种子 1041547400")]
        AltusPlateauWestWindmillVillageGoldenSeed = 1041547400,

        [Annotation(Name = "[亚坛高原 - 唤雷教堂] 圣杯露滴 1040517400")]
        AltusPlateauStormcallerChurchSacredTear = 1040517400,

        [Annotation(Name = "[王城罗德尔 - 城外幻影树] 黄金种子 1042517400")]
        LeyndellOuterWallPhantomTreeGoldenSeed = 1042517400,

        [Annotation(Name = "[王城罗德尔 - 城外幻影树] 黄金种子 1042517410")]
        LeyndellOuterWallPhantomTreeGoldenSeed_ = 1042517410,

        [Annotation(Name = "[亚坛高原 - 大道监视塔] 黄金种子 1042547400")]
        AltusPlateauHighwayLookoutTowerGoldenSeed = 1042547400,

        [Annotation(Name = "[王城罗德尔 - 城外战场东南] 黄金种子 1043527400")]
        LeyndellSoutheastOuterWallBattlegroundGoldenSeed = 1043527400,

        [Annotation(Name = "[王城罗德尔 - 城外战场东南] 黄金种子 1043527410")]
        LeyndellSoutheastOuterWallBattlegroundGoldenSeed_ = 1043527410,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 黄金种子 1036547400")]
        MtGelmirVolcanoManorEntranceGoldenSeed = 1036547400,

        [Annotation(Name = "[格密尔火山 - “起源魔法师”亚兹勒] 黄金种子 1037537400")]
        MtGelmirPrimevalSorcererAzurGoldenSeed = 1037537400,

        [Annotation(Name = "[亚坛高原 - 穿林大桥] 地图碎片：亚坛高原 62030")]
        AltusPlateauForestSpanningGreatbridgeMapAltusPlateau = 62030,

        [Annotation(Name = "[王城罗德尔 - 城外幻影树] 地图碎片：王城罗德尔 62031")]
        LeyndellOuterWallPhantomTreeMapLeyndellRoyalCapital = 62031,

        [Annotation(Name = "[格密尔火山 - 火山官邸入口] 地图碎片：格密尔火山 62032")]
        MtGelmirVolcanoManorEntranceMapMtGelmir = 62032,

        [Annotation(Name = "[Liurnia of the Lakes - 谷底东北] 中毒苔药 1037507000")]
        LiurniaOfTheLakeNortheastRavineNeutralizingBoluses = 1037507000,

        [Annotation(Name = "[Liurnia of the Lakes - 谷底东北] 黄金种子 1037507100")]
        LiurniaOfTheLakeNortheastRavineGoldenSeed = 1037507100,

        [Annotation(Name = "[王城罗德尔 - 东亚坛神授塔入口] 附绳火油脂 1047517000")]
        LeyndellDivineTowerOfEastAltusEntranceDrawstringFireGrease = 1047517000,

        [Annotation(Name = "[王城罗德尔 - 东亚坛神授塔入口] 黄金卢恩【７】 1047517010")]
        LeyndellDivineTowerOfEastAltusEntranceGoldenRune7 = 1047517010,

        [Annotation(Name = "[王城罗德尔 - 东亚坛神授塔入口] 伤龙油脂 1047517300")]
        LeyndellDivineTowerOfEastAltusEntranceDragonwoundGrease = 1047517300,

        [Annotation(Name = "[桂奥尔龙墓 - 隐居商人的破屋] 失色锻造石【７】 1048517000")]
        GreyollsDragonbarrowIsolatedMerchantsShackSomberSmithingStone7 = 1048517000,

        [Annotation(Name = "[桂奥尔龙墓 - 隐居商人的破屋] 战灰：幻影共击 1048517700")]
        GreyollsDragonbarrowIsolatedMerchantsShackAshOfWarPhantomSlash = 1048517700,

        [Annotation(Name = "[巨人山顶 - 洛德大升降机前] 结冰油脂 1049527000")]
        MountaintopsOfTheGiantsBeforeGrandLiftOfRoldFreezingGrease = 1049527000,

        [Annotation(Name = "[巨人山顶 - 洛德大升降机前] 黄金种子 1049527800")]
        MountaintopsOfTheGiantsBeforeGrandLiftOfRoldGoldenSeed = 1049527800,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟西] 肉片 1049537000")]
        MountaintopsOfTheGiantsWestZamorRuinsSliverOfMeat = 1049537000,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟西] 健壮肉干 1049537010")]
        MountaintopsOfTheGiantsWestZamorRuinsInvigoratingCuredMeat = 1049537010,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟西] 黄金卢恩【１０】 1049537020")]
        MountaintopsOfTheGiantsWestZamorRuinsGoldenRune10 = 1049537020,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟西] 萨米尔冰风暴 1049537030")]
        MountaintopsOfTheGiantsWestZamorRuinsZamorIceStorm = 1049537030,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟西] 野兽血液 1049537300")]
        MountaintopsOfTheGiantsWestZamorRuinsBeastBlood = 1049537300,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟西] 地图碎片：巨人山顶（西） 62050")]
        MountaintopsOfTheGiantsWestZamorRuinsMapMountaintopsOfTheGiantsWest = 62050,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟西] 锻造石矿工的铃珠【３】 1049537900")]
        MountaintopsOfTheGiantsWestZamorRuinsSmithingStoneMinersBellBearing3 = 1049537900,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟东] 失色锻造石【７】 1050537000")]
        MountaintopsOfTheGiantsEastZamorRuinsSomberSmithingStone7 = 1050537000,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟东] 火星蝶 1050537300")]
        MountaintopsOfTheGiantsEastZamorRuinsSmolderingButterfly = 1050537300,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟东] 失色锻造石【７】 1050537700")]
        MountaintopsOfTheGiantsEastZamorRuinsSomberSmithingStone7_ = 1050537700,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟以北] 失力战灰 1050547000")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsLostAshesOfWar = 1050547000,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟以北] 亚缇莉亚叶 1050547800")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsArteriaLeaf = 1050547800,

        [Annotation(Name = "[巨人山顶 - 萨米尔废墟以北] 责罚荆棘 1050547810")]
        MountaintopsOfTheGiantsNorthOfZamorRuinsBriarsOfPunishment = 1050547810,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 黄金卢恩【７】 1051557300")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune7 = 1051557300,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 附绳圣油脂 1051557310")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsDrawstringHolyGrease = 1051557310,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 虹彩石 1051557320")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsRainbowStone = 1051557320,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 黄金卢恩【１３】 1051557330")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune13 = 1051557330,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 褪色金轮草 1050567300")]
        MountaintopsOfTheGiantsShackOfTheLoftyTarnishedGoldenSunflower = 1050567300,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 温热石 1050567500")]
        MountaintopsOfTheGiantsShackOfTheLoftyWarmingStone = 1050567500,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 健壮白肉干 1050567510")]
        MountaintopsOfTheGiantsShackOfTheLoftyInvigoratingWhiteCuredMeat = 1050567510,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 锻造石【７】 1050567520")]
        MountaintopsOfTheGiantsShackOfTheLoftySmithingStone7 = 1050567520,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 古龙岩锻造石 1050567600")]
        MountaintopsOfTheGiantsShackOfTheLoftyAncientDragonSmithingStone = 1050567600,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 旅行女巫风帽 1050567620")]
        MountaintopsOfTheGiantsShackOfTheLoftyTravelingMaidenHood = 1050567620,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 霍斯劳花瓣鞭 1050567700")]
        MountaintopsOfTheGiantsShackOfTheLoftyHoslowsPetalWhip = 1050567700,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 锻造石【８】 1050567800")]
        MountaintopsOfTheGiantsShackOfTheLoftySmithingStone8 = 1050567800,

        [Annotation(Name = "[巨人山顶 - 离群独行者的破屋] 魔法师块护符 1050567820")]
        MountaintopsOfTheGiantsShackOfTheLoftyGravenMassTalisman = 1050567820,

        [Annotation(Name = "[巨人山顶 - 结冰湖前] 催眠苔药 1052577000")]
        MountaintopsOfTheGiantsBeforeFreezingLakeStimulatingBoluses = 1052577000,

        [Annotation(Name = "[巨人山顶 - 结冰湖前] 冻伤苔药 1052577300")]
        MountaintopsOfTheGiantsBeforeFreezingLakeThawfrostBoluses = 1052577300,

        [Annotation(Name = "[巨人山顶 - 结冰湖前] 古牙 1052577310")]
        MountaintopsOfTheGiantsBeforeFreezingLakeOldFang = 1052577310,

        [Annotation(Name = "[巨人山顶 - 结冰湖前] 黄金种子 1052577800")]
        MountaintopsOfTheGiantsBeforeFreezingLakeGoldenSeed = 1052577800,

        [Annotation(Name = "[巨人山顶 - 结冰湖前] 锻造石【７】 1052577810")]
        MountaintopsOfTheGiantsBeforeFreezingLakeSmithingStone7 = 1052577810,

        [Annotation(Name = "[巨人山顶 - 结冰湖西北] 黄金卢恩【１１】 1053577300")]
        MountaintopsOfTheGiantsNorthwestFreezingLakeGoldenRune11 = 1053577300,

        [Annotation(Name = "[巨人山顶 - 结冰湖西南] 失色锻造石【８】 1053567300")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeSomberSmithingStone8 = 1053567300,

        [Annotation(Name = "[巨人山顶 - 结冰湖西南] 黄金卢恩【１０】 1053567310")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune10 = 1053567310,

        [Annotation(Name = "[巨人山顶 - 结冰湖西南] 黄金卢恩【１２】 1053567700")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12 = 1053567700,

        [Annotation(Name = "[巨人山顶 - 结冰湖西南] 黄金卢恩【１２】 1053567710")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12_ = 1053567710,

        [Annotation(Name = "[巨人山顶 - 结冰湖西南] 黄金卢恩【１２】 1053567720")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune12__ = 1053567720,

        [Annotation(Name = "[巨人山顶 - 结冰湖西南] 黄金卢恩【７】 1053567800")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune7 = 1053567800,

        [Annotation(Name = "[巨人山顶 - 结冰湖西南] 黄金卢恩【７】 1053567810")]
        MountaintopsOfTheGiantsSouthwestFreezingLakeGoldenRune7_ = 1053567810,

        [Annotation(Name = "[巨人山顶 - 结冰湖前] 创星雨 1052577900")]
        MountaintopsOfTheGiantsBeforeFreezingLakeFoundingRainOfStars = 1052577900,

        [Annotation(Name = "[巨人山顶 - 玛莉卡第一教堂] 锻造石【７】 1054557000")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSmithingStone7 = 1054557000,

        [Annotation(Name = "[巨人山顶 - 玛莉卡第一教堂] 失色石矿工的铃珠【３】 1054557310")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSomberstoneMinersBellBearing3 = 1054557310,

        [Annotation(Name = "[巨人山顶 - 玛莉卡第一教堂] 圣杯露滴 1054557800")]
        MountaintopsOfTheGiantsFirstChurchOfMarikaSacredTear = 1054557800,

        [Annotation(Name = "[巨人山顶 - 降雪棱线路] 爆炸大弩箭 1052567300")]
        MountaintopsOfTheGiantsWhiteridgeRoadExplosiveGreatbolt = 1052567300,

        [Annotation(Name = "[巨人山顶 - 降雪棱线路] 卢恩弯弧 1052567310")]
        MountaintopsOfTheGiantsWhiteridgeRoadRuneArc = 1052567310,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 古龙岩锻造石 1051537000")]
        MountaintopsOfTheGiantsGiantsGravepostAncientDragonSmithingStone = 1051537000,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 锻造石【７】 1051537010")]
        MountaintopsOfTheGiantsGiantsGravepostSmithingStone7 = 1051537010,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 附绳圣油脂 1051537300")]
        MountaintopsOfTheGiantsGiantsGravepostDrawstringHolyGrease = 1051537300,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 尸山血海 1051537500")]
        MountaintopsOfTheGiantsGiantsGravepostRiversOfBlood = 1051537500,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 战灰：山妖咆哮 1051537600")]
        MountaintopsOfTheGiantsGiantsGravepostAshOfWarTrollsRoar = 1051537600,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 失色锻造石【８】 1051537700")]
        MountaintopsOfTheGiantsGiantsGravepostSomberSmithingStone8 = 1051537700,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 圣杯露滴 1051537800")]
        MountaintopsOfTheGiantsGiantsGravepostSacredTear = 1051537800,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 温热石 1051537810")]
        MountaintopsOfTheGiantsGiantsGravepostWarmingStone = 1051537810,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 健壮白肉干 1051547000")]
        MountaintopsOfTheGiantsGiantsGravepostInvigoratingWhiteCuredMeat = 1051547000,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑] 扇形暗器 1051547800")]
        MountaintopsOfTheGiantsGiantsGravepostFanDaggers = 1051547800,

        [Annotation(Name = "[巨人山顶 - 火焰巨人场地西北] 黄金卢恩【１０】 1052537000")]
        MountaintopsOfTheGiantsNorthwestFireGiantArenaGoldenRune10 = 1052537000,

        [Annotation(Name = "[巨人山顶 - 火焰巨人场地西北] 黄金种子 1052537800")]
        MountaintopsOfTheGiantsNorthwestFireGiantArenaGoldenSeed = 1052537800,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑东北] 拟态赐福 1052547000")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGraceMimic = 1052547000,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑东北] 黄金卢恩【１０】 1052547010")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGoldenRune10 = 1052547010,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑东北] 黄金卢恩【１０】 1052547020")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostGoldenRune10_ = 1052547020,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑东北] 地图碎片：巨人山顶（东） 62051")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostMapMountaintopsOfTheGiantsEast = 62051,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑东北] 星光碎片 1052547800")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostStarlightShards = 1052547800,

        [Annotation(Name = "[巨人山顶 - 巨人墓碑东北] 红漩泡状露滴 65200")]
        MountaintopsOfTheGiantsNortheastGiantsGravepostCrimsonwhorlBubbletear = 65200,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 火星蝶 1052557000")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmolderingButterfly = 1052557000,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 锻造石【７】 1052557010")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmithingStone7 = 1052557010,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 黄金卢恩【１０】 1052557020")]
        MountaintopsOfTheGiantsGuardiansGarrisonGoldenRune10 = 1052557020,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 火星蝶 1052557030")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmolderingButterfly_ = 1052557030,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 锻造石【７】 1052557040")]
        MountaintopsOfTheGiantsGuardiansGarrisonSmithingStone7_ = 1052557040,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 黄金卢恩【８】 1052557300")]
        MountaintopsOfTheGiantsGuardiansGarrisonGoldenRune8 = 1052557300,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 石剑钥匙 1052557310")]
        MountaintopsOfTheGiantsGuardiansGarrisonStoneswordKey = 1052557310,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 独眼盾 1052557700")]
        MountaintopsOfTheGiantsGuardiansGarrisonOneEyedShield = 1052557700,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 碎石 1052557800")]
        MountaintopsOfTheGiantsGuardiansGarrisonGravelStone = 1052557800,

        [Annotation(Name = "[巨人山顶 - 监视者要塞] 巨人祷告书 1052557900")]
        MountaintopsOfTheGiantsGuardiansGarrisonGiantsPrayerbook = 1052557900,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 失色锻造石【９】 1051567020")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSomberSmithingStone9 = 1051567020,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 结冰油脂 1051567030")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsFreezingGrease = 1051567030,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 蚁酸石 1051567300")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsFormicRock = 1051567300,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 柔软棉花 1051567310")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSoftCotton = 1051567310,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 黄金卢恩【１０】 1051567320")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsGoldenRune10 = 1051567320,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 失色锻造石【８】 1051567700")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsSomberSmithingStone8 = 1051567700,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 米凯拉睡莲 1051567800")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsMiquellasLily = 1051567800,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 米凯拉睡莲 1051567810")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsMiquellasLily_ = 1051567810,

        [Annotation(Name = "[巨人山顶 - 古遗迹降雪谷] 源辉石刀 1051567900")]
        MountaintopsOfTheGiantsAncientSnowValleyRuinsPrimalGlintstoneBlade = 1051567900,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 结冰油脂 1051577000")]
        MountaintopsOfTheGiantsSouthCastleSolFreezingGrease = 1051577000,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 黄金卢恩【１０】 1051577010")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10 = 1051577010,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 锻造石【５】 1051577020")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone5 = 1051577020,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 扇形暗器 1051577030")]
        MountaintopsOfTheGiantsSouthCastleSolFanDaggers = 1051577030,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 黄金卢恩【１０】 1051577040")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10_ = 1051577040,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 黄金卢恩【１０】 1051577050")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10__ = 1051577050,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 蜕生蝶 1051577060")]
        MountaintopsOfTheGiantsSouthCastleSolNascentButterfly = 1051577060,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 蓝琥珀链坠＋１ 1051577070")]
        MountaintopsOfTheGiantsSouthCastleSolCeruleanAmberMedallion1 = 1051577070,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 锻造石【７】 1051577080")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone7 = 1051577080,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 锻造石【５】 1051577090")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone5_ = 1051577090,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 锻造石【６】 1051577100")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone6 = 1051577100,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 失色锻造石【８】 1051577110")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone8 = 1051577110,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 黄金卢恩【１０】 1051577120")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10___ = 1051577120,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 人骨碎片 1051577130")]
        MountaintopsOfTheGiantsSouthCastleSolHumanBoneShard = 1051577130,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 黄金卢恩【１１】 1051577140")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune11 = 1051577140,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 冻伤苔药 1051577150")]
        MountaintopsOfTheGiantsSouthCastleSolThawfrostBoluses = 1051577150,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 唤勾指药 1051577160")]
        MountaintopsOfTheGiantsSouthCastleSolFurlcallingFingerRemedy = 1051577160,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 锻造石【６】 1051577170")]
        MountaintopsOfTheGiantsSouthCastleSolSmithingStone6_ = 1051577170,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 冻伤苔药 1051577180")]
        MountaintopsOfTheGiantsSouthCastleSolThawfrostBoluses_ = 1051577180,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 失色锻造石【８】 1051577190")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone8_ = 1051577190,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 黄金卢恩【９】 1051577200")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune9 = 1051577200,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 卢恩弯弧 1051577210")]
        MountaintopsOfTheGiantsSouthCastleSolRuneArc = 1051577210,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 风暴鹰斧 1051577220")]
        MountaintopsOfTheGiantsSouthCastleSolStormhawkAxe = 1051577220,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 黄金卢恩【１０】 1051577230")]
        MountaintopsOfTheGiantsSouthCastleSolGoldenRune10____ = 1051577230,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 石剑钥匙 1051577300")]
        MountaintopsOfTheGiantsSouthCastleSolStoneswordKey = 1051577300,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 日蚀钩剑 1051577600")]
        MountaintopsOfTheGiantsSouthCastleSolEclipseShotel = 1051577600,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 赫芬尖塔剑 1051577720")]
        MountaintopsOfTheGiantsSouthCastleSolHelphensSteeple = 1051577720,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 失色锻造石【７】 1051577800")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone7 = 1051577800,

        [Annotation(Name = "[巨人山顶 - 索尔城南] 失色锻造石【７】 1051577810")]
        MountaintopsOfTheGiantsSouthCastleSolSomberSmithingStone7_ = 1051577810,

        [Annotation(Name = "[巨人山顶 - 结冰湖西北] 黄金卢恩【４】 1052587800")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune4 = 1052587800,

        [Annotation(Name = "[巨人山顶 - 结冰湖西北] 黄金卢恩【５】 1052587810")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune5 = 1052587810,

        [Annotation(Name = "[巨人山顶 - 结冰湖西北] 黄金卢恩【１０】 1052587820")]
        MountaintopsOfTheGiantsNorthwestOfFreezingLakeGoldenRune10 = 1052587820,

        [Annotation(Name = "[巨人山顶 - 索尔城北] 圣树秘密符节（左） 1051587800")]
        MountaintopsOfTheGiantsNorthCastleSolHaligtreeSecretMedallionLeft = 1051587800,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯废墟] 锻造石【７】 1047557000")]
        ConsecratedSnowfieldYeloughAnixRuinsSmithingStone7 = 1047557000,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯废墟] 罗亚原种果实 1047557010")]
        ConsecratedSnowfieldYeloughAnixRuinsRimedRowa = 1047557010,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯废墟] 黄金卢恩【１３】 1047557020")]
        ConsecratedSnowfieldYeloughAnixRuinsGoldenRune13 = 1047557020,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯废墟] 石剑钥匙 1047557030")]
        ConsecratedSnowfieldYeloughAnixRuinsStoneswordKey = 1047557030,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯废墟] 黄金卢恩【７】 1047557040")]
        ConsecratedSnowfieldYeloughAnixRuinsGoldenRune7 = 1047557040,

        [Annotation(Name = "[化圣雪原 - 耶罗·亚尼斯废墟] 难耐癫火 1047557900")]
        ConsecratedSnowfieldYeloughAnixRuinsUnendurableFrenzy = 1047557900,

        [Annotation(Name = "[化圣雪原 - 耶尼·亚罗斯废墟以北] 英雄卢恩【２】 1047567300")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsHerosRune2 = 1047567300,

        [Annotation(Name = "[化圣雪原 - 耶尼·亚罗斯废墟以北] 锻造石【８】 1047567310")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsSmithingStone8 = 1047567310,

        [Annotation(Name = "[化圣雪原 - 耶尼·亚罗斯废墟以北] 冻伤苔药 1047567320")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsThawfrostBoluses = 1047567320,

        [Annotation(Name = "[化圣雪原 - 耶尼·亚罗斯废墟以北] 结晶飞刀 1047567330")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsCrystalDart = 1047567330,

        [Annotation(Name = "[化圣雪原 - 耶尼·亚罗斯废墟以北] 鲜血贵族风帽 1047567700")]
        ConsecratedSnowfieldNorthOfYeloughAnixRuinsSanguineNobleHood = 1047567700,

        [Annotation(Name = "[化圣雪原 - 最西边悬崖] 黄金卢恩【１】 1046577300")]
        ConsecratedSnowfieldFarWestCliffsideGoldenRune1 = 1046577300,

        [Annotation(Name = "[化圣雪原 - 最西边悬崖] 锻造石【７】 1046577800")]
        ConsecratedSnowfieldFarWestCliffsideSmithingStone7 = 1046577800,

        [Annotation(Name = "[化圣雪原 - 仪典镇以南] 石剑钥匙 1048567300")]
        ConsecratedSnowfieldSouthOfOrdinaStoneswordKey = 1048567300,

        [Annotation(Name = "[化圣雪原 - 仪典镇以南] 地图碎片：化圣雪原 62052")]
        ConsecratedSnowfieldSouthOfOrdinaMapConsecratedSnowfield = 62052,

        [Annotation(Name = "[化圣雪原 - 仪典镇以南] 古龙岩失色锻造石 1048567800")]
        ConsecratedSnowfieldSouthOfOrdinaSomberAncientDragonSmithingStone = 1048567800,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 卢恩弯弧 1048577000")]
        ConsecratedSnowfieldOrdinaLiturgicalTownRuneArc = 1048577000,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 黄金卢恩【１３】 1048577010")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune13 = 1048577010,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 粗大兽骨 1048577020")]
        ConsecratedSnowfieldOrdinaLiturgicalTownHeftyBeastBone = 1048577020,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 黄金卢恩【１３】 1048577030")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune13_ = 1048577030,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 结冰油脂 1048577040")]
        ConsecratedSnowfieldOrdinaLiturgicalTownFreezingGrease = 1048577040,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 杜鹃辉石 1048577050")]
        ConsecratedSnowfieldOrdinaLiturgicalTownCuckooGlintstone = 1048577050,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 结晶飞刀 1048577060")]
        ConsecratedSnowfieldOrdinaLiturgicalTownCrystalDart = 1048577060,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 古牙 1048577070")]
        ConsecratedSnowfieldOrdinaLiturgicalTownOldFang = 1048577070,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 眠卵 1048577080")]
        ConsecratedSnowfieldOrdinaLiturgicalTownSlumberingEgg = 1048577080,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 黄金卢恩【１２】 1048577090")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune12 = 1048577090,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 健壮肉干 1048577300")]
        ConsecratedSnowfieldOrdinaLiturgicalTownInvigoratingCuredMeat = 1048577300,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 黄金卢恩【１０】 1048577310")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenRune10 = 1048577310,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 迸发灵火 1048577700")]
        ConsecratedSnowfieldOrdinaLiturgicalTownExplosiveGhostflame = 1048577700,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 黄金种子 1048577800")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGoldenSeed = 1048577800,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 黑刀风帽 1048577810")]
        ConsecratedSnowfieldOrdinaLiturgicalTownBlackKnifeHood = 1048577810,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 灵依墓地铃兰【９】 1048577900")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9 = 1048577900,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 灵依墓地铃兰【９】 1048577910")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9_ = 1048577910,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 灵依墓地铃兰【９】 1048577920")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9__ = 1048577920,

        [Annotation(Name = "[化圣雪原 - “仪典镇”奥缇那] 灵依墓地铃兰【９】 1048577930")]
        ConsecratedSnowfieldOrdinaLiturgicalTownGhostGlovewort9___ = 1048577930,

        [Annotation(Name = "[化圣雪原 - 离教废屋以东] 黄金卢恩【１３】 1048587300")]
        ConsecratedSnowfieldEastOfApostateDerelictGoldenRune13 = 1048587300,

        [Annotation(Name = "[化圣雪原 - 通往圣树的密道] 黄金卢恩【１３】 1049547300")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeGoldenRune13 = 1049547300,

        [Annotation(Name = "[化圣雪原 - 通往圣树的密道] 黄金卢恩【１１】 1049547310")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeGoldenRune11 = 1049547310,

        [Annotation(Name = "[化圣雪原 - 通往圣树的密道] 失色锻造石【８】 1049547700")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeSomberSmithingStone8 = 1049547700,

        [Annotation(Name = "[化圣雪原 - 通往圣树的密道] 流浪战士的制作笔记【２３】 67090")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeNomadicWarriorsCookbook23 = 67090,

        [Annotation(Name = "[化圣雪原 - 通往圣树的密道] 托莉娜烛火 1049547900")]
        ConsecratedSnowfieldHiddenPathtoTheHaligtreeStTrinasTorch = 1049547900,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西南] 黄金卢恩【１】 1048547800")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune1 = 1048547800,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西南] 黄金卢恩【３】 1048547810")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune3 = 1048547810,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西南] 黄金卢恩【６】 1048547820")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune6 = 1048547820,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西南] 黄金卢恩【９】 1048547830")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune9 = 1048547830,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西南] 黄金卢恩【１１】 1048547840")]
        ConsecratedSnowfieldSouthwestFoggyAreaGoldenRune11 = 1048547840,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西北] 黄金卢恩【１３】 1048557300")]
        ConsecratedSnowfieldNorthwestFoggyAreaGoldenRune13 = 1048557300,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西北] 健壮角饰品＋１ 1048557600")]
        ConsecratedSnowfieldNorthwestFoggyAreaStalwartHornCharm1 = 1048557600,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西北] 古龙岩锻造石 1048557700")]
        ConsecratedSnowfieldNorthwestFoggyAreaAncientDragonSmithingStone = 1048557700,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西北] 黑夜骑兵头盔 1048557710")]
        ConsecratedSnowfieldNorthwestFoggyAreaNightsCavalryHelm = 1048557710,

        [Annotation(Name = "[化圣雪原 - 暴雪区域西北] 流水曲剑 1048557900")]
        ConsecratedSnowfieldNorthwestFoggyAreaFlowingCurvedSword = 1048557900,

        [Annotation(Name = "[化圣雪原 - 暴雪区域东北] 失色锻造石【９】 1049557300")]
        ConsecratedSnowfieldNortheastFoggyAreaSomberSmithingStone9 = 1049557300,

        [Annotation(Name = "[化圣雪原 - 暴雪区域东北] 古牙 1049557310")]
        ConsecratedSnowfieldNortheastFoggyAreaOldFang = 1049557310,

        [Annotation(Name = "[化圣雪原 - 暴雪区域东北] 火焰花 1049557320")]
        ConsecratedSnowfieldNortheastFoggyAreaFireBlossom = 1049557320,

        [Annotation(Name = "[化圣雪原 - 暴雪区域东北] 米凯拉睡莲 1049557330")]
        ConsecratedSnowfieldNortheastFoggyAreaMiquellasLily = 1049557330,

        [Annotation(Name = "[化圣雪原 - 暴雪区域东北] 泪滴幼体 1049557700")]
        ConsecratedSnowfieldNortheastFoggyAreaLarvalTear = 1049557700,

        [Annotation(Name = "[化圣雪原 - 暴雪区域东北] 黄金种子 1049557800")]
        ConsecratedSnowfieldNortheastFoggyAreaGoldenSeed = 1049557800,

        [Annotation(Name = "[化圣雪原 - 暴雪区域东北] 黄金卢恩【１１】 1049557810")]
        ConsecratedSnowfieldNortheastFoggyAreaGoldenRune11 = 1049557810,

        [Annotation(Name = "[化圣雪原 - 奥尔迪纳东南] 白金凝血 1049567300")]
        ConsecratedSnowfieldSoutheastOfOrdinaAlbinauricBloodclot = 1049567300,

        [Annotation(Name = "[化圣雪原 - 奥尔迪纳东南] 古牙 1049567310")]
        ConsecratedSnowfieldSoutheastOfOrdinaOldFang = 1049567310,

        [Annotation(Name = "[化圣雪原 - 奥尔迪纳东南] 白色肉片 1049567320")]
        ConsecratedSnowfieldSoutheastOfOrdinaStripOfWhiteFlesh = 1049567320,

        [Annotation(Name = "[化圣雪原 - 奥尔迪纳东南] 伤龙油脂 1049567330")]
        ConsecratedSnowfieldSoutheastOfOrdinaDragonwoundGrease = 1049567330,

        [Annotation(Name = "[化圣雪原 - 奥尔迪纳东南] 蜕生蝶 1049567340")]
        ConsecratedSnowfieldSoutheastOfOrdinaNascentButterfly = 1049567340,

        [Annotation(Name = "[化圣雪原 - 奥尔迪纳东南] 锻造石【８】 1049567350")]
        ConsecratedSnowfieldSoutheastOfOrdinaSmithingStone8 = 1049567350,

        [Annotation(Name = "[化圣雪原 - 奥尔迪纳东南] 辉石工匠的制作笔记【８】 67440")]
        ConsecratedSnowfieldSoutheastOfOrdinaGlintstoneCraftsmansCookbook8 = 67440,

        [Annotation(Name = "[化圣雪原 - 仪典镇以东] 失色锻造石【７】 1049577700")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone7 = 1049577700,

        [Annotation(Name = "[化圣雪原 - 仪典镇以东] 失色锻造石【８】 1049577710")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone8 = 1049577710,

        [Annotation(Name = "[化圣雪原 - 仪典镇以东] 失色锻造石【９】 1049577720")]
        ConsecratedSnowfieldEastOfOrdinaSomberSmithingStone9 = 1049577720,

        [Annotation(Name = "[巨人山顶 - 索尔城西] 温热石 1050577300")]
        MountaintopsOfTheGiantsWestOfCastleSolWarmingStone = 1050577300,

        [Annotation(Name = "[巨人山顶 - 索尔城西] 星光碎片 1050577800")]
        MountaintopsOfTheGiantsWestOfCastleSolStarlightShards = 1050577800,

        [Annotation(Name = "[化圣雪原 - 仪典镇以西] 黄金卢恩【７】 1047577300")]
        ConsecratedSnowfieldWestOfOrdinaGoldenRune7 = 1047577300,

        [Annotation(Name = "[化圣雪原 - 仪典镇以西] 黄金卢恩【１２】 1047577310")]
        ConsecratedSnowfieldWestOfOrdinaGoldenRune12 = 1047577310,

        [Annotation(Name = "[化圣雪原 - 离教废屋] 失色锻造石【９】 1047587000")]
        ConsecratedSnowfieldApostateDerelictSomberSmithingStone9 = 1047587000,

        [Annotation(Name = "[化圣雪原 - 离教废屋] 白银盾 1047587800")]
        ConsecratedSnowfieldApostateDerelictSilverMirrorshield = 1047587800,

        [Annotation(Name = "[化圣雪原 - 化圣雪原地下墓地入口] 粗大兽骨 1050557300")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceHeftyBeastBone = 1050557300,

        [Annotation(Name = "[化圣雪原 - 化圣雪原地下墓地入口] 黄金卢恩【９】 1050557310")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceGoldenRune9 = 1050557310,

        [Annotation(Name = "[化圣雪原 - 化圣雪原地下墓地入口] 野兽肉块 1050557320")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceLumpOfFlesh = 1050557320,

        [Annotation(Name = "[化圣雪原 - 化圣雪原地下墓地入口] 失色锻造石【８】 1050557800")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceSomberSmithingStone8 = 1050557800,

        [Annotation(Name = "[化圣雪原 - 化圣雪原地下墓地入口] 卢恩弯弧 1050557900")]
        ConsecratedSnowfieldConsecratedSnowfieldCatacombsEntranceRuneArc = 1050557900,

        // DLC Items
        [Annotation(Name = "[幽影城] 左手匕首 21007020")]
        ShadowKeepMaingauche = 21007020,

        [Annotation(Name = "[石棺大洞] 托莉娜暗剑 22007150")]
        StoneCoffinFissureVelvetSwordofStTrina = 22007150,

        [Annotation(Name = "[墓地平原 - “亚人女王”玛丽戈] 连星剑 530845")]
        GravesitePlainDemiHumanQueenMariggaStarLinedSword = 530845,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 卡利亚魔法剑 2047447820")]
        GravesitePlainWestCastleEnsisCarianSorcerySword = 2047447820,

        [Annotation(Name = "[劳弗下方 - 峡谷北方] 石鞘剑 2045477900")]
        RauhBaseRavineNorthStoneSheathedSword = 2045477900,

        [Annotation(Name = "[劳弗下方 - 峡谷北方] 光明剑 2045477500")]
        RauhBaseRavineNorthSwordofLight = 2045477500,

        [Annotation(Name = "[幽影亚坛 - 城底积水处东南] 黑暗剑 2045477700")]
        ScaduAltusCastleWateringHoleSoutheastSwordofDarkness = 2045477700,

        [Annotation(Name = "[墓地平原 - 孤牢骑士] 孤牢大剑, 孤牢套装 530820")]
        GravesitePlainBlackgaolKnightGreatswordofSolitude = 530820,

        [Annotation(Name = "[古铁陨石锻造遗迹] 古铁陨石大剑 42027000")]
        RuinedForgeofStarfallPastAncientMeteoricOreGreatsword = 42027000,

        [Annotation(Name = "[墓地平原 - “卡利亚骑士”穆利缇尔] 穆利缇尔的骑士剑 530865")]
        GravesitePlainMoonrithyllCarianKnightMoonrithyllsKnightSword = 530865,

        [Annotation(Name = "[幽影城] 昆兰的大剑 400692")]
        ShadowKeepQueelignsGreatsword = 400692,

        [Annotation(Name = "[青蓝海岸 - 谷底南边] 灵魂剑 2047397000")]
        CeruleanCoastRavineSouthSpiritSword = 2047397000,

        [Annotation(Name = "[艾尼尔·伊利姆 - 角人] 镰型刀, 角人套装 400614")]
        EnirIlimHornsentFalx = 400614,

        [Annotation(Name = "[“塔之镇”贝瑞特 - 角战士] 角战士曲剑 20007993")]
        BeluratHornedWarriorHornedWarriorsSword = 20007993,

        [Annotation(Name = "[艾尼尔·伊利姆或之前的地点] 弗蕾亚的大剑, 弗蕾亚的套装 400602")]
        EnirIlimFreyjasGreatsword = 400602,

        [Annotation(Name = "[艾尼尔·伊利姆 - 角战士] 角战士大曲剑 20017991")]
        EnirIlimHornedWarriorHornedWarriorsGreatsword = 20017991,

        [Annotation(Name = "[幽影亚坛 - 玛努斯·美特大教堂] 黑夜刀 400671")]
        ScaduAltusCathedralofManusMetyrSwordofNight = 400671,

        [Annotation(Name = "[“塔之镇”贝瑞特] 艾珀莉亚 20007330")]
        BeluratEuporia = 20007330,

        [Annotation(Name = "[幽影亚坛 - 黑骑士] 黑铁双头剑 2048467710")]
        ScaduAltusBlackKnightBlackSteelTwinblade = 2048467710,

        [Annotation(Name = "[利亚指头遗迹 - 指头追寻者的破屋] 花岩槌 400704")]
        FingerRuinsofRhiaClimbtoFingerWeaversHovelFlowerstoneGavel = 400704,

        [Annotation(Name = "[泰乌尔锻造遗迹] 流纹大槌 42037160")]
        TaylewsRuinedForgeSmithscriptGreathammer = 42037160,

        [Annotation(Name = "[熔岩管锻造遗迹] 铁砧大锤 42007000")]
        RuinedForgeLavaIntakeAnvilHammer = 42007000,

        [Annotation(Name = "[墓地平原 - 黑骑士] 黑铁大锤 2048417980")]
        GravesitePlainBlackKnightBlackSteelGreathammer = 2048417980,

        [Annotation(Name = "[墓地平原 - 血怪] 血怪手臂 2045417950")]
        GravesitePlainBloodfiendBloodfiendsArm = 2045417950,

        [Annotation(Name = "[墓地平原 - 雾谷要塞北] 蛇连枷 2047457900")]
        GravesitePlainNorthFogRiftFortSerpentFlail = 2047457900,

        [Annotation(Name = "[泰乌尔锻造遗迹] 流纹斧 42037100")]
        TaylewsRuinedForgeSmithscriptAxe = 42037100,

        [Annotation(Name = "[雾谷地下墓地 - 死骑士] 死骑士对斧, 红琥珀链坠＋３ 520700")]
        FogRiftCatacombsDeathKnightDeathKnightsTwinAxes = 520700,

        [Annotation(Name = "[蝎河地下墓地 - 死骑士] 死骑士长柄斧 520710")]
        ScorpionRiverCatacombsDeathKnightDeathKnightsLonghaftAxe = 520710,

        [Annotation(Name = "[幽影亚坛 - 波尼村] 波尼肢解菜刀 2050447050")]
        ScaduAltusMainBonnyVillageBonnyButcheringKnife = 2050447050,

        [Annotation(Name = "[古铁陨石锻造遗迹] 流纹矛 42027050")]
        RuinedForgeofStarfallPastSmithscriptSpear = 42027050,

        [Annotation(Name = "[墓地平原 - 恩希斯城前方以东] 迅矛 2047437030")]
        GravesitePlainEastofEnsisCastleFrontSwiftSpear = 2047437030,

        [Annotation(Name = "[古遗迹下方 - 血怪] 血怪圣矛 2047477950")]
        AncientRuinsBaseBloodfiendBloodfiendsSacredSpear = 2047477950,

        [Annotation(Name = "[谷底森林 - “拷问老者”约里] 倒刺杖矛 510610")]
        AbyssalWoodsJoriElderInquisitorBarbedStaffSpear = 510610,

        [Annotation(Name = "[墓地平原 - 慰借教堂以南] 灵魂剑刃戟 2048407010")]
        GravesitePlainSouthofChurchofConsolationSpiritGlaive = 2048407010,

        [Annotation(Name = "[幽影亚坛 - 通村吊桥] 畸齿软鞭 2051447000")]
        ScaduAltusBridgeLeadingtotheVillageToothWhip = 2051447000,

        [Annotation(Name = "[艾尼尔·伊利姆] 休里耶的暗针, 休里耶套装 400634")]
        EnirIlimThiolliersHiddenNeedle = 400634,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 帕塔剑 2046407000")]
        GravesitePlainChurchofBenedictionPata = 2046407000,

        [Annotation(Name = "[“塔之镇”贝瑞特] 毒皮手套 20007300")]
        BeluratPoisonedHand = 20007300,

        [Annotation(Name = "[谷底森林 - 癫狂皮手套] 癫狂皮手套 2052427500")]
        AbyssalWoodsMaddingHandMaddingHand = 2052427500,

        [Annotation(Name = "[波尼监牢] 黑夜盾 41017220")]
        BonnyGaolShieldofNight = 41017220,

        [Annotation(Name = "[幽影亚坛 - “黑夜剑士”安娜] 黑夜爪 400672")]
        ScaduAltusSwordhandofNightAnnaClawsofNight = 400672,

        [Annotation(Name = "[劳弗下方 - 熔炉骑士泥盆亚] 泥盆亚的大槌 2045477400")]
        RauhBaseCrucibleKnightDevoniaDevoniasHammer = 2045477400,

        [Annotation(Name = "[米德拉府邸] 娜娜亚烛火 28007100")]
        MidrasManseNanayasTorch = 28007100,

        [Annotation(Name = "[喟叹监牢] 喟叹头颅 41027130")]
        LamentersGaolLamentingVisage = 41027130,

        [Annotation(Name = "[泰乌尔锻造遗迹] 流纹盾 42037120")]
        TaylewsRuinedForgeSmithscriptShield = 42037120,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 狼徽章盾 2047447830")]
        GravesitePlainWestCastleEnsisWolfCrestShield = 2047447830,

        [Annotation(Name = "[墓地平原 - 灵火龙湖南] 蛇徽章盾 580400")]
        GravesitePlainSouthofDragonLakeSerpentCrestShield = 580400,

        [Annotation(Name = "[墓地平原 - “红狮子”弗蕾亚] 黄金狮子盾 400600")]
        GravesitePlainRedmaneFreyjaGoldenLionShield = 400600,

        [Annotation(Name = "[墓地平原 - “黑骑士”迦鲁] 黑铁大盾 530955")]
        GravesitePlainBlackKnightGarrewBlackSteelGreatshield = 530955,

        [Annotation(Name = "[墓地平原 - 正门前方的十字记号] 铜绿大盾, 铜绿套装 400645")]
        GravesitePlainBeluratMainGateCrossVerdigrisGreatshield = 400645,

        [Annotation(Name = "[幽影亚坛 - “指头之母”尤弥尔] 母亲杖, 大祭司套装, 尤弥尔的铃珠 400664")]
        ScaduAltusCountYmirMotherofFingersMaternalStaff = 400664,

        [Annotation(Name = "[幽影亚坛 - 波尼村以北] 落叶圣印记 2050457020")]
        ScaduAltusBonnyVillageNorthTreeandOverlookDryleafSeal = 2050457020,

        [Annotation(Name = "[幽影城] 火焰骑士圣印记 21007650")]
        ShadowKeepFireKnightsSeal = 21007650,

        [Annotation(Name = "[“塔之镇”贝瑞特] 骸骨弓 20007600")]
        BeluratBoneBow = 20007600,

        [Annotation(Name = "[物种保藏库 - “金针骑士”蕾妲] 安帕赫的长弓 400595")]
        SpecimenStorehouseNeedleKnightLedaAnsbachsLongbow = 400595,

        [Annotation(Name = "[物种保藏库 - 老兵安帕赫] 安帕赫的长弓 400623")]
        SpecimenStorehouseSirAnsbachAnsbachsLongbow = 400623,

        [Annotation(Name = "[尖刺山的山脚 - 尖刺山的山脚] 埃贡的大弓 - 战灰：埃贡的猎龙, 埃贡的套装, 埃贡的铃珠 400712")]
        FootoftheJaggedPeakFootoftheJaggedPeakIgonsGreatbowwithAshofWarIgonsDrakeHunt = 400712,

        [Annotation(Name = "[尖刺山的山脚 - 尖刺山的山脚] 埃贡的大弓, 埃贡的套装, 埃贡的铃珠 400714")]
        FootoftheJaggedPeakFootoftheJaggedPeakIgonsGreatbow = 400714,

        [Annotation(Name = "[墓地平原 - 埃贡] 埃贡的大弓, 埃贡的套装, 埃贡的铃珠 400711")]
        GravesitePlainIgonIgonsGreatbow = 400711,

        [Annotation(Name = "[墓地平原 - 毒沼泽东南] 连射弩 2049437000")]
        GravesitePlainSoutheastPoisonSwampRepeatingCrossbow = 2049437000,

        [Annotation(Name = "[墓地平原 - 恩希斯城前方以东] 多击发弩 2047437010")]
        GravesitePlainEastofEnsisCastleFrontSpreadCrossbow = 2047437010,

        [Annotation(Name = "[幽影亚坛 - 通往玛努斯·美特大教堂的路] 拉巴斯大炮 2051467900")]
        ScaduAltusRoadtoManusMetyrRabbathsCannon = 2051467900,

        [Annotation(Name = "[幽影亚坛 - 穆斯废墟] 落叶格斗术 - 战灰：发劲, 丹恩的帽子 400730")]
        ScaduAltusMoorthRuinsDryleafArtswithAshofWarPalmBlast = 400730,

        [Annotation(Name = "[艾尼尔·伊利姆] 丹恩流踢击术 400732")]
        EnirIlimDanesFootwork = 400732,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 火花调香瓶 2047447840")]
        GravesitePlainWestCastleEnsisFiresparkPerfumeBottle = 2047447840,

        [Annotation(Name = "[喟叹监牢] 寒气调香瓶 41027100")]
        LamentersGaolChillingPerfumeBottle = 41027100,

        [Annotation(Name = "[谷底森林 - 废弃教堂] 癫火调香瓶 2053417000")]
        AbyssalWoodsAbandonedChurchFrenzyflamePerfumeBottle = 2053417000,

        [Annotation(Name = "[墓地平原 - 慰借教堂以南] 雷电调香瓶 2048407000")]
        GravesitePlainSouthofChurchofConsolationLightningPerfumeBottle = 2048407000,

        [Annotation(Name = "[物种保藏库] 决斗盾 - 战灰：盾牌攻击 21017150")]
        SpecimenStorehouseDuelingShieldwithAshofWarShieldStrike = 21017150,

        [Annotation(Name = "[物种保藏库] 卡利亚突刺盾 21017620")]
        SpecimenStorehouseCarianThrustingShield = 21017620,

        [Annotation(Name = "[熔岩管锻造遗迹] 流纹短剑 42007150")]
        RuinedForgeLavaIntakeSmithscriptDagger = 42007150,

        [Annotation(Name = "[墓地平原 - 火吻废墟以北] 反手刀 - 战灰：死角一击 2047427700")]
        GravesitePlainNorthofScorchedRuinsBackhandBladewithAshofWarBlindSpot = 2047427700,

        [Annotation(Name = "[古铁陨石锻造遗迹] 流纹圆刃刀 42027060")]
        RuinedForgeofStarfallPastSmithscriptCirque = 42027060,

        [Annotation(Name = "[龙洞 - 古龙人] 猎龙大刀 520810")]
        DragonsPitAncientDragonManDragonHuntersGreatKatana = 520810,

        [Annotation(Name = "[幽影亚坛 - 罗刹] 罗刹大刀, 罗刹套装 530830")]
        ScaduAltusRakshasaRakshasasGreatKatana = 530830,

        [Annotation(Name = "[墓地平原 - 灵火龙湖] 大刀 - 战灰：大上段 2045447010")]
        GravesitePlainDragonLakeGreatKatanawithAshofWarOverheadStance = 2045447010,

        [Annotation(Name = "[龙洞 - 古龙人] 猎龙大刀 520810")]
        DragonsPitAncientDragonManDragonHuntersGreatKatana_ = 520810,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 仕女剑 2047447800")]
        GravesitePlainWestCastleEnsisMilady = 2047447800,

        [Annotation(Name = "[艾尼尔·伊利姆 - “金针骑士”蕾妲] 蕾妲的剑 510420")]
        EnirIlimNeedleKnightLedaLedasSword = 510420,

        [Annotation(Name = "[墓地平原 - “兽爪”罗格] 野兽爪 - 战灰：野兽爪击 2047407980")]
        GravesitePlainLogurtheBeastClawBeastClawWeapon68500000withAshofWarSavageClaws = 2047407980,

        [Annotation(Name = "[劳弗下方 - 红熊] 红熊爪, 铁铆钉套装 530900")]
        RauhBaseRedBearRedBearsClaw = 530900,

        [Annotation(Name = "[幽影亚坛 - 波尼村] 落叶套装 2050447720")]
        ScaduAltusMainBonnyVillageDryleafSet = 2050447720,

        [Annotation(Name = "[望影露台 - 白金射手] 盖乌斯腿甲 2049490900")]
        ScaduviewAlbinauricArcherGaiussGreaves = 2049490900,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 誓约骑士头盔 2046407001")]
        GravesitePlainChurchofBenedictionOathseekerKnightHelm = 2046407001,

        [Annotation(Name = "[艾尼尔·伊利姆] 蕾妲铠甲 400598")]
        EnirIlimLedasArmor = 400598,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 誓约骑士臂甲 2046407003")]
        GravesitePlainChurchofBenedictionOathseekerKnightGauntlets = 2046407003,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 誓约骑士腿甲 2046407004")]
        GravesitePlainChurchofBenedictionOathseekerKnightGreaves = 2046407004,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 誓约骑士铠甲 2046407002")]
        GravesitePlainChurchofBenedictionOathseekerKnightArmor = 2046407002,

        [Annotation(Name = "[幽影亚坛 - 大红熊拉鲁瓦] 拉鲁瓦毛皮 530930")]
        ScaduAltusRalvatheGreatRedBearPeltofRalva = 530930,

        [Annotation(Name = "[青蓝海岸 - 拉纳舞娘] 舞娘套装, 拉纳舞蹈剑 530810")]
        CeruleanCoastDancerofRanahDancersSet = 530810,

        [Annotation(Name = "[波尼监牢] 黑夜套装 41017300")]
        BonnyGaolNightSet = 41017300,

        [Annotation(Name = "[物种保藏库 - 老兵安帕赫] 安帕赫套装 400622")]
        SpecimenStorehouseSirAnsbachAnsbachsSet = 400622,

        [Annotation(Name = "[艾尼尔·伊利姆] 安帕赫套装, 安帕赫的狂刃, 黑曜薄刀 400624")]
        EnirIlimAnsbachsSet = 400624,

        [Annotation(Name = "[物种保藏库] 安帕赫套装, 安帕赫的长弓, 给弗蕾亚的信 400625")]
        SpecimenStorehouseAnsbachsSet = 400625,

        [Annotation(Name = "[幽影城 - 火焰骑士] 死亡面具头盔 21007995")]
        ShadowKeepFireKnightDeathMaskHelm = 21007995,

        [Annotation(Name = "[物种保藏库 - 火焰骑士] 带翼蛇头盔, 战灰：火焰枪 21017991")]
        SpecimenStorehouseFireKnightWingedSerpentHelm = 21017991,

        [Annotation(Name = "[幽影城 - 火焰骑士] 萨赞风帽, 火焰雨 21027991")]
        ShadowKeepFireKnightSalzasHood = 21027991,

        [Annotation(Name = "[劳弗下方 - 大红熊区域西北] 高地战士套装 2044477010")]
        RauhBaseNorthwestGreatRedBearAreaHighlandWarriorSet = 2044477010,

        [Annotation(Name = "[幽影亚坛 - 穆斯大道营地] 高地战士套装 2049457200")]
        ScaduAltusMoorthHighwayCampHighlandWarriorSet = 2049457200,

        [Annotation(Name = "[驱暗地下墓地] 死骑士套装 40027130")]
        DarklightCatacombsDeathKnightSet = 40027130,

        [Annotation(Name = "[艾尼尔·伊利姆] 守墓鸟头盔 20017500")]
        EnirIlimGravebirdHelm = 20017500,

        [Annotation(Name = "[劳弗下方 - 腐败区域] 守墓鸟黑羽铠甲 2045467070")]
        RauhBaseRotAreaGravebirdsBlackquillArmor = 2045467070,

        [Annotation(Name = "[墓地平原 - 通柱坡中段] 守墓鸟手环 2048427020")]
        GravesitePlainPillarPathWaypointGravebirdBracelets = 2048427020,

        [Annotation(Name = "[幽影亚坛 - 毒沼泽] 守墓鸟脚环 2049467010")]
        ScaduAltusPoisonSwampGravebirdAnklets = 2049467010,

        [Annotation(Name = "[墓地平原 - 灵火龙湖] 守墓鸟铠甲 2045447020")]
        GravesitePlainDragonLakeGravebirdArmor = 2045447020,

        [Annotation(Name = "[艾尼尔·伊利姆] 光芒头冠 20017981")]
        EnirIlimCircletofLight = 20017981,

        [Annotation(Name = "[“塔之镇”贝瑞特] 神兽头部 20007810")]
        BeluratDivineBeastHead = 20007810,

        [Annotation(Name = "[石棺大洞] 托莉娜孤花 400740")]
        StoneCoffinFissureStTrinasBlossom = 400740,

        [Annotation(Name = "[贝瑞特监牢] 大壶头罩 41007250")]
        BeluratGaolGreatjar = 41007250,

        [Annotation(Name = "[蝎河地下墓地] 小恶魔头罩（狮子） 40017070")]
        ScorpionRiverCatacombsImpHeadLion = 40017070,

        [Annotation(Name = "[蝎河地下墓地 - 死骑士] 蓝琥珀链坠＋３ 520711")]
        ScorpionRiverCatacombsDeathKnightCeruleanAmberMedallion3 = 520711,

        [Annotation(Name = "[驱暗地下墓地] 绿琥珀链坠＋３ 40027020")]
        DarklightCatacombsViridianAmberMedallion3 = 40027020,

        [Annotation(Name = "[劳弗下方 - 神殿镇废墟] 双首龟护符 2046457000")]
        RauhBaseTempleTownRuinsTwoHeadedTurtleTalisman = 2046457000,

        [Annotation(Name = "[波尼监牢] 健壮角饰品＋２ 41017020")]
        BonnyGaolStalwartHornCharm2 = 41017020,

        [Annotation(Name = "[“塔之镇”贝瑞特 - 腐烂树灵] 免疫角饰品＋２ 20007991")]
        BeluratUlceratedTreeSpiritImmunizingHornCharm2 = 20007991,

        [Annotation(Name = "[喟叹监牢] 理智角饰品＋２ 41027210")]
        LamentersGaolClarifyingHornCharm2 = 41027210,

        [Annotation(Name = "[劳弗下方 - 腐败区域] 斑斓项链＋２ 2045467900")]
        RauhBaseRotAreaMottledNecklace2 = 2045467900,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 魔力龙徽护符＋３ 2047447190")]
        GravesitePlainWestCastleEnsisSpelldrakeTalisman3 = 2047447190,

        [Annotation(Name = "[墓地平原 - 毒沼泽东南] 火龙徽护符＋３ 2049437270")]
        GravesitePlainSoutheastPoisonSwampFlamedrakeTalisman3 = 2049437270,

        [Annotation(Name = "[物种保藏库] 雷龙徽护符＋３ 21017100")]
        SpecimenStorehouseBoltdrakeTalisman3 = 21017100,

        [Annotation(Name = "[幽影亚坛 - 教区大道] 金黄色编发 2051477510")]
        ScaduAltusChurchDistrictHighroadGoldenBraid = 2051477510,

        [Annotation(Name = "[物种保藏库] 珍珠龙徽护符＋３ 21017120")]
        SpecimenStorehousePearldrakeTalisman3 = 21017120,

        [Annotation(Name = "[利亚指头遗迹 - 西北] 红种子护符＋１ 2050407000")]
        FingerRuinsofRhiaNorthwestCrimsonSeedTalisman1 = 2050407000,

        [Annotation(Name = "[狄欧指头遗迹 - 西] 蓝种子护符＋１ 2053467600")]
        FingerRuinsofDheoWestCeruleanSeedTalisman1 = 2053467600,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 恩惠蓝露滴护符 2046407700")]
        GravesitePlainChurchofBenedictionBlessedBlueDewTalisman = 2046407700,

        [Annotation(Name = "[劳弗下方 - 大红熊区域东北] 熔炉薄翼护符 2045487000")]
        RauhBaseNortheastGreatRedBearAreaFineCrucibleFeatherTalisman = 2045487000,

        [Annotation(Name = "[墓地平原 - 崖上道路的终点] 外在神祇的传说 2045417800")]
        GravesitePlainCliffroadTerminusOuterGodHeirloom = 2045417800,

        [Annotation(Name = "[幽影亚坛 - 穆斯废墟] 裂石护符 2049447090")]
        ScaduAltusMoorthRuinsShatteredStoneTalisman = 2049447090,

        [Annotation(Name = "[劳弗下方 - 神殿镇废墟] 双手剑护符 2046457910")]
        RauhBaseTempleTownRuinsTwoHandedSwordTalisman = 2046457910,

        [Annotation(Name = "[“塔之镇”贝瑞特 - “火焰骑士”昆兰] 圣战徽章 400694")]
        BeluratFireKnightQueelignCrusadeInsignia = 400694,

        [Annotation(Name = "[利亚指头遗迹 - 冬灯] 老翁的欢愉 2051417700")]
        FingerRuinsofRhiaWinterLanternAgedOnesExultation = 2051417700,

        [Annotation(Name = "[墓地平原 - 雾谷要塞北] 远硬箭护符 2047457910")]
        GravesitePlainNorthFogRiftFortArrowsSoaringStingTalisman = 2047457910,

        [Annotation(Name = "[劳弗下方 - 血怪洞窟] 珍珠盾护符 2047477900")]
        RauhBaseBloodfiendCavePearlShieldTalisman = 2047477900,

        [Annotation(Name = "[“塔之镇”贝瑞特] 干枯花束 20007630")]
        BeluratDriedBouquet = 20007630,

        [Annotation(Name = "[古铁陨石锻造遗迹] 锻造术护符 42027030")]
        RuinedForgeofStarfallPastSmithingTalisman = 42027030,

        [Annotation(Name = "[墓地平原 - 大桥北] 疾病护符 2046447030")]
        GravesitePlainGreatbridgeNorthAilmentTalisman = 2046447030,

        [Annotation(Name = "[幽影亚坛 - “金针骑士”蕾妲] 回击交错树 400592")]
        ScaduAltusNeedleKnightLedaRetaliatoryCrossedTree = 400592,

        [Annotation(Name = "[幽影亚坛 - “金针骑士”蕾妲] 贯刺交错树 400590")]
        ScaduAltusNeedleKnightLedaLaceratingCrossedTree = 400590,

        [Annotation(Name = "[望影露台 - 幽影树圣杯] 狙击弓护符 2049497510")]
        ScaduviewScadutreeChaliceSharpshotTalisman = 2049497510,

        [Annotation(Name = "[石棺大洞 - 休里耶] 托莉娜的微笑 400632")]
        StoneCoffinFissureThiollierStTrinasSmile = 400632,

        [Annotation(Name = "[墓地平原 - 老者的破屋] 狂龙护符 2049427000")]
        GravesitePlainEldersHovelTalismanoftheDread = 2049427000,

        [Annotation(Name = "[幽影亚坛 - “大祭司”尤弥尔] 亲爱的星尘, 遗迹地图 (第二张) 400661")]
        ScaduAltusCountYmirHighPriestBelovedStardust = 400661,

        [Annotation(Name = "[幽影城] 王受赐护符 21007070")]
        ShadowKeepTalismanofLordsBestowal = 21007070,

        [Annotation(Name = "[劳弗下方 - 火精灵石洞窟] 铜绿圆碟 2046477720")]
        RauhBaseFireSpritestoneCaveVerdigrisDiscus = 2046477720,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 蕾菈娜的浮雕坠饰 2047447700")]
        GravesitePlainWestCastleEnsisRellanasCameo = 2047447700,

        [Annotation(Name = "[墓地平原 - 火吻废墟] 介错刀 2047417800")]
        GravesitePlainScorchedRuinsBladeofMercy = 2047417800,

        [Annotation(Name = "[劳弗古遗迹 - 花蕾教堂以南] 熔炉全护符 2044457900")]
        AncientRuinsofRauhSouthChurchoftheBudTalismanofAllCrucibles = 2044457900,

        [Annotation(Name = "[劳弗下方 - 火精灵石洞窟] 战灰：落叶旋风脚 2046477150")]
        RauhBaseFireSpritestoneCaveAshofWarDryleafWhirlwind = 2046477150,

        [Annotation(Name = "[墓地平原 - “黑骑士”艾瑞德] 战灰：熔炉百相之羽 530965")]
        GravesitePlainBlackKnightEdreddAshofWarAspectsoftheCrucibleWings = 530965,

        [Annotation(Name = "[墓地平原 - 粪金龟] 战灰：贯穿投掷 540902")]
        GravesitePlainScarabAshofWarPiercingThrow = 540902,

        [Annotation(Name = "[幽影亚坛 - 粪金龟] 战灰：多重投掷 540910")]
        ScaduAltusScarabAshofWarScattershotThrow = 540910,

        [Annotation(Name = "[幽影城 - 西边城墙] 战灰：四面火花香 21027020")]
        ShadowKeepWestRampartAshofWarWallofSparks = 21027020,

        [Annotation(Name = "[幽影亚坛 - 粪金龟] 战灰：串联火花香 540904")]
        ScaduAltusScarabAshofWarRollingSparks = 540904,

        [Annotation(Name = "[幽影亚坛 - 粪金龟] 战灰：野兽突袭 540906")]
        ScaduAltusScarabAshofWarRagingBeast = 540906,

        [Annotation(Name = "[幽影城 - “金针骑士”蕾妲] 战灰：迅斩 400594")]
        ShadowKeepNeedleKnightLedaAshofWarSwiftSlash = 400594,

        [Annotation(Name = "[墓地平原 - 恩希斯城东] 战灰：单翼架式 2048447810")]
        GravesitePlainEastCastleEnsisAshofWarWingStance = 2048447810,

        [Annotation(Name = "[雾谷地下墓地] 战灰：瞬雷 40007900")]
        FogRiftCatacombsAshofWarBlinkbolt = 40007900,

        [Annotation(Name = "[“塔之镇”贝瑞特 - “火焰骑士”昆兰] 战灰：火焰穿刺, 祈祷厅钥匙 400696")]
        BeluratFireKnightQueelignAshofWarFlameSkewer = 400696,

        [Annotation(Name = "[墓地平原 - 灵火龙湖南] 战灰：勇猛狮子斩 2045437700")]
        GravesitePlainSouthofDragonLakeAshofWarSavageLionsClaw = 2045437700,

        [Annotation(Name = "[幽影亚坛 - 粪金龟] 战灰：尊矣卡利亚 540900")]
        ScaduAltusScarabAshofWarCarianSovereignty = 540900,

        [Annotation(Name = "[“塔之镇”贝瑞特] 战灰：悲恸惨叫 20007410")]
        BeluratAshofWarShriekofSorrow = 20007410,

        [Annotation(Name = "[青蓝海岸 - 死亡仪式鸟] 战灰：唤起灵火 530855")]
        CeruleanCoastDeathRiteBirdAshofWarGhostflameCall = 530855,

        [Annotation(Name = "[劳弗下方 - 粪金龟] 战灰：双刺毒花 540916")]
        RauhBaseScarabAshofWarThePoisonFlowerBloomsTwice = 540916,

        [Annotation(Name = "[尖刺山 - 尖刺山腰与山顶之间] 岩石心脏 580420")]
        JaggedPeakBetweenJaggedPeakMountainsideandSummitRockHeart = 580420,

        [Annotation(Name = "[喟叹监牢 - 喟叹者] 喟叹者面具 520770")]
        LamentersGaolLamenterLamentersMask = 520770,

        [Annotation(Name = "[幽影城] 赐福覆眼膜 21007800")]
        ShadowKeepIrisofGrace = 21007800,

        [Annotation(Name = "[幽影城 - 西边城墙] 赐福覆眼膜 21027040")]
        ShadowKeepWestRampartIrisofGrace = 21027040,

        [Annotation(Name = "[幽影城 - 腐烂树灵] 黑暗覆眼膜 21007993")]
        ShadowKeepUlceratedTreeSpiritIrisofOccultation = 21007993,

        [Annotation(Name = "[墓地平原 - 恶兆猎人] 黑暗覆眼膜 2049437940")]
        GravesitePlainOmenkillerIrisofOccultation = 2049437940,

        [Annotation(Name = "[墓地平原 - 休里耶] 休里耶的秘药 400630")]
        GravesitePlainThiollierThiolliersConcoction = 400630,

        [Annotation(Name = "[喟叹监牢] 唤声泥颅“喟叹” 41027010")]
        LamentersGaolPrattlingPateLamentation = 41027010,

        [Annotation(Name = "[望影露台 - 老将盖乌斯] 山猪骑士的追忆 510640")]
        ScaduviewCommanderGaiusRemembranceoftheWildBoarRider = 510640,

        [Annotation(Name = "[望影露台 - 幽影树的化身] 影轮草的追忆, 米凯拉的大符文 510620")]
        ScaduviewScadutreeAvatarRemembranceoftheShadowSunflower = 510620,

        [Annotation(Name = "[墓地平原 - “双月骑士”蕾菈娜] 双月骑士的追忆 510900")]
        GravesitePlainRellanaTwinMoonKnightRemembranceoftheTwinMoonKnight = 510900,

        [Annotation(Name = "[劳弗古遗迹 - “花蕾圣女”萝蜜娜] 花蕾圣女的追忆 510600")]
        AncientRuinsofRauhRominaSaintoftheBudRemembranceoftheSaintoftheBud = 510600,

        [Annotation(Name = "[“塔之镇”贝瑞特 - 神兽舞狮] 舞狮的追忆 510400")]
        BeluratDivineBeastDancingLionRemembranceoftheDancingLion = 510400,

        [Annotation(Name = "[艾尼尔·伊利姆 - “米凯拉的王”拉塔恩] 神祇与王的追忆 510430")]
        EnirIlimRadahnConsortofMiquellaRemembranceofaGodandaLord = 510430,

        [Annotation(Name = "[米德拉府邸 - “癫火之王”米德拉] 癫火之王的追忆 510560")]
        MidrasManseMidraLordofFrenziedFlameRemembranceoftheLordofFrenziedFlame = 510560,

        [Annotation(Name = "[指头产房 - “指头之母”梅蒂尔] 指头之母的追忆 510550")]
        FingerBirthingGroundsMetyrMotherofFingersRemembranceoftheMotherofFingers = 510550,

        [Annotation(Name = "[石棺大洞 - 融泥骑士] 融泥的追忆 510480")]
        StoneCoffinFissurePutrescentKnightRemembranceofPutrescence = 510480,

        [Annotation(Name = "[劳弗古遗迹 - 废墟东部坑道北部] 情谊石 2046487010")]
        AncientRuinsofRauhEastRuinsNorthPitandTunnelsBondstone = 2046487010,

        [Annotation(Name = "[劳弗下方 - 火精灵石洞窟] 火精灵石 2046477060")]
        RauhBaseFireSpritestoneCaveFireSpritestone = 2046477060,

        [Annotation(Name = "[墓地平原 - 腐烂树灵] 带角幼子像 2047437980")]
        GravesitePlainUlceratedTreeSpiritHornedBairn = 2047437980,

        [Annotation(Name = "[青蓝海岸 - 南方无名灵庙] 拉纳香油瓶 2046387070")]
        CeruleanCoastSouthernNamelessMausoleumPerfumedOilofRanah = 2046387070,

        [Annotation(Name = "[喟叹监牢] 提比亚的唤声 41027110")]
        LamentersGaolCallofTibia = 41027110,

        [Annotation(Name = "[青蓝海岸 - 青蓝海岸] 提比亚的唤声 2048397030")]
        CeruleanCoastCeruleanCoastCallofTibia = 2048397030,

        [Annotation(Name = "[米德拉府邸] 迸发癫火 3x 28007050")]
        MidrasManseSurgingFrenziedFlame3x = 28007050,

        [Annotation(Name = "[幽影城] 黄金树立誓 (黄金树立誓) 21007040")]
        ShadowKeepGoldenVowGoods2003170 = 21007040,

        [Annotation(Name = "[幽影城] 黄金树立誓 (黄金树立誓) 3x 21007090")]
        ShadowKeepGoldenVowGoods20031703x = 21007090,

        [Annotation(Name = "[幽影亚坛 - 熔炉巨人区域] 黄金树立誓 (黄金树立誓) 2x 2048467010")]
        ScaduAltusFurnaceGolemAreaGoldenVowGoods20031702x = 2048467010,

        [Annotation(Name = "[物种保藏库] 蜷曲火焰 21017040")]
        SpecimenStorehouseFireCoil = 21017040,

        [Annotation(Name = "[物种保藏库] 蜷曲火焰 2x 21017410")]
        SpecimenStorehouseFireCoil2x = 21017410,

        [Annotation(Name = "[物种保藏库] 蜷曲火焰 3x 21017630")]
        SpecimenStorehouseFireCoil3x = 21017630,

        [Annotation(Name = "[墓地平原 - 慰借教堂] 蜷曲火焰 2x 2048417000")]
        GravesitePlainChurchofConsolationFireCoil2x = 2048417000,

        [Annotation(Name = "[幽影亚坛 - 玛努斯·美特大教堂] 光辉指爪 2x 2051457000")]
        ScaduAltusCathedralofManusMetyrGlintingNail2x = 2051457000,

        [Annotation(Name = "[艾尼尔·伊利姆] 暖阳石 2x 20017480")]
        EnirIlimSunwarmthStone2x = 20017480,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 魔法三辉剑 2047447090")]
        GravesitePlainWestCastleEnsisGlintbladeTrio = 2047447090,

        [Annotation(Name = "[望影露台 - 坠星兽物] 引力球 530960")]
        ScaduviewFallingstarBeastGravitationalMissile = 530960,

        [Annotation(Name = "[幽影城 - 腐烂树灵] 棘刺上身 21007991")]
        ShadowKeepUlceratedTreeSpiritMantleofThorns = 21007991,

        [Annotation(Name = "[物种保藏库] 拒绝的刺 21017510")]
        SpecimenStorehouseImpenetrableThorns = 21017510,

        [Annotation(Name = "[青蓝海岸 - 青蓝海岸] 灵魂光环 2048397050")]
        CeruleanCoastCeruleanCoastRingsofSpectralLight = 2048397050,

        [Annotation(Name = "[石棺大洞] 融泥块 22007210")]
        StoneCoffinFissureMassofPutrescence = 22007210,

        [Annotation(Name = "[幽影亚坛 - 穆斯大道营地] 远方之恢复 2049457500")]
        ScaduAltusMoorthHighwayCampHealfromAfar = 2049457500,

        [Annotation(Name = "[幽影城 - 黄金河马] 熔炉百相之针, 幽影树碎片 2x 510440")]
        ShadowKeepGoldenHippopotamusAspectsoftheCrucibleThorns = 510440,

        [Annotation(Name = "[劳弗下方 - 峡谷北方] 熔炉百相之花 2045477040")]
        RauhBaseRavineNorthAspectsoftheCrucibleBloom = 2045477040,

        [Annotation(Name = "[幽影亚坛 - 教区大道] 小黄金树 2051477500")]
        ScaduAltusChurchDistrictHighroadMinorErdtree = 2051477500,

        [Annotation(Name = "[物种保藏库] 远方之怒 21017780")]
        SpecimenStorehouseWrathfromAfar = 21017780,

        [Annotation(Name = "[石棺大洞 - 狮子混种] 相迭光环 22007900")]
        StoneCoffinFissureLeonineMisbegottenMultilayeredRingofLight = 22007900,

        [Annotation(Name = "[劳弗下方 - 大红熊鲁格利亚] 鲁格利亚的咆哮 530905")]
        RauhBaseRugaleatheGreatRedBearRoarofRugalea = 530905,

        [Annotation(Name = "[蝎河地下墓地] 骑士雷电枪 40017080")]
        ScorpionRiverCatacombsKnightsLightningSpear = 40017080,

        [Annotation(Name = "[利亚指头遗迹 - 龙飨女巫] 芙柔桑克斯的龙雷 400702")]
        FingerRuinsofRhiaDragonCommunionPriestessDragonboltofFlorissax = 400702,

        [Annotation(Name = "[雾谷地下墓地] 带电 40007090")]
        FogRiftCatacombsElectrocharge = 40007090,

        [Annotation(Name = "[劳弗下方 - 蝎河地下墓地入口] 虫丝枪 2044467040")]
        RauhBaseScorpionRiverCatacombsEntrancePestThreadSpears = 2044467040,

        [Annotation(Name = "[幽影亚坛 - 波尼村以北] 守护指头 400666")]
        ScaduAltusBonnyVillageNorthTreeandOverlookCherishingFingers = 400666,

        [Annotation(Name = "[“塔之镇”贝瑞特 - 角人老妪] 守护灵 400721")]
        BeluratHornsentGrandamWatchfulSpirit = 400721,

        [Annotation(Name = "[幽影亚坛 - 穆斯废墟] 黄金弯弧 2049447900")]
        ScaduAltusMoorthRuinsGoldenArcs = 2049447900,

        [Annotation(Name = "[幽影亚坛 - 城底积水处东南] 黄金大弯弧 2050467910")]
        ScaduAltusCastleWateringHoleSoutheastGiantGoldenArc = 2050467910,

        [Annotation(Name = "[劳弗下方 - 神殿镇废墟] 螺旋树圣印记 580410")]
        RauhBaseTempleTownRuinsSpiraltreeSeal_ = 580410,

        [Annotation(Name = "[艾尼尔·伊利姆] 旋流 20017230")]
        EnirIlimSpira = 20017230,

        [Annotation(Name = "[劳弗下方 - 神兽舞狮] 神兽龙卷风 530940")]
        RauhBaseDivineBeastDancingLionDivineBeastTornado = 530940,

        [Annotation(Name = "[劳弗下方 - 蝎河地下墓地入口] 神鸟羽毛 2044467110")]
        RauhBaseScorpionRiverCatacombsEntranceDivineBirdFeathers = 2044467110,

        [Annotation(Name = "[物种保藏库] 火焰蛇 21017650")]
        SpecimenStorehouseFireSerpent = 21017650,

        [Annotation(Name = "[墓地平原 - 埃贡] 埃贡的勾指 400710")]
        GravesitePlainIgonIgonsFurledFinger = 400710,

        [Annotation(Name = "[“塔之镇”贝瑞特] 井底钥匙 20007510")]
        BeluratWellDepthsKey = 20007510,

        [Annotation(Name = "[喟叹监牢] 监牢上层钥匙 41027000")]
        LamentersGaolGaolUpperLevelKey = 41027000,

        [Annotation(Name = "[喟叹监牢] 监牢下层钥匙 41027320")]
        LamentersGaolGaolLowerLevelKey = 41027320,

        [Annotation(Name = "[墓地平原 - 角人] 十字记号地图 400610")]
        GravesitePlainHornsentCrossMap = 400610,

        [Annotation(Name = "[墓地平原 - 角人] 新的十字记号地图 400611")]
        GravesitePlainHornsentNewCrossMap = 400611,

        [Annotation(Name = "[幽影亚坛 - “大祭司”尤弥尔] 孔洞项链, 遗迹地图 400660")]
        ScaduAltusCountYmirHighPriestHoleLadenNecklace = 400660,

        [Annotation(Name = "[尖刺山 - “狂龙”贝勒] 贝勒的心脏 510630")]
        JaggedPeakBayletheDreadHeartofBayle = 510630,

        [Annotation(Name = "[“塔之镇”贝瑞特] 仓库钥匙 20007480")]
        BeluratStoreroomKey = 20007480,

        [Annotation(Name = "[物种保藏库] 秘密仪式卷轴 21017340")]
        SpecimenStorehouseSecretRiteScroll = 21017340,

        [Annotation(Name = "[物种保藏库 - 老兵安帕赫] 给弗蕾亚的信 400620")]
        SpecimenStorehouseSirAnsbachLetterforFreyja = 400620,

        [Annotation(Name = "[幽影亚坛 - “大祭司”尤弥尔] 遗迹地图（第三张） 400662")]
        ScaduAltusCountYmirHighPriestRuinsMap3rd = 400662,

        [Annotation(Name = "[墓地平原 - 穆尔] 黑色浓浆 400642")]
        GravesitePlainMooreBlackSyrup = 400642,

        [Annotation(Name = "[物种保藏库 - “恶之蛇”梅瑟莫] 梅瑟莫的火种, 穿刺者的追忆 510460")]
        SpecimenStorehouseBaseSerpentMessmerMessmersKindling = 510460,

        [Annotation(Name = "[幽影亚坛 - 城底积水处西北入口] 燃炉工匠的笔记 2049477000")]
        ScaduAltusCastleWateringHoleNorthwestEntranceFurnaceKeepersNote = 2049477000,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 恩希斯城十字记号旁的信 2047447710")]
        GravesitePlainWestCastleEnsisCastleCrossMessage = 2047447710,

        [Annotation(Name = "[劳弗下方 - 火精灵石洞窟] 古遗迹十字记号旁的信 2047477000")]
        RauhBaseFireSpritestoneCaveAncientRuinsCrossMessage = 2047477000,

        [Annotation(Name = "[幽影亚坛 - 大道旁的十字记号] 修士的信 2048457510")]
        ScaduAltusHighroadCrossMonksMissive = 2048457510,

        [Annotation(Name = "[物种保藏库] 保藏库十字记号旁的信 21017180")]
        SpecimenStorehouseStorehouseCrossMessage = 21017180,

        [Annotation(Name = "[米德拉府邸] 被丢弃的日记 28007010")]
        MidrasManseTornDiaryPage = 28007010,

        [Annotation(Name = "[幽影亚坛 - 穆斯废墟] 蕾妲留下的信 580600")]
        ScaduAltusMoorthRuinsMessagefromLeda = 580600,

        [Annotation(Name = "[“塔之镇”贝瑞特] 幽影塔旁的信 20007830")]
        BeluratTowerofShadowMessage = 20007830,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 绘画《侵略》 580100")]
        GravesitePlainChurchofBenedictionIncursionPainting = 580100,

        [Annotation(Name = "[墓地平原 - 火吻废墟以北] 绘画《神之塔》 580110")]
        GravesitePlainNorthofScorchedRuinsTheSacredTowerPainting = 580110,

        [Annotation(Name = "[幽影城] 绘画《龙之境界》 580120")]
        ShadowKeepDomainofDragonsPainting = 580120,

        [Annotation(Name = "[墓地平原 - 火吻废墟] 地图碎片：墓地平原 62080")]
        GravesitePlainScorchedRuinsMapGravesitePlain = 62080,

        [Annotation(Name = "[幽影亚坛 - 大道旁的十字记号] 地图碎片：幽影亚坛 62081")]
        ScaduAltusHighroadCrossMapScaduAltus = 62081,

        [Annotation(Name = "[青蓝海岸 - 青蓝海岸的十字记号] 地图碎片：南方海岸 62082")]
        CeruleanCoastCeruleanCoastCrossMapSouthernShore = 62082,

        [Annotation(Name = "[劳弗下方 - 神殿镇废墟] 地图碎片：劳弗古遗迹 62083")]
        RauhBaseTempleTownRuinsMapRauhRuins = 62083,

        [Annotation(Name = "[谷底森林 - 教堂西边的大树] 地图碎片：谷底 62084")]
        AbyssalWoodsBigTreeWestofChurchMapAbyss = 62084,

        [Annotation(Name = "[墓地平原 - 正门前方的十字记号] 穆尔的铃珠 400644")]
        GravesitePlainBeluratMainGateCrossMooresBellBearing = 400644,

        [Annotation(Name = "[墓地平原 - 火吻废墟] 药草贩子的铃珠 2047407710")]
        GravesitePlainScorchedRuinsHerbalistsBellBearing = 2047407710,

        [Annotation(Name = "[墓地平原 - 大桥北] 蘑菇贩子的铃珠【１】 2046447710")]
        GravesitePlainGreatbridgeNorthMushroomSellersBellBearing1 = 2046447710,

        [Annotation(Name = "[墓地平原 - 火吻废墟] 蘑菇贩子的铃珠【２】 2047417110")]
        GravesitePlainScorchedRuinsMushroomSellersBellBearing2 = 2047417110,

        [Annotation(Name = "[幽影亚坛 - 通往玛努斯·美特大教堂的路] 树脂贩子的铃珠 2051467500")]
        ScaduAltusRoadtoManusMetyrGreasemongersBellBearing = 2051467500,

        [Annotation(Name = "[幽影亚坛 - 波尼村] 霉菌贩子的铃珠 2050447730")]
        ScaduAltusMainBonnyVillageMoldmongersBellBearing = 2050447730,

        [Annotation(Name = "[幽影亚坛 - 通往玛努斯·美特大教堂的路] 魔法技师的铃珠 2051467020")]
        ScaduAltusRoadtoManusMetyrSpellmachinistsBellBearing = 2051467020,

        [Annotation(Name = "[墓地平原 - 崖上道路的终点] 绳索贩子的铃珠 2045417710")]
        GravesitePlainCliffroadTerminusStringSellersBellBearing = 2045417710,

        [Annotation(Name = "[幽影亚坛 - 波尼村北] 母亲啊 2050457510")]
        ScaduAltusBonnyVillageNorthOMother = 2050457510,

        [Annotation(Name = "[幽影亚坛 - 腐败眷属] 集物虫的制作笔记【６】 68510")]
        ScaduAltusKindredofRotForagerBroodCookbook6 = 68510,

        [Annotation(Name = "[墓地平原 - 腐败眷属] 集物虫的制作笔记【１】 68520")]
        GravesitePlainKindredofRotForagerBroodCookbook1 = 68520,

        [Annotation(Name = "[墓地平原 - 腐败眷属] 集物虫的制作笔记【２】 68530")]
        GravesitePlainKindredofRotForagerBroodCookbook2 = 68530,

        [Annotation(Name = "[墓地平原 - 腐败眷属] 集物虫的制作笔记【３】 68540")]
        GravesitePlainKindredofRotForagerBroodCookbook3 = 68540,

        [Annotation(Name = "[幽影亚坛 - 腐败眷属] 集物虫的制作笔记【４】 68550")]
        ScaduAltusKindredofRotForagerBroodCookbook4 = 68550,

        [Annotation(Name = "[幽影亚坛 - 腐败眷属] 集物虫的制作笔记【５】 68560")]
        ScaduAltusKindredofRotForagerBroodCookbook5 = 68560,

        [Annotation(Name = "[尖刺山 - 尖刺山（中段）] 埃贡的制作笔记【２】 68570")]
        JaggedPeakJaggedPeakMountainsideIgonsCookbook2 = 68570,

        [Annotation(Name = "[幽影亚坛 - 通往玛努斯·美特大教堂的路] 指头追寻者的制作笔记【２】 68580")]
        ScaduAltusRoadtoManusMetyrFingerWeaversCookbook2 = 68580,

        [Annotation(Name = "[墓地平原 - 火吻废墟] 大维壶师的制作笔记【１】 68590")]
        GravesitePlainScorchedRuinsGreaterPotentatesCookbook1 = 68590,

        [Annotation(Name = "[幽影亚坛 - 玛努斯·美特大教堂] 大维壶师的制作笔记【４】 68600")]
        ScaduAltusCathedralofManusMetyrGreaterPotentatesCookbook4 = 68600,

        [Annotation(Name = "[墓地平原 - 恩惠教堂] 大维壶师的制作笔记【５】 68610")]
        GravesitePlainChurchofBenedictionGreaterPotentatesCookbook5 = 68610,

        [Annotation(Name = "[墓地平原 - 火吻废墟以北] 大维壶师的制作笔记【１２】 68620")]
        GravesitePlainNorthofScorchedRuinsGreaterPotentatesCookbook12 = 68620,

        [Annotation(Name = "[墓地平原 - 毒沼泽东南] 大维壶师的制作笔记【７】 68630")]
        GravesitePlainSoutheastPoisonSwampGreaterPotentatesCookbook7 = 68630,

        [Annotation(Name = "[劳弗下方 - 蝎河地下墓地入口] 大维壶师的制作笔记【９】 68640")]
        RauhBaseScorpionRiverCatacombsEntranceGreaterPotentatesCookbook9 = 68640,

        [Annotation(Name = "[墓地平原 - 大桥北] 大维壶师的制作笔记【１０】 68650")]
        GravesitePlainGreatbridgeNorthGreaterPotentatesCookbook10 = 68650,

        [Annotation(Name = "[贝瑞特监牢] 大维壶师的制作笔记【１１】 68660")]
        BeluratGaolGreaterPotentatesCookbook11 = 68660,

        [Annotation(Name = "[利亚指头遗迹 - 最西北处] 发狂工匠的制作笔记【２】 68670")]
        FingerRuinsofRhiaFarNorthwestMadCraftsmansCookbook2 = 68670,

        [Annotation(Name = "[劳弗下方 - 蝎河西] 大维壶师的制作笔记【８】 68680")]
        RauhBaseWestScorpionRiverGreaterPotentatesCookbook8 = 68680,

        [Annotation(Name = "[墓地平原 - 雾谷要塞北] 大维壶师的制作笔记【３】 68690")]
        GravesitePlainNorthFogRiftFortGreaterPotentatesCookbook3 = 68690,

        [Annotation(Name = "[熔岩管锻造遗迹] 大维壶师的制作笔记【１３】 68700")]
        RuinedForgeLavaIntakeGreaterPotentatesCookbook13 = 68700,

        [Annotation(Name = "[青蓝海岸 - 谷底南边] 大维壶师的制作笔记【１４】 68710")]
        CeruleanCoastRavineSouthGreaterPotentatesCookbook14 = 68710,

        [Annotation(Name = "[利亚指头遗迹 - 最东北处] 大维壶师的制作笔记【６】 68720")]
        FingerRuinsofRhiaFarNortheastGreaterPotentatesCookbook6 = 68720,

        [Annotation(Name = "[墓地平原 - 艾拉克大桥] 大维壶师的制作笔记【２】 68730")]
        GravesitePlainEllacGreatbridgeGreaterPotentatesCookbook2 = 68730,

        [Annotation(Name = "[雾谷地下墓地] 古龙骑士的制作笔记【１】 68740")]
        FogRiftCatacombsAncientDragonKnightsCookbook1 = 68740,

        [Annotation(Name = "[墓地平原 - 通柱坡中段] 发狂工匠的制作笔记【１】 68750")]
        GravesitePlainPillarPathWaypointMadCraftsmansCookbook1 = 68750,

        [Annotation(Name = "[青蓝海岸 - 青蓝海岸的十字记号] 托莉娜信徒的制作笔记【１】 68760")]
        CeruleanCoastCeruleanCoastCrossStTrinaDisciplesCookbook1 = 68760,

        [Annotation(Name = "[幽影亚坛 - 穆斯废墟] 火焰骑士的制作笔记【１】 68770")]
        ScaduAltusMoorthRuinsFireKnightsCookbook1 = 68770,

        [Annotation(Name = "[蝎河地下墓地] 古龙骑士的制作笔记【２】 68780")]
        ScorpionRiverCatacombsAncientDragonKnightsCookbook2 = 68780,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 骑士实习生的制作笔记 68790")]
        GravesitePlainWestCastleEnsisLoyalKnightsCookbook = 68790,

        [Annotation(Name = "[幽影城] 战场神父的制作笔记【１】 68800")]
        ShadowKeepBattlefieldPriestsCookbook1 = 68800,

        [Annotation(Name = "[利亚指头遗迹 - 指头追寻者的破屋] 埃贡的制作笔记【１】 68810")]
        FingerRuinsofRhiaClimbtoFingerWeaversHovelIgonsCookbook1 = 68810,

        [Annotation(Name = "[墓地平原 - 毒沼泽东南] 战场神父的制作笔记【２】 68820")]
        GravesitePlainSoutheastPoisonSwampBattlefieldPriestsCookbook2 = 68820,

        [Annotation(Name = "[墓地平原 - 穆尔] 集物虫的制作笔记【７】 68830")]
        GravesitePlainMooreForagerBroodCookbook7 = 68830,

        [Annotation(Name = "[石棺大洞] 托莉娜信徒的制作笔记【３】 68840")]
        StoneCoffinFissureStTrinaDisciplesCookbook3 = 68840,

        [Annotation(Name = "[青蓝海岸 - 指头海岸中间] 守墓者的制作笔记【２】 68850")]
        CeruleanCoastFingercreeperBeachCenterGraveKeepersCookbook2 = 68850,

        [Annotation(Name = "[劳弗古遗迹 - 废墟东部坑道北部] 考古学者的制作笔记【２】 68860")]
        AncientRuinsofRauhEastRuinsNorthPitandTunnelsAntiquityScholarsCookbook2 = 68860,

        [Annotation(Name = "[青蓝海岸 - 提比亚的唤声船] 提比亚的制作笔记 68870")]
        CeruleanCoastTibiaMarinerTibiasCookbook = 68870,

        [Annotation(Name = "[米德拉府邸] 发狂工匠的制作笔记【３】 68880")]
        MidrasManseMadCraftsmansCookbook3 = 68880,

        [Annotation(Name = "[幽影亚坛 - 熔炉巨人区域] 战场神父的制作笔记【３】 68890")]
        ScaduAltusFurnaceGolemAreaBattlefieldPriestsCookbook3 = 68890,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 火焰骑士的制作笔记【２】 68900")]
        GravesitePlainWestCastleEnsisFireKnightsCookbook2 = 68900,

        [Annotation(Name = "[劳弗下方 - 影子之民] 考古学者的制作笔记【１】 68910")]
        RauhBaseShadowCommonerAntiquityScholarsCookbook1 = 68910,

        [Annotation(Name = "[青蓝海岸 - 指头海岸中间] 指头追寻者的制作笔记【１】 68920")]
        CeruleanCoastFingercreeperBeachCenterFingerWeaversCookbook1 = 68920,

        [Annotation(Name = "[幽影城 - 西边城墙] 战场神父的制作笔记【４】 68930")]
        ShadowKeepWestRampartBattlefieldPriestsCookbook4 = 68930,

        [Annotation(Name = "[青蓝海岸 - 南方无名灵庙] 守墓者的制作笔记【１】 68940")]
        CeruleanCoastSouthernNamelessMausoleumGraveKeepersCookbook1 = 68940,

        [Annotation(Name = "[青蓝海岸 - 石棺大洞南] 托莉娜信徒的制作笔记【２】 68950")]
        CeruleanCoastTheFissureSouthStTrinaDisciplesCookbook2 = 68950,

        [Annotation(Name = "[幽影城 - 西边城墙] 大龟裂壶 66980")]
        ShadowKeepWestRampartHeftyCrackedPot = 66980,

        [Annotation(Name = "[贝瑞特监牢] 大龟裂壶 66900")]
        BeluratGaolHeftyCrackedPot = 66900,

        [Annotation(Name = "[贝瑞特监牢] 大龟裂壶 66910")]
        BeluratGaolHeftyCrackedPot_ = 66910,

        [Annotation(Name = "[贝瑞特监牢] 大龟裂壶 66920")]
        BeluratGaolHeftyCrackedPot__ = 66920,

        [Annotation(Name = "[波尼监牢] 大龟裂壶 66930")]
        BonnyGaolHeftyCrackedPot = 66930,

        [Annotation(Name = "[喟叹监牢] 大龟裂壶 66940")]
        LamentersGaolHeftyCrackedPot = 66940,

        [Annotation(Name = "[青蓝海岸 - 山妖] 大龟裂壶 66990")]
        CeruleanCoastTrollHeftyCrackedPot = 66990,

        [Annotation(Name = "[墓地平原 - 火吻废墟] 大龟裂壶 66950")]
        GravesitePlainScorchedRuinsHeftyCrackedPot = 66950,

        [Annotation(Name = "[幽影亚坛 - 波尼村] 大龟裂壶 66970")]
        ScaduAltusMainBonnyVillageHeftyCrackedPot = 66970,

        [Annotation(Name = "[幽影亚坛 - 波尼村] 大龟裂壶 66960")]
        ScaduAltusMainBonnyVillageHeftyCrackedPot_ = 66960,

        [Annotation(Name = "[“塔之镇”贝瑞特] 幽影树碎片 20007620")]
        BeluratScadutreeFragment = 20007620,

        [Annotation(Name = "[“塔之镇”贝瑞特] 幽影树碎片 20007820")]
        BeluratScadutreeFragment_ = 20007820,

        [Annotation(Name = "[艾尼尔·伊利姆] 幽影树碎片 20017350")]
        EnirIlimScadutreeFragment = 20017350,

        [Annotation(Name = "[艾尼尔·伊利姆] 幽影树碎片 20017470")]
        EnirIlimScadutreeFragment_ = 20017470,

        [Annotation(Name = "[艾尼尔·伊利姆] 幽影树碎片 20017550")]
        EnirIlimScadutreeFragment__ = 20017550,

        [Annotation(Name = "[幽影城] 幽影树碎片 21007400")]
        ShadowKeepScadutreeFragment = 21007400,

        [Annotation(Name = "[物种保藏库] 幽影树碎片 21017200")]
        SpecimenStorehouseScadutreeFragment = 21017200,

        [Annotation(Name = "[物种保藏库] 幽影树碎片 21017500")]
        SpecimenStorehouseScadutreeFragment_ = 21017500,

        [Annotation(Name = "[石棺大洞] 幽影树碎片 22007000")]
        StoneCoffinFissureScadutreeFragment = 22007000,

        [Annotation(Name = "[劳弗古遗迹 - 花蕾教堂以南] 幽影树碎片 2044457000")]
        AncientRuinsofRauhSouthChurchoftheBudScadutreeFragment = 2044457000,

        [Annotation(Name = "[墓地平原 - 正门前方的十字记号] 幽影树碎片 2045427700")]
        GravesitePlainBeluratMainGateCrossScadutreeFragment = 2045427700,

        [Annotation(Name = "[墓地平原 - 三叉口的十字记号] 幽影树碎片 2046427700")]
        GravesitePlainThreePathCrossScadutreeFragment = 2046427700,

        [Annotation(Name = "[劳弗下方 - 神殿镇废墟] 幽影树碎片 2046457040")]
        RauhBaseTempleTownRuinsScadutreeFragment = 2046457040,

        [Annotation(Name = "[劳弗下方 - 河马] 幽影树碎片 2046467000")]
        RauhBaseHippopotamusScadutreeFragment = 2046467000,

        [Annotation(Name = "[劳弗下方 - 火精灵石洞窟] 幽影树碎片 2046477750")]
        RauhBaseFireSpritestoneCaveScadutreeFragment = 2046477750,

        [Annotation(Name = "[青蓝海岸 - 河马] 幽影树碎片 2047397070")]
        CeruleanCoastHippopotamusScadutreeFragment = 2047397070,

        [Annotation(Name = "[墓地平原 - 火吻废墟以南] 幽影树碎片 2047407100")]
        GravesitePlainSouthofScorchedRuinsScadutreeFragment = 2047407100,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 幽影树碎片 2047447720")]
        GravesitePlainWestCastleEnsisScadutreeFragment = 2047447720,

        [Annotation(Name = "[墓地平原 - 恩希斯城以西] 幽影树碎片 2047447750")]
        GravesitePlainWestCastleEnsisScadutreeFragment_ = 2047447750,

        [Annotation(Name = "[幽影亚坛 - 圣战教堂] 幽影树碎片 2x 2047467500")]
        ScaduAltusChurchoftheCrusadeScadutreeFragment2x = 2047467500,

        [Annotation(Name = "[青蓝海岸 - 青蓝海岸的十字记号] 幽影树碎片 2048377050")]
        CeruleanCoastCeruleanCoastCrossScadutreeFragment = 2048377050,

        [Annotation(Name = "[墓地平原 - 慰借教堂] 幽影树碎片 2x 2048417700")]
        GravesitePlainChurchofConsolationScadutreeFragment2x = 2048417700,

        [Annotation(Name = "[墓地平原 - 通柱坡的十字记号] 幽影树碎片 2048437700")]
        GravesitePlainPillarPathCrossScadutreeFragment = 2048437700,

        [Annotation(Name = "[墓地平原 - 恩希斯城东] 幽影树碎片 2048447500")]
        GravesitePlainEastCastleEnsisScadutreeFragment = 2048447500,

        [Annotation(Name = "[幽影亚坛 - 大道旁的十字记号] 幽影树碎片 2048457520")]
        ScaduAltusHighroadCrossScadutreeFragment = 2048457520,

        [Annotation(Name = "[幽影亚坛 - 熔炉巨人区域] 幽影树碎片 2048467510")]
        ScaduAltusFurnaceGolemAreaScadutreeFragment = 2048467510,

        [Annotation(Name = "[幽影亚坛 - 穆斯废墟] 幽影树碎片 2049447530")]
        ScaduAltusMoorthRuinsScadutreeFragment = 2049447530,

        [Annotation(Name = "[幽影亚坛 - 穆斯大道营地] 幽影树碎片 2049457510")]
        ScaduAltusMoorthHighwayCampScadutreeFragment = 2049457510,

        [Annotation(Name = "[望影露台 - 物种保藏库出口] 幽影树碎片 2049487000")]
        ScaduviewSpecimenStorehouseExitScadutreeFragment = 2049487000,

        [Annotation(Name = "[望影露台 - 幽影树圣杯] 幽影树碎片 2049497500")]
        ScaduviewScadutreeChaliceScadutreeFragment = 2049497500,

        [Annotation(Name = "[望影露台 - 幽影树圣杯] 幽影树碎片 2049497520")]
        ScaduviewScadutreeChaliceScadutreeFragment_ = 2049497520,

        [Annotation(Name = "[望影露台 - 幽影树圣杯] 幽影树碎片 2049497530")]
        ScaduviewScadutreeChaliceScadutreeFragment__ = 2049497530,

        [Annotation(Name = "[望影露台 - 幽影树圣杯] 幽影树碎片 2049497540")]
        ScaduviewScadutreeChaliceScadutreeFragment___ = 2049497540,

        [Annotation(Name = "[望影露台 - 幽影树圣杯] 幽影树碎片 2049497550")]
        ScaduviewScadutreeChaliceScadutreeFragment____ = 2049497550,

        [Annotation(Name = "[幽影亚坛 - 远望幽影树的十字记号] 幽影树碎片 2050437010")]
        ScaduAltusScaduviewCrossScadutreeFragment = 2050437010,

        [Annotation(Name = "[幽影亚坛 - 远望幽影树的十字记号] 幽影树碎片 2050437500")]
        ScaduAltusScaduviewCrossScadutreeFragment_ = 2050437500,

        [Annotation(Name = "[幽影亚坛 - 波尼村以北] 幽影树碎片 2050457730")]
        ScaduAltusBonnyVillageNorthTreeandOverlookScadutreeFragment = 2050457730,

        [Annotation(Name = "[幽影亚坛 - 河马] 幽影树碎片 2051447500")]
        ScaduAltusHippopotamusScadutreeFragment = 2051447500,

        [Annotation(Name = "[幽影亚坛 - 河马] 幽影树碎片 2051447510")]
        ScaduAltusHippopotamusScadutreeFragment_ = 2051447510,

        [Annotation(Name = "[尖刺山 - 尖刺山腰与山顶之间] 幽影树碎片 2053397020")]
        JaggedPeakBetweenJaggedPeakMountainsideandSummitScadutreeFragment = 2053397020,

        [Annotation(Name = "[谷底森林 - 废弃教堂] 幽影树碎片 2x 2053417500")]
        AbyssalWoodsAbandonedChurchScadutreeFragment2x = 2053417500,

        [Annotation(Name = "[墓地平原 - 影子之民] 幽影树碎片 2049440990")]
        GravesitePlainShadowCommonerScadutreeFragment = 2049440990,

        [Annotation(Name = "[墓地平原 - 影子之民] 幽影树碎片 2044417995")]
        GravesitePlainShadowCommonerScadutreeFragment_ = 2044417995,

        [Annotation(Name = "[幽影亚坛 - 影子之民] 幽影树碎片 2046477960")]
        ScaduAltusShadowCommonerScadutreeFragment = 2046477960,

        [Annotation(Name = "[劳弗古遗迹 - 影子之民] 幽影树碎片 2047417995")]
        AncientRuinsofRauhShadowCommonerScadutreeFragment = 2047417995,

        [Annotation(Name = "[“塔之镇”贝瑞特] 灵灰 2x 20007170")]
        BeluratReveredSpiritAsh2x = 20007170,

        [Annotation(Name = "[“塔之镇”贝瑞特] 灵灰 20007700")]
        BeluratReveredSpiritAsh = 20007700,

        [Annotation(Name = "[“塔之镇”贝瑞特] 灵灰 20007800")]
        BeluratReveredSpiritAsh_ = 20007800,

        [Annotation(Name = "[艾尼尔·伊利姆] 灵灰 2x 20017200")]
        EnirIlimReveredSpiritAsh2x = 20017200,

        [Annotation(Name = "[艾尼尔·伊利姆] 灵灰 20017400")]
        EnirIlimReveredSpiritAsh = 20017400,

        [Annotation(Name = "[物种保藏库] 灵灰 21017020")]
        SpecimenStorehouseReveredSpiritAsh = 21017020,

        [Annotation(Name = "[物种保藏库] 灵灰 21017460")]
        SpecimenStorehouseReveredSpiritAsh_ = 21017460,

        [Annotation(Name = "[米德拉府邸] 灵灰 28007110")]
        MidrasManseReveredSpiritAsh = 28007110,

        [Annotation(Name = "[劳弗下方 - 蝎河地下墓地入口] 灵灰 2044467000")]
        RauhBaseScorpionRiverCatacombsEntranceReveredSpiritAsh = 2044467000,

        [Annotation(Name = "[墓地平原 - 崖上道路的终点] 灵灰 2045417700")]
        GravesitePlainCliffroadTerminusReveredSpiritAsh = 2045417700,

        [Annotation(Name = "[墓地平原 - 大桥北] 灵灰 2046447700")]
        GravesitePlainGreatbridgeNorthReveredSpiritAsh = 2046447700,

        [Annotation(Name = "[劳弗下方 - 神殿镇废墟] 灵灰 2046457720")]
        RauhBaseTempleTownRuinsReveredSpiritAsh = 2046457720,

        [Annotation(Name = "[墓地平原 - 火吻废墟] 灵灰 2047417700")]
        GravesitePlainScorchedRuinsReveredSpiritAsh = 2047417700,

        [Annotation(Name = "[墓地平原 - 恩希斯城前方以东] 灵灰 2047437700")]
        GravesitePlainEastofEnsisCastleFrontReveredSpiritAsh = 2047437700,

        [Annotation(Name = "[幽影亚坛 - 穆斯废墟] 灵灰 2049447500")]
        ScaduAltusMoorthRuinsReveredSpiritAsh = 2049447500,

        [Annotation(Name = "[幽影亚坛 - 远望幽影树的十字记号] 灵灰 2050437720")]
        ScaduAltusScaduviewCrossReveredSpiritAsh = 2050437720,

        [Annotation(Name = "[幽影亚坛 - 波尼村] 灵灰 2050447500")]
        ScaduAltusMainBonnyVillageReveredSpiritAsh = 2050447500,

        [Annotation(Name = "[幽影亚坛 - 城底积水处东南] 灵灰 2050467700")]
        ScaduAltusCastleWateringHoleSoutheastReveredSpiritAsh = 2050467700,

        [Annotation(Name = "[“塔之镇”贝瑞特 - 影子之民] 灵灰 20007900")]
        BeluratShadowCommonerReveredSpiritAsh = 20007900,

        [Annotation(Name = "[米德拉府邸 - 胖审判者] 灵灰 20017900")]
        MidrasManseFatInquisitorReveredSpiritAsh = 20017900,

        [Annotation(Name = "[艾尼尔·伊利姆 - 胖审判者] 灵灰 28007900")]
        EnirIlimFatInquisitorReveredSpiritAsh = 28007900,

        [Annotation(Name = "[劳弗古遗迹 - 影子之民] 灵灰 2044467950")]
        AncientRuinsofRauhShadowCommonerReveredSpiritAsh = 2044467950,

        [Annotation(Name = "[劳弗古遗迹 - 影子之民] 灵灰 2046477950")]
        AncientRuinsofRauhShadowCommonerReveredSpiritAsh_ = 2046477950,

        [Annotation(Name = "[墓地平原 - 慰借教堂以南] 绿秘密露滴 65400")]
        GravesitePlainSouthofChurchofConsolationViridianHiddenTear = 65400,

        [Annotation(Name = "[幽影亚坛 - 熔炉巨人区域] 涌红枯露滴 65410")]
        ScaduAltusFurnaceGolemAreaCrimsonburstDriedTear = 65410,

        [Annotation(Name = "[劳弗下方 - 腐败区域] 夺红破露滴 65420")]
        RauhBaseRotAreaCrimsonSappingCrackedTear = 65420,

        [Annotation(Name = "[幽影亚坛 - 玛努斯·美特大教堂] 夺蓝破露滴 65430")]
        ScaduAltusCathedralofManusMetyrCeruleanSappingCrackedTear = 65430,

        [Annotation(Name = "[幽影亚坛 - 城底积水处东南] 油光露滴 65440")]
        ScaduAltusCastleWateringHoleSoutheastOilSoakedTear = 65440,

        [Annotation(Name = "[幽影亚坛 - 城底积水处东南] 吸血破露滴 65450")]
        ScaduAltusCastleWateringHoleSoutheastBloodsuckingCrackedTear = 65450,

        [Annotation(Name = "[青蓝海岸 - 青蓝海岸西边] 铃兰结晶露滴 65460")]
        CeruleanCoastCeruleanCoastWestGlovewortCrystalTear = 65460,

        [Annotation(Name = "[墓地平原 - 三叉口的十字记号] 反弹硬露滴 65470")]
        GravesitePlainThreePathCrossDeflectingHardtear = 65470,

        [Annotation(Name = "[波尼监牢 - 咒剑士拉比利士] 咒剑士米拉 520760")]
        BonnyGaolCursebladeLabirithCursebladeMeera = 520760,

        [Annotation(Name = "[河尾洞窟 - 血怪之首] 血怪咒术师的骨灰 520800")]
        RivermouthCaveChiefBloodfiendBloodfiendHexersAshes = 520800,

        [Annotation(Name = "[青蓝海岸 - 青蓝海岸西边] 守墓鸟的骨灰 2046397040")]
        CeruleanCoastCeruleanCoastWestGravebirdAshes = 2046397040,

        [Annotation(Name = "[物种保藏库] “火焰骑士”希德 21017800")]
        SpecimenStorehouseFireKnightHilde = 21017800,

        [Annotation(Name = "[劳弗下方 - 火精灵石洞窟] 蜘蛛蝎的骨灰 2046477020")]
        RauhBaseFireSpritestoneCaveSpiderScorpionAshes = 2046477020,

        [Annotation(Name = "[艾尼尔·伊利姆] 拷问官的骨灰 20017310")]
        EnirIlimInquisitorAshes = 20017310,

        [Annotation(Name = "[贝瑞特监牢 - “亚人剑圣”翁吉] “亚人剑士”约西 520750")]
        BeluratGaolDemiHumanSwordmasterOnzeDemiHumanSwordsmanYosh = 520750,

        [Annotation(Name = "[墓地平原 - 毒沼泽东南] 梅瑟莫士兵的骨灰 2049437230")]
        GravesitePlainSoutheastPoisonSwampMessmerSoldierAshes = 2049437230,

        [Annotation(Name = "[雾谷地下墓地] “黑骑士团长”安卓斯 40007810")]
        FogRiftCatacombsBlackKnightCommanderAndreas = 40007810,

        [Annotation(Name = "[蝎河地下墓地] “黑骑士副团长”修 40017050")]
        ScorpionRiverCatacombsBlackKnightCaptainHuw = 40017050,

        [Annotation(Name = "[驱暗地下墓地] 大嘴小恶魔的骨灰 40027220")]
        DarklightCatacombsBigmouthImpAshes = 40027220,

        [Annotation(Name = "[幽影亚坛 - 波尼村] 人形苍蝇的骨灰 2050447710")]
        ScaduAltusMainBonnyVillageManFlyAshes = 2050447710,

        [Annotation(Name = "[泰乌尔锻造遗迹] “锻造魔像”泰乌尔 42037000")]
        TaylewsRuinedForgeTaylewtheGolemSmith = 42037000,

        [Annotation(Name = "[劳弗下方 - 神殿镇废墟] “神鸟战士”奥尼斯 2046457920")]
        RauhBaseTempleTownRuinsDivineBirdWarriorOrnis = 2046457920,

        [Annotation(Name = "[艾尼尔·伊利姆] 角战士的骨灰 20017420")]
        EnirIlimHornedWarriorAshes = 20017420,

        [Annotation(Name = "[利亚指头遗迹 - 龙飨女巫] “古龙”芙柔桑克斯 400700")]
        FingerRuinsofRhiaDragonCommunionPriestessAncientDragonFlorissax = 400700,

        [Annotation(Name = "[望影露台 - 指岩山丘口以东] 指虫的骨灰 2053487000")]
        ScaduviewEastofFingerstoneHillCraterFingercreeperAshes = 2053487000,

        [Annotation(Name = "[幽影城 - “火焰骑士”昆兰] “火焰骑士”昆兰 400690")]
        ShadowKeepFireKnightQueelignFireKnightQueelign = 400690,

        [Annotation(Name = "[幽影亚坛 - “黑夜剑士”约兰] “黑夜剑士”约兰 400670")]
        ScaduAltusSwordhandofNightJolanSwordhandofNightJolan = 400670,

    }
}
