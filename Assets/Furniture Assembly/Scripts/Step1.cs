using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step1 : MonoBehaviour
{
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
        //Destroy Step 1 Piece
        GameObject[] prefabs_p = GameObject.FindGameObjectsWithTag("step-1-piece");
        foreach (GameObject prefab_1 in prefabs_p)
        {
            DestroyImmediate(prefab_1);
        }

        //Destroy Step 1 SnapDropZone
        GameObject[] prefab_sdz = GameObject.FindGameObjectsWithTag("step-1-sdz");
        foreach (GameObject prefab_2 in prefab_sdz)
        {
            DestroyImmediate(prefab_2);

        }

        //Instantiate Step 1 Piece
        Instantiate(stepObject, new Vector3(5.538f, 0.69f, 3.589f), Quaternion.identity);
    }
}

