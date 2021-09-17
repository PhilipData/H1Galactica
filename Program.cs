using System;

namespace H1Galactica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //star.list = new list<Planet>() {
            //    new Planet(){}
            //};
            Star Sun = new Star()
            {
                Id = 1,
                Name = "Sun",
                //_Position = (new SpaceObjects.Position(){X = 5, Y = 0}),
                _Position = new Star.Position{ X = 0, Y = 1 },//bliver overrided af en constructor i class'en star
                _Startype = Startype.YellowDwarf,
                Temperature = 5500

            };
            
            Planet mercury = new Planet()
            {
                Id = 1,
                Name = "Mercury",
                _Position = (new SpaceObjects.Position() { X = 2, Y = 2 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 4880000,
                RoationsPeriod_I_Timer = 1407,
                RevolutionsPeriode_I_Dage = 88
            };
            Sun.planets.Add(mercury);

            Planet venus = new Planet()
            {
                Id = 2,
                Name = "Venus",
                _Position = (new SpaceObjects.Position() { X = 3, Y = 3 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 6051800,
                RoationsPeriod_I_Timer = 5832,
                RevolutionsPeriode_I_Dage = 116
            };
            Sun.planets.Add( venus );

            Planet earth = new Planet()
            {
                Id = 3,
                Name = "Earth",
                _Position = (new SpaceObjects.Position() { X = 4, Y = 4 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 6371000,
                RoationsPeriod_I_Timer = 24,
                RevolutionsPeriode_I_Dage = 365
            };
            Sun.planets.Add(earth);

            Planet Mars = new Planet()
            {
                Id = 4,
                Name = "Mars",
                _Position = (new SpaceObjects.Position() { X = 5, Y = 5 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 3389500,
                RoationsPeriod_I_Timer = 24,
                RevolutionsPeriode_I_Dage = 365
            };
            Sun.planets.Add(Mars);

            Planet Jupiter = new Planet()
            {
                Id = 5,
                Name = "Jupiter",
                _Position = (new SpaceObjects.Position() { X = 6, Y = 6 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 69911000,
                RoationsPeriod_I_Timer = 10,
                RevolutionsPeriode_I_Dage = 687
            };
            Sun.planets.Add(Jupiter);

            Planet Saturn = new Planet()
            {
                Id = 6,
                Name = "Saturn",
                _Position = (new SpaceObjects.Position() { X = 7, Y = 7 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 58232000,
                RoationsPeriod_I_Timer = 10,
                RevolutionsPeriode_I_Dage = 10585
            };
            Sun.planets.Add(Saturn);

            Planet Uranus = new Planet()
            {
                Id = 7,
                Name = "Uranus",
                _Position = (new SpaceObjects.Position() { X = 8, Y = 8 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 25362000,
                RoationsPeriod_I_Timer = 17,
                RevolutionsPeriode_I_Dage = 30660
            };
            Sun.planets.Add(Uranus);

            Planet Neptune = new Planet()
            {
                Id = 8,
                Name = "Neptune",
                _Position = (new SpaceObjects.Position() { X = 9, Y = 9 }),
                _PlanetType = PlanetType.Terrestial,
                Diameter_I_M = 24622000,
                RoationsPeriod_I_Timer = 16,
                RevolutionsPeriode_I_Dage = 60225
            };
            Sun.planets.Add(Neptune);

            Moon Luna = new Moon()
            {
                Id = 1,
                Name = "Luna",
                _Position = (new SpaceObjects.Position() {  X = 4, Y = 5 }),
                Diameter_I_M = 1737400,
                RoationsPeriod_I_Timer = 648,
                RevolutionsPeriode_I_Dage = 27,
                Orbiting = earth
            };
            earth._Moon.Add(Luna);

            Moon Titan = new Moon()
            {
                Id = 2,
                Name = "Titan",
                _Position = (new SpaceObjects.Position() { X = 0, Y = 0 }),
                Diameter_I_M = 2574700,
                RoationsPeriod_I_Timer = 382,
                RevolutionsPeriode_I_Dage = 16
            };
            Saturn._Moon.Add(Titan);

            Moon Phobos = new Moon()
            {
                Id = 3,
                Name = "Phobos",
                _Position = (new SpaceObjects.Position() { X = 0, Y = 0 }),
                Diameter_I_M = 11267,
                RoationsPeriod_I_Timer = 8,
                RevolutionsPeriode_I_Dage = 0
            };
            Mars._Moon.Add(Phobos);

            Moon Europa = new Moon()
            {
                Id = 4,
                Name = "Europe",
                _Position = (new SpaceObjects.Position() { X = 0, Y = 0 }),
                Diameter_I_M = 1560800,
                RoationsPeriod_I_Timer = 84,
                RevolutionsPeriode_I_Dage = 3
            };
            Jupiter._Moon.Add(Europa);

            Moon Deimos = new Moon()
            {
                Id = 5,
                Name = "Deimos",
                _Position = (new SpaceObjects.Position() { X = 0, Y = 0 }),
                Diameter_I_M = 6200,
                RoationsPeriod_I_Timer = 30,
                RevolutionsPeriode_I_Dage = 1
            };
            Mars._Moon.Add(Deimos);

            Moon Ganymedes = new Moon()
            {
                Id = 6,
                Name = "Ganymedes",
                _Position = (new SpaceObjects.Position() { X = 0, Y = 0 }),
                Diameter_I_M = 2634100,
                RoationsPeriod_I_Timer = 171,
                RevolutionsPeriode_I_Dage = 7
            };
            Jupiter._Moon.Add(Ganymedes);

            Moon Io = new Moon()
            {
                Id = 7,
                Name = "Io",
                _Position = (new SpaceObjects.Position() { X = 0, Y = 0 }),
                Diameter_I_M = 1821600,
                RoationsPeriod_I_Timer = 172,
                RevolutionsPeriode_I_Dage = 2
            };
            Jupiter._Moon.Add(Io);

            Moon Mimas = new Moon()
            {
                Id = 8,
                Name = "Mimas",
                _Position = (new SpaceObjects.Position() { X = 0, Y = 0 }),
                Diameter_I_M = 198200,
                RoationsPeriod_I_Timer = 22,
                RevolutionsPeriode_I_Dage = 1
            };
            Saturn._Moon.Add(Mimas);

            foreach (Planet PLanetCollection in Sun.planets)
            {

            }

            Console.WriteLine(Sun._Position);
        }
    }
}
