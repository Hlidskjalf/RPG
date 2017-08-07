using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Logic.States {
    public class GameState : IState {

        public StateStack stateStack { get; set; }

        public void OnEnter() {
            //Load game would go here


            UnityEngine.Object.Instantiate(Resources.Load("Hero"));

            //Add all the rooms we need
            RoomManager.AddRoom(new Room("Level 1", (GameObject)Resources.Load("Levels/level_desert")));
            RoomManager.AddRoom(new Room("Level 2", (GameObject)Resources.Load("Levels/level_1")));

            RoomManager.ChangeRoom("Level 1");

        }

        public void OnExit() {
            
        }

        public void Update() {
            
        }
    }
}
