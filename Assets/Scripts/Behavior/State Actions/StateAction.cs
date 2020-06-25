using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    public abstract class StateAction<T> : ScriptableObject where T : StateManager
    {
        public abstract void Execute(T state);
    }
}
