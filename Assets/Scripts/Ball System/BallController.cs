using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script is responisble for controlling the ball using the BallData scriptable object
/// we provide to populate our fields to determine which ball we have
/// </summary>
namespace Pongapalooza
{
    //Helper ENUM to decide who currently owns the ball for scoring points    
    public enum BallOwner
    {
        Player,
        AI,
        None
    }

    public class BallController : MonoBehaviour
    {
        public BallData data;
        public BallOwner owner;
        private BallType ballType;
        public float ballSpeed;
        [SerializeField]
        private Rigidbody2D rb2D;

        void Start()
        {
            rb2D.velocity = new Vector2(6f, 0f);
            ballSpeed = data.moveSpeed;
            owner = BallOwner.None;
        }

        float HitFactorY(Vector2 currentBallPos, Vector2 currentPaddlePos, float currentPaddleHeight) 
        {
            //Collision
            // ||  1 : Top of Paddle
            // ||  0 : Middle of Paddle
            // || -1 : Bottom of Paddle
            return (currentBallPos.y - currentPaddlePos.y) / currentPaddleHeight;
        }

        void OnCollisionEnter2D(Collision2D col) 
        {
            //If the ball collides with a racket, then col is a paddle

            //Hit the left paddle
            if (col.gameObject.name == "LeftPaddle") 
            {
                //Calculate hit strength
                float y = HitFactorY(transform.position, col.transform.position,
                                    col.collider.bounds.size.y);

                //Calculate direction, make length=1 via .normalized
                Vector2 dir = new Vector2(1, y).normalized;

                // Set Velocity with dir * speed
                rb2D.velocity = dir * ballSpeed;
            }

            //Hit the right paddle
            if (col.gameObject.name == "RightPaddle") 
            {
                //Calculate hit strength
                float y = HitFactorY(transform.position, col.transform.position,
                                    col.collider.bounds.size.y);

                // Calculate direction, make length = 1 with .normalized
                Vector2 dir = new Vector2(-1, y).normalized;

                // Set Velocity with dir * speed
                rb2D.velocity = dir * ballSpeed;
            }

        }
    }
}