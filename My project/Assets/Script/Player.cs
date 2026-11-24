using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
   [SerializeField] float dodgeSpeed = 0.2f; //speed dodge movement right and left
   [SerializeField] float pushSpeed = 0.2f; //speed push movement forward and backward

    void Update()
    {
        float dodge = 0f; //starting value for dodge movement
        float push = 0f; //starting value for push movement

        if (Keyboard.current.wKey.isPressed)
        {
            push = 0.1f; // Move forward
        }
        
        if (Keyboard.current.sKey.isPressed)
        {
            push = - 0.1f; // Move backward
        }

        if (Keyboard.current.aKey.isPressed)
        {
            dodge = -0.1f; // Move left
        }

        if (Keyboard.current.dKey.isPressed)
        {
            dodge = 0.1f; // Move right
        }

     transform.Translate(dodgeSpeed * dodge, pushSpeed * push, 0);   //move player
    }
}
