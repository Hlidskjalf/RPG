using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Logic.Battles {
    public class Battle {

        List<BattleEntity> _entities;

        float _timer;

        public Battle(List<BattleEntity> ents) {
            _entities = ents;
        }

        public void Update() {
            _timer += Time.deltaTime * 1000;
            //Debug.Log(_timer);
            //By rights, should update every 100 milliseconds
            if (_timer > 1000) {
                foreach(BattleEntity e in _entities) {
                    e.Action();
                    Debug.Log(_entities.Count);
                }
                _timer = 0;
            }

        }
        



    }
}
