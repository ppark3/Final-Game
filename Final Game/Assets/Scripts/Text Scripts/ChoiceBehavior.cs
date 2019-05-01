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

    public float verticalSpeed;
    public float horizontalSpeed;

    // Start is called before the first frame update
    void Start()
    {
        selectedBool = false;
        m_TextComponent = gameObject.GetComponent<TMP_Text>();
        verticalSpeed = Random.Range(-5f, 5f);
        horizontalSpeed = Random.Range(-5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (GameManager.gameScene == 14)
        {
            gameObject.transform.Translate(Vector3.left * horizontalSpeed * Time.deltaTime);
            gameObject.transform.Translate(Vector3.up * verticalSpeed * Time.deltaTime);
        }
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

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Top")
        {
            verticalSpeed = Random.Range(-1f, -5f);
        }
        if (collision.gameObject.tag == "Bottom")
        {
            verticalSpeed = Random.Range(1f, 5f);
        }
        if (collision.gameObject.tag == "Left")
        {
            horizontalSpeed = Random.Range(-1f, -5f);
        }
        if (collision.gameObject.tag == "Right")
        {
            horizontalSpeed = Random.Range(1f, 5f);
        }
    }
}
