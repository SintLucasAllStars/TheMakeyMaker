using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attractor : MonoBehaviour
{
    [SerializeField]
    private bool _active = true;

    public MakeyManager.Key respondTo;
    public bool responsive = false;
    public float strength = 1.0f;
    public Vector3 Position
    {
        get
        {
            return transform.position;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (responsive)
        {
            SetActive(MakeyManager.Instance.GetKey(respondTo));
        }
    }

    public bool isActive()
    {
        return _active;
    }

    public void SetActive(bool val)
    {
        _active = val;
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
