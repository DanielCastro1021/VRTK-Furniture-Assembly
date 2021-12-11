using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Step3 : MonoBehaviour
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

    public void OnStep3()
    {
        //Destroy Step Piece 2
        GameObject[] prefab_sp = GameObject.FindGameObjectsWithTag("step-piece-2");
        foreach (GameObject prefab_3 in prefab_sp)
        {
            DestroyImmediate(prefab_3);

        }
        //Destroy Piece 3
        GameObject[] prefabs_p = GameObject.FindGameObjectsWithTag("piece-3");
        foreach (GameObject prefab_1 in prefabs_p)
        {
            DestroyImmediate(prefab_1);
        }

        //Destroy SnapDropZone 3
        GameObject[] prefab_sdz = GameObject.FindGameObjectsWithTag("sdzone-3");

        foreach (GameObject prefab_2 in prefab_sdz)
        {
            DestroyImmediate(prefab_2);

        }

        //Instantiate Step Piece 3
        Instantiate(stepObject, new Vector3(5.538f, 0.69f, 3.589f), Quaternion.identity);
    }
}
