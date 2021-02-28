using System.Collections.Generic;

using UnityEngine;
using UnityEngine.EventSystems;

public class ff : BaseMovement
{
    private void Start()
    {
        byte[] ff = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x48, 0x83, 0xec, 0x08, 0x48, 0x8b, 0xf1 };
        f = new DumbHook(typeof(PlayerWalkMovement), "Movement_Walking", typeof(ff), "Movement_Walking", typeof(ff), "Movement_WalkingTrampoline", ff);
        f.Hook();
        byte[] yeahhh1111111 = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        boredasf1111111 = new DumbHook(typeof(GameTrace), "TraceAll", typeof(ff), "TraceAll", typeof(ff), "TraceAllTrampoline", yeahhh1111111);
        boredasf1111111.Hook();
        byte[] yeahhh11111111 = { 0x55, 0x48, 0x8b, 0xec, 0x56, 0x57, 0x41, 0x56, 0x48, 0x83, 0xec, 0x08 };
        boredasf11111111 = new DumbHook(typeof(ItemIcon), "OnPointerEnter", typeof(ff), "OnPointerEnter", typeof(ff), "OnPointerEnterTrampoline", yeahhh11111111);
        boredasf11111111.Hook();



    }

    private readonly DumbHook dfd;

    public void OnPointerEnterTrampoline()
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

        if (UnityEngine.Input.GetKey(KeyCode.F))
        {
            gameObject.GetComponent<ItemIcon>().TryToMove();
            return;
        }
        base.transform.localScale = Vector3.one;
        if (SelectedBlueprint.isOpen)
        {
            return;
        }
        if (DragMe.dragging)
        {
            return;
        }
        if (gameObject.GetComponent<ItemIcon>().item == null)
        {
            return;
        }
        if (gameObject.GetComponent<ItemIcon>().hoverOutline)
        {
            gameObject.GetComponent<ItemIcon>().hoverOutline.enabled = true;
        }
        gameObject.GetComponent<AboutYou>().username.text = CFG.Setting.spoof ? CFG.Setting.faked : SteamClient.localName;
        SteamClient.localName = CFG.Setting.spoof ? CFG.Setting.faked : Client.Steam.Username;
    }

    private DumbHook f;
    private DumbHook boredasf1111111;
    private readonly DumbHook boredasf111111111;
    private DumbHook boredasf11111111;
    public static void TraceAll(HitTest test, List<TraceInfo> traces, int layerMask = -5)
    {
        if (CFG.Setting.grass12)
        {
            layerMask &= CFG.Setting.grass ? -1073741825 : -5;
        }
        layerMask &= CFG.Setting.grass ? -8388609 : -5;
        layerMask &= CFG.Setting.grass ? -65537 : -5;

        if (CFG.Setting.grass ? test.HitMaterial != "Flesh" : true)
        {
            List<RaycastHit> list = Facepunch.Pool.GetList<RaycastHit>();
            Vector3 origin = test.AttackRay.origin;
            Vector3 direction = test.AttackRay.direction;
            float maxDistance = test.MaxDistance;
            float radius = test.Radius;
            if ((layerMask & 16384) != 0)
            {
                layerMask &= -16385;
                GamePhysics.TraceAllUnordered(new Ray(origin - direction * 5f, direction), radius, list, maxDistance + 5f, 16384, QueryTriggerInteraction.UseGlobal);
                for (int i = 0; i < list.Count; i++)
                {
                    RaycastHit raycastHit = list[i];
                    raycastHit.distance -= 5f;
                    list[i] = raycastHit;
                }
            }
            GamePhysics.TraceAllUnordered(new Ray(origin, direction), radius, list, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
            for (int j = 0; j < list.Count; j++)
            {
                RaycastHit hit = list[j];
                Collider collider = hit.GetCollider();
                if (!collider.isTrigger)
                {
                    ColliderInfo component = collider.GetComponent<ColliderInfo>();
                    if (!component || component.Filter(test))
                    {
                        BaseCollision component2 = collider.GetComponent<BaseCollision>();
                        if (component2 != null)
                        {
                            component2.TraceTest(test, traces);
                        }
                        else if (hit.distance > 0f)
                        {
                            TraceInfo traceInfo = default(TraceInfo);
                            traceInfo.valid = true;
                            traceInfo.distance = hit.distance;
                            traceInfo.partID = 0U;
                            traceInfo.point = hit.point;
                            traceInfo.normal = hit.normal;
                            traceInfo.collider = collider;
                            traceInfo.material = collider.GetMaterialAt(hit.point);
                            traceInfo.entity = collider.gameObject.ToBaseEntity();
                            traceInfo.bone = Model.GetTransform(collider.transform, hit.point, traceInfo.entity);
                            if (!traceInfo.entity || (traceInfo.entity.isClient && traceInfo.entity != test.ignoreEntity))
                            {
                                traces.Add(traceInfo);
                            }
                        }
                    }
                }
            }
            traces.Sort((TraceInfo a, TraceInfo b) => a.distance.CompareTo(b.distance));
            Facepunch.Pool.FreeList<RaycastHit>(ref list);
        }
    }
    public static void TraceAllTrampoline(HitTest test, List<TraceInfo> traces, int layerMask = -5)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }
    private void Movement_Walking(InputState input, ModelState modelState)
    {
        bool flag = input.IsDown(CFG.Setting.eeeeeeeee ? BUTTON.SPRINT : BUTTON.FORWARD) && (!input.IsDown(CFG.Setting.eeeeeeeee ? BUTTON.JUMP : BUTTON.LEFT) && !input.IsDown(CFG.Setting.eeeeeeeee ? BUTTON.JUMP : BUTTON.BACKWARD) && !input.IsDown(CFG.Setting.eeeeeeeee ? BUTTON.JUMP : BUTTON.RIGHT));
        if (flag)
        {
            if (input.IsDown(BUTTON.SPRINT))
            {
                if (!input.WasDown(BUTTON.SPRINT))
                {
                    gameObject.GetComponent<PlayerWalkMovement>().lastSprintTime = UnityEngine.Time.time;
                    if (gameObject.GetComponent<PlayerWalkMovement>().sprintForced)
                    {
                        gameObject.GetComponent<PlayerWalkMovement>().sprintForced = false;
                    }
                }
                if (UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().lastSprintTime > 2f)
                {
                    gameObject.GetComponent<PlayerWalkMovement>().sprintForced = true;
                }
            }
        }
        else
        {
            gameObject.GetComponent<PlayerWalkMovement>().sprintForced = false;
            gameObject.GetComponent<PlayerWalkMovement>().lastSprintTime = UnityEngine.Time.time;
        }
        base.TargetMovement = Vector3.zero;
        if (!ProgressBarUI.IsOpen())
        {
            if (input.IsDown(BUTTON.FORWARD))
            {
                base.TargetMovement += Owner.transform.forward;
            }
            if (input.IsDown(BUTTON.BACKWARD))
            {
                base.TargetMovement -= Owner.transform.forward;
            }
            if (input.IsDown(BUTTON.LEFT))
            {
                base.TargetMovement -= Owner.transform.right;
            }
            if (input.IsDown(BUTTON.RIGHT))
            {
                base.TargetMovement += Owner.transform.right;
            }
        }
        if (gameObject.GetComponent<PlayerWalkMovement>().swimming || gameObject.GetComponent<PlayerWalkMovement>().jumping || (gameObject.GetComponent<PlayerWalkMovement>().falling && UnityEngine.Time.time - gameObject.GetComponent<PlayerWalkMovement>().groundTime > 0.3f))
        {
            gameObject.GetComponent<PlayerWalkMovement>().HandleGrounded(modelState, false);
        }
        else
        {
            gameObject.GetComponent<PlayerWalkMovement>().HandleGrounded(modelState, true);
        }
        bool wantsRun = (input.IsDown(BUTTON.SPRINT) || gameObject.GetComponent<PlayerWalkMovement>().sprintForced) && flag && gameObject.GetComponent<PlayerWalkMovement>().CanSprint();
        bool wantsDuck = input.IsDown(BUTTON.DUCK);
        bool wantsJump = input.WasJustPressed(BUTTON.JUMP);
        gameObject.GetComponent<PlayerWalkMovement>().HandleRunning(modelState, wantsRun);
        gameObject.GetComponent<PlayerWalkMovement>().HandleDucking(modelState, wantsDuck);
        if (base.TargetMovement != Vector3.zero)
        {
            base.TargetMovement = base.TargetMovement.normalized * Owner.GetSpeed(base.Running, base.Ducking);
        }
        float t = Mathf.Max(gameObject.GetComponent<PlayerWalkMovement>().modify.drag, Owner.clothingMoveSpeedReduction);
        base.TargetMovement = Vector3.Lerp(base.TargetMovement, Vector3.zero, t);
        if (base.TargetMovement.magnitude < 0.1f)
        {
            base.Running = 0f;
        }
        gameObject.GetComponent<PlayerWalkMovement>().HandleJumping(modelState, wantsJump, false);

        if (CFG.Setting.flyhack)
        {
            if (LocalPlayer.Entity != null)
            {
                gameObject.GetComponent<PlayerWalkMovement>().flying = true;
                base.TargetMovement = Vector3.zero;

                if (input.IsDown(BUTTON.FORWARD))
                {
                    base.TargetMovement += Owner.eyes.BodyForward();
                }
                if (input.IsDown(BUTTON.BACKWARD))
                {
                    base.TargetMovement -= Owner.eyes.BodyForward();
                }
                if (input.IsDown(BUTTON.LEFT))
                {
                    base.TargetMovement -= Owner.eyes.BodyRight();
                }
                if (input.IsDown(BUTTON.RIGHT))
                {
                    base.TargetMovement += Owner.eyes.BodyRight();
                }
                if (input.IsDown(BUTTON.JUMP))
                {
                    base.TargetMovement += Vector3.up;
                }
            }
            float d = 6f;
            if (input.IsDown(BUTTON.DUCK))
            {
                d = 3f;
            }
            if (input.IsDown(BUTTON.SPRINT))
            {
                d = 25f;
            }
            if (base.TargetMovement != Vector3.zero)
            {
                base.TargetMovement = base.TargetMovement.normalized * d;
            }



        }
        bool tpp = CFG.Setting.df && UnityEngine.Input.GetKey(KeyCode.Z);
        if (tpp)
        {
            foreach (BasePlayer basePlayer2 in BasePlayer.VisiblePlayerList)
            {
                if (basePlayer2 != null)
                {
                    if (basePlayer2.IsLocalPlayer())
                    {

                        gameObject.GetComponent<PlayerWalkMovement>().flying = true;
                        gameObject.GetComponent<PlayerWalkMovement>().groundAngle = 0f;
                        gameObject.GetComponent<PlayerWalkMovement>().groundAngleNew = 0f;
                        gameObject.GetComponent<PlayerWalkMovement>().grounded = true;
                        gameObject.GetComponent<PlayerWalkMovement>().TeleportTo(LocalPlayer.Entity.transform.position + new Vector3(0f, 0.13f, 0f), LocalPlayer.Entity);
                    }
                }
            }
        }

    }


    private void Movement_WalkingTrampoline(InputState input, ModelState modelState)
    {
        int a = 12;
        int b = 9;
        int c = 12 * 9 - 4;
        int d = c * a - 15;
        int e = d + a;
        int f = b + c;
        a = b + 12;
        b = c - 4;
        d = a + b;
        e = a + c + d;
    }

}