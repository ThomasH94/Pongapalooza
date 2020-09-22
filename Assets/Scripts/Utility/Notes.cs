using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The purpose of this class is to be attached to a gameobject so you can
/// provide notes to the designer so they don't have to look at the code
/// to check for what this object does, what components it needs, it's 
/// dependencies, etc.
/// </summary>
namespace Pongapalooza
{
    public class Notes : MonoBehaviour
    {
        [TextArea]
        public string GameObjectNotes;
    }    
}