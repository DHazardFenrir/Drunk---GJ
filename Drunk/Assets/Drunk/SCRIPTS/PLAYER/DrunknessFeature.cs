
using UnityEngine;
using UnityEngine.Events;

public class DrunknessFeature : MonoBehaviour
{
    const float _maxDrunkness = 1f;
    [SerializeField,Range(0,_maxDrunkness)] private float _drunkness;
    [SerializeField] private UnityEvent<float> MotionBlur;
    [SerializeField] private UnityEvent<float> Bloom;
    [SerializeField] private UnityEvent<float> LensDistortion;
    [SerializeField] private UnityEvent<float> PaniniProjection;

    public float Drunkness
    {
        get => _drunkness;
        set => _drunkness = value;
    }
    
    public void GetDrunk(float drunkValue)
    {
        Drunkness += drunkValue;
        Drunkness = Mathf.Clamp(Drunkness, 0, _maxDrunkness);
        RandomEffect();
    }

    public void GetSober(float soberValue)
    {
        Drunkness -= soberValue;
        Drunkness = Mathf.Clamp(Drunkness, 0, _maxDrunkness);
        UpdateEffects();
    }
    public void UpdateEffects()
    {
        MotionBlur?.Invoke(Drunkness);
        Bloom?.Invoke(Drunkness);
        LensDistortion?.Invoke(Drunkness);
        PaniniProjection?.Invoke(Drunkness);
    }

    public void RandomEffect()
    {
        int random = Random.Range(0, 4);

        switch(random)
        {

            case 0:
                {
                    MotionBlur?.Invoke(Drunkness);
                    break;
                }

            case 1:
                {
                    Bloom?.Invoke(Drunkness);
                    break;
                }
           
            case 2:
                {
                    LensDistortion?.Invoke(Drunkness);
                    break;
                }

            case 3:
                {
                    PaniniProjection?.Invoke(Drunkness);
                    break;
                }

        }
    }

}
