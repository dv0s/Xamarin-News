using System.Web;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace News.Views
{
    [QueryProperty("Url", "url")]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArticleView : ContentPage
    {
        public string Url
        {
            set
            {
                BindingContext = new UrlWebViewSource
                {
                    Url = HttpUtility.UrlDecode(value)
                };
            }
        }
        public ArticleView()
        {
            InitializeComponent();
        }
    }
}