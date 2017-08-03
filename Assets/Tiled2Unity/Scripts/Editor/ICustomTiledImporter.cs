using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Tiled2Unity
{
    public interface ICustomTiledImporter
    {
        // A game object within the prefab has some custom properites assigned through Tiled that are not consumed by Tiled2Unity
        // This callback gives customized importers a chance to react to such properites.
        void HandleCustomProperties(GameObject gameObject, IDictionary<string, string> customProperties);

        // Called just before the prefab is saved to the asset database
        // A last chance opporunity to modify it through script
        void CustomizePrefab(GameObject prefab);
    }
}

//This is where we can create our own custom prefabs based off different bits of info in Tiled
[Tiled2Unity.CustomTiledImporter]
class CustomImporterAddComponent : Tiled2Unity.ICustomTiledImporter
{
    public void HandleCustomProperties(UnityEngine.GameObject gameObject,
        IDictionary<string, string> props)
    {
        // Simply add a component to our GameObject
        if (props.ContainsKey("Teleporter"))
        {
            string s = props["Teleporter"];
            Door d = gameObject.AddComponent<Door>();
            d.GotoRoom = s.Split(',')[0];
            d.RoomPosition = new Vector2(float.Parse(s.Split(',')[1]), float.Parse(s.Split(',')[2]));
        }
    }


    public void CustomizePrefab(GameObject prefab)
    {
        // Do nothing
    }
}
