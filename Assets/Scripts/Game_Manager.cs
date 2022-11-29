using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game_Manager : MonoBehaviour{
    public static Game_Manager instance;
    
    private void Awake() { 
    if (Game_Manager.instance == null) instance = this;
    else Destroy(gameObject);
    }

    public void GameOver() {
        UIManager _ui = GetComponent<UIManager>();
        if (_ui != null) {
            _ui.ToggleDeathPanel();
        }
    }
}
