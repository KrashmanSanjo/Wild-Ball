using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using WindBall.Inputs;

namespace Wildball.Inputs
{
    public class Puncher : MonoBehaviour
    {
        private float punch = 10;
        private void OnCollisionEnter(Collision collision)
        {
            collision.rigidbody.AddForce(10, 0, 10, ForceMode.Impulse);
        }
    }
}