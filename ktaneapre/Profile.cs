using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ktaneapre
{
    public partial class Profile : UserControl
    {
        public static string profileName { get; private set; } = "vanilla";
        public Profile()
        {
            InitializeComponent();
            string[] files = Directory.GetFiles("./profiles", "*.json").Select(Path.GetFileNameWithoutExtension).ToArray();
            comboBoxProfile.Items.AddRange(files);
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            profileName = comboBoxProfile.Text;
            //TODO make this reload the usercontrols, change window title?
            
        }
    }
}
