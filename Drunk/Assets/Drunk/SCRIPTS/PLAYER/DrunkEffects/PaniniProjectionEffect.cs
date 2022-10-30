using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.HighDefinition;

public class PaniniProjectionEffect : MonoBehaviour
{
    [SerializeField] private Volume postProcessVolume;
    [SerializeField] private PaniniProjection paniniProjection;

    private void Start()
    {
        postProcessVolume.profile.TryGet<PaniniProjection>(out paniniProjection);
    }

    public void ChancePaniniProjection(float value)
    {
        Debug.Log("PaniniProjection");
        paniniProjection.distance.value = value;
        paniniProjection.distance.value = Mathf.Clamp(paniniProjection.distance.value, 0, 1);
    }
}
