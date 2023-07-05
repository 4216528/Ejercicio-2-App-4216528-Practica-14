namespace Ejercicio2;

public partial class MainPage : ContentPage
{

    public MainPage()

    {

        InitializeComponent();

    }

    ///<Summary>
    ///<Createddate>03-07-2023</createddate>
    ///<company>SandBox</company>
    ///<lastmodificationdate>03-07-2023</lastmodificationdate>
    ///<lastmodificationdescription>Ninguna</lastmodificationdescription>
    ///<lastmodifierautor>Nery</lastmodifierautor>
    ///</Summary>

    public void OnCounterClicked(object sender, EventArgs e)

    {

        // Mostramos el resultado con la propiedad DisplayAlert y un mensaje personalizado //

        double A = double.Parse(AEntry.Text);

        double B = double.Parse(BEntry.Text);

        double result = Math.Pow(A + B, 2) / 2;

        Resultado.Text = result.ToString();

    }
}
