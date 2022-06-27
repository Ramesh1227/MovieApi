﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieinformationService.Domain
{
    public  class MovieInformationEditRequest
    {
        public int MovieId { get; set; }
        public string MovieName { get; set; }

        public int ProducerId { get; set; }
        public string Plot { get; set; }
        public string DateOfRelease { get; set; }

        public string ProducerName { get; set; }

        public List<Actors> Actors { get; set; }
    }

    public class Actors
    {
        public int ActorsId { get; set; }
        public string ActorsName { get; set; }
    }
}
