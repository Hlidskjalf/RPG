using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class RoomManager {

    static List<Room> Rooms = new List<Room>();

    public static Room CurrentRoom;

    private static GameObject tempRoom;

    public static void AddRoom(Room room) {
        Rooms.Add(room);
    }

    public static void ChangeRoom(string roomName) {
        if (CurrentRoom != null) {
            Object.Destroy(tempRoom);
        }
       
        CurrentRoom = Rooms.Single(x => x.RoomName == roomName);
        
        tempRoom = Object.Instantiate(CurrentRoom.roomData);
        
    }
	
}
