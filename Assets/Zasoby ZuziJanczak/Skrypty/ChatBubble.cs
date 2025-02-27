using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChatBubble : MonoBehaviour
{
    private TextMeshPro textMeshPro;

    private void Awake()
    {
        textMeshPro = transform.Find("Text").GetComponent<TextMeshPro>();
    }


    void Start()
    {
        Setup("Ksi¹dz Grzegorz");
    }

    
    void Setup(string text)
    {
        textMeshPro.SetText(text);
        textMeshPro.ForceMeshUpdate();
        Vector2 textSize = textMeshPro.GetRenderedValues(false);
    }
}
