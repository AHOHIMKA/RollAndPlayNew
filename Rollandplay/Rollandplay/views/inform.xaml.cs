using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Rollandplay.views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class inform : ContentPage
    {
        public ObservableCollection<InformItem> InformItems { get; set; }

        public inform()
        {
            InitializeComponent();

            // Инициализация списка
            InformItems = new ObservableCollection<InformItem>
            {
                new InformItem { Number = 1, ActionName = "Бросок кубика", ImageSource = "dice.png" },
                new InformItem { Number = 2, ActionName = "Создание листа персонажа", ImageSource = "character_sheet.png" },
                // Добавьте остальные элементы в список
            };

            // Установка источника данных для ListView
            informListView.ItemsSource = InformItems;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item is InformItem selectedItem)
            {
                // Обработка нажатия на элемент списка
                // В этом методе вы можете выполнить необходимые действия при нажатии на элемент
                // Например, перейти на нужную страницу
            }

            // Сброс выделения элемента
            ((ListView)sender).SelectedItem = null;
        }
    }



    public class InformItem
    {
        public int Number { get; set; }
        public string ActionName { get; set; }
        public string ImageSource { get; set; }
    }
}