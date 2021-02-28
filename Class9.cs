using ProtoBuf;

using UnityEngine;
public class melee : MonoBehaviour
{
    private readonly float dist = 4f;
    private void Update()
    {
        if (CFG.Setting.animal && LocalPlayer.Entity != null && BaseEntityEx.IsValid(LocalPlayer.Entity))
        {
            HeldEntity хелд = LocalPlayer.Entity.GetHeldEntity();
            BaseMelee мил = хелд as BaseMelee;
            if (мил == null)
            {
                return;
            }
            if (UnityEngine.Time.time - float_0 < мил.repeatDelay)
            {
                return;
            }
            if (хелд != null)
            {

                foreach (BaseNpc player in BaseNpc.VisibleNpcList)
                {
                    if (player != null && !player.IsDead() && BaseEntityEx.IsValid(player) && BaseEntityEx.IsValid(мил))
                    {
                        int дист = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.FindBone("head").position);
                        if (дист < 6f)
                        {
                            Ray ray = new Ray(LocalPlayer.Entity.transform.position, (player.FindBone("head").position - player.FindBone("head").position).normalized);
                            using (PlayerAttack аттак = Facepunch.Pool.Get<PlayerAttack>())
                            {
                                using (Attack attack = Facepunch.Pool.Get<Attack>())
                                {
                                    аттак.attack = attack;
                                    аттак.attack.hitID = player.net.ID;
                                    аттак.attack.hitBone = 698017942;
                                    аттак.attack.hitPositionWorld = player.FindBone("head").position;
                                    аттак.attack.hitNormalWorld = ray.direction;
                                    аттак.attack.pointStart = LocalPlayer.Entity.transform.position;
                                    аттак.attack.pointEnd = player.FindBone("head").position;
                                    мил.ServerRPC<PlayerAttack>("PlayerAttack", аттак);
                                }
                            };
                            float_0 = UnityEngine.Time.time;
                        }
                    }
                }
            }
        }
        if (CFG.Setting.rrrar && LocalPlayer.Entity != null)
        {
            HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
            BaseMelee baseMelee = heldEntity as BaseMelee;

            {

                foreach (BasePlayer player in BasePlayer.VisiblePlayerList)
                {
                    if (player != null && !(baseMelee == null) && Time.time - float_0 >= baseMelee.repeatDelay && heldEntity != null && BaseEntityEx.IsValid(player) && BaseEntityEx.IsValid(baseMelee)
  && !player.IsLocalPlayer() && !player.IsDead() && !CFG.Setting.friendsList.Contains(player.userID))
                    {

                        int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.model.headBone.transform.position + new Vector3(0f, 0.04f, 0.04f));
                        if (dist < this.dist)
                        {
                            Ray ray = new Ray(menu.localplayer.eyes.transform.position, (player.FindBone("head").position - player.FindBone("head").position).normalized);
                            using (PlayerAttack playerAttack = Facepunch.Pool.Get<PlayerAttack>())
                            {
                                if (CFG.Setting.milll)
                                {
                                    Effect.client.Run(CFG.Setting.tt ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/headshot_2d.prefab", LocalPlayer.Entity.eyes.gameObject);
                                    playerAttack.attack = new Attack
                                    {
                                        hitID = player.net.ID,
                                        hitBone = (CFG.Setting.tt ? 3399023664U : 3198432U),
                                        hitPartID = (CFG.Setting.tt ? 1890214305U : 1744899316U),
                                        hitItem = 0u,
                                        hitPositionWorld = menu.localplayer.eyes.transform.position,
                                        hitPositionLocal = menu.localplayer.eyes.transform.position,
                                        hitNormalLocal = menu.localplayer.eyes.transform.position,
                                        hitNormalWorld = menu.localplayer.eyes.transform.position,
                                        pointStart = menu.localplayer.eyes.transform.position + Vector3.up,
                                        pointEnd = menu.localplayer.eyes.transform.position + Vector3.up,
                                        ShouldPool = true

                                    };
                                    baseMelee.ServerRPC("PlayerAttack", playerAttack);
                                }
                            }
                            using (PlayerAttack playerAttack = Facepunch.Pool.Get<PlayerAttack>())
                            {
                                using (Attack attack = Facepunch.Pool.Get<Attack>())
                                {
                                    Effect.client.Run(CFG.Setting.tt ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/headshot_2d.prefab", LocalPlayer.Entity.eyes.gameObject);
                                    playerAttack.attack = attack;
                                    playerAttack.attack.hitID = player.net.ID;
                                    playerAttack.attack.hitBone = (CFG.Setting.tt ? 3399023664U : 3198432U);
                                    playerAttack.attack.hitPartID = (CFG.Setting.tt ? 1890214305U : 1744899316U);
                                    playerAttack.attack.hitPositionWorld = player.FindBone("head").position;
                                    playerAttack.attack.hitNormalWorld = ray.direction;
                                    playerAttack.attack.pointStart = menu.localplayer.eyes.position;
                                    playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -1f, 0f);
                                    playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
                                    playerAttack.attack.pointEnd = player.FindBone("head").position;
                                    baseMelee.ServerRPC<PlayerAttack>("PlayerAttack", playerAttack);
                                }
                            };
                            float_0 = Time.time;
                        }
                    }
                }
            }
        }


    }
    public GameObjectRef EffectToCreate;

    private float float_0;
}
