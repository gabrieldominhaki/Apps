namespace Aplicativo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double  etanol = Convert.ToDouble(txt_Etanol.Text);
                double  gasolina = Convert.ToDouble(txt_Gasolina.Text);

                if (etanol <= 0.7 * gasolina) {
                    DisplayAlert("ETANOL!", "Nesse caso o etanol compensa mais.", "Sair.");
                }
                else
                {
                    DisplayAlert("GASOLINA!", "Nesse caso a gasolina compensa mais.", "Sair.");
                }



            }
            catch (Exception ex)
            {
                DisplayAlert("Ops...", ex.Message ,"Fechar");
            }
        }
    }
}
