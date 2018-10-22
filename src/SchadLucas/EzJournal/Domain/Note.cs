using System;
using System.Collections.Generic;

namespace SchadLucas.EzJournal.Domain
{
    public class Note
    {
        public string Content { get; set; }
        public DateTime Created { get; set; }
        public DateTime Edited { get; set; }
        public long Size { get; private set; }
        public IList<Tag> Tags { get; set; }
        public string Title { get; set; }
    }
}