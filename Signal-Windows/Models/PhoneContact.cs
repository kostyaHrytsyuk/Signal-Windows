﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Signal_Windows.Controls;
using Windows.UI.Xaml.Media;

namespace Signal_Windows.Models
{
    public class PhoneContact
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public ImageSource Photo { get; set; }
        public AddContactListElement View;
    }
}
