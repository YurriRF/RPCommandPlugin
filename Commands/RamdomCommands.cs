using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using BrokeProtocol.API;
using BrokeProtocol.Collections;
using BrokeProtocol.Entities;
using BrokeProtocol.GameSource.Types;
using BrokeProtocol.Managers;
using BrokeProtocol.Required;
using BrokeProtocol.Utility;
using BrokeProtocol.Utility.Networking;
using Newtonsoft.Json.Linq;
using UnityEngine;

namespace BrokeProtocol.GameSource.Commands
{
    internal class Commands : IScript
    {
        public Commands()
        {
            CommandHandler.RegisterCommand("roll", new Action<ShPlayer>(RollHandler), null, null);
            //CommandHandler.RegisterCommand("getmarker", new Action<ShPlayer, ShPlayer>(MarkerHandler), null, null);
        }

        [CustomTarget]

        public void RollHandler(ShPlayer player)
        {
            int num = UnityEngine.Random.Range(1, 100);
            player.svPlayer.SvChatLocal("*La personne est tombé sur " + num + " *");
            player.svPlayer.SendGameMessage("&aSuccès &7- &fVous avez lancé un dé et vous êtes tombé sur &e" + num + " &f!");
        }

        //public void MarkerHandler(ShPlayer player, ShPlayer target)
        //{
        //    foreach (ShPlayer ems in from x in EntityCollections.Humans
        //                             where ((MyJobInfo)x.svPlayer.job.info).
        //                             select x)
        //    {
        //        var e = SvManager.Instance.AddNewEntity(SceneManager.Instance.GetEntity("MarkerShoot"), player.GetPlace, player.GetPosition, player.GetRotation, new IDCollection<ShPlayer> { showToPlayer });
        //        SvManager.Instance.StartCoroutine(DestroyAfter(e, 5f));

        //        IEnumerator DestroyAfter(ShEntity e, float delay)
        //        {
        //            yield return new WaitForSeconds(delay);
        //            e2.Destroy();
        //        }
        //    }
        //}
    }
}
