using System;
using System.Reflection;

namespace journalapp.service.models
{
    /// <summary>
    /// PZN response model
    /// </summary>
    public class SimplePostRequest
    {
        public string entryId { get; set; } 
        public string entry { get; set; }
        public DateTime dateTimeCreated { get; set; }
    }
}