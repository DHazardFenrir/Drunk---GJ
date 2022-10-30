using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class LensDistortionEffect : MonoBehaviour
{


    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private LensDistortion lensDistortion;

    void Start()
    {
        postProcessVolume.profile.TryGet<LensDistortion>(out lensDistortion);
    }

    public void ChangeLensDistortion(float value)
    {
        Debug.Log("LensDistortion");
        lensDistortion.intensity.value = value;
        lensDistortion.intensity.value = Mathf.Clamp(lensDistortion.intensity.value, -.7f, .7f);
    }
    
}
