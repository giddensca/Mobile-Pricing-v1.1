using System;
using System.Reflection.Emit;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace Mobile_Pricing
{
    public partial class frmMain : Form
    {

        public frmMain()
        {
            InitializeComponent();
            wBrowser.EnsureCoreWebView2Async();

        }
        bool ensure = false;
        private void PriceHelper(double costOfItem, double markupValue, double laborAmount)
        {
            costOfItem = Math.Round(costOfItem / markupValue) - 0.01;
            lblPartPrice.Text = "$" + costOfItem;
            lblRepairPrice.Text = "$" + (costOfItem + laborAmount);
        }

        private void btnPrice_Click(object sender, EventArgs e)
        {
            //Makes it so the user can not get a price if one of the vendors website's haven't been navigated to
            btnGetPrice.Enabled = true;
            if (ensure == true)
            {
                if (cmbSKU.Text == "MobileSentrix")
                    wBrowser.CoreWebView2.Navigate("https://www.mobilesentrix.com");
                else if (cmbSKU.Text == "InjuredGadgets") wBrowser.CoreWebView2.Navigate("https://injuredgadgets.com");
                else if (cmbSKU.Text == "eBay") wBrowser.CoreWebView2.Navigate("https://www.ebay.com");
                else if (cmbSKU.Text == "WholesaleGadgetParts") wBrowser.CoreWebView2.Navigate("https://www.wholesalegadgetparts.com");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            wBrowser.GoBack();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            wBrowser.GoForward();
        }

        private void wBrowser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }

        private void btnGetPrice_Click(object sender, EventArgs e)
        {
            var web = new HtmlWeb();
            var htmlDoc = web.Load(wBrowser.Source.ToString());
            string price;

            //Index 0 is MS, Index 1 is InjuredGadgets, Index 2 is WholesaleGadgetParts
            if (cmbLabor.Text != "" && cmbSKU.Text != "")
            {

                
                //MS
                if (cmbSKU.SelectedIndex == 0)
                    {
                        var node = htmlDoc.DocumentNode.SelectNodes("(//span[@class='regular-price']//span)[1]");
                        //Ensures program doesn't crash because the HTML can't be found
                        if (node == null)
                        {
                            MessageBox.Show("You must be on an item page to get a price!");
                        }
                        else
                        {
                            price = node[0].InnerText;
                            price = Regex.Replace(price, "[^. 0-9]", "");

                            switch (cmbLabor.SelectedIndex)
                            {
                                //iPhone Screen Repair
                                case 0:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 300 ? 0.9 : 0.80, 80);
                                    break;
                                //iPhone Battery Repair
                                case 1:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 50 ? 0.80 : 0.70, 60);
                                    break;
                                //iPhone Charging Port Repair
                                case 2:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 25 ? 0.80 : 0.70, 120);
                                    break;
                                //Android Charging Port
                                case 3:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 25 ? 0.80 : 0.70, 60);
                                    break;
                            //iPad Screen
                            case 4:
                                //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                //As well as sending along the labor price
                                PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 100 ? 0.80 : 0.70, 90);
                                break;
                            case 5:
                                    string labor =
                                        Microsoft.VisualBasic.Interaction.InputBox(
                                            "Please Enter a Labor value for the repair below.", "Custom Labor Value", "60");
                                    if (labor.Contains("$"))
                                    {
                                        labor.Trim('$');
                                    }

                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 250 ? 0.85 : 0.75,
                                        Convert.ToDouble(labor));
                                    break;
                            }
                        }
                    }

                    //InjuredGadgets
                    else if (cmbSKU.SelectedIndex == 1)
                    {
                        var node = htmlDoc.DocumentNode.SelectNodes("//span[@class='price-wrapper ']//span[1]");
                        //Ensures program doesn't crash because the HTML can't be found
                        if (node == null)
                        {
                            MessageBox.Show("Select an appropriate Site or Repair Type!");
                        }
                        else
                        {
                            price = node[0].InnerHtml;
                            price = Regex.Replace(price, "[^. 0-9]", "");


                            switch (cmbLabor.SelectedIndex)
                            {
                                //iPhone Screen Repair
                                case 0:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 300 ? 0.9 : 0.85, 80);
                                    break;
                                //iPhone Battery Repair
                                case 1:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 50 ? 0.85 : 0.75, 60);
                                    break;
                                //iPhone Charging Port Repair
                                case 2:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 15 ? 0.85 : 0.75, 120);
                                    break;
                                //Android Charging Port
                                case 3:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 15 ? 0.85 : 0.75, 60);
                                    break;
                                //Other
                                case 4:
                                    string labor =
                                        Microsoft.VisualBasic.Interaction.InputBox(
                                            "Please Enter a Labor value for the repair below.", "Custom Labor Value", "60", 0, 0);
                                    if (labor.Contains("$"))
                                    {
                                        labor.Trim('$');

                                    }

                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 250 ? 0.85 : 0.75,
                                        Convert.ToDouble(labor));
                                    break;
                            }
                        }
                    }
                    //Ebay
                    else if (cmbSKU.SelectedIndex == 2)
                    {
                        var node = htmlDoc.DocumentNode.SelectNodes("//*[@id='mainContent']/form/div[2]/div[1]/div[1]/div[1]/div/div[2]/div/span[1]");

                    //Ensures program doesn't crash because the HTML can't be found
                    if (node == null)
                    {         
                            MessageBox.Show("Something Went Wrong");
                    }
                        else
                        {
                            price = node[0].InnerHtml;
                            price.Trim('7', '0');
                            
                            price = Regex.Replace(price, "[^. 0-9]", "");


                            switch (cmbLabor.SelectedIndex)
                            {
                                //iPhone Screen Repair
                                case 0:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 300 ? 0.9 : 0.85, 80);
                                    break;
                                //iPhone Battery Repair
                                case 1:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 50 ? 0.85 : 0.75, 60);
                                    break;
                                //iPhone Charging Port Repair
                                case 2:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 15 ? 0.85 : 0.75, 120);
                                    break;
                                //Android Charging Port
                                case 3:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 15 ? 0.85 : 0.75, 60);
                                    break;
                                //Other 
                                case 4:
                                    string labor =
                                        Microsoft.VisualBasic.Interaction.InputBox(
                                            "Please Enter a Labor value for the repair below.", "Custom Labor Value", "60", 0, 0);
                                    if (labor.Contains("$"))
                                    {
                                        labor.Trim('$');
                                    }
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 250 ? 0.80 : 0.70,
                                        Convert.ToDouble(labor));
                                    break;
                            }
                        }
                    }
                    //WholesaleGadgetParts
                    else if (cmbSKU.SelectedIndex == 3)
                    {
                        var node = htmlDoc.DocumentNode.SelectNodes("(//span[@class='product-price-value']//span)[1]");
                        //Ensures program doesn't crash because the HTML can't be found
                        if (node == null)
                        {
                            MessageBox.Show("Select an appropriate Site or Repair Type!");
                        }
                        else
                        {
                            price = node[0].InnerHtml;
                            price = Regex.Replace(price, "[^. 0-9]", "");


                            switch (cmbLabor.SelectedIndex)
                            {
                                //iPhone Screen Repair
                                case 0:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 300 ? 0.9 : 0.85, 80);
                                    break;
                                //iPhone Battery Repair
                                case 1:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 50 ? 0.85 : 0.75, 60);
                                    break;
                                //iPhone Charging Port Repair
                                case 2:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 15 ? 0.85 : 0.75, 120);
                                    break;
                                //Android Charging Port
                                case 3:
                                    //Sends the Method PriceHelper the found price from HTML as a double, then uses a ternary operator to decide which markup value to use
                                    //As well as sending along the labor price
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 15 ? 0.85 : 0.75, 60);
                                    break;
                                //Other 
                                case 4:
                                    string labor =
                                        Microsoft.VisualBasic.Interaction.InputBox(
                                            "Please Enter a Labor value for the repair below.", "Custom Labor Value", "60", 0, 0);
                                    if (labor.Contains("$"))
                                    {
                                        labor.Trim('$');

                                    }
                                    PriceHelper(Convert.ToDouble(price), Convert.ToDouble(price) > 250 ? 0.85 : 0.75,
                                        Convert.ToDouble(labor));
                                    break;
                            }
                        }
                    } 
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void wBrowser_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e)
        {
            ensure = true;
        }
    }
}