using System;
using Rogue.Creature;

namespace Rogue
{
    public class StatusBarControllerImpl : StatusBarController
    {
        public StatusBarControllerImpl(PlayerLifeImpl life)
        {
            life.PlayerLifeChanged += newValue => Console.WriteLine(newValue);
        }
        
    }
}