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
            try
            {
                string[] files = Directory.GetFiles("./profiles", "*.json").Select(Path.GetFileNameWithoutExtension).ToArray();
                comboBoxProfile.Items.AddRange(files);
                JsonHandling.loadData();
                reloadModules();
            }
            catch { }
        }

        private void reloadModules()
        {
            //TODO figure this out lmao. i probably need to do event listener bullshit, define a custom event and have the other files listen to it
        }

        private void comboBoxProfile_SelectedIndexChanged(object sender, EventArgs e)
        {
            profileName = comboBoxProfile.Text;
            this.FindForm().Text = $"KTANEAPRE — {profileName}";
            reloadModules();
        }
    }
}
