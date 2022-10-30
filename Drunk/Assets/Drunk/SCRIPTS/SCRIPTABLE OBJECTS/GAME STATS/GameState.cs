using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "NewGameStat", menuName = "Stats/CreateGamesStat", order = 1)]
public class GameState : ScriptableObject
{
    public UnityEvent OnGameOver;

    public enum GameStateEnum
    {
        Playing,
        GameOver
    }
    [SerializeField] private GameStateEnum currentGameState;

    public GameStateEnum CurrentGameState { get; set; }

    [SerializeField] private bool winner;

    public bool Winner
    {
        get => winner;
        set => winner = value;
    }

    [Range(0, 2)] [SerializeField] private float gameSpeed = 1;

    public float GameSpeed
    {
        set
        {
            gameSpeed = value;
            Time.timeScale = value;
        }
    }

    [SerializeField] private bool gameOver;
    public bool GameOver
    {
        get => gameOver;
        set
        {
            gameOver = value;
            currentGameState = GameStateEnum.GameOver;
            OnGameOver?.Invoke();
        }
    }

    public void ResetData()
    {
        winner = false;
        gameSpeed = 1;
        gameOver = false;
    }



}
