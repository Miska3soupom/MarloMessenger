using mrl.Models;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace mrl
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // добавление данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // создаем два объекта User
                
                User user1 = new User
                {
                    Firstname = "Tom",
                    Lastname = "Sanders",
                    Patronymic = "P",
                    Login = "dd",
                    HashedPassword = "",
                    IsDeleted = false,
                    CloudAuth = false,
                    JiraAuth = false,
                    WikiAuth = false
                };
                User user2 = new User
                {
                    Firstname = "Alice",
                    Lastname = "Stanford",
                    Patronymic = "P",
                    Login = "dd",
                    HashedPassword = "",
                    IsDeleted = false,
                    CloudAuth = false,
                    JiraAuth = false,
                    WikiAuth = false
                };

                // добавляем их в бд
                
                db.Users.AddRange(user1, user2);
                db.SaveChanges();
            }
            // получение данных
            using (ApplicationContext db = new ApplicationContext())
            {
                // получаем объекты из бд и выводим на консоль
                var users = db.Users.ToList();
                foreach (User u in users)
                {
                    TextBlock textBlock = new TextBlock() { Text = $"{u.Firstname} {u.Lastname} - auth is {u.CloudAuth}", Margin = new Thickness() { Top = 10, Left = 20 } };
                    Users.Children.Add(textBlock);
                }
            }
        }
    }
}