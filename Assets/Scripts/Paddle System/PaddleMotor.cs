using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will move the Paddle
/// Because we have a player and AI, this class will be controller by either
/// the player or the AI using their respective controllers
/// </summary>
namespace Pongapalooza
{
    public class PaddleMotor : MonoBehaviour
    {
        [SerializeField]
        private Rigidbody2D rb2D;

        // Update is called once per frame
        void Update()
        {
        }

        //Should only need to move up and down
        public void Move(float ySpeed)
        {
            rb2D.velocity = new Vector2(0f, 1f * ySpeed);
        }

        public void StopMoving()
        {
            rb2D.velocity = Vector2.zero;
        }
    }   
}
