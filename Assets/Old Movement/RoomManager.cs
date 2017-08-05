using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public static class RoomManager {

    static List<Room> Rooms;

    public static Room CurrentRoom;

    public static void AddRoom(Room room) {
        Rooms.Add(room);
    }

    public static void ChangeRoom(string roomName) {
        CurrentRoom = Rooms.Single(x => x.RoomName == roomName);
        Object.Instantiate(CurrentRoom.roomData);
    }
	
}
