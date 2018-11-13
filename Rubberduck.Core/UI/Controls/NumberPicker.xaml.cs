﻿using System;
using System.ComponentModel;
using System.Windows;

// credit to http://stackoverflow.com/a/2752538
namespace Rubberduck.UI.Controls
{
    /// <summary>
    /// Interaction logic for NumberPicker.xaml
    /// </summary>
    public partial class NumberPicker : IDataErrorInfo
    {
        public static readonly DependencyProperty NumValueProperty =
            DependencyProperty.Register("NumValue", typeof(int), typeof(NumberPicker), new UIPropertyMetadata(null));
        public static readonly DependencyProperty MinNumberProperty =
            DependencyProperty.Register("MinNumber", typeof(int), typeof(NumberPicker), new UIPropertyMetadata(null));
        public static readonly DependencyProperty MaxNumberProperty =
            DependencyProperty.Register("MaxNumber", typeof(int), typeof(NumberPicker), new UIPropertyMetadata(null));

        public int NumValue
        {
            get => (int)GetValue(NumValueProperty);
            set
            {
                SetValue(NumValueProperty, value);
                OnPropertyChanged(new DependencyPropertyChangedEventArgs(NumValueProperty, NumValue - 1, NumValue));
            }
        }


        public int MinNumber
        {
            get => (int)GetValue(MinNumberProperty);
            set
            {
                SetValue(MinNumberProperty, value);
                OnPropertyChanged(new DependencyPropertyChangedEventArgs(MinNumberProperty, NumValue - 1, NumValue));
            }
        }

        public int MaxNumber
        {
            get => (int)GetValue(MaxNumberProperty);
            set
            {
                SetValue(MaxNumberProperty, value);
                OnPropertyChanged(new DependencyPropertyChangedEventArgs(MaxNumberProperty, NumValue - 1, NumValue));
            }
        }

        public NumberPicker()
        {
            InitializeComponent();
        }

        private void cmdUp_Click(object sender, RoutedEventArgs e)
        {
            NumValue++;
        }

        private void cmdDown_Click(object sender, RoutedEventArgs e)
        {
            NumValue--;
        }

        public string this[string columnName]
        {
            get
            {
                if (columnName != "NumValue")
                {
                    return string.Empty;
                }

                if (NumValue < MinNumber || NumValue > MaxNumber)
                {
                    return "Invalid Selection";
                }

                return string.Empty;
            }
        }

        public string Error { get; private set; }
    }
}
