using System;


namespace bacit_dotnet.MVC.Teamlead
{
    //Her så bruker den arv til å arve employee rollen først, deretter employee sitt interface.
    public class TeamLead : Employee, EmployeeInterface

    {   //her sier den at som har tildelt roller er teamlead
        bool isTeamlead = true;
    }
    //dette er en funksjon for å overføre en rolle til en annen, litt usikker på om den fungerer.
    [Windows.Foundation.Metadata.Overload("TransferOwnership")]
    public void TransferOwnership(string empID);
}

//"Employee", "EmployeeInterface": Er ikke objekter/klasser som vi har laget så det må legges inn hva de faktisk heter.