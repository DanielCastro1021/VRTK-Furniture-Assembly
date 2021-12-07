using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnSnapDestroyParentChild : MonoBehaviour
{
    [SerializeField] private GameObject nextStepObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSnapDestroy()
    {
        Instantiate(nextStepObject, new Vector3((float)5.538, (float)0.691, (float)4.263), Quaternion.identity);
    }
}