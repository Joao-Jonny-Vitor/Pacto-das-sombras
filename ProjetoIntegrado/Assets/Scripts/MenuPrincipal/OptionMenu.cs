using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class OptionMenu : MonoBehaviour
{
    [SerializeField] private GameObject mainMenu;

    [SerializeField] private TMP_Dropdown resolutionDropdown;
    [SerializeField] private TMP_Dropdown qualityDropdown;

    private Resolution[] resolutions;
    private QualitySettings[] qualitys;
    private List<Resolution> filteredResolution;


    private float currentRefreshRate;
    private int currentIndexResolution = 0;

    public void Start() {
        SetResolutions();
        SetQuality();
    }

    public void FullScreen(){
        Screen.fullScreen = !Screen.fullScreen;
    }

    public void SetResolutions(){
        resolutions = Screen.resolutions;
        filteredResolution = new List<Resolution>();

        resolutionDropdown.ClearOptions();
        currentRefreshRate = Screen.currentResolution.refreshRate;

        for (int i = 0; i < resolutions.Length; i++){
            if (resolutions[i].refreshRate == currentRefreshRate)
            {
                filteredResolution.Add(resolutions[i]);
            }
        }

        List<string> options = new List<string>();
        for (int i = 0; i < filteredResolution.Count; i++)
        {
            string resolutionOption = filteredResolution[i].width + "x" + filteredResolution[i].height + " " + filteredResolution[i].refreshRate + " Hz";
            options.Add(resolutionOption);
            if (filteredResolution[i].width == Screen.width && filteredResolution[i].height == Screen.height)
            {
                currentIndexResolution = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentIndexResolution;
        resolutionDropdown.RefreshShownValue();
    }

    public void SetResolution(int resolutionIndex){
        Resolution resolution = filteredResolution[resolutionIndex];
        if (Screen.fullScreen)
        {
            Screen.SetResolution(resolution.width, resolution.height, true);
        } else{
            Screen.SetResolution(resolution.width, resolution.height, false);
        }
    }

    public void SetQuality(){
        qualityDropdown.ClearOptions();

        string[] names = QualitySettings.names;
        List<string> options = new List<string>();

        for (int i = 0; i < names.Length; i++)
        {
            options.Add(names[i]);
        }

        qualityDropdown.AddOptions(options);
        qualityDropdown.value = 0;
        qualityDropdown.RefreshShownValue();
    }

    public void SetQualitys(int qualityIndex){
        QualitySettings.SetQualityLevel(qualityIndex, true);
        Debug.Log(QualitySettings.GetQualityLevel());
    }

    public void BackGame(){
        var eventSystem = EventSystem.current;
        eventSystem.SetSelectedGameObject(mainMenu, new BaseEventData(eventSystem));
    }

    
}
