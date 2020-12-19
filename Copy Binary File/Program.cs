using System;
using System.IO;
using System.Threading;

namespace Copy_Binary_File
{
    class Program
    {
        static void Main( string [ ] args )
        {
            using (FileStream pictureFile = new FileStream(@"../../../copyMe.png", FileMode.Open))
            {
                byte[] buffer = new byte[4096];
              
                using (FileStream writer = new FileStream("../../../picCopy.png", FileMode.Create))
                {
                    while (writer.CanRead)
                    {
                        int bytesRead =  pictureFile.Read(buffer, 0, buffer.Length);
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        writer.Write(buffer, 0, buffer.Length);
                    }
                   
                }
            }
        }
    }
}
