namespace VRTK
{
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class StepController : MonoBehaviour
    {
        [SerializeField] private GameObject stepUI;
        private GameObject stepText;
        private int currentStep;

        // Start is called before the first frame update
        void Start()
        {
            this.stepText = this.stepUI.transform.GetChild(1).gameObject;
            this.startSteps();
        }

        // Update is called once per frame
        void Update()
        {

        }

        public int getCurrentStep()
        {
            return this.currentStep;
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