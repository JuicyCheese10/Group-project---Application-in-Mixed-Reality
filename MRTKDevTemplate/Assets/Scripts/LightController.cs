using UnityEngine;
using UnityEngine.UI; 

public class LightController : MonoBehaviour
{
    public Light sceneLight; 

   
    public void AdjustLightIntensity(float newIntensity)
    {
        if (sceneLight != null)
        {
            sceneLight.intensity = newIntensity;
        }
    }
}
