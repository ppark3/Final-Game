using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenDoor : MonoBehaviour
{

    public ParticleSystem crash1;
    public ParticleSystem crash2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        crash1.gameObject.SetActive(true);
        crash2.gameObject.SetActive(true);
    }
}
