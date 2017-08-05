using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Room {

        public string RoomName;
        public GameObject roomData;

        public Room(string name, GameObject room) {
            RoomName = name;
            roomData = room;
        }

    }
