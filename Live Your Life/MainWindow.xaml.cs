using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Live_Your_Life
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region FormInternalFunctions

        void SuppressErrors()
        {
            dynamic activeX = this.Titanium.GetType().InvokeMember("ActiveXInstance",
                System.Reflection.BindingFlags.GetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, this.Titanium, new object[] { });
            activeX.Silent = true;
        } 
        #endregion
        public MainWindow()
        {
            InitializeComponent();
            

        }
        void CreateNew(object sender, RoutedEventArgs e)
        {
            meraBilla.Visibility = Visibility.Hidden;
            teraBilla.Visibility = Visibility.Visible;
            }
        void OpenProject(object sender, RoutedEventArgs e)
        {

            Titanium.Navigate("http://192.168.5.17:8100/");
            SuppressErrors();
        }
        void Save(object sender, RoutedEventArgs e)
        {
        }
        void Exit(object sender, RoutedEventArgs e)
        {
        }
        void Simulate(object sender, RoutedEventArgs e)
        {
        }

    }
    public enum Templates
    {
        blank,
        sidemenu,
        tabs
    }
    class Project
    {

        public static void CreateProject(string ProjectName, Templates template)
        {
            
        }
        public static void LoadProject(string ProjectName)
        {

        }
    }
    class Module
    {
        public Routes routes { get; set; }

    }
    class Routes
    {
        public List<Page> routes { get; set; }
        public void RouteAdd(Page page)
        {
            routes.Add(page);
            /*
             * to be implemented app.js routes manipulation 
             */
        }
    }
    class Page
    {
        public string Name { get; set; }
        public View View { get; set; }
        public Controller Controller { get; set; }
        public Dictionary<string,string> parameters { get; set; }
        public Page()
        {
            parameters = new Dictionary<string, string>();
        }

    }
    class View
    {
        public string template { get; set; }
        public View(string template)
        {
            this.template = template;
        }
    }
    class Controller
    {
        public string controller { get; set; }
        public Controller(string controller)
        {
            this.controller = controller;
        }
    }

}