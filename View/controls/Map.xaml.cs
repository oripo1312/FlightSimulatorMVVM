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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Maps.MapControl.WPF;
using System.ComponentModel;

namespace flightSimulator.View.controls
{
    /// <summary>
    /// Interaction logic for Map.xaml
    /// </summary>
    public partial class Map : UserControl
    {

        public Map()
        {
            InitializeComponent();
            ControlTemplate template = (ControlTemplate)this.FindResource("CutomPushpinTemplate");
            pin.Template = template;



        }



    }
}
