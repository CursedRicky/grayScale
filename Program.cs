using System;
using Emgu.CV;
using Emgu.CV.Structure;

class Program {
    static void Main(string []args) {

        Console.WriteLine(@"
  ________                         _______             .__          
 /  _____/___________  ___.__.  /   _____/ ____ _____  |  |   ____  
/   \  __\_  __ \__  \<   |  |  \_____  \_/ ___\\__  \ |  | _/ __ \ 
\    \_\  \  | \// __ \\___  |  /        \  \___ / __ \|  |_\  ___/ 
 \______  /__|  (____  / ____| /_______  /\___  >____  /____/\___  >
        \/           \/\/              \/     \/     \/          \/ 
        ");

        string filePath = "";
        Console.WriteLine("Inserire percorso immagine:");
        filePath = Console.ReadLine();
        Mat pic = CvInvoke.Imread(filePath); //Crea matrice

        //Scala di grigio
        Image<Gray, byte> grayPic = pic.ToImage<Gray, byte>();
        CvInvoke.Imwrite("out.png", grayPic);

    }
}

