﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessProj
{
    public static class Globals
    {
        public static int Progress = 0;
        public static int level = 1;
        public static List<FitnessType> fList = new List<FitnessType>();
        public static bool isDarkMode = false;
        public static int requiredProgress;
        public static void updateProgress()
        {
            //fix? just adds 1
            requiredProgress = Convert.ToInt32((level + 99) * 1.2);
        }
        public static List<Account> aList = new List<Account>();
        public static int index = 0;
    }
}
