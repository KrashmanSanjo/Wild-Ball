using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    private Animator anim;
    private Rigidbody rb;
    public Transform player;
    public float radius;
    [SerializeField, Range(0, 10)] private float aggroRadius = 10;
    [SerializeField, Range(0, 1)] private float speed = 0.1f;

    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Vector3.Distance(transform.position, player.position) < aggroRadius)
        {
            transform.LookAt(player);
            transform.position = Vector3.MoveTowards(transform.position, player.position, speed);
        }
        anim.SetFloat("Velocity", rb.velocity.magnitude);
        Debug.Log(rb.velocity.magnitude);

    }
}
