using System;
using MagicDestroyers.Enums;

namespace MagicDestroyers
{
    public static class Consts 
    {
        //public code is for the fields and cannot be seen outside the class

        public static class Warrior
        {
            public const int HEALTH_POINTS = 120;
            public const int ABILITY_POINTS = 100;
            public const string NAME = "Bob";
        }

        public static class Knight
        {  
           private const int HEALTH_POINTS = 100;
           private const int ABILITY_POINTS = 110;
           private const string NAME = "Smith";
        }

         public static class Assassin
        {
            private const string NAME = "Sam";
            private const int HEALTH_POINTS = 120;
            private const int ABILITY_POINTS = 90;
        }

         public static class Mage
        {
            private const string NAME = "Rain";
            private const int HEALTH_POINTS = 70;
            private const int ABILITY_POINTS = 130;
        }

        public static class Druid
        {
            private const string NAME = "Oak";
            private const int HEALTH_POINTS = 80;
            private const int ABILITY_POINTS = 120;
        }

        public static class Necromancer
        {
            private const string DEFAULT_NAME = "Angie";
            private const int DEFAULT_HEALTH_POINTS = 60;
            private const int DEFAULT_ABILITY_POINTS = 150;
        }

    }
}