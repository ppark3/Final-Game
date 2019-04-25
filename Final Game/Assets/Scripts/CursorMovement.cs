using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorMovement : MonoBehaviour
{
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A) && GetComponent<Transform>().position.x > -7.7)
        {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) && GetComponent<Transform>().position.x < 7.7)
        {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W) && GetComponent<Transform>().position.y < 4.58)
        {
            gameObject.transform.Translate(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S) && GetComponent<Transform>().position.y > -4.58)
        {
            gameObject.transform.Translate(Vector3.down * speed * Time.deltaTime);
        }
    }
}
