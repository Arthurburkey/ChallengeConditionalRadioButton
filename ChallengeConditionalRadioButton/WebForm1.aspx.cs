using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeConditionalRadioButton
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void okButton_Click(object sender, EventArgs e)
        {
            /*
            if (PencilRadioButton.Checked)
                ResultLabel.Text = "You selected Pencil";
            else if (PenRadioButton.Checked)
                ResultLabel.Text = "You selected Pen";
            else if (PhoneRadioButton.Checked)
                ResultLabel.Text = "You selected Phone";
            else if (TabletRadioButton.Checked)
                ResultLabel.Text = "You selected Tablet";
            else
                ResultLabel.Text = "Please select an option";
            */

            if (PencilRadioButton.Checked)
                resultImage.ImageUrl = "pencil.png";
            else if (PenRadioButton.Checked)
                resultImage.ImageUrl = "pen.png";
            else if (PhoneRadioButton.Checked)
                resultImage.ImageUrl = "phone.png";
            else if (TabletRadioButton.Checked)
                resultImage.ImageUrl = "tablet.png";
            else
                ResultLabel.Text = "Please select an option";
        }
    }
}