using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab_01
{
    public partial class About : Page
    {
        protected void Page_Init (object sender, EventArgs e)
        {
            form_events.Text += ("--init--");
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            form_events.Text += ("--unload--");
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
            form_events.Text += ("--pre-render--");
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            form_events.Text += ("--page load--");
        }

        protected void Page_Disposed(object sender, EventArgs e)
        {
            form_events.Text += ("--Disposed--");
        }

        protected void button_Click(object sender, EventArgs e)
        {
            label.Text += " " + textBox.Text;
            string viewstate = Request["__VIEWSTATE"];
            viewStateLabel.Text = "";
            viewStateLabel.Text = "[" + viewstate.Length + "]"; 
            viewStateLabel.Text += viewstate +"\n";


        }

        protected void checkbox_CheckedChanged(object sender, EventArgs e)
        {
            form_events.Text += checkbox.Checked ? "cheked" : "unchecked";
        }
    }
}