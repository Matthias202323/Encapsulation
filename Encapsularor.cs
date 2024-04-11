
using System;

namespace Encapsulation
{
    public class BeerEncapsulator
    {
        private ulong _avalaibleBeerVolume = 33;
        private ulong _avalaibleBottles = 1;
        private ulong _avalaibleCapsules = 1;
        
        public void SetAvaiaibleBottles(ulong _availableBottles)
        {
            _availableBottles = _availableBottles;
            
        }

        public ulong GetAvaiaibleBottles()
        {
            return _avalaibleBottles;
        }
        public void SetAvaiaibleCapsules(ulong _availableCapsules)
        {
            _availableCapsules = _availableCapsules;
        }

        public ulong GetAvaiaibleCapsules()
        {
            return _avalaibleCapsules;
        }
        public void AddBeer()
        {
            if (_avalaibleBeerVolume < 33)
            {
                Console.WriteLine("Conbien de volume voulez vous ajouter?");
                string _avalaiblBeerVolumeIn = Console.ReadLine();
                ulong _availableBeerVolumeInt = ulong.Parse(_avalaiblBeerVolumeIn);
                _avalaibleBeerVolume += _availableBeerVolumeInt;

            }
            Console.WriteLine($"il reste {_avalaibleBeerVolume} cl");
        }
        public void AddCapsules()
        {
            if (_avalaibleCapsules < 1)
            {
                Console.WriteLine("Conbien de capsules voulez vous ajouter?");
                string _avalaibleCapsulesIn = Console.ReadLine();
                ulong _avalaibleCapsulesInt = ulong.Parse(_avalaibleCapsulesIn);
                _avalaibleCapsules += _avalaibleCapsulesInt;
            }
            Console.WriteLine($"il reste {_avalaibleCapsules} capsules");
        }
        public void AddBottles()
        {
            if (_avalaibleBottles < 1)
            {
                Console.WriteLine("Conbien de bouteilles vides voulez vous ajouter?");
                string _avalaibleBottlesIn = Console.ReadLine();
                ulong _avalaibleBottlesInt = ulong.Parse(_avalaibleBottlesIn);

                _avalaibleBottles += _avalaibleBottlesInt;

            }
            Console.WriteLine($"il reste {_avalaibleBottles} bottles");
        }
        public ulong GetBeer()
        {
            return _avalaibleBeerVolume;
        }
        public void ProduceEncapsulatedBeerBottles(int nbrBouteilles)
        {
            for (int i = 0; i < nbrBouteilles; i++)
            {

                if (_avalaibleCapsules > 0)
                {
                    _avalaibleCapsules -= 1;

                }
                if (_avalaibleBottles > 0)
                {
                    _avalaibleBottles -= 1;
                }
                if(_avalaibleBeerVolume > 0)
                {
                    _avalaibleBeerVolume -= 33;
                }
                
                
                
                if (_avalaibleCapsules < 1)
                { 
                    Console.WriteLine("il n'y a plus de capsules");
                    AddCapsules();
                   // Environment.Exit(0);
                }
                if (_avalaibleBottles < 1)
                {
                    Console.WriteLine("il n'y a plus de bouteilles");
                    AddBottles();
                  //  Environment.Exit(0);
                }
                if (_avalaibleBeerVolume < 33)
                {
                    Console.WriteLine("il n'y a plus de volume de bière");
                    AddBeer();
                }
            }
        }
     
    }
}
