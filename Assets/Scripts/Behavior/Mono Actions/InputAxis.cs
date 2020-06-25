using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
    [CreateAssetMenu(menuName = "Actions/Mono Actions/Get Input Axis")]
    public class InputAxis : Action
    {
        public string targetString;
        public float value;

        public override void Execute()
        {
            value = Input.GetAxis(targetString);
        }
    }
}
