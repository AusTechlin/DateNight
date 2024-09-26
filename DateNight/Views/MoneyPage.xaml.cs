using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class MoneyPage : ContentPage
{
    public MoneyPage()
    {
        InitializeComponent();
    }
    
    protected override void OnAppearing()
    {
        base.OnAppearing();
        try
        {
            lblCost.Text = App.dateCalc.GetTotalCost();
        }
        catch (Exception ex)
        {
            lblCost.Text = "$0.00";
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}