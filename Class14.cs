using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Internal;
using UnityEngine.Scripting;

	public static class ImageConversion
	{
		[GeneratedByOldBindingsGenerator]
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LoadImage(this Texture2D tex, byte[] data, [DefaultValue("false")] bool markNonReadable);

		[ExcludeFromDocs]
		public static bool LoadImage(this Texture2D tex, byte[] data)
		{
			bool markNonReadable = false;
			return tex.LoadImage(data, markNonReadable);
		}
	}

