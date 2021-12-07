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

    public void OnStep()
    {
        //Destroy Step 2 Piece
        GameObject[] prefabs_p = GameObject.FindGameObjectsWithTag("step-2-piece");
        foreach (GameObject prefab_1 in prefabs_p)
        {
            DestroyImmediate(prefab_1);
        }

        //Destroy Step 2 SnapDropZone
        GameObject[] prefab_sdz = GameObject.FindGameObjectsWithTag("step-2-sdz");
        foreach (GameObject prefab_2 in prefab_sdz)
        {
            DestroyImmediate(prefab_2);

        }

        //Destroy Step 1 Piece
        GameObject[] prefab_sp = GameObject.FindGameObjectsWithTag("stepe-2-step-piece");
        foreach (GameObject prefab_3 in prefab_sp)
        {
            DestroyImmediate(prefab_3);

        }

        //Instantiate Step 2 Piece
        Instantiate(stepObject, new Vector3((float)5.538, (float)0.69, (float)3.589), Quaternion.identity);
    }
}
