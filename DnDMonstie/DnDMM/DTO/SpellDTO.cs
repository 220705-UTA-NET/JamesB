﻿using System;
using System.Text.Json;

namespace spell.DTO
{

    public class SpellShell
    {
        public int? count { get; set; }
        public string? next { get; set; }
        public string? previous { get; set; }
        public results[]? re { get; set; }

    }
    public class results
    {

        public string? slug { get; set; }
        public string? name { get; set; }
        public string? desc { get; set; }
        public string? higher_level { get; set; }
        public string? page { get; set; }
        public string? range { get; set; }
        public string? components { get; set; }
        public string? material { get; set; }
        public string? ritual { get; set; }
        public string? duration { get; set; }
        public string? concentration { get; set; }
        public string? casting_time { get; set; }
        public string? level { get; set; }
        public int level_int { get; set; }
        public string? school { get; set; }
        public string? dnd_class { get; set; }
        public string? archetype { get; set; }
        public string? circles { get; set; }
        public string? document__slug { get; set; }
        public string? document__title { get; set; }
        public string? document__license_url { get; set; }
    }
}