using System.Collections; 
using System.Collections.Generic;
using UnityEngine;

public class SequenceAnimator : MonoBehaviour
{

    List<Animator> animators;

    // Start is called before the first frame update
    void Start()
    {
        animators = new List<Animator>(GetComponentsInChildren<Animator>());

        StartCoroutine(DoAnimation());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator DoAnimation()
    {
        while (true)
        {
            foreach(var animator in animators)
            {
                animator.SetTrigger("DoAnimation");
                yield return new WaitForSeconds(0.05f);
            }
            yield return new WaitForSeconds(1f);

        }
    }
}
