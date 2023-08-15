using UnityEngine;
using UnityEngine.InputSystem;
public class Player : MonoBehaviour
{
	[SerializeField] PlayerInput mPlayerInput;
	[SerializeField] Dice mDicePrefab;
	[SerializeField] Vector2Int mDiceNum;
	public void Point(InputInteractionContext inContext)
	{
	}
	void SetDice()
	{
	}
}
