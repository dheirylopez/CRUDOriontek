﻿using SGClaves.General;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGClaves
{
    public interface IDescripcion : IView
    {

    }
    public partial class FormDescripcion : FormBase
    {
        public FormDescripcion()
        {
            InitializeComponent();
        }
    }
}
