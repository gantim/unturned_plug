using Rocket.API;
using Rocket.Unturned;
using Rocket.Unturned.Chat;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Security.Cryptography.Xml;

namespace MyPlugin
{
    public class AddDoorCommand : IRocketCommand
    {
        public AllowedCaller AllowedCaller => AllowedCaller.Player;

        public string Name => "kit start";

        public string Help => "";

        public string Syntax => "";

        public List<string> Aliases => new List<string> { "kit start", "kit s" };

        public List<string> Permissions => new List<string> { "Exp.ad" };
        public UnturnedPlayer uplayer;
        public void Execute(IRocketPlayer caller, string[] command)
        {           

        }
    }
}
