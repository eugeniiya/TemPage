using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace TemPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HeaderFooterPage : ContentPage
    {
        ControlTemplate GrayTemplate;
        ControlTemplate BlueTemplate;
        public static readonly BindableProperty
        HeaderTextProperty =
        BindableProperty.Create(nameof(HeaderText),
        typeof(string),
        typeof(HeaderFooterPage),
        default(string));
        public string HeaderText
        {
            get => (string)GetValue(HeaderTextProperty);
            set => SetValue(HeaderTextProperty, value);
        }
        bool original = true;
        public bool OriginalTemplate
        {
            get { return original; }
        }
        public HeaderFooterPage()
        {
            InitializeComponent();
            GrayTemplate =
            (ControlTemplate)Resources["GrayTemplate"];
            BlueTemplate =
            (ControlTemplate)Resources["BlueTemplate"];
        }
        void OnChangeTheme(object sender, EventArgs e)
        {
            original = !original;
            ControlTemplate =
            (original) ? GrayTemplate : BlueTemplate;
        }
    }
}
