﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Preject2netAsp.Models
{
    public class PlayListModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string AudioStream { get; set; }
        public string titleAudio { get; set; }
        public DateTime DateToAdd { get; set; }
    }
}
