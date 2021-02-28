using ProtoBuf;

using UnityEngine;

public class AUTO : MonoBehaviour
{
    private void Update()
    {
        if (CFG.Setting.bvbvn && LocalPlayer.Entity && LocalPlayer.Entity.IsValid() && global::BasePlayer.VisiblePlayerList != null)
        {

            global::HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
            BaseMelee baseMelee = heldEntity as BaseMelee;
            if (!(baseMelee == null) && Time.time - nextAttack >= Time.deltaTime && heldEntity != null)
            {
                foreach (OreHotSpot player in companent.orehotspot)
                {
                    global::Item activeItem = LocalPlayer.Entity.Belt.GetActiveItem();

                    if (player != null && !player.IsDestroyed && BaseEntityEx.IsValid(player) && BaseEntityEx.IsValid(baseMelee) && activeItem != null && (activeItem.info.shortname.Contains("bone.club") ||
                       activeItem.info.shortname.Contains("hammer.salvaged") || activeItem.info.shortname.Contains("icepick.salvaged") ||
                       activeItem.info.shortname.Contains("pickaxe") || activeItem.info.shortname.Contains("stone.pickaxe") ||
                       activeItem.info.shortname.Contains("rock") || activeItem.info.shortname.Contains("jackhammer")))
                    {

                        int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.transform.position);
                        if (dist < 4)
                        {
                            Ray ray = new Ray(menu.localplayer.eyes.transform.position, (player.transform.position - player.transform.position).normalized);
                            using (PlayerAttack playerAttack = Facepunch.Pool.Get<PlayerAttack>())
                            {
                                using (Attack attack = Facepunch.Pool.Get<Attack>())
                                {
                                    playerAttack.attack = attack;
                                    playerAttack.attack.hitID = player.net.ID;
                                    playerAttack.attack.hitBone = 0;
                                    playerAttack.attack.hitPositionWorld = player.transform.position;
                                    playerAttack.attack.hitNormalWorld = ray.direction;
                                    playerAttack.attack.pointStart = menu.localplayer.eyes.position;
                                    playerAttack.attack.pointEnd = player.transform.position;
                                    baseMelee.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack);
                                }
                            };
                            nextAttack = UnityEngine.Time.time + baseMelee.repeatDelay;
                        }
                    }
                }
            }










        }
    }

    // Token: 0x0400000B RID: 11
    private float nextAttack;
}
