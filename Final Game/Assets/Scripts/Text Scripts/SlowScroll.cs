using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SlowScroll : MonoBehaviour
{
    public TMP_Text m_TextComponent;
    public bool displayed;
    public bool isTyping;
    public bool cancelTyping;

    // Start is called before the first frame update
    void Start()
    {
        displayed = false;
        cancelTyping = false;
    }

    void Awake()
    {
        m_TextComponent = gameObject.GetComponent<TMP_Text>();
        StartCoroutine(RevealCharacters(m_TextComponent));
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator RevealCharacters(TMP_Text textComponent)
    {
        textComponent.ForceMeshUpdate();

        TMP_TextInfo textInfo = textComponent.textInfo;

        int totalVisibleCharacters = textInfo.characterCount; // Get # of Visible Character in text object
        int visibleCount = 0;
        isTyping = true;

        while (!displayed && !cancelTyping)
        {
            if (visibleCount > totalVisibleCharacters)
            {
                displayed = true;
                isTyping = false;
                yield return null;
            }

            textComponent.maxVisibleCharacters = visibleCount; // How many characters should TextMeshPro display?

            visibleCount += 1;
            if (GameManager.gameScene == -1)
            {
                yield return new WaitForSeconds(0.5f);
            }
            else if (GameManager.gameScene != 23)
            {
                yield return new WaitForSeconds(0.1f);
            }
            else
            {
                yield return new WaitForSeconds(0.11f);
            }
        }
        textComponent.maxVisibleCharacters = totalVisibleCharacters;
        displayed = true;
        isTyping = false;
        yield return null;
    }
}
