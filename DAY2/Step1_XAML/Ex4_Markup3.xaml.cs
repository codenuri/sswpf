﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Step1_XAML
{
    // property 를 가진 사용자정의 markup up
    public class FontInfo : MarkupExtension
    {
        public string Element { get; set; }
        public string Key { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if ( Element == "Title" )
            {
                switch(Key)
                {
                    case "FontSize": return (Double)30;
                    case "Background": return new SolidColorBrush(Colors.Yellow);
                }
            } 
            else if ( Element == "SubTitle")
            {
                switch (Key)
                {
                    case "FontSize": return (Double)12;
                    case "Background": return new SolidColorBrush(Colors.Green);
                }
            }
            return null;
        }
        
    }







    public partial class Ex4_Markup3 : Window
    {
        public Ex4_Markup3()
        {
            InitializeComponent();
        }
    }
}
