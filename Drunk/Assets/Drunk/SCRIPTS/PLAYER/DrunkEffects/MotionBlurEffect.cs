using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class MotionBlurEffect : MonoBehaviour
{

    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private MotionBlur motionBlur;

    private void Start()
    {
        postProcessVolume.profile.TryGet<MotionBlur>(out motionBlur);
    }

    public void ChangeMotion(float value)
    {
        Debug.Log("MotionBlur");
        motionBlur.intensity.value = value * 10f;
        motionBlur.intensity.value = Mathf.Clamp(motionBlur.intensity.value, 0, 10); 
    }

    public void Reset()
    {
        motionBlur.intensity.value = 0;
    }

}
