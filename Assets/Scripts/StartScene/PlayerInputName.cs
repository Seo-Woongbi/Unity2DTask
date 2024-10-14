using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInputName : MonoBehaviour
{
    public InputField playerNameInput;
    private string playerName = null;

    private void Awake()
    {
        playerName = playerNameInput.GetComponent<InputField> ().text;
    }

    private void Update()
    {
        if(playerName.Length > 1 && playerName.Length < 11 && Input.GetKeyDown(KeyCode.Return))
        {
            InputName();
        }
    }
    
    public void InputName()
    {
        playerName = playerNameInput.text;
    }
}
