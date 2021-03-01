using System;
using System.Reflection;
using UnityEngine;

// Token: 0x0200001B RID: 27
public static class Extensions
{
	// Token: 0x0600005C RID: 92 RVA: 0x0000765C File Offset: 0x0000585C
	public static void SetPrivateField(this object obj, string name, object value)
	{
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.NonPublic;
		obj.GetType().GetField(name, bindingAttr).SetValue(obj, value);
	}

	// Token: 0x0600005D RID: 93 RVA: 0x00007684 File Offset: 0x00005884
	public static object GetPrivateValue(Type type, object instance, string name)
	{
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		FieldInfo field = type.GetField(name, bindingAttr);
		bool flag = !(field == null);
		bool flag2 = flag;
		bool flag3 = flag2;
		object result;
		if (flag3)
		{
			result = field.GetValue(instance);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600005E RID: 94 RVA: 0x000076CC File Offset: 0x000058CC
	public static object GetFieldValue(this object instance, string fieldName)
	{
		FieldInfo field = instance.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		bool flag = !(field == null);
		bool flag2 = flag;
		bool flag3 = flag2;
		object result;
		if (flag3)
		{
			result = field.GetValue(instance);
		}
		else
		{
			result = null;
		}
		return result;
	}

	// Token: 0x0600005F RID: 95 RVA: 0x00007714 File Offset: 0x00005914
	public static void CallPrivateMethod<T>(this object obj, string name, object[] parameters)
	{
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.NonPublic;
		typeof(T).GetMethod(name, bindingAttr).Invoke(obj, null);
	}

	// Token: 0x06000060 RID: 96 RVA: 0x00007740 File Offset: 0x00005940
	public static void InvokePrivateMethod(this object obj, string name, params object[] param)
	{
		BindingFlags bindingAttr = BindingFlags.Instance | BindingFlags.NonPublic;
		obj.GetType().GetMethod(name, bindingAttr).Invoke(obj, param);
	}

	// Token: 0x06000061 RID: 97 RVA: 0x00007768 File Offset: 0x00005968
	public static bool withinViewport(this Vector2 pos)
	{
		return MainCamera.mainCamera.pixelRect.Contains(pos);
	}
}
