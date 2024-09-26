using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateNight.Views;

public partial class DinnerPage : ContentPage
{
    public DinnerPage()
    {
        InitializeComponent();
    }
    
    protected override void OnDisappearing()
    {
        base.OnDisappearing();
        App.dateCalc.DinnerCost = txtDinner.Text;
    }
}