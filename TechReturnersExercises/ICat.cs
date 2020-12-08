using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        String Eat { get; }
        int AverageHeight { get; }
        String Setting { get; }
        void GoToSleep();
        void WakeUp();
        Boolean IsAsleep { get; }

    }

    public class DomesticCat : ICat
    {
        private Boolean sleepStatus;
        private String eat = "Purrrrrrr";
        private int height = 23;
        private String setting = "domestic";
        public String Eat
        {
            get { return eat; }
        }
        public int AverageHeight
        {
            get { return height; }
        }
        public String Setting
        {
            get { return setting; }
        }
        public void GoToSleep()
        {
            sleepStatus = true;
        }
        public void WakeUp()
        {
            sleepStatus = false;
        }

        public Boolean IsAsleep
        {
            get { return sleepStatus; }
        }
    }
    public class LionCat : ICat
    {
        public Boolean sleepStatus;
        private String eat = "Roar!!!!";
        private int height = 1100;
        private String setting = "wild";
        public String Eat
        {
            get { return eat; }
        }
        public int AverageHeight
        {
            get { return height; }
        }
        public String Setting
        {
            get { return setting; }
        }
        public void GoToSleep()
        {
            sleepStatus = true;
        }
        public void WakeUp()
        {
            sleepStatus = false;
        }

        public Boolean IsAsleep
        {
            get { return sleepStatus; }
        }
    }
    public class CheetahCat : ICat
    {
        public Boolean sleepStatus;
        private String eat = "Zzzzzzz";
        private int height = 1100;
        private String setting = "wild";

        public String Eat
        {
            get { return eat; }
        }
        public int AverageHeight
        {
            get { return height; }
        }
        public String Setting
        {
            get { return setting; }
        }
        public void GoToSleep()
        {
            sleepStatus = true;
        }
        public void WakeUp()
        {
            sleepStatus = false;
        }
        public Boolean IsAsleep
        {
            get { return sleepStatus; }
        }
    }
}
