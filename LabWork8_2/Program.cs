using LabWork8_2.telephones;
using System;

namespace LabWork8_2;
class Program
{
    static void Main(string[] args)
    {
        Rotary rotary = new Rotary();
        rotary.Call();
        rotary.AcceptCall();

        Button button= new Button();
        button.Call();
        button.AcceptCall();

        BlackScreen blackScreen = new BlackScreen();
        blackScreen.Call();
        blackScreen.AcceptCall();
        blackScreen.SendSms();
        blackScreen.AcceptSms();

        ColorScreen colorScreen = new ColorScreen();
        colorScreen.Call();
        colorScreen.AcceptCall();
        colorScreen.SendSms();
        colorScreen.AcceptSms();
        colorScreen.SendMms();
        colorScreen.AcceptMms();

        Smart smart = new Smart();
        smart.Call();
        smart.AcceptCall();
        smart.SendSms();
        smart.AcceptSms();
        smart.SendMms();
        smart.AcceptMms();
        smart.MakeAPhoto();
        smart.MakeAVideo();
    }
}