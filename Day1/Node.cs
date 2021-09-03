﻿using System;
namespace Day1
{
    public class Node
    {
        public Node(string data)
        {
            Data = data;
            Next = null;
        }

        public string Data { get; set; }
        public Node Next { get; set; }
    }
}
