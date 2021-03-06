﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flare_Sharp.Memory.FlameSDK
{
    public class Level : SDKObj
    {
        public Level(ulong addr) : base(addr)
        {
        }

        public Mob lookingEntity
        {
            get
            {
                return new Mob(MCM.readInt64(addr + 0x870));
            }
        }

        public int lookingBlockSide 
        {
            get
            {
                return MCM.readInt(addr + 0x854);
            }
            set
            {
                MCM.writeInt(addr + 0x854, value);
            }
        }
        public int lookingBlockX
        {
            get
            {
                return MCM.readInt(addr + 0x858);
            }
            set
            {
                MCM.writeInt(addr + 0x858, value);
            }
        }
        public int lookingBlockY
        {
            get
            {
                return MCM.readInt(addr + 0x85C);
            }
            set
            {
                MCM.writeInt(addr + 0x85C, value);
            }
        }
        public int lookingBlockZ
        {
            get
            {
                return MCM.readInt(addr + 0x860);
            }
            set
            {
                MCM.writeInt(addr + 0x860, value);
            }
        }

        public FirstPersonLookBehavior firstPersonCamera
        {
            get
            {
                return new FirstPersonLookBehavior(MCM.evaluatePointer(addr, MCM.ceByte2uLong("60 38 0")));
            }
        }

        public List<Gamerule> gamerules
        {
            get
            {
                List<Gamerule> returnRules = new List<Gamerule>();
                for (ulong ruleIndex = 0; ruleIndex < 28; ruleIndex++)
                {
                    returnRules.Add(new Gamerule(MCM.readInt64(addr + 0x340) + (ruleIndex * 176)));
                }
                return returnRules;
            }
        }
    }
}
