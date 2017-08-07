using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Logic.Battles {
    public class BattleEntity {

        public bool isDead;

        public int Health { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int Speed { get; set; }

        private int _timer;

        

        public bool CanAct() {
            if (_timer < 50) {
                return false;
            }
            else {
                _timer = 0;
                return true;
            }
        }

        public virtual void Action() { }

        public void AddTick() {
            _timer += Speed;
        }


    }
}
