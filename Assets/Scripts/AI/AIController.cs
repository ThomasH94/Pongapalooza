using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will control the left Paddle in most cases, the AI Paddle
/// by grabbing the Paddle Motor attached to this object and controlling it 
/// based on difficulty and game mode to determine how fast it goes
/// </summary>
namespace Pongapalooza
{
    public class AIController : MonoBehaviour
    {
        //Might want to group this into an interface..
        public float yMoveSpeed;

        [SerializeField]
        PaddleMotor myMotor;

        void Start()
        {
            InvokeRepeating("MoveRandom", 0.05f, 1f);
        }

        void MoveRandom()
        {
            int random = Random.Range(0,2);
            if(random == 0)
            {
                myMotor.Move(yMoveSpeed);
                Debug.Log("Moved up");
            }
            else
            {
                myMotor.Move(-yMoveSpeed);
                Debug.Log("Moved down");
            }
            
        }

    }
}