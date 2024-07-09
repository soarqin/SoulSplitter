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
        [AnnotationAttribute(Name = "鬼形部")]
        GyoubuMasatakaOniwa = 9301,

        [AnnotationAttribute(Name = "幻影之蝶")]
        LadyButterfly = 9302,

        [AnnotationAttribute(Name = "苇名弦一郎")]
        GenichiroAshina = 9303,

        [AnnotationAttribute(Name = "观猴、闻猴、言猴")]
        FoldingScreenMonkeys = 9305,

        [AnnotationAttribute(Name = "狮子猿")]
        GuardianApe = 9304,

        [AnnotationAttribute(Name = "无首狮子猿")]
        HeadlessApe = 9307,

        [AnnotationAttribute(Name = "破戒僧 (幻影)")]
        CorruptedMonkGhost = 9306,

        [AnnotationAttribute(Name = "柔剑 永真")]
        EmmaTheGentleBlade = 9315,

        [AnnotationAttribute(Name = "苇名一心")]
        IsshinAshina = 9316,

        [AnnotationAttribute(Name = "巨型忍者 枭")]
        GreatShinobiOwl = 9308,

        [AnnotationAttribute(Name = "破戒僧")]
        TrueCorruptedMonk = 9309,

        [AnnotationAttribute(Name = "樱龙")]
        DivineDragon = 9310,

        [AnnotationAttribute(Name = "义父")]
        OwlFather = 9317,

        [AnnotationAttribute(Name = "怨恨之鬼")]
        DemonOfHatred = 9313,

        [AnnotationAttribute(Name = "剑圣 苇名一心")]
        IsshinTheSwordSaint = 9312,
    }
}