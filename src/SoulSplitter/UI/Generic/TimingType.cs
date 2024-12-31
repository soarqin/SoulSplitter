﻿// This file is part of the SoulSplitter distribution (https://github.com/FrankvdStam/SoulSplitter).
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

using SoulMemory;

namespace SoulSplitter.UI.Generic
{
    public enum TimingType
    {
        [Annotation(Name = "立即触发")]
        Immediate,
        
        [Annotation(Name = "游戏加载")]
        OnLoading,

        [Annotation(Name = "过场黑屏")]
        OnBlackscreen,

        [Annotation(Name = "传送")]
        OnWarp,
    }
}
