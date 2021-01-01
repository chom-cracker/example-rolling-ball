using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RolllingBall : MonoBehaviour
{
    public float speed = 3f;

    public Rigidbody rigid;
    public float horizontal;
    public float vertical;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, 0.0f, vertical);

        rigid.AddForce(direction * speed);
    }
}
