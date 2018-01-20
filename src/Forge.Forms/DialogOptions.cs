﻿using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Forge.Forms
{
    public class DialogOptions : INotifyPropertyChanged
    {
        public static DialogOptions Default = new DialogOptions();

        private double width = 350d;
        private double height = double.NaN;
        private Thickness padding = new Thickness(16d, 16d, 16d, 8d);
        private double titleFontSize = 20d;
        private double headingFontSize = 15d;
        private double textFontSize = 15d;

        public DialogOptions()
            : this(Default)
        {
        }

        public DialogOptions(DialogOptions defaults)
        {
            if (defaults == null)
            {
                return;
            }

            width = defaults.width;
            height = defaults.height;
            padding = defaults.padding;
            titleFontSize = defaults.titleFontSize;
            headingFontSize = defaults.headingFontSize;
            textFontSize = defaults.textFontSize;
        }

        public double Width
        {
            get => width;
            set
            {
                if (value.Equals(width)) return;
                width = value;
                OnPropertyChanged();
            }
        }

        public double Height
        {
            get => height;
            set
            {
                if (value.Equals(height)) return;
                height = value;
                OnPropertyChanged();
            }
        }


        public Thickness Padding
        {
            get => padding;
            set
            {
                if (value == padding) return;
                padding = value;
                OnPropertyChanged();
            }
        }

        public double TitleFontSize
        {
            get => titleFontSize;
            set
            {
                if (value == titleFontSize) return;
                titleFontSize = value;
                OnPropertyChanged();
            }
        }

        public double HeadingFontSize
        {
            get => headingFontSize;
            set
            {
                if (value == headingFontSize) return;
                headingFontSize = value;
                OnPropertyChanged();
            }
        }

        public double TextFontSize
        {
            get => textFontSize;
            set
            {
                if (value == textFontSize) return;
                textFontSize = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}