using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

using ProtoBuf;

using UnityEngine;

// Token: 0x02000017 RID: 23
internal class HOOK
{
    // Token: 0x17000004 RID: 4
    // (get) Token: 0x0600004D RID: 77 RVA: 0x00002202 File Offset: 0x00000402
    // (set) Token: 0x0600004E RID: 78 RVA: 0x0000220A File Offset: 0x0000040A
    public MethodInfo OriginalMethod { get; private set; }

    // Token: 0x17000005 RID: 5
    // (get) Token: 0x0600004F RID: 79 RVA: 0x00002213 File Offset: 0x00000413
    // (set) Token: 0x06000050 RID: 80 RVA: 0x0000221B File Offset: 0x0000041B
    public MethodInfo HookMethod { get; private set; }

    // Token: 0x17000006 RID: 6
    // (get) Token: 0x06000051 RID: 81 RVA: 0x00002224 File Offset: 0x00000424
    // (set) Token: 0x06000052 RID: 82 RVA: 0x0000222C File Offset: 0x0000042C
    public MethodInfo OriginalNew { get; private set; }

    // Token: 0x06000053 RID: 83 RVA: 0x00006564 File Offset: 0x00004764
    public HOOK()
    {
        original = null;
        OriginalMethod = (HookMethod = null);
    }

    // Token: 0x06000054 RID: 84 RVA: 0x00002235 File Offset: 0x00000435
    public HOOK(MethodInfo orig, MethodInfo hook, MethodInfo orignew)
    {
        original = null;
        Init(orig, hook, orignew);
    }

    // Token: 0x06000055 RID: 85 RVA: 0x00006594 File Offset: 0x00004794
    public HOOK(Type typeOrig, string nameOrig, Type typeHook, string nameHook, Type typeOrigNew, string nameOrigNew, byte[] orig)
    {
        original = new byte[orig.Length];
        original = orig;
        bool flag = nameOrig == "DoHit";
        bool flag2 = flag;
        if (flag2)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(HitTest),
                typeof(Vector3),
                typeof(Vector3)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(HitTest),
                typeof(Vector3),
                typeof(Vector3)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(HitTest),
                typeof(Vector3),
                typeof(Vector3)
            }, null));
        }
        bool flag3 = nameOrig == "GetMinSpeed";
        bool flag4 = flag3;
        if (flag4)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag5 = nameOrig == "OnRequestUserInformation";
        bool flag6 = flag5;
        if (flag6)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag7 = nameOrig == "OnLand";
        bool flag8 = flag7;
        if (flag8)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag9 = nameOrig == "AddPunch";
        bool flag10 = flag9;
        if (flag10)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag11 = nameOrig == "SendClientTick";
        bool flag12 = flag11;
        if (flag12)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag13 = nameOrig == "GetAimCone";
        bool flag14 = flag13;
        if (flag14)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag15 = nameOrig == "SetTimedAction";
        bool flag16 = flag15;
        if (flag16)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag17 = nameOrig == "GetIndexedSpreadScalar";
        bool flag18 = flag17;
        if (flag18)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag19 = nameOrig == "UpdateMovementPenalty";
        bool flag20 = flag19;
        if (flag20)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag21 = nameOrig == "UpdateClothesIfNeeded";
        bool flag22 = flag21;
        if (flag22)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag23 = nameOrig == "ClientInput";
        bool flag24 = flag23;
        if (flag24)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag25 = nameOrig == "GetSpeed";
        bool flag26 = flag25;
        if (flag26)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(float),
                typeof(float)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(float),
                typeof(float)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(float),
                typeof(float)
            }, null));
        }
        bool flag27 = nameOrig == "CanAttack";
        bool flag28 = flag27;
        if (flag28)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag29 = nameOrig == "HasLocalControls";
        bool flag30 = flag29;
        if (flag30)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag31 = nameOrig == "UpdateAmbient";
        bool flag32 = flag31;
        if (flag32)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag33 = nameOrig == "OnAttacked";
        bool flag34 = flag33;
        if (flag34)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(HitInfo)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(HitInfo)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(HitInfo)
            }, null));
        }
        bool flag35 = nameOrig == "CreateOrUpdateEntity";
        bool flag36 = flag35;
        if (flag36)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Entity),
                typeof(long)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Entity),
                typeof(long)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Entity),
                typeof(long)
            }, null));
        }
        bool flag37 = nameOrig == "UpdatePositionFromNetwork";
        bool flag38 = flag37;
        if (flag38)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(Vector3)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(Vector3)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public, null, new Type[]
            {
                typeof(Vector3)
            }, null));
        }
        bool flag39 = nameOrig == "IsDead";
        bool flag40 = flag39;
        if (flag40)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag41 = nameOrig == "CreateProjectile" && object.Equals(typeOrig, typeof(global::BaseProjectile));
        bool flag42 = flag41;
        if (flag42)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(Vector3),
                typeof(Vector3),
                typeof(Vector3)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(Vector3),
                typeof(Vector3),
                typeof(Vector3)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(Vector3),
                typeof(Vector3),
                typeof(Vector3)
            }, null));
        }
        bool flag43 = nameOrig == "CreateProjectile" && object.Equals(typeOrig, typeof(BaseMelee));
        bool flag44 = flag43;
        if (flag44)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(Vector3),
                typeof(Vector3),
                typeof(Vector3)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(Vector3),
                typeof(Vector3),
                typeof(Vector3)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(Vector3),
                typeof(Vector3),
                typeof(Vector3)
            }, null));
        }
        bool flag45 = nameOrig == "SendProjectileAttack";
        bool flag46 = flag45;
        if (flag46)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag47 = nameOrig == "OnDeploy";
        bool flag48 = flag47;
        if (flag48)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag49 = nameOrig == "UpdateAmbient";
        bool flag50 = flag49;
        if (flag50)
        {
            Init(typeOrig.GetMethod(nameOrig), typeHook.GetMethod(nameHook), typeOrigNew.GetMethod(nameOrigNew));
        }
        bool flag51 = nameOrig == "get_isAlive";
        bool flag52 = flag51;
        if (flag52)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.NonPublic, null, new Type[0], null));
        }
        bool flag53 = nameOrig == "CanJump";
        bool flag54 = flag53;
        if (flag54)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
        }
        bool flag55 = nameOrig == "StartAttackCooldown";
        bool flag56 = flag55;
        if (flag56)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(float)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(float)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(float)
            }, null));
        }
        bool flag57 = nameOrig == "Update" && nameHook == "EnvSyncUpdate";
        bool flag58 = flag57;
        if (flag58)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
        }
        bool flag59 = nameOrig == "ServerRPC";
        bool flag60 = flag59;
        if (flag60)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(object),
                typeof(object),
                typeof(object),
                typeof(object),
                typeof(object)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(object),
                typeof(object),
                typeof(object),
                typeof(object),
                typeof(object)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(string),
                typeof(object),
                typeof(object),
                typeof(object),
                typeof(object),
                typeof(object)
            }, null));
        }
        bool flag61 = nameOrig == "OnTextureWasEdited";
        bool flag62 = flag61;
        if (flag62)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Texture2D)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Texture2D)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Texture2D)
            }, null));
        }
        bool flag63 = nameOrig == "DrawTexture";
        bool flag64 = flag63;
        if (flag64)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Vector2),
                typeof(float),
                typeof(float),
                typeof(Texture2D),
                typeof(Color)
            }, null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Vector2),
                typeof(float),
                typeof(float),
                typeof(Texture2D),
                typeof(Color)
            }, null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[]
            {
                typeof(Vector2),
                typeof(float),
                typeof(float),
                typeof(Texture2D),
                typeof(Color)
            }, null));
        }
        bool flag65 = nameOrig == "CanTalk";
        bool flag66 = flag65;
        if (flag66)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
        }
        bool flag67 = nameOrig == "ShouldReceiveVoice";
        bool flag68 = flag67;
        if (flag68)
        {
            Init(typeOrig.GetMethod(nameOrig, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeHook.GetMethod(nameHook, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null), typeOrigNew.GetMethod(nameOrigNew, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic, null, new Type[0], null));
        }
    }

    // Token: 0x06000056 RID: 86 RVA: 0x000073A8 File Offset: 0x000055A8
    public void Init(MethodInfo orig, MethodInfo hook, MethodInfo orignew)
    {
        bool flag = object.Equals(orig, null);
        bool flag2 = flag;
        if (flag2)
        {
            throw new ArgumentException("Original method is null");
        }
        bool flag3 = object.Equals(hook, null);
        bool flag4 = flag3;
        if (flag4)
        {
            throw new ArgumentException("Hook method is null");
        }
        RuntimeHelpers.PrepareMethod(orig.MethodHandle);
        RuntimeHelpers.PrepareMethod(hook.MethodHandle);
        RuntimeHelpers.PrepareMethod(orignew.MethodHandle);
        OriginalMethod = orig;
        HookMethod = hook;
        OriginalNew = orignew;
    }

    // Token: 0x06000057 RID: 87 RVA: 0x00007424 File Offset: 0x00005624
    public unsafe void Hook()
    {
        bool flag = object.Equals(OriginalMethod, null) || object.Equals(HookMethod, null);
        bool flag2 = flag;
        if (flag2)
        {
            throw new ArgumentException("Hook has to be properly Init'd before use");
        }
        IntPtr functionPointer = OriginalMethod.MethodHandle.GetFunctionPointer();
        IntPtr functionPointer2 = HookMethod.MethodHandle.GetFunctionPointer();
        IntPtr functionPointer3 = OriginalNew.MethodHandle.GetFunctionPointer();
        HOOK.Import.VirtualProtect(functionPointer3, (uint)(original.Length + 12), 64U, out uint newProtect);
        byte* ptr = (byte*)((void*)functionPointer3);
        for (int i = 0; i < original.Length; i++)
        {
            ptr[i] = original[i];
        }
        ptr[original.Length] = 72;
        (ptr + original.Length)[1] = 184;
        *(IntPtr*)(ptr + original.Length + 2) = (IntPtr)(functionPointer.ToInt64() + original.Length);
        (ptr + original.Length)[10] = byte.MaxValue;
        (ptr + original.Length)[11] = 224;
        HOOK.Import.VirtualProtect(functionPointer3, (uint)(original.Length + 12), newProtect, out newProtect);
        HOOK.Import.VirtualProtect(functionPointer, 12U, 64U, out newProtect);
        byte* ptr2 = (byte*)((void*)functionPointer);
        *ptr2 = 72;
        ptr2[1] = 184;
        *(IntPtr*)(ptr2 + 2) = functionPointer2;
        ptr2[10] = byte.MaxValue;
        ptr2[11] = 224;
        HOOK.Import.VirtualProtect(functionPointer, 12U, newProtect, out newProtect);
    }

    // Token: 0x06000058 RID: 88 RVA: 0x000075C0 File Offset: 0x000057C0
    public unsafe void Unhook()
    {
        IntPtr functionPointer = OriginalMethod.MethodHandle.GetFunctionPointer();
        IntPtr functionPointer2 = HookMethod.MethodHandle.GetFunctionPointer();
        IntPtr functionPointer3 = OriginalNew.MethodHandle.GetFunctionPointer();
        HOOK.Import.VirtualProtect(functionPointer, 12U, 64U, out uint newProtect);
        byte* ptr = (byte*)((void*)functionPointer);
        for (int i = 0; i < original.Length; i++)
        {
            ptr[i] = original[i];
        }
        HOOK.Import.VirtualProtect(functionPointer, 12U, newProtect, out newProtect);
    }

    // Token: 0x04000067 RID: 103
    private readonly byte[] original;

    // Token: 0x02000018 RID: 24
    internal class Import
    {
        // Token: 0x06000059 RID: 89
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern bool VirtualProtect(IntPtr address, uint size, uint newProtect, out uint oldProtect);

        // Token: 0x0600005A RID: 90
        [DllImport("kernel32.dll", SetLastError = true)]
        internal static extern IntPtr VirtualAlloc(uint lpAddress, uint dwSize, HOOK.Import.AllocationType lAllocationType, HOOK.Import.MemoryProtection flProtect);

        // Token: 0x02000019 RID: 25
        [Flags]
        public enum AllocationType
        {
            // Token: 0x04000069 RID: 105
            Commit = 4096,
            // Token: 0x0400006A RID: 106
            Reserve = 8192,
            // Token: 0x0400006B RID: 107
            Decommit = 16384,
            // Token: 0x0400006C RID: 108
            Release = 32768,
            // Token: 0x0400006D RID: 109
            Reset = 524288,
            // Token: 0x0400006E RID: 110
            Physical = 4194304,
            // Token: 0x0400006F RID: 111
            TopDown = 1048576,
            // Token: 0x04000070 RID: 112
            WriteWatch = 2097152,
            // Token: 0x04000071 RID: 113
            LargePages = 536870912
        }

        // Token: 0x0200001A RID: 26
        [Flags]
        public enum MemoryProtection : uint
        {
            // Token: 0x04000073 RID: 115
            EXECUTE = 16U,
            // Token: 0x04000074 RID: 116
            EXECUTE_READ = 32U,
            // Token: 0x04000075 RID: 117
            EXECUTE_READWRITE = 64U,
            // Token: 0x04000076 RID: 118
            EXECUTE_WRITECOPY = 128U,
            // Token: 0x04000077 RID: 119
            NOACCESS = 1U,
            // Token: 0x04000078 RID: 120
            READONLY = 2U,
            // Token: 0x04000079 RID: 121
            READWRITE = 4U,
            // Token: 0x0400007A RID: 122
            WRITECOPY = 8U,
            // Token: 0x0400007B RID: 123
            GUARD_Modifierflag = 256U,
            // Token: 0x0400007C RID: 124
            NOCACHE_Modifierflag = 512U,
            // Token: 0x0400007D RID: 125
            WRITECOMBINE_Modifierflag = 1024U
        }
    }
}
