using MarketLocator.Interfaces.Services;
using MarketLocator.Models;
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

        protected void Filter_Click(object sender, EventArgs e)
        {
            string age = this.DropDownListAge.SelectedValue;
            int minimumAge = int.Parse(age.Split('-')[0]);
            int maximumAge = int.Parse(age.Split('-')[1]);
            string gender = this.DropDownListGenre.SelectedValue;

            DateTime date = DateTime.Now;

            if (this.startDate.Text != String.Empty)
            {
                date = Convert.ToDateTime(this.startDate.Text);
            }
            else
            {
                this.startDate.Text = DateTime.Now.Date.ToString();
            }

            List<Traffic> data = this.TrafficService.GetFilteredLocations(gender, minimumAge, maximumAge, date);

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(data);
            Response.Write(string.Concat("<input id='data' type='hidden' value='", json, "' />"));
            Page.ClientScript.RegisterStartupScript(GetType(), "addPoint", "addPoint();", true);        
        }
    }
}