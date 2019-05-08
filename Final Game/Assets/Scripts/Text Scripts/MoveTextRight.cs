using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTextRight : MonoBehaviour
{
    public float speed;
    public bool landed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 6;
        if (GameManager.gameScene == 24)
        {
            speed = 40;
        }
        landed = false;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnCollisionEnter2D()
    {
        speed = 0;
        landed = true;
    }
}
