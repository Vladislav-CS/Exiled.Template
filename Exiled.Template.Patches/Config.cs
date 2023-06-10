﻿using Exiled.API.Interfaces;

namespace Exiled.Template.Patches
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;
    }
}