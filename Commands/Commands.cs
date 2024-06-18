using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BrokeProtocol.API;
using BrokeProtocol.Collections;
using BrokeProtocol.Entities;
using BrokeProtocol.Managers;
using BrokeProtocol.Required;
using BrokeProtocol.Utility;
using BrokeProtocol.Utility.Networking;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace YurriRPCommandPlugin
{
    internal class Commands : IScript
    {
        public Commands()
        {
            CommandHandler.RegisterCommand("roll", new Action<ShPlayer>(RollHandler), null, null);
            CommandHandler.RegisterCommand("me", new Action<ShPlayer, string>(MeHandler), null, null);
        }

        [CustomTarget]
        public void RollHandler(ShPlayer player)
        {
            int num = UnityEngine.Random.Range(1, 100);
            player.svPlayer.SvChatLocal("*La personne est tombé(e) sur " + num + " *");
            player.svPlayer.SendGameMessage("&aSuccès &7 - &fVous avez lancé un dé et vous êtes tombé sur &e" + num + " & f!");
        }

        [CustomTarget]
        public void MeHandler(ShPlayer player, string action)
        {
            player.svPlayer.SvChatLocal("*La personne " + action + " *");
        }
    }
}
