using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class inherits from the BallController to create a custom Bomb Ball
/// This bomb will start to countdown after being hit and the player has to
/// Score before it explodes. If the player gets hit when it explodes they lose a point,
/// unless it hits the enemy, then the player gains a point
/// </summary>
namespace Pongapalooza
{
    public class BombBall : BallController
    {
        private BallType balltype = BallType.Bomb;
        //How long the ball lives before going off
        private float explosionTimer;
        private GameObject explosionFX; //Make this a particle system

        void Start()
        {
            explosionTimer = Random.Range(10f, 15f);
        }
    }
}