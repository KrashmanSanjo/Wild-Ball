using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WindBall.Inputs;

namespace Wildball.Inputs
{
    public class Puncher : MonoBehaviour
    {
        private Vector3 punch;
        private void OnCollisionEnter(Collision collision)
        {
            punch = new Vector3(-collision.rigidbody.velocity.x, 0, -collision.rigidbody.velocity.z);
            collision.rigidbody.AddForce(punch, ForceMode.VelocityChange);
        }
    }
}