namespace RaceExplorer.Models
{
    public class TensorData
    {
        float rightLeg;
        float leftLeg;
        float rightCushion;
        float leftCushion;
        float backCushion;
        float frontCushion;

        public void getFromString(string dataString)
        {
            string[] data = dataString.Split(',');
            
            leftLeg = float.Parse(data[0]);
            rightLeg= float.Parse(data[1]);
            leftCushion= float.Parse(data[2]);
            rightCushion= float.Parse(data[3]);
            backCushion= float.Parse(data[4]);
            if(data.Length == 6)
            {
                // parse frontCushion
            }


            //Data format :  {"LeftLeg":12,"RightLeg":2,"LeftPillow":11,"RightPillow":21,"RearPillow":4,"LeftButton":1,"RightButton":1,"BarButton":1}
        }

    }
}