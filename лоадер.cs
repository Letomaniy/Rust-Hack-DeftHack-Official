using System;
using UnityEngine;
using static gg.AimBotTest2;

namespace RustInternal
{
    public class Loader
    {
        private static GameObject gameObject;


        public static void Load()
        {
			Loader.gameObject = new GameObject();
			Loader.gameObject.AddComponent<ff>();
			Loader.gameObject.AddComponent<radar2D>();
			Loader.gameObject.AddComponent<melee>();
			Loader.gameObject.AddComponent<AutoFarm2>();
			Loader.gameObject.AddComponent<AUTO>();
			Loader.gameObject.AddComponent<Players>();
			Loader.gameObject.AddComponent<friend>();
			Loader.gameObject.AddComponent<companent>();
			Loader.gameObject.AddComponent<ESP>();
			Loader.gameObject.AddComponent<HukTexture>();
			Loader.gameObject.AddComponent<menu>();
			Loader.gameObject.AddComponent<ggg>();
			Loader.gameObject.AddComponent<HACK>();
			Loader.gameObject.AddComponent<hack2>();
			UnityEngine.Object.DontDestroyOnLoad(Loader.gameObject);
			
           
        }
    }
}