﻿using Flare_Sharp.ClientBase.Categories;
using Flare_Sharp.Memory.FlameSDK;

namespace Flare_Sharp.ClientBase.Modules.Modules
{
    public class PlayerSpeed : Module
    {
        public PlayerSpeed() : base("Speed", CategoryHandler.registry.categories[1], (char)0x07, false)
        {
            RegisterSliderSetting("Speed", 0, 5, 50);
        }

        public override void onDisable()
        {
            base.onDisable();
            Minecraft.clientInstance.localPlayer.playerAttributes.speed.value = 0.1F;
        }

        public override void onTick()
        {
            base.onTick();
            Minecraft.clientInstance.localPlayer.playerAttributes.speed.value = (float)sliderSettings[0].value/10;
        }
    }
}
