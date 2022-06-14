using System;

namespace ICE 
{
    public class Robot 
    {
        public int _ammunition;

        public Robot ()
        {
            _ammunition = 10;
        }

        public void Shoot()
        {
            Console.WriteLine("pew! pew!");
            _ammunition -= 1;
            
        }
    }
}