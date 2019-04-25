using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GoodChoiceBehavior : MonoBehaviour
{
    public Color selected;
    public Color unselected;
    public TMP_Text m_TextComponent;
    public bool selectedBool;

    // Start is called before the first frame update
    void Start()
    {
        selectedBool = false;
        m_TextComponent = gameObject.GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        m_TextComponent.color = selected;
        selectedBool = true;

    }

    void OnTriggerExit2D(Collider2D col)
    {
        m_TextComponent.color = unselected;
        selectedBool = false;
    }
}
