using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class RoomLoad : MonoBehaviour {

	// Use this for initialization
	void Start () {
        string myPath = "Assets/Resources/Levels";
        DirectoryInfo dir = new DirectoryInfo(myPath);
        FileInfo[] info = dir.GetFiles("*.*");
        foreach (FileInfo f in info) {
            if (f.Extension == ".prefab") {
                string tempName = f.Name;
                //Not done
                //RoomManager.AddRoom();
            }
        }
    }

    void Update() {

    }

}
