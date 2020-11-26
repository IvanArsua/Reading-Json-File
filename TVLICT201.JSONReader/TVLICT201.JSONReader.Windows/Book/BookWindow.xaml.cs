using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Shapes;

namespace TVLICT201.JSONReader.Windows.Book
{
    /// <summary>
    /// Interaction logic for BookWindow.xaml
    /// </summary>
    public partial class BookWindow : Window
    {
        public BookWindow()
        {
            InitializeComponent();
            Book book = new Book();

            using (StreamReader r = new StreamReader("data\\book.json"))
            {
                string json = r.ReadToEnd();
                book = JsonConvert.DeserializeObject<Book>(json);
            }
           
            lblBookId.Content = "Id :" + book.Id;
            lblBookTitle.Content = "Title :" + book.title;
            lblBookAuthor.Content = "Author :" + book.author;
            lblBookPublisher.Content = "Publisher :" + book.publisher;
            lblBookDate.Content = "Date :" + book.date;
        }
    }
}
