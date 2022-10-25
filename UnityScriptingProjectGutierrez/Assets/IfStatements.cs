using UnityEngine;
using System.Collections;

public class IfStatements : MonoBehaviour
{
    float cofeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TemperatureTest();

        cofeeTemperature -= Time.deltaTime * 5f;
    }


    void TemperatureTest()
    {
        // If the cofee's temperature is greater than the hottest drinking temperature...
        if (cofeeTemperature > hotLimitTemperature)
        {
            // ... do this.
            print("Cofee is too hot");
        }
        // If it isn't, but the cofee temperature is less than the coldest drinking temperature...
        else if (cofeeTemperature < coldLimitTemperature)
        {
            // ... do this.
            print("Cofee is too cold.");
        }
        // If it is neither of those then...
        else
        {
            // ... do this.
            print("Cofee is just right.");
        }
    }
}