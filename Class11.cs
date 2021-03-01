using System;
using System.Collections;
using System.Collections.Generic;
using ConVar;
using UnityEngine;
using Facepunch;
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
	DumbHook instantloot;
	public void SetTimedAction(float time, Action action)
	{
		gameObject.GetComponent<ItemIcon>().timedAction = action;
		gameObject.GetComponent<ItemIcon>().timedActionTime = new Vector2?(new Vector2(UnityEngine.Time.realtimeSinceStartup, UnityEngine.Time.realtimeSinceStartup + time));
		base.Invoke("RunTimedAction", time);
		time = 0f;
	}

	public void SetTimedActionTrampoline(float time, Action action)
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
	public void OnPointerEnterTrampoline( )
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
	}


	private void Update()
	{
	
		bool flag = LocalPlayer.Entity != null;
		if (flag)
		{
			if (menu.adf && UnityEngine.Input.GetKeyDown(KeyCode.Plus) || UnityEngine.Input.GetKey(KeyCode.Mouse4) || UnityEngine.Input.GetKey(KeyCode.Mouse3) || UnityEngine.Input.GetKey(KeyCode.Mouse5))
			{
				foreach (BuildingPrivlidge t in companent.tcshit)
				{
					if (t != null)
					{
						if (menu.adf && Vector3.Distance(t.transform.position, LocalPlayer.Entity.transform.position) < 12f && !t.IsDead())
						{
							t.gameObject.transform.position = new Vector3(LocalPlayer.Entity.eyes.HeadForward().x + LocalPlayer.Entity.transform.position.x + LocalPlayer.Entity.eyes.BodyForward().x, LocalPlayer.Entity.eyes.HeadForward().y + LocalPlayer.Entity.transform.position.y + LocalPlayer.Entity.eyes.BodyForward().y, LocalPlayer.Entity.eyes.HeadForward().z + LocalPlayer.Entity.transform.position.z + LocalPlayer.Entity.eyes.BodyForward().z);
						}
					}
				}
			
			}

			if (menu.adf1 && UnityEngine.Input.GetKeyDown(KeyCode.Plus) || UnityEngine.Input.GetKey(KeyCode.Mouse4) || UnityEngine.Input.GetKey(KeyCode.Mouse3) || UnityEngine.Input.GetKey(KeyCode.Mouse5))
			{

				UpdateLookAt();
				GameObject gameObject = At;
				if (menu.adf1 && gameObject != null)
				{
					if (gameObject.name.Contains("wood") || gameObject.name.Contains("furnace") || gameObject.name.Contains("cupboard"))
					{
						Vector3 a = gameObject.transform.position - LocalPlayer.Entity.transform.position;
						a.Normalize();
						gameObject.transform.position -= a / 3f;
					}
				}
			}
		}
	}
	public static void UpdateLookAt()
	{
		RaycastHit Hit = default(RaycastHit);
		
		if (UnityEngine.Physics.Raycast(LocalPlayer.Entity.eyes.HeadRay(), out Hit))
		{
			Point = Hit.point;
			At = Hit.transform.gameObject;
		}
	}
	public static GameObject At;
	public static Vector3 Point = Vector3.zero;
	DumbHook boredasf1111111;
	DumbHook f; DumbHook boredasf11111111;
	public static void TraceAll(HitTest test, List<TraceInfo> traces, int layerMask = -5)
	{
		 
			layerMask &= menu.grass ? -2097153 : -5;

		layerMask &= menu.grass ? -8388609 : -5;
		layerMask &= menu.grass ? -65537 : -5;

		if (menu.grass ? test.HitMaterial != "Flesh" : true)
		{
			List<RaycastHit> list = Facepunch.Pool.GetList<RaycastHit>();
			Vector3 origin = test.AttackRay.origin;
			Vector3 direction = test.AttackRay.direction;
			float maxDistance = test.MaxDistance;
			float radius = test.Radius;
			if ((layerMask & 16384) != 0)
			{
				layerMask &= -16385;
				GamePhysics.TraceAll(new Ray(origin - direction * 5f, direction), radius, list, maxDistance + 5f, 16384, QueryTriggerInteraction.UseGlobal);
				for (int i = 0; i < list.Count; i++)
				{
					RaycastHit value = list[i];
					value.distance -= 5f;
					list[i] = value;
				}
			}
			GamePhysics.TraceAll(new Ray(origin, direction), radius, list, maxDistance, layerMask, QueryTriggerInteraction.UseGlobal);
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
	private void Movement_Walking(InputState input, ModelState modelState, float fTickRate)
	{

		gameObject.GetComponent<PlayerWalkMovement>().sprintForced = menu.nnnn ? true : false;
		bool flag =  input.IsDown(CFG.Misc.eeeeeeeee ? BUTTON.SPRINT : BUTTON.FORWARD) && !input.IsDown(CFG.Misc.eeeeeeeee ? BUTTON.JUMP : BUTTON.LEFT) && !input.IsDown(CFG.Misc.eeeeeeeee ? BUTTON.JUMP : BUTTON.BACKWARD) && !input.IsDown(CFG.Misc.eeeeeeeee ? BUTTON.JUMP : BUTTON.RIGHT);
		if (flag)
		{
			if (input.IsDown(BUTTON.SPRINT))
			{
				if (!input.WasDown(BUTTON.SPRINT))
				{
					gameObject.GetComponent<PlayerWalkMovement>().lastSprintTime = UnityEngine.Time.time;
					if (gameObject.GetComponent<PlayerWalkMovement>().sprintForced)
					{
						gameObject.GetComponent<PlayerWalkMovement>().sprintForced = menu.nnnn ? true : false;
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
			gameObject.GetComponent<PlayerWalkMovement>().sprintForced =menu.nnnn ? true : false;
			gameObject.GetComponent<PlayerWalkMovement>().lastSprintTime = UnityEngine.Time.time;
		}
		base.TargetMovement = Vector3.zero;
		if (!ProgressBarUI.IsOpen())
		{
			if (input.IsDown(BUTTON.FORWARD))
			{
				base.TargetMovement += this.Owner.transform.forward;
			}
			if (input.IsDown(BUTTON.BACKWARD))
			{
				base.TargetMovement -= this.Owner.transform.forward;
			}
			if (input.IsDown(BUTTON.LEFT))
			{
				base.TargetMovement -= this.Owner.transform.right;
			}
			if (input.IsDown(BUTTON.RIGHT))
			{
				base.TargetMovement += this.Owner.transform.right;
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
			base.TargetMovement = base.TargetMovement.normalized * this.Owner.GetSpeed(base.Running, base.Ducking);
		}
		base.TargetMovement = Vector3.Lerp(base.TargetMovement, Vector3.zero, gameObject.GetComponent<PlayerWalkMovement>().modify.drag);
		if (base.TargetMovement.magnitude < 0.1f)
		{
			base.Running = 0f;
		}
		gameObject.GetComponent<PlayerWalkMovement>().HandleJumping(modelState, wantsJump, false);
	}
	
    private void Movement_WalkingTrampoline(InputState input, ModelState modelState, float fTickRate)
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