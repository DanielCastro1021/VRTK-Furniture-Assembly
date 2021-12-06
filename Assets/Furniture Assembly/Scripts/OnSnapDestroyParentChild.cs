using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSnapDestroyParentChild : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnSnapDestroy() {
        gameObject.GetComponent<Renderer>().material.color = Color.blue;
    }
}
