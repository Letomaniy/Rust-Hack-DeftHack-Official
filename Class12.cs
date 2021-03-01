using System;
using System.Collections.Generic;
using UnityEngine;


	// Token: 0x02000008 RID: 8
	public static class Bones
	{
		// Token: 0x0600001C RID: 28 RVA: 0x000031C8 File Offset: 0x000013C8
		static Bones()
		{
			Bones.boneList[0] = "head";
			Bones.boneList[1] = "neck";
			Bones.boneList[2] = "spine1";
			Bones.boneList[3] = "pelvis";
			Bones.boneList[4] = "l_upperarm";
			Bones.boneList[5] = "l_forearm";
			Bones.boneList[6] = "l_hand";
			Bones.boneList[7] = "r_upperarm";
			Bones.boneList[8] = "r_forearm";
			Bones.boneList[9] = "r_hand";
			Bones.boneList[10] = "l_hip";
			Bones.boneList[11] = "l_knee";
			Bones.boneList[12] = "l_foot";
			Bones.boneList[13] = "r_hip";
			Bones.boneList[14] = "r_knee";
			Bones.boneList[15] = "r_foot";
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000032F8 File Offset: 0x000014F8
		public static Vector3[] GetBonePositions(this BasePlayer player)
		{
			Vector3[] array = new Vector3[Bones.boneList.Count];
			for (int i = 0; i < Bones.boneList.Count; i++)
			{
				array[i] = player.playerModel.FindBone(Bones.boneList[i]).position;
			}
			return array;
		}

		// Token: 0x0400000C RID: 12
		public static Dictionary<int, string> boneList = new Dictionary<int, string>();
	}

