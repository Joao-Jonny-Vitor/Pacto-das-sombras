using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private GameObject optionMenu;

    public void PlayGame(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void OptionGame(){
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(optionMenu, new BaseEventData(eventSystem));
    }

    public void QuitGame(){
        Debug.Log("Fechou");
        Application.Quit();
    }

}
