using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppearText : MonoBehaviour
{
    public float speed;
    public bool reached;
    public bool reached2;

    public bool finish;

    public float startX;
    public float endX;

    public GameObject wall;

    // Start is called before the first frame update
    void Start()
    {
        speed = 3;
        reached = false;
        reached2 = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (finish)
        {
            reached = true;
            reached2 = true;
            transform.localPosition = new Vector3(startX, transform.localPosition.y, transform.localPosition.z);
            wall.gameObject.SetActive(false);
        }
        if (!reached)
        {
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (transform.localPosition.x >= endX)
            {
                reached = true;
            }
        }
        else if (reached && !reached2)
        {
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
            if (transform.localPosition.x <= startX)
            {
                reached2 = true;
            }
        }
        if (reached)
        {
            wall.gameObject.SetActive(false);
        }
    }
}
