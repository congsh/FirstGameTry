using FirstGameTry.Models;
using FirstGameTry.Modules;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstGameTry
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        GamePad? gamePad;
        public MainWindow()
        {
            InitializeComponent();
            InitGame();
            DrawMap();
        }

        private void InitGame()
        {
            gamePad = GamePad.getInstance();
            gamePad.Techs = gamePad.Food = gamePad.Golds = gamePad.Metals = 0;
        }

        private void DrawMap()
        {
            gamePad = GamePad.getInstance();
            var map = gamePad.map;
            if (map == null)
            {
                map = new Map()
                {
                    Columns = 5,
                    Rows = 5,
                };
            }
            
        }

        private void Update()
        {
            RefreshService.Update();
            gamePad = GamePad.getInstance();
            this.GoldLabel.Content = "黄金:" + gamePad.Golds;
            this.TechLabel.Content = "科技:" + gamePad.Techs;
            this.MetaLabel.Content = "矿物:" + gamePad.Metals;
            this.FoodLabel.Content = "食物:" + gamePad.Food;
        }
    }
}
