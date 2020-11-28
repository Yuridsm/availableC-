﻿using System;
using System.Collections.Generic;
using System.Text;
using LeanringWithMosh.interfaces;

namespace LeanringWithMosh.services
{
    class OracleDatabaseService : IDatabase
    {
        public void delete()
        {
            Console.WriteLine("Oracle...");
            Console.WriteLine("Deleting 1 row");
        }

        public void insert()
        {
            Console.WriteLine("Oracle...");
            Console.WriteLine("Inserting 1 row");
        }

        public void select()
        {
            Console.WriteLine("Oracle...");
            Console.WriteLine("Selecting 1 row");
        }

        public void update()
        {
            Console.WriteLine("Oracle...");
            Console.WriteLine("Updating 1 row");
        }
    }
}
