using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step4 : MonoBehaviour
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

    public void OnStep4()
    {
        //Destroy Step Piece 3
        GameObject[] prefab_sp = GameObject.FindGameObjectsWithTag("step-piece-3");
        foreach (GameObject prefab_3 in prefab_sp)
        {
            DestroyImmediate(prefab_3);

        }

        //Destroy Piece 4
        GameObject[] prefabs_p = GameObject.FindGameObjectsWithTag("piece-4");
        foreach (GameObject prefab_1 in prefabs_p)
        {
            DestroyImmediate(prefab_1);
        }

        //Destroy SnapDropZone 4
        GameObject[] prefab_sdz = GameObject.FindGameObjectsWithTag("sdzone-4");

        foreach (GameObject prefab_2 in prefab_sdz)
        {
            DestroyImmediate(prefab_2);

        }

        //Instantiate Step Piece 4
        Instantiate(stepObject, new Vector3(5.538f, 0.69f, 3.589f), Quaternion.identity);
    }
}
