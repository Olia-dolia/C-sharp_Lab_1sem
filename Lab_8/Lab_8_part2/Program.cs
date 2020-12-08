using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_8_part2
{
    class Program
    {
        class Disk
        {
            public long number;
            public string function = "Вы можете использовать такие символы: от 0 до 9";
            public void makeCall(long number)
            {
                Console.WriteLine("*Beeping*");
            }
            public void answerCall()
            {
                Console.WriteLine("*Ringing*");
            }
        }
        class PushButton : Disk
        {
            public string Name = "";
     
            public PushButton() {
                function = "Вы можете использовать такие символы: от 0 до 9, +, *, #, A-Z, a-z";
            }
        }
        class MobileBW : PushButton
        {
            public MobileBW()
            {
                function = "Вы можете использовать такие символы: от 0 до 9, +, -, *, #, A-Z, a-z, (), ?, !";
            }

            public void sendSMS(long number, string text)
            {
                Console.WriteLine("{1} sent to {0}", number, text);
            }
            public void receiveSMS(long number, string text)
            {
                Console.WriteLine("{0} : {1}", number, text);
            }
        }
        class MobileColor : MobileBW
        {
            public int amountOfColors;
            public int simCards;

            public void sendMMS(long number)
            {
                Console.WriteLine(" sent to {0}", number);
            }
            public void receiveMMS(long number)
            {
                Console.WriteLine("{0} : ", number);
            }
        }
        class Smartphone : MobileColor
        {
            const bool sensor = true;
            public int amountOfTouches;
            public int amountOfCameras;
            public string cameraCharacteristics;

            public void TakePhoto()
            {
                Console.WriteLine("*Shutter Sound*");
            }
            public void TakeWidePhoto()
            {
                Console.WriteLine("*Shutter Sound*");
            }
            public void TakePortraitPhoto()
            {
                Console.WriteLine("*Shutter Sound*");
            }
            public void MakeVideo()
            {
                Console.WriteLine("*Recording*");
            }

        }
        static void Main(string[] args)
        {
        
        }
    }
}
