using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace application
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        string effect2LabelText = "Vous êtes au volant de votre voiture,";
        string effect3LabelText = "vous êtes sur le point de rentrer chez vous.";
        string effect4LabelText = "Soudainement une silouhette apparait, vous frenez...";
        string effect5LabelText = "malheuresement la chose s'écrase contre le capot.";

        string effect6LabelText = "Votre voiture s'est arrété, le moteur tourne toujours.";
        string effect7LabelText = "Vérifier la voiture ou la chose ?";



        public Page1()
        {
            InitializeComponent();
            choix1.IsVisible = false;
            lavoiture.IsVisible = false;
            lachose.IsVisible = false;
            entretext1.IsVisible = false;
            entretext2.IsVisible = false;
            entretext3.IsVisible = false;
            entretext4.IsVisible = false;
            entretext5.IsVisible = false;
            entretext6.IsVisible = false;
            entretext7.IsVisible = false;
            entretext9.IsVisible = false;
            entretext10.IsVisible = false;
            text();
        }

        private async void text()
        {
            entretext1.IsVisible = true;
            text1();
            entretext2.IsVisible = true;
            await Task.Delay(3000);
            text2();
            entretext3.IsVisible = true;
            await Task.Delay(3000);
            text3();
            entretext4.IsVisible = true;
            await Task.Delay(3000);
            text4();
            entretext5.IsVisible = true;
            await Task.Delay(3000);
            text5();
            entretext6.IsVisible = true;
            await Task.Delay(3000);
            text6();
            entretext7.IsVisible = true;
            await Task.Delay(2200);

            entretext9.IsVisible = true;
            entretext10.IsVisible = true;

            await Task.Delay(1500);
            choix1.IsVisible = true;
            await Task.Delay(1000);
            lavoiture.IsVisible = true;
            await Task.Delay(1000);
            lachose.IsVisible = true;

        }

        private async void text1()
        {
            effect2Label.Text = string.Empty;
            for (int i = 0; i < effect2LabelText.Length; i++)
            {
                await Task.Delay(50);
                effect2Label.Text += effect2LabelText[i];
            }
        }
        private async void text2()
        {
            
            effect3Label.Text = string.Empty;
            for (int i = 0; i < effect3LabelText.Length; i++)
            {
                await Task.Delay(50);
                effect3Label.Text += effect3LabelText[i];
            }
        }

        private async void text3()
        {

            effect4Label.Text = string.Empty;
            for (int i = 0; i < effect4LabelText.Length; i++)
            {
                await Task.Delay(50);
                effect4Label.Text += effect4LabelText[i];
            }
        }

        private async void text4()
        {

            effect5Label.Text = string.Empty;
            for (int i = 0; i < effect5LabelText.Length; i++)
            {
                await Task.Delay(50);
                effect5Label.Text += effect5LabelText[i];
            }
        }

        private async void text5()
        {

            effect6Label.Text = string.Empty;
            for (int i = 0; i < effect6LabelText.Length; i++)
            {
                await Task.Delay(50);
                effect6Label.Text += effect6LabelText[i];
            }
        }

        private async void text6()
        {

            effect7Label.Text = string.Empty;
            for (int i = 0; i < effect7LabelText.Length; i++)
            {
                await Task.Delay(50);
                effect7Label.Text += effect7LabelText[i];
            }
        }



    }
}