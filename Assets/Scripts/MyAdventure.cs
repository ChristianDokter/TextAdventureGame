using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.XR;
using Random = UnityEngine.Random;


public class MyAdventure : MonoBehaviour
{
    //dit zijn al mijn states
    private enum States
    {
        Mainmenu,
        Gamestart,
        controls,
        credits,
        Verhaal,
        Keuze1,
        NeilArmstrong,
        WillWilliams,
        GeorgieTurner,
        spacewalkgelukt,
        spacewalknee,
        spacewalk1einde,
        dood1,
        helpNeil,
        klusafmaken,
        redtneil,
    }

    private States currentState = States.Mainmenu;

    // Start is called before the first frame update
    void Start()
    {
        Mainmenu();
    }

    

    //Dit is mijn switch met daar in alle verschillende cases
    void OnUserInput(string input)
    {
        switch (currentState)
        {
            case States.Mainmenu:
                if (input == "start")
                {
                    GameStart();
                }
                else if (input == "controls")
                {
                    controls();
                }
                else if (input == "credits")
                {
                    credits();
                }
                else
                {
                    Mainmenu();
                }

                break;

            case States.controls:
                if (input == "back")
                {
                    Mainmenu();
                }
                else
                {
                    controls();
                }
                break;

            case States.credits:
                if (input == "back")
                {
                    Mainmenu();
                }
                else
                {
                    credits();
                }
                break;

            case States.Gamestart:
                if (input == "verder")
                {
                    Verhaal();
                }
                break;

            case States.Verhaal:
                if (input == "verder")
                {
                    Keuze1();
                }
                break;

            case States.Keuze1:
                if (input == "neil armstrong")
                {
                    NeilArmstrong();
                }
                else if (input == "will williams")
                {
                    WillWilliams();
                }
                else if (input == "georgie turner")
                {
                    GeorgieTurner();
                }
                else
                {
                    Keuze1();
                }
                break;

            case States.NeilArmstrong:
                if(input == "ja")
                {
                    spacewalkgelukt();
                }
                if (input == "nee")
                {
                    spacewalknee();
                }
                break;

            case States.spacewalkgelukt:
                if(input == "verder")
                {
                    spacewalk1einde();
                }
                break;

            case States.spacewalknee:
                if(input == "verder")
                {
                    Mainmenu();
                }
                break;

            case States.WillWilliams:
                if (input == "verder")
                {
                    spacewalk1einde();
                }
                break;

            case States.spacewalk1einde:
                if (input == "ja")
                {
                    helpNeil();
                }
                else if (input == "nee")
                {
                    dood1();
                }
                else
                {
                    spacewalk1einde();
                }
                break;

            case States.dood1:
                if (input == "verder")
                {
                    Mainmenu();
                }
                else
                {
                    dood1();
                }
                break;

            case States.GeorgieTurner:
                if (input == "verder")
                {
                    Mainmenu();
                }
                break;

            case States.helpNeil:
                if (input == "a")
                {
                    klusafmaken();
                }
                else if (input == "b")
                {
                    redtneil();
                }
                else
                {
                    helpNeil();
                }
                break;

            case States.klusafmaken:
                if (input == "verder")
                {
                    Mainmenu();
                }
                else
                {
                    klusafmaken();
                }
                break;
            case States.redtneil:
                if (input == "verder")
                {
                    Mainmenu();
                }
                break;
              }
    }

    //Dit zijn alle voids van mijn game hierin staat de daadwerkelijke content
    void Mainmenu()
    {
        currentState = States.Mainmenu;
        Terminal.ClearScreen();
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("                                 ASTROWORLD");
        Terminal.WriteLine("");
        Terminal.WriteLine("");
        Terminal.WriteLine("                Controls            Start            Credits");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
        Terminal.WriteLine("                                    Keuze");
        Terminal.WriteLine(" ");
        Terminal.WriteLine(" ");
    }

    void GameStart()
    {
        currentState = States.Gamestart;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent op ruimtereis met een groep van 3 astronauten en onderweg gebeurt er veel onverwachts");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ verder om te beginnen");
    }

    void controls()
    {
        currentState = States.controls;
        Terminal.ClearScreen();
        Terminal.WriteLine("De game is eigenlijk heel simpel, het is een text based games dus je hoeft alleen");
        Terminal.WriteLine("te typen er zijn daarom ook geen daadwerkelijke controls");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ Back om terug te gaan");
    }

    void credits()
    {
        currentState = States.credits;
        Terminal.ClearScreen();
        Terminal.WriteLine("Deze game is gemaakt door Christian Dokter");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ Back om terug te gaan");
    }

    void Verhaal()
    {
        currentState = States.Verhaal;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je bent dus op ruimtereis met een groep van 3 astronauten het is een niuewe dag en jij");
        Terminal.WriteLine("loopt door het ruimteschip om te kijken of er niets kapot is gegaan. even later zie je dat er");
        Terminal.WriteLine("ergens een lek in het ruimteschip zit. Dit probleem moet opgelsot worden door middel");
        Terminal.WriteLine("van een spacewalk want het zit aan de buitenkant van het schip.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ verder om door te gaan");
    }

    void Keuze1()
    {
        currentState = States.Keuze1;
        Terminal.ClearScreen();
        Terminal.WriteLine("Nu moet er een keuze gemaakt worden tussen de 3 astronauten want iemand moet het probleem oplossen.");
        Terminal.WriteLine("");
        Terminal.WriteLine("Kies tussen Neil Armstrong, Will Williams en Georgie Turner");
        Terminal.WriteLine("");
        Terminal.WriteLine("Keuze:");
    }

    void NeilArmstrong()
    {
        currentState = States.NeilArmstrong;
        Terminal.ClearScreen();
        Terminal.WriteLine("Neil gaat de spacewalk maken hij doet zijn pak aan en zoekt naar het gereedschap.");
        Terminal.WriteLine("hij vindt de kist vol met gereedschap alleen niet alles zit erin");
        Terminal.WriteLine("");
        Terminal.WriteLine("ga je nogsteeds de spacewalk maken?");
        Terminal.WriteLine("");
        Terminal.WriteLine("Zo ja typ: ja");
        Terminal.WriteLine("Zo nee typ: nee");
        Terminal.WriteLine("");
        Terminal.WriteLine("Keuze:");
    }

    void spacewalkgelukt()
    {
        currentState = States.spacewalkgelukt;
        Terminal.ClearScreen();
        Terminal.WriteLine("Ondaks je niet alle gereedschap had is het je nogsteeds gelukt om het ship te repareren!");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ verder om door te gaan");

    }
    
    void spacewalknee()
    {
        currentState = States.spacewalknee;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt ervoor gekozen om niet het schip te maken. het lijkt geen probleem te zijn todat");
        Terminal.WriteLine("een week later plotseling iedereen stik omdat alle zuurstof is ontsnapt via het gat");
        Terminal.WriteLine("en iedereen in het schip gaat dood");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ verder om opnieuw te beginnen");
    }


    void spacewalk1einde()
    {
        currentState = States.spacewalk1einde;
        Terminal.ClearScreen();
        Terminal.WriteLine("Het is erg rustig op het ruimteschip er gaan een paar weken voorbij er wordt weer");
        Terminal.WriteLine("een maandelijkse check gedaan om te kijken of er niets kapot is er is een groot probleem en");
        Terminal.WriteLine("het moet opgelost worden door 2 man er is nog een probleemje er zijn niet");
        Terminal.WriteLine("genoeg 6 liter zuurstof tanks dus 1 van de astronauten moet een 3 liter tank gebruiken");
        Terminal.WriteLine("Ga je nogsteeds de spacewalkt doen?");
        Terminal.WriteLine("");
        Terminal.WriteLine("typ ja voor ja");
        Terminal.WriteLine("typ nee voor nee");
    }

    void helpNeil()
    {
        currentState = States.helpNeil;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je gaat met z'n tweeën (Neil en Will) het schip repareren het is een grote klus die direct");
        Terminal.WriteLine("gemaakt moet worden. het duurt erg lang Neil heeft de 3 liter tank om en zijn zuurstof raakt snel op, even later raakt neil buiten");
        Terminal.WriteLine("bewustzijn Will moet nu kiezen: A - je gaat snel de klus af maken en laat neil achter");
        Terminal.WriteLine("of B - Je redt neil en komt weer veilig terug naar binnen");
    }

    void klusafmaken()
    {
        currentState = States.klusafmaken;
        Terminal.ClearScreen();
        Terminal.WriteLine("Het is een lastige keuzen geweest je hebt neil achtergelaten maar je hebt wel het schip");
        Terminal.WriteLine("gerepareerd dit was het doel van de game en je hebt het nu ook overleefd!");
        Terminal.WriteLine("Dit is was de enige manier om te overleven goed gedaan!!");
        Terminal.WriteLine("typ verder om weer terug te gaan naar het mainmenu");
    }

    void redtneil()
    {
        currentState = States.redtneil;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt ervoor gekozen om neil te redden super aardig! maar.. nu zijn er niet genoeg spullen om");
        Terminal.WriteLine("nog een keer met z'n tweeën een spacewalk te maken nu moeten er extra materialen naar het schip");
        Terminal.WriteLine("gebracht worden en dat gaat te lang duren, een week later gaat het schip kapot");
        Terminal.WriteLine("Typ verder om opnieuw te beginnen");
    }

    void dood1()
    {
        currentState = States.dood1;
        Terminal.ClearScreen();
        Terminal.WriteLine("Je hebt gekozen om het ship niet te repareren");
        Terminal.WriteLine("Het bleek een grote scheur te zijn die nu zo groot is geworden dat hij niet meer te");
        Terminal.WriteLine("repareren valt. Een paar dagen later breekt het schip en iedereen gaat dood");
        Terminal.WriteLine("en iedereen gaat dood");
        Terminal.WriteLine("Typ verder om opnieuw te beginnen");
    }

    void WillWilliams()
    {
        currentState = States.WillWilliams;
        Terminal.ClearScreen();
        Terminal.WriteLine("Will gaat de spacewalk maken, hij doet dit super vaak en is er daarom ook erg goed in hij");
        Terminal.WriteLine("repareet het gat en komt weer terug in het ship");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ verder om door te gaan");
    }
    void GeorgieTurner()
    {
        currentState = States.GeorgieTurner;
        Terminal.ClearScreen();
        Terminal.WriteLine("Georgie Turner gaat de spacewalk maken hij is hier erg goed in alleen hij is niet de beste");
        Terminal.WriteLine("klusser. na een tijdje heeft hij het bijna gerepareerd het lijkt allemaal goed te gaan");
        Terminal.WriteLine("totdat hij perongelijk op iets verkeerd slaat en het schip ontploft");
        Terminal.WriteLine("");
        Terminal.WriteLine("Typ verder om opnieuw te beginnen");
    }

}