using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
/*
namespace WpfDependensyPropertyApp
{
    internal class MyTextBlock : System.Windows.FrameworkElement, IServiceProvider, System.Windows.IContentHost
    {
        public static readonly DependencyProperty TextProperty;

        static MyTextBlock()
        {
            TextProperty = DependencyProperty.Register(
                "Text",
                typeof(string),
                typeof(MyTextBlock),
                new FrameworkPropertyMetadata(
                    string.Empty
                    )
                );
        }

        public string Text
        {
            get
            {
                return GetValue(TextProperty) as string;
            }
            set
            {
                SetValue(TextProperty, value);
            }
        }


        public IEnumerator<IInputElement> HostedElements => throw new NotImplementedException();

        public ReadOnlyCollection<Rect> GetRectangles(ContentElement child)
        {
            throw new NotImplementedException();
        }

        public object? GetService(Type serviceType)
        {
            throw new NotImplementedException();
        }

        void IContentHost.OnChildDesiredSizeChanged(UIElement child)
        {
            throw new NotImplementedException();
        }
    }
}
*/