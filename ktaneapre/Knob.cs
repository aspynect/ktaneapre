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

        private void updateOutput()
        {
            string outputString = "";
            foreach (bool i in inputs)
            {
                outputString += i ? 'x' : '/';
            }
            labelKnobOutput.Text = options.ContainsKey(outputString) ? options[outputString] : "n/a";
        }

        public Knob()
        {
            try
            {
                InitializeComponent();
                string fileContents = File.ReadAllText("template.json");
                JsonRoot jsonData = JsonSerializer.Deserialize<JsonRoot>(fileContents)!;
                options = jsonData.Knob;
                updateOutput();
            } catch (Exception e){}
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
    }
}
