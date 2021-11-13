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

namespace Practic5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        Pair _firstPair = new Pair();
        Pair _secondPair = new Pair();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void help_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("ИСП-31. Назаров Д. Вариант 2. \nСоздать класс Pair (пара чисел). Создать необходимые методы и свойства. Определить методы метод сложения полей и операцию сложения пар(а, b) + (с, d)= (а + c, b + d).\nСоздать перегруженные методы для увеличения полей на 1, сложения трех пар чисел.", "О программе");
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void startSum_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInFirstPair1 = Int32.TryParse(firstPairFirstNumber.Text, out int firstNumberPair1);
            bool isNotErrorInSecondPair1 = Int32.TryParse(firstPairSecondNumber.Text, out int secondNumberPair1);
            bool isNotErrorInFirstPair2 = Int32.TryParse(secondPairFirstNumber.Text, out int firstNumberPair2);
            bool isNotErrorInSecondPair2 = Int32.TryParse(secondPairSecondNumber.Text, out int secondNumberPair2);
            if(isNotErrorInFirstPair1 && isNotErrorInFirstPair2 && isNotErrorInSecondPair1 && isNotErrorInSecondPair2)
            {
                _firstPair.First = firstNumberPair1;
                _firstPair.Second = secondNumberPair1;
                _secondPair.First = firstNumberPair2;
                _secondPair.Second = secondNumberPair2;
                Pair endPair = new Pair();
                endPair = _firstPair  + _secondPair;
                endSum.Text = $"{endPair.First}, {endPair.Second}";
            }
            else
            {
                MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                firstPairFirstNumber.Clear();
                firstPairSecondNumber.Clear();
                secondPairFirstNumber.Clear();
                secondPairSecondNumber.Clear();
                endSum.Clear();
            }
        }

        private void addToFirstPair_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInFirst = Int32.TryParse(firstPairFirstNumber.Text, out int firstNumber);
            bool isNotErrorInSecond = Int32.TryParse(firstPairSecondNumber.Text, out int secondNumber);
            if (isNotErrorInFirst && isNotErrorInSecond)
            {
                _firstPair.First = firstNumber;
                _firstPair.Second = secondNumber;
                _firstPair++;
                firstPairFirstNumber.Text = _firstPair.First.ToString();
                firstPairSecondNumber.Text = _firstPair.Second.ToString();
                endSum.Clear();
            }
            else 
            {
                MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                firstPairFirstNumber.Clear();
                firstPairSecondNumber.Clear();
            }

        }

        private void addToSecondPair_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInFirst = Int32.TryParse(secondPairFirstNumber.Text, out int firstNumber);
            bool isNotErrorInSecond = Int32.TryParse(secondPairSecondNumber.Text, out int secondNumber);
            if (isNotErrorInFirst && isNotErrorInSecond)
            {
                _secondPair.First = firstNumber;
                _secondPair.Second = secondNumber;
                _secondPair++;
                secondPairFirstNumber.Text = _secondPair.First.ToString();
                secondPairSecondNumber.Text = _secondPair.Second.ToString();
                endSum.Clear();
            }
            else
            {
                MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                secondPairFirstNumber.Clear();
                secondPairSecondNumber.Clear();
            }
        }

        private void addNumber_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInNumber = int.TryParse(numberToAdd.Text, out int number);
            if (isNotErrorInNumber)
            {
                _firstPair.Add(number);
                _secondPair.Add(number);

                firstPairFirstNumber.Text = _firstPair.First.ToString();
                firstPairSecondNumber.Text = _firstPair.Second.ToString();

                secondPairFirstNumber.Text = _secondPair.First.ToString();
                secondPairSecondNumber.Text = _secondPair.Second.ToString();
                endSum.Clear();
            }
            else
            {
                MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                numberToAdd.Clear();
            }
        }

        private void removeFromFirstPair_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInFirst = Int32.TryParse(firstPairFirstNumber.Text, out int firstNumber);
            bool isNotErrorInSecond = Int32.TryParse(firstPairSecondNumber.Text, out int secondNumber);
            if (isNotErrorInFirst && isNotErrorInSecond)
            {
                _firstPair.First = firstNumber;
                _firstPair.Second = secondNumber;
                _firstPair--;
                firstPairFirstNumber.Text = _firstPair.First.ToString();
                firstPairSecondNumber.Text = _firstPair.Second.ToString();
                endSum.Clear();
            }
            else
            {
                MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                firstPairFirstNumber.Clear();
                firstPairSecondNumber.Clear();
            }
        }

        private void removeFromSecondPair_Click(object sender, RoutedEventArgs e)
        {
            bool isNotErrorInFirst = Int32.TryParse(secondPairFirstNumber.Text, out int firstNumber);
            bool isNotErrorInSecond = Int32.TryParse(secondPairSecondNumber.Text, out int secondNumber);
            if (isNotErrorInFirst && isNotErrorInSecond)
            {
                _secondPair.First = firstNumber;
                _secondPair.Second = secondNumber;
                _secondPair--;
                secondPairFirstNumber.Text = _secondPair.First.ToString();
                secondPairSecondNumber.Text = _secondPair.Second.ToString();
                endSum.Clear();
            }
            else
            {
                MessageBox.Show("Введены некоректные значения, введите другие", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                secondPairFirstNumber.Clear();
                secondPairSecondNumber.Clear();
            }
        }
    }
}
