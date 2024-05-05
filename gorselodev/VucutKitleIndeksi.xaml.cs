using System.Collections.ObjectModel;
using System.Text.Json;
namespace gorselodev;

public partial class VucutKitleIndeksi : ContentPage
{
    public VucutKitleIndeksi()
    {
        InitializeComponent();
    }

    private void CalculateBMI(object sender, EventArgs e)
    {
        double weight = sliderWeight.Value;
        double height = sliderHeight.Value / 100.0;

        double bmi = weight / (height * height);
        string category = GetBMICategory(bmi);
        lblResult.Text = $"VKI: {bmi:F2}\nKategori: {category}";
    }

    private string GetBMICategory(double bmi)
    {
        switch (bmi)
        {
            case var n when n < 16:
                return "�leri d�zeyde zay�f";
            case var n when n < 17:
                return "Orta D�zeyde Zay�f";
            case var n when n < 18.5:
                return "Hafif D�zeyde Zay�f";
            case var n when n < 25:
                return "Normal Kilolu";
            case var n when n < 30:
                return "Hafif �i�man";
            case var n when n < 35:
                return "1.derecede obez";
            case var n when n < 40:
                return "2.derecede obez";
            default:
                return "3.derecede obez";
        }
    }

    private void SliderWeight_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double weight = e.NewValue;
       
    }

    private void SliderHeight_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double height = e.NewValue;
        
    }

}


