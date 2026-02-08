using MelonLoader.Utils;
using UnityEngine.Rendering.PostProcessing;
using MelonLoader;
using UnityEngine;
using System.Collections;

namespace BricklayersDoorFix
{
    public class Main : MelonMod
    {
        public override void OnInitializeMelon()
        {
            //Settings.OnLoad();
        }

        public override void OnSceneWasInitialized(int buildIndex, string sceneName)
        {
            

      

            
        }

        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
                   
            if (sceneName == "BlackrockRegion")
            {

                // Enable cabin hinge
                var cabinHinge = GameObject.Find("Scene_Art/Blackrock_structures/AbandonedCabin/STR_StoneCabinA_Prefab/Hinge");
                if (cabinHinge != null)
                {
                    cabinHinge.SetActive(true);
                }


                // Disable cabin door
                var cabinDoor = GameObject.Find("Scene_Art/Blackrock_structures/AbandonedCabin/STR_StoneCabinADoor_Prefab");
                if (cabinDoor != null)
                {
                    cabinDoor.SetActive(false);
                }


                // Fill in hole
                GameObject snowFloor = GameObject.Find("TRN_RockCliff_08_Big_C_Prefab");
                Vector3 position = new Vector3(897.4969f, 230.2189f, -97.9197f);
                Vector3 rotation = new Vector3(13.0001f, 254.9626f, 353.9999f);
                Vector3 scale = new Vector3(.14f, .03f, .1f);
                SceneUtils.InstantiateObjectInScene(snowFloor, position, rotation, scale);

            }

        }
    }
}