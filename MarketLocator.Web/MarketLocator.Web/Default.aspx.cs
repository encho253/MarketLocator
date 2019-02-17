using System;
using System.Collections.Generic;
using System.Web.UI;

namespace MarketLocator.Web
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<string> listAge = new List<string>()
                {
                    "1-18",
                    "19-25",
                    "26-35",
                    "36-45",
                    "46-65",
                    "66-100"
                };

                DropDownListAge.DataSource = listAge;
                DropDownListAge.DataBind();

                List<string> listGenre = new List<string>()
                {
                    "M",
                    "F",
                    "?"
                };

                DropDownListGenre.DataSource = listGenre;
                DropDownListGenre.DataBind();
            }
        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            var p = this.DropDownListAge.SelectedValue;
            var c = this.DropDownListGenre.SelectedValue;
        }
    }
}