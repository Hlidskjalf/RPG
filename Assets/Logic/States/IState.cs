using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logic.States {
    public interface IState {
        StateStack stateStack { get; set; }
        void Update();
        void OnEnter();
        void OnExit();
    }
}
