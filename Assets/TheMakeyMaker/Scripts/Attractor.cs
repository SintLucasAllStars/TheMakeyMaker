using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{   
    private bool _active = true;

    public enum AttractionMode{Attract, Reppel};

    public AttractionMode Mode;
    public MakeyManager.Key respondTo;
    public bool responsive;
    public float strength = 1.0f;
    public float range = 100;
    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }
    
    public bool Active
    {
        get { return _active; }
        set
        {
            _active = value;
            if (_active)
            {
                transform.localScale = new Vector3(3f,3f,3f);
            }
            else
            {
                transform.localScale = new Vector3(1f,1f,1f);
            }
        }
    }

    void Update()
    {
        if (responsive)
        {
            Active =MakeyManager.Instance.GetKey(respondTo);
        }
    }
}
