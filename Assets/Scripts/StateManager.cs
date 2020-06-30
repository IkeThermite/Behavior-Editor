using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace SA
{
    public class StateManager : MonoBehaviour
    {
        [HideInInspector] public MovementData movementData;
        [HideInInspector] public CollisionData collisionData;
        [HideInInspector] public float delta;
        [HideInInspector] public Transform mTransform;

        public bool isGrounded;

        protected void OnStart()
        {
            mTransform = transform;
            movementData = new MovementData();
        }
        protected void OnUpdate()
        {
            delta = Time.deltaTime;
        }
        protected void OnFixedUpdate()
        {
            delta = Time.fixedDeltaTime;
        }

        #region Pure State Manager
        public State currentState;

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
        #endregion
    }

 

    public class MovementData
    {
        public float moveMagnitude;
        public Vector3 moveDirection;
        public Quaternion playerRotation;
    }

    public class CollisionData
    {

    }

}
