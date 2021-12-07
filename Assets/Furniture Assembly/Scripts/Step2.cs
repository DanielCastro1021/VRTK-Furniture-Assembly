using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step2 : MonoBehaviour
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

    public void OnStep2()
    {

        //Destroy Piece 2
        GameObject[] prefabs_p = GameObject.FindGameObjectsWithTag("piece-2");
        foreach (GameObject prefab_1 in prefabs_p)
        {
            DestroyImmediate(prefab_1);
        }

        //Destroy SnapDropZone 2
        GameObject[] prefab_sdz = GameObject.FindGameObjectsWithTag("sdzone-2");

        foreach (GameObject prefab_2 in prefab_sdz)
        {
            DestroyImmediate(prefab_2);

        }

        //Destroy Step Piece 1
        GameObject[] prefab_sp = GameObject.FindGameObjectsWithTag("step-piece-1");
        foreach (GameObject prefab_3 in prefab_sp)
        {
            DestroyImmediate(prefab_3);

        }

        //Instantiate Step Piece 2
        Instantiate(stepObject, new Vector3(5.538f, 0.69f, 3.589f), Quaternion.Euler(0f, 180f, 0f));
    }
}
