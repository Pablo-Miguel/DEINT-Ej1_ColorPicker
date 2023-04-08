namespace DEINT_Ej1_ColorPicker;

public partial class MainPage : ContentPage
{
	private Random random;
	private String colorRed;
    private String colorBlue;
    private String colorGreen;
    private const Int32 COLOR_INT_REF = 200;

	public MainPage()
	{
		InitializeComponent();
		random = new Random();
		colorRed = "00";
		colorBlue = "00";
		colorGreen = "00";
	}

	private void redSlider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		int colorBit = Int32.Parse(Math.Round(redSlider.Value).ToString());

		colorRed = colorBit.ToString("X2");

		btnColor.Text = $"#{colorRed}{colorGreen}{colorBlue}";

		ContenidoPagina.BackgroundColor = Color.Parse(btnColor.Text);
		btnRndColor.BackgroundColor = Color.Parse(btnColor.Text);

        if (Int32.Parse(colorRed, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF || Int32.Parse(colorBlue, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF || Int32.Parse(colorGreen, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF)
        {
            btnRndColor.TextColor = Color.Parse("Black");
        }
        else
        {
            btnRndColor.TextColor = Color.Parse("White");
        }
    }

	private void blueSlider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
        int colorBit = Int32.Parse(Math.Round(blueSlider.Value).ToString());

        colorBlue = colorBit.ToString("X2");

        btnColor.Text = $"#{colorRed}{colorGreen}{colorBlue}";

        ContenidoPagina.BackgroundColor = Color.Parse(btnColor.Text);
        btnRndColor.BackgroundColor = Color.Parse(btnColor.Text);

        if (Int32.Parse(colorRed, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF || Int32.Parse(colorBlue, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF || Int32.Parse(colorGreen, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF)
        {
            btnRndColor.TextColor = Color.Parse("Black");
        }
        else
        {
            btnRndColor.TextColor = Color.Parse("White");
        }

    }

	private void greenSlider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
        int colorBit = Int32.Parse(Math.Round(greenSlider.Value).ToString());

        colorGreen = colorBit.ToString("X2");

        btnColor.Text = $"#{colorRed}{colorGreen}{colorBlue}";

        ContenidoPagina.BackgroundColor = Color.Parse(btnColor.Text);
        btnRndColor.BackgroundColor = Color.Parse(btnColor.Text);

        if (Int32.Parse(colorRed, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF || Int32.Parse(colorBlue, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF || Int32.Parse(colorGreen, System.Globalization.NumberStyles.HexNumber) >= COLOR_INT_REF)
        {
            btnRndColor.TextColor = Color.Parse("Black");
        }
        else
        {
            btnRndColor.TextColor = Color.Parse("White");
        }

    }

	private void btnRndColor_Clicked(object sender, EventArgs e)
	{
		int colorBitRed = random.Next(0, 256);
        int colorBitBlue = random.Next(0, 256);
        int colorBitGreen = random.Next(0, 256);

		redSlider.Value = colorBitRed;
		blueSlider.Value = colorBitBlue;
		greenSlider.Value = colorBitGreen;

        colorRed = colorBitRed.ToString("X2");
        colorGreen = colorBitBlue.ToString("X2");
        colorGreen = colorBitGreen.ToString("X2");

        btnColor.Text = $"#{colorRed}{colorGreen}{colorBlue}";

        ContenidoPagina.BackgroundColor = Color.Parse(btnColor.Text);
        btnRndColor.BackgroundColor = Color.Parse(btnColor.Text);

        if (colorBitRed >= COLOR_INT_REF || colorBitBlue >= COLOR_INT_REF || colorBitGreen >= COLOR_INT_REF)
        {
            btnRndColor.TextColor = Color.Parse("Black");
        }
        else
        {
            btnRndColor.TextColor = Color.Parse("White");
        }

    }

	private void btnColor_Clicked(object sender, EventArgs e)
	{
        Clipboard.SetTextAsync(btnColor.Text);
    }
}

