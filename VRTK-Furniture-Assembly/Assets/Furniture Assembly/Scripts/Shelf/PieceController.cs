namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;

    public class PieceController : MonoBehaviour
    {
        private GameObject sdzone;

        [Header("Assembly Step Controller")]
        [SerializeField] private GameObject stepController;

        [Header("Assembly Step Pieces Objects")]
        [SerializeField] private GameObject stepPiece1;
        [SerializeField] private GameObject stepPiece2;
        [SerializeField] private GameObject stepPiece3;
        [SerializeField] private GameObject stepPiece4;
        [SerializeField] private GameObject stepPiece5;
        [SerializeField] private GameObject stepPiece6;
        [SerializeField] private GameObject stepPiece7;
        [SerializeField] private GameObject finalSnapDropZone;


        // Start is called before the first frame update
        void Start()
        {
            this.stepController = GameObject.Find("StepController");
            this.sdzone = gameObject;
            this.sdzone.GetComponent<VRTK_SnapDropZone>().ObjectEnteredSnapDropZone += new SnapDropZoneEventHandler(this.OnObjectEnteredSnapDropZone);
            this.sdzone.GetComponent<VRTK_SnapDropZone>().ObjectSnappedToDropZone += new SnapDropZoneEventHandler(this.OnObjectSnappedToDropZone);
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void OnObjectEnteredSnapDropZone(object sender, SnapDropZoneEventArgs e)
        {
            Debug.Log(e.snappedObject.tag);
            this.stepController.GetComponent<StepController>().checkOnObjectEnteredSnapDropZone(e.snappedObject.tag);
        }

        private void OnObjectSnappedToDropZone(object sender, SnapDropZoneEventArgs e)
        {
            string tag = e.snappedObject.tag;
            Vector3 position;
            Quaternion rotation;

            switch (tag)
            {
                case "piece-1":
                    this.stepController.GetComponent<StepController>().nextStep();
                    position = this.sdzone.transform.position;
                    DestroyImmediate(e.snappedObject);
                    DestroyImmediate(this.sdzone);
                    Instantiate(this.stepPiece1, position, Quaternion.identity);
                    break;
                case "piece-2":
                    this.stepController.GetComponent<StepController>().nextStep();
                    position = this.transform.parent.position;
                    rotation = this.transform.parent.rotation;
                    rotation *= Quaternion.Euler(0, 180f, 0);
                    DestroyImmediate(e.snappedObject);
                    DestroyImmediate(this.transform.parent.gameObject);
                    Instantiate(this.stepPiece2, position, rotation);
                    break;

                case "piece-3":
                    this.stepController.GetComponent<StepController>().nextStep();
                    position = this.transform.parent.position;
                    rotation = this.transform.parent.rotation;
                    DestroyImmediate(e.snappedObject);
                    DestroyImmediate(this.transform.parent.gameObject);
                    Instantiate(this.stepPiece3, position, rotation);
                    break;

                case "piece-4":
                    this.stepController.GetComponent<StepController>().nextStep();
                    position = this.transform.parent.position;
                    rotation = this.transform.parent.rotation;
                    DestroyImmediate(e.snappedObject);
                    DestroyImmediate(this.transform.parent.gameObject);
                    Instantiate(this.stepPiece4, position, rotation);
                    break;

                case "piece-5":
                    this.stepController.GetComponent<StepController>().nextStep();
                    position = this.transform.parent.position;
                    rotation = this.transform.parent.rotation;
                    DestroyImmediate(e.snappedObject);
                    DestroyImmediate(this.transform.parent.gameObject);
                    Instantiate(this.stepPiece5, position, rotation);
                    break;

                case "piece-6":
                    this.stepController.GetComponent<StepController>().nextStep();
                    position = this.transform.parent.position;
                    rotation = this.transform.parent.rotation;
                    DestroyImmediate(e.snappedObject);
                    DestroyImmediate(this.transform.parent.gameObject);
                    Instantiate(this.stepPiece6, position, rotation);
                    break;

                case "piece-7":
                    this.stepController.GetComponent<StepController>().nextStep();
                    position = this.transform.parent.position;
                    rotation = this.transform.parent.rotation;
                    DestroyImmediate(e.snappedObject);
                    DestroyImmediate(this.transform.parent.gameObject);
                    Instantiate(this.stepPiece7, position, rotation);
                    break;

                case "step-piece-7":
                    this.stepController.GetComponent<StepController>().nextStep();
                    if (this.stepController.GetComponent<StepController>().getCurrentStep() == 8)
                    {
                        Instantiate(this.stepPiece7, new Vector3(3.779367f, 2.684f, -0.6045485f), Quaternion.Euler(0, -90f, 0));
                    }
                    break;
            }
        }
    }
}