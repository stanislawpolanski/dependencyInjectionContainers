﻿using dependencyInjectionContainers.Models;
using dependencyInjectionContainers.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dependencyInjectionContainers.Services
{
    public class TopicAreaService : ITopicAreaService
    {
        public IEnumerable<TopicArea> GetAllTopicAreas()
        {
            return new List<TopicArea>
        {
            new TopicArea {Name =".NET Core" },
            new TopicArea {Name ="Docker" },
            new TopicArea { Name ="C#" }
        };
        }
    }
}
