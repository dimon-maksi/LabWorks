using System;

namespace LabWork11_1;

public delegate void Delegate(AmusementPark amusementPark);

class Program
{
    static void Main(string[] args)
    {
        AmusementPark amusementParkDelegate = new AmusementPark();

        Delegate AllOfMetods = new(amusementParkDelegate.RideARollerCoaster);
        AllOfMetods += amusementParkDelegate.ShotingInTheShootingRange;
        AllOfMetods += amusementParkDelegate.RideTheFerrisWheel;
        AllOfMetods += amusementParkDelegate.EatPopcorn;
        AllOfMetods(amusementParkDelegate);

        amusementParkDelegate.Show();
    }
}