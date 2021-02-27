using ShapesApp.Infrastructure;
using System.Windows;

namespace ShapesApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private IEditor editor;
        /// <summary>
        /// Ссылка на объект редактора
        /// </summary>
        public IEditor Editor
        {
            get { return editor; }
            set
            {
                value.Canvas = canvas;
                editor = value;
            }
        }
    }
}
