using System.Collections.Generic;

namespace RazorPagesTypeScriptKnockout.Models
{
    public class WebMail
    {
        public List<Folder> Folders { get; set; } = new List<Folder>();
    }
}