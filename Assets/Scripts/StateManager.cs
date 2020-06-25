using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public abstract class StateManager : MonoBehaviour
    {
        
        public State currentState;

        protected abstract void OnStart();
        protected abstract void OnUpdate();
        protected abstract void OnFixedUpdate();

        private void Start()
        {
            OnStart();
        }

        private void Update()
        {
            OnUpdate();  
            if(currentState != null)
            {
                currentState.Tick(this);
            }
        }

        private void FixedUpdate()
        {
            OnFixedUpdate();
            if (currentState != null)
            {
                currentState.FixedTick(this);
            }
        }
    }
}
