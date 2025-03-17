using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace ChalkeeDesktop.Helpers
{
    public static class PasswordBoxHelper
    {
        public static readonly DependencyProperty BoundPasswordProperty =
            DependencyProperty.RegisterAttached(
                "BoundPassword", typeof(string), typeof(PasswordBoxHelper), 
                new FrameworkPropertyMetadata(string.Empty, OnBoundPasswordChanged));

        public static void SetBoundPassword(DependencyObject obj, string value)
        {
            obj.SetValue(BoundPasswordProperty, value);
        }

        public static string GetBoundPassword(DependencyObject obj)
        {
            return (string)obj.GetValue(BoundPasswordProperty);
        }

        private static void OnBoundPasswordChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var passwordBox = d as PasswordBox;
            if (passwordBox == null) return;

            if (e.NewValue != null)
            {
                passwordBox.Password = e.NewValue.ToString();
            }

            passwordBox.PasswordChanged += (sender, args) =>
            {
                SetBoundPassword(passwordBox, passwordBox.Password);
            };
        }
    }
}