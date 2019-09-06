﻿using System;

namespace RazorPagesTypeScriptKnockout.Models
{
    public class Mail
    {
        public int Id { get; set; }

        public string From { get; set; }
        
        public string To { get; set; }
        
        public DateTime Date { get; set; }
        
        public string Subject { get; set; }
        
        public string Folder { get; set; }
        
        public string MessageContent { get; set; }
    }
}