using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Wildball.Inputs 
{
    [RequireComponent(typeof(Rigidbody))]
    public class PlayerMovement : MonoBehaviour
    {
        [SerializeField, Range(0, 10)] private float speed = 2.0f;
        private Rigidbody playerRigidbody;

        private void Awake()
        {
            playerRigidbody = GetComponent<Rigidbody>();
        }

        public void MoveCharacter(Vector3 movement)
        {
            playerRigidbody.AddForce(movement * speed);
        }

        private void Update()
        {
            Debug.Log(playerRigidbody.velocity);
        }

#if unity_Editor
        [ContextMenu("Reset Values")]
        public void ResetValeues()
        {
            speed = 2;
        }
#endif
    }
}
