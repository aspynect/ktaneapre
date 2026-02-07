using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace ktaneapre
{
    public partial class Knob : UserControl
    {
        bool[] inputs = [false, false, false, false, false, false, false, false, false, false, false, false];
        Dictionary<string, string> options;

        private void writeKnobData()
        {
            JsonHandling.Data.Knob = options;
            JsonHandling.writeData();
            updateOutput();
        }

        private string getOutputString()
        {
            string outputString = "";
            foreach (bool i in inputs)
            {
                outputString += i ? 'x' : '/';
            }
            return outputString;
        }

        private void updateOutput()
        {
            string outputString = getOutputString();
            buttonKnobAddState.Enabled = options.ContainsKey(outputString) ? false : true;
            buttonKnobUp.FlatStyle = options.GetValueOrDefault(outputString)?.Contains('u') == true ? FlatStyle.Flat : FlatStyle.Standard;
            buttonKnobLeft.FlatStyle = options.GetValueOrDefault(outputString)?.Contains('l') == true ? FlatStyle.Flat : FlatStyle.Standard;
            buttonKnobDown.FlatStyle = options.GetValueOrDefault(outputString)?.Contains('d') == true ? FlatStyle.Flat : FlatStyle.Standard;
            buttonKnobRight.FlatStyle = options.GetValueOrDefault(outputString)?.Contains('r') == true ? FlatStyle.Flat : FlatStyle.Standard;
        }

        private void updateKnobData(char button)
        {
            string outputString = getOutputString();
            if (!options.ContainsKey(outputString)) return;
            if (checkBoxKnobCorrect.Checked)
            {
                options[outputString] = button.ToString();
            }
            else
            {
                options[outputString] = options[outputString].Replace(button.ToString(), "");
            }
            writeKnobData();
        }

        public void reloadKnobData()
        {
            options = JsonHandling.Data.Knob;
            updateOutput();
        }

        public Knob()
        {
            try
            {
                //TODO make this work
                InitializeComponent();
                reloadKnobData();
            }
            catch (Exception e) { }
        }

        private void buttonKnob1_Click(object sender, EventArgs e)
        {
            inputs[0] = !inputs[0];
            buttonKnob1.FlatStyle = (inputs[0] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob2_Click(object sender, EventArgs e)
        {
            inputs[1] = !inputs[1];
            buttonKnob2.FlatStyle = (inputs[1] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob3_Click(object sender, EventArgs e)
        {
            inputs[2] = !inputs[2];
            buttonKnob3.FlatStyle = (inputs[2] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob4_Click(object sender, EventArgs e)
        {
            inputs[3] = !inputs[3];
            buttonKnob4.FlatStyle = (inputs[3] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob5_Click(object sender, EventArgs e)
        {
            inputs[4] = !inputs[4];
            buttonKnob5.FlatStyle = (inputs[4] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob6_Click(object sender, EventArgs e)
        {
            inputs[5] = !inputs[5];
            buttonKnob6.FlatStyle = (inputs[5] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob7_Click(object sender, EventArgs e)
        {
            inputs[6] = !inputs[6];
            buttonKnob7.FlatStyle = (inputs[6] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob8_Click(object sender, EventArgs e)
        {
            inputs[7] = !inputs[7];
            buttonKnob8.FlatStyle = (inputs[7] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob9_Click(object sender, EventArgs e)
        {
            inputs[8] = !inputs[8];
            buttonKnob9.FlatStyle = (inputs[8] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob10_Click(object sender, EventArgs e)
        {
            inputs[9] = !inputs[9];
            buttonKnob10.FlatStyle = (inputs[9] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob11_Click(object sender, EventArgs e)
        {
            inputs[10] = !inputs[10];
            buttonKnob11.FlatStyle = (inputs[10] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnob12_Click(object sender, EventArgs e)
        {
            inputs[11] = !inputs[11];
            buttonKnob12.FlatStyle = (inputs[11] == true) ? FlatStyle.Flat : FlatStyle.Standard;
            updateOutput();
        }

        private void buttonKnobUp_Click(object sender, EventArgs e)
        {
            updateKnobData('u');
        }

        private void buttonKnobLeft_Click(object sender, EventArgs e)
        {
            updateKnobData('l');

        }

        private void buttonKnobDown_Click(object sender, EventArgs e)
        {
            updateKnobData('d');

        }

        private void buttonKnobRight_Click(object sender, EventArgs e)
        {
            updateKnobData('r');

        }

        private void buttonKnobAddState_Click(object sender, EventArgs e)
        {
            string outputString = getOutputString();
            options[outputString] = "udlr";
            updateOutput();
            writeKnobData();
        }
    }
}
