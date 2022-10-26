using System;
using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models
{
    public class Scripture
    {
        public int ScriptureId { get; set; }
        public string Book { get; set; }
        public int Chapter { get; set; }
        public string Verses { get; set; }
        public string Notes { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public Scripture()
        {

        }
    }
}

