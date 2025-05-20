using MyFirstApp.Activities;

namespace MyFirstApp;

public static class ProgramFactory
{
    public static IProgram Create(int id)
    {
        return id switch
        {
            1 => new Activity01(),
            2 => new Activity02(),
            3 => new Activity03(),
            4 => new Activity04(),
            5 => new Activity05(),
            6 => new Activity06(),
            7 => new Activity07(),
            8 => new Activity08(),
            9 => new Activity09(),
            10 => new Activity10(),
            11 => new Activity11(),
            12 => new Activity12(),
            13 => new Activity13(),
            14 => new Activity14(),
            15 => new Activity15(),
            16 => new Activity16(),
            17 => new Activity17(),
            18 => new Activity18(),
            19 => new Activity19(),
            20 => new Activity20(),
            21 => new Activity21(),
            22 => new Activity22(),
            23 => new Activity23(),
            24 => new Activity24(),
            25 => new Activity25(),
            26 => new Activity26(),
            27 => new Activity27(),
            28 => new Activity28(),
            _ => throw new Exception("Activity not found.")
        };
    }
}
