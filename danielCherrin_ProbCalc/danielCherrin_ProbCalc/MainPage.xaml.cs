using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace danielCherrin_ProbCalc
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            lbl_02Prob.Text = "0%";
            lbl_03Prob.Text = "0%";
            lbl_04Prob.Text = "0%";
            lbl_05Prob.Text = "0%";
            lbl_06Prob.Text = "0%";
            lbl_07Prob.Text = "0%";
            lbl_08Prob.Text = "0%";
            lbl_09Prob.Text = "0%";
            lbl_10Prob.Text = "0%";
            lbl_11Prob.Text = "0%";
            lbl_12Prob.Text = "0%";

            List<float> rollResults = new List<float>(new float[] {0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,0f,0f});

            Task.Run(() => {

                Device.BeginInvokeOnMainThread(() =>
                {
                    indic_calculating.IsRunning = true;
                });

                for (int n = 0; n < 100000001; n++)
                {
                    Random rand = new Random();

                    int roll = rand.Next(1, 7) + rand.Next(1, 7);

                    rollResults[roll-1]++;

                    if (n == 100000000)//100000000)
                    {
                        Debug.WriteLine("Dong");
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            lbl_02Prob.Text = ((rollResults[1] / n) * 100).ToString() + "%";
                            lbl_03Prob.Text = ((rollResults[2] / n) * 100).ToString() + "%";
                            lbl_04Prob.Text = ((rollResults[3] / n) * 100).ToString() + "%";
                            lbl_05Prob.Text = ((rollResults[4] / n) * 100).ToString() + "%";
                            lbl_06Prob.Text = ((rollResults[5] / n) * 100).ToString() + "%";
                            lbl_07Prob.Text = ((rollResults[6] / n) * 100).ToString() + "%";
                            lbl_08Prob.Text = ((rollResults[7] / n) * 100).ToString() + "%";
                            lbl_09Prob.Text = ((rollResults[8] / n) * 100).ToString() + "%";
                            lbl_10Prob.Text = ((rollResults[9] / n) * 100).ToString() + "%";
                            lbl_11Prob.Text = ((rollResults[10] / n) * 100).ToString() + "%";
                            lbl_12Prob.Text = ((rollResults[11] / n) * 100).ToString() + "%";
                            indic_calculating.IsRunning = false;
                        });
                        break;
                    }
                    else if (n % 1000 == 0)
                    {
                        Device.BeginInvokeOnMainThread(() =>
                        {
                            lbl_02Prob.Text = ((rollResults[1] / n) * 100).ToString() + "%";
                            lbl_03Prob.Text = ((rollResults[2] / n) * 100).ToString() + "%";
                            lbl_04Prob.Text = ((rollResults[3] / n) * 100).ToString() + "%";
                            lbl_05Prob.Text = ((rollResults[4] / n) * 100).ToString() + "%";
                            lbl_06Prob.Text = ((rollResults[5] / n) * 100).ToString() + "%";
                            lbl_07Prob.Text = ((rollResults[6] / n) * 100).ToString() + "%";
                            lbl_08Prob.Text = ((rollResults[7] / n) * 100).ToString() + "%";
                            lbl_09Prob.Text = ((rollResults[8] / n) * 100).ToString() + "%";
                            lbl_10Prob.Text = ((rollResults[9] / n) * 100).ToString() + "%";
                            lbl_11Prob.Text = ((rollResults[10] / n) * 100).ToString() + "%";
                            lbl_12Prob.Text = ((rollResults[11] / n) * 100).ToString() + "%";
                        });
                    }
                }

            });
        }
    }
}
