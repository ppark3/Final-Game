using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChoiceBehavior : MonoBehaviour
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
        selectedBool = true;
        m_TextComponent.color = selected;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        selectedBool = false;
        m_TextComponent.color = unselected;
    }
}
