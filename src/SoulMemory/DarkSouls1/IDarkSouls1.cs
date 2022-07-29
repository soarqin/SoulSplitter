﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoulMemory.DarkSouls1
{
    internal interface IDarkSouls1
    {
        bool Refresh(out Exception exception);
        bool ReadEventFlag(uint eventFlagId);
        int GetAttribute(Attribute attribute);
        bool IsWarping();
        bool IsLoaded();
        bool IsPlayerLoaded();
        int GetInGameTimeMillis();
        Vector3f GetPosition();
    }
}
