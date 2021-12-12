namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class DestroyGarbage : MonoBehaviour
    {
        private GameObject sdzone;
        // Start is called before the first frame update
        void Start()
        {
            this.sdzone = gameObject;
            this.sdzone.GetComponent<VRTK_SnapDropZone>().ObjectSnappedToDropZone += new SnapDropZoneEventHandler(this.OnObjectSnappedToDropZone);

        }

        // Update is called once per frame
        void Update()
        {

        }


        private void OnObjectSnappedToDropZone(object sender, SnapDropZoneEventArgs e)
        {
            DestroyImmediate(e.snappedObject);
        }
    }
}