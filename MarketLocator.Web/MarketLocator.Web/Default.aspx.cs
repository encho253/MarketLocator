using MarketLocator.Interfaces.Services;
using Ninject;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace MarketLocator.Web
{
    public partial class _Default : Page
    {
        [Inject]
        public ITrafficService TrafficService { get; set; }

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
            var pt = new decimal[30,30];
            //[48.1486, 17.1077]
            for (int i = 0; i < 30; i++)
            {
                var l1 = 48.1486 + 0.01;
                var l2 = 17.1077 + 0.01;

               // Page.ClientScript.RegisterStartupScript(GetType(), "addPoint", "addPoint('" + l1 +"', '" + l2 +"');", true);
            }

            this.TrafficService.GetFilteredLocations();
            var p = this.DropDownListAge.SelectedValue;
            var c = this.DropDownListGenre.SelectedValue;
        }
    }
}