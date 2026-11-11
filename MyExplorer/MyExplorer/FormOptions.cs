using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyExplorer
{

    public partial class FormOptions : Form
    {
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string DisplayType { get; private set; } = "list";

        public FormOptions()
        {
            InitializeComponent();

            CheckCorrectRadioButton();
        }

        public FormOptions(string displayType)
        {
            InitializeComponent();

            DisplayType = displayType;

            CheckCorrectRadioButton();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonList_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonList.Checked)
            {
                DisplayType = "list";
            }
        }

        private void radioButtonIcons_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonIcons.Checked)
            {
                DisplayType = "icons";
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckCorrectRadioButton()
        {
            switch (DisplayType)
            {
                case "list":
                    radioButtonList.Checked = true;
                    break;

                case "icons":
                    radioButtonIcons.Checked = true;
                    break;

                default:
                    radioButtonList.Checked = true;
                    break;
            }
        }

        private void FormOptions_Load(object sender, EventArgs e)
        {
        }

        public string GetCorrectDisplayType()
        {
            return DisplayType;
        }
    }
}
