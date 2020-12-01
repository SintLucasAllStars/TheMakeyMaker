using System.Collections;
using System.Collections.Generic;
using UnityEditor.IMGUI.Controls;
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Image))]
public class LedIndicator : MonoBehaviour
{
    public KeyCode respondTo;
    private Image _image;
    
    void Start()
    {
        _image = GetComponent<Image>();
    }
    void Update()
    {
        if (Input.GetKey(respondTo))
        {
            _image.color = Color.green;
        }
        else
        {
            _image.color = Color.black;
        }
    }
}
