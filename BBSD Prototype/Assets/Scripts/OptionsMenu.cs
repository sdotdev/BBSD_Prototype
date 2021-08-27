using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;

public class OptionsMenu : MonoBehaviour
{
    [Header("Audio")]
    public AudioMixer volumeAudioMix;

    [Header("Resolutions")]
    public Resolution[] resolutions;
    public TMP_Dropdown resDrop;

    public LevelLoader lvlL;

    void Start()
    {
        resolutions = Screen.resolutions;

        resDrop.ClearOptions();

        List<string> options = new List<string>();

        int curResInd = 0;

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                curResInd = i;
            }
        }

        resDrop.AddOptions(options);
        resDrop.value = curResInd;
        resDrop.RefreshShownValue();
    }
   public void SetVolume(float vol)
    {
        volumeAudioMix.SetFloat("Volume", vol);
    }
    public void SeetQuality(int quality)
    {
        QualitySettings.SetQualityLevel(quality);
    }
    public void SetFulscreen(bool isScreen)
    {
        Screen.fullScreen = isScreen;
    }
    public void SetRes(int resInd)
    {
        Resolution res = resolutions[resInd];
        Screen.SetResolution(res.width,res.height,Screen.fullScreen);
    }
    public void Back()
    {
        lvlL.LoadNextLevel(0);
    }
}
