namespace LabWork11_1
{
    public class AmusementPark
    {
        private bool RodeARollerCoaster { get; set; }
        private bool ShotInTheShootingRange { get; set; }
        private bool WasInTheRoomOfFears { get; set; }
        private bool WasInTheRoomOfCrookedMirrors { get; set; }
        private bool AtePopcorn { get; set; }
        private bool RodeTheFerrisWheel { get; set; }

        public AmusementPark()
        {
            RodeARollerCoaster = false;
            ShotInTheShootingRange = false;
            WasInTheRoomOfFears = false;
            WasInTheRoomOfCrookedMirrors = false;
            AtePopcorn = false;
            RodeTheFerrisWheel = false;
        }

        public void Show()
        {
            Console.WriteLine("RodeARollerCoaster = " + RodeARollerCoaster);
            Console.WriteLine("ShotInTheShootingRange = " + ShotInTheShootingRange);
            Console.WriteLine("WasInTheRoomOfFears = " + WasInTheRoomOfFears);
            Console.WriteLine("WasInTheRoomOfCrookedMirrors = " + WasInTheRoomOfCrookedMirrors);
            Console.WriteLine("AtePopcorn = " + AtePopcorn);
            Console.WriteLine("RodeTheFerrisWheel = " + RodeTheFerrisWheel);
        }

        public void RideARollerCoaster(AmusementPark amusementPark) => amusementPark.RodeARollerCoaster = true;
        public void ShotingInTheShootingRange(AmusementPark amusementPark) => amusementPark.ShotInTheShootingRange = true;
        public void ToBeInTheRoomOfFears(AmusementPark amusementPark) => amusementPark.WasInTheRoomOfFears = true;
        public void ToBeInTheRoomOfCrookedMirrors(AmusementPark amusementPark) => amusementPark.WasInTheRoomOfCrookedMirrors = true;
        public void EatPopcorn(AmusementPark amusementPark) => amusementPark.AtePopcorn = true;
        public void RideTheFerrisWheel(AmusementPark amusementPark) => amusementPark.RodeTheFerrisWheel = true;
    }
}
