﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagment
{
    public class InventoryDetails
    {
        public List <TypesOfRice> typesOfRice;
        public List<TypesOfRice> typesOfPulse;
        public List<TypesOfRice> typesOfWheat;
    }
    public class TypesOfRice
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfPulse
    {
        public string name;
        public int weight;
        public int price;
    }

    public class TypesOfWheat
    {
        public string name;
        public int weight;
        public int price;
    }
}
