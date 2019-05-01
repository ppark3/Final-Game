using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VibrateText : MonoBehaviour
{
    public bool shaking = false;
    public float shakeAmt;

    // Start is called before the first frame update
    void Start()
    {
        shakeAmt = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (shaking)
        {
            Vector3 newPos = Random.insideUnitSphere * (Time.deltaTime * shakeAmt);
            newPos.y = 0;
            newPos.z = 0;

            transform.position += newPos;
        }
    }

    void Awake()
    {
        //StartCoroutine(ShakeNow());
        shaking = true;
    }

    public void ShakeMe()
    {
        //StartCoroutine(ShakeNow());
    }

    /*IEnumerator ShakeNow()
    {
        Vector3 originalPosition = transform.position;

        if (!shaking)
        {
            shaking = true;
        }
        yield return new WaitForSeconds(10f);

        shaking = false;
        transform.position = originalPosition;
    }*/
}
