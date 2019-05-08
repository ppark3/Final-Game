using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SizePop : MonoBehaviour
{
    public TMP_Text m;
    public bool displayed;
    public float zoopTime;

    public int startFontSize;
    public int endFontSize;

    public Coroutine theCoroutine;

    // Start is called before the first frame update
    void Start()
    {
        displayed = false;
    }

    void OnEnable()
    {
        m = gameObject.GetComponent<TMP_Text>();
        theCoroutine = StartCoroutine(Zoop(m));
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Zoop(TMP_Text textComponent)
    {
        zoopTime = 0.4f;
        if (GameManager.gameScene == 23)
        {
            zoopTime = 1f;
        }
        for (float t = 0.0f; t < zoopTime; t += Time.deltaTime)
        {
            m.fontSize = Mathf.Lerp(startFontSize, endFontSize, Mathf.Min(1, t / zoopTime));
            yield return null;
        }
        for (float t = 0.0f; t < zoopTime; t += Time.deltaTime)
        {
            m.fontSize = Mathf.Lerp(endFontSize, startFontSize, Mathf.Min(1, t / zoopTime));
            yield return null;
        }
        m.fontSize = startFontSize;
        displayed = true;
    }

    public void Stop()
    {
        StopCoroutine(theCoroutine);
        m.fontSize = startFontSize;
        displayed = true;
    }
}
