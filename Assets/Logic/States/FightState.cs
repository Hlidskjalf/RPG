using Assets.Logic.Battles;
using Logic.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Logic.States {
    public class FightState : IState {

        public StateStack stateStack { get; set; }

        Battle _battle;

        public void OnEnter() {
            List<BattleEntity> combats = new List<BattleEntity>() {
                new HeroEntity(100,1,1,25), new EnemyEntity(100,1,1,50)
            };
            _battle = new Battle(combats);
        }

        public void OnExit() {
            
        }

        public void Update() {
            if (_battle != null)
            _battle.Update();
        }
    }
}
