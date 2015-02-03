﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnotherSc2Hack.Classes.BackEnds.Preference
{
    public class PreferenceAll
    {
        public PreferenceGlobal Global { get; set; }
        public PreferenceOverlayResources OverlayResources { get; set; }
        public PreferenceOverlayWorker OverlayWorker { get; set; }
        public PreferenceOverlayUnits OverlayUnits { get; set; }
        public PreferenceOverlayProduction OverlayProduction { get; set; }
        public PreferenceOverlayIncome OverlayIncome { get; set; }
        public PreferenceOverlayArmy OverlayArmy { get; set; }
        public PreferenceOverlayApm OverlayApm { get; set; }
        public PreferenceOverlayMaphack OverlayMaphack { get; set; }

        public PreferenceAll()
        {
            Global = new PreferenceGlobal();
            OverlayResources = new PreferenceOverlayResources();
            OverlayIncome = new PreferenceOverlayIncome();
            OverlayWorker = new PreferenceOverlayWorker();
            OverlayApm = new PreferenceOverlayApm();
            OverlayArmy = new PreferenceOverlayArmy();
            OverlayProduction = new PreferenceOverlayProduction();
            OverlayUnits = new PreferenceOverlayUnits();
            OverlayMaphack = new PreferenceOverlayMaphack();
        }
    }

    
}
