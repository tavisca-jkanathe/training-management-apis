using System;
using System.Collections.Generic;
using System.Text;
using Tavisca.TMS.Contracts.Models.BaseModels;

namespace Tavisca.TMS.Contracts.Models.TopicModels
{
    public class Topic : BaseModel
    {
        public string Name { get; set; }
        public string Complexity { get; set; }
        public string Role { get; set; }
        public string Duration { get; set; }
        public SubTopic[] SubTopics { get; set; }
        public string Category { get; set; }
        public string Prerequisite { get; set; }
        public string Difficulty { get; set; }
    }
    public class SubTopic : BaseModel
    {
        public string Name { get; set; }
        public string Complexity { get; set; }
        public string[] Reference { get; set; }
    }
}
