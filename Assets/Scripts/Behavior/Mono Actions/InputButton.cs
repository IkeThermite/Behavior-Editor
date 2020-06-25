using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SA
{
	[CreateAssetMenu(menuName = "Actions/Mono Actions/Get Input Button")]
	public class InputButton : Action
	{
		public string targetInput;
		public KeyState keyState;
		public bool isPressed;

		public override void Execute()
		{
			switch (keyState)
			{
				case KeyState.onDown:
					isPressed = Input.GetButtonDown(targetInput);
					break;
				case KeyState.onHeld:
					isPressed = Input.GetButton(targetInput);
					break;
				case KeyState.onUp:
					isPressed = Input.GetButtonUp(targetInput);
					break;
				default:
					break;
			}
		}

		public enum KeyState
		{
			onDown,onHeld,onUp
		}
	}
}
