using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class BloomEffect : MonoBehaviour
{
    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private Bloom _bloom;


    void Start()
    {
        postProcessVolume.profile.TryGet<Bloom>(out _bloom);
    }

    public void ChangeBloom(float value)
    {
        Debug.Log("Bloom");
        _bloom.intensity.value = value;
        _bloom.intensity.value = Mathf.Clamp(_bloom.intensity.value, 0, 1);
    }
    
}
