using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RSSReader {
    public partial class Form1 : Form {

        IEnumerable<string> xTitle,xLink;

        public Form1()
        {
            InitializeComponent();
        }

    private void btRssGet_Click(object sender, EventArgs e)
        {
            using (var wc = new WebClient())
            {
                //var stream = wc.OpenRead("https://news.yahoo.co.jp/rss/media/jomo/all.xml");
                var stream = wc.OpenRead(cbRssUrl.Text);

                var xdoc = XDocument.Load(stream);

                xTitle = xdoc.Root.Descendants("item").Select(x => (string)x.Element("title"));
                xLink = xdoc.Root.Descendants("item").Select(x => (string)x.Element("link"));

                foreach (var data in xTitle)
                {
                    lbRssTitle.Items.Add(data);
                }
            }
        }

        private void lbRssTitle_Click(object sender, EventArgs e)
        {

            if (lbRssTitle.SelectedIndex != -1)
            {
                int index = lbRssTitle.SelectedIndex;

                var url = xLink.ElementAt(index);

                //wbBrowser.Navigate(url);
                wvBrowser.Source = new Uri(url);
            }
            btback.Enabled = wvBrowser.CanGoBack;
        }

        private void btback_Click(object sender, EventArgs e)
        {
            wvBrowser.GoBack();
            btback.Enabled = wvBrowser.CanGoBack;

        }

        private void btAdvance_Click(object sender, EventArgs e)
        {
            wvBrowser.GoForward();
            btAdvance.Enabled = wvBrowser.CanGoBack;
        }

        private void wvBrowser_NavigationCompleted(object sender, Microsoft.Toolkit.Win32.UI.Controls.Interop.WinRT.WebViewControlNavigationCompletedEventArgs e)
        {
            btback.Enabled = wvBrowser.CanGoBack;
            btAdvance.Enabled = wvBrowser.CanGoBack;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            btback.Enabled = wvBrowser.CanGoBack;

        }

    }
}
