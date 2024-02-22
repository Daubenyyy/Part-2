using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rb;
    public SpriteRenderer spriteRenderer;
    public Color unSelectedColour;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        spriteRenderer.color = unSelectedColour;
        Selected(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        Controller.SetSelectedPlayer(this);
    }

    public void Selected(bool isSelected)
    {
        if (isSelected == true)
        {
            spriteRenderer.color = Color.green;
        }
        else { 
            spriteRenderer.color = unSelectedColour;
        }
    }
}
