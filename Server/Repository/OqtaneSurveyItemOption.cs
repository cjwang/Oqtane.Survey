﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Oqtane.Survey.Server.Repository
{
    public partial class OqtaneSurveyItemOption
    {
        public int Id { get; set; }
        public int SurveyItem { get; set; }
        public string OptionLabel { get; set; }

        public virtual OqtaneSurveyItem SurveyItemNavigation { get; set; }
    }
}