using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will use the PaddleMotor script attached to the players paddle
/// Then we will call the move method on the Paddle Motor to move the players paddle
/// </summary>
namespace Pongapalooza
{
    public class PlayerController : MonoBehaviour
    {
        public float yMoveSpeed;

        [SerializeField]
        PaddleMotor myMotor;
        // Start is called before the first frame update
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            
            if(Input.GetAxisRaw("Vertical") > 0)
            {
                myMotor.Move(yMoveSpeed);
            }
            else if(Input.GetAxisRaw("Vertical") < 0)
            {
                myMotor.Move(-yMoveSpeed);
            }
            else
            {
                myMotor.StopMoving();
            }
            
        }
    }
}