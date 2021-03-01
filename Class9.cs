using System;
using Facepunch;
using ProtoBuf;
using UnityEngine;
public class melee : MonoBehaviour
{
    private float dist=4f;
    private void Update()
    {
        if (CFG.Misc.rrrar && LocalPlayer.Entity != null)
        {
            HeldEntity heldEntity = LocalPlayer.Entity.GetHeldEntity();
            BaseMelee baseMelee = heldEntity as BaseMelee;

            {
                
                    foreach (BasePlayer player in BasePlayer.visiblePlayerList)
                    {
                        if (player != null && !(baseMelee == null) && Time.time - this.float_0 >= baseMelee.repeatDelay && heldEntity != null && BaseEntityEx.IsValid(player) && BaseEntityEx.IsValid(baseMelee)
      && !player.IsLocalPlayer() && !player.IsDead() && !friend.friendsList.Contains(player.userID))
                        {
                          
                                int dist = (int)Vector3.Distance(MainCamera.mainCamera.transform.position, player.model.headBone.transform.position + new Vector3(0f, 0.04f, 0.04f));
                            if (dist < this.dist)
                            {
                            Ray ray = new Ray(menu.localplayer.eyes.transform.position, (player.FindBone("head").position - player.FindBone("head").position).normalized);
                                using (PlayerAttack playerAttack = Facepunch.Pool.Get<PlayerAttack>())
                                {
                                    if (CFG.Misc.milll)
                                {
                                   
                                        playerAttack.attack = new Attack
                                        {
                                            hitID = player.net.ID,
                                            hitBone = (CFG.Misc.tt ? 3399023664U : 3198432U),
                                            hitPartID = (CFG.Misc.tt ? 1890214305U : 1744899316U),
                                            hitItem = 0u,
                                            hitPositionWorld = menu.localplayer.eyes.transform.position,
                                            hitPositionLocal = menu.localplayer.eyes.transform.position,
                                            hitNormalLocal = menu.localplayer.eyes.transform.position,
                                            hitNormalWorld = menu.localplayer.eyes.transform.position,
                                            pointStart = menu.localplayer.eyes.transform.position + Vector3.up,
                                            pointEnd = menu.localplayer.eyes.transform.position + Vector3.up,
                                            ShouldPool = true

                                        };
                                    baseMelee.ServerRPC("PlayerAttack", playerAttack, null, null, null, null);
                                }
                                }
                                using (PlayerAttack playerAttack = Facepunch.Pool.Get<PlayerAttack>())
                                {
                                    using (Attack attack = Facepunch.Pool.Get<Attack>())
                                    {
                                    Effect.client.Run("assets/bundled/prefabs/fx/entities/tree/tree-impact.prefab", CFG.Misc.tt ? player.model.rootBone.gameObject : player.model.headBone.gameObject);
                                    Effect.client.Run(CFG.Misc.tt ? "assets/bundled/prefabs/fx/hit_notify.prefab" : "assets/bundled/prefabs/fx/headshot.prefab", CFG.Misc.tt ? player.model.rootBone.gameObject : player.model.headBone.gameObject);
                                    playerAttack.attack = attack;
                                        playerAttack.attack.hitID = player.net.ID;
                                        playerAttack.attack.hitBone = (CFG.Misc.tt ? 3399023664U : 3198432U);
                                        playerAttack.attack.hitPartID = (CFG.Misc.tt ? 1890214305U : 1744899316U);
                                        playerAttack.attack.hitPositionWorld = player.FindBone("head").position;
                                        playerAttack.attack.hitNormalWorld = ray.direction;
                                        playerAttack.attack.pointStart = menu.localplayer.eyes.position;
                                        playerAttack.attack.hitPositionLocal = new Vector3(-0.1f, -1f, 0f);
                                        playerAttack.attack.hitNormalLocal = new Vector3(0f, -1f, 0f);
                                        playerAttack.attack.pointEnd = player.FindBone("head").position;
                                        baseMelee.ServerRPC ("PlayerAttack", playerAttack,null,null,null,null);
                                    }
                                };
                                this.float_0 = Time.time;
                            }
                        }
                    }
                }
            }

        
    }
	public GameObjectRef EffectToCreate;

	private float float_0;
}
