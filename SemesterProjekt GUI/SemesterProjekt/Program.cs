﻿using SemesterProjekt.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterProjekt
{
    public class Program
    {
        /// <summary>
        /// Method Opens GUI "BGFStartside"
        /// </summary>
        static void Main(string[] args)
        {
            Application.Run(new BGFStartside());
        }
    }

}

