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
    public enum Boss
    {
        [Annotation(Name = "鬼形部")]
        GyoubuMasatakaOniwa = 9301,

        [Annotation(Name = "幻影之蝶")]
        LadyButterfly = 9302,

        [Annotation(Name = "苇名弦一郎")]
        GenichiroAshina = 9303,

        [Annotation(Name = "观猴、闻猴、言猴")]
        FoldingScreenMonkeys = 9305,

        [Annotation(Name = "狮子猿")]
        GuardianApe = 9304,

        [Annotation(Name = "无首狮子猿")]
        HeadlessApe = 9307,

        [Annotation(Name = "破戒僧 (幻影)")]
        CorruptedMonkGhost = 9306,

        [Annotation(Name = "柔剑 永真")]
        EmmaTheGentleBlade = 9315,

        [Annotation(Name = "苇名一心")]
        IsshinAshina = 9316,

        [Annotation(Name = "巨型忍者 枭")]
        GreatShinobiOwl = 9308,

        [Annotation(Name = "破戒僧")]
        TrueCorruptedMonk = 9309,

        [Annotation(Name = "樱龙")]
        DivineDragon = 9310,

        [Annotation(Name = "义父")]
        OwlFather = 9317,

        [Annotation(Name = "怨恨之鬼")]
        DemonOfHatred = 9313,

        [Annotation(Name = "剑圣 苇名一心")]
        IsshinTheSwordSaint = 9312,
    }
}