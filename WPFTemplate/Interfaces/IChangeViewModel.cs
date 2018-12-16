﻿using WPFTemplate.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFTemplate.Interfaces
{
    interface IChangeViewModel
    {
        void PushViewModel(BaseViewModel model);
        void PopViewModel();
    }
}
