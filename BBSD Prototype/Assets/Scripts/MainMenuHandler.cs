using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuHandler : MonoBehaviour
{
    [Header("Scripts")]
    public LevelLoader ll;

    [Header("EasyModeNumbers")]
    public int e_MinBuildIndex;
    public int e_MaxBuildIndex;

    [Header("HardModeNumbers")]
    public int h_MinBuildIndex;
    public int h_MaxBuildIndex;

    public void EasyMode()
    {
        ll.LoadNextLevel(Random.Range(e_MinBuildIndex, e_MaxBuildIndex));
    }

    public void HardMode()
    {
        ll.LoadNextLevel(Random.Range(h_MinBuildIndex, h_MaxBuildIndex));
    }
    public void Options()
    {
        ll.LoadNextLevel(1);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
