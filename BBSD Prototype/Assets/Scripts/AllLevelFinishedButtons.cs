using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AllLevelFinishedButtons : MonoBehaviour
{
    public LevelLoader lvlLdr;

    [Header("EasyModeNumbers")]
    public int e_MinBuildIndex;
    public int e_MaxBuildIndex;

    [Header("HardModeNumbers")]
    public int h_MinBuildIndex;
    public int h_MaxBuildIndex;

    void Start()
    {
        lvlLdr = GameObject.FindObjectOfType<LevelLoader>();
    }

    public void MainMenu()
    {
        lvlLdr.LoadNextLevel(0);
    }

    public void ReplayLevel()
    {
        lvlLdr.LoadNextLevel(SceneManager.GetActiveScene().buildIndex);
    }

    public void NextLevelEasy()
    {
        lvlLdr.LoadNextLevel(Random.Range(e_MinBuildIndex, e_MaxBuildIndex));
    }

    public void NextLevelHard()
    {
        lvlLdr.LoadNextLevel(Random.Range(h_MinBuildIndex, h_MaxBuildIndex));
    }
}
