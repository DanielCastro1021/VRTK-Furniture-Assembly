using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Step1 : MonoBehaviour
{

    [Header("Assembly Object")]
    [SerializeField] private GameObject stepObject;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnStep1()
    {
        //Destroy Piece 1
        GameObject[] prefabs_p = GameObject.FindGameObjectsWithTag("piece-1");
        foreach (GameObject prefab_1 in prefabs_p)
        {
            DestroyImmediate(prefab_1);
        }

        //Destroy SnapDropZone 1 
        GameObject[] prefab_sdz = GameObject.FindGameObjectsWithTag("sdzone-1");
        foreach (GameObject prefab_2 in prefab_sdz)
        {
            DestroyImmediate(prefab_2);

        }

        //Instantiate Step Piece 1
        Instantiate(stepObject, new Vector3(5.538f, 0.69f, 3.589f), Quaternion.identity);
    }

}

