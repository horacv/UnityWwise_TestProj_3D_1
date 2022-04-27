using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayEvent : MonoBehaviour
{
    public AK.Wwise.Event audioEvent;

    // Start is called before the first frame update
    void Start()
    {
        audioEvent.Post(gameObject);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
