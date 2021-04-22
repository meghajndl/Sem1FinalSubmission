﻿using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Input;
using Flurl.Http;
using MDEV1014PracticeProject.Models;
using MDEV1014PracticeProject.Services.Auth;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace MDEV1014PracticeProject.ViewModels
{
    public class LoginVM : ViewModelBase
    {

        private string _Username;
        public string Username
        {
            get { return _Username; }
            set { SetProperty(ref _Username, value); }
        }

        private string _Password;
        public string Password
        {
            get { return _Password; }
            set { SetProperty(ref _Password, value); }
        }

        public ICommand LoginCommand => new Command(()=> {
            LoginTapped();
        });

        public LoginVM()
        {
            Title = "Login Page";
        }


        private async Task LoginTapped() {


            if (Username == null || Password == null) {
                await DisplayAlert("Error", "Please enter username/password", "Ok");
                return;
            }

            

            Debug.WriteLine("Auth process started ..");

            try
            {
                var service = Adapter.Shared.authService;
                var resultObject = await service.SignInAsync(Username, Password);

                if (resultObject != null)
                {
                    //Error true
                    if (resultObject.error)
                    {
                        if (resultObject.message == "PassMismatch")
                        {
                            await DisplayAlert("Invalid Password");
                        }
                        else if (resultObject.message == "UserNotFound")
                        {
                            await DisplayAlert("Account not found!");
                        }
                        else
                        {
                            await DisplayAlert("Unknown error!");
                        }
                    }

                    //No Error
                    else
                    {
                        if (resultObject.token != null)
                        {
                            await DisplayAlert("Success login");
                            //TODO: save token in app properties
                            await MyApp.SavePropertyAsync(KEYS.KEY_USERNAME, Username);
                            await MyApp.SavePropertyAsync(KEYS.KEY_USERTOKEN, Password);
                            await MyApp.SavePropertyAsync("token", resultObject.token);
                            MyApp.SignIn();
                        }
                        else
                        {
                            await DisplayAlert("Token not found!", "Error!");
                        }
                    }
                }
                else {
                    await DisplayAlert("Unknown Error");
                }



            }
            catch (Exception e) {
                await DisplayAlert($"Something went wrong:{e.Message}");
                throw new Exception($"Something went wrong:{e.Message}");
            }
            
            

            /*
            if (Username == Settings.Shared.mockUsername
                && Password == Settings.Shared.mockUserPassword) {
                Debug.WriteLine("Login Success");
                await MyApp.SavePropertyAsync(KEYS.KEY_USERNAME, Username);
                await MyApp.SavePropertyAsync(KEYS.KEY_USERTOKEN, Password);
                MyApp.SignIn();
            }
            */

        }
    }
}
