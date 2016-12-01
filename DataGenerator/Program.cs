﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataGenerator.Generators;

namespace DataGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var tg = new TechikGenerator();
            //tg.Generate(500);

            //var ug = new UlicaGenerator();
            //ug.Generate(50);

            //var lg = new LampaGenerator();
            //lg.Generate(10);

            //var sg = new StlpGenerator(421);
            //sg.Generate(25);

            //var lg = new LampaNaStlpeGenerator(9, 9724);
            //lg.Generate(0);

            var sg = new SluzbyGenerator();
            sg.Generate(50000);
        }
    }
}
