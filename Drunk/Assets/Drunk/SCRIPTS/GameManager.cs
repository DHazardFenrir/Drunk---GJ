using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{
    [SerializeField] private UnityEvent OnGameStart;
    [SerializeField] private GameState gameState;
    // Start is called before the first frame update
    void Start()
    {
        OnGameStart?.Invoke();
    }

    private void OnDisable()
    {
        gameState.ResetData();
    }

}
