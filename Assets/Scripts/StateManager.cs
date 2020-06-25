using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public class StateManager : MonoBehaviour
    {
        
        public State currentState;

        protected void OnStart()
        {

        }
        protected void OnUpdate()
        {

        }
        protected void OnFixedUpdate()
        {

        }

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
