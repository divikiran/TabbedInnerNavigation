using Xamarin.Forms;

namespace TabbedNavTest1
{
    public partial class TabbedNavTest1Page : TabbedPage
    {
        public TabbedNavTest1Page()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
