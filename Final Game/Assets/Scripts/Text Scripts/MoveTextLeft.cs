using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTextLeft : MonoBehaviour
{
    public float speed;
    public bool landed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 15;
        landed = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D()
    {
        speed = 0;
        landed = true;
    }
}
