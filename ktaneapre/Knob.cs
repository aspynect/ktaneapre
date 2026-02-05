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
            buttonKnob1.FlatStyle = (buttonKnob1.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[0] = !inputs[0];
            updateOutput();
        }

        private void buttonKnob2_Click(object sender, EventArgs e)
        {
            buttonKnob2.FlatStyle = (buttonKnob2.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[1] = !inputs[1];
            updateOutput();
        }

        private void buttonKnob3_Click(object sender, EventArgs e)
        {
            buttonKnob3.FlatStyle = (buttonKnob3.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[2] = !inputs[2];
            updateOutput();
        }

        private void buttonKnob4_Click(object sender, EventArgs e)
        {
            buttonKnob4.FlatStyle = (buttonKnob4.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[3] = !inputs[3];
            updateOutput();
        }

        private void buttonKnob5_Click(object sender, EventArgs e)
        {
            buttonKnob5.FlatStyle = (buttonKnob5.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[4] = !inputs[4];
            updateOutput();
        }

        private void buttonKnob6_Click(object sender, EventArgs e)
        {
            buttonKnob6.FlatStyle = (buttonKnob6.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[5] = !inputs[5];
            updateOutput();
        }

        private void buttonKnob7_Click(object sender, EventArgs e)
        {
            buttonKnob7.FlatStyle = (buttonKnob7.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[6] = !inputs[6];
            updateOutput();
        }

        private void buttonKnob8_Click(object sender, EventArgs e)
        {
            buttonKnob8.FlatStyle = (buttonKnob8.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[7] = !inputs[7];
            updateOutput();
        }

        private void buttonKnob9_Click(object sender, EventArgs e)
        {
            buttonKnob9.FlatStyle = (buttonKnob9.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[8] = !inputs[8];
            updateOutput();
        }

        private void buttonKnob10_Click(object sender, EventArgs e)
        {
            buttonKnob10.FlatStyle = (buttonKnob10.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[9] = !inputs[9];
            updateOutput();
        }

        private void buttonKnob11_Click(object sender, EventArgs e)
        {
            buttonKnob11.FlatStyle = (buttonKnob11.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[10] = !inputs[10];
            updateOutput();
        }

        private void buttonKnob12_Click(object sender, EventArgs e)
        {
            buttonKnob12.FlatStyle = (buttonKnob12.FlatStyle == FlatStyle.Standard) ? FlatStyle.Flat : FlatStyle.Standard;
            inputs[11] = !inputs[11];
            updateOutput();
        }
    }
}
