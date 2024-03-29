﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DungeonsAndDragonsCharacter.API.Entities
{
    public class CharacterEquipment
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int Price { get; set; }
        public string Description { get; set; }

        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }

    }
}
