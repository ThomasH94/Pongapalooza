using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class will be a scriptable object that the different balls can reference to change their data
/// </summary>
namespace Pongapalooza
{
    public enum BallType
    {
        Default,
        Sticky,
        Bomb
    }
    [CreateAssetMenu(menuName = "BallData")]
    public class BallData : ScriptableObject
    {
        public float moveSpeed;
        public BallType ballType;
    }
}