﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IdeoRestfulService.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string SharedFile { get; set; }
        public bool IsAccepted { get; set; }
        public string RefusedCause { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime PublishDate { get; set; }
        public List<Tag> Tags { get; set; }
    }
}
