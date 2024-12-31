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

using System;
using System.Windows.Data;
using SoulMemory.Memory;
using SoulSplitter.Splits.EldenRing;
using SoulSplitter.UI.Generic;

namespace SoulSplitter.UI.Converters
{
    public class EnumDisplayNameConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (value)
            {
                case EldenRingSplitType erEnum:
                    switch (erEnum)
                    {
                        case EldenRingSplitType.Boss:
                            return "击杀Boss";
                        case EldenRingSplitType.Grace:
                            return "点亮赐福";
                        case EldenRingSplitType.Flag:
                            return "事件标志";
                        case EldenRingSplitType.ItemPickup:
                            return "拾取物品";
                        case EldenRingSplitType.Item:
                            return "获取物品";
                        case EldenRingSplitType.Position:
                            return "抵达位置";
                        case EldenRingSplitType.KnownFlag:
                            return "已知标志";
                        default:
                            return erEnum.GetDisplayName();
                    }
                case SplitType soulEnum:
                    switch (soulEnum)
                    {
                        case SplitType.Boss:
                            return "击杀Boss";
                        case SplitType.Attribute:
                            return "升级属性";
                        case SplitType.Position:
                            return "抵达位置";
                        case SplitType.KnownFlag:
                            return "已知标志";
                        case SplitType.Flag:
                            return "事件标志";
                        case SplitType.Item:
                            return "获取物品";
                        case SplitType.Bonfire:
                            return "点亮篝火";
                        case SplitType.ItemPickup:
                            return "拾取物品";
                        case SplitType.Credits:
                            return "游戏结尾鸣谢名单";
                        default:
                            return soulEnum.GetDisplayName();
                    }
                case Enum e:
                    return e.GetDisplayName();
                default:
                    return "";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
