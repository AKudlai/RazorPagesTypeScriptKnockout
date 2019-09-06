using System.Collections.Generic;

namespace RazorPagesTypeScriptKnockout.Models
{
    public class Folder
    {
        public string Id { get; set; }

        public List<Mail> Mails { get; set; } = new List<Mail>();
    }
}