using UnityEngine;

public class PlayerUI : MonoBehaviour {

    [SerializeField]
    RectTransform thrusterFuelFill;


    [SerializeField]
    RectTransform healthBarFill;

    [SerializeField]
    GameObject pauseMenu;

    [SerializeField]
    PauseMenu PM;


    private Player player;
    private PlayerController controller;


    public void SetPlayer(Player _player)
    {
        player = _player;
        controller = player.GetComponent<PlayerController>();
    }

    void Start ()
    {
        PauseMenu.IsOn = false;
    }

    void Update ()
    {

        SetHealthAmount(player.HealthPct);

        SetFuelAmount(controller.GetThrusterFuelAmount());
        
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePauseMenu();
        }
        if (PauseMenu.IsOn)
        {
            if (Input.GetKey("q")) 
            {
                PM.LeaveRoom();
            }
        }
    }

    void TogglePauseMenu ()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
        PauseMenu.IsOn = pauseMenu.activeSelf;
    }
    void SetFuelAmount (float _amount)
    {
        thrusterFuelFill.localScale = new Vector3(1f, _amount, 1f);
    }

    void SetHealthAmount(float _amount)
    {
        healthBarFill.localScale = new Vector3(1f, _amount, 1f);
    }
}
