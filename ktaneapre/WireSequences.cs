using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;
using static System.Windows.Forms.Design.AxImporter;

namespace ktaneapre
{

    public partial class WireSequences : UserControl
    {
        private int wireSeqRedCount;
        private int wireSeqBlueCount;
        private int wireSeqBlackCount;
        private string currentSequenceStep = "";
        private Wireseq sequences;

        private void newWireSequenceStep()
        {
            currentSequenceStep = "";
            buttonOutput1.Text = "0";
            buttonOutput2.Text = "0";
            buttonOutput3.Text = "0";
            labelWiresStage.Text += "I";
            buttonOutput1.BackColor = Color.Gray;
            buttonOutput2.BackColor = Color.Gray;
            buttonOutput3.BackColor = Color.Gray;
            buttonOutput1A.FlatStyle = FlatStyle.Standard;
            buttonOutput1B.FlatStyle = FlatStyle.Standard;
            buttonOutput1C.FlatStyle = FlatStyle.Standard;
            buttonOutput2A.FlatStyle = FlatStyle.Standard;
            buttonOutput2B.FlatStyle = FlatStyle.Standard;
            buttonOutput2C.FlatStyle = FlatStyle.Standard;
            buttonOutput3A.FlatStyle = FlatStyle.Standard;
            buttonOutput3B.FlatStyle = FlatStyle.Standard;
            buttonOutput3C.FlatStyle = FlatStyle.Standard;
        }

        private void resetWireSequences()
        {
            wireSeqRedCount = 0;
            wireSeqBlueCount = 0;
            wireSeqBlackCount = 0;
            currentSequenceStep = "";
            labelInputRed.Text = "";
            labelInputBlue.Text = "";
            labelInputBlack.Text = "";
            labelWiresStage.Text = "";
            newWireSequenceStep();
        }

        private void updateWireOutputs()
        {
            string colorString = ""; // TODO replace this later pls
            int currentSequenceStepStep = currentSequenceStep.Length - 1;
            Color currentColor =
                currentSequenceStep[currentSequenceStepStep] == 'r' ? Color.Red :
                currentSequenceStep[currentSequenceStepStep] == 'b' ? Color.Blue :
                currentSequenceStep[currentSequenceStepStep] == 'k' ? Color.Black :
                Color.Gray;

            Button[,] operands =
            {
                {buttonOutput1, buttonOutput1A, buttonOutput1B, buttonOutput1C },
                {buttonOutput2, buttonOutput2A, buttonOutput2B, buttonOutput2C },
                {buttonOutput3, buttonOutput3A, buttonOutput3B, buttonOutput3C }
            };

            switch(currentSequenceStep[currentSequenceStepStep])
            {
                case 'r':
                    operands[currentSequenceStepStep, 0].BackColor = Color.Red;
                    operands[currentSequenceStepStep, 0].Text = wireSeqRedCount.ToString();
                    colorString = sequences.Red[wireSeqRedCount - 1];
                    break;
                case 'b':
                    operands[currentSequenceStepStep, 0].BackColor = Color.Blue;
                    operands[currentSequenceStepStep, 0].Text = wireSeqBlueCount.ToString();
                    colorString = sequences.Blue[wireSeqBlueCount - 1];
                    break;
                case 'k':
                    operands[currentSequenceStepStep, 0].BackColor = Color.Black;
                    operands[currentSequenceStepStep, 0].Text = wireSeqBlackCount.ToString();
                    colorString = sequences.Black[wireSeqBlackCount - 1];
                    break;
                default:
                    break;
            }


            if (colorString.Contains("a"))
            {
                operands[currentSequenceStepStep, 1].FlatStyle = FlatStyle.Flat;
            }
            if (colorString.Contains("b"))
            {
                operands[currentSequenceStepStep, 2].FlatStyle = FlatStyle.Flat;
            }
            if (colorString.Contains("c"))
            {
                operands[currentSequenceStepStep, 3].FlatStyle = FlatStyle.Flat;
            }
        }

        public WireSequences()
        {

            try
            {
                InitializeComponent();
                resetWireSequences();
                string fileContents = File.ReadAllText("template.json");
                JsonRoot jsonData = JsonSerializer.Deserialize<JsonRoot>(fileContents)!;
                sequences = jsonData.Wireseq;
            }
            catch (Exception e){}
        }

        private void buttonInputRed_Click(object sender, EventArgs e)
        {
            if (currentSequenceStep.Length < 3)
            {
                wireSeqRedCount++;
                labelInputRed.Text += "I";
                currentSequenceStep += "r";
                updateWireOutputs();
            }
        }

        private void buttonInputBlue_Click(object sender, EventArgs e)
        {
            if (currentSequenceStep.Length < 3)
            {
                wireSeqBlueCount++;
                labelInputBlue.Text += "I";
                currentSequenceStep += "b";
                updateWireOutputs();
            }
        }

        private void buttonInputBlack_Click(object sender, EventArgs e)
        {
            if (currentSequenceStep.Length < 3)
            {
                wireSeqBlackCount++;
                labelInputBlack.Text += "I";
                currentSequenceStep += "k";
                updateWireOutputs();
            }
        }

        private void buttonNewSequence_Click(object sender, EventArgs e)
        {
            resetWireSequences();
        }

        private void buttonNextStage_Click(object sender, EventArgs e)
        {
            newWireSequenceStep();
        }
    }
}
