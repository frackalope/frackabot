﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSharpPlus
{
    public interface IModule
    {
        DiscordClient Client { get; }

        void Setup(DiscordClient client);
    }
}
