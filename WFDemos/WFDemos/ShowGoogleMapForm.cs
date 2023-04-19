using CefSharp;
using CefSharp.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDemos
{
    /// <summary>
    /// Because we display static content I think it's not nesessary to use Google Maps API. Use only url from your project
    /// </summary>


    public partial class ShowGoogleMapForm : Form
    {
        const string APIKey = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";

        private readonly ChromiumWebBrowser browser = new ChromiumWebBrowser();

        public ShowGoogleMapForm()
        {
            InitializeComponent();

            //// Replace YOUR_API_KEY with your actual API key
            //string url = $"https://www.google.com/maps/embed/v1/place?key={APIKey}&q=обменни+бюра+Бургас";
            //string html = $"<html><head><title>Google Maps</title></head><body><iframe width='1400' height='1200' frameborder='0' style='border:0' src='{url}'></iframe></body></html>";
            //browser.LoadHtml(html);

            // Replace YOUR_API_KEY with your actual API key
            string url = $"https://www.google.com/maps/embed/v1/search?key={APIKey}&q=currency+exchange+in+burgas";
            string html = $"<html><head><title>Google Maps</title></head><body><iframe width='1400' height='1200' frameborder='0' style='border:0' src='{url}'></iframe></body></html>";
            browser.LoadHtml(html);

            ////// Hide the command buttons on the map
            ////browser.FrameLoadEnd += (sender, args) =>
            ////{
            ////    var frame = args.Frame;
            ////    var script = @"var styleElement = document.createElement('style');
            ////        styleElement.innerHTML = '.gm-fullscreen-control, .gmnoprint .gm-bundled-control, .gm-style .gm-bundled-control { display: none; }';
            ////        document.getElementsByTagName('head')[0].appendChild(styleElement);";
            ////    frame.ExecuteJavaScriptAsync(script);
            ////};

            //// Add the ChromiumWebBrowser control to the form
            browser.Dock = DockStyle.Fill;
            this.Controls.Add(browser);
        }
    }
}
