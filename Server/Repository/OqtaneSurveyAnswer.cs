﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace Oqtane.Survey.Server.Repository
{
    public partial class OqtaneSurveyAnswer
    {
        public int Id { get; set; }
        public int SurveyItemId { get; set; }
        public string AnswerValue { get; set; }
        public DateTime? AnswerValueDateTime { get; set; }
        public int UserId { get; set; }

        public virtual OqtaneSurveyItem SurveyItem { get; set; }
    }
}