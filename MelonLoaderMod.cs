using MelonLoader;
using UnityEngine;

namespace LightAmmoPouch
{
    public static class BuildInfo
    {
        public const string Name = "Light Ammo Pouch";
        public const string Author = "DarkSwitchPro";
        public const string Company = null;
        public const string Version = "1.0.0";
        public const string DownloadLink = null;
    }

    public class LightAmmoPouch : MelonMod 
    {
        public override void OnSceneWasInitialized(int buildindex, string sceneName)
        {
                GameObject rig = GameObject.Find("[RigManager (Default Brett)]");
                Transform slot_container_sidearm_ammo = rig.transform.Find("[SkeletonRig (GameWorld Brett)]/Body/skull/c4Vertebra/t1Vertebra/t7Vertebra/l1Vertebra/l3Vertebra/sacrum/BeltLf1/slot_container sidearm ammo");
                slot_container_sidearm_ammo.gameObject.SetActive(true);
        }
    }
}
