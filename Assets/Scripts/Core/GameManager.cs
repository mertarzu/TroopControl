using UnityEngine;

public class GameManager : MonoBehaviour
{  
    [SerializeField] UIController _uiController;
    [SerializeField] Player _player;
    [SerializeField] SelectionInputController _selectionInputController;
    [SerializeField] TargetInputController _targetInputController;

    private void Awake()
    {
        StartGame();
    }
    public void StartGame()
    {
        InitializeUIController();
        InitializePlayer();
        InitializeSelectionInputController();
        InitializeTargetInputController();
    }

    void InitializeUIController()
    {
        _uiController.Initialize();
    }

    void InitializePlayer()
    {
        _player.Initialize();
    }

    void InitializeSelectionInputController()
    {
        _selectionInputController.Initialize();
    }

    void InitializeTargetInputController()
    {
        _targetInputController.Initialize();
    }

}
