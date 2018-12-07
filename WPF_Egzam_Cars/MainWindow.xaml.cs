using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
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
using WPF_Egzam_Cars.DAL;
using WPF_Egzam_Cars.Locazation;

namespace WPF_Egzam_Cars
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public static class ColorsMenu
    {
        public static SolidColorBrush YellowColor = new SolidColorBrush(Color.FromRgb(251, 187, 0));
        public static SolidColorBrush GrayColor = new SolidColorBrush(Color.FromRgb(61, 61, 61));
        public static SolidColorBrush OrangeColor = new SolidColorBrush(Color.FromRgb(255, 128, 0));
    }

    public partial class MainWindow : Window
    {
        public void UpdateUI()
        {
            TextBlockGlav.Text = LeftMenu.Main;
            TextBlockOtlRab.Text = LeftMenu.DeferredWork;
            TextBlockVipRab.Text = LeftMenu.CompletedWork;
            TextBlockAgreg.Text = LeftMenu.Unit;
            TextBlockMotoHaur.Text = LeftMenu.EngineHours;
            TextBlockRashMat.Text = LeftMenu.Consumables;
            TextBlockPlan.Text = LeftMenu.Planning;
            TextBlockProject.Text = LeftMenu.Project;
            TextBlockListOfCars.Text = LeftMenu.MachineList;
            TextBlockSprav.Text = LeftMenu.Directories;
            TextBlockDost.Text = LeftMenu.Accesses;
            TextBoxCheck.Text = LeftMenu.Checklist;
            TextBoxReports.Text = LeftMenu.Reports;
        }

        public void UpdateLocalization(string lang)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(lang);
        }
        public MainWindow()
        {
            InitializeComponent();

            UpdateLocalization("ru");

            UpdateUI();
        }

        #region Кнопка Главное - смена иконок
        private void ButtonGlav_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageHome.Source = new BitmapImage(new Uri(@"Menu_png\Home_b.png", UriKind.RelativeOrAbsolute));
            ImageArrHome.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonGlav_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageHome.Source = new BitmapImage(new Uri(@"Menu_png\Home_g.png", UriKind.RelativeOrAbsolute));
            ImageArrHome.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Отложенные работы - смена иконок
        private void ButtonOtlRab_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageOtlRab.Source = new BitmapImage(new Uri(@"Menu_png\information_b.png", UriKind.RelativeOrAbsolute));
            ImageArrOtlRab.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonOtlRab_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageOtlRab.Source = new BitmapImage(new Uri(@"Menu_png\information_g.png", UriKind.RelativeOrAbsolute));
            ImageArrOtlRab.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Выполненные работы - смена иконок
        private void ButtonVipRab_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageVipRab.Source = new BitmapImage(new Uri(@"Menu_png\key_b.png", UriKind.RelativeOrAbsolute));
            ImageArrVipRab.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonVipRab_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageVipRab.Source = new BitmapImage(new Uri(@"Menu_png\key_g.png", UriKind.RelativeOrAbsolute));
            ImageArrVipRab.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Агрегат - смена иконок
        private void ButtonAgreg_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageAgreg.Source = new BitmapImage(new Uri(@"Menu_png\Cogs_b.png", UriKind.RelativeOrAbsolute));
            ImageArrAgreg.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonAgreg_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageAgreg.Source = new BitmapImage(new Uri(@"Menu_png\Cogs_g.png", UriKind.RelativeOrAbsolute));
            ImageArrAgreg.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Моточасы - смена иконок
        private void ButtonMotochas_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageMotochas.Source = new BitmapImage(new Uri(@"Menu_png\clock_b.png", UriKind.RelativeOrAbsolute));
            ImageArrMotochas.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonMotochas_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageMotochas.Source = new BitmapImage(new Uri(@"Menu_png\clock_g.png", UriKind.RelativeOrAbsolute));
            ImageArrMotochas.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Расходные материалы - смена иконок
        private void ButtonRashMat_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageRashMat.Source = new BitmapImage(new Uri(@"Menu_png\drop_b.png", UriKind.RelativeOrAbsolute));
            ImageArrRashMat.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonRashMat_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageRashMat.Source = new BitmapImage(new Uri(@"Menu_png\drop_g.png", UriKind.RelativeOrAbsolute));
            ImageArrRashMat.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка План - смена иконок
        private void ButtonPlan_MouseEnter(object sender, MouseEventArgs e)
        {
            ImagePlan.Source = new BitmapImage(new Uri(@"Menu_png\calendar_b.png", UriKind.RelativeOrAbsolute));
            ImageArrPlan.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonPlan_MouseLeave(object sender, MouseEventArgs e)
        {
            ImagePlan.Source = new BitmapImage(new Uri(@"Menu_png\calendar_g.png", UriKind.RelativeOrAbsolute));
            ImageArrPlan.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Проект - смена иконок
        private void ButtonProect_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageProect.Source = new BitmapImage(new Uri(@"Menu_png\world_b.png", UriKind.RelativeOrAbsolute));
            ImageArrProect.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonProect_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageProect.Source = new BitmapImage(new Uri(@"Menu_png\world_g.png", UriKind.RelativeOrAbsolute));
            ImageArrProect.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Список машин - смена иконок
        private void ButtonListOfCars_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageListOfCars.Source = new BitmapImage(new Uri(@"Menu_png\CAR_B.png", UriKind.RelativeOrAbsolute));
            ImageArrListOfCars.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonListOfCars_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageListOfCars.Source = new BitmapImage(new Uri(@"Menu_png\CAR_G.png", UriKind.RelativeOrAbsolute));
            ImageArrListOfCars.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Справочник - смена иконок
        private void ButtonSprav_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageSprav.Source = new BitmapImage(new Uri(@"Menu_png\graph_b.png", UriKind.RelativeOrAbsolute));
            ImageArrSprav.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonSprav_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageSprav.Source = new BitmapImage(new Uri(@"Menu_png\graph_g.png", UriKind.RelativeOrAbsolute));
            ImageArrSprav.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка доступы - смена иконок
        private void ButtonDost_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageDost.Source = new BitmapImage(new Uri(@"Menu_png\people_b.png", UriKind.RelativeOrAbsolute));
            ImageArrDost.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonDost_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageDost.Source = new BitmapImage(new Uri(@"Menu_png\people_g.png", UriKind.RelativeOrAbsolute));
            ImageArrDost.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Checklist - смена иконок
        private void ButtonCheck_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageCheck.Source = new BitmapImage(new Uri(@"Menu_png\magic_wand_b.png", UriKind.RelativeOrAbsolute));
            ImageArrCheck.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonCheck_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageCheck.Source = new BitmapImage(new Uri(@"Menu_png\magic_wand_g.png", UriKind.RelativeOrAbsolute));
            ImageArrCheck.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        #region Кнопка Отчеты - смена иконок
        private void ButtonReports_MouseEnter(object sender, MouseEventArgs e)
        {
            ImageReports.Source = new BitmapImage(new Uri(@"Menu_png\paper_b.png", UriKind.RelativeOrAbsolute));
            ImageArrReports.Source = new BitmapImage(new Uri(@"Menu_png\Arr.png", UriKind.RelativeOrAbsolute));
        }

        private void ButtonReports_MouseLeave(object sender, MouseEventArgs e)
        {
            ImageReports.Source = new BitmapImage(new Uri(@"Menu_png\paper_g.png", UriKind.RelativeOrAbsolute));
            ImageArrReports.Source = new BitmapImage(new Uri(@"Menu_png\Arr_empt.png", UriKind.RelativeOrAbsolute));
        }
        #endregion

        //Событие выбора языка
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                ComboBox comboBox = (ComboBox)sender;
                ComboBoxItem selectedItem = (ComboBoxItem)comboBox.SelectedItem;

                string Lang = selectedItem.Content.ToString();

                if (Lang == "Русский")
                {
                    ImageFlag.Source = new BitmapImage(new Uri(@"Bar_png\ruFlag.png", UriKind.RelativeOrAbsolute));
                    UpdateLocalization("ru");
                    UpdateUI();
                }
                else
                {
                    ImageFlag.Source = new BitmapImage(new Uri(@"Bar_png\usFlag.png", UriKind.RelativeOrAbsolute));
                    UpdateLocalization("en-US");
                    UpdateUI();
                }
            }
            catch (Exception)
            {
                UpdateLocalization("ru");
            }
        }
    }
}
