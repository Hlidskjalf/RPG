using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Logic.States {
    public class StateStack : MonoBehaviour {
        
        Dictionary<string, IState> mStates = new Dictionary<string, IState>();
        Stack<IState> mStack = new Stack<IState>();

        public void Update() {
            IState top = mStack.First();
            top.Update();
        }

        public void Add(string name, IState state) {
            mStates[name] = state;
            mStates[name].stateStack = this;
        }

        public void Push(String name) {
            IState state = mStates[name];
            mStack.Push(state);
            state.OnEnter();
        }

        public IState Pop() {
            mStack.First().OnExit();
            return mStack.Pop();
        }

    }
}
