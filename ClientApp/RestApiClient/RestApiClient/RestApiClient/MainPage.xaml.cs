using Flurl.Http;
using RestApiClient.DataContracts;
using System;
using System.ComponentModel;
using Xamarin.Forms;

namespace RestApiClient
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private const string BaseUrl = "http://10.0.2.2:4000/users/";

        public MainPage()
        {
            InitializeComponent();
        }

        private void AdminLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                var authenticateUrl = BaseUrl + "authenticate";
                var result = authenticateUrl.PostJsonAsync(new AuthenticateUserRequest
                {
                    Password = "admin",
                    Username = "admin"
                }).Result;

                ApiResult.Text = result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception)
            {
            }
        }

        private void UserLogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                var authenticateUrl = BaseUrl + "authenticate";
                var result = authenticateUrl.PostJsonAsync(new AuthenticateUserRequest
                {
                    Password = "user",
                    Username = "user"
                }).Result;

                ApiResult.Text = result.Content.ReadAsStringAsync().Result;
            }
            catch (Exception)
            {

            }
        }
    }
}
