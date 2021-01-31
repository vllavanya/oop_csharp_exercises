using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        bool IsAsleep { get; set; }
        string Setting { get; set; }
        string Eat { get; set; }
        int AverageHeight { get; set; }
        void GoToSleep();
        void WakeUp();
    }

    public abstract class TypeCat : ICat
    {
        public bool IsAsleep { get; set; }
        public string Setting { get; set; }
        public string Eat { get; set; }
        public int AverageHeight { get; set; }
        public void GoToSleep()
        {
            IsAsleep = true;
        }
        public void WakeUp()
        {
            IsAsleep = false;
        }
    }
    public class DomesticCat : TypeCat
    {
        public DomesticCat()
        {
            IsAsleep = false;
            Setting = "domestic";
            AverageHeight = 23;
            Eat = "Purrrrrrr";
        }
    }
    public class LionCat : TypeCat
    {
        public LionCat()
        {
            AverageHeight = 1100;
            Eat = "Roar!!!!";

        }
    }
    public class CheetahCat : TypeCat
    {
        public CheetahCat()
        {
            Eat = "Zzzzzzz";
        }
    }

}
