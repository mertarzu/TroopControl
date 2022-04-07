using UnityEngine;

public class GameManager : MonoBehaviour
{  
    [SerializeField] UIController uiController;
    [SerializeField] Player player;
    [SerializeField] SelectionInputController selectionInputController;
    [SerializeField] TargetInputController targetInputController;

    void InitializeUIController()
    {
        uiController.Initialize();
    }

    void InitializePlayer()
    {
        player.Initialize();
    }

    void InitializeSelectionInputController()
    {
        selectionInputController.Initialize();
    }

    void InitializeTargetInputController()
    {
        targetInputController.Initialize();
    }

    public void StartGame()
    {   
        InitializeUIController();
        InitializePlayer();
        InitializeSelectionInputController();
        InitializeTargetInputController();
    }

}
