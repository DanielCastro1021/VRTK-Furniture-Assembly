namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class StepController : MonoBehaviour
    {
        [SerializeField] private GameObject stepUI;
        [SerializeField] private GameObject sdzone;
        private GameObject stepText;
        private int currentStep;

        // Start is called before the first frame update
        void Start()
        {
            this.stepText = this.stepUI.transform.GetChild(1).gameObject;
            this.sdzone.SetActive(false);
            this.startSteps();
        }

        // Update is called once per frame
        void Update()
        {

        }

        private void startSteps()
        {
            this.currentStep = 1;
            this.stepText.GetComponent<Text>().text = this.getStepText();
        }

        public void nextStep()
        {
            currentStep++;
            this.stepText.GetComponent<Text>().text = this.getStepText();
            if (currentStep == 9) {
                this.sdzone.SetActive(true);
            }
        }

        public void checkOnObjectEnteredSnapDropZone(string tag)
        {
            switch (tag)
            {
                case "piece-1":
                    if (this.currentStep == 1)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
                case "piece-2":
                    if (this.currentStep == 2)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
                case "piece-3":
                    if (this.currentStep == 3)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
                case "piece-4":
                    if (this.currentStep == 4)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
                case "piece-5":
                    if (this.currentStep == 5)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
                case "piece-6":
                    if (this.currentStep == 6)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
                case "piece-7":
                    if (this.currentStep == 7)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
                case "step-piece-7":
                    if (this.currentStep == 8)
                    {
                        this.stepText.GetComponent<Text>().text = this.getStepText();
                    }
                    else
                    {
                        this.stepText.GetComponent<Text>().text = "Peça errada, repetir o seguinte passo:'" + this.getStepText() + "'.";
                    }
                    break;
            }
            Debug.Log("StepController ==>" + this.stepText.GetComponent<Text>().text);
        }

        private string getStepText()
        {
            string text = "Error";
            switch (this.currentStep)
            {
                case 1:
                    text = "Colocar uma peça do tipo 'Piece 1' na zona assinalada.";
                    break;
                case 2:
                    text = "Colocar uma peça do tipo 'Piece 2' na zona assinalada..";
                    break;
                case 3:
                    text = "Colocar uma peça do tipo 'Piece 3' na zona assinalada.";
                    break;
                case 4:
                    text = "Colocar uma peça do tipo 'Piece 4' na zona assinalada.";
                    break;
                case 5:
                    text = "Colocar uma peça do tipo 'Piece 5'na zona assinalada.";
                    break;
                case 6:
                    text = "Colocar uma peça do tipo 'Piece 6' na zona assinalada.";
                    break;
                case 7:
                    text = "Colocar uma peça do tipo 'Piece 7' na zona assinalada.";
                    break;
                case 8:
                    text = "Colocar a estante na zona assinalada, na parede.";
                    break;
                case 9:
                    text = "Parabéns terminou o tutorial de montagem.";
                    break;
            }
            return text;
        }
    }
}