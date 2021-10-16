using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TemPage
{
    public partial class MainPage : HeaderFooterPage
    {
        Label TemLabel;
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnApplyTemplate()
        {
            base.OnApplyTemplate();
            TemLabel = (Label)GetTemplateChild("СhangeThemeLabel");
            TemLabel.Text =
            OriginalTemplate ? "Gray Theme" : "Blue Theme";
        }
    }
}

