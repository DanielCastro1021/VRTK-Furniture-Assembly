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
        //Destroy Piece 3
        GameObject[] prefabs_p = GameObject.FindGameObjectsWithTag("step-3-piece");
        foreach (GameObject prefab_1 in prefabs_p)
        {
            DestroyImmediate(prefab_1);
        }

        //Destroy SnapDropZone 3
        GameObject[] prefab_sdz = GameObject.FindGameObjectsWithTag("step-3-sdz");

        foreach (GameObject prefab_2 in prefab_sdz)
        {
            DestroyImmediate(prefab_2);

        }

        //Destroy Step Piece 2
        //NOTA: Alterar tag com a sintaxe correta
        GameObject[] prefab_sp = GameObject.FindGameObjectsWithTag("stepe-2-step-piece");
        foreach (GameObject prefab_3 in prefab_sp)
        {
            DestroyImmediate(prefab_3);

        }

        //Instantiate Step Piece 3
        Instantiate(stepObject, new Vector3(5.538f, 0.69f, 3.589f), Quaternion.identity);
    }
}
