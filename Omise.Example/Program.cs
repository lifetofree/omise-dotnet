﻿using System;

namespace Omise.Example {
    class MainClass {
        public static void Main(string[] args) {
            var ex = new SearchExample();

            try {
                ex.Run().Wait();
            }
            catch (Exception e) {
                Console.Error.WriteLine(e);
            }
        }
    }
}